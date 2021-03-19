using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlSafetyAndRiskManagement
    {
        private static DatabaseHelper db = new DatabaseHelper();

        public static void getEmployeesStats(DateTime startDate, DateTime endDate, ListView employeeList, string conditions)
        {
            employeeList.Items.Clear();
            string employeeName = "";
            foreach (DataRow employee in db.getEmployeesBetweenDates(startDate, endDate, conditions).Rows)
            {
                employeeName = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(employee["First_Name"], " "), employee["Last_Name"]), " ("), employee["Alias"]), ")"));
                if (db.isWorkingToday(Conversions.ToInteger(employee["ID"])))
                {
                    employeeList.Items.Add(new ListViewItem(new[] { "", employeeName, employee["Site_Location"].ToString(), employee["ID"].ToString() }, 0));
                }
                else
                {
                    employeeList.Items.Add(new ListViewItem(new[] { "", employeeName, employee["Site_Location"].ToString(), employee["ID"].ToString() }, 1));
                }
            }

            employeeList.Update();
        }
    }
}