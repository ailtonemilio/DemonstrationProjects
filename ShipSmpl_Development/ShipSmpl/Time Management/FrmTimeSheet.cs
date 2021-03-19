// Imports Microsoft.Office.Interop.Excel
using Bunifu.UI.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmTimeSheet
    {
        public FrmTimeSheet()
        {
            InitializeComponent();
            _printButton.Name = "printButton";
            _exportCSVButton.Name = "exportCSVButton";
            _searchBunifuTextBox1.Name = "searchBunifuTextBox1";
            _detailsBunifuDataGridView.Name = "detailsBunifuDataGridView";
            _selectAllCheckBox.Name = "selectAllCheckBox";
            _summaryBunifuDataGridView.Name = "summaryBunifuDataGridView";
            _holidaysButton.Name = "holidaysButton";
            _editEntryButton.Name = "editEntryButton";
            _deleteEntryButton.Name = "deleteEntryButton";
            _addEntryButton.Name = "addEntryButton";
            _endPeriodComboBox.Name = "endPeriodComboBox";
            _monthComboBox.Name = "monthComboBox";
            _payMethodComboBox.Name = "payMethodComboBox";
            _yearComboBox.Name = "yearComboBox";
        }

        private object firstLoad = true;

        public int _selectedEntryIndex { get; set; } = -1;

        private DatabaseHelper db = new DatabaseHelper();

        private void FrmTimeManagement_Load(object sender, EventArgs e)
        {
            summaryBunifuDataGridView.InitializeLifetimeService();
            MdlOptionsManagement.getTimeManagementAllowedFunctionalities();
            payMethodComboBox.SelectedIndex = 0;
            MdlTimeManagement.populateMonthDropDown();
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MdlTimeManagement.populateEndPeriod();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool completeTimeSheet = true;
            if (summaryBunifuDataGridView.SelectedRows.Count > 0)
            {
                if (completeTimeSheet == true)
                {
                    MdlControllerModifier.clearFields();
                    MdlTimeManagement.exportCSV();
                }
                else
                {
                    MdlControllerModifier.warning("timesheet not complete", titleTimeManagementLabel);
                }
            }
            else
            {
                MdlControllerModifier.warning("nothing selected", titleTimeManagementLabel);
            }
        }

        private void endPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MdlControllerModifier.deactivateButtons(detailedEntryButton, editEntryButton, editEntryButton, deleteEntryButton)
            // payMethodComboBox.SelectedIndex = 0
            MdlTimeManagement.populateTimeSheetList();
            firstLoad = false;
        }

        private void editEntryButton_Click(object sender, EventArgs e)
        {
            MdlTimeManagement.fillModifyEntryFields();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditEntry, this);
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            MdlTimeManagement.populateCreateEmployeeEntryList("order by Alias");
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddNewEntry, this);
        }

        private bool indexChanged = false;
        private bool issearch = false;

        private void summaryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MdlControllerModifier.deactivateButtons(detailedEntryButton, editEntryButton, editEntryButton, deleteEntryButton)

            // '      clearDataGrid(detailsBunifuDataGridView)
            detailsBunifuDataGridView.Rows.Clear();
            if (issearch == false)
            {
                if (summaryBunifuDataGridView.SelectedRows.Count > 0)
                {
                    int selectedRow = summaryBunifuDataGridView.CurrentCell.RowIndex;
                    string aliastName = Conversions.ToString(summaryBunifuDataGridView.Rows[selectedRow].Cells[1].Value);
                    string lastName = Conversions.ToString(summaryBunifuDataGridView.Rows[selectedRow].Cells[2].Value);
                    int employeeID = Conversions.ToInteger(summaryBunifuDataGridView.Rows[selectedRow].Cells[6].Value);
                    detailsLabel.Text = "Details - " + aliastName + " " + lastName;
                    detailsLabel.Update();
                    MdlTimeManagement.populateDetails(employeeID);
                    indexChanged = true;
                }
            }
            else
            {
                issearch = false;
            }
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            int selectedItemD = detailsBunifuDataGridView.CurrentCell.RowIndex;
            int selectedItemS = summaryBunifuDataGridView.CurrentCell.RowIndex;
            int employeeID = Conversions.ToInteger(summaryBunifuDataGridView.Rows[selectedItemS].Cells[6].Value);
            // Dim selectedEmployee As Integer = Convert.ToUInt32(summaryListView.FocusedItem.Index.ToString)
            int _punchID = Convert.ToInt32(detailsBunifuDataGridView.Rows[selectedItemD].Cells[6].Value);
            var result = MessageBox.Show("Are you sure you want to delete this entry? This can not be undone", "Delete Entry", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.deleteEntry(_punchID);
                MdlTimeManagement.populateDetails(employeeID);
                if (detailsBunifuDataGridView.Rows.Count == 0)
                {
                    MdlTimeManagement.populateTimeSheetList();
                }
                // MdlControllerModifier.deactivateButtons(detailedEntryButton, editEntryButton, editEntryButton, deleteEntryButton)
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void showAllEmployeesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MdlTimeManagement.populateTimeSheetList();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void payMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(firstLoad, false, false)))
            {
                MdlTimeManagement.populateTimeSheetList();
            }
        }

        private bool summaryIsPrinted = false;
        private int listViewIndex = 0;
        public int punchID;

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (summaryIsPrinted == false)
            {
                HH = 80;
                e.Graphics.DrawString(Conversions.ToString(Operators.AddObject("Summary time sheet for period ending ", endPeriodComboBox.SelectedItem)), new Font("Times New Roman", 16f), Brushes.Black, 150f, HH);
                HH += 50;
                e.Graphics.DrawString("Name", new Font("Times New Roman", 14f), Brushes.Black, 80f, HH);
                e.Graphics.DrawString("Total Hours", new Font("Times New Roman", 14f), Brushes.Black, 500f, HH);
                LineNumber += 4;
                HH += 30;
                for (int i = I_Start, loopTo = summaryBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
                {

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(summaryBunifuDataGridView.Rows[i].Cells[0].Value, true, false)))
                    {
                        decimal hours = Convert.ToInt32(summaryBunifuDataGridView.Rows[i].Cells[4].Value.ToString().Split(':')[0]);
                        decimal minutes = Convert.ToInt32(summaryBunifuDataGridView.Rows[i].Cells[4].Value.ToString().Split(':')[1]);
                        decimal r = hours + minutes / 60m;
                        decimal result = decimal.Round(r, 2, MidpointRounding.AwayFromZero);

                        // e.Graphics.DrawRectangle(New Pen(Color.Black), New System.Drawing.Rectangle(0, HH - 30, 100, 35))
                        e.Graphics.DrawString(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(summaryBunifuDataGridView.Rows[i].Cells[3].Value, " "), summaryBunifuDataGridView.Rows[i].Cells[2].Value), " ("), summaryBunifuDataGridView.Rows[i].Cells[1].Value), ")")), new Font("Times New Roman", 12f), Brushes.Black, 80f, HH);
                        e.Graphics.DrawString(result.ToString(), new Font("Times New Roman", 12f), Brushes.Black, 505f, HH);
                        e.Graphics.DrawString(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject("(", summaryBunifuDataGridView.Rows[i].Cells[4].Value.ToString().Replace(":", "hrs ")), "min"), ")")), new Font("Times New Roman", 12f), Brushes.Black, 560f, HH);
                        HH += 25;
                        LineNumber += 1;
                    }

                    I_Start += 1;
                    if (HH > 1050)
                    {
                        e.HasMorePages = true;
                        summaryIsPrinted = false;
                        HH = 0;
                        // summaryListView.Items(I_Start).Checked = True
                        summaryBunifuDataGridView.Rows[I_Start].Cells[0].Value = true;
                        // I_Start_Items += 1
                        break;
                    }
                    else
                    {
                    }

                    if (I_Start == summaryBunifuDataGridView.Rows.Count)
                    {
                        e.HasMorePages = true;
                        summaryIsPrinted = true;
                        I_Start_Items = 0;
                        break;
                    }
                }
            }
            else
            {
                HH = 50;
                bool goToNextPage = false;
                decimal h = 0m;
                decimal m = 0m;
                for (int j = I_Start_Items, loopTo1 = summaryBunifuDataGridView.Rows.Count - 1; j <= loopTo1; j++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[0].Value, true, false)))
                    {
                        MdlTimeManagement.populateDetails(Conversions.ToInteger(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[6].Value));
                        HH += 30;
                        e.Graphics.DrawString(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[3].Value, " "), summaryBunifuDataGridView.Rows[I_Start_Items].Cells[2].Value), " ("), summaryBunifuDataGridView.Rows[I_Start_Items].Cells[1].Value), ")")), new Font("Times New Roman", 12f), Brushes.Black, 80f, HH);
                        HH += 30;
                        e.Graphics.DrawString(Conversions.ToString(Operators.AddObject("Time Sheet for period ending ", endPeriodComboBox.SelectedItem)), new Font("Times New Roman", 16f), Brushes.Black, 200f, HH);
                        HH += 40;
                        e.Graphics.DrawString("Date", new Font("Times New Roman", 12.5f), Brushes.Black, 80f, HH);
                        e.Graphics.DrawString("Start Time", new Font("Times New Roman", 12.5f), Brushes.Black, 190f, HH);
                        e.Graphics.DrawString("End Time", new Font("Times New Roman", 12.5f), Brushes.Black, 290f, HH);
                        e.Graphics.DrawString("Pay Method", new Font("Times New Roman", 12.5f), Brushes.Black, 380f, HH);
                        e.Graphics.DrawString("Job Description", new Font("Times New Roman", 12.5f), Brushes.Black, 490f, HH);
                        e.Graphics.DrawString("Hours Worked", new Font("Times New Roman", 12.5f), Brushes.Black, 635f, HH);
                        var detailsListView = MdlTimeManagement.detailedEntires;
                        HH += 30;
                        for (int i = listViewIndex, loopTo2 = detailsListView.Items.Count - 1; i <= loopTo2; i++)
                        {
                            decimal hours;
                            decimal minutes;
                            object r;
                            object result;
                            if (!detailsListView.Items[i].SubItems[3].Text.Equals(""))
                            {
                                hours = Convert.ToInt32(detailsListView.Items[i].SubItems[3].Text.Split(':')[0]);
                                minutes = Convert.ToInt32(detailsListView.Items[i].SubItems[3].Text.Split(':')[1]);
                                r = hours + minutes / 60m;
                                result = decimal.Round(Conversions.ToDecimal(r), 2, MidpointRounding.AwayFromZero);
                            }

                            // date
                            e.Graphics.DrawString(detailsListView.Items[i].SubItems[0].Text, new Font("Times New Roman", 12f), Brushes.Black, 80f, HH);
                            // clock in
                            e.Graphics.DrawString(detailsListView.Items[i].SubItems[1].Text, new Font("Times New Roman", 12f), Brushes.Black, 195f, HH);
                            // clock out
                            e.Graphics.DrawString(detailsListView.Items[i].SubItems[2].Text, new Font("Times New Roman", 12f), Brushes.Black, 295f, HH);
                            // 
                            e.Graphics.DrawString(detailsListView.Items[i].SubItems[5].Text, new Font("Times New Roman", 12f), Brushes.Black, 385f, HH);
                            detailsListView.Items[i].Focused = true;
                            foreach (DataRow entry in db.getSelectedEntry(Convert.ToInt32(detailsListView.Items[i].SubItems[4].Text)).Rows)
                            {
                                punchID = Conversions.ToInteger(detailsListView.Items[i].SubItems[4].Text);
                                MdlTimeManagement.getWorkDone(punchID, Conversions.ToString(entry["Type"]), Conversions.ToString(entry["Punch_Type"]), Conversions.ToString(entry["Job_Description"]));
                            }

                            string check = MdlTimeManagement.workDone;
                            e.Graphics.DrawString(MdlTimeManagement.workDone, new Font("Times New Roman", 8.5f), Brushes.Black, 495f, HH);
                            if (!detailsListView.Items[i].SubItems[3].Text.Equals(""))
                            {
                                e.Graphics.DrawString(detailsListView.Items[i].SubItems[3].Text.Replace(":", "hrs ") + "min", new Font("Times New Roman", 12f), Brushes.Black, 640f, HH);
                            }
                            else
                            {
                                e.Graphics.DrawString("N/A", new Font("Times New Roman", 12f), Brushes.Black, 640f, HH);
                            }

                            // e.Graphics.DrawString("(" + result.ToString + ")",
                            // New System.Drawing.Font("Times New Roman", 12), Brushes.Black, 680, HH)

                            HH += 70;
                            listViewIndex += 1;
                            if (HH > 1050)
                            {
                                break;
                            }
                        }

                        if (HH > 1050)
                        {
                            e.HasMorePages = true;
                            summaryIsPrinted = true;
                            HH = 0;
                            summaryBunifuDataGridView.Rows[I_Start_Items].Cells[0].Value = true;
                            // I_Start_Items += 1
                            break;
                        }
                        else
                        {
                            decimal hour = Convert.ToInt32(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[4].Value.ToString().Split(':')[0]);
                            decimal minute = Convert.ToInt32(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[4].Value.ToString().Split(':')[1]);
                            decimal rs = hour + minute / 60m;
                            decimal resulTotal = decimal.Round(rs, 2, MidpointRounding.AwayFromZero);
                            e.Graphics.DrawString("Total Hours:", new Font("Times New Roman", 12f), Brushes.Black, 510f, HH);
                            e.Graphics.DrawString(Conversions.ToString(Operators.AddObject(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[4].Value.ToString().Replace(":", "hrs "), "min")), new Font("Times New Roman", 12f), Brushes.Black, 640f, HH);
                            HH += 40;
                            goToNextPage = true;
                        }
                    }

                    I_Start_Items += 1;
                    listViewIndex = 0;
                    if (goToNextPage == true)
                    {
                        if (I_Start_Items < summaryBunifuDataGridView.Rows.Count)
                        {
                            e.HasMorePages = true;
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(summaryBunifuDataGridView.Rows[I_Start_Items].Cells[0].Value, true, false)))
                            {
                                e.HasMorePages = true;
                            }
                        }

                        summaryIsPrinted = true;
                        HH = 0;
                        // summaryListView.Items(I_Start_Items).Checked = True
                        break;
                    }
                }
            }
        }

        private int HH;
        private int LineNumber;
        private int LinePerPage;
        private int I_Start;
        private int I_Start_Items;
        private object I_Counter;

        private void printButton_Click(object sender, EventArgs e)
        {
            titleTimeManagementLabel.Text = "";
            I_Start_Items = 0;
            I_Start = 0;
            bool employeeIsSelected = false;
            summaryIsPrinted = false;
            for (int i = 0, loopTo = summaryBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(summaryBunifuDataGridView.Rows[i].Cells[0].Value, true, false)))
                {
                    employeeIsSelected = true;
                    break;
                }
            }

            if (employeeIsSelected)
            {
                // If completeTimeSheet = True Then

                PrintDialog1.Document = PrintDocument1;
                if (PrintDialog1.ShowDialog() == DialogResult.OK)
                {
                    PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
                    LineNumber = 0;
                    var New_Paper = new PaperSize("", 850, 1100);
                    New_Paper.PaperName = ((int)PaperKind.Custom).ToString();
                    var New_Margin = new Margins();
                    New_Margin.Left = 0;
                    New_Margin.Top = 50;
                    {
                        var withBlock = PrintDocument1;
                        withBlock.DefaultPageSettings.PaperSize = New_Paper;
                        withBlock.DefaultPageSettings.Margins = New_Margin;
                        // .PrinterSettings.DefaultPageSettings.Landscape = False
                        withBlock.Print();
                    }
                }
            }
            else
            {
                MdlControllerModifier.warning("nothing selected", titleTimeManagementLabel);
            }
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmHolidays.Show();
        }

        private bool IndexClicked = false;

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(firstLoad, false, false)))
            {
                MdlTimeManagement.populateEndPeriod();
            }
        }

        private void BunifuDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // to add complete/in progress images to datagridview

            int iHeight = summaryBunifuDataGridView.Rows[e.RowIndex].Height - 5;
            int iWidth = summaryBunifuDataGridView.Rows[e.RowIndex].Height - 5;
            var ico = My.Resources.Resources.workingInProgress2;
            var ico2 = My.Resources.Resources.workingComplete2;
            var Graphics = e.Graphics;
            int xPosition = summaryBunifuDataGridView.Width - 60;
            int yPosition = e.RowBounds.Y + (summaryBunifuDataGridView.Rows[e.RowIndex].Height - iHeight);
            var rectangle = new Rectangle(xPosition, yPosition, iWidth, iHeight);
            if (summaryBunifuDataGridView.Rows[e.RowIndex].Cells[5].Value.Equals("working"))
            {
                Graphics.DrawIcon(ico, rectangle);
            }
            else
            {
                Graphics.DrawIcon(ico2, rectangle);
            }
        }

        private void detailsBunifuDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // to add complete/in progress images to datagridview

            int iHeight = detailsBunifuDataGridView.Rows[e.RowIndex].Height - 5;
            int iWidth = detailsBunifuDataGridView.Rows[e.RowIndex].Height - 5;
            var ico = My.Resources.Resources.editedPencil;
            var Graphics = e.Graphics;
            int xPosition = detailsBunifuDataGridView.Width - 60;
            int yPosition = e.RowBounds.Y + (detailsBunifuDataGridView.Rows[e.RowIndex].Height - iHeight);
            var rectangle = new Rectangle(xPosition, yPosition, iWidth, iHeight);
            if (detailsBunifuDataGridView.Rows[e.RowIndex].Cells[5].Value.Equals("modified"))
            {
                Graphics.DrawIcon(ico, rectangle);
            }
        }

        private void summaryBunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(summaryBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    summaryBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    summaryBunifuDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }
        }

        private void BunifuCheckBox1_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                for (int i = 0, loopTo = summaryBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
                    summaryBunifuDataGridView.Rows[i].Cells[0].Value = true;
                selectAllCheckBox.BackColor = Color.Teal;
            }
            else
            {
                for (int i = 0, loopTo1 = summaryBunifuDataGridView.Rows.Count - 1; i <= loopTo1; i++)
                {
                    summaryBunifuDataGridView.Rows[i].Cells[0].Value = false;
                    selectAllCheckBox.BackColor = Color.FromArgb(64, 64, 0);
                }
            }
        }

        private void detailsBunifuDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (MdlOptionsManagement.canSeeEntryDetail)
            {
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmDetailedEntry, this);
            }
            else
            {
                My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = "You are not allowed to see entry details";
                My.MyProject.Forms.FrmdeleteWarning.confirmationPanel.Hide();
                My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Visible = false;
                My.MyProject.Forms.FrmdeleteWarning.Show();
            }
        }

        private void findText()
        {
            for (int i = 0, loopTo = summaryBunifuDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (summaryBunifuDataGridView.Rows[i].Cells[1].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper()) || summaryBunifuDataGridView.Rows[i].Cells[2].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper()))
                {
                    // cell.Style.BackColor = Color.Yellow
                    // summaryBunifuDataGridView.Rows(i).Selected = True
                    issearch = true;
                    summaryBunifuDataGridView.CurrentCell = summaryBunifuDataGridView.Rows[i].Cells[1];
                    int selectedRow = summaryBunifuDataGridView.CurrentCell.RowIndex;
                    string aliastName = Conversions.ToString(summaryBunifuDataGridView.Rows[selectedRow].Cells[1].Value);
                    string lastName = Conversions.ToString(summaryBunifuDataGridView.Rows[selectedRow].Cells[2].Value);
                    int employeeID = Conversions.ToInteger(summaryBunifuDataGridView.Rows[selectedRow].Cells[6].Value);
                    MdlTimeManagement.populateDetails(employeeID);
                    detailsLabel.Text = "Details - " + aliastName + " " + lastName;
                    return;
                }
            }

            detailsLabel.Update();
        }

        private void searchBunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            findText();
        }
    }
}