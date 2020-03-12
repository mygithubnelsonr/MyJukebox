using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjectName
{
  /// <summary>
  /// Summary description for frmOptions.
  /// </summary>
  public class frmOptions : System.Windows.Forms.Form
  {
   private System.Windows.Forms.TabControl tbsOptions;
   private System.Windows.Forms.RadioButton opt_Default7;
   private System.Windows.Forms.RadioButton opt_Default6;
   private System.Windows.Forms.RadioButton opt_Default5;
   private System.Windows.Forms.RadioButton opt_Default4;
   private System.Windows.Forms.RadioButton opt_Default3;
   private System.Windows.Forms.RadioButton opt_Default2;
   private System.Windows.Forms.RadioButton opt_Default1;
   private System.Windows.Forms.RadioButton opt_Default0;
   private System.Windows.Forms.OpenFileDialog DialogColor;
   private System.Windows.Forms.ListBox lst_HideColumns;
   private System.Windows.Forms.GroupBox fra_allgemein;
   private System.Windows.Forms.TextBox txt_imagepath;
   private System.Windows.Forms.CheckBox chk_DJmode;
   private System.Windows.Forms.CheckBox chk_ShowMultibleFiles;
   private System.Windows.Forms.CheckBox chk_FileRenam;
   private System.Windows.Forms.Label Label1;
   private System.Windows.Forms.GroupBox Frame1;
   private System.Windows.Forms.ListView lv_SendTo;
   private System.Windows.Forms.TextBox txt_AddName;
   private System.Windows.Forms.TextBox txt_AddPath;
   private System.Windows.Forms.Button cmd_SendToDel;
   private System.Windows.Forms.Button cmd_SendToAdd;
   private System.Windows.Forms.GroupBox fra_Playback;
   private System.Windows.Forms.CheckBox chk_skipdoubles;
   private System.Windows.Forms.CheckBox chk_skipplayed;
   private System.Windows.Forms.Label lbl_Colors7;
   private System.Windows.Forms.Label lbl_Colors6;
   private System.Windows.Forms.Label Label4;
   private System.Windows.Forms.Label lbl_Colors5;
   private System.Windows.Forms.Label lbl_Colors4;
   private System.Windows.Forms.Label lbl_Colors3;
   private System.Windows.Forms.Label lbl_Colors2;
   private System.Windows.Forms.Label lbl_Colors1;
   private System.Windows.Forms.Label lbl_Colors0;
   private System.Windows.Forms.Label Label3;
   private System.Windows.Forms.Label Label2;
   private System.Windows.Forms.PictureBox picOptions3;
   private System.Windows.Forms.GroupBox fraSample4;
   private System.Windows.Forms.PictureBox picOptions2;
   private System.Windows.Forms.GroupBox fraSample3;
   private System.Windows.Forms.PictureBox picOptions1;
   private System.Windows.Forms.GroupBox fraSample2;
   private System.Windows.Forms.Button cmdApply;
   private System.Windows.Forms.Button cmdCancel;
   private System.Windows.Forms.Button cmdOK;
   private System.Windows.Forms.TabPage tabPage0;
   private System.Windows.Forms.TabPage tabPage1;
   private System.Windows.Forms.TabPage tabPage2;
   private System.Windows.Forms.TabPage tabPage3;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public frmOptions()
    {
      // Required for Windows Form Designer support
      InitializeComponent();

      // TODO: Add any constructor code after InitializeComponent call
    }
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }
    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmOptions));
      this.tbsOptions = new System.Windows.Forms.TabControl();
      this.opt_Default7 = new System.Windows.Forms.RadioButton();
      this.opt_Default6 = new System.Windows.Forms.RadioButton();
      this.opt_Default5 = new System.Windows.Forms.RadioButton();
      this.opt_Default4 = new System.Windows.Forms.RadioButton();
      this.opt_Default3 = new System.Windows.Forms.RadioButton();
      this.opt_Default2 = new System.Windows.Forms.RadioButton();
      this.opt_Default1 = new System.Windows.Forms.RadioButton();
      this.opt_Default0 = new System.Windows.Forms.RadioButton();
      this.DialogColor = new System.Windows.Forms.OpenFileDialog();
      this.lst_HideColumns = new System.Windows.Forms.ListBox();
      this.fra_allgemein = new System.Windows.Forms.GroupBox();
      this.txt_imagepath = new System.Windows.Forms.TextBox();
      this.chk_DJmode = new System.Windows.Forms.CheckBox();
      this.chk_ShowMultibleFiles = new System.Windows.Forms.CheckBox();
      this.chk_FileRenam = new System.Windows.Forms.CheckBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.Frame1 = new System.Windows.Forms.GroupBox();
      this.lv_SendTo = new System.Windows.Forms.ListView();
      this.txt_AddName = new System.Windows.Forms.TextBox();
      this.txt_AddPath = new System.Windows.Forms.TextBox();
      this.cmd_SendToDel = new System.Windows.Forms.Button();
      this.cmd_SendToAdd = new System.Windows.Forms.Button();
      this.fra_Playback = new System.Windows.Forms.GroupBox();
      this.chk_skipdoubles = new System.Windows.Forms.CheckBox();
      this.chk_skipplayed = new System.Windows.Forms.CheckBox();
      this.lbl_Colors7 = new System.Windows.Forms.Label();
      this.lbl_Colors6 = new System.Windows.Forms.Label();
      this.Label4 = new System.Windows.Forms.Label();
      this.lbl_Colors5 = new System.Windows.Forms.Label();
      this.lbl_Colors4 = new System.Windows.Forms.Label();
      this.lbl_Colors3 = new System.Windows.Forms.Label();
      this.lbl_Colors2 = new System.Windows.Forms.Label();
      this.lbl_Colors1 = new System.Windows.Forms.Label();
      this.lbl_Colors0 = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.picOptions3 = new System.Windows.Forms.PictureBox();
      this.fraSample4 = new System.Windows.Forms.GroupBox();
      this.picOptions2 = new System.Windows.Forms.PictureBox();
      this.fraSample3 = new System.Windows.Forms.GroupBox();
      this.picOptions1 = new System.Windows.Forms.PictureBox();
      this.fraSample2 = new System.Windows.Forms.GroupBox();
      this.cmdApply = new System.Windows.Forms.Button();
      this.cmdCancel = new System.Windows.Forms.Button();
      this.cmdOK = new System.Windows.Forms.Button();
      this.tabPage0 = new System.Windows.Forms.TabPage();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.SuspendLayout();
      this.tbsOptions.SuspendLayout();
      this.fra_allgemein.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.fra_Playback.SuspendLayout();
      this.picOptions3.SuspendLayout();
      this.picOptions2.SuspendLayout();
      this.picOptions1.SuspendLayout();
      this.tabPage0.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      //
      // tbsOptions
      //
      this.tbsOptions.Name = "tbsOptions";
      this.tbsOptions.Size = new System.Drawing.Size(393, 281);
      this.tbsOptions.Location = new System.Drawing.Point(8, 8);
      this.tbsOptions.TabIndex = 9;
