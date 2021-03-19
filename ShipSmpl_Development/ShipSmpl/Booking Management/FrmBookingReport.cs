using BusinessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmBookingReport
    {
        public FrmBookingReport()
        {
            InitializeComponent();
            _exportButton.Name = "exportButton";
            _cbSearchDate.Name = "cbSearchDate";
            _dtpTo.Name = "dtpTo";
            _dtpFrom.Name = "dtpFrom";
            _tbBooking.Name = "tbBooking";
            _tbType.Name = "tbType";
            _tbLRD.Name = "tbLRD";
            _tbCustomer.Name = "tbCustomer";
            _tbDock.Name = "tbDock";
            _tbSplit.Name = "tbSplit";
            _tbSSLine.Name = "tbSSLine";
            _tbService.Name = "tbService";
            _activeToggleSwitch.Name = "activeToggleSwitch";
            _dgvBookings.Name = "dgvBookings";
        }

        private List<VW_BookingMinibooking> listReport;
        private DateTime minValueDate = new DateTime(1753, 1, 1);
        private string sortMode = "DESC";

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            //  My.MyProject.Forms.FrmParentScreen.showLOadForm();
            listReport = MinibookingService.GetJointBooking(true).Where(b => b.MiniBookingId != 0).ToList();
            VWBookingMinibookingBindingSource.DataSource = listReport;
            // My.MyProject.Forms.FrmParentScreen.HideLoadForm();
        }

        private void FrmBookingReport_Load(object sender, EventArgs e)
        {
            listReport = MinibookingService.GetJointBooking(true).Where(b => b.MiniBookingId != 0).ToList();
            VWBookingMinibookingBindingSource.DataSource = listReport;
            cbSearchDate.Checked = false;
            dtpFrom.Visible = false;
            dtpTo.Visible = false;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var rows1 = dgvBookings.Rows;
            var headers = (from header in dgvBookings.Columns.Cast<DataGridViewColumn>()
                           select header.HeaderText).ToArray();
            var rows = from row in dgvBookings.Rows.Cast<DataGridViewRow>()
                       where !row.IsNewRow
                       select Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value is object ? c.Value.ToString() : "");
            try
            {
                using (var sw = new System.IO.StreamWriter("csv.csv"))
                {
                    sw.WriteLine(string.Join(",", headers));
                    foreach (var r in rows)
                        sw.WriteLine(string.Join(",", r));
                }

                Process.Start("csv.csv");
            }
            catch (Exception ex)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error.", ex.Message, this);
            }
        }

        private void activeToggleSwitch_OnValuechange(object sender, EventArgs e)
        {
            listReport = MinibookingService.GetJointBooking(activeToggleSwitch.Value).Where(b => b.MiniBookingId != 0).ToList();
            VWBookingMinibookingBindingSource.DataSource = listReport;
        }

        private void dgvBookings_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ColName = dgvBookings.Columns[e.ColumnIndex].DataPropertyName;
            string querySort;
            List<VW_BookingMinibooking> list;

            // If sort mode was asc, now it will be desc
            if (sortMode.Equals("ASC"))
            {
                querySort = ColName + " DESC";
                sortMode = "DESC";
            }
            else
            {
                querySort = ColName + " ASC";
                sortMode = "ASC";
            }

            list = listReport.OrderBy(querySort).ToList();
            VWBookingMinibookingBindingSource.DataSource = list;
        }

        private void tbBooking_TextChanged(object sender, EventArgs e)
        {
            var fromDate = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day, 0, 0, 0);
            var toDate = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, 23, 59, 59);
            object list;
            if (cbSearchDate.Checked)
            {
                list = listReport.Where(b => b.BookingNumber.ToUpper().Contains(tbBooking.Text) & b.BookingType.ToUpper().Contains(tbType.Text) & b.CustomerName.ToUpper().Contains(tbCustomer.Text) & b.ForwarderName.ToUpper().Contains(tbForwarder.Text) & b.ServiceCode.ToUpper().Contains(tbService.Text) & b.SSLineCode.ToUpper().Contains(tbSSLine.Text) & b.TerminalName.ToUpper().Contains(tbDock.Text) & b.VesselName.ToUpper().Contains(tbVessel.Text) & b.LRDStr.ToUpper().Contains(tbLRD.Text) & b.SplitBooking.ToUpper().Contains(tbSplit.Text) & (b.CreatedAt.HasValue && b.CreatedAt >= fromDate & b.CreatedAt <= toDate)).ToList();
            }
            else
            {
                list = listReport.Where(b => b.BookingNumber.ToUpper().Contains(tbBooking.Text) & b.BookingType.ToUpper().Contains(tbType.Text) & b.CustomerName.ToUpper().Contains(tbCustomer.Text) & b.ForwarderName.ToUpper().Contains(tbForwarder.Text) & b.ServiceCode.ToUpper().Contains(tbService.Text) & b.SSLineCode.ToUpper().Contains(tbSSLine.Text) & b.TerminalName.ToUpper().Contains(tbDock.Text) & b.VesselName.ToUpper().Contains(tbVessel.Text) & b.LRDStr.ToUpper().Contains(tbLRD.Text) & b.SplitBooking.ToUpper().Contains(tbSplit.Text)).ToList();
            }

            VWBookingMinibookingBindingSource.DataSource = list;
        }

        private void dgvBookings_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var SplitBookingCel = dgvBookings.Rows[e.RowIndex].Cells["SplitBooking"];
            var ServiceCodeCel = dgvBookings.Rows[e.RowIndex].Cells["ServiceCode"];
            var BookingTypeCel = dgvBookings.Rows[e.RowIndex].Cells["BookingType"];
            var BookingNumberCel = dgvBookings.Rows[e.RowIndex].Cells["BookingNumber"];
            var LRDCel = dgvBookings.Rows[e.RowIndex].Cells["LRDStr"];
            var CreatedAt = dgvBookings.Rows[e.RowIndex].Cells["CreatedAtStr"];
            BookingNumberCel.Style.Font = new Font(Font, FontStyle.Bold);
            BookingNumberCel.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            LRDCel.Style.Font = new Font(Font, FontStyle.Bold);
            LRDCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CreatedAt.Style.Font = new Font(Font, FontStyle.Bold);
            CreatedAt.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SplitBookingCel.Style.ForeColor = Color.White;
            SplitBookingCel.Style.SelectionForeColor = Color.White;
            SplitBookingCel.Style.Font = new Font(Font, FontStyle.Bold);
            SplitBookingCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ServiceCodeCel.Style.ForeColor = Color.White;
            ServiceCodeCel.Style.SelectionForeColor = Color.White;
            ServiceCodeCel.Style.Font = new Font(Font, FontStyle.Bold);
            ServiceCodeCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BookingTypeCel.Style.ForeColor = Color.White;
            BookingTypeCel.Style.SelectionForeColor = Color.White;
            BookingTypeCel.Style.Font = new Font(Font, FontStyle.Bold);
            BookingTypeCel.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (SplitBookingCel.Value.Equals("DNS"))
            {
                SplitBookingCel.Style.BackColor = Color.Red;
                SplitBookingCel.Style.SelectionBackColor = Color.Red;
            }
            else
            {
                SplitBookingCel.Style.BackColor = Color.Green;
                SplitBookingCel.Style.SelectionBackColor = Color.Green;
            }
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

            switch (BookingTypeCel.Value)
            {
                case "EXPORT":
                    {
                        BookingTypeCel.Style.SelectionBackColor = Color.Sienna;
                        BookingTypeCel.Style.BackColor = Color.Chocolate;
                        break;
                    }

                case "REPO":
                    {
                        BookingTypeCel.Style.SelectionBackColor = Color.Chocolate;
                        BookingTypeCel.Style.BackColor = Color.Peru;
                        break;
                    }
                case "IMPORT":
                    {
                        BookingTypeCel.Style.SelectionBackColor = Color.SaddleBrown;
                        BookingTypeCel.Style.BackColor = Color.Brown;
                        break;
                    }
            }
        }

        private void cbSearchDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchDate.Checked)
            {
                dtpFrom.Visible = true;
                dtpTo.Visible = true;
            }
            else
            {
                dtpFrom.Visible = false;
                dtpTo.Visible = false;
            }
        }
    }
}