namespace MyJukebox_EF
{
    partial class EditRecord
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
            this.chechBoxSampler = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.checkBoxError = new System.Windows.Forms.CheckBox();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxFilesize = new System.Windows.Forms.TextBox();
            this.textBoxFiledate = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxBeat = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxPlayed = new System.Windows.Forms.TextBox();
            this.textboxComment = new System.Windows.Forms.TextBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.textBoxInterpret = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Label121 = new System.Windows.Forms.Label();
            this.Label119 = new System.Windows.Forms.Label();
            this.Label118 = new System.Windows.Forms.Label();
            this.Label117 = new System.Windows.Forms.Label();
            this.Label116 = new System.Windows.Forms.Label();
            this.Label115 = new System.Windows.Forms.Label();
            this.Label114 = new System.Windows.Forms.Label();
            this.Label113 = new System.Windows.Forms.Label();
            this.Label112 = new System.Windows.Forms.Label();
            this.Label111 = new System.Windows.Forms.Label();
            this.Label110 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxCatalog = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chechBoxSampler
            // 
            this.chechBoxSampler.BackColor = System.Drawing.Color.Silver;
            this.chechBoxSampler.Location = new System.Drawing.Point(310, 331);
            this.chechBoxSampler.Name = "chechBoxSampler";
            this.chechBoxSampler.Size = new System.Drawing.Size(17, 17);
            this.chechBoxSampler.TabIndex = 12;
            this.chechBoxSampler.UseVisualStyleBackColor = false;
            this.chechBoxSampler.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(272, 421);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 25);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(160, 421);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 25);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.Location = new System.Drawing.Point(422, 331);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(17, 17);
            this.checkBoxHide.TabIndex = 14;
            this.checkBoxHide.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // checkBoxError
            // 
            this.checkBoxError.Location = new System.Drawing.Point(366, 331);
            this.checkBoxError.Name = "checkBoxError";
            this.checkBoxError.Size = new System.Drawing.Size(17, 17);
            this.checkBoxError.TabIndex = 13;
            this.checkBoxError.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(16, 220);
            this.textBoxFilename.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(452, 20);
            this.textBoxFilename.TabIndex = 8;
            this.textBoxFilename.Text = "Filename";
            this.textBoxFilename.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(16, 173);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(452, 20);
            this.textBoxPath.TabIndex = 7;
            this.textBoxPath.Text = "Path";
            this.textBoxPath.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // textBoxFilesize
            // 
            this.textBoxFilesize.Location = new System.Drawing.Point(16, 273);
            this.textBoxFilesize.Name = "textBoxFilesize";
            this.textBoxFilesize.Size = new System.Drawing.Size(105, 20);
            this.textBoxFilesize.TabIndex = 17;
            this.textBoxFilesize.Text = "Filesize";
            this.textBoxFilesize.Enter += new System.EventHandler(this.FileValue_Changed);
            // 
            // textBoxFiledate
            // 
            this.textBoxFiledate.Location = new System.Drawing.Point(148, 273);
            this.textBoxFiledate.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.textBoxFiledate.Name = "textBoxFiledate";
            this.textBoxFiledate.Size = new System.Drawing.Size(114, 20);
            this.textBoxFiledate.TabIndex = 18;
            this.textBoxFiledate.Text = "Filedate";
            this.textBoxFiledate.Enter += new System.EventHandler(this.FileValue_Changed);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(289, 273);
            this.textBoxDuration.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(114, 20);
            this.textBoxDuration.TabIndex = 19;
            this.textBoxDuration.Text = "Duration";
            this.textBoxDuration.Enter += new System.EventHandler(this.FileValue_Changed);
            // 
            // textBoxBeat
            // 
            this.textBoxBeat.Location = new System.Drawing.Point(168, 327);
            this.textBoxBeat.Name = "textBoxBeat";
            this.textBoxBeat.Size = new System.Drawing.Size(41, 20);
            this.textBoxBeat.TabIndex = 11;
            this.textBoxBeat.Text = "Beat";
            this.textBoxBeat.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(100, 327);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(41, 20);
            this.textBoxRating.TabIndex = 10;
            this.textBoxRating.Text = "Rating";
            this.textBoxRating.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // textBoxPlayed
            // 
            this.textBoxPlayed.Location = new System.Drawing.Point(16, 327);
            this.textBoxPlayed.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxPlayed.Name = "textBoxPlayed";
            this.textBoxPlayed.Size = new System.Drawing.Size(57, 20);
            this.textBoxPlayed.TabIndex = 9;
            this.textBoxPlayed.Text = "Played";
            this.textBoxPlayed.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // textboxComment
            // 
            this.textboxComment.Location = new System.Drawing.Point(16, 374);
            this.textboxComment.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textboxComment.Name = "textboxComment";
            this.textboxComment.Size = new System.Drawing.Size(269, 20);
            this.textboxComment.TabIndex = 15;
            this.textboxComment.Text = "Comment";
            this.textboxComment.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(16, 126);
            this.textBoxTitel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(452, 20);
            this.textBoxTitel.TabIndex = 6;
            this.textBoxTitel.Text = "Titel";
            this.textBoxTitel.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // textBoxInterpret
            // 
            this.textBoxInterpret.ForeColor = System.Drawing.Color.Black;
            this.textBoxInterpret.Location = new System.Drawing.Point(272, 80);
            this.textBoxInterpret.Name = "textBoxInterpret";
            this.textBoxInterpret.Size = new System.Drawing.Size(196, 20);
            this.textBoxInterpret.TabIndex = 5;
            this.textBoxInterpret.Text = "Interpret";
            this.textBoxInterpret.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(16, 79);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(233, 20);
            this.textBoxAlbum.TabIndex = 4;
            this.textBoxAlbum.Text = "Album";
            this.textBoxAlbum.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Location = new System.Drawing.Point(326, 374);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(113, 20);
            this.textBoxMedia.TabIndex = 16;
            this.textBoxMedia.Text = "Media";
            this.textBoxMedia.Enter += new System.EventHandler(this.InfoValue_Changed);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(16, 32);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(105, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.Text = "ID";
            // 
            // Label121
            // 
            this.Label121.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label121.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label121.Location = new System.Drawing.Point(310, 311);
            this.Label121.Name = "Label121";
            this.Label121.Size = new System.Drawing.Size(47, 17);
            this.Label121.TabIndex = 45;
            this.Label121.Text = "Sampler";
            // 
            // Label119
            // 
            this.Label119.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label119.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label119.Location = new System.Drawing.Point(422, 311);
            this.Label119.Name = "Label119";
            this.Label119.Size = new System.Drawing.Size(47, 17);
            this.Label119.TabIndex = 37;
            this.Label119.Text = "Hide";
            // 
            // Label118
            // 
            this.Label118.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label118.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label118.Location = new System.Drawing.Point(366, 311);
            this.Label118.Name = "Label118";
            this.Label118.Size = new System.Drawing.Size(46, 17);
            this.Label118.TabIndex = 36;
            this.Label118.Text = "Error";
            // 
            // Label117
            // 
            this.Label117.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label117.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label117.Location = new System.Drawing.Point(16, 204);
            this.Label117.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label117.Name = "Label117";
            this.Label117.Size = new System.Drawing.Size(105, 17);
            this.Label117.TabIndex = 34;
            this.Label117.Text = "Filename";
            // 
            // Label116
            // 
            this.Label116.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label116.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label116.Location = new System.Drawing.Point(16, 157);
            this.Label116.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label116.Name = "Label116";
            this.Label116.Size = new System.Drawing.Size(105, 17);
            this.Label116.TabIndex = 32;
            this.Label116.Text = "Path";
            // 
            // Label115
            // 
            this.Label115.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label115.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label115.Location = new System.Drawing.Point(16, 257);
            this.Label115.Name = "Label115";
            this.Label115.Size = new System.Drawing.Size(105, 17);
            this.Label115.TabIndex = 30;
            this.Label115.Text = "Filesize";
            // 
            // Label114
            // 
            this.Label114.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label114.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label114.Location = new System.Drawing.Point(148, 257);
            this.Label114.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.Label114.Name = "Label114";
            this.Label114.Size = new System.Drawing.Size(114, 17);
            this.Label114.TabIndex = 28;
            this.Label114.Text = "Filedate";
            // 
            // Label113
            // 
            this.Label113.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label113.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label113.Location = new System.Drawing.Point(289, 257);
            this.Label113.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.Label113.Name = "Label113";
            this.Label113.Size = new System.Drawing.Size(114, 17);
            this.Label113.TabIndex = 26;
            this.Label113.Text = "Duration";
            // 
            // Label112
            // 
            this.Label112.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label112.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label112.Location = new System.Drawing.Point(168, 311);
            this.Label112.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.Label112.Name = "Label112";
            this.Label112.Size = new System.Drawing.Size(41, 17);
            this.Label112.TabIndex = 24;
            this.Label112.Text = "Beat";
            // 
            // Label111
            // 
            this.Label111.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label111.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label111.Location = new System.Drawing.Point(100, 311);
            this.Label111.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.Label111.Name = "Label111";
            this.Label111.Size = new System.Drawing.Size(41, 17);
            this.Label111.TabIndex = 22;
            this.Label111.Text = "Rating";
            // 
            // Label110
            // 
            this.Label110.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label110.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label110.Location = new System.Drawing.Point(16, 311);
            this.Label110.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label110.Name = "Label110";
            this.Label110.Size = new System.Drawing.Size(57, 17);
            this.Label110.TabIndex = 20;
            this.Label110.Text = "Played";
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label19.Location = new System.Drawing.Point(16, 358);
            this.Label19.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(105, 17);
            this.Label19.TabIndex = 18;
            this.Label19.Text = "Comment";
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label17.Location = new System.Drawing.Point(148, 16);
            this.Label17.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(114, 17);
            this.Label17.TabIndex = 14;
            this.Label17.Text = "Genre";
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label16.Location = new System.Drawing.Point(16, 110);
            this.Label16.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(105, 17);
            this.Label16.TabIndex = 12;
            this.Label16.Text = "Titel";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label15.Location = new System.Drawing.Point(272, 64);
            this.Label15.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(105, 17);
            this.Label15.TabIndex = 10;
            this.Label15.Text = "Interpret";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label14.Location = new System.Drawing.Point(16, 63);
            this.Label14.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(105, 17);
            this.Label14.TabIndex = 8;
            this.Label14.Text = "Album";
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label13.Location = new System.Drawing.Point(326, 358);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(113, 17);
            this.Label13.TabIndex = 6;
            this.Label13.Text = "Media";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label11.Location = new System.Drawing.Point(289, 16);
            this.Label11.Margin = new System.Windows.Forms.Padding(24, 0, 3, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(114, 17);
            this.Label11.TabIndex = 2;
            this.Label11.Text = "Catalog";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label10.Location = new System.Drawing.Point(16, 16);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(105, 17);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "ID";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(16, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 3);
            this.label1.TabIndex = 46;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(16, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 3);
            this.label2.TabIndex = 47;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(16, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 3);
            this.label3.TabIndex = 48;
            this.label3.Text = " ";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(148, 32);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(114, 21);
            this.comboBoxGenre.TabIndex = 2;
            this.comboBoxGenre.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // comboBoxCatalog
            // 
            this.comboBoxCatalog.FormattingEnabled = true;
            this.comboBoxCatalog.Location = new System.Drawing.Point(289, 32);
            this.comboBoxCatalog.Name = "comboBoxCatalog";
            this.comboBoxCatalog.Size = new System.Drawing.Size(114, 21);
            this.comboBoxCatalog.TabIndex = 3;
            this.comboBoxCatalog.Enter += new System.EventHandler(this.SongValue_Changed);
            // 
            // EditRecord
            // 
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.comboBoxCatalog);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.textBoxMedia);
            this.Controls.Add(this.textboxComment);
            this.Controls.Add(this.textBoxBeat);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.textBoxPlayed);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chechBoxSampler);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxHide);
            this.Controls.Add(this.checkBoxError);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxFilesize);
            this.Controls.Add(this.textBoxFiledate);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.textBoxInterpret);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.Label121);
            this.Controls.Add(this.Label119);
            this.Controls.Add(this.Label118);
            this.Controls.Add(this.Label117);
            this.Controls.Add(this.Label116);
            this.Controls.Add(this.Label115);
            this.Controls.Add(this.Label114);
            this.Controls.Add(this.Label113);
            this.Controls.Add(this.Label112);
            this.Controls.Add(this.Label111);
            this.Controls.Add(this.Label110);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "EditRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Record";
            this.Load += new System.EventHandler(this.EditRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.CheckBox chechBoxSampler;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.CheckBox checkBoxError;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxFilesize;
        private System.Windows.Forms.TextBox textBoxFiledate;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxBeat;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxPlayed;
        private System.Windows.Forms.TextBox textboxComment;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TextBox textBoxInterpret;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label Label121;
        //   private System.Windows.Forms.Unsuported shp_Changed;
        private System.Windows.Forms.Label Label119;
        private System.Windows.Forms.Label Label118;
        private System.Windows.Forms.Label Label117;
        private System.Windows.Forms.Label Label116;
        private System.Windows.Forms.Label Label115;
        private System.Windows.Forms.Label Label114;
        private System.Windows.Forms.Label Label113;
        private System.Windows.Forms.Label Label112;
        private System.Windows.Forms.Label Label111;
        private System.Windows.Forms.Label Label110;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxCatalog;
    }
}
