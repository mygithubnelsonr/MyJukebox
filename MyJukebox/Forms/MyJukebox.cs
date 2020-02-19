using MyJukebox_EF.BLL;
using NRSoft.FunctionPool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace MyJukebox_EF
{
    public partial class MyJukebox : Form
    {
        #region fields

        private bool _isloop = false;
        private bool _isSetting = false;
        private bool _tvFilled = false;
        private double _duration = 0;
        private bool _buttonStop = true;
        private bool _isPlaying = false;

        private TreeNode rootNode;
        private TreeNode currentTreeNode;
        private TreeNode lastSelectedTreeNode;

        // FunctionPool functions
        private RandomH random = new RandomH();

        private List<string> artistImageFiles;

        #endregion fields

        #region CTor

        public MyJukebox()
        {
            InitializeComponent();
            Colors.Initialize();
            MyJukebox_Initialize();
        }

        #endregion CTor

        #region Form Main

        #region Form Main Event Handler

        private async void MyJukebox_Load(object sender, EventArgs e)
        {
            SettingsDb.Load();

            var currentDatagrigRow = 1;
            var lastQuery = DataGetSet.GetSetting("LastQuery").ToString();

            #region restore last window properties

            Top = SettingsDb.FormTop;
            Left = SettingsDb.FormLeft;
            Width = SettingsDb.FormWidth;
            Height = SettingsDb.FormHeight;

            WindowState = (FormWindowState)SettingsDb.Formstate(SettingsDb.FormState);

            #endregion restore last window properties

            #region restote TreeviewLogicStates

            TreeViewLogicStates.Album = DataGetSet.GetSetting("LastAlbum", "").ToString();
            TreeViewLogicStates.Catalog = DataGetSet.GetSetting("LastCatalog", "").ToString();
            TreeViewLogicStates.Genre = DataGetSet.GetSetting("LastGenre", "").ToString();
            TreeViewLogicStates.Interpret = DataGetSet.GetSetting("LastInterpret", "").ToString();

            #endregion restote TreeviewStates

            #region restore query

            Common.TextBoxSearchClear(textBoxSearch);

            FillQueryCombo();

            //if (!string.IsNullOrEmpty(Settings.QueryLastQuery))
            //{
            //    textBoxSearch.Text = Settings.QueryLastQuery;
            //    textBoxSearch.ForeColor = Colors.Standard;
            //}

            #endregion restore query

            #region initialize TreeView

            tvlogicInitialize();
            tvplaylistInitialize();

            #endregion initialize TreeView

            menuMainFileExit.Tag = "0";    // if not 1 then prompt a message to the user

            TreeviewsFirstFill();
            FillDatagridView(lastQuery);

            statusStripVersion.Text = DataGetSet.GetSetting("Version").ToString();
            if (Convert.ToBoolean(DataGetSet.GetSetting("IsRandom")))
                toolStripPlaybackButtonRandom.BackColor = Color.LightSteelBlue;

            toolStripPlaybackTrackBarVolume.Value = Convert.ToInt16(DataGetSet.GetSetting("Volume"));
            trackBarVolume_Scroll(this, EventArgs.Empty);

            int lastSelectedTab = Convert.ToInt32(DataGetSet.GetSetting("LastSelectedTab"));
            tabControl.SelectedTab = tabControl.TabPages[lastSelectedTab];

            if (lastSelectedTab == (int)TabcontrolTab.Logical)
            {
                statusStripGenre.Text = TreeViewLogicStates.Genre;
                statusStripKatalog.Text = TreeViewLogicStates.Catalog;
                statusStripAlbum.Text = TreeViewLogicStates.Album;
                statusStripInterpret.Text = TreeViewLogicStates.Interpret;
                currentDatagrigRow = SettingsDb.DatagridLastSelectedRow;
            }

            if (lastSelectedTab == (int)TabcontrolTab.Playlist)
            {
                tvplaylist.ExpandAll();
                statusStripGenre.Text = "";
                statusStripKatalog.Text = "";
                statusStripAlbum.Text = "";
                statusStripInterpret.Text = "";

                int currentPlaylist = DataGetSet.GetLastselectedPlaylist();
                currentDatagrigRow = DataGetSet.GetLastselectedPlaylistRow(currentPlaylist);

                PlaylistInfo playlist = DataGetSet.GetPlaylistInfos(currentPlaylist);

                TreeviewFindNodeByText(tvplaylist.Nodes["root"], playlist.Name, true, true);


            }

            pictureBoxFoto.Image = Properties.Resources.MyBitmap;
            splitContainer1.SplitterDistance = Convert.ToInt32(DataGetSet.GetSetting("FormSplitterLeft"));
        }

        private void MyJukebox_Resize(object sender, EventArgs e)
        {
            this.Update();
        }

        private void MyJukebox_ResizeEnd(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = Convert.ToInt32(DataGetSet.GetSetting("FormSplitterLeft", "200"));
        }

        private void MyJukebox_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save window metrics
            DataGetSet.SetSetting("FormTop", Top.ToString());
            DataGetSet.SetSetting("FormLeft", Left.ToString());
            DataGetSet.SetSetting("FormWidth", Width.ToString());
            DataGetSet.SetSetting("FormHeight", Height.ToString());
            DataGetSet.SetSetting("FormState", WindowState.ToString());
            DataGetSet.SetSetting("FormSplitterLeft", splitContainer1.SplitterDistance.ToString());

            // save dataGridView.Columns widht
            foreach (DataGridViewColumn column in dataGridView.Columns)
                DataGetSet.SetColumnWidth(column.Name, column.Width);

            // save query list entries
            var result = DataGetSet.TruncateTableQueries();

            if (result == true)
            {
                foreach (var q in comboBoxQueries.Items)
                {
                    if (q.ToString() != "")
                        DataGetSet.SetQueries(q.ToString());
                }
            }
            else
            {
                Debug.Print("truncate table tQueries failed!");
            }

            // save treeview logic states
            DataGetSet.SetSetting("LastGenre", TreeViewLogicStates.Genre);
            DataGetSet.SetSetting("LastCatalog", TreeViewLogicStates.Catalog);
            DataGetSet.SetSetting("LastAlbum", TreeViewLogicStates.Album);
            DataGetSet.SetSetting("LastInterpret", TreeViewLogicStates.Interpret);

            SettingsDb.Save();
        }

        private void TreeviewsFirstFill()
        {
            // fill treeview with last results
            tvlogicFillGenreAsync();

            tvlogicFillCatalogAsync();

            tvlogicFillAlbumAsync();

            tvlogicFillInterpretAsync();

            tvplaylistFillPlaylist();

            _tvFilled = true;
        }

        private async Task TreeviewsFirstFillAsync()
        {
            // fill treeview with last results
            await tvlogicFillGenreAsync();

            await tvlogicFillCatalogAsync();

            await tvlogicFillAlbumAsync();

            await tvlogicFillInterpretAsync();

            await tvplaylistFillPlaylist();

            _tvFilled = true;
        }

        #endregion Form Main Event Handler

        #region Form Main Methodes

        private void MyJukebox_Initialize()
        {
            SettingsDb.Initalaze();
            DataGetSet.SetSetting("LastRunDate", DateTime.UtcNow.ToString());
        }

        #endregion Form Main Methodes

        #endregion Form Main

        #region Menu Main

        #region Menu Event Handlers

        private void toolStripMenuItemimportNewSongs_Click(object sender, EventArgs e)
        {
            Filescanner filescanner = new Filescanner();
            filescanner.Show();
        }

        private void menuMainFileExit_Click(object sender, EventArgs e)
        {
            this.menuMainFileExit.Tag = "1";
            this.Close();
        }

        private void menuMainToolsTest1_Click(object sender, EventArgs e)
        {
            var row = SettingsDb.DatagridLastSelectedRow;

            dataGridView.Rows[row].Selected = true;

        }

        private void menuMainToolsTest2_Click(object sender, EventArgs e)
        {

        }

        private void menuMainEditRecord_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

            EditRecord editRecord = new EditRecord(id);
            editRecord.Show();

            refreshToolStripMenuItem.PerformClick();
        }

        private void menuMainPlaybackPlay_Click(object sender, EventArgs e)
        {
            toolStripPlaybackButtonPlay.PerformClick();
        }

        private void menuMainPlaybackPause_Click(object sender, EventArgs e)
        {
            toolStripPlaybackButtonPlay.PerformClick();
        }

        private void menuMainPlaybackStop_Click(object sender, EventArgs e)
        {
            toolStripPlaybackButtonStop.PerformClick();
        }

        #endregion Menu Event Handlers

        #endregion Menu Main

        #region Treeview tvlogic

        #region Treeview tvlogic Event Handlers

        private void tvlogic_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (_tvFilled == false) return;

            if (e.Node.Name == "genre")
                tvlogicFillGenreAsync();

            if (e.Node.Name == "katalog")
                tvlogicFillCatalogAsync();

            if (e.Node.Name == "album")
                tvlogicFillAlbumAsync();

            if (e.Node.Name == "interpret")
                tvlogicFillInterpretAsync();
        }

        private void tvlogic_MouseDown(object sender, MouseEventArgs e)
        {
            currentTreeNode = tvlogic.GetNodeAt(e.X, e.Y);
        }

        private void tvlogic_Click(object sender, EventArgs e)
        {
            Debug.Print("tvlogic_Click");
            Common.TextBoxSearchClear(textBoxSearch);

            string mainNode = "";

            if (_isPlaying)
            {
                BeginInvoke(new Action(() => { toolStripPlaybackButtonStop.PerformClick(); }));
            }

            // check if node have children
            if (currentTreeNode.FirstNode != null)
            {
                if (lastSelectedTreeNode != null)
                    tvlogic.SelectedNode = lastSelectedTreeNode;
                else
                    tvlogic.SelectedNode = rootNode.Nodes["genre_country"];

                return;
            }

            if (currentTreeNode.FirstNode == null)
            {
                tvlogic.SelectedNode = currentTreeNode;
                tvlogic.SelectedNode.BackColor = Color.DodgerBlue;
                tvlogic.SelectedNode.ForeColor = Color.Gold;
                currentTreeNode = tvlogic.SelectedNode;
            }
            else
            {
                return;
            }

            mainNode = currentTreeNode.Parent.Name;

            // do nothing if selected node is allready selected
            if (mainNode == "genre" && currentTreeNode.Text == TreeViewLogicStates.Genre) return;
            if (mainNode == "katalog" && currentTreeNode.Text == TreeViewLogicStates.Catalog) return;
            if (mainNode == "album" && currentTreeNode.Text == TreeViewLogicStates.Album) return;
            if (mainNode == "interpret" && currentTreeNode.Text == TreeViewLogicStates.Interpret) return;

            if (mainNode == "katalog" || mainNode == "genre")
            {
                DataGetSet.SetSetting("LastKatalog", "");
                TreeViewLogicStates.Catalog = "";

                tvlogicFillAlbumAsync();
                tvlogicFillInterpretAsync();
            }

            if (mainNode == "genre")
            {
                TreeViewLogicStates.Genre = statusStripGenre.Text = currentTreeNode.Text;
                DataGetSet.SetSetting("LastGenre", currentTreeNode.Text);

                TreeviewFindNodeByText(currentTreeNode.Parent, TreeViewLogicStates.Genre, true, true);
                tvlogicFillCatalogAsync();
            }

            if (mainNode == "katalog")
            {
                var catalog = currentTreeNode.Text == "Alle" ? "" : currentTreeNode.Text;

                DataGetSet.SetSetting("LastCatalog", catalog);
                DataGetSet.SetSetting("LastAlbum", "");
                DataGetSet.SetSetting("LastInterpret", "");

                TreeViewLogicStates.Catalog = catalog;
                TreeViewLogicStates.Album = "";
                TreeViewLogicStates.Interpret = "";

                TreeviewFindNodeByText(currentTreeNode.Parent, catalog, true, true);
                TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["album"], "Alle", true, true);
                TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["interpret"], "Alle", true, true);

                statusStripKatalog.Text = currentTreeNode.Text;
                statusStripAlbum.Text = "Alle";
                statusStripInterpret.Text = "Alle";

                tvlogicFillAlbumAsync();
                tvlogicFillInterpretAsync();
            }

            if (mainNode == "album")
            {
                var album = currentTreeNode.Text == "Alle" ? "" : currentTreeNode.Text;

                DataGetSet.SetSetting("LastAlbum", album);
                DataGetSet.SetSetting("LastInterpret", "");
                TreeViewLogicStates.Album = album;
                TreeViewLogicStates.Interpret = "";
                statusStripAlbum.Text = album;

                TreeviewFindNodeByText(currentTreeNode.Parent, album, true, true);
                tvlogic.SelectedNode = tvlogic.Nodes["root"].Nodes["album"].Nodes[album];

                tvlogicFillInterpretAsync();

                if (tvlogic.Nodes["root"].Nodes["Interpret"].Nodes.Count > 1)   // node interpreter wurde bereits aufgeklappt
                {
                    TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["Interpret"], "Alle", true, true);
                    TreeViewLogicStates.Interpret = "";
                }
            }

            if (mainNode == "interpret")
            {
                var interpret = currentTreeNode.Text == "Alle" ? "" : currentTreeNode.Text;

                DataGetSet.SetSetting("LastInterpret", interpret);
                DataGetSet.SetSetting("LastAlbum", "");
                DataGetSet.SetSetting("LastCatalog", "");

                TreeViewLogicStates.Catalog = "";
                TreeViewLogicStates.Album = "";
                TreeViewLogicStates.Interpret = interpret;

                statusStripKatalog.Text = "Alle";
                statusStripAlbum.Text = "Alle";
                statusStripInterpret.Text = interpret;

                TreeviewFindNodeByText(currentTreeNode.Parent, interpret, true, true);

                tvlogic.SelectedNode = tvlogic.Nodes["root"].Nodes["interpret"].Nodes[interpret];

                if (tvlogic.Nodes["root"].Nodes["Interpret"].Nodes.Count > 1)   // node album wurde bereits aufgeklappt
                {
                    TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["katalog"], "Alle", true, true);
                    TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["album"], "Alle", true, true);
                }
            }

            lastSelectedTreeNode = currentTreeNode;

            SettingsDb.DatagridLastSelectedRow = 0;

            FillDatagridView();


            //GridViewSetColumsWidth();
            //random.InitRandomNumbers(dataGridView.RowCount - 1, 0);
        }

        #endregion Treeview tvlogic Event Handlers

        #region Treeview tvlogic initialize

        /// <summary>
        /// Initialize the Treeview Logic
        /// adding all root nodes (but does not fill them)
        /// </summary>
        private void tvlogicInitialize()
        {
            string[] subnodes = { "Genre", "Katalog", "Album", "Interpret" };

            tvlogic.Nodes.Clear();
            tvlogic.ImageList = imageListTreeView;
            rootNode = tvlogic.Nodes.Add("root", "MyJukebox");
            rootNode.ImageKey = "root";
            rootNode.Tag = "root";

            foreach (string sn in subnodes)
            {
                TreeNode tn = new TreeNode(sn);
                tn.Name = sn.ToLower();
                tn.ImageKey = sn.ToLower();
                tn.SelectedImageKey = sn.ToLower();
                tn.Tag = tn.Text.ToLower();
                tn.Nodes.Add(sn + "_alle", "Alle", sn.ToLower());
                tn.Nodes[sn + "_alle"].ImageKey = sn.ToLower();
                tn.Nodes[sn + "_alle"].SelectedImageKey = sn.ToLower();
                tn.Nodes[sn + "_alle"].Tag = "alle";
                rootNode.Nodes.Add(tn);
            }

            tvlogic.ExpandAll();
        }

        private void tvplaylistInitialize()
        {
            tvplaylist.ForeColor = Color.Gold;
            tvplaylist.LineColor = Color.Gold;
            tvplaylist.ImageList = imageListTreeView;

            tvplaylist.Nodes.Clear();

            // create Root Node
            TreeNode rootNode = new TreeNode();
            rootNode = tvplaylist.Nodes.Add("root", "MyJukebox");
            rootNode.ImageKey = "root";
            rootNode.Tag = "root";

            TreeNode tnPlaylist = rootNode.Nodes.Add("playlists", "Playlists");
            tnPlaylist.ImageKey = "playlist";
            tnPlaylist.Tag = "playlist";
            tnPlaylist.SelectedImageKey = "playlist";

            tvplaylist.ExpandAll();
        }

        #endregion Treeview tvlogic initialize

        #region Treeview FindNodeByText

        /// <summary>
        /// finds a node starting from given treenode
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="nodText"></param>
        private void TreeviewFindNodeByText(TreeNodeCollection NNodes, string nodText, bool bSetColor, bool bClearColor)
        {
            if (bClearColor) this.TreeviewClearNodeBackColor(NNodes);

            TreeNodeCollection nodes = NNodes;
            foreach (TreeNode tn in nodes)
            {
                // if the text properties match, color the item
                if (tn.Text == nodText)
                {
                    tvlogic.SelectedNode = tn;
                    if (bSetColor)
                    {
                        tn.BackColor = Color.LightCyan;
                        tn.ForeColor = Color.Gold;
                    }
                }
            }
        }

        private void TreeviewFindNodeByText(TreeNode startNode, string nodText, bool bSetColor, bool bClearColor)
        {
            if (bClearColor) TreeviewClearNodeBackColor(startNode);

            TreeNodeCollection nodes = startNode.Nodes;
            foreach (TreeNode tn in nodes)
            {
                // if the text properties match, color the item
                if (tn != null && tn.Text == nodText)
                {
                    tvlogic.SelectedNode = tn;
                    if (bSetColor)
                    {
                        tn.BackColor = Color.DodgerBlue;
                        tn.ForeColor = Color.Wheat;
                    }
                }
            }
        }

        #region BackColor

        // recursively move through the treeview nodes
        // and reset backcolors to white
        private void TreeviewClearNodeBackColor(TreeNode startNode)
        {
            TreeNodeCollection nodes = startNode.Nodes;
            foreach (TreeNode n in nodes)
            {
                n.BackColor = Color.LightSlateGray;
                n.ForeColor = Color.Gold;
                TreeviewClearNodeBackColorRecursive(n);
            }
        }

        private void TreeviewClearNodeBackColor(TreeNodeCollection NNodes)
        {
            foreach (TreeNode n in NNodes)
            {
                n.BackColor = Color.LightSlateGray;
                n.ForeColor = Color.Gold;
                TreeviewClearNodeBackColorRecursive(n);
            }
        }

        // called by ClearBackColor function
        private void TreeviewClearNodeBackColorRecursive(TreeNode startNode)
        {
            foreach (TreeNode tn in startNode.Nodes)
            {
                tn.BackColor = Color.LightSlateGray;
                tn.ForeColor = Color.Gold;
                TreeviewClearNodeBackColorRecursive(tn);
            }
        }

        #endregion BackColor

        #endregion Treeview FindNodeByText

        #region Treeview FindNodeByName

        /// <summary>
        /// finds a node starting from given treenode
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="nodText"></param>
        private void TreeviewFindNodeByName(TreeNode startNode, string nodName, bool bSetColor, bool bClearColor)
        {
            try
            {
                TreeNode[] tn = tvlogic.Nodes[0].Nodes.Find(nodName, true);
                for (int i = 0; i < tn.Length; i++)
                {
                    tvlogic.SelectedNode = tn[i];
                    if (bSetColor)
                    {
                        tvlogic.SelectedNode.BackColor = Color.LightBlue;
                        tvlogic.SelectedNode.ForeColor = Color.Gold;
                    }
                }
            }
            catch { }
        }

        private void TreeviewFindNodeByName(TreeNodeCollection NNodes, string nodName, bool bSetColor, bool bClearColor)
        {
            try
            {
                //TreeNode[] tn = tvlogic.Nodes[0].Nodes.Find(nodName, true);
                TreeNode[] tn = NNodes.Find(nodName, true);

                for (int i = 0; i < tn.Length; i++)
                {
                    tvlogic.SelectedNode = tn[i];
                    if (bSetColor)
                    {
                        tvlogic.SelectedNode.BackColor = Color.Blue;
                        tvlogic.SelectedNode.ForeColor = Color.Wheat;
                    }
                }
            }
            catch { }
        }

        private void TreeviewFindNodeByName(TreeView tv, TreeNodeCollection NNodes, string nodName, bool bSetColor, bool bClearColor)
        {
            try
            {
                //TreeNode[] tn = tvlogic.Nodes[0].Nodes.Find(nodName, true);
                TreeNode[] tn = NNodes.Find(nodName, true);

                for (int i = 0; i < tn.Length; i++)
                {
                    tv.SelectedNode = tn[i];
                    if (bSetColor)
                    {
                        tv.SelectedNode.BackColor = Color.Blue;
                        tv.SelectedNode.ForeColor = Color.Wheat;
                    }
                }
            }
            catch { }
        }

        #endregion Treeview FindNodeByName

        #region tvlogic FindNodeByTag

        /// <summary>
        /// Searching for nodes by tag requires a special function
        /// this function recursively scans the treeview and
        /// marks matching items.  Tags can be object; in this
        /// case they are just used to contain strings
        /// </summary>
        ///
        private void TreeviewFindNodeByTag(TreeNode startNode, string nodTag, bool bSetColor, bool bClearColor)
        {
            if (bClearColor) this.TreeviewClearNodeBackColor(startNode);

            foreach (TreeNode tn in startNode.Nodes)
            {
                // if the text properties match, color the item
                if (tn.Tag.ToString() == nodTag)
                {
                    tn.BackColor = Color.Blue;
                    tn.ForeColor = Color.Gold;
                }

                TreeviewFindNodeByTag(tn, nodTag, bSetColor, bClearColor);
            }
        }

        private void TreeviewFindNodeByTag(TreeNodeCollection NNodes, string nodTag, bool bSetColor, bool bClearColor)
        {
            foreach (TreeNode tn in NNodes)
            {
                // if the text properties match, color the item
                if (tn.Tag.ToString() == nodTag)
                {
                    tn.BackColor = Color.Blue;
                    tn.ForeColor = Color.Gold;
                }

                TreeviewFindNodeByTag(tn, nodTag, bSetColor, bClearColor);
            }
        }

        #endregion tvlogic FindNodeByTag

        #region TreeView tvlogic Methodes

        private void tvlogic_RemoveNodes(TreeNode tnstart)
        {   // erst alle nodes bis auf Node[0] ('alle') löschen
            int tncnt = tnstart.Nodes.Count - 1;
            while (true)
            {
                tnstart.Nodes[tncnt].Remove();
                tncnt--;

                if (tnstart.Nodes.Count == 1)
                    break;
            }
        }

        private async Task tvlogicFillGenreAsync()
        {
            string mainNode = "genre";
            List<string> genres = null;

            genres = await DataGetSet.GetGenresAsync();

            TreeNode tngenre = tvlogic.Nodes["root"].Nodes[mainNode];
            if (!tngenre.IsExpanded) tngenre.Expand();

            tvlogic.BeginUpdate();
            foreach (string node in genres)
            {
                string nodeName = node.ToLower();
                TreeNode tn = tngenre.Nodes.Add(node);
                tn.Name = tn.Parent.Name + "_" + nodeName;
                tn.ImageKey = tngenre.ImageKey;
                tn.SelectedImageKey = tngenre.SelectedImageKey;
                tn.Tag = tn.Text.ToLower();
            }

            TreeviewFindNodeByText(tngenre, TreeViewLogicStates.Genre, true, false);
            tvlogic.EndUpdate();
        }

        private async Task tvlogicFillCatalogAsync()
        {
            string mainNode = "katalog";
            List<string> catalogues = null;

            TreeNode tnkatalog;
            tnkatalog = tvlogic.Nodes["root"].Nodes[mainNode];
            tnkatalog.Nodes.Clear();
            tnkatalog.Nodes.Add("katalog_alle", "Alle");
            tnkatalog.FirstNode.ImageKey = mainNode;
            tnkatalog.FirstNode.SelectedImageKey = mainNode;
            statusStripKatalog.Text = DataGetSet.GetSetting("LastKatalog").ToString();

            catalogues = await DataGetSet.GetCatalogsAsync();

            tvlogic.BeginUpdate();
            foreach (string node in catalogues)
            {
                string strNodeName = node.ToLower();
                TreeNode tn = tnkatalog.Nodes.Add(tnkatalog.Parent.Name + "_" + strNodeName, node);
                tn.Name = tn.Parent.Name + "_" + strNodeName;
                tn.ImageKey = tnkatalog.ImageKey;
                tn.SelectedImageKey = tnkatalog.SelectedImageKey;
                tn.Tag = tn.Text.ToUpper();
            }

            TreeviewFindNodeByText(tnkatalog, TreeViewLogicStates.Catalog, true, false);
            tvlogic.EndUpdate();
        }

        private async Task tvlogicFillAlbumAsync()
        {
            string mainNode = "album";
            List<string> albums = null;


            if (TreeViewLogicStates.Genre == "" || TreeViewLogicStates.Catalog == "")
            {
                tvlogic.Nodes["root"].Nodes["album"].Nodes.Clear();
                tvlogic.Nodes["root"].Nodes["album"].Nodes.Add("album_alle", "Alle");
                tvlogic.Nodes["root"].Nodes["album"].FirstNode.ImageKey = "album";
                tvlogic.Nodes["root"].Nodes["album"].FirstNode.SelectedImageKey = "album";
                DataGetSet.SetSetting("LastAlbum", "");
                DataGetSet.SetSetting("LastInterpret", "");
                TreeViewLogicStates.Album = "";
                TreeViewLogicStates.Interpret = "";
                statusStripAlbum.Text = "Alle";
                return;
            }

            albums = await DataGetSet.GetAlbumsAsync();

            TreeNode tnalbum = new TreeNode();

            tnalbum = tvlogic.Nodes["root"].Nodes[mainNode];
            tnalbum.Nodes.Clear();
            tnalbum.Nodes.Add("Alle");
            tnalbum.FirstNode.ImageKey = mainNode;
            tnalbum.FirstNode.SelectedImageKey = mainNode;
            tnalbum.FirstNode.Tag = "ALLE";

            statusStripAlbum.Text = "Alle";
            statusStripInterpret.Text = "Alle";

            tvlogic.BeginUpdate();
            foreach (string strAlbum in albums)
            {
                string strNodeName = strAlbum.ToLower();
                TreeNode tn = tnalbum.Nodes.Add(tnalbum.Parent.Name + "_" + strNodeName, strAlbum);
                tn.Name = tn.Parent.Name + "_" + strNodeName;
                tn.ImageKey = tnalbum.ImageKey;
                tn.SelectedImageKey = tnalbum.SelectedImageKey;
                tn.Tag = tn.Text.ToUpper();
            }

            TreeviewFindNodeByText(tnalbum, TreeViewLogicStates.Album, true, false);
            tvlogic.EndUpdate();
        }

        private async Task tvlogicFillInterpretAsync()
        {
            string mainNode = "interpret";
            List<string> interpreters = null;

            if (TreeViewLogicStates.Genre == "" || TreeViewLogicStates.Catalog == "")
            {
                tvlogic.Nodes["root"].Nodes[mainNode].Nodes.Clear();
                tvlogic.Nodes["root"].Nodes[mainNode].Nodes.Add(mainNode + "_alle", "Alle");
                tvlogic.Nodes["root"].Nodes[mainNode].FirstNode.ImageKey = mainNode;
                tvlogic.Nodes["root"].Nodes[mainNode].FirstNode.SelectedImageKey = mainNode;
                DataGetSet.SetSetting("LastAlbum", "");
                DataGetSet.SetSetting("LastInterpret", "");
                TreeViewLogicStates.Album = "";
                TreeViewLogicStates.Interpret = "";
                statusStripInterpret.Text = "Alle";
                interpreters = await DataGetSet.GetInterpretenAsync();
                return;
            }

            interpreters = await DataGetSet.GetInterpretenAsync();

            TreeNode tninterpret = new TreeNode();
            tninterpret = tvlogic.Nodes["root"].Nodes[mainNode];
            tninterpret.Nodes.Clear();
            tninterpret.Nodes.Add("Alle");
            tninterpret.FirstNode.ImageKey = mainNode;
            tninterpret.FirstNode.SelectedImageKey = mainNode;
            tninterpret.FirstNode.Tag = "ALLE";

            if (tninterpret.Nodes.Count == 1)
            {
                tvlogic.BeginUpdate();
                foreach (string strNode in interpreters)
                {
                    string strNodeName = strNode.ToLower();
                    TreeNode tn = tninterpret.Nodes.Add(tninterpret.Parent.Name + "_" + strNodeName, strNode);
                    tn.Name = tn.Parent.Name + "_" + strNodeName;
                    tn.ImageKey = tninterpret.ImageKey;
                    tn.SelectedImageKey = tninterpret.SelectedImageKey;
                    tn.Tag = tn.Text.ToUpper();
                }

                TreeviewFindNodeByText(tninterpret, TreeViewLogicStates.Interpret, true, false);
                tvlogic.EndUpdate();
            }
        }

        #endregion TreeView tvlogic Methodes

        #endregion Treeview tvlogic

        #region Treeview tvplaylist

        #region Treeview tvplaylist Events

        private void tvplaylist_MouseDown(object sender, MouseEventArgs e)
        {
            currentTreeNode = tvplaylist.GetNodeAt(e.X, e.Y);
        }

        private void tvplaylist_Click(object sender, EventArgs e)
        {
            Debug.Print("tvplaylist_Click:");

            Common.TextBoxSearchClear(textBoxSearch);
            int lastSelectedPlaylist = DataGetSet.GetLastselectedPlaylist();

            try
            {
                if (currentTreeNode.FirstNode != null || (int)currentTreeNode.Tag == lastSelectedPlaylist)
                    return;
            }
            catch
            {
                throw new NotImplementedException();
            }

            tvplaylist.SelectedNode = currentTreeNode;
            tvplaylist.SelectedNode.BackColor = Color.DodgerBlue;
            tvplaylist.SelectedNode.ForeColor = Color.Gold;

            int playlistID = Convert.ToInt32(tvplaylist.SelectedNode.Tag);
            DataGetSet.SetPlaylistLastSelected(playlistID);

            PlaylistInfo info = new PlaylistInfo();
            info.ID = playlistID;
            info.Last = true;

            DataGetSet.SetPlaylistInfos(info);
            info = DataGetSet.GetPlaylistInfos(playlistID);

            TreeviewFindNodeByText(currentTreeNode.Parent, info.Name, true, true);

            FillDatagridView();

            random.InitRandomNumbers(dataGridView.RowCount - 1);
            GridViewSetColumsWidth();

            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Columns["ID"].Visible = false;

                dataGridView.Rows[(int)info.Row].Selected = true;
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.SelectedRows[0].Index;

                statusStripRow.Text = (info.Row + 1).ToString();
                statusStripRowcount.Text = dataGridView.RowCount.ToString();
                statusStripTitel.Text = dataGridView.Rows[(int)info.Row].Cells[1].Value + " - " + dataGridView.Rows[(int)info.Row].Cells[2].Value;
            }
            else
            {
                statusStripRow.Text = (info.Row).ToString();
                statusStripRowcount.Text = (info.Row).ToString();
            }
        }

        #endregion Treeview tvplaylist Events

        #region Treeview tvplaylist Methodes

        private async Task tvplaylistFillPlaylist()
        {
            List<Playlist> playlistEntries = DataGetSet.GetPlaylists();

            TreeNode treeNode = tvplaylist.Nodes["root"].Nodes["playlists"];

            int ID = -1;
            string strNode = "";

            foreach (var item in playlistEntries)
            {
                ID = item.ID;
                strNode = item.Name;
                TreeNode tn = treeNode.Nodes.Add("playlist_" + strNode.ToLower(), strNode);
                tn.Name = strNode.ToLower();
                tn.ImageKey = "playlist";
                tn.SelectedImageKey = "playlist";
                tn.Tag = ID;
                ToolStripMenuItem subitem = new ToolStripMenuItem();
                subitem.Text = Common.CamelSpaceOut(item.Name);
                subitem.Name = item.Name;
                subitem.Tag = item.ID;
                subitem.Click += PlaylistsContextMenuStrip_Click;
                datagridContextMenuStripSendToPlaylist.DropDownItems.Add(subitem);
            }

            var plid = DataGetSet.GetLastselectedPlaylist();
            PlaylistInfo info = DataGetSet.GetPlaylistInfos(plid);

            tvplaylist.ExpandAll();
            TreeviewFindNodeByText(treeNode, info.Name, true, false);
            tvplaylist.SelectedNode = treeNode.Nodes[info.Name];
        }

        #endregion Treeview tvplaylist Methodes

        #endregion Treeview tvplaylist

        #region Datagrid Methods and Events

        #region Datagrid Events

        private void dataGridView_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            int row = dataGridView.CurrentCellAddress.Y + 1;
            int column = dataGridView.CurrentCellAddress.X;
            statusStripRow.Text = row.ToString();
            Debug.Print($"dataGridView_Click: ID={id}, Row={row}, Column={column}");
        }

        private void dataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (_isSetting == false)
                DataGetSet.SetColumnWidth(e.Column.Name, e.Column.Width);
        }

        private void dataGridView_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            Debug.Print(e.Row.Height.ToString());
        }

        private void dataGridView_EditModeChanged(object sender, EventArgs e)
        {
            Debug.Print("dataGridView_EditModeChanged");
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string msg = string.Format("Editing Cell at ({1}, {0})", e.ColumnIndex, e.RowIndex);
            Debug.Print(msg);
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string msg = String.Format("Finished Editing Cell at ({1}, {0})", e.ColumnIndex, e.RowIndex);
            Debug.Print(msg);
        }

        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = DataGetSet.GetTablogicalResults();
            dataGridView.DataSource = result;
        }

        #endregion Datagrid Events

        #region datagridContextMenu Events

        private void datagridContextMenuStripCopyToClip_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView.CurrentCellAddress.Y;
            int c = this.dataGridView.CurrentCellAddress.X;
            Debug.Print($"{dataGridView.Rows[r].Cells[c].Value}");

            Clipboard.Clear();
            Clipboard.SetText($"{dataGridView.Rows[r].Cells[c].Value}");
        }

        private void DatagridContextMenuStripCopyLineToClip_Click(object sender, EventArgs e)
        {
            string text = "";

            try
            {
                int row = this.dataGridView.CurrentRow.Index;
                int colums = this.dataGridView.ColumnCount;

                for (int column = 1; column < colums; column++)
                    text += dataGridView.Rows[row].Cells[column].Value.ToString() + Environment.NewLine;

                Clipboard.Clear();
                Clipboard.SetText(text);
            }
            catch
            {
            }
        }

        private void datagridContextMenuStripEditRecord_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            EditRecord editRecord = new EditRecord(id);
            editRecord.ShowDialog();
            refreshToolStripMenuItem.PerformClick();
        }

        private void datagridContextMenuStripRating_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            var rating = item.Tag.ToString();
            var titelID = dataGridView.CurrentRow.Cells[0].Value;

            DataGetSet.SetRating(Convert.ToInt32(titelID), Convert.ToInt32(rating));
        }

        private void datagridContextMenuStripdeleteEntrys_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            DataGetSet.DeleteSong(id);
            refreshToolStripMenuItem.PerformClick();
        }

        #endregion datagridContextMenu Events

        #region DataGrid Methodes

        public void FillDatagridView(string filter = "")
        {
            #region FillDatagridByQuery

            if (Common.IsQuery(filter) == true)
            {
                FillDatagridByQuery();
                return;
            }

            #endregion FillDatagridByQuery

            #region FillDatagrid by Logical Tab

            if (tabControl.SelectedTab == tabLogical)
            {
                FillDatagridByTabLogical();
                dataGridView.Rows[SettingsDb.DatagridLastSelectedRow].Selected = true;
            }

            #endregion FillDatagrid by Logical Tab

            #region Fill Datagrid by Playlist

            if (tabControl.SelectedTab == tabPlayLists)
            {
                Debug.Print("calling FillDatagridByTabPlaylist");
                FillDatagridByTabPlaylist();

                Debug.Print("back from FillDatagridByTabPlaylist");

                //int playlistID = (int)tvplaylist.SelectedNode.Tag;

                //PlaylistInfo info = new PlaylistInfo();
                //info = DataGetSet.GetLastselectedPlaylistInfos(playlistID);
                //lastRow = (int)info.Row;
            }
            #endregion Fill Datagrid by Playlist

            #region format datagridview

            try
            {
                if (dataGridView.RowCount > 1)
                {
                    GridViewSetColumsWidth();

                    dataGridView.Columns["ID"].Visible = false;
                    // after hiding the first column the CurrentRow becomes NULL!!
                    // so set the CurrentCell to any valid value
                    dataGridView.CurrentCell = dataGridView["Genre", SettingsDb.DatagridLastSelectedRow];
                    dataGridView.Rows[SettingsDb.DatagridLastSelectedRow].Selected = true;
                }

                if (dataGridView.CurrentRow != null)
                {
                    dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.SelectedRows[0].Index;
                    statusStripRow.Text = (dataGridView.SelectedRows[0].Index + 1).ToString();
                    statusStripRowcount.Text = dataGridView.RowCount.ToString();
                }

                dataGridView.ResumeLayout();
            }
            catch (Exception ex)
            {
                Debug.Print($"FillDatagridView_Error: {ex.Message}");
            }

            DataGetSet.SetSetting("LastQuery", "");
            statusStripTitel.Text = "";
            random.InitRandomNumbers(dataGridView.RowCount - 1);

            #endregion format datagridview

        }

        private void FillDatagridByTabLogical()
        {
            var results = DataGetSet.GetTablogicalResults();

            dataGridView.SuspendLayout();
            dataGridView.DataSource = results;
            dataGridView.ResumeLayout();

            Debug.Print("FillDatagridByTabLogical finish");
        }

        private void FillDatagridByTabPlaylist()
        {
            int playlistID = DataGetSet.GetLastselectedPlaylist();
            PlaylistInfo info = DataGetSet.GetPlaylistInfos(playlistID);

            var results = DataGetSet.GetPlaylistEntries(playlistID);
            dataGridView.SuspendLayout();
            dataGridView.DataSource = results;
            dataGridView.ResumeLayout();

            if (dataGridView.Rows.Count > 1)
            {
                dataGridView.Rows[(int)info.Row].Selected = true;
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.SelectedRows[0].Index;
            }
            Debug.Print("FillDatagridByTabPlaylist finish");
        }

        private async Task FillDatagridByTabPlaylistAsync()
        {
            int playlistID = DataGetSet.GetLastselectedPlaylist();
            PlaylistInfo info = DataGetSet.GetPlaylistInfos(playlistID);

            var results = DataGetSet.GetPlaylistEntries(playlistID);
            dataGridView.SuspendLayout();
            dataGridView.DataSource = results;
            dataGridView.ResumeLayout();

            Debug.Print("FillDatagridByTabPlaylist finish");
        }

        private void FillDatagridByQuery()
        {
            int currentDatagrigRow = 0;
            if (DataGetSet.GetSetting("LastSelectedTab").ToString() == TabcontrolTab.Logical.ToString())
                currentDatagrigRow = 1;

            var results = DataGetSet.GetQueryResult(textBoxSearch.Text);
            dataGridView.DataSource = results;

            if (dataGridView.RowCount > 0)
            {
                dataGridView.Columns["ID"].Visible = false;
                GridViewSetColumsWidth();
                dataGridView.CurrentCell = dataGridView[1, currentDatagrigRow];
                statusStripRow.Text = Convert.ToString(currentDatagrigRow + 1);
            }
        }

        private void AddQueryToComboBox(string query)
        {
            bool itemExist = false;
            foreach (var item in comboBoxQueries.Items)
            {
                if (item.ToString().ToUpper() == query.ToUpper())
                    itemExist = true;
            }
            if (itemExist == false)
            {
                comboBoxQueries.Items.Add(query);
                //Settings.QueryList.Add(query);
            }
        }

        private void GridViewSetColumsWidth()
        {
            _isSetting = true;

            var columnList = DataGetSet.GetColumsWidth();

            if (dataGridView.ColumnCount > 0)
            {
                foreach (var column in columnList)
                {
                    string columnName = column.Name;
                    int columnWidth = Convert.ToInt32(column.Width);

                    if (dataGridView.Columns[columnName] != null)
                        dataGridView.Columns[columnName].Width = columnWidth;
                }
            }
            _isSetting = false;
        }

        #endregion DataGrid Methodes

        #endregion Datagrid Methods and Events

        #region toolStripPlaybackButtons Events

        private void toolStripPlaybackButtonPreviuos_Click(object sender, EventArgs e)
        {
            Debug.Print("buttonPrevious_Click");
            int currentRow = dataGridView.SelectedRows[0].Index;
            if (currentRow > 0)
            {
                dataGridView.Rows[--currentRow].Cells[0].Selected = true;
                DataGridViewRow dgrow = dataGridView.CurrentRow;
                string filespec = Path.Combine(dgrow.Cells["Pfad"].Value.ToString(), dgrow.Cells["FileName"].Value.ToString());
                BeginInvoke(new Action(() => { axWindowsMediaPlayer1.URL = filespec; }));
            }
        }

        private void toolStripPlaybackButtonPlay_Click(object sender, EventArgs e)
        {
            Debug.Print("buttonPlay_Click");
            _buttonStop = false;

            if (toolStripPlaybackButtonPause.Text == "Resume")
            {
                toolStripPlaybackButtonPause.Text = "Pause";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timerDuration.Enabled = true;

                return;
            }

            var currentRow = dataGridView.CurrentRow.Index;
            DataGridViewRow dgrow = dataGridView.CurrentRow;
            var path = dgrow.Cells["Pfad"].Value.ToString();
            var fileName = dgrow.Cells["FileName"].Value.ToString();
            var artist = dgrow.Cells["Interpret"].Value.ToString();
            var filespec = Path.Combine(path, fileName);


            currentRow = dataGridView.SelectedRows[0].Index;

            if (!File.Exists(filespec))
            {
                dataGridView.Rows[dataGridView.CurrentRow.Index].DefaultCellStyle.BackColor = Colors.NotFound;
                if (currentRow >= dataGridView.RowCount - 1)
                    BeginInvoke(new Action(() => { toolStripPlaybackButtonStop.PerformClick(); }));
                else
                    BeginInvoke(new Action(() => { toolStripPlaybackButtonNext.PerformClick(); }));
                return;
            }
            else
            {
                if (tabControl.SelectedTab == tabLogical)
                    DataGetSet.SetSetting("DatagridLastSelectedRow", currentRow.ToString());

                if (tabControl.SelectedTab == tabPlayLists)
                {
                    PlaylistInfo info = new PlaylistInfo();
                    info.ID = DataGetSet.GetLastselectedPlaylist(); ;
                    info.Row = currentRow;
                    DataGetSet.SetPlaylistInfos(info);
                }

                axWindowsMediaPlayer1.URL = filespec;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                statusStripRow.Text = (currentRow + 1).ToString();
                statusStrip.Refresh();

                FlipImage(dgrow);
            }
        }

        private void toolStripPlaybackButtonPause_Click(object sender, EventArgs e)
        {
            if (toolStripPlaybackButtonPause.Text == "Pause")
            {
                toolStripPlaybackButtonPause.Text = "Resume";
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timerDuration.Enabled = false;
            }
            else
            {
                toolStripPlaybackButtonPause.Text = "Pause";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timerDuration.Enabled = true;
            }
        }

        private void toolStripPlaybackButtonStop_Click(object sender, EventArgs e)
        {
            _buttonStop = true;
            Debug.Print("buttonPlay_Click");
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timerImageFlip.Enabled = false;
            Task.Delay(TimeSpan.FromSeconds(2.0));
            pictureBoxFoto.Image = Properties.Resources.MyBitmap;
        }

        private void toolStripPlaybackButtonNext_Click(object sender, EventArgs e)
        {
            Debug.Print("buttonNext_Click");

            int currentRow = dataGridView.CurrentRow.Index;

            if ((currentRow < dataGridView.RowCount - 1) && !SettingsDb.IsRandom)
            {
                var columsCount = dataGridView.ColumnCount - 1;
                dataGridView.Rows[++currentRow].Cells[2].Selected = true;
            }
            else if (SettingsDb.IsRandom == true)
            {
                var nextRow = random.GetNextNumber;
                dataGridView.Rows[nextRow].Cells[2].Selected = true;
            }

            BeginInvoke(new Action(() => { toolStripPlaybackButtonPlay.PerformClick(); }));
        }

        private void toolStripButtonRandom_Click(object sender, EventArgs e)
        {
            _isloop = false;
            Debug.Print("buttonRandom_Click");

            bool isRandom = SettingsDb.IsRandom;

            toolStripPlaybackButtonLoop.Checked = false;
            toolStripPlaybackButtonLoop.BackColor = Color.LightSlateGray;

            isRandom = !isRandom;
            if (isRandom)
                toolStripPlaybackButtonRandom.BackColor = Color.LightSteelBlue;
            else
                toolStripPlaybackButtonRandom.BackColor = Color.LightSlateGray;

            toolStripPlayback.Refresh();

            SettingsDb.IsRandom = isRandom;
        }

        private void toolStripPlaybackButtonLoop_Click(object sender, EventArgs e)
        {
            Debug.Print("buttonLoop_Click");

            DataGetSet.SetSetting("IsRandom", "False");


            toolStripPlaybackButtonRandom.Checked = false;
            toolStripPlaybackButtonRandom.BackColor = Color.LightSlateGray;

            _isloop = !_isloop;
            if (_isloop)
                toolStripPlaybackButtonLoop.BackColor = Color.LightSteelBlue;
            else
                toolStripPlaybackButtonLoop.BackColor = Color.LightSlateGray;

            toolStripPlayback.Refresh();
        }

        private void toolStripPlaybackButtonSpeaker_Click(object sender, EventArgs e)
        {
            Debug.Print("buttonSpeaker_Click");

            if (toolStripPlaybackButtonSpeaker.Checked)
            {
                toolStripPlaybackButtonSpeaker.Image = Properties.Resources.SpeakerOff.ToBitmap();
                axWindowsMediaPlayer1.settings.mute = true;
            }
            else
            {
                toolStripPlaybackButtonSpeaker.Image = Properties.Resources.SpeakerOn.ToBitmap();
                axWindowsMediaPlayer1.settings.mute = false;
            }
        }

        private void toolStripPlaybackButtonOpen_Click(object sender, EventArgs e)
        {
        }

        private void toolStripFileButtonDelete_Click(object sender, EventArgs e)
        {
        }

        private void toolStripFileButtonOpen_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrow = this.dataGridView.CurrentRow;
            string strPfad = dgrow.Cells["Pfad"].Value.ToString();
            ProcessStartInfo psi = new ProcessStartInfo("explorer", strPfad);
            psi.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen des Folders:" + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion toolStripPlaybackButtons Events

        #region trackBar Events

        private void trackBarPosition_Scroll(object sender, EventArgs e)
        {
            var pos = toolStripPlaybackTrackBarPosition.Value;
            var max = toolStripPlaybackTrackBarPosition.Maximum;
            var val = pos / (max / 100);

            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = pos;
            toolTipPosition.SetToolTip(toolStripPlaybackTrackBarPosition, "Position " + val.ToString() + "%");
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = toolStripPlaybackTrackBarVolume.Value;
            DataGetSet.SetSetting("Volume", toolStripPlaybackTrackBarVolume.Value.ToString());
            if (toolStripPlaybackTrackBarVolume.Value == 0)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                toolTipVolume.SetToolTip(toolStripPlaybackTrackBarVolume, "Mute");
                toolStripPlaybackButtonSpeaker.Image = Properties.Resources.SpeakerOff.ToBitmap();
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                toolTipVolume.SetToolTip(toolStripPlaybackTrackBarVolume, $"Volume {toolStripPlaybackTrackBarVolume.Value}%");
                toolStripPlaybackButtonSpeaker.Image = Properties.Resources.SpeakerOn.ToBitmap();
            }
        }

        #endregion trackBar Events

        #region tabControl Events

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("tabControl_SelectedIndexChanged");

            Common.TextBoxSearchClear(textBoxSearch);

            int currentTabIndex = tabControl.SelectedIndex;
            switch (currentTabIndex)
            {
                case 0:     // logical
                    Debug.Print("tvlogic Tab clicked");
                    string lastAlbum = DataGetSet.GetSetting("LastAlbum").ToString();

                    if (lastAlbum != "Alle")
                    {
                        tvlogic.Nodes["root"].Nodes["album"].ExpandAll();
                        tvlogic.Nodes["root"].Nodes["album"].Tag = lastAlbum;
                    }
                    string lastInterpret = DataGetSet.GetSetting("LastInterpret").ToString();

                    if (lastInterpret != "Alle")
                    {
                        tvlogic.Nodes["root"].Nodes["interpret"].ExpandAll();
                        tvlogic.Nodes["root"].Nodes["interpret"].Tag = lastInterpret;
                    }

                    break;

                case 1:     // playlist
                    Debug.Print("tvplaylist Tab clicked");
                    tvplaylist.ExpandAll();
                    break;
            }

            Debug.Print("tabControl_SelectedIndexChanged: calling FillDatagridView");

            FillDatagridView();
            GridViewSetColumsWidth();
            DataGetSet.SetSetting("LastSelectedTab", currentTabIndex.ToString());
        }

        #endregion tabControl Events

        #region other controls

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonQueryExecute.PerformClick();
            }
        }

        private void buttonQueryExecute_Click(object sender, EventArgs e)
        {
            var placeholderText = DataGetSet.GetSetting("PlaceHolderText").ToString();

            if (textBoxSearch.Text != placeholderText)
                FillDatagridView(textBoxSearch.Text);
        }

        private void buttonQueryhSave_Click(object sender, EventArgs e)
        {
            AddQueryToComboBox(textBoxSearch.Text);
        }

        private void buttonQueryClear_Click(object sender, EventArgs e)
        {
            Common.TextBoxSearchClear(textBoxSearch);
            if (comboBoxQueries.Text != "")
            {
                comboBoxQueries.Text = "";
            }

            FillDatagridView();
        }

        #endregion other controls

        #region Timer Events

        private void timerImageFlip_Tick(object sender, EventArgs e)
        {
            if (artistImageFiles.Count == 0)
            {
                pictureBoxFoto.Image = Properties.Resources.ShadowMen;
                return;
            }

            if (Tag == null || (int)Tag >= artistImageFiles.Count) Tag = 0;

            int counter = (int)Tag;
            pictureBoxFoto.ImageLocation = artistImageFiles[counter];
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            Tag = ++counter; ;
        }

        private void timerDuration_Tick(object sender, EventArgs e)
        {
            double max = toolStripPlaybackTrackBarPosition.Maximum;
            double pos = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            string position = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            var percentige = 0;

            toolStripPlaybackTrackBarPosition.Value = (int)pos;
            statusStripPosition.Text = position;

            try
            {
                percentige = (int)(pos / (max / 100));
                toolTipPosition.SetToolTip(toolStripPlaybackTrackBarPosition, $"Position {(int)percentige}%");
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        #endregion Timer Events

        #region Public Methodes

        public void FillQueryCombo()
        {
            comboBoxQueries.Items.Clear();

            List<string> queries = DataGetSet.GetQueryList();

            if (queries.Count > 0)
            {
                comboBoxQueries.Items.Add("");
                foreach (var q in queries)
                {
                    comboBoxQueries.Items.Add(q);
                }
            }
        }

        public string QueryBuilder()
        {
            string and, query, temp, strGenre, katalog, album, interpret;

            Hashtable ht = new Hashtable();

            strGenre = "";
            if (TreeViewLogicStates.Genre != "")
            {
                ht.Add("genre", TreeViewLogicStates.Genre);
                strGenre = $" genre LIKE '{TreeViewLogicStates.Genre}'";
            }

            katalog = "";
            if (TreeViewLogicStates.Catalog != "")
            {
                ht.Add("katalog", TreeViewLogicStates.Catalog);
                katalog = $" katalog LIKE '{TreeViewLogicStates.Catalog}'";
            }

            if (TreeViewLogicStates.Album != "")
            {
                ht.Add("album", TreeViewLogicStates.Album);
                album = $" album LIKE '{TreeViewLogicStates.Album}'";
            }

            if (TreeViewLogicStates.Interpret != "")
            {
                ht.Add("interpret", TreeViewLogicStates.Interpret);
                interpret = $" interpret LIKE '{TreeViewLogicStates.Interpret}'";
            }

            temp = "";
            query = "";
            and = "";
            query = "";

            if (ht.Count > 1) and = " AND ";
            int htcount = 1;
            // Query zusammenbasteln
            foreach (DictionaryEntry de in ht)
            {
                string v = de.Value.ToString();
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, v.Replace("'", "''"));
                temp = "";
                temp += de.Key + " LIKE '" + v.Replace("'", "''") + "'";
                query += " (" + temp + ") ";
                if (htcount < ht.Count) query += and;
                htcount++;
            }
            return query;
        }

        private void FlipImage(DataGridViewRow datagridrow)
        {
            var path = datagridrow.Cells["Pfad"].Value.ToString();
            var artist = datagridrow.Cells["Interpret"].Value.ToString();

            List<string> pathList = new List<string>();

            pathList.Add(Path.Combine(
                DataGetSet.GetSetting("RootImagePath", @"\\win2k16dc01\FS012").ToString(),
                datagridrow.Cells["Genre"].Value.ToString(),
                DataGetSet.GetSetting("ImagePath", "_Images").ToString()
                ));

            pathList.Add(path);
            pathList.Add(Path.Combine(path, DataGetSet.GetSetting("ImagePath", "_Images").ToString()));

            var collector = new ImageCollector(pathList, artist);
            artistImageFiles = new List<string>();
            artistImageFiles = collector.GetImagesFullName();
            timerImageFlip.Enabled = true;
        }

        #endregion Public Methodes

        private void comboBoxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.TextBoxSearchClear(textBoxSearch);
            toolStripPlaybackButtonStop.PerformClick();

            if (comboBoxQueries.Text != "")
            {
                int item = comboBoxQueries.SelectedIndex;
                textBoxSearch.Text = comboBoxQueries.Text;
                textBoxSearch.ForeColor = Color.Black;
                textBoxSearch.Refresh();
                DataGetSet.SetSetting("LastQuery", comboBoxQueries.Text);
            }

            buttonQueryExecute.PerformClick();
        }

        private void dataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            Debug.Print("");
        }

        #region WindowsMediaPlayer Events

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            int currentRow = dataGridView.CurrentRow.Index;
            switch (e.newState)
            {
                case (int)WMPPlayState.wmppsUndefined:
                    Debug.Print("Undefined");
                    break;

                case (int)WMPPlayState.wmppsStopped:
                    Debug.Print("Stopped");
                    _isPlaying = false;

                    timerDuration.Enabled = false;
                    timerImageFlip.Enabled = false;

                    dataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Colors.Played;

                    if ((currentRow < dataGridView.RowCount - 1) && _buttonStop == false)
                    {
                        if (toolStripPlaybackButtonLoop.Checked)
                            toolStripPlaybackButtonPlay.PerformClick();
                        else
                            toolStripPlaybackButtonNext.PerformClick();
                    }

                    if (_buttonStop)
                        BeginInvoke(new Action(() => { axWindowsMediaPlayer1.URL = null; }));

                    break;

                case (int)WMPPlayState.wmppsPaused:
                    Debug.Print("Paused");
                    _isPlaying = false;
                    timerImageFlip.Enabled = false;
                    break;

                case (int)WMPPlayState.wmppsPlaying:
                    Debug.Print("Playing");
                    _duration = axWindowsMediaPlayer1.currentMedia.duration;
                    toolStripPlaybackTrackBarPosition.Maximum = (int)_duration + 1;
                    statusStripDuration.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                    var row = dataGridView.CurrentCell.RowIndex;
                    dataGridView.Rows[row].DefaultCellStyle.BackColor = Colors.Playing;
                    timerDuration.Enabled = true;
                    _isPlaying = true;

                    break;

                case 4:    // ScanForward
                    Debug.Print("ScanForward");
                    break;

                case 5:    // ScanReverse
                    Debug.Print("ScanReverse");
                    break;

                case 6:    // Buffering
                    Debug.Print("Buffering");
                    break;

                case 7:    // Waiting
                    Debug.Print("Waiting");
                    break;

                case 8:    // MediaEnded
                    Debug.Print("MediaEnded");
                    break;

                case 9:    // Transitioning
                    Debug.Print("Transitioning");
                    break;

                case 10:   // Ready
                    Debug.Print("Ready");
                    break;

                case 11:   // Reconnecting
                    Debug.Print("Reconnecting");
                    break;

                case 12:   // Last
                    Debug.Print("Last");
                    break;

                default:
                    Debug.Print("Unknown State: " + e.newState.ToString());
                    break;
            }
        }

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            Debug.Print($"OpenStateChange: {e.newState}");
        }

        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            Debug.Print("EndOfStream");
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            statusStripPosition.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }

        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {
            Debug.Print($"StatusChange: {e.ToString()}");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            Debug.Print($"WindowsMediaPlayer Enter: {e.ToString()}");
        }

        #endregion WindowsMediaPlayer Events

        private void PlaylistsContextMenuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            var titelID = dataGridView.CurrentRow.Cells[0].Value;
            var playlistName = item.Name;

            DataGetSet.AddSongToPlaylist(Convert.ToInt32(titelID), playlistName);
        }

        #region PlaceHolderTextBox

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == DataGetSet.GetSetting("PlaceHolderText").ToString())
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = DataGetSet.GetSetting("PlaceHolderText").ToString();
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        #endregion PlaceHolderTextBox

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = dataGridView.CurrentRow.Cells["Pfad"].Value.ToString();
            Process.Start("explorer.exe", path);
        }

        private void tvlogicContextMenuStripCollaps_Click(object sender, EventArgs e)
        {
        }

        private void tvlogicContextMenuStripExpand_Click(object sender, EventArgs e)
        {
        }

        private void contextPlaylistMenuItemAdd_Click(object sender, EventArgs e)
        {
            string _caption = "New Playlist";
            string _prompt = "Enter Playlist Name:";
            string playlistName = "";

            InputDialog input = new InputDialog(Caption: _caption, Prompt: _prompt);

            if (input.ShowDialog() == DialogResult.OK)
            {
                playlistName = input.textBoxInput.Text;
            };

            // Check to see if the dialog is still hanging around
            // and, if so, get rid of it.
            if (input != null)
                input.Dispose();

            if (string.IsNullOrEmpty(playlistName))
            {
                MessageBox.Show("Empty Playlist Name!");
                return;
            }

            int newID = DataGetSet.AddNewPlaylist(playlistName);

            TreeNode treeNode = tvplaylist.Nodes["root"].Nodes["playlists"];

            TreeNode tn = treeNode.Nodes.Add("playlist_" + playlistName.ToLower(), playlistName);
            tn.Name = playlistName.ToLower();
            tn.ImageKey = "playlist";
            tn.SelectedImageKey = "playlist";
            tn.Tag = newID;
            ToolStripMenuItem subitem = new ToolStripMenuItem();
            subitem.Text = Common.CamelSpaceOut(playlistName);
            subitem.Name = playlistName;
            subitem.Tag = newID;
            subitem.Click += PlaylistsContextMenuStrip_Click;
            datagridContextMenuStripSendToPlaylist.DropDownItems.Add(subitem);

        }


        // ToDo: implement rename and delete playlist
        private void toolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            string _caption = "Delete Playlist";
            string _prompt = "Playlist Name:";
            string _default = tvplaylist.SelectedNode.Text;
            string playlistName = "";

            InputDialog input = new InputDialog(Caption: _caption, Prompt: _prompt, DefautText: _default);

            if (input.ShowDialog() == DialogResult.OK)
            {
                playlistName = input.textBoxInput.Text;
            };

            // Check to see if the dialog is still hanging around
            // and, if so, get rid of it.
            if (input != null)
                input.Dispose();

            if (string.IsNullOrEmpty(playlistName))
            {
                MessageBox.Show("Empty Playlist Name!");
                return;
            }
            else
                MessageBox.Show($"New Playlist Name is {playlistName}");



        }

        private void toolStripMenuItemRename_Click(object sender, EventArgs e)
        {
            string _caption = "Delete Playlist";
            string _prompt = "Enter new Playlist Name:";
            string _default = tvplaylist.SelectedNode.Text;
            string playlistName = "";

            InputDialog input = new InputDialog(Caption: _caption, Prompt: _prompt, DefautText: _default);

            if (input.ShowDialog() == DialogResult.OK)
            {
                playlistName = input.textBoxInput.Text;
            };

            // Check to see if the dialog is still hanging around
            // and, if so, get rid of it.
            if (input != null)
                input.Dispose();

            if (string.IsNullOrEmpty(playlistName))
            {
                MessageBox.Show("Empty Playlist Name!");
                return;
            }
            else
                MessageBox.Show($"New Playlist Name is {playlistName}");


        }
    }
}