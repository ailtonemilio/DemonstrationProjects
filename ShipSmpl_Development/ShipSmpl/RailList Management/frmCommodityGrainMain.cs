using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmCommodityGrainMain
    {
        public frmCommodityGrainMain()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _dgvCommodity.Name = "dgvCommodity";
            _dgvGrade.Name = "dgvGrade";
            _txtCommodity.Name = "txtCommodity";
            _txtCommodityCode.Name = "txtCommodityCode";
            _txtGrade.Name = "txtGrade";
            _txtGradeCode.Name = "txtGradeCode";
            _btnEditCommodity.Name = "btnEditCommodity";
            _btnEditGrade.Name = "btnEditGrade";
            _btnAddCommodity.Name = "btnAddCommodity";
            _btnAddGrade.Name = "btnAddGrade";
        }

        private WaitLoadingRun waitForm = new WaitLoadingRun();
        private bool CName = true;
        private bool CCode = true;
        private bool GCode = true;
        private bool GName = true;
        private List<Commodity> listCommodity;
        private List<Commodity> ListCommodityByColumn;
        private List<Grade> listGrade;
        private List<Grade> listGradeByColumn;

        private void frmCommodityGrainMain_Load(object sender, EventArgs e)
        {
            waitForm.Show();
            LoadCommodity();
            LoadGrade();
            waitForm.Close();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void dgvCommodity_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (dgvCommodity.Columns[e.ColumnIndex].Name.ToString() ?? "")
            {
                case "CommodityCode":
                    {
                        if (CCode)
                        {
                            var L = from b in ListCommodityByColumn
                                    select b;
                            CommodityBindingSource.DataSource = L.ToList();
                            CCode = false;
                        }
                        else
                        {
                            var L = from b in ListCommodityByColumn
                                    select b;
                            CommodityBindingSource.DataSource = L.ToList();
                            CCode = true;
                        }

                        break;
                    }

                case "CommodityName":
                    {
                        if (CName)
                        {
                            var L = from b in ListCommodityByColumn
                                    select b;
                            CommodityBindingSource.DataSource = L.ToList();
                            CName = false;
                        }
                        else
                        {
                            var L = from b in ListCommodityByColumn
                                    select b;
                            CommodityBindingSource.DataSource = L.ToList();
                            CName = true;
                        }

                        break;
                    }
            }
        }

        private void dgvGrade_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (dgvGrade.Columns[e.ColumnIndex].Name.ToString() ?? "")
            {
                case "GradeCode":
                    {
                        if (GCode)
                        {
                            var L = from b in listGrade
                                    select b;
                            GradeBindingSource.DataSource = L.ToList();
                            GCode = false;
                        }
                        else
                        {
                            var L = from b in listGrade
                                    select b;
                            GradeBindingSource.DataSource = L.ToList();
                            GCode = true;
                        }

                        break;
                    }

                case "GradeName":
                    {
                        if (GName)
                        {
                            var L = from b in listGrade
                                    select b;
                            GradeBindingSource.DataSource = L.ToList();
                            GName = false;
                        }
                        else
                        {
                            var L = from b in listGrade
                                    select b;
                            GradeBindingSource.DataSource = L.ToList();
                            GName = true;
                        }

                        break;
                    }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void LoadCommodity()
        {
            listCommodity = CommodityService.GetAll();
            var Lc = from b in listCommodity
                     where b.CommodityId > 0
                     select b;
            CommodityBindingSource.DataSource = Lc.ToList();
            ListCommodityByColumn = Lc.ToList();
        }

        public void LoadGrade()
        {
            listGrade = GradeService.GetAll();
            var Lg = from b in listGrade
                     where b.GradeId != 0
                     select b;
            GradeBindingSource.DataSource = Lg.ToList();
            listGradeByColumn = Lg.ToList();
        }

        private void SearchCommodityByColumn()
        {
            var L = from b in listCommodity
                    where b.CommodityCode.StartsWith(txtCommodityCode.Text) & b.CommodityName.StartsWith(txtCommodity.Text)
                    select b;
            CommodityBindingSource.DataSource = L.ToList();
            ListCommodityByColumn = L.ToList();
        }

        private void SearchGradeByColumn()
        {
            var L = from b in listGrade
                    where b.GradeCode.StartsWith(txtGradeCode.Text) & b.GradeName.StartsWith(txtGrade.Text)
                    select b;
            GradeBindingSource.DataSource = L.ToList();
            listGradeByColumn = L.ToList();
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia *//* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCommodityCode_TextChange(object sender, EventArgs e)
        {
            SearchCommodityByColumn();
        }

        private void txtCommodity_TextChange(object sender, EventArgs e)
        {
            SearchCommodityByColumn();
        }

        private void txtGradeCode_TextChange(object sender, EventArgs e)
        {
            SearchGradeByColumn();
        }

        private void txtGrade_TextChange(object sender, EventArgs e)
        {
            SearchGradeByColumn();
        }

        private void btnEditCommodity_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmEditCommodity.CommodityId = Conversions.ToInteger(dgvCommodity.CurrentRow.Cells[0].Value);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmEditCommodity, this);
        }

        private void btnEditGrade_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmEditGrade.GradeId = Conversions.ToInteger(dgvGrade.CurrentRow.Cells[0].Value);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmEditGrade, this);
        }

        private void btnAddCommodity_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmEditCommodity.CommodityId = 0;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmEditCommodity, this);
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmEditGrade.GradeId = 0;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmEditGrade, this);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

    }
}