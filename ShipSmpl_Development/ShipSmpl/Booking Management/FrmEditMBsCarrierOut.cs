using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmEditMBsCarrierOut
    {
        public FrmEditMBsCarrierOut()
        {
            InitializeComponent();
            _dgvBookings.Name = "dgvBookings";
            _noButton.Name = "noButton";
            _btnComplete.Name = "btnComplete";
            _closeFlatButton.Name = "closeFlatButton";
        }

        private EmployeeActivityLogService EmpService = new EmployeeActivityLogService();

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            VW_BookingMinibooking mb;
            var mbService = new MinibookingService();
            if (GoodToGo())
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboCarrierOut.SelectedValue, 0, false)))
                {
                    var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Warning:", "There is not carrier selected. If you proceed, the carrier out information will be removed from the selected bookings." + Constants.vbNewLine + " Would you like to proceed?", My.Resources.Resources.warning, this);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvBookings.Rows)
                        {
                            if (row.Cells[0].Equals("✔"))
                            {
                                mb = (VW_BookingMinibooking)row.DataBoundItem;
                                mbService.UpdateCarrierOut(mb.MiniBookingId, Conversions.ToInteger(cboCarrierOut.SelectedValue));
                            }
                        }

                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success!", "Carrier out updated with success", this);
                        Close();
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvBookings.Rows)
                    {
                        if (row.Cells[0].Value.Equals("✔"))
                        {
                            mb = (VW_BookingMinibooking)row.DataBoundItem;
                            EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, mb.MinibookingNumber, "UPDATE", "CARRIER BOOKING ASSIGNMENT", "Assigned " + cboCarrierOut.Text + " to Booking " + mb.MinibookingNumber);
                            mbService.UpdateCarrierOut(mb.MiniBookingId, Conversions.ToInteger(cboCarrierOut.SelectedValue));
                        }
                    }

                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success!", "Carrier out updated with success", this);
                    Close();
                }
            }
        }

        public bool GoodToGo()
        {
            if (BksSelected() == 0)
            {
                lblWarning.Text = "Need to select a booking to continue";
                return false;
            }

            return true;
        }

        public void populateGrid(List<VW_Booking> bkList)
        {
            var bookings = new List<string>();
            var MiniBkList = new List<VW_BookingMinibooking>();
            foreach (var bk in bkList)
                bookings.Add(bk.BookingNumber);
            MiniBkList = MinibookingService.GetJointBookingByBookingList(bookings);
            VWBookingMinibookingBindingSource.DataSource = MiniBkList;
        }

        private void FrmEditMBsCarrierOut_Load(object sender, EventArgs e)
        {
            {
                var withBlock = cboCarrierOut;
                withBlock.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Drayage_Provider, new WTCCeresEntities());
                withBlock.DisplayMember = "CompanyName";
                withBlock.ValueMember = "CompanyId";
            }
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string value = Conversions.ToString(dgvBookings.Rows[e.RowIndex].Cells[0].Value);
                    if (!Information.IsNothing(value) && value.Equals("   "))
                    {
                        dgvBookings.Rows[e.RowIndex].Cells[0].Value = "✔";
                    }
                    else
                    {
                        dgvBookings.Rows[e.RowIndex].Cells[0].Value = "   ";
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void dgvBookings_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var ServiceCodeCel = dgvBookings.Rows[e.RowIndex].Cells["ServiceCode"];
            var BookingNumberCel = dgvBookings.Rows[e.RowIndex].Cells["MinibookingNumber"];
            var checkCell = dgvBookings.Rows[e.RowIndex].Cells["check"];
            var cans = dgvBookings.Rows[e.RowIndex].Cells["NumberOfContainer"];
            checkCell.Style.Font = new Font("Arial", 15.5f, FontStyle.Bold);
            checkCell.Style.ForeColor = Color.Black;
            checkCell.Style.SelectionForeColor = Color.Black;
            if (MdlBookingManagement.IsOdd(e.RowIndex))
            {
                checkCell.Style.SelectionBackColor = Color.FromKnownColor(KnownColor.Control);
            }
            else
            {
                checkCell.Style.SelectionBackColor = Color.White;
            }

            checkCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (Information.IsNothing(checkCell.Value))
                checkCell.Value = "✔";
            BookingNumberCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            BookingNumberCel.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cans.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            cans.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ServiceCodeCel.Style.ForeColor = Color.White;
            ServiceCodeCel.Style.SelectionForeColor = Color.White;
            ServiceCodeCel.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            ServiceCodeCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // REPO Color.Thistle
            // EXPORT Color.PowderBlue
            switch (ServiceCodeCel.Value)
            {
                case "BAG":
                    {
                        ServiceCodeCel.Style.SelectionBackColor = Color.Olive;
                        ServiceCodeCel.Style.BackColor = Color.DarkKhaki;
                        break;
                    }

                case "BGR":
                    {
                        ServiceCodeCel.Style.SelectionBackColor = Color.DarkGoldenrod;
                        ServiceCodeCel.Style.BackColor = Color.Goldenrod;
                        break;
                    }

                case "BLK":
                    {
                        ServiceCodeCel.Style.SelectionBackColor = Color.DarkKhaki;
                        ServiceCodeCel.Style.BackColor = Color.DarkSeaGreen;
                        break;
                    }
            }
        }

        private bool allSelected = true;

        private void dgvBookings_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgvBookings.Rows)
                {
                    if (allSelected == false)
                    {
                        row.Cells[0].Value = "✔";
                        allSelected = true;
                    }
                    else
                    {
                        row.Cells[0].Value = "   ";
                        allSelected = false;
                    }
                }
            }
        }

        private int BksSelected()
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvBookings.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(row.Cells[0].Value, "✔", false)))
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}