using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmTruckingRecon
    {
        public FrmTruckingRecon()
        {
            InitializeComponent();
            _exportButton.Name = "exportButton";
            _BunifuFlatButton1.Name = "BunifuFlatButton1";
            _btnOkExtraCarriers.Name = "btnOkExtraCarriers";
            _dgvExtraCarriers.Name = "dgvExtraCarriers";
            _closeFlatButton.Name = "closeFlatButton";
            _dgvTest.Name = "dgvTest";
            _addedServDataGridView.Name = "addedServDataGridView";
            _btnAddCarrier.Name = "btnAddCarrier";
            _btnRemoveDate.Name = "btnRemoveDate";
            _cboMultiEmpty.Name = "cboMultiEmpty";
            _cboSingleLoad.Name = "cboSingleLoad";
            _cboMultiLoad.Name = "cboMultiLoad";
            _cbxSingleEmpty.Name = "cbxSingleEmpty";
            _cboDropOff.Name = "cboDropOff";
            _cboPickUp.Name = "cboPickUp";
            _cboBookingNumber.Name = "cboBookingNumber";
            _fromDatePicker.Name = "fromDatePicker";
            _cboTruckingCompany.Name = "cboTruckingCompany";
            _searchBunifuTextBox1.Name = "searchBunifuTextBox1";
            _BunifuButton2.Name = "BunifuButton2";
            _printButton.Name = "printButton";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        public DataTable drayageRates = new DataTable();
        public DataTable FSC_Rate = new DataTable();
        public DataTable reportDTEpty = new DataTable();
        public DataTable reportDTLoad = new DataTable();
        private bool firstLoad;
        public DataTable inOutReport = new DataTable();
        public DataTable TEFDT = new DataTable();
        public decimal totalAfterTaxes = 0m;
        public DataTable tempTable = new DataTable();
        public List<VW_ContainersInOutDrayage> reportList = new List<VW_ContainersInOutDrayage>();
        private List<string> SelectedCarrierCodeList = new List<string>();
        private int emptyNumb = 0;
        private int loadsNum = 0;
        private int singleLoad = 0;
        private int singleEmpty = 0;
        private decimal rateSingleEpty = 0m;
        private decimal rateMultiEpty = 0m;
        private decimal rateMultiLoads = 0m;
        private decimal rateSingleLoad = 0m;

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmServices, My.MyProject.Forms.FrmParentScreen);
        }

        private void FrmTruckingRecon_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
            firstLoad = false;
        }

        private void loadComboBoxes()
        {
            CompanyService.GetAll();
            try
            {
                panelCarriers.Hide();
                object truckingCompanies;
                object terminalsPickUp;
                object terminalsDropOff;
                using (var db = new WTCCeresEntities())
                {
                    truckingCompanies = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Drayage_Provider, db);
                    terminalsPickUp = CompanyService.GetAllByType(((int)MdlEnum.CompanyType.Container_Terminal).ToString(), db);
                    terminalsDropOff = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Container_Terminal, db);
                }

                var driverId = TruckDriversService.GetAll();
                var tr = new Company();
                var dtid = new Truck_Drivers();
                dtid.Port_Pass_ID = "";
                driverId.Insert(0, dtid);
                var bookingsDT = new DataTable();
                firstLoad = true;
                var cp = new Company();
                using (var db = new WTCCeresEntities())
                {
                    dgvExtraCarriers.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Drayage_Provider, db).Where(c => c.CompanyId != 0).ToList();
                }

                cboTruckingCompany.DataSource = truckingCompanies;
                cboPickUp.DataSource = terminalsPickUp;
                cboDropOff.DataSource = terminalsDropOff;
                cboDriverId.DataSource = driverId;
                cboPickUp.SelectedValue = "";
                cboDropOff.SelectedValue = "";
                cboDriverId.SelectedValue = "";
                string truckComp = "(" + Strings.Trim(Conversions.ToString(cboTruckingCompany.SelectedValue)) + ") " + Strings.Trim(cboTruckingCompany.SelectedText);
                cboTruckingCompany.DropDownHeight = Height - 200;
                string query = @"  select * from (select distinct(Trim([Release Number])) as fileNumber from [Containers In-Out] where [Release Number] is not null and [Release Number] <> ''
  union
  select distinct(Trim([BookingNumber])) as fileNumber from booking where [BookingNumber] is not null and [BookingNumber] <> '') fn
  order by fileNumber";
                bookingsDT = dbCeres.getDataByQuery(query);
                var newrow = bookingsDT.NewRow();
                newrow["fileNumber"] = " ALL";
                bookingsDT.Rows.Add(newrow);
                cboBookingNumber.Items.Clear();
                cboBookingNumber.Items.Add("ALL");
                foreach (DataRow booking in bookingsDT.Rows)
                    cboBookingNumber.Items.Add(booking["fileNumber"]);
                cboBookingNumber.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }

        private void populateServices()
        {
            addedServDataGridView.Rows.Clear();
            string condition = "";
            // Get Drayages
            foreach (DataRow service in drayageRates.Rows)
            {
                decimal defaultRate = Convert.ToDecimal(service["Rate"]);
                bool servAdded = false;
                string servName = Conversions.ToString(Operators.AddObject("Drayage: ", service["RateType"])); // + " - $" + defaultRate.ToString("F2")
                servAdded = false;
                for (int i = 0, loopTo = addedServDataGridView.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (addedServDataGridView.Rows[i].Cells[2].Value.Equals(servName))
                    {
                        servAdded = true;
                        break;
                    }
                }

                if (servAdded == false)
                {
                    addedServDataGridView.Rows.Add("Drayage", service["DrayageRateId"], servName);
                }
            }

            foreach (DataRow rateRow in FSC_Rate.Rows)
            {
                DateTime fromMonth = Conversions.ToDate(rateRow["From_Date"]);
                string rateName = "";
                string rateType;
                decimal rate = Conversions.ToDecimal(rateRow["Rate"]);
                rateType = "FSC";
                rateName = "Fuel Surcharge (" + fromMonth.ToString("MMMM") + "): " + rateRow["Rate"].ToString() + "%";
                addedServDataGridView.Rows.Add(rateType, rateRow["ID"], rateName);
            }
        }

        private void populateReport(string code)
        {
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // Dim headers = (From header As DataGridViewColumn In dgvTest.Columns.Cast(Of DataGridViewColumn)()
            // Select header.HeaderText).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray
            // headers = headers.Except({headers(4)}).ToArray

            // Dim rows = From row As DataGridViewRow In dgvTest.Rows.Cast(Of DataGridViewRow)()
            // Where Not row.IsNewRow
            // Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot DBNull.Value, c.Value.ToString, c.Value.ToString))

            try
            {
                // Dim fileName As String = Now.ToString("Reconciliation_Report_dd-MMM-yyyy-HHMMSS") + ".csv"
                // Using sw As New IO.StreamWriter(fileName)
                // sw.WriteLine(String.Join(",", headers))
                // Dim count As Integer = 0
                // For Each r In rows
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray
                // 'r = r.Except({r(4)}).ToArray

                // sw.WriteLine(String.Join(",", r))
                // count += 1

                // Next
                // End Using
                // Dim p = New Process
                // p.Start(fileName)

                var headers = (from header in dgvTest.Columns.Cast<DataGridViewColumn>()
                               select header.HeaderText).ToArray();
                headers = headers.Except(new[] { headers[11] }).ToArray();
                headers = headers.Except(new[] { headers[13] }).ToArray();
                headers = headers.Except(new[] { headers[0] }).ToArray();
                var rows = from row in dgvTest.Rows.Cast<DataGridViewRow>()
                           where !row.IsNewRow
                           select Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value is object ? c.Value.ToString() : "");
                string fileName = "Reconciliation_Report_" + DateAndTime.Now.ToString("dd-MMM-yyyy_HHMMss") + ".csv";
                using (var sw = new System.IO.StreamWriter(fileName))
                {
                    sw.WriteLine(string.Join(",", headers));
                    foreach (var r in rows)
                    {
                        try
                        {
                            //r = r.Except(new[] { r[11] }).ToArray();
                            //r = r.Except(new[] { r[13] }).ToArray();
                            //r = r.Except(new[] { r[0] }).ToArray();
                            sw.WriteLine(string.Join(",", r));
                        }
                        catch
                        {
                        }
                    }
                }

                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmServices, this);
        }

        private void dispServiceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                populateServices();
            }
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            string code = Conversions.ToString(cboTruckingCompany.SelectedValue);
            reportList.Clear();

            VW_CompanyCompanyType c = (VW_CompanyCompanyType)cboTruckingCompany.SelectedItem;
            if (!SelectedCarrierCodeList.Contains(Strings.Trim(Conversions.ToString(c.CompanyCode))))
            {
                SelectedCarrierCodeList.Add(Strings.Trim(Conversions.ToString(c.CompanyCode)));
            }

            if (!firstLoad)
            {
                MdlLoadingSetting.waitForm.Show();
                if (!Information.IsNothing(cboTruckingCompany.SelectedValue) & goodToGo())
                {
                    if (!fromDatePicker.CustomFormat.Equals(""))
                    {
                        TEFDT = dbCeres.getTableInfo("TEF_Rate", "*", "where FromDate <= '" + Conversions.ToString(fromDatePicker.Value.Date) + "' and (ToDate is null or ToDate <='" + Conversions.ToString(toIDatePicker.Value.Date) + "')");
                        FSC_Rate = dbCeres.getTableInfo("FSC_Rate", "*", " where  From_Date <= '" + Conversions.ToString(fromDatePicker.Value.Date) + "'   And  (To_Date >= '" + Conversions.ToString(toIDatePicker.Value.Date) + "' or To_Date is null) order by From_Date");
                        populateServices();
                    }

                    drayageRates = dbCeres.getTableInfo("DrayageSchemeRate", "*", " where TruckingCompany = '" + Strings.Trim(Conversions.ToString(cboTruckingCompany.SelectedValue)) + "' order by FromDate");
                    var endDate = Convert.ToDateTime(toIDatePicker.Value.Date.ToShortDateString() + " 23:59:59".ToString());
                    var StartDate = Convert.ToDateTime(fromDatePicker.Value.Date.ToShortDateString() + " 00:00:00".ToString());
                    reportList = ContainersInOutDrayageService.GetByDrayageRates(Strings.Trim(Conversions.ToString(cboBookingNumber.SelectedItem)), Strings.Trim(cboPickUp.Text), Strings.Trim(cboDropOff.Text), Strings.Trim(cboDriverId.Text), StartDate, endDate, SelectedCarrierCodeList, streetTurnToggleSwitch.Value, btnRemoveDate.Visible);
                    dgvTest.DataSource = reportList;
                }

                populateReport();
                filterReportTable();
                populateReport();
                updateRatesReport();
            }

            if (dgvTest.Rows.Count > 0)
            {
                printButton.Enabled = true;
            }
            else
            {
                printButton.Enabled = false;
            }

            foreach (DataGridViewColumn column in dgvTest.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            MdlLoadingSetting.waitForm.Close();
        }

        private void populateReport()
        {
            bool isMulti;
            DateTime startRangeTime;
            DateTime endRangeTime;
            DateTime gateDate;
            int totalQty = 0;
            loadsNum = 0;
            singleEmpty = 0;
            emptyNumb = 0;
            singleLoad = 0;
            foreach (var item in reportList)
            {
                try
                {
                    startRangeTime = (DateTime)item.GateDateTime;
                    startRangeTime = startRangeTime.AddMinutes(-140);
                    endRangeTime = (DateTime)item.GateDateTime;
                    endRangeTime = startRangeTime.AddMinutes(140d);
                    gateDate = (DateTime)item.GateDateTime;
                    // gateDate = Convert.ToDateTime(gateDate.ToShortDateString + " " + "23:59:59")

                    isMulti = ContainersInOutDrayageService.isMultiDrayage(item.truckDriverId, gateDate, item.drayageType);
                }
                catch
                {
                    isMulti = false;
                }

                if (item.drayageType.Equals("Empty"))
                {
                    if (isMulti)
                    {
                        item.rateType = "Multi Empty";
                        emptyNumb += 1;
                    }
                    else
                    {
                        item.rateType = "Single Empty";
                        singleEmpty += 1;
                    }
                }
                else if (isMulti)
                {
                    item.rateType = "Multi Load";
                    loadsNum += 1;
                }
                else
                {
                    item.rateType = "Single Load";
                    singleLoad += 1;
                }

                string pick = item.pickUpCode.Trim();
                string drop = item.dropOffCode.Trim();
                if (pick.Equals("") | pick.Equals("N/A") | pick.Equals("0"))
                {
                    item.pickUpCode = "UNKNOWN";
                }

                if (drop.Equals("") | drop.Equals("N/A") | drop.Equals("0"))
                {
                    item.dropOffCode = "UNKNOWN";
                }

                totalQty += 1;
            }

            totalMultiLoadLabel.Text = loadsNum.ToString();
            totalSingleLoadLabel.Text = singleLoad.ToString();
            totalMultiEptyLabel.Text = emptyNumb.ToString();
            totalSingleEptyLabel.Text = singleEmpty.ToString();
            lblqtyEmpty.Text = (emptyNumb + singleEmpty).ToString();
            lblqtyLoads.Text = (singleLoad + loadsNum).ToString();
            totalQtyLbl.Text = totalQty.ToString();
        }

        private void findText()
        {
            for (int i = 0, loopTo = dgvTest.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(dgvTest.Rows[i].Cells[3].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper())))
                {
                    dgvTest.CurrentCell = dgvTest.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void searchBunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            findText();
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fromDatePicker.CustomFormat.Equals(" "))
            {
                fromDatePicker.CustomFormat = "MMM dd, yyyy";
                toIDatePicker.CustomFormat = "MMM dd, yyyy";
            }

            int DaysInMonth = DateTime.DaysInMonth(fromDatePicker.Value.Year, fromDatePicker.Value.Month);
            var LastDayInMonthDate = new DateTime(fromDatePicker.Value.Year, fromDatePicker.Value.Month, DaysInMonth);
            toIDatePicker.Value = LastDayInMonthDate;
            btnRemoveDate.Visible = true;
        }

        private void addedServDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                addedServDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void updateRatesReport()
        {
            DataRow serviceRow;
            var gateTime = new DateTime();
            DateTime servDueTime;
            decimal rate;
            rateMultiEpty = 0m;
            rateSingleEpty = 0m;
            rateMultiLoads = 0m;
            rateSingleLoad = 0m;

            // loop through all in/out gates in datagrid
            foreach (var reportedServ in reportList)
            {
                reportedServ.rate = "$0.00";
                foreach (DataRow addedService in drayageRates.Rows)
                {
                    if (!Information.IsDBNull(addedService["Rate"]))
                    {
                        rate = Convert.ToDecimal(addedService["Rate"]);
                    }
                    else
                    {
                        MessageBox.Show("Rate not set up. Please add a default rate for");
                        return;
                    }

                    string fromCodeDG = Strings.Trim(reportedServ.pickUpCode);
                    string toCodeDG = Strings.Trim(reportedServ.dropOffCode);
                    string fromCodeDT = Strings.Trim(Conversions.ToString(addedService["FromDock"]));
                    string toCodeDT = Strings.Trim(Conversions.ToString(addedService["ToDock"]));
                    if (fromCodeDG.Equals(fromCodeDT) & toCodeDG.Equals(toCodeDT))
                    {
                        if (reportedServ.rateType.Equals("Single Empty") & addedService["RateType"].Equals("Single Empty"))
                        {
                            reportedServ.rate = "$" + rate.ToString("F2");
                            // reportedServ.Cells(8).Value = rate

                            rateSingleEpty += rate;
                        }
                        else if (reportedServ.rateType.Equals("Multi Empty") & addedService["RateType"].Equals("Multi Empty"))
                        {
                            reportedServ.rate = "$" + rate.ToString("F2");
                            // reportedServ.Cells(8).Value = rate

                            rateMultiEpty += rate;
                        }
                        else if (reportedServ.rateType.Equals("Single Load") & addedService["RateType"].Equals("Single Load"))
                        {
                            reportedServ.rate = "$" + rate.ToString("F2");
                            // reportedServ.Cells(8).Value = rate

                            singleLoad += 1;
                            rateSingleLoad += rate;
                        }
                        else if (reportedServ.rateType.Equals("Multi Load") & addedService["RateType"].Equals("Multi Load"))
                        {
                            reportedServ.rate = "$" + rate.ToString("F2");
                            // reportedServ.Cells(8).Value = rate

                            rateMultiLoads += rate;
                        }
                    }
                }
            }

            calculateRates();
        }

        private void cboBookingNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateServices();
        }

        private bool goodToGo()
        {
            try
            {
                if (fromDatePicker.CustomFormat.Equals(" ") & !cboTruckingCompany.SelectedValue.Equals("") & cboBookingNumber.SelectedItem.Equals(" ALL"))
                {
                    warningLabel.Text = "Please inform date range.";
                    fromDatePicker.CustomFormat = " ";
                    toIDatePicker.CustomFormat = " ";
                }
                else if (fromDatePicker.CustomFormat.Equals(" ") | !cboBookingNumber.SelectedItem.Equals(" ALL"))
                {
                    warningLabel.Text = "";
                    fromDatePicker.CustomFormat = " ";
                    toIDatePicker.CustomFormat = " ";
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }

            return default;
        }

        private void btnRemoveDate_Click(object sender, EventArgs e)
        {
            fromDatePicker.CustomFormat = " ";
            toIDatePicker.CustomFormat = " ";
            btnRemoveDate.Visible = false;
        }

        private void dgvExtraCarriers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvExtraCarriers.Rows[e.RowIndex].Cells[0].Value, false, false)))
                {
                    dgvExtraCarriers.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgvExtraCarriers.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void btnOkExtraCarriers_Click(object sender, EventArgs e)
        {
            VW_CompanyCompanyType carrierSelected;
            SelectedCarrierCodeList.Clear();
            lblExtraCarrier.Text = "";
            foreach (DataGridViewRow row in dgvExtraCarriers.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[0].Value, true, false)))
                {
                    carrierSelected = (VW_CompanyCompanyType)row.DataBoundItem;
                    SelectedCarrierCodeList.Add(Strings.Trim(carrierSelected.CompanyCode));
                    lblExtraCarrier.Text += Strings.Trim(carrierSelected.CompanyName) + Constants.vbNewLine;
                }
            }

            panelCarriers.Hide();
        }

        private void btnAddCarrier_Click(object sender, EventArgs e)
        {
            panelCarriers.Show();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelCarriers.Hide();
        }

        private void cboTruckingCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Strings.Trim(cboTruckingCompany.Text).Equals(""))
            {
                btnAddCarrier.Hide();
            }
            else
            {
                btnAddCarrier.Show();
            }
        }

        public DataRow getRate(DataTable dtName, int rateID)
        {
            var selectedTableRow = dtName.Select("where ID = " + rateID.ToString()).CopyToDataTable();
            return selectedTableRow.Rows[0];
        }

        private void calculateRates()
        {
            DataRow serviceRow;
            totalfsctefLabel.Text = "$0,00";
            fscFeeLabel.Text = "$0,00";
            fscLabel.Text = "N/A";
            tefFeeLabel.Text = "$0,00";
            totalaftTaxesLabel.Text = "$0,00";

            // Rate Before Due
            rateMultiLoadLabel.Text = "...";
            rateSingleLoadsLabel.Text = "...";
            rateMultEptyLabel.Text = "...";
            rateSingleEptyLabel.Text = "...";
            totalAfterTaxes = 0m;

            // total rates
            ratetotalMultiLoadLabel.Text = Strings.FormatCurrency(rateMultiLoads, IncludeLeadingDigit: TriState.True);
            ratetotalSingleLoadLabel.Text = Strings.FormatCurrency(rateSingleLoad, IncludeLeadingDigit: TriState.True);
            ratetotalMultiEptyLabel.Text = Strings.FormatCurrency(rateMultiEpty, IncludeLeadingDigit: TriState.True);
            ratetotalSingleEptyLabel.Text = Strings.FormatCurrency(rateSingleEpty, IncludeLeadingDigit: TriState.True);
            decimal totalBaseCost = rateMultiLoads + rateSingleLoad + rateMultiEpty + rateSingleEpty;
            lblTotalLoad.Text = Strings.FormatCurrency(totalBaseCost, IncludeLeadingDigit: TriState.True);
            foreach (DataRow addedService in FSC_Rate.Rows)
            {
                if (addedService["Rate_Name"].Equals("FSC"))
                {
                    fscLabel.Text = "Fuel Surcharge: " + addedService["Rate"].ToString() + "%";
                    fscFeeLabel.Text = Strings.FormatCurrency(Operators.DivideObject(Operators.MultiplyObject(addedService["Rate"], totalBaseCost), 100), IncludeLeadingDigit: TriState.True);
                    totalAfterTaxes = Conversions.ToDecimal(totalAfterTaxes + Convert.ToDecimal(addedService["Rate"]) + Convert.ToDecimal(totalBaseCost));
                }
            }

            decimal tedRateCost = tedRate();

            // FrmReportViwer.getSummaryByService()
            totalAfterTaxes += tedRateCost;
            tefFeeLabel.Text = Strings.FormatCurrency(tedRateCost, (int)TriState.True);
            totalfsctefLabel.Text = Strings.FormatCurrency(totalAfterTaxes, IncludeLeadingDigit: TriState.True);
            totalaftTaxesLabel.Text = Strings.FormatCurrency(totalBaseCost + totalAfterTaxes, IncludeLeadingDigit: TriState.True);
            lblTotalEmpty.Text = Strings.FormatCurrency(rateMultiEpty + rateSingleEpty, IncludeLeadingDigit: TriState.True);
            Label27.Text = Strings.FormatCurrency(rateMultiLoads + rateSingleLoad, IncludeLeadingDigit: TriState.True);
        }

        private decimal tedRate()
        {
            string cost;
            string status;
            string pickUp;
            string dropOff;
            string terminalName = "";
            string carrier;
            var totalCost = default(decimal);
            DateTime dateTime;
            TimeSpan cutOffTime;
            foreach (var item in reportList)
            {
                status = item.rateType;
                pickUp = Strings.Trim(item.pickUpCode);
                dropOff = Strings.Trim(item.dropOffCode);
                try
                {
                    dateTime = (DateTime)item.GateDateTime;
                }
                catch
                {
                    dateTime = DateAndTime.Now;
                }

                foreach (DataRow tef in TEFDT.Rows)
                {
                    terminalName = Strings.Trim(tef["Terminal"].ToString().Split(')')[0].Replace("(", ""));
                    if ((terminalName.Equals(pickUp) | terminalName.Equals(dropOff)) & item.drayageType.Equals(tef["RateType"]))
                    {
                        if (dateTime.DayOfWeek == DayOfWeek.Saturday | dateTime.DayOfWeek == DayOfWeek.Sunday)
                        {
                            if (!Information.IsDBNull(tef["WkEndsCutOffTime"]))
                            {
                                cutOffTime = (TimeSpan)tef["WkEndsCutOffTime"];
                                if (dateTime.TimeOfDay <= cutOffTime)
                                {
                                    cost = Conversions.ToString(tef["WkEndsDayRate"]);
                                }
                                else
                                {
                                    cost = Conversions.ToString(tef["WkEndsNightRate"]);
                                }
                            }
                            else
                            {
                                // if no cut off, rate for day and night are the same
                                cost = Conversions.ToString(tef["WkEndsDayRate"]);
                            }
                        }

                        // If there's a cut off time
                        else if (!Information.IsDBNull(tef["WkDaydCutOffTime"]))
                        {
                            cutOffTime = (TimeSpan)tef["WkDaydCutOffTime"];
                            if (dateTime.TimeOfDay <= cutOffTime)
                            {
                                cost = Conversions.ToString(tef["WkDaysDayRate"]);
                            }
                            else
                            {
                                cost = Conversions.ToString(tef["WkDaysNightRate"]);
                            }
                        }
                        else
                        {
                            // if no cut off, rate for day and night are the same
                            cost = Conversions.ToString(tef["WkDaysDayRate"]);
                        }

                        totalCost = Conversions.ToDecimal((Conversions.ToDouble(totalCost) + Conversions.ToDouble(cost)));
                    }
                }
            }

            return totalCost;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmReportViwer, this);
        }

        private void BunifuDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewCell serviceButton;
            try
            {
                serviceButton = addedServDataGridView.Rows[e.RowIndex].Cells[3];
                serviceButton.Style.BackColor = Color.Firebrick;
                serviceButton.Style.SelectionBackColor = Color.Firebrick;
                serviceButton.Style.SelectionForeColor = Color.White;
                serviceButton.Style.ForeColor = Color.White;
            }
            catch
            {
            }
        }

        private void reports1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewCell location;
            try
            {
                location = dgvTest.Rows[e.RowIndex].Cells[5];
                if (dgvTest.Rows[e.RowIndex].Cells[5].Value.Equals("UNKNOWN"))
                {
                    location.Style.BackColor = Color.Firebrick;
                    location.Style.SelectionBackColor = Color.Maroon;
                    location.Style.SelectionForeColor = Color.White;
                    location.Style.ForeColor = Color.White;
                }

                location = dgvTest.Rows[e.RowIndex].Cells[6];
                if (location.Value.Equals("UNKNOWN"))
                {
                    location.Style.BackColor = Color.Firebrick;
                    location.Style.SelectionBackColor = Color.Maroon;
                    location.Style.SelectionForeColor = Color.White;
                    location.Style.ForeColor = Color.White;
                }

                location = dgvTest.Rows[e.RowIndex].Cells[1];
                if (location.Value.Equals("$0.00"))
                {
                    location.Style.BackColor = Color.Goldenrod;
                    location.Style.SelectionBackColor = Color.DarkGoldenrod;
                    location.Style.SelectionForeColor = Color.Black;
                    location.Style.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }

        private void filterReportTable()
        {
            string singleEmpty = "na";
            string multiEmpty = "na";
            string singleLoad = "na";
            string multiLoad = "na";
            if (cbxSingleEmpty.Checked)
            {
                singleEmpty = "Single Empty";
            }

            if (cboMultiEmpty.Checked)
            {
                multiEmpty = "Multi Empty";
            }

            if (cboSingleLoad.Checked)
            {
                singleLoad = "Single Load";
            }

            if (cboMultiLoad.Checked)
            {
                multiLoad = "Multi Load";
            }

            var filteredList = new List<VW_ContainersInOutDrayage>();
            reportList = reportList.Where(c => (c.rateType ?? "") == (singleEmpty ?? "") | (c.rateType ?? "") == (multiEmpty ?? "") | (c.rateType ?? "") == (singleLoad ?? "") | (c.rateType ?? "") == (multiLoad ?? "")).ToList();
            dgvTest.DataSource = reportList;
        }
    }
}