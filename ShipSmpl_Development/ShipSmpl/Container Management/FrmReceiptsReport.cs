using Bunifu.UI.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ShipSmpl.Container_Management;
using ShipSmpl.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ShipSmpl
{
    public partial class FrmReceiptsReport
    {
        public FrmReceiptsReport()
        {
            InitializeComponent();
            doc = reportSource;
            _closeFlatButton.Name = "closeFlatButton";
            _Label26.Name = "Label26";
            _applyChangesButton.Name = "applyChangesButton";
            _CrystalReportViewer1.Name = "CrystalReportViewer1";
            doc = reportSource;
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private string bkngReleaseField = "[RELEASE NUMBER]";

        // Dim bkgRealDT As New DataTable
        private DataTable containersDT = new DataTable();

        private DataTable companies = new DataTable();
        private DataSetReceipt.InOutSelectedContainersDataTable receiptsDT = new DataSetReceipt.InOutSelectedContainersDataTable();
        private Dictionary<int, string> truckDictionary = new Dictionary<int, string>();

        private CrystalReportReceipts reportSource = new CrystalReportReceipts();
        private CrystalDecisions.CrystalReports.Engine.ReportDocument doc;

        private void FrmReceiptsReport_Load(object sender, EventArgs e)
        {
            companies = dbCeres.getTableInfo("VW_CompanyCompanyType", "*", "");
            populateBookingCombobox();
            // outGateButton.Checked = False
            // inGateButton.Checked = True
            populateContainers();
            getReceipts();
            //   var doc  CrystalDecisions.CrystalReports.Engine.ReportDocument = reportSource;
            //doc.ReportDefinition.Sections("Section3").SectionFormat.EnableSuppress = False
            //CrystalReportViewer1.ReportSource = reportSource

            if (My.MyProject.Forms.FrmInOutGate.tabinoutGate.SelectedIndex == 0)
            {
                doc.ReportDefinition.Sections["Section3"].SectionFormat.EnableSuppress = false;
                doc.ReportDefinition.Sections["DetailSection1"].SectionFormat.EnableSuppress = true;
                bkngReleaseField = "[RELEASE NUMBER]";
                bkngLabel.Text = "Release #:";
            }
            else
            {
                doc.ReportDefinition.Sections["Section3"].SectionFormat.EnableSuppress = true;
                doc.ReportDefinition.Sections["DetailSection1"].SectionFormat.EnableSuppress = false;
                bkngReleaseField = "[BOOKING NUMBER]";
                bkngLabel.Text = "Booking #:";
            }

            //   CrystalReportViewer1.ReportSource = reportSource;
        }

        private void populateContainers()
        {
            string contIDList = "[Unique ID] = ";
            BunifuDataGridView focudesDataGrid;
            {
                var withBlock = My.MyProject.Forms.FrmInOutGate;
                if (withBlock.tabinoutGate.SelectedIndex == 0)
                {
                    focudesDataGrid = withBlock.InGateDataGridView;
                }
                else
                {
                    focudesDataGrid = withBlock.OutGateDataGridView;
                }

                for (int i = 0, loopTo = focudesDataGrid.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(focudesDataGrid.Rows[i].Cells[1].Value, true, false)))
                    {
                        contIDList += focudesDataGrid.Rows[i].Cells[0].Value.ToString() + " or [Unique ID]=";
                    }
                }

                contIDList = contIDList.Substring(0, contIDList.Length - 15);
            }

            containersDT = dbCeres.getTableInfo("[Containers In-Out]", "*", "where " + contIDList + "order by [Container Number]");
        }

        private void populateBookingCombobox()
        {
            truckDropdown.Items.Clear();
            truckDictionary.Clear();
            ssLineDropdown.Items.Clear();
            carrierDropdown.Items.Clear();
            pickUpDropOffDropdown.Items.Clear();
            shipToDropdown.Items.Clear();
            driverDropdown.Items.Clear();
            truckDropdown.Items.Add("N/A");
            ssLineDropdown.Items.Add("N/A");
            carrierDropdown.Items.Add("N/A");
            pickUpDropOffDropdown.Items.Add("N/A");
            shipToDropdown.Items.Add("N/A");
            driverDropdown.Items.Add("N/A");
            var truckDT = dbCeres.getTableInfo("[Truck Drivers]", "[Truck Number], [Last Name], [First Name]", "order by [Truck Number], [Last Name], [First Name]");
            var trucks = (from row in truckDT.AsEnumerable()
                          select row.Field<string>("Truck Number")).Distinct();
            foreach (var truck in trucks)
                truckDropdown.Items.Add(Strings.Trim(truck));
            foreach (DataRow truck in truckDT.Rows)
                driverDropdown.Items.Add(Strings.Trim(Conversions.ToString(truck["Last Name"])) + ", " + Strings.Trim(Conversions.ToString(truck["First Name"])));
            foreach (DataRow company in dbCeres.getTableInfo("VW_CompanyCompanyType", "*", "order by CompanyName").Rows)
            {
                if (company["DescCompanyType"].Equals("Steamship Line"))
                {
                    ssLineDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
                else if (company["DescCompanyType"].Equals("Drayage Provider"))
                {
                    carrierDropdown.Items.Add(Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
                else if (company["DescCompanyType"].Equals("Container Terminal"))
                {
                    pickUpDropOffDropdown.Items.Add(Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                    shipToDropdown.Items.Add(Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
            }
        }

        private void relbkgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateContainers();
        }

        private void populateContComboBoxes(int tableIndex)
        {
            try
            {
                var row = receiptsDT.Rows[tableIndex];
                string gateMode;
                if (My.MyProject.Forms.FrmInOutGate.tabinoutGate.SelectedIndex == 0)
                {
                    gateMode = "In";
                    bkgRelTextBox.Text = Conversions.ToString(row["ReleaseNumber"]);
                }
                else
                {
                    gateMode = "Out";
                    bkgRelTextBox.Text = Conversions.ToString(row["BookingNumber"]);
                }

                contNumbTextBox.Text = Strings.Trim(Conversions.ToString(row["ContainerNumber"]));
                sizeDropdown.SelectedItem = row["ContainerSize"];
                statusDropdown.SelectedItem = row["Status"];
                conditionDropdown.SelectedItem = row["Condition"];
                if (row["ssLine"] != DBNull.Value)
                {
                    ssLineDropdown.SelectedItem = row["ssLine"];
                }
                else
                {
                    ssLineDropdown.SelectedItem = "N/A";
                }

                carrierDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["carrierIn"])).ToUpper();
                pickUpDropOffDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["PickUp"])).ToUpper();
                if (row["ShipTo"] != DBNull.Value)
                {
                    shipToDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["ShipTo"])).ToUpper();
                }
                else
                {
                    shipToDropdown.Text = "";
                }

                if (row["Destination"] != DBNull.Value)
                {
                    destinationTextBox.Text = Strings.Trim(Conversions.ToString(row["Destination"]));
                }
                else
                {
                    destinationTextBox.Text = "";
                }

                datePicker.Value = Conversions.ToDate(row["Date-Time"]);
                timePicker.Value = Conversions.ToDate(row["Date-Time"]);
                tareNumericUpDown.Value = Conversions.ToDecimal(row["TareWeight"]);
                if (row["CargoWeight"] != DBNull.Value)
                {
                    cargoNumericUpDown.Value = Conversions.ToDecimal(row["CargoWeight"]);
                }
                else
                {
                    cargoNumericUpDown.Value = 0m;
                }

                grossNumericUpDown.Value = Conversions.ToDecimal(row["GrossWeight"]);
                if (row["SealNumber"] != DBNull.Value)
                {
                    sealTextBox2.Text = Strings.Trim(Conversions.ToString(row["SealNumber"]));
                }
                else
                {
                    sealTextBox2.Text = "";
                }

                truckDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["TruckIn"]));
                driverDropdown.SelectedItem = row["DriverIn"];
                if (row["Comments"] != DBNull.Value)
                {
                    commentsTextBox.Text = Conversions.ToString(row["Comments"]);
                }
                else
                {
                    commentsTextBox.Text = "";
                }

                if (row["LRD"] != DBNull.Value)
                {
                    lrdDatePicker.Value = Conversions.ToDate(row["LRD"]);
                    lrdDatePicker.Enabled = true;
                }
                else
                {
                    lrdDatePicker.Enabled = false;
                }

                if (row["ERD"] != DBNull.Value)
                {
                    erdDatePicker.Value = Conversions.ToDate(row["ERD"]);
                    erdDatePicker.Enabled = true;
                }
                else
                {
                    erdDatePicker.Enabled = false;
                }

                vesselTextBox.Text = Strings.Trim(Conversions.ToString(row["Vessel"]));
            }
            catch
            {
            }
        }

        private void CrystalReportViewer1_PageChanged(object sender, EventArgs e)
        {
            // Stop
            int pageNumber = CrystalReportViewer1.GetCurrentPageNumber();
            populateContComboBoxes(pageNumber - 1);
        }

        private void getReceipts()
        {
            DateTime dateTimeInOut;
            DateTime timeInOut;
            string bkgRel;
            string pickUpDropOff;
            var ssLine = default(string);
            string dateTimeStr;
            string gateMode;
            string gateNumber;
            string damageMode;
            receiptsDT.Rows.Clear();
            if (My.MyProject.Forms.FrmInOutGate.tabinoutGate.SelectedIndex == 0)
            {
                gateMode = "In";
                gateNumber = "1";
                damageMode = "Damage ";
            }
            else
            {
                gateMode = "Out";
                gateNumber = "2";
                damageMode = "Damages ";
            }

            foreach (DataRow row in containersDT.Rows)
            {
                // For i = 0 To contNumbDataGridView.Rows.Count - 1
                // If contNumbDataGridView.Rows(i).Cells(1).Value = True And contNumbDataGridView.Rows(i).Cells(0).Value = row["Unique ID") Then
                var newRow = receiptsDT.NewInOutSelectedContainersRow();

                // dateTimeStr = row["Gate Time " + gateMode)
                // dateTimeStr = row["Gate Date In") ''+ " " + timeInOut.ToString("hh:mm tt")
                dateTimeInOut = Conversions.ToDate(row["Gate Date " + gateMode]);

                // dateTimeStr = row["Gate Date In") + " " + timeInOut.ToString("hh:mm tt")

                try
                {
                    ssLine = "(" + Strings.Trim(Conversions.ToString(row["ss Line Code " + gateMode])) + ") " + Strings.Trim(Conversions.ToString(companies.Select("CompanyCode = '" + Strings.Trim(Conversions.ToString(row["ss Line Code " + gateMode])) + "' and DescCompanyType= 'Steamship Line'").CopyToDataTable().Rows[0]["CompanyName"]));
                }
                catch
                {
                }

                if (row["Condition " + gateMode] != DBNull.Value)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition " + gateMode], '\0', false)))
                    {
                        newRow.Status = "EMPTY";
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition " + gateMode], '\u0001', false)))
                    {
                        newRow.Status = "PARTIAL";
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition " + gateMode], '\u0002', false)))
                    {
                        newRow.Status = "LOADED";
                    }
                }

                if (row[damageMode + gateMode] == DBNull.Value)
                {
                    newRow.Condition = "GOOD";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\0', false)))
                {
                    newRow.Condition = "GOOD";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\u0001', false)))
                {
                    newRow.Condition = "HOLE";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\u0002', false)))
                {
                    newRow.Condition = "BENT";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\u0003', false)))
                {
                    newRow.Condition = "BROKEN";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\u0004', false)))
                {
                    newRow.Condition = "CUT";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\u0005', false)))
                {
                    newRow.Condition = "DENT";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\u0006', false)))
                {
                    newRow.Condition = "BULGE";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row[damageMode + gateMode], '\a', false)))
                {
                    newRow.Condition = "MISSING";
                }

                if (row["Carrier DriverName " + gateMode] != DBNull.Value)
                {
                    newRow.DriverIn = Strings.Trim(Conversions.ToString(row["Carrier DriverName " + gateMode]));
                }
                else
                {
                    newRow.DriverIn = "";
                }

                if (row["Booking Number"] != DBNull.Value)
                {
                    newRow.BookingNumber = Strings.Trim(Conversions.ToString(row["Booking Number"]));
                }
                else
                {
                    newRow.BookingNumber = "";
                }

                if (row["Release Number"] != DBNull.Value)
                {
                    newRow.ReleaseNumber = Strings.Trim(Conversions.ToString(row["Release Number"]));
                }
                else
                {
                    newRow.ReleaseNumber = "";
                }

                if (row["Comments " + gateMode] != DBNull.Value)
                {
                    newRow.Comments = Strings.Trim(Conversions.ToString(row["Comments " + gateMode]));
                }
                else
                {
                    newRow.Comments = "";
                }

                // If row["Container Size") = ChrW(0) Then
                // newRow.ContainerSize = "20 FT"
                // ElseIf row["Container Size") = ChrW(1) Then
                // newRow.ContainerSize = "40 FT"
                // ElseIf row["Container Size") = ChrW(2) Then
                // newRow.ContainerSize = "40 HC FT"
                // ElseIf row["Container Size") = ChrW(3) Then
                // newRow.ContainerSize = "53 FT"
                // End If
                newRow.ContainerSize = Conversions.ToString(row["ContainerSize"]);
                if (gateMode.Equals("In"))
                {
                    newRow.GrossWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["Gross Weight"]));
                }
                else
                {
                    newRow.GrossWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["Gross Weight Out"]));
                    newRow.CargoWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["Cargo Weight Out"]));
                    newRow.BookingNumber = Strings.Trim(Conversions.ToString(row["Booking Number"]));
                }

                if (row["LRD"] != DBNull.Value)
                {
                    newRow.LRD = Conversions.ToDate(row["LRD"]);
                }

                if (row["ERD"] != DBNull.Value)
                {
                    try
                    {
                        newRow.ERD = Conversions.ToDate(row["ERD"]);
                        erdDatePicker.Enabled = true;
                    }
                    catch
                    {
                    }
                }

                newRow._Date_Time = dateTimeInOut;
                if (row["Terminal Name " + gateMode] != DBNull.Value)
                {
                    pickUpDropOff = Strings.Trim(Conversions.ToString(row["Terminal Name " + gateMode]));
                }
                else
                {
                    pickUpDropOff = "";
                }

                newRow.ssLIne = ssLine.ToUpper();
                newRow.ContainerNumber = Strings.Trim(Conversions.ToString(row["Container Number"]));
                if (row["Release Number"] != DBNull.Value)
                {
                    newRow.ReleaseNumber = Strings.Trim(Conversions.ToString(row["Release Number"]));
                }
                else
                {
                    newRow.ReleaseNumber = "";
                }

                newRow.PickUp = pickUpDropOff;
                newRow.TareWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["TARE Weight"]));
                newRow.CarrierIn = Strings.Trim(Conversions.ToString(row["carrier Name " + gateMode]));
                newRow.TruckIn = Conversions.ToString(row["Carrier Truck " + gateMode]);

                // newRow.DriverIn = Trim(row["Carrier DriverName In"))
                if (row["Terminal Name Out"] != DBNull.Value)
                {
                    newRow.ShipTo = Strings.Trim(Conversions.ToString(row["Terminal Name Out"]));
                }
                else
                {
                    newRow.ShipTo = "";
                }

                newRow.BarCodeInfo = dateTimeInOut.ToString("dd-mm-yyyy-" + gateNumber + "-") + Strings.Trim(Conversions.ToString(row["Container NUmber"]));
                if (row["Vessel Name"] != DBNull.Value)
                {
                    newRow.Vessel = Conversions.ToString(row["Vessel Name"]);
                }
                else
                {
                    newRow.Vessel = "";
                }

                if (row["Export Destination"] != DBNull.Value)
                {
                    newRow.Destination = Strings.Trim(Conversions.ToString(row["Export Destination"]));
                }
                else
                {
                    newRow.Destination = "";
                }

                newRow.LRD = Conversions.ToDate(lrdDatePicker.Value.ToString("dd-MMM-yyyy"));
                if (row["Seal Number"] != DBNull.Value)
                {
                    newRow.SealNumber = Strings.Trim(Conversions.ToString(row["Seal Number"]));
                }
                else
                {
                    newRow.SealNumber = "";
                }

                newRow.UserID = My.MyProject.Forms.FrmLoginWindow._userID.ToString();
                newRow.DeviceName = My.MyProject.Computer.Name;
                receiptsDT.AddInOutSelectedContainersRow(newRow);

                // End If
                // Next
            }

            try
            {
                //    reportSource.Database.Tables[0].SetDataSource(receiptsDT.CopyToDataTable());
                //   CrystalReportViewer1.ReportSource = reportSource;
            }
            catch
            {
            }

            populateContComboBoxes(0);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            getReceipts();
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            var row = receiptsDT.Rows[CrystalReportViewer1.GetCurrentPageNumber() - 1];
            string dateTimestr;
            DateTime dateTime;
            string gateMode;
            dateTimestr = datePicker.Value.ToShortDateString() + " " + timePicker.Value.ToShortTimeString();
            dateTime = Convert.ToDateTime(dateTimestr);
            if (My.MyProject.Forms.FrmInOutGate.tabinoutGate.SelectedIndex == 0)
            {
                gateMode = "IN";
                row["ReleaseNumber"] = bkgRelTextBox.Text;
            }
            else
            {
                gateMode = "Out";
                row["BookingNumber"] = bkgRelTextBox.Text;
            }

            row["ContainerNumber"] = contNumbTextBox.Text;
            row["ContainerSize"] = sizeDropdown.Text;
            row["Status"] = statusDropdown.Text;
            row["Condition"] = conditionDropdown.Text;
            row["ssLine"] = ssLineDropdown.Text;
            row["carrierIn"] = carrierDropdown.Text;
            row["LRD"] = lrdDatePicker.Value;
            row["ERD"] = erdDatePicker.Value;
            row["Vessel"] = vesselTextBox.Text;
            row["ShipTo"] = shipToDropdown.Text;
            row["pickUp"] = pickUpDropOffDropdown.Text;
            row["truck" + gateMode] = truckDropdown.Text;
            row["cargoWeight"] = cargoNumericUpDown.Value;
            row["tareWeight"] = tareNumericUpDown.Value;
            row["GrossWeight"] = grossNumericUpDown.Value;
            row["comments"] = commentsTextBox.Text;
            row["Date-Time"] = dateTime;
            row["Driver" + gateMode] = driverDropdown.Text;
            row["Destination"] = destinationTextBox.Text;
            try
            {
                //    reportSource.Database.Tables[0].SetDataSource(receiptsDT.CopyToDataTable());
                //  CrystalReportViewer1.ReportSource = reportSource;
            }
            catch
            {
            }
        }

        private void Label26_Click(object sender, EventArgs e)
        {
        }
    }
}