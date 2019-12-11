using NRSoft.FunctionPool;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MyJukebox_EF
{
    public partial class Filescanner : Form
    {
        #region private Fields
        private bool _dbvisible;
        private RegistryH rh;
        #endregion

        #region CTOR
        public Filescanner()
        {
            InitializeComponent();

            RegistryH rh = new RegistryH();

            //{ 
            //    Properties.Settings.Default.CompanyName,
            //    Properties.Settings.Default.ProductName
            //);

            if (panelDB.Tag == null)
            {
                panelDB.Tag = false;
                ClientSize = new System.Drawing.Size(426, 272);
            }
        }
        #endregion

        #region Form_Events
        private void Filescanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            rh.SaveSetting("Settings\\Filescanner", "Width", Size.Width.ToString());
            rh.SaveSetting("Settings\\Filescanner", "Height", Size.Height.ToString());
            rh.SaveSetting("Settings\\Filescanner", "Top", Top.ToString());
            rh.SaveSetting("Settings\\Filescanner", "Left", Left.ToString());
            rh.SaveSetting("Settings\\Filescanner", "State", WindowState.ToString());
        }

        private void Filescanner_Load(object sender, EventArgs e)
        {
            Top = Convert.ToInt16(rh.GetSetting(@"Settings\Filescanner", "Top", "100"));
            Left = Convert.ToInt16(rh.GetSetting(@"Settings\Filescanner", "Left", "100"));
            Width = Convert.ToInt16(rh.GetSetting("Settings\\Filescanner", "Width", "434"));
            Height = Convert.ToInt16(rh.GetSetting("Settings\\Filescanner", "Height", "272"));

            cmb_StartOrdner.Items.Add(rh.GetSetting("Settings\\Filescanner", "LastScanPfad", ""));
            textBoxExtension.Text = rh.GetSetting("Settings\\Filescanner", "LastFileSpec", "");

            MaximumSize = new System.Drawing.Size(434, 272);
            ClientSize = new System.Drawing.Size(434, 272 - 34);

            comboBoxGenre.Text = "";
            comboBoxKatalog.Text = "";
            comboBoxMedium.Text = "";
            comboBoxQuelle.Text = "";

        }
        #endregion

        #region statusStrip_Events
        private void statusStripLabelSpecial_Click(object sender, EventArgs e)
        {
            if (_dbvisible)
            {
                this.MaximumSize = new System.Drawing.Size(434, 272);
                this.ClientSize = new System.Drawing.Size(434, 272 - 34);
                this.labelDateien1.Visible = true;
                this.labelDateien2.Visible = true;
                this.labelFolders1.Visible = true;
                this.labelFolders2.Visible = true;

                _dbvisible = false;
                this.statusStripLabelSpecial.Text = "S";
            }
            else
            {
                this.labelDateien1.Visible = false;
                this.labelDateien2.Visible = false;
                this.labelFolders1.Visible = false;
                this.labelFolders2.Visible = false;
                this.MaximumSize = new System.Drawing.Size(434, 516);
                this.ClientSize = new System.Drawing.Size(434, 516 - 34);
                _dbvisible = true;
                this.statusStripLabelSpecial.Text = "H";
            }
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
                    rh.SaveSetting("Settings\\Filescanner", "LastScanPfad", di.FullName);
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

        /// <summary>
        /// Alle Bilddateien im Windows-Ordner suchen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartScann_Click(object sender, EventArgs e)
        {
            string startDirectory = this.cmb_StartOrdner.Text;
            string filePattern = this.textBoxExtension.Text;          //"*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff";

            if (startDirectory == "")
                return;

            Application.DoEvents();
            //this.statusStripLabelMessage.Text = "scanning...";
            this.statusStrip.Refresh();
            this.buttonCancelScann.Enabled = true;

            ReadOnlyCollection<FileInfo> fileList = FileSystemUtils.FindFiles(startDirectory, filePattern, true);
            //this.statusStripLabelMessage.Text = "";
            // Die gefundenen Dateien durchgehen und ausgeben

            ListViewItem xItm;
            listViewFileList.Items.Clear();
            listViewFileList.BeginUpdate();
            long allFileSize = 0;

            foreach (FileInfo fi in fileList)
            {
                xItm = listViewFileList.Items.Add(fi.Name);
                xItm.SubItems.Add(fi.Length.ToString());
                allFileSize += fi.Length;
                xItm.SubItems.Add(fi.CreationTime.ToString());
                xItm.SubItems.Add(fi.DirectoryName);
            }

            for (int n = 0; n < listViewFileList.Columns.Count; ++n)
            {
                listViewFileList.AutoResizeColumn(n, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            int DirCount = DirectoryCout(startDirectory);

            listViewFileList.EndUpdate();
            this.labelDateien.Text = this.listViewFileList.Items.Count.ToString();
            this.labelDateien2.Text = this.listViewFileList.Items.Count.ToString();
            this.labelFolders.Text = DirCount.ToString();
            this.labelFolders2.Text = DirCount.ToString();
            this.labelAllFileSize.Text = allFileSize.ToString();

            if (allFileSize > 0)
            {
                this.statusStripLabelSpecial.Enabled = true;
                this.buttonImport.Enabled = true;
            }
        }

        private int DirectoryCout(string StartDirectory)
        {
            int DirCount = 0;
            DirectoryInfo di = new DirectoryInfo(StartDirectory);
            try
            {
                foreach (DirectoryInfo SubDirectory in di.GetDirectories())
                {
                    DirCount++;
                    DirCount += DirectoryCout(SubDirectory.FullName.ToString());
                }
            }
            catch (UnauthorizedAccessException)
            { }

            return DirCount;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.Import();
        }

        private void buttonCancelImport_Click(object sender, EventArgs e)
        {
            buttonCancelImport.Tag = true;
        }

        private void buttonCancelScann_Click(object sender, EventArgs e)
        {
            buttonCancelScann.Tag = true;
            TestMitDH2();
        }

        private void buttonOrdner_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            this.cmb_StartOrdner.Text = folderBrowserDialog1.SelectedPath;

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
                if (comboBoxQuelle.Items.Count == 0)
                {
                    Sql = "select distinct quelle from tMusicDb order by quelle";
                    al = dh.ReadData(Sql);
                    foreach (object[] oar in al)
                    {
                        string s = oar[0].ToString();
                        this.comboBoxQuelle.Items.Add(s);
                    }
                }
            }
        }
        #endregion CheckBox_Events

        #region TextBox_Events
        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            rh.SaveSetting("Settings\\Filescanner", "LastFileSpec", textBoxExtension.Text);
        }
        #endregion TextBox_Events

        #region Methodes
        internal void Import()
        {
            string strExtension, strDateiName, strPfad, strKatalog, strMD5;
            string[] arPath;
            long lngSize;
            //int j, iErrors;
            DateTime datDate;

            //bool bExport;
            //bool bTest;
            // prerequisits
            if (this.listViewFileList.Items.Count == 0)
            {
                return;
            }

            if (this.checkBoxSpecialImport.Checked)
            {
                if (comboBoxGenre.Text == "" | comboBoxKatalog.Text == "" | comboBoxMedium.Text == "" | comboBoxQuelle.Text == "")
                {
                    MessageBox.Show("If checkbox spezial import is checked then all combos must be filled out");
                    return;
                }
            }

            this.buttonImport.Enabled = false;

            DatabaseH dh = new DatabaseH();
            Console.WriteLine(dh.ExecuteNonQuery("delete * from tTestImport"));

            DateTime t1 = DateTime.Now;
            this.statusStripLabelStart.Text = t1.Hour.ToString() + ":" + t1.Minute.ToString() + ":" + t1.Second.ToString();
            this.statusStripabelDauer.Text = "";
            this.toolStripProgressBar.Visible = true;
            this.toolStripProgressBar.Enabled = true;

            foreach (ListViewItem xItm in listViewFileList.Items)
            {
                //Application.DoEvents();
                this.statusStrip.Refresh();

                if (Convert.ToBoolean(buttonCancelImport.Tag) == true)
                    break;

                MP3Record tMp3 = new MP3Record();
                strDateiName = xItm.Text;
                lngSize = Convert.ToInt64(xItm.SubItems[1].Text);
                datDate = Convert.ToDateTime(xItm.SubItems[2].Text);
                strPfad = xItm.SubItems[3].Text;

                tMp3.Path = strPfad;
                tMp3.FileName = strDateiName;
                tMp3.FileSize = lngSize;
                tMp3.FileDate = datDate;

                arPath = strPfad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                FileInfo fi = new FileInfo(strDateiName);
                strExtension = fi.Extension.ToLower();
                if (strExtension == ".mp3")
                {
                    if (checkBoxSpecialImport.Checked)
                    {
                        string[] arTmp = strDateiName.ToLower().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                        if (arTmp.Length == 0)
                        {
                            tMp3.Interpret = "NA";
                            tMp3.Titel = ToProperCase(arTmp[0].Trim());
                        }
                        else
                        {
                            tMp3.Interpret = ToProperCase(arTmp[0].Trim());
                            tMp3.Titel = ToProperCase(arTmp[1].Trim());
                        }

                        tMp3.Genre = this.comboBoxGenre.Text;
                        tMp3.Album = arPath[arPath.Length - 1];
                        tMp3.Media = this.comboBoxMedium.Text;
                        tMp3.Owner = this.comboBoxQuelle.Text;
                        tMp3.Katalog = this.comboBoxKatalog.Text;
                        strKatalog = this.comboBoxKatalog.Text;
                    }
                    else
                    {
                        // no special import
                        string[] arTmp = strPfad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

                        if (arTmp.Length < 5)
                        {
                            MessageBox.Show("Falsche Anzahl von Folderebenen!");
                            this.buttonImport.Enabled = true;
                            this.toolStripProgressBar.Visible = false;
                            break;  // Stop Import
                        }

                        arTmp = strDateiName.ToLower().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                        if (arTmp.Length == 0)
                        {
                            tMp3.Interpret = "NA";
                            string strTitel = ToProperCase(arTmp[0].Trim());
                            tMp3.Titel = strTitel.Replace(strExtension, "");
                        }
                        else
                        {
                            tMp3.Interpret = ToProperCase(arTmp[0].Trim());
                            string strTitel = ToProperCase(arTmp[1].Trim());
                            tMp3.Titel = strTitel.Replace(strExtension, "");
                        }

                        tMp3.Album = arPath[arPath.Length - 1];
                        tMp3.Interpret = arPath[arPath.Length - 2];
                        tMp3.Media = arPath[arPath.Length - 3];
                        tMp3.Owner = arPath[arPath.Length - 4];
                        tMp3.Genre = arPath[arPath.Length - 5];
                        tMp3.Katalog = arPath[arPath.Length - 4];
                    }

                    strMD5 = MD5(tMp3.Album + tMp3.Path + tMp3.FileName);
                    tMp3.MD5 = strMD5;

                    //j = j + 1
                    //sb.Panels("message").Text = "rec " & j
                    //gstrTitel = tMp3.Interpret & " - " & tMp3.Titel

                    // Console.WriteLine(dh.ImportData(tMp3, true));

                    //If gfImport(tMp3, bTest) = False Then
                    //    iErrors = iErrors + 1
                    //    al.FaultType = alError
                    //    al.FaultSource = cstrQuelle
                    //    al.FaultMsg = "Fehler beim importieren von " & tMp3.Path & "\" & tMp3.FILE
                    //    al.AddEntry
                    //End If
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

                //    If iErrors > 0 Then
                //        MsgBox "Es sind (ist) " & iErrors & " Fehler aufgetreten!"
                //    End If
            }
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

    }
}
