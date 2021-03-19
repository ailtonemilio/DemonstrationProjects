using Bunifu.UI.WinForms;
using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmEDIManagement
    {
        public FrmEDIManagement()
        {
            InitializeComponent();
            _refreshInShapedButton.Name = "refreshInShapedButton";
            _STATUSDropdown1.Name = "STATUSDropdown1";
            _truckTextBox.Name = "truckTextBox";
            _releaseTextBox.Name = "releaseTextBox";
            _ssLineTextBox.Name = "ssLineTextBox";
            _conatinerTextBox.Name = "conatinerTextBox";
            _InGateDataGridView.Name = "InGateDataGridView";
            _resendEDIButton.Name = "resendEDIButton";
            _BunifuButton1.Name = "BunifuButton1";
            _presendButton.Name = "presendButton";
            _contOutTextBox.Name = "contOutTextBox";
            _OutGateDataGridView.Name = "OutGateDataGridView";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private DataTable InOutEDIRecDT = new DataTable();
        private DataTable searchTable = new DataTable();
        private DataTable companies = new DataTable();
        private int selectedContIn = 0;
        private int selectedContOut = 0;
        private bool isRefresh;
        private bool firstLoad = true;
        private Dictionary<string, string> terminalCode = new Dictionary<string, string>();

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEDIManagement_Load(object sender, EventArgs e)
        {
            companies = dbCeres.getTableInfo("VW_CompanyCompanyType", "CompanyCode", "where [EDIRequired] = 1 order by CompanyCode");
            // statusOutDropdown.SelectedIndex = 0
            STATUSDropdown1.SelectedIndex = 0;
            var vwMB = new MinibookingService();
            bookingComboBox.DataSource = MinibookingService.GetJointBooking(bookingActivBookingBunifuToggleSwitch2.Value);
            bookingComboBox.SelectedIndex = 0;
            bookingComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookingComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSSLine.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Steamship_Line, new WTCCeresEntities());
            cboSSLine.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSSLine.AutoCompleteSource = AutoCompleteSource.ListItems;
            firstLoad = false;
        }

        private string getEDIssLines()
        {
            string compStr;
            if (tabinoutGate.SelectedIndex == 0)
            {
                compStr = " [SS Line Code In] = '";
            }
            else
            {
                compStr = " [SS Line Code Out] = '";
            }

            foreach (DataRow ssLine in companies.Rows)
            {
                if (tabinoutGate.SelectedIndex == 0)
                {
                    compStr += Strings.Trim(Conversions.ToString(ssLine["CompanyCode"])) + "' or [SS Line Code In] = '";
                }
                else
                {
                    compStr += Strings.Trim(Conversions.ToString(ssLine["CompanyCode"])) + "' or [SS Line Code Out] = '";
                }
            }

            compStr = compStr.Substring(0, compStr.Length - 25);
            return compStr;
        }

        public void getEDIs(BunifuDataGridView ediDataGrid)
        {
            string condition = "";
            string table;
            string EDIMode;
            decimal GrossWeight = 0m;
            string inputSource;
            string TruckDriverName = "";
            string gateDate;
            string gateTime;
            string TruckNumber = "";
            string contSize = "";
            decimal tareWeight;
            DateTime ediModDateTime;
            DateTime datimeTineInsideFile;
            string datimeTineInsideFileStr;
            DateTime gateTimeDate;
            var ediorgTimeDate = default(DateTime);
            DateTime dTRequestSent;
            var dTRequestSentStr = default(string);
            string ssLineCode;
            string bkgnRelNumb;
            DateTime tempDateTime, tempTime;
            string confHandshakeEdi = "";
            string location;
            string carrierCode;
            string dateAndTimeRequested;

            // Set different queries for in-gate EDI and out-gate EDI
            if (tabinoutGate.SelectedIndex == 0)
            {
                EDIMode = "IN-GATE";
                InGateDataGridView.Rows.Clear();
                condition = "on [In-Out Unique ID] = [Unique ID] ";
                table = "(select * from [Containers In-Out] where convert(date,[Gate Date In]) >='" + fromInBunifuDatePicker.Value.ToShortDateString() + @"'  AND
		 convert(date,[Gate Date In]) <=  '" + toInBunifuDatePicker.Value.ToShortDateString() + "' and [Trouble In-Gate] = 0 and [In Gate EDI] = 1 and (" + getEDIssLines() + @")) as c lEFT join
	 (select * from ((select * from[EDI Records] where [Gate Mode] <> 'OUT-GATE') as d  LEFT join
		(select * from [ManualEDILog] ) as m on d.EDIRecID = m.EDIRecordID))as r ";
            }
            else
            {
                EDIMode = "OUT-GATE";
                OutGateDataGridView.Rows.Clear();
                string showOutCans = "";
                if (cbShowOutGatedCans.Checked == true)
                {
                    showOutCans = "and [Gate Date Out] is not null";
                }
                VW_CompanyCompanyType c = (VW_CompanyCompanyType)cboSSLine.SelectedItem;
                VW_BookingMinibooking b = (VW_BookingMinibooking)bookingComboBox.SelectedItem;

                var conditionFilter = Operators.AddObject(Operators.AddObject(Operators.AddObject("and ([SS Line Code Out] like '%" + Strings.Trim(Conversions.ToString(c.CompanyCode)) + "%' or [SS Line Code In] like '%" + Strings.Trim(Conversions.ToString(c.CompanyCode)) + "%') and " + " [Booking Number] is not null and [Booking Number] like '%", b.BookingNumber), "%' "), showOutCans);
                table = Conversions.ToString(Operators.AddObject(Operators.AddObject("(select * from [Containers In-Out] where (" + getEDIssLines() + ") ", conditionFilter), @")  as c lEFT join
	 (select * from ((select * from[EDI Records] where [Gate Mode] <> 'IN-GATE') as d  LEFT join
		(select * from [ManualEDILog] ) as m on d.EDIRecID = m.EDIRecordID))as r "));

                // toOutBunifuDatePicker.Value.Date + "' and [Trouble In-Gate] = 0 and [In Gate EDI] = 1
                condition = "on [Unique ID] = [In-Out Unique ID]";
            }

            if (isRefresh)
            {
                InOutEDIRecDT = dbCeres.getTableInfo(table, "*", condition);
                searchTable = InOutEDIRecDT;
            }

            foreach (DataRow row in searchTable.Rows)
            {
                if (tabinoutGate.SelectedIndex == 0)
                {
                    if (row["Yard Code In"] != DBNull.Value)
                    {
                        location = Strings.Trim(Conversions.ToString(row["Yard Code In"]));
                    }
                    else
                    {
                        location = "N/A";
                    }

                    if (row["Carrier Truck In"] == DBNull.Value)
                    {
                        TruckNumber = "";
                    }
                    else
                    {
                        TruckNumber = Strings.Trim(Conversions.ToString(row["Carrier Truck In"]));
                    }

                    if (row["Carrier DriverName In"] == DBNull.Value)
                    {
                        TruckDriverName = Strings.Trim("N/A");
                    }
                    else
                    {
                        TruckDriverName = Strings.Trim(Conversions.ToString(row["Carrier DriverName In"]));
                    }

                    bkgnRelNumb = Strings.Trim(Conversions.ToString(row["Release Number"]));
                    ssLineCode = Strings.Trim(Conversions.ToString(row["SS Line Code In"]));
                    carrierCode = Strings.Trim(Conversions.ToString(row["Carrier Code In"]));


                    if (row["ConfHandShakeDateTime"] != DBNull.Value)
                    {
                        ediorgTimeDate = Conversions.ToDate(row["ConfHandShakeDateTime"]);
                        confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                        if (row["EDIModDateTime"] != DBNull.Value)
                        {
                            datimeTineInsideFile = Conversions.ToDate(row["EDIModDateTime"]);
                            datimeTineInsideFileStr = datimeTineInsideFile.ToString("dd-MMM-yyyy HH:mm");
                            // ediorgTimeDate = row["EDIOriginalDateTime")
                            confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                        }
                        else if (row["In Gate EDI Date Time"] != DBNull.Value)
                        {
                            ediorgTimeDate = Conversions.ToDate(row["ConfHandShakeDateTime"]);
                            confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                            datimeTineInsideFile = Conversions.ToDate(row["Gate Date In"]);
                            datimeTineInsideFileStr = datimeTineInsideFile.ToString("dd-MMM-yyyy HH:mm");
                        }
                        else
                        {
                            datimeTineInsideFileStr = "N/A";
                        }

                        if (row["Date and Time"] != DBNull.Value)
                        {
                            dTRequestSent = Conversions.ToDate(row["Date and Time"]);
                            dTRequestSentStr = dTRequestSent.ToString("dd-MMM-yyyy HH:mm");
                        }
                        else
                        {
                            dTRequestSent = Conversions.ToDate("N/A");
                        }
                    }
                    else
                    {
                        datimeTineInsideFileStr = "N/A";
                        if (row["In Gate EDI Date Time"] != DBNull.Value)
                        {
                            ediorgTimeDate = Conversions.ToDate(row["Gate Date In"]);
                            confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                            datimeTineInsideFileStr = confHandshakeEdi;
                        }
                        else
                        {
                            confHandshakeEdi = "N/A";
                        }

                        if (row["Date and Time"] != DBNull.Value)
                        {
                            dTRequestSent = Conversions.ToDate(row["Date and Time"]);
                            dTRequestSentStr = dTRequestSent.ToString("dd-MMM-yyyy HH:mm");
                        }
                        else
                        {
                            dTRequestSentStr = "N/A";
                        }
                    }

                    gateTimeDate = Conversions.ToDate(row["Gate Date In"]);
                    gateDate = gateTimeDate.ToString("dd-MMM-yyyy");
                    gateTime = gateTimeDate.ToString("HH:mm");
                }
                else
                {
                    if (row["Booking Number"] != DBNull.Value)
                    {
                        bkgnRelNumb = Strings.Trim(Conversions.ToString(row["Booking Number"]));
                    }
                    else
                    {
                        bkgnRelNumb = "N/A";
                    }

                    if (row["SS Line Code Out"] == DBNull.Value)
                    {
                        ssLineCode = "";
                    }
                    else
                    {
                        ssLineCode = Strings.Trim(Conversions.ToString(row["SS Line Code Out"]));
                    }

                    if (row["Carrier Code Out"] != DBNull.Value)
                    {
                        carrierCode = Strings.Trim(Conversions.ToString(row["Carrier Code Out"]));
                    }
                    else
                    {
                        carrierCode = "";
                    }

                    if (row["Yard Code Out"] != DBNull.Value)
                    {
                        location = Strings.Trim(Conversions.ToString(row["Yard Code Out"]));
                    }
                    else
                    {
                        location = "N/A";
                    }

                    if (row["Carrier Truck Out"] == DBNull.Value)
                    {
                        TruckNumber = "N/A";
                    }
                    else
                    {
                        TruckNumber = Strings.Trim(Conversions.ToString(row["Carrier Truck Out"]));
                    }

                    if (row["Carrier DriverName Out"] == DBNull.Value)
                    {
                        TruckDriverName = "N/A";
                    }
                    else
                    {
                        TruckDriverName = Strings.Trim(Conversions.ToString(row["Carrier DriverName Out"]));
                    }

                    if (row["ConfHandShakeDateTime"] != DBNull.Value)
                    {
                        ediorgTimeDate = Conversions.ToDate(row["ConfHandShakeDateTime"]);
                        confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                        if (row["EDIModDateTime"] != DBNull.Value)
                        {
                            datimeTineInsideFile = Conversions.ToDate(row["EDIModDateTime"]);
                            datimeTineInsideFileStr = datimeTineInsideFile.ToString("dd-MMM-yyyy HH:mm");
                            // ediorgTimeDate = row["EDIOriginalDateTime")
                            confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                        }
                        else if (row["Out Gate EDI Date Time"] != DBNull.Value)
                        {
                            ediorgTimeDate = Conversions.ToDate(row["ConfHandShakeDateTime"]);
                            confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                            if (row["Gate Date Out"] != DBNull.Value)
                            {
                                datimeTineInsideFile = Conversions.ToDate(row["Gate Date Out"]);
                                datimeTineInsideFileStr = datimeTineInsideFile.ToString("dd-MMM-yyyy HH:mm");
                            }
                            else
                            {
                                datimeTineInsideFileStr = "N/A";
                            }
                        }
                        else
                        {
                            datimeTineInsideFileStr = "N/A";
                        }

                        if (row["Date and Time"] != DBNull.Value)
                        {
                            dTRequestSent = Conversions.ToDate(row["Date and Time"]);
                            dTRequestSentStr = dTRequestSent.ToString("dd-MMM-yyyy HH:mm");
                        }
                        else
                        {
                            dTRequestSent = Conversions.ToDate("N/A");
                        }
                    }
                    else
                    {
                        datimeTineInsideFileStr = "N/A";
                        if (row["Out Gate EDI Date Time"] != DBNull.Value && row["Gate Date Out"] != DBNull.Value)
                        {
                            ediorgTimeDate = Conversions.ToDate(row["Gate Date Out"]);
                            confHandshakeEdi = ediorgTimeDate.ToString("dd-MMM-yyyy HH:mm");
                            datimeTineInsideFileStr = confHandshakeEdi;
                        }
                        else
                        {
                            confHandshakeEdi = "N/A";
                        }
                    }

                    if (row["Gate Date Out"] != DBNull.Value)
                    {
                        gateTimeDate = Conversions.ToDate(row["Gate Date Out"]);
                        gateDate = gateTimeDate.ToString("dd-MMM-yyyy");
                        gateTime = gateTimeDate.ToString("HH:mm");
                    }
                    else
                    {
                        gateDate = "";
                        gateTime = "";
                    }

                    if (row["Date and Time"] != DBNull.Value)
                    {
                        dTRequestSent = Conversions.ToDate(row["Date and Time"]);
                        dTRequestSentStr = dTRequestSent.ToString("dd-MMM-yyyy HH:mm");
                    }
                    else
                    {
                        dTRequestSentStr = "N/A";
                    }
                }

                try
                {
                    contSize = Conversions.ToString(row["ContainerSize"]);
                }
                catch
                {
                    contSize = "";
                }

                if (row["Input Source"].Equals("SYSTEM"))
                {
                    inputSource = "SYSTEM";
                }
                else if (tabinoutGate.SelectedIndex == 1)
                {
                    if (row["Input Source"] == DBNull.Value)
                    {
                        if (row["Out Gate EDI Date Time"] == DBNull.Value)
                        {
                            inputSource = "";
                        }
                        else
                        {
                            inputSource = "SYSTEM";
                        }
                    }
                    else
                    {
                        inputSource = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("PRE-SEND    " + Constants.vbNewLine + "By: ", row["User Name"]), Constants.vbNewLine), "Date/Time: "), ediorgTimeDate.ToString("dd-MMM-yyyy hh:mm tt")));
                    }
                }
                else if (row["Input Source"] == DBNull.Value)
                {
                    if (row["In Gate EDI Date Time"] == DBNull.Value)
                    {
                        inputSource = "";
                    }
                    else
                    {
                        inputSource = "SYSTEM";
                    }
                }
                else
                {
                    inputSource = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("RESEND    " + Constants.vbNewLine + "By: ", row["User Name"]), Constants.vbNewLine), "Date/Time: "), ediorgTimeDate.ToString("dd-MMM-yyyy hh:mm tt")));
                }

                if (row["TARE Weight"] != DBNull.Value)
                {
                    tareWeight = (decimal)MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["TARE Weight"]));
                }
                else
                {
                    tareWeight = 0m;
                }

                // GrossWeight = DoFunctions.CVS(row["Gross Weight"])

                if (row["Gross Weight"] != DBNull.Value)
                {
                    GrossWeight = (decimal)MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["Gross Weight"]));
                }
                else
                {
                    GrossWeight = 0m;
                }

                ediDataGrid.Rows.Add(row["Unique ID"], null, Strings.Trim(Conversions.ToString(row["Container Number"])), location, datimeTineInsideFileStr, confHandshakeEdi, gateDate + " " + gateTime, dTRequestSentStr, inputSource, ssLineCode, bkgnRelNumb, contSize, (object)GrossWeight, (object)tareWeight, carrierCode, TruckNumber, TruckDriverName);
            }
        }

        private void refreshInShapedButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            isRefresh = true;
            firstLoad = false;
            getEDIs(InGateDataGridView);
            resendEDIButton.Enabled = false;
            MdlLoadingSetting.waitForm.Close();
        }

        private void BunifuDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // to add complete/in progress images to datagridview
            BunifuDataGridView focusedDataGrid;
            if (tabinoutGate.SelectedIndex == 0)
            {
                focusedDataGrid = InGateDataGridView;
            }
            else
            {
                focusedDataGrid = OutGateDataGridView;
            }

            if (focusedDataGrid.Rows[e.RowIndex].Cells[8].Value.ToString().Split(Conversions.ToChar(Constants.vbNewLine))[0].Equals("SYSTEM"))
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.BackColor = Color.SlateGray;
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.SelectionBackColor = Color.DimGray;
            }
            else if (!focusedDataGrid.Rows[e.RowIndex].Cells[8].Value.Equals(""))
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.BackColor = Color.Peru;
                focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.SelectionBackColor = Color.Chocolate;
            }

            focusedDataGrid.Rows[e.RowIndex].Cells[8].Style.ForeColor = Color.White;
            try
            {
                if (!focusedDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0, 11).Equals(focusedDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString().Substring(0, 11)))
                {
                    focusedDataGrid.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.PeachPuff;
                    focusedDataGrid.Rows[e.RowIndex].Cells[5].Style.SelectionBackColor = Color.SandyBrown;
                    focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.PeachPuff;
                    focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.SelectionBackColor = Color.SandyBrown;

                    // focusedDataGrid.Rows(e.RowIndex).Cells(4).Style.SelectionForeColor = Color.White
                    // focusedDataGrid.Rows(e.RowIndex).Cells(9).Style.SelectionForeColor = Color.White
                }

                if (!focusedDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString().Substring(0, 11).Equals(focusedDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString().Substring(0, 11)))
                {
                    focusedDataGrid.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.Peru;
                    focusedDataGrid.Rows[e.RowIndex].Cells[4].Style.SelectionBackColor = Color.Chocolate;
                    focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.Peru;
                    focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.SelectionBackColor = Color.Chocolate;
                    focusedDataGrid.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.White;
                    focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.ForeColor = Color.White;
                    // focusedDataGrid.Rows(e.RowIndex).Cells(4).Style.SelectionForeColor = Color.White
                    // focusedDataGrid.Rows(e.RowIndex).Cells(9).Style.SelectionForeColor = Color.White
                }
            }
            catch
            {
            }
        }

        private void OutGateDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // to add complete/in progress images to datagridview
            BunifuDataGridView focusedDataGrid;
            focusedDataGrid = OutGateDataGridView;
            if (focusedDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString().Split(Conversions.ToChar(Constants.vbNewLine))[0].Equals("SYSTEM"))
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.SlateGray;
                focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.SelectionBackColor = Color.DimGray;
            }
            else if (!focusedDataGrid.Rows[e.RowIndex].Cells[6].Value.Equals(""))
            {
                focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.Peru;
                focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.SelectionBackColor = Color.Chocolate;
            }

            focusedDataGrid.Rows[e.RowIndex].Cells[6].Style.ForeColor = Color.White;

            // If Not focusedDataGrid.Rows(e.RowIndex).Cells(4).Value.ToString.Substring(0, 11).Equals(
            // focusedDataGrid.Rows(e.RowIndex).Cells(9).Value.ToString.Substring(0, 11)) Then

            // focusedDataGrid.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Peru
            // focusedDataGrid.Rows(e.RowIndex).Cells(4).Style.SelectionBackColor = Color.Chocolate

            // focusedDataGrid.Rows(e.RowIndex).Cells(9).Style.BackColor = Color.Peru
            // focusedDataGrid.Rows(e.RowIndex).Cells(9).Style.SelectionBackColor = Color.Chocolate

            // focusedDataGrid.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.White
            // focusedDataGrid.Rows(e.RowIndex).Cells(9).Style.ForeColor = Color.White
            // 'focusedDataGrid.Rows(e.RowIndex).Cells(4).Style.SelectionForeColor = Color.White
            // 'focusedDataGrid.Rows(e.RowIndex).Cells(9).Style.SelectionForeColor = Color.White
            // End If

        }

        private void bookingComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            isRefresh = true;
            getEDIs(OutGateDataGridView);
        }

        private void resendEDIButton_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmChangeEDI;
                withBlock.ediMode = "RESEND";
                if (this.getSelectedContIDs(InGateDataGridView).Count > 1)
                {
                    withBlock.currentEDILabel.Text = "Gate Date/Time (Multiple containers selected)";
                    withBlock.changeLabel.Text = "Change EDIs Date/Time:";
                    withBlock.changeEDIButton.Text = "Resend EDIs";
                }
                else
                {
                    string dateTimeStr = Conversions.ToString(getSelectedRow(InGateDataGridView).Cells[4].Value);
                    withBlock.currentEDILabel.Text = "Gate Date/Time (" + dateTimeStr + ")";
                    withBlock.changeLabel.Text = "Change EDI Date/Time:";
                    withBlock.changeEDIButton.Text = "Resend EDI";
                }
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmChangeEDI, this);
        }

        private void presendButton_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmChangeEDI;
                withBlock.ediMode = "PRE-SEND";
                string dateTimeStr = DateAndTime.Now.ToString("dd-MMM-yyy HH:mm");
                withBlock.currentEDILabel.Text = "Current Date/Time (" + dateTimeStr + ")";
                if (this.getSelectedContIDs(OutGateDataGridView).Count > 1)
                {
                    withBlock.changeLabel.Text = "Change EDIs Date/Time:";
                }
                else
                {
                    withBlock.changeLabel.Text = "Change EDI Date/Time:";
                }
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmChangeEDI, this);
        }

        private void BunifuTextBox1In_TextChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                isRefresh = false;
                string search = "";
                string status;
                if (STATUSDropdown1.SelectedItem.Equals("SYSTEM"))
                {
                    status = "[Input Source]  ='SYSTEM' and ";
                }
                else if (STATUSDropdown1.SelectedItem.Equals("RESEND"))
                {
                    status = "[Input Source] <> 'SYSTEM' and ";
                }
                else
                {
                    status = "";
                }

                search = "[Container Number] Like '%" + conatinerTextBox.Text.ToUpper() + "%' and " + "[Yard Code In] Like '%" + locationTextBox.Text.ToUpper() + "%' and " + status + "[SS Line Code In] Like '%" + ssLineTextBox.Text.ToUpper() + "%' and " + "[Release Number] Like '%" + releaseTextBox.Text.ToUpper() + "%' and " + "[Carrier Code In] Like '%" + carrierTextBox.Text.ToUpper() + "%' and " + "[Carrier Truck In] Like '%" + truckTextBox.Text.ToUpper() + "%'";
                try
                {
                    searchTable = InOutEDIRecDT.Select(search).CopyToDataTable();
                }
                catch
                {
                }

                getEDIs(InGateDataGridView);
            }
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                isRefresh = false;
                string search = "";
                string status;

                // If statusOutDropdown.SelectedItem.Equals("SYSTEM") Then
                // status = "[Input Source]  ='SYSTEM' and "
                // ElseIf statusOutDropdown.SelectedItem.Equals("PRE-SEND") Then
                // status = "[Input Source] <> 'SYSTEM' and "
                // Else
                // status = ""
                // End If

                search = "[Container Number] Like '%" + contOutTextBox.Text.ToUpper() + "%'  ";
                // "[Yard Code In] Like '%" + locationOutTextBox.Text.ToUpper + "%' and " +
                // status +
                // "[SS Line Code Out] Like '%" + SSLineOutTextBox.Text.ToUpper + "%' and " +
                // "[Booking Number] Like '%" + bkngTextBox.Text.ToUpper + "%' and " +
                // "[Carrier Code Out] Like '%" + carrierOutTextBox.Text.ToUpper + "%' and " +
                // "[Carrier Truck Out] Like '%" + TruckOutTextBox.Text.ToUpper + "%'"

                try
                {
                    searchTable = InOutEDIRecDT.Select(search).CopyToDataTable();
                }
                catch
                {
                }

                getEDIs(OutGateDataGridView);
            }
        }

        private void InGateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(InGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    InGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    selectedContIn += 1;
                }
                else
                {
                    InGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    selectedContIn -= 1;
                }
            }

            if (selectedContIn > 0)
            {
                resendEDIButton.Enabled = true;
            }
            else
            {
                resendEDIButton.Enabled = false;
            }
        }

        private void OutGateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(OutGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    OutGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    selectedContOut += 1;
                }
                else
                {
                    OutGateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    selectedContOut -= 1;
                }
            }

            if (selectedContOut > 0)
            {
                presendButton.Enabled = true;
            }
            else
            {
                presendButton.Enabled = false;
            }
        }

        private void refreshOutBunifuButton1_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            isRefresh = true;
            firstLoad = false;
            getEDIs(OutGateDataGridView);
            resendEDIButton.Enabled = false;
            MdlLoadingSetting.waitForm.Close();
        }

        public Dictionary<int, string> getSelectedContIDs(BunifuDataGridView dataDrid)
        {
            var selectedIDs = new Dictionary<int, string>();
            for (int i = 0, loopTo = dataDrid.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dataDrid.Rows[i].Cells[1].Value, true, false)))
                {
                    int rowID;
                    string ssline;
                    rowID = Conversions.ToInteger(dataDrid.Rows[i].Cells[0].Value);
                    ssline = Conversions.ToString(dataDrid.Rows[i].Cells[7].Value);
                    selectedIDs.Add(rowID, ssline);
                }
            }

            return selectedIDs;
        }

        private DataGridViewRow getSelectedRow(BunifuDataGridView dataGrid)
        {
            for (int i = 0, loopTo = dataGrid.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dataGrid.Rows[i].Cells[1].Value, true, false)))
                {
                    return dataGrid.Rows[i];
                    break;
                }
            }

            return default;
        }
    }
}