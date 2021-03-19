using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Diagnostics;

namespace ShipSmpl
{
    public partial class FrmListContainers
    {
        public FrmListContainers()
        {
            InitializeComponent();
            _ComboSSLineList.Name = "ComboSSLineList";
            _TextSSLineListSearch.Name = "TextSSLineListSearch";
            _assignBunifuButton.Name = "assignBunifuButton";
            _closeFlatButton.Name = "closeFlatButton";
            _ContainerList2.Name = "ContainerList2";
        }

        private string AllSSLines = "";
        private string ContainerTerminals = "";
        private string DBConnect = DatabaseHelperCeres.StrConnWTCCeres;
        private string[] ContainerStats = new string[5];

        private void ComboSSLineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            short OffSSLine;
            string SSLineCode = "";
            // waitForm.Show

            {
                var withBlock = ComboSSLineList;
                if (withBlock.SelectedIndex == 0)
                {
                    ContainerList2.TakeContainerList(PopulateContainerInventory("ALL"));
                }
                else
                {
                    OffSSLine = (short)(ComboSSLineList.SelectedIndex * 50 - 49);
                    SSLineCode = Strings.Mid(AllSSLines, OffSSLine, 10);
                    ContainerList2.TakeContainerList(PopulateContainerInventory(SSLineCode));
                }

                ContainerList2.Select();
            }
            // FrmParentScreen.HideLoadForm()
        }

        private void ContainerList2_RemoveAssignment(string SelectedContainers)
        {
            int x = 0;
            string ContainerNumber = "";
            var loopTo = Strings.Len(SelectedContainers);
            for (x = 1; x <= loopTo; x += 11)
            {
                ContainerNumber = Strings.Mid(SelectedContainers, x, 11);
                freeContainer(Conversions.ToString('\0'), ContainerNumber);
                ContainerList2.AssignedContainerType(ContainerNumber, Conversions.ToString('\0'), "");
            }

            ContainerList2.ClearSelectedContainers();
        }

