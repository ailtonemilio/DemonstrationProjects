using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class MessageBoxConfirmDelete
    {
        public MessageBoxConfirmDelete()
        {
            InitializeComponent();
            _noBunifuButton.Name = "noBunifuButton";
            _yesBunifuButton.Name = "yesBunifuButton";
            _confirmationBunifuTextBox.Name = "confirmationBunifuTextBox";
        }

        private string textToCheck = "";

        public DialogResult ShowDialog(string titleMessage, string message, string textToConfirm, Form assgnForm)
        {
            titleLabel.Text = titleMessage;
            mainMessageLabel.Text = message;
            textToCheck = Strings.Trim(textToConfirm);
            MdlLoadingSetting.showDialogForm(this, assgnForm);
            return DialogResult;
        }

        private void Button_Abort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void confirmationBunifuTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmationBunifuTextBox.Text.Equals(textToCheck))
            {
                yesBunifuButton.Enabled = true;
            }
            else
            {
                yesBunifuButton.Enabled = false;
            }
        }

        private void yesBunifuButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}