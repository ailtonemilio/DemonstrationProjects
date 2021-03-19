using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddEditRelease
    {
        public FrmAddEditRelease()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _tbReleaseNumber.Name = "tbReleaseNumber";
            _bdnSaveRelease.Name = "bdnSaveRelease";
            _tbSeacrhBooking.Name = "tbSeacrhBooking";
            _btnRmBooking.Name = "btnRmBooking";
            _btnAddReleaseDetail.Name = "btnAddReleaseDetail";
            _dgvReleaseDetail.Name = "dgvReleaseDetail";
            _btnRmReleaseDetail.Name = "btnRmReleaseDetail";
            _btnAddBooking.Name = "btnAddBooking";
        }

        private List<ReleaseOrder> RelOrderList = new List<ReleaseOrder>();
        private List<VW_ReleaseOrderMinibooking> ReleaseDetMinibooking = new List<VW_ReleaseOrderMinibooking>();
        public VW_Release Release = new VW_Release();
        public bool isNewRelease;
        private int sumDetailQtyAdded = 0;
        private ReleaseOrderService relOrderService = new ReleaseOrderService();
        private ReleaseOrderMinibookingService relMbService = new ReleaseOrderMinibookingService();
        private int ReleaseId = 0;
        private ReleaseOrder relOrder;
        public VW_InboundRequest RelReq;
        private bool firstLoad;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private bool MbAlreadyAssigned(int mbId)
        {
            return ReleaseDetMinibooking.Where(r => r.MinibookingId == mbId).Count() > 0;
        }

        private void btnRmBooking_Click(object sender, EventArgs e)
        {
            VW_ReleaseOrderMinibooking SelectedRelMb = (VW_ReleaseOrderMinibooking)dgvBookingRelease.CurrentRow.DataBoundItem;
            if (relMbService.Delete(SelectedRelMb.ReleaseOrderMinibookingId))
            {
                ReleaseDetMinibooking.Remove(SelectedRelMb);
                dgvBookingRelease.DataSource = null;
                dgvBookingRelease.DataSource = ReleaseDetMinibooking;
                CheckButtons();
                CalculateQtys();
            }
        }

        public void LoadForm()
        {
            firstLoad = true;
            RelOrderList = new List<ReleaseOrder>();
            ReleaseDetMinibooking = new List<VW_ReleaseOrderMinibooking>();
            lblReleaseType.Text = "";
            tbReleaseNumber.Text = "";
            dgvReleaseDetail.DataSource = null;
            dgvBookingRelease.DataSource = null;
            lblReleaseType.Text = My.MyProject.Forms.FrmUpdateReqStatus.lblRelType.Text;
            CalculateQtys();
            CheckButtons();
            firstLoad = false;
        }

        public void PopulateInfo(VW_Release rel)
        {
            LoadForm();
            firstLoad = true;
            Release = rel;
            ReleaseId = rel.ReleaseId;
            RelReq = InboundRequestService.GetVWById(rel.InboundRequestId);
            lblReleaseType.Text = rel.ReleaseType;
            tbReleaseNumber.Text = rel.ReleaseNumber;
            lblReqRelease.Text = RelReq.TotalQtyAccptOfRequest.ToString();
            RelOrderList = ReleaseOrderService.GetAllByReleaseId(rel.ReleaseId);
            dgvReleaseDetail.DataSource = RelOrderList;
            if (dgvReleaseDetail.Rows.Count > 0)
            {
                ReleaseOrder relOrder = (ReleaseOrder)dgvReleaseDetail.Rows[0].DataBoundItem;
                ReleaseDetMinibooking = ReleaseOrderMinibookingService.GetAllVWByRelOrderId(relOrder.ReleaseOrderId);
                dgvBookingRelease.DataSource = null;
                dgvBookingRelease.DataSource = ReleaseDetMinibooking;
            }
            // UpdateBookingCbo()
            firstLoad = false;
            CalculateQtys();
            CheckButtons();
        }

        private void CalculateQtys()
        {
            if (!firstLoad)
            {
                sumDetailQtyAdded = 0;
                foreach (DataGridViewRow rel in dgvReleaseDetail.Rows)
                    sumDetailQtyAdded = Conversions.ToInteger(sumDetailQtyAdded + Convert.ToInt32(rel.Cells[1].Value));
                lblBalance.Text = (RelReq.QtyRequested - sumDetailQtyAdded).ToString();
                lblReqRelease.Text = RelReq.QtyRequested.ToString();
                lblTotalRelDetails.Text = dgvReleaseDetail.Rows.Count.ToString();
                lblTotalBks.Text = dgvBookingRelease.Rows.Count.ToString();
            }
        }

        private void CheckButtons()
        {
            btnAddReleaseDetail.Enabled = false;
            btnRmReleaseDetail.Enabled = false;
            btnAddBooking.Enabled = false;
            btnRmBooking.Enabled = false;
            bdnSaveRelease.Enabled = false;
            if (!string.IsNullOrEmpty(tbReleaseNumber.Text))
            {
                btnAddReleaseDetail.Enabled = true;
                if (dgvReleaseDetail.Rows.Count > 0)
                {
                    btnRmReleaseDetail.Enabled = true;
                    btnAddBooking.Enabled = true;
                }
            }

            if (dgvBookingRelease.Rows.Count > 0)
            {
                btnRmBooking.Enabled = true;
            }

            if (sumDetailQtyAdded > 0)
            {
                bdnSaveRelease.Enabled = true;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void btnAddReleaseDetail_Click(object sender, EventArgs e)
        {
            var relService = new ReleaseService();
            var rel = new Release();
            int lastRelId;
            int lastRelOrderId;
            My.MyProject.Forms.FrmAddEditReleaseDetail.isNewRecord = true;
            My.MyProject.Forms.FrmAddEditReleaseDetail.LoadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditReleaseDetail, this);
            RelOrderList.Add(My.MyProject.Forms.FrmAddEditReleaseDetail.updatedRelDetail);
            if (isNewRelease)
            {
                rel.ReleaseNumber = tbReleaseNumber.Text;
                relService.AddOrUpdate(rel);
                lastRelId = relService.GetLastReleaseId();
            }
            else
            {
                VW_Release relVW = (VW_Release)My.MyProject.Forms.FrmUpdateReqStatus.dgvRelease.CurrentRow.DataBoundItem;
                lastRelId = relVW.ReleaseId;
            }

            ReleaseId = lastRelId;
            // Save ReleaseOrders
            foreach (var currentRelOrder in RelOrderList)
            {
                relOrder = currentRelOrder;
                relOrder.ReleaseId = lastRelId;
                relOrder.InboundRequestId = My.MyProject.Forms.FrmUpdateReqStatus.RelReq.InboundRequestId;
                relOrderService.AddOrUpdate(relOrder);
                // '   lastRelOrderId = relOrderService.GetLastReleaseOrderId()
            }
            // FrmUpdateReqStatus.RelReq = InboundRequestService.GetVWById(RelReq.InboundRequestId)

            dgvReleaseDetail.DataSource = null;
            dgvReleaseDetail.DataSource = RelOrderList;
            CalculateQtys();
            CheckButtons();
        }

        private void dgvReleaseDetail_DoubleClick(object sender, EventArgs e)
        {
            ReleaseOrder relDist = (ReleaseOrder)dgvReleaseDetail.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmAddEditReleaseDetail.isNewRecord = false;
            My.MyProject.Forms.FrmAddEditReleaseDetail.PopulateInfo(relDist);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditReleaseDetail, this);
            if (!Information.IsNothing(My.MyProject.Forms.FrmAddEditReleaseDetail.updatedRelDetail.ReleaseOrderId))
            {
                RelOrderList[dgvReleaseDetail.CurrentRow.Index] = My.MyProject.Forms.FrmAddEditReleaseDetail.updatedRelDetail;
                ReleaseOrderBindingSource.DataSource = RelOrderList;
            }

            RelReq = InboundRequestService.GetVWById(Release.InboundRequestId);
            CalculateQtys();
            CheckButtons();
        }

        private void tbSeacrhBooking_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBookingRelease.Rows)
            {
                if (row.Cells[0].Value.ToString().EndsWith(tbSeacrhBooking.Text.ToUpper()))
                {
                    dgvBookingRelease.CurrentCell = (DataGridViewCell)row.Cells[0];
                    return;
                }
            }
        }

        private void bdnSaveRelease_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmUpdateReqStatus;
                withBlock.RelOrderList = ReleaseOrderService.GetAllVWByReleaseId(ReleaseId);
                withBlock.cboRelOrder.DataSource = withBlock.RelOrderList;
                withBlock.ReleaseList = ReleaseService.GetAllVWByInboundReqId(RelReq.InboundRequestId);
                withBlock.VWReleaseBindingSource.DataSource = withBlock.ReleaseList;
            }

            Close();
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRmReleaseDetail_Click(object sender, EventArgs e)
        {
            if (relOrderService.Delete(relOrder.ReleaseOrderId))
            {
                RelOrderList.Remove(relOrder);
                dgvReleaseDetail.DataSource = null;
                dgvReleaseDetail.DataSource = RelOrderList;
                My.MyProject.Forms.FrmUpdateReqStatus.RelReq = InboundRequestService.GetVWById(RelReq.InboundRequestId);
                CalculateQtys();
                CheckButtons();
            }
        }

        private void tbReleaseNumber_TextChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void dgvReleaseDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReleaseDetail.Rows.Count > 0)
            {
                try
                {
                    relOrder = (ReleaseOrder)dgvReleaseDetail.CurrentRow.DataBoundItem;
                    ReleaseDetMinibooking = ReleaseOrderMinibookingService.GetAllVWByRelOrderId(relOrder.ReleaseOrderId);
                    dgvBookingRelease.DataSource = null;
                    dgvBookingRelease.DataSource = ReleaseDetMinibooking;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            ReleaseOrder SelectedRelDetail = (ReleaseOrder)dgvReleaseDetail.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmAddEditReleaseMb.LoadForm(ReleaseDetMinibooking, SelectedRelDetail.ReleaseOrderId);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditReleaseMb, this);
            ReleaseDetMinibooking = ReleaseOrderMinibookingService.GetAllVWByRelOrderId(SelectedRelDetail.ReleaseOrderId);
            dgvBookingRelease.DataSource = null;
            dgvBookingRelease.DataSource = ReleaseDetMinibooking;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}