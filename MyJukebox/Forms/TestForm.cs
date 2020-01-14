using System.Windows.Forms;
using MyJukebox_EF.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyJukebox_EF
{
    public partial class TestForm : Form
    {
        MyJukeboxEntities context;

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, System.EventArgs e)
        {
            context = new MyJukeboxEntities();
            context.tSongs.Load();

            var songs = from s in context.tSongs
                        select new
                        {
                            ID = s.ID,
                            Album = s.Album,
                            Titel = s.Titel
                        };

            //dataGridView1.DataSource = songs.ToList();

            dataGridView1.DataSource = context.tSongs.Local.ToBindingList();

            dataGridView1.AutoResizeColumns();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }
    }
}
