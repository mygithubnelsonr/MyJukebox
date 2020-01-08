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
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonStartScann = new System.Windows.Forms.Button();
            this.statusStripScann = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFolders = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalsize = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewFileList = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.buttonOrdner = new System.Windows.Forms.Button();
            this.comboBoxStartOrdner = new System.Windows.Forms.ComboBox();
            this.panelDB = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxMedium = new System.Windows.Forms.ComboBox();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxKatalog = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFailed = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelImport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.checkBoxSpecialImport = new System.Windows.Forms.CheckBox();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.checkBoxSampler = new System.Windows.Forms.CheckBox();
            this.checkBoxLöschen = new System.Windows.Forms.CheckBox();
            this.statusStripImport = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabelStart = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripabelDauer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStripLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelShowHideDbPanel = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.statusStripScann.SuspendLayout();
            this.panelDB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStripImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.panelControls);
            this.panel1.Controls.Add(this.listViewFileList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxExtension);
            this.panel1.Controls.Add(this.buttonOrdner);
            this.panel1.Controls.Add(this.comboBoxStartOrdner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 219);
            this.panel1.TabIndex = 8;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonTest);
            this.panelControls.Controls.Add(this.buttonStartScann);
            this.panelControls.Controls.Add(this.statusStripScann);
            this.panelControls.Location = new System.Drawing.Point(12, 195);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(412, 21);
            this.panelControls.TabIndex = 24;
            // 
            // buttonStartScann
            // 
            this.buttonStartScann.Location = new System.Drawing.Point(313, -1);
            this.buttonStartScann.Name = "buttonStartScann";
            this.buttonStartScann.Size = new System.Drawing.Size(87, 20);
            this.buttonStartScann.TabIndex = 9;
            this.buttonStartScann.Text = "Start";
            this.buttonStartScann.UseVisualStyleBackColor = true;
            this.buttonStartScann.Click += new System.EventHandler(this.buttonStartScann_Click);
            // 
            // statusStripScann
            // 
            this.statusStripScann.BackColor = System.Drawing.Color.LightSlateGray;
            this.statusStripScann.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelFolders,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelFiles,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelTotalsize});
            this.statusStripScann.Location = new System.Drawing.Point(0, -1);
            this.statusStripScann.Name = "statusStripScann";
            this.statusStripScann.Size = new System.Drawing.Size(412, 22);
            this.statusStripScann.TabIndex = 23;
            this.statusStripScann.Text = "statusStripScanner";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel2.Text = "Folders:";
            // 
            // toolStripStatusLabelFolders
            // 
            this.toolStripStatusLabelFolders.Name = "toolStripStatusLabelFolders";
            this.toolStripStatusLabelFolders.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelFolders.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Files:";
            // 
            // toolStripStatusLabelFiles
            // 
            this.toolStripStatusLabelFiles.Name = "toolStripStatusLabelFiles";
            this.toolStripStatusLabelFiles.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelFiles.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel3.Text = "Filesize total:";
            // 
            // toolStripStatusLabelTotalsize
            // 
            this.toolStripStatusLabelTotalsize.Name = "toolStripStatusLabelTotalsize";
            this.toolStripStatusLabelTotalsize.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelTotalsize.Text = "0";
            // 
            // listViewFileList
            // 
            this.listViewFileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderSize,
            this.columnHeaderDate,
            this.columnHeaderPath});
            this.listViewFileList.FullRowSelect = true;
            this.listViewFileList.GridLines = true;
            this.listViewFileList.HideSelection = false;
            this.listViewFileList.Location = new System.Drawing.Point(12, 52);
            this.listViewFileList.Name = "listViewFileList";
            this.listViewFileList.Size = new System.Drawing.Size(401, 133);
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
            this.textBoxExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtension.Location = new System.Drawing.Point(366, 25);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(47, 20);
            this.textBoxExtension.TabIndex = 12;
            this.textBoxExtension.Text = ".mp3";
            // 
            // buttonOrdner
            // 
            this.buttonOrdner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrdner.Location = new System.Drawing.Point(303, 30);
            this.buttonOrdner.Name = "buttonOrdner";
            this.buttonOrdner.Size = new System.Drawing.Size(34, 16);
            this.buttonOrdner.TabIndex = 10;
            this.buttonOrdner.Text = "----";
            this.buttonOrdner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOrdner.UseVisualStyleBackColor = true;
            this.buttonOrdner.Click += new System.EventHandler(this.buttonOrdner_Click);
            // 
            // comboBoxStartOrdner
            // 
            this.comboBoxStartOrdner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStartOrdner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxStartOrdner.FormattingEnabled = true;
            this.comboBoxStartOrdner.Items.AddRange(new object[] {
            "",
            "A:\\Temp",
            "\\\\win2k16dc01\\FS012\\Country\\Sonja\\CD\\Dan + Shay\\Dan + Shay"});
            this.comboBoxStartOrdner.Location = new System.Drawing.Point(12, 25);
            this.comboBoxStartOrdner.Name = "comboBoxStartOrdner";
            this.comboBoxStartOrdner.Size = new System.Drawing.Size(285, 21);
            this.comboBoxStartOrdner.TabIndex = 8;
            this.comboBoxStartOrdner.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartOrdner_SelectedIndexChanged);
            this.comboBoxStartOrdner.TextChanged += new System.EventHandler(this.comboBoxStartOrdner_TextChanged);
            // 
            // panelDB
            // 
            this.panelDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDB.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelDB.Controls.Add(this.groupBox3);
            this.panelDB.Controls.Add(this.groupBox2);
            this.panelDB.Controls.Add(this.groupBox1);
            this.panelDB.Location = new System.Drawing.Point(0, 233);
            this.panelDB.Name = "panelDB";
            this.panelDB.Size = new System.Drawing.Size(424, 246);
            this.panelDB.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxMedium);
            this.groupBox3.Controls.Add(this.comboBoxAlbum);
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
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(10, 86);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(166, 21);
            this.comboBoxAlbum.TabIndex = 7;
            this.comboBoxAlbum.Text = "Album";
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
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Album";
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelFailed);
            this.groupBox2.Controls.Add(this.labelSuccess);
            this.groupBox2.Location = new System.Drawing.Point(220, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Record";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Import failed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Import success: ";
            // 
            // labelFailed
            // 
            this.labelFailed.AutoSize = true;
            this.labelFailed.Location = new System.Drawing.Point(158, 43);
            this.labelFailed.Name = "labelFailed";
            this.labelFailed.Size = new System.Drawing.Size(19, 13);
            this.labelFailed.TabIndex = 1;
            this.labelFailed.Text = "----";
            this.labelFailed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Location = new System.Drawing.Point(158, 18);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(19, 13);
            this.labelSuccess.TabIndex = 0;
            this.labelSuccess.Text = "----";
            this.labelSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // statusStripImport
            // 
            this.statusStripImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1,
            this.statusStripLabelStart,
            this.statusStripLabel2,
            this.statusStripabelDauer,
            this.toolStripProgressBar,
            this.statusStripLabel3});
            this.statusStripImport.Location = new System.Drawing.Point(0, 477);
            this.statusStripImport.Name = "statusStripImport";
            this.statusStripImport.Size = new System.Drawing.Size(424, 24);
            this.statusStripImport.TabIndex = 16;
            this.statusStripImport.Text = "statusStrip1";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(31, 19);
            this.statusStripLabel1.Text = "Start";
            // 
            // statusStripLabelStart
            // 
            this.statusStripLabelStart.AutoSize = false;
            this.statusStripLabelStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabelStart.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabelStart.Name = "statusStripLabelStart";
            this.statusStripLabelStart.Size = new System.Drawing.Size(50, 19);
            this.statusStripLabelStart.Text = " ";
            // 
            // statusStripLabel2
            // 
            this.statusStripLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabel2.Name = "statusStripLabel2";
            this.statusStripLabel2.Size = new System.Drawing.Size(42, 19);
            this.statusStripLabel2.Text = "Dauer";
            // 
            // statusStripabelDauer
            // 
            this.statusStripabelDauer.AutoSize = false;
            this.statusStripabelDauer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripabelDauer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripabelDauer.Name = "statusStripabelDauer";
            this.statusStripabelDauer.Size = new System.Drawing.Size(50, 19);
            this.statusStripabelDauer.Text = " ";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Enabled = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(160, 18);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // statusStripLabel3
            // 
            this.statusStripLabel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabel3.Name = "statusStripLabel3";
            this.statusStripLabel3.Size = new System.Drawing.Size(236, 19);
            this.statusStripLabel3.Spring = true;
            // 
            // labelShowHideDbPanel
            // 
            this.labelShowHideDbPanel.AutoSize = true;
            this.labelShowHideDbPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowHideDbPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelShowHideDbPanel.Location = new System.Drawing.Point(193, 221);
            this.labelShowHideDbPanel.Name = "labelShowHideDbPanel";
            this.labelShowHideDbPanel.Size = new System.Drawing.Size(35, 9);
            this.labelShowHideDbPanel.TabIndex = 17;
            this.labelShowHideDbPanel.Text = "======";
            this.labelShowHideDbPanel.Click += new System.EventHandler(this.labelShowHideDbPanel_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(269, -1);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(38, 20);
            this.buttonTest.TabIndex = 24;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Filescanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.labelShowHideDbPanel);
            this.Controls.Add(this.statusStripImport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 640);
            this.Name = "Filescanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filescanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filescanner_FormClosing);
            this.Load += new System.EventHandler(this.Filescanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.statusStripScann.ResumeLayout(false);
            this.statusStripScann.PerformLayout();
            this.panelDB.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStripImport.ResumeLayout(false);
            this.statusStripImport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Button buttonOrdner;
        private System.Windows.Forms.Button buttonStartScann;
        private System.Windows.Forms.ComboBox comboBoxStartOrdner;
        private System.Windows.Forms.Panel panelDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStripImport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSpecialImport;
        private System.Windows.Forms.CheckBox checkBoxTest;
        private System.Windows.Forms.CheckBox checkBoxSampler;
        private System.Windows.Forms.CheckBox checkBoxLöschen;
        private System.Windows.Forms.ComboBox comboBoxMedium;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxKatalog;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFailed;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabelStart;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripabelDauer;
        private System.Windows.Forms.ListView listViewFileList;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel3;
        private System.Windows.Forms.Button buttonCancelImport;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStripScann;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFolders;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFiles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalsize;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelShowHideDbPanel;
        private System.Windows.Forms.Button buttonTest;
    }
}