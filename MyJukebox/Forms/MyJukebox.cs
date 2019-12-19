using MyJukebox_EF.DAL;
using NRSoft.FunctionPool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MyJukebox_EF
{
    public partial class MyJukebox : Form
    {
        #region fields
        private bool _isloop = false;
        private bool _tvFilled = false;
        private bool _isSetting = false;
        private double _duration = 0;
        bool _buttonStop = true;
        bool _isPlaying = false;

        private TreeNode rootNode;
        private TreeNode currentTreeNode;
        private TreeNode lastSelectedTreeNode;

        string _placeHolder = $"<Input SQL like Album='V8-A-1'>";

        // FunctionPool functions
        RandomH random = new RandomH();

        List<string> artistImageFiles;

        #endregion local Fields

        #region CTor
        public MyJukebox()
        {
            InitializeComponent();
            MyJukebox_Initialize();
        }
        #endregion CTor

        #region Form Main
        #region Form Main Event Handler
        private void MyJukebox_Load(object sender, EventArgs e)
        {
            var currentDatagrigRow = 0;

            Settings.Load();

            #region restore last window properties
            Top = Settings.FormTop;
            Left = Settings.FormLeft;
            Width = Settings.FormWidth;
            Height = Settings.FormHeight;
            WindowState = (Settings.FormState == "Normal") ? FormWindowState.Normal : FormWindowState.Maximized;
            #endregion

            #region restore query
            TextBoxSearchClear();
            FillQueryCombo();
            if (!string.IsNullOrEmpty(Settings.QueryLastQuery))
            {
                textBoxSearch.Text = Settings.QueryLastQuery;
                textBoxSearch.ForeColor = Colors.Standard;
            }
            #endregion

            #region initialize TreeView
            tvlogicInitialize();
            tvplaylistInitialize();
            TreeviewsFirstFill();
            #endregion

            menuMainFileExit.Tag = "0";    // if not 1 then prompt a message to the user

            statusStripVersion.Text = Settings.Version;
            if (Settings.IsRandom)
                toolStripPlaybackButtonRandom.BackColor = Color.LightSteelBlue;

            toolStripPlaybackTrackBarVolume.Value = Convert.ToInt16(Settings.Volume);

            trackBarVolume_Scroll(this, EventArgs.Empty);
            tabControl.SelectedTab = tabControl.TabPages[Settings.LastTab];

            if (Settings.LastTab == (int)TabcontrolTab.Playlist)
            {
                statusStripGenre.Text = "";
                statusStripKatalog.Text = "";
                statusStripAlbum.Text = "";
                statusStripInterpret.Text = "";
                currentDatagrigRow = Settings.PlaylistCurrentSelected;
            }

            if (Settings.LastTab == (int)TabcontrolTab.Logical)
            {
                statusStripGenre.Text = Settings.LastGenre;
                statusStripKatalog.Text = Settings.LastKatalog;
                statusStripAlbum.Text = Settings.LastAlbum;
                statusStripInterpret.Text = Settings.LastInterpret;
                currentDatagrigRow = Settings.DatagridLastSelectedRow;
            }

            pictureBoxFoto.Image = Properties.Resources.MyBitmap;
            splitContainer1.SplitterDistance = Settings.FormSplitterLeft;

            // first fill
            FillDatagridViewAsynk(Settings.QueryLastQuery);

            //if (dataGridView.RowCount > 0)
            //{
            //    GridViewSetColumsWidth();
            //    dataGridView.CurrentCell = dataGridView[1, currentDatagrigRow];
            //    statusStripRow.Text = Convert.ToString(currentDatagrigRow + 1);
            //}
        }

        private void TreeviewsFirstFill()
        {   // fill treeview with last results
            tvlogicFillGenreAsync();

            tvlogicFillCatalogAsync();

            tvlogicFillAlbumAsync();

            tvlogicFillInterpretAsync();

            tvplaylistFillPlaylist();

            _tvFilled = true;
        }

        private void MyJukebox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.FormState = WindowState.ToString();
            Settings.FormSplitterLeft = splitContainer1.SplitterDistance;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                try
                {
                    Settings.DatagridColums.Add(column.Name, column.Width);
                }
                catch
                {
                    Settings.DatagridColums[column.Name] = column.Width;
                }
            }

            Settings.QueryList.Clear();
            foreach (var q in comboBoxQueries.Items)
            {
                if (q != "")
                    Settings.QueryList.Add(q.ToString());
            }

            Settings.Save();
        }

        private void MyJukebox_ResizeEnd(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Settings.FormWidth = Size.Width;
                Settings.FormHeight = Size.Height;
                Settings.FormTop = Top;
                Settings.FormLeft = Left;
                dataGridView.Refresh();
            }
        }
        #endregion Form Main Event Handler
        #region Form Main Methodes
        private void MyJukebox_Initialize()
        {
            Settings.Initialize();
            Settings.LastRunDate = DateTime.UtcNow.ToString();
            Settings.Version = Properties.Settings.Default.Version;
        }
        #endregion Form Main Methodes
        #endregion Form Main

        #region Menu Main
        #region Menu Event Handlers
        private void menuMainToolsTest1_Click(object sender, EventArgs e)
        {
            #region DatagridContextMenuStrip Items
            /*
                sendToToolStripMenuItem
                rateItemsToolStripMenuItem
                beatToolStripMenuItem
                DatagridContextMenuStripCopyToClip
                editToolStripMenuItem
                setLinkToToolStripMenuItem
                resetErrorflagToolStripMenuItem
                deleteEntrysToolStripMenuItem
                deleteFilesAndEntrysToolStripMenuItem
                openFolderToolStripMenuItem
                setLinkToToolStripMenuItem1
                moveEntryToolStripMenuItem
             */
            #endregion
        }

        private void menuMainToolsTest2_Click(object sender, EventArgs e)
        {
            int n = 0;

            random.InitRandomNumbers(25);
            n = random.GetNextNumber;
            Debug.Print(n.ToString());
            n = random.GetNextNumber;
            Debug.Print(n.ToString());
            n = random.GetNextNumber;
            Debug.Print(n.ToString());
            n = random.GetNextNumber;
            Debug.Print(n.ToString());
            n = random.GetNextNumber;
            Debug.Print(n.ToString());
            n = random.GetNextNumber;
            Debug.Print(n.ToString());
        }

        private void menuMainToolsFileScanner_Click(object sender, EventArgs e)
        {
            Filescanner fs = new Filescanner();
            fs.Show();
        }

        private void menuMainEditRecord_Click(object sender, EventArgs e)
        {
            EditRecord er = new EditRecord();
            er.Show();
        }

        private void menuMainFileExit_Click(object sender, EventArgs e)
        {
            this.menuMainFileExit.Tag = "1";
            this.Close();
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

            if (e.Node.Name == "katalog")
                this.tvlogicFillCatalogAsync();

            if (e.Node.Name == "album")
                tvlogicFillAlbumAsync();

            if (e.Node.Name == "interpret")
                this.tvlogicFillInterpretAsync();
        }

        private void tvlogic_MouseDown(object sender, MouseEventArgs e)
        {
            currentTreeNode = tvlogic.GetNodeAt(e.X, e.Y);
        }

        private void tvlogic_DoubleClick(object sender, EventArgs e)
        {
            tvlogic_Click(null, null);
        }

        private void tvlogic_Click(object sender, EventArgs e)
        {
            string mainNode = "";
            TreeNode tn;
            TextBoxSearchClear();

            if (_isPlaying)
            {
                BeginInvoke(new Action(() => { toolStripPlaybackButtonStop.PerformClick(); }));
            }

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
                tn = tvlogic.SelectedNode;
            }
            else
            {
                return;
            }

            mainNode = tn.Parent.Name;
            //Settings.LastKatalog = "wetert";

            // do nothing if selected node is allready selected
            if (mainNode == "genre" && tn.Text == Settings.LastGenre) return;
            if (mainNode == "katalog" && tn.Text == Settings.LastKatalog) return;
            if (mainNode == "album" && tn.Text == Settings.LastAlbum) return;
            if (mainNode == "interpret" && tn.Text == Settings.LastInterpret) return;

            if (mainNode == "katalog" || mainNode == "genre")
            {
                Settings.LastKatalog = "Alle";
                tvlogicFillAlbumAsync();
                tvlogicFillInterpretAsync();
            }

            if (mainNode == "genre")
            {
                Settings.LastGenre = statusStripGenre.Text = tn.Text;
                TreeviewFindNodeByText(tn.Parent, Settings.LastGenre, true, true);
                tvlogicFillCatalogAsync();
            }

            if (mainNode == "katalog")
            {
                Settings.LastKatalog = statusStripKatalog.Text = tn.Text;
                TreeviewFindNodeByText(tn.Parent, Settings.LastKatalog, true, true);

                tvlogicFillAlbumAsync();
                tvlogicFillInterpretAsync();
            }

            if (mainNode == "album")
            {
                Settings.LastAlbum = statusStripAlbum.Text = tn.Text;
                TreeviewFindNodeByText(tn.Parent, Settings.LastAlbum, true, true);

                if (tvlogic.Nodes["root"].Nodes["Interpret"].Nodes.Count > 1)   // node interpreter wurde bereits aufgeklappt
                {
                    tvlogic.SelectedNode = tvlogic.Nodes["root"].Nodes["Interpret"];
                    TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["Interpret"], "Alle", true, true);
                    Settings.LastInterpret = "Alle";
                }
            }

            if (mainNode == "interpret")
            {
                Settings.LastInterpret = statusStripInterpret.Text = tn.Text;
                TreeviewFindNodeByText(tn.Parent, Settings.LastInterpret, true, true);

                if (tvlogic.Nodes["root"].Nodes["Interpret"].Nodes.Count > 1)   // node album wurde bereits aufgeklappt
                {
                    tvlogic.SelectedNode = tvlogic.Nodes["root"].Nodes["Album"];
                    TreeviewFindNodeByText(tvlogic.Nodes["root"].Nodes["Album"], "Alle", true, true);
                    Settings.LastAlbum = "Alle";
                }
            }

            lastSelectedTreeNode = currentTreeNode;

            Debug.Print("tvlogic_Click");
            FillDatagridView();
            random.InitRandomNumbers(dataGridView.RowCount - 1, 0);
            //GridViewSetColumsWidth();

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
            tnPlaylist.SelectedImageKey = "playlist";

            TreeNode tnAlle = tnPlaylist.Nodes.Add("playlist_alle", "Alle");
            tnAlle.ImageKey = "playlist";
            tnAlle.SelectedImageKey = "playlist";
            tnAlle.Tag = "0";

            rootNode.ExpandAll();
        }
        #endregion

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
            if (bClearColor) this.TreeviewClearNodeBackColor(startNode);

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

        #endregion

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

        #endregion

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

            genres = await GetGenresAsync();

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

            TreeviewFindNodeByText(tngenre, Settings.LastGenre, true, false);
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
            statusStripKatalog.Text = Settings.LastKatalog;

            catalogues = await GetKatalogsAsync();

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

            TreeviewFindNodeByText(tnkatalog, Settings.LastKatalog, true, false);
            tvlogic.EndUpdate();
        }

        private async Task tvlogicFillAlbumAsync()
        {
            string mainNode = "album";
            List<string> albums = null;

            albums = await GetAlbumsAsync();

            if (Settings.LastGenre == "Alle" || Settings.LastKatalog == "Alle")
            {
                tvlogic.Nodes["root"].Nodes["album"].Nodes.Clear();
                tvlogic.Nodes["root"].Nodes["album"].Nodes.Add("album_alle", "Alle");
                tvlogic.Nodes["root"].Nodes["album"].FirstNode.ImageKey = "album";
                tvlogic.Nodes["root"].Nodes["album"].FirstNode.SelectedImageKey = "album";
                Settings.LastAlbum = "Alle";
                statusStripAlbum.Text = "Alle";
                return;
            }

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

            TreeviewFindNodeByText(tnalbum, Settings.LastAlbum, true, false);
            tvlogic.EndUpdate();
        }

        private async Task tvlogicFillInterpretAsync()
        {
            string mainNode = "interpret";
            List<string> interpreters = null;

            interpreters = await GetInterpretenAsync();

            if (Settings.LastGenre == "Alle" || Settings.LastKatalog == "Alle")
            {
                tvlogic.Nodes["root"].Nodes[mainNode].Nodes.Clear();
                tvlogic.Nodes["root"].Nodes[mainNode].Nodes.Add(mainNode + "_alle", "Alle");
                tvlogic.Nodes["root"].Nodes[mainNode].FirstNode.ImageKey = mainNode;
                tvlogic.Nodes["root"].Nodes[mainNode].FirstNode.SelectedImageKey = mainNode;
                Settings.LastInterpret = "Alle";
                statusStripInterpret.Text = "Alle";
                return;
            }

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

                TreeviewFindNodeByText(tninterpret, Settings.LastInterpret, true, false);
                tvlogic.EndUpdate();
            }
        }

        #endregion TreeView tvlogic Methodes
        #endregion Treeview tvlogic

        #region Treeview tvplaylist
        #region Treeview tvplaylist Events
        private void tvplaylist_DoubleClick(object sender, EventArgs e)
        {
            tvplaylist_Click(sender, e);
        }

        private void tvPlaylist_MouseDown(object sender, MouseEventArgs e)
        {
            currentTreeNode = tvplaylist.GetNodeAt(e.X, e.Y);
        }

        private void tvplaylist_Click(object sender, EventArgs e)
        {
            Debug.Print("tvplaylist_Click");

            TextBoxSearchClear();
            TreeNode tn = new TreeNode();
            if (currentTreeNode.FirstNode == null)
            {
                tvplaylist.SelectedNode = currentTreeNode;
                tvplaylist.SelectedNode.BackColor = Color.DodgerBlue;
                tvplaylist.SelectedNode.ForeColor = Color.Gold;
                tn = tvplaylist.SelectedNode;
            }
            else
            {
                return;
            }

            Settings.PlaylistCurrentName = tn.Text;
            Settings.PlaylistCurrentID = Convert.ToInt32(tn.Tag);
            TreeviewFindNodeByText(tn.Parent, Settings.PlaylistCurrentName, true, true);

            FillDatagridView();
            random.InitRandomNumbers(dataGridView.RowCount - 1);
            GridViewSetColumsWidth();

            int row = Settings.PlaylistCurrentSelected;
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows[row].Selected = true;
                statusStripRow.Text = (row + 1).ToString();
                statusStripRowcount.Text = dataGridView.RowCount.ToString();
                statusStripTitel.Text = dataGridView.Rows[row].Cells[1].Value + " - " + dataGridView.Rows[row].Cells[2].Value;
            }
            else
            {
                statusStripRow.Text = (row).ToString();
                statusStripRowcount.Text = (row).ToString();
            }
        }
        #endregion  Treeview tvplaylist Events

        #region Treeview tvplaylist Methodes
        private async void tvplaylistFillPlaylist()
        {
            string mainNode = "playlists";
            List<Playlist> playlistEntries = null;

            playlistEntries = await GetPlaylistsAsync();

            TreeNode treeNode = tvplaylist.Nodes["root"].Nodes[mainNode];

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
            }

            foreach (var entry in playlistEntries)
            {
                ToolStripMenuItem subitem = new ToolStripMenuItem();
                subitem.Text = CamelSpaceOut(entry.Name);
                subitem.Name = entry.Name;
                subitem.Tag = entry.ID;
                subitem.Click += ContextMenuStripPlaylists_Click;
                DatagridContextMenuStripSendToPlaylist.DropDownItems.Add(subitem);
            }

            TreeNodeCollection tnc = tvplaylist.Nodes;
            TreeviewFindNodeByText(treeNode, Settings.PlaylistCurrentName, true, false);
        }
        #endregion Treeview tvplaylist Methodes
        #endregion Treeview tvplaylist

        #region Datagrid Methods and Events
        #region Datagrid Events
        private void dataGridView_Click(object sender, EventArgs e)
        {
            int rowselected;
            rowselected = dataGridView.SelectedRows[0].Index + 1;
            statusStripRow.Text = (rowselected).ToString();
        }

        private void dataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (_isSetting == false)
                Settings.DatagridColums[e.Column.Name] = e.Column.Width;
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
        #endregion Datagrid Events

        #region DataGrid Methodes
        public void FillDatagridView()
        {
            FillDatagridViewAsynk(string.Empty);
        }

        public async Task FillDatagridViewAsynk(string filter)
        {
            bool isQuery = IsQuery(filter);
            List<vSongsNewShort> songs = new List<vSongsNewShort>();

            if (isQuery)
            {
                var results = await GetQueryResultAsync();

                int currentDatagrigRow = 0;

                if (Settings.LastTab == (int)TabcontrolTab.Logical)
                    currentDatagrigRow = Settings.DatagridLastSelectedRow;

                dataGridView.DataSource = results;

                if (dataGridView.RowCount > 0)
                {
                    dataGridView.Columns["ID"].Visible = false;
                    GridViewSetColumsWidth();
                    dataGridView.CurrentCell = dataGridView[1, currentDatagrigRow];
                    statusStripRow.Text = Convert.ToString(currentDatagrigRow + 1);
                }

                return;
            }

            if (tabControl.SelectedTab == tabLogical)
            {
                //_gridFilled = false;

                var results = await GetTablogicalResultsAsync();

                int currentDatagrigRow = 0;

                dataGridView.DataSource = results;

                if (dataGridView.RowCount > 0)
                {
                    dataGridView.Columns["ID"].Visible = false;
                    GridViewSetColumsWidth();
                    dataGridView.CurrentCell = dataGridView[1, currentDatagrigRow];
                    statusStripRow.Text = Convert.ToString(currentDatagrigRow + 1);
                }

            }

            if (tabControl.SelectedTab == tabPlayLists)
            {
                GetPlaylistEntries();
            }

            Settings.QueryLastQuery = "";

            try
            {
                if (dataGridView.CurrentRow != null)
                {
                    dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.SelectedRows[0].Index;

                    statusStripRow.Text = Convert.ToString(dataGridView.CurrentRow.Index + 1);
                    statusStripRowcount.Text = this.dataGridView.RowCount.ToString();
                }

                dataGridView.Columns["ID"].Visible = false;
                //dataGridView.Columns["K1"].Visible = false;
                //dataGridView.Columns["K2"].Visible = false;
                //dataGridView.Columns["Voting"].Visible = false;
                //dataGridView.Columns["Beat"].Visible = false;

                dataGridView.ResumeLayout();
            }
            catch (Exception ex)
            {
                Debug.Print($"FillDatagridView_Error: {ex.Message}");
            }

            statusStripTitel.Text = "";
            random.InitRandomNumbers(dataGridView.RowCount - 1);
        }

        private bool IsQuery(string filter)
        {
            bool IsQuery = false;

            if (filter == "" || filter == _placeHolder)
                IsQuery = false;
            else
                IsQuery = true;
            return IsQuery;
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
                Settings.QueryList.Add(query);
            }
        }

        private void GridViewSetColumsWidth()
        {
            _isSetting = true;
            if (dataGridView.ColumnCount > 0)
            {
                foreach (var column in Settings.DatagridColums)
                {
                    string columnName = column.Key;
                    int columnWidth = column.Value;

                    if (dataGridView.Columns[columnName] != null)
                        dataGridView.Columns[columnName].Width = columnWidth;
                }
            }
            _isSetting = false;
        }

        #endregion DataGrid Methodes
        #endregion Datagrid

        #region toolStrip Button Events
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
                dataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Colors.Played;
                Settings.DatagridLastSelectedRow = currentRow; // 0 based

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
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timerImageFlip.Enabled = false;

            //ToDo: place a timeout thred
            Task.Delay(TimeSpan.FromSeconds(2.0));
            pictureBoxFoto.Image = Properties.Resources.MyBitmap;
        }

        private void toolStripPlaybackButtonNext_Click(object sender, EventArgs e)
        {
            Debug.Print("buttonNext_Click");
            int currentRow = dataGridView.CurrentRow.Index;

            if ((currentRow < dataGridView.RowCount - 1) && !Settings.IsRandom)
            {
                var columsCount = dataGridView.ColumnCount - 1;
                dataGridView.Rows[++currentRow].Cells[2].Selected = true;
            }
            else if (Settings.IsRandom)
            {
                var nextRow = random.GetNextNumber;
                //var columsCount = dataGridView.ColumnCount - 1;
                dataGridView.Rows[nextRow].Cells[2].Selected = true;
            }

            BeginInvoke(new Action(() => { toolStripPlaybackButtonPlay.PerformClick(); }));
        }

        private void toolStripButtonRandom_Click(object sender, EventArgs e)
        {
            _isloop = false;
            toolStripPlaybackButtonLoop.Checked = false;
            toolStripPlaybackButtonLoop.BackColor = Color.LightSlateGray;

            Settings.IsRandom = !Settings.IsRandom;
            if (Settings.IsRandom)
                toolStripPlaybackButtonRandom.BackColor = Color.LightSteelBlue;
            else
                toolStripPlaybackButtonRandom.BackColor = Color.LightSlateGray;

            toolStripPlayback.Refresh();
            //Debug.Print($"toolStripButtonRandom_Click: Checked={toolStripPlaybackButtonRandom.Checked}, " +
            //    $"BackColor= {toolStripPlaybackButtonRandom.BackColor}");
        }

        private void toolStripPlaybackButtonLoop_Click(object sender, EventArgs e)
        {
            Settings.IsRandom = false;
            toolStripPlaybackButtonRandom.Checked = false;
            toolStripPlaybackButtonRandom.BackColor = Color.LightSlateGray;

            _isloop = !_isloop;
            if (_isloop)
                toolStripPlaybackButtonLoop.BackColor = Color.LightSteelBlue;
            else
                toolStripPlaybackButtonLoop.BackColor = Color.LightSlateGray;

            toolStripPlayback.Refresh();
            Debug.Print($"toolStripButtonLoop_Click: checked={toolStripPlaybackButtonLoop.Checked}, " +
                        $"BackColor={toolStripPlaybackButtonLoop.BackColor}");
        }

        private void toolStripPlaybackButtonSpeaker_Click(object sender, EventArgs e)
        {
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
            Debug.Print("");
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

        #endregion

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
            Settings.Volume = toolStripPlaybackTrackBarVolume.Value;
            if (toolStripPlaybackTrackBarVolume.Value == 0)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                toolTipVolume.SetToolTip(toolStripPlaybackTrackBarVolume, "Mute");
                toolStripPlaybackButtonSpeaker.Image = Properties.Resources.SpeakerOff.ToBitmap();
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                toolTipVolume.SetToolTip(toolStripPlaybackTrackBarVolume, "Volume " + toolStripPlaybackTrackBarVolume.Value.ToString() + "%");
                toolStripPlaybackButtonSpeaker.Image = Properties.Resources.SpeakerOn.ToBitmap();
            }
        }

        #endregion trackBar Events

        #region tabControl Events
        private void tabControl_Click(object sender, EventArgs e)
        {
            Debug.Print("tabControl_Click");
            Debug.Print(sender.ToString());

            TextBoxSearchClear();
            int intTabIndex = tabControl.SelectedIndex;

            switch (intTabIndex)
            {
                case 0:     // logical
                    string strLastAlbum = Settings.LastAlbum;
                    if (strLastAlbum != "Alle")
                    {
                        tvlogic.Nodes["root"].Nodes["album"].ExpandAll();
                        tvlogic.Nodes["root"].Nodes["album"].Tag = strLastAlbum;
                    }
                    string strLastInterpret = Settings.LastInterpret;
                    if (strLastInterpret != "Alle")
                    {
                        tvlogic.Nodes["root"].Nodes["interpret"].ExpandAll();
                        tvlogic.Nodes["root"].Nodes["interpret"].Tag = strLastInterpret;
                    }

                    Debug.Print("tvplaylist_Click");
                    FillDatagridView();


                    //' column breite setzen
                    GridViewSetColumsWidth();
                    break;

                case 1:     // playlist
                    Debug.Print("tabControl_Click");
                    FillDatagridView();


                    GridViewSetColumsWidth();
                    break;

                case 2:     // Folders and files
                    break;
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            Console.WriteLine("tabControl_Selecting");
            Console.WriteLine(sender.ToString());

            //int intTabIndex = tabControl.SelectedIndex;
            //rh.SaveSetting("Settings", "LastTab", intTabIndex.ToString());

            //switch (intTabIndex)
            //{
            //    case 0:     // logical
            //        string strLastAlbum = rh.GetSetting("Settings\\Logical\\Album", "LastAlbum", "Alle");
            //        if (strLastAlbum != "Alle")
            //        {
            //            tvlogic.Nodes["root"].Nodes["album"].ExpandAll();
            //            tvlogic.Nodes["root"].Nodes["album"].Tag = strLastAlbum;
            //        }
            //        string strLastInterpret = rh.GetSetting("Settings\\Logical\\Interpret", "LastInterpret", "Alle");
            //        if (strLastInterpret != "Alle")
            //        {
            //            tvlogic.Nodes["root"].Nodes["interpret"].ExpandAll();
            //            tvlogic.Nodes["root"].Nodes["interpret"].Tag = strLastInterpret;
            //        }
            //        FillDatagridView();
            //        //' column breite setzen
            //        GridViewSetColums();
            //        break;

            //    case 1:     // playlist
            //        // tvplaylist_Fill();
            //        // GridViewSetFilter();
            //        //' column breite setzen
            //        // GridViewSetColums();

            //        break;

            //    case 2:
            //        break;
            //}
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentTabIndex = tabControl.SelectedIndex;
            switch (currentTabIndex)
            {
                case (int)TabcontrolTab.Logical:
                    string strLastAlbum = Settings.LastAlbum;
                    if (strLastAlbum != "Alle")
                    {
                        tvlogic.Nodes["root"].Nodes["album"].ExpandAll();
                        tvlogic.Nodes["root"].Nodes["album"].Tag = strLastAlbum;
                    }
                    string strLastInterpret = Settings.LastInterpret;
                    if (strLastInterpret != "Alle")
                    {
                        tvlogic.Nodes["root"].Nodes["interpret"].ExpandAll();
                        tvlogic.Nodes["root"].Nodes["interpret"].Tag = strLastInterpret;
                    }
                    //FillDatagridView();
                    //' column breite setzen
                    //GridViewSetColumsWidth();
                    break;

                case (int)TabcontrolTab.Playlist:
                    //FillDatagridView();
                    //GridViewSetColumsWidth();
                    break;

                case (int)TabcontrolTab.Explorer:
                    break;
            }

            Settings.LastTab = currentTabIndex;

            Debug.Print("tabControl_Click");
            //FillDatagridView();
            //GridViewSetColumsWidth();

        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("tabControl_TabIndexChanged");
        }

        #endregion tabControl Events

        #region other controls
        private void buttonQueryExecute_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != _placeHolder)
                FillDatagridViewAsynk(textBoxSearch.Text);
        }

        private void buttonQueryhSave_Click(object sender, EventArgs e)
        {
            AddQueryToComboBox(textBoxSearch.Text);
        }

        private void tvlogicContextMenuStripAdd_Click(object sender, EventArgs e)
        {
            string strAdd, strMainNode;

            TreeNode xNod = this.tvlogic.SelectedNode;

            strMainNode = xNod.Parent.Text.ToString();
            //string strLastKatalog = registry.GetSetting(@"Settings\Logical\" + strMainNode, "LastKatalog", "Alle");

            //if (strLastKatalog != "Alle")
            //    strAdd = strLastKatalog + "," + xNod.Text;
            //else
            //    strAdd = xNod.Text;

            //registry.SaveSetting(@"Settings\Logical\" + strMainNode, "LastKatalog", strAdd);

            TreeviewFindNodeByText(xNod.Parent, xNod.Text, true, false);

            Debug.Print("tvlogicContextMenuStripAdd_Click");
            FillDatagridView();


            GridViewSetColumsWidth();
        }

        private void DatagridContextMenuStripCopyToClip_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView.CurrentCellAddress.Y;
            int c = this.dataGridView.CurrentCellAddress.X;

            string strCellInhalt = this.dataGridView.Rows[r].Cells[c].Value.ToString();
            Console.WriteLine(strCellInhalt);

            Clipboard.Clear();
            Clipboard.SetText(strCellInhalt);
        }

        private void buttonQueryClear_Click(object sender, EventArgs e)
        {
            TextBoxSearchClear();
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
            var pos = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            toolStripPlaybackTrackBarPosition.Value = pos;

            //var max = toolStripPlaybackTrackBarPosition.Maximum;

            var val = pos / (toolStripPlaybackTrackBarPosition.Maximum / 100);

            toolTipPosition.SetToolTip(toolStripPlaybackTrackBarPosition, "Position " + val.ToString() + "%");
            statusStripPosition.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }
        #endregion Timer Events

        #region Public Methodes
        public void FillQueryCombo()
        {
            comboBoxQueries.Items.Clear();

            if (Settings.QueryList.Count > 0)
            {
                comboBoxQueries.Items.Add("");
                foreach (var q in Settings.QueryList)
                {
                    comboBoxQueries.Items.Add(q);
                }
            }
        }

        public bool ImportData(MP3Record mp3Data, bool Test)
        {
            //const string scQuelle = "ImportData";
            //var dh = factory.GetDatabaseH(Factory.dbType.mssql);
            string _testTable = "tTestImport";
            string _mainTable = "vSongsNewShort";
            string Katalog, Owner, Media, Album, Interpret, Titel, Genre, Path, FileName, SQL, TableName, MD5;
            long FileSize;
            DateTime FileDate;

            TableName = (Test) ? _testTable : _mainTable;

            Katalog = mp3Data.Katalog;
            Owner = mp3Data.Owner;
            Media = mp3Data.Media;
            Album = mp3Data.Album;
            Interpret = mp3Data.Interpret;
            Titel = mp3Data.Titel;
            Genre = mp3Data.Genre;
            Path = mp3Data.Path;
            FileName = mp3Data.FileName;
            FileSize = mp3Data.FileSize;
            FileDate = mp3Data.FileDate;
            MD5 = mp3Data.MD5;

            SQL = "insert into " + TableName + " (katalog, quelle, medium, interpret, album, titel, genre, pfad, filename, filesize, filedate, md5) " +
                "values (" + "\"" +
                Katalog + "\",\"" +
                Owner + "\",\"" +
                Media + "\",\"" +
                Interpret + "\",\"" +
                Album + "\",\"" +
                Titel + "\",\"" +
                Genre + "\",\"" +
                Path + "\",\"" +
                FileName + "\",'" +
                FileSize + "','" +
                FileDate + "','" +
                MD5 + "')";
            Console.WriteLine(SQL);
            try
            {
                //dh.ExecuteNonQuery(SQL);
                return true;
            }
            catch
            {
                //    al.FaultType = alError
                //    al.FaultSource = scQuelle
                //    al.FaultMsg = Err.Description
                //    al.AddEntry

                return false;
            }
            finally { };
        }

        public string QueryBuilder()
        {
            string and, query, temp, strGenre, katalog, album, interpret;

            Hashtable ht = new Hashtable();

            strGenre = "";
            if (Settings.LastGenre != "Alle")
            {
                ht.Add("genre", Settings.LastGenre);
                strGenre = " genre LIKE '" + Settings.LastGenre + "'";
            }

            katalog = "";
            if (Settings.LastKatalog != "Alle")
            {
                ht.Add("katalog", Settings.LastKatalog);
                katalog = " katalog LIKE '" + Settings.LastKatalog + "'";
            }

            if (Settings.LastAlbum != "Alle")
            {
                ht.Add("album", Settings.LastAlbum);
                album = $" album LIKE '{Settings.LastAlbum}'";
            }

            if (Settings.LastInterpret != "Alle")
            {
                ht.Add("interpret", Settings.LastInterpret);
                interpret = $" interpret LIKE '{Settings.LastInterpret}'";
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

        private void FlipImage(DataGridViewRow dgrow)
        {
            var path = dgrow.Cells["Pfad"].Value.ToString();
            var artist = dgrow.Cells["Interpret"].Value.ToString();

            List<string> pathList = new List<string>();
            var genre = dgrow.Cells["Genre"].Value.ToString();
            pathList.Add(Path.Combine(Settings.RootImagePath, genre, Settings.ImagePath));
            pathList.Add(path);
            pathList.Add(Path.Combine(path, Settings.ImagePath));
            var collector = new ImageCollector(pathList, artist);

            artistImageFiles = new List<string>();
            artistImageFiles = collector.GetImagesFullName();
            timerImageFlip.Enabled = true;
        }

        #endregion Public Methodes

        private string CamelSpaceOut(string str)
        {
            for (int i = 1; i < str.Length; i++)
                if (Char.IsUpper(str[i]))
                    str = str.Insert(i++, " ");
            return str;
        }

        private void comboBoxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxSearchClear();
            toolStripPlaybackButtonStop.PerformClick();

            if (comboBoxQueries.Text != "")
            {
                int item = comboBoxQueries.SelectedIndex;
                textBoxSearch.Text = comboBoxQueries.Text;
                textBoxSearch.ForeColor = Color.Black;
                textBoxSearch.Refresh();
                Settings.QueryLastQuery = comboBoxQueries.Text;
            }

            buttonQueryExecute.PerformClick();
        }

        // ToDo: Make async
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new MyJukeboxEntities())
            {
                var result = context.vSongsNewShort
                            .Where(a => a.Genre == Settings.LastGenre && a.Catalog == Settings.LastKatalog)
                            .Select(a => a.Album)
                            .Distinct().OrderBy(a => a);

                result.ToList();
            }
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
        #endregion

        private void ContextMenuStripPlaylists_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            var titelID = dataGridView.CurrentRow.Cells[0].Value;
            var playListName = item.Name;

            var context = new MyJukeboxEntities();
            var playlist = context.tPlaylists
                                .Where(p => p.Name == playListName)
                                .Select(p => p.ID);

            int playlistID = -1;

            foreach (var a in playlist)
            {
                playlistID = a;
            }

            Debug.Print($"Titel={titelID} => {playListName}, ID={playlistID}");

            //var entry = new tPLentries()
            //{
            //    PLID = playlistID,
            //    SongID = (int)titelID,
            //    Pos = 1
            //};

            //context.tPLentries.Add(entry);
            //context.SaveChanges();

        }

        private void DatagridContextMenuStripRating_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            var rating = item.Tag.ToString();
            var titelID = dataGridView.CurrentRow.Cells[0].Value;
            Debug.Print($"Titel={titelID} => {rating}");

            //var context = new MyJukeboxEntities();
            //var result = context.tInfos.SingleOrDefault(s => s.ID_Song == (int)titelID);

            //if (result != null)
            //{
            //    result.Rating = Convert.ToInt32(rating);
            //    context.SaveChanges();
            //}
            //else
            //{
            //    var info = new tInfos()
            //    {
            //        ID_Song = (int)titelID,
            //        Rating = Convert.ToInt32(rating)
            //    };
            //    context.tInfos.Add(info);
            //    context.SaveChanges();
            //}
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == _placeHolder)
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = _placeHolder;
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void TextBoxSearchClear()
        {
            textBoxSearch.Text = _placeHolder;
            textBoxSearch.ForeColor = Color.Gray;
        }

        #region Data Getters
        private async Task<List<vSongsNewShort>> GetQueryResultAsync()
        {
            List<vSongsNewShort> songs = null;

            try
            {
                var arTokens = textBoxSearch.Text.Split('=');
                var search = arTokens[0];
                var argument = arTokens[1];

                if (argument.Substring(0, 1) == "'")
                    argument = argument.Substring(1);

                if (argument.Substring(argument.Length - 1, 1) == "'")
                    argument = argument.Substring(0, argument.Length - 1);

                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    try
                    {
                        songs = context.vSongsNewShort
                            .SqlQuery($"select * from vSongsNewShort where {search} like '%{argument}%'").ToList();
                    }
                    catch
                    {

                    }

                });

                return songs;
            }
            catch
            {
                return null;
            }
        }

        private async Task<List<vSongsNewShort>> GetTablogicalResultsAsync()
        {
            List<vSongsNewShort> songs = null;

            try
            {
                var genre = Settings.LastGenre == "Alle" ? "" : Settings.LastGenre;
                var album = Settings.LastAlbum == "Alle" ? "" : Settings.LastAlbum;
                var catalog = Settings.LastKatalog == "Alle" ? "" : Settings.LastKatalog;
                var artist = Settings.LastInterpret == "Alle" ? "" : Settings.LastInterpret;

                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    songs = context.vSongsNewShort
                        .Where(s => (s.Genre.Contains(genre)) &&
                            (s.Catalog.Contains(catalog)) &&
                            (s.Album.Contains(album)) &&
                            (s.Interpret.Contains(artist))
                            ).ToList();
                });

                return songs;

            }
            catch
            {
                return null;
            }
        }

        private async Task GetPlaylistEntries()
        {
            List<vPlaylistSong> songs = null;

            try
            {
                var context = new MyJukeboxEntities();

                await Task.Run(() =>
                {
                    songs = context.vPlaylistSongs
                        .Where(i => i.PLID == Settings.PlaylistCurrentID).ToList();
                });

                dataGridView.SuspendLayout();
                dataGridView.DataSource = songs;
            }
            catch
            { }
        }

        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            List<Playlist> playLists = new List<Playlist>();

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    var playlists = context.tPlaylists
                                 .OrderBy(p => p.Name)
                                 .Select(p => new { p.ID, p.Name, p.Pos });

                    foreach (var p in playlists)
                    {
                        playLists.Add(new Playlist { ID = p.ID, Name = p.Name, Pos = p.Pos });
                    }

                });

                return playLists;
            }
        }

        public async Task<List<string>> GetGenresAsync()
        {
            List<string> genres = null;
            var context = new MyJukeboxEntities();
            await Task.Run(() =>
            {
                genres = context.vSongsNewShort
                    .Select(g => g.Genre).Distinct().OrderBy(g => g).ToList();
            });
            return genres;
        }

        public async Task<List<string>> GetKatalogsAsync()
        {
            List<string> catalogues = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    catalogues = context.vSongsNewShort
                                        .Where(c => c.Genre == Settings.LastGenre)
                                        .Select(c => c.Catalog)
                                        .Distinct().OrderBy(c => c).ToList();
                });

                return catalogues;
            }
        }

        public async Task<List<string>> GetAlbumsAsync()
        {
            List<string> albums = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    albums = context.vSongsNewShort
                                    .Where(a => a.Genre == Settings.LastGenre && a.Catalog == Settings.LastKatalog)
                                    .Select(a => a.Album)
                                    .Distinct().OrderBy(a => a).ToList();
                });

                return albums;
            }
        }

        public async Task<List<string>> GetInterpretenAsync()
        {
            List<string> interprer = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    interprer = context.vSongsNewShort
                                    .Where(i => i.Genre == Settings.LastGenre && i.Catalog == Settings.LastKatalog)
                                    .Select(i => i.Interpret)
                                    .Distinct().OrderBy(i => i).ToList();
                });

                return interprer;
            }
        }
        #endregion
    }
}
