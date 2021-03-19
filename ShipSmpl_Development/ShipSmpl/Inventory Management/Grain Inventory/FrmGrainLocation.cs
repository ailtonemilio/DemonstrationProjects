using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace ShipSmpl
{
    public partial class FrmGrainLocation
    {
        public FrmGrainLocation()
        {
            InitializeComponent();
            _cboStorageType.Name = "cboStorageType";
            _closeFlatButton.Name = "closeFlatButton";
            _btnOk.Name = "btnOk";
        }

        public bool isNewLocation;

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(GoodToGo()))
            {
                var bl = new VW_GrainUnitStorage();
                if (isNewLocation)
                {
                    bl.QtyInStorage = default;
                }

                bl.StorageTypeId = Conversions.ToInteger(cboStorageType.SelectedValue);
                bl.StorageTypeName = cboStorageType.Text;
                bl.StorageId = Conversions.ToInteger(cboStorage.SelectedValue);
                bl.QtyInStorage = (double)nudBagQty.Value;
                bl.StorageLocation = cboStorage.Text;
                if (!My.MyProject.Forms.FrmAddEditGrainInventory.GrainLocationList.Contains(bl))
                {
                    My.MyProject.Forms.FrmAddEditGrainInventory.GrainLocationList.Add(bl);
                }
                // FrmAddEditGrainInventory.VWGrainUnitStorageBindingSource.DataSource = FrmAddEditGrainInventory.GrainLocationList
                Close();
            }
        }

        private void cboLocationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStorageType.Text.Equals("CONTAINER"))
            {
                {
                    var withBlock = cboStorage;
                    var delegationList = new List<string>();
                    delegationList.Add("STORAGE");
                    delegationList.Add("UNASSIGNED");
                    withBlock.DataSource = ContainerService.GetByFilters("", "", "", "", "", "", delegationList, "");
                    withBlock.DisplayMember = "ContainerNumber";
                    withBlock.ValueMember = "ContainerId";
                }

                cboStorage.SelectedValue = 0;
            }
            else if (cboStorageType.Text.Equals("BAGGER"))
            {
                {
                    var withBlock2 = cboStorage;
                    withBlock2.DataSource = BaggerService.GetAll();
                    withBlock2.DisplayMember = "BaggerName";
                    withBlock2.ValueMember = "BaggerId";
                }
            }
            else
            {
                {
                    var withBlock1 = cboStorage;
                    withBlock1.DataSource = PalletService.GetAll();
                    withBlock1.DisplayMember = "PalletName";
                    withBlock1.ValueMember = "PalletId";
                }
            }
        }

        public void loadForm()
        {
            {
                var withBlock = cboStorageType;
                withBlock.DataSource = StorageTypeService.GetAll();
                withBlock.DisplayMember = "StorageTypeName";
                withBlock.ValueMember = "StorageTypeId";
                withBlock.SelectedIndex = 0;
            }

            {
                var withBlock1 = cboStorage;
                var delegationList = new List<string>();
                delegationList.Add("STORAGE");
                delegationList.Add("UNASSIGNED");
                withBlock1.DataSource = ContainerService.GetByFilters("", "", "", "", "", "", delegationList, "");
                withBlock1.DisplayMember = "ContainerNumber";
                withBlock1.ValueMember = "ContainerId";
                withBlock1.SelectedIndex = 0;
            }

            nudBagQty.Value = 0m;
            if (My.MyProject.Forms.FrmAddEditGrainInventory.UnitObj.CargoType.Equals("BAG"))
            {
                nudBagQty.DecimalPlaces = 0;
            }
            else
            {
                nudBagQty.DecimalPlaces = 3;
            }

            lblWarning.Text = "";
        }

        public void populateEditInfo(VW_InventoryBagLocation storage)
        {
            cboStorageType.SelectedValue = storage.StorageTypeId;
            cboStorage.SelectedValue = storage.StorageId;
            nudBagQty.Value = storage.BagQuantity;
        }

        private object GoodToGo()
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboStorage.SelectedValue, 0, false)))
            {
                lblWarning.Text = "Storage cannot be empty";
                return false;
            }
            else if (nudBagQty.Value == 0m)
            {
                lblWarning.Text = "Quantity cannot be 0";
                return false;
            }

            return true;
        }
    }
}