using MyJukebox_EF.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJukebox_EF
{
    /// <summary>
    /// Summary description for frmEditRecord.
    /// </summary>
    public partial class EditRecord : Form
    {
        #region private Fields
        private int _id = -1;
        private bool _formloaded = false;
        private bool IsSongChanged = false;
        #endregion private Fields

        #region CTOR
        public EditRecord(int id)
        {
            InitializeComponent();
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCatalog.DropDownStyle = ComboBoxStyle.DropDownList;

            _id = id;
            FillFormAsync();
        }
        #endregion CTOR

        #region Form_Events
        private void Form_Load()
        {
            _formloaded = false;
            _formloaded = true;
        }

        private void chk_Error_Click()
        {
            if (_formloaded == false)
            {
                return;
                //chk_Error.BackColor = +HC0C0FF;
            }
        }

        private void chk_Hide_Click()
        {
            if (_formloaded == false)
            {
                return;
                //chk_Hide.BackColor = +HC0C0FF;
            }
        }

        private void chk_Link_Click()
        {
            if (_formloaded == false)
            {
                return;
                //chk_Link.BackColor = +HC0C0FF;
            }
        }

        private void chk_Sampler_Click()
        {
            if (_formloaded == false)
            {
                return;
                //chk_Sampler.BackColor = +HC0C0FF;
            }
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(IsSongChanged == true)
            {
                if(textBoxTitel.Text != (string)textBoxTitel.Tag)
                {

                }
            }

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
            textBoxAlbum.BackColor = Color.Salmon;
        }

        private void txt_Filename_KeyUp(object sender, EventArgs e)
        {
            textBoxFilename.BackColor = Color.Salmon;
        }

        private void txt_Genre_KeyUp(object sender, EventArgs e)
        {
        }

        private void txt_Interpret_KeyUp(object sender, EventArgs e)
        {
            textBoxInterpret.BackColor = Color.Salmon;
        }

        private void txt_Lenght_KeyUp(object sender, EventArgs e)
        {
            textBoxDuration.BackColor = Color.Salmon;
        }

        private void txt_K2_KeyUp(object sender, EventArgs e)
        {
            textboxComment.BackColor = Color.Salmon;
        }

        private void txt_Pfad_KeyUp(object sender, EventArgs e)
        {
            textBoxPath.BackColor = Color.Salmon;
        }

        private void txt_Titel_KeyUp(object sender, EventArgs e)
        {
            textBoxTitel.BackColor = Color.Salmon;
        }

        private void cmd_Exit_Click()
        {

        }

        private void cmd_Save_Click()
        {

        }

        private void Label116_Click(object sender, EventArgs e)
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

        #endregion

        #region Methods
        private async Task FillFormAsync()
        {
            List<string> record = null;

            try
            {
                // fill combo genres
                //List<string> genres = null;
                List<string> genres = await DataGetSet.GetGenresFullAsync();
                foreach (string genre in genres)
                    comboBoxGenre.Items.Add(genre);

                // fill combo catalogs
                List<string> catalogs = await DataGetSet.GetCatalogsAsync();
                foreach (string catalog in catalogs)
                    comboBoxCatalog.Items.Add(catalog);

                record = DataGetSet.GetSongRecord(_id);
                textBoxID.Text = record[0];
                comboBoxGenre.Text = record[1];
                comboBoxCatalog.Text = record[2];
                textBoxAlbum.Text = record[3];
                textBoxInterpret.Text = record[4];
                textBoxTitel.Tag = record[5];
                textBoxTitel.Text = record[5];
                textBoxPath.Text = record[6];
                textBoxFilename.Text = record[7];
            }
            catch
            { }
        }
        #endregion

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInterpret_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitel_TextChanged(object sender, EventArgs e)
        {
            IsSongChanged = true;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFilename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
