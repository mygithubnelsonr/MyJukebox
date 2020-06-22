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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Knoten1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Knoten0", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyJukebox));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importNewSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMainFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainView = new System.Windows.Forms.ToolStripMenuItem();
            this.hideShowPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlayback = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlaybackPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlaybackPause = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPlaybackStop = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainTools = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainToolsTest1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainToolsTest2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogical = new System.Windows.Forms.TabPage();
            this.tvlogic = new System.Windows.Forms.TreeView();
            this.contextMenuStripTvlogic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvlogicContextMenuStripCollaps = new System.Windows.Forms.ToolStripMenuItem();
            this.tvlogicContextMenuStripExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPlayLists = new System.Windows.Forms.TabPage();
            this.tvplaylist = new System.Windows.Forms.TreeView();
            this.contextMenuStripPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDatagrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDatagridSendToPlaylist = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DatagridContextMenuStripCopyCellToClip = new System.Windows.Forms.ToolStripMenuItem();
            this.DatagridContextMenuStripCopyLineToClip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.setLinkToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetErrorflagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntrysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFilesAndEntrysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLinkToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSpeaker = new System.Windows.Forms.CheckBox();
            this.buttonQueryDelete = new System.Windows.Forms.Button();
            this.panelPlayback = new System.Windows.Forms.Panel();
            this.checkBoxPause = new System.Windows.Forms.CheckBox();
            this.checkBoxShuffel = new System.Windows.Forms.CheckBox();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.buttonPlaybackNext = new System.Windows.Forms.Button();
            this.buttonPlaybackStop = new System.Windows.Forms.Button();
            this.buttonPlaybackPlay = new System.Windows.Forms.Button();
            this.buttonQueryhSave = new System.Windows.Forms.Button();
            this.toolStripPlaybackTrackBarPosition = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripPlaybackTrackBarVolume = new System.Windows.Forms.TrackBar();
            this.comboBoxQueries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonQueryClear = new System.Windows.Forms.Button();
            this.buttonQueryExecute = new System.Windows.Forms.Button();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.toolTipVolume = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPosition = new System.Windows.Forms.ToolTip(this.components);
            this.timerImageFlip = new System.Windows.Forms.Timer(this.components);
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.timerShowMyBitmap = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.menuMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabLogical.SuspendLayout();
            this.contextMenuStripTvlogic.SuspendLayout();
            this.tabPlayLists.SuspendLayout();
            this.contextMenuStripPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStripDatagrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPlayback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
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
            this.menuMainAbout});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(916, 24);
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
            this.menuMainView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideShowPanelToolStripMenuItem});
            this.menuMainView.Name = "menuMainView";
            this.menuMainView.Size = new System.Drawing.Size(44, 20);
            this.menuMainView.Text = "View";
            // 
            // hideShowPanelToolStripMenuItem
            // 
            this.hideShowPanelToolStripMenuItem.Name = "hideShowPanelToolStripMenuItem";
            this.hideShowPanelToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.hideShowPanelToolStripMenuItem.Text = "Hide / Show Panel";
            this.hideShowPanelToolStripMenuItem.Click += new System.EventHandler(this.hideShowPanelToolStripMenuItem_Click);
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
            this.parametersToolStripMenuItem,
            this.menuMainToolsTest1,
            this.menuMainToolsTest2});
            this.menuMainTools.Name = "menuMainTools";
            this.menuMainTools.Size = new System.Drawing.Size(46, 20);
            this.menuMainTools.Text = "Tools";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // menuMainToolsTest1
            // 
            this.menuMainToolsTest1.Name = "menuMainToolsTest1";
            this.menuMainToolsTest1.Size = new System.Drawing.Size(133, 22);
            this.menuMainToolsTest1.Text = "Test only 1";
            this.menuMainToolsTest1.Click += new System.EventHandler(this.menuMainToolsTest1_Click);
            // 
            // menuMainToolsTest2
            // 
            this.menuMainToolsTest2.Name = "menuMainToolsTest2";
            this.menuMainToolsTest2.Size = new System.Drawing.Size(133, 22);
            this.menuMainToolsTest2.Text = "Test only 2";
            this.menuMainToolsTest2.Click += new System.EventHandler(this.menuMainToolsTest2_Click);
            // 
            // menuMainAbout
            // 
            this.menuMainAbout.Name = "menuMainAbout";
            this.menuMainAbout.Size = new System.Drawing.Size(52, 20);
            this.menuMainAbout.Text = "About";
            this.menuMainAbout.Click += new System.EventHandler(this.menuMainAbout_Click);
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
            this.statusStrip.Size = new System.Drawing.Size(916, 28);
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
            this.statusStripTitel.Size = new System.Drawing.Size(193, 23);
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.splitContainer1.Panel2MinSize = 220;
            this.splitContainer1.Size = new System.Drawing.Size(916, 509);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterIncrement = 6;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.pictureBoxFoto.Location = new System.Drawing.Point(-1, 380);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(235, 125);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 1;
            this.pictureBoxFoto.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabLogical);
            this.tabControl.Controls.Add(this.tabPlayLists);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(229, 244);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabLogical
            // 
            this.tabLogical.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabLogical.Controls.Add(this.tvlogic);
            this.tabLogical.Location = new System.Drawing.Point(4, 24);
            this.tabLogical.Name = "tabLogical";
            this.tabLogical.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogical.Size = new System.Drawing.Size(221, 216);
            this.tabLogical.TabIndex = 0;
            this.tabLogical.Text = "Logical";
            this.tabLogical.UseVisualStyleBackColor = true;
            // 
            // tvlogic
            // 
            this.tvlogic.BackColor = System.Drawing.Color.LightSlateGray;
            this.tvlogic.ContextMenuStrip = this.contextMenuStripTvlogic;
            this.tvlogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvlogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvlogic.ForeColor = System.Drawing.Color.Gold;
            this.tvlogic.FullRowSelect = true;
            this.tvlogic.LineColor = System.Drawing.Color.Gold;
            this.tvlogic.Location = new System.Drawing.Point(3, 3);
            this.tvlogic.Name = "tvlogic";
            treeNode5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode5.ForeColor = System.Drawing.Color.Gold;
            treeNode5.Name = "Knoten1";
            treeNode5.Text = "Knoten1";
            treeNode6.Name = "Knoten0";
            treeNode6.Text = "Knoten0";
            this.tvlogic.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvlogic.ShowNodeToolTips = true;
            this.tvlogic.Size = new System.Drawing.Size(215, 210);
            this.tvlogic.TabIndex = 0;
            this.tvlogic.Click += new System.EventHandler(this.tvlogic_Click);
            this.tvlogic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvlogic_MouseDown);
            // 
            // contextMenuStripTvlogic
            // 
            this.contextMenuStripTvlogic.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTvlogic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tvlogicContextMenuStripCollaps,
            this.tvlogicContextMenuStripExpand});
            this.contextMenuStripTvlogic.Name = "tvlogicContextMenuStrip";
            this.contextMenuStripTvlogic.Size = new System.Drawing.Size(114, 48);
            // 
            // tvlogicContextMenuStripCollaps
            // 
            this.tvlogicContextMenuStripCollaps.Name = "tvlogicContextMenuStripCollaps";
            this.tvlogicContextMenuStripCollaps.Size = new System.Drawing.Size(113, 22);
            this.tvlogicContextMenuStripCollaps.Text = "Collaps";
            // 
            // tvlogicContextMenuStripExpand
            // 
            this.tvlogicContextMenuStripExpand.Name = "tvlogicContextMenuStripExpand";
            this.tvlogicContextMenuStripExpand.Size = new System.Drawing.Size(113, 22);
            this.tvlogicContextMenuStripExpand.Text = "Expand";
            // 
            // tabPlayLists
            // 
            this.tabPlayLists.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPlayLists.Controls.Add(this.tvplaylist);
            this.tabPlayLists.Location = new System.Drawing.Point(4, 24);
            this.tabPlayLists.Name = "tabPlayLists";
            this.tabPlayLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayLists.Size = new System.Drawing.Size(221, 216);
            this.tabPlayLists.TabIndex = 1;
            this.tabPlayLists.Text = "Playlists";
            // 
            // tvplaylist
            // 
            this.tvplaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvplaylist.BackColor = System.Drawing.Color.LightSlateGray;
            this.tvplaylist.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.tvplaylist.ForeColor = System.Drawing.Color.Gold;
            this.tvplaylist.Location = new System.Drawing.Point(3, 3);
            this.tvplaylist.Name = "tvplaylist";
            treeNode1.BackColor = System.Drawing.Color.Blue;
            treeNode1.ForeColor = System.Drawing.Color.Gold;
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.ForeColor = System.Drawing.Color.Gold;
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.tvplaylist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvplaylist.Size = new System.Drawing.Size(218, 215);
            this.tvplaylist.TabIndex = 0;
            this.tvplaylist.Click += new System.EventHandler(this.tvplaylist_Click);
            this.tvplaylist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvplaylist_MouseDown);
            // 
            // contextMenuStripPlaylist
            // 
            this.contextMenuStripPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemRemove,
            this.toolStripMenuItemRename});
            this.contextMenuStripPlaylist.Name = "contextMenuStripPlaylist";
            this.contextMenuStripPlaylist.Size = new System.Drawing.Size(162, 70);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemAdd.Text = "Add new Playlist";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.contextPlaylistMenuItemAdd_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemRemove.Text = "Remove Playlist";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // toolStripMenuItemRename
            // 
            this.toolStripMenuItemRename.Name = "toolStripMenuItemRename";
            this.toolStripMenuItemRename.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemRename.Text = "Rename Playlist";
            this.toolStripMenuItemRename.Click += new System.EventHandler(this.toolStripMenuItemRename_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.ColumnHeadersHeight = 28;
            this.dataGridView.ContextMenuStrip = this.contextMenuStripDatagrid;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 71);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowHeadersWidth = 20;
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(670, 438);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.EditModeChanged += new System.EventHandler(this.dataGridView_EditModeChanged);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnWidthChanged);
            this.dataGridView.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_RowHeightChanged);
            this.dataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView_Scroll);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // contextMenuStripDatagrid
            // 
            this.contextMenuStripDatagrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDatagrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSendTo,
            this.rateItemsToolStripMenuItem,
            this.beatToolStripMenuItem,
            this.DatagridContextMenuStripCopyCellToClip,
            this.DatagridContextMenuStripCopyLineToClip,
            this.toolStripMenuItemEditRecord,
            this.setLinkToToolStripMenuItem,
            this.resetErrorflagToolStripMenuItem,
            this.deleteEntrysToolStripMenuItem,
            this.deleteFilesAndEntrysToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.setLinkToToolStripMenuItem1,
            this.moveEntryToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStripDatagrid.Name = "DatagridContextMenuStrip";
            this.contextMenuStripDatagrid.Size = new System.Drawing.Size(208, 312);
            // 
            // toolStripMenuItemSendTo
            // 
            this.toolStripMenuItemSendTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStripDatagridSendToPlaylist,
            this.DatagridContextMenuStripSendToNewPlaylist,
            this.datagridContextMenuStripSendToKatalog,
            this.DatagridContextMenuStripSendToNewKatalog});
            this.toolStripMenuItemSendTo.Name = "toolStripMenuItemSendTo";
            this.toolStripMenuItemSendTo.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuItemSendTo.Text = "Send to";
            // 
            // contextMenuStripDatagridSendToPlaylist
            // 
            this.contextMenuStripDatagridSendToPlaylist.Name = "contextMenuStripDatagridSendToPlaylist";
            this.contextMenuStripDatagridSendToPlaylist.Size = new System.Drawing.Size(141, 22);
            this.contextMenuStripDatagridSendToPlaylist.Text = "Playlist";
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
            // DatagridContextMenuStripCopyCellToClip
            // 
            this.DatagridContextMenuStripCopyCellToClip.Name = "DatagridContextMenuStripCopyCellToClip";
            this.DatagridContextMenuStripCopyCellToClip.Size = new System.Drawing.Size(207, 22);
            this.DatagridContextMenuStripCopyCellToClip.Text = "Copy Cell to Clip";
            this.DatagridContextMenuStripCopyCellToClip.Click += new System.EventHandler(this.datagridContextMenuStripCopyToClip_Click);
            // 
            // DatagridContextMenuStripCopyLineToClip
            // 
            this.DatagridContextMenuStripCopyLineToClip.Name = "DatagridContextMenuStripCopyLineToClip";
            this.DatagridContextMenuStripCopyLineToClip.Size = new System.Drawing.Size(207, 22);
            this.DatagridContextMenuStripCopyLineToClip.Text = "Copy Line to Clip";
            this.DatagridContextMenuStripCopyLineToClip.Click += new System.EventHandler(this.DatagridContextMenuStripCopyLineToClip_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSpeaker);
            this.panel1.Controls.Add(this.buttonQueryDelete);
            this.panel1.Controls.Add(this.panelPlayback);
            this.panel1.Controls.Add(this.buttonQueryhSave);
            this.panel1.Controls.Add(this.toolStripPlaybackTrackBarPosition);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.toolStripPlaybackTrackBarVolume);
            this.panel1.Controls.Add(this.comboBoxQueries);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonQueryClear);
            this.panel1.Controls.Add(this.buttonQueryExecute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 71);
            this.panel1.TabIndex = 7;
            // 
            // checkBoxSpeaker
            // 
            this.checkBoxSpeaker.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSpeaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxSpeaker.BackgroundImage")));
            this.checkBoxSpeaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxSpeaker.FlatAppearance.BorderSize = 0;
            this.checkBoxSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSpeaker.Location = new System.Drawing.Point(263, 7);
            this.checkBoxSpeaker.Name = "checkBoxSpeaker";
            this.checkBoxSpeaker.Size = new System.Drawing.Size(24, 24);
            this.checkBoxSpeaker.TabIndex = 26;
            this.checkBoxSpeaker.UseVisualStyleBackColor = true;
            this.checkBoxSpeaker.CheckedChanged += new System.EventHandler(this.checkBoxSpeaker_CheckedChanged);
            // 
            // buttonQueryDelete
            // 
            this.buttonQueryDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQueryDelete.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryDelete.BackgroundImage = global::MyJukebox_EF.Properties.Resources.delete;
            this.buttonQueryDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQueryDelete.Location = new System.Drawing.Point(642, 39);
            this.buttonQueryDelete.Name = "buttonQueryDelete";
            this.buttonQueryDelete.Size = new System.Drawing.Size(24, 24);
            this.buttonQueryDelete.TabIndex = 25;
            this.buttonQueryDelete.UseVisualStyleBackColor = false;
            this.buttonQueryDelete.Click += new System.EventHandler(this.buttonQueryDelete_Click);
            // 
            // panelPlayback
            // 
            this.panelPlayback.Controls.Add(this.checkBoxPause);
            this.panelPlayback.Controls.Add(this.checkBoxShuffel);
            this.panelPlayback.Controls.Add(this.checkBoxLoop);
            this.panelPlayback.Controls.Add(this.buttonPlaybackNext);
            this.panelPlayback.Controls.Add(this.buttonPlaybackStop);
            this.panelPlayback.Controls.Add(this.buttonPlaybackPlay);
            this.panelPlayback.Location = new System.Drawing.Point(6, 5);
            this.panelPlayback.Name = "panelPlayback";
            this.panelPlayback.Size = new System.Drawing.Size(230, 31);
            this.panelPlayback.TabIndex = 23;
            // 
            // checkBoxPause
            // 
            this.checkBoxPause.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPause.BackgroundImage = global::MyJukebox_EF.Properties.Resources.Playback_Pause;
            this.checkBoxPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxPause.FlatAppearance.BorderSize = 0;
            this.checkBoxPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPause.Location = new System.Drawing.Point(37, 1);
            this.checkBoxPause.Name = "checkBoxPause";
            this.checkBoxPause.Size = new System.Drawing.Size(28, 28);
            this.checkBoxPause.TabIndex = 28;
            this.checkBoxPause.UseVisualStyleBackColor = true;
            this.checkBoxPause.CheckedChanged += new System.EventHandler(this.checkBoxPause_CheckedChanged);
            // 
            // checkBoxShuffel
            // 
            this.checkBoxShuffel.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShuffel.BackgroundImage = global::MyJukebox_EF.Properties.Resources.Playback_Shuffel;
            this.checkBoxShuffel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxShuffel.FlatAppearance.BorderSize = 0;
            this.checkBoxShuffel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShuffel.Location = new System.Drawing.Point(160, 1);
            this.checkBoxShuffel.Name = "checkBoxShuffel";
            this.checkBoxShuffel.Size = new System.Drawing.Size(28, 28);
            this.checkBoxShuffel.TabIndex = 27;
            this.checkBoxShuffel.UseVisualStyleBackColor = true;
            this.checkBoxShuffel.CheckedChanged += new System.EventHandler(this.checkBoxShuffel_CheckedChanged);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLoop.BackgroundImage = global::MyJukebox_EF.Properties.Resources.Playback_Loop;
            this.checkBoxLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxLoop.FlatAppearance.BorderSize = 0;
            this.checkBoxLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLoop.Location = new System.Drawing.Point(191, 1);
            this.checkBoxLoop.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(28, 28);
            this.checkBoxLoop.TabIndex = 26;
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // buttonPlaybackNext
            // 
            this.buttonPlaybackNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlaybackNext.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonPlaybackNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlaybackNext.BackgroundImage")));
            this.buttonPlaybackNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlaybackNext.FlatAppearance.BorderSize = 0;
            this.buttonPlaybackNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaybackNext.Location = new System.Drawing.Point(105, 1);
            this.buttonPlaybackNext.Name = "buttonPlaybackNext";
            this.buttonPlaybackNext.Size = new System.Drawing.Size(28, 28);
            this.buttonPlaybackNext.TabIndex = 23;
            this.buttonPlaybackNext.TabStop = false;
            this.buttonPlaybackNext.Tag = "false";
            this.buttonPlaybackNext.UseVisualStyleBackColor = false;
            this.buttonPlaybackNext.Click += new System.EventHandler(this.buttonPlaybackNext_Click);
            // 
            // buttonPlaybackStop
            // 
            this.buttonPlaybackStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlaybackStop.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonPlaybackStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlaybackStop.BackgroundImage")));
            this.buttonPlaybackStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlaybackStop.FlatAppearance.BorderSize = 0;
            this.buttonPlaybackStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaybackStop.Location = new System.Drawing.Point(71, 1);
            this.buttonPlaybackStop.Name = "buttonPlaybackStop";
            this.buttonPlaybackStop.Size = new System.Drawing.Size(28, 28);
            this.buttonPlaybackStop.TabIndex = 22;
            this.buttonPlaybackStop.Tag = "false";
            this.buttonPlaybackStop.UseVisualStyleBackColor = false;
            this.buttonPlaybackStop.Click += new System.EventHandler(this.buttonPlaybackStop_Click);
            // 
            // buttonPlaybackPlay
            // 
            this.buttonPlaybackPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlaybackPlay.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonPlaybackPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlaybackPlay.BackgroundImage")));
            this.buttonPlaybackPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlaybackPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlaybackPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaybackPlay.Location = new System.Drawing.Point(3, 1);
            this.buttonPlaybackPlay.Name = "buttonPlaybackPlay";
            this.buttonPlaybackPlay.Size = new System.Drawing.Size(28, 28);
            this.buttonPlaybackPlay.TabIndex = 21;
            this.buttonPlaybackPlay.TabStop = false;
            this.buttonPlaybackPlay.Tag = "false";
            this.buttonPlaybackPlay.UseVisualStyleBackColor = false;
            this.buttonPlaybackPlay.Click += new System.EventHandler(this.buttonPlaybackPlay_Click);
            // 
            // buttonQueryhSave
            // 
            this.buttonQueryhSave.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryhSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryhSave.Image")));
            this.buttonQueryhSave.Location = new System.Drawing.Point(342, 39);
            this.buttonQueryhSave.Name = "buttonQueryhSave";
            this.buttonQueryhSave.Size = new System.Drawing.Size(24, 24);
            this.buttonQueryhSave.TabIndex = 6;
            this.buttonQueryhSave.UseVisualStyleBackColor = false;
            this.buttonQueryhSave.Click += new System.EventHandler(this.buttonQuerySave_Click);
            // 
            // toolStripPlaybackTrackBarPosition
            // 
            this.toolStripPlaybackTrackBarPosition.AutoSize = false;
            this.toolStripPlaybackTrackBarPosition.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripPlaybackTrackBarPosition.Location = new System.Drawing.Point(416, 12);
            this.toolStripPlaybackTrackBarPosition.Maximum = 100;
            this.toolStripPlaybackTrackBarPosition.Name = "toolStripPlaybackTrackBarPosition";
            this.toolStripPlaybackTrackBarPosition.Size = new System.Drawing.Size(112, 18);
            this.toolStripPlaybackTrackBarPosition.TabIndex = 5;
            this.toolStripPlaybackTrackBarPosition.TickFrequency = 10;
            this.toolTipPosition.SetToolTip(this.toolStripPlaybackTrackBarPosition, "Position");
            this.toolStripPlaybackTrackBarPosition.Scroll += new System.EventHandler(this.trackBarPosition_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(398, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Queries:";
            // 
            // toolStripPlaybackTrackBarVolume
            // 
            this.toolStripPlaybackTrackBarVolume.AutoSize = false;
            this.toolStripPlaybackTrackBarVolume.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripPlaybackTrackBarVolume.Location = new System.Drawing.Point(285, 12);
            this.toolStripPlaybackTrackBarVolume.Maximum = 100;
            this.toolStripPlaybackTrackBarVolume.Name = "toolStripPlaybackTrackBarVolume";
            this.toolStripPlaybackTrackBarVolume.Size = new System.Drawing.Size(112, 18);
            this.toolStripPlaybackTrackBarVolume.TabIndex = 4;
            this.toolStripPlaybackTrackBarVolume.TickFrequency = 10;
            this.toolTipVolume.SetToolTip(this.toolStripPlaybackTrackBarVolume, "Volume");
            this.toolStripPlaybackTrackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            this.toolStripPlaybackTrackBarVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripPlaybackTrackBarVolume_MouseUp);
            // 
            // comboBoxQueries
            // 
            this.comboBoxQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueries.FormattingEnabled = true;
            this.comboBoxQueries.Location = new System.Drawing.Point(449, 42);
            this.comboBoxQueries.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxQueries.Name = "comboBoxQueries";
            this.comboBoxQueries.Size = new System.Drawing.Size(182, 21);
            this.comboBoxQueries.TabIndex = 5;
            this.comboBoxQueries.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSearch.Location = new System.Drawing.Point(51, 44);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(220, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "  <Input SQL like \'Album\' = \'V8-A-1\'>";
            this.toolTipSearch.SetToolTip(this.textBoxSearch, "Query Samples:\r\nlike \'Album\' = \'V8-A-1\'\r\n*=johnny");
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonQueryClear
            // 
            this.buttonQueryClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryClear.BackgroundImage = global::MyJukebox_EF.Properties.Resources.edit_clear;
            this.buttonQueryClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQueryClear.Location = new System.Drawing.Point(282, 39);
            this.buttonQueryClear.Name = "buttonQueryClear";
            this.buttonQueryClear.Size = new System.Drawing.Size(24, 24);
            this.buttonQueryClear.TabIndex = 3;
            this.buttonQueryClear.UseVisualStyleBackColor = false;
            this.buttonQueryClear.Click += new System.EventHandler(this.buttonQueryClear_Click);
            // 
            // buttonQueryExecute
            // 
            this.buttonQueryExecute.BackColor = System.Drawing.Color.LightGray;
            this.buttonQueryExecute.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryExecute.Image")));
            this.buttonQueryExecute.Location = new System.Drawing.Point(312, 39);
            this.buttonQueryExecute.Name = "buttonQueryExecute";
            this.buttonQueryExecute.Size = new System.Drawing.Size(24, 24);
            this.buttonQueryExecute.TabIndex = 2;
            this.buttonQueryExecute.UseVisualStyleBackColor = false;
            this.buttonQueryExecute.Click += new System.EventHandler(this.buttonQueryExecute_Click);
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
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 256);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(228, 169);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_StatusChange);
            this.axWindowsMediaPlayer1.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.axWindowsMediaPlayer1_EndOfStream);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // toolTipSearch
            // 
            this.toolTipSearch.AutomaticDelay = 200;
            this.toolTipSearch.AutoPopDelay = 5000;
            this.toolTipSearch.InitialDelay = 200;
            this.toolTipSearch.ReshowDelay = 40;
            // 
            // MyJukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 561);
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
            this.Shown += new System.EventHandler(this.MyJukebox_Shown);
            this.ResizeEnd += new System.EventHandler(this.MyJukebox_ResizeEnd);
            this.Resize += new System.EventHandler(this.MyJukebox_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabLogical.ResumeLayout(false);
            this.contextMenuStripTvlogic.ResumeLayout(false);
            this.tabPlayLists.ResumeLayout(false);
            this.contextMenuStripPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStripDatagrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlayback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolStripPlaybackTrackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainFile;
        private System.Windows.Forms.ToolStripMenuItem menuMainFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuMainTools;
        private System.Windows.Forms.ToolStripMenuItem menuMainToolsTest1;
        private System.Windows.Forms.ToolStripMenuItem menuMainEdit;
        private System.Windows.Forms.ToolStripMenuItem menuMainView;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlayback;
        private System.Windows.Forms.ToolStripMenuItem menuMainAbout;
        private System.Windows.Forms.ToolStripMenuItem menuMainToolsTest2;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlaybackPlay;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlaybackPause;
        private System.Windows.Forms.ToolStripMenuItem menuMainPlaybackStop;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMainEditRecord;




        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpring1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpring2;
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

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogical;
        private System.Windows.Forms.TabPage tabPlayLists;
        private System.Windows.Forms.TreeView tvlogic;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Timer timerMusic;
        private System.Windows.Forms.TreeView tvplaylist;
        private System.Windows.Forms.TrackBar toolStripPlaybackTrackBarPosition;
        private System.Windows.Forms.TrackBar toolStripPlaybackTrackBarVolume;
        private System.Windows.Forms.ToolTip toolTipVolume;
        private System.Windows.Forms.ToolTip toolTipPosition;
        private System.Windows.Forms.Timer timerImageFlip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTvlogic;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripCollaps;
        private System.Windows.Forms.ToolStripMenuItem tvlogicContextMenuStripExpand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDatagrid;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripCopyCellToClip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSendTo;
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
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripDatagridSendToPlaylist;
        private System.Windows.Forms.ToolStripMenuItem datagridContextMenuStripSendToKatalog;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Timer timerShowMyBitmap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem importNewSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatagridContextMenuStripCopyLineToClip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRename;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPlayback;
        private System.Windows.Forms.Button buttonPlaybackNext;
        private System.Windows.Forms.Button buttonPlaybackStop;
        private System.Windows.Forms.Button buttonPlaybackPlay;
        private System.Windows.Forms.Button buttonQueryDelete;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.CheckBox checkBoxShuffel;
        private System.Windows.Forms.CheckBox checkBoxPause;
        private System.Windows.Forms.ToolStripMenuItem hideShowPanelToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxSpeaker;
        private System.Windows.Forms.ToolTip toolTipSearch;
    }
}

