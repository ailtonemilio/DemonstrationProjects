using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddEditServices
    {
        public FrmAddEditServices()
        {
            InitializeComponent();
            _Label8.Name = "Label8";
            _servTypeDropdown.Name = "servTypeDropdown";
            _cancelButton.Name = "cancelButton";
            _saveButton.Name = "saveButton";
            _toDateToggleSwitch.Name = "toDateToggleSwitch";
            _endDateCheckbox.Name = "endDateCheckbox";
            _diffRateRadioButton.Name = "diffRateRadioButton";
            _sameRateRadioButton.Name = "sameRateRadioButton";
            _wkDayCutoffCheckbox.Name = "wkDayCutoffCheckbox";
            _wkDayDayRateFeeday.Name = "wkDayDayRateFeeday";
            _wkEndCutOffCheckbox.Name = "wkEndCutOffCheckbox";
            _wkEndsDayNumericUpDown.Name = "wkEndsDayNumericUpDown";
            _closeFlatButton.Name = "closeFlatButton";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        public string typeOfUpdate = "";

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int servID = 0;
            int frcRateID = 0;
            string compCode = "";
            var rateType = default(string);
            decimal rate;
            if (typeOfUpdate.Equals("update"))
            {
                servID = Conversions.ToInteger(My.MyProject.Forms.FrmServices.servicesDataGridView.Rows[My.MyProject.Forms.FrmServices.servicesDataGridView.CurrentRow.Index].Cells[0].Value);
            }
            else
            {
                servID = 0;
            }

            foreach (DataRow company in My.MyProject.Forms.FrmServices.companiesDT.Rows)
            {
                if (company["DescCompanyType"].Equals("Trucking Company"))
                {
                    if (company["CompanyName"].ToString().ToUpper().Equals(truckNameDropdown6.SelectedItem))
                    {
                        compCode = Conversions.ToString(company["CompanyCode"]);
                    }
                }
            }

            if (servTypeDropdown.SelectedItem.Equals("Drayage"))
            {
                if (singleEmptyRadioButton.Checked)
                {
                    rateType = "Single Empty";
                }
                else if (multipleEmtyRadioButton.Checked)
                {
                    rateType = "Multiple Empty";
                }
                else if (multLoadRadioButton.Checked)
                {
                    rateType = "Multiple Load";
                }
                else if (singleLoadsRadioButton2.Checked)
                {
                    rateType = "Single Load";
                }
                else if (deadCallRadioButton.Checked)
                {
                    rateType = "Dead Call";
                }
                else if (transfersRadioButton.Checked)
                {
                    rateType = "Transfer";
                }

                dbCeres.saveUpdateDrayage(servID, Conversions.ToString(truckNameDropdown6.SelectedItem), rateType, Conversions.ToString(fromDropdown.SelectedItem), Conversions.ToString(toDropdown.SelectedItem), rateNumericUpDown.Value);
            }
            else if (servTypeDropdown.SelectedItem.Equals("FSC"))
            {
                dbCeres.saveUpdateFSC(frcRateID, Conversions.ToString(truckNameDropdown6.SelectedItem), fromDatePicker.Value, toDatePicker.Value, rateFSCUpDown.Value, Conversions.ToString(servTypeDropdown.SelectedItem), toDateToggleSwitch.Value);
            }
            else
            {
                if (sameRateRadioButton.Checked == true)
                {
                    wkEndCutOffTimePicker.Value = wkDayCutOfftimePicker.Value;
                    wkEndsDayNumericUpDown.Value = wkDayDayRateFeeday.Value;
                    wkEndNightNumericUpDown.Value = wkDayNightRateUpDown.Value;
                }

                dbCeres.saveUpdateTEF(servID, wkDayCutOfftimePicker.Value, wkDayDayRateFeeday.Value, wkDayNightRateUpDown.Value, wkEndCutOffTimePicker.Value, wkEndsDayNumericUpDown.Value, wkEndNightNumericUpDown.Value, Conversions.ToString(portsRvDropdown.SelectedItem), fromRVDatePicker.Value, toRVDatePicker.Value, Conversions.ToString(rvRateTypeDropdown.SelectedItem));
            }

            My.MyProject.Forms.FrmServices.populateServices();
            Close();
        }

        private void FrmAddEditServices_Load(object sender, EventArgs e)
        {
            // Populate Trucking company DropDownBox
            var companiesDT = new DataTable();
            companiesDT = dbCeres.getTableInfo("VW_CompanyCompanyType", "*", "order by CompanyName");
            truckNameDropdown6.Items.Clear();
            fromDropdown.Items.Clear();
            toDropdown.Items.Clear();
            portsRvDropdown.Items.Clear();
            fromDropdown.Items.Add("All");
            toDropdown.Items.Add("All");
            foreach (DataRow company in companiesDT.Rows)
            {
                if (company["CompanyType"].Equals("Trucking Company"))
                {
                    truckNameDropdown6.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
                else if (company["CompanyType"].Equals("Terminal"))
                {
                    fromDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                    toDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                    portsRvDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
            }

            truckNameDropdown6.Items.Add("ALL");
            truckNameDropdown6.SelectedIndex = 0;
            servTypeDropdown.SelectedIndex = 0;
            fromDropdown.SelectedIndex = 0;
            toDropdown.SelectedIndex = 0;
            sameRateRadioButton.Checked = true;
            diffRateRadioButton.Checked = false;
            rvRateTypeDropdown.SelectedIndex = 0;
            portsRvDropdown.SelectedIndex = 0;
            truckNameDropdown6.DropDownHeight = Height - 200;
            wkDayCutOfftimePicker.Value = DateAndTime.Now;
            endDateCheckbox.Checked = false;
            if (typeOfUpdate.Equals("update"))
            {
                int selectedRow = My.MyProject.Forms.FrmServices.servicesDataGridView.CurrentRow.Index;
                int id = Conversions.ToInteger(My.MyProject.Forms.FrmServices.servicesDataGridView.Rows[selectedRow].Cells[0].Value);
                if (My.MyProject.Forms.FrmServices.servTypeDropdown.SelectedItem.Equals("Drayage"))
                {
                    string argtableName = "Drayage_Rate";
                    populateServiceInfo(ref argtableName, id);
                }
                else
                {
                    string argtableName1 = "FSC_Rate";
                    populateServiceInfo(ref argtableName1, id);
                }
            }
        }

        private void servTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if drayage show tab drayage
            if (servTypeDropdown.SelectedIndex == 0)
            {
                ratePages.SelectedIndex = 0;
                truckNameDropdown6.Enabled = true;
            }
            else if (servTypeDropdown.SelectedIndex == 1)
            {
                ratePages.SelectedIndex = 1;
                percentLabel.Show();
                truckNameDropdown6.Enabled = false;
                rateFSCUpDown.DecimalPlaces = 0;
            }
            else
            {
                ratePages.SelectedIndex = 2;
                truckNameDropdown6.Text = "";
                truckNameDropdown6.Enabled = false;
                percentLabel.Hide();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            beforeLabel.Text = "RV Fee Before  " + wkDayCutOfftimePicker.Value.ToString("hh:mm tt") + ":";
        }

        private void populateServiceInfo(ref string tableName, int id)
        {
            singleEmptyRadioButton.Checked = false;
            multipleEmtyRadioButton.Checked = false;
            multLoadRadioButton.Checked = false;
            singleLoadsRadioButton2.Checked = false;
            deadCallRadioButton.Checked = false;
            transfersRadioButton.Checked = false;
            foreach (DataRow row in dbCeres.getTableInfo(tableName, "*", "where ID =" + id.ToString()).Rows)
            {
                if (tableName.Equals("Drayage_Rate"))
                {
                    truckNameDropdown6.SelectedItem = row["Trucking_Company"];
                    servTypeDropdown.SelectedIndex = 0;
                    if (row["Rate_Type"].Equals("Single Empty"))
                    {
                        singleEmptyRadioButton.Checked = true;
                    }
                    else if (row["Rate_Type"].Equals("Multiple Empty"))
                    {
                        multipleEmtyRadioButton.Checked = true;
                    }
                    else if (row["Rate_Type"].Equals("Single Load"))
                    {
                        singleLoadsRadioButton2.Checked = true;
                    }
                    else if (row["Rate_Type"].Equals("Multiple Load"))
                    {
                        multLoadRadioButton.Checked = true;
                    }
                    else if (row["Rate_Type"].Equals("Dead Call"))
                    {
                        deadCallRadioButton.Checked = true;
                    }
                    else if (row["Rate_Type"].Equals("Transfer"))
                    {
                        transfersRadioButton.Checked = true;
                    }

                    fromDropdown.SelectedItem = row["From"];
                    toDropdown.SelectedItem = row["To"];
                    rateNumericUpDown.Value = Conversions.ToDecimal(row["Rate"]);
                }
                else
                {
                    truckNameDropdown6.Enabled = false;
                    servTypeDropdown.SelectedItem = row["Rate_Name"];
                    fromDatePicker.Value = Conversions.ToDate(row["From_Date"]);
                    if (row["To_Date"] != DBNull.Value)
                    {
                        toDateToggleSwitch.Value = false;
                    }
                    else
                    {
                        toDateToggleSwitch.Value = true;
                        toDatePicker.Value = Conversions.ToDate(row["To_Date"]);
                    }

                    rateFSCUpDown.Value = Conversions.ToDecimal(row["Rate"]);
                }
            }
        }

        private void BunifuRadioButton3_Click(object sender, EventArgs e)
        {
            if (sameRateRadioButton.Checked == true)
            {
                wkEndPanel.Hide();
                wkdayPanel.Dock = DockStyle.Fill;
                Label23.Text = "Weekdays and Weekends";
            }
        }

        private void diffRateRadioButton_Click(object sender, EventArgs e)
        {
            if (diffRateRadioButton.Checked)
            {
                wkdayPanel.Dock = DockStyle.Left;
                Label23.Text = "Weekdays";
                wkEndPanel.Show();
            }
        }

        private void wkDayCutoffCheckbox_OnChange(object sender, EventArgs e)
        {
            if (wkDayCutoffCheckbox.Checked == false)
            {
                wkDayCutOfftimePicker.Hide();
                if (sameRateRadioButton.Checked)
                {
                    wkEndCutOffCheckbox.Checked = false;
                    wkEndCutOffTimePicker.Hide();
                }
            }
            else
            {
                wkDayCutOfftimePicker.Show();
                wkEndCutOffTimePicker.Show();
            }
        }

        private void wkEndCutOffCheckbox_OnChange(object sender, EventArgs e)
        {
            if (wkEndCutOffCheckbox.Checked == false)
            {
                wkEndCutOffTimePicker.Hide();
            }
            else
            {
                wkEndCutOffTimePicker.Show();
            }
        }

        private void wkDayDayRateFeeday_ValueChanged(object sender, EventArgs e)
        {
            if (wkDayCutoffCheckbox.Checked == false)
            {
                wkDayNightRateUpDown.Value = wkDayDayRateFeeday.Value;
            }
        }

        private void wkEndsDayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (wkEndCutOffCheckbox.Checked == false)
            {
                wkEndNightNumericUpDown.Value = wkEndsDayNumericUpDown.Value;
            }
        }

        private void endDateCheckbox_OnChange(object sender, EventArgs e)
        {
            if (endDateCheckbox.Checked)
            {
                toRVDatePicker.Enabled = true;
            }
            else
            {
                toRVDatePicker.Enabled = false;
            }
        }

        private void toDateToggleSwitch_OnValuechange(object sender, EventArgs e)
        {
            if (toDateToggleSwitch.Value == true)
            {
                toDatePicker.Show();
            }
            else
            {
                toDatePicker.Hide();
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
        }
    }
}