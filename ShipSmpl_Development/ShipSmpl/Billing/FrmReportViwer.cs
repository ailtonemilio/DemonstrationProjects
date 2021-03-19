using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ShipSmpl.Billing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmReportViwer
    {
        public FrmReportViwer()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
        }

        private string[] servicesList;
        private DataSetSummaryReport.DTSummaryDataTable summaryDT = new DataSetSummaryReport.DTSummaryDataTable();
        private DataSetSummaryReport.DTServPortSummaryDataTable summaryServicesDT = new DataSetSummaryReport.DTServPortSummaryDataTable();
        private DataSetSummaryReport.DEFCSummaryDataTable summaryFSCReport = new DataSetSummaryReport.DEFCSummaryDataTable();
        private DataSetSummaryReport.CarrierDataTable carrierDt = new DataSetSummaryReport.CarrierDataTable();
        public decimal totalRVFees = 0m;
        private decimal totalDrayage = 0m;
        private decimal totalFSCAfterTax = 0m;
        private DataSetSummaryReport.DtRVSummatyDataTable summaryTFCReport = new DataSetSummaryReport.DtRVSummatyDataTable();
        private CrystalTruckingReport reportSource = new CrystalTruckingReport();

        // Dim truckingName As New DataSetSummaryReport.TruckingCompanyDataTable
        public DataTable tempTable = new DataTable();

        private void FrmReportViwer_Load(object sender, EventArgs e)
        {
            // CrystalReportViewer1.
            totalRVFees = 0m;
            getSummaryReport();
            getSummaryByService();
            getFSCReport();
            totalDrayage = 0m;
            GetSelectedCarriers(reportSource);
            reportSource.Database.Tables["DtRVSummaty"].SetDataSource(summaryTFCReport.CopyToDataTable());
            reportSource.Database.Tables["DTSummary"].SetDataSource(summaryDT.CopyToDataTable());
            reportSource.Database.Tables["DTServPortSummary"].SetDataSource(summaryServicesDT.CopyToDataTable());
            reportSource.Database.Tables["DTFSCSummary"].SetDataSource(summaryFSCReport.CopyToDataTable());
            reportSource.Database.Tables["Carrier"].SetDataSource(carrierDt.CopyToDataTable());
            reportSource.DataDefinition.FormulaFields["total"].Text = "$" + (Conversions.ToDouble(My.MyProject.Forms.FrmTruckingRecon.totalaftTaxesLabel.Text.Replace("$", "")) + 0d).ToString();
            CrystalReportViewer1.ReportSource = reportSource;
        }

        private void getSummaryReport()
        {
            var StringAlign = new StringFormat();
            var serviceMonths = new List<DateTime>();
            DateTime startDate;

            FrmTruckingRecon f = new FrmTruckingRecon();

            if (My.MyProject.Forms.FrmTruckingRecon.dgvTest.Rows.Count > 0)
            { //todo
                //servicesList = (from row in FrmTruckingRecon.dgvTest.Rows
                //                where !row.IsNewRow
                //                select Conversions.ToString(row.Cells[2].Value)).Distinct().ToArray();
            }

            summaryDT.Rows.Clear();
            startDate = My.MyProject.Forms.FrmTruckingRecon.fromDatePicker.Value.Date;
            while (startDate <= My.MyProject.Forms.FrmTruckingRecon.toIDatePicker.Value.Date)
            {
                serviceMonths.Add(startDate.AddMonths(1));
                startDate = startDate.AddMonths(1);
            }

            foreach (var focusedMonthDate in serviceMonths)
            {
                foreach (var service in servicesList)
                {
                    var newRow = summaryDT.NewDTSummaryRow();
                    newRow.Service_Name = "Drayage Report - " + service;
                    newRow.Month = focusedMonthDate.ToString("MMMM");
                    newRow.Trucker = My.MyProject.Forms.FrmTruckingRecon.cboTruckingCompany.SelectedText;
                    {
                        var withBlock = My.MyProject.Forms.FrmTruckingRecon;
                        if (service.Equals("Multi Empty"))
                        {
                            newRow.ServiceType = "Empty";
                            newRow.Quantity = Conversions.ToInteger(withBlock.totalMultiEptyLabel.Text);
                            // newRow.Rate = .rateBMultEptyLabel.Text
                            newRow.Total = Conversions.ToDecimal(withBlock.ratetotalMultiEptyLabel.Text.Replace("$", ""));
                        }
                        else if (service.Equals("Single Empty"))
                        {
                            newRow.Quantity = Conversions.ToInteger(withBlock.totalSingleEptyLabel.Text);
                            newRow.ServiceType = "Empty";
                            // newRow.Rate = .rateBSingleEptyLabel.Text

                            newRow.Total = Conversions.ToDecimal(withBlock.ratetotalSingleEptyLabel.Text.Replace("$", ""));
                        }
                        else if (service.Equals("Multi Load"))
                        {
                            newRow.ServiceType = "Load";
                            newRow.Quantity = Conversions.ToInteger(withBlock.totalMultiLoadLabel.Text);
                            // newRow.Rate = .rateBMultiLoadLabel.Text
                            newRow.Total = Conversions.ToDecimal(withBlock.ratetotalMultiLoadLabel.Text.Replace("$", ""));
                        }
                        else if (service.Equals("Single Load"))
                        {
                            newRow.ServiceType = "Load";
                            newRow.Quantity = Conversions.ToInteger(withBlock.totalSingleLoadLabel.Text);
                            // newRow.Rate = .rateBSingleLoadsLabel.Text
                            newRow.Total = Conversions.ToDecimal(withBlock.ratetotalSingleLoadLabel.Text.Replace("$", ""));
                        }

                        newRow.Rate = "...";
                    }

                    summaryDT.AddDTSummaryRow(newRow);
                }
            }
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void getSummaryByService()
        {
            DataTable deliveredPortsEpty;
            DataTable deliveredPortsLoad;
            string[] portName;
            int qty;
            DataTable rateService = new DataTable(), tempTable = new DataTable();
            var yardInDT = new DataTable();
            decimal Rate;
            decimal total;
            decimal totalSum;
            int countTable;
            var query = new DataTable();
            string terminalName;
            string rateType;
            DateTime dateTime;
            DayOfWeek day;
            decimal dayRate;
            decimal nightRate;
            TimeSpan cutOffTime;
            int rvID = 1;
            tempTable.Clear();
            summaryServicesDT.Rows.Clear();
            summaryTFCReport.Rows.Clear();
            totalRVFees = 0m;
            {
                var withBlock = My.MyProject.Forms.FrmTruckingRecon;
                // -------Conver DatagridViewReport to a tempDataTable ---------------
                foreach (DataGridViewColumn column in withBlock.dgvTest.Columns)
                    tempTable.Columns.Add(column.HeaderText);

                // Adding the Rows.
                foreach (DataGridViewRow row in withBlock.dgvTest.Rows)
                {
                    tempTable.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        var val = cell.Value;
                        if (!Information.IsNothing(val))
                        {
                            tempTable.Rows[tempTable.Rows.Count - 1][cell.ColumnIndex] = val;
                        }
                        else
                        {
                            tempTable.Rows[tempTable.Rows.Count - 1][cell.ColumnIndex] = 0;
                        }
                    }
                }

                var reports = withBlock.dgvTest.Rows;
                deliveredPortsEpty = tempTable.DefaultView.ToTable(true, "Drop Off");
                yardInDT = tempTable.DefaultView.ToTable(true, "Pick Up");
                countTable = withBlock.dgvTest.Rows.Count;
                for (int i = 0, loopTo = withBlock.dgvTest.Rows.Count - 1; i <= loopTo; i++)
                {
                    string cost;
                    string status;
                    string pickUp;
                    string dropOff;
                    var selectedRow = withBlock.dgvTest.Rows[i];
                    cost = selectedRow.Cells[1].Value.ToString().Replace("$", "");
                    status = Strings.Trim(Conversions.ToString(selectedRow.Cells[2].Value));
                    pickUp = Strings.Trim(Conversions.ToString(selectedRow.Cells[5].Value));
                    dropOff = Strings.Trim(Conversions.ToString(selectedRow.Cells[6].Value));
                    dateTime = Convert.ToDateTime(selectedRow.Cells[7].Value);
                    var newRow = summaryServicesDT.NewDTServPortSummaryRow();
                    Rate = Conversions.ToDecimal(selectedRow.Cells[1].Value.ToString().Replace("$", ""));
                    newRow.Service_Name = status;
                    newRow.Quantity = 1;
                    newRow.Rate = Conversions.ToDecimal(cost);
                    newRow.Yarn_In = pickUp;
                    newRow.Port_Out = dropOff;
                    summaryServicesDT.AddDTServPortSummaryRow(newRow);
                    if (status.Contains("Load"))
                    {
                        rateType = "Load";
                    }
                    else
                    {
                        rateType = "Empty";
                    }

                    foreach (DataRow tef in withBlock.TEFDT.Rows)
                    {
                        var newRowTEF = summaryTFCReport.NewDtRVSummatyRow();
                        terminalName = Strings.Trim(tef["Terminal"].ToString().Split(')')[0].Replace("(", ""));
                        if ((terminalName.Equals(pickUp) | terminalName.Equals(dropOff)) & rateType.Equals(tef["RateType"]))
                        {
                            // If Weekend, apply rates and cut of of weekend
                            if (dateTime.DayOfWeek == DayOfWeek.Saturday | dateTime.DayOfWeek == DayOfWeek.Sunday)
                            {
                                newRowTEF.WeekMode = "Weekends";
                                if (!Information.IsDBNull(tef["WkEndsCutOffTime"]))
                                {
                                    cutOffTime = (TimeSpan)tef["WkEndsCutOffTime"];
                                    newRowTEF.CutOffTime = cutOffTime;
                                    if (dateTime.TimeOfDay <= cutOffTime)
                                    {
                                        newRowTEF.Rate = Conversions.ToDecimal(tef["WkEndsDayRate"]);
                                        newRowTEF.DayMode = "Before Cut Off";
                                    }
                                    else
                                    {
                                        newRowTEF.Rate = Conversions.ToDecimal(tef["WkEndsNightRate"]);
                                        newRowTEF.DayMode = "After Cut Off";
                                    }
                                }
                                else
                                {
                                    // if no cut off, rate for day and night are the same
                                    newRowTEF.Rate = Conversions.ToDecimal(tef["WkEndsDayRate"]);
                                    newRowTEF.DayMode = "";
                                }
                            }
                            else
                            {
                                newRowTEF.WeekMode = "Weekdays";
                                // If there's a cut off time
                                if (!Information.IsDBNull(tef["WkDaydCutOffTime"]))
                                {
                                    cutOffTime = (TimeSpan)tef["WkDaydCutOffTime"];
                                    newRowTEF.CutOffTime = cutOffTime;
                                    if (dateTime.TimeOfDay <= cutOffTime)
                                    {
                                        newRowTEF.Rate = Conversions.ToDecimal(tef["WkDaysDayRate"]);
                                        newRowTEF.DayMode = "Before Cut Off";
                                    }
                                    else
                                    {
                                        newRowTEF.Rate = Conversions.ToDecimal(tef["WkDaysNightRate"]);
                                        newRowTEF.DayMode = "After Cut Off";
                                    }
                                }
                                else
                                {
                                    // if no cut off, rate for day and night are the same
                                    newRowTEF.Rate = Conversions.ToDecimal(tef["WkEndsDayRate"]);
                                    newRowTEF.DayMode = "";
                                }
                            }

                            totalRVFees += newRowTEF.Rate;
                            newRowTEF.Terminal = Conversions.ToString(tef["Terminal"]);
                            newRowTEF.RateType = rateType;
                            newRowTEF.RVSummaryID = rvID;
                            newRowTEF.Qty = 1;
                            try
                            {
                                summaryTFCReport.AddDtRVSummatyRow(newRowTEF);
                            }
                            catch (Exception ex)
                            {
                                Debugger.Break();
                            }

                            rvID += 1;
                        }
                    }
                }
            }
        }

        private void getFSCReport()
        {
            DataRow serviceRow;
            summaryFSCReport.Rows.Clear();
            {
                var withBlock = My.MyProject.Forms.FrmTruckingRecon;
                foreach (DataRow addedService in My.MyProject.Forms.FrmTruckingRecon.FSC_Rate.Rows)
                {
                    decimal rate = Conversions.ToDecimal(addedService["Rate"]);
                    if (addedService["Rate_Name"].Equals("FSC"))
                    {
                        // serviceRow = .getRate(.FSC_TEF_Rate, addedService.Cells(1).Value)
                        var newRow = summaryFSCReport.NewDEFCSummaryRow();
                        newRow.Fee_Name = "Fuel Surcharge: " + addedService["Rate"].ToString() + "%";
                        newRow.Rate = Conversions.ToDecimal(addedService["Rate"]);
                        totalFSCAfterTax = Conversions.ToDecimal(Operators.DivideObject(Operators.MultiplyObject(addedService["Rate"], totalDrayage), 100));
                        summaryFSCReport.AddDEFCSummaryRow(newRow);
                    }
                }
            }
        }

        private void GetSelectedCarriers(CrystalTruckingReport reportSource)
        {
            carrierDt.Clear();
            var carrierList = My.MyProject.Forms.FrmTruckingRecon.dgvExtraCarriers;
            var newRow = carrierDt.NewCarrierRow();
            newRow.CarrierName = My.MyProject.Forms.FrmTruckingRecon.cboTruckingCompany.Text;
            carrierDt.AddCarrierRow(newRow);
            VW_CompanyCompanyType carrierSelected;
            foreach (DataGridViewRow row in My.MyProject.Forms.FrmTruckingRecon.dgvExtraCarriers.Rows)
            {
                newRow = carrierDt.NewCarrierRow();
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[0].Value, true, false)))
                {
                    carrierSelected = (VW_CompanyCompanyType)row.DataBoundItem;
                    newRow.CarrierName = carrierSelected.CompanyName;
                    carrierDt.AddCarrierRow(newRow);
                }
            }

            Subreports headerSubReprt;  // As CrystalDecisions.CrystalReports.Engine.ReportDocument
            DateTime fromDate, toDate, booking; // As ParameterFieldDefinition
            headerSubReprt = reportSource.Subreports;
            // TODO
            //fromDate = headerSubReprt[0].ReportDefinition.ReportObjects("txtFromDate");
            //toDate = headerSubReprt[0].ReportDefinition.ReportObjects("txtToDate");
            //booking = headerSubReprt[0].ReportDefinition.ReportObjects("txtBooking");
            //{
            //    var withBlock = My.MyProject.Forms.FrmTruckingRecon;
            //    if (!withBlock.fromDatePicker.CustomFormat.Equals(""))
            //    {
            //        fromDate.Text = withBlock.fromDatePicker.Value.ToString("dd-MMMM-yyyy");
            //        toDate.Text = withBlock.toIDatePicker.Value.ToString("dd-MMMM-yyyy");
            //    }
            //    else
            //    {
            //        fromDate.Text = "N/A";
            //        toDate.Text = "N/A";
            //    }

            //    string bkText = Strings.Trim(withBlock.cboBookingNumber.Text);
            //    if (!bkText.Equals("ALL"))
            //    {
            //        booking.Text = withBlock.cboBookingNumber.Text;
            //    }
            //    else
            //    {
            //        booking.Text = "N/A";
            //    }
            //}
        }
    }
}