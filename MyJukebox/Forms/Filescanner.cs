using MyJukebox_EF.BLL;
using MyJukebox_EF.DAL;
using NRSoft.FunctionPool;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

// ToDo: implement productive db import

namespace MyJukebox_EF
{
    public partial class Filescanner : Form
    {

        #region private Fields
        //private bool _dbPanelVisible;
        #endregion

        #region CTOR
        public Filescanner()
        {
            InitializeComponent();

            FillCombos();

            // show or hide panelDb
            //if (panelDB.Tag == null)
            //{
            //    panelDB.Tag = false;
            //    ClientSize = new System.Drawing.Size(426, 272);
            //}
        }
        #endregion

        #region Form_Events
        private void Filescanner_Load(object sender, EventArgs e)
        {
            Settings.FilescannerLoad();

            //Top = Settings.FilescannerTop;
            //Left = Settings.FilescannerLeft;
            //Height = Settings.FilescannerHeight;
            //Width = Settings.FilescannerWidth;

            //cmb_StartOrdner.Items.Add(rh.GetSetting("Settings\\Filescanner", "LastScanPfad", ""));
            //textBoxExtension.Text = rh.GetSetting("Settings\\Filescanner", "LastFileSpec", "");

            //MaximumSize = new System.Drawing.Size(434, 272);
            //ClientSize = new System.Drawing.Size(434, 272 - 34);

        }

        private void Filescanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            //rh.SaveSetting("Settings\\Filescanner", "Width", Size.Width.ToString());
            //rh.SaveSetting("Settings\\Filescanner", "Height", Size.Height.ToString());
            //rh.SaveSetting("Settings\\Filescanner", "Top", Top.ToString());
            //rh.SaveSetting("Settings\\Filescanner", "Left", Left.ToString());
            //rh.SaveSetting("Settings\\Filescanner", "State", WindowState.ToString());
        }
        #endregion

        #region ComboBox_Events
        private void ActionStartfolder()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(textBoxStartpath.Text);

