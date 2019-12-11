namespace MyJukebox_EF
{
    partial class Filescanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFolders2 = new System.Windows.Forms.Label();
            this.labelFolders1 = new System.Windows.Forms.Label();
            this.labelDateien1 = new System.Windows.Forms.Label();
            this.labelDateien2 = new System.Windows.Forms.Label();
            this.listViewFileList = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSize = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.buttonCancelScann = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.buttonOrdner = new System.Windows.Forms.Button();
            this.buttonStartScann = new System.Windows.Forms.Button();
            this.cmb_StartOrdner = new System.Windows.Forms.ComboBox();
            this.panelDB = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxMedium = new System.Windows.Forms.ComboBox();
            this.comboBoxQuelle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxKatalog = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAllFileSize = new System.Windows.Forms.Label();
            this.labelFolders = new System.Windows.Forms.Label();
            this.labelDateien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelImport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.checkBoxSpecialImport = new System.Windows.Forms.CheckBox();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.checkBoxSampler = new System.Windows.Forms.CheckBox();
            this.checkBoxLöschen = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabelStart = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripabelDauer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabelSpecial = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panelDB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.labelFolders2);
            this.panel1.Controls.Add(this.labelFolders1);
            this.panel1.Controls.Add(this.labelDateien1);
            this.panel1.Controls.Add(this.labelDateien2);
            this.panel1.Controls.Add(this.listViewFileList);
            this.panel1.Controls.Add(this.buttonCancelScann);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxExtension);
            this.panel1.Controls.Add(this.buttonOrdner);
            this.panel1.Controls.Add(this.buttonStartScann);
            this.panel1.Controls.Add(this.cmb_StartOrdner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 219);
            this.panel1.TabIndex = 8;
            // 
            // labelFolders2
            // 
            this.labelFolders2.AutoSize = true;
            this.labelFolders2.Location = new System.Drawing.Point(378, 191);
            this.labelFolders2.Name = "labelFolders2";
            this.labelFolders2.Size = new System.Drawing.Size(19, 13);
            this.labelFolders2.TabIndex = 22;
            this.labelFolders2.Text = "----";
            // 
            // labelFolders1
            // 
            this.labelFolders1.AutoSize = true;
            this.labelFolders1.Location = new System.Drawing.Point(335, 191);
            this.labelFolders1.Name = "labelFolders1";
            this.labelFolders1.Size = new System.Drawing.Size(47, 13);
            this.labelFolders1.TabIndex = 21;
            this.labelFolders1.Text = "Folders: ";
            // 
            // labelDateien1
            // 
            this.labelDateien1.AutoSize = true;
            this.labelDateien1.Location = new System.Drawing.Point(239, 191);
            this.labelDateien1.Name = "labelDateien1";
            this.labelDateien1.Size = new System.Drawing.Size(50, 13);
            this.labelDateien1.TabIndex = 18;
            this.labelDateien1.Text = "Dateien: ";
            // 
            // labelDateien2
            // 
            this.labelDateien2.AutoSize = true;
            this.labelDateien2.Location = new System.Drawing.Point(285, 191);
            this.labelDateien2.Name = "labelDateien2";
            this.labelDateien2.Size = new System.Drawing.Size(19, 13);
            this.labelDateien2.TabIndex = 17;
            this.labelDateien2.Text = "----";
            // 
            // listViewFileList
            // 
            this.listViewFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderSize,
            this.columnHeaderDate,
            this.columnHeaderPath});
            this.listViewFileList.FullRowSelect = true;
            this.listViewFileList.GridLines = true;
            this.listViewFileList.Location = new System.Drawing.Point(12, 52);
            this.listViewFileList.Name = "listViewFileList";
            this.listViewFileList.Size = new System.Drawing.Size(401, 111);
            this.listViewFileList.TabIndex = 16;
            this.listViewFileList.UseCompatibleStateImageBehavior = false;
            this.listViewFileList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "Filename";
            this.columnHeaderFileName.Width = 128;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 107;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 118;
            // 
            // buttonCancelScann
            // 
            this.buttonCancelScann.Enabled = false;
            this.buttonCancelScann.Location = new System.Drawing.Point(113, 181);
            this.buttonCancelScann.Name = "buttonCancelScann";
            this.buttonCancelScann.Size = new System.Drawing.Size(87, 23);
            this.buttonCancelScann.TabIndex = 15;
            this.buttonCancelScann.Tag = "false";
            this.buttonCancelScann.Text = "Cancel";
            this.buttonCancelScann.UseVisualStyleBackColor = true;
            this.buttonCancelScann.Click += new System.EventHandler(this.buttonCancelScann_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Extension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Startpfad";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(367, 25);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(47, 20);
            this.textBoxExtension.TabIndex = 12;
            this.textBoxExtension.Text = ".mp3";
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // buttonOrdner
            // 
            this.buttonOrdner.Location = new System.Drawing.Point(316, 26);
            this.buttonOrdner.Name = "buttonOrdner";
            this.buttonOrdner.Size = new System.Drawing.Size(34, 16);
            this.buttonOrdner.TabIndex = 10;
            this.buttonOrdner.Text = "----";
            this.buttonOrdner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOrdner.UseVisualStyleBackColor = true;
            this.buttonOrdner.Click += new System.EventHandler(this.buttonOrdner_Click);
            // 
            // buttonStartScann
            // 
            this.buttonStartScann.Enabled = false;
            this.buttonStartScann.Location = new System.Drawing.Point(12, 181);
            this.buttonStartScann.Name = "buttonStartScann";
            this.buttonStartScann.Size = new System.Drawing.Size(87, 23);
            this.buttonStartScann.TabIndex = 9;
            this.buttonStartScann.Text = "Start";
            this.buttonStartScann.UseVisualStyleBackColor = true;
            this.buttonStartScann.Click += new System.EventHandler(this.buttonStartScann_Click);
            // 
            // cmb_StartOrdner
            // 
            this.cmb_StartOrdner.BackColor = System.Drawing.Color.Salmon;
            this.cmb_StartOrdner.FormattingEnabled = true;
            this.cmb_StartOrdner.Location = new System.Drawing.Point(12, 25);
            this.cmb_StartOrdner.Name = "cmb_StartOrdner";
            this.cmb_StartOrdner.Size = new System.Drawing.Size(287, 21);
            this.cmb_StartOrdner.TabIndex = 8;
            this.cmb_StartOrdner.SelectedIndexChanged += new System.EventHandler(this.cmb_StartOrdner_SelectedIndexChanged);
            this.cmb_StartOrdner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_StartOrdner_KeyUp);
            this.cmb_StartOrdner.TextChanged += new System.EventHandler(this.cmb_StartOrdner_TextChanged);
            // 
            // panelDB
            // 
            this.panelDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDB.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelDB.Controls.Add(this.groupBox3);
            this.panelDB.Controls.Add(this.groupBox2);
            this.panelDB.Controls.Add(this.groupBox1);
            this.panelDB.Location = new System.Drawing.Point(0, 228);
            this.panelDB.Name = "panelDB";
            this.panelDB.Size = new System.Drawing.Size(430, 250);
            this.panelDB.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxMedium);
            this.groupBox3.Controls.Add(this.comboBoxQuelle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxKatalog);
            this.groupBox3.Controls.Add(this.comboBoxGenre);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(17, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Special Import";
            // 
            // comboBoxMedium
            // 
            this.comboBoxMedium.FormattingEnabled = true;
            this.comboBoxMedium.Location = new System.Drawing.Point(222, 86);
            this.comboBoxMedium.Name = "comboBoxMedium";
            this.comboBoxMedium.Size = new System.Drawing.Size(160, 21);
            this.comboBoxMedium.TabIndex = 8;
            this.comboBoxMedium.Text = "Medium";
            // 
            // comboBoxQuelle
            // 
            this.comboBoxQuelle.FormattingEnabled = true;
            this.comboBoxQuelle.Location = new System.Drawing.Point(10, 86);
            this.comboBoxQuelle.Name = "comboBoxQuelle";
            this.comboBoxQuelle.Size = new System.Drawing.Size(166, 21);
            this.comboBoxQuelle.TabIndex = 7;
            this.comboBoxQuelle.Text = "Quelle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Medium";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Quelle";
            // 
            // comboBoxKatalog
            // 
            this.comboBoxKatalog.FormattingEnabled = true;
            this.comboBoxKatalog.Location = new System.Drawing.Point(222, 32);
            this.comboBoxKatalog.Name = "comboBoxKatalog";
            this.comboBoxKatalog.Size = new System.Drawing.Size(160, 21);
            this.comboBoxKatalog.TabIndex = 4;
            this.comboBoxKatalog.Text = "Katalog";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(10, 32);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(166, 21);
            this.comboBoxGenre.TabIndex = 3;
            this.comboBoxGenre.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Katalog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Genre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelAllFileSize);
            this.groupBox2.Controls.Add(this.labelFolders);
            this.groupBox2.Controls.Add(this.labelDateien);
            this.groupBox2.Location = new System.Drawing.Point(220, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Size: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Folders: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Count: ";
            // 
            // labelAllFileSize
            // 
            this.labelAllFileSize.AutoSize = true;
            this.labelAllFileSize.Location = new System.Drawing.Point(66, 67);
            this.labelAllFileSize.Name = "labelAllFileSize";
            this.labelAllFileSize.Size = new System.Drawing.Size(19, 13);
            this.labelAllFileSize.TabIndex = 2;
            this.labelAllFileSize.Text = "----";
            this.labelAllFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFolders
            // 
            this.labelFolders.AutoSize = true;
            this.labelFolders.Location = new System.Drawing.Point(66, 42);
            this.labelFolders.Name = "labelFolders";
            this.labelFolders.Size = new System.Drawing.Size(19, 13);
            this.labelFolders.TabIndex = 1;
            this.labelFolders.Text = "----";
            this.labelFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateien
            // 
            this.labelDateien.AutoSize = true;
            this.labelDateien.Location = new System.Drawing.Point(66, 21);
            this.labelDateien.Name = "labelDateien";
            this.labelDateien.Size = new System.Drawing.Size(19, 13);
            this.labelDateien.TabIndex = 0;
            this.labelDateien.Text = "----";
            this.labelDateien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelImport);
            this.groupBox1.Controls.Add(this.buttonImport);
            this.groupBox1.Controls.Add(this.checkBoxSpecialImport);
            this.groupBox1.Controls.Add(this.checkBoxTest);
            this.groupBox1.Controls.Add(this.checkBoxSampler);
            this.groupBox1.Controls.Add(this.checkBoxLöschen);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datenbank";
            // 
            // buttonCancelImport
            // 
            this.buttonCancelImport.Enabled = false;
            this.buttonCancelImport.Location = new System.Drawing.Point(101, 71);
            this.buttonCancelImport.Name = "buttonCancelImport";
            this.buttonCancelImport.Size = new System.Drawing.Size(69, 23);
            this.buttonCancelImport.TabIndex = 5;
            this.buttonCancelImport.Tag = "false";
            this.buttonCancelImport.Text = "Cancel";
            this.buttonCancelImport.UseVisualStyleBackColor = true;
            this.buttonCancelImport.Click += new System.EventHandler(this.buttonCancelImport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(15, 71);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(69, 23);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // checkBoxSpecialImport
            // 
            this.checkBoxSpecialImport.AutoSize = true;
            this.checkBoxSpecialImport.Location = new System.Drawing.Point(75, 40);
            this.checkBoxSpecialImport.Name = "checkBoxSpecialImport";
            this.checkBoxSpecialImport.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSpecialImport.TabIndex = 3;
            this.checkBoxSpecialImport.Text = "Special Import";
            this.checkBoxSpecialImport.UseVisualStyleBackColor = true;
            this.checkBoxSpecialImport.CheckedChanged += new System.EventHandler(this.checkBoxSpecialImport_CheckedChanged);
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Checked = true;
            this.checkBoxTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTest.Location = new System.Drawing.Point(15, 43);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(47, 17);
            this.checkBoxTest.TabIndex = 2;
            this.checkBoxTest.Text = "Test";
            this.checkBoxTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxSampler
            // 
            this.checkBoxSampler.AutoSize = true;
            this.checkBoxSampler.Location = new System.Drawing.Point(101, 21);
            this.checkBoxSampler.Name = "checkBoxSampler";
            this.checkBoxSampler.Size = new System.Drawing.Size(64, 17);
            this.checkBoxSampler.TabIndex = 1;
            this.checkBoxSampler.Text = "Sampler";
            this.checkBoxSampler.UseVisualStyleBackColor = true;
            // 
            // checkBoxLöschen
            // 
            this.checkBoxLöschen.AutoSize = true;
            this.checkBoxLöschen.Location = new System.Drawing.Point(15, 20);
            this.checkBoxLöschen.Name = "checkBoxLöschen";
            this.checkBoxLöschen.Size = new System.Drawing.Size(67, 17);
            this.checkBoxLöschen.TabIndex = 0;
            this.checkBoxLöschen.Text = "Löschen";
            this.checkBoxLöschen.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1,
            this.statusStripLabelStart,
            this.statusStripLabel2,
            this.statusStripabelDauer,
            this.toolStripProgressBar,
            this.statusStripLabel3,
            this.statusStripLabelSpecial});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(426, 22);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(31, 17);
            this.statusStripLabel1.Text = "Start";
            // 
            // statusStripLabelStart
            // 
            this.statusStripLabelStart.AutoSize = false;
            this.statusStripLabelStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabelStart.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabelStart.Name = "statusStripLabelStart";
            this.statusStripLabelStart.Size = new System.Drawing.Size(50, 17);
            this.statusStripLabelStart.Text = " ";
            // 
            // statusStripLabel2
            // 
            this.statusStripLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabel2.Name = "statusStripLabel2";
            this.statusStripLabel2.Size = new System.Drawing.Size(40, 17);
            this.statusStripLabel2.Text = "Dauer";
            // 
            // statusStripabelDauer
            // 
            this.statusStripabelDauer.AutoSize = false;
            this.statusStripabelDauer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripabelDauer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripabelDauer.Name = "statusStripabelDauer";
            this.statusStripabelDauer.Size = new System.Drawing.Size(50, 17);
            this.statusStripabelDauer.Text = " ";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Enabled = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(160, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // statusStripLabel3
            // 
            this.statusStripLabel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabel3.Name = "statusStripLabel3";
            this.statusStripLabel3.Size = new System.Drawing.Size(223, 17);
            this.statusStripLabel3.Spring = true;
            // 
            // statusStripLabelSpecial
            // 
            this.statusStripLabelSpecial.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.statusStripLabelSpecial.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.statusStripLabelSpecial.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.statusStripLabelSpecial.Enabled = false;
            this.statusStripLabelSpecial.Name = "statusStripLabelSpecial";
            this.statusStripLabelSpecial.Size = new System.Drawing.Size(17, 17);
            this.statusStripLabelSpecial.Text = "S";
            this.statusStripLabelSpecial.Click += new System.EventHandler(this.statusStripLabelSpecial_Click);
            // 
            // Filescanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 500);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDB);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(434, 272);
            this.Name = "Filescanner";
            this.Text = "Filescanner";
            this.Load += new System.EventHandler(this.Filescanner_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filescanner_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDB.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Button buttonOrdner;
        private System.Windows.Forms.Button buttonStartScann;
        private System.Windows.Forms.ComboBox cmb_StartOrdner;
        private System.Windows.Forms.Panel panelDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSpecialImport;
        private System.Windows.Forms.CheckBox checkBoxTest;
        private System.Windows.Forms.CheckBox checkBoxSampler;
        private System.Windows.Forms.CheckBox checkBoxLöschen;
        private System.Windows.Forms.ComboBox comboBoxMedium;
        private System.Windows.Forms.ComboBox comboBoxQuelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxKatalog;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAllFileSize;
        private System.Windows.Forms.Label labelFolders;
        private System.Windows.Forms.Label labelDateien;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonCancelScann;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelStart;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripabelDauer;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelSpecial;
        private System.Windows.Forms.ListView listViewFileList;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel3;
        private System.Windows.Forms.Button buttonCancelImport;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.Label labelDateien2;
        private System.Windows.Forms.Label labelDateien1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelFolders2;
        private System.Windows.Forms.Label labelFolders1;
    }
}