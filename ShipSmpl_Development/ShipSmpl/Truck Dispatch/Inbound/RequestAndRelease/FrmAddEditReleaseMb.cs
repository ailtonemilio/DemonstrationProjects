using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ShipSmpl
{
    public partial class FrmAddEditReleaseMb
    {
        public FrmAddEditReleaseMb()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _btnClose.Name = "btnClose";
        }

        private List<VW_BookingMinibooking> BkMbList = new List<VW_BookingMinibooking>();
        private ReleaseOrderMinibookingService relMbService = new ReleaseOrderMinibookingService();
        private int RelOrderId;

        public void LoadForm(List<VW_ReleaseOrderMinibooking> ReleaseDetMinibooking, int ReleaseOrderId)
        {
            {
                var withBlock = cboBooking;
                BkMbList = MinibookingService.GetJointBooking(true);
                withBlock.DataSource = BkMbList;
                withBlock.DisplayMember = "MinibookingNumber";
                withBlock.ValueMember = "MinibookingId";
            }

            RelOrderId = ReleaseOrderId;
            BkMbList = MinibookingService.GetJointBooking(true);
            var mbIdAssignedList = new List<int>();
            mbIdAssignedList = (from r in ReleaseDetMinibooking
                                select r.MinibookingId).ToList();
            BkMbList = BkMbList.Where(b => !mbIdAssignedList.Contains(b.MiniBookingId)).ToList();
            cboBooking.DataSource = BkMbList;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var relmbVW = new VW_ReleaseOrderMinibooking();
            var relmb = new ReleaseOrderMinibooking();
            VW_BookingMinibooking bk = (VW_BookingMinibooking)cboBooking.SelectedItem;
            relmb.MinibookingId = bk.MiniBookingId;
            relmb.ReleaseOrderId = RelOrderId;
            relmb.CreatedAt = DateAndTime.Now;
            if (relMbService.AddOrUpdate(relmb))
            {
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("", "", this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}