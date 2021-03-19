using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmTimeReport
    {
        public FrmTimeReport()
        {
            InitializeComponent();
            _comparisonTypeComboBox.Name = "comparisonTypeComboBox";
            _printButton.Name = "printButton";
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void FrmTimeReport_Load(object sender, EventArgs e)
        {
            foreach (DataRow employee in db.getAllActiveEmployees1().Rows)

                // ' compareToListView.Items.Add(New ListViewItem({employee("Alias") + " " + employee("Last_Name"), employee("ID")}))
                reportFromListView.Items.Add(new ListViewItem(new[] { Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"])), Conversions.ToString(employee["ID"]) }));
            comparisonTypeComboBox.SelectedIndex = 1;
            typeReportComboBox.SelectedIndex = 0;
            yardComboBox.SelectedIndex = 0;
        }

        private void comparisonTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comparisonTypeComboBox.SelectedItem.Equals("COMPARE TO ANOTHER EMPLOYEE"))
            {
                PanelCheckList.Hide();
            }
            else if (comparisonTypeComboBox.SelectedItem.Equals("COMPARE TO ALL EMPLOYEES"))
            {
                PanelCheckList.Show();
            }
        }

        private int HH;
        private int LineNumber;
        private int pageNumber;
        private int INDEX_ALL_DAYS;
        private int INDEX_FOCUSED_EMPLOYEE;
        private int INDEX_EMPLOYEES_COMPARED_CHECK_OVERTIME;
        private int INDEX_EMPLOYEES_COMPARED;
        private int I_Start_Items;
        private object I_Counter;
        private bool nextPageExists = false;

        private void printButton_Click(object sender, EventArgs e)
        {
            INDEX_ALL_DAYS = 0;
            INDEX_FOCUSED_EMPLOYEE = 0;
            INDEX_EMPLOYEES_COMPARED = 0;
            INDEX_EMPLOYEES_COMPARED_CHECK_OVERTIME = 0;
            pageNumber = 1;
            checkedWork = "";
            nextPageExists = false;
            if (reportFromListView.SelectedItems.Count > 0 & CheckedListBox1.CheckedItems.Count > 0 & comparisonTypeComboBox.SelectedIndex == 1)
            {
                titleLabel.Text = "Hours worked comparison report";
                titleLabel.BackColor = Color.FromArgb(64, 64, 0);
                var loopTo = CheckedListBox1.Items.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    string Item = (string)CheckedListBox1.Items[i];
                    if (CheckedListBox1.GetItemChecked(i))
                    {
                        Item = Strings.Trim(Conversions.ToString(Item.Split('(')[0]));
                        checkedWork += Item.ToString().Replace(" ", "_") + "='yes' or ";
                    }
                }

                checkedWork = checkedWork.Substring(0, checkedWork.Length - 3);
                int selectedIndex = reportFromListView.FocusedItem.Index;
                string condition = Conversions.ToString(Operators.AddObject(Operators.AddObject(" and Site_Location = '", yardComboBox.SelectedItem), "'"));
                if (yardComboBox.SelectedItem.Equals("Both"))
                {
                    condition = "";
                }

                employeesWorkingThatDay = (DataTable)db.getReport(Conversions.ToInteger(reportFromListView.Items[selectedIndex].SubItems[1].Text), 2, checkedWork, condition);
                datesWorkedByFocusedEmployee = (DataTable)db.getReport(Conversions.ToInteger(reportFromListView.Items[selectedIndex].SubItems[1].Text), 1, checkedWork, "");
                datesWorkedTable = (DataTable)db.getReport(Conversions.ToInteger(reportFromListView.Items[selectedIndex].SubItems[1].Text), 3, checkedWork, condition);
                if (comparisonTypeComboBox.SelectedIndex == 1 & CheckedListBox1.CheckedItems.Count > 0)
                {
                    PrintDialog1.Document = PrintDocument1;
                    if (PrintDialog1.ShowDialog() == DialogResult.OK)
                    {
                        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
                        LineNumber = 0;
                        var New_Paper = new PaperSize("", 850, 1100);
                        New_Paper.PaperName = ((int)PaperKind.Custom).ToString();
                        var New_Margin = new Margins();
                        New_Margin.Left = 20;
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
                }
            }
            else
            {
                MdlControllerModifier.warning("nothing selected report", titleLabel);
            }
        }

        private string checkedWork = "";
        private int i = 0;
        private DataTable employeesWorkingThatDay = new DataTable();
        private DataTable datesWorkedByFocusedEmployee = new DataTable();
        private DataTable datesWorkedTable = new DataTable();
        private DateTime startTime;
        private DateTime dWorked;
        private DateTime endTime;
        private DateTime startTimeCompared;
        private DateTime endTimeCompared;
        private TimeSpan hoursWorkCompared;
        private TimeSpan hoursDiff;
        private TimeSpan hoursWork;
        private TimeSpan earliestTimeFocusedEmployee = new TimeSpan(0, 0, 0);
        private TimeSpan latestTimeFocusedEmployee = new TimeSpan(0, 0, 0);
        private TimeSpan hoursOverBefore = new TimeSpan(0, 0, 0);
        private TimeSpan totalHoursOver = new TimeSpan(0, 0, 0);
        private TimeSpan hoursOverAfter = new TimeSpan(0, 0, 0);
        private TimeSpan hoursBeforeFocusedEmployee = new TimeSpan(0, 0, 0);
        private TimeSpan hoursAfterFocusedEmployee = new TimeSpan(0, 0, 0);

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            HH = 80;
            int selectedIndex = reportFromListView.FocusedItem.Index;
            bool headerEmployeePrinted = false;
            e.Graphics.DrawString("HOURS WORKED COMPARISON REPORT - " + reportFromListView.Items[selectedIndex].SubItems[0].Text, new Font("Times New Roman", 14f), Brushes.Black, 160f, HH);
            while (pageNumber > 0)
            {
                var loopTo = datesWorkedTable.Rows.Count - 1;
                for (i = INDEX_ALL_DAYS; i <= loopTo; i++)
                {
                    hoursOverBefore = new TimeSpan(0, 0, 0, 0);
                    dWorked = Conversions.ToDate(datesWorkedTable.Rows[INDEX_ALL_DAYS]["startTime"]);
                    INDEX_ALL_DAYS += 1;

                    // ********* check if overtime exists *************
                    bool overTimeExists = false;
                    foreach (DataRow item in datesWorkedByFocusedEmployee.Rows)
                    {
                        DateTime dateItem = Conversions.ToDate(item["startTime"]);
                        if (dWorked.Date == dateItem.Date)
                        {
                            startTime = Conversions.ToDate(item["startTime"]);
                            if (!Information.IsDBNull(item["endTime"]))
                            {
                                endTime = Conversions.ToDate(item["endTime"]);
                            }
                            else
                            {
                                endTime = DateAndTime.Now;
                            }

                            headerEmployeePrinted = true;
                            // Exit For
                            int selectedInde = reportFromListView.FocusedItem.Index;
                            if (earliestTimeFocusedEmployee != new TimeSpan(0, startTime.Hour, startTime.Minute, 0, 0))
                            {
                                if (earliestTimeFocusedEmployee.TotalMinutes == 0d)
                                {
                                    earliestTimeFocusedEmployee = new TimeSpan(0, startTime.Hour, startTime.Minute, 0, 0);
                                }

                                if (earliestTimeFocusedEmployee > new TimeSpan(0, startTime.Hour, startTime.Minute, 0, 0))
                                {
                                    earliestTimeFocusedEmployee = new TimeSpan(0, startTime.Hour, startTime.Minute, 0, 0);
                                }
                            }

                            if (latestTimeFocusedEmployee != new TimeSpan(0, endTime.Hour, endTime.Minute, 0, 0))
                            {
                                if (latestTimeFocusedEmployee.TotalMinutes == 0d)
                                {
                                    latestTimeFocusedEmployee = new TimeSpan(0, endTime.Hour, endTime.Minute, 0, 0);
                                }

                                if (latestTimeFocusedEmployee < new TimeSpan(0, endTime.Hour, endTime.Minute, 0, 0))
                                {
                                    latestTimeFocusedEmployee = new TimeSpan(0, endTime.Hour, endTime.Minute, 0, 0);
                                }
                            }

                            startTime = Convert.ToDateTime(dWorked.ToShortDateString() + " " + earliestTimeFocusedEmployee.Hours.ToString() + ":" + earliestTimeFocusedEmployee.Minutes.ToString() + ":00");
                            endTime = Convert.ToDateTime(dWorked.ToShortDateString() + " " + latestTimeFocusedEmployee.Hours.ToString() + ":" + latestTimeFocusedEmployee.Minutes.ToString());
                        }
                    }

                    if (headerEmployeePrinted == false)
                    {
                        startTime = Convert.ToDateTime(dWorked.Date);
                        endTime = Convert.ToDateTime(dWorked.Date);
                    }

                    foreach (DataRow infoCompared in employeesWorkingThatDay.Rows)
                    {

                        // Dim infoCompared = employeesWorkingThatDay.Rows(INDEX_EMPLOYEES_COMPARED_CHECK_OVERTIME)

                        startTimeCompared = Conversions.ToDate(infoCompared["startTime"]);
                        endTimeCompared = Conversions.ToDate(infoCompared["endTime"]);
                        if (startTimeCompared.Date == dWorked.Date)
                        {
                            hoursWorkCompared = endTimeCompared - startTimeCompared;
                            hoursWork = endTime - startTime;
                            hoursDiff = hoursWorkCompared - hoursWork;
                            if (startTimeCompared < startTime | endTimeCompared > endTime)
                            {
                                overTimeExists = true;
                                break;
                            }
                        }
                        // INDEX_EMPLOYEES_COMPARED_CHECK_OVERTIME += 1
                    }

                    headerEmployeePrinted = false;
                    earliestTimeFocusedEmployee = new TimeSpan(0, 0, 0);
                    latestTimeFocusedEmployee = new TimeSpan(0, 0, 0);
                    // '********************************************************

                    // print header if overtime exists
                    if (overTimeExists == true)
                    {
                        if (HH < 900)
                        {
                            HH += 35;
                            e.Graphics.DrawString(dWorked.Date.ToString("MMM dd, yyyy") + " (" + dWorked.DayOfWeek.ToString() + ")", new Font("Times New Roman", 14f), Brushes.Black, 100f, HH);
                            HH += 25;

                            // If
                            // rec for name
                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(100, HH, 220, 25));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(100, HH, 220, 25));
                            e.Graphics.DrawString("Name", new Font("Times New Roman", 12f), Brushes.Black, 100f, HH);

                            // rec for start
                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(320, HH, 80, 25));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(320, HH, 80, 25));
                            e.Graphics.DrawString("Start", new Font("Times New Roman", 12f), Brushes.Black, 320f, HH);

                            // rect for end
                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(400, HH, 80, 25));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(400, HH, 80, 25));
                            e.Graphics.DrawString("End", new Font("Times New Roman", 12f), Brushes.Black, 400f, HH);

                            // rec hor hours worked
                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(480, HH, 120, 25));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(480, HH, 120, 25));
                            e.Graphics.DrawString("Hours Worked", new Font("Times New Roman", 12f), Brushes.Black, 480f, HH);

                            // rec for hours diff
                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(600, HH, 160, 25));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(600, HH, 160, 25));
                            e.Graphics.DrawString("Extra Hours(Start/End)", new Font("Times New Roman", 12f), Brushes.Black, 600f, HH);
                            HH += 25;
                            bool missedWork = false;
                            // loop through days worked and only print info from dWorked
                            var totalHWorkedByFocusedEmployee = new TimeSpan(0, 0, 0, 0);
                            for (int r = 0, loopTo1 = datesWorkedByFocusedEmployee.Rows.Count - 1; r <= loopTo1; r++)
                            {
                                var item = datesWorkedByFocusedEmployee.Rows[r];
                                DateTime dateItem = Conversions.ToDate(item["startTime"]);
                                if (dWorked.Date == dateItem.Date)
                                {
                                    startTime = Conversions.ToDate(item["startTime"]);
                                    if (!Information.IsDBNull(item["endTime"]))
                                    {
                                        endTime = Conversions.ToDate(item["endTime"]);
                                    }
                                    else
                                    {
                                        endTime = DateAndTime.Now;
                                    }

                                    e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(100, HH, 220, 20));
                                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(100, HH, 220, 20));
                                    e.Graphics.DrawString(Conversions.ToString(Operators.AddObject(Operators.AddObject(item["alias"], " "), item["last_name"])), new Font("Times New Roman", 12f), Brushes.Black, 100f, HH);

                                    // rect for start
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(320, HH, 80, 20));
                                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(320, HH, 80, 20));
                                    e.Graphics.DrawString(startTime.ToString("HH:mm"), new Font("Times New Roman", 12f), Brushes.Black, 320f, HH);

                                    // rect for end
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(400, HH, 80, 20));
                                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(400, HH, 80, 20));
                                    e.Graphics.DrawString(endTime.ToString("HH:mm"), new Font("Times New Roman", 12f), Brushes.Black, 400f, HH);
                                    hoursWork = endTime - startTime;
                                    totalHWorkedByFocusedEmployee += hoursWork;

                                    // rec for hoursWorked

                                    e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(480, HH, 120, 20));
                                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(480, HH, 120, 20));
                                    if (totalHWorkedByFocusedEmployee != hoursWork)
                                    {
                                        e.Graphics.DrawString(hoursWork.Hours.ToString("D2") + ":" + hoursWork.Minutes.ToString("D2") + " >> " + totalHWorkedByFocusedEmployee.Hours.ToString("D2") + ":" + totalHWorkedByFocusedEmployee.Minutes.ToString("D2"), new Font("Times New Roman", 12f), Brushes.Black, 480f, HH);
                                    }
                                    else
                                    {
                                        e.Graphics.DrawString(hoursWork.Hours.ToString("D2") + ":" + hoursWork.Minutes.ToString("D2"), new Font("Times New Roman", 12f), Brushes.Black, 480f, HH);
                                    }

                                    // rec for difference
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(600, HH, 160, 20));
                                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(600, HH, 160, 20));
                                    e.Graphics.DrawString("-----", new Font("Times New Roman", 12f), Brushes.Firebrick, 660f, HH);
                                    headerEmployeePrinted = true;
                                    HH += 20;
                                }
                            }

                            if (headerEmployeePrinted == false)
                            {
                                startTime = Convert.ToDateTime(dWorked.Date);
                                endTime = Convert.ToDateTime(dWorked.Date);
                                e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(100, HH, 220, 20));
                                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(100, HH, 220, 20));
                                e.Graphics.DrawString(reportFromListView.Items[selectedIndex].SubItems[0].Text, new Font("Times New Roman", 12f), Brushes.Black, 100f, HH);

                                // rect for start
                                e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(320, HH, 80, 20));
                                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(320, HH, 80, 20));
                                e.Graphics.DrawString("00:00", new Font("Times New Roman", 12f), Brushes.Black, 320f, HH);

                                // rect for end
                                e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(400, HH, 80, 20));
                                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(400, HH, 80, 20));
                                e.Graphics.DrawString("00:00", new Font("Times New Roman", 12f), Brushes.Black, 400f, HH);
                                hoursWork = endTime - startTime;

                                // rec for hoursWorked
                                e.Graphics.FillRectangle(new SolidBrush(Color.Goldenrod), new Rectangle(480, HH, 120, 20));
                                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(480, HH, 120, 20));
                                e.Graphics.DrawString("00:00", new Font("Times New Roman", 12f), Brushes.Black, 480f, HH);

                                // rec for difference
                                e.Graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(600, HH, 160, 20));
                                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(600, HH, 160, 20));
                                e.Graphics.DrawString("-----", new Font("Times New Roman", 12f), Brushes.Firebrick, 660f, HH);
                                HH += 20;
                                missedWork = true;
                            }

                            headerEmployeePrinted = false;
                            bool moreThanOneRecord = false;

                            // print all the employees that are over time of focused employee
                            for (int s = 0, loopTo2 = employeesWorkingThatDay.Rows.Count - 1; s <= loopTo2; s++)
                            {
                                var infoCompared = employeesWorkingThatDay.Rows[s];
                                startTimeCompared = Conversions.ToDate(infoCompared["startTime"]);
                                endTimeCompared = Conversions.ToDate(infoCompared["endTime"]);
                                if (startTimeCompared.Date == dWorked.Date)
                                {
                                    hoursWorkCompared = endTimeCompared - startTimeCompared;
                                    hoursWork = endTime - startTime;
                                    if (totalHWorkedByFocusedEmployee != hoursWork)
                                    {
                                        hoursWork = totalHWorkedByFocusedEmployee;
                                    }

                                    hoursDiff = hoursWorkCompared - hoursWork;
                                    if (startTimeCompared < startTime | endTimeCompared > endTime)
                                    {
                                        hoursBeforeFocusedEmployee = startTime - startTimeCompared;
                                        hoursAfterFocusedEmployee = endTimeCompared - endTime;
                                        if (hoursAfterFocusedEmployee.TotalMinutes < 0d)
                                        {
                                            hoursAfterFocusedEmployee = new TimeSpan(0, 0, 0, 0);
                                        }

                                        if (hoursBeforeFocusedEmployee.TotalMinutes < 0d)
                                        {
                                            hoursBeforeFocusedEmployee = new TimeSpan(0, 0, 0, 0);
                                        }

                                        // rec for name
                                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(100, HH, 220, 20));
                                        e.Graphics.DrawString(Conversions.ToString(Operators.AddObject(Operators.AddObject(infoCompared["alias"], " "), infoCompared["last_name"])), new Font("Times New Roman", 12f), Brushes.Black, 100f, HH);

                                        // rect for start
                                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(320, HH, 80, 20));
                                        e.Graphics.DrawString(startTimeCompared.ToString("HH:mm"), new Font("Times New Roman", 12f), Brushes.Black, 320f, HH);

                                        // rect for end
                                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(400, HH, 80, 20));
                                        e.Graphics.DrawString(endTimeCompared.ToString("HH:mm"), new Font("Times New Roman", 12f), Brushes.Black, 400f, HH);

                                        // rec for hoursWorked
                                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(480, HH, 120, 20));
                                        e.Graphics.DrawString(hoursWorkCompared.Hours.ToString("D2") + ":" + hoursWorkCompared.Minutes.ToString("D2"), new Font("Times New Roman", 12f), Brushes.Black, 480f, HH);
                                        if (missedWork)
                                        {
                                            hoursAfterFocusedEmployee = new TimeSpan(0, endTimeCompared.Hour, endTimeCompared.Minute, 0, 0);
                                            hoursBeforeFocusedEmployee = new TimeSpan(0, startTimeCompared.Hour, startTimeCompared.Minute, 0, 0);
                                            // hoursOverBefore = hoursBeforeFocusedEmployee
                                        }

                                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(infoCompared["ID"], reportFromListView.Items[selectedIndex].SubItems[1].Text, false)))
                                        {
                                            if (earliestTimeFocusedEmployee != new TimeSpan(0, startTime.Hour, startTime.Minute, 0, 0))
                                            {
                                                if (earliestTimeFocusedEmployee > hoursBeforeFocusedEmployee)
                                                {
                                                    earliestTimeFocusedEmployee = hoursBeforeFocusedEmployee;
                                                }
                                            }

                                            if (latestTimeFocusedEmployee != new TimeSpan(0, endTime.Hour, endTime.Minute, 0, 0))
                                            {
                                                if (latestTimeFocusedEmployee > hoursAfterFocusedEmployee)
                                                {
                                                    latestTimeFocusedEmployee = hoursAfterFocusedEmployee;
                                                }
                                            }
                                        }

                                        // rec for difference
                                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(600, HH, 160, 20));
                                        e.Graphics.DrawString("* " + hoursBeforeFocusedEmployee.Hours.ToString() + ":" + hoursBeforeFocusedEmployee.Minutes.ToString("D2") + " / * " + hoursAfterFocusedEmployee.Hours.ToString() + ":" + hoursAfterFocusedEmployee.Minutes.ToString("D2"), new Font("Times New Roman", 12f), Brushes.Firebrick, 620f, HH);
                                        if (!missedWork)
                                        {
                                            if (hoursBeforeFocusedEmployee > hoursOverBefore)
                                            {
                                                hoursOverBefore = hoursBeforeFocusedEmployee;
                                            }

                                            if (hoursAfterFocusedEmployee > hoursOverAfter)
                                            {
                                                hoursOverAfter = hoursAfterFocusedEmployee;
                                            }
                                        }

                                        if (missedWork)
                                        {
                                            if (hoursOverBefore.TotalMinutes == 0d)
                                            {
                                                hoursOverBefore = hoursBeforeFocusedEmployee;
                                            }

                                            if (hoursOverAfter.TotalMinutes == 0d)
                                            {
                                                hoursOverAfter = hoursAfterFocusedEmployee;
                                            }

                                            if (hoursBeforeFocusedEmployee < hoursOverBefore)
                                            {
                                                hoursOverBefore = hoursBeforeFocusedEmployee;
                                            }

                                            if (hoursAfterFocusedEmployee > hoursOverAfter)
                                            {
                                                hoursOverAfter = hoursAfterFocusedEmployee;
                                            }
                                        }

                                        HH += 20;
                                    }

                                    if (HH > 1200)
                                    {
                                        e.HasMorePages = true;
                                        nextPageExists = true;
                                        INDEX_ALL_DAYS -= 1;
                                        break;
                                    }
                                    else
                                    {
                                        nextPageExists = false;
                                    }
                                }
                            }

                            // rec for maxHourText
                            var totalOverDay = hoursOverBefore + hoursOverAfter;
                            if (missedWork)
                            {
                                totalOverDay = hoursOverAfter - hoursOverBefore;
                            }

                            totalHoursOver += totalOverDay;
                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(480, HH, 120, 20));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(480, HH, 120, 20));
                            e.Graphics.DrawString("Max hours over", new Font("Times New Roman", 12f), Brushes.Black, 480f, HH);

                            // rec for MaxHour

                            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(600, HH, 160, 20));
                            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(600, HH, 160, 20));
                            e.Graphics.DrawString(totalOverDay.Hours.ToString() + ":" + totalOverDay.Minutes.ToString("D2"), new Font("Times New Roman", 12f), Brushes.Black, 660f, HH);
                            hoursOverBefore = new TimeSpan(0, 0, 0, 0);
                            hoursOverAfter = new TimeSpan(0, 0, 0, 0);
                            hoursBeforeFocusedEmployee = new TimeSpan(0, 0, 0);
                            hoursAfterFocusedEmployee = new TimeSpan(0, 0, 0);
                            missedWork = false;
                            if (HH + 120 > 900)
                            {
                                e.HasMorePages = true;
                                nextPageExists = true;
                                break;
                            }
                            else
                            {
                                nextPageExists = false;
                            }
                        }

                        // INDEX_ALL_DAYS += 1
                        else
                        {
                            e.HasMorePages = true;
                            nextPageExists = true;
                            INDEX_ALL_DAYS -= 1;
                            break;
                        }
                    }
                }

                if (nextPageExists == false | pageNumber == 1)
                {
                    // rec for totalHourText
                    e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(480, 1000, 120, 20));
                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(480, 1000, 120, 20));
                    e.Graphics.DrawString("Total hours over", new Font("Times New Roman", 12f), Brushes.Black, 480f, 1000f);

                    // rec for totalHour
                    e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), new Rectangle(600, 1000, 160, 20));
                    e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(600, 1000, 160, 20));
                    e.Graphics.DrawString((totalHoursOver.Days * 24 + totalHoursOver.Hours).ToString() + ":" + totalHoursOver.Minutes.ToString("D2"), new Font("Times New Roman", 12f), Brushes.Black, 660f, 1000f);
                }

                totalHoursOver = new TimeSpan(0, 0, 0);
                earliestTimeFocusedEmployee = new TimeSpan(0, 0, 0);
                latestTimeFocusedEmployee = new TimeSpan(0, 0, 0);
                hoursOverBefore = new TimeSpan(0, 0, 0);
                totalHoursOver = new TimeSpan(0, 0, 0);
                hoursOverAfter = new TimeSpan(0, 0, 0);
                hoursBeforeFocusedEmployee = new TimeSpan(0, 0, 0);
                hoursAfterFocusedEmployee = new TimeSpan(0, 0, 0);
                pageNumber -= 1;
            }
        }
    }
}