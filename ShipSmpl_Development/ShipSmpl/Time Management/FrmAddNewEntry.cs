using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmAddNewEntry
    {
        public FrmAddNewEntry()
        {
            InitializeComponent();
            _newEntryclockOutTimePicker.Name = "newEntryclockOutTimePicker";
            _newEntryclockInTimePicker.Name = "newEntryclockInTimePicker";
            _clockOutCheckBox.Name = "clockOutCheckBox";
            _closeLabel.Name = "closeLabel";
            _cancelButton.Name = "cancelButton";
            _createNewEntryButton.Name = "createNewEntryButton";
            _shiftTypeComboBox.Name = "shiftTypeComboBox";
            _clockInCheckBox.Name = "clockInCheckBox";
            _reasonNewEntryComboBox.Name = "reasonNewEntryComboBox";
            _createEntyDataGrid.Name = "createEntyDataGrid";
            _findEmployee.Name = "findEmployee";
        }

        private void createNewEntryButton_Click(object sender, EventArgs e)
        {
            var employeeType = default(string);
            int selectedRow = createEntyDataGrid.CurrentRow.Index;
            if (createEntyDataGrid.SelectedRows.Count > 0)
            {
                employeeType = Conversions.ToString(createEntyDataGrid.Rows[selectedRow].Cells[4].Value);
            }

            if (string.IsNullOrEmpty(newEntrymodifiedByTextBox.Text) | reasonNewEntryComboBox.SelectedIndex == -1 | shiftTypeComboBox.SelectedIndex == -1 | siteLocationComboBox.SelectedIndex == -1)
            {
            }
            else if (createEntyDataGrid.SelectedRows.Count == 0 | clockInCheckBox.Checked == false)
            {
                MdlControllerModifier.warning("no item selected", editEntryTitleLabel);
            }
            else if (reasonNewEntryComboBox.SelectedItem.Equals("Other") & string.IsNullOrEmpty(RichTextBox1.Text))
            {
                MdlControllerModifier.warning("Edit entry", editEntryTitleLabel);
            }
            else if (employeeType.Equals("Crew") & workDoneListView.CheckedItems.Count == 0 & shiftTypeComboBox.SelectedItem.Equals("Piece Work"))
            {
                MdlControllerModifier.warning("Edit entry", editEntryTitleLabel);
            }
            else if (employeeType.Equals("Crew") & workDoneListView.CheckedItems.Count == 0 & shiftTypeComboBox.SelectedItem.Equals("Hourly") & clockOutCheckBox.Checked)
            {
                MdlControllerModifier.warning("Edit entry", editEntryTitleLabel);
            }
            else if (clockOutCheckBox.Checked & newEntryclockInTimePicker.Value > newEntryclockOutTimePicker.Value)
            {
                MdlControllerModifier.warning("Wrong time", editEntryTitleLabel);
            }
            else
            {
                MdlTimeManagement.createNewPunch(newEntryDatePicker, newEntryclockInTimePicker, newEntryclockOutTimePicker);
                editEntryTitleLabel.Text = "Success!";
                editEntryTitleLabel.Update();
                if (createEntyDataGrid.SelectedRows.Count > 0)
                {
                    if (My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView.SelectedRows.Count > 0)
                    {
                        int selectedEmployee = Conversions.ToInteger(createEntyDataGrid.Rows[selectedRow].Cells[3].Value);
                        MdlTimeManagement.populateDetails(selectedEmployee);
                    }
                    else
                    {
                        MdlTimeManagement.populateTimeSheetList();
                    }

                    Close();
                }

                My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex = My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex;
            }
        }

        private void clockInCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clockInCheckBox.Checked)
            {
                newEntryclockInTimePicker.Show();
                clockOutPanel.Show();
            }
            else
            {
                newEntryclockInTimePicker.Hide();
                clockOutPanel.Hide();
            }
        }

        private void clockOutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clockOutCheckBox.Checked)
            {
                newEntryclockOutTimePicker.Show();
                if (newEntryclockInTimePicker.Value > newEntryclockOutTimePicker.Value)
                {
                    createNewEntryButton.Enabled = false;
                    warningLabel.Text = "Clock out time need to be greater than clock in time";
                }
                else
                {
                    createNewEntryButton.Enabled = true;
                    warningLabel.Text = "";
                }
            }
            else
            {
                newEntryclockOutTimePicker.Hide();
                createNewEntryButton.Enabled = true;
                warningLabel.Text = "";
            }

            showHideWorkDone();
        }

        private void FrmAddNewEntry_Load(object sender, EventArgs e)
        {
            findEmployee.Text = "";
            editEntryTitleLabel.Text = "Select employee and entries to be created";
            newEntryDatePicker.Value = DateTime.Now;
            newEntryclockInTimePicker.Value = DateTime.Now;
            newEntryclockOutTimePicker.Value = DateTime.Now;
            newEntrymodifiedByTextBox.Text = My.MyProject.Forms.FrmLoginWindow._employeeName;
            MdlTimeManagement.populateWorks(workDoneListView);
            findEmployee.Select();
        }

        private void reasonNewEntryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reasonNewEntryComboBox.SelectedItem.Equals("Other"))
            {
                Panel1.Show();
            }
            else
            {
                Panel1.Hide();
            }
        }

        private void shiftTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showHideWorkDone();
        }

        private void showHideWorkDone()
        {
            int selectedRow;
            if (createEntyDataGrid.SelectedRows.Count > 0)
            {
                selectedRow = createEntyDataGrid.CurrentRow.Index;
                string employeeType = Conversions.ToString(createEntyDataGrid.Rows[selectedRow].Cells[4].Value);
                if (shiftTypeComboBox.SelectedIndex > -1)
                {
                    if (employeeType.Equals("Crew") & shiftTypeComboBox.SelectedItem.Equals("Piece Work"))
                    {
                        Panel2.Show();
                    }
                    else if (employeeType.Equals("Crew") & shiftTypeComboBox.SelectedItem.Equals("Hourly") & clockOutCheckBox.Checked)
                    {
                        Panel2.Show();
                    }
                    else
                    {
                        Panel2.Hide();
                    }
                }
            }
        }

        private void createEntyEmployeesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            showHideWorkDone();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!findEmployee.Text.Equals(""))
            {
                string condition = " where Alias like '%" + findEmployee.Text + "%' or First_Name Like '%" + findEmployee.Text + "%' or Last_Name Like '%" + findEmployee.Text + "%' order by alias";
                MdlTimeManagement.populateCreateEmployeeEntryList(condition);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newEntryclockOutTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (clockOutCheckBox.Checked)
            {
                if (newEntryclockInTimePicker.Value > newEntryclockOutTimePicker.Value)
                {
                    createNewEntryButton.Enabled = false;
                    warningLabel.Text = "Clock out time need to be greater than clock in time";
                }
                else
                {
                    createNewEntryButton.Enabled = true;
                    warningLabel.Text = "";
                }
            }
        }

        private void newEntryclockInTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (clockOutCheckBox.Checked)
            {
                if (newEntryclockInTimePicker.Value > newEntryclockOutTimePicker.Value)
                {
                    createNewEntryButton.Enabled = false;
                    warningLabel.Text = "Clock out time need to be greater than clock in time";
                }
                else
                {
                    createNewEntryButton.Enabled = true;
                    warningLabel.Text = "";
                }
            }
        }
    }
}