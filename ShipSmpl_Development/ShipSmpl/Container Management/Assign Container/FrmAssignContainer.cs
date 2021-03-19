using Bunifu.UI.WinForms;
using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAssignContainer
    {
        public FrmAssignContainer()
        {
            InitializeComponent();
            _bookingActivBookingBunifuToggleSwitch2.Name = "bookingActivBookingBunifuToggleSwitch2";
            _BunifuButton2.Name = "BunifuButton2";
            _changeBookingBtn.Name = "changeBookingBtn";
            _holdButton.Name = "holdButton";
            _removeButton.Name = "removeButton";
            _transloadButton.Name = "transloadButton";
            _selectAllCheckBox.Name = "selectAllCheckBox";
            _assignedContainersBunifuDataGridView2.Name = "assignedContainersBunifuDataGridView2";
            _bookingComboBox.Name = "bookingComboBox";
            _assignBunifuButton1.Name = "assignBunifuButton1";
            _containersBunifuDataGridView1.Name = "containersBunifuDataGridView1";
            _searchBunifuTextBox1.Name = "searchBunifuTextBox1";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private Dictionary<string, string> terminalCode = new Dictionary<string, string>();
        private Dictionary<string, int> selectedContainers = new Dictionary<string, int>();
        public Dictionary<string, int> selectedAssgnContainers = new Dictionary<string, int>();
        private CeresExcelPendingSyncService CeresExcService = new CeresExcelPendingSyncService();
        public VW_BookingMinibooking SelectedMBObj;
        private string focusedPath = @"\\server-one\Brian\WTC\Open\";
        // Dim focusedPath As String = "C:\Users\vania oliveira\Desktop\Booking\"

        private void FrmAssignContainer_Load(object sender, EventArgs e)
        {
            populateBookings();
            firstLoad = false;
            Timer1.Start();
            if (containersBunifuDataGridView1.Rows.Count > 0)
            {
                totalContainersLabel.Text = (containersBunifuDataGridView1.CurrentRow.Index + 1).ToString() + " of " + containersBunifuDataGridView1.Rows.Count.ToString();
            }
        }

        private object firstLoad = true;

        private void populateBookings()
        {
            string conditionBooking = "";
            var vwMB = new MinibookingService();
            {
                var withBlock = bookingComboBox;
                withBlock.DataSource = MinibookingService.GetJointBooking(bookingActivBookingBunifuToggleSwitch2.Value);
                withBlock.DisplayMember = "MinibookingNumber";
                withBlock.SelectedValue = "MiniBookingId";
                withBlock.SelectedIndex = 0;
                withBlock.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                withBlock.AutoCompleteSource = AutoCompleteSource.ListItems;
                SelectedMBObj = (VW_BookingMinibooking)withBlock.SelectedItem;
            }
        }

        private void PopulateContainerList(string SSLineCode)
        {
            containersBunifuDataGridView1.Rows.Clear();
            string Sql;
            int RecordCount = 0;
            float GrossWeight = 0f;
            string TareWeight;
            float WeightLimit = 30.48f;
            string HSState = "";
            string TempLine = "";
            DateTime dateIn;
            int age;
            string condition = "Where [SS Line Code In] = '" + SSLineCode + "' AND ([trouble in-gate] = 0 OR [trouble in-gate] IS NULL)   Order By [Gate Date In] DESC";
            if (SSLineCode.Equals("APL") | SSLineCode.Equals("CMA"))
            {
                condition = "Where [SS Line Code In] = 'CMA' or [SS Line Code In] = 'APL' and ([trouble in-gate] = 0 OR [trouble in-gate] IS NULL) Order By [Gate Date In] DESC";
            }

            var bookingList = dbCeres.getTableInfo("[Containers to assign]", "*", condition).Rows;
            foreach (DataRow container in bookingList)
            {
                if (AddContainerToPool(container) == true)
                {
                    GrossWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(container["Gross Weight"]));
                    if (!Information.IsDBNull(container["TAre Weight"]))
                    {
                        TareWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(container["TAre Weight"])).ToString();
                    }
                    else
                    {
                        TareWeight = "";
                    }

                    dateIn = Conversions.ToDate(container["Gate Date In"]);
                    age = (DateAndTime.Now.Date - dateIn).Days;
                    if (GrossWeight < WeightLimit)
                    {
                        HSState = "S";
                    }
                    else
                    {
                        HSState = "H";
                    }

                    bool hold = false;
                    if (Information.IsDBNull(container["Hold Out-Gate"]))
                    {
                        hold = false;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(container["Hold Out-Gate"], false, false)))
                    {
                        hold = false;
                    }
                    else
                    {
                        hold = true;
                    }

                    string truckCode = "";
                    // Carrier Code Out")
                    if (Information.IsDBNull(container["Carrier Code In"]))
                    {
                        truckCode = "";
                    }
                    else if (Strings.Trim(Conversions.ToString(container["Carrier Code In"])).Equals(""))
                    {
                        truckCode = "";
                    }
                    else
                    {
                        truckCode = Strings.Trim(Conversions.ToString(container["Carrier Code In"]));
                    }

                    string realNumber = "";
                    if (Information.IsDBNull(container["Release Number"]))
                    {
                        realNumber = "";
                    }
                    else if (Strings.Trim(Conversions.ToString(container["Release Number"])).Equals(""))
                    {
                        realNumber = "";
                    }
                    else
                    {
                        realNumber = Strings.Trim(Conversions.ToString(container["Release Number"]));
                    }

                    containersBunifuDataGridView1.Rows.Add(false, Strings.Trim(Conversions.ToString(container["Container Number"])), HSState, TareWeight, dateIn.ToString("dd-MMM-yyyy"), age.ToString(), container["Unique ID"], hold, truckCode, realNumber);
                    RecordCount += 1;
                    if (containersBunifuDataGridView1.Rows.Count > 0)
                    {
                        totalContainersLabel.Text = (containersBunifuDataGridView1.CurrentRow.Index + 1).ToString() + " of " + totalNumberOfCans.ToString();
                    }
                }
            }
        }

        private bool AddContainerToPool(DataRow ContainerList)
        {
            if (ContainerList.IsNull("Container Out-Gated") == true)
            {
                goto MoveOn;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Container Out-Gated"], false, false)))
            {
                goto MoveOn;
            }
            else
            {
                return false;
            }

        MoveOn:
            ;
            if (ContainerList.IsNull("Trouble In-Gate") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Trouble In-Gate"], true, false)))
            {
                return false;
            }
            else if (ContainerList.IsNull("Assigned To Excel") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Assigned To Excel"], true, false)))
            {
                return false;
            }
            else if (ContainerList.IsNull("Assigned To Storage") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Assigned To Storage"], true, false)))
            {
                return false;
            }
            else if (ContainerList.IsNull("Assigned To Extra") == false && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Assigned To Extra"], true, false)))
            {
                return false;
            }
            else if (ContainerList.IsNull("Assigned To Excel") == true)
            {
                return true;
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Assigned To Excel"], false, false)))
            {
                return true;
            }
            else if (!Information.IsDBNull(ContainerList["Street Turn"]) && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ContainerList["Street Turn"], true, false)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string totalNumberOfCans = "";

        private void bookingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMBObj = (VW_BookingMinibooking)bookingComboBox.SelectedItem;
            getBookingInfo();
            selectedAssgnContainers.Clear();
            selectedContainers.Clear();
            containersBunifuDataGridView1.Rows.Clear();
            PopulateContainers();
            cansLabel.Text = assignedContainersBunifuDataGridView2.Rows.Count.ToString() + " of " + totalNumberOfCans.ToString();
            checkContainerButton();
            checkAssignButtons();
        }

        public void PopulateContainers()
        {
            if (!Information.IsNothing(SelectedMBObj) && SelectedMBObj.MiniBookingId != 0)
            {
                PopulateContainerList(SelectedMBObj.SSLineCode);
                populateAssignedCOntainers();
            }
        }

        public void populateAssignedCOntainers()
        {
            float WeightLimit = 30.48f;
            float GrossWeight = 0f;
            string HSState = "";
            DateTime outDate;
            DateTime inDate;
            string dateOut;
            string truckOut;
            string truckCodeOut;
            string sealNumb;
            string cargoWeightOut;
            string seal;
            string deliveredStatus;
            string truckCodeIn;
            assignedContainersBunifuDataGridView2.Rows.Clear();
            foreach (DataRow contNumb in dbCeres.getTableInfo("[Containers In-Out]", "*", "where MinibookingId = '" + SelectedMBObj.MiniBookingId.ToString() + "'  order by [Gate Date Out]").Rows)
            {
                // or [Booking Number] = '" + bookingComboBox.SelectedItem.BookingNumber + "'
                GrossWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(contNumb["Gross Weight"]));
                if (GrossWeight < WeightLimit)
                {
                    HSState = "S";
                }
                else
                {
                    HSState = "H";
                }

                inDate = Conversions.ToDate(contNumb["Gate Date In"]);
                if (Information.IsDBNull(contNumb["Gate Date Out"]))
                {
                    dateOut = "";
                }
                else
                {
                    outDate = Conversions.ToDate(contNumb["Gate Date Out"]);
                    dateOut = outDate.ToString("dd-MMM-yyyy");
                }

                if (Information.IsDBNull(contNumb["Carrier Code Out"]))
                {
                    truckOut = "";
                }
                else
                {
                    truckOut = Strings.Trim(Conversions.ToString(contNumb["Carrier Code Out"]));
                }

                if (Information.IsDBNull(contNumb["Seal Number"]))
                {
                    sealNumb = "";
                }
                else
                {
                    sealNumb = Strings.Trim(Conversions.ToString(contNumb["Seal Number"]));
                }

                if (Information.IsDBNull(contNumb["Carrier Code In"]))
                {
                    truckCodeIn = "";
                }
                else
                {
                    truckCodeIn = Strings.Trim(Conversions.ToString(contNumb["Carrier Code In"]));
                }

                if (Information.IsDBNull(contNumb["Cargo Weight Out"]))
                {
                    cargoWeightOut = "";
                }
                else
                {
                    cargoWeightOut = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(contNumb["Cargo Weight Out"])).ToString();
                }

                string tareWeight = "";
                if (!Information.IsDBNull(contNumb["Tare Weight"]))
                {
                    tareWeight = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(contNumb["Tare Weight"])).ToString();
                }
                else
                {
                    tareWeight = "";
                }

                bool hold = false;
                string status;
                if (Information.IsDBNull(contNumb["Hold Out-Gate"]))
                {
                    hold = false;
                    status = "";
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(contNumb["Hold Out-Gate"], false, false)))
                {
                    hold = false;
                    status = "";
                }
                else
                {
                    hold = true;
                    status = "HOLD";
                }

                assignedContainersBunifuDataGridView2.Rows.Add(false, Strings.Trim(Conversions.ToString(contNumb["Container Number"])), Strings.Trim(Conversions.ToString(contNumb["SS Line Code In"])), HSState, tareWeight, inDate.ToString("dd-MMM-yyyy"), truckCodeIn, sealNumb, cargoWeightOut, dateOut, truckOut, Strings.Trim(Conversions.ToString(contNumb["Unique ID"])), hold, truckCodeIn, status);
            }
        }

        private void summaryBunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(containersBunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    containersBunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    selectedContainers.Add(Conversions.ToString(containersBunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value), Conversions.ToInteger(containersBunifuDataGridView1.Rows[e.RowIndex].Cells[6].Value));
                }
                else
                {
                    containersBunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    selectedContainers.Remove(Conversions.ToString(containersBunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value));
                }
            }
            // to enable assign button
            checkContainerButton();
        }

        public void checkContainerButton()
        {
            for (int i = 0, loopTo = containersBunifuDataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(containersBunifuDataGridView1.Rows[i].Cells[0].Value, true, false)))
                {
                    assignBunifuButton1.Enabled = true;
                    return;
                }
                else
                {
                    assignBunifuButton1.Enabled = false;
                }
            }
        }

        public void checkAssignButtons()
        {
            for (int i = 0, loopTo = assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value, true, false)))
                {
                    removeButton.Enabled = true;
                    holdButton.Enabled = true;
                    changeBookingBtn.Enabled = true;
                    return;
                }
                else
                {
                    removeButton.Enabled = false;
                    holdButton.Enabled = false;
                    changeBookingBtn.Enabled = false;
                }
            }

            if (containersBunifuDataGridView1.Rows.Count > 0)
            {
                cansLabel.Text = assignedContainersBunifuDataGridView2.Rows.Count.ToString() + " of " + totalNumberOfCans.ToString();
                cansLabel.Refresh();
            }
        }

        private void getBookingInfo()
        {
            DateTime lrdDate;
            if (!Information.IsNothing(SelectedMBObj))
            {
                foreach (DataRow row in dbCeres.getTableInfo("[VW_BookingMinibooking]", "*", "where MinibookingID = '" + SelectedMBObj.MiniBookingId.ToString() + "'").Rows)
                {
                    if (row["CustomerName"] != DBNull.Value)
                    {
                        customerNameLabel.Text = Strings.Trim(Conversions.ToString(row["CustomerName"]));
                    }
                    else
                    {
                        customerNameLabel.Text = "N/A";
                    }

                    try
                    {
                        ssLineLabel.Text = Conversions.ToString(row["SSlineName"]);
                    }
                    catch
                    {
                    }

                    vesselLabel.Text = Strings.Trim(Conversions.ToString(row["VesselName"]));
                    bookingLabel.Text = Strings.Trim(Conversions.ToString(row["BookingNumber"]));
                    if (row["LRD"] != DBNull.Value)
                    {
                        lrdDate = Conversions.ToDate(row["LRD"]);
                        LRDLabel.Text = lrdDate.ToString("dd-MMM-yyyy").ToUpper();
                    }
                    else
                    {
                        LRDLabel.Text = "N/A";
                    }

                    if (row["BookingType"] != DBNull.Value)
                    {
                        typeLabel.Text = Strings.Trim(Conversions.ToString(row["BookingType"]));
                    }
                    else
                    {
                        typeLabel.Text = "N/A";
                    }

                    cansLabel.Text = Conversions.ToString(row["NumberOfContainer"]);
                    totalNumberOfCans = cansLabel.Text;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["ActiveBooking"], true, false)))
                    {
                        statusLabel.Text = "OPEN";
                        statusLabel.BackColor = Color.Green;
                        if (row["HoldMinibooking"] != DBNull.Value && Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row["HoldMinibooking"], true, false)))
                        {
                            statusLabel.Text = "OPEN - ON HOLD";
                            statusLabel.BackColor = Color.OrangeRed;
                        }
                    }
                    else
                    {
                        statusLabel.Text = "CLOSED";
                        statusLabel.BackColor = Color.FromArgb(192, 0, 0);
                    }
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string someText = searchBunifuTextBox1.Text;
            for (int i = 0, loopTo = containersBunifuDataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (containersBunifuDataGridView1.Rows[i].Cells[1].Value.ToString().EndsWith(someText))
                {
                    // cell.Style.BackColor = Color.Yellow
                    containersBunifuDataGridView1.Rows[i].Selected = true;
                    containersBunifuDataGridView1.CurrentCell = containersBunifuDataGridView1.Rows[i].Cells[1];
                }
            }
        }

        private void searchBunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string someText = searchBunifuTextBox1.Text;
            // If e.KeyCode = Keys.Enter Then
            for (int i = 0, loopTo = containersBunifuDataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(containersBunifuDataGridView1.Rows[i].Cells[1].Value.ToString().Contains(someText)))
                {
                    // cell.Style.BackColor = Color.Yellow
                    containersBunifuDataGridView1.Rows[i].Selected = true;
                    containersBunifuDataGridView1.CurrentCell = containersBunifuDataGridView1.Rows[i].Cells[1];
                }
            }
            // End If
        }

        private Workbook XLWorkbook;
        private Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

        private void assignBunifuButton1_Click(object sender, EventArgs e)
        {


            int numbOfCounSelected = 0;
            bool shouldHoldCont = statusLabel.Text.Equals("OPEN - ON HOLD");
            for (int i = 0, loopTo = containersBunifuDataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(containersBunifuDataGridView1.Rows[i].Cells[0].Value, true, false)))
                {
                    numbOfCounSelected += 1;
                }
            }

            if (assignedContainersBunifuDataGridView2.Rows.Count + numbOfCounSelected > 45)
            {
                if (assignedContainersBunifuDataGridView2.Rows.Count == 45)
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Cannot assign containers to booking.", "This booking has reached the maximum of containers allowed in a booking (45 cans per booking)." + Microsoft.VisualBasic.Constants.vbNewLine + "Please, create another minibooking to keep assigning", this);
                }
                else
                {
                    int totalSelected = assignedContainersBunifuDataGridView2.Rows.Count + numbOfCounSelected;
                    int maxToBeassign = totalSelected - 45;
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Cannot assign containers to booking.", "The maximum number of containers a booking can receive is 45. You can only assign " + maxToBeassign.ToString() + " containers to this booking. To keep assigning, create another minibooking and assign remaining containers.", this);
                }

                return;
            }

            if (Convert.ToInt32(totalNumberOfCans) > assignedContainersBunifuDataGridView2.Rows.Count)
            {
                if (Convert.ToInt32(totalNumberOfCans) >= assignedContainersBunifuDataGridView2.Rows.Count + numbOfCounSelected)
                {
                    saveAssigment(selectedContainers, Strings.Trim(SelectedMBObj.MinibookingNumber), shouldHoldCont);

                    // Add pending record to database
                    var cep = new CeresExcelPendingSync();
                    cep.RecordId = SelectedMBObj.MiniBookingId;
                    cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
                    cep.SyncType = "CONTAINER ASSIGNMENT";
                    cep.ExtraInfo = "";
                    cep.CurrentStatus = "QUEUE";
                    cep.QtyOfAttempts = 0;
                    cep.SyncMessage = "ADDED TO QUEUE";
                    cep.CreatedAt = DateAndTime.Now;
                    CeresExcService.AddOrUpdate(cep);
                    removeFromList();
                    selectedContainers.Clear();
                    populateAssignedCOntainers();
                    if (containersBunifuDataGridView1.Rows.Count > 0)
                    {
                        totalContainersLabel.Text = (containersBunifuDataGridView1.CurrentRow.Index + 1).ToString() + " of " + containersBunifuDataGridView1.Rows.Count.ToString();
                    }
                    else
                    {
                        totalContainersLabel.Text = "0 of " + containersBunifuDataGridView1.Rows.Count.ToString();
                    }

                    selectAllCheckBox.Checked = false;
                }
                else
                {
                    string message = "The total number of containers allowed is " + totalNumberOfCans.ToString() + ". Please unselect " + (numbOfCounSelected + assignedContainersBunifuDataGridView2.Rows.Count - Conversions.ToDouble(totalNumberOfCans)).ToString() + " container(s) to continue";
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not procced", message, this);
                }
            }
            else if (Conversions.ToDouble(totalNumberOfCans) == assignedContainersBunifuDataGridView2.Rows.Count)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not procced", "The total number of containers allowed is " + totalNumberOfCans.ToString() + ". You can not add more containers to this booking.", this);
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Can not procced", "The total number of containers allowed is " + totalNumberOfCans.ToString() + ". Please unselect " + (numbOfCounSelected + assignedContainersBunifuDataGridView2.Rows.Count - Conversions.ToDouble(totalNumberOfCans)).ToString() + " container(s) to continue", this);
            }
            // End If
        }

        private void removeFromList()
        {
            int listSize = containersBunifuDataGridView1.Rows.Count - 1;
            foreach (var contKey in selectedContainers)
            {
                for (int j = containersBunifuDataGridView1.RowCount - 1; j >= 0; j -= 1)
                {
                    if (contKey.Key.Equals(containersBunifuDataGridView1.Rows[j].Cells[1].Value))
                    {
                        containersBunifuDataGridView1.Rows.RemoveAt(j);
                    }
                }
            }
        }

        public bool IsExcelFileOpened(string WorkBookName)
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

        public void saveAssigment(Dictionary<string, int> containerList, string bookingNumber, bool shouldHoldCOnt)
        {
            int recordID;
            var ContainerMinibooking = new ContainerMinibookingService();
            foreach (var containerNumb in containerList)
            {
                recordID = containerNumb.Value;
                dbCeres.saveContrAssignment(recordID, bookingNumber, SelectedMBObj.MiniBookingId, true, true, false, false, false, shouldHoldCOnt);
                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "CanID: " + recordID.ToString() + " | MbID: " + SelectedMBObj.MiniBookingId.ToString(), "ASSIGN", "CONTAINER", "Container assigned to booking " + SelectedMBObj.MinibookingNumber);
                ContainerMinibooking.Insert(recordID, SelectedMBObj.MiniBookingId);
            }
        }

        public bool isDeletedFromExcel = false;

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // If (Not System.IO.Directory.Exists(focusedPath)) Then
            // MessageBoxCeresOK.ShowDialog("Cannot save booking.",
            // "It seems like you are not connected to WTC netowrk. Please, connect to VPN and try again." + vbNewLine +
            // "If problem persists, contact IT department", Me)
            // Else

            bool canDelete = true;
            var selectedCont = new List<int>();
            for (int i = 0, loopTo = assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value, true, false)))
                {
                    selectedCont.Add(Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value));
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(assignedContainersBunifuDataGridView2.Rows[i].Cells[8].Value, "", false)))
                    {
                        canDelete = true;
                    }
                    else
                    {
                        canDelete = false;
                        break;
                    }
                }
            }

            if (canDelete)
            {
                unassignbooking(SelectedMBObj.MinibookingNumber, selectedCont, false);
                selectedAssgnContainers.Clear();
                if (containersBunifuDataGridView1.Rows.Count != 0)
                {
                    totalContainersLabel.Text = containersBunifuDataGridView1.Rows.Count.ToString() + " of " + totalNumberOfCans.ToString();
                }
                else
                {
                    totalContainersLabel.Text = "0 of " + totalNumberOfCans.ToString();
                }

                PopulateContainers();
                populateAssignedCOntainers();
                selectAllCheckBox.Checked = false;
                checkAssignButtons();
                selectAllCheckBox.Checked = false;
                checkAssignButtons();
            }
            else
            {
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Warning:", "You can not remove a loaded container. Have you deleted the record from the excel file?", My.Resources.Resources.warning, this);
                if (result == DialogResult.Yes)
                {
                    unassignbooking(SelectedMBObj.MinibookingNumber, selectedCont, false);
                    selectedAssgnContainers.Clear();
                    if (containersBunifuDataGridView1.Rows.Count != 0)
                    {
                        totalContainersLabel.Text = containersBunifuDataGridView1.Rows.Count.ToString() + " of " + totalNumberOfCans.ToString();
                    }
                    else
                    {
                        totalContainersLabel.Text = "0 of " + totalNumberOfCans.ToString();
                    }

                    PopulateContainers();
                    populateAssignedCOntainers();
                    selectAllCheckBox.Checked = false;
                    checkAssignButtons();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Warning:", "The record was not deleted", this);
                }
            }
            // End If
        }

        public void unassignbooking(string bookingBumber, List<int> selectedCountainers, bool isBookingChange)
        {
            //  My.MyProject.Forms.FrmParentScreen.showLOadForm();
            string ThisXLSFile = "";
            var dbCeres = new DatabaseHelperCeres();
            try
            {

                // unassign on database
                var canInOut = new Containers_In_OutService();
                foreach (var contNum in selectedCountainers)
                {
                    dbCeres.unassignBooking(contNum, false);
                    canInOut.UnassignContainerFromMinibooking(contNum, SelectedMBObj.MiniBookingId, false);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "CanID: " + contNum.ToString() + " | MbID: " + SelectedMBObj.MiniBookingId.ToString(), "UNASSIGN", "CONTAINER", "Container unassigned from booking");
                }

                var cep = new CeresExcelPendingSync();
                cep.RecordId = SelectedMBObj.MiniBookingId;
                cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
                cep.SyncType = "CONTAINER ASSIGNMENT";
                cep.ExtraInfo = "";
                cep.CurrentStatus = "QUEUE";
                cep.QtyOfAttempts = 0;
                cep.SyncMessage = "ADDED TO QUEUE";
                cep.CreatedAt = DateAndTime.Now;
                CeresExcService.AddOrUpdate(cep);
                //   My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. Please close this tab and try again. Error: " + ex.Message);
                //   My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            }

            selectedAssgnContainers.Clear();
        }

        private void assignedContainersBunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status;
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    if (selectedAssgnContainers.ContainsKey(Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[1].Value)) == false)
                    {
                        selectedAssgnContainers.Add(Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[1].Value), Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[11].Value));
                    }
                }
                else
                {
                    assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    selectedAssgnContainers.Remove(Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[1].Value));
                }

                status = Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Value);
                if (status.Equals("HOLD"))
                {
                    holdButton.Text = "RELEASE";
                }
                else
                {
                    holdButton.Text = "HOLD";
                }
            }
            // to enable assign button
            checkAssignButtons();
        }

        private void holdButton_Click(object sender, EventArgs e)
        {
            selectedAssgnContainers.Clear();
            for (int i = 0, loopTo = assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value, true, false)))
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(assignedContainersBunifuDataGridView2.Rows[i].Cells[12].Value, true, false)))
                    {
                        assignedContainersBunifuDataGridView2.Rows[i].Cells[12].Value = false;
                        assignedContainersBunifuDataGridView2.Rows[i].Cells[14].Value = "";
                        dbCeres.holdContainer(Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value), false);
                    }
                    else
                    {
                        assignedContainersBunifuDataGridView2.Rows[i].Cells[14].Value = "HOLD";
                        assignedContainersBunifuDataGridView2.Rows[i].Cells[12].Value = true;
                        dbCeres.holdContainer(Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value), true);
                    }

                    selectedAssgnContainers.Add(Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[i].Cells[1].Value), Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value));
                }
            }

            var cep = new CeresExcelPendingSync();
            cep.RecordId = SelectedMBObj.MiniBookingId;
            cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
            cep.SyncType = "CONTAINER ASSIGNMENT";
            cep.ExtraInfo = "";
            cep.CurrentStatus = "QUEUE";
            cep.QtyOfAttempts = 0;
            cep.SyncMessage = "ADDED TO QUEUE";
            cep.CreatedAt = DateAndTime.Now;
            CeresExcService.AddOrUpdate(cep);

            // Dim ThisXLSFile As String = ""
            // Dim ThisExcelFile = SelectedMBObj.MinibookingNumber + ".xls"
            // ThisXLSFile = focusedPath + ThisExcelFile

            // '         ThisXLSFile = "C:\Users\vania\Desktop\Booking\" + ThisExcelFile

            // If File.Exists(ThisXLSFile) Then

            // If IsExcelFileOpened(ThisXLSFile) = False Then

            // XLWorkbook = Excel.Workbooks.Open(ThisXLSFile, ReadOnly:=False)
            // XLWorkbook.Application.DisplayAlerts = False

            // Dim ContainerSheet As Worksheet = XLWorkbook.Sheets(2)

            // Call UpdateExcelBooking(ContainerSheet, selectedAssgnContainers, "assignedContainers",
            // SelectedMBObj.MinibookingNumber, False)

            // XLWorkbook.Close(False)
            // selectedAssgnContainers.Clear()
            // populateAssignedCOntainers()

            // MessageBoxCeresOK.ShowDialog("Sucess!", "", Me)

            // checkAssignButtons()
            // checkContainerButton()
            // Else

            // MsgBox(ThisXLSFile + ": Is Currently Opened!", MsgBoxStyle.OkOnly)
            // End If
            // Else

            // MsgBox(ThisXLSFile + ": Is Not Found!", MsgBoxStyle.OkOnly)
            // End If

        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmListContainers, this);
        }

        private void selectAllCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            selectedAssgnContainers.Clear();
            if (selectAllCheckBox.Checked)
            {
                for (int i = 0, loopTo = assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo; i++)
                {
                    assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value = true;
                    selectedAssgnContainers.Add(Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[i].Cells[1].Value), Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value));
                }

                selectAllCheckBox.BackColor = Color.Teal;
            }
            else
            {
                for (int i = 0, loopTo1 = assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo1; i++)
                {
                    assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value = false;
                    selectAllCheckBox.BackColor = Color.FromArgb(64, 64, 0);
                    selectedAssgnContainers.Add(Conversions.ToString(assignedContainersBunifuDataGridView2.Rows[i].Cells[1].Value), Conversions.ToInteger(assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value));
                }
            }

            checkAssignButtons();
        }

        private void changeBookingBtn_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmChangeBooking, this);
        }

        private void containersBunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BunifuDataGridView s = (BunifuDataGridView)sender;
            totalContainersLabel.Text = s.Rows.Count.ToString() + " of " + totalNumberOfCans.ToString();
        }

        private void bookingActivBookingBunifuToggleSwitch2_OnValuechange(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(firstLoad, false, false)))
            {
                populateBookings();
            }

            checkAssignButtons();
            checkContainerButton();
        }

        private void assignedContainersBunifuDataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Value, "HOLD", false)))
            {
                assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Style.BackColor = Color.Orange;
                assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Style.ForeColor = Color.White;
                assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Style.SelectionForeColor = Color.Black;
                assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Style.SelectionBackColor = Color.DarkOrange;
            }
            else
            {
                assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Style.BackColor = Color.White;
                assignedContainersBunifuDataGridView2.Rows[e.RowIndex].Cells[14].Style.ForeColor = Color.White;
            }
        }

        private void transloadButton_Click(object sender, EventArgs e)
        {
        }
    }
}