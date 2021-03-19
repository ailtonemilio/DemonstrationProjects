using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAssignStorageExtra
    {
        public FrmAssignStorageExtra()
        {
            InitializeComponent();
            _cancelButton.Name = "cancelButton";
            _TouchAssignExtra.Name = "TouchAssignExtra";
            _bookingComboBox.Name = "bookingComboBox";
            _typeBunifuDropdown3.Name = "typeBunifuDropdown3";
            _closeFlatButton.Name = "closeFlatButton";
        }

        private Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
        private Workbook XLWorkbook;
        private string AllSSLines = "";
        private string DBConnect = DatabaseHelperCeres.StrConnWTCCeres;
        private string AllCustomerBookings = "";
        private string selectectedBooking;
        private int selectedMBId;

        private void FrmAssignStorageExtra_Load(object sender, EventArgs e)
        {
            var allBookings = MinibookingService.GetJointBooking(true);
            {
                var withBlock = bookingComboBox;
                withBlock.DataSource = allBookings;
                withBlock.DisplayMember = "BookingNumber";
                withBlock.ValueMember = "MinibookingId";
            }

            typeBunifuDropdown3.SelectedIndex = 0;
        }

        private void TouchAssignExtra_ButtonClick(object sender, EventArgs e)
        {
            int x = 0;
            string ContainerNumber = "";
            string ListOfContainers = "";
            ListOfContainers = My.MyProject.Forms.FrmListContainers.ContainerList2.GiveSeletcedContainers();
            if (typeBunifuDropdown3.SelectedItem.Equals("Storage"))
            {
                var loopTo = Strings.Len(ListOfContainers);
                for (x = 1; x <= loopTo; x += 11)
                {
                    ContainerNumber = Strings.Mid(ListOfContainers, x, 11);
                    AssignContainerToStorage(Conversions.ToString('\u0001'), ContainerNumber, selectectedBooking);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "CanID: " + ContainerNumber, "ASSIGN", "CONTAINER", "Container assigned to Storage");
                    My.MyProject.Forms.FrmListContainers.ContainerList2.AssignedContainerType(ContainerNumber, Conversions.ToString('\u0002'), selectectedBooking);
                }
            }
            else
            {
                var loopTo1 = Strings.Len(ListOfContainers);
                for (x = 1; x <= loopTo1; x += 11)
                {
                    ContainerNumber = Strings.Mid(ListOfContainers, x, 11);
                    AssignContainerToStorage(Conversions.ToString('\u0002'), Strings.Mid(ListOfContainers, x, 11), selectectedBooking);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "CanID: " + ContainerNumber, "ASSIGN", "CONTAINER", "Container assigned To Extra");
                    My.MyProject.Forms.FrmListContainers.ContainerList2.AssignedContainerType(ContainerNumber, Conversions.ToString('\u0002'), selectectedBooking);
                }
            }

            var CeresExcService = new CeresExcelPendingSyncService();
            var cep = new CeresExcelPendingSync();
            cep.RecordId = selectedMBId;
            cep.EmployeeId = My.MyProject.Forms.FrmLoginWindow._userID;
            cep.SyncType = "CONTAINER ASSIGNMENT";
            cep.ExtraInfo = "";
            cep.CurrentStatus = "QUEUE";
            cep.QtyOfAttempts = 0;
            cep.SyncMessage = "ADDED TO QUEUE";
            cep.CreatedAt = DateAndTime.Now;
            CeresExcService.AddOrUpdate(cep);
            My.MyProject.Forms.FrmListContainers.ContainerList2.ClearSelectedContainers();
            Close();
        }

        // Public Sub saveAssigment(ByVal containerList As Dictionary(Of String, Integer), ByVal bookingNumber As String, shouldHoldCOnt As Boolean)
        // Dim recordID As Integer, ContainerMinibooking As New ContainerMinibookingService
        // For Each containerNumb In containerList
        // recordID = containerNumb.Value

        // dbCeres.saveContrAssignment(recordID, bookingNumber, selectedMiniBookingId, True, True, False, False, False, shouldHoldCOnt)
        // EmployeeActivityLogService.Insert(FrmLoginWindow._userID, "CanID: " + recordID.ToString + " | MbID: " + selectedMiniBookingId.ToString, "ASSIGN", "CONTAINER", "Container assigned to booking")
        // ContainerMinibooking.Insert(recordID, selectedMiniBookingId)
        // Next

        // End Sub

        private void AssignContainerToStorage(string AssignMode, string ThisContainer, string ThisBookingNumber)
        {
            int RecCount = 0;
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Containers In-Out] Where [Container Number] = '" + ThisContainer + "'", DBConnect);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new System.Data.DataTable();
            DbObjAdapter.Fill(DbObjDataTable);
            if (DbObjDataTable.Rows.Count > 0)
            {
                RecCount = DbObjDataTable.Rows.Count - 1;
                DbObjDataTable.Rows[RecCount]["In-Gate To Excel"] = false;
                DbObjDataTable.Rows[RecCount]["Assigned To Excel"] = false;
                if (AssignMode == Conversions.ToString('\0'))
                {
                    DbObjDataTable.Rows[RecCount]["Assigned To Storage"] = false;
                    DbObjDataTable.Rows[RecCount]["Assigned To Extra"] = false;
                    DbObjDataTable.Rows[RecCount]["Excel Booking Number"] = "";
                    DbObjDataTable.Rows[RecCount]["Booking Number"] = "";
                    DbObjAdapter.Update(DbObjDataTable);
                }
                else if (AssignMode == Conversions.ToString('\u0001')) // ' If Storage
                {
                    DbObjDataTable.Rows[RecCount]["Assigned To Storage"] = true;
                    DbObjDataTable.Rows[RecCount]["Assigned To Extra"] = false;
                    DbObjDataTable.Rows[RecCount]["Excel Booking Number"] = ThisBookingNumber;
                    DbObjDataTable.Rows[RecCount]["Excel Booking Number"] = ThisBookingNumber;
                    DbObjDataTable.Rows[RecCount]["MinibookingId"] = DBNull.Value;
                    DbObjAdapter.Update(DbObjDataTable);
                }
                else if (AssignMode == Conversions.ToString('\u0002'))
                {
                    DbObjDataTable.Rows[RecCount]["Assigned To Storage"] = false;
                    DbObjDataTable.Rows[RecCount]["Assigned To Extra"] = true;
                    DbObjDataTable.Rows[RecCount]["Excel Booking Number"] = ThisBookingNumber;
                    DbObjDataTable.Rows[RecCount]["Booking Number"] = ThisBookingNumber;
                    DbObjDataTable.Rows[RecCount]["MinibookingId"] = selectedMBId;
                    DbObjAdapter.Update(DbObjDataTable);
                }
            }

            // DBConnect.Close()

        }

        // Private Function PopulateCustomerBookings() As String
        // Dim ThisBooking As DataRow
        // Dim SQL As String = ""
        // Dim ThisCustomer As String = ""
        // Dim TempLine As String = ""

        // SQL = "Select * From [Container Bookings] Order By [Customer Name]"

        // Dim DbObjDataTable As New System.Data.DataTable
        // Dim DbObjAdapter = New System.Data.SqlClient.SqlDataAdapter(SQL, DBConnect)
        // Dim DbObjCommand = New System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter)

        // DbObjAdapter.Fill(DbObjDataTable)

        // ComboCustomerAssign.Items.Clear()
        // '    ComboBookingAssign.Items.Clear()

        // For Each ThisBooking In DbObjDataTable.Rows

        // If IsDBNull(ThisBooking("Customer Name")) = False AndAlso RTrim(ThisBooking("Customer Name")) <> "" Then
        // ThisCustomer = RTrim(ThisBooking("Customer Name"))
        // If NewCustomer(ThisCustomer) = True Then
        // ComboCustomerAssign.Items.Add(ThisCustomer)
        // End If
        // TempLine += DoFunctions.PadToString(ThisBooking("Customer Name"), 50) + DoFunctions.PadToString(ThisBooking("Booking Number"), 20)
        // End If
        // Next
        // 'DBConnect.Close()

        // Return TempLine
        // End Function

        // Private Function NewCustomer(ThisCustomer As String) As Boolean
        // Dim x As Int32 = 0

        // With ComboCustomerAssign
        // For x = 0 To .Items.Count - 1
        // If ThisCustomer = .Items(x).ToString Then
        // Return False
        // End If
        // Next x
        // End With
        // Return True
        // End Function

        // Private Sub ComboCustomerAssign_SelectedIndexChanged(sender As Object, e As EventArgs)

        // Call PopulateAllCustomerBookings(ComboCustomerAssign.SelectedItem)
        // If Not IsNothing(typeBunifuDropdown3.Text) And Not IsNothing(selectectedBooking) And Not IsNothing(ComboCustomerAssign.Text) Then
        // TouchAssignExtra.Enabled = True
        // Else
        // TouchAssignExtra.Enabled = False

        // End If

        // End Sub

        private void PopulateAllCustomerBookings(string ThisCustomer)
        {
            int x = 0;

            // ComboBookingAssign.Items.Clear()

            // For x = 1 To Len(AllCustomerBookings) Step 70
            // If ThisCustomer = RTrim(Mid(AllCustomerBookings, x, 50)) Then
            // ComboBookingAssign.Items.Add(RTrim(Mid(AllCustomerBookings, x + 50, 20)))
            // End If
            // Next x

            var vwMB = new MinibookingService();

            // bookingComboBox.DataSource = vwMB.GetJointBookingByCustomer(ThisCustomer)
            // bookingComboBox.SelectedIndex = 0

            // bookingComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            // bookingComboBox.AutoCompleteSource = AutoCompleteSource.ListItems

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void typeBunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBunifuDropdown3.SelectedItem.Equals("Storage"))
            {
                bookingComboBox.Enabled = false;
            }
            else
            {
                bookingComboBox.Enabled = true;
            }
        }

        private void bookinbgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectectedBooking = Strings.Trim(bookingComboBox.Text);
            selectedMBId = Conversions.ToInteger(bookingComboBox.SelectedValue);
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}