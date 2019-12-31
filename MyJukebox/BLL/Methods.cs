using System.Drawing;
using System.IO;
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

            record = new MP3Record();
            record.Album = arTmp[arTmp.Length - 1];
            record.Interpret = arTmp[arTmp.Length - 2];
            record.Media = arTmp[arTmp.Length - 3];
            record.Owner = arTmp[arTmp.Length - 4];
            record.Genre = arTmp[arTmp.Length - 5];
            record.Katalog = arTmp[arTmp.Length - 4];

            return record;
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
