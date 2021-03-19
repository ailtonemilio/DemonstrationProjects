using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmMiniBookingWarning
    {
        public FrmMiniBookingWarning()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _proceedButton.Name = "proceedButton";
            _cancelButton.Name = "cancelButton";
            _miniBkDataGridView.Name = "miniBkDataGridView";
        }

        private int numbSelectedMB = 0;

        private void FrmMiniBookingWarning_Load(object sender, EventArgs e)
        {
            numbSelectedMB = 0;
            proceedButton.Enabled = false;
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miniBkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmBookingList;
                if (e.ColumnIndex == 0)
                {
                    bool value = Conversions.ToBoolean(miniBkDataGridView.Rows[e.ColumnIndex].Cells[0].Value);
                    if (value == false)
                    {
                        miniBkDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                        numbSelectedMB += 1;
                    }
                    else
                    {
                        miniBkDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                        numbSelectedMB -= 1;
                    }
                }

                if (numbSelectedMB > 0)
                {
                    proceedButton.Enabled = true;
                }
                else
                {
                    proceedButton.Enabled = false;
                }
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            var mbRowList = new List<VW_BookingMinibooking>();
            for (int i = 0, loopTo = miniBkDataGridView.Rows.Count - 1; i <= loopTo; i++)
            {
                bool value = Conversions.ToBoolean(miniBkDataGridView.Rows[i].Cells[0].Value);
                if (value == true)
                {
                    var mbRow = new VW_BookingMinibooking();
                    mbRow = (VW_BookingMinibooking)miniBkDataGridView.Rows[i].DataBoundItem;
                    My.MyProject.Forms.FrmAssignToUnits.OriginalMBSelectedList.Add(mbRow);
                    // FrmAssignToUnits.VWBookingJoinMBBindingSource.DataSource.add(mbRow)
                }
            }

            Close();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAssignToUnits, My.MyProject.Forms.FrmParentScreen);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}