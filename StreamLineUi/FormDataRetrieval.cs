using System;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class FormDataRetrieval : Form
    {
        internal string dataValue { get; set; }

        public FormDataRetrieval(string labelText, string buttonText, string messageText)
        {
            InitializeComponent();
            labelDescription.Text = labelText;
            labelMessage.Text = messageText;
            buttonDone.Text = buttonText;
        }

        private void event_Done(object sender, EventArgs e)
        {
            this.dataValue = textboxDataValue.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void event_Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
