using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmSplitMiniUnit
    {
        public frmSplitMiniUnit()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnCancel.Name = "btnCancel";
            _btnAddMiniUnit.Name = "btnAddMiniUnit";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private int TotalBilledWeight;
        private int TotalMUBilledWeight;
        private int TotalBilledPieces;
        private int TotalPCBilledPieces;
        public int UnitSourceId;
        public int RecordKey;
        private DataUnitSource clsUnit = new DataUnitSource();
        private DatabaseHelper db = new DatabaseHelper();
        private SqlCommand objCommand = new SqlCommand();
        private string StrConnection = DatabaseHelperCeres.StrConnWTCCeres;
        private ListBox lstBox = new ListBox();

        private void frmSplitMiniUnit_Load(object sender, EventArgs e)
        {
            // LoadForm()
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMiniUnit_Click(object sender, EventArgs e)
        {
            CalculateSplit();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void CalculateSplit()
        {
            decimal MaxMU;
            {
                var withBlock = My.MyProject.Forms.FrmEditAddRailList;
                if (withBlock.cboCargoType.Text.Equals("BULK"))
                {
                    MaxMU = (decimal)withBlock.miniUnitDT[withBlock.focusedMiniUnit].TotalBilled;
                }
                else
                {
                    MaxMU = (decimal)withBlock.miniUnitDT[withBlock.focusedMiniUnit].TotalBilled;
                }
            }
            // Convert.ToInt32(dgvMiniUnit.CurrentRow.Cells(1).Value)

            // Checks whether the value entered for Split is greater than 0 and less than the MiniUnit selected for split.
            if (MaxMU > nudMaxSplitMU.Value & nudMaxSplitMU.Value > 0m & MaxMU != nudMaxSplitMU.Value)
            {
                // MessageBox.Show("Passou no teste")
                // SplitMiniUnit()
                My.MyProject.Forms.FrmEditAddRailList.splitNumber = nudMaxSplitMU.Value;
                My.MyProject.Forms.FrmEditAddRailList.SplitMU();
                Close();
            }
            else
            {
                MessageBox.Show("To split, it is necessary to enter a value of less than " + MaxMU.ToString() + " and greater than 0.", "Attention to Split a Unit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}