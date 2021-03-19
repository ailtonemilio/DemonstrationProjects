using BusinessLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmGrainInvList
    {
        public FrmGrainInvList()
        {
            InitializeComponent();
            _dgvInventory.Name = "dgvInventory";
            _btnNewInventory.Name = "btnNewInventory";
            _cboUnitNumber.Name = "cboUnitNumber";
            _cboGrade.Name = "cboGrade";
            _cboCustomer.Name = "cboCustomer";
            _dgvDetails.Name = "dgvDetails";
        }

        private bool firstLoad;

        private void dgvDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var selectedCell = dgvDetails.Rows[e.RowIndex].Cells[1];
            selectedCell.Style.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold);
            selectedCell.Style.SelectionForeColor = Color.White;
            selectedCell.Style.ForeColor = Color.White;
            if (selectedCell.Value.Equals("RECEIVE"))
            {
                selectedCell.Style.BackColor = Color.Green;
                selectedCell.Style.SelectionBackColor = Color.Green;
            }
            else if (selectedCell.Value.Equals("USE"))
            {
                selectedCell.Style.BackColor = Color.DarkGoldenrod;
                selectedCell.Style.SelectionBackColor = Color.DarkGoldenrod;
            }
            else if (selectedCell.Value.Equals("ADJUST"))
            {
                selectedCell.Style.BackColor = Color.IndianRed;
                selectedCell.Style.SelectionBackColor = Color.IndianRed;
            }
            else
            {
                selectedCell.Style.BackColor = Color.RosyBrown;
                selectedCell.Style.SelectionBackColor = Color.RosyBrown;
            }

            VWGrainInventoryBindingSource.DataSource = GrainInventoryService.GetGrainInventoryByFilets("", "", "", "", "");
        }

        private void FrmGrainInvList_Load(object sender, EventArgs e)
        {
            firstLoad = true;
            var giService = new GrainInventoryService();
            dgvInventory.DataSource = GrainInventoryService.GetAllGrainInventory();
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
                }

                var exclusionList = new List<string>();
                exclusionList.Add("RELEASED");
                {
                    var withBlock1 = cboUnitNumber;
                    var newUs = new VW_UnitSourceMiniUnit();
                    newUs.MiniunitNumber = "";
                    newUs.MiniUnitId = 0;
                    var uslist = MiniUnitService.GetAll(exclusionList, db);
                    uslist.Insert(0, newUs);
                    withBlock1.DataSource = uslist;
                    withBlock1.DisplayMember = "MiniUnitNumber";
                    withBlock1.ValueMember = "MiniUnitId";
                    withBlock1.SelectedIndex = -1;
                }

                {
                    var withBlock2 = cboCommodity;
                    withBlock2.DataSource = CommodityService.GetAll(db);
                    withBlock2.DisplayMember = "CommodityCode";
                    withBlock2.ValueMember = "CommodityId";
                }

                {
                    var withBlock3 = cboGrade;
                    withBlock3.DataSource = GradeService.GetAll(db);
                    withBlock3.DisplayMember = "GradeCode";
                    withBlock3.ValueMember = "GradeId";
                }
            }

            firstLoad = false;
        }

        private void btnNewInventory_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditGrainInventory.LoadForm();
            My.MyProject.Forms.FrmAddEditGrainInventory.isNewInventory = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditGrainInventory, this);
            dgvInventory.DataSource = GrainInventoryService.GetAllGrainInventory();
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            VW_GrainInventory GrainInvObj = (VW_GrainInventory)dgvInventory.CurrentRow.DataBoundItem;
            dgvDetails.DataSource = GrainInventoryService.GetGrainInventoryTransactionByGrainInvId(GrainInvObj.GrainInventoryId);
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                VWGrainInventoryBindingSource.DataSource = GrainInventoryService.GetGrainInventoryByFilets(cboCustomer.Text, cboCommodity.Text, cboGrade.Text, cboUnitNumber.Text, "");
            }
        }
    }
}