//      this.tbsOptions.Tabs = 4;
//      this.tbsOptions.Tab = 3;
//      this.tbsOptions.TabsPerRow = 4;
//      this.tbsOptions.TabHeight = 520;
//      this.tbsOptions.TabCaption(0) = "Allgemein";
//      this.tbsOptions.TabPicture(0) = "Options.frx":000C;
//      this.tbsOptions.Tab(0).ControlEnable = 0;
//      this.tbsOptions.Tab(0).Control(0 = "fra_allgemein";
//      this.tbsOptions.Tab(0).ControlCoun = 1;
//      this.tbsOptions.TabCaption(1) = "Playback";
//      this.tbsOptions.TabPicture(1) = "Options.frx":0028;
//      this.tbsOptions.Tab(1).ControlEnable = 0;
//      this.tbsOptions.Tab(1).Control(0 = "fra_Playback";
//      this.tbsOptions.Tab(1).ControlCoun = 1;
//      this.tbsOptions.TabCaption(2) = "Spare";
//      this.tbsOptions.TabPicture(2) = "Options.frx":0044;
//      this.tbsOptions.Tab(2).ControlEnable = 0;
//      this.tbsOptions.Tab(2).Control(0 = "Frame1";
//      this.tbsOptions.Tab(2).ControlCoun = 1;
//      this.tbsOptions.TabCaption(3) = "Flex settings";
//      this.tbsOptions.TabPicture(3) = "Options.frx":0060;
//      this.tbsOptions.Tab(3).ControlEnable = -1;
//      this.tbsOptions.Tab(3).Control(0 = "Label2";
//      this.tbsOptions.Tab(3).Control(0).Enable = 0;
//      this.tbsOptions.Tab(3).Control(1 = "Label3";
//      this.tbsOptions.Tab(3).Control(1).Enable = 0;
//      this.tbsOptions.Tab(3).Control(2 = "lbl_Colors(0)";
//      this.tbsOptions.Tab(3).Control(2).Enable = 0;
//      this.tbsOptions.Tab(3).Control(3 = "lbl_Colors(1)";
//      this.tbsOptions.Tab(3).Control(3).Enable = 0;
//      this.tbsOptions.Tab(3).Control(4 = "lbl_Colors(2)";
//      this.tbsOptions.Tab(3).Control(4).Enable = 0;
//      this.tbsOptions.Tab(3).Control(5 = "lbl_Colors(3)";
//      this.tbsOptions.Tab(3).Control(5).Enable = 0;
//      this.tbsOptions.Tab(3).Control(6 = "lbl_Colors(4)";
//      this.tbsOptions.Tab(3).Control(6).Enable = 0;
//      this.tbsOptions.Tab(3).Control(7 = "lbl_Colors(5)";
//      this.tbsOptions.Tab(3).Control(7).Enable = 0;
//      this.tbsOptions.Tab(3).Control(8 = "Label4";
//      this.tbsOptions.Tab(3).Control(8).Enable = 0;
//      this.tbsOptions.Tab(3).Control(9 = "lbl_Colors(6)";
//      this.tbsOptions.Tab(3).Control(9).Enable = 0;
//      this.tbsOptions.Tab(3).Control(10 = "lbl_Colors(7)";
//      this.tbsOptions.Tab(3).Control(10).Enable = 0;
//      this.tbsOptions.Tab(3).Control(11 = "lst_HideColumns";
//      this.tbsOptions.Tab(3).Control(11).Enable = 0;
//      this.tbsOptions.Tab(3).Control(12 = "DialogColor";
//      this.tbsOptions.Tab(3).Control(12).Enable = 0;
//      this.tbsOptions.Tab(3).Control(13 = "opt_Default(0)";
//      this.tbsOptions.Tab(3).Control(13).Enable = 0;
//      this.tbsOptions.Tab(3).Control(14 = "opt_Default(1)";
//      this.tbsOptions.Tab(3).Control(14).Enable = 0;
//      this.tbsOptions.Tab(3).Control(15 = "opt_Default(2)";
//      this.tbsOptions.Tab(3).Control(15).Enable = 0;
//      this.tbsOptions.Tab(3).Control(16 = "opt_Default(3)";
//      this.tbsOptions.Tab(3).Control(16).Enable = 0;
//      this.tbsOptions.Tab(3).Control(17 = "opt_Default(4)";
//      this.tbsOptions.Tab(3).Control(17).Enable = 0;
//      this.tbsOptions.Tab(3).Control(18 = "opt_Default(5)";
//      this.tbsOptions.Tab(3).Control(18).Enable = 0;
//      this.tbsOptions.Tab(3).Control(19 = "opt_Default(6)";
//      this.tbsOptions.Tab(3).Control(19).Enable = 0;
//      this.tbsOptions.Tab(3).Control(20 = "opt_Default(7)";
//      this.tbsOptions.Tab(3).Control(20).Enable = 0;
//      this.tbsOptions.Tab(3).ControlCoun = 21;
      this.tbsOptions.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.tabPage0,
            this.tabPage1,
            this.tabPage2,
            this.tabPage3
      });
      //
      // opt_Default7
      //
      this.opt_Default7.Name = "opt_Default7";
      this.opt_Default7.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default7.BackColor = System.Drawing.Color.FromArgb(-4128769);
      this.opt_Default7.Size = new System.Drawing.Size(33, 17);
      this.opt_Default7.Location = new System.Drawing.Point(312, 168);
      this.opt_Default7.TabIndex = 44;
      this.opt_Default7.Tag = "played";
      //
      // opt_Default6
      //
      this.opt_Default6.Name = "opt_Default6";
      this.opt_Default6.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default6.BackColor = System.Drawing.Color.FromArgb(-8323200);
      this.opt_Default6.Size = new System.Drawing.Size(33, 17);
      this.opt_Default6.Location = new System.Drawing.Point(312, 152);
      this.opt_Default6.TabIndex = 42;
      this.opt_Default6.Tag = "playing";
      //
      // opt_Default5
      //
      this.opt_Default5.Name = "opt_Default5";
      this.opt_Default5.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default5.BackColor = System.Drawing.Color.FromArgb(-16192);
      this.opt_Default5.Size = new System.Drawing.Size(33, 17);
      this.opt_Default5.Location = new System.Drawing.Point(312, 136);
      this.opt_Default5.TabIndex = 40;
      this.opt_Default5.Tag = "Error";
      //
      // opt_Default4
      //
      this.opt_Default4.Name = "opt_Default4";
      this.opt_Default4.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default4.BackColor = System.Drawing.Color.FromArgb(-10181892);
      this.opt_Default4.Size = new System.Drawing.Size(33, 17);
      this.opt_Default4.Location = new System.Drawing.Point(312, 120);
      this.opt_Default4.TabIndex = 39;
      this.opt_Default4.Tag = "Selback";
      //
      // opt_Default3
      //
      this.opt_Default3.Name = "opt_Default3";
      this.opt_Default3.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default3.BackColor = System.Drawing.Color.FromArgb(-16548716);
      this.opt_Default3.Size = new System.Drawing.Size(33, 17);
      this.opt_Default3.Location = new System.Drawing.Point(312, 104);
      this.opt_Default3.TabIndex = 38;
      this.opt_Default3.Tag = "Cellback";
      //
      // opt_Default2
      //
      this.opt_Default2.Name = "opt_Default2";
      this.opt_Default2.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default2.BackColor = System.Drawing.Color.FromArgb(-9389885);
      this.opt_Default2.Size = new System.Drawing.Size(33, 17);
      this.opt_Default2.Location = new System.Drawing.Point(312, 88);
      this.opt_Default2.TabIndex = 37;
      this.opt_Default2.Tag = "FixRow";
      //
      // opt_Default1
      //
      this.opt_Default1.Name = "opt_Default1";
      this.opt_Default1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default1.BackColor = System.Drawing.Color.FromArgb(-1249035);
      this.opt_Default1.Size = new System.Drawing.Size(33, 17);
      this.opt_Default1.Location = new System.Drawing.Point(312, 72);
      this.opt_Default1.TabIndex = 36;
      this.opt_Default1.Tag = "EvenRow";
      //
      // opt_Default0
      //
      this.opt_Default0.Name = "opt_Default0";
      this.opt_Default0.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.opt_Default0.BackColor = System.Drawing.Color.FromArgb(-2039584);
      this.opt_Default0.Size = new System.Drawing.Size(33, 17);
      this.opt_Default0.Location = new System.Drawing.Point(312, 56);
      this.opt_Default0.TabIndex = 35;
      this.opt_Default0.Tag = "OddRow";
      //
      // DialogColor
      //
      this.DialogColor.Name = "DialogColor";
      this.DialogColor.Location = new System.Drawing.Point(304, 224);
