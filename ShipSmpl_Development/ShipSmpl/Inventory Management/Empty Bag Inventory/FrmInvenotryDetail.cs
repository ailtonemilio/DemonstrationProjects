using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmInvenotryDetail
    {
        public FrmInvenotryDetail()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _btnEdit.Name = "btnEdit";
            _BunifuButton1.Name = "BunifuButton1";
        }

        private VW_BagInventory selectedInventory;

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void PopulateInventoryInfo(VW_BagInventory InvInfo)
        {
            selectedInventory = InvInfo;
            var mdlFtp = new MdlFtp();
            lblCustomer.Text = InvInfo.CustomerName;
            lblQuantity.Text = InvInfo.TotalQuantity.ToString();
            lblRemaining.Text = InvInfo.Remaining.ToString();
            lblStorageDate.Text = InvInfo.StorageDate.ToString();
            dgvBagLocations.DataSource = BagInventoryService.GetBagLocationsByInvId((int)InvInfo.BagInventoryId);
            lblBagSize.Text = InvInfo.BagSizeName;
            lblBagWeight.Text = InvInfo.BagWeightName + " " + InvInfo.BagUnit;
            lblBagColor.Text = InvInfo.BagColor;
            lblColorType.Text = InvInfo.ColorType;
            lblBagDescription.Text = InvInfo.BagDescription;
            lblLogoDescription.Text = InvInfo.LogoDescription;
            lblLogoYear.Text = InvInfo.BagYear;
            try
            {
                pbBagImage.Image = mdlFtp.GetFTPImage(InvInfo.ImagePath);
                if (!Information.IsNothing(pbBagImage.Image))
                {
                    // pbBagImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                }
            }
            catch
            {
                if (!InvInfo.ImagePath.Equals("N/A"))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error loading bag image", "The bag image is not accessible or does not exist on the ftp server.", My.MyProject.Forms.FrmParentScreen);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditInventory.loadForm();
            My.MyProject.Forms.FrmAddEditInventory.isNewInventory = false;
            My.MyProject.Forms.FrmAddEditInventory.LoadEditInfo(selectedInventory);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditInventory, this);
            PopulateInventoryInfo(selectedInventory);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}