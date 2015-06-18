﻿using System;
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
using System.Collections.Specialized;
namespace Classify
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public List<Paper> papers = new List<Paper>();
        //Dictionary<string, string> subjects = new Dictionary<string, string>();
        NameValueCollection subjects = new NameValueCollection();
        private void btnOpenPaper_Click(object sender, EventArgs e)
        {
            openFileDialog_paper.ShowDialog();
            if (openFileDialog_paper.FileNames.Length > 0)
            {
                cbbPapers.Items.Clear();
                papers.Clear();
                foreach (var filename in openFileDialog_paper.FileNames)
                {
                    try
                    {
                        papers.AddRange(Paper.ReadWos(filename));
                        cbbPapers.Items.Add(filename);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error! Please input the correct format file");
                        break;
                    }
                }
            }
            if (cbbPapers.Items.Count > 0)
                cbbPapers.SelectedIndex = 0;
            lblPaperCount.Text = papers.Count.ToString();
        }

        private void btnOpenJounal_Click(object sender, EventArgs e)
        {
            openFileDialog_journal.ShowDialog();
            string filename = openFileDialog_journal.FileName;
            if (!string.IsNullOrEmpty(filename))
            {
                txtClass.Text = filename;
                subjects.Clear();
                try
                {
                    //subjects = Combine(subjects, GetSubjects(filename));
                    subjects = GetSubjects(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Please input the correct format file");
                }
            }

            lblJournalCount.Text = subjects.Keys.Count.ToString();
        }
        NameValueCollection GetSubjects(string filename)
        {
            NameValueCollection subjects = new NameValueCollection();
            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            {

                CsvReader csv = new CsvReader(reader);
                while (csv.Read())
                {
                    string journal = csv.GetField("Journal").Trim();
                    string subject = csv.GetField("Subject");
                    if (!string.IsNullOrEmpty(journal) && !string.IsNullOrEmpty(subject))
                    {
                        subjects.Add(journal, subject);
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
        NameValueCollection Combine(NameValueCollection nvc1, NameValueCollection nvc2)
        {
            foreach (var key in nvc2.AllKeys)
            {
                string[] values = nvc2[key].Split(';');
                foreach (var value in values)
                {
                    nvc1.Add(key, value);
                }
            }
            return nvc1;
        }
        private void SavePapers(string filename, List<Paper> papers)
        {
            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.Default))
            {
                writer.WriteLine("\"Title\",\"UT\",\"Tag\",\"Strict_Subject\",\"Loose_Subject\",\"Subjects\",\"NR\",\"DocumentType\"");
                foreach (var paper in papers)
                {
                    writer.WriteLine("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},\"{7}\"", paper.Title.Replace("\"", "'"), paper.UT, paper.Tag, paper.Subject, paper._Subject, paper.Subjects, paper.NR, paper.DocumentType);
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
            Action<List<Paper>> Save = (paper) =>
            {
                folderBrowserDialog.ShowDialog();
                if (folderBrowserDialog.SelectedPath != null)
                {
                    string filename = Path.Combine(folderBrowserDialog.SelectedPath, "全部.csv");
                    SavePapers(filename, papers);
                }
                MessageBox.Show("保存成功");


            };
            string keyword = txtKey.Text.ToLower();
            Task task = new Task(() =>
            {
                int index = 0;
                foreach (var paper in papers)
                {

                    this.BeginInvoke(updateProgress, index++ * 100 / papers.Count);
                    Dictionary<string, int> subject = new Dictionary<string, int>();
                    if (paper.References.Count == 0)
                    {
                        paper.Tag = "没有参考文献";
                        continue;
                    }
                    Dictionary<string, bool> journals = new Dictionary<string, bool>();
                    foreach (var key in subjects.AllKeys)
                    {
                        journals[key] = true;
                    }
                    foreach (var reference in paper.References)
                    {
                        string[] items = reference.Split(',');
                        bool ismatch = false;
                        foreach (string item in items)
                        {
                            string journal = item.Trim();
                            if (journals.ContainsKey(journal))
                            {
                                string[] subjects_ = subjects.GetValues(journal);
                                foreach (var _subject in subjects_)
                                {

                                    if (subject.ContainsKey(_subject))
                                    {
                                        subject[_subject] += 1;
                                    }
                                    else
                                    {
                                        subject[_subject] = 1;
                                    }
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
                    var maxvalue = subject.Max(x => x.Value);
                    var _maxvalue = 0;
                    foreach (var key in subject.OrderByDescending(x => x.Value))
                    {
                        if ((key.Key.ToLower() == keyword || key.Key.ToLower() == "null") && key.Value == maxvalue)
                        {
                            paper.Subjects = ";" + key.Key + "[" + key.Value.ToString() + "]" + paper.Subjects;
                        }
                        else
                        {
                            paper.Subjects += ";" + key.Key + "[" + key.Value.ToString() + "]";
                        }


                        if (key.Key.ToLower() != keyword && key.Key.ToLower() != "null")
                        {
                            if (string.IsNullOrEmpty(paper._Subject))
                            {
                                paper._Subject = key.Key;
                                _maxvalue = key.Value;
                            }
                            else if (key.Value == maxvalue)
                            {
                                paper._Subject += ";" + key.Key;
                            }
                            else if (key.Value == _maxvalue)
                            {
                                paper._Subject += ";" + key.Key;
                            }
                        }
                    }

                    paper.Subjects = paper.Subjects.StartsWith(";") ? paper.Subjects.Substring(1) : paper.Subjects;

                    if (subject.Keys.Count > 0)
                    {

                        StringBuilder sb = new StringBuilder();
                        foreach (var item in subject.Keys)
                        {
                            if (subject[item] == maxvalue)
                            {
                                if (item.ToLower() == keyword || item.ToLower() == "null")
                                {
                                    sb.Insert(0, ";" + item);
                                }
                                else
                                {
                                    sb.Append(";" + item);
                                }

                            }
                        }
                        paper.Subject = sb.ToString().StartsWith(";") ? sb.ToString().Substring(1) : sb.ToString();
                    }
                    if (!paper.Subject.ToLower().Contains("null") && !paper.Subject.ToLower().Contains(keyword))
                    {
                        paper._Subject = paper.Subject;
                    }
                    if (string.IsNullOrEmpty(paper._Subject))
                    {
                        paper.Tag = "没有参考文献";
                    }
                    else if (paper._Subject.Contains(";"))
                    {
                        paper.Tag = "待人工分";
                    }
                    else
                    {
                        paper.Tag = "分到单学科";
                    }
                }
            });
            task.Start();
            task.ContinueWith(t =>
            {
                this.BeginInvoke(updateProgress, 100);
                MessageBox.Show("success");

                //
                //List<Paper> _papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && !p.Subject.Contains(";") && !p.Subject.ToLower().Contains("multidisciplinary"));
                //List<Paper> __papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && p.Subject.Contains("Null"));
                //List<Paper> ___papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && p.Subject.Contains(";"));
                //List<Paper> ____papers = papers.FindAll(p => !string.IsNullOrEmpty(p.Subject) && p.Subject.ToLower().Contains("multidisciplinary"));
                //string message = string.Format("全部:{0} 单学科:{1} 多个学科:{2} multidisciplinary:{3} null:{4}", papers.Count, _papers.Count, ___papers.Count, ____papers.Count, __papers.Count);
                //this.BeginInvoke(updateMessage, message);
                this.BeginInvoke(Save, papers);
            });



        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
