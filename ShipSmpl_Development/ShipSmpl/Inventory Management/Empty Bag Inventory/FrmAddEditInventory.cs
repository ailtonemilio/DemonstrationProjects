using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddEditInventory
    {
        public FrmAddEditInventory()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _btnSave.Name = "btnSave";
            _cboCustomer.Name = "cboCustomer";
            _btnChooseLogo.Name = "btnChooseLogo";
            _BunifuFlatButton1.Name = "BunifuFlatButton1";
            _cboCustomerBag.Name = "cboCustomerBag";
            _tbBagName.Name = "tbBagName";
            _cboBagSize.Name = "cboBagSize";
            _btnAddLogo.Name = "btnAddLogo";
            _btnOkLogo.Name = "btnOkLogo";
            _dgvBags.Name = "dgvBags";
            _BunifuButton1.Name = "BunifuButton1";
        }

        private VW_BagInventory FocusedBagInv;
        public List<VW_InventoryBagLocation> BagLocationList = new List<VW_InventoryBagLocation>();
        public bool isNewInventory = true;
        private bool firstLoad = true;

        // Dim selectedLogoId As Integer = 0
        private VW_Bag SelectedBag;

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
                Close();
            }
        }

        private void btnOkLogo_Click(object sender, EventArgs e)
        {
            if (dgvBags.Rows.Count > 0)
            {
                SelectedBag = (VW_Bag)dgvBags.CurrentRow.DataBoundItem;
                panelBagsList.Hide();
                populateBagInfoLbls();
                lblWarning.Text = "";
            }
            else
            {
                lblWarning.Text = "No bag selected. Please click '+' and add bag";
            }
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnChooseLogo.Enabled = true;
                dgvBags.DataSource = BagInventoryService.GetAllBags();
            }
            catch
            {
                btnChooseLogo.Enabled = false;
            }
        }

        private void cboBagWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                dgvBags.DataSource = BagInventoryService.GetAllBagsByFilter(tbBagName.Text, cboBagColor.Text, cboBagSize.Text, cboCustomerBag.Text);
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelBagsList.Hide();
        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            if (panelBagsList.Visible)
            {
                panelBagsList.Hide();
            }
            else
            {
                panelBagsList.Show();
            }
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEditAddBags.isNewInventory = true;
            My.MyProject.Forms.FrmEditAddBags.loadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBags, this);
        }

        private void dgvBags_DoubleClick(object sender, EventArgs e)
        {
            VW_Bag bag = (VW_Bag)dgvBags.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmEditAddBags.isNewInventory = false;
            My.MyProject.Forms.FrmEditAddBags.loadForm();
            My.MyProject.Forms.FrmEditAddBags.LoadEditInfo(bag);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBags, this);
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditBagInventoryLocation.loadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditBagInventoryLocation, this);
            dgvBagLocations.DataSource = BagLocationList.ToList();
            calculateTotalBags();
        }

        private void dgvBagLocations_DoubleClick(object sender, EventArgs e)
        {
            VW_InventoryBagLocation selectedLocation = (VW_InventoryBagLocation)dgvBagLocations.Rows[dgvBagLocations.CurrentRow.Index].DataBoundItem;
            My.MyProject.Forms.FrmAddEditBagInventoryLocation.loadForm();
            My.MyProject.Forms.FrmAddEditBagInventoryLocation.populateEditInfo(selectedLocation);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditBagInventoryLocation, this);
        }

        private void dgvBagLocations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                var selectedRow = dgvBagLocations.Rows[e.RowIndex];
                selectedRow.Cells["btnDelete"].Value = "×";
                selectedRow.Cells["btnDelete"].Value = "×";
                selectedRow.Cells["btnDelete"].Style.BackColor = Color.Red;
                selectedRow.Cells["btnDelete"].Style.SelectionBackColor = Color.Red;
                selectedRow.Cells["btnDelete"].Style.SelectionForeColor = Color.White;
                selectedRow.Cells["btnDelete"].Style.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold);
            }
            catch (Exception ex)
            {
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void loadForm()
        {
            lblWarning.Text = "";
            SelectedBag = null;
            firstLoad = true;
            BagLocationList.Clear();
            dgvBagLocations.DataSource = null;
            lblTotalBags.Text = 0.ToString();
            using (var db = new WTCCeresEntities())
            {
                {
                    var withBlock = cboCustomer;
                    var categories = new List<int>();
                    categories.Add((int)MdlEnum.CompanyCategory.CUSTOMER);
                    categories.Add((int)MdlEnum.CompanyCategory.CUSTOMER_VENDOR);
                    withBlock.DataSource = CompanyService.GetByCompanyCategoryId(categories, db);
                    withBlock.DisplayMember = "CompanyName";
                    withBlock.ValueMember = "CompanyId";
                    withBlock.SelectedItem = "CompanyId";
                }

                {
                    var withBlock1 = cboBagSize;
                    var bagSizes = BagInventoryService.GetAllBagSize();
                    withBlock1.DataSource = bagSizes;
                    withBlock1.DisplayMember = "BagSizeName";
                    withBlock1.ValueMember = "BagSizeId";
                    withBlock1.SelectedValue = 0;
                }

                {
                    var withBlock2 = cboBagColor;
                    withBlock2.DataSource = BagInventoryService.GetAllColors();
                    withBlock2.DisplayMember = "ColorName";
                    withBlock2.ValueMember = "ColorId";
                    withBlock2.SelectedValue = 0;
                }
            }

            panelBagsList.Hide();
            lblBagName.Text = "--";
            lblBagSize.Text = "--";
            lblBagWeight.Text = "--";
            lblColorType.Text = "--";
            lblBagColor.Text = "--";
            lblLogoDescription.Text = "--";
            firstLoad = false;
        }

        public void LoadEditInfo(VW_BagInventory BagInfo)
        {
            FocusedBagInv = BagInfo;
            cboCustomer.SelectedValue = BagInfo.CustomerId;
            cboBagSize.SelectedValue = BagInfo.BagSizeId;
            cboBagColor.SelectedValue = BagInfo.ColorId;

            // cboLocation.SelectedValue = BagInfo.StorageId

            lblTotalBags.Text = BagInfo.TotalQuantity.ToString();
            dtpStorage.Value = (DateTime)BagInfo.StorageDate;

            // tbLocation.Text = BagInfo.LocationTag

            dgvBags.DataSource = BagInventoryService.GetAllBags();
            SelectedBag = BagInventoryService.GetBagVWById(BagInfo.BagId);
            var bagsLocations = BagInventoryService.GetBagLocationsByInvId((int)BagInfo.BagInventoryId);
            dgvBagLocations.DataSource = bagsLocations;
            BagLocationList = bagsLocations;
            populateBagInfoLbls();
        }

        private void populateBagInfoLbls()
        {
            lblBagName.Text = SelectedBag.BagDescription;
            lblBagSize.Text = SelectedBag.BagSizeName;
            lblBagWeight.Text = SelectedBag.BagWeightName.ToString() + " " + SelectedBag.BagUnit;
            lblColorType.Text = SelectedBag.ColorType;
            lblBagColor.Text = SelectedBag.ColorName;
            lblLogoDescription.Text = SelectedBag.LogoDescription;
        }

        private void SaveUpdateInfo(bool isNewInventory)
        {
            var bs = new BagInventoryService();
            int inventoryId;
            int canId;
            int baggerId;
            int lastBagLocationIserted = 0;
            if (isNewInventory)
            {
                // '1 - RECEIVE
                // '2 - SEND
                // '3 - USE
                // '4 - ADJUST

                bs.InsertBagInventory(Conversions.ToInteger(cboCustomer.SelectedValue), SelectedBag.BagId, Conversions.ToInteger(lblTotalBags.Text), dtpStorage.Value, Conversions.ToBoolean(1));
                inventoryId = bs.GetLastBagInventoryId();
                foreach (var bag in BagLocationList)
                {
                    bs.InsertBagLocation(inventoryId, bag.LocationStorageName, bag.StorageTypeId, (int)bag.StorageId, bag.BagQuantity);
                    lastBagLocationIserted = bs.GetLastBagLocationId();
                    bs.InsertBagInventoryTransaction(1, bag.BagQuantity, DateAndTime.Now, lastBagLocationIserted);
                }
            }
            else
            {
                bs.UpdateBagInventory((int)FocusedBagInv.BagInventoryId, Conversions.ToInteger(cboCustomer.SelectedValue), SelectedBag.BagId, Conversions.ToInteger(lblTotalBags.Text), dtpStorage.Value, Conversions.ToBoolean(1));
                foreach (var bag in BagLocationList)
                {
                    if (!Information.IsNothing(bag.BagInventoryId))
                    {
                        bs.UpdateBagLocation(bag.BagLocationId, (int)FocusedBagInv.BagInventoryId, bag.LocationStorageName, bag.StorageTypeId, (int)bag.StorageId, bag.BagQuantity);
                    }
                    else
                    {
                        bs.InsertBagLocation((int)FocusedBagInv.BagInventoryId, bag.LocationStorageName, bag.StorageTypeId, (int)bag.StorageId, bag.BagQuantity);
                        lastBagLocationIserted = bs.GetLastBagLocationId();
                        bs.InsertBagInventoryTransaction(1, bag.BagQuantity, DateAndTime.Now, lastBagLocationIserted);
                    }
                }
            }
        }

        private bool isGoodToGo()
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboCustomer.SelectedValue, 0, false)))
            {
                lblWarning.Text = "Customer can not be empty";
                return false;
            }

            if (lblTotalBags.Text.Equals("0"))
            {
                lblWarning.Text = "Quantity can not be 0";
                return false;
            }

            if (Information.IsNothing(SelectedBag))
            {
                lblWarning.Text = "No bags selected. Please, select a bag";
                return false;
            }

            return true;
        }

        private void calculateTotalBags()
        {
            int totalbags = 0;
            foreach (var bagLocation in BagLocationList)
                totalbags += bagLocation.BagQuantity;
            lblTotalBags.Text = totalbags.ToString();
        }

        private void dgvBagLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                VW_InventoryBagLocation bagLocationToRemove = (VW_InventoryBagLocation)dgvBagLocations.Rows[e.RowIndex].DataBoundItem;
                dgvBagLocations.DataSource = null;
                if (!Information.IsNothing(bagLocationToRemove.BagInventoryId))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Action not allowed", @"Can not delete a bag location that was already saved in an inventory because it would erase bag transaction logs.
If there's no bags at this location, modify bag invenotry quantity, selecting the option 'AJUST' and setting bag quantity to 0.", this);
                }
                else
                {
                    BagLocationList.Remove(bagLocationToRemove);
                }

                dgvBagLocations.DataSource = BagLocationList;
                calculateTotalBags();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}