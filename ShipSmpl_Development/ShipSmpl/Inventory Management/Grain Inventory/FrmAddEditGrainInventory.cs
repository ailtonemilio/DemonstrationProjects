using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddEditGrainInventory
    {
        public FrmAddEditGrainInventory()
        {
            InitializeComponent();
            _btnChooseLogo.Name = "btnChooseLogo";
            _cboUnitSources.Name = "cboUnitSources";
            _closeFlatButton.Name = "closeFlatButton";
            _btnAddQty.Name = "btnAddQty";
            _btnSave.Name = "btnSave";
            _BunifuButton1.Name = "BunifuButton1";
            _BunifuFlatButton1.Name = "BunifuFlatButton1";
            _tbBagName.Name = "tbBagName";
            _btnOkLogo.Name = "btnOkLogo";
        }

        public VW_UnitSourceMiniUnit UnitObj;
        private List<string> exclusionList = new List<string>();
        private VW_Bag SelectedBag;
        public bool isNewInventory;
        public List<VW_GrainUnitStorage> GrainLocationList = new List<VW_GrainUnitStorage>();
        private bool firstLoad = true;

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelBagsList.Hide();
        }

        private void btnOkLogo_Click(object sender, EventArgs e)
        {
            SelectedBag = (VW_Bag)dgvBags.CurrentRow.DataBoundItem;
            lblBagName.Text = SelectedBag.BagDescription;
            panelBagsList.Hide();
            GoodToGo();
        }

        public void LoadForm()
        {
            firstLoad = true;
            exclusionList.Clear();
            GrainLocationList.Clear();
            VWBagBindingSource.DataSource = BagInventoryService.GetAllBags();
            dtpStorage.Value = DateAndTime.Now;
            SelectedBag = null;
            lblCustomer.Text = "";
            lblCargoType.Text = "";
            lblCommodityGrade.Text = "";
            dgvGrainLocations.Rows.Clear();
            exclusionList.Add("RELEASED");
            {
                var withBlock = cboUnitSources;
                withBlock.DataSource = MiniUnitService.GetAll(exclusionList);
                withBlock.DisplayMember = "MiniUnitNumber";
                withBlock.ValueMember = "MiniUnitId";
            }

            cboUnitSources.SelectedIndex = -1;
            firstLoad = false;
        }

        private void cboUnitSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                populateBagLabels();
                GoodToGo();
            }
        }

        private void populateBagLabels()
        {
            UnitObj = (VW_UnitSourceMiniUnit)cboUnitSources.SelectedItem;
            lblCustomer.Text = UnitObj.CustomerName;
            lblCargoType.Text = UnitObj.CargoType;
            lblCommodityGrade.Text = UnitObj.GradeName + " " + UnitObj.CommodityName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GoodToGo())
            {
                var giService = new GrainInventoryService();
                // '1 - RECEIVE
                // '2 - SEND
                // '3 - USE
                // '4 - ADJUST

                if (isNewInventory)
                {
                    if (!Information.IsNothing(SelectedBag))
                    {
                        giService.InsertGrainInventory(UnitObj.CustomerId, SelectedBag.BagId, Conversions.ToSingle(lblTotalQuantity.Text), UnitObj.MiniUnitId);
                    }
                    else
                    {
                        giService.InsertGrainInventory(UnitObj.CustomerId, 0, Conversions.ToSingle(lblTotalQuantity.Text), UnitObj.MiniUnitId);
                    }

                    foreach (var grainLoc in GrainLocationList)
                    {
                        giService.InsertGrainInvStorageLocation(giService.GetLastGrainInvetoryId(), grainLoc.StorageTypeId, grainLoc.StorageId, (float)grainLoc.QtyInStorage, DateAndTime.Now);
                        giService.InsertGrainInventoryTransaction(giService.GetLastGrainInvetoryId(), 1, (float)grainLoc.QtyInStorage, DateAndTime.Now);
                        giService.InsertGrainInvTransactionGrainStorageLocation(giService.GetLastGrainInventoryTransactionId(), giService.GetLastGrainInvStorageLocationId());
                    }
                }

                My.MyProject.Forms.FrmGrainInvList.dgvInventory.DataSource = GrainInventoryService.GetAllGrainInventory();
                Close();
            }
        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            panelBagsList.Show();
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            double totalValue = 0d;
            My.MyProject.Forms.FrmGrainLocation.loadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmGrainLocation, this);

            // dgvGrainLocations.DataSource = GrainLocationList
            // dgvGrainLocations.Refresh()
            // Dim n = dgvGrainLocations.Rows.Count

            dgvGrainLocations.Rows.Clear();
            foreach (var value in GrainLocationList)
            {
                totalValue += value.QtyInStorage;
                dgvGrainLocations.Rows.Add(value.StorageLocation, value.QtyInStorage);
            }

            lblTotalQuantity.Text = totalValue.ToString();
        }

        private bool GoodToGo()
        {
            bool isGood = true;
            int railListId = 0;
            lblWarning.Text = "";
            int previousMiniUnitId = 0;
            if (UnitObj.CustomerId == 0)
            {
                isGood = false;
                previousMiniUnitId = UnitObj.MiniUnitId;
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Field Required:", "It seems like the unit " + UnitObj.MiniunitNumber + " has no customer yet, and creation on grain inventory can not proceed without this information." + Constants.vbNewLine + "Would you like to edit this unit now?", My.Resources.Resources.warning, this);
                if (result == DialogResult.Yes)
                {
                    if (!Information.IsNothing(UnitObj.RecordKey))
                        railListId = (int)UnitObj.RecordKey;
                    var unit = UnitSourceService.GetVWById(UnitObj.UnitSourceId);
                    var unitList = new List<VW_UnitSource>();
                    unitList.Add(unit);
                    My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                    My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
                    My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, this);
                    firstLoad = true;
                    cboUnitSources.DataSource = MiniUnitService.GetAll(exclusionList);
                    cboUnitSources.SelectedValue = previousMiniUnitId;
                    UnitObj = (VW_UnitSourceMiniUnit)cboUnitSources.SelectedItem;
                    populateBagLabels();
                    firstLoad = false;
                    GoodToGo();
                }
            }
            else if (dgvGrainLocations.Rows.Count == 0)
            {
                isGood = false;
                lblWarning.Text = "Inventory quantity can not be 0";
            }
            else if (UnitObj.CargoType == "BAGGER" & Information.IsNothing(SelectedBag))
            {
                lblWarning.Text = "Must select a bag for cargo type 'BAGGER'";
                isGood = false;
            }

            return isGood;
        }

        private void tbBagName_TextChanged(object sender, EventArgs e)
        {
            VWBagBindingSource.DataSource = BagInventoryService.GetAllBagsByFilter(tbBagName.Text, "", "", "");
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEditAddBags.isNewInventory = true;
            My.MyProject.Forms.FrmEditAddBags.loadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddBags, this);
            VWBagBindingSource.DataSource = BagInventoryService.GetAllBags();
        }
    }
}