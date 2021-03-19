using Bunifu.UI.WinForms;
using System.Data;

namespace ShipSmpl
{
    static class MdlEmpManagement
    {
        private static DatabaseHelper db = new DatabaseHelper();

        public static void populateEmployeeList(BunifuDataGridView gridView, string status)
        {
            gridView.Rows.Clear();
            foreach (DataRow employee in db.getTableInfo("Employees", "Alias, First_Name ,LAst_Name , Yard, Phone_Number , Status, ID", status + " order by alias").Rows)
                gridView.Rows.Add(employee["Alias"], employee["First_Name"], employee["Last_Name"], employee["Yard"], employee["Phone_Number"], employee["Status"], employee["ID"]);
            // sqlCon.Close()
            // End Using

        }
    }
}