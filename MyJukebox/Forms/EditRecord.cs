using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyJukebox_EF
{  
    /// <summary>
    /// Summary description for frmEditRecord.
    /// </summary>
    public partial class EditRecord : Form
    {
        #region private Fields
        //private object nullRecord = null;
        public int tID, intID;
        //private object rstrRecordNeu, arstrRecordAlt;
        private bool bFormloaded = false;
        //private int n, R;
        //private string ql, sSql;
        //private OleDbDataReader rs;
        //private Control c;
        //private string strFieldName, strValueNew;
        //private string strCtype;
        //private string Msg;
        #endregion private Fields

        #region CTOR
        public EditRecord()
        {
            // Required for Windows Form Designer support
            InitializeComponent();

        }
        #endregion CTOR

        private void Form_Load()
        {
            bFormloaded = false;
            //GetRecord intID;
            bFormloaded = true;
        }

        private void chk_Error_Click()
        {
          if ( bFormloaded == false )
          {
            return;
          //chk_Error.BackColor = +HC0C0FF;
          }
        }

        private void chk_Hide_Click()
        {
          if ( bFormloaded == false )
          {
            return;
          //chk_Hide.BackColor = +HC0C0FF;
          }
        }
        private void chk_Link_Click()
        {
          if ( bFormloaded == false )
          {
            return;
          //chk_Link.BackColor = +HC0C0FF;
          }
        }
        private void chk_Sampler_Click()
        {
          if ( bFormloaded == false )
          {
            return;
          //chk_Sampler.BackColor = +HC0C0FF;
          }
        }
        private void cmd_Exit_Click(object sender, EventArgs e)
        {
          Close();
        }
        private void cmd_Save_Click(object sender, EventArgs e)
        {

          //foreach( c In Me)
          //{
          //    if ( c.BackColor = +HC0C0FF )
          //    {
          //      // Textfeld wurde bearbeitet;
          //        if ( IsFieldChanged(c) )
          //        {
          //          SaveChanges c;
          //        }
          //    }
          //}

        }



        private void txt_Album_KeyUp(object sender, EventArgs e)
        {
            txt_Album.BackColor = Color.Salmon;
        }

        private void txt_Filename_KeyUp(object sender, EventArgs e)
        {
            txt_Filename.BackColor = Color.Salmon;
        }

        private void txt_Genre_KeyUp(object sender, EventArgs e)
        {
            txt_Genre.BackColor = Color.Salmon;
        }
        
        private void txt_Interpret_KeyUp(object sender, EventArgs e)
        {
            txt_Interpret.BackColor = Color.Salmon;
        }
        private void txt_Lenght_KeyUp(object sender, EventArgs e)
        {
            txt_Laenge.BackColor = Color.Salmon;
        }
        private void txt_K1_KeyUp(object sender, EventArgs e)
        {
            txt_K1.BackColor = Color.Salmon;
        }
        private void txt_K2_KeyUp(object sender, EventArgs e)
        {
            txt_K2.BackColor = Color.Salmon;
        }
        private void txt_Pfad_KeyUp(object sender, EventArgs e)
        {
            txt_Pfad.BackColor = Color.Salmon;
        }
        private void txt_Titel_KeyUp(object sender, EventArgs e)
        {
            txt_Titel.BackColor = Color.Salmon;
        }

        private void cmd_Exit_Click()
        {

        }

        private void cmd_Save_Click()
        {

        }
    
        bool IsFieldChanged(Control c)
        {
        //Dim strValueNew$, strValueOld$, strFieldName$, strCtype

            //bool IsFieldChanged = false;

        //strCtype = TypeName(Contr)
        //Debug.Print strCtype

        //Select Case strCtype
        //  Case "TextBox"
        //      strValueOld = Contr.Tag
        //      strValueNew = Contr.Text
              
        //  Case "CheckBox"
        //      strValueOld = Contr.Tag
        //      strValueNew = Contr.Value
          
        //  Case Else
          
        //End Select

        //If strValueOld = strValueNew Then
        //  IsFieldChanged = False
        //Else
            return true;
        //End If
      
        }
    }
}
