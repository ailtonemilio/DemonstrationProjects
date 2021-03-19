using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class MessageBoxCustomerMatchingWarning
    {
        public MessageBoxCustomerMatchingWarning()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _saveButton.Name = "saveButton";
            _cancelButton.Name = "cancelButton";
            _openFormLinkLabel.Name = "openFormLinkLabel";
            _dontAsnRadioButton.Name = "dontAsnRadioButton";
        }

        private int _muID;
        private int _mbID;
        public int unitSourceID = 0;
        public int recordKey = 0;

        public object VW_UnitSourceMiniUnit { get; private set; }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public DialogResult ShowDialog(VW_BookingMinibooking mbRow, object muRow, Form assgnForm)
        {
            bkgNumbLabel.Text = mbRow.BookingNumber;
            bkgCustomerLabel.Text = mbRow.CustomerName;
            VW_UnitSourceMiniUnit mu = (VW_UnitSourceMiniUnit)muRow;


            unitSourvceNumbLabel.Text = Conversions.ToString(mu.MiniunitNumber);
            try
            {
                unitSourceCustomLabel.Text = Conversions.ToString(mu.CustomerName);
            }
            catch
            {
                unitSourceCustomLabel.Text = Conversions.ToString(mu.CustomerName);
            }

            _muID = Conversions.ToInteger(mu.MiniUnitId);
            PictureBox1.Hide();
            changeUnitCustRadioButton.Checked = false;
            dontAsnRadioButton.Checked = true;
            checkUnit();
            MdlLoadingSetting.showDialogForm(this, assgnForm);
            return DialogResult;
        }

        private void save_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAssignToUnits.shouldChangeCustomer = false;
            if (changeUnitCustRadioButton.Checked & warningLabel.Text.Equals("Able to change Customer Name"))
            {
                My.MyProject.Forms.FrmAssignToUnits.shouldChangeCustomer = true;
                My.MyProject.Forms.frmAssignUnitToBooking.shouldChangeCustomer = true;
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.No;
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BunifuRadioButton2_Click(object sender, EventArgs e)
        {
            checkUnit();
        }

        private void checkUnit()
        {
            PictureBox1.Hide();
            var fBold = new Font("Segoe UI", 11f, FontStyle.Bold);
            var fNormal = new Font("Segoe UI", 11f, FontStyle.Regular);
            if (dontAsnRadioButton.Checked)
            {
                dontAsnLabel.Font = fBold;
                chageUnitCustLabel.Font = fNormal;
                warningLabel.Text = "";
                openFormLinkLabel.Text = "";
                saveButton.Enabled = true;
            }
            else if (changeUnitCustRadioButton.Checked)
            {
                dontAsnLabel.Font = fNormal;
                chageUnitCustLabel.Font = fBold;
                if (MdlBookingManagement.isAssignedToOthersMBs(_muID))
                {
                    PictureBox1.Show();
                    warningLabel.Text = "This unit is already assigned to another booking so the customer can not be changed. Please " + "create a Mini Unit with the desired customer.";
                    openFormLinkLabel.Text = "Edit Unit Source";
                    PictureBox1.Image = My.Resources.Resources.icon_not_available;
                    saveButton.Enabled = false;
                }
                else
                {
                    PictureBox1.Show();
                    warningLabel.Text = "Able to change Customer Name";
                    openFormLinkLabel.Text = "";
                    PictureBox1.Image = My.Resources.Resources.icon_available;
                    saveButton.Enabled = true;
                }
            }
        }

        private void openFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // FrmRailList.selectedRecordKey(0) = recordKey
            // FrmRailList.SelectedUniSourceId(0) = _muID

            // FrmEditAddRailList.LoadForm(True, unitSourceID, recordKey, unitSourvceNumbLabel.Text)
            var unit = UnitSourceService.GetVWById(unitSourceID);
            var unitList = new List<VW_UnitSource>();
            unitList.Add(unit);
            My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
            My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
            My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
            My.MyProject.Forms.frmAssignUnitToBooking.Close();
            My.MyProject.Forms.frmMiniUnitToAssign.Close();
            My.MyProject.Forms.FrmAssignToUnits.Close();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, My.MyProject.Forms.FrmParentScreen);
            Close();
        }
    }
}