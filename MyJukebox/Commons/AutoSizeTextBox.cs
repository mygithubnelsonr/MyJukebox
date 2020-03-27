using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyJukebox_EF.Commons
{
    public class AutoSizeTextBox : TextBox
    {
        #region Properties
        [Description("Minim width of the textbox")]
        [DefaultValue(30)]
        public int MinWidth { get; set; }

        [Description("Maximum width of the textbox")]
        [DefaultValue(400)]
        public int MaxWidth { get; set; }

        [Description("Padding")]
        [DefaultValue(5)]
        public new int Padding { get; set; }
        #endregion

        #region Ctor
        public AutoSizeTextBox() : base()
        {
            this.MinWidth = 30;
            this.MaxWidth = 400;
            this.Padding = 5;
        }
        #endregion
        #region Overrides
        protected override void OnTextChanged(EventArgs e)
        {
            // "Inform" the base:
            base.OnTextChanged(e);

            using (Graphics g = this.CreateGraphics())
            {
                SizeF size = g.MeasureString(this.Text, this.Font);
                int width = (int)size.Width + this.Padding;

                if (width < this.MinWidth) width = this.MinWidth;

                this.Width = width;
            }
        }
        #endregion
    }
}
