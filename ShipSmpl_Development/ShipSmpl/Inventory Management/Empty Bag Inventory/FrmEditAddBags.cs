using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Data;
using System.Linq;

namespace ShipSmpl
{
    public partial class FrmEditAddBags
    {
        public FrmEditAddBags()
        {
            InitializeComponent();
            _btnChooseLogo.Name = "btnChooseLogo";
            _cboBagWeight.Name = "cboBagWeight";
            _closeFlatButton.Name = "closeFlatButton";
            _btnSave.Name = "btnSave";
            _btnAddLogo.Name = "btnAddLogo";
            _BunifuFlatButton1.Name = "BunifuFlatButton1";
            _btnOkLogo.Name = "btnOkLogo";
            _dgvLogos.Name = "dgvLogos";
        }

        private VW_Bag FocusedBagInv;
        public bool isNewInventory = true;
        private int selectedLogoId = 0;
        private BagLogo selectedLogo;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isGoodToGo())
            {
                SaveUpdateInfo(isNewInventory);
                My.MyProject.Forms.FrmEmptyBagInvList.dgvInventory.DataSource = BagInventoryService.GetAllInventory(true);
                My.MyProject.Forms.FrmAddEditInventory.dgvBags.DataSource = BagInventoryService.GetAllBags();
                Close();
            }
        }

        private void cboBagWeight_SelectedValueChanged(object sender, EventArgs e)
        {
            BagWeight b = (BagWeight)cboBagWeight.SelectedItem;
            lblUnitWeight.Text = Conversions.ToString(b.BagUnit);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void loadForm()
        {
            {
                var withBlock = cboBagSize;
                withBlock.DataSource = BagInventoryService.GetAllBagSize();
                withBlock.DisplayMember = "BagSizeName";
                withBlock.ValueMember = "BagSizeId";
            }

            {
                var withBlock1 = cboBagWeight;
                withBlock1.DataSource = BagInventoryService.GetAllBagWeights();
                withBlock1.DisplayMember = "BagWeightName";
                withBlock1.ValueMember = "BagWeightId";
            }

            {
                var withBlock2 = cboBagColor;
                withBlock2.DataSource = BagInventoryService.GetAllColors();
                withBlock2.DisplayMember = "ColorName";
                withBlock2.ValueMember = "ColorId";
            }

            {
                var withBlock3 = cboColortype;
                withBlock3.Items.Clear();
                withBlock3.Items.Add("Solid");
                withBlock3.Items.Add("Multicolor");
                withBlock3.SelectedIndex = 0;
            }

            dgvLogos.DataSource = BagInventoryService.GetAllBagLogos().Where(b => b.LogoDescription != "N/A").ToList();
            selectedLogo = null;
            tbBagDescription.Text = "";
            lblWarning.Text = "";
            pbLogo.Image = null;
        }

        public void LoadEditInfo(VW_Bag BagInfo)
        {
            FocusedBagInv = BagInfo;
            // cboCustomer.SelectedValue = BagInfo.CustomerId

            cboBagSize.SelectedValue = BagInfo.BagSizeId;
            cboBagWeight.SelectedValue = BagInfo.BagWeightId;
            cboBagColor.SelectedValue = BagInfo.ColorId;
            cboColortype.SelectedItem = BagInfo.ColorType;
            tbBagDescription.Text = BagInfo.BagDescription;
            string path = "Operations/EmptyBags/BagPictures";
            var ftp = new MdlFtp();
            if (!BagInfo.ImagePath.Equals("N/A"))
            {
                selectedLogo = BagInventoryService.GetBagLogoById(BagInfo.BagLogoId);
                var image = ftp.GetFTPImage(BagInfo.ImagePath);
                pbLogo.Image = image;
            }
        }

        private void SaveUpdateInfo(bool isNewInventory)
        {
            var bs = new BagInventoryService();
            int bagId;
            if (!Information.IsNothing(selectedLogo))
            {
                if (isNewInventory)
                {
                    bs.InsertBag(Conversions.ToInteger(cboBagSize.SelectedValue), Conversions.ToInteger(cboBagWeight.SelectedValue), Conversions.ToInteger(cboBagColor.SelectedValue), Conversions.ToString(cboColortype.SelectedItem), selectedLogo.BagLogoId, tbBagDescription.Text);
                    bagId = bs.GetLastBagId();
                }
                else
                {
                    bs.UpdateBag(FocusedBagInv.BagId, Conversions.ToInteger(cboBagSize.SelectedValue), Conversions.ToInteger(cboBagWeight.SelectedValue), Conversions.ToInteger(cboBagColor.SelectedValue), Conversions.ToString(cboColortype.SelectedItem), selectedLogo.BagLogoId, tbBagDescription.Text);
                    // bs.UpdateBagLogo(selectedLogo.BagLogoId, selectedLogo.LogoDescription, selectedLogo.BagYear, selectedLogo.ImagePath)

                }
            }
            else if (isNewInventory)
            {
                bs.InsertBag(Conversions.ToInteger(cboBagSize.SelectedValue), Conversions.ToInteger(cboBagWeight.SelectedValue), Conversions.ToInteger(cboBagColor.SelectedValue), Conversions.ToString(cboColortype.SelectedItem), 0, tbBagDescription.Text);
                bagId = bs.GetLastBagId();
            }
            else
            {
                bs.UpdateBag(FocusedBagInv.BagId, Conversions.ToInteger(cboBagSize.SelectedValue), Conversions.ToInteger(cboBagWeight.SelectedValue), Conversions.ToInteger(cboBagColor.SelectedValue), Conversions.ToString(cboColortype.SelectedItem), 0, tbBagDescription.Text);
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelLogoList.Hide();
        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            if (panelLogoList.Visible)
            {
                panelLogoList.Hide();
            }
            else
            {
                panelLogoList.Show();
            }
        }

        private void btnOkLogo_Click(object sender, EventArgs e)
        {
            if (dgvLogos.Rows.Count > 0)
            {
                selectedLogo = (BagLogo)dgvLogos.CurrentRow.DataBoundItem;
                selectedLogoId = selectedLogo.BagLogoId;
                lblBagLogo.Text = selectedLogo.LogoDescription;
                var ftp = new MdlFtp();
                var image = ftp.GetFTPImage(selectedLogo.ImagePath);
                pbLogo.Image = image;
                panelLogoList.Hide();
            }
            else
            {
                lblWarning.Text = "No logo selected. Please add a logo.";
            }
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditBagLogo.isNewLogo = true;
            My.MyProject.Forms.FrmAddEditBagLogo.LoadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditBagLogo, this);
        }

        private void dgvLogos_DoubleClick(object sender, EventArgs e)
        {
            BagLogo BagLogoInfo = (BagLogo)dgvLogos.Rows[dgvLogos.CurrentRow.Index].DataBoundItem;
            My.MyProject.Forms.FrmAddEditBagLogo.isNewLogo = false;
            My.MyProject.Forms.FrmAddEditBagLogo.LoadForm();
            My.MyProject.Forms.FrmAddEditBagLogo.LoadEditInfo(BagLogoInfo);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditBagLogo, this);
        }

        private bool isGoodToGo()
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboBagColor.SelectedValue, 0, false)))
            {
                lblWarning.Text = "Bag color can not be empty";
                return false;
            }

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboBagSize.SelectedValue, 0, false)))
            {
                lblWarning.Text = "Bag size can not be empty";
                return false;
            }

            if (string.IsNullOrEmpty(tbBagDescription.Text))
            {
                lblWarning.Text = "Bag Description can not be empty";
                return false;
            }

            return true;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}