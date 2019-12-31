using MyJukebox_EF.BLL;
using NRSoft.FunctionPool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MyJukebox_EF
{
    // ToDo: check md5 before import
    // ToDo: what is _dbvisible ??

    public partial class Filescanner : Form
    {
        #region private Fields
        private bool _dbPanelVisible;
        #endregion

        #region CTOR
        public Filescanner()
        {
            InitializeComponent();

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

            comboBoxGenre.Text = "";
            comboBoxKatalog.Text = "";
            comboBoxMedium.Text = "";
            comboBoxAlbum.Text = "";

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

        #region statusStrip_Events
        private void statusStripLabelSpecial_Click(object sender, EventArgs e)
        {
            //if (_dbPanelVisible)
            //{
            //    MaximumSize = new System.Drawing.Size(434, 272);
            //    ClientSize = new System.Drawing.Size(434, 272 - 34);
            //    //labelDateien1.Visible = true;
            //    //this.labelDateien2.Visible = true;
            //    //this.labelFolders1.Visible = true;
            //    //this.labelFolders2.Visible = true;

            //    _dbPanelVisible = false;
            //    this.statusStripLabelSpecial.Text = "S";
            //}
            //else
            //{
            //    //this.labelDateien1.Visible = false;
            //    //this.labelDateien2.Visible = false;
            //    //this.labelFolders1.Visible = false;
            //    //this.labelFolders2.Visible = false;
            //    this.MaximumSize = new System.Drawing.Size(434, 516);
            //    this.ClientSize = new System.Drawing.Size(434, 516 - 34);
            //    _dbPanelVisible = true;
            //    this.statusStripLabelSpecial.Text = "H";
            //}
        }
        #endregion

        #region ComboBox_Events
        internal void cmb_StartOrdner_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(cmb_StartOrdner.Text);

                if (di.Exists)
                {
                    cmb_StartOrdner.BackColor = Color.LightGreen;
                    //rh.SaveSetting("Settings\\Filescanner", "LastScanPfad", di.FullName);
                    this.buttonStartScann.Enabled = true;
                }
                else
                {
                    cmb_StartOrdner.BackColor = Color.Salmon;
                    this.buttonStartScann.Enabled = false;
                }
            }
            catch { }
            finally { }
        }

        private void cmb_StartOrdner_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyEventArgs k = new KeyEventArgs(Keys.KeyCode);
            cmb_StartOrdner_KeyUp(sender, k);
        }

        private void cmb_StartOrdner_TextChanged(object sender, EventArgs e)
        {
            KeyEventArgs k = new KeyEventArgs(Keys.KeyCode);
            cmb_StartOrdner_KeyUp(sender, k);
        }
        #endregion ComboBox_Events

        #region Button_Events
        private void buttonStartScann_Click(object sender, EventArgs e)
        {
            Scanner();
        }

        //private int DirectoryCout(string StartDirectory)
        //{
        //    int dirCount = 0;

        //    if (Directory.Exists(StartDirectory))
        //    {
        //        dirCount = 1;
        //        DirectoryInfo di = new DirectoryInfo(StartDirectory);
        //        try
        //        {
        //            foreach (DirectoryInfo SubDirectory in di.GetDirectories())
        //            {
        //                dirCount++;
        //                dirCount += DirectoryCout(SubDirectory.FullName.ToString());
        //            }
        //        }
        //        catch
        //        { }
        //    }

        //    return dirCount;
        //}

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

            cmb_StartOrdner.Text = folderBrowserDialog1.SelectedPath;

        }
        #endregion Button_Events

        #region CheckBox_Events
        private void checkBoxSpecialImport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecialImport.Checked == true)
            {
                Application.DoEvents();
                DatabaseH dh = new DatabaseH();
                string Sql;
                ArrayList al;

                // fill combo genre
                if (comboBoxGenre.Items.Count == 0)
                {
                    Sql = "select distinct genre from tMusicDb order by genre";
                    al = dh.ReadData(Sql);
                    foreach (object[] oar in al)
                    {
                        string s = oar[0].ToString();
                        this.comboBoxGenre.Items.Add(s);
                    }
                }
                // fill combo katalog
                if (comboBoxKatalog.Items.Count == 0)
                {
                    Sql = "select distinct katalog from tMusicDb order by katalog";
                    al = dh.ReadData(Sql);
                    foreach (object[] oar in al)
                    {
                        string s = oar[0].ToString();
                        this.comboBoxKatalog.Items.Add(s);
                    }
                }
                // fill combo medium
                if (comboBoxMedium.Items.Count == 0)
                {
                    Sql = "select distinct medium from tMusicDb order by medium";
                    al = dh.ReadData(Sql);
                    foreach (object[] oar in al)
                    {
                        string s = oar[0].ToString();
                        this.comboBoxMedium.Items.Add(s);
                    }
                }
                // fill combo quelle
                if (comboBoxAlbum.Items.Count == 0)
                {
                    Sql = "select distinct quelle from tMusicDb order by quelle";
                    al = dh.ReadData(Sql);
                    foreach (object[] oar in al)
                    {
                        string s = oar[0].ToString();
                        this.comboBoxAlbum.Items.Add(s);
                    }
                }
            }
        }
        #endregion CheckBox_Events

        #region TextBox_Events
        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            // rh.SaveSetting("Settings\\Filescanner", "LastFileSpec", textBoxExtension.Text);
        }
        #endregion TextBox_Events

        #region Methodes
        private void Scanner()
        {
            string startDirectory = this.cmb_StartOrdner.Text;
            string filePattern = this.textBoxExtension.Text;

            if (startDirectory == "")
                return;

            //Application.DoEvents();
            //this.statusStripLabelMessage.Text = "scanning...";
            statusStripImport.Refresh();

            List<FileInfo> fileInfos = new List<FileInfo>();
            fileInfos = FileSystemUtils.GetFileinfos(startDirectory, true);

            // this.statusStripLabelMessage.Text = "";
            // Die gefundenen Dateien durchgehen und ausgeben

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
                    xItm.SubItems.Add(fi.CreationTime.ToString());
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
                this.statusStripLabelSpecial.Enabled = true;
                this.buttonImport.Enabled = true;
            }

            MP3Record record = new MP3Record();
            record = Methods.GetRecordInfo(startDirectory);

            comboBoxGenre.Text = record.Genre;
            comboBoxKatalog.Text = record.Katalog;
            comboBoxAlbum.Text = record.Album;
            comboBoxMedium.Text = record.Media;

        }

        private void Import()
        {
            string strExtension, fileName, strPfad, strKatalog;
            string[] arPath;
            int fileSize;
            int importFailed = 0;
            int importSuccess = 0;
            DateTime fileDate;

            MP3Record record;

            if (this.listViewFileList.Items.Count == 0)
                return;

            if (this.checkBoxSpecialImport.Checked)
            {
                if (comboBoxGenre.Text == "" | comboBoxKatalog.Text == "" | comboBoxMedium.Text == "" | comboBoxAlbum.Text == "")
                {
                    MessageBox.Show("If checkbox spezial import is checked then all combos must be filled out");
                    return;
                }
            }

            record = new MP3Record();

            buttonImport.Enabled = false;

            // delete table testimport first
            //DatabaseH dh = new DatabaseH();
            //Console.WriteLine(dh.ExecuteNonQuery("delete * from tTestImport"));

            DateTime t1 = DateTime.Now;
            statusStripLabelStart.Text = t1.Hour.ToString() + ":" + t1.Minute.ToString() + ":" + t1.Second.ToString();
            statusStripabelDauer.Text = "";
            toolStripProgressBar.Visible = true;
            toolStripProgressBar.Enabled = true;

            var result = DataGetSet.TruncateTableImportTest();
            Debug.Print($"TruncateTableImportTest result = {result}");

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
                strPfad = item.SubItems[3].Text;

                mp3.Path = strPfad;
                mp3.FileName = fileName;
                mp3.FileSize = fileSize;
                mp3.FileDate = fileDate;

                arPath = strPfad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                FileInfo fi = new FileInfo(fileName);
                strExtension = fi.Extension.ToLower();
                if (strExtension == ".mp3")
                {
                    if (checkBoxSpecialImport.Checked)
                    {
                        record = Methods.GetRecordInfo(strPfad);

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
                        mp3.Album = arPath[arPath.Length - 1];
                        mp3.Media = comboBoxMedium.Text;
                        mp3.Owner = comboBoxAlbum.Text;
                        mp3.Katalog = comboBoxKatalog.Text;
                        strKatalog = comboBoxKatalog.Text;
                    }
                    else
                    {
                        record = Methods.GetRecordInfo(strPfad);

                        // no special import
                        string[] arTmp = strPfad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

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
                            mp3.Titel = strTitel.Replace(strExtension, "");
                        }
                        else
                        {
                            mp3.Interpret = ToProperCase(arTmp[0].Trim());
                            string strTitel = ToProperCase(arTmp[1].Trim());
                            mp3.Titel = strTitel.Replace(strExtension, "");
                        }

                        mp3.Album = arPath[arPath.Length - 1];
                        mp3.Interpret = arPath[arPath.Length - 2];
                        mp3.Media = arPath[arPath.Length - 3];
                        mp3.Owner = arPath[arPath.Length - 4];
                        mp3.Genre = arPath[arPath.Length - 5];
                        mp3.Katalog = arPath[arPath.Length - 4];
                    }

                    mp3.MD5 = MD5(mp3.Album + mp3.Path + mp3.FileName);

                    if (DataGetSet.SaveNewRecord(mp3, checkBoxTest.Checked) == false)
                    {
                        importFailed++;
                    }
                    else
                    {
                        importSuccess++;
                    }
                }

                //StopImport:
                //    gbBuisy = False

                DateTime t2 = DateTime.Now;

                this.statusStripabelDauer.Text = (t2 - t1).Seconds.ToString();
                this.toolStripProgressBar.Visible = false;
                this.toolStripProgressBar.Enabled = false;

                //    sb.Panels("message").Text = i - 1 & " Records added"
                //    Me.MousePointer = vbNormal
                //    cmd_import.BackColor = &HC0FFC0
                //    cmd_import.Tag = "0"
                //    cmd_import.Caption = "Start Import"
                //    cmd_StartScan.Enabled = True

                this.buttonImport.Enabled = true;

            }

            labelSuccess.Text = $"{importSuccess}";
            labelFailed.Text = $"{importFailed}";

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

        public void TestMitDH1()
        {
            //string cmdText = "DELETE * FROM tTestImport";
            string cmdText = "update tTestImport set Gespielt=2 where id=15";
            DatabaseH dh = new DatabaseH();

            Console.WriteLine(dh.ExecuteNonQuery(cmdText));

        }

        public void TestMitDH2()
        {
            MP3Record tMp3 = new MP3Record();
            tMp3.Katalog = "Xaver";
            tMp3.Interpret = "Huber";
            tMp3.Titel = "Bulla Bulla";
            tMp3.Genre = "Andere";
            tMp3.MD5 = "234gf6587dfg345sdf25";
            Console.WriteLine(tMp3.MD5);
            DatabaseH dh = new DatabaseH();
            //  dh.ImportData(tMp3, true);
        }

        #endregion Methodes

        #region
        #endregion

        private void labelShowHideDbPanel_Click(object sender, EventArgs e)
        {
            if (this.Height > 294)
                this.Height = 294;
            else
                this.Height = 540;
        }
    }
}
