using BusinessLayer.WTC_Ceres;
using DataLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmListDistributions
    {
        public FrmListDistributions()
        {
            InitializeComponent();
            _btnAddDate.Name = "btnAddDate";
            _dgvPUDODates.Name = "dgvPUDODates";
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _BunifuFlatButton1.Name = "BunifuFlatButton1";
            _dgvReleases.Name = "dgvReleases";
            _tgOpenCloseRequest.Name = "tgOpenCloseRequest";
            _btnRemove.Name = "btnRemove";
            _btnAddCarrier.Name = "btnAddCarrier";
            _dgvRelDistReq.Name = "dgvRelDistReq";
            _btnRmvDate.Name = "btnRmvDate";
        }

        public bool firstLoad = true;
        private VW_RelOrderPickUpDropOffLocation SelectedRelPUDORow;
        private SortableBindingList<VW_RelOrderPickUpDropOffLocation> RelPUDOList;
        private VW_ReleaseDistributionRequest SelRelDistReq;
        public SortableBindingList<VW_ReleaseDistributionRequest> RelDistReqList;
        private RelDistRequestSchedule SelPUDODate;
        private SortableBindingList<RelDistRequestSchedule> PUDOSchDateList;

        // Public relDistReqSchList As New List(Of VW_RelDistRequestSchedule)
        public SortableBindingList<VW_RelOrderPickUpDropOffLocation> RelOrderPudoList;
        private RelDistRequestScheduleService reqSchServ = new RelDistRequestScheduleService();

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tgOpenCloseRequest_OnValuechange(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                RefreshList(0);
            }

            CheckButtons();
        }

        private void BunifuButton9_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditDistRequest.isNewRecord = true;
            SelRelDistReq = (VW_ReleaseDistributionRequest)dgvRelDistReq.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmAddEditDistRequest.LoadForm(SelRelDistReq, PUDOSchDateList);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditDistRequest, this);
            RefreshList(2);
            CheckButtons();
        }

        private void dgvReleases_SelectionChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (dgvReleases.Rows.Count > 0)
                {
                    SelectedRelPUDORow = (VW_RelOrderPickUpDropOffLocation)dgvReleases.CurrentRow.DataBoundItem;
                    lblPickUpCode.Text = SelectedRelPUDORow.PickUpTerminalCode;
                    lblDropOff.Text = SelectedRelPUDORow.YardName;
                    RefreshList(1);
                    btnAddCarrier.Enabled = true;
                }
                else
                {
                    lblPickUpCode.Text = "";
                    lblDropOff.Text = "";
                    VWReleaseDistributionRequestBindingSource.DataSource = null;
                    btnAddCarrier.Enabled = false;
                }

                CheckButtons();
                CalculateTotals();
            }
        }

        private void dgvRelDistReq_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRelDistReq.Rows.Count > 0 && !firstLoad)
            {
                SelRelDistReq = (VW_ReleaseDistributionRequest)dgvRelDistReq.CurrentRow.DataBoundItem;
                RefreshList(2);
                return;
            }
            else
            {
                RelDistRequestScheduleBindingSource.DataSource = null;
            }

            CheckButtons();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SelRelDistReq = (VW_ReleaseDistributionRequest)dgvRelDistReq.CurrentRow.DataBoundItem;
            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Delete carrier request?", "All pick up date range will be deleted. This can not be undone." + Constants.vbNewLine + "Are you sure you want to delete this carrier request?", My.Resources.Resources.warning, this);
            if (result == DialogResult.Yes)
            {
                var relDistService = new ReleaseDistributionRequestService();
                if (relDistService.Delete(SelRelDistReq.ReleaseDistributionRequestId))
                {
                    RefreshList(1);
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information not deleted", "Something went wrong and the information was not deleted. Please try again.", this);
                }
            }

            CheckButtons();
        }

        private void btnAddCarrier_Click(object sender, EventArgs e)
        {
            SelectedRelPUDORow = (VW_RelOrderPickUpDropOffLocation)dgvReleases.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmAddEditCarrierReqDist.isNewRecord = true;
            My.MyProject.Forms.FrmAddEditCarrierReqDist.LoadForm(SelectedRelPUDORow);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditCarrierReqDist, this);
            RefreshList(1);
            CheckButtons();
        }

        private void btnRmvDate_Click(object sender, EventArgs e)
        {
            if (reqSchServ.Delete(SelPUDODate.RelDistRequestScheduleId))
            {
                RefreshList(2);
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information not deleted", "Something went wrong and the information was not deleted. Please try again.", this);
            }
        }

        private void dgvPUDODates_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPUDODates.Rows.Count > 0)
            {
                SelPUDODate = (RelDistRequestSchedule)dgvPUDODates.CurrentRow.DataBoundItem;
            }

            CheckButtons();
        }

        private void dgvPUDODates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                SelRelDistReq = (VW_ReleaseDistributionRequest)dgvRelDistReq.CurrentRow.DataBoundItem;
                My.MyProject.Forms.FrmAddEditDistRequest.isNewRecord = false;
                My.MyProject.Forms.FrmAddEditDistRequest.LoadForm(SelRelDistReq, PUDOSchDateList);
                My.MyProject.Forms.FrmAddEditDistRequest.PopulateInfo(SelRelDistReq, SelPUDODate);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditDistRequest, this);
                PUDOSchDateList = new SortableBindingList<RelDistRequestSchedule>(RelDistRequestScheduleService.GetAllByRelDistReqId(SelRelDistReq.ReleaseDistributionRequestId));
                RelDistRequestScheduleBindingSource.DataSource = PUDOSchDateList;
                CheckButtons();
                CalculateTotals();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void loadForm()
        {
            firstLoad = true;
            RefreshList(0);
            firstLoad = false;
            CheckButtons();
        }

        /// <summary>
        /// 0 = RelOrderPudoList; 1 = RelDistReqList; 2 = PUDODateList
        /// </summary>
        public void RefreshList(int listId)
        {
            switch (listId)
            {
                case 0:
                    {
                        firstLoad = true;
                        var list = RelOrderPickUpDropOffLocationService.GetAllByOpenStatus(tgOpenCloseRequest.Value);
                        RelOrderPudoList = new SortableBindingList<VW_RelOrderPickUpDropOffLocation>(list);
                        VWRelOrderPickUpDropOffLocationBindingSource.DataSource = null;
                        VWRelOrderPickUpDropOffLocationBindingSource.DataSource = RelOrderPudoList;
                        firstLoad = false;
                        break;
                    }

                case 1:
                    {
                        firstLoad = true;
                        var list = ReleaseDistributionRequestService.GetByRelPUDOId(SelectedRelPUDORow.RelOrderPickUpDropOffLocationId);
                        RelDistReqList = new SortableBindingList<VW_ReleaseDistributionRequest>(list);
                        VWReleaseDistributionRequestBindingSource.DataSource = RelDistReqList;
                        dgvRelDistReq.Refresh();
                        if (RelDistReqList.Count > 0)
                        {
                            SelRelDistReq = (VW_ReleaseDistributionRequest)dgvRelDistReq.CurrentRow.DataBoundItem;
                            CalculateTotals();
                            firstLoad = false;
                            RefreshList(2);
                        }
                        else
                        {
                            RelDistRequestScheduleBindingSource.DataSource = null;
                        }

                        firstLoad = false;
                        break;
                    }

                case 2:
                    {
                        firstLoad = true;
                        var list = RelDistRequestScheduleService.GetAllByRelDistReqId(SelRelDistReq.ReleaseDistributionRequestId);
                        PUDOSchDateList = new SortableBindingList<RelDistRequestSchedule>(list);
                        RelDistRequestScheduleBindingSource.DataSource = PUDOSchDateList;
                        firstLoad = false;
                        CalculateTotals();
                        break;
                    }
            }
        }

        private void CalculateTotals()
        {
            int sumOfCansCarrier = 0;
            int sumOfCansBySch = 0;
            if (!Information.IsNothing(RelDistReqList))
            {
                foreach (var order in RelDistReqList)
                    sumOfCansCarrier += order.QtyRequested;
            }

            if (!Information.IsNothing(PUDOSchDateList))
            {
                foreach (var sch in PUDOSchDateList)
                    sumOfCansBySch += sch.QtyRequested;
            }

            lblQtyReqPudo.Text = SelectedRelPUDORow.QtyPickUpDropOff.ToString();
            lblQtyDistPudo.Text = sumOfCansCarrier.ToString();
            lblBalPudo.Text = (SelectedRelPUDORow.QtyPickUpDropOff - sumOfCansCarrier).ToString();
            if (Conversions.ToDouble(lblBalPudo.Text) == 0d)
            {
                lblBalPudo.BackColor = Color.Green;
            }
            else
            {
                lblBalPudo.BackColor = Color.Brown;
            }

            if (Conversions.ToDouble(lblQtyDistPudo.Text) == 0d)
            {
                lblQtyDistPudo.BackColor = Color.Brown;
            }
            else
            {
                lblQtyDistPudo.BackColor = Color.Green;
            }

            lblSumCansSch.Text = sumOfCansBySch.ToString();
        }

        private void CheckButtons()
        {
            btnRemove.Enabled = false;
            btnRmvDate.Enabled = false;
            btnAddDate.Enabled = false;
            if (dgvRelDistReq.Rows.Count > 0)
            {
                btnRemove.Enabled = true;
                btnAddDate.Enabled = true;
            }

            if (dgvPUDODates.Rows.Count > 0)
            {
                btnRmvDate.Enabled = true;
            }
        }

        private void FrmListDistributions_Shown(object sender, EventArgs e)
        {
            firstLoad = false;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}