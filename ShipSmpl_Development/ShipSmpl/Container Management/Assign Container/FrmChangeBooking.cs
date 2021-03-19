using Bunifu.ToggleSwitch;
using Bunifu.UI.WinForms;
using BusinessLayer.WTC_Ceres;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmChangeBooking
    {
        public FrmChangeBooking()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _cancelButton.Name = "cancelButton";
            _transferButton.Name = "transferButton";
            _bookingsBunifuDataGridView1.Name = "bookingsBunifuDataGridView1";
            _searchBunifuTextBox1.Name = "searchBunifuTextBox1";
            _BunifuToggleSwitch1.Name = "BunifuToggleSwitch1";
        }

        private string bookingStatus = "1";
        private Workbook XLWorkbook;
        private Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
        private string selectedBookingNumber = "";
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private Dictionary<string, int> selectedContainers = new Dictionary<string, int>();
        private bool firstLoad = true;
        private int selectedMinibookingId = 0;

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string contList = "";

        private void FrmChangeBooking_Load(object sender, EventArgs e)
        {
            selectedContainers.Clear();
            searchBunifuTextBox1.Text = "";
            {
                var withBlock = My.MyProject.Forms.FrmAssignContainer;
                for (int i = 0, loopTo = withBlock.assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(withBlock.assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value, true, false)))
                    {
                        selectedContainers.Add(Conversions.ToString(withBlock.assignedContainersBunifuDataGridView2.Rows[i].Cells[1].Value), Conversions.ToInteger(withBlock.assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value));
                    }
                }

                firstLoad = false;
            }

            populateBookings();
        }

        private void populateBookings()
        {
            string sslineCode = "";
            string condition = "where ([MinibookingNumber] Like '%" + searchBunifuTextBox1.Text + "%' or [CustomerName] Like '%" + searchBunifuTextBox1.Text + "%') and [BookingNumber] <> '' and [ActiveBooking] = " + bookingStatus + " order by [MinibookingNumber]";
            bookingsBunifuDataGridView1.Rows.Clear();
            foreach (DataRow booking in dbCeres.getTableInfo("[VW_BookingMinibooking]", "*", condition).Rows)
            {
                string custName = "";
                if (Information.IsDBNull(booking["CustomerName"]))
                {
                    custName = "N/A";
                }
                else
                {
                    custName = Strings.Trim(Conversions.ToString(booking["CustomerName"]));
                }

                if (!Information.IsDBNull(booking["SSLineCode"]))
                {
                    sslineCode = Strings.Trim(Conversions.ToString(booking["SSLineCode"]));
                }
                else
                {
                    sslineCode = "";
                }

                bookingsBunifuDataGridView1.Rows.Add(Strings.Trim(Conversions.ToString(booking["BookingNumber"])), custName, sslineCode, booking["MinibookingId"]);
            }
        }

        private void searchBunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            // populateBookings()

            for (int i = 0, loopTo = bookingsBunifuDataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(bookingsBunifuDataGridView1.Rows[i].Cells[0].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper())))
                {
                    // cell.Style.BackColor = Color.Yellow
                    bookingsBunifuDataGridView1.Rows[i].Selected = true;
                    bookingsBunifuDataGridView1.CurrentCell = bookingsBunifuDataGridView1.Rows[i].Cells[0];
                }
            }

            contList = "";
            foreach (var cont in selectedContainers)
                contList += cont.Key + ", ";
            try
            {
                contList = contList.Substring(0, contList.Length - 2);
                int selectedRow = bookingsBunifuDataGridView1.CurrentRow.Index;
                selectedBookingNumber = Conversions.ToString(bookingsBunifuDataGridView1.Rows[selectedRow].Cells[0].Value);
                selectedMinibookingId = Conversions.ToInteger(bookingsBunifuDataGridView1.Rows[selectedRow].Cells[3].Value);
                infoLabel.Text = "Booking #: " + selectedBookingNumber + Microsoft.VisualBasic.Constants.vbNewLine + "will receive containers:" + Microsoft.VisualBasic.Constants.vbNewLine + contList;
            }
            catch
            {
            }
        }

        // ' Public isBookingChange As Boolean = False

        private void transferButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            var selectedCont = new List<int>();
            for (int i = 0, loopTo = My.MyProject.Forms.FrmAssignContainer.assignedContainersBunifuDataGridView2.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Forms.FrmAssignContainer.assignedContainersBunifuDataGridView2.Rows[i].Cells[0].Value, true, false)))
                {
                    selectedCont.Add(Conversions.ToInteger(My.MyProject.Forms.FrmAssignContainer.assignedContainersBunifuDataGridView2.Rows[i].Cells[11].Value));
                }
            }

            {
                var withBlock = My.MyProject.Forms.FrmAssignContainer;
                var canInOut = new Containers_In_OutService();
                foreach (var contNum in selectedCont)
                {
                    dbCeres.unassignBooking(contNum, true);
                    canInOut.UnassignContainerFromMinibooking(contNum, My.MyProject.Forms.FrmAssignContainer.SelectedMBObj.MiniBookingId, false);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "CanID: " + contNum.ToString() + " | MbID: " + My.MyProject.Forms.FrmAssignContainer.SelectedMBObj.MiniBookingId.ToString(), "UNASSIGN", "CONTAINER", "Container unassigned from booking");
                }

                saveAssigment(selectedContainers, selectedBookingNumber);
            }

            MdlLoadingSetting.waitForm.Close();
            My.MyProject.Forms.FrmAssignContainer.selectAllCheckBox.Checked = false;
            searchBunifuTextBox1.Text = "";
            Close();
            // End If
        }

        private void saveAssigment(Dictionary<string, int> containerList, string bookingNumber)
        {
            int focusedIndex = bookingsBunifuDataGridView1.CurrentRow.Index;
            var miniBookingID = bookingsBunifuDataGridView1.Rows[focusedIndex].Cells[3].Value;
            int recordID;
            var ContainerMinibooking = new ContainerMinibookingService();
            foreach (var containerNumb in containerList)
            {
                recordID = containerNumb.Value;
                dbCeres.saveContrAssignment(recordID, bookingNumber, Conversions.ToInteger(miniBookingID), true, true, false, false, true, false);
                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, "CanID: " + recordID.ToString() + " | MbID: " + miniBookingID.ToString(), "ASSIGN", "CONTAINER", "Container reassigned to booking");
                ContainerMinibooking.Insert(recordID, Conversions.ToInteger(miniBookingID));
            }
        }

        private void bookingsBunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BunifuDataGridView s = (BunifuDataGridView)sender;
            if (firstLoad == false)
            {
                contList = "";
                foreach (var cont in selectedContainers)
                    contList += cont.Key + ", ";
                contList = contList.Substring(0, contList.Length - 2);
                int selectedRow = Conversions.ToInteger(s.CurrentRow.Index);
                selectedBookingNumber = Conversions.ToString(bookingsBunifuDataGridView1.Rows[selectedRow].Cells[0].Value);
                selectedMinibookingId = Conversions.ToInteger(bookingsBunifuDataGridView1.Rows[selectedRow].Cells[3].Value);
                infoLabel.Text = "Booking #: " + selectedBookingNumber + Microsoft.VisualBasic.Constants.vbNewLine + "will receive containers:" + Microsoft.VisualBasic.Constants.vbNewLine + contList;
            }
        }

        private void BunifuToggleSwitch1_OnValuechange(object sender, EventArgs e)
        {
            BunifuToggleSwitch s = (BunifuToggleSwitch)sender;
            MdlLoadingSetting.waitForm.Show();
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(s.Value, true, false)))
            {
                bookingStatus = "1";
            }
            else
            {
                bookingStatus = "0";
            }

            populateBookings();
            MdlLoadingSetting.waitForm.Close();
        }
    }
}