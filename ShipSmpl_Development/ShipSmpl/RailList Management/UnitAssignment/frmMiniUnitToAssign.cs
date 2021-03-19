using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmMiniUnitToAssign
    {
        public frmMiniUnitToAssign()
        {
            InitializeComponent();
            _btnCancel.Name = "btnCancel";
            _btnAssignBooking.Name = "btnAssignBooking";
            _closeFlatButton.Name = "closeFlatButton";
        }

        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        public DataTable mbMU = new DataTable();
        private int numbSelectedMU = 0;
        public Dictionary<int, string> selectedMUID = new Dictionary<int, string>();

        private void frmMiniUnitToAssign_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            numbSelectedMU = 0;
        }

        public string[] MiniUnitIds()
        {
            var array = new string[2];
            var ids = new List<string>();
            int a = 0;
            for (int i = 0, loopTo = dgvMiniUnit.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(dgvMiniUnit[1, i].Value) == true)
                {
                    array[a] = dgvMiniUnit[0, i].Value.ToString();
                    a += 1;
                }
            }

            return array;
        }

        private void btnAssignBooking_Click(object sender, EventArgs e)
        {
            var muToBeAssign = new List<VW_UnitSourceMiniUnit>();
            muToBeAssign = (List<VW_UnitSourceMiniUnit>)My.MyProject.Forms.frmAssignUnitToBooking.VWUnitSourceMiniUnitBindingSource.DataSource;
            for (int i = 0, loopTo = dgvMiniUnit.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvMiniUnit.Rows[i].Cells[1].Value, true, false)))
                {
                    var muRow = new VW_UnitSourceMiniUnit();
                    muRow = (VW_UnitSourceMiniUnit)dgvMiniUnit.Rows[i].DataBoundItem;
                    muToBeAssign.Add(muRow);
                }
            }

            My.MyProject.Forms.frmAssignUnitToBooking.VWUnitSourceMiniUnitBindingSource.DataSource = muToBeAssign;
            Close();
            My.MyProject.Forms.FrmRailList.LoadForm(false);
        }

        private void dgvMiniUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                bool value = Conversions.ToBoolean(dgvMiniUnit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    dgvMiniUnit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    numbSelectedMU += 1;
                }
                else
                {
                    dgvMiniUnit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    numbSelectedMU -= 1;
                }
            }

            if (numbSelectedMU > 0)
            {
                btnAssignBooking.Enabled = true;
            }
            else
            {
                btnAssignBooking.Enabled = false;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmRailList.LoadForm(true);
            Close();
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmRailList.LoadForm(true);
            Close();
        }
    }
}