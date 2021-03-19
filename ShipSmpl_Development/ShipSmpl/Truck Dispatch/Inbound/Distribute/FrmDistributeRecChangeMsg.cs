using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmDistributeRecChangeMsg
    {
        public FrmDistributeRecChangeMsg()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _BunifuButton1.Name = "BunifuButton1";
            _dgvProposedChange.Name = "dgvProposedChange";
        }

        private List<RequestStatus> RequestStatusList = new List<RequestStatus>();
        private RelDistChangeSchRequestedService relchService = new RelDistChangeSchRequestedService();
        private VW_RelDistChangeSchRequested focusedRow;
        private ReleaseDistributionRequest focusedReleaseDistribution;
        private RelDistRequestSchedule sch;
        private RelDistRequestScheduleService schService = new RelDistRequestScheduleService();

        public void LoadForm(VW_ReleaseDistributionRequest r)
        {
            RequestStatusList = RequestStatusService.GetByFlowType("INBOUND");
            focusedReleaseDistribution = ReleaseDistributionRequestService.GetById(r.ReleaseDistributionRequestId);
            {
                var withBlock = cboDistReqStatus;
                withBlock.DataSource = RequestStatusList;
                withBlock.DisplayMember = "StatusName";
                withBlock.ValueMember = "RequestStatusId";
            }

            tbNotes.Text = "";
            var list = RelDistChangeSchRequestedService.GetByRelDistRequestId(r.ReleaseDistributionRequestId);
            VWRelDistChangeSchRequestedBindingSource.DataSource = null;
            VWRelDistChangeSchRequestedBindingSource.DataSource = list;
            sch = new RelDistRequestSchedule();
            focusedRow = (VW_RelDistChangeSchRequested)dgvProposedChange.CurrentRow.DataBoundItem;
            sch = RelDistRequestScheduleService.GetById(focusedRow.RelDistRequestScheduleId);
            cboDistReqStatus.SelectedValue = r.RequestStatusId;
            tbNotes.Text = list[0].WTCMessage;
            lblCarrierNotes.Text = list[0].CarrierMessage;
            AddComboBoxCol();
        }

        private void AddComboBoxCol()
        {
            if (!dgvProposedChange.Columns.Contains("cboAction"))
            {
                var newListStatus = new List<RequestStatus>();
                newListStatus = RequestStatusList;
                var cboActions = new DataGridViewComboBoxColumn();
                cboActions.HeaderText = "";
                cboActions.Name = "cboAction";
                cboActions.MaxDropDownItems = 10;
                cboActions.Width = 120;
                cboActions.DataSource = newListStatus;
                cboActions.DisplayMember = "StatusName";
                cboActions.ValueMember = "RequestStatusId";
                dgvProposedChange.Columns.Add(cboActions);
                dgvProposedChange.Refresh();
            }
        }

        private void dgvProposedChange_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvProposedChange.Columns.Contains("cboAction"))
            {
                VW_RelDistChangeSchRequested focusedRow;
                focusedRow = (VW_RelDistChangeSchRequested)dgvProposedChange.Rows[e.RowIndex].DataBoundItem;
                dgvProposedChange.Rows[e.RowIndex].Cells["cboAction"].Value = focusedRow.ChangeReqStatusId;
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProposedChange_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var changedFromDate = dgvProposedChange.Rows[e.RowIndex].Cells[0];
            var changedToDate = dgvProposedChange.Rows[e.RowIndex].Cells[1];
            var changedQty = dgvProposedChange.Rows[e.RowIndex].Cells[2];
            focusedRow = (VW_RelDistChangeSchRequested)dgvProposedChange.Rows[e.RowIndex].DataBoundItem;
            if (!(focusedRow.OrigFromDate.Date == focusedRow.FromDateChange.Date))
            {
                changedFromDate.Style.Font = new Font("Arial", 12f, FontStyle.Bold);
                changedFromDate.Style.ForeColor = Color.Firebrick;
                changedFromDate.Style.SelectionForeColor = Color.Firebrick;
            }

            if (!(focusedRow.OrigToDate.Date == focusedRow.ToDateChange.Date))
            {
                changedToDate.Style.Font = new Font("Arial", 12f, FontStyle.Bold);
                changedToDate.Style.ForeColor = Color.Firebrick;
                changedToDate.Style.SelectionForeColor = Color.Firebrick;
            }

            if (!(focusedRow.OrigQtyRequested == focusedRow.QtyRequestdChange))
            {
                changedQty.Style.Font = new Font("Arial", 12f, FontStyle.Bold);
                changedQty.Style.ForeColor = Color.Firebrick;
                changedQty.Style.SelectionForeColor = Color.Firebrick;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            VW_RelDistChangeSchRequested focusedRow;
            var relDReqSch = new RelDistChangeReqSchedule();
            var relDistServAs = new ReleaseDistributionRequestService();
            var distAcptService = new RelDistScheduleAcceptedService();
            int status;
            foreach (DataGridViewRow row in dgvProposedChange.Rows)
            {
                focusedRow = (VW_RelDistChangeSchRequested)row.DataBoundItem;
                status = Convert.ToInt32(row.Cells["cboAction"].Value);
                relDReqSch = RelDistChangeSchRequestedService.GetById(focusedRow.RelDistChangeReqScheduleId);
                relDReqSch.isRead = true;
                relDReqSch.RequestStatusId = status;
                relDReqSch.WTCNote = tbNotes.Text;
                bool isSaved = relchService.AddOrUpdate(relDReqSch);
                focusedReleaseDistribution.RequestStatusId = Conversions.ToInteger(cboDistReqStatus.SelectedValue);
                relDistServAs.AddOrUpdate(focusedReleaseDistribution);
                if (status == (int)MdlEnum.RequestStatus.ACCEPTED)
                {
                    var distAcpt = new RelDistScheduleAccepted();
                    distAcpt.QtyAccepted = focusedRow.QtyRequestdChange;
                    distAcpt.RelDistRequestScheduleId = focusedRow.RelDistRequestScheduleId;
                    distAcpt.FromDate = focusedRow.FromDateChange;
                    distAcpt.ToDate = focusedRow.ToDateChange;
                    distAcpt.DateAccepted = DateAndTime.Now;
                    distAcpt.WTCMessage = tbNotes.Text;
                    distAcptService.AddOrUpdate(distAcpt);
                }

                // sch = New RelDistRequestSchedule
                focusedRow = (VW_RelDistChangeSchRequested)dgvProposedChange.CurrentRow.DataBoundItem;
                sch = RelDistRequestScheduleService.GetById(focusedRow.RelDistRequestScheduleId);
                sch.RequestStatusId = status;
                isSaved = schService.AddOrUpdate(sch);
            }

            Close();
        }

        private void dgvProposedChange_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProposedChange.Columns[e.ColumnIndex].Name == "cboAction")
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvProposedChange.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, 4, false)))
                {
                    focusedRow = (VW_RelDistChangeSchRequested)dgvProposedChange.CurrentRow.DataBoundItem;
                    My.MyProject.Forms.FrmRelDistSchDeclined.PopulateInfo(focusedRow);
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmRelDistSchDeclined, this);
                }
            }
        }
    }
}