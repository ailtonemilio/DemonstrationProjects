using Bunifu.ToggleSwitch;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmChangeEDI
    {
        public FrmChangeEDI()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _changeEDIButton.Name = "changeEDIButton";
            _systemEDIRadioButton.Name = "systemEDIRadioButton";
            _changeEDIRadioButton.Name = "changeEDIRadioButton";
        }

        public string ediMode = "";
        public BunifuToggleSwitch focusedToggle;

        // Dim EDIHelper As New ClassEDI
        private DatabaseHelperCeres db = new DatabaseHelperCeres();

        private void FrmChangeEDI_Load(object sender, EventArgs e)
        {
            // If Not (ediMode.Equals("PRESEND") Or ediMode.Equals("RESEND")) Then
            // currentEDILabel.Text = "System EDI Date/Time (" + Now.ToString("dd-MMM-yyyy @ hh:mm tt") + ")"
            // End If
            EDIDateTimePicker.Value = DateAndTime.Now;
            EdiTimePicker.Value = DateAndTime.Now;
            systemEDIRadioButton.Checked = true;
            changeEDIRadioButton.Checked = false;
            EDIDateTimePicker.Enabled = false;
            EdiTimePicker.Enabled = false;
            changeLabel.ForeColor = Color.Gray;
            atLabel.ForeColor = Color.Gray;
            if (ediMode.Equals("PRE-SEND"))
            {
                changeEDIRadioButton.Enabled = false;
            }
            else
            {
                changeEDIRadioButton.Enabled = true;
            }
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            try
            {
                focusedToggle.Value = false;
            }
            catch
            {
            }
            // FrmIsendEDILabel.Text = "(EDI WILL NOT be sent)"
            // sendEDILabel.ForeColor = Color.Firebrick
            // FrmChangeEDI.focusedToggle = sendEDIBunifuToggleSwitch
            Close();
        }

        private void currentEDIRadioButton_Click(object sender, EventArgs e)
        {
            if (systemEDIRadioButton.Checked)
            {
                EDIDateTimePicker.Enabled = false;
                EdiTimePicker.Enabled = false;
                changeLabel.ForeColor = Color.Gray;
                atLabel.ForeColor = Color.Gray;
                currentEDILabel.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void changeEDIRadioButton_Click(object sender, EventArgs e)
        {
            if (changeEDIRadioButton.Checked)
            {
                EDIDateTimePicker.Enabled = true;
                EdiTimePicker.Enabled = true;
                changeLabel.ForeColor = Color.FromArgb(64, 64, 64);
                atLabel.ForeColor = Color.FromArgb(64, 64, 64);
                currentEDILabel.ForeColor = Color.Gray;
            }
        }

        private void changeEDIButton_Click(object sender, EventArgs e)
        {
            int recordID;
            DataGridViewRow row;
            DateTime gateDateTime;
            int lastEDIRecordAdded;
            {
                var withBlock = My.MyProject.Forms.FrmEDIManagement;
                if (ediMode.Equals("RESEND"))
                {
                    MdlLoadingSetting.waitForm.Show();
                    // selectedIDs = .getSelectedContIDs(.InGateDataGridView)

                    foreach (DataGridViewRow currentRow in My.MyProject.Forms.FrmEDIManagement.InGateDataGridView.Rows)
                    {
                        row = currentRow;
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[1].Value, true, false)))
                        {
                            recordID = Conversions.ToInteger(row.Cells[0].Value);
                            gateDateTime = Convert.ToDateTime(row.Cells[9].Value);
                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), "CREATE", "IN-GATE", "Requested EDI to be RESENT");
                            db.AddEDILog(recordID, "IN-GATE", "IN GATE - Resend EDI");
                            lastEDIRecordAdded = db.getLadstEDIadded();
                            DateTime EDIDateTime;
                            if (systemEDIRadioButton.Checked)
                            {
                                db.saveEDIModifiedRecord(lastEDIRecordAdded, gateDateTime);
                                db.pushEDIRequest(recordID, true, false, lastEDIRecordAdded, gateDateTime);
                            }
                            else
                            {
                                string EDIdateTimeSrt;
                                EDIdateTimeSrt = EDIDateTimePicker.Value.ToShortDateString() + " " + EdiTimePicker.Value.ToShortTimeString();
                                EDIDateTime = Convert.ToDateTime(EDIdateTimeSrt);
                                db.pushEDIRequest(recordID, true, false, lastEDIRecordAdded, EDIDateTime);
                            }
                        }
                    }

                    withBlock.getEDIs(withBlock.InGateDataGridView);
                    MdlLoadingSetting.waitForm.Close();
                }
                else if (ediMode.Equals("PRE-SEND"))
                {
                    MdlLoadingSetting.waitForm.Show();
                    foreach (DataGridViewRow currentRow1 in My.MyProject.Forms.FrmEDIManagement.OutGateDataGridView.Rows)
                    {
                        row = currentRow1;
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[1].Value, true, false)))
                        {
                            recordID = Conversions.ToInteger(row.Cells[0].Value);
                            gateDateTime = DateAndTime.Now;
                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), "CREATE", "OUT-GATE", "Requested EDI to be PRE-SENT");
                            db.AddEDILog(recordID, "OUT-GATE", "OUT GATE - Pre-Send EDI");
                            lastEDIRecordAdded = db.getLadstEDIadded();
                            DateTime EDIDateTime;
                            if (systemEDIRadioButton.Checked)
                            {
                                // EDIHelper.EDIContainers(selContainer.Value, ediMode, False, selContainer.Key)

                                db.saveEDIModifiedRecord(lastEDIRecordAdded, gateDateTime);
                                db.UpdatePreSendStatus(recordID, true);
                                db.pushEDIRequest(recordID, false, true, lastEDIRecordAdded, gateDateTime);
                            }
                            else
                            {
                                string EDIdateTimeSrt;
                                EDIdateTimeSrt = EDIDateTimePicker.Value.ToShortDateString() + " " + EdiTimePicker.Value.ToShortTimeString();
                                EDIDateTime = Convert.ToDateTime(EDIdateTimeSrt);
                                db.UpdatePreSendStatus(recordID, true);
                                db.pushEDIRequest(recordID, false, true, lastEDIRecordAdded, Conversions.ToDate(EDIdateTimeSrt));
                            }
                        }
                    }

                    withBlock.getEDIs(withBlock.OutGateDataGridView);
                    MdlLoadingSetting.waitForm.Close();
                }
            }

            Hide();
        }
    }
}