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
    public partial class FrmAddEditOutGate
    {
        public FrmAddEditOutGate()
        {
            InitializeComponent();
            _sendEDIBunifuToggleSwitch.Name = "sendEDIBunifuToggleSwitch";
            _saveBunifuButton.Name = "saveBunifuButton";
            _noBunifuButton.Name = "noBunifuButton";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();
        private DataTable companies = new DataTable();
        private string EDIdateTimeSrt;
        public DateTime EDIDateTime;

        private void FrmAddEditOutGate_Load(object sender, EventArgs e)
        {
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
                titleLabel.Text = "Edit Record - Out Gate";
                for (int i = 0, loopTo = My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows[i].Cells[0].Value);
                        break;
                    }
                }
            }
            // ediPanel.Hide()
            else
            {
                titleLabel.Text = "Create New Record - Out Gate";
                for (int i = 0, loopTo1 = My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[1].Value, true, false)))
                    {
                        recordID = Conversions.ToInteger(My.MyProject.Forms.FrmInOutGate.InGateDataGridView.Rows[i].Cells[0].Value);
                        break;
                    }
                }
                // ediPanel.Show()
            }

            MdlContainerManagement.populateOutGateInfo(this, recordID);
            fromComboBox.DropDownHeight = Height - 100;
            toBunifuDropdown.DropDownHeight = Height - 100;
            carrierBunifuDropdown.DropDownHeight = Height - 100;
            shippingLineBunifuDropdown.DropDownHeight = Height - 100;
            truckNumberBunifuDropdown1.DropDownHeight = Height - 100;
        }

        private void cleanFields()
        {
            fromComboBox.SelectedIndex = 0;
            toBunifuDropdown.SelectedIndex = 0;
            dateDateTimePicker.Value = DateAndTime.Now;
            timeDateTimePicker.Value = DateAndTime.Now;
            bookingNumberBunifuTextBox.Text = "";
            containerBunifuTextBox.Text = "";
            tareWeightBunifuTextBox.Text = "";
            maxWeightBunifuTextBox.Text = "";
            cargoBunifuTextBox1.Text = "";
            sealNumberBunifuTextBox2.Text = "";
            My.MyProject.Forms.FrmInOutGate.numbOfSelecCans = 0;
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
            sendEDIBunifuToggleSwitch.Value = false;
            holdBunifuToggleSwitch1.Value = false;
            My.MyProject.Forms.FrmInOutGate.checkButtons();
        }

        private void noBunifuButton_Click(object sender, EventArgs e)
        {
            cleanFields();
            for (int i = 0, loopTo = My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows[i].Cells[1].Value = false;
            Close();
        }

        private int recordID = 0;

        private void saveBunifuButton_Click(object sender, EventArgs e)
        {
            string actionTaken = "";
            int lastEDIRecordAdded;
            DataRow dataRows;
            string gateAction;
            // recordID = inGateUniqueIDList(0)

            if (My.MyProject.Forms.FrmInOutGate.isNewRecord)
            {
                actionTaken = "Create";
            }
            else
            {
                actionTaken = "Update";
            }

            gateAction = "OUT-GATE";
            // Save Outgate info
            MdlContainerManagement.saveOutGate(recordID, this);

            // Save Log
            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), actionTaken, gateAction, "");
            string ssLineCode;
            ssLineCode = Strings.Trim(shippingLineBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
            if (sendEDIBunifuToggleSwitch.Value == true)
            {
                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), actionTaken, gateAction, "Requested EDI to be sent");
                db.AddEDILog(recordID, "OUT-GATE", gateAction);
                lastEDIRecordAdded = db.getLadstEDIadded();
                if (My.MyProject.Forms.FrmChangeEDI.changeEDIRadioButton.Checked)
                {
                    DateTime modDateTime;
                    DateTime modDateTimeSTR;
                    modDateTimeSTR = Conversions.ToDate(My.MyProject.Forms.FrmChangeEDI.EDIDateTimePicker.Value.ToShortDateString() + " " + My.MyProject.Forms.FrmChangeEDI.EdiTimePicker.Value.ToShortTimeString());
                    modDateTime = Convert.ToDateTime(modDateTimeSTR);
                    db.saveEDIModifiedRecord(lastEDIRecordAdded, modDateTime);
                    // db.UpdatePreSendStatus(recordID, True)
                    db.pushEDIRequest(recordID, false, true, lastEDIRecordAdded, modDateTime);
                }
                else
                {
                    DateTime gateDateTime;
                    DateTime gateDateTimeTR;
                    gateDateTimeTR = Conversions.ToDate(dateDateTimePicker.Value.ToShortDateString() + " " + timeDateTimePicker.Value.ToShortTimeString());
                    gateDateTime = Convert.ToDateTime(gateDateTimeTR);
                    // db.UpdatePreSendStatus(recordID, True)
                    db.pushEDIRequest(recordID, false, true, lastEDIRecordAdded, gateDateTime);
                }
            }

            cleanFields();
            for (int i = 0, loopTo = My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows.Count - 1; i <= loopTo; i++)
                My.MyProject.Forms.FrmInOutGate.OutGateDataGridView.Rows[i].Cells[1].Value = false;
            My.MyProject.Forms.FrmInOutGate.isRefresh = true;
            My.MyProject.Forms.FrmInOutGate.tabinoutGate.SelectedIndex = 1;
            My.MyProject.Forms.FrmInOutGate.getInOutContainers();
            My.MyProject.Forms.FrmInOutGate.checkButtons();
            Close();
        }

        private void sendEDIBunifuToggleSwitch_OnValuechange(object sender, EventArgs e)
        {
            if (sendEDIBunifuToggleSwitch.Value == true)
            {
                string ssLineCode;
                bool isAllowedssLine;
                ssLineCode = Strings.Trim(shippingLineBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                isAllowedssLine = companies.Select("[RequireEDI] = true and CompanyCode = '" + ssLineCode + "'").Count() > 0;
                if (isAllowedssLine)
                {
                    My.MyProject.Forms.FrmChangeEDI.focusedToggle = sendEDIBunifuToggleSwitch;
                    DateTime gateDateTime;
                    DateTime gateDateTimeTR;
                    gateDateTimeTR = Conversions.ToDate(dateDateTimePicker.Value.ToShortDateString() + " " + timeDateTimePicker.Value.ToShortTimeString());
                    gateDateTime = Convert.ToDateTime(gateDateTimeTR);
                    My.MyProject.Forms.FrmChangeEDI.ediMode = "OUT-GATE";
                    My.MyProject.Forms.FrmChangeEDI.currentEDILabel.Text = "Gate DateTime EDI (" + gateDateTime.ToString("dd-MMM-yyyy hh:mm tt") + ")";
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmChangeEDI, this);
                }
                // EDIdateTimeSrt = FrmChangeEDI.EDIDateTimePicker.Value.ToShortDateString + " " + FrmChangeEDI.EdiTimePicker.Value.ToShortTimeString
                // EDIDateTime = Convert.ToDateTime(EDIdateTimeSrt)
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
    }
}