//      this.DialogColor.Color = 255;
      //
      // lst_HideColumns
      //
      this.lst_HideColumns.Name = "lst_HideColumns";
      this.lst_HideColumns.Size = new System.Drawing.Size(137, 214);
//      this.lst_HideColumns.ItemData = "Options.frx":007C;
      this.lst_HideColumns.Location = new System.Drawing.Point(16, 48);
//      this.lst_HideColumns.List = "Options.frx":0083;
      this.lst_HideColumns.TabIndex = 26;
      //
      // fra_allgemein
      //
      this.fra_allgemein.Name = "fra_allgemein";
      this.fra_allgemein.Text = "Allgemeine Settings";
      this.fra_allgemein.Size = new System.Drawing.Size(377, 239);
      this.fra_allgemein.Location = new System.Drawing.Point(8, 24);
      this.fra_allgemein.TabIndex = 14;
      this.fra_allgemein.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.txt_imagepath,
            this.chk_DJmode,
            this.chk_ShowMultibleFiles,
            this.chk_FileRenam,
            this.Label1
      });
      //
      // txt_imagepath
      //
      this.txt_imagepath.Name = "txt_imagepath";
      this.txt_imagepath.Size = new System.Drawing.Size(233, 19);
      this.txt_imagepath.Location = new System.Drawing.Point(112, 112);
      this.txt_imagepath.TabIndex = 24;
      this.txt_imagepath.Text = "_Image";
