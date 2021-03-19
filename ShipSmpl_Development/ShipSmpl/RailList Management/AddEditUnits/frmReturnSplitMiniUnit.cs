using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmReturnSplitMiniUnit
    {
        public frmReturnSplitMiniUnit()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnCancel.Name = "btnCancel";
            _btnReturn.Name = "btnReturn";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        private int TotalBilledWeight;
        private int TotalMUBilledWeight;
        private int TotalBilledPieces;
        private int TotalPCBilledPieces;
        public int RecordKey;
        public int UnitSourceId;
        public int MiniUnitId;
        private DatabaseHelper db = new DatabaseHelper();
        private SqlCommand objCommand = new SqlCommand();
        private string StrConnection = DatabaseHelperCeres.StrConnWTCCeres;

        private void frmReturnSplitMiniUnit_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            string query;
            if (gboMain.Text == "Bulk")
            {
                query = "MiniUnitOrder as MiniUnit, Sum(TotalBilled) As [TotalBilled]";
            }
            else
            {
                query = "MiniUnitOrder as MiniUnit, Sum(PCBilled) As [Total Pieces]";
            }

            dgvMiniUnit.DataSource = dbCeres.getTableInfo("MiniUnit", query, "where UnitSourceId = " + UnitSourceId.ToString() + " and MiniUnitId <> " + MiniUnitId.ToString() + " Group By MiniUnitOrder");
            dgvMiniUnit.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int MiniUnitOrder = Convert.ToInt32(dgvMiniUnit.CurrentRow.Cells[0].Value);
            int MaxMU = Convert.ToInt32(dgvMiniUnit.CurrentRow.Cells[1].Value);
            int UpdateMaxMU = MaxMU + Convert.ToInt16(nudMaxSplitMU.Value);
            int count = 0;

            // 1 - Insert the updated value
            if (gboMain.Text == "Bulk")
            {
                dbCeres.getDataByQuery("update miniunit set TotalBilled = " + UpdateMaxMU.ToString() + " where UnitSourceId = " + UnitSourceId.ToString() + " and MiniUnitOrder = " + MiniUnitOrder.ToString());
            }
            else
            {
                dbCeres.getDataByQuery("update miniunit set PCBilled = " + UpdateMaxMU.ToString() + " where UnitSourceId = " + UnitSourceId.ToString() + " and MiniUnitOrder = " + MiniUnitOrder.ToString());
            }

            // 2 - Deletes the MiniUnit row
            dbCeres.deleteMiniUnit("delete from MiniUnit where MiniUnitId = " + MiniUnitId.ToString());

            // 3 - Updates the order of Mini Units
            foreach (DataRow mini in dbCeres.getTableInfo("MiniUnit", "*", "where UnitSourceId = " + UnitSourceId.ToString() + " order by MiniUnitId").Rows)
            {
                count += 1;
                dbCeres.getDataByQuery("update miniunit set MiniUnitOrder = " + count.ToString() + " where MiniUnitId = " + mini["MiniUnitId"].ToString());
            }

            MessageBox.Show("Return made successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            My.MyProject.Forms.FrmEditAddRailList.PopulateMU();
            Close();
        }
    }
}