using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ShipSmpl.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmSafetyRiskManagement
    {
        public FrmSafetyRiskManagement()
        {
            ImgList = new ImageList() { ImageSize = new Size(30, 30) };
            InitializeComponent();
            _btnSearch.Name = "btnSearch";
            _btnPrintReport.Name = "btnPrintReport";
            _closeLabel.Name = "closeLabel";
        }

        private ImageList ImgList;
        private DatabaseHelper db = new DatabaseHelper();
        private SqlCommand objCommand = new SqlCommand();
        private string StrConnection = DatabaseHelper.StrConnWTCOperationsCers;

        private void FrmSafetyRiskManagement_Load(object sender, EventArgs e)
        {
            startDateTimePicker.Value = DateAndTime.Now;
            endDateTimePicker.Value = DateAndTime.Now;
            typeComboBox.SelectedIndex = 0;
            yardComboBox.SelectedIndex = 0;
            LoadHours();

            // getEmployeesStats(startDateTimePicker.Value.Date, endDateTimePicker.Value.Date, ListView1, "")
        }

        private void LoadHours()
        {
            string query = "";
            var TotalHours = default(decimal);
            TimeSpan span;
            TimeSpan spanhours;
            string Type = typeComboBox.Text;
            string Yard = yardComboBox.Text;
            if (Type == "All")
            {
                Type = "";
            }
            else
            {
                Type = "And e.[Type] = '" + Type + "'";
            }

            if (Yard == "All")
            {
                Yard = "";
            }
            else
            {
                Yard = "and  T.Site_Location = '" + Yard + "'";
            }

            if (rblHoursPerSite.Checked)
            {
                query = @"select T.Site_Location as Yard, T.Punch_Type, FORMAT(SUM(DATEDIFF(MINUTE, t.Start_Time_Date, t.End_Time_Date))/60.0,'N','en-us') AS [Hours]
                        from Time_Sheet T
                        where (T.Start_Time_Date >= '" + startDateTimePicker.Value.Date.ToString("yyyy-MM-dd 00:00:00") + "' and T.End_Time_Date <= '" + endDateTimePicker.Value.Date.ToString("yyyy-MM-dd 23:59:59") + @"')
                        " + Yard + @"
                        group by T.Site_Location,T.Punch_Type";
            }
            else if (rblHoursPerSiteType.Checked)
            {
                query = @"select T.Site_Location as Yard, E.[Type], T.Punch_Type,FORMAT(SUM(DATEDIFF(MINUTE, t.Start_Time_Date, t.End_Time_Date))/60.0,'N','en-us') AS [Hours]
                        from Time_Sheet T
                        inner join Employees E on E.ID = T.UserID
                        where (T.Start_Time_Date >= '" + startDateTimePicker.Value.Date.ToString("yyyy-MM-dd 00:00:00") + "' and T.End_Time_Date <= '" + endDateTimePicker.Value.Date.ToString("yyyy-MM-dd 23:59:59") + @"')
                        " + Yard + @"
                        " + Type + @"
                        group by T.Site_Location, E.[Type], T.Punch_Type";
            }
            else if (rblHoursPerEmployeeSite.Checked)
            {
                query = @"select E.First_Name + ' ' + E.Last_Name + ' (' + E.Alias + ')' As 'Name Employee',
                        E.[Type], T.Site_Location as Yard, T.Punch_Type,
                        FORMAT(SUM(DATEDIFF(MINUTE, t.Start_Time_Date, t.End_Time_Date))/60.0,'N','en-us') AS 'Hours Worked'
                        from Employees E
                        inner join Time_Sheet T on T.UserID = E.ID
                        where (T.Start_Time_Date >= '" + startDateTimePicker.Value.Date.ToString("yyyy-MM-dd 00:00:00") + "' and T.End_Time_Date <= '" + endDateTimePicker.Value.Date.ToString("yyyy-MM-dd 23:59:59") + @"')
                        " + Yard + @"
                        " + Type + @"
                        group by E.First_Name + ' ' + E.Last_Name + ' (' + E.Alias + ')', E.[Type], T.Site_Location, T.Punch_Type
                        order by E.First_Name + ' ' + E.Last_Name + ' (' + E.Alias + ')', E.[Type], T.Site_Location, T.Punch_Type";
            }

            var objDataReader = db.getDataReader(query, objCommand);
            dgvEmployees.Columns.Clear();
            if (rblHoursPerSite.Checked)
            {
                dgvEmployees.Columns.Add("Yard", "Yard");
                dgvEmployees.Columns.Add("Punch Type", "Punch Type");
                dgvEmployees.Columns.Add("Time", "Time");
                {
                    var withBlock = dgvEmployees;
                    withBlock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    withBlock.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (objDataReader.HasRows)
                {
                    while (objDataReader.Read())
                    {
                        TotalHours = (decimal)((double)TotalHours + Convert.ToDouble(objDataReader[2]));
                        span = TimeSpan.FromHours(Convert.ToDouble(objDataReader[2]));
                        dgvEmployees.Rows.Add(objDataReader[0].ToString(), objDataReader[1].ToString(), (span.Days * 24 + span.Hours).ToString() + "h " + span.Minutes.ToString() + "min");
                    }
                }
            }
            else if (rblHoursPerSiteType.Checked)
            {
                dgvEmployees.Columns.Add("Yard", "Yard");
                dgvEmployees.Columns.Add("Type", "Type");
                dgvEmployees.Columns.Add("Punch Type", "Punch Type");
                dgvEmployees.Columns.Add("Time", "Time");
                {
                    var withBlock1 = dgvEmployees;
                    withBlock1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    withBlock1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (objDataReader.HasRows)
                {
                    while (objDataReader.Read())
                    {
                        TotalHours = (decimal)((double)TotalHours + Convert.ToDouble(objDataReader[3]));
                        span = TimeSpan.FromHours(Convert.ToDouble(objDataReader[3]));
                        dgvEmployees.Rows.Add(objDataReader[0].ToString(), objDataReader[1].ToString(), objDataReader[2].ToString(), (span.Days * 24 + span.Hours).ToString() + "h " + span.Minutes.ToString() + "min");
                    }
                }
            }
            else if (rblHoursPerEmployeeSite.Checked)
            {
                dgvEmployees.Columns.Add("Name Employee", "Name Employee");
                dgvEmployees.Columns.Add("Type", "Type");
                dgvEmployees.Columns.Add("Yard", "Yard");
                dgvEmployees.Columns.Add("Punch Type", "Punch Type");
                dgvEmployees.Columns.Add("Time", "Time");
                {
                    var withBlock2 = dgvEmployees;
                    withBlock2.Columns[0].Width = 450;
                    withBlock2.Columns[1].Width = 80;
                    withBlock2.Columns[2].Width = 80;
                    withBlock2.Columns[3].Width = 150;
                    withBlock2.Columns[4].Width = 80;
                    withBlock2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    withBlock2.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (objDataReader.HasRows)
                {
                    while (objDataReader.Read())
                    {
                        TotalHours = (decimal)((double)TotalHours + Convert.ToDouble(objDataReader[4]));
                        span = TimeSpan.FromHours(Convert.ToDouble(objDataReader[4]));
                        dgvEmployees.Rows.Add(objDataReader[0].ToString(), objDataReader[1].ToString(), objDataReader[2].ToString(), objDataReader[3].ToString(), (span.Days * 24 + span.Hours).ToString() + "h " + span.Minutes.ToString() + "min");
                    }
                }
            }

            objDataReader.Close();
            objCommand.Dispose();
            spanhours = TimeSpan.FromHours((double)TotalHours);
            int Min = 0;
            switch (Convert.ToInt16(spanhours.Minutes))
            {
                case var @case when 0 <= @case && @case <= 15:
                    {
                        Min = Conversions.ToInteger("15");
                        break;
                    }

                case var case1 when 16 <= case1 && case1 <= 30:
                    {
                        Min = Conversions.ToInteger("30");
                        break;
                    }

                case var case2 when 31 <= case2 && case2 <= 45:
                    {
                        Min = Conversions.ToInteger("45");
                        break;
                    }

                default:
                    {
                        Min = Conversions.ToInteger("45");
                        break;
                    }
            }

            lblTotHours.Text = (spanhours.Days * 24 + spanhours.Hours).ToString() + " h " + Min.ToString() + " min";
        }

        private void LoadReport()
        {
            var dt = new DataTable();
            ReportDocument reportDocument;
            try
            {
                if (rblHoursPerSite.Checked)
                {
                    dt.Columns.Add("Yard");
                    dt.Columns.Add("Punch Type");
                    dt.Columns.Add("Time");
                    foreach (DataGridViewRow dgr in dgvEmployees.Rows)
                        dt.Rows.Add(dgr.Cells[0].Value, dgr.Cells[1].Value, dgr.Cells[2].Value);
                    reportDocument = new rptHoursWorkedYard();
                    reportDocument.SetDataSource(dt);
                    My.MyProject.Forms.frmHoursWorkedYard.CrystalReportViewer1.ReportSource = reportDocument;
                    TextObject txtObjDisplay = (TextObject)reportDocument.ReportDefinition.ReportObjects["txoTotDisplay"];
                    txtObjDisplay.Text = "Total";
                    TextObject txtObj = (TextObject)reportDocument.ReportDefinition.ReportObjects["txoTotal"];
                    txtObj.Text = lblTotHours.Text;
                    reportDocument.SummaryInfo.ReportTitle = "Work Hours per Yard";
                    My.MyProject.Forms.frmHoursWorkedYard.ShowDialog();
                    My.MyProject.Forms.frmHoursWorkedYard.Dispose();
                }
                else if (rblHoursPerSiteType.Checked)
                {
                    dt.Columns.Add("Yard");
                    dt.Columns.Add("Type");
                    dt.Columns.Add("Punch Type");
                    dt.Columns.Add("Time");
                    foreach (DataGridViewRow dgr in dgvEmployees.Rows)
                        dt.Rows.Add(dgr.Cells[0].Value, dgr.Cells[1].Value, dgr.Cells[2].Value, dgr.Cells[3].Value);
                    reportDocument = new rptHoursWorkedYardType();
                    reportDocument.SetDataSource(dt);
                    My.MyProject.Forms.frmHoursWorkedYard.CrystalReportViewer1.ReportSource = reportDocument;
                    TextObject txtObjDisplay = (TextObject)reportDocument.ReportDefinition.ReportObjects["txoTotDisplay"];
                    txtObjDisplay.Text = "Total";
                    TextObject txtObj = (TextObject)reportDocument.ReportDefinition.ReportObjects["txoTotal"];
                    txtObj.Text = lblTotHours.Text;
                    reportDocument.SummaryInfo.ReportTitle = "Work Hours per Yard and Type";
                    My.MyProject.Forms.frmHoursWorkedYard.ShowDialog();
                    My.MyProject.Forms.frmHoursWorkedYard.Dispose();
                }
                else if (rblHoursPerEmployeeSite.Checked)
                {
                    dt.Columns.Add("Name Employee");
                    dt.Columns.Add("Yard");
                    dt.Columns.Add("Type");
                    dt.Columns.Add("Punch Type");
                    dt.Columns.Add("Time");
                    foreach (DataGridViewRow dgr in dgvEmployees.Rows)
                        dt.Rows.Add(dgr.Cells[0].Value, dgr.Cells[1].Value, dgr.Cells[2].Value, dgr.Cells[3].Value, dgr.Cells[4].Value);
                    reportDocument = new rptHoursWorkedEmployee1();
                    reportDocument.SetDataSource(dt);
                    My.MyProject.Forms.frmHoursWorkedYard.CrystalReportViewer1.ReportSource = reportDocument;
                    TextObject txtObjDisplay = (TextObject)reportDocument.ReportDefinition.ReportObjects["txoTotDisplay"];
                    txtObjDisplay.Text = "Total";
                    TextObject txtObj = (TextObject)reportDocument.ReportDefinition.ReportObjects["txoTotal"];
                    txtObj.Text = lblTotHours.Text;
                    reportDocument.SummaryInfo.ReportTitle = "Work Hours per Employee";
                    My.MyProject.Forms.frmHoursWorkedYard.ShowDialog();
                    My.MyProject.Forms.frmHoursWorkedYard.Dispose();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("There was a small error in the filters, please try again. If the error persists, contact the IT area and report the error.");
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHours();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}