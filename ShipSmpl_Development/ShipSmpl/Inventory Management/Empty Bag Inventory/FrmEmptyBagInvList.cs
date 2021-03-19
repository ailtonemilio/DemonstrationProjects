using BusinessLayer.WTC_Ceres;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmEmptyBagInvList
    {
        public FrmEmptyBagInvList()
        {
            InitializeComponent();
            _dgvInventory.Name = "dgvInventory";
            _btnNewInventory.Name = "btnNewInventory";
            _cboBagColor.Name = "cboBagColor";
            _cboBagSize.Name = "cboBagSize";
            _cboCustomer.Name = "cboCustomer";
            _dgvDetails.Name = "dgvDetails";
        }

        private VW_BagInventory focusedRow;
        private bool firstLoad = true;

        public Image generateApp(double pass)
        {
            double dgpp_d = double.Parse(dgpp.Width.ToString());
            double x = 0d;
            x = pass * dgpp_d / 100d;
            PictureBox1.Width = (int)Math.Round(Math.Round(x, 0));
            return PanelToBitmap(dgpp);
        }

        private Image PanelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private void FrmEmptyBagInvList_Load(object sender, EventArgs e)
        {
            firstLoad = true;
            var bagInventory = BagInventoryService.GetAllInventory(true);
            var listCan = new List<VW_Container>();
            var listBagger = new List<Bagger>();
            var locationList = new List<string>();
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

                var delegationList = new List<string>();
                delegationList.Add("STORAGE");
                delegationList.Add("UNASSIGNED");
                listCan = ContainerService.GetByFilters("", "", "", "", "", "", delegationList, "").Where(c => !string.IsNullOrEmpty(c.ContainerNumber)).ToList();
                listBagger = BagInventoryService.GetAllBaggers().ToList();
                dgvInventory.DataSource = BagInventoryService.GetInventoryByFilters(cboCustomer.Text, tbBagName.Text, cboBagColor.Text, cboBagSize.Text);
                firstLoad = false;
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            focusedRow = (VW_BagInventory)dgvInventory.Rows[dgvInventory.CurrentRow.Index].DataBoundItem;
            dgvDetails.DataSource = BagInventoryService.GetInventoryTransactionById((int)focusedRow.BagInventoryId);
        }

        private void btnNewInventory_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditInventory.loadForm();
            My.MyProject.Forms.FrmAddEditInventory.isNewInventory = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditInventory, this);
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                dgvInventory.DataSource = BagInventoryService.GetInventoryByFilters(cboCustomer.Text, tbBagName.Text, cboBagColor.Text, cboBagSize.Text);
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                VW_BagInventory rowInv = (VW_BagInventory)dgvInventory.Rows[dgvInventory.CurrentRow.Index].DataBoundItem;
                My.MyProject.Forms.FrmInvenotryDetail.PopulateInventoryInfo(rowInv);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmInvenotryDetail, this);
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            focusedRow = (VW_BagInventory)dgvInventory.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == 8)
            {
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAdjustBagsInventoryQty, this);
            }
        }

        private void dgvInventory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int percentRemaining;
            try
            {
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    VW_BagInventory rowInv = (VW_BagInventory)dgvInventory.Rows[row.Index].DataBoundItem;

                    row.Cells["btnEditQtyCol"].Style.BackColor = Color.Sienna;
                    row.Cells["btnEditQtyCol"].Style.ForeColor = Color.White;
                    row.Cells["btnEditQtyCol"].Style.SelectionBackColor = Color.Sienna;
                    row.Cells["btnEditQtyCol"].Style.SelectionForeColor = Color.White;
                    row.Cells["btnEditQtyCol"].Style.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
                    percentRemaining = Convert.ToInt32(rowInv.LeftPercentage.Replace("%", ""));
                    var img = new Bitmap(dgpp.Width, dgpp.Height);
                    img = (Bitmap)generateApp(percentRemaining);
                    row.Cells["percentagePicture"].Value = img;
                    row.Cells["btnEditQtyCol"].Value = "Adjust";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var selectedCell = dgvDetails.Rows[e.RowIndex].Cells["TransactionType"];
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
        }
    }
}