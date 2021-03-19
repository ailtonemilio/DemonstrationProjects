using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmManageReleaseBalance
    {
        public FrmManageReleaseBalance()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _btnClose.Name = "btnClose";
            _cboDelineStatus.Name = "cboDelineStatus";
            _tbNotes.Name = "tbNotes";
        }

        private InboundReqDeclinedQty InReqDeclined;
        public bool isNewRecord;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadForm(VW_InboundRequest inreq)
        {
            {
                var withBlock = cboDelineStatus;
                withBlock.Items.Clear();
                var list = RequestStatusService.GetByFlowType("INBOUND - BAL");
                foreach (var item in list)
                    withBlock.Items.Add(item.StatusName);
                withBlock.SelectedIndex = 0;
            }

            tbNotes.Text = "";
            nudQtyCans.Value = 0m;
            InReqDeclined = new InboundReqDeclinedQty();
            InReqDeclined.InboundRequestId = inreq.InboundRequestId;
            btnComplete.Enabled = false;
        }

        public void PopulateInfo(InboundReqDeclinedQty ro, int maxToDecline)
        {
            InReqDeclined = ro;
            tbNotes.Text = InReqDeclined.Notes;
            nudQtyCans.Value = InReqDeclined.QtyDeclined;
            cboDelineStatus.SelectedItem = InReqDeclined.DeclineStatus;
            IsGoodToGo();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (IsGoodToGo())
            {
                var ird = new InboundReqDeclinedQtyService();
                if (isNewRecord)
                {
                    InReqDeclined.CreatedAt = DateAndTime.Now;
                }

                InReqDeclined.Notes = Strings.Trim(tbNotes.Text);
                InReqDeclined.QtyDeclined = (int)Math.Round(nudQtyCans.Value);
                InReqDeclined.DeclineStatus = cboDelineStatus.Text;
                if (ird.AddOrUpdate(InReqDeclined))
                {
                    {
                        var withBlock = My.MyProject.Forms.FrmUpdateReqStatus;
                        withBlock.InReqDeclined = InReqDeclined;
                        if (isNewRecord)
                        {
                            var newRel = new VW_Release();
                            newRel.ReleaseNumber = InReqDeclined.DeclineStatus;
                            newRel.TotalQtyAccepted = InReqDeclined.QtyDeclined;
                            withBlock.ReleaseList.Add(newRel);
                        }
                        else
                        {
                            var newRel = new VW_Release();
                            newRel.ReleaseNumber = InReqDeclined.DeclineStatus;
                            newRel.TotalQtyAccepted = InReqDeclined.QtyDeclined;
                            withBlock.ReleaseList[withBlock.dgvRelease.CurrentRow.Index] = newRel;
                        }
                    }

                    Close();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Not saved.", "There was a problem and the information was not saved", this);
                }
            }
        }

        private bool IsGoodToGo()
        {
            bool goodToGo = true;
            btnComplete.Enabled = true;
            lblWarning.Text = "";
            if (nudQtyCans.Value == 0m)
            {
                goodToGo = false;
                btnComplete.Enabled = false;
                lblWarning.Text = "Quantity can not be 0.";
            }

            return goodToGo;
        }

        private void cboDelineStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsGoodToGo();
        }
    }
}