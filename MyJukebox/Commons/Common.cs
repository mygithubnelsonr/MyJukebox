using MyJukebox_EF.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyJukebox_EF
{
    public static class Common
    {
        public static void TextBoxSearchClear(TextBox textBox)
        {
            textBox.Text = SettingsDb.GetSetting("PlaceHolderText").ToString();
            textBox.ForeColor = Color.Gray;
        }

        public static bool IsQuery(string filter)
        {
            bool IsQuery = false;

            if (filter == "" || filter == SettingsDb.GetSetting("PlaceHolderText").ToString())
                IsQuery = false;
            else
                IsQuery = true;

            return IsQuery;
        }

        public static string GetQueryString(string queryText)
        {
            List<string> tokens = new List<string>();
            string[] arTokens = null;
            string sql = "";
            bool findExplizit = false;

            try
            {
                arTokens = queryText.Split('=');

                if (queryText.IndexOf(@"==") == -1)
                    findExplizit = false;
                else
                {
                    findExplizit = true;
                    arTokens = arTokens.Where(w => w != arTokens[1]).ToArray();
                }

                var search = arTokens[0];
                var argument = arTokens[1];

                if (argument.Substring(0, 1) == "'")
                    argument = argument.Substring(1);

                if (argument.Substring(argument.Length - 1, 1) == "'")
                    argument = argument.Substring(0, argument.Length - 1);

                if (findExplizit == true)
                    sql = $"select * from vSongs where {search} = '{argument}'";
                else
                    sql = $"select * from vSongs where {search} like '%{argument}%'";

                return sql;
            }
            catch
            {
                return null;
            }
        }

        public static string MD5(string password)
        {
            byte[] textBytes = System.Text.Encoding.Default.GetBytes(password);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    ret += a.ToString("x2");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }

        public static int DirectoryCount(string startfolder)
        {
            int dirCount = 0;

            if (Directory.Exists(startfolder))
            {
                dirCount = 1;
                DirectoryInfo di = new DirectoryInfo(startfolder);
                try
                {
                    foreach (DirectoryInfo SubDirectory in di.GetDirectories())
                    {
                        dirCount++;
                        dirCount += DirectoryCount(SubDirectory.FullName.ToString());
                    }
                }
                catch
                { }
            }

            return dirCount;
        }

        public static string CamelSpaceOut(string str)
        {
            for (int i = 1; i < str.Length; i++)
                if (Char.IsUpper(str[i]))
                    str = str.Insert(i++, " ");
            return str;
        }

    }
}

