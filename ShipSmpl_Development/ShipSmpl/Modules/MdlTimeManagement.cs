using Bunifu.UI.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace ShipSmpl
{

    // Imports Microsoft.Office.Interop
    // Imports Microsoft.Office.Interop.Excel

    static class MdlTimeManagement
    {
        private static int rowCount;
        private static DatabaseHelper db = new DatabaseHelper();
        private static int _employeeID;
        private static string _firstName;
        private static string _lastName;
        private static string _alias;
        private static object _firstDayOfMonth;
        private static int _punchID;
        private static DateTime endPeriodDate;
        private static DateTime startPeriodDate;

        public static void populateMonthDropDown()
        {
            var months = DateTimeFormatInfo.InvariantInfo.MonthNames;
            foreach (string month in months)
            {
                if (!string.IsNullOrEmpty(month))
                {
                    My.MyProject.Forms.FrmTimeSheet.monthComboBox.Items.Add(month);
                }
            }

            foreach (DataRow yearWorked in db.getTableInfo("Time_Sheet", "distinct(year(Start_Time_Date)) as y", "order by y").Rows)
                My.MyProject.Forms.FrmTimeSheet.yearComboBox.Items.Add(yearWorked["y"]);
            My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedIndex = My.MyProject.Forms.FrmTimeSheet.yearComboBox.Items.Count - 1;
            My.MyProject.Forms.FrmTimeSheet.monthComboBox.SelectedItem = DateTime.Now.ToString("MMMM");
        }

        public static void populateEndPeriod()
        {
            My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.Items.Clear();
            string year = Conversions.ToString(My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedItem);
            string selectedMonth = Conversions.ToString(My.MyProject.Forms.FrmTimeSheet.monthComboBox.SelectedItem);
            DateTime period;
            int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.CurrentCulture).Month;
            int lastDay = DateTime.DaysInMonth(Convert.ToInt32(year), monthNumber);
            period = Convert.ToDateTime(selectedMonth + "-15-" + year);
            My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.Items.Add(period.ToString("MMM 15"));
            string endPeriod = "MMM " + lastDay.ToString() + ", " + My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedItem.ToString();
            period = Convert.ToDateTime(selectedMonth + "-" + lastDay.ToString() + "-" + year);
            var temp = Convert.ToDateTime(selectedMonth + "-01-" + year);
            My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.Items.Add(period.ToString("MMM dd"));
            _firstDayOfMonth = temp.ToString("MMM dd");
            if (DateAndTime.Today.Day <= 15)
            {
                My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.SelectedIndex = 0;
            }
            else
            {
                My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.SelectedIndex = 1;
            }

            My.MyProject.Forms.FrmTimeSheet.timeSheetDescriptionLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject("Time Sheet for period ending ", My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.SelectedItem), ", "), My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedItem.ToString()));
        }

        private static BunifuDataGridView summaryList = My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView;
        private static int selectedID;

        public static void populateTimeSheetList()
        {
            summaryList = My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView;
            string payMethod = Conversions.ToString(My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedItem.ToString().Substring(0, 1));
            string selectField = "";
            if (payMethod.Equals("P"))
            {
                payMethod = "Punch_Type = 'PW' and ";
                selectField = "Punch_Type,";
            }
            else if (payMethod.Equals("A"))
            {
                payMethod = "";
            }
            else
            {
                payMethod = "Punch_Type = '" + payMethod + "' and ";
                selectField = "Punch_Type,";
            }

            My.MyProject.Forms.FrmTimeSheet.timeSheetDescriptionLabel.Text = Conversions.ToString(Operators.AddObject("Time Sheet for period ending ", My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.SelectedItem));
            ComboBox endPeriodComboBox = My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox;
            string endDate = Conversions.ToString(Convert.ToDateTime(Operators.AddObject(Operators.AddObject(endPeriodComboBox.SelectedItem, " "), My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedItem.ToString())));
            endPeriodDate = Convert.ToDateTime(endDate + " 23:59:59");
            if (endPeriodComboBox.SelectedIndex == 0)
            {
                startPeriodDate = Conversions.ToDate(_firstDayOfMonth);
                startPeriodDate = new DateTime(Convert.ToInt32(My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedItem), startPeriodDate.Month, startPeriodDate.Day, 0, 0, 0, 0);
            }
            else
            {
                startPeriodDate = Convert.ToDateTime(endPeriodComboBox.Items[0]);
                startPeriodDate = new DateTime(Convert.ToInt32(My.MyProject.Forms.FrmTimeSheet.yearComboBox.SelectedItem), startPeriodDate.Month, 16, 0, 0, 0, 0, 0);
            }

            int totalHours = 0;
            int totalMinutes = 0;
            string totalTime = "";
            int remainder = 0;
            bool employeeWorked = false;
            summaryList.Rows.Clear();

            // clearDataGrid(summaryList)

            DataTable showEmployees = (DataTable)db.getHourlyEmpIdOfCurrentPeriod(startPeriodDate, endPeriodDate);
            int uid;
            string fname;
            string lname;
            string aliasName;
            // Dim firstEntry = True

            string columnsEmployees = "UserID, Alias, First_Name, Last_Name, " + selectField + " sum(totalMinutes) as totalMinutes, Type";
            string tables = @"(select Alias, First_Name, Last_Name, userID, Type,
Start_Time_Date, End_Time_Date, " + selectField + @"
  DATEDIFF(minute,Start_Time_Date, End_Time_Date) as totalMinutes  from
  Time_Sheet, Employees e";
            string columnsTimeSheet = " Alias,  " + selectField + @" sum(totalMinutes)from
     (select Alias, Last_Name, userID, Start_Time_Date, End_Time_Date, Punch_Type,
  DATEDIFF(minute,Start_Time_Date, End_Time_Date) as totalMinutes  from
  Time_Sheet, Employees e) k";
            string conditions = "where " + payMethod + " Start_Time_Date >= '" + startPeriodDate.ToString("yyyy-MM-dd 00:00:00") + @"' and
   Start_Time_Date  <= '" + endPeriodDate.ToString("yyyy-MM-dd 23:59:59") + @"' and UserID = e.ID) s
   group by UserID, Alias, First_Name, Last_Name, " + selectField + " Type order by Alias";
            foreach (DataRow row in db.getTableInfo(tables, columnsEmployees, conditions).Rows)
            {
                // empid = row["ID")
                uid = Conversions.ToInteger(row["userID"]);
                fname = Conversions.ToString(row["First_Name"]);
                lname = Conversions.ToString(row["Last_Name"]);
                aliasName = Conversions.ToString(row["Alias"]);
                if (Information.IsDBNull(row["totalMinutes"]))
                {
                    totalMinutes = 0;
                }
                else
                {
                    totalMinutes = Conversions.ToInteger(row["totalMinutes"]);
                }

                remainder = totalMinutes % 60;
                if (totalMinutes >= 60)
                {
                    totalHours += totalMinutes / 60;
                }

                totalTime = totalHours + ":" + remainder.ToString("D2");
                conditions = "where " + payMethod + " UserID = " + uid.ToString() + " and End_Time_Date is null and Start_Time_Date >= '" + startPeriodDate.ToString("yyyy-MM-dd 00:00:00") + @"' and
   Start_Time_Date  <= '" + endPeriodDate.ToString("yyyy-MM-dd 23:59:59") + "'";
                string punchType = "";
                if (string.IsNullOrEmpty(selectField))
                {
                    punchType = "";
                }
                else
                {
                    punchType = Conversions.ToString(row["Punch_Type"]);
                }

                if (db.getTableInfo("Time_Sheet", "*", conditions).Rows.Count > 0)
                {
                    summaryList.Rows.Add((object)false, aliasName, lname, fname, totalTime, "working", uid.ToString(), punchType, row["Type"]);
                }
                else
                {
                    summaryList.Rows.Add((object)false, aliasName, lname, fname, totalTime, "complete", uid.ToString(), punchType, row["Type"]);
                }

                totalHours = 0;
                totalMinutes = 0;
                totalTime = "";
                employeeWorked = false;
            }
        }

        public static void fillModifyEntryFields()
        {
            var clockInTimePicker = My.MyProject.Forms.FrmEditEntry.clockInTimePicker;
            var clockOutTimePicker = My.MyProject.Forms.FrmEditEntry.clockOutTimePicker;
            int selectedItem = detailsDataGridView.CurrentCell.RowIndex;
            var punchType = detailsDataGridView.Rows[selectedItem].Cells[4].Value;
            if (punchType.Equals("Hourly"))
            {
                My.MyProject.Forms.FrmEditEntry.shiftTypeComboBox.SelectedIndex = 0;
            }
            else if (punchType.Equals("Salary"))
            {
                My.MyProject.Forms.FrmEditEntry.shiftTypeComboBox.SelectedIndex = 1;
            }
            else
            {
                My.MyProject.Forms.FrmEditEntry.shiftTypeComboBox.SelectedIndex = 2;
            }

            var d1 = Convert.ToDateTime(detailsDataGridView.Rows[selectedItem].Cells[1].Value);
            DateTime d2;
            if (detailsDataGridView.Rows[selectedItem].Cells[2].Value.Equals(""))
            {
                d2 = DateAndTime.Now.Date;
            }
            else
            {
                d2 = Convert.ToDateTime(detailsDataGridView.Rows[selectedItem].Cells[2].Value);
            }

            clockInTimePicker.Value = d1;
            clockOutTimePicker.Value = d2;
            My.MyProject.Forms.FrmEditEntry.clockInDateTimePicker.Value = Conversions.ToDate(detailsDataGridView.Rows[selectedItem].Cells[0].Value);
            My.MyProject.Forms.FrmEditEntry.clockoOutDateTimePicker.Value = Conversions.ToDate(detailsDataGridView.Rows[selectedItem].Cells[0].Value);
            _punchID = Convert.ToInt32(detailsDataGridView.Rows[selectedItem].Cells[6].Value);
        }

        public static void updatePunchInfo()
        {
            int selectedItem = detailsDataGridView.CurrentCell.RowIndex;
            int selectedItemSummary = summaryList.CurrentCell.RowIndex;
            string newClockInValue;
            string newCLockOutValue;
            if (My.MyProject.Forms.FrmEditEntry.clockInCheckBox.Checked)
            {
                newClockInValue = My.MyProject.Forms.FrmEditEntry.clockInDateTimePicker.Value.Date.ToString("yyyy-MM-dd") + " " + My.MyProject.Forms.FrmEditEntry.clockInTimePicker.Value.ToString("HH:mm");
            }
            else
            {
                newClockInValue = Conversions.ToString(Operators.AddObject(Operators.AddObject(detailsDataGridView.Rows[selectedItem].Cells[0].Value, " "), detailsDataGridView.Rows[selectedItem].Cells[1].Value));
            }

            if (My.MyProject.Forms.FrmEditEntry.clockOutCheckBox.Checked)
            {
                newCLockOutValue = My.MyProject.Forms.FrmEditEntry.clockoOutDateTimePicker.Value.Date.ToString("yyyy-MM-dd") + " " + My.MyProject.Forms.FrmEditEntry.clockOutTimePicker.Value.ToString("HH:mm");
            }
            else if (detailsDataGridView.Rows[selectedItem].Cells[2].Value.Equals(""))
            {
                newCLockOutValue = null;
            }
            else
            {
                newCLockOutValue = Conversions.ToString(Operators.AddObject(Operators.AddObject(detailsDataGridView.Rows[selectedItem].Cells[0].Value, " "), detailsDataGridView.Rows[selectedItem].Cells[2].Value));
            }

            db.updatePunch(newClockInValue, newCLockOutValue, _punchID);

            // to save modifications
            if (My.MyProject.Forms.FrmEditEntry.clockInCheckBox.Checked == true & My.MyProject.Forms.FrmEditEntry.clockOutCheckBox.Checked == true)
            {
                db.saveModification("update", 3);
            }
            else if (My.MyProject.Forms.FrmEditEntry.clockInCheckBox.Checked)
            {
                db.saveModification("update", 1);
            }
            else if (My.MyProject.Forms.FrmEditEntry.clockOutCheckBox.Checked)
            {
                db.saveModification("update", 2);
            }

            string fieldsToUpdate = "";
            if (My.MyProject.Forms.FrmEditEntry.shiftTypeComboBox.SelectedItem.Equals("Hourly") & summaryList.Rows[selectedItemSummary].Cells[8].Value.Equals("Crew"))
            {
                // populateWorkDone(FrmEditEntry.workDoneListView, "Crew")

                foreach (ListViewItem item in My.MyProject.Forms.FrmEditEntry.workDoneListView.Items)
                {
                    if (Conversions.ToBoolean(item.Checked))
                    {
                        fieldsToUpdate += "'yes', ";
                    }
                    else
                    {
                        fieldsToUpdate += "'no', ";
                    }
                }

                fieldsToUpdate = fieldsToUpdate.Substring(0, fieldsToUpdate.Length - 2);
                db.saveWorkDone(fieldsToUpdate);
            }
        }

        private static BunifuDataGridView detailsDataGridView = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView;
        public static ListView detailedEntires = new ListView();

        public static void populateDetails(int selectedID)
        {
            MdlLoadingSetting.waitForm.Show();
            detailedEntires.Clear();
            detailsDataGridView.Rows.Clear();
            detailedEntires.Columns.Add("date");
            detailedEntires.Columns.Add("clockIn");
            detailedEntires.Columns.Add("clockOut");
            detailedEntires.Columns.Add("hoursWorked");
            detailedEntires.Columns.Add("punchID");
            detailedEntires.Columns.Add("shift");
            summaryList = My.MyProject.Forms.FrmTimeSheet.summaryBunifuDataGridView;
            detailsDataGridView = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView;
            DateTime d1;
            var d2 = default(DateTime);
            string hours;
            string payMethod = My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.Text.Substring(0, 1);
            if (payMethod.Equals("P"))
            {
                payMethod = "and Punch_Type = 'PW'";
            }
            else if (payMethod.Equals("A"))
            {
                payMethod = "";
            }
            else
            {
                payMethod = "and Punch_Type = '" + payMethod + "'";
            }

            string fields = "ID, userID, Start_Time_Date, End_Time_Date, Punch_Type";
            string condition = "where  Start_Time_Date >= '" + Conversions.ToString(startPeriodDate) + "' and " + "Start_Time_Date  <= '" + Conversions.ToString(endPeriodDate) + "' and UserID = " + selectedID.ToString() + "  " + payMethod + " order by Start_Time_Date";
            foreach (DataRow entry in db.getTableInfo("Time_Sheet", fields, condition).Rows)
            {
                string punchType;
                if (entry["Punch_Type"].Equals("H"))
                {
                    punchType = "Hourly";
                }
                else if (entry["Punch_Type"].Equals("S"))
                {
                    punchType = "Salary";
                }
                else
                {
                    punchType = "Piece Work";
                }

                if (db.isStatPunch(Conversions.ToString(entry["ID"])))
                {
                    punchType = "Statutory";
                }

                d1 = Convert.ToDateTime(entry["Start_Time_Date"]);
                if (!Information.IsDBNull(entry["End_Time_Date"]))
                {
                    d2 = Convert.ToDateTime(entry["End_Time_Date"]);
                    hours = Conversions.ToString(MdlControllerModifier.hoursWorked(Conversions.ToString(entry["Start_Time_Date"]), Conversions.ToString(entry["End_Time_Date"])));
                    detailedEntires.Items.Add(new ListViewItem(new[] { Strings.Format(d1, "MM/dd/yyyy"), Strings.Format(d1, "HH:mm "), Strings.Format(d2, "HH:mm "), Conversions.ToString(MdlControllerModifier.hoursWorked(Conversions.ToString(entry["Start_Time_Date"]), Conversions.ToString(entry["End_Time_Date"]))), Conversions.ToString(entry["ID"]), Conversions.ToString(entry["Punch_Type"]) }));
                    detailsDataGridView.Rows.Add(Strings.Format((object)d1, "MM/dd/yyyy"), Strings.Format((object)d1, "HH:mm "), Strings.Format((object)d2, "HH:mm "), MdlControllerModifier.hoursWorked(Conversions.ToString(entry["Start_Time_Date"]), Conversions.ToString(entry["End_Time_Date"])), punchType, "", entry["ID"], entry["Punch_Type"]);
                }
                else
                {
                    detailsDataGridView.Rows.Add(Strings.Format((object)d1, "MM/dd/yyyy"), Strings.Format((object)d1, "HH:mm "), "", "", punchType, "", entry["ID"], entry["Punch_Type"]);
                    detailedEntires.Items.Add(new ListViewItem(new[] { Strings.Format(d1, "MM/dd/yyyy"), Strings.Format(d1, "HH:mm "), Strings.Format(d2, "HH:mm "), "", Conversions.ToString(entry["ID"]), Conversions.ToString(entry["Punch_Type"]) }));
                }
            }

            showModifiedPunches();
            MdlLoadingSetting.waitForm.Close();
        }

        public static void showModifiedPunches()
        {
            for (int i = 0, loopTo = detailsDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                if (db.getModifiedEntries(detailsDataGridView.Rows[i].Cells[6].Value.ToString()).Rows.Count > 0)
                {
                    detailsDataGridView.Rows[i].Cells[5].Value = "modified";
                }
            }
        }

        public static void createNewPunch(DateTimePicker entryDate, DateTimePicker entryClockIn, DateTimePicker entryClockOut)
        {
            string newClockInEntry = entryDate.Value.ToString("yyyy-MM-dd") + " " + entryClockIn.Value.ToString("HH:mm");
            ComboBox selectedShiftType = My.MyProject.Forms.FrmAddNewEntry.shiftTypeComboBox;
            string newClockOutEntry;
            if (My.MyProject.Forms.FrmAddNewEntry.clockOutCheckBox.Checked)
            {
                newClockOutEntry = entryDate.Value.ToString("yyyy-MM-dd") + " " + entryClockOut.Value.ToString("HH:mm");
            }
            else
            {
                newClockOutEntry = "";
            }

            string selectShift;
            if (selectedShiftType.SelectedIndex == 0)
            {
                selectShift = "H";
            }
            else if (selectedShiftType.SelectedIndex == 1)
            {
                selectShift = "S";
            }
            else
            {
                selectShift = "PW";
            }

            var newEntryLV = My.MyProject.Forms.FrmAddNewEntry.createEntyDataGrid;
            int selectedRow = My.MyProject.Forms.FrmAddNewEntry.createEntyDataGrid.CurrentRow.Index;
            var lName = newEntryLV.Rows[selectedRow].Cells[2].Value;
            var fName = newEntryLV.Rows[selectedRow].Cells[1].Value;
            var aName = newEntryLV.Rows[selectedRow].Cells[0].Value;
            db._ID = Conversions.ToInteger(newEntryLV.Rows[selectedRow].Cells[3].Value);
            db.createPunch(newClockInEntry, newClockOutEntry, selectShift);

            // to save modifications
            if (My.MyProject.Forms.FrmAddNewEntry.clockInCheckBox.Checked == true & My.MyProject.Forms.FrmAddNewEntry.clockOutCheckBox.Checked == true)
            {
                db.saveModification("new", 3);
            }
            else if (My.MyProject.Forms.FrmAddNewEntry.clockInCheckBox.Checked)
            {
                db.saveModification("new", 1);
            }
            else if (My.MyProject.Forms.FrmAddNewEntry.clockOutCheckBox.Checked)
            {
                db.saveModification("new", 2);
            }

            string employeeType = Conversions.ToString(newEntryLV.Rows[selectedRow].Cells[4].Value);
            string fieldsToUpdate = "";
            if (employeeType.Equals("Crew") & My.MyProject.Forms.FrmAddNewEntry.shiftTypeComboBox.SelectedItem.Equals("Hourly") & My.MyProject.Forms.FrmAddNewEntry.clockOutCheckBox.Checked | employeeType.Equals("Crew") & My.MyProject.Forms.FrmAddNewEntry.shiftTypeComboBox.SelectedItem.Equals("Piece Work"))
            {
                foreach (ListViewItem item in My.MyProject.Forms.FrmAddNewEntry.workDoneListView.Items)
                {
                    if (Conversions.ToBoolean(item.Checked))
                    {
                        fieldsToUpdate += "'yes', ";
                    }
                    else
                    {
                        fieldsToUpdate += "'no', ";
                    }
                }

                fieldsToUpdate = fieldsToUpdate.Substring(0, fieldsToUpdate.Length - 2);
                db.saveWorkDone(fieldsToUpdate);
            }
        }

        public static void populateCreateEmployeeEntryList(string condition)
        {
            // populate employeeDropBox
            var createEntryList = My.MyProject.Forms.FrmAddNewEntry.createEntyDataGrid;
            createEntryList.Rows.Clear();
            // populate summary list
            foreach (DataRow employee in db.getTableInfo("Employees", "Alias, First_Name, Last_Name, ID, Type", condition).Rows)
                createEntryList.Rows.Add(employee["Alias"], employee["First_Name"], employee["Last_Name"], employee["ID"], employee["Type"]);
        }

        public static void exportCSV()
        {
            string CSVLine = "";
            string TempLine = "";
            string ThisCSVFile = @"C:\temp\TimeSheetPeriod-" + DateTime.Today.ToString("dd-MMM-yyyy") + "-" + Strings.Format(DateAndTime.TimeOfDay, "hhmmss") + ".CSV";
            System.IO.StreamWriter file;
            if (System.IO.File.Exists(ThisCSVFile) == true)
            {
                System.IO.File.Delete(ThisCSVFile);
            }

            file = My.MyProject.Computer.FileSystem.OpenTextFileWriter(ThisCSVFile, true);
            string tempendPeriod = My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.SelectedItem.ToString().Split(',')[0];
            tempendPeriod = tempendPeriod.Split(' ')[0] + "-" + tempendPeriod.Split(' ')[1];
            file.WriteLine("Time Sheet for period ending " + tempendPeriod + " " + DateTime.Today.Year.ToString() + Conversions.ToString(','));
            file.WriteLine("" + Conversions.ToString(','));
            file.WriteLine(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(summaryList.Columns[1].HeaderCell.Value, ','), summaryList.Columns[2].HeaderCell.Value), ','), summaryList.Columns[3].HeaderCell.Value), ','), summaryList.Columns[4].HeaderCell.Value), ','), "Converted Hours"), ','));
            for (int i = 0, loopTo = summaryList.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(summaryList.Rows[i].Cells[0].Value, true, false)))
                {
                    summaryList.Rows[i].Selected = true;
                    decimal hours = Convert.ToInt32(summaryList.Rows[i].Cells[4].Value.ToString().Split(':')[0]);
                    decimal minutes = Convert.ToInt32(summaryList.Rows[i].Cells[4].Value.ToString().Split(':')[1]);
                    decimal r = hours + minutes / 60m;
                    decimal result = decimal.Round(r, 2, MidpointRounding.AwayFromZero);
                    file.WriteLine(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(summaryList.Rows[i].Cells[1].Value, ','), summaryList.Rows[i].Cells[2].Value), ','), summaryList.Rows[i].Cells[3].Value), ','), summaryList.Rows[i].Cells[4].Value), ','), result.ToString()), ','));
                    exportCSVDetails(Conversions.ToString(summaryList.Rows[i].Cells[4].Value), result.ToString(), i);
                }
            }

            file.Close();
            Process.Start("EXCEL.EXE", ThisCSVFile);
        }

        public static void exportCSVDetails(string totalHoursWorked, string totalHoursWorkedConverted, int i)
        {
            string CSVLine = "";
            string TempLine = "";
            _alias = Strings.Trim(Conversions.ToString(summaryList.Rows[i].Cells[1].Value.ToString().Split(' ')[0]));
            _lastName = Strings.Trim(Conversions.ToString(summaryList.Rows[i].Cells[2].Value.ToString().Split(' ')[0]));
            _firstName = Strings.Trim(Conversions.ToString(summaryList.Rows[i].Cells[3].Value.ToString().Split(' ')[0]));
            populateDetails(Conversions.ToInteger(summaryList.Rows[i].Cells[6].Value));
            string tempendPeriod = My.MyProject.Forms.FrmTimeSheet.endPeriodComboBox.SelectedItem.ToString().Split(',')[0];
            tempendPeriod = tempendPeriod.Split(' ')[0] + "-" + tempendPeriod.Split(' ')[1];
            string ThisCSVFile = @"C:\temp\TimeSheetPeriod-" + tempendPeriod + "-" + Strings.Trim(_firstName) + "-" + Strings.Trim(_lastName) + "_(" + Strings.Trim(_alias) + ")" + "-" + Strings.Format(DateAndTime.TimeOfDay, "hhmmss") + ".CSV";
            System.IO.StreamWriter file;

            // Dim detailsListView As ListView = FrmTimeSheet.detailsListView

            if (System.IO.File.Exists(ThisCSVFile) == true)
            {
                System.IO.File.Delete(ThisCSVFile);
            }

            file = My.MyProject.Computer.FileSystem.OpenTextFileWriter(ThisCSVFile, true);
            file.WriteLine(_firstName + " " + _lastName + " (" + _alias + ")" + Conversions.ToString(','));
            file.WriteLine("" + Conversions.ToString(','));
            file.WriteLine("Total Hours: " + totalHoursWorked + Conversions.ToString(','));
            file.WriteLine("Total Hours (Converted): " + totalHoursWorkedConverted + Conversions.ToString(','));
            file.WriteLine("" + Conversions.ToString(','));
            file.WriteLine("Date" + Conversions.ToString(',') + "Clock In" + Conversions.ToString(',') + "Clock Out" + Conversions.ToString(',') + "Total Hours" + Conversions.ToString(',') + "Converted Hours" + Conversions.ToString(','));
            for (int j = 0, loopTo = detailedEntires.Items.Count - 1; j <= loopTo; j++)
            {
                string value = detailedEntires.Items[j].SubItems[3].Text;
                decimal hours;
                decimal minutes;
                object r;
                object result;
                if (!value.Equals(""))
                {
                    hours = Convert.ToInt32(detailedEntires.Items[j].SubItems[3].Text.Split(':')[0]);
                    minutes = Convert.ToInt32(detailedEntires.Items[j].SubItems[3].Text.Split(':')[1]);
                    r = hours + minutes / 60m;
                    result = decimal.Round(Conversions.ToDecimal(r), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    result = 0;
                }

                file.WriteLine(detailedEntires.Items[j].SubItems[0].Text + Conversions.ToString(',') + detailedEntires.Items[j].SubItems[1].Text + Conversions.ToString(',') + detailedEntires.Items[j].SubItems[2].Text + Conversions.ToString(',') + detailedEntires.Items[j].SubItems[3].Text + Conversions.ToString(',') + result.ToString() + Conversions.ToString(','));
            }

            file.Close();
            Process.Start("EXCEL.EXE", ThisCSVFile);
        }

        private static DateTime d1;

        public static void populateEntryDetails(int punchID)
        {
            var entryDetails = My.MyProject.Forms.FrmDetailedEntry.entryDetailsDataGrid;
            int selectedRowDetails = entryDetails.CurrentCell.RowIndex;
            My.MyProject.Forms.FrmDetailedEntry.siteLocationLabel.Text = Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[5].Value);
            My.MyProject.Forms.FrmDetailedEntry.deviceNameLabel.Text = Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[6].Value);
            My.MyProject.Forms.FrmDetailedEntry.reasonLabel.Text = Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[4].Value);
            My.MyProject.Forms.FrmDetailedEntry.modifiedOnLabel.Text = Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[7].Value);
            getWorkDone(punchID, Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[8].Value), Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[9].Value), Conversions.ToString(entryDetails.Rows[selectedRowDetails].Cells[10].Value));
        }

        public static void getEntryDetails()
        {
            int selectedItemSummary = summaryList.CurrentCell.RowIndex;
            string aliastName = Conversions.ToString(summaryList.Rows[selectedItemSummary].Cells[1].Value);
            string lastName = Conversions.ToString(summaryList.Rows[selectedItemSummary].Cells[2].Value);
            string firstName = Conversions.ToString(summaryList.Rows[selectedItemSummary].Cells[3].Value);
            int selectedEntry = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.CurrentCell.RowIndex;
            int punchID = Conversions.ToInteger(My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.Rows[selectedEntry].Cells[6].Value);
            DateTime clockIn;
            DateTime clockOut;
            var clockOutStr = default(string);
            string fieldModified;
            object clockInStr;
            var entryDetails = My.MyProject.Forms.FrmDetailedEntry.entryDetailsDataGrid;
            entryDetails.Rows.Clear();
            DateTime d2;
            My.MyProject.Forms.FrmDetailedEntry.employeeNameLabel.Text = "Employee: " + firstName + " " + lastName;
            var modifiedPunches = db.getModifiedPunchInfo(punchID).Rows;
            if (modifiedPunches.Count > 0)
            {
                foreach (DataRow info in modifiedPunches)
                {
                    d1 = Convert.ToDateTime(info["Start_Time_Date"]);
                    clockInStr = d1.ToShortTimeString();
                    if (!Information.IsDBNull(info["End_Time_Date"]))
                    {
                        d2 = Convert.ToDateTime(info["End_Time_Date"]);
                        clockOutStr = d2.ToShortTimeString();
                    }

                    if (!Information.IsDBNull(info["Modified_Fields"]))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(info["Modified_Fields"], 1, false)))
                        {
                            fieldModified = "Clock In";
                            clockOutStr = "N/A";
                        }
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(info["Modified_Fields"], 2, false)))
                        {
                            fieldModified = "Clock Out";
                            clockInStr = "N/A";
                        }
                        else
                        {
                            fieldModified = "Clock In & Clock Out";
                        }
                    }
                    else
                    {
                        fieldModified = "N/A";
                    }

                    DateTime modDate = Conversions.ToDate(info["Date_Time_Of_Modification"]);
                    My.MyProject.Forms.FrmDetailedEntry.dateLabel.Text = d1.ToString("MMM dd, yyyy");
                    entryDetails.Rows.Add(clockInStr, clockOutStr, info["Modified_By"], fieldModified, info["Reason"], info["Site_Location"], info["Device_Name"], modDate.ToString("MMM dd, yyyy") + " at " + modDate.ToShortTimeString(), info["Type"], info["Punch_Type"], info["Job_Description"]);
                    // getWorkDone(info["Type"], info["Punch_Type"], info["Job_Description"])
                }
            }
            else
            {
                foreach (DataRow entry in (IEnumerable)db.getSelectedEntry(punchID).Rows)
                {
                    d1 = Conversions.ToDate(entry["Start_Time_Date"]);
                    if (!Information.IsDBNull(entry["End_Time_Date"]))
                    {
                        d2 = Convert.ToDateTime(entry["End_Time_Date"]);
                        clockOutStr = d2.ToShortTimeString();
                    }
                    // getWorkDone(entry("Type"), entry("Punch_Type"), entry("Job_Description"))
                    entryDetails.Rows.Add(d1.ToShortTimeString(), clockOutStr, "N/A", "N/A", "N/A", entry["Site_Location"], entry["Device_Name"], "N/A", entry["Type"], entry["Punch_Type"], entry["Job_Description"]);
                }
            }
        }

        public static string workDone { get; set; } = "";

        public static void getWorkDone(int workID, string employeeType, string punchType, string jobDescription)
        {
            workDone = "";
            if (employeeType.Equals("Office"))
            {
                workDone = "‣ Office Work ";
            }
            else if (punchType.Equals("S"))
            {
                workDone = "‣ N/A." + Environment.NewLine + jobDescription;
            }
            else if (punchType.Equals("Hourly"))
            {
                workDone = "‣ N/A." + Environment.NewLine + jobDescription;
            }
            else
            {
                foreach (DataRow work in db.getWorkDone(workID).Rows)
                {
                    if (work["Bag_To_Bag"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Bag to Bag";
                    }

                    if (work["Bulk_To_Bag"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Bag to Bulk";
                    }

                    if (work["Bulk_To_Bulk"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Bulk to Bulk";
                    }

                    if (work["Forklift_Operator"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Forklift Operator";
                    }

                    if (work["Grain_Door"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Grain Door";
                    }

                    if (work["Mechanic"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Mechanic Work";
                    }

                    if (work["Papaerwork"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Paperwork";
                    }

                    if (work["Repairs"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Repairs";
                    }

                    if (work["Shunter_Operator"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Shunter Operator";
                    }

                    if (work["Reach_Stacker"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Reach Stacker";
                    }

                    if (work["Tipping"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Tipping";
                    }

                    if (work["Warehouse"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Warehouse";
                    }

                    if (work["Workshop"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Workshop";
                    }

                    if (work["Yard_work"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "‣ Yard Work";
                    }

                    if (work["Yard_Cleanup"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "  • Yard Cleanup";
                    }

                    if (work["Yard_Maintenance"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "  • Yard Maintenence";
                    }

                    if (work["Push_Bin"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "  • Push Bin";
                    }

                    if (work["Belt"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "  • Belt";
                    }

                    if (work["Bagger1"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "  • Bagger 1";
                    }

                    if (work["Bagger2"].Equals("yes"))
                    {
                        workDone += Environment.NewLine + "  • Bagger 2";
                    }

                    if (work["Nothing"].Equals("yes"))
                    {
                        workDone += "‣ Nothing ";
                    }
                }
            }

            if (workDone.Equals(""))
            {
                workDone = "N/A";
            }
            else
            {
                workDone = Strings.Mid(workDone, 3, workDone.Length - 2);
            }

            string hol = Conversions.ToString(db.getHolidayName(workID.ToString()));
            if (!string.IsNullOrEmpty(hol)) // BunifuDataGridView1
            {
                workDone = hol;
            }

            My.MyProject.Forms.FrmDetailedEntry.workDoneLabel.Text = workDone;
        }

        public static void populateWorks(ListView workDoneListview)
        {
            // = FrmAddNewEntry.workDoneListView

            workDoneListview.Columns.Add("", 200);
            workDoneListview.Width = 240;
            workDoneListview.Items.Clear();
            workDoneListview.HeaderStyle = ColumnHeaderStyle.None;
            workDoneListview.Items.Add(new ListViewItem(new[] { "Bag to Bag (BAG)" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Bulk to Bag (BGR)" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Bulk to Bulk (BLK)" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Forklift Operator" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Grain Door" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Mechanic" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Paperwork" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Repairs" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Shunter Operator" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Reach Stacker" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Tipping" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Warehouse" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Workshop" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Yard Work" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Yard Cleanup" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Yard Maintenance" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Push Bin" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Belt" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Bagger 1" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Bagger 2" }));
            workDoneListview.Items.Add(new ListViewItem(new[] { "Nothing" }));
            workDoneListview.Update();
        }
    }
}