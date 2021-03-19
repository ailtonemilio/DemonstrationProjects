using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAddEditReleasePickUpDropOff
    {
        public FrmAddEditReleasePickUpDropOff()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _btnClose.Name = "btnClose";
        }

        public bool isNewRecord;
        private VW_RelOrderPickUpDropOffLocation relPuDol;

        public void LoadForm()
        {
            {
                var withBlock = cbPickUp;
                withBlock.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Container_Terminal, new WTCCeresEntities());
                withBlock.DisplayMember = "CompanyName";
                withBlock.ValueMember = "CompanyId";
            }

            {
                var withBlock1 = cbDropOff;
                withBlock1.DataSource = YardLocationService.GetAll();
                withBlock1.DisplayMember = "YardName";
                withBlock1.ValueMember = "YardLocationId";
            }

            nudQtyCans.Value = 0m;
            lblRelOrder.Text = "";
        }

        public void PopulateInfo(VW_RelOrderPickUpDropOffLocation relDistReq)
        {
            LoadForm();
            relPuDol = relDistReq;
            cbPickUp.SelectedValue = relDistReq.PickUpTerminalId;
            cbDropOff.SelectedValue = relDistReq.DropOffYardLocationId;
            nudQtyCans.Value = relDistReq.QtyPickUpDropOff;
            lblRelOrder.Text = relDistReq.ReleaseNumber;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var pudoService = new RelOrderPickUpDropOffLocationService();
            var pudo = new RelOrderPickUpDropOffLocation();
            if (isNewRecord)
            {
                pudo.ReleaseOrderId = My.MyProject.Forms.FrmUpdateReqStatus.SelectedReleaseOrder.ReleaseOrderId;
            }
            else
            {
                pudo = RelOrderPickUpDropOffLocationService.GetById(relPuDol.RelOrderPickUpDropOffLocationId);
            }

            pudo.PickUpTerminalId = Conversions.ToInteger(cbPickUp.SelectedValue);
            pudo.DropOffYardLocationId = Conversions.ToInteger(cbDropOff.SelectedValue);
            pudo.QtyPickUpDropOff = (int)Math.Round(nudQtyCans.Value);
            if (pudoService.AddOrUpdate(pudo))
            {
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("An error occurred", "Something happened and the information was not saved", this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}