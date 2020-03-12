using System;
using System.Collections;
using System.IO;

namespace MyJukebox_EF
{
    class GetFilesH
    {
        private string filter;
        private string path;
        private ArrayList al = new ArrayList();


        public string Filter
        {
            set { filter = value.ToLower(); }
            get { return filter; }
        }

        public string Path
        {
            set { path = value.ToLower(); }
            get { return path; }
        }

        public ArrayList GetFiles()
        {
            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            {
                // Get a reference to each file in that directory.
                FileInfo[] fiArr = di.GetFiles();

                string strTemp = "";
                // Display the names of the files.
                foreach (FileInfo fri in fiArr)
                {
                    if (filter != "")
                    {
                        strTemp = fri.Name;
                        if (strTemp.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            al.Add(fri.FullName);
                        }
                    }
                    else
                    {
                        al.Add(fri.FullName);
                    }
                }
            }

            if (al.Count == 0)
                al = null;

            return al;

        }
    }
}
