using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmCreateTransfer
    {
        public FrmCreateTransfer()
        {
            InitializeComponent();
            _dueTypeBunifuDropdown.Name = "dueTypeBunifuDropdown";
            _NumericUpDown.Name = "NumericUpDown";
            _statusComboBox.Name = "statusComboBox";
            _containersRichTextBox.Name = "containersRichTextBox";
            _checkBunifuButton1.Name = "checkBunifuButton1";
            _transferAnywaysButton.Name = "transferAnywaysButton";
            _closeLabel.Name = "closeLabel";
            _cancelButton.Name = "cancelButton";
            _createTransfeRButton.Name = "createTransfeRButton";
        }

        private DatabaseHelper db = new DatabaseHelper();
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private DataTable companies;
        private Dictionary<int, string> compIDNameDictionaty = new Dictionary<int, string>();
        private Dictionary<string, int> compIDCodeDictionaty = new Dictionary<string, int>();
        private DateTime due = DateAndTime.Now;
        private bool firstLoad = true;

        private void transferAnywaysButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow containerNumber in problemsDataGrid.Rows)
                okToTransferDataGrid.Rows.Add(containerNumber.Cells[0].Value.ToString().Replace("*", ""));
            int count = problemsDataGrid.Rows.Count - 1;
            while (count >= 0)
            {
                problemsDataGrid.Rows.RemoveAt(count);
                count = problemsDataGrid.Rows.Count - 1;
            }

            if (okToTransferDataGrid.Rows.Count > 0)
            {
                createTransfeRButton.Enabled = true;
            }
            else
            {
                createTransfeRButton.Enabled = false;
            }
        }

        private void FrmCreateTransfer_Load(object sender, EventArgs e)
        {
            string queryCondition = "where Type = 'Trucking Company' or Type = 'Terminal' order by Name";
            string queryCondition2 = "where Type = 'Terminal' order by Name";
            foreach (DataRow company in db.getTableInfoCeres("Companies", "*", queryCondition).Rows)
            {
                if (company["Type"].Equals("Trucking Company"))
                {
                    truckerComboBox.Items.Add(Operators.AddObject("(" + Strings.Trim(Conversions.ToString(company["Code"])) + ") ", company["NAME"]));
                }
                else
                {
                    fromComboBox.Items.Add(Operators.AddObject("(" + Strings.Trim(Conversions.ToString(company["Code"])) + ") ", company["NAME"]));
                    toComboBox.Items.Add(Operators.AddObject("(" + Strings.Trim(Conversions.ToString(company["Code"])) + ") ", company["NAME"]));
                }
            }

            sizeComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
            truckerComboBox.SelectedIndex = 0;
            dueTypeBunifuDropdown.SelectedIndex = 0;
            createTransfeRButton.Enabled = false;
            checkBunifuButton1.Enabled = false;
            getDue();
            firstLoad = false;
            titlewarningLabel.Text = "Create new Transfer";
            titlewarningLabel.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private DataTable sizeList = new DataTable();
        private DataTable statusList = new DataTable();
        private DataTable dueList = new DataTable();

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedItem.Equals("Loaded"))
            {
                loadedInfoTableLayoutPanel.Show();
            }
            else
            {
                loadedInfoTableLayoutPanel.Hide();
            }
        }

        private void createTransfetTouchButton_Load(object sender, EventArgs e)
        {
            string companyCode;
            string fromTerminal;
            string toTerminal;
            string typeOfTransfer;
            if (statusComboBox.SelectedItem.Equals("Empty"))
            {
                weightTextBox.Text = 0.ToString();
            }

            foreach (DataGridViewRow containerNumber in okToTransferDataGrid.Rows)
            {
                char[] c = new char[] { ')' };
                char[] d = new char[] { '(' };
                companyCode = Conversions.ToString(truckerComboBox.SelectedItem.ToString().Split(c)[0].Split(d)[1]).ToUpper();
                fromTerminal = Conversions.ToString(fromComboBox.SelectedItem.ToString().Split(c)[0].Split(d)[1]).ToUpper();
                toTerminal = Conversions.ToString(toComboBox.SelectedItem.ToString().Split(c)[0].Split(d)[1]).ToUpper();
                if (dueTypeBunifuDropdown.SelectedItem.Equals("Days"))
                {
                    due = DateAndTime.Now.AddDays((double)NumericUpDown.Value);
                }
                else if (dueTypeBunifuDropdown.SelectedItem.Equals("Weeks"))
                {
                    due = DateAndTime.Now.AddDays((double)(NumericUpDown.Value * 7m));
                }
                else if (dueTypeBunifuDropdown.SelectedItem.Equals("Months"))
                {
                    due = DateAndTime.Now.AddMonths((int)Math.Round(NumericUpDown.Value));
                }

                if ((fromTerminal.Equals("LINDSEY") | fromTerminal.Equals("EWEN")) & (toTerminal.Equals("LINDSEY") | toTerminal.Equals("EWEN")))
                {
                    typeOfTransfer = "INTERNAL";
                }
                else if (!(fromTerminal.Equals("LINDSEY") | fromTerminal.Equals("EWEN")) & (toTerminal.Equals("LINDSEY") | toTerminal.Equals("EWEN")))
                {
                    typeOfTransfer = "INBOUND";
                }
                else if ((fromTerminal.Equals("LINDSEY") | fromTerminal.Equals("EWEN")) & !(toTerminal.Equals("LINDSEY") | toTerminal.Equals("EWEN")))
                {
                    typeOfTransfer = "OUTBOUND";
                }
                else
                {
                    typeOfTransfer = "EXTERNAL";
                }

                try
                {
                    var dateOfCreation = DateAndTime.Now;
                    db.saveAlowedTransfer(My.MyProject.Forms.FrmLoginWindow._userID, Conversions.ToString(containerNumber.Cells[0].Value), companyCode, Conversions.ToString(sizeComboBox.SelectedItem.ToString().Replace("'", "")), Conversions.ToString(statusComboBox.SelectedItem), weightTextBox.Text, fromTerminal, toTerminal, due.Date, typeOfTransfer, dateOfCreation);
                    string condition = "where [Date of Creation] = '" + Conversions.ToString(dateOfCreation) + "' order by ID DESC";
                    string message = "New " + typeOfTransfer + " transfer has been created";

                    // dbCeresLogs.saveAlowedTransfer(FrmLoginWindow._userID, containerNumber.Cells(0).Value, companyCode,
                    // sizeComboBox.SelectedItem.Replace("'", ""), statusComboBox.SelectedItem,
                    // weightTextBox.Text, fromTerminal, toTerminal, due.Date, typeOfTransfer, dateOfCreation)

                    int recordID = Conversions.ToInteger(dbCeres.getTableInfo("[Allowed Transfers]", "ID", condition).Rows[0]["ID"]);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, recordID.ToString(), "CREATE", "TRANSFER", message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject("There was an error saving transfer of Container #: ", containerNumber.Cells[0].Value), ". Error: "), ex.Message)));
                }
            }

            titlewarningLabel.Text = "The containers were added to the allowed transfer list successfuly!";
            titlewarningLabel.ForeColor = Color.Green;
            cleanDataGrids();
            explanationTableLayoutPanel.Hide();
        }

        private void cleanDataGrids()
        {
            int count = okToTransferDataGrid.Rows.Count - 1;
            while (count >= 0)
            {
                okToTransferDataGrid.Rows.RemoveAt(count);
                count = okToTransferDataGrid.Rows.Count - 1;
            }

            count = problemsDataGrid.Rows.Count - 1;
            while (count >= 0)
            {
                problemsDataGrid.Rows.RemoveAt(count);
                count = problemsDataGrid.Rows.Count - 1;
            }

            if (okToTransferDataGrid.Rows.Count > 0)
            {
                createTransfeRButton.Enabled = true;
            }
            else
            {
                createTransfeRButton.Enabled = false;
            }
        }

        // Private Sub transfersBunifuDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        // transfersBunifuDataGridView.Rows(0).DefaultCellStyle.BackColor = Color.Teal
        // With transfersBunifuDataGridView.Rows(0).DefaultCellStyle
        // .BackColor = Color.Teal
        // .ForeColor = Color.White
        // .SelectionBackColor = Color.Gray
        // .SelectionForeColor = Color.White

        // End With

        // End Sub

        // Private Sub transfersBunifuDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)

        // If e.RowIndex = 0 Then

        // For i = 0 To transfersBunifuDataGridView.Rows.Count - 1
        // If transfersBunifuDataGridView.Rows(i).Cells(1).Value = True Then
        // transfersBunifuDataGridView.Rows(i).Cells(e.ColumnIndex).Value = transfersBunifuDataGridView.Rows(0).Cells(e.ColumnIndex).Value
        // End If
        // Next
        // End If
        // End Sub

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void assignBunifuButton1_Click(object sender, EventArgs e)
        {
            cleanDataGrids();
            MdlContainerManagement.checkContainersAdded();
        }

        private void containersRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Strings.Trim(containersRichTextBox.Text).Length > 4)
            {
                checkBunifuButton1.Enabled = true;
            }
            else
            {
                checkBunifuButton1.Enabled = false;
            }

            if (okToTransferDataGrid.Rows.Count > 0)
            {
                createTransfeRButton.Enabled = true;
            }
            else
            {
                createTransfeRButton.Enabled = false;
            }
        }

        private void dueTypeBunifuDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                getDue();
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                getDue();
            }
        }

        private void getDue()
        {
            if (dueTypeBunifuDropdown.SelectedItem.Equals("Days"))
            {
                due = DateAndTime.Now.AddDays((double)NumericUpDown.Value);
            }
            else if (dueTypeBunifuDropdown.SelectedItem.Equals("Weeks"))
            {
                due = DateAndTime.Now.AddDays((double)(NumericUpDown.Value * 7m));
            }
            else if (dueTypeBunifuDropdown.SelectedItem.Equals("Months"))
            {
                due = DateAndTime.Now.AddMonths((int)Math.Round(NumericUpDown.Value));
            }

            dueLabel.Text = "Deadline: " + due.ToString("dd-MMM-yyyy");
        }
    }
}