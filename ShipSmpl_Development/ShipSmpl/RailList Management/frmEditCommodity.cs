using BusinessLayer.WTC_Ceres;
using System;

namespace ShipSmpl
{
    public partial class frmEditCommodity
    {
        public frmEditCommodity()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnEditCommodity.Name = "btnEditCommodity";
        }

        public int CommodityId;

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditCommodity_Load(object sender, EventArgs e)
        {
            if (CommodityId != 0)
            {
                var L = CommodityService.GetById(CommodityId);
                txtCommodity.Text = L.CommodityName;
                txtCommodityCode.Text = L.CommodityCode;
            }
        }

        private void btnEditCommodity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCommodity.Text) | string.IsNullOrEmpty(txtCommodityCode.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Fields Empty !", "The Commodity or Commodity Code fields cannot be empty.", this);
            }
            else if (CommodityService.VerifyByCommodityCode(txtCommodityCode.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Warning!", "This registration code already exists!", this);
            }
            else if (CommodityId == 0)
            {
                if (CommodityService.Insert(txtCommodityCode.Text, txtCommodity.Text))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success", "Commodity inserted successfully.", this);
                    My.MyProject.Forms.frmCommodityGrainMain.LoadCommodity();
                    Close();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error!", "There was an error when changing the Commodity, please contact the IT department. Error # 0121", this);
                }
            }
            else if (CommodityService.Update(CommodityId, txtCommodityCode.Text, txtCommodity.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success", "Commodity updated successfully.", this);
                My.MyProject.Forms.frmCommodityGrainMain.LoadCommodity();
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error!", "There was an error when changing the Commodity, please contact the IT department. Error # 0121", this);
            }
        }
    }
}