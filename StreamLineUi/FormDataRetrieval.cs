using System;
using System.Drawing;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class FormDataRetrieval : Form
    {
        private Common common = new Common();
        private string uiColor;
        private string userProvidedDataValue;

        public FormDataRetrieval(string uiColor, string labelText, string buttonText, string messageText)
        {
            InitializeComponent();
            this.uiColor = uiColor;
            labelDescription.Text = labelText;
            labelMessage.Text = messageText;
            buttonDone.Text = buttonText;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            Color color = common.event_RetrieveUiColor(uiColor);
            common.event_ChangeButtonColor(buttonDone, color);
            common.event_ChangeButtonColor(buttonCancel, color);
        }

        private void event_Done(object sender, EventArgs e)
        {
            userProvidedDataValue = textboxDataValue.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void event_Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        internal string UserSpecifiedDataValue { get => userProvidedDataValue; }
    }
}