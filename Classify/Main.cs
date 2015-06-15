using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Threading.Tasks;
namespace Classify
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public List<Paper> papers = new List<Paper>();
        Dictionary<string, string> subjects = new Dictionary<string, string>();
        private void btnOpenPaper_Click(object sender, EventArgs e)
        {
            openFileDialog_paper.ShowDialog();
            if (openFileDialog_paper.FileNames.Length > 0)
            {
                cbbPapers.Items.Clear();
                papers.Clear();
                foreach (var filename in openFileDialog_paper.FileNames)
                {
                    papers.AddRange(Paper.ReadWos(filename));
                    cbbPapers.Items.Add(filename);
                }
            }
            if (cbbPapers.Items.Count > 0)
                cbbPapers.SelectedIndex = 0;
            lblPaperCount.Text = papers.Count.ToString();
        }

        private void btnOpenJounal_Click(object sender, EventArgs e)
        {
            openFileDialog_journal.ShowDialog();
            if (openFileDialog_journal.FileNames.Length > 0)
            {
                cbbJournal.Items.Clear();
                subjects.Clear();
                foreach (var filename in openFileDialog_journal.FileNames)
                {
                    subjects = CombineDict(subjects, GetSubjects(filename));
                    cbbJournal.Items.Add(filename);
                }
            }
            if (cbbJournal.Items.Count > 0)
            {
                cbbJournal.SelectedIndex = 0;
                lblJournalCount.Text = subjects.Keys.Count.ToString();
            }
        }
        Dictionary<string, string> GetSubjects(string filename)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            {

                CsvReader csv = new CsvReader(reader);
                while (csv.Read())
                {
                    string journal = csv.GetField("Journal").Trim();
                    string subject = csv.GetField("Subject");
                    if (!string.IsNullOrEmpty(journal) && !string.IsNullOrEmpty(subject))
                    {
                        subjects[journal] = subject;
                    }
                }
            }
            return subjects;
        }
        Dictionary<string, string> CombineDict(Dictionary<string, string> d1, Dictionary<string, string> d2)
        {
            foreach (var key in d2.Keys)
            {
                d1[key] = d2[key];
            }
            return d1;
        }
        private void SavePapers(string filename, List<Paper> papers)
        {
            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.Default))
            {
                writer.WriteLine("\"Title\",\"UT\",\"Subject\",\"Subjects\",\"NR\"");
                foreach (var paper in papers)
                {
                    writer.WriteLine("\"{0}\",\"{1}\",\"{2}\",\"{3}\",{4}", paper.Title, paper.UT, paper.Subject, paper.Subjects, paper.NR);
                }
                writer.Close();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Action<int> updateProgress = (value) =>
            {
                progressBar1.Value = value;
            };
            Action<string> updateMessage = (message) =>
            {
                lblMessage.Text = message;
            };
            Action<List<Paper>, List<Paper>, List<Paper>, List<Paper>, List<Paper>> Save = (paper, _papers, __papers, ___papers, ____papers) =>
            {
                folderBrowserDialog.ShowDialog();
                if (folderBrowserDialog.SelectedPath != null)
                {
                    string filename = Path.Combine(folderBrowserDialog.SelectedPath, "单个学科.csv");
                    SavePapers(filename, _papers);

                    filename = Path.Combine(folderBrowserDialog.SelectedPath, "全部.csv");
                    SavePapers(filename, papers);


                    filename = Path.Combine(folderBrowserDialog.SelectedPath, "无学科.csv");
                    SavePapers(filename, __papers);

                    filename = Path.Combine(folderBrowserDialog.SelectedPath, "多个学科(包括multidisciplinary.csv");
                    SavePapers(filename, ___papers);

                    filename = Path.Combine(folderBrowserDialog.SelectedPath, "multidisciplinary.csv");
                    SavePapers(filename, ____papers);
                }
                MessageBox.Show("保存成功");


            };
            Task task = new Task(() =>
            {
                int index = 0;
                foreach (var paper in papers)
                {

                    this.BeginInvoke(updateProgress, index++ * 100 / papers.Count);
                    Dictionary<string, int> subject = new Dictionary<string, int>();
                    if (paper.References.Count == 0)
                    {
                        paper.Subject = "无参考文献";
                        continue;
                    }
                    foreach (var reference in paper.References)
                    {
                        string[] items = reference.Split(',');
                        bool ismatch = false;
                        foreach (string item in items)
                        {
                            string journal = item.Trim();
                            if (subjects.ContainsKey(journal))
                            {
                                string _subject = subjects[journal];
                                if (subject.ContainsKey(_subject))
                                {
                                    subject[_subject] += 1;
                                }
                                else
                                {
                                    subject[_subject] = 1;
                                }
                                ismatch = true;
                                break;
                            }
                        }
                        if (!ismatch)
                        {
                            if (subject.ContainsKey("Null"))
                            {
                                subject["Null"] += 1;
                            }
                            else
                            {
                                subject["Null"] = 1;
                            }
                        }
                    }
                    ;
                    foreach (var key in subject.OrderByDescending(x => x.Value))
                    {
                        paper.Subjects += ";" + key.Key + "[" + key.Value.ToString() + "]";
                    }
                    if (subject.Keys.Count > 0)
                    {
                        paper.Subjects = paper.Subjects.Substring(1);
                    }
                    if (subject.Keys.Count > 0)
                    {
                        var maxvalue = subject.Max(x => x.Value);
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in subject.Keys)
                        {
                            if (subject[item] == maxvalue)
                            {
                                sb.Append(";" + item);
                            }
                        }
                        if (sb.Length > 1)
                        {
                            paper.Subject = sb.ToString().Substring(1);
                        }
                    }
                    if (!paper.Subject.ToLower().Contains("multidisciplinary") && !paper.Subject.ToLower().Contains("null"))
                    {
                        paper.Tag = "分到单学科";
                    }
                    else if (!paper.Subject.ToLower().Contains("multidisciplinary") && paper.Subject.ToLower().Contains("null"))
                    {
                        string[] splits = paper.Subject.Split(';');
                        foreach (var split in splits)
                        {
                            if (split.Trim().ToLower() != "null")
                            {
                                paper._Subject += ";" + split.Trim();
                                paper.Tag = "待人工分";
                            }
                        }
                        paper._Subject = paper._Subject.Substring(1);
                    }
                    else if (paper.Subject.ToLower().Contains("multidisciplinary") && !paper.Subject.ToLower().Contains("null"))
                    {
                        string[] splits = paper.Subject.Split(';');
                        foreach (var split in splits)
                        {
                            if (split.Trim().ToLower() != "multidisciplinary")
                            {
                                paper._Subject += ";" + split.Trim();
                                paper.Tag = "待人工分";
                            }
                        }
                        paper._Subject = paper._Subject.Substring(1);
                    }
                    else
                    {
                        string[] splits = paper.Subject.Split(';');
                        foreach (var split in splits)
                        {
                            if (split.Trim().ToLower() != "multidisciplinary" && split.Trim().ToLower() != "null")
                            {
                                paper._Subject += ";" + split.Trim();
                                paper.Tag = "待人工分";
                            }
                        }
                        paper._Subject = paper._Subject.Substring(1);
                    }
                }
            });
            task.Start();
            task.ContinueWith(t =>
            {
                this.BeginInvoke(updateProgress, 100);
                MessageBox.Show("success");

                //
                List<Paper> _papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && !p.Subject.Contains(";") && !p.Subject.ToLower().Contains("multidisciplinary"));
                List<Paper> __papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && p.Subject.Contains("Null"));
                List<Paper> ___papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && p.Subject.Contains(";"));
                List<Paper> ____papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && p.Subject.ToLower().Contains("multidisciplinary"));
                string message = string.Format("全部:{0} 单学科:{1} 多个学科:{2} multidisciplinary:{3} null:{4}", papers.Count, _papers.Count, ___papers.Count, ____papers.Count, __papers.Count);
                this.BeginInvoke(updateMessage, message);
                this.BeginInvoke(Save, papers, _papers, __papers, ___papers, ____papers);
            });



        }
    }
}
