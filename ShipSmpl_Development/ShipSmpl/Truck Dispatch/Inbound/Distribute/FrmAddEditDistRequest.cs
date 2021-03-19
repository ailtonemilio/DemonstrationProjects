using BusinessLayer.WTC_Ceres;
using DataLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAddEditDistRequest
    {
        public FrmAddEditDistRequest()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _BunifuButton1.Name = "BunifuButton1";
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool isNewRecord;
        private RelDistRequestSchedule distReq;
        private VW_ReleaseDistributionRequest distVW;
        private RelDistRequestSchedule distSchedule;

        public void LoadForm(VW_ReleaseDistributionRequest dist, SortableBindingList<RelDistRequestSchedule> PUDOSchList)
        {
            string dateBgnTimeStr = DateAndTime.Now.ToShortDateString() + " 00:00:00";
            string dateEndTimeStr = DateAndTime.Now.ToShortDateString() + " 23:59:59";
            lblReleaseNumb.Text = dist.ReleaseNumber;
            lblPickUpCode.Text = dist.PickUpTerminalCode;
            lblDropOff.Text = dist.YardName;
            lblCarrierCode.Text = dist.CarrierCode;
            dtpFromDate.Value = Convert.ToDateTime(dateBgnTimeStr);
            dtpToDate.Value = Convert.ToDateTime(dateEndTimeStr);
            nudQtyCans.Value = 0m;
            distVW = dist;
            int SumTotalSch = 0;
            foreach (var item in PUDOSchList)
                SumTotalSch += item.QtyRequested;
            nudQtyCans.Value = dist.QtyRequested - SumTotalSch;
            nudQtyCans.Maximum = dist.QtyRequested - SumTotalSch;
        }

        public void PopulateInfo(VW_ReleaseDistributionRequest dist, RelDistRequestSchedule distSch)
        {
            distVW = dist;
            distSchedule = distSch;
            dtpFromDate.Value = distSch.FromDate;
            dtpToDate.Value = distSch.ToDate;
            nudQtyCans.Maximum = distSch.QtyRequested + nudQtyCans.Maximum;
            nudQtyCans.Value = distSch.QtyRequested;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var reqSchServ = new RelDistRequestScheduleService();
            if (isNewRecord)
            {
                distReq = new RelDistRequestSchedule();
                distReq.DateRequested = DateAndTime.Now;
                distReq.RequestStatusId = (int)MdlEnum.RequestStatus.PENDING_REPLY;
            }
            else
            {
                distReq = distSchedule;

                // distReq.ReleaseDistributionRequestId = distSchedule.ReleaseDistributionRequestId
                // distReq.RequestStatusId = distSchedule.RequestStatusId
            }

            distReq.ReleaseDistributionRequestId = distVW.ReleaseDistributionRequestId;
            distReq.FromDate = dtpFromDate.Value;
            distReq.ToDate = dtpToDate.Value;
            distReq.QtyRequested = (int)Math.Round(nudQtyCans.Value);
            if (reqSchServ.AddOrUpdate(distReq))
            {
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information not saved.", "Something went wrong and the information was not saved. Please try again.", this);
            }
        }
    }
}