using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmSplitbooking
    {
        public FrmSplitbooking()
        {
            InitializeComponent();
            _dgvCansToTransfer.Name = "dgvCansToTransfer";
            _transferButton.Name = "transferButton";
            _btnCancel.Name = "btnCancel";
            _dgvCansAsnMb.Name = "dgvCansAsnMb";
            _btnAsnToMb.Name = "btnAsnToMb";
            _btnRmvFromMb.Name = "btnRmvFromMb";
        }

        public bool reasignCans = false;
        private List<VW_ContainersByBooking> cansList = new List<VW_ContainersByBooking>();
        private List<VW_ContainersByBooking> tempSelectedCans = new List<VW_ContainersByBooking>();

        public List<VW_ContainersByBooking> SelectedCans
        {
            get
            {
                return cansList;
            }

            set
            {
                cansList = value;
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
            Size = new Size(485, 494);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            var canAsnInfo = new MdlBookingManagement.SplitedCanInfo();
            var tempCansList = new List<MdlBookingManagement.SplitedCanInfo>();
            if (reasignCans == true)
            {
                {
                    var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                    withBlock.asnCansMb.Clear();
                    MdlBookingManagement.SplitedCansList.Clear();
                    foreach (DataGridViewRow row in dgvCansAsnMb.Rows)
                    {
                        withBlock.asnCansMb.Add(Conversions.ToInteger(row.Cells[0].Value), Conversions.ToInteger(row.Cells[4].Value));
                        canAsnInfo.ContainerId = Conversions.ToInteger(row.Cells[0].Value);
                        canAsnInfo.ContainerNumber = Conversions.ToString(row.Cells[2].Value);
                        canAsnInfo.MinibookingNumber = Conversions.ToString(row.Cells[3].Value);
                        canAsnInfo.MinibookingTempId = Conversions.ToString(row.Cells[4].Value);
                        tempCansList.Add(canAsnInfo);
                    }
                }

                MdlBookingManagement.SplitedCansList = tempCansList;
            }
            else
            {
                DataGridViewRow row;
                cansList.Clear();
                for (int i = 0, loopTo = dgvCansToTransfer.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvCansToTransfer.Rows[i].Cells[1].Value, true, false)))
                    {
                        cansList.Add((VW_ContainersByBooking)dgvCansToTransfer.Rows[i].DataBoundItem);
                        row = dgvCansToTransfer.Rows[i];
                        canAsnInfo.ContainerId = Conversions.ToInteger(row.Cells[0].Value);
                        canAsnInfo.ContainerNumber = Conversions.ToString(row.Cells[2].Value);
                        canAsnInfo.MinibookingNumber = "";
                        canAsnInfo.MinibookingTempId = 0.ToString();
                        tempCansList.Add(canAsnInfo);
                    }

                    MdlBookingManagement.SplitedCansList = tempCansList;
                }

                DialogResult = DialogResult.OK;
                SelectedCans = cansList;
            }

            DialogResult = DialogResult.Yes;
            Close();
            Size = new Size(485, 494);
        }

        private void dgvCansToTransfer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(dgvCansToTransfer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    dgvCansToTransfer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    dgvCansToTransfer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }
        }

        private void dgvCansAsnMb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                bool value = Conversions.ToBoolean(dgvCansAsnMb.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value == false)
                {
                    dgvCansAsnMb.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    dgvCansAsnMb.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }
        }

        public void populateMbGrid(List<Minibooking> mbDt)
        {
            string mbNumb = "";
            int count = 0;
            tempSelectedCans.Clear();
            dgvCansAsnMb.Rows.Clear();
            {
                var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                var canList = MdlBookingManagement.SplitedCansList;
                if (mbDt.Count == 1)
                {
                    mbNumb = Strings.Trim(withBlock.bkgNumbTextBox1.Text);
                }
                else if (withBlock.asnCansMb.Count == 0)
                {
                    mbNumb = Strings.Trim(withBlock.bkgNumbTextBox1.Text) + "(A)";
                }

                if (canList.Count == 0)
                {
                    foreach (var can in SelectedCans.ToList())
                        dgvCansAsnMb.Rows.Add(can.Unique_ID, false, Strings.Trim(can.Container_Number), mbNumb, 0);
                }
                else
                {
                    foreach (var canInfo in canList)
                        dgvCansAsnMb.Rows.Add(canInfo.ContainerId, false, canInfo.ContainerNumber, canInfo.MinibookingNumber, canInfo.MinibookingTempId);
                }
            }

            updateGgvCansToTransfer();
        }

        public DialogResult ShowDialog(Form assgnForm)
        {
            if (reasignCans == true)
            {
                cboMinibooking.Items.Clear();
                {
                    var withBlock = My.MyProject.Forms.FrmEditAddBooking;
                    foreach (var mb in withBlock.originalMBTable)
                    {
                        if (withBlock.originalMBTable.Count == 1)
                        {
                            cboMinibooking.Items.Add(Strings.Trim(withBlock.bkgNumbTextBox1.Text));
                        }
                        else
                        {
                            cboMinibooking.Items.Add(mb.MiniBookingOrder.ToString());
                        }
                    }
                }

                cboMinibooking.SelectedIndex = 0;
            }

            MdlLoadingSetting.showDialogForm(this, assgnForm);
            return DialogResult;
        }

        private void btnRmvFromMb_Click(object sender, EventArgs e)
        {
            for (int i = dgvCansAsnMb.RowCount - 1; i >= 0; i -= 1)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvCansAsnMb.Rows[i].Cells[1].Value, true, false)))
                {
                    foreach (var can in SelectedCans)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(can.Unique_ID, dgvCansAsnMb.Rows[i].Cells[0].Value, false)))
                        {
                            tempSelectedCans.Add(can);
                        }
                    }

                    dgvCansAsnMb.Rows.RemoveAt(i);
                }
            }

            updateGgvCansToTransfer();
        }

        private void updateGgvCansToTransfer()
        {
            dgvCansToTransfer.DataSource = tempSelectedCans.ToList();
            dgvCansToTransfer.Columns[0].Visible = false;
        }

        private void btnAsnToMb_Click(object sender, EventArgs e)
        {
            int mbtempId = 0;
            string mbNumb;
            string letter;
            mbNumb = Conversions.ToString(cboMinibooking.SelectedItem);
            for (int i = dgvCansToTransfer.RowCount - 1; i >= 0; i -= 1)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvCansToTransfer.Rows[i].Cells[1].Value, true, false)))
                {
                    tempSelectedCans.RemoveAt(i);
                    letter = mbNumb.Split('(')[1].Replace(")", "");
                    mbtempId = MdlBookingManagement.letterToDigit(letter) - 1;
                    dgvCansAsnMb.Rows.Add(dgvCansToTransfer.Rows[i].Cells[0].Value, false, dgvCansToTransfer.Rows[i].Cells[2].Value, mbNumb, mbtempId);
                }
            }

            updateGgvCansToTransfer();
        }
    }
}