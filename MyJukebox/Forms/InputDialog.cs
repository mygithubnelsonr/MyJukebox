using System.Windows.Forms;

namespace MyJukebox_EF
{
    public partial class InputDialog : Form
    {
        private string _caption = "Input Dialog";
        private string _prompt = "Input:";
        private string _defaultText = "";
        //private string _ok = "OK";
        //private string _cancel = "Cancel";

        //public InputBox(string caption = "InputYYY", string prompt = "Input", string defauttext = "", string ok = "OK", string cancel = "Cancel")
        public InputDialog(string Caption, string Prompt = "Input:", string DefautText = "Unnamed")
        {
            InitializeComponent();
            _caption = Caption;
            _prompt = Prompt;
            _defaultText = DefautText;
        }

        private void InputDialog_Load(object sender, System.EventArgs e)
        {
            this.Text = _caption;
            this.labelPrompt.Text = _prompt;
            //this.textBoxInput.Text = _defaultText;
            //this.buttonOK.Text = _ok;
            //this.buttonCancel.Text = _cancel;
        }
    }
}
