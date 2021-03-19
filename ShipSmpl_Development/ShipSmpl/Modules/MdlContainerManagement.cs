using Bunifu.UI.WinForms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace ShipSmpl
{
    static class MdlContainerManagement
    {
        private static string DBConnect = DatabaseHelperCeres.StrConnWTCCeres;
        private static DatabaseHelper db = new DatabaseHelper();
        private static DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        public static string deleteRecordType = "";
        private static Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
        private static Workbook XLWorkbook;
        private static object focusedPath = @"\\server-one\Brian\WTC\Open";
        // Dim focusedPath = "C:\Users\vania\Desktop\Booking"

        public static bool successPushing;

        public static void clearDataGrid(BunifuDataGridView dataGrid)
        {
            int count = dataGrid.Rows.Count - 1;
            while (count >= 0)
            {
                dataGrid.Rows.RemoveAt(count);
                count = dataGrid.Rows.Count - 1;
            }
        }

        // Public Sub unassignFromExcel(ByVal ContainerSheet As Worksheet, numbOfcansInBk As Integer)
        // Dim YSt As Int16 = 8
        // Try
        // 'For i = 0 To maxContainersIn - 1
        // 'ThisLine = Mid(ContainersToUpdate, x, 31)
        // ContainerSheet.Select()
        // ContainerSheet.Unprotect()

        // For i = 8 To (numbOfcansInBk + 8)
        // YSt = i
        // Try
        // Dim rconNumb As Excel.Range = ContainerSheet.Cells(YSt, 13)
        // If Not IsNothing(rconNumb.Value) AndAlso (Not rconNumb.Value.ToString().Contains("/")) AndAlso (Not rconNumb.Value.ToString().Contains("-")) Then
        // '  Dim rconNumb As Excel.Range = ContainerSheet.Cells(YSt, 13)
        // rconNumb.Select()
        // rconNumb.ClearContents()

        // Dim rcontype As Excel.Range = ContainerSheet.Cells(YSt, 14)
        // rcontype.Select()
        // rcontype.ClearContents()

        // Dim rconTare As Excel.Range = ContainerSheet.Cells(YSt, 15)
        // rconTare.Select()
        // rconTare.ClearContents()
        // Dim rconPickUp As Excel.Range = ContainerSheet.Cells(YSt, 16)
        // rconPickUp.Select()
        // rconPickUp.ClearContents()

        // Dim rconDelivStatus As Excel.Range = ContainerSheet.Cells(YSt, 20)
        // rconDelivStatus.Select()
        // rconDelivStatus.ClearContents()

        // Dim rcontruckNumb As Excel.Range = ContainerSheet.Cells(YSt, 21)
        // rcontruckNumb.Select()
        // rcontruckNumb.ClearContents()

        // Dim rcontruckOut As Excel.Range = ContainerSheet.Cells(YSt, 22)
        // rcontruckOut.Select()
        // rcontruckOut.ClearContents()

        // YSt += 1
        // End If
        // ContainerSheet.Protect()
        // Catch ex As Exception

        // End Try

        // Next
        // Catch ex As Exception
        // ContainerSheet.Protect()
        // MessageBox.Show(ex.Message, "Error:")
        // End Try

        // End Sub

        public static void checkContainersAdded()
        {
            {
                var withBlock = My.MyProject.Forms.FrmCreateTransfer;
                withBlock.titlewarningLabel.Text = "Create new Transfer";
                withBlock.titlewarningLabel.ForeColor = Color.FromArgb(64, 64, 64);
                withBlock.explanationTableLayoutPanel.Hide();
                string[] containerList;
                containerList = withBlock.containersRichTextBox.Text.Split(Conversions.ToChar(Microsoft.VisualBasic.Constants.vbLf));

                // verify if containers are saved on database or if its a wtc container
                foreach (string c in containerList)
                {
                    string containerNumber = Strings.Trim(c);
                    if (!containerNumber.Equals(""))
                    {
                        string condition = "where [Container Number] = '" + containerNumber + "'";
                        bool isValidContainerInOut = db.isOnDatabase("[Containers In-Out]", condition + " and [Container Out-Gated] = 0");
                        bool isWTCContainer = db.isOnDatabase("[WTC Containers]", condition);
                        if (ValidateContainer(containerNumber) & isValidContainerInOut == true | isWTCContainer == true)
                        {
                            withBlock.okToTransferDataGrid.Rows.Add(new ListViewItem(new[] { containerNumber }));
                        }
                        else
                        {
                            withBlock.explanationTableLayoutPanel.Show();
                            int focusedItemIndex;
                            if (isValidContainerInOut == false)
                            {
                                bool containerExists = db.isOnDatabase("[Containers In-Out]", condition);

                                // if container is already out gated
                                if (containerExists)
                                {
                                    withBlock.problemsDataGrid.Rows.Add(containerNumber + "**");
                                    focusedItemIndex = withBlock.problemsDataGrid.Rows.Count - 1;
                                }
                                // .problemsDataGrid.Rows(focusedItemIndex).UseItemStyleForSubItems = False
                                // .problemsDataGrid.Rows(focusedItemIndex).Cells(0).ForeColor = Color.Firebrick
                                else
                                {
                                    // if containerNumber is not valid
                                    withBlock.problemsDataGrid.Rows.Add(containerNumber + "*");
                                    focusedItemIndex = withBlock.problemsDataGrid.Rows.Count - 1;
                                    // .problemsDataGrid.Items(focusedItemIndex).UseItemStyleForSubItems = False
                                    // .problemsDataGrid.Items(focusedItemIndex).SubItems(0).ForeColor = Color.Indigo
                                }
                            }
                        }
                    }
                }

                if (withBlock.okToTransferDataGrid.Rows.Count > 0)
                {
                    withBlock.createTransfeRButton.Enabled = true;
                }
                else
                {
                    withBlock.createTransfeRButton.Enabled = false;
                }
            }
        }

        public static bool ValidateContainer(string TextEntry)
        {
            if (Strings.Len(TextEntry) == 11)
            {
                if (Strings.Mid(TextEntry, 4, 1) == Conversions.ToString('U'))
                {
                    return GoodCheckSumNumber(Strings.Mid(TextEntry, 1, 10), Conversions.ToString((char)Conversion.Val(Strings.Mid(TextEntry, 11, 1))));
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool GoodCheckSumNumber(string ContainerNumber, string CheckSum)
        {
            short x;
            short RaiseFactor;
            var Total = default(short);
            short PartTwo;
            short Result;
            short ThisValue;
            string ThisNumber;
            RaiseFactor = 1;
            var loopTo = (short)Strings.Len(ContainerNumber);
            for (x = 1; x <= loopTo; x++)
            {
                ThisNumber = Strings.Mid(ContainerNumber, x, 1);
                if (x >= 1 & x <= 4)
                {
                    ThisValue = (short)GiveAplhaValue(ThisNumber);
                }
                else
                {
                    ThisValue = (short)Math.Round(Conversion.Val(Strings.Mid(ContainerNumber, x, 1)));
                }

                Total = (short)(Total + (short)(ThisValue * RaiseFactor));
                RaiseFactor = (short)(RaiseFactor * 2);
            }

            PartTwo = (short)Math.Round(Conversion.Int(Total / 11d) * 11d);
            Result = (short)(Total - PartTwo);
            if (Result == 10 & CheckSum == Conversions.ToString('\0') | Conversions.ToString((char)Result) == CheckSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GiveAplhaValue(string ThisNumber)
        {
            switch (ThisNumber ?? "")
            {
                case "A":
                    {
                        return 10;
                    }

                case "B":
                    {
                        return 12;
                    }

                case "C":
                    {
                        return 13;
                    }

                case "D":
                    {
                        return 14;
                    }

                case "E":
                    {
                        return 15;
                    }

                case "F":
                    {
                        return 16;
                    }

                case "G":
                    {
                        return 17;
                    }

                case "H":
                    {
                        return 18;
                    }

                case "I":
                    {
                        return 19;
                    }

                case "J":
                    {
                        return 20;
                    }

                case "K":
                    {
                        return 21;
                    }

                case "L":
                    {
                        return 23;
                    }

                case "M":
                    {
                        return 24;
                    }

                case "N":
                    {
                        return 25;
                    }

                case "O":
                    {
                        return 26;
                    }

                case "P":
                    {
                        return 27;
                    }

                case "Q":
                    {
                        return 28;
                    }

                case "R":
                    {
                        return 29;
                    }

                case "S":
                    {
                        return 30;
                    }

                case "T":
                    {
                        return 31;
                    }

                case "U":
                    {
                        return 32;
                    }

                case "V":
                    {
                        return 34;
                    }

                case "W":
                    {
                        return 35;
                    }

                case "X":
                    {
                        return 36;
                    }

                case "Y":
                    {
                        return 37;
                    }

                case "Z":
                    {
                        return 38;
                    }
            }

            return default;
        }

        public static void fillContainerManagementStats()
        {
            string queryConditions = "where Arrive is null";
            System.Data.DataTable containersInTransfer;
            containersInTransfer = db.getTableInfoCeres("[Container Transfers]", "*", queryConditions);
            var transferToEwen = default(int);
            var transferToLindsey = default(int);
            foreach (DataRow transfer in containersInTransfer.Rows)
            {
                if (transfer["Transferred To"].Equals("LINDSEY"))
                {
                    transferToLindsey += 1;
                }
                else if (transfer["Transferred To"].Equals("EWEN"))
                {
                    transferToEwen += 1;
                }
            }

            // With FrmContainerManagement
            // .containersInTransferLabel.Text = containersInTransfer.Rows.Count.ToString
            // .toEwenLabel.Text = "To Ewen" + vbNewLine + transferToEwen.ToString
            // .toLindseyLabel.Text = "To Lindsey" + vbNewLine + transferToLindsey.ToString
            // .toOtherTerminalLabel.Text = "Other" + vbNewLine +
            // (containersInTransfer.Rows.Count - (transferToLindsey + transferToEwen)).ToString
            // End With
        }

        public static void getTransferDetails(string terminalName)
        {
            string queryConditions;
            if (terminalName.Equals("OTHER"))
            {
                queryConditions = "where Arrive is null and " + "([Transferred to] <> 'LINDSEY' AND [Transferred to] <> 'EWEN') order by [Transferred to]";
                My.MyProject.Forms.FrmReminderDetails.titleLabel.Text = "Container Transfers to other terminals";
            }
            else
            {
                queryConditions = "where Arrive is null and [Transferred to] = '" + terminalName + "' ORDER BY [Container Number]";
                My.MyProject.Forms.FrmReminderDetails.titleLabel.Text = "Container Transfers to " + terminalName;
            }

            DataTable containersInTransfer;
            containersInTransfer = db.getTableInfoCeres("[Container Transfers]", "*", queryConditions);
            DateTime dateOfTransfer;
            {
                var withBlock = My.MyProject.Forms.FrmReminderDetails;
                withBlock.Show();
                withBlock.ListView1.Columns.Add("CONTAINER #", 200);
                withBlock.ListView1.Columns.Add("TRANSFERRED TO", 200);
                withBlock.ListView1.Columns.Add("DATE OF TRANSFER", 300);
                withBlock.ListView1.Width = 705;
                foreach (DataRow transfer in containersInTransfer.Rows)
                {
                    dateOfTransfer = Conversions.ToDate(transfer["Departure"]);
                    withBlock.ListView1.Items.Add(new ListViewItem(new[] { Conversions.ToString(transfer["Container Number"]), Conversions.ToString(transfer["Transferred To"]), dateOfTransfer.ToString("MMM dd, yyyy HH:mm") }));
                }

                withBlock.ListView1.Update();
            }
        }

        public static string GiveEDITick(char EDIStatus)
        {
            if (EDIStatus == '\u0001')
            {
                return "√";
            }
            else
            {
                return "";
            }
        }

        public static string GiveGateStatus(char GateMode, char Status)
        {
            if (GateMode == '\u0001' & Status == '\u0001')
            {
                return "VALID";
            }
            else if (GateMode == '\u0001' & Status == '\u0002')
            {
                return "TROUBLE";
            }
            else if (GateMode == '\u0002' & Status == '\u0001')
            {
                return "VALID";
            }

            return default;
        }

        public static string GiveContainerSize(char CanSize)
        {
            if (CanSize == '\0')
            {
                return "20Ft";
            }
            else if (CanSize == '\u0001')
            {
                return "40Ft SC";
            }
            else if (CanSize == '\u0002')
            {
                return "53Ft";
            }
            else if (CanSize == '\u0003')
            {
                return "40Ft HC";
            }
            else
            {
                return "";
            }
        }

        public static YardTabletControls.GeneralFunctions DoFunctions = new YardTabletControls.GeneralFunctions();

        public static void populateInGateInfo(FrmAddEditInGate form, int rowID)
        {
            foreach (DataRow row in dbCeres.getTableInfo("[Containers In-Out]", "*", "where [Unique ID] = " + rowID.ToString()).Rows)
            {
                bool noWeight = false;
                bool noSeal = false;
                if (Information.IsDBNull(row["CargoWeight"]))
                {
                    noWeight = true;
                }
                else if (string.IsNullOrEmpty(Conversions.ToString(row["CargoWeight"])))
                {
                    noWeight = true;
                }

                if (Information.IsDBNull(row["Seal Number"]))
                {
                    noSeal = true;
                }
                else if (string.IsNullOrEmpty(Conversions.ToString(row["Seal Number"])))
                {
                    noSeal = true;
                }

                if (Information.IsDBNull(row["Terminal Code In"]))
                {
                    form.fromComboBox.SelectedItem = "N/A";
                }
                else
                {
                    form.fromComboBox.SelectedItem = Strings.Trim(Conversions.ToString(row["Terminal Code In"])) + " (" + Strings.Trim(Conversions.ToString(row["Terminal Name In"])) + ")";
                }

                if (Strings.Trim(Conversions.ToString(row["Yard Code In"])).Equals("EWEN"))
                {
                    form.toBunifuDropdown.SelectedItem = "EWEN (WTC GROUP)";
                }
                else if (Strings.Trim(Conversions.ToString(row["Yard Code In"])).Equals("LINDSEY"))
                {
                    form.toBunifuDropdown.SelectedItem = "LINDSEY (WTC GROUP)";
                }
                else
                {
                    form.toBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["Yard Code In"])) + " (" + Strings.Trim(Conversions.ToString(row["Yard Name In"])) + ")";
                }

                if (!Information.IsDBNull(row["Street Turn"]))
                {
                    form.streetTurnBunifuCheckBox.Checked = Conversions.ToBoolean(row["Street Turn"]);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Street Turn"], true, false)))
                    {
                        form.releaseTableLayoutPanel.Hide();
                    }
                    else
                    {
                        form.releaseTableLayoutPanel.Show();
                    }
                }

                if (!Information.IsDBNull(row["Release Number"]))
                {
                    form.releaseNumberBunifuTextBox.Text = Strings.Trim(Conversions.ToString(row["Release Number"]));
                }
                else
                {
                    form.releaseNumberBunifuTextBox.Text = "";
                }

                if (Information.IsDBNull(row["Trouble In-Gate"]))
                {
                    form.troubleBunifuToggleSwitch1.Value = false;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Trouble In-Gate"], false, false)))
                {
                }
                else
                {
                    form.troubleBunifuToggleSwitch1.Value = true;
                }

                form.dateDateTimePicker.Value = Conversions.ToDate(row["Gate Date In"]);
                form.timeDateTimePicker.Value = Conversions.ToDate(row["Gate Date In"]);
                form.carrierBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["Carrier Code In"])) + " (" + Strings.Trim(Conversions.ToString(row["Carrier Name In"])) + ")";
                form.truckNumberBunifuDropdown1.SelectedItem = Strings.Trim(Conversions.ToString(row["Carrier Truck In"]));
                if (Strings.Trim(Conversions.ToString(row["SS Line Code In"])).Equals(""))
                {
                    form.shippingLineBunifuDropdown.SelectedItem = "N/A";
                }
                else if (Strings.Trim(Conversions.ToString(row["SS Line Code In"])).Equals("N/A"))
                {
                    form.shippingLineBunifuDropdown.SelectedItem = "N/A";
                }
                else
                {
                    string shippingLine = Conversions.ToString(dbCeres.getTableInfo("VW_CompanyCompanyType", "CompanyName", "where Companycode = '" + Strings.Trim(Conversions.ToString(row["SS Line Code In"])) + "' and [DescCompanyType] = 'Steamship Line' ").Rows[0]["CompanyName"]);
                    form.shippingLineBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["SS Line Code In"])) + " (" + Strings.Trim(shippingLine.ToUpper()) + ")";
                }

                form.containerBunifuTextBox.Text = Strings.Trim(Conversions.ToString(row["Container Number"]));
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition In"], '\0', false)))
                {
                    form.statusBunifuDropdown.SelectedIndex = 0;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition In"], '\u0001', false)))
                {
                    form.statusBunifuDropdown.SelectedIndex = 1;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition In"], '\u0002', false)))
                {
                    form.statusBunifuDropdown.SelectedIndex = 2;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition In"], '\u0003', false)))
                {
                    form.statusBunifuDropdown.SelectedIndex = 3;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\0', false)))
                {
                    form.damagesDropdown.SelectedIndex = 0;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\u0001', false)))
                {
                    form.damagesDropdown.SelectedIndex = 1;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\u0002', false)))
                {
                    form.damagesDropdown.SelectedIndex = 2;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\u0003', false)))
                {
                    form.damagesDropdown.SelectedIndex = 3;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\u0004', false)))
                {
                    form.damagesDropdown.SelectedIndex = 4;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\u0005', false)))
                {
                    form.damagesDropdown.SelectedIndex = 5;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\u0006', false)))
                {
                    form.damagesDropdown.SelectedIndex = 6;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damage In"], '\a', false)))
                {
                    form.damagesDropdown.SelectedIndex = 7;
                }

                // If row["Container Size"] = ChrW(0) Then
                // .sizeBunifuDropdown.SelectedIndex = 0
                // ElseIf row["Container Size"] = ChrW(1) Then
                // .sizeBunifuDropdown.SelectedIndex = 1
                // ElseIf row["Container Size"] = ChrW(2) Then
                // .sizeBunifuDropdown.SelectedIndex = 2
                // ElseIf row["Container Size"] = ChrW(3) Then
                // .sizeBunifuDropdown.SelectedIndex = 3
                // End If

                if (!Information.IsDBNull(row["ContainerSize"]))
                {
                    form.sizeBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["ContainerSize"]));
                }
                else
                {
                    form.sizeBunifuDropdown.SelectedItem = "20 FT";
                }

                form.maxWeightBunifuTextBox.Text = Conversions.ToString(row["GrossWeightIn"]);
                form.tareWeightBunifuTextBox.Text = Conversions.ToString(row["TAREWeightIn"]);
                form.commentsRichTextBox.Text = Strings.Trim(Conversions.ToString(row["Comments In"]));
            }
        }

        public static void populateOutGateInfo(FrmAddEditOutGate form, int rowID)
        {
            foreach (DataRow row in dbCeres.getTableInfo("[Containers In-Out]", "*", "where [Unique ID] = " + rowID.ToString()).Rows)
            {
                bool noWeight = false;
                bool noSeal = false;
                if (!Information.IsDBNull(row["Terminal Code Out"]))
                {
                    form.toBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["Terminal Code Out"])) + " (" + Strings.Trim(Conversions.ToString(row["Terminal Name Out"])) + ")";
                }
                else
                {
                    form.toBunifuDropdown.SelectedItem = "N/A";
                }

                if (!Information.IsDBNull(row["Yard Code Out"]))
                {
                    if (Strings.Trim(Conversions.ToString(row["Yard Code Out"])).Equals("EWEN"))
                    {
                        form.fromComboBox.SelectedItem = "EWEN (WTC GROUP)";
                    }
                    else if (Strings.Trim(Conversions.ToString(row["Yard Code Out"])).Equals("LINDSEY"))
                    {
                        form.fromComboBox.SelectedItem = "LINDSEY (WTC GROUP)";
                    }
                    else
                    {
                        form.fromComboBox.SelectedItem = Strings.Trim(Conversions.ToString(row["Yard Code Out"])) + " (" + Strings.Trim(Conversions.ToString(row["Yard Name Out"])) + ")";
                    }
                }
                else
                {
                    form.fromComboBox.SelectedItem = "N/A";
                }

                if (!Information.IsDBNull(row["Booking Number"]))
                {
                    form.bookingNumberBunifuTextBox.Text = Strings.Trim(Conversions.ToString(row["Release Number"]));
                }

                if (!Information.IsDBNull(row["Seal Number"]))
                {
                    form.bookingNumberBunifuTextBox.Text = Strings.Trim(Conversions.ToString(row["Release Number"]));
                }

                if (Information.IsDBNull(row["Hold Out-Gate"]))
                {
                    form.holdBunifuToggleSwitch1.Value = false;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Hold Out-Gate"], false, false)))
                {
                    form.holdBunifuToggleSwitch1.Value = false;
                }
                else
                {
                    form.holdBunifuToggleSwitch1.Value = true;
                }

                if (!Information.IsDBNull(row["Gate Date Out"]))
                {
                    form.dateDateTimePicker.Value = Conversions.ToDate(row["Gate Date Out"]);
                    form.timeDateTimePicker.Value = Conversions.ToDate(row["Gate Date Out"]);
                }
                else
                {
                    form.dateDateTimePicker.Value = DateAndTime.Now;
                    form.timeDateTimePicker.Value = DateAndTime.Now;
                }

                if (!Information.IsDBNull(row["Carrier Code Out"]))
                {
                    form.carrierBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["Carrier Code Out"])) + " (" + Strings.Trim(Conversions.ToString(row["Carrier Name Out"])) + ")";
                }
                else
                {
                    form.carrierBunifuDropdown.SelectedItem = "N/A";
                }

                if (!Information.IsDBNull(row["Carrier Truck Out"]))
                {
                    form.truckNumberBunifuDropdown1.SelectedItem = Strings.Trim(Conversions.ToString(row["Carrier Truck Out"]));
                }
                else
                {
                    form.truckNumberBunifuDropdown1.SelectedItem = "N/A";
                }

                if (!Information.IsDBNull(row["SS Line Code Out"]))
                {
                    if (!Strings.Trim(Conversions.ToString(row["SS Line Code Out"])).Equals("N/A"))
                    {
                        string shippingLine = Conversions.ToString(dbCeres.getTableInfo("VW_CompanyCompanyType", "CompanyName", "where Companycode = '" + Strings.Trim(Conversions.ToString(row["SS Line Code Out"])) + "' and [DescCompanyType] = 'Steamship Line' ").Rows[0]["CompanyName"]);
                        form.shippingLineBunifuDropdown.SelectedItem = Strings.Trim(Conversions.ToString(row["SS Line Code Out"])) + " (" + Strings.Trim(shippingLine.ToUpper()) + ")";
                    }
                    else
                    {
                        form.shippingLineBunifuDropdown.SelectedItem = "N/A";
                    }
                }

                if (!Information.IsDBNull(row["Booking Number"]))
                {
                    form.bookingNumberBunifuTextBox.Text = Strings.Trim(Conversions.ToString(row["Booking Number"]));
                }
                else
                {
                    form.bookingNumberBunifuTextBox.Text = "";
                }

                if (!Information.IsDBNull(row["Seal Number"]))
                {
                    form.sealNumberBunifuTextBox2.Text = Strings.Trim(Conversions.ToString(row["Seal Number"]));
                }
                else
                {
                    form.sealNumberBunifuTextBox2.Text = "";
                }

                form.containerBunifuTextBox.Text = Strings.Trim(Conversions.ToString(row["Container Number"]));
                if (!Information.IsDBNull(row["Condition Out"]))
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition Out"], '\0', false)))
                    {
                        form.statusBunifuDropdown.SelectedIndex = 0;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition Out"], '\u0001', false)))
                    {
                        form.statusBunifuDropdown.SelectedIndex = 1;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition Out"], '\u0002', false)))
                    {
                        form.statusBunifuDropdown.SelectedIndex = 2;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Condition Out"], '\u0003', false)))
                    {
                        form.statusBunifuDropdown.SelectedIndex = 3;
                    }
                }
                else
                {
                    form.statusBunifuDropdown.SelectedIndex = 0;
                }

                if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\0', false)))
                {
                    form.damagesDropdown.SelectedIndex = 0;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\u0001', false)))
                {
                    form.damagesDropdown.SelectedIndex = 1;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\u0002', false)))
                {
                    form.damagesDropdown.SelectedIndex = 2;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\u0003', false)))
                {
                    form.damagesDropdown.SelectedIndex = 3;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\u0004', false)))
                {
                    form.damagesDropdown.SelectedIndex = 4;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\u0005', false)))
                {
                    form.damagesDropdown.SelectedIndex = 5;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\u0006', false)))
                {
                    form.damagesDropdown.SelectedIndex = 6;
                }
                else if (!Information.IsDBNull(row["Damages Out"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["Damages Out"], '\a', false)))
                {
                    form.damagesDropdown.SelectedIndex = 7;
                }
                else
                {
                    form.damagesDropdown.SelectedIndex = 0;
                }

                // If Not IsDBNull(row["Container Size"]) AndAlso row["Container Size"] = ChrW(0) Then
                // .sizeBunifuDropdown.SelectedIndex = 0
                // ElseIf Not IsDBNull(row["Container Size"]) AndAlso row["Container Size"] = ChrW(1) Then
                // .sizeBunifuDropdown.SelectedIndex = 1
                // ElseIf Not IsDBNull(row["Container Size"]) AndAlso row["Container Size"] = ChrW(2) Then
                // .sizeBunifuDropdown.SelectedIndex = 2
                // ElseIf Not IsDBNull(row["Container Size"]) AndAlso row["Container Size"] = ChrW(3) Then
                // .sizeBunifuDropdown.SelectedIndex = 3
                // Else
                // .sizeBunifuDropdown.SelectedIndex = 0
                // End If
                if (!Information.IsDBNull(row["ContainerSize"]))
                {
                    form.sizeBunifuDropdown.SelectedItem = row["ContainerSize"];
                }
                else
                {
                    form.sizeBunifuDropdown.SelectedItem = "20 FT";
                }

                // If Not IsDBNull(row["Gross Weight Out"]) Then
                // .maxWeightBunifuTextBox.Text = DoFunctions.CVS(row["Gross Weight Out"])
                // Else
                // .maxWeightBunifuTextBox.Text = ""
                // End If

                // If Not IsDBNull(row["TARE Weight Out"]) Then
                // .tareWeightBunifuTextBox.Text = DoFunctions.CVS(row["TARE Weight Out"])
                // Else
                // .tareWeightBunifuTextBox.Text = ""
                // End If

                // If Not IsDBNull(row["Cargo Weight Out"]) Then
                // .cargoBunifuTextBox1.Text = DoFunctions.CVS(row["Cargo Weight Out"])
                // Else
                // .cargoBunifuTextBox1.Text = ""
                // End If

                if (!Information.IsDBNull(row["GrossWeightOut"]))
                {
                    form.maxWeightBunifuTextBox.Text = Conversions.ToString(row["GrossWeightOut"]);
                }
                else
                {
                    form.maxWeightBunifuTextBox.Text = "";
                }

                if (!Information.IsDBNull(row["TAREWeightOut"]))
                {
                    form.tareWeightBunifuTextBox.Text = Conversions.ToString(row["TAREWeightOut"]);
                }
                else
                {
                    form.tareWeightBunifuTextBox.Text = "";
                }

                if (!Information.IsDBNull(row["CargoWeight"]))
                {
                    form.cargoBunifuTextBox1.Text = Conversions.ToString(row["CargoWeight"]);
                }
                else
                {
                    form.cargoBunifuTextBox1.Text = "";
                }

                if (!Information.IsDBNull(row["Comments out"]))
                {
                    form.commentsRichTextBox.Text = Strings.Trim(Conversions.ToString(row["Comments Out"]));
                }
                else
                {
                    form.commentsRichTextBox.Text = "";
                }
            }
        }

        public static void saveInGate(int inGateID, FrmAddEditInGate focusedForm)
        {
            string containerSize;
            var status = default(char);
            double grossWeight;
            double tareWeight;
            char damages;
            bool sendEDI;
            string terminalCode;
            string terminalName;
            string yardCode;
            string yardName;
            string ssLineCode;
            string ssLineName;
            string carrierCode;
            string carrierName;
            bool shouldSendEDI;
            object tempValue;
            damages = (char)focusedForm.damagesDropdown.SelectedIndex;
            // tempValue = Val(focusedForm.tareWeightBunifuTextBox.Text)
            // tareWeight = DoFunctions.MKS(tempValue)

            grossWeight = Conversion.Val(focusedForm.maxWeightBunifuTextBox.Text);
            // grossWeight = DoFunctions.MKS(tempValue)

            // status = ChrW(focusedForm.statusBunifuDropdown.SelectedIndex)
            containerSize = Conversions.ToString(focusedForm.sizeBunifuDropdown.SelectedItem);
            tareWeight = Conversions.ToDouble(focusedForm.tareWeightBunifuTextBox.Text);
            // tareWeight = DoFunctions.MKS(tempValue)

            if (!focusedForm.fromComboBox.SelectedItem.Equals("N/A"))
            {
                terminalCode = Strings.Trim(focusedForm.fromComboBox.SelectedItem.ToString().Split('(')[0]);
                terminalName = Strings.Trim(focusedForm.fromComboBox.SelectedItem.ToString().Split('(')[1].Split(')')[0]);
            }
            else
            {
                terminalCode = "N/A";
                terminalName = "N/A";
            }

            if (!focusedForm.toBunifuDropdown.SelectedItem.Equals("N/A"))
            {
                yardCode = Strings.Trim(focusedForm.toBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                yardName = Strings.Trim(focusedForm.toBunifuDropdown.SelectedItem.ToString().Split('(')[1].Split(')')[0]);
            }
            else
            {
                yardCode = "N/A";
                yardName = "N/A";
            }

            if (!focusedForm.shippingLineBunifuDropdown.SelectedItem.Equals("N/A"))
            {
                ssLineCode = Strings.Trim(focusedForm.shippingLineBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                ssLineName = Conversions.ToString(focusedForm.shippingLineBunifuDropdown.SelectedItem);
            }
            else
            {
                ssLineCode = "N/A";
                ssLineName = "N/A";
            }

            if (!focusedForm.carrierBunifuDropdown.SelectedItem.Equals("N/A"))
            {
                carrierCode = Strings.Trim(focusedForm.carrierBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                carrierName = Strings.Trim(focusedForm.carrierBunifuDropdown.SelectedItem.ToString().Split('(')[1].Split(')')[0]);
            }
            else
            {
                carrierCode = "N/A";
                carrierName = "N/A";
            }

            string releaseNumber = "";
            if (focusedForm.streetTurnBunifuCheckBox.Checked == true)
            {
                releaseNumber = "STREET TURN";
            }
            else
            {
                releaseNumber = Strings.Trim(focusedForm.releaseNumberBunifuTextBox.Text);
            }

            if (focusedForm.sendEDIBunifuToggleSwitch.Value == true)
            {
                sendEDI = Conversions.ToBoolean(0);
                shouldSendEDI = Conversions.ToBoolean(1);
            }
            else
            {
                sendEDI = Conversions.ToBoolean(1);
                shouldSendEDI = Conversions.ToBoolean(0);
            }

            DateTime gateDateTime;
            DateTime gateDateTimeTR;
            gateDateTimeTR = Conversions.ToDate(focusedForm.dateDateTimePicker.Value.ToShortDateString() + " " + focusedForm.timeDateTimePicker.Value.ToShortTimeString());
            gateDateTime = Convert.ToDateTime(gateDateTimeTR);
            dbCeres.saveOrUpdateInGate(inGateID, terminalCode, terminalName, yardCode, yardName, gateDateTime, gateDateTime, focusedForm.streetTurnBunifuCheckBox.Checked, releaseNumber, carrierCode, carrierName, Conversions.ToString(focusedForm.truckNumberBunifuDropdown1.SelectedItem), ssLineCode, ssLineName, Strings.Trim(focusedForm.containerBunifuTextBox.Text), containerSize, status, (decimal)grossWeight, (decimal)tareWeight, damages, Strings.Trim(focusedForm.commentsRichTextBox.Text), sendEDI, focusedForm.troubleBunifuToggleSwitch1.Value, shouldSendEDI);
            lastrecordID = Conversions.ToInteger(dbCeres.lastRecordInserted);

            // If focusedForm.sendEDIBunifuToggleSwitch.Value = True Then
            // dbCeres.saveEDIRecord(lastrecordID, "IN-GATE", "IN-GATE", FrmLoginWindow._userID, FrmLoginWindow._employeeName)
            // End If
        }

        public static int lastrecordID;

        public static void saveOutGate(int inGateID, FrmAddEditOutGate focusedForm)
        {
            string containerSize;
            var status = default(char);
            double grossWeight;
            double cargoWeight;
            double tareWeight;
            char damages;
            bool sendEDI;
            string terminalCodeTo;
            string terminalNameTo;
            string yardCodeFrom;
            string yardNameFrom;
            string ssLineCode;
            string ssLineName;
            string carrierCode;
            string carrierName;
            bool shouldSendEDI;
            bool holdOutGate;
            string bookingNumber;
            string sealNumber;
            string comments;
            string containerNumber;
            string workstation;
            object tempValue;
            damages = (char)focusedForm.damagesDropdown.SelectedIndex;
            if (focusedForm.tareWeightBunifuTextBox.Text.Equals(""))

                tareWeight = 0;

            else
                tareWeight = Conversions.ToDouble(focusedForm.tareWeightBunifuTextBox.Text);
            // tareWeight = DoFunctions.MKS(tempValue)

            grossWeight = Conversions.ToDouble(focusedForm.maxWeightBunifuTextBox.Text);
            // grossWeight = DoFunctions.MKS(tempValue)

            // status = ChrW(focusedForm.statusBunifuDropdown.SelectedIndex)
            containerSize = Conversions.ToString(focusedForm.sizeBunifuDropdown.SelectedItem);

            // tempValue = Val(focusedForm.tareWeightBunifuTextBox.Text)
            // tareWeight = DoFunctions.MKS(tempValue)

            cargoWeight = Conversions.ToDouble(focusedForm.cargoBunifuTextBox1.Text);
            // cargoWeight = Val(DoFunctions.MKS(tempValue))

            if (!focusedForm.fromComboBox.SelectedItem.Equals("N/A"))
            {
                yardCodeFrom = Strings.Trim(focusedForm.fromComboBox.SelectedItem.ToString().Split('(')[0]);
                yardNameFrom = Strings.Trim(focusedForm.fromComboBox.SelectedItem.ToString().Split('(')[1].Split(')')[0]);
            }
            else
            {
                yardCodeFrom = "N/A";
                yardNameFrom = "N/A";
            }

            if (!focusedForm.toBunifuDropdown.SelectedItem.Equals("N/A"))
            {
                terminalCodeTo = Strings.Trim(focusedForm.toBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                terminalNameTo = Strings.Trim(focusedForm.toBunifuDropdown.SelectedItem.ToString().Split('(')[1].Split(')')[0]);
            }
            else
            {
                terminalCodeTo = "N/A";
                terminalNameTo = "N/A";
            }

            if (!focusedForm.shippingLineBunifuDropdown.SelectedItem.Equals("N/A"))
            {
                ssLineCode = Strings.Trim(focusedForm.shippingLineBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                ssLineName = Conversions.ToString(focusedForm.shippingLineBunifuDropdown.SelectedItem);
            }
            else
            {
                ssLineCode = "N/A";
                ssLineName = "N/A";
            }

            if (!focusedForm.carrierBunifuDropdown.SelectedItem.Equals("N/A"))
            {
                carrierCode = Strings.Trim(focusedForm.carrierBunifuDropdown.SelectedItem.ToString().Split('(')[0]);
                carrierName = Strings.Trim(focusedForm.carrierBunifuDropdown.SelectedItem.ToString().Split('(')[1].Split(')')[0]);
            }
            else
            {
                carrierCode = "N/A";
                carrierName = "N/A";
            }

            if (focusedForm.sendEDIBunifuToggleSwitch.Value == true)
            {
                sendEDI = Conversions.ToBoolean(0);
                shouldSendEDI = Conversions.ToBoolean(1);
            }
            else
            {
                sendEDI = Conversions.ToBoolean(1);
                shouldSendEDI = Conversions.ToBoolean(0);
            }

            bookingNumber = Strings.Trim(focusedForm.bookingNumberBunifuTextBox.Text);
            sealNumber = Strings.Trim(focusedForm.sealNumberBunifuTextBox2.Text);
            comments = Strings.Trim(focusedForm.commentsRichTextBox.Text);
            holdOutGate = focusedForm.holdBunifuToggleSwitch1.Value;
            containerNumber = Strings.Trim(focusedForm.containerBunifuTextBox.Text);
            workstation = My.MyProject.Computer.Name;
            DateTime gateDateTime;
            DateTime gateDateTimeTR;
            gateDateTimeTR = Conversions.ToDate(focusedForm.dateDateTimePicker.Value.ToShortDateString() + " " + focusedForm.timeDateTimePicker.Value.ToShortTimeString());
            gateDateTime = Convert.ToDateTime(gateDateTimeTR);
            dbCeres.saveOrUpdateOutGate(inGateID, terminalCodeTo, terminalNameTo, yardCodeFrom, yardNameFrom, gateDateTime, gateDateTime, bookingNumber, sealNumber, carrierCode, carrierName, Conversions.ToString(focusedForm.truckNumberBunifuDropdown1.SelectedItem), ssLineCode, ssLineName, containerNumber, containerSize, status, (decimal)grossWeight, (decimal)tareWeight, (decimal)cargoWeight, damages, comments, sendEDI, holdOutGate, shouldSendEDI, workstation);

            // If focusedForm.sendEDIBunifuToggleSwitch.Value = True Then
            // dbCeres.saveEDIRecord(inGateID, "OUT-GATE", "OUT-GATE", FrmLoginWindow._userID, FrmLoginWindow._employeeName)
            // End If
        }

        public static bool IsExcelFileOpened(string WorkBookName)
        {
            bool IsExcelFileOpenedRet = default;
            FileStream fs;
            IsExcelFileOpenedRet = false;
            try
            {
                fs = File.OpenWrite(WorkBookName);
                fs.Close();
            }
            catch (Exception ex)
            {
                IsExcelFileOpenedRet = true;
            }

            return IsExcelFileOpenedRet;
        }

        public static string GiveEquipmentType(string EQCode, char UntiNumber)
        {
            if (Strings.Mid(EQCode, 1, 1) == "A")
            {
                return DoFunctions.PadToString("BOX", 6);
            }
            else if (Strings.Mid(EQCode, 1, 1) == "C")
            {
                return DoFunctions.PadToString("HOPPER", 6);
            }
            else if (Strings.Mid(EQCode, 1, 1) == "U")
            {
                return DoFunctions.PadToString("IMDL", 6);
            }
            else if (Conversions.ToString(UntiNumber) == "U")
            {
                return DoFunctions.PadToString("IMDL", 6);
            }
            else
            {
                return DoFunctions.PadToString(Conversions.ToString(' '), 6);
            }
        }

        public static string StripCommas(string ThisText)
        {
            short x = 0;
            string TempLine = "";
            TempLine = Conversions.ToString('"') + ThisText + Conversions.ToString('"');
            return TempLine;
        }

        public struct RailSight
        {
            public string UnitNumber;
            public string CustomerName;
            public char UnitStatus;
            public string LastUpdate;
            public string ETADate;
            public string ETADays;
            public string SightingLocation;
            public string CallDate;
            public string ArrivalDate;
            public string WayBillDate;
            public string ShipperName;
            public string OriginLocation;
            public string SASC;
            public string EquipType;
            public string WgtMT;
            public string Bags;
            public string CaargoDescription;
            public string BookingNumbers;
        }

        public static string FetchAllCarriers()
        {
            string Sql = "";
            string TempLine = "";
            Sql = "Select [OWNID], [Company] From [Trucking Companies]  Order By [Company]";
            var DbObjDataTable = new System.Data.DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter(Sql, DatabaseHelperCeres.StrConnWTCCeres);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow CarrierRow in DbObjDataTable.Rows)
                TempLine = Conversions.ToString(TempLine + Operators.AddObject(CarrierRow["OWNID"], CarrierRow["Company"]));
            return TempLine;
        }

        public static bool ShouldHoldBooking(string BookingNum)
        {
            int x;
            if (Strings.Len(BookingNum) >= 4)
            {
                var loopTo = Strings.Len(BookingNum);
                for (x = 1; x <= loopTo; x++)
                {
                    if (Strings.Mid(BookingNum, x, 4) == "HOLD")
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        public static string AssignContainerSize(object ContainerSize)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerSize, "20' (8'6'')", false)))
            {
                return Conversions.ToString('\0');
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerSize, "40' (8'6'')", false)))
            {
                return Conversions.ToString('\u0001');
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerSize, "40' HC (9'6'')", false)))
            {
                return Conversions.ToString('\u0001');
            }
            else
            {
                return Conversions.ToString('\n');
            }
        }

        public static string FetchShippingLines()
        {
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select SLCode, Name From [Shipping Line] Order by Name Asc", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new System.Data.DataTable();
            short x;
            string ShipLineCode;
            string ShipLineName;
            string FinalLine;
            DbObjAdapter.Fill(DbObjDataTable);
            FinalLine = "";
            var loopTo = (short)(DbObjDataTable.Rows.Count - 1);
            for (x = 0; x <= loopTo; x++)
            {
                ShipLineCode = Conversions.ToString(DbObjDataTable.Rows[x]["SLCode"]).ToUpper();
                ShipLineName = DoFunctions.PadToString("(" + Strings.RTrim(ShipLineCode) + ") " + Strings.RTrim(Conversions.ToString(DbObjDataTable.Rows[(int)x]["Name"]).ToUpper()), (short)50);
                FinalLine += ShipLineCode + ShipLineName;
            }

            return FinalLine;
        }

        public static bool FetchExcelFiles(string BookNumber, string ExcelFile, string ShippingLines, int mbId)
        {
            bool OpenedExcel = false;
            bool BookHold = false;
            bool BookERD = false;
            string ShipLine;
            string ShipPort;
            var ContainerNumber = default(string);
            string ContainerSize;
            short x;
            short NumOfContainers = 0;
            string LRDDate = "";
            string ERDDate = "";
            string VesselName = "";
            string VoyageNumber = "";
            string Destination = "";
            bool GoodPush;
            foreach (var ThisExcelFile in Directory.GetFiles(Conversions.ToString(focusedPath), ExcelFile.Replace(Microsoft.VisualBasic.Constants.vbTab, "") + "*.XLS", SearchOption.TopDirectoryOnly))
            {
                var FileInfo = new FileInfo(ThisExcelFile);
                if (File.Exists(ThisExcelFile))
                {
                    // Try
                    XLWorkbook = Excel.Workbooks.Open(ThisExcelFile, ReadOnly: true);
                    XLWorkbook.Application.DisplayAlerts = false;
                    OpenedExcel = true;
                    Worksheet BookSetupSheet = (Worksheet)XLWorkbook.Sheets[(object)1];
                    Worksheet VGMsheet = (Worksheet)XLWorkbook.Sheets[(object)3];
                    var r = VGMsheet.UsedRange;
                    object[,] VGMArray = (object[,])r.get_Value(XlRangeValueDataType.xlRangeValueDefault);
                    if (VGMArray is object)
                    {
                        if (VGMArray.GetUpperBound(0) >= 22)
                        {
                            ShipLine = Conversions.ToString(VGMArray[13, 2]);
                            ShipPort = Conversions.ToString(VGMArray[17, 2]);
                            ContainerSize = Conversions.ToString(VGMArray[19, 4]);
                            NumOfContainers = (short)Conversions.ToInteger(VGMArray[19, 2]);
                            x = 1;
                            while (!string.IsNullOrEmpty(Strings.RTrim(Conversions.ToString(VGMArray[21 + x, 1]))))
                            {
                                ContainerNumber = Strings.RTrim(Conversions.ToString(VGMArray[21 + x, 1]));
                                if (!ContainerNumber.Contains("/") && !ContainerNumber.Contains("-"))
                                {
                                    MdlContainerManagement.UpdateDatabase(FileInfo.Name, mbId, GiveExcelShipLineCode(ShipLine), ShipPort, ContainerSize, LRDDate, ERDDate, VesselName, VoyageNumber, ContainerNumber, Conversions.ToString(VGMArray[21 + x, 2]), Conversions.ToString(VGMArray[21 + x, 3]), Conversions.ToString(VGMArray[21 + x, 4]), Conversions.ToString(VGMArray[21 + x, 5]), StripBookingNumber(Conversions.ToString(VGMArray[21 + (int)x, 6]).ToUpper()), MdlContainerManagement.ContainerIsHold((VGMArray[21 + (int)x, 6]).ToString().ToUpper()), Destination, Conversions.ToString(BookSetupSheet.get_Range("I3").get_Value()), ShippingLines);
                                    x = (short)(x + 1);
                                }
                            }
                        }
                    }

                    XLWorkbook.Close();
                    successPushing = true;
                }
                else
                {
                    XLWorkbook.Close(false);
                    successPushing = false;
                    MdlLoadingSetting.waitForm.Close();
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error:", "Could not push container #:" + ContainerNumber, My.MyProject.Forms.FrmParentScreen);
                }
            }

            return successPushing;
        }

        private static void UpdateDatabase(string FileName, int mbId, string ShipLine, string ShipPort, string ContainerSize, string LRDDate, string ERDDate, string VesselName, string VoyageNumber, string ContainerNumber, string SealNumber, string TareWgt, string NetWgt, string GrossWgt, string DeliveredBooking, bool HoldContainer, string Destination, string BookingNumber, string ShippingLines)
        {
            int RecordCount = 0;

            // If ContainerNumber = "" Or Len(ContainerNumber) <> 11 Then
            // successPushing = False
            // Exit Sub
            // ElseIf ValidateContainer(ContainerNumber) = False Then
            // successPushing = False
            // Exit Sub
            // ElseIf SealNumber = "" Or Len(SealNumber) < 3 Then
            // successPushing = False
            // Exit Sub
            // Else
            bool HoldBooking = ShouldHoldBooking(Strings.UCase(DeliveredBooking));
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Containers In-Out] Where [Container Number] = '" + ContainerNumber + "'", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new System.Data.DataTable();
            bool OutGated;
            string ThisCarrierID;
            string CarrierID;
            DbObjAdapter.Fill(DbObjDataTable);
            try
            {
                if (DbObjDataTable.Rows.Count == 0)
                {
                    var DBObj_NewRow = DbObjDataTable.NewRow();
                    DBObj_NewRow["Container Number"] = ContainerNumber;
                    DBObj_NewRow["Container Size"] = AssignContainerSize(ContainerSize);
                    DBObj_NewRow["Booking Number"] = BookingNumber;
                    DBObj_NewRow["Delivered Booking"] = DeliveredBooking;
                    DBObj_NewRow["LRD"] = LRDDate;
                    DBObj_NewRow["ERD"] = ERDDate;
                    DBObj_NewRow["Seal Number"] = SealNumber;
                    DBObj_NewRow["SS Line Code Out"] = ShipLine;
                    DBObj_NewRow["SS Line Name Out"] = GiveShippingLineName(ShipLine, ShippingLines);
                    DBObj_NewRow["Vessel Name"] = VesselName;
                    DBObj_NewRow["Voyage Number"] = VoyageNumber;
                    DBObj_NewRow["Terminal Code Out"] = GiveTerminalCode(ShipPort);
                    DBObj_NewRow["Terminal Name Out"] = ShipPort;
                    DBObj_NewRow["Cargo Weight Out"] = DoFunctions.MKS((float)Conversion.Val(NetWgt));
                    DBObj_NewRow["Tare Weight Out"] = DoFunctions.MKS((float)Conversion.Val(TareWgt));
                    DBObj_NewRow["Gross Weight Out"] = DoFunctions.MKS((float)Conversion.Val(GrossWgt));
                    DBObj_NewRow["Excel Filename Out"] = FileName;
                    DBObj_NewRow["MinibookingID"] = mbId;
                    DBObj_NewRow["Container Out-Gated"] = false;
                    if (HoldContainer == true)
                    {
                        DBObj_NewRow["Hold Out-Gate"] = true;
                    }
                    else
                    {
                        DBObj_NewRow["Hold Out-Gate"] = HoldBooking;
                    }

                    DBObj_NewRow["Export Destination"] = Destination;
                    DBObj_NewRow["CargoWeight"] = Conversion.Val(Strings.Format(Conversion.Val(NetWgt), "#,0.000"));
                    DBObj_NewRow["GrossWeightOut"] = Conversion.Val(Strings.Format(Conversion.Val(GrossWgt), "#,0.000"));
                    DBObj_NewRow["TareWeightOut"] = Conversion.Val(Strings.Format(Conversion.Val(TareWgt), "#,0.000"));
                    DbObjDataTable.Rows.Add(DBObj_NewRow);
                    DbObjAdapter.Update(DbObjDataTable);
                }
                else
                {
                    RecordCount = DbObjDataTable.Rows.Count - 1;
                    if (Information.IsDBNull(DbObjDataTable.Rows[RecordCount]["Container Out-Gated"]) == true)
                    {
                        OutGated = false;
                    }
                    else
                    {
                        OutGated = Conversions.ToBoolean(DbObjDataTable.Rows[RecordCount]["Container Out-Gated"]);
                    }

                    DbObjDataTable.Rows[RecordCount]["Booking Number"] = BookingNumber;
                    DbObjDataTable.Rows[RecordCount]["Delivered Booking"] = DeliveredBooking;
                    if (LRDDate.Equals(""))
                    {
                        DbObjDataTable.Rows[RecordCount]["LRD"] = DBNull.Value;
                    }
                    else
                    {
                        DbObjDataTable.Rows[RecordCount]["LRD"] = LRDDate;
                    }

                    if (ERDDate.Equals(""))
                    {
                        DbObjDataTable.Rows[RecordCount]["ERD"] = DBNull.Value;
                    }
                    else
                    {
                        DbObjDataTable.Rows[RecordCount]["ERD"] = ERDDate;
                    }

                    DbObjDataTable.Rows[RecordCount]["Seal Number"] = SealNumber;
                    DbObjDataTable.Rows[RecordCount]["SS Line Code Out"] = ShipLine;
                    DbObjDataTable.Rows[RecordCount]["SS Line Name Out"] = GiveShippingLineName(ShipLine, ShippingLines);
                    DbObjDataTable.Rows[RecordCount]["Vessel Name"] = VesselName;
                    DbObjDataTable.Rows[RecordCount]["Voyage Number"] = VoyageNumber;
                    DbObjDataTable.Rows[RecordCount]["Terminal Code Out"] = GiveTerminalCode(ShipPort).Split(')')[0].Replace("(", "");
                    DbObjDataTable.Rows[RecordCount]["Terminal Name Out"] = ShipPort;
                    DbObjDataTable.Rows[RecordCount]["Cargo Weight Out"] = DoFunctions.MKS((float)Conversion.Val(NetWgt));
                    DbObjDataTable.Rows[RecordCount]["Tare Weight Out"] = DoFunctions.MKS((float)Conversion.Val(TareWgt));
                    DbObjDataTable.Rows[RecordCount]["Gross Weight Out"] = DoFunctions.MKS((float)Conversion.Val(GrossWgt));
                    DbObjDataTable.Rows[RecordCount]["Excel Filename Out"] = FileName;
                    DbObjDataTable.Rows[RecordCount]["MinibookingID"] = mbId;
                    if (HoldContainer == true)
                    {
                        DbObjDataTable.Rows[RecordCount]["Hold Out-Gate"] = true;
                    }
                    else
                    {
                        DbObjDataTable.Rows[RecordCount]["Hold Out-Gate"] = HoldBooking;
                    }

                    DbObjDataTable.Rows[RecordCount]["Export Destination"] = Destination;
                    DbObjDataTable.Rows[RecordCount]["CargoWeight"] = Conversion.Val(Strings.Format(Conversion.Val(NetWgt), "#,0.000"));
                    DbObjDataTable.Rows[RecordCount]["GrossWeightOut"] = Conversion.Val(Strings.Format(Conversion.Val(GrossWgt), "#,0.000"));
                    DbObjDataTable.Rows[RecordCount]["TareWeightOut"] = Conversion.Val(Strings.Format(Conversion.Val(TareWgt), "#,0.000"));
                    DbObjAdapter.Update(DbObjDataTable);
                }
            }
            catch (Exception ex)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error updating container #: " + ContainerNumber, "Error: " + ex.Message, My.MyProject.Forms.FrmBookingList);
            }

            // End If
        }

        private static string StripBookingNumber(string BookNumber)
        {
            short x = 0;
            char ThisChar;
            string TempLine = "";
            var loopTo = (short)Strings.Len(BookNumber);
            for (x = 1; x <= loopTo; x++)
            {
                ThisChar = Conversions.ToChar(Strings.Mid(BookNumber, x, 1));
                if (ThisChar >= '0' & ThisChar <= '9' | ThisChar >= 'A' & ThisChar <= 'Z')
                {
                    TempLine += Conversions.ToString(ThisChar);
                }
                else
                {
                    return TempLine;
                }
            }

            return BookNumber;
        }

        public static bool ContainerIsHold(object DeliveredBooking)
        {
            if (Strings.Mid(Conversions.ToString(DeliveredBooking), Strings.Len(DeliveredBooking) - 4, 5) == "-HOLD")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GiveShippingLineName(string ShipLineCode, string ShippingLines)
        {
            short x;
            var loopTo = (short)Strings.Len(ShippingLines);
            for (x = 1; x <= loopTo; x += 60)
            {
                if ((ShipLineCode ?? "") == (Strings.RTrim(Strings.Mid(ShippingLines, x, 10)) ?? ""))
                {
                    return Strings.RTrim(Strings.Mid(ShippingLines, x + 10, 50));
                }
            }

            return "";
        }

        public static string GiveTerminalCode(string TerminalCode)
        {
            if (TerminalCode == "AHEER")
            {
                return "AHEER";
            }
            else if (TerminalCode == "CENTERM")
            {
                return "CT";
            }
            else if (TerminalCode == "COAST")
            {
                return "COAST";
            }
            else if (TerminalCode == "COLUMBIA CONTAINERS")
            {
                return "CCL";
            }
            else if (TerminalCode == "CN")
            {
                return "CN";
            }
            else if (TerminalCode == "CP")
            {
                return "CP";
            }
            else if (TerminalCode == "DELCO")
            {
                return "DELCO";
            }
            else if (TerminalCode == "DELTAPORT")
            {
                return "DP";
            }
            else if (TerminalCode == "EUROASIA")
            {
                return "EURO";
            }
            else if (TerminalCode == "FRASER/SURREY")
            {
                return "FSD";
            }
            else if (TerminalCode == "FRASER SURREY DOCKS")
            {
                return "FSD";
            }
            else if (TerminalCode == "HARBOUR LINK")
            {
                return "HARBOUR";
            }
            else if (TerminalCode == "MARCO")
            {
                return "MARCO";
            }
            else if (TerminalCode == "MISC")
            {
                return "MISC";
            }
            else if (TerminalCode == "PACIFIC GATEWAY")
            {
                return "PACIFIC";
            }
            else if (TerminalCode == "RAYMONT")
            {
                return "RMT";
            }
            else if (TerminalCode == "TDK")
            {
                return "TDK";
            }
            else if (TerminalCode == "VANTERM")
            {
                return "VT";
            }
            else
            {
                return TerminalCode;
            }
        }

        public static string GiveExcelShipLineCode(string SSLine)
        {
            if (SSLine == "APL")
            {
                return "APL";
            }
            else if (SSLine == "CCNI")
            {
                return "CCNI";
            }
            else if (SSLine == "CHINA SHIPPING")
            {
                return "CSCL";
            }
            else if (SSLine == "CMA CGM")
            {
                return "CMA";
            }
            else if (SSLine == "COSCO")
            {
                return "COSC";
            }
            else if (SSLine == "CSAV")
            {
                return "CSAV";
            }
            else if (SSLine == "EVERGREEN")
            {
                return "EVGR";
            }
            else if (SSLine == "HAMBURG SUD")
            {
                return "HBG";
            }
            else if (SSLine == "HANJIN")
            {
                return "HNJN";
            }
            else if (SSLine == "HAPAG LLOYD")
            {
                return "HAP";
            }
            else if (SSLine == "HYUNDAI")
            {
                return "HYND";
            }
            else if (SSLine == "K-Line")
            {
                return "KLIN";
            }
            else if (SSLine == "MAERSK")
            {
                return "MRSK";
            }
            else if (SSLine == "MOL")
            {
                return "MOL";
            }
            else if (SSLine == "MSC")
            {
                return "MSC";
            }
            else if (SSLine == "NYK")
            {
                return "NYK";
            }
            else if (SSLine == "ONE")
            {
                return "ONE";
            }
            else if (SSLine == "OOCL")
            {
                return "OOCL";
            }
            else if (SSLine == "PIL")
            {
                return "PIL";
            }
            else if (SSLine == "SETH")
            {
                return "SETH";
            }
            else if (SSLine == "SM LINE")
            {
                return "SML";
            }
            else if (SSLine == "SAFMARINE")
            {
                return "SAF";
            }
            else if (SSLine == "UASC")
            {
                return "UASC";
            }
            else if (SSLine == "US LINES")
            {
                return "USL";
            }
            else if (SSLine == "YANG MING")
            {
                return "YGMG";
            }
            else if (SSLine == "ZIM")
            {
                return "ZIM";
            }
            else
            {
                return SSLine;
            }
        }

        private static void UpdateDatabase(string ExcelFileName, string ShipLine, string ShipPort, string ContainerSize, string LRDDate, string ERDDate, string VesselName, string VoyageNumber, string ContainerNumber, string SealNumber, string TareWgt, string NetWgt, string GrossWgt, string BookingNum, string AllSteamShipLines)
        {
            int RecordCount = 0;
            // if ContainerNumber = "" Or Len(ContainerNumber) <> 11 Or ValidateContainer(ContainerNumber) = False Or
            // If (SealNumber = "" Or Len(SealNumber) <= 5) Then
            // waitForm.Close
            // MessageBoxCeresOK.ShowDialog("Error:", "An error occurred. Please check the excel file. Possible errors: " + vbNewLine + "Container Number: Empty or not valid" +
            // vbNewLine + "Seal Number: Empty or length is greater than 7 characters", FrmParentScreen)
            // successPushing = False
            // Exit Sub
            // Else
            bool HoldBooking = ShouldHoldBooking(Strings.UCase(BookingNum));

            // DBConnect = New SqlClient.SqlConnection("Server=tcp:WTC-Ceres.database.windows.net,1433;Initial Catalog=WTC-Ceres;Persist Security Info=False;User ID=CeresAdmin;Password=C3r3$@dm!n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            // DBConnect.Open()

            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Containers In-Out] Where [Container Number] = '" + ContainerNumber + "'", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new System.Data.DataTable();
            bool OutGated;
            string ThisCarrierID;
            string CarrierID;
            DbObjAdapter.Fill(DbObjDataTable);
            if (DbObjDataTable.Rows.Count == 0)
            {
                var DBObj_NewRow = DbObjDataTable.NewRow();
                DBObj_NewRow["Container Number"] = ContainerNumber;
                DBObj_NewRow["Container Size"] = AssignContainerSize(ContainerSize);
                DBObj_NewRow["Delivered Booking"] = BookingNum;
                DBObj_NewRow["Booking Number"] = BookingNum;
                DBObj_NewRow["LRD"] = LRDDate;
                DBObj_NewRow["ERD"] = ERDDate;
                DBObj_NewRow["Seal Number"] = SealNumber;
                DBObj_NewRow["SS Line Code Out"] = ShipLine;
                DBObj_NewRow["SS Line Name Out"] = GiveShippingLineName(ShipLine, AllSteamShipLines);
                DBObj_NewRow["Vessel Name"] = VesselName;
                DBObj_NewRow["Voyage Number"] = VoyageNumber;
                DBObj_NewRow["Terminal Code Out"] = GiveTerminalCode(ShipPort);
                DBObj_NewRow["Terminal Name Out"] = ShipPort;
                DBObj_NewRow["Cargo Weight Out"] = DoFunctions.MKS((float)Conversion.Val(NetWgt));
                DBObj_NewRow["Tare Weight Out"] = DoFunctions.MKS((float)Conversion.Val(TareWgt));
                DBObj_NewRow["Gross Weight Out"] = DoFunctions.MKS((float)Conversion.Val(GrossWgt));
                DBObj_NewRow["Excel Filename Out"] = ExcelFileName;
                DBObj_NewRow["Container Out-Gated"] = false;
                DBObj_NewRow["Hold Out-Gate"] = HoldBooking;
                DbObjDataTable.Rows.Add(DBObj_NewRow);
                DbObjAdapter.Update(DbObjDataTable);
            }
            else
            {
                RecordCount = DbObjDataTable.Rows.Count - 1;
                if (Information.IsDBNull(DbObjDataTable.Rows[RecordCount]["Container Out-Gated"]) == true)
                {
                    OutGated = false;
                }
                else
                {
                    OutGated = Conversions.ToBoolean(DbObjDataTable.Rows[RecordCount]["Container Out-Gated"]);
                }

                DbObjDataTable.Rows[RecordCount]["Delivered Booking"] = BookingNum;
                DbObjDataTable.Rows[RecordCount]["Booking Number"] = BookingNum;
                DbObjDataTable.Rows[RecordCount]["LRD"] = LRDDate;
                DbObjDataTable.Rows[RecordCount]["ERD"] = ERDDate;
                DbObjDataTable.Rows[RecordCount]["Seal Number"] = SealNumber;
                DbObjDataTable.Rows[RecordCount]["SS Line Code Out"] = ShipLine;
                DbObjDataTable.Rows[RecordCount]["SS Line Name Out"] = GiveShippingLineName(ShipLine, AllSteamShipLines);
                DbObjDataTable.Rows[RecordCount]["Vessel Name"] = VesselName;
                DbObjDataTable.Rows[RecordCount]["Voyage Number"] = VoyageNumber;
                DbObjDataTable.Rows[RecordCount]["Terminal Code Out"] = GiveTerminalCode(ShipPort);
                DbObjDataTable.Rows[RecordCount]["Terminal Name Out"] = ShipPort;
                DbObjDataTable.Rows[RecordCount]["Cargo Weight Out"] = DoFunctions.MKS((float)Conversion.Val(NetWgt));
                DbObjDataTable.Rows[RecordCount]["Tare Weight Out"] = DoFunctions.MKS((float)Conversion.Val(TareWgt));
                DbObjDataTable.Rows[RecordCount]["Gross Weight Out"] = DoFunctions.MKS((float)Conversion.Val(GrossWgt));
                DbObjDataTable.Rows[RecordCount]["Excel Filename Out"] = ExcelFileName;
                DbObjDataTable.Rows[RecordCount]["Hold Out-Gate"] = HoldBooking;
                try
                {
                    DbObjAdapter.Update(DbObjDataTable);
                    successPushing = true;
                }
                catch
                {
                    MdlLoadingSetting.waitForm.Close();
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error:", "An error occurred when pushing container " + ContainerNumber + ". Please check the excel file for wrong entries and try again. ", My.MyProject.Forms.FrmParentScreen);
                    successPushing = false;
                }
            }

            // End If

        }
    }
}