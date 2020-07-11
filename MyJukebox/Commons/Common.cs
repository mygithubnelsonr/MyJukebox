using MyJukebox_EF.BLL;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyJukebox_EF.Commons
{
    public static class Common
    {
        public static void TextBoxSearchClear(TextBox textBox)
        {
            textBox.Text = SettingsDb.PlaceHolderText;
            textBox.ForeColor = Color.Gray;
        }

        public static bool IsQuery(string filter)
        {
            bool IsQuery = false;

            if (filter == "" || filter == SettingsDb.PlaceHolderText)
                IsQuery = false;
            else
                IsQuery = true;

            return IsQuery;
        }

        public static string GetQueryString(string queryText)
        {
            return $"select * from vsongs where charindex('{queryText}', lower( concat([pfad],[filename]))) > 0";
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

        //public static string GetQueryStringOld(string queryText)
        //{
        //    List<string> tokens = new List<string>();
        //    string[] arTokens = null;
        //    string sql = "";
        //    bool findExplizit = false;

        //    try
        //    {
        //        arTokens = queryText.Split('=');

        //        if (queryText.IndexOf(@"==") == -1)
        //            findExplizit = false;
        //        else
        //        {
        //            findExplizit = true;
        //            arTokens = arTokens.Where(w => w != arTokens[1]).ToArray();
        //        }

        //        var search = arTokens[0];
        //        var argument = arTokens[1];

        //        if (argument.Substring(0, 1) == "'")
        //            argument = argument.Substring(1);

        //        if (argument.Substring(argument.Length - 1, 1) == "'")
        //            argument = argument.Substring(0, argument.Length - 1);

        //        if (findExplizit == true)
        //            sql = $"select * from vSongs where {search} = '{argument}'";
        //        else
        //            if (search == "*")
        //            sql = $"select * from vsongs where charindex('{argument}', lower( concat([pfad],[filename]))) > 0";
        //        else
        //            sql = $"select * from vSongs where {search} like '%{argument}%'";

        //        return sql;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public static string QueryBuilder()
        //{
        //    string and, query, temp, strGenre, catalog, album, artist;

        //    Hashtable ht = new Hashtable();

        //    strGenre = "";
        //    if (TreeViewLogicStates.Genre != "")
        //    {
        //        ht.Add("genre", TreeViewLogicStates.Genre);
        //        strGenre = $" genre LIKE '{TreeViewLogicStates.Genre}'";
        //    }

        //    catalog = "";
        //    if (TreeViewLogicStates.Catalog != "")
        //    {
        //        ht.Add("catalog", TreeViewLogicStates.Catalog);
        //        catalog = $" catalog LIKE '{TreeViewLogicStates.Catalog}'";
        //    }

        //    if (TreeViewLogicStates.Album != "")
        //    {
        //        ht.Add("album", TreeViewLogicStates.Album);
        //        album = $" album LIKE '{TreeViewLogicStates.Album}'";
        //    }

        //    if (TreeViewLogicStates.Artist != "")
        //    {
        //        ht.Add("artist", TreeViewLogicStates.Artist);
        //        artist = $" artist LIKE '{TreeViewLogicStates.Artist}'";
        //    }

        //    temp = "";
        //    query = "";
        //    and = "";
        //    query = "";

        //    if (ht.Count > 1) and = " AND ";
        //    int htcount = 1;
        //    // Query zusammenbasteln
        //    foreach (DictionaryEntry de in ht)
        //    {
        //        string v = de.Value.ToString();
        //        Console.WriteLine("Key = {0}, Value = {1}", de.Key, v.Replace("'", "''"));
        //        temp = "";
        //        temp += de.Key + " LIKE '" + v.Replace("'", "''") + "'";
        //        query += " (" + temp + ") ";
        //        if (htcount < ht.Count) query += and;
        //        htcount++;
        //    }
        //    return query;
        //}

    }
}