                if (di.Exists)
                {
                    textBoxStartpath.BackColor = Color.LightGreen;
                    buttonStartScann.Enabled = true;
                }
                else
                {
                    textBoxStartpath.BackColor = Color.Salmon;
                    buttonStartScann.Enabled = false;
                }
            }
            catch { }
        }

        private void comboBoxStartOrdner_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewFileList.Items.Clear();
            ActionStartfolder();
        }

        private void comboBoxStartOrdner_TextChanged(object sender, EventArgs e)
        {
            listViewFileList.Items.Clear();
            ActionStartfolder();
        }
        #endregion ComboBox_Events

        #region Button_Events
        private void buttonStartScann_Click(object sender, EventArgs e)
        {
            Scanner();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void buttonCancelImport_Click(object sender, EventArgs e)
        {
            buttonCancelImport.Tag = true;
        }

        private void buttonOrdner_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxStartpath.Text = folderBrowserDialog1.SelectedPath;
        }
        #endregion Button_Events

        #region CheckBox_Events
        private void checkBoxSpecialImport_CheckedChanged(object sender, EventArgs e)
        {
        }
        #endregion CheckBox_Events

        private void labelShowHideDbPanel_Click(object sender, EventArgs e)
        {
            if (this.Height > 294)
                this.Height = 294;
            else
                this.Height = 540;
        }

        #region Methodes
        private void FillCombos()
        {
            List<string> list = null;

            comboBoxGenre.Items.Clear();
            comboBoxKatalog.Items.Clear();
            comboBoxMedium.Items.Clear();

            var context = new MyJukeboxEntities();
            list = context.tGenres
                .Select(g => g.Name).ToList();

            comboBoxGenre.Items.Add("Untitled");
            foreach (var g in list)
                comboBoxGenre.Items.Add(g);

            list = context.tCatalogs
                .Select(c => c.Name).ToList();

            comboBoxKatalog.Items.Add("Untitled");

            foreach (var c in list)
                comboBoxKatalog.Items.Add(c);

            list = context.tMedias
                .Select(m => m.Type).ToList();

            comboBoxMedium.Items.Add("NA");

            foreach (var m in list)
                comboBoxMedium.Items.Add(m);

            comboBoxAlbum.Items.Add("Untitled");

            comboBoxGenre.Text = "Untitled";
            comboBoxKatalog.Text = "Untitled";
            comboBoxAlbum.Text = "Untitled";
            comboBoxMedium.Text = "NA";
        }

        private void Scanner()
        {
            string startDirectory = this.textBoxStartpath.Text;
            string filePattern = this.textBoxExtension.Text;

            if (startDirectory == "")
                return;

            statusStripImport.Refresh();

            List<FileInfo> fileInfos = new List<FileInfo>();
            fileInfos = FileSystemUtils.GetFileinfos(startDirectory, true);

            ListViewItem xItm;
            listViewFileList.Items.Clear();
            listViewFileList.BeginUpdate();
            long allFileSize = 0;

            foreach (FileInfo fi in fileInfos)
            {
                if (fi.Extension == filePattern)
                {
                    xItm = listViewFileList.Items.Add(fi.Name);
                    xItm.SubItems.Add(fi.Length.ToString());
                    allFileSize += fi.Length;
                    xItm.SubItems.Add(fi.LastWriteTime.ToString());
                    xItm.SubItems.Add(fi.DirectoryName);
                }
            }

            for (int n = 0; n < listViewFileList.Columns.Count; ++n)
            {
                listViewFileList.AutoResizeColumn(n, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            int DirCount = Methods.DirectoryCount(startDirectory);

            listViewFileList.EndUpdate();
            toolStripStatusLabelFiles.Text = listViewFileList.Items.Count.ToString();
            toolStripStatusLabelFolders.Text = DirCount.ToString();

            toolStripStatusLabelTotalsize.Text = allFileSize.ToString();

            if (allFileSize > 0)
            {
                this.buttonImport.Enabled = true;
            }

            MP3Record record = new MP3Record();
            record = Methods.GetRecordInfo(startDirectory);

            if (record != null)
            {
                comboBoxGenre.Text = record.Genre;
                comboBoxKatalog.Text = record.Katalog;
                comboBoxAlbum.Text = record.Album;
                comboBoxMedium.SelectedIndex = record.Media;
            }
        }

        private void Import()
        {
            string fileExtension, fileName, filePfad, catalogue;
            string[] arPath;
            int fileSize;
            int importFailed = 0;
            int importSuccess = 0;
            DateTime fileDate;

            List<MP3Record> mp3List = new List<MP3Record>();

            if (listViewFileList.Items.Count == 0)
                return;

            if (checkBoxSpecialImport.Checked)
            {
                if (comboBoxGenre.Text == "" | comboBoxKatalog.Text == "" | comboBoxMedium.Text == "" | comboBoxAlbum.Text == "")
                {
                    MessageBox.Show("If checkbox spezial import is checked then all combos must be filled out");
                    return;
                }
            }

            DateTime t1 = DateTime.Now;
            statusStripLabelStart.Text = t1.Hour.ToString() + ":" + t1.Minute.ToString() + ":" + t1.Second.ToString();
            statusStripabelDauer.Text = "";
            toolStripProgressBar.Visible = true;
            toolStripProgressBar.Enabled = true;

            foreach (ListViewItem item in listViewFileList.Items)
            {
                //Application.DoEvents();
                statusStripImport.Refresh();

                if (Convert.ToBoolean(buttonCancelImport.Tag) == true)
                    break;

                MP3Record mp3 = new MP3Record();

                fileName = item.Text;
                fileSize = Convert.ToInt32(item.SubItems[1].Text);
                fileDate = Convert.ToDateTime(item.SubItems[2].Text);
                filePfad = item.SubItems[3].Text;

                mp3.Path = filePfad;
                mp3.FileName = fileName;
                mp3.FileSize = fileSize;
                mp3.FileDate = fileDate;

                arPath = filePfad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                FileInfo fi = new FileInfo(fileName);
                fileExtension = fi.Extension.ToLower();
                if (checkBoxSpecialImport.Checked)
                {
                    MP3Record record = Methods.GetRecordInfo(filePfad);

                    string[] arTmp = fileName.ToLower().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                    if (arTmp.Length == 0)
                    {
                        mp3.Interpret = "NA";
                        mp3.Titel = ToProperCase(arTmp[0].Trim());
                    }
                    else
                    {
                        mp3.Interpret = ToProperCase(arTmp[0].Trim());
                        mp3.Titel = ToProperCase(arTmp[1].Trim());
                    }

                    mp3.Genre = comboBoxGenre.Text;
                    mp3.Album = comboBoxAlbum.Text;  //arPath[arPath.Length - 1];
                    mp3.Media = comboBoxMedium.SelectedIndex;
                    mp3.Katalog = comboBoxKatalog.Text;
                    catalogue = comboBoxKatalog.Text;
                }
                else
                {
                    MP3Record record = Methods.GetRecordInfo(filePfad);

                    string[] arTmp = filePfad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

                    if (arTmp.Length < 5)
                    {
                        MessageBox.Show("Falsche Anzahl von Folderebenen!");
                        buttonImport.Enabled = true;
                        toolStripProgressBar.Visible = false;
                        break;  // Stop Import
                    }

                    arTmp = fileName.ToLower().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                    if (arTmp.Length == 0)
                    {
                        mp3.Interpret = "NA";
                        string strTitel = ToProperCase(arTmp[0].Trim());
                        mp3.Titel = strTitel.Replace(fileExtension, "");
                    }
                    else
                    {
                        mp3.Interpret = ToProperCase(arTmp[0].Trim());
                        string strTitel = ToProperCase(arTmp[1].Trim());
                        mp3.Titel = strTitel.Replace(fileExtension, "");
                    }

                    List<int> media;
                    string type = arPath[arPath.Length - 3];
                    var context = new MyJukeboxEntities();
                    media = context.tMedias
                                .Where(m => m.Type == type)
                                .Select(m => m.ID).ToList();

                    mp3.Media = media[0];
                    mp3.Album = arPath[arPath.Length - 1];
                    mp3.Interpret = arPath[arPath.Length - 2];
                    mp3.Katalog = arPath[arPath.Length - 4];
                    mp3.Genre = arPath[arPath.Length - 5];
                }

                mp3.MD5 = MD5(mp3.Path + mp3.FileName);
                mp3List.Add(mp3);

                //StopImport:
                //    gbBuisy = False
            }

            toolStripProgressBar.Visible = false;
            toolStripProgressBar.Enabled = false;
            ///    sb.Panels("message").Text = i - 1 & " Records added"
            ///    Me.MousePointer = vbNormal
            ///    cmd_import.BackColor = &HC0FFC0
            ///    cmd_import.Tag = "0"
            ///    cmd_import.Caption = "Start Import"
            ///    cmd_StartScan.Enabled = True
            buttonImport.Enabled = false;

            // save records
            int recordsAffected = DataGetSet.SaveNewRecords(mp3List, checkBoxTest.Checked);
            DateTime t2 = DateTime.Now;
            statusStripabelDauer.Text = (t2 - t1).Milliseconds.ToString() + " ms";


            buttonImport.Enabled = true;

            labelSuccess.Text = $"{recordsAffected}";
            labelFailed.Text = $"{mp3List.Count - recordsAffected}";

            var lastID = DataGetSet.GetLastSongID("tTestImport");
            Debug.Print($"Import success = {importSuccess}, failed={importFailed}, lastId={lastID}");
        }

        public string ToProperCase(string sText)
        {
            //Get the culture property of the thread.
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            //Create TextInfo object.
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(sText);
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
        #endregion Methodes

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //DataGetSet.SaveRecordTest("Sonja");

            var md5 = MD5(@"\\win2k16dc01\FS012\Country\Sonja\CD\Dan + Shay\Dan + Shay\" + "Dan + Shay - All To Myself.mp3");
            Debug.Print(md5);
        }

        private void textBoxStartpath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                listViewFileList.Items.Clear();

                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                DirectoryInfo di;
                di = new DirectoryInfo(filenames[0]);
                string strFolder;

                if ((di.Attributes & FileAttributes.Directory) > 0)
                    strFolder = di.FullName;
                else
                    strFolder = di.Parent.FullName;

                textBoxStartpath.Text = strFolder;
                ActionStartfolder();

                buttonStartScann.PerformClick();
            }
        }

        private void textBoxStartpath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
