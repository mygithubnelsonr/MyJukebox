using MyJukebox_EF.DAL;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyJukebox_EF.BLL
{
    public static class Methods
    {
        public static void TextBoxSearchClear(TextBox textBox)
        {
            textBox.Text = Settings.PlaceHolderText;
            textBox.ForeColor = Color.Gray;
        }

        public static bool IsQuery(string filter)
        {
            bool IsQuery = false;

            if (filter == "" || filter == Settings.PlaceHolderText)
                IsQuery = false;
            else
                IsQuery = true;

            return IsQuery;
        }

        public static MP3Record GetRecordInfo(string startDirectory)
        {
            MP3Record record = null;

            // no special import
            string[] arTmp = startDirectory.Split('\\');

            if (arTmp.Length < 5)
                return record;

            List<int> media;
            string type = arTmp[arTmp.Length - 3];
            var context = new MyJukeboxEntities();
            media = context.tMedias
                        .Where(m => m.Type == type)
                        .Select(m => m.ID).ToList();

            record = new MP3Record();
            record.Album = arTmp[arTmp.Length - 1];
            record.Interpret = arTmp[arTmp.Length - 2];
            record.Media = media[0];
            record.Genre = arTmp[arTmp.Length - 5];
            record.Catalog = arTmp[arTmp.Length - 4];

            return record;
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
    }
}

