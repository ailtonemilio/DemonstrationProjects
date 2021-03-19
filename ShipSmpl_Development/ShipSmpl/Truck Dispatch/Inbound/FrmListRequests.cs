using BusinessLayer.WTC_Ceres;
using DataLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmListRequests
    {
        public FrmListRequests()
        {
            InitializeComponent();
            _tbReleaseType.Name = "tbReleaseType";
            _inboutTabs.Name = "inboutTabs";
            _tgDateReq.Name = "tgDateReq";
            _tdpFromReq.Name = "tdpFromReq";
            _dtpInReqto.Name = "dtpInReqto";
            _tbInReqSize.Name = "tbInReqSize";
            _tbInReqState.Name = "tbInReqState";
            _tbInRqSSLineName.Name = "tbInRqSSLineName";
            _tbInReqCurrentStatus.Name = "tbInReqCurrentStatus";
            _tbInReqRelType.Name = "tbInReqRelType";
            _dgvRequests.Name = "dgvRequests";
            _btneditReqst.Name = "btneditReqst";
            _btnCloseRequest.Name = "btnCloseRequest";
            _btnNewRequest.Name = "btnNewRequest";
            _btnEditPuDo.Name = "btnEditPuDo";
            _btnDelPuDo.Name = "btnDelPuDo";
            _dgvReleases.Name = "dgvReleases";
            _btnEditRelease.Name = "btnEditRelease";
            _btnDeleteRelease.Name = "btnDeleteRelease";
            _openDistributions.Name = "openDistributions";
            _btnAddDistribution.Name = "btnAddDistribution";
            _tbStatus.Name = "tbStatus";
            _tbCarrierName.Name = "tbCarrierName";
            _tbReleaseName.Name = "tbReleaseName";
            _tbReqdate.Name = "tbReqdate";
            _tbDropOff.Name = "tbDropOff";
            _tbPickUp.Name = "tbPickUp";
            _dgvReleaseDistribution.Name = "dgvReleaseDistribution";
            _tgReport.Name = "tgReport";
            _tbReportCarrier.Name = "tbReportCarrier";
            _tbReportToDate.Name = "tbReportToDate";
            _tbReportFromDate.Name = "tbReportFromDate";
            _dgvReport.Name = "dgvReport";
        }

        private VW_InboundRequest InReq;
        private VW_ReleaseOrder SelectedReleaseOrder;
        private VW_InboundRequest SelectedInboundrequest;
        private VW_ReleaseDistributionRequest SelecDistReq;
        private bool firstLoad = true;
        private SortableBindingList<VW_InboundRequest> InboundRequestList = new SortableBindingList<VW_InboundRequest>();
        private SortableBindingList<VW_ReleaseOrder> ReleaseOrderList = new SortableBindingList<VW_ReleaseOrder>();
        private SortableBindingList<VW_ReleaseDistributionRequest> RelDistRequestList = new SortableBindingList<VW_ReleaseDistributionRequest>();
        private SortableBindingList<VW_RelOrderPickUpDropOffLocation> PudoList;
        private SortableBindingList<VW_InboundReport> ReportList;

        // Dim RelDistRequestList As New List(Of VW_ReleaseDistributionRequest)
        private object newImgMsg;
        private object oldImgMsg;
        private object noImgMsg;

        private void FrmListRequests_Load(object sender, EventArgs e)
        {
            firstLoad = true;
            tgDateReq.Value = false;
            Timer1.Interval = 300;
            Timer1.Start();

            // Distribute list will refresh each 30 sec
            TimerRefreshDist.Interval = 300000;
            TimerRefreshDist.Start();
            firstLoad = false;
            LoadInformation(0);
        }

        private void LoadInformation(int tbIndex)
        {
            firstLoad = true;
            //    My.MyProject.Forms.FrmParentScreen.showLOadForm();
            newImgMsg = ResizeImage(My.Resources.Resources.newMessage);
            oldImgMsg = ResizeImage(My.Resources.Resources.oldMessage);
            noImgMsg = ResizeImage(My.Resources.Resources.noMessage);
            switch (tbIndex)
            {
                case 0:
                    {
                        ShapedPanel1.Refresh();
                        var list = InboundRequestService.GetByOpenStatus(tgDistStatus.Value);
                        InboundRequestList = new SortableBindingList<VW_InboundRequest>(list);
                        VWInboundRequestBindingSource1.DataSource = InboundRequestList;
                        CheckButtons();
                        break;
                    }

                case 1:
                    {
                        var list = ReleaseDistributionRequestService.GetByReleaseStatus(openDistributions.Value);
                        RelDistRequestList = new SortableBindingList<VW_ReleaseDistributionRequest>(list);
                        VWReleaseDistributionRequestBindingSource.DataSource = RelDistRequestList;
                        CheckButtons();
                        break;
                    }

                case 2:
                    {
                        var list = InboundRequestService.GetInboundReport(tgReport.Value);
                        ReportList = new SortableBindingList<VW_InboundReport>(list);
                        VWInboundReportBindingSource.DataSource = ReportList;
                        break;
                    }
            }

            //     My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            firstLoad = false;
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            //  My.MyProject.Forms.FrmParentScreen.showLOadForm();
            {
                var withBlock = My.MyProject.Forms.FrmAddEditRequest;
                withBlock.isNewRequest = true;
                withBlock.loadForm();
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRequest, this);
            LoadInformation(0);
            //   My.MyProject.Forms.FrmParentScreen.HideLoadForm();
            CheckButtons();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            VW_InboundRequest rqRow = (VW_InboundRequest)dgvRequests.CurrentRow.DataBoundItem;
            {
                var withBlock = My.MyProject.Forms.FrmAddEditRequest;
                withBlock.isNewRequest = false;
                withBlock.LoadInfo(rqRow);
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRequest, this);
            LoadInformation(inboutTabs.SelectedIndex);
            CheckButtons();
        }

        private void dgvRequests_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (inboutTabs.SelectedIndex == 0)
            {
                var DateRequested = dgvRequests.Rows[e.RowIndex].Cells["DateRequestedDataGridViewTextBoxColumn2"];
                var checkCell = dgvRequests.Rows[e.RowIndex].Cells["check"];
                var cansRequested = dgvRequests.Rows[e.RowIndex].Cells["QtyRequestedDataGridViewTextBoxColumn3"];
                var cansAccepted = dgvRequests.Rows[e.RowIndex].Cells["TotalQtyAccptOfRequest"];
                var StatusName = dgvRequests.Rows[e.RowIndex].Cells["StatusNameDataGridViewTextBoxColumn3"];
                DataGridViewButtonCell BtnAction = (DataGridViewButtonCell)dgvRequests.Rows[e.RowIndex].Cells["btnReqAction"];
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
                    checkCell.Value = "   ";
                BtnAction.Style.Font = new Font("Arial Narrow", 8.5f, FontStyle.Bold);
                BtnAction.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                BtnAction.Style.SelectionForeColor = Color.White;
                BtnAction.Style.ForeColor = Color.White;
                // dgvRequests.Columns(8).Height = 25

                DateRequested.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
                DateRequested.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                cansRequested.Style.Font = new Font("Arial", 11f, FontStyle.Bold);
                cansRequested.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                cansAccepted.Style.Font = new Font("Arial", 11f, FontStyle.Bold);
                cansAccepted.Style.ForeColor = Color.DarkGreen;
                cansAccepted.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                StatusName.Style.ForeColor = Color.White;
                StatusName.Style.SelectionForeColor = Color.White;
                StatusName.Style.Font = new Font("Bahnschrift", 9f, FontStyle.Bold);
                StatusName.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                BtnAction.Value = "UPDATE STATUS";
                BtnAction.Style.BackColor = Color.OliveDrab;
                BtnAction.Style.SelectionBackColor = Color.OliveDrab;
                switch (StatusName.Value)
                {
                    case "ACCEPTED":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkGreen;
                            StatusName.Style.BackColor = Color.Green;
                            break;
                        }

                    case "PENDING REPLY":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkGoldenrod;
                            StatusName.Style.BackColor = Color.Goldenrod;
                            break;
                        }

                    case "DECLINED":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkRed;
                            StatusName.Style.BackColor = Color.Red; // case "FOLLOW UP"
                            break;
                        }

                    default:
                        {
                            // StatusName.Style.Font = New Font("Arial", 10, FontStyle.Bold)
                            if (StatusName.Value.ToString().Contains("TODAY") | StatusName.Value.ToString().Contains("LATE"))
                            {
                                if (StatusName.Value.ToString().Contains("LATE"))
                                {
                                    // StatusName.Style.Font = New Font("Arial", 8, FontStyle.Bold)
                                    StatusName.Style.BackColor = Color.Red;
                                }
                                else
                                {
                                    StatusName.Style.SelectionBackColor = Color.Maroon;
                                    StatusName.Style.BackColor = Color.OrangeRed;
                                }
                            }
                            else
                            {
                                StatusName.Style.SelectionBackColor = Color.DarkOrange;
                                StatusName.Style.BackColor = Color.Orange;
                            }

                            break;
                        }
                }
            }
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRequests.Columns["btnReqAction"].Index == e.ColumnIndex)
            {
                InReq = (VW_InboundRequest)dgvRequests.Rows[e.RowIndex].DataBoundItem;
                My.MyProject.Forms.FrmUpdateReqStatus.PopulateInfo(InReq);
                My.MyProject.Forms.FrmUpdateReqStatus.firstLoad = true;
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmUpdateReqStatus, this);
                LoadInformation(inboutTabs.SelectedIndex);
            }

            if (e.ColumnIndex == 0)
            {
                var value = dgvRequests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!Information.IsNothing(value) && value.Equals("   "))
                {
                    dgvRequests.Rows[e.RowIndex].Cells[0].Value = "✔";
                }
                else
                {
                    dgvRequests.Rows[e.RowIndex].Cells[0].Value = "   ";
                }
            }

            CheckButtons();
        }

        public void CheckButtons()
        {
            switch (inboutTabs.SelectedIndex)
            {
                case 0:
                    {
                        btneditReqst.Enabled = false;
                        btnCloseRequest.Enabled = false;
                        btnEditRelease.Enabled = false;
                        btnDeleteRelease.Enabled = false;
                        btnEditPuDo.Enabled = false;
                        btnDelPuDo.Enabled = false;
                        int SelectedRows = 0;
                        foreach (DataGridViewRow row in dgvRequests.Rows)
                        {
                            if (!Information.IsNothing(row.Cells[0].Value) && row.Cells[0].Value.Equals("✔"))
                            {
                                SelectedRows += 1;
                            }
                        }

                        if (SelectedRows == 1)
                        {
                            btneditReqst.Enabled = true;
                            btnCloseRequest.Enabled = true;
                        }
                        else if (SelectedRows > 1)
                        {
                            btneditReqst.Enabled = false;
                            btnCloseRequest.Enabled = true;
                        }

                        if (dgvReleases.Rows.Count > 0)
                        {
                            btnEditRelease.Enabled = true;
                            btnDeleteRelease.Enabled = true;
                        }

                        if (dgvPickUpDropOf.Rows.Count > 0)
                        {
                            btnEditPuDo.Enabled = true;
                            btnDelPuDo.Enabled = true;
                        }

                        lblQtySelected.Text = SelectedRows.ToString();
                        lblReleaseQty.Text = dgvReleases.Rows.Count.ToString();
                        lblDistReqQty.Text = dgvPickUpDropOf.Rows.Count.ToString();
                        break;
                    }

                case 1:
                    {
                        break;
                    }
            }
        }

        private void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRequests.Rows.Count > 0 && firstLoad == false)
            {
                SelectedInboundrequest = (VW_InboundRequest)dgvRequests.CurrentRow.DataBoundItem;
                var list = ReleaseOrderService.GetAllVWByInboundRequestId(SelectedInboundrequest.InboundRequestId);
                ReleaseOrderList = new SortableBindingList<VW_ReleaseOrder>(list);
                VWReleaseOrderBindingSource.DataSource = ReleaseOrderList;
            }

            CheckButtons();
        }

        private void dgvReleases_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReleases.Rows.Count > 0 && firstLoad == false)
            {
                SelectedReleaseOrder = (VW_ReleaseOrder)dgvReleases.CurrentRow.DataBoundItem;
                var list = RelOrderPickUpDropOffLocationService.GetByReleaseOrderId(SelectedReleaseOrder.ReleaseOrderId);
                PudoList = new SortableBindingList<VW_RelOrderPickUpDropOffLocation>(list);
                VWRelOrderPickUpDropOffLocationBindingSource.DataSource = PudoList;
            }
            else if (dgvReleases.Rows.Count == 0)
            {
                VWRelOrderPickUpDropOffLocationBindingSource.DataSource = null;
            }

            CheckButtons();
        }

        private void dgvReleases_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var relNumb = dgvReleases.Rows[e.RowIndex].Cells["ReleaseNumberDataGridViewTextBoxColumn"];
            var qtyAccept = dgvReleases.Rows[e.RowIndex].Cells["QtyAcceptedInOrder"];
            relNumb.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            qtyAccept.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
            qtyAccept.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnEditDistReq_Click(object sender, EventArgs e)
        {
            if (dgvPickUpDropOf.Rows.Count > 0)
            {
                var VWRel = ReleaseService.GetVWByReleaseId(SelectedReleaseOrder.ReleaseId);
                My.MyProject.Forms.FrmAddEditRelease.PopulateInfo(VWRel);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRelease, this);
                VWRelOrderPickUpDropOffLocationBindingSource.DataSource = RelOrderPickUpDropOffLocationService.GetByReleaseOrderId(SelectedReleaseOrder.ReleaseOrderId);
            }
        }

        private void btnDelPuDo_Click(object sender, EventArgs e)
        {
            if (dgvPickUpDropOf.Rows.Count > 0)
            {
                var pudoSevice = new RelOrderPickUpDropOffLocationService();
                VW_RelOrderPickUpDropOffLocation selRow = (VW_RelOrderPickUpDropOffLocation)dgvPickUpDropOf.CurrentRow.DataBoundItem;
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure of this?", "Pick up: " + selRow.PickUpTerminalName + Constants.vbNewLine + "Drop off: " + selRow.YardName + Constants.vbNewLine + "Are you sure you want to delete this location? This can not be undone", My.Resources.Resources.warning, this);
                if (result == DialogResult.Yes)
                {
                    if (pudoSevice.Delete(selRow.RelOrderPickUpDropOffLocationId))
                    {
                        VWRelOrderPickUpDropOffLocationBindingSource.DataSource = RelOrderPickUpDropOffLocationService.GetByReleaseOrderId(SelectedReleaseOrder.ReleaseOrderId);
                        Close();
                    }
                    else
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Location not deleted.", "Something went wrong and the location was not deleted. Please try again.", this);
                    }
                }

                CheckButtons();
            }
        }

        private void btnDeleteRelease_Click(object sender, EventArgs e)
        {
            var relService = new ReleaseOrderService();
            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure of this?", "Release Order: " + SelectedReleaseOrder.ReleaseNumber + " - " + SelectedReleaseOrder.RelOrder + Constants.vbNewLine + "Are you sure you want to delete this release? This can not be undone", My.Resources.Resources.warning, this);
            if (result == DialogResult.Yes)
            {
                if (relService.Delete(SelectedReleaseOrder.ReleaseOrderId))
                {
                    var list = ReleaseOrderService.GetAllVWByReleaseId(SelectedReleaseOrder.ReleaseId);
                    ReleaseOrderList = new SortableBindingList<VW_ReleaseOrder>(list);
                    VWReleaseOrderBindingSource.DataSource = ReleaseOrderList;
                    Close();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Release Order not deleted.", "Something went wrong and the release order was not deleted. Please try again.", this);
                }
            }
        }

        private void btnCloseRequest_Click(object sender, EventArgs e)
        {
            // Dim result = MessageBoxCeresYesNo.ShowDialog("Are you sure of this?",
            // "Release Order: " + SelectedReleaseOrder.ReleaseNumber + " - " + SelectedReleaseOrder.RelOrder + vbNewLine +
            // "Are you sure you want to delete this release? This can not be undone", My.Resources.warning, Me)

            // If result = DialogResult.Yes Then
            // If relService.Delete(SelectedReleaseOrder.ReleaseOrderId) Then
            // VWReleaseOrderBindingSource.DataSource = ReleaseOrderService.GetAllVWByReleaseId(SelectedReleaseOrder.ReleaseId)
            // Me.Close()
            // Else
            // MessageBoxCeresOK.ShowDialog("Release Order not deleted.", "Something went wrong and the release order was not deleted. Please try again.", Me)
            // End If
            // End If
        }

        private void btnAddDistribution_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmListDistributions.loadForm();
            My.MyProject.Forms.FrmListDistributions.firstLoad = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmListDistributions, this);
            LoadInformation(inboutTabs.SelectedIndex);
        }

        private void btnEditPuDo_Click(object sender, EventArgs e)
        {
            VW_RelOrderPickUpDropOffLocation relDistReq = (VW_RelOrderPickUpDropOffLocation)dgvPickUpDropOf.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmAddEditReleasePickUpDropOff.PopulateInfo(relDistReq);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditReleasePickUpDropOff, this);
            var list = RelOrderPickUpDropOffLocationService.GetByReleaseOrderId(SelectedReleaseOrder.ReleaseOrderId);
            var PickUpList = new SortableBindingList<VW_RelOrderPickUpDropOffLocation>(list);
            VWRelOrderPickUpDropOffLocationBindingSource.DataSource = PickUpList;
        }

        private void dgvReleaseDistribution_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (inboutTabs.SelectedIndex == 1)
            {
                var DateRequested = dgvReleaseDistribution.Rows[e.RowIndex].Cells["DataGridViewTextBoxColumn17"];
                var checkCell = dgvReleaseDistribution.Rows[e.RowIndex].Cells["checkDist"];
                var cansRequested = dgvReleaseDistribution.Rows[e.RowIndex].Cells["QtyRequestedDataGridViewTextBoxColumn4"];
                var cansAccepted = dgvReleaseDistribution.Rows[e.RowIndex].Cells["TotalAcceptedOfRequestDataGridViewTextBoxColumn"];
                var StatusName = dgvReleaseDistribution.Rows[e.RowIndex].Cells["StatusNameDataGridViewTextBoxColumn2"];
                var relNumber = dgvReleaseDistribution.Rows[e.RowIndex].Cells["ReleaseNumberDataGridViewTextBoxColumn2"];
                var carrier = dgvReleaseDistribution.Rows[e.RowIndex].Cells["DataGridViewTextBoxColumn18"];
                DataGridViewImageCell msgImg = (DataGridViewImageCell)dgvReleaseDistribution.Rows[e.RowIndex].Cells["MessageColumn"];
                var msg = dgvReleaseDistribution.Rows[e.RowIndex].Cells["msg"];
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
                    checkCell.Value = "   ";

                // dgvRequests.Columns(8).Height = 25

                DateRequested.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
                DateRequested.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                carrier.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
                carrier.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                cansRequested.Style.Font = new Font("Arial", 11f, FontStyle.Bold);
                cansRequested.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                cansAccepted.Style.Font = new Font("Arial", 11f, FontStyle.Bold);
                cansAccepted.Style.ForeColor = Color.DarkGreen;
                cansAccepted.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                StatusName.Style.ForeColor = Color.White;
                StatusName.Style.SelectionForeColor = Color.White;
                StatusName.Style.Font = new Font("Bahnschrift", 9f, FontStyle.Bold);
                StatusName.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                int width = dgvReleaseDistribution.Columns["MessageColumn"].Width;
                int heght = dgvReleaseDistribution.Rows[e.RowIndex].Height;
                // msgImg.Style.BackColor = Color.White
                // msgImg.Style.SelectionBackColor = Color.White
                msgImg.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msgImg.Style.SelectionBackColor = Color.FromArgb(64, 64, 64);
                msgImg.Style.BackColor = Color.FromArgb(64, 64, 64);
                switch (msg.Value)
                {
                    case "New Message":
                        {
                            msgImg.Value = newImgMsg;
                            break;
                        }

                    case "Old Message":
                        {
                            msgImg.Value = oldImgMsg;
                            break;
                        }

                    default:
                        {
                            msgImg.Value = noImgMsg;
                            break;
                        }
                }

                switch (StatusName.Value)
                {
                    case "ACCEPTED":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkGreen;
                            StatusName.Style.BackColor = Color.Green;
                            break;
                        }

                    case "PENDING REPLY":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkGoldenrod;
                            StatusName.Style.BackColor = Color.Goldenrod;
                            break;
                        }

                    case "DECLINED":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkRed;
                            StatusName.Style.BackColor = Color.Red;
                            break;
                        }

                    case "FOLLOW UP":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkOrange;
                            StatusName.Style.BackColor = Color.Orange;
                            break;
                        }

                    case "PARTIALLY ACCEPTED":
                        {
                            StatusName.Style.SelectionBackColor = Color.DarkOliveGreen;
                            StatusName.Style.BackColor = Color.DarkOliveGreen;
                            break;
                        }
                }
            }
        }

        public static Image ResizeImage(Image InputImage)
        {
            return new Bitmap(InputImage, new Size(45, 30));
        }

        private void dgvReleaseDistribution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReleaseDistribution.Columns["MessageColumn"].Index == e.ColumnIndex)
            {
                SelecDistReq = (VW_ReleaseDistributionRequest)dgvReleaseDistribution.CurrentRow.DataBoundItem;
                if (!SelecDistReq.msg.Equals(""))
                {
                    My.MyProject.Forms.FrmDistributeRecChangeMsg.LoadForm(SelecDistReq);
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmDistributeRecChangeMsg, this);
                    LoadInformation(inboutTabs.SelectedIndex);
                }
            }

            if (e.ColumnIndex == 0)
            {
                var value = dgvReleaseDistribution.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!Information.IsNothing(value) && value.Equals("   "))
                {
                    dgvReleaseDistribution.Rows[e.RowIndex].Cells[0].Value = "✔";
                }
                else
                {
                    dgvReleaseDistribution.Rows[e.RowIndex].Cells[0].Value = "   ";
                }
            }

            CheckButtons();
        }

        private void dgvReleaseDistribution_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReleaseDistribution.Rows.Count > 0 && !firstLoad)
            {
                SelecDistReq = (VW_ReleaseDistributionRequest)dgvReleaseDistribution.CurrentRow.DataBoundItem;
                dgvDistributionDetails.DataSource = GetDistAcceptedList();
                dgvDistributionDetails.ColumnHeadersVisible = true;
            }
        }

        private DataTable GetDistAcceptedList()
        {
            var acptList = new DataTable();
            var Db = new DatabaseHelperCeres();
            string fields;
            fields = @"[ReleaseNumber] as [Release Number]
      ,[QtyRequested] as [Qty Requested]
      ,[FromDateReq] as [From Date Req]
      ,[ToDateReq] as [To Date Req]
      ,[QtyAccepted] as [Qty Acpt]
      ,[FromDateAcpt] as [From Date Acpt]
      ,[ToDateAcpt] as [To Date Acpt]
      ,[DateAccepted] as [Date Accepted]
      ,[StatusNameSch] [Status]";
            acptList = Db.getTableInfo("VW_RelDistReqSchRelDistSchAccpt", fields, "where ReleaseDistributionRequestId = " + SelecDistReq.ReleaseDistributionRequestId.ToString(0.ToString()));
            return acptList;
        }

        private void inboutTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                LoadInformation(inboutTabs.SelectedIndex);
            }
        }

        private void tgReport_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                LoadInformation(2);
            }
        }

        private void dgvReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (inboutTabs.SelectedIndex == 2)
            {
                var dlvStatus = dgvReport.Rows[e.RowIndex].Cells["DlvStatus"];
                var qtyAccepted = dgvReport.Rows[e.RowIndex].Cells["DataGridViewTextBoxColumn26"];
                var totalIngated = dgvReport.Rows[e.RowIndex].Cells["TotalIngated"];
                var fromDate = dgvReport.Rows[e.RowIndex].Cells["FromDate"];
                var toDate = dgvReport.Rows[e.RowIndex].Cells["ToDate"];
                var relNumb = dgvReport.Rows[e.RowIndex].Cells["DataGridViewTextBoxColumn24"];
                qtyAccepted.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
                qtyAccepted.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                totalIngated.Style.Font = new Font("Arial", 10f, FontStyle.Bold);
                totalIngated.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                fromDate.Style.Font = new Font("arial", 10f, FontStyle.Bold);
                fromDate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                toDate.Style.Font = new Font("arial", 10f, FontStyle.Bold);
                toDate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                relNumb.Style.Font = new Font("arial", 10f, FontStyle.Bold);
                relNumb.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dlvStatus.Style.ForeColor = Color.White;
                dlvStatus.Style.SelectionForeColor = Color.White;
                dlvStatus.Style.Font = new Font("Bahnschrift", 9f, FontStyle.Bold);
                dlvStatus.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                switch (dlvStatus.Value)
                {
                    case "ON TIME":
                        {
                            dlvStatus.Style.SelectionBackColor = Color.DarkGreen;
                            dlvStatus.Style.BackColor = Color.Green;
                            break;
                        }

                    case "COMPLETED":
                        {
                            dlvStatus.Style.SelectionBackColor = Color.DimGray;
                            dlvStatus.Style.BackColor = Color.DimGray;
                            break;
                        }

                    case "UPCOMING":
                        {
                            dlvStatus.Style.SelectionBackColor = Color.OliveDrab;
                            dlvStatus.Style.BackColor = Color.OliveDrab;
                            break;
                        }

                    case "LATE":
                        {
                            dlvStatus.Style.SelectionBackColor = Color.Firebrick;
                            dlvStatus.Style.BackColor = Color.Firebrick;
                            break;
                        }
                }
            }
        }

        private void TimerRefreshDist_Tick(object sender, EventArgs e)
        {
            if (inboutTabs.SelectedIndex == 1)
            {
                var list = ReleaseDistributionRequestService.GetByReleaseStatus(openDistributions.Value);
                RelDistRequestList = new SortableBindingList<VW_ReleaseDistributionRequest>(list);
                VWReleaseDistributionRequestBindingSource.DataSource = RelDistRequestList;
                CheckButtons();
            }
            else if (inboutTabs.SelectedIndex == 2)
            {
                var list = InboundRequestService.GetInboundReport(tgReport.Value);
                ReportList = new SortableBindingList<VW_InboundReport>(list);
                VWInboundReportBindingSource.DataSource = ReportList;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (Timer1.Interval >= 300 & Timer1.Interval < 600)
                {
                    Timer1.Stop();
                    firstLoad = true;
                    switch (inboutTabs.SelectedIndex)
                    {
                        case 0:
                            {
                                object list;
                                if (!Information.IsNothing(InboundRequestList))
                                {
                                    if (tgDateReq.Value == true)
                                    {
                                        list = new SortableBindingList<VW_InboundRequest>();
                                        list = InboundRequestList.Where(i => i.DateRequested.Date >= tdpFromReq.Value.Date & i.DateRequested.Date <= dtpInReqto.Value.Date & i.SSLineName.Contains(tbInRqSSLineName.Text) & i.ContainerSizeName.Contains(tbInReqSize.Text) & i.ContainerState.Contains(tbInReqState.Text) & i.ReleaseType.Contains(tbInReqRelType.Text) & i.StatusName.Contains(tbInReqCurrentStatus.Text)).ToList();
                                    }
                                    else
                                    {
                                        list = new SortableBindingList<VW_InboundRequest>();
                                        list = InboundRequestList.Where(i => i.SSLineName.Contains(tbInRqSSLineName.Text) & i.ContainerSizeName.Contains(tbInReqSize.Text) & i.ContainerState.Contains(tbInReqState.Text) & i.ReleaseType.Contains(tbInReqRelType.Text) & i.StatusName.Contains(tbInReqCurrentStatus.Text)).ToList();
                                    }

                                    VWInboundRequestBindingSource1.DataSource = new SortableBindingList<VW_InboundRequest>((IList<VW_InboundRequest>)list);
                                }

                                break;
                            }

                        case 1:
                            {
                                object list;
                                if (!Information.IsNothing(RelDistRequestList))
                                {
                                    list = new SortableBindingList<VW_InboundRequest>();
                                    list = RelDistRequestList.Where(i => i.CarrierName.Contains(tbCarrierName.Text) & i.ReleaseNumber.Contains(tbReleaseName.Text) & i.PickUpTerminalName.Contains(tbPickUp.Text) & i.YardName.Contains(tbDropOff.Text) & i.ReleaseType.Contains(tbReleaseType.Text) & i.RequestDate.ToString("dd-MMM-yyyy").ToUpper().Contains(tbReqdate.Text) & i.StatusName.Contains(tbStatus.Text)).ToList();
                                    VWReleaseDistributionRequestBindingSource.DataSource = new SortableBindingList<VW_ReleaseDistributionRequest>((IList<VW_ReleaseDistributionRequest>)list);
                                }

                                break;
                            }

                        case 2:
                            {
                                object list;
                                list = new SortableBindingList<VW_InboundReport>();
                                list = ReportList.Where(i => i.CarrierName.Contains(tbReportCarrier.Text) & i.ReleaseNumber.Contains(tbReportReleaseNUMB.Text) & i.FromDate.ToString("dd-MMM-yyyy").Contains(tbReportFromDate.Text) & i.ToDate.ToString("dd-MMM-yyyy").Contains(tbReportToDate.Text) & i.DlvStatus.Contains(tbReportDlvStatus.Text)).ToList();
                                var listReport = new SortableBindingList<VW_InboundReport>((IList<VW_InboundReport>)list);
                                VWInboundReportBindingSource.DataSource = new SortableBindingList<VW_InboundReport>(listReport);
                                break;
                            }

                            // tbReportCarrier.TextChanged,
                            // tbReportReleaseNUMB.TextChanged, tbReportFromDate.TextChanged, tbReportToDate.TextChanged,
                            // tbReportDlvStatus.TextChanged
                    }

                    firstLoad = false;
                }

                CheckButtons();
            }
        }

        private void tbInbReqDateRequested_TextChanged(object sender, EventArgs e)
        {
            Timer1.Stop();
            Timer1.Start();
        }

        private void tgDateReq_OnValuechange(object sender, EventArgs e)
        {
            Timer1.Stop();
            Timer1.Start();
            if (tgDateReq.Value == true)
            {
                pnlInReqDates.Enabled = true;
                ForeColor = Color.LightGray;
            }
            else
            {
                pnlInReqDates.Enabled = false;
                ForeColor = Color.Black;
            }
        }

        private void tbCarrierName_TextChanged(object sender, EventArgs e)
        {
            Timer1.Stop();
            Timer1.Start();
        }

        private void tgCurrentDist_OnValuechange(object sender, EventArgs e)
        {
        }

        private void tgDistStatus_OnValuechange(object sender, EventArgs e)
        {
        }

        private void tbReportCarrier_TextChanged(object sender, EventArgs e)
        {
            Timer1.Stop();
            Timer1.Start();
        }

        private void tgReport_OnValuechange_1(object sender, EventArgs e)
        {
            LoadInformation(inboutTabs.SelectedIndex);
        }
    }
}