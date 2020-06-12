using MyJukebox_EF.BLL;
using MyJukebox_EF.Commons;
using MyJukebox_EF.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyJukebox_EF
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
            FillTables();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Setting> settings = new List<Setting>();

            foreach (Control c in tableLayoutPanel.Controls)
            {
                string control = c.GetType().Name;

                if (control == "AutoSizeTextBox")
                    settings.Add(new Setting { Name = c.Name, Value = c.Text });
            }

            DataGetSet.SaveParameters(settings);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTables()
        {
            using (var context = new MyJukeboxEntities())
            {
                Label label;
                TextBox textBox;
                var settings = DataGetSet.GetParameters();

                foreach (var setting in settings)
                {
                    label = new Label();
                    label.Name = $"label{setting.ID}";
                    label.ForeColor = System.Drawing.Color.White;
                    label.AutoSize = true;
                    label.Anchor = AnchorStyles.Left;
                    label.Text = $"{setting.Name}";
                    tableLayoutPanel.Controls.Add(label);

                    textBox = new AutoSizeTextBox();
                    textBox.Name = $"{setting.Name}";
                    textBox.AutoSize = true;
                    textBox.Text = $"{(setting.Value.Length == 0 ? " " : setting.Value)}";
                    if (setting.Editable == false)
                    {
                        textBox.Enabled = false;
                    }
                    tableLayoutPanel.Controls.Add(textBox);
                }
            }
        }
    }
}
