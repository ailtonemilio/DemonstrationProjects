using BusinessLayer.WTC_Ceres;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmReportEmployeeIsworking
    {
        public frmReportEmployeeIsworking()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _dgvEmployee.Name = "dgvEmployee";
            _txtSiteLocation.Name = "txtSiteLocation";
            _txtPhoneNumber.Name = "txtPhoneNumber";
            _txtLastName.Name = "txtLastName";
            _txtFirstName.Name = "txtFirstName";
            _btnExportToExcel.Name = "btnExportToExcel";
        }

        private List<EmployeeWorking> listEmployeeWorkingByColumn;
        private List<EmployeeWorking> listEmployeeWorking;
        private string sortMode = "ASC";

        private void LoadForm()
        {
            listEmployeeWorking = EmployeeService.GetEmployeeWorking();
            dgvEmployee.DataSource = listEmployeeWorking;
            listEmployeeWorkingByColumn = listEmployeeWorking;
            lblTotalEmployeeWorking.Text = "Total Employee working: " + dgvEmployee.Rows.Count.ToString();
            CountTotalPerSite();
        }

        private void SearchEmployee()
        {
            var L = from e in listEmployeeWorking
                    where e.FirstName.StartsWith(txtFirstName.Text) & e.LastName.StartsWith(txtLastName.Text) & e.PhoneNumber.StartsWith(txtPhoneNumber.Text) & e.SiteLocation.StartsWith(txtSiteLocation.Text)
                    select e;
            listEmployeeWorkingByColumn = L.ToList();
            dgvEmployee.DataSource = L.ToList();
            lblTotalEmployeeWorking.Text = "Total Employee working: " + dgvEmployee.Rows.Count.ToString();
            CountTotalPerSite();
        }

        private void CountTotalPerSite()
        {
            int te = (from e in listEmployeeWorking
                      where e.SiteLocation.StartsWith("E")
                      select e).Count();
            lblTotalEwen.Text = te.ToString();
            int tl = (from e in listEmployeeWorking
                      where e.SiteLocation.StartsWith("L")
                      select e).Count();
            lblTotalLindsey.Text = tl.ToString();
            int tr = (from e in listEmployeeWorking
                      where e.SiteLocation.StartsWith("R")
                      select e).Count();
            lblTotalRemote.Text = tr.ToString();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmReportEmployeeIsworking_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtFirstName_TextChange(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void txtLastName_TextChange(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void txtPhoneNumber_TextChange(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void txtSiteLocation_TextChange(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void dgvEmployee_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ColName = dgvEmployee.Columns[e.ColumnIndex].DataPropertyName;
            string querySort;
            List<EmployeeWorking> list;
            if (sortMode.Equals("ASC"))
            {
                querySort = ColName + " DESC";
                sortMode = "DESC";
            }
            else
            {
                querySort = ColName + " ASC";
                sortMode = "ASC";
            }

            list = listEmployeeWorkingByColumn.OrderBy(querySort).ToList();
            dgvEmployee.DataSource = list;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            var rows1 = dgvEmployee.Rows;
            var headers = (from header in dgvEmployee.Columns.Cast<DataGridViewColumn>()
                           select header.HeaderText).ToArray();
            var rows = from row in dgvEmployee.Rows.Cast<DataGridViewRow>()
                       where !row.IsNewRow
                       select Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value is object ? c.Value.ToString() : "");
            try
            {
                using (var sw = new System.IO.StreamWriter("csv.csv"))
                {
                    sw.WriteLine(string.Join(",", headers));
                    foreach (var r in rows)
                        sw.WriteLine(string.Join(",", r));
                }

                Process.Start("csv.csv");
            }
            catch (Exception ex)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error.", ex.Message, this);
            }

            MdlLoadingSetting.waitForm.Close();
        }
    }
}