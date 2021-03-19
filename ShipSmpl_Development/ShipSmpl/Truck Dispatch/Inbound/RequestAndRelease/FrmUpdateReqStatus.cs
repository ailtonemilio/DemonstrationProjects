using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmUpdateReqStatus
    {
        public FrmUpdateReqStatus()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _dgvRelease.Name = "dgvRelease";
            _btnNewRequest.Name = "btnNewRequest";
            _btnManageBal.Name = "btnManageBal";
            _cbStatus.Name = "cbStatus";
            _btnRmRel.Name = "btnRmRel";
            _btnRmPickUpDropOff.Name = "btnRmPickUpDropOff";
            _btnAddNewPUDO.Name = "btnAddNewPUDO";
            _cboRelOrder.Name = "cboRelOrder";
            _nudFlwUpQtyCans.Name = "nudFlwUpQtyCans";
        }

        public VW_InboundRequest RelReq;
        public List<VW_ReleaseOrder> RelOrderList = new List<VW_ReleaseOrder>();
        public VW_ReleaseOrder SelectedReleaseOrder;
        private VW_Release SelectedRelease;
        private RelOrderPickUpDropOffLocationService pudoService = new RelOrderPickUpDropOffLocationService();
        private InboundFollowUpService followUpServ = new InboundFollowUpService();
        private int SumAddedLocations = 0;
        private int followUpQty = 0;
        public bool firstLoad = true;
        private InboundFollowUpRequest fu = new InboundFollowUpRequest();
        public InboundReqDeclinedQty InReqDeclined = new InboundReqDeclinedQty();
        public List<VW_Release> ReleaseList = new List<VW_Release>();
        public List<VW_RelOrderPickUpDropOffLocation> PickUpDropOffLocations = new List<VW_RelOrderPickUpDropOffLocation>();
        private InboundFollowUpService fuService = new InboundFollowUpService();

        private void btnManageBal_Click(object sender, EventArgs e)
        {
            if (InReqDeclined.InboundRequestId == 0)
            {
                My.MyProject.Forms.FrmManageReleaseBalance.isNewRecord = true;
                My.MyProject.Forms.FrmManageReleaseBalance.LoadForm(RelReq);
            }
            else
            {
                My.MyProject.Forms.FrmManageReleaseBalance.LoadForm(RelReq);
                My.MyProject.Forms.FrmManageReleaseBalance.isNewRecord = false;
                My.MyProject.Forms.FrmManageReleaseBalance.PopulateInfo(InReqDeclined, Convert.ToInt32(lblBalRelease.Text));
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmManageReleaseBalance, this);
            dgvRelease.DataSource = null;
            VWReleaseBindingSource.DataSource = null;
            VWReleaseBindingSource.DataSource = ReleaseList;
            dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
            CalculateQtys();
        }

        private void CheckReleaseManagementList()
        {
            bool writeOffExists;
            var SelectedRelease = ReleaseList.Where(s => s.ReleaseNumber == "WRITE OFF" | s.ReleaseNumber == "DECLINED").ToList();
            if (SelectedRelease.Count > 0)
            {
                writeOffExists = true;
            }
            else
            {
                writeOffExists = false;
            }

            if (InReqDeclined.InboundReqDeclinedQtyId != 0)
            {
                var newRel = new VW_Release();
                newRel.ReleaseNumber = InReqDeclined.DeclineStatus;
                newRel.TotalQtyAccepted = InReqDeclined.QtyDeclined;
                if (!writeOffExists)
                {
                    ReleaseList.Add(newRel);
                }
                else
                {
                    ReleaseList.Remove(SelectedRelease[0]);
                    ReleaseList.Add(newRel);
                }

                VWReleaseBindingSource.DataSource = null;
                VWReleaseBindingSource.DataSource = ReleaseList;
            }
        }

        public void LoadForm()
        {
            firstLoad = true;
            RelOrderList.Clear();
            {
                var withBlock = cbStatus;
                withBlock.DataSource = RequestStatusService.GetByFlowType("INBOUND");
                withBlock.DisplayMember = "StatusName";
                withBlock.ValueMember = "RequestStatusId";
            }

            {
                var withBlock1 = cboRelOrder;
                withBlock1.DataSource = RelOrderList;
                withBlock1.DisplayMember = "RelOrder";
                withBlock1.ValueMember = "ReleaseOrderId";
            }

            pnlFollowUp.Hide();
            SumAddedLocations = 0;
            followUpQty = 0;
            fu = null;
            firstLoad = false;
        }

        public void PopulateInfo(VW_InboundRequest req)
        {
            LoadForm();
            firstLoad = true;
            btnManageBal.Enabled = true;
            RelReq = req;
            cbStatus.SelectedValue = req.RequestStatusId;
            lblSSLineName.Text = req.SSLineCode;
            lblRelType.Text = req.ReleaseType;
            lblSize.Text = req.ContainerSizeName;
            lblReqDate.Text = req.DateRequested.ToString("dd-MMMd-yyyy");
            fu = InboundFollowUpService.GetByOpenInboundRequestId(req.InboundRequestId);
            ReleaseList = ReleaseService.GetAllVWByInboundReqId(RelReq.InboundRequestId);
            if (!Information.IsNothing(fu))
            {
                followUpQty = RelReq.TotalQtyAccptOfRequest - SumAddedLocations;
                var newRel = new VW_Release();
                newRel.ReleaseNumber = "FOLLOW UP";
                newRel.TotalQtyAccepted = followUpQty;
                pnlFollowUp.Show();
                ReleaseList.Add(newRel);
            }

            var inReqDeclinedList = ReleaseList.Where(r => r.InboundReqDeclinedQtyId != 0).ToList();
            if (inReqDeclinedList.Count > 0)
            {
                InReqDeclined = InboundReqDeclinedQtyService.GetById(inReqDeclinedList[0].InboundReqDeclinedQtyId);
                var newRel = new VW_Release();
                newRel.ReleaseNumber = InReqDeclined.DeclineStatus;
                newRel.TotalQtyAccepted = InReqDeclined.QtyDeclined;
                ReleaseList.Add(newRel);
                btnManageBal.Enabled = false;
            }

            VWReleaseBindingSource.DataSource = null;
            VWReleaseBindingSource.DataSource = ReleaseList;
            dgvRelease.DataSource = null;
            dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
            if (!Information.IsNothing(dgvRelease.CurrentRow) && dgvRelease.Rows.Count > 0 && InReqDeclined.InboundReqDeclinedQtyId == 0)
            {
                VW_Release focusedRel = (VW_Release)dgvRelease.CurrentRow.DataBoundItem;
                RelOrderList = ReleaseOrderService.GetAllVWByReleaseId(focusedRel.ReleaseId);
                cboRelOrder.DataSource = RelOrderList;
                cboRelOrder.DisplayMember = "RelOrder";
                cboRelOrder.ValueMember = "ReleaseOrderId";
            }

            firstLoad = false;
            CalculateQtys();
        }

        private void checkFollowUpAndWriteOffs()
        {
            if (!Information.IsNothing(fu))
            {
                followUpQty = RelReq.TotalQtyAccptOfRequest - SumAddedLocations;
                var newRel = new VW_Release();
                newRel.ReleaseNumber = "FOLLOW UP";
                newRel.TotalQtyAccepted = followUpQty;
                pnlFollowUp.Show();
                ReleaseList.Add(newRel);
            }

            if (InReqDeclined.InboundReqDeclinedQtyId != 0)
            {
                var newRel = new VW_Release();
                newRel.ReleaseNumber = InReqDeclined.DeclineStatus;
                newRel.TotalQtyAccepted = InReqDeclined.QtyDeclined;
                ReleaseList.Add(newRel);
                btnManageBal.Enabled = false;
            }

            dgvRelease.DataSource = null;
            VWReleaseBindingSource.DataSource = null;
            VWReleaseBindingSource.DataSource = ReleaseList;
            dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
        }

        private void CalculateQtys()
        {
            if (!firstLoad)
            {
                btnManageBal.Enabled = true;
                VW_RelOrderPickUpDropOffLocation pudo; // pudoList As New List(Of VW_RelOrderPickUpDropOffLocation),
                int SumAddedLocations = 0;
                int balRelease;
                int balPudo;
                var TotalQtyAccptOfRequest = default(int);
                foreach (DataGridViewRow row in dgvPickUpDropOff.Rows)
                {
                    pudo = (VW_RelOrderPickUpDropOffLocation)row.DataBoundItem;
                    SumAddedLocations += pudo.QtyPickUpDropOff;
                }

                // pudoList = pudoService.GetByInboundRequestId(RelReq.InboundRequestId)

                foreach (var row in ReleaseList)
                {
                    TotalQtyAccptOfRequest = (int)(TotalQtyAccptOfRequest + row.TotalQtyAccepted);
                    if (row.ReleaseNumber == "DECLINED" | row.ReleaseNumber == "WRITE OFF")
                        btnManageBal.Enabled = false;
                }

                balRelease = RelReq.QtyRequested - TotalQtyAccptOfRequest;
                balPudo = TotalQtyAccptOfRequest + followUpQty - SumAddedLocations;
                if (balRelease == 0)
                {
                    lblBalRelease.ForeColor = Color.Green;
                    btnComplete.Enabled = true;
                }
                else
                {
                    lblBalRelease.ForeColor = Color.Firebrick;
                    btnComplete.Enabled = false;
                }

                if (balPudo == 0)
                {
                    lblBalPickUpDropOff.ForeColor = Color.Green;
                }
                else
                {
                    lblBalPickUpDropOff.ForeColor = Color.Firebrick;
                }

                lblBalRelease.Text = balRelease.ToString();
                lblBalPickUpDropOff.Text = balPudo.ToString();
                lblAddedRel.Text = TotalQtyAccptOfRequest.ToString();
                lblAddedPickUpDropOff.Text = TotalQtyAccptOfRequest.ToString();
                lblTotalReq.Text = RelReq.QtyRequested.ToString();
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditRelease.isNewRelease = true;
            My.MyProject.Forms.FrmAddEditRelease.RelReq = RelReq;
            My.MyProject.Forms.FrmAddEditRelease.LoadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRelease, this);
            RelReq = InboundRequestService.GetVWById(RelReq.InboundRequestId);
            ReleaseList = ReleaseService.GetAllVWByInboundReqId(RelReq.InboundRequestId);
            checkFollowUpAndWriteOffs();
            CalculateQtys();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var inbService = new InboundRequestService();
            InboundRequest inbReq;
            inbReq = InboundRequestService.GetById(RelReq.InboundRequestId);
            inbReq.RequestStatusId = Conversions.ToInteger(cbStatus.SelectedValue);
            if (inbService.AddOrUpdate(inbReq))
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(MdlEnum.RequestStatus.FOLLOW_UP, cbStatus.SelectedValue, false)))
                {
                    // fu.InboundRequestId = RelReq.InboundRequestId
                    if (Information.IsNothing(fu))
                    {
                        fu = new InboundFollowUpRequest();
                    }
                    else
                    {
                        fu.isOpenFollowUp = false;
                        followUpServ.AddOrUpdate(fu);
                        fu = new InboundFollowUpRequest();
                    }

                    fu.DueDate = dtpFollowUpDate.Value;
                    fu.InboundRequestId = RelReq.InboundRequestId;
                    fu.CreatedAt = DateAndTime.Now;
                    fu.isOpenFollowUp = true;
                    followUpServ.AddOrUpdate(fu);
                }

                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Request status not updated.", "There was a problem updating the status of this request. Please try again or contact IT department", this);
            }
        }

        private void btnAddNewPUDO_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditReleasePickUpDropOff.LoadForm();
            My.MyProject.Forms.FrmAddEditReleasePickUpDropOff.isNewRecord = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditReleasePickUpDropOff, this);
            PickUpDropOffLocations = RelOrderPickUpDropOffLocationService.GetByReleaseOrderId(SelectedReleaseOrder.ReleaseOrderId);
            dgvPickUpDropOff.DataSource = null;
            dgvPickUpDropOff.DataSource = PickUpDropOffLocations;
            CalculateQtys();
        }

        private void dgvRelease_SelectionChanged(object sender, EventArgs e)
        {
            PopulateRelOrder();
        }

        private void PopulateRelOrder()
        {
            if (!Information.IsNothing(dgvRelease.CurrentRow) && !firstLoad)
            {
                var relNumb = dgvRelease.CurrentCell.Value;
                if (!Information.IsNothing(relNumb) && !relNumb.Equals("WRITE OFF") && !relNumb.Equals("DECLINED") && !relNumb.Equals("FOLLOW UP"))
                {
                    SelectedRelease = (VW_Release)dgvRelease.CurrentRow.DataBoundItem;
                    RelOrderList = ReleaseOrderService.GetAllVWByReleaseId(SelectedRelease.ReleaseId).Where(r => !(r.ReleaseNumber == "WRITE OFF") && !(r.ReleaseNumber == "DECLINED")).ToList();
                    cboRelOrder.DataSource = RelOrderList;
                    cboRelOrder.DisplayMember = "RelOrder";
                    cboRelOrder.ValueMember = "ReleaseOrderId";
                }
                else
                {
                    cboRelOrder.DataSource = null;
                }
            }
            else
            {
                cboRelOrder.DataSource = null;
            }
        }

        private void cboRelOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Information.IsNothing(cboRelOrder.DataSource))
            {
                SelectedReleaseOrder = (VW_ReleaseOrder)cboRelOrder.SelectedItem;
                PickUpDropOffLocations = RelOrderPickUpDropOffLocationService.GetByReleaseOrderId(SelectedReleaseOrder.ReleaseOrderId);
                dgvPickUpDropOff.DataSource = null;
                dgvPickUpDropOff.DataSource = PickUpDropOffLocations;
            }
        }

        private void dgvRelease_DoubleClick(object sender, EventArgs e)
        {
            string relNumber = Conversions.ToString(dgvRelease.CurrentCell.Value);
            switch (relNumber ?? "")
            {
                case "WRITE OFF":
                    {
                        My.MyProject.Forms.FrmManageReleaseBalance.isNewRecord = false;
                        My.MyProject.Forms.FrmManageReleaseBalance.PopulateInfo(InReqDeclined, Convert.ToInt32(lblBalRelease.Text));
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmManageReleaseBalance, this);
                        break;
                    }

                case "DECLINED":
                    {
                        My.MyProject.Forms.FrmManageReleaseBalance.isNewRecord = false;
                        My.MyProject.Forms.FrmManageReleaseBalance.PopulateInfo(InReqDeclined, Convert.ToInt32(lblBalRelease.Text));
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmManageReleaseBalance, this);
                        break;
                    }

                case "FOLLOW UP":
                    {
                        break;
                    }

                default:
                    {
                        SelectedRelease = (VW_Release)dgvRelease.CurrentRow.DataBoundItem;
                        My.MyProject.Forms.FrmAddEditRelease.isNewRelease = false;
                        My.MyProject.Forms.FrmAddEditRelease.PopulateInfo(SelectedRelease);
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditRelease, this);
                        ReleaseList = ReleaseService.GetAllVWByInboundReqId(RelReq.InboundRequestId);
                        VWReleaseBindingSource.DataSource = null;
                        VWReleaseBindingSource.DataSource = ReleaseList;
                        dgvRelease.DataSource = null;
                        dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
                        CheckReleaseManagementList();
                        break;
                    }
            }
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRmRel_Click(object sender, EventArgs e)
        {
            SelectedRelease = (VW_Release)dgvRelease.CurrentRow.DataBoundItem;
            if (SelectedRelease.ReleaseNumber != "FOLLOW UP" && InReqDeclined.InboundReqDeclinedQtyId == 0)
            {
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to do this?", "This can not be undone. All releases order and assignments to  Minibookings will be removed.", My.Resources.Resources.warning, this);
                if (result == DialogResult.Yes)
                {
                    var RelService = new ReleaseService();
                    if (RelService.Delete(SelectedRelease.ReleaseId))
                    {
                        ReleaseList.Remove(SelectedRelease);
                    }
                }
            }
            else if (SelectedRelease.ReleaseNumber == "FOLLOW UP")
            {
                if (!Information.IsNothing(fu) && fu.InboundFollowUpRequestId != 0)
                {
                    if (fuService.AddOrUpdate(fu))
                    {
                        followUpQty = 0;
                        fu.isOpenFollowUp = Conversions.ToBoolean(0);
                        ReleaseList.Remove(SelectedRelease);
                    }
                }
                else
                {
                    ReleaseList.Remove(SelectedRelease);
                }
            }
            else
            {
                var idqs = new InboundReqDeclinedQtyService();
                if (idqs.Delete(InReqDeclined.InboundReqDeclinedQtyId))
                {
                    ReleaseList.Remove(SelectedRelease);
                }
            }

            dgvRelease.DataSource = null;
            VWReleaseBindingSource.DataSource = null;
            VWReleaseBindingSource.DataSource = ReleaseList;
            dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
            CalculateQtys();
        }

        private void btnRmPickUpDropOff_Click(object sender, EventArgs e)
        {
            VW_RelOrderPickUpDropOffLocation selecPudo = (VW_RelOrderPickUpDropOffLocation)dgvPickUpDropOff.CurrentRow.DataBoundItem;
            if (pudoService.Delete(selecPudo.RelOrderPickUpDropOffLocationId))
            {
                PickUpDropOffLocations.Remove(selecPudo);
                dgvPickUpDropOff.DataSource = null;
                dgvPickUpDropOff.DataSource = PickUpDropOffLocations;
                CalculateQtys();
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fupRel = "FOLLOW UP";
            bool followUpExists = ReleaseList.Where(s => (s.ReleaseNumber ?? "") == (fupRel ?? "")).Count() > 0;
            // ReleaseList = VWReleaseBindingSource.DataSource
            if (!firstLoad)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(MdlEnum.RequestStatus.FOLLOW_UP, cbStatus.SelectedValue, false)))
                {
                    pnlFollowUp.Show();
                    if (followUpExists == false)
                    {
                        followUpQty = RelReq.QtyRequested - SumAddedLocations;
                        var newRel = new VW_Release();
                        newRel.ReleaseNumber = fupRel;
                        int qtyFup = MaxQtyAllowedFollowUp();
                        newRel.TotalQtyAccepted = qtyFup;
                        ReleaseList.Add(newRel);
                        nudFlwUpQtyCans.Maximum = qtyFup;
                        nudFlwUpQtyCans.Value = qtyFup;
                    }
                    else if (followUpExists)
                    {

                        // TODO if follow up existed, set its status to false
                        if (fuService.AddOrUpdate(fu))
                        {
                            followUpQty = 0;
                            fu.isOpenFollowUp = Conversions.ToBoolean(0);
                            ReleaseList.Remove(SelectedRelease);
                        }
                    }
                }
                else
                {
                    if (followUpExists)
                    {
                        var rel = ReleaseList.Where(r => (r.ReleaseNumber ?? "") == (fupRel ?? "")).ToList()[0];
                        ReleaseList.Remove(rel);
                        VWReleaseBindingSource.DataSource = null;
                        VWReleaseBindingSource.DataSource = ReleaseList;
                    }

                    pnlFollowUp.Hide();
                }
            }

            dgvRelease.DataSource = null;
            VWReleaseBindingSource.DataSource = null;
            VWReleaseBindingSource.DataSource = ReleaseList;
            dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
            CalculateQtys();
        }

        private int MaxQtyAllowedFollowUp()
        {
            var TotalQtyAccptOfRequest = default(int);
            foreach (var row in ReleaseList)
                TotalQtyAccptOfRequest = (int)(TotalQtyAccptOfRequest + row.TotalQtyAccepted);
            return RelReq.QtyRequested - TotalQtyAccptOfRequest;
        }

        private void nudFlwUpQtyCans_ValueChanged(object sender, EventArgs e)
        {
            foreach (var row in ReleaseList)
            {
                if (row.ReleaseNumber == "FOLLOW UP")
                {
                    row.TotalQtyAccepted = (int?)nudFlwUpQtyCans.Value;
                    break;
                }
            }

            dgvRelease.DataSource = null;
            VWReleaseBindingSource.DataSource = null;
            VWReleaseBindingSource.DataSource = ReleaseList;
            dgvRelease.DataSource = VWReleaseBindingSource.DataSource;
            CalculateQtys();
        }

        private void FrmUpdateReqStatus_Shown(object sender, EventArgs e)
        {
            firstLoad = false;
            PopulateRelOrder();
        }
    }
}