using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    public partial class frmVesselCSVUpdate
    {
        public frmVesselCSVUpdate()
        {
            InitializeComponent();
            _btnClose.Name = "btnClose";
            _dgvVesselCSV.Name = "dgvVesselCSV";
            _btnClear.Name = "btnClear";
            _btnSave.Name = "btnSave";
            _lblClosePanel.Name = "lblClosePanel";
        }

        private int countSyncError = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ClearDataGridView()
        {
            dgvVesselCSV.Rows.Clear();
            pnlMessage.Visible = false;
            pnlMessageDefault.Visible = false;
            dgvVesselCSV.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dgvVesselCSV.Columns[3].HeaderCell.Style.BackColor = Color.White;
            dgvVesselCSV.Columns[4].HeaderCell.Style.BackColor = Color.White;
            dgvVesselCSV.Columns[6].HeaderCell.Style.BackColor = Color.White;
        }

        private void frmVesselCSVUpdate_Load(object sender, EventArgs e)
        {
        }

        private void dgvVesselCSV_KeyDown(object sender, KeyEventArgs e)
        {
            // If the keys pressed are CTRL + V
            if (e.Control && e.KeyCode == Keys.V)
            {
                int TotItem = 0;
                int CountItem = 0;
                try
                {
                    foreach (string line in Clipboard.GetText().Split(Conversions.ToChar(Constants.vbNewLine)))
                        TotItem += 1;
                    TotItem = TotItem - 1;

                    // Starts the Cycle on the copied lines
                    foreach (string line in Clipboard.GetText().Split(Conversions.ToChar(Constants.vbNewLine)))
                    {
                        // Separates the columns for the current row
                        var item = line.Trim().Split(Conversions.ToChar(Constants.vbTab));

                        // Eliminates the last line that is normally completely empty
                        if (TotItem > CountItem)
                        {
                            // If the number of columns is different it shows an error message
                            if (item.Length != dgvVesselCSV.ColumnCount)
                            {
                                string str = "The number of columns copied is different" + " of the number of columns in the DataGridView";
                                throw new Exception(str);
                            }

                            // Adds the row to the DataGridView
                            dgvVesselCSV.Rows.Add(item);
                        }

                        CountItem += 1;
                    }
                }
                catch (Exception ex)
                {
                    // Mensagem de erro caso exista
                    MessageBox.Show(ex.Message, My.MyProject.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FieldsVerification();
            if (countSyncError > 0)
            {
                pnlMessageDefault.Visible = true;
                return;
            }

            SyncSave();
            My.MyProject.Forms.frmVesselList.SearchByColumn();
        }

        private void FieldsVerification()
        {
            int countRow = 0;
            int countActive = 0;
            int countYear = 0;
            int countCapacity = 0;
            int countVesselName = 0;
            lbMessage.Items.Clear();
            if (dgvVesselCSV.Rows.Count <= 1)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("To update only one Vessel, use the Edit option.", "", this);
                return;
            }

            foreach (DataGridViewRow row in dgvVesselCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselCSV.Rows.Count)
                    {
                        string VesselName = Conversions.ToString(row.Cells[0].Value);
                        string Owner = Conversions.ToString(row.Cells[1].Value);
                        string Manager = Conversions.ToString(row.Cells[2].Value);
                        string Capacity = Conversions.ToString(row.Cells[3].Value);
                        string Year = Conversions.ToString(row.Cells[4].Value);
                        string Flag = Conversions.ToString(row.Cells[5].Value);
                        string Active = Conversions.ToString(row.Cells[6].Value);
                        if (string.IsNullOrEmpty(VesselName) | string.IsNullOrWhiteSpace(VesselName) | string.IsNullOrEmpty(VesselName))
                        {
                            row.Cells[0].Style.BackColor = Color.Red;
                            countVesselName += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - The field Vessel Name is empty.");
                        }

                        if (string.IsNullOrEmpty(Capacity) | string.IsNullOrWhiteSpace(Capacity) | string.IsNullOrEmpty(Capacity))
                        {
                            Capacity = "0";
                        }

                        if (VerifyNumber(Capacity) == false)
                        {
                            row.Cells[3].Style.BackColor = Color.Red;
                            countCapacity += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - The field Capacity is number, please insert number in this field.");
                        }
                        else
                        {
                            row.Cells[3].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(Year) | string.IsNullOrWhiteSpace(Year))
                        {
                            Year = "0";
                        }

                        if (VerifyInteger(Year) == false)
                        {
                            row.Cells[4].Style.BackColor = Color.Red;
                            countYear += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - The field Year is number, please insert number in this field.");
                        }
                        else
                        {
                            row.Cells[4].Style.BackColor = Color.White;
                        }

                        if (string.IsNullOrEmpty(Active))
                        {
                            row.Cells[6].Style.BackColor = Color.Red;
                            countActive += 1;
                            lbMessage.Items.Add("Row " + countRow.ToString() + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                        }
                        else
                        {
                            switch (Active)
                            {
                                case "TRUE":
                                    {
                                        row.Cells[6].Style.BackColor = global::System.Drawing.Color.White;
                                        break;
                                    }

                                case "FALSE":
                                    {
                                        row.Cells[6].Style.BackColor = global::System.Drawing.Color.White;
                                        break;
                                    }

                                case "":
                                    {
                                        row.Cells[6].Style.BackColor = global::System.Drawing.Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add("Row " + countRow.ToString() + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                                        break;
                                    }

                                case null:

                                    {
                                        row.Cells[6].Style.BackColor = global::System.Drawing.Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add("Row " + countRow.ToString() + " - Field is empty, please insert TRUE or FALSE in Field Active.");
                                        break;
                                    }

                                default:
                                    {
                                        row.Cells[6].Style.BackColor = global::System.Drawing.Color.Red;
                                        countActive += 1;
                                        lbMessage.Items.Add("Row " + countRow.ToString() + " - Insert TRUE or FALSE in Field Active.");
                                        break;
                                    }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                }
            }

            if (countCapacity > 0)
            {
                dgvVesselCSV.Columns[3].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselCSV.Columns[3].HeaderCell.Style.BackColor = Color.White;
            }

            if (countYear > 0)
            {
                dgvVesselCSV.Columns[4].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselCSV.Columns[4].HeaderCell.Style.BackColor = Color.White;
            }

            if (countActive > 0)
            {
                dgvVesselCSV.Columns[6].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselCSV.Columns[6].HeaderCell.Style.BackColor = Color.White;
            }

            if (countVesselName > 0)
            {
                dgvVesselCSV.Columns[0].HeaderCell.Style.BackColor = Color.Red;
            }
            else
            {
                dgvVesselCSV.Columns[0].HeaderCell.Style.BackColor = Color.White;
            }

            countSyncError = countCapacity + countYear + countActive + countVesselName;
        }

        private void SyncSave()
        {
            int countRow = 0;
            int IdVessel = 0;
            bool isActive = false;
            foreach (DataGridViewRow row in dgvVesselCSV.Rows)
            {
                countRow += 1;
                try
                {
                    if (countRow < dgvVesselCSV.Rows.Count)
                    {
                        string VesselName = Conversions.ToString(row.Cells[0].Value);
                        string Owner = Conversions.ToString(row.Cells[1].Value);
                        string Manager = Conversions.ToString(row.Cells[2].Value);
                        string Capacity = Conversions.ToString(row.Cells[3].Value);
                        string Year = Conversions.ToString(row.Cells[4].Value);
                        string Flag = Conversions.ToString(row.Cells[5].Value);
                        string Active = Conversions.ToString(row.Cells[6].Value);
                        IdVessel = VesselService.GetVesselIdByVesselName(VesselName);
                        if (string.IsNullOrEmpty(Owner))
                        {
                            Owner = "";
                        }

                        if (string.IsNullOrEmpty(Manager))
                        {
                            Manager = "";
                        }

                        if (string.IsNullOrEmpty(Flag))
                        {
                            Flag = "";
                        }

                        if (Active.ToUpper().Equals("TRUE"))
                        {
                            isActive = true;
                        }
                        else
                        {
                            isActive = false;
                        }

                        if (string.IsNullOrEmpty(Capacity) | string.IsNullOrWhiteSpace(Capacity))
                        {
                            Capacity = "0";
                        }

                        if (string.IsNullOrEmpty(Year) | string.IsNullOrWhiteSpace(Year))
                        {
                            Year = "0";
                        }

                        if (IdVessel == 0)
                        {
                            if (VesselService.Insert(VesselName, Owner, Manager, Convert.ToDecimal(Capacity), Convert.ToInt32(Year), Flag, isActive))
                            {
                                dgvVesselCSV.Rows.Remove((DataGridViewRow)row);
                            }
                            else
                            {
                                pnlMessage.Visible = true;
                            }
                        }
                        else if (VesselService.Update(IdVessel, VesselName, Owner, Manager, Convert.ToDecimal(Capacity), Convert.ToInt32(Year), Flag, isActive))
                        {
                            dgvVesselCSV.Rows.Remove((DataGridViewRow)row);
                        }
                        else
                        {
                            pnlMessage.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    pnlMessage.Visible = true;
                }
            }

            if (pnlMessage.Visible == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("", "Vessel updated successfully.", this);
                ClearDataGridView();
                Close();
            }
        }

        public bool VerifyNumber(string Field)
        {
            bool isNumber = false;
            try
            {
                Convert.ToDouble(Field);
                isNumber = true;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }

            return isNumber;
        }

        public bool VerifyInteger(string Field)
        {
            bool isNumber = false;
            try
            {
                Convert.ToInt32(Field);
                isNumber = true;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }

            return isNumber;
        }

        private void lblClosePanel_Click(object sender, EventArgs e)
        {
            pnlMessageDefault.Visible = false;
        }
    }
}