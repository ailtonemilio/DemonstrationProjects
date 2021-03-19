using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmDetailedEntry
    {
        public FrmDetailedEntry()
        {
            InitializeComponent();
            _entryDetailsDataGrid.Name = "entryDetailsDataGrid";
            _closeLabel.Name = "closeLabel";
        }

        private void FrmDetailedEntry_Load(object sender, EventArgs e)
        {
            int selectedEntry = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.CurrentCell.RowIndex;
            int punchID = Conversions.ToInteger(My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.Rows[selectedEntry].Cells[6].Value);
            MdlTimeManagement.getEntryDetails();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entryDetailsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEntry = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.CurrentCell.RowIndex;
            int punchID = Conversions.ToInteger(My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.Rows[selectedEntry].Cells[6].Value);
            MdlTimeManagement.populateEntryDetails(punchID);
        }
    }
}