using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class MessageBoxCeresOK
    {
        public MessageBoxCeresOK()
        {
            InitializeComponent();
            _okButton.Name = "okButton";
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public DialogResult ShowDialog(string titleMessage, string message, Form assgnForm)
        {
            titleLabel.Text = titleMessage;
            messageLabel.Text = message;
            MdlLoadingSetting.showDialogForm(this, assgnForm);
            return DialogResult;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}