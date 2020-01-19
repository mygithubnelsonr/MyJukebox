using MyJukebox_EF.BLL;
using System;
using System.Collections.Generic;
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
        private bool IsFileInfoChanged = false;
        private bool IsSongInfoChanged = false;
        private MP3Record mp3Record;

        #endregion private Fields

        #region CTOR
        public EditRecord(int id)
        {
            InitializeComponent();
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCatalog.DropDownStyle = ComboBoxStyle.DropDownList;

            _id = id;
            FillFormAsync();

            //_formloaded = true;
        }
        #endregion CTOR

        #region Form_Events
        private void Form_Load()
        {
            //_formloaded = false;
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
            if (IsSongChanged == true)
            {
                mp3Record = new MP3Record();
                mp3Record.Genre = comboBoxGenre.Text;
                mp3Record.Catalog = comboBoxCatalog.Text;
                mp3Record.Album = textBoxAlbum.Text;
                mp3Record.Interpret = textBoxInterpret.Text;
                mp3Record.Titel = textBoxTitel.Text;
                mp3Record.Path = textBoxPath.Text;
                mp3Record.FileName = textBoxFilename.Text;

                bool result = DataGetSet.EditSaveSongChanges(_id, mp3Record);
            }

            if (IsFileInfoChanged == true)
            {
                mp3Record = new MP3Record();
                mp3Record.FileSize = Convert.ToInt32(textBoxFilesize.Text);
                mp3Record.FileDate = Convert.ToDateTime(textBoxFiledate.Text);
                mp3Record.Duration = TimeSpan.Parse(textBoxDuration.Text);

                bool result = DataGetSet.EditSaveFileinfoChanges(_id, mp3Record);
            }

            if (IsSongInfoChanged == true)
            {
                mp3Record = new MP3Record();
                mp3Record.IsSample = chechBoxSampler.Checked;
                mp3Record.Error = checkBoxError.Checked;
                mp3Record.Hide = checkBoxHide.Checked;
                mp3Record.Comment = textboxComment.Text;
                mp3Record.Media = Convert.ToInt32(textBoxMedia.Text);
            }

            #region Zeuch
            //if (textBoxTitel.Text != (string)textBoxTitel.Tag)
            //{

            //}

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
            #endregion
        }

        private void cmd_Exit_Click()
        {

        }

        private void cmd_Save_Click()
        {

        }

        //bool IsFieldChanged(Control c)
        //{
        //    //Dim strValueNew$, strValueOld$, strFieldName$, strCtype

        //    //bool IsFieldChanged = false;

        //    //strCtype = TypeName(Contr)
        //    //Debug.Print strCtype

        //    //Select Case strCtype
        //    //  Case "TextBox"
        //    //      strValueOld = Contr.Tag
        //    //      strValueNew = Contr.Text

        //    //  Case "CheckBox"
        //    //      strValueOld = Contr.Tag
        //    //      strValueNew = Contr.Value

        //    //  Case Else

        //    //End Select

        //    //If strValueOld = strValueNew Then
        //    //  IsFieldChanged = False
        //    //Else
        //    return true;
        //    //End If

        //}

        #endregion

        #region Methods
        private async Task FillFormAsync()
        {
            List<string> record = null;

            try
            {
                // fill combo genres
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
                textBoxTitel.Text = record[5];
                textBoxPath.Text = record[6];
                textBoxFilename.Text = record[7];

                record = DataGetSet.GetFileRecord(_id);
                textBoxFilesize.Text = record[0];
                textBoxFiledate.Text = record[1];
                textBoxDuration.Text = record[2];

                record = DataGetSet.GetInfoRecord(_id);
                textBoxBeat.Text = record[0];
                textboxComment.Text = record[1];
                textBoxMedia.Text = record[2];
                textBoxPlayed.Text = record[3];
                textBoxRating.Text = record[4];
                chechBoxSampler.Text = record[5];
                checkBoxError.Checked = Convert.ToBoolean(record[6]);
            }
            catch
            { }

            _formloaded = true;
        }
        #endregion

        private void SongValue_Changed(object sender, EventArgs e)
        {
            if (_formloaded == true)
                IsSongChanged = true;

        }

        private void FileValue_Changed(object sender, EventArgs e)
        {
            if (_formloaded == true)
                IsFileInfoChanged = true;

        }

        private void InfoValue_Changed(object sender, EventArgs e)
        {
            if (_formloaded == true)
                IsSongInfoChanged = true;

        }
    }
}
