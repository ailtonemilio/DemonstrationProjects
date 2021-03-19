using BusinessLayer.WTC_Ceres;
using DataLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAddEditCarrierReqDist
    {
        public FrmAddEditCarrierReqDist()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _btnClose.Name = "btnClose";
        }

        public bool isNewRecord;
        private VW_ReleaseDistributionRequest RelDistReqVW;
        private ReleaseDistributionRequestService RelDistService = new ReleaseDistributionRequestService();
        private VW_RelOrderPickUpDropOffLocation SelRelPUDO;

        public void LoadForm(VW_RelOrderPickUpDropOffLocation relPudo)
        {
            {
                var withBlock = cboCarrier;
                withBlock.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Drayage_Provider, new WTCCeresEntities());
                withBlock.DisplayMember = "CompanyName";
                withBlock.ValueMember = "CompanyId";
            }

            lblReleaseNumb.Text = relPudo.ReleaseNumber;
            SelRelPUDO = relPudo;
            nudQtyCans.Maximum = Conversions.ToDecimal(Operators.SubtractObject(SelRelPUDO.QtyPickUpDropOff, GetSumCansCarriers()));
            nudQtyCans.Value = Conversions.ToDecimal(Operators.SubtractObject(SelRelPUDO.QtyPickUpDropOff, GetSumCansCarriers()));
        }

        public void PopulateInfo(VW_RelOrderPickUpDropOffLocation relPudo, VW_ReleaseDistributionRequest relDistReq)
        {
            RelDistReqVW = relDistReq;
            lblReleaseNumb.Text = relDistReq.ReleaseNumber;
            nudQtyCans.Maximum = Conversions.ToDecimal(Operators.SubtractObject(relPudo.QtyPickUpDropOff, GetSumCansCarriers()));
            nudQtyCans.Value = relDistReq.QtyRequested;
            cboCarrier.SelectedValue = relDistReq.CarrierId;
        }

        private object GetSumCansCarriers()
        {
            SortableBindingList<VW_ReleaseDistributionRequest> relOrderList;
            relOrderList = My.MyProject.Forms.FrmListDistributions.RelDistReqList;
            int sumOfCans = 0;
            foreach (var order in relOrderList)
                sumOfCans += order.QtyRequested;
            return sumOfCans;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            ReleaseDistributionRequest RelDistReq;
            if (isNewRecord)
            {
                RelDistReq = new ReleaseDistributionRequest();
                RelDistReq.RequestDate = DateAndTime.Now;
                RelDistReq.RequestStatusId = (int)MdlEnum.RequestStatus.PENDING_REPLY;
                RelDistReq.RelOrderPickUpDropOffLocationId = SelRelPUDO.RelOrderPickUpDropOffLocationId;
            }
            else
            {
                RelDistReq = ReleaseDistributionRequestService.GetById(RelDistReqVW.ReleaseDistributionRequestId);
            }

            RelDistReq.QtyRequested = (int)Math.Round(nudQtyCans.Value);
            RelDistReq.CarrierId = Conversions.ToInteger(cboCarrier.SelectedValue);
            if (RelDistService.AddOrUpdate(RelDistReq) == true)
            {
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information not saved.", "Something went wrong and the information was not saved. Please try again.", this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}