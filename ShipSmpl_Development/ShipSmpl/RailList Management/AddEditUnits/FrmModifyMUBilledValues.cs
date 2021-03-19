using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;

namespace ShipSmpl
{
    public partial class FrmModifyMUBilledValues
    {
        public FrmModifyMUBilledValues()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnUpdateMu.Name = "btnUpdateMu";
            _btnCancel.Name = "btnCancel";
            _dgvMiniUnits.Name = "dgvMiniUnits";
            _nucTotal.Name = "nucTotal";
        }

        private decimal numbToReassign;
        private decimal numbTotalBefore = 0m;
        public List<MiniUnit> tempDeletedMUDT = new List<MiniUnit>();
        private List<MiniUnit> tempDt = new List<MiniUnit>();
        private bool shouldRemoveRow;
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();

        private void FrmModifyMUBilledValues_Load(object sender, EventArgs e)
        {
            // loadForm()
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            try
            {
                // FrmEditAddRailList.nudTotalBilledWeight.Value = numbTotalBefore

                Close();
            }
            catch (Exception ex)
            {
            }
        }

        public void loadForm(bool isDeleteMU)
        {
            numbTotalBefore = 0m;
            shouldRemoveRow = isDeleteMU;
            btnUpdateMu.Enabled = false;
            dgvMiniUnits.Rows.Clear();
            string cmdtyCode;
            string gradeCode;
            string custName;
            {
                var withBlock = My.MyProject.Forms.FrmEditAddRailList;
                if (isDeleteMU == false)
                {
                    tempDt = withBlock.miniUnitDT;
                }
                else
                {
                    tempDt = tempDeletedMUDT;
                }
                // Populate dgv
                string totalbStr;
                foreach (var mu in tempDt)
                {
                    if (withBlock.cboCargoType.Text.Equals("BULK"))
                    {
                        mu.TotalBilled = Convert.ToDecimal(mu.TotalBilled);
                    }
                    // totalbStr = FormatNumber(mu.TotalBilled.ToString, 3)
                    else
                    {
                        mu.TotalBilled = Convert.ToInt32(mu.TotalBilled);
                        // totalbStr = FormatNumber(mu.TotalBilled.ToString, 0)
                    }

                    cmdtyCode = CommodityService.GetById(mu.CommodityId).CommodityCode;
                    gradeCode = GradeService.GetById(mu.GradeId).GradeCode;
                    custName = CompanyService.GetVWById(mu.CustomerId).CompanyName;
                    dgvMiniUnits.Rows.Add(withBlock.txtUnitNumber.Text + "(" + MdlBookingManagement.digitToLetter((object)mu.MiniUnitOrder).ToUpper() + ")", custName, cmdtyCode + " " + gradeCode, (object)mu.TotalBilled);
                    numbTotalBefore = (decimal)(numbTotalBefore + mu.TotalBilled);
                }

                // Set texts.
                if (withBlock.cboCargoType.Text.Equals("BULK"))
                {
                    labelTotalSomething.Text = "Total Weight:";
                    lbltotalNumber.Text = withBlock.nudTotalBilledWeight.Value.ToString("0.###");
                    numbToReassign = withBlock.nudTotalBilledWeight.Value - numbTotalBefore;
                    lblTotaltoBeAsgn.Text = numbToReassign.ToString("0.###");
                    nucTotal.DecimalPlaces = 3;
                }
                else
                {
                    labelTotalSomething.Text = "Total Pieces:";
                    lbltotalNumber.Text = withBlock.nudTotalBilledWeight.Value.ToString("#");
                    numbToReassign = withBlock.nudTotalBilledWeight.Value - numbTotalBefore;
                    lblTotaltoBeAsgn.Text = numbToReassign.ToString("#");
                    nucTotal.DecimalPlaces = 0;
                }
            }
        }

        private void dgvMiniUnits_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = dgvMiniUnits.CurrentRow.Index;
            lblminiUnitNumber.Text = Conversions.ToString(dgvMiniUnits.Rows[rowIndex].Cells[0].Value);
            nucTotal.Value = Conversions.ToDecimal(dgvMiniUnits.Rows[rowIndex].Cells[3].Value);
        }

        private void nucTotal_ValueChanged(object sender, EventArgs e)
        {
            int rowIndex = dgvMiniUnits.CurrentRow.Index;
            var totalInMUDgv = default(decimal);
            dgvMiniUnits.Rows[rowIndex].Cells[3].Value = nucTotal.Value;

            // Check if reassignedNumber = 0
            for (int i = 0, loopTo = dgvMiniUnits.Rows.Count - 1; i <= loopTo; i++)
                totalInMUDgv = Conversions.ToDecimal(totalInMUDgv + Convert.ToInt32(dgvMiniUnits.Rows[i].Cells[3].Value));
            numbToReassign = My.MyProject.Forms.FrmEditAddRailList.nudTotalBilledWeight.Value - totalInMUDgv;
            numbToReassign = decimal.Round(numbToReassign, 3, MidpointRounding.AwayFromZero);
            if (numbToReassign == 0m)
            {
                btnUpdateMu.Enabled = true;
            }
            else
            {
                btnUpdateMu.Enabled = false;
            }

            lblTotaltoBeAsgn.Text = numbToReassign.ToString();
        }

        private void btnUpdateMu_Click(object sender, EventArgs e)
        {
            MiniUnit muRow;
            var muService = new MiniUnitService();
            {
                var withBlock = My.MyProject.Forms.FrmEditAddRailList;
                if (shouldRemoveRow)
                {
                    if (withBlock.miniUnitDT[withBlock.focusedMiniUnit].MiniUnitId != 0)
                    {
                        muService.Delete(withBlock.miniUnitDT[withBlock.focusedMiniUnit].MiniUnitId);
                    }

                    withBlock.miniUnitDT.RemoveAt(withBlock.focusedMiniUnit);
                    withBlock.focusedMiniUnit -= 1;
                }

                for (int i = 0, loopTo = withBlock.miniUnitDT.Count - 1; i <= loopTo; i++)
                {
                    muRow = withBlock.miniUnitDT[i];
                    muRow.TotalBilled = (decimal?)dgvMiniUnits.Rows[i].Cells[3].Value;
                }

                withBlock.checkArrowButtons();
                withBlock.PopulateMU();
            }

            Close();
        }
    }
}