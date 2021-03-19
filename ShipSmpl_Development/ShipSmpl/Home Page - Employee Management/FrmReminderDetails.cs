using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmReminderDetails
    {
        public FrmReminderDetails()
        {
            InitializeComponent();
            _TouchButton1.Name = "TouchButton1";
            _ListView1.Name = "ListView1";
        }

        private void FrmProbationPeriodReminders_Load(object sender, EventArgs e)
        {
            ListView1.Clear();
            if (My.MyProject.Forms.FrmHomePage.typeOfReminder.Equals("Probation"))
            {
                ListView1.Columns.Add("Name", 300);
                ListView1.Columns.Add("Hire date", 150);
                ListView1.Columns.Add("Probation date end", 200);
                ListView1.Columns.Add("", 0);
                notificationTypeLabel.Text = "Upcoming probation period due dates";
            }
            else if (My.MyProject.Forms.FrmHomePage.typeOfReminder.Equals("Birthday"))
            {
                notificationTypeLabel.Text = "Upcoming Birthdays";
                ListView1.Columns.Add("Name", 400);
                ListView1.Columns.Add("Birthday", 250);
                ListView1.Columns.Add("", 0);
            }

            ListView1.Width = 655;
            populate();
        }

        private void TouchButton1_Load(object sender, EventArgs e)
        {
            Close();
        }

        public void populate()
        {
            var db = new DatabaseHelper();
            var todayDate = DateTime.Now.Date;
            DateTime threeMonthsBackM = Conversions.ToDate(DateTime.Now.Date.AddMonths(-3).ToString("yyyy/MM/dd"));
            DateTime hiredDate;
            DateTime birthdate;
            string condition = "and Start_Date >= '" + DateTime.Now.Date.AddMonths(-3).ToString("yyyy/MM/dd") + "'";
            if (My.MyProject.Forms.FrmHomePage.typeOfReminder.Equals("Probation"))
            {
                foreach (DataRow employee in db.getAllActiveEmployees(condition).Rows)
                {
                    hiredDate = Conversions.ToDate(employee["Start_Date"]);
                    ListView1.Items.Add(new ListViewItem(new[] { Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"])), hiredDate.ToString("MMM dd, yyyy"), hiredDate.Date.AddMonths(+3).ToString("MMM dd, yyyy"), Conversions.ToString(employee["ID"]) }));
                }
            }
            else if (My.MyProject.Forms.FrmHomePage.typeOfReminder.Equals("Birthday"))
            {
                foreach (DataRow employee in (IEnumerable)db.getAllActiveEmployees(@"and DATEPART( Week, DATEADD( Year, DATEPART( Year, GETDATE()) - DATEPART( Year, birth_Date), birth_Date))
      = DATEPART( Week, GETDATE())").Rows)
                {
                    birthdate = Conversions.ToDate(employee["Birth_Date"]);
                    ListView1.Items.Add(new ListViewItem(new[] { Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"])), birthdate.ToString("MMM dd") + ", " + DateAndTime.Now.Year.ToString(), Conversions.ToString(employee["ID"]) }));
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.FocusedItem.Index > -1)
            {
                // If FrmEmployeeManagementHP.typeOfReminder.Equals("Probation") Then
                // fillEmployeeDetails(ListView1, 3)
                // Else
                // fillEmployeeDetails(ListView1, 2)
                // End If
                // FrmEmployeeDetails.Show()
            }
        }
    }
}