        private void freeContainer(string AssignMode, string ThisContainer)
        {
            // DBConnect = New SqlClient.SqlConnection("Server=tcp:WTC-Ceres.database.windows.net,1433;Initial Catalog=WTC-Ceres;Persist Security Info=False;User ID=CeresAdmin;Password=C3r3$@dm!n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            // DBConnect.Open()
            int RecCount = 0;
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Containers In-Out] Where [Container Number] = '" + ThisContainer + "' and ([Container Rejected] = 0 or [Container Rejected] is null)", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new DataTable();
            DbObjAdapter.Fill(DbObjDataTable);
            if (DbObjDataTable.Rows.Count == 1)
            {
                RecCount = DbObjDataTable.Rows.Count - 1;
                DbObjDataTable.Rows[RecCount]["In-Gate To Excel"] = false;
                DbObjDataTable.Rows[RecCount]["Assigned To Excel"] = false;
                if (AssignMode == Conversions.ToString('\0'))
                {
                    DbObjDataTable.Rows[RecCount]["Assigned To Storage"] = false;
                    DbObjDataTable.Rows[RecCount]["Assigned To Extra"] = false;
                    DbObjDataTable.Rows[RecCount]["Excel Booking Number"] = DBNull.Value;
                    DbObjDataTable.Rows[RecCount]["Booking Number"] = DBNull.Value;
                    DbObjDataTable.Rows[RecCount]["MinibookingId"] = DBNull.Value;
                    DbObjAdapter.Update(DbObjDataTable);
                }

                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "Can: " + ThisContainer, "FREE", "CONTAINER", "Container was released from storage");
            }
        }

        private string FetchContainerTerminals()
        {
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select CompanyCode, CompanyName From VW_CompanyCompanyType where DescCompanyType = 'Terminal' Order by CompanyName", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new DataTable();
            short x;
            string TerminalCode;
            string TerminalName;
            string FinalLine;
            DbObjAdapter.Fill(DbObjDataTable);
            FinalLine = "";
            var loopTo = (short)(DbObjDataTable.Rows.Count - 1);
            for (x = 0; x <= loopTo; x++)
            {
                TerminalCode = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(DbObjDataTable.Rows[(int)x]["CompanyCode"]), 10);
                TerminalName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(DbObjDataTable.Rows[(int)x]["CompanyName"]).ToUpper(), 50);
                FinalLine += TerminalCode + TerminalName;
            }

            return FinalLine;
        }

        private string FetchSteamShipLines()
        {
            string SSLineCode = "";
            string AllSSlines = "";

            // DBConnect = New SqlClient.SqlConnection("Server=tcp:WTC-Ceres.database.windows.net,1433;Initial Catalog=WTC-Ceres;Persist Security Info=False;User ID=CeresAdmin;Password=C3r3$@dm!n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            // DBConnect.Open()

            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select CompanyCode, CompanyName From VW_CompanyCompanyType  where DescCompanyType = 'Steamship Line' Order By CompanyCode ", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            ComboSSLineList.Items.Clear();
            ComboSSLineList.Items.Add("--------[ALL STEAM SHIP LINES]--------");
            foreach (DataRow SSLineList in DbObjDataTable.Rows)
            {
                SSLineCode = Strings.RTrim(SSLineList["CompanyCode"].ToString().ToUpper());
                ComboSSLineList.Items.Add("(" + SSLineCode + ") " + SSLineList["CompanyName"].ToString().ToUpper());
                AllSSlines += MdlContainerManagement.DoFunctions.PadToString(SSLineCode, 10) + MdlContainerManagement.DoFunctions.PadToString(SSLineList["CompanyName"].ToString(), 40);
            }
            // DBConnect.Close()

            return AllSSlines;
        }

        private string PopulateContainerInventory(string SSLineCode)
        {
            short x = 0;
            string DeliverBook = "";
            string LRD = "";
            char StreetTurn = '\0';
            char Trouble = '\0';
            string Sql;
            string TempList = "";
            string VesselName = "";
            char ContainerState = '\0';
            string ThisLine = "";
            for (x = 0; x <= 4; x++)
                ContainerStats[x] = MdlContainerManagement.DoFunctions.MKI(0) + MdlContainerManagement.DoFunctions.MKI(0) + MdlContainerManagement.DoFunctions.MKI(0);
            Sql = @"Select [SS Line Code In], [BookingNumber],[Vessel Name],[LRD],
                [Street Turn],[Gate Date In],[Gate Date In],[Gate Date Out],[Trouble In-Gate],[SS Line Code In]
                     [Carrier Code In],[Yard Code In],[Release Number],[Container Number],
             [Gross Weight],[TARE Weight],[Vessel Name],
          [Assigned To Excel], [Assigned To Storage], [Assigned To Extra] From VW_ContainersByBooking ";
            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter(Sql, DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow DBList in DbObjDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.OrObject(SSLineCode == "ALL", (DBList.IsNull("SS Line Code In") == false) && Operators.ConditionalCompareObjectEqual(DBList["SS Line Code In"], SSLineCode, false))))
                {
                    if (DBList.IsNull("BookingNumber") == true)
                    {
                        DeliverBook = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 40);
                    }
                    else
                    {
                        DeliverBook = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(DBList["BookingNumber"]), 40);
                    }

                    if (DBList.IsNull("Vessel Name") == true)
                    {
                        VesselName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(' '), 50);
                    }
                    else
                    {
                        VesselName = MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(DBList["Vessel Name"]), 50);
                    }

                    if (Information.IsDate(DBList["LRD"]) == true)
                    {
                        LRD = MdlContainerManagement.DoFunctions.DateToNum(Conversions.ToDate(DBList["LRD"]));
                    }
                    else
                    {
                        LRD = MdlContainerManagement.DoFunctions.MKL(0);
                    }

                    if (DBList.IsNull("Street Turn") == true)
                    {
                        StreetTurn = '\0';
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Street Turn"], false, false)))
                    {
                        StreetTurn = '\0';
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Street Turn"], true, false)))
                    {
                        StreetTurn = '\u0001';
                    }

                    if (DBList.IsNull("Trouble In-Gate") == true)
                    {
                        Trouble = '\0';
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Trouble In-Gate"], false, false)))
                    {
                        Trouble = '\0';
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Trouble In-Gate"], true, false)))
                    {
                        Trouble = '\u0001';
                    }

                    DateTime dateIn;
                    if (Information.IsDBNull(DBList["Gate Date In"]))
                    {
                        dateIn = DateTime.MinValue;
                    }
                    else
                    {
                        dateIn = Conversions.ToDate(DBList["Gate Date In"]);
                    }

                    string ssLineIn, carrierIn, yardIn;
                    if (Information.IsDBNull(DBList["SS Line Code In"]))
                    {
                        ssLineIn = "";
                    }
                    else
                    {
                        ssLineIn = Conversions.ToString(DBList["SS Line Code In"]);
                    }

                    if (Information.IsDBNull(DBList["Carrier Code In"]))
                    {
                        carrierIn = "";
                    }
                    else
                    {
                        carrierIn = Conversions.ToString(DBList["Carrier Code In"]);
                    }

                    if (Information.IsDBNull(DBList["Yard Code In"]))
                    {
                        yardIn = "";
                    }
                    else
                    {
                        yardIn = Conversions.ToString(DBList["Yard Code In"]);
                    }

                    string relNumb;
                    if (Information.IsDBNull(DBList["Release Number"]))
                    {
                        relNumb = "";
                    }
                    else
                    {
                        relNumb = Conversions.ToString(DBList["Release Number"]);
                    }

                    ContainerState = Conversions.ToChar(AssignContainerState(DBList));
                    try
                    {
                        ThisLine = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Conversions.ToString('\0') + MdlContainerManagement.DoFunctions.PadToString(Conversions.ToString(DBList["Container Number"]), 11), DBList["Gross Weight"]), DBList["TARE Weight"]), MdlContainerManagement.DoFunctions.DateToNum(dateIn)), MdlContainerManagement.DoFunctions.PadToString(yardIn, 10)), StreetTurn), Trouble), MdlContainerManagement.DoFunctions.PadToString(relNumb, 40)), MdlContainerManagement.DoFunctions.PadToString(ssLineIn, 10)), ContainerState), DeliverBook), VesselName), LRD), MdlContainerManagement.DoFunctions.PadToString(carrierIn, 10)), MdlContainerManagement.DoFunctions.MKI((int)DateAndTime.DateDiff("d", dateIn, DateTime.Today))));
                        if (Strings.Len(ThisLine) == 193)
                        {
                            TempList += ThisLine;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            // DBConnect.Close()
            return TempList;
        }

        private string AssignContainerState(DataRow DBList)
        {
            if (DBList.IsNull("Assigned To Excel") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Assigned To Excel"], true, false)))
            {
                return Conversions.ToString('\u0001');
            }
            else if (DBList.IsNull("Assigned To Storage") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Assigned To Storage"], true, false)))
            {
                return Conversions.ToString('\u0002');
            }
            else if (DBList.IsNull("Assigned To Extra") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DBList["Assigned To Extra"], true, false)))
            {
                return Conversions.ToString('\u0003');
            }
            else
            {
                return Conversions.ToString('\0');
            }
        }

        private void ContainerList2_ExportAsCSV(short RecordLgt, string AllContainers)
        {
            int x = 0;
            string ThisCSVFile = "";
            string TempLine = "";
            string CSVLine = "";
            string AssignCode = "";
            string PickupDate = "";
            System.IO.StreamWriter file;
            ThisCSVFile = System.IO.Path.GetTempPath() + "ConatinerList-" + DateTime.Today.ToString("dd-MMM-yyyy") + ".CSV";
            if (System.IO.File.Exists(ThisCSVFile) == true)
            {
                System.IO.File.Delete(ThisCSVFile);
            }

            file = My.MyProject.Computer.FileSystem.OpenTextFileWriter(ThisCSVFile, true);
            file.WriteLine("Container #" + Conversions.ToString(',') + "MAX" + Conversions.ToString(',') + "TARE" + Conversions.ToString(',') + "P/U Date" + Conversions.ToString(',') + "Yard" + Conversions.ToString(',') + "Release #" + Conversions.ToString(',') + "SS Line" + Conversions.ToString(',') + "State" + Conversions.ToString(',') + "Booking" + Conversions.ToString(',') + "Vessel Name" + Conversions.ToString(',') + "L.R.D." + Conversions.ToString(',') + "Carrier" + Conversions.ToString(',') + "Age");
            var loopTo = Strings.Len(AllContainers);
            for (x = 1; RecordLgt >= 0 ? x <= loopTo : x >= loopTo; x += RecordLgt)
            {
                CSVLine = Strings.Mid(AllContainers, x, RecordLgt);
                if (Strings.Mid(CSVLine, 87, 1) == Conversions.ToString('\u0001'))
                {
                    AssignCode = "ASSIGNED";
                }
                else if (Strings.Mid(CSVLine, 87, 1) == Conversions.ToString('\u0002'))
                {
                    AssignCode = "STORAGE";
                }
                else if (Strings.Mid(CSVLine, 87, 1) == Conversions.ToString('\u0003'))
                {
                    AssignCode = "EXTRA";
                }
                else if (Strings.Mid(CSVLine, 87, 1) == Conversions.ToString('\u0004'))
                {
                    AssignCode = "HOLD";
                }
                else
                {
                    AssignCode = "";
                }

                if ((Strings.Mid(CSVLine, 177, 4) ?? "") == (MdlContainerManagement.DoFunctions.MKL(0) ?? ""))
                {
                    PickupDate = "";
                }
                else
                {
                    PickupDate = MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(CSVLine, 177, 4));
                }

                TempLine = "";
                TempLine += Strings.Mid(CSVLine, 2, 11) + Conversions.ToString(',') + Strings.Format(MdlContainerManagement.DoFunctions.CVS(Strings.Mid(CSVLine, 13, 4)), "#,0.000") + Conversions.ToString(',') + Strings.Format(MdlContainerManagement.DoFunctions.CVS(Strings.Mid(CSVLine, 17, 4)), "#,0.000") + Conversions.ToString(',') + MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(CSVLine, 21, 4)) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 25, 10)) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 36, 40)) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 76, 10)) + Conversions.ToString(',') + AssignCode + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 88, 40)) + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 128, 50)) + Conversions.ToString(',') + PickupDate + Conversions.ToString(',') + Strings.RTrim(Strings.Mid(CSVLine, 182, 10)) + Conversions.ToString(',') + MdlContainerManagement.DoFunctions.CVI(Strings.Mid(CSVLine, 192, 2)).ToString();
                file.WriteLine(TempLine);
            }

            file.Close();
            Process.Start("EXCEL.EXE", ThisCSVFile);
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            ContainerList2.SearchContainerRecords('\u0001', TextSSLineListSearch.Text);
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAssignStorageExtra, this);
        }

        private void ContainerList2_ContainersSelected(bool SelectedContainers)
        {
            if (SelectedContainers)
            {
                assignBunifuButton.Enabled = true;
            }
            else
            {
                assignBunifuButton.Enabled = false;
            }
        }

        private void FrmListContainers_Load(object sender, EventArgs e)
        {
            TextSSLineListSearch.Text = "";
            TextSSLineListSearch.Select();
            AllSSLines = FetchSteamShipLines();
            ContainerTerminals = FetchContainerTerminals();
            ComboSSLineList.SelectedIndex = 0;
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}