//      this.txt_imagepath.ToolTipText = "this path is expected below each genre path";
      //
      // chk_DJmode
      //
      this.chk_DJmode.Name = "chk_DJmode";
      this.chk_DJmode.Text = "DJ Modus";
      this.chk_DJmode.Size = new System.Drawing.Size(121, 17);
      this.chk_DJmode.Location = new System.Drawing.Point(16, 88);
      this.chk_DJmode.TabIndex = 17;
      this.chk_DJmode.CheckState = System.Windows.Forms.CheckState.Checked;
      //
      // chk_ShowMultibleFiles
      //
      this.chk_ShowMultibleFiles.Name = "chk_ShowMultibleFiles";
      this.chk_ShowMultibleFiles.Text = "show multible files";
      this.chk_ShowMultibleFiles.Size = new System.Drawing.Size(321, 25);
      this.chk_ShowMultibleFiles.Location = new System.Drawing.Point(16, 56);
      this.chk_ShowMultibleFiles.TabIndex = 16;
      this.chk_ShowMultibleFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      //
      // chk_FileRenam
      //
      this.chk_FileRenam.Name = "chk_FileRenam";
      this.chk_FileRenam.Text = "Rename linked Files";
      this.chk_FileRenam.Size = new System.Drawing.Size(313, 17);
      this.chk_FileRenam.Location = new System.Drawing.Point(16, 32);
      this.chk_FileRenam.TabIndex = 15;
      //
      // Label1
      //
      this.Label1.Name = "Label1";
      this.Label1.Text = "global Image Path:";
      this.Label1.Size = new System.Drawing.Size(89, 17);
      this.Label1.Location = new System.Drawing.Point(16, 112);
      this.Label1.TabIndex = 23;
      //
      // Frame1
      //
      this.Frame1.Name = "Frame1";
      this.Frame1.Text = "additional SendTo";
      this.Frame1.Size = new System.Drawing.Size(377, 241);
      this.Frame1.Location = new System.Drawing.Point(8, 32);
      this.Frame1.TabIndex = 13;
      this.Frame1.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.lv_SendTo,
            this.txt_AddName,
            this.txt_AddPath,
            this.cmd_SendToDel,
            this.cmd_SendToAdd
      });
      //
      // lv_SendTo
      //
      this.lv_SendTo.Name = "lv_SendTo";
      this.lv_SendTo.Size = new System.Drawing.Size(361, 121);
      this.lv_SendTo.Location = new System.Drawing.Point(8, 24);
      this.lv_SendTo.TabIndex = 22;
      this.lv_SendTo.LabelWrap = true;
      this.lv_SendTo.HideSelection = true;
      this.lv_SendTo.ForeColor = System.Drawing.Color.FromArgb(-10189964);
      this.lv_SendTo.BackColor = System.Drawing.Color.FromArgb(-10189964);
      this.lv_SendTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//      this.lv_SendTo.NumItems = 0;
      //
      // txt_AddName
      //
      this.txt_AddName.Name = "txt_AddName";
      this.txt_AddName.Size = new System.Drawing.Size(361, 19);
      this.txt_AddName.Location = new System.Drawing.Point(8, 152);
      this.txt_AddName.TabIndex = 21;
      this.txt_AddName.Text = "Text1";
      //
      // txt_AddPath
      //
      this.txt_AddPath.Name = "txt_AddPath";
      this.txt_AddPath.Size = new System.Drawing.Size(361, 19);
      this.txt_AddPath.Location = new System.Drawing.Point(8, 184);
      this.txt_AddPath.TabIndex = 20;
      this.txt_AddPath.Text = "Text1";
      //
      // cmd_SendToDel
      //
      this.cmd_SendToDel.Name = "cmd_SendToDel";
      this.cmd_SendToDel.Text = "Remove";
      this.cmd_SendToDel.Size = new System.Drawing.Size(65, 17);
      this.cmd_SendToDel.Location = new System.Drawing.Point(104, 216);
      this.cmd_SendToDel.TabIndex = 19;
      //
      // cmd_SendToAdd
      //
      this.cmd_SendToAdd.Name = "cmd_SendToAdd";
      this.cmd_SendToAdd.Text = "Add";
      this.cmd_SendToAdd.Size = new System.Drawing.Size(65, 17);
      this.cmd_SendToAdd.Location = new System.Drawing.Point(24, 216);
      this.cmd_SendToAdd.TabIndex = 18;
      //
      // fra_Playback
      //
      this.fra_Playback.Name = "fra_Playback";
      this.fra_Playback.Text = "Playback settings";
      this.fra_Playback.Size = new System.Drawing.Size(377, 241);
      this.fra_Playback.Location = new System.Drawing.Point(8, 32);
      this.fra_Playback.TabIndex = 10;
      this.fra_Playback.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.chk_skipdoubles,
            this.chk_skipplayed
      });
      //
      // chk_skipdoubles
      //
      this.chk_skipdoubles.Name = "chk_skipdoubles";
      this.chk_skipdoubles.Text = "skip double Titles";
      this.chk_skipdoubles.Size = new System.Drawing.Size(337, 25);
      this.chk_skipdoubles.Location = new System.Drawing.Point(16, 24);
      this.chk_skipdoubles.TabIndex = 12;
      this.chk_skipdoubles.CheckState = System.Windows.Forms.CheckState.Checked;
      //
      // chk_skipplayed
      //
      this.chk_skipplayed.Name = "chk_skipplayed";
      this.chk_skipplayed.Text = "skip played Titles";
      this.chk_skipplayed.Size = new System.Drawing.Size(329, 25);
      this.chk_skipplayed.Location = new System.Drawing.Point(16, 56);
      this.chk_skipplayed.TabIndex = 11;
      //
      // lbl_Colors7
      //
      this.lbl_Colors7.Name = "lbl_Colors7";
      this.lbl_Colors7.BackColor = System.Drawing.Color.FromArgb(-4128769);
      this.lbl_Colors7.Text = "played";
      this.lbl_Colors7.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors7.Location = new System.Drawing.Point(168, 168);
      this.lbl_Colors7.TabIndex = 43;
      this.lbl_Colors7.Tag = "played";
      //
      // lbl_Colors6
      //
      this.lbl_Colors6.Name = "lbl_Colors6";
      this.lbl_Colors6.BackColor = System.Drawing.Color.FromArgb(-8323200);
      this.lbl_Colors6.Text = "playing";
      this.lbl_Colors6.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors6.Location = new System.Drawing.Point(168, 152);
      this.lbl_Colors6.TabIndex = 41;
      this.lbl_Colors6.Tag = "playing";
      //
      // Label4
      //
      this.Label4.Name = "Label4";
      this.Label4.Text = "Default";
      this.Label4.Font = new System.Drawing.Font("MS Sans Serif",8F, ( System.Drawing.FontStyle.Bold ), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));;
      this.Label4.Size = new System.Drawing.Size(41, 17);
      this.Label4.Location = new System.Drawing.Point(312, 40);
      this.Label4.TabIndex = 34;
      //
      // lbl_Colors5
      //
      this.lbl_Colors5.Name = "lbl_Colors5";
      this.lbl_Colors5.BackColor = System.Drawing.Color.FromArgb(-16192);
      this.lbl_Colors5.Text = "Error";
      this.lbl_Colors5.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors5.Location = new System.Drawing.Point(168, 136);
      this.lbl_Colors5.TabIndex = 33;
      this.lbl_Colors5.Tag = "Error";
      //
      // lbl_Colors4
      //
      this.lbl_Colors4.Name = "lbl_Colors4";
      this.lbl_Colors4.BackColor = System.Drawing.Color.FromArgb(-10181892);
      this.lbl_Colors4.Text = "Sel backcolor";
      this.lbl_Colors4.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors4.Location = new System.Drawing.Point(168, 120);
      this.lbl_Colors4.TabIndex = 32;
      this.lbl_Colors4.Tag = "Selback";
      //
      // lbl_Colors3
      //
      this.lbl_Colors3.Name = "lbl_Colors3";
      this.lbl_Colors3.BackColor = System.Drawing.Color.FromArgb(-16548716);
      this.lbl_Colors3.Text = "Cell backcolor";
      this.lbl_Colors3.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors3.Location = new System.Drawing.Point(168, 104);
      this.lbl_Colors3.TabIndex = 31;
      this.lbl_Colors3.Tag = "Cellback";
      //
      // lbl_Colors2
      //
      this.lbl_Colors2.Name = "lbl_Colors2";
      this.lbl_Colors2.BackColor = System.Drawing.Color.FromArgb(-9389885);
      this.lbl_Colors2.Text = "FixRow";
      this.lbl_Colors2.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors2.Location = new System.Drawing.Point(168, 88);
      this.lbl_Colors2.TabIndex = 30;
      this.lbl_Colors2.Tag = "FixRow";
      //
      // lbl_Colors1
      //
      this.lbl_Colors1.Name = "lbl_Colors1";
      this.lbl_Colors1.BackColor = System.Drawing.Color.FromArgb(-1249035);
      this.lbl_Colors1.Text = "EvenRow";
      this.lbl_Colors1.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors1.Location = new System.Drawing.Point(168, 72);
      this.lbl_Colors1.TabIndex = 29;
      this.lbl_Colors1.Tag = "EvenRow";
      //
      // lbl_Colors0
      //
      this.lbl_Colors0.Name = "lbl_Colors0";
      this.lbl_Colors0.BackColor = System.Drawing.Color.FromArgb(-2039584);
      this.lbl_Colors0.Text = "OddRow";
      this.lbl_Colors0.Size = new System.Drawing.Size(145, 17);
      this.lbl_Colors0.Location = new System.Drawing.Point(168, 56);
      this.lbl_Colors0.TabIndex = 28;
      this.lbl_Colors0.Tag = "OddRow";
      //
      // Label3
      //
      this.Label3.Name = "Label3";
      this.Label3.Text = "Colors";
      this.Label3.Font = new System.Drawing.Font("MS Sans Serif",8F, ( System.Drawing.FontStyle.Bold ), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));;
      this.Label3.Size = new System.Drawing.Size(145, 17);
      this.Label3.Location = new System.Drawing.Point(168, 40);
      this.Label3.TabIndex = 27;
      //
      // Label2
      //
      this.Label2.Name = "Label2";
      this.Label2.Text = "Hide columns";
      this.Label2.Font = new System.Drawing.Font("MS Sans Serif",8F, ( System.Drawing.FontStyle.Bold ), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));;
      this.Label2.Size = new System.Drawing.Size(65, 17);
      this.Label2.Location = new System.Drawing.Point(16, 32);
      this.Label2.TabIndex = 25;
      //
      // picOptions3
      //
      this.picOptions3.Name = "picOptions3";
      this.picOptions3.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.picOptions3.Size = new System.Drawing.Size(379, 252);
      this.picOptions3.Location = new System.Drawing.Point(3666, 32);
      this.picOptions3.TabIndex = 5;
      this.picOptions3.TabStop = false;
      //
      // fraSample4
      //
      this.fraSample4.Name = "fraSample4";
      this.fraSample4.Text = "Sample 4";
      this.fraSample4.Size = new System.Drawing.Size(137, 119);
      this.fraSample4.Location = new System.Drawing.Point(140, 56);
      this.fraSample4.TabIndex = 8;
      //
      // picOptions2
      //
      this.picOptions2.Name = "picOptions2";
      this.picOptions2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.picOptions2.Size = new System.Drawing.Size(379, 252);
      this.picOptions2.Location = new System.Drawing.Point(3666, 32);
      this.picOptions2.TabIndex = 4;
      this.picOptions2.TabStop = false;
      //
      // fraSample3
      //
      this.fraSample3.Name = "fraSample3";
      this.fraSample3.Text = "Sample 3";
      this.fraSample3.Size = new System.Drawing.Size(137, 119);
      this.fraSample3.Location = new System.Drawing.Point(103, 45);
      this.fraSample3.TabIndex = 7;
      //
      // picOptions1
      //
      this.picOptions1.Name = "picOptions1";
      this.picOptions1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.picOptions1.Size = new System.Drawing.Size(379, 252);
      this.picOptions1.Location = new System.Drawing.Point(3666, 32);
      this.picOptions1.TabIndex = 3;
      this.picOptions1.TabStop = false;
      //
      // fraSample2
      //
      this.fraSample2.Name = "fraSample2";
      this.fraSample2.Text = "Sample 2";
      this.fraSample2.Size = new System.Drawing.Size(137, 119);
      this.fraSample2.Location = new System.Drawing.Point(43, 20);
      this.fraSample2.TabIndex = 6;
      //
      // cmdApply
      //
      this.cmdApply.Name = "cmdApply";
      this.cmdApply.Text = "Apply";
      this.cmdApply.Size = new System.Drawing.Size(73, 25);
      this.cmdApply.Location = new System.Drawing.Point(328, 297);
      this.cmdApply.TabIndex = 2;
      //
      // cmdCancel
      //
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.Size = new System.Drawing.Size(73, 25);
      this.cmdCancel.Location = new System.Drawing.Point(248, 297);
      this.cmdCancel.TabIndex = 1;
      //
      // cmdOK
      //
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Text = "OK";
      this.cmdOK.Size = new System.Drawing.Size(73, 25);
      this.cmdOK.Location = new System.Drawing.Point(166, 297);
      this.cmdOK.TabIndex = 0;
      //
      // tabPage0
      //
      this.tabPage0.Name = "tabPage0";
      this.tabPage0.Location = new System.Drawing.Point(4, 22);
      this.tabPage0.Size = new System.Drawing.Size(477, 374);
      this.tabPage0.Text = "Allgemein";
      this.tabPage0.TabIndex = 0;
      this.tabPage0.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.fra_allgemein
      });
      //
      // tabPage1
      //
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Size = new System.Drawing.Size(477, 374);
      this.tabPage1.Text = "Playback";
      this.tabPage1.TabIndex = 1;
      this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.fra_Playback
      });
      //
      // tabPage2
      //
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Size = new System.Drawing.Size(477, 374);
      this.tabPage2.Text = "Spare";
      this.tabPage2.TabIndex = 2;
      this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.Frame1
      });
      //
      // tabPage3
      //
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Size = new System.Drawing.Size(477, 374);
      this.tabPage3.Text = "Flex settings";
      this.tabPage3.TabIndex = 3;
      this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.opt_Default7,
            this.opt_Default6,
            this.opt_Default5,
            this.opt_Default4,
            this.opt_Default3,
            this.opt_Default2,
            this.opt_Default1,
            this.opt_Default0,
            this.lst_HideColumns,
            this.lbl_Colors7,
            this.lbl_Colors6,
            this.Label4,
            this.lbl_Colors5,
            this.lbl_Colors4,
            this.lbl_Colors3,
            this.lbl_Colors2,
            this.lbl_Colors1,
            this.lbl_Colors0,
            this.Label3,
            this.Label2
      });
      //
      // frmOptions
      //
      this.Controls.AddRange(new System.Windows.Forms.Control[]
      {
            this.tbsOptions,
            this.picOptions3,
            this.picOptions2,
            this.picOptions1,
            this.cmdApply,
            this.cmdCancel,
            this.cmdOK
      });
      this.Name = "frmOptions";
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Text = "Options";
      this.ClientSize = new System.Drawing.Size(413, 336);
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.tbsOptions.ResumeLayout(false);
      this.fra_allgemein.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.fra_Playback.ResumeLayout(false);
      this.picOptions3.ResumeLayout(false);
      this.picOptions2.ResumeLayout(false);
      this.picOptions1.ResumeLayout(false);
      this.tabPage0.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.ResumeLayout(false);
    }
    #endregion

    private ListItem ItmX;
    private  n%;
    private  n%;
    private  c;
    private tColwidth% intColwidth%;
    private rCol$ strCol$;
    private  n;
    private Reg arReg;

    private void cmd_SendToAdd_Click()
    {

      ItmX = lv_SendTo.ListItems.Add(, , txt_AddName);
      ItmX.SubItems(1) = txt_AddPath;

    }
    private void cmd_SendToDel_Click()
    {

      if ( lv_SendTo.ListItems.Count > 0 )
      {;
      Dim intSel%;
      intSel = lv_SendTo.SelectedItem.Index;
      Debug.Print intSel;
      lv_SendTo.ListItems.Remove (intSel);
      lv_SendTo.Refresh;
      };

    }
    private void cmdApply_Click()
    {

      SaveSetting App.EXEName, "Settings\", "DJMode", chk_DJmode.Value;
      SaveSetting App.EXEName, "Settings\", "ShowMultibleFiles", chk_ShowMultibleFiles.Value;
      SaveSetting App.EXEName, "Settings\", "SkipDoubles", chk_skipdoubles.Value;
      SaveSetting App.EXEName, "Settings\", "SkipPlayed", chk_skipplayed.Value;
      SaveSetting App.EXEName, "Settings\", "ImagePath", txt_imagepath.Text;
      For n = 0 To lbl_Colors.Count - 1;
      SaveSetting App.EXEName, "Settings\Colors", lbl_Colors(n).Tag, lbl_Colors(n).BackColor;
      Next;
      Call frmMain.SetColumnWidth;
    }
    private void cmdCancel_Click()
    {
      Close();
    }
    private void cmdOK_Click()
    {
      cmdApply_Click;
      Close();
    }
    private void Form_Load()
    {

      tbsOptions.Tab = 0;

      txt_imagepath.Text = GetSetting(App.EXEName, "Settings\", "ImagePath", "_Images");
      chk_skipplayed.Value = GetSetting(App.EXEName, "Settings\", "SkipPlayed", vbChecked);

      With lv_SendTo;
      .View = lvwReport;
      .ColumnHeaders.Add , , "Name", , lvwColumnLeft;
      .ColumnHeaders.Add , , "Path", , lvwColumnCenter;
      End With;

      For n = 0 To lbl_Colors.Count - 1;
      lbl_Colors(n).BackColor = GetSetting(App.EXEName, "Settings\Colors", lbl_Colors(n).Tag, opt_Default(n).BackColor);
      Next;
      //center the form;
      Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2;

    }
    private void lbl_Colors_Click    {
      DialogColor.ShowColor;
      c = DialogColor.Color;
      lbl_Colors(Index).BackColor = c;
    }
    private void lst_HideColumns_ItemCheck    {

      Debug.Print "item " + Item + " checked";
      Debug.Print lst_HideColumns.SelCount;
      Debug.Print lst_HideColumns.List(Item);
      Debug.Print lst_HideColumns.Selected(Item);

      strCol = lst_HideColumns.List(Item);

      intColwidth = Val(GetSetting(App.EXEName, "Settings\Flex\ColDefs", strCol));
      Debug.Print strCol, intColwidth;
      if ( lst_HideColumns.Selected(Item) )
      {;
      SaveSetting App.EXEName, "Settings\Flex\ColDefs", LCase(strCol), CStr(intColwidth) + "_h";
      }
      else
      {;
      SaveSetting App.EXEName, "Settings\Flex\ColDefs", LCase(strCol), intColwidth;
      };

    }
    private void opt_Default_DblClick    {
      Me.lbl_Colors(Index).BackColor = Me.opt_Default(Index).BackColor;
    }
    private void tbsOptions_Click    {
      Static bListFilled As Boolean;


      if ( tbsOptions.Tab = 3 )
      {;
      lst_HideColumns.Clear;

      arReg = GetAllSettings(App.EXEName, "Settings\Flex\ColDefs");

      if ( ! IsEmpty(arReg) )
      {;
      For n = 0 To UBound(arReg);
      Debug.Print arReg(n, 0);
      lst_HideColumns.AddItem arReg(n, 0);

      if ( Right(arReg(n, 1), 1) = "h" )
      {;
      lst_HideColumns.Selected(n) = true;
      };

      Next;
      };
      };

    }
  }
}
