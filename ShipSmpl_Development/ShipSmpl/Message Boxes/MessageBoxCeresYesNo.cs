using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class MessageBoxCeresYesNo : Form
    {
        public MessageBoxCeresYesNo()
        {
            InitializeComponent();
            _noButton.Name = "noButton";
            _yesButton.Name = "yesButton";
        }

        public DialogResult ShowDialog(string titleMessage, string message, Image pictureWarning, Form assgnForm)
        {
            titleLabel.Text = titleMessage;
            messageLabel.Text = message;
            PictureBox1.Image = pictureWarning;
            MdlLoadingSetting.showDialogForm(this, assgnForm);
            return DialogResult;
        }

        private void Button_Abort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void MessageBoxCeresYesNo_Load(object sender, EventArgs e)
        {
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}