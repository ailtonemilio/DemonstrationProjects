using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmEDIPerformanceAudit
    {
        public frmEDIPerformanceAudit()
        {
            InitializeComponent();
            _btnSearch.Name = "btnSearch";
            _btnPrintReport.Name = "btnPrintReport";
            _dgvEDI.Name = "dgvEDI";
            _btnExporToCSV.Name = "btnExporToCSV";
            _txtTransaction.Name = "txtTransaction";
            _txtEDIDelay.Name = "txtEDIDelay";
            _txtInOut.Name = "txtInOut";
            _txtInput.Name = "txtInput";
            _txtRequest.Name = "txtRequest";
            _txtEDIPush.Name = "txtEDIPush";
            _txtSSLineCode.Name = "txtSSLineCode";
            _txtContainerNumber.Name = "txtContainerNumber";
            _txtSSLineName.Name = "txtSSLineName";
            _txtBookingNumber.Name = "txtBookingNumber";
        }

        private WaitLoadingRun waitLoading = new WaitLoadingRun();
        private string OrderByGlobal = "";
        private bool AscGlobal = true;
        private bool Booking = true;
        private bool SS_Line_Code = true;
        private bool SS_Line = true;
        private bool ContainerNumber = true;
        private bool Transaction = true;
        private bool EDI_Push = true;
        private bool Request = true;
        private bool Input = true;
        private bool In_Out = true;
        private bool EDI_Delay = false;
        private List<Containers_In_OutReport> listReport;
        private List<Containers_In_OutReport> listByColumn;
        private List<Containers_In_OutReport> listAsc;

        private void frmEDIPerformanceAudit_Load(object sender, EventArgs e)
        {
            Search();
            CompaniesNameBindingSource.DataSource = CompanyService.GetCompaniesDropBoxByType("Steamship Line", true);
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            waitLoading.Show();
            Search();
            waitLoading.Close();
        }

        private void btnExporToCSV_Click(object sender, EventArgs e)
        {
            waitLoading.Show();
            var rows1 = dgvEDI.Rows;
            var headers = (from header in dgvEDI.Columns.Cast<DataGridViewColumn>()
                           select header.HeaderText).ToArray();
            var rows = from row in dgvEDI.Rows.Cast<DataGridViewRow>()
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

            waitLoading.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            waitLoading.Show();
            string A = txtStartDate.Value.ToString("yyyy/MM/dd") + " 00:00:00";
            var SDate = Convert.ToDateTime(A);
            A = txtEndDate.Value.ToString("yyyy/MM/dd") + " 23:59:59";
            var EDate = Convert.ToDateTime(A);
            var totAVG = lblTotalAVG.Text.Split(new char[] { ':' });
            My.MyProject.Forms.frmEDIPerformanceAuditReport.LoadForm(SDate, EDate, totAVG[1], listByColumn);
            My.MyProject.Forms.frmEDIPerformanceAuditReport.Show();
            waitLoading.Close();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void dgvEDI_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var Cell_AVG_Delay = dgvEDI.Rows[e.RowIndex].Cells["AVG_Delay"];
            string[] d2 = (string[])Cell_AVG_Delay.Value.ToString().Split('h');
            int dh = Convert.ToInt32(d2[0]);
            if (dh >= 3 & dh < 5)
            {
                Cell_AVG_Delay.Style.BackColor = Color.Yellow;
            }

            if (dh >= 5 & dh < 12)
            {
                Cell_AVG_Delay.Style.BackColor = Color.Orange;
            }

            if (dh > 12)
            {
                Cell_AVG_Delay.Style.BackColor = Color.Red;
            }

            var CellInputSource = dgvEDI.Rows[e.RowIndex].Cells["InputSource"];
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CellInputSource.Value.ToString().Substring(0, 6), "MANUAL", false)))
            {
                CellInputSource.Style.BackColor = Color.DodgerBlue;
            }
        }

        private void dgvEDI_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderByGlobal = dgvEDI.Columns[e.ColumnIndex].Name.ToString();
            switch (dgvEDI.Columns[e.ColumnIndex].Name.ToString() ?? "")
            {
                case "Booking_Number":
                    {
                        // OrderBy(dgvEDI.Columns(e.ColumnIndex).Name.ToString(), ContainerNumber)
                        if (Booking)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Booking = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Booking = true;
                        }

                        break;
                    }

                case "SS_Line_Code_In":
                    {
                        if (SS_Line_Code)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            SS_Line_Code = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            SS_Line_Code = true;
                        }

                        break;
                    }

                case "SS_Line_Name_In":
                    {
                        if (SS_Line)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            SS_Line = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            SS_Line = true;
                        }

                        break;
                    }

                case "Container_Number":
                    {
                        if (ContainerNumber)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            ContainerNumber = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            ContainerNumber = true;
                        }

                        break;
                    }

                case "Gate_Date_In":
                    {
                        if (Transaction)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Transaction = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Transaction = true;
                        }

                        break;
                    }

                case "Gate_EDI_Date":
                    {
                        if (EDI_Push)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            EDI_Push = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            EDI_Push = true;
                        }

                        break;
                    }

                case "RequestDate":
                    {
                        if (Request)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Request = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Request = true;
                        }

                        break;
                    }

                case "InputSource":
                    {
                        if (Input)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Input = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            Input = true;
                        }

                        break;
                    }

                case "Gate_Type":
                    {
                        if (In_Out)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            In_Out = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            In_Out = true;
                        }

                        break;
                    }

                case "AVG_Delay":
                    {
                        if (EDI_Delay)
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            EDI_Delay = false;
                        }
                        else
                        {
                            var L = from b in listByColumn
                                    select b;
                            ContainersInOutReportBindingSource.DataSource = L.ToList();
                            listByColumn = L.ToList();
                            EDI_Delay = true;
                        }

                        break;
                    }
            }

            CalculateTotalAVG();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void Search()
        {
            string A = txtStartDate.Value.ToString("yyyy/MM/dd") + " 00:00:00";
            var SDate = Convert.ToDateTime(A);
            A = txtEndDate.Value.ToString("yyyy/MM/dd") + " 23:59:59";
            var EDate = Convert.ToDateTime(A);
            listReport = Containers_In_OutService.GetByInOutGateByReportDateRange(SDate, EDate);
            ContainersInOutReportBindingSource.DataSource = listReport.ToList();
            SearcByColumn();
            CalculateTotalAVG();
        }

        private void SearcByColumn()
        {
            var L = from b in listReport
                    where b.Booking_Number.StartsWith(txtBookingNumber.Text) & b.SS_Line_Code_In.StartsWith(txtSSLineCode.Text) & b.SS_Line_Name_In.StartsWith(txtSSLineName.Text) & b.Container_Number.StartsWith(txtContainerNumber.Text) & b.Gate_Date_In.StartsWith(txtTransaction.Text) & b.Gate_EDI_Date.StartsWith(txtEDIPush.Text) & b.RequestDate.StartsWith(txtRequest.Text) & b.InputSource.StartsWith(txtInput.Text) & b.Gate_Type.StartsWith(txtInOut.Text) & b.AVG_Delay.StartsWith(txtEDIDelay.Text)
                    select b;
            ContainersInOutReportBindingSource.DataSource = L.ToList();
            listByColumn = L.ToList();
        }

        private void CalculatePercent()
        {
            int TR = dgvEDI.Rows.Count;
            int QtdBlank = 0;
            int QtdYellow = 0;
            int QtdOrange = 0;
            int QtdRed = 0;
            int h = 0;
            foreach (DataGridViewRow row in dgvEDI.Rows)
            {
                var d2 = row.Cells[9].Value.ToString().Split(' ');
                h = Convert.ToInt32(d2[0].ToString().Remove(d2[0].ToString().Length - 1));
                if (h <= 2)
                {
                    QtdBlank = QtdBlank + 1;
                }

                if (h >= 3 & h < 5)
                {
                    QtdYellow = QtdYellow + 1;
                }

                if (h >= 5 & h < 12)
                {
                    QtdOrange = QtdOrange + 1;
                }

                if (h > 12)
                {
                    QtdRed = QtdRed + 1;
                }
            }

            lblPercentBlank.Text = (QtdBlank / (double)TR * 100d).ToString("#0.00") + " %";
            lblPercentYellow.Text = (QtdYellow / (double)TR * 100d).ToString("#0.00") + " %";
            lblPercentOrange.Text = (QtdOrange / (double)TR * 100d).ToString("#0.00") + " %";
            lblPercentRed.Text = (QtdRed / (double)TR * 100d).ToString("#0.00") + " %";
        }

        private void CalculateTotalAVG()
        {
            int Th = 0;
            int Tm = 0;
            int Ts = 0;
            string h = "0";
            string m = "0";
            string s = "0";
            foreach (DataGridViewRow row in dgvEDI.Rows)
            {
                var d2 = row.Cells[9].Value.ToString().Split(' ');
                h = d2[0].ToString().Remove(d2[0].ToString().Length - 1);
                m = d2[1].ToString().Remove(d2[1].ToString().Length - 1);
                s = d2[2].ToString().Remove(d2[2].ToString().Length - 1);
                Ts = (int)Math.Round(Ts + Conversions.ToDouble(s) + Conversions.ToDouble(m) * 60d + Conversions.ToDouble(h) * 3600d);
            }

            if (dgvEDI.Rows.Count > 0)
            {
                Ts = (int)Math.Round(Ts / (double)dgvEDI.Rows.Count);
            }

            Tm = (int)Math.Round(Ts / 60d);
            Ts = Ts % 60;
            Th = (int)Math.Round(Tm / 60d);
            Tm = Tm % 60;
            lblTotalAVG.Text = "Average EDI Delay: " + Th.ToString() + "h " + Tm.ToString() + "m " + Ts.ToString() + "s";
            txtQtyContainer.Text = "Qty. Containers: " + dgvEDI.Rows.Count.ToString();
            CalculatePercent();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void txtBookingNumber_TextChange(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtSSLineCode_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtSSLineName_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtContainerNumber_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtTransaction_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtEDIPush_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtRequest_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtInOut_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        private void txtEDIDelay_TextChanged(object sender, EventArgs e)
        {
            waitLoading.Show();
            SearcByColumn();
            CalculateTotalAVG();
            waitLoading.Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}