using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace ShipSmpl
{
    public partial class FrmModifyTotalNumbCont
    {
        public FrmModifyTotalNumbCont()
        {
            InitializeComponent();
            _nucTotal.Name = "nucTotal";
            _dgvMiniBks.Name = "dgvMiniBks";
            _btnCancel.Name = "btnCancel";
            _btnSaveMb.Name = "btnSaveMb";
            _closeLabel.Name = "closeLabel";
        }

        private int containerToAsn;
        private int totalContInBkg;

        // Dim tempMBTable As New List(Of Minibooking)
        private bool shouldRemoveRow;
        public List<Minibooking> tempDeletedMBDT = new List<Minibooking>();

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private int getTotalTempMBNumb()
        {
            var total = default(int);
            foreach (var mb in tempDeletedMBDT)
                total = (int)(total + mb.NumberOfContainer);
            return total;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeLabel_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                withBlock.totalContainersNumericUpDown.Value = withBlock.getTotalContInMB();
            }

            Close();
        }

        private void nucTotal_ValueChanged(object sender, EventArgs e)
        {
            int index = dgvMiniBks.CurrentRow.Index;
            dgvMiniBks.Rows[index].Cells[1].Value = nucTotal.Value;
            tempDeletedMBDT[index].NumberOfContainer = (int?)nucTotal.Value;
            containerToAsn = totalContInBkg - getTotalTempMBNumb();
            if (containerToAsn == 0)
            {
                btnSaveMb.Enabled = true;
            }
            else
            {
                btnSaveMb.Enabled = false;
            }

            lblTotaltoBeAsgn.Text = containerToAsn.ToString();
        }

        public void loadForm(bool isDeleteMB)
        {
            shouldRemoveRow = isDeleteMB;
            btnSaveMb.Enabled = false;
            dgvMiniBks.Rows.Clear();
            {
                var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                if (isDeleteMB == false)
                {
                    tempDeletedMBDT = new List<Minibooking>(withBlock.originalMBTable);
                }

                totalContInBkg = (int)Math.Round(withBlock.totalContainersNumericUpDown.Value);
                containerToAsn = totalContInBkg - getTotalTempMBNumb();
                lblContInMb.Text = withBlock.getTotalContInMB().ToString();
                lbltotalNumber.Text = totalContInBkg.ToString();
                lblTotaltoBeAsgn.Text = containerToAsn.ToString();

                // Dim cmdtyList As List(Of VW_MinibookingCommodity) = FrmEditAddBooking.MbCmdtyList
                int NumbOfCanMb = 0;
                foreach (var mb in tempDeletedMBDT)
                    // NumbOfCanMb = tempDeletedMBDT.Where(Function(m) m.MiniBookingId = mb.MiniBookingId).ToList(0).NumberOfContainer
                    dgvMiniBks.Rows.Add(withBlock.bkgNumbTextBox1.Text + MdlBookingManagement.digitToLetter(mb.MiniBookingOrder), mb.NumberOfContainer);
            }
        }

        private void btnSaveMb_Click(object sender, EventArgs e)
        {
            DataRow mbRow;
            {
                var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                if (shouldRemoveRow)
                {
                    withBlock.deleteMB();
                    withBlock.btnCancel.Enabled = false;
                }

                for (int i = 0, loopTo = tempDeletedMBDT.Count - 1; i <= loopTo; i++)
                    withBlock.originalMBTable[i].NumberOfContainer = tempDeletedMBDT[i].NumberOfContainer;
                withBlock.populateMB();
            }

            Close();
        }

        private void dgvMiniBks_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvMiniBks.CurrentRow.Index;
            nucTotal.Value = Conversions.ToDecimal(dgvMiniBks.Rows[index].Cells[1].Value);
            lblminiBkgNumber.Text = Conversions.ToString(dgvMiniBks.Rows[index].Cells[0].Value);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}