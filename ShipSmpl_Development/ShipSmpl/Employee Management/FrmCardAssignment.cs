using Bunifu.ToggleSwitch;
using Bunifu.UI.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmCardAssignment
    {
        public FrmCardAssignment()
        {
            InitializeComponent();
            _BunifuToggleSwitch1.Name = "BunifuToggleSwitch1";
            _closeButton.Name = "closeButton";
        }

        public string _cardID { get; set; } = "";

        private DatabaseHelper db = new DatabaseHelper();
        private BunifuDataGridView employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;

        public bool isPhoneID { get; set; } = false;

        private void Key_press_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.ShiftKey)
            {
                /* TODO ERROR: Skipped WarningDirectiveTrivia */
                if (e.KeyCode == Keys.Enter)
                {
                    _cardID = _cardID.Substring(1, _cardID.Length - 2);
                    MdlModifyData.reassignCardID(_cardID);
                }
                else
                {
                    _cardID += char.ConvertFromUtf32(e.KeyValue);
                }
            }
        }

        private int selectedRow;
        private string firstName;
        private string lastName;

        private void FrmCardAssignment_Load(object sender, EventArgs e)
        {
            reassignCardTitleLabel.ForeColor = Color.FromArgb(64, 64, 0);
            reassignCardTitleLabel.BackColor = Color.White;
            BunifuToggleSwitch1.Value = false;
            PictureBox1.Image = My.Resources.Resources.tapCard;
            PictureBox1.BackColor = Color.LightSeaGreen;
            selectedRow = employeDataGridView.CurrentCell.RowIndex;
            firstName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[1].Value);
            lastName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[2].Value);
            string device = "";
            if (isPhoneID)
            {
                device = "device";
            }
            else
            {
                device = "card";
            }

            reassignCardTitleLabel.Text = "Scan " + device + " that will be assigned to " + firstName + " " + lastName;
        }

        private void BunifuToggleSwitch1_OnValuechange(object sender, EventArgs e)
        {
            BunifuToggleSwitch b = (BunifuToggleSwitch)sender;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(b.Value, true, false)))
            {
                isPhoneID = true;
                PictureBox1.Image = My.Resources.Resources.cellphoneTap;
                PictureBox1.BackColor = Color.FromArgb(192, 64, 0);
                reassignCardTitleLabel.Text = "Scan the phone that will be assigned to " + firstName + " " + lastName;
            }
            else
            {
                PictureBox1.Image = My.Resources.Resources.tapCard;
                PictureBox1.BackColor = Color.Teal;
                reassignCardTitleLabel.Text = "Scan the card that will be assigned to " + firstName + " " + lastName;
                isPhoneID = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}