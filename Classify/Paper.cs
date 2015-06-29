using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Classify
{
    public class Paper
    {
        public string Title { set; get; }
        public string UT { set; get; }

        public List<string> References { set; get; }
        /// <summary>
        /// 多个学科使用;
        /// </summary>
        public string Subject { set; get; }
        public string Subjects { set; get; }
        /// <summary>
        ///参考文献数量
        /// </summary>
        public int NR { set; get; }
        public Paper()
        {
            References = new List<string>();
        }
        public static List<Paper> ReadWos(string filename)
        {
            List<Paper> papers = new List<Paper>();
            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            {
                string line = string.Empty;
                string mark = string.Empty;
                Paper paper = null;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length < 2)
                        continue;
                    string prefix = line.Substring(0, 2);
                    if (prefix.Trim().Length == 0)
                    {
                        prefix = mark;
                    }
                    else
                    {
                        mark = prefix;
                    }
                    switch (prefix)
                    {
                        case "PT":
                            paper = new Paper();
                            break;
                        case "ER":
                            paper.Title = paper.Title.Trim();
                            papers.Add(paper);
                            break;
                        case "TI":
                            paper.Title += " " + line.Substring(2);
                            break;
                        case "CR":
                            paper.References.Add(line.Substring(2).Trim());
                            paper.NR++;
                            break;
                        case "UT":
                            paper.UT = line.Substring(2).Trim();
                            break;
                        default:
                            break;

                    }

                }
                return papers;
            }
        }
    }
}
