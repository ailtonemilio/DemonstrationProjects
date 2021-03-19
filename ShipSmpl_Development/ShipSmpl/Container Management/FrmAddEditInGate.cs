using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddEditInGate
    {
        public FrmAddEditInGate()
        {
            InitializeComponent();
            _sendEDIBunifuToggleSwitch.Name = "sendEDIBunifuToggleSwitch";
            _saveBunifuButton.Name = "saveBunifuButton";
            _noBunifuButton.Name = "noBunifuButton";
            _streetTurnBunifuCheckBox.Name = "streetTurnBunifuCheckBox";
            _containerBunifuTextBox.Name = "containerBunifuTextBox";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();
        private string modifiedEDIdateTimeSrt;
        public DateTime modifiedEDIDateTime;
        private DataTable companies = new DataTable();

        private void noBunifuButton_Click(object sender, EventArgs e)
        {
            cleanFields();
            for (int i = 0, loopTo = My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[1].Value = false;
            Close();
        }

        // Dim inGateUniqueIDList() As Integer

        private void FrmAddEditInGate_Load(object sender, EventArgs e)
        {
            // inGateUniqueIDList = FrmInOutGate.containersIDIn

            companies = db.getTableInfo("VW_CompanyCompanyType", "*", "order by CompanyName");
            var truckDrivers = db.getTableInfo("[Truck Drivers]", "*", "order by [Truck Number]");
            // Dim ssLineCeres As DataTable = db.getTableInfo("[Containers In-Out]", "*", "order by [Truck Number]")
            fromComboBox.Items.Clear();
            toBunifuDropdown.Items.Clear();
            carrierBunifuDropdown.Items.Clear();
            shippingLineBunifuDropdown.Items.Clear();
            truckNumberBunifuDropdown1.Items.Clear();
            fromComboBox.Items.Add("N/A");
            toBunifuDropdown.Items.Add("N/A");
            carrierBunifuDropdown.Items.Add("N/A");
            shippingLineBunifuDropdown.Items.Add("N/A");
            truckNumberBunifuDropdown1.Items.Add("N/A");
            foreach (DataRow company in companies.Rows)
            {
                if (company["DescCompanyType"].Equals("Container Terminal"))
                {
                    fromComboBox.Items.Add(Strings.Trim(Conversions.ToString(company["Companycode"])) + " (" + Strings.Trim(Conversions.ToString(company["CompanyName"])) + ")");
                    toBunifuDropdown.Items.Add(Strings.Trim(Conversions.ToString(company["Companycode"])) + " (" + Strings.Trim(Conversions.ToString(company["CompanyName"])) + ")");
                }
                else if (company["DescCompanyType"].Equals("Drayage Provider"))
                {
                    carrierBunifuDropdown.Items.Add((Strings.Trim(Conversions.ToString(company["Companycode"])) + " (" + Strings.Trim(Conversions.ToString(company["CompanyName"])) + ")").ToUpper());
                }
                else if (company["DescCompanyType"].Equals("Steamship Line"))
                {
                    shippingLineBunifuDropdown.Items.Add((Strings.Trim(Conversions.ToString(company["Companycode"])) + " (" + Strings.Trim(Conversions.ToString(company["CompanyName"])) + ")").ToUpper());
                }
            }

            foreach (DataRow truckDriver in truckDrivers.Rows)
                truckNumberBunifuDropdown1.Items.Add(Strings.Trim(Conversions.ToString(truckDriver["Truck Number"])));
            cleanFields();
            if (My.MyProject.Forms.FrmInOutGate.isNewRecord == false)
            {
                int recordID = 0;
                int focusedRow = 0;
                focusedRow = My.MyProject.Forms.FrmInOutGate.InGateDataGridView.CurrentRow.Index;
                recordID = Conversions.ToInteger(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[focusedRow].Cells[0].Value);
                titleLabel.Text = "Edit Record - In Gate";
                saveBunifuButton.Text = "UPDATE";
                MdlContainerManagement.populateInGateInfo(this, recordID);
            }
            // ediPanel.Hide()
            else
            {
                titleLabel.Text = "Create New Record - In Gate";
                // ediPanel.Show()

                saveBunifuButton.Text = "SAVE";
            }

            fromComboBox.DropDownHeight = Height - 100;
            toBunifuDropdown.DropDownHeight = Height - 100;
            carrierBunifuDropdown.DropDownHeight = Height - 100;
            shippingLineBunifuDropdown.DropDownHeight = Height - 100;
            truckNumberBunifuDropdown1.DropDownHeight = Height - 100;
        }

        private int containerIndexCount = 0;

        private void containerBunifuTextBox_TextChanged(object sender, EventArgs e)
        {
            availablePictureBox.Visible = true;
            if (string.IsNullOrEmpty(containerBunifuTextBox.Text))
            {
                availablePictureBox.Visible = false;
            }
            else if (MdlContainerManagement.ValidateContainer(containerBunifuTextBox.Text))
            {
                availablePictureBox.Image = My.Resources.Resources.icon_available;
            }
            else
            {
                availablePictureBox.Image = My.Resources.Resources.icon_not_available;
            }
        }

        private void BunifuToggleSwitch2_OnValuechange(object sender, EventArgs e)
        {
            if (sendEDIBunifuToggleSwitch.Value == true)
            {
                string ssLineCode;
                bool isAllowedssLine;
                ssLineCode = Strings.Trim(shippingLineBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                isAllowedssLine = companies.Select("[EDIRequired] = true and CompanyCode = '" + ssLineCode + "'").Count() > 0;
                if (isAllowedssLine)
                {
                    sendEDILabel.Text = "(EDI WILL be sent)";
                    sendEDILabel.ForeColor = Color.Firebrick;
                    My.MyProject.Forms.FrmChangeEDI.focusedToggle = sendEDIBunifuToggleSwitch;
                    My.MyProject.Forms.FrmChangeEDI.ediMode = "IN-GATE";
                    DateTime gateDateTime;
                    DateTime gateDateTimeTR;
                    gateDateTimeTR = Conversions.ToDate(dateDateTimePicker.Value.ToShortDateString() + " " + timeDateTimePicker.Value.ToShortTimeString());
                    gateDateTime = Convert.ToDateTime(gateDateTimeTR);
                    My.MyProject.Forms.FrmChangeEDI.currentEDILabel.Text = "Gate DateTime EDI (" + gateDateTime.ToString("dd-MMM-yyyy hh:mm tt") + ")";
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmChangeEDI, this);
                }
                else
                {
                    sendEDILabel.Text = "(EDI will NOT be sent)";
                    sendEDILabel.ForeColor = Color.FromArgb(64, 64, 0);
                    MessageBox.Show("This Shipping Line does not require EDI");
                    sendEDIBunifuToggleSwitch.Value = false;
                }
            }
            else
            {
                sendEDILabel.Text = "(EDI will NOT be sent)";
                sendEDILabel.ForeColor = Color.FromArgb(64, 64, 0);
            }
        }

        private void saveBunifuButton_Click(object sender, EventArgs e)
        {
            string actionTaken = "";
            int lastEDIRecordAdded;
            DataRow dataRows;
            string gateAction;
            var recordID = default(int);
            if (My.MyProject.Forms.FrmInOutGate.isNewRecord)
            {
                MdlContainerManagement.saveInGate(0, this);
                recordID = MdlContainerManagement.lastrecordID;
                actionTaken = "CREATE";
                gateAction = "IN-GATE";
            }
            else
            {
                for (int i = 0, loopTo = My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[0].Value);
                        break;
                    }
                }

                MdlContainerManagement.saveInGate(recordID, this);
                actionTaken = "UPDATE";
                gateAction = "IN-GATE";
            }

            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), actionTaken, gateAction, "");

            // ' To send EDI -- program only allow specific ss lines
            string ssLineCode;
            ssLineCode = Strings.Trim(shippingLineBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
            if (sendEDIBunifuToggleSwitch.Value == true)
            {
                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), actionTaken, gateAction, "Requested EDI to be sent");
                db.AddEDILog(recordID, "IN-GATE", gateAction);
                lastEDIRecordAdded = db.getLadstEDIadded();
                if (My.MyProject.Forms.FrmChangeEDI.changeEDIRadioButton.Checked)
                {
                    DateTime modDateTime;
                    DateTime modDateTimeSTR;
                    modDateTimeSTR = Conversions.ToDate(My.MyProject.Forms.FrmChangeEDI.EDIDateTimePicker.Value.ToShortDateString() + " " + My.MyProject.Forms.FrmChangeEDI.EdiTimePicker.Value.ToShortTimeString());
                    modDateTime = Convert.ToDateTime(modDateTimeSTR);
                    db.saveEDIModifiedRecord(lastEDIRecordAdded, modDateTime);
                    db.pushEDIRequest(recordID, true, false, lastEDIRecordAdded, modDateTime);
                }
                else
                {
                    DateTime gateDateTime;
                    DateTime gateDateTimeTR;
                    gateDateTimeTR = Conversions.ToDate(dateDateTimePicker.Value.ToShortDateString() + " " + timeDateTimePicker.Value.ToShortTimeString());
                    gateDateTime = Convert.ToDateTime(gateDateTimeTR);
                    db.pushEDIRequest(recordID, true, false, lastEDIRecordAdded, gateDateTime);
                }
            }

            My.MyProject.Forms.FrmInOutGate.isRefresh = true;
            My.MyProject.Forms.FrmInOutGate.getInOutContainers();
            cleanFields();
            for (int i = 0, loopTo1 = My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[1].Value = false;
            My.MyProject.Forms.FrmInOutGate.checkButtons();
            Close();
        }

        private void cleanFields()
        {
            fromComboBox.SelectedIndex = 0;
            toBunifuDropdown.SelectedIndex = 0;
            dateDateTimePicker.Value = DateAndTime.Now;
            timeDateTimePicker.Value = DateAndTime.Now;
            containerBunifuTextBox.Text = "";
            tareWeightBunifuTextBox.Text = "";
            maxWeightBunifuTextBox.Text = "";
            releaseNumberBunifuTextBox.Text = "";
            fromComboBox.SelectedIndex = 0;
            toBunifuDropdown.SelectedIndex = 0;
            carrierBunifuDropdown.SelectedIndex = 0;
            shippingLineBunifuDropdown.SelectedIndex = 0;
            statusBunifuDropdown.SelectedIndex = 0;
            sizeBunifuDropdown.SelectedIndex = 0;
            damagesDropdown.SelectedIndex = 0;
            truckNumberBunifuDropdown1.SelectedIndex = 0;
            dateDateTimePicker.Value = DateAndTime.Now;
            timeDateTimePicker.Value = DateAndTime.Now;
            damagesDropdown.SelectedIndex = 0;
            My.MyProject.Forms.FrmInOutGate.numbOfSelecCans = 0;
            My.MyProject.Forms.FrmChangeEDI.changeEDIRadioButton.Checked = false;
            My.MyProject.Forms.FrmChangeEDI.systemEDIRadioButton.Checked = true;
            sendEDIBunifuToggleSwitch.Value = false;
            troubleBunifuToggleSwitch1.Value = false;
        }

        private void streetTurnBunifuCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (streetTurnBunifuCheckBox.Checked)
            {
                releaseTableLayoutPanel.Hide();
            }
            else
            {
                releaseTableLayoutPanel.Show();
            }
        }
    }
}