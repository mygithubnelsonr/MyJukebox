namespace MyJukebox_EF
{
    partial class MyJukebox
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyJukebox));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Knoten1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Knoten0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importNewSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMainFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlayback = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlaybackPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlaybackPause = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlaybackStop = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainToolsTest1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainToolsTest2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripGenre = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripKatalog = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripAlbum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInterpret = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripGap1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripRowcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripGap2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTitel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpring1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpring2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogical = new System.Windows.Forms.TabPage();
            this.tvlogic = new System.Windows.Forms.TreeView();
            this.tvlogicContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvlogicContextMenuStripCollaps = new System.Windows.Forms.ToolStripMenuItem();
            this.tvlogicContextMenuStripExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tvlogicContextMenuStripAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tvlogicContextMenuStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tvlogicContextMenuStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tvlogicContextMenuStripRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tvlogicContextMenuStripScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPlayLists = new System.Windows.Forms.TabPage();
            this.tvplaylist = new System.Windows.Forms.TreeView();
            this.tabPhysical = new System.Windows.Forms.TabPage();
            this.tvphysical = new System.Windows.Forms.TreeView();
            this.toolStripPlaybackTrackBarPosition = new System.Windows.Forms.TrackBar();
            this.toolStripPlaybackTrackBarVolume = new System.Windows.Forms.TrackBar();
            this.toolStripPlayback = new System.Windows.Forms.ToolStrip();
            this.toolStripPlaybackButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripPlaybackButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripPlaybackButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripPlaybackButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPlaybackButtonRandom = new System.Windows.Forms.ToolStripButton();
            this.toolStripPlaybackButtonLoop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPlaybackButtonSpeaker = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.datagridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridContextMenuStripSendToPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripSendToNewPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridContextMenuStripSendToKatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripSendToNewKatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.rateItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripRating0 = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripRating1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripRating2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripRating3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripRating4 = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripRating5 = new System.Windows.Forms.ToolStripMenuItem();
            this.beatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripBeatF = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripBeatM = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripBeatS = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripCopyToClip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.setLinkToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetErrorflagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntrysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFilesAndEntrysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLinkToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonQueryhSave = new System.Windows.Forms.Button();
            this.comboBoxQueries = new System.Windows.Forms.ComboBox();
            this.buttonQueryClear = new System.Windows.Forms.Button();
            this.buttonQueryExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripFile = new System.Windows.Forms.ToolStrip();
            this.toolStripFileButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripFileButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.toolTipVolume = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPosition = new System.Windows.Forms.ToolTip(this.components);
            this.timerImageFlip = new System.Windows.Forms.Timer(this.components);
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.timerShowMyBitmap = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabLogical.SuspendLayout();
            this.tvlogicContextMenuStrip.SuspendLayout();
            this.tabPlayLists.SuspendLayout();
            this.tabPhysical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarVolume)).BeginInit();
            this.toolStripPlayback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.datagridContextMenuStrip.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.toolStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainFile,
            this.menuMainEdit,
            this.menuMainView,
            this.menuMainPlayback,
            this.menuMainTools,
            this.menuMainDatabase,
            this.menuMainAbout});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(884, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuMain";
            // 
            // menuMainFile
            // 
            this.menuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importNewSongsToolStripMenuItem,
            this.toolStripSeparator3,
            this.menuMainFileExit});
            this.menuMainFile.Name = "menuMainFile";
            this.menuMainFile.Size = new System.Drawing.Size(37, 20);
            this.menuMainFile.Text = "File";
            // 
            // importNewSongsToolStripMenuItem
            // 
            this.importNewSongsToolStripMenuItem.Name = "importNewSongsToolStripMenuItem";
            this.importNewSongsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importNewSongsToolStripMenuItem.Text = "Import new Songs";
            this.importNewSongsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemimportNewSongs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // menuMainFileExit
            // 
            this.menuMainFileExit.Name = "menuMainFileExit";
            this.menuMainFileExit.Size = new System.Drawing.Size(170, 22);
            this.menuMainFileExit.Text = "Exit";
            this.menuMainFileExit.Click += new System.EventHandler(this.menuMainFileExit_Click);
            // 
            // menuMainEdit
            // 
            this.menuMainEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainEditRecord});
            this.menuMainEdit.Name = "menuMainEdit";
            this.menuMainEdit.Size = new System.Drawing.Size(39, 20);
            this.menuMainEdit.Text = "Edit";
            // 
            // menuMainEditRecord
            // 
            this.menuMainEditRecord.Name = "menuMainEditRecord";
            this.menuMainEditRecord.Size = new System.Drawing.Size(111, 22);
            this.menuMainEditRecord.Text = "Record";
            this.menuMainEditRecord.Click += new System.EventHandler(this.menuMainEditRecord_Click);
            // 
            // menuMainView
            // 
            this.menuMainView.Name = "menuMainView";
            this.menuMainView.Size = new System.Drawing.Size(44, 20);
            this.menuMainView.Text = "View";
            // 
            // menuMainPlayback
            // 
            this.menuMainPlayback.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainPlaybackPlay,
            this.menuMainPlaybackPause,
            this.menuMainPlaybackStop,
            this.repeatToolStripMenuItem});
            this.menuMainPlayback.Name = "menuMainPlayback";
            this.menuMainPlayback.Size = new System.Drawing.Size(66, 20);
            this.menuMainPlayback.Text = "Playback";
            // 
            // menuMainPlaybackPlay
            // 
            this.menuMainPlaybackPlay.Name = "menuMainPlaybackPlay";
            this.menuMainPlaybackPlay.Size = new System.Drawing.Size(110, 22);
            this.menuMainPlaybackPlay.Text = "Play";
            this.menuMainPlaybackPlay.Click += new System.EventHandler(this.menuMainPlaybackPlay_Click);
            // 
            // menuMainPlaybackPause
            // 
            this.menuMainPlaybackPause.Name = "menuMainPlaybackPause";
            this.menuMainPlaybackPause.Size = new System.Drawing.Size(110, 22);
            this.menuMainPlaybackPause.Text = "Pause";
            this.menuMainPlaybackPause.Click += new System.EventHandler(this.menuMainPlaybackPause_Click);
            // 
            // menuMainPlaybackStop
            // 
            this.menuMainPlaybackStop.Name = "menuMainPlaybackStop";
            this.menuMainPlaybackStop.Size = new System.Drawing.Size(110, 22);
            this.menuMainPlaybackStop.Text = "Stop";
            this.menuMainPlaybackStop.Click += new System.EventHandler(this.menuMainPlaybackStop_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackToolStripMenuItem,
            this.allToolStripMenuItem});
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            // 
            // trackToolStripMenuItem
            // 
            this.trackToolStripMenuItem.Name = "trackToolStripMenuItem";
            this.trackToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.trackToolStripMenuItem.Text = "Track";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Checked = true;
            this.allToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // menuMainTools
            // 
            this.menuMainTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainToolsTest1,
            this.menuMainToolsTest2});
            this.menuMainTools.Name = "menuMainTools";
            this.menuMainTools.Size = new System.Drawing.Size(46, 20);
            this.menuMainTools.Text = "Tools";
            // 
            // menuMainToolsTest1
            // 
            this.menuMainToolsTest1.Name = "menuMainToolsTest1";
            this.menuMainToolsTest1.Size = new System.Drawing.Size(129, 22);
            this.menuMainToolsTest1.Text = "Test only 1";
            this.menuMainToolsTest1.Click += new System.EventHandler(this.menuMainToolsTest1_Click);
            // 
            // menuMainToolsTest2
            // 
            this.menuMainToolsTest2.Name = "menuMainToolsTest2";
            this.menuMainToolsTest2.Size = new System.Drawing.Size(129, 22);
            this.menuMainToolsTest2.Text = "Test only 2";
            this.menuMainToolsTest2.Click += new System.EventHandler(this.menuMainToolsTest2_Click);
            // 
            // menuMainDatabase
            // 
            this.menuMainDatabase.Name = "menuMainDatabase";
            this.menuMainDatabase.Size = new System.Drawing.Size(67, 20);
            this.menuMainDatabase.Text = "Database";
            // 
            // menuMainAbout
            // 
            this.menuMainAbout.Name = "menuMainAbout";
            this.menuMainAbout.Size = new System.Drawing.Size(52, 20);
            this.menuMainAbout.Text = "About";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightSlateGray;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripGenre,
            this.statusStripKatalog,
            this.statusStripAlbum,
            this.statusStripInterpret,
            this.statusStripGap1,
            this.statusStripRow,
            this.statusStripLabel1,
            this.statusStripRowcount,
            this.statusStripGap2,
            this.statusStripTitel,
            this.statusStripPosition,
            this.statusStripDuration,
            this.statusStripVersion,
            this.statusStripCopyright});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(884, 28);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripGenre
            // 
            this.statusStripGenre.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripGenre.Name = "statusStripGenre";
            this.statusStripGenre.Size = new System.Drawing.Size(42, 23);
            this.statusStripGenre.Text = "Genre";
            this.statusStripGenre.ToolTipText = "Genre";
            // 
            // statusStripKatalog
            // 
            this.statusStripKatalog.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripKatalog.Name = "statusStripKatalog";
            this.statusStripKatalog.Size = new System.Drawing.Size(51, 23);
            this.statusStripKatalog.Text = "Katalog";
            this.statusStripKatalog.ToolTipText = "Katalog";
            // 
            // statusStripAlbum
            // 
            this.statusStripAlbum.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripAlbum.Name = "statusStripAlbum";
            this.statusStripAlbum.Size = new System.Drawing.Size(47, 23);
            this.statusStripAlbum.Text = "Album";
            // 
            // statusStripInterpret
            // 
            this.statusStripInterpret.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripInterpret.Name = "statusStripInterpret";
            this.statusStripInterpret.Size = new System.Drawing.Size(56, 23);
            this.statusStripInterpret.Text = "Interpret";
            // 
            // statusStripGap1
            // 
            this.statusStripGap1.AutoSize = false;
            this.statusStripGap1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripGap1.Name = "statusStripGap1";
            this.statusStripGap1.Size = new System.Drawing.Size(100, 23);
            // 
            // statusStripRow
            // 
            this.statusStripRow.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripRow.Name = "statusStripRow";
            this.statusStripRow.Size = new System.Drawing.Size(44, 23);
            this.statusStripRow.Text = "Count";
            this.statusStripRow.ToolTipText = "Genre";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(31, 23);
            this.statusStripLabel1.Text = "von";
            // 
            // statusStripRowcount
            // 
            this.statusStripRowcount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripRowcount.Name = "statusStripRowcount";
            this.statusStripRowcount.Size = new System.Drawing.Size(51, 23);
            this.statusStripRowcount.Text = "Gesamt";
            this.statusStripRowcount.ToolTipText = "Genre";
            // 
            // statusStripGap2
            // 
            this.statusStripGap2.AutoSize = false;
            this.statusStripGap2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripGap2.Name = "statusStripGap2";
            this.statusStripGap2.Size = new System.Drawing.Size(60, 23);
            // 
            // statusStripTitel
            // 
            this.statusStripTitel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripTitel.Name = "statusStripTitel";
            this.statusStripTitel.Size = new System.Drawing.Size(161, 23);
            this.statusStripTitel.Spring = true;
            this.statusStripTitel.Text = "Titel";
            this.statusStripTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusStripTitel.ToolTipText = "Titel";
            // 
            // statusStripPosition
            // 
            this.statusStripPosition.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripPosition.Name = "statusStripPosition";
            this.statusStripPosition.Size = new System.Drawing.Size(54, 23);
            this.statusStripPosition.Text = "Position";
            // 
            // statusStripDuration
            // 
            this.statusStripDuration.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripDuration.Name = "statusStripDuration";
            this.statusStripDuration.Size = new System.Drawing.Size(57, 23);
            this.statusStripDuration.Text = "Duration";
            this.statusStripDuration.ToolTipText = "Duration";
            // 
            // statusStripVersion
            // 
            this.statusStripVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripVersion.Name = "statusStripVersion";
            this.statusStripVersion.Size = new System.Drawing.Size(49, 23);
            this.statusStripVersion.Text = "Version";
            // 
            // statusStripCopyright
            // 
            this.statusStripCopyright.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusStripCopyright.Name = "statusStripCopyright";
            this.statusStripCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStripCopyright.Size = new System.Drawing.Size(65, 23);
            this.statusStripCopyright.Text = "(c) NRSoft";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel2.Text = "Node";
            // 
            // toolStripStatusLabelNode
            // 
            this.toolStripStatusLabelNode.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelNode.Name = "toolStripStatusLabelNode";
            this.toolStripStatusLabelNode.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabelNode.Text = "Node";
            // 
            // toolStripStatusLabelSpring1
            // 
            this.toolStripStatusLabelSpring1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelSpring1.Name = "toolStripStatusLabelSpring1";
            this.toolStripStatusLabelSpring1.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabelSpring1.Text = " ";
            // 
            // toolStripStatusLabelSpring2
            // 
            this.toolStripStatusLabelSpring2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelSpring2.Name = "toolStripStatusLabelSpring2";
            this.toolStripStatusLabelSpring2.Size = new System.Drawing.Size(767, 17);
            this.toolStripStatusLabelSpring2.Spring = true;
            this.toolStripStatusLabelSpring2.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Version";
            // 
            // toolStripStatusLabelVersion
            // 
            this.toolStripStatusLabelVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabelVersion.Text = "Version";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightSlateGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxFoto);
            this.splitContainer1.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            this.splitContainer1.Panel1MinSize = 220;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripPlaybackTrackBarPosition);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripPlaybackTrackBarVolume);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripPlayback);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.panelSearch);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripFile);
            this.splitContainer1.Size = new System.Drawing.Size(884, 509);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.SplitterIncrement = 6;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.pictureBoxFoto.Location = new System.Drawing.Point(-1, 380);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(228, 125);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 1;
            this.pictureBoxFoto.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 256);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(221, 169);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_StatusChange);
            this.axWindowsMediaPlayer1.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.axWindowsMediaPlayer1_EndOfStream);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabLogical);
            this.tabControl.Controls.Add(this.tabPlayLists);
            this.tabControl.Controls.Add(this.tabPhysical);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(222, 244);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabLogical
            // 
            this.tabLogical.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabLogical.Controls.Add(this.tvlogic);
            this.tabLogical.Location = new System.Drawing.Point(4, 24);
            this.tabLogical.Name = "tabLogical";
            this.tabLogical.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogical.Size = new System.Drawing.Size(214, 216);
            this.tabLogical.TabIndex = 0;
            this.tabLogical.Text = "Logical";
            this.tabLogical.UseVisualStyleBackColor = true;
            // 
            // tvlogic
            // 
            this.tvlogic.BackColor = System.Drawing.Color.LightSlateGray;
            this.tvlogic.ContextMenuStrip = this.tvlogicContextMenuStrip;
            this.tvlogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvlogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvlogic.ForeColor = System.Drawing.Color.Gold;
            this.tvlogic.FullRowSelect = true;
            this.tvlogic.LineColor = System.Drawing.Color.Gold;
            this.tvlogic.Location = new System.Drawing.Point(3, 3);
            this.tvlogic.Name = "tvlogic";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode1.ForeColor = System.Drawing.Color.Gold;
            treeNode1.Name = "Knoten1";
            treeNode1.Text = "Knoten1";
            treeNode2.Name = "Knoten0";
            treeNode2.Text = "Knoten0";
            this.tvlogic.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvlogic.ShowNodeToolTips = true;
            this.tvlogic.Size = new System.Drawing.Size(208, 210);
            this.tvlogic.TabIndex = 0;
            this.tvlogic.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvlogic_AfterExpand);
            this.tvlogic.Click += new System.EventHandler(this.tvlogic_Click);
            this.tvlogic.DoubleClick += new System.EventHandler(this.tvlogic_DoubleClick);
            this.tvlogic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvlogic_MouseDown);
            // 
            // tvlogicContextMenuStrip
            // 
            this.tvlogicContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tvlogicContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tvlogicContextMenuStripCollaps,
            this.tvlogicContextMenuStripExpand,
            this.toolStripSeparator8,
            this.tvlogicContextMenuStripAdd,
            this.tvlogicContextMenuStripNew,
            this.tvlogicContextMenuStripDelete,
            this.tvlogicContextMenuStripRename,
            this.toolStripSeparator7,
            this.tvlogicContextMenuStripScanner});
            this.tvlogicContextMenuStrip.Name = "tvlogicContextMenuStrip";
            this.tvlogicContextMenuStrip.Size = new System.Drawing.Size(149, 170);
            // 
            // tvlogicContextMenuStripCollaps
            // 
            this.tvlogicContextMenuStripCollaps.Name = "tvlogicContextMenuStripCollaps";
            this.tvlogicContextMenuStripCollaps.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripCollaps.Text = "Collaps";
            // 
            // tvlogicContextMenuStripExpand
            // 
            this.tvlogicContextMenuStripExpand.Name = "tvlogicContextMenuStripExpand";
            this.tvlogicContextMenuStripExpand.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripExpand.Text = "Expand";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(145, 6);
            // 
            // tvlogicContextMenuStripAdd
            // 
            this.tvlogicContextMenuStripAdd.Name = "tvlogicContextMenuStripAdd";
            this.tvlogicContextMenuStripAdd.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripAdd.Text = "add to Playlist";
            this.tvlogicContextMenuStripAdd.Click += new System.EventHandler(this.tvlogicContextMenuStripAdd_Click);
            // 
            // tvlogicContextMenuStripNew
            // 
            this.tvlogicContextMenuStripNew.Name = "tvlogicContextMenuStripNew";
            this.tvlogicContextMenuStripNew.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripNew.Text = "Neu";
            // 
            // tvlogicContextMenuStripDelete
            // 
            this.tvlogicContextMenuStripDelete.Name = "tvlogicContextMenuStripDelete";
            this.tvlogicContextMenuStripDelete.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripDelete.Text = "Löschen";
            // 
            // tvlogicContextMenuStripRename
            // 
            this.tvlogicContextMenuStripRename.Name = "tvlogicContextMenuStripRename";
            this.tvlogicContextMenuStripRename.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripRename.Text = "Rename";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(145, 6);
            // 
            // tvlogicContextMenuStripScanner
            // 
            this.tvlogicContextMenuStripScanner.Name = "tvlogicContextMenuStripScanner";
            this.tvlogicContextMenuStripScanner.Size = new System.Drawing.Size(148, 22);
            this.tvlogicContextMenuStripScanner.Text = "open Scanner";
            // 
            // tabPlayLists
            // 
            this.tabPlayLists.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPlayLists.Controls.Add(this.tvplaylist);
            this.tabPlayLists.Location = new System.Drawing.Point(4, 24);
            this.tabPlayLists.Name = "tabPlayLists";
            this.tabPlayLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayLists.Size = new System.Drawing.Size(214, 216);
            this.tabPlayLists.TabIndex = 1;
            this.tabPlayLists.Text = "Playlists";
            // 
            // tvplaylist
            // 
            this.tvplaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvplaylist.BackColor = System.Drawing.Color.LightSlateGray;
            this.tvplaylist.ForeColor = System.Drawing.Color.Gold;
            this.tvplaylist.Location = new System.Drawing.Point(3, 3);
            this.tvplaylist.Name = "tvplaylist";
            treeNode3.BackColor = System.Drawing.Color.Blue;
            treeNode3.ForeColor = System.Drawing.Color.Gold;
            treeNode3.Name = "Node1";
            treeNode3.Text = "Node1";
            treeNode4.ForeColor = System.Drawing.Color.Gold;
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            this.tvplaylist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvplaylist.Size = new System.Drawing.Size(211, 215);
            this.tvplaylist.TabIndex = 0;
            this.tvplaylist.Click += new System.EventHandler(this.tvplaylist_Click);
            this.tvplaylist.DoubleClick += new System.EventHandler(this.tvplaylist_DoubleClick);
            this.tvplaylist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvPlaylist_MouseDown);
            // 
            // tabPhysical
            // 
            this.tabPhysical.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPhysical.Controls.Add(this.tvphysical);
            this.tabPhysical.Location = new System.Drawing.Point(4, 24);
            this.tabPhysical.Name = "tabPhysical";
            this.tabPhysical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhysical.Size = new System.Drawing.Size(214, 216);
            this.tabPhysical.TabIndex = 2;
            this.tabPhysical.Text = "Physical";
            this.tabPhysical.UseVisualStyleBackColor = true;
            // 
            // tvphysical
            // 
            this.tvphysical.BackColor = System.Drawing.Color.LightSlateGray;
            this.tvphysical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvphysical.Location = new System.Drawing.Point(3, 3);
            this.tvphysical.Name = "tvphysical";
            this.tvphysical.Size = new System.Drawing.Size(208, 210);
            this.tvphysical.TabIndex = 0;
            // 
            // toolStripPlaybackTrackBarPosition
            // 
            this.toolStripPlaybackTrackBarPosition.AutoSize = false;
            this.toolStripPlaybackTrackBarPosition.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripPlaybackTrackBarPosition.Location = new System.Drawing.Point(347, 4);
            this.toolStripPlaybackTrackBarPosition.Maximum = 100;
            this.toolStripPlaybackTrackBarPosition.Name = "toolStripPlaybackTrackBarPosition";
            this.toolStripPlaybackTrackBarPosition.Size = new System.Drawing.Size(112, 18);
            this.toolStripPlaybackTrackBarPosition.TabIndex = 5;
            this.toolStripPlaybackTrackBarPosition.TickFrequency = 10;
            this.toolTipPosition.SetToolTip(this.toolStripPlaybackTrackBarPosition, "Position");
            this.toolStripPlaybackTrackBarPosition.Scroll += new System.EventHandler(this.trackBarPosition_Scroll);
            // 
            // toolStripPlaybackTrackBarVolume
            // 
            this.toolStripPlaybackTrackBarVolume.AutoSize = false;
            this.toolStripPlaybackTrackBarVolume.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripPlaybackTrackBarVolume.Location = new System.Drawing.Point(219, 4);
            this.toolStripPlaybackTrackBarVolume.Maximum = 100;
            this.toolStripPlaybackTrackBarVolume.Name = "toolStripPlaybackTrackBarVolume";
            this.toolStripPlaybackTrackBarVolume.Size = new System.Drawing.Size(112, 18);
            this.toolStripPlaybackTrackBarVolume.TabIndex = 4;
            this.toolStripPlaybackTrackBarVolume.TickFrequency = 10;
            this.toolTipVolume.SetToolTip(this.toolStripPlaybackTrackBarVolume, "Volume");
            this.toolStripPlaybackTrackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // toolStripPlayback
            // 
            this.toolStripPlayback.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripPlayback.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPlayback.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripPlayback.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPlaybackButtonPlay,
            this.toolStripPlaybackButtonPause,
            this.toolStripPlaybackButtonStop,
            this.toolStripPlaybackButtonNext,
            this.toolStripSeparator1,
            this.toolStripPlaybackButtonRandom,
            this.toolStripPlaybackButtonLoop,
            this.toolStripSeparator2,
            this.toolStripPlaybackButtonSpeaker});
            this.toolStripPlayback.Location = new System.Drawing.Point(2, 0);
            this.toolStripPlayback.Name = "toolStripPlayback";
            this.toolStripPlayback.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripPlayback.Size = new System.Drawing.Size(449, 27);
            this.toolStripPlayback.TabIndex = 3;
            this.toolStripPlayback.Text = "toolStripPlayback";
            // 
            // toolStripPlaybackButtonPlay
            // 
            this.toolStripPlaybackButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonPlay.Image")));
            this.toolStripPlaybackButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonPlay.Name = "toolStripPlaybackButtonPlay";
            this.toolStripPlaybackButtonPlay.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonPlay.Text = "Play";
            this.toolStripPlaybackButtonPlay.Click += new System.EventHandler(this.toolStripPlaybackButtonPlay_Click);
            // 
            // toolStripPlaybackButtonPause
            // 
            this.toolStripPlaybackButtonPause.CheckOnClick = true;
            this.toolStripPlaybackButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonPause.Image")));
            this.toolStripPlaybackButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonPause.Name = "toolStripPlaybackButtonPause";
            this.toolStripPlaybackButtonPause.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonPause.Text = "Pause";
            this.toolStripPlaybackButtonPause.Click += new System.EventHandler(this.toolStripPlaybackButtonPause_Click);
            // 
            // toolStripPlaybackButtonStop
            // 
            this.toolStripPlaybackButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonStop.Image")));
            this.toolStripPlaybackButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonStop.Name = "toolStripPlaybackButtonStop";
            this.toolStripPlaybackButtonStop.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonStop.Text = "Stop";
            this.toolStripPlaybackButtonStop.Click += new System.EventHandler(this.toolStripPlaybackButtonStop_Click);
            // 
            // toolStripPlaybackButtonNext
            // 
            this.toolStripPlaybackButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonNext.Image")));
            this.toolStripPlaybackButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonNext.Name = "toolStripPlaybackButtonNext";
            this.toolStripPlaybackButtonNext.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonNext.Tag = "";
            this.toolStripPlaybackButtonNext.Text = "Next";
            this.toolStripPlaybackButtonNext.Click += new System.EventHandler(this.toolStripPlaybackButtonNext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripPlaybackButtonRandom
            // 
            this.toolStripPlaybackButtonRandom.CheckOnClick = true;
            this.toolStripPlaybackButtonRandom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonRandom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonRandom.Image")));
            this.toolStripPlaybackButtonRandom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonRandom.Name = "toolStripPlaybackButtonRandom";
            this.toolStripPlaybackButtonRandom.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonRandom.Tag = false;
            this.toolStripPlaybackButtonRandom.Text = "toolStripButton6";
            this.toolStripPlaybackButtonRandom.ToolTipText = "Random";
            this.toolStripPlaybackButtonRandom.Click += new System.EventHandler(this.toolStripButtonRandom_Click);
            // 
            // toolStripPlaybackButtonLoop
            // 
            this.toolStripPlaybackButtonLoop.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripPlaybackButtonLoop.CheckOnClick = true;
            this.toolStripPlaybackButtonLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonLoop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonLoop.Image")));
            this.toolStripPlaybackButtonLoop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonLoop.Name = "toolStripPlaybackButtonLoop";
            this.toolStripPlaybackButtonLoop.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonLoop.Text = "toolStripButton7";
            this.toolStripPlaybackButtonLoop.ToolTipText = "Loop";
            this.toolStripPlaybackButtonLoop.Click += new System.EventHandler(this.toolStripPlaybackButtonLoop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripPlaybackButtonSpeaker
            // 
            this.toolStripPlaybackButtonSpeaker.CheckOnClick = true;
            this.toolStripPlaybackButtonSpeaker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlaybackButtonSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlaybackButtonSpeaker.Image")));
            this.toolStripPlaybackButtonSpeaker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlaybackButtonSpeaker.Margin = new System.Windows.Forms.Padding(6, 1, 250, 2);
            this.toolStripPlaybackButtonSpeaker.Name = "toolStripPlaybackButtonSpeaker";
            this.toolStripPlaybackButtonSpeaker.Size = new System.Drawing.Size(24, 24);
            this.toolStripPlaybackButtonSpeaker.Text = "YYYYYYYYYYYY";
            this.toolStripPlaybackButtonSpeaker.ToolTipText = "Mute";
            this.toolStripPlaybackButtonSpeaker.Click += new System.EventHandler(this.toolStripPlaybackButtonSpeaker_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 28;
            this.dataGridView.ContextMenuStrip = this.datagridContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(2, 57);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidth = 20;
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(643, 448);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.EditModeChanged += new System.EventHandler(this.dataGridView_EditModeChanged);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnWidthChanged);
            this.dataGridView.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_RowHeightChanged);
            this.dataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView_Scroll);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // datagridContextMenuStrip
            // 
            this.datagridContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.datagridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToToolStripMenuItem,
            this.rateItemsToolStripMenuItem,
            this.beatToolStripMenuItem,
            this.DatagridContextMenuStripCopyToClip,
            this.toolStripMenuItemEditRecord,
            this.setLinkToToolStripMenuItem,
            this.resetErrorflagToolStripMenuItem,
            this.deleteEntrysToolStripMenuItem,
            this.deleteFilesAndEntrysToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.setLinkToToolStripMenuItem1,
            this.moveEntryToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.datagridContextMenuStrip.Name = "DatagridContextMenuStrip";
            this.datagridContextMenuStrip.Size = new System.Drawing.Size(208, 312);
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datagridContextMenuStripSendToPlaylist,
            this.DatagridContextMenuStripSendToNewPlaylist,
            this.datagridContextMenuStripSendToKatalog,
            this.DatagridContextMenuStripSendToNewKatalog});
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            this.sendToToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.sendToToolStripMenuItem.Text = "Send to";
            // 
            // datagridContextMenuStripSendToPlaylist
            // 
            this.datagridContextMenuStripSendToPlaylist.Name = "datagridContextMenuStripSendToPlaylist";
            this.datagridContextMenuStripSendToPlaylist.Size = new System.Drawing.Size(141, 22);
            this.datagridContextMenuStripSendToPlaylist.Text = "Playlist";
            // 
            // DatagridContextMenuStripSendToNewPlaylist
            // 
            this.DatagridContextMenuStripSendToNewPlaylist.Name = "DatagridContextMenuStripSendToNewPlaylist";
            this.DatagridContextMenuStripSendToNewPlaylist.Size = new System.Drawing.Size(141, 22);
            this.DatagridContextMenuStripSendToNewPlaylist.Text = "New Playlist";
            // 
            // datagridContextMenuStripSendToKatalog
            // 
            this.datagridContextMenuStripSendToKatalog.Name = "datagridContextMenuStripSendToKatalog";
            this.datagridContextMenuStripSendToKatalog.Size = new System.Drawing.Size(141, 22);
            this.datagridContextMenuStripSendToKatalog.Text = "Katalog";
            // 
            // DatagridContextMenuStripSendToNewKatalog
            // 
            this.DatagridContextMenuStripSendToNewKatalog.Name = "DatagridContextMenuStripSendToNewKatalog";
            this.DatagridContextMenuStripSendToNewKatalog.Size = new System.Drawing.Size(141, 22);
            this.DatagridContextMenuStripSendToNewKatalog.Text = "New Katalog";
            // 
            // rateItemsToolStripMenuItem
            // 
            this.rateItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatagridContextMenuStripRating0,
            this.DatagridContextMenuStripRating1,
            this.DatagridContextMenuStripRating2,
            this.DatagridContextMenuStripRating3,
            this.DatagridContextMenuStripRating4,
            this.DatagridContextMenuStripRating5});
            this.rateItemsToolStripMenuItem.Name = "rateItemsToolStripMenuItem";
            this.rateItemsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.rateItemsToolStripMenuItem.Text = "Rate Items";
            // 
            // DatagridContextMenuStripRating0
            // 
            this.DatagridContextMenuStripRating0.Name = "DatagridContextMenuStripRating0";
            this.DatagridContextMenuStripRating0.Size = new System.Drawing.Size(135, 22);
            this.DatagridContextMenuStripRating0.Tag = "0";
            this.DatagridContextMenuStripRating0.Text = "(No Rating)";
            this.DatagridContextMenuStripRating0.Click += new System.EventHandler(this.datagridContextMenuStripRating_Click);
            // 
            // DatagridContextMenuStripRating1
            // 
            this.DatagridContextMenuStripRating1.Name = "DatagridContextMenuStripRating1";
            this.DatagridContextMenuStripRating1.Size = new System.Drawing.Size(135, 22);
            this.DatagridContextMenuStripRating1.Tag = "1";
            this.DatagridContextMenuStripRating1.Text = "*";
            this.DatagridContextMenuStripRating1.Click += new System.EventHandler(this.datagridContextMenuStripRating_Click);
            // 
            // DatagridContextMenuStripRating2
            // 
            this.DatagridContextMenuStripRating2.Name = "DatagridContextMenuStripRating2";
            this.DatagridContextMenuStripRating2.Size = new System.Drawing.Size(135, 22);
            this.DatagridContextMenuStripRating2.Tag = "2";
            this.DatagridContextMenuStripRating2.Text = "**";
            this.DatagridContextMenuStripRating2.Click += new System.EventHandler(this.datagridContextMenuStripRating_Click);
            // 
            // DatagridContextMenuStripRating3
            // 
            this.DatagridContextMenuStripRating3.Name = "DatagridContextMenuStripRating3";
            this.DatagridContextMenuStripRating3.Size = new System.Drawing.Size(135, 22);
            this.DatagridContextMenuStripRating3.Tag = "3";
            this.DatagridContextMenuStripRating3.Text = "***";
            this.DatagridContextMenuStripRating3.Click += new System.EventHandler(this.datagridContextMenuStripRating_Click);
            // 
            // DatagridContextMenuStripRating4
            // 
            this.DatagridContextMenuStripRating4.Name = "DatagridContextMenuStripRating4";
            this.DatagridContextMenuStripRating4.Size = new System.Drawing.Size(135, 22);
            this.DatagridContextMenuStripRating4.Tag = "4";
            this.DatagridContextMenuStripRating4.Text = "****";
            this.DatagridContextMenuStripRating4.Click += new System.EventHandler(this.datagridContextMenuStripRating_Click);
            // 
            // DatagridContextMenuStripRating5
            // 
            this.DatagridContextMenuStripRating5.Name = "DatagridContextMenuStripRating5";
            this.DatagridContextMenuStripRating5.Size = new System.Drawing.Size(135, 22);
            this.DatagridContextMenuStripRating5.Tag = "5";
            this.DatagridContextMenuStripRating5.Text = "*****";
            this.DatagridContextMenuStripRating5.Click += new System.EventHandler(this.datagridContextMenuStripRating_Click);
            // 
            // beatToolStripMenuItem
            // 
            this.beatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatagridContextMenuStripBeatF,
            this.DatagridContextMenuStripBeatM,
            this.DatagridContextMenuStripBeatS});
            this.beatToolStripMenuItem.Name = "beatToolStripMenuItem";
            this.beatToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.beatToolStripMenuItem.Text = "Beat";
            // 
            // DatagridContextMenuStripBeatF
            // 
            this.DatagridContextMenuStripBeatF.Name = "DatagridContextMenuStripBeatF";
            this.DatagridContextMenuStripBeatF.Size = new System.Drawing.Size(85, 22);
            this.DatagridContextMenuStripBeatF.Text = "F";
            // 
            // DatagridContextMenuStripBeatM
            // 
            this.DatagridContextMenuStripBeatM.Name = "DatagridContextMenuStripBeatM";
            this.DatagridContextMenuStripBeatM.Size = new System.Drawing.Size(85, 22);
            this.DatagridContextMenuStripBeatM.Text = "M";
            // 
            // DatagridContextMenuStripBeatS
            // 
            this.DatagridContextMenuStripBeatS.Name = "DatagridContextMenuStripBeatS";
            this.DatagridContextMenuStripBeatS.Size = new System.Drawing.Size(85, 22);
            this.DatagridContextMenuStripBeatS.Text = "S";
            // 
            // DatagridContextMenuStripCopyToClip
            // 
            this.DatagridContextMenuStripCopyToClip.Name = "DatagridContextMenuStripCopyToClip";
            this.DatagridContextMenuStripCopyToClip.Size = new System.Drawing.Size(207, 22);
            this.DatagridContextMenuStripCopyToClip.Text = "Copy to Clip";
            this.DatagridContextMenuStripCopyToClip.Click += new System.EventHandler(this.datagridContextMenuStripCopyToClip_Click);
            // 
            // toolStripMenuItemEditRecord
            // 
            this.toolStripMenuItemEditRecord.Name = "toolStripMenuItemEditRecord";
            this.toolStripMenuItemEditRecord.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuItemEditRecord.Text = "Edit Record";
            this.toolStripMenuItemEditRecord.Click += new System.EventHandler(this.datagridContextMenuStripEditRecord_Click);
            // 
            // setLinkToToolStripMenuItem
            // 
            this.setLinkToToolStripMenuItem.Name = "setLinkToToolStripMenuItem";
            this.setLinkToToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.setLinkToToolStripMenuItem.Text = "Set Link to";
            // 
            // resetErrorflagToolStripMenuItem
            // 
            this.resetErrorflagToolStripMenuItem.Name = "resetErrorflagToolStripMenuItem";
            this.resetErrorflagToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.resetErrorflagToolStripMenuItem.Text = "Reset Errorflag";
            // 
            // deleteEntrysToolStripMenuItem
            // 
            this.deleteEntrysToolStripMenuItem.Name = "deleteEntrysToolStripMenuItem";
            this.deleteEntrysToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteEntrysToolStripMenuItem.Text = "Delete Entry(s)";
            this.deleteEntrysToolStripMenuItem.Click += new System.EventHandler(this.datagridContextMenuStripdeleteEntrys_Click);
            // 
            // deleteFilesAndEntrysToolStripMenuItem
            // 
            this.deleteFilesAndEntrysToolStripMenuItem.Name = "deleteFilesAndEntrysToolStripMenuItem";
            this.deleteFilesAndEntrysToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteFilesAndEntrysToolStripMenuItem.Text = "Delete File(s) and Entry(s)";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openFolderToolStripMenuItem.Text = "open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // setLinkToToolStripMenuItem1
            // 
            this.setLinkToToolStripMenuItem1.Name = "setLinkToToolStripMenuItem1";
            this.setLinkToToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.setLinkToToolStripMenuItem1.Text = "Set Link to";
            // 
            // moveEntryToolStripMenuItem
            // 
            this.moveEntryToolStripMenuItem.Name = "moveEntryToolStripMenuItem";
            this.moveEntryToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.moveEntryToolStripMenuItem.Text = "move entry";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.buttonQueryhSave);
            this.panelSearch.Controls.Add(this.comboBoxQueries);
            this.panelSearch.Controls.Add(this.buttonQueryClear);
            this.panelSearch.Controls.Add(this.buttonQueryExecute);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Location = new System.Drawing.Point(2, 26);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(608, 28);
            this.panelSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(342, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Queries:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSearch.Location = new System.Drawing.Point(56, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(220, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "<Input SQL like \\\'Album\\\' = \\\'V8-A-1\\\'>";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonQueryhSave
            // 
            this.buttonQueryhSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryhSave.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryhSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryhSave.Image")));
            this.buttonQueryhSave.Location = new System.Drawing.Point(580, 5);
            this.buttonQueryhSave.Name = "buttonQueryhSave";
            this.buttonQueryhSave.Size = new System.Drawing.Size(18, 20);
            this.buttonQueryhSave.TabIndex = 6;
            this.buttonQueryhSave.UseVisualStyleBackColor = false;
            this.buttonQueryhSave.Click += new System.EventHandler(this.buttonQueryhSave_Click);
            // 
            // comboBoxQueries
            // 
            this.comboBoxQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueries.FormattingEnabled = true;
            this.comboBoxQueries.Location = new System.Drawing.Point(393, 5);
            this.comboBoxQueries.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxQueries.Name = "comboBoxQueries";
            this.comboBoxQueries.Size = new System.Drawing.Size(182, 21);
            this.comboBoxQueries.TabIndex = 5;
            this.comboBoxQueries.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueries_SelectedIndexChanged);
            // 
            // buttonQueryClear
            // 
            this.buttonQueryClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryClear.Image")));
            this.buttonQueryClear.Location = new System.Drawing.Point(282, 6);
            this.buttonQueryClear.Name = "buttonQueryClear";
            this.buttonQueryClear.Size = new System.Drawing.Size(18, 20);
            this.buttonQueryClear.TabIndex = 3;
            this.buttonQueryClear.UseVisualStyleBackColor = false;
            this.buttonQueryClear.Click += new System.EventHandler(this.buttonQueryClear_Click);
            // 
            // buttonQueryExecute
            // 
            this.buttonQueryExecute.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryExecute.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryExecute.Image")));
            this.buttonQueryExecute.Location = new System.Drawing.Point(306, 5);
            this.buttonQueryExecute.Name = "buttonQueryExecute";
            this.buttonQueryExecute.Size = new System.Drawing.Size(18, 20);
            this.buttonQueryExecute.TabIndex = 2;
            this.buttonQueryExecute.UseVisualStyleBackColor = false;
            this.buttonQueryExecute.Click += new System.EventHandler(this.buttonQueryExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search: ";
            // 
            // toolStripFile
            // 
            this.toolStripFile.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripFile.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileButtonOpen,
            this.toolStripFileButtonDelete});
            this.toolStripFile.Location = new System.Drawing.Point(521, 0);
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripFile.Size = new System.Drawing.Size(61, 27);
            this.toolStripFile.TabIndex = 6;
            this.toolStripFile.Text = "toolStripFile";
            // 
            // toolStripFileButtonOpen
            // 
            this.toolStripFileButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFileButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFileButtonOpen.Image")));
            this.toolStripFileButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFileButtonOpen.Name = "toolStripFileButtonOpen";
            this.toolStripFileButtonOpen.Size = new System.Drawing.Size(24, 24);
            this.toolStripFileButtonOpen.Text = "toolStripFileButtonOpen";
            this.toolStripFileButtonOpen.Click += new System.EventHandler(this.toolStripFileButtonDelete_Click);
            // 
            // toolStripFileButtonDelete
            // 
            this.toolStripFileButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFileButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFileButtonDelete.Image")));
            this.toolStripFileButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFileButtonDelete.Name = "toolStripFileButtonDelete";
            this.toolStripFileButtonDelete.Size = new System.Drawing.Size(24, 24);
            this.toolStripFileButtonDelete.Text = "toolStripFileButtonDelete";
            this.toolStripFileButtonDelete.Click += new System.EventHandler(this.toolStripFileButtonDelete_Click);
            // 
            // timerImageFlip
            // 
            this.timerImageFlip.Interval = 10000;
            this.timerImageFlip.Tick += new System.EventHandler(this.timerImageFlip_Tick);
            // 
            // imageListTreeView
            // 
            this.imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView.ImageStream")));
            this.imageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeView.Images.SetKeyName(0, "root");
            this.imageListTreeView.Images.SetKeyName(1, "genre");
            this.imageListTreeView.Images.SetKeyName(2, "katalog");
            this.imageListTreeView.Images.SetKeyName(3, "album");
            this.imageListTreeView.Images.SetKeyName(4, "interpret");
            this.imageListTreeView.Images.SetKeyName(5, "playlist");
            // 
            // timerDuration
            // 
            this.timerDuration.Interval = 250;
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // timerShowMyBitmap
            // 
            this.timerShowMyBitmap.Interval = 10000;
            // 
            // MyJukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MyJukebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyJukebox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyJukebox_FormClosing);
            this.Load += new System.EventHandler(this.MyJukebox_Load);
            this.ResizeEnd += new System.EventHandler(this.MyJukebox_ResizeEnd);
            this.Resize += new System.EventHandler(this.MyJukebox_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabLogical.ResumeLayout(false);
            this.tvlogicContextMenuStrip.ResumeLayout(false);
            this.tabPlayLists.ResumeLayout(false);
            this.tabPhysical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarVolume)).EndInit();
            this.toolStripPlayback.ResumeLayout(false);
            this.toolStripPlayback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.datagridContextMenuStrip.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.toolStripFile.ResumeLayout(false);
            this.toolStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainFile;
        private System.Windows.Forms.ToolStripMenuItem menuMainFileExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogical;
        private System.Windows.Forms.TabPage tabPlayLists;
        private System.Windows.Forms.TabPage tabPhysical;
        private System.Windows.Forms.TreeView tvlogic;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem menuMainTools;
        private System.Windows.Forms.ToolStripMenuItem menuMainToolsTest1;
        private System.Windows.Forms.ToolStripMenuItem menuMainEdit;
        private System.Windows.Forms.ToolStripMenuItem menuMainView;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlayback;
        private System.Windows.Forms.ToolStripMenuItem menuMainDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuMainAbout;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.ToolStripMenuItem menuMainToolsTest2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpring1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpring2;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlaybackPlay;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlaybackPause;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlaybackStop;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.Timer timerMusic;
        private System.Windows.Forms.TreeView tvplaylist;
        private System.Windows.Forms.TreeView tvphysical;
        private System.Windows.Forms.ToolStrip toolStripPlayback;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonRandom;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonLoop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TrackBar toolStripPlaybackTrackBarPosition;
        private System.Windows.Forms.TrackBar toolStripPlaybackTrackBarVolume;
        private System.Windows.Forms.ToolStripButton toolStripPlaybackButtonSpeaker;
        private System.Windows.Forms.ToolStripStatusLabel statusStripRow;
        private System.Windows.Forms.ToolStripStatusLabel statusStripKatalog;
        private System.Windows.Forms.ToolStripStatusLabel statusStripGenre;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripRowcount;
        private System.Windows.Forms.ToolStripStatusLabel statusStripTitel;
        private System.Windows.Forms.ToolStripStatusLabel statusStripDuration;
        private System.Windows.Forms.ToolStripStatusLabel statusStripAlbum;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInterpret;
        private System.Windows.Forms.ToolStripStatusLabel statusStripGap1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripGap2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripVersion;
        private System.Windows.Forms.ToolStripStatusLabel statusStripCopyright;
        private System.Windows.Forms.ToolStripStatusLabel statusStripPosition;
        private System.Windows.Forms.ToolTip toolTipVolume;
        private System.Windows.Forms.ToolTip toolTipPosition;
        private System.Windows.Forms.Timer timerImageFlip;
        private System.Windows.Forms.ToolStripMenuItem menuMainEditRecord;
        private System.Windows.Forms.ContextMenuStrip tvlogicContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripCollaps;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripExpand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripAdd;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripNew;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripDelete;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripScanner;
        private System.Windows.Forms.ContextMenuStrip datagridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripCopyToClip;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripSendToNewPlaylist;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripSendToNewKatalog;
        private System.Windows.Forms.ToolStripMenuItem rateItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripRating0;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripRating1;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripRating2;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripRating3;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripRating4;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripRating5;
        private System.Windows.Forms.ToolStripMenuItem beatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripBeatF;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripBeatM;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripBeatS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditRecord;
        private System.Windows.Forms.ToolStripMenuItem setLinkToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetErrorflagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntrysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFilesAndEntrysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLinkToToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveEntryToolStripMenuItem;
        private System.Windows.Forms.Button buttonQueryExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQueryClear;
        private System.Windows.Forms.ComboBox comboBoxQueries;
        private System.Windows.Forms.Button buttonQueryhSave;
        //private System.Windows.Forms.PlaceholderTextBox placeholderTextBoxSearch;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ImageList imageListTreeView;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.ToolStrip toolStripFile;
        private System.Windows.Forms.ToolStripButton toolStripFileButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripFileButtonDelete;
        private System.Windows.Forms.ToolStripMenuItem datagridContextMenuStripSendToPlaylist;
        private System.Windows.Forms.ToolStripMenuItem datagridContextMenuStripSendToKatalog;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Timer timerShowMyBitmap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem importNewSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

