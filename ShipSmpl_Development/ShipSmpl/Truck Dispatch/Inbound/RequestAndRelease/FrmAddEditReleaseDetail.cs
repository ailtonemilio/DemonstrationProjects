using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAddEditReleaseDetail
    {
        public FrmAddEditReleaseDetail()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _btnClose.Name = "btnClose";
        }

        public bool isNewRecord;
        public ReleaseOrder updatedRelDetail = new ReleaseOrder();
        private ReleaseOrderService relOrderServ = new ReleaseOrderService();

        public void LoadForm()
        {
            dpReleaseDate.Value = DateAndTime.Now;
            nudQtyCans.Value = 0m;
        }

        public void PopulateInfo(ReleaseOrder relDetail)
        {
            LoadForm();
            updatedRelDetail = relDetail;
            if (!Information.IsNothing(relDetail.DateAccepted))
            {
                dpReleaseDate.Value = (DateTime)relDetail.DateAccepted;
            }
            else
            {
                dpReleaseDate.Value = DateAndTime.Now;
            }

            nudQtyCans.Value = relDetail.QtyAccepted;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (isNewRecord)
            {
                updatedRelDetail = new ReleaseOrder();
                updatedRelDetail.CreatedAt = DateAndTime.Now;
            }

            updatedRelDetail.QtyAccepted = (int)Math.Round(nudQtyCans.Value);
            updatedRelDetail.DateAccepted = dpReleaseDate.Value;
            relOrderServ.AddOrUpdate(updatedRelDetail);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}