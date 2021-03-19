using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmDeactivateBooking : Form
    {
        public FrmDeactivateBooking()
        {
            InitializeComponent();
            _noButton.Name = "noButton";
            _btnComplete.Name = "btnComplete";
            _closeFlatButton.Name = "closeFlatButton";
        }

        public string BkReason;

        public object Reason
        {
            get
            {
                return BkReason;
            }

            set
            {
                BkReason = Conversions.ToString(value);
            }
        }

        public DialogResult ShowDialog(string titleMessage, Form assgnForm)
        {
            lblTitle.Text = titleMessage;
            MdlLoadingSetting.showDialogForm(this, assgnForm);
            return DialogResult;
        }

        private void Button_Abort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            switch (cboReason.SelectedIndex)
            {
                case 0:
                    {
                        BkReason = "COMPLETED";
                        break;
                    }

                case 1:
                    {
                        BkReason = "CANCELLED";
                        break;
                    }

                default:
                    {
                        BkReason = "DELETED";
                        break;
                    }
            }

            Reason = BkReason;
            Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void MessageBoxCeresYesNo_Load(object sender, EventArgs e)
        {
            cboReason.SelectedIndex = 0;
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}