using BusinessLayer.Billing;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmEditDrayage
    {
        public FrmEditDrayage()
        {
            InitializeComponent();
            _saveButton.Name = "saveButton";
            _closeFlatButton.Name = "closeFlatButton";
            _dgvFromDock.Name = "dgvFromDock";
            _dgvToDock.Name = "dgvToDock";
            _cboTuckingCompany.Name = "cboTuckingCompany";
            _cboRateType.Name = "cboRateType";
            _dtpEndDate.Name = "dtpEndDate";
            _dgvAssignedRates.Name = "dgvAssignedRates";
            _BunifuButton1.Name = "BunifuButton1";
            _cboStartDate.Name = "cboStartDate";
            _deleteButton.Name = "deleteButton";
        }

        private DrayageRateService dr = new DrayageRateService();

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEditDrayage_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WTCCeresEntities())
                {
                    truckCompaniesBS.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Drayage_Provider, db);
                    toCompaniesBS.DataSource = CompanyService.GetAllByName("WTC GROUP", "Container Terminal");
                    fromCompaniesBS.DataSource = CompanyService.GetAllExceptName("WTC GROUP", "Container Terminal");
                }

                cboRateType.SelectedIndex = 0;
                dgvFromDock.Columns[0].Visible = false;
                dgvToDock.Columns[0].Visible = false;
                cboStartDate.Text = "";
                getStartDates();
            }
            catch (Exception ex)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Oh-oh... ", ex.Message, this);
            }

            checkSaveButton();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.CustomFormat = "  dd-MMM-yyyy";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.waitForm.Show();
            var fromID = default(int);
            var toId = default(int);
            DateTime startDate;
            var toDateTime = dtpEndDate.MinDate;
            int drayageRateId;
            int schemaID = DrayageSchemeService.GetByFromToId(Conversions.ToInteger(cboTuckingCompany.SelectedValue), fromID, toId);
            if (IsUpdate())
            {
                for (int j = 0, loopTo = dgvAssignedRates.Rows.Count - 1; j <= loopTo; j++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvAssignedRates.Rows[j].Cells[0].Value, true, false)))
                    {
                        drayageRateId = Conversions.ToInteger(dgvAssignedRates.Rows[j].Cells[1].Value);
                        startDate = Convert.ToDateTime(cboStartDate.SelectedItem);
                        schemaID = Conversions.ToInteger(dgvAssignedRates.Rows[j].Cells[2].Value);
                        if (dtpEndDate.CustomFormat.Equals(" "))
                        {
                            bool isupdated = dr.Update(drayageRateId, schemaID, startDate.Date, toDateTime, NumericUpDown1.Value, Conversions.ToString(cboRateType.SelectedItem));
                        }
                        else
                        {
                            bool isupdated = dr.Update(drayageRateId, schemaID, startDate.Date, dtpEndDate.Value.Date, NumericUpDown1.Value, Conversions.ToString(cboRateType.SelectedItem));
                        }
                    }
                }
            }
            else if (isNewRate())
            {
                for (int i = 0, loopTo1 = dgvFromDock.Rows.Count - 1; i <= loopTo1; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvFromDock.Rows[i].Cells[1].Value, true, false)))
                    {
                        fromID = Conversions.ToInteger(dgvFromDock.Rows[i].Cells[0].Value);
                        for (int s = 0, loopTo2 = dgvToDock.Rows.Count - 1; s <= loopTo2; s++)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvToDock.Rows[s].Cells[1].Value, true, false)))
                            {
                                toId = Conversions.ToInteger(dgvToDock.Rows[s].Cells[0].Value);
                                schemaID = DrayageSchemeService.GetByFromToId(Conversions.ToInteger(cboTuckingCompany.SelectedValue), fromID, toId);
                                if (schemaID == 0)
                                {
                                    DrayageSchemeService.Insert(Conversions.ToInteger(cboTuckingCompany.SelectedValue), fromID, toId);
                                    schemaID = DrayageSchemeService.GetByFromToId(Conversions.ToInteger(cboTuckingCompany.SelectedValue), fromID, toId);
                                }

                                startDate = Convert.ToDateTime(cboStartDate.SelectedItem);
                                if (dtpEndDate.CustomFormat.Equals(" "))
                                {
                                    DrayageRateService.Insert(schemaID, startDate.Date, toDateTime, NumericUpDown1.Value, Conversions.ToString(cboRateType.SelectedItem));
                                }
                                else
                                {
                                    DrayageRateService.Insert(schemaID, startDate.Date, dtpEndDate.Value.Date, NumericUpDown1.Value, Conversions.ToString(cboRateType.SelectedItem));
                                }
                            }
                        }
                    }
                }
            }

            getAssignedRates();
            checkSaveButton();
            MdlLoadingSetting.waitForm.Close();
        }

        private void checkSaveButton()
        {
            if (IsUpdate())
            {
                saveButton.Enabled = true;
                deleteButton.Enabled = true;
                dgvFromDock.Columns[1].Visible = false;
                dgvToDock.Columns[1].Visible = false;
                dgvFromDock.Columns[0].Visible = false;
                dgvFromDock.Columns[0].Visible = false;
                dgvAssignedRates.Columns[0].Visible = true;
                dgvAssignedRates.Columns[1].Visible = false;
            }
            else if (isNewRate())
            {
                saveButton.Enabled = true;
                deleteButton.Enabled = false;
                dgvFromDock.Columns[1].Visible = true;
                dgvToDock.Columns[1].Visible = true;
                dgvFromDock.Columns[0].Visible = false;
                dgvToDock.Columns[0].Visible = false;
                dgvAssignedRates.Columns[1].Visible = false;
                dgvAssignedRates.Columns[0].Visible = false;
                var hasFromDock = default(bool);
                var hasToDock = default(bool);
                for (int i = 0, loopTo = dgvFromDock.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvFromDock.Rows[i].Cells[1].Value, true, false)))
                    {
                        hasFromDock = true;
                        break;
                    }
                }

                for (int i = 0, loopTo1 = dgvToDock.Rows.Count - 1; i <= loopTo1; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvToDock.Rows[i].Cells[1].Value, true, false)))
                    {
                        hasToDock = true;
                        break;
                    }
                }

                if (hasFromDock & hasToDock)
                {
                    saveButton.Enabled = true;
                }
                else
                {
                    saveButton.Enabled = false;
                }
            }
            else
            {
                dgvFromDock.Columns[1].Visible = true;
                dgvToDock.Columns[1].Visible = true;
                dgvFromDock.Columns[0].Visible = false;
                dgvToDock.Columns[0].Visible = false;
                dgvAssignedRates.Columns[0].Visible = true;
                dgvAssignedRates.Columns[1].Visible = false;
                saveButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private bool isNewRate()
        {
            bool isNew = false;
            for (int i = 0, loopTo = dgvFromDock.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvFromDock.Rows[i].Cells[1].Value, true, false)))
                {
                    isNew = true;
                    break;
                }
            }

            for (int i = 0, loopTo1 = dgvToDock.Rows.Count - 1; i <= loopTo1; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvToDock.Rows[i].Cells[1].Value, true, false)))
                {
                    isNew = true;
                    break;
                }
            }

            return isNew;
        }

        private bool IsUpdate()
        {
            bool isanUpdate = false;
            for (int i = 0, loopTo = dgvAssignedRates.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvAssignedRates.Rows[i].Cells[0].Value, true, false)))
                {
                    return true;
                }
            }

            return isanUpdate;
        }

        private void dgvFromDock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvFromDock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, true, false)))
                {
                    dgvFromDock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    for (int i = dgvToDock.RowCount - 1; i >= 0; i -= 1)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvToDock.Rows[i].Cells[0].Value, dgvFromDock.Rows[e.RowIndex].Cells[0].Value, false)))
                        {
                            dgvToDock.Rows[i].Visible = true;
                        }
                    }
                }
                else
                {
                    // dgvToDock.Rows.Add(dgvFromDock.Rows(e.RowIndex))
                    dgvFromDock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    for (int i = dgvToDock.RowCount - 1; i >= 0; i -= 1)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvToDock.Rows[i].Cells[0].Value, dgvFromDock.Rows[e.RowIndex].Cells[0].Value, false)))
                        {
                            dgvToDock.Rows[i].Visible = false;
                        }
                    }
                }
            }

            checkSaveButton();
        }

        private void dgvToDock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboStartDate.Text = "";
            getStartDates();
            if (e.ColumnIndex == 1)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvToDock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, true, false)))
                {
                    dgvToDock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    // dgvToDock.Rows.Add(dgvFromDock.Rows(e.RowIndex))
                    dgvToDock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
            }

            checkSaveButton();
        }

        private void cboRateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRateType.SelectedItem.Equals("Multi Load") | cboRateType.SelectedItem.Equals("Single Load"))
            {
                fromCompaniesBS.DataSource = CompanyService.GetAllByName("WTC GROUP", "Terminal");
                toCompaniesBS.DataSource = CompanyService.GetAllExceptName("WTC GROUP", "Terminal");
            }
            else
            {
                toCompaniesBS.DataSource = CompanyService.GetAllByName("WTC GROUP", "Terminal");
                fromCompaniesBS.DataSource = CompanyService.GetAllExceptName("WTC GROUP", "Terminal");
            }

            getAssignedRates();
            dgvFromDock.Columns[0].Visible = false;
            dgvToDock.Columns[0].Visible = false;
            checkSaveButton();
        }

        private void getAssignedRates()
        {
            try
            {
                if (!Information.IsNothing(cboRateType.SelectedItem))
                {
                    var fromDate = Convert.ToDateTime(cboStartDate.SelectedItem);
                    DrayageSchemeRateBindingSource.DataSource = DrayageSchemeService.GetAssignedRates(Conversions.ToInteger(cboTuckingCompany.SelectedValue), Conversions.ToString(cboRateType.SelectedItem), Conversions.ToString(fromDate.Date));
                    dgvAssignedRates.Columns[1].Visible = false;
                    dgvAssignedRates.Columns[2].Visible = false;
                    dgvAssignedRates.Columns[3].Visible = false;
                    dgvAssignedRates.Columns[4].Visible = false;
                    dgvAssignedRates.Columns[5].Visible = false;
                    dgvAssignedRates.Columns[10].Visible = false;

                    // dgvAssignedRates.RowsDefaultCellStyle.ForeColor = Color.Black

                }
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }

        private void cboTuckingCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStartDate.Text = "";
            getStartDates();
            getAssignedRates();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddNewStartDate, this);
        }

        private void getStartDates()
        {
            DateTime startDate;
            cboStartDate.Items.Clear();
            foreach (var item in DrayageSchemeService.GetDrayageScheme(Conversions.ToInteger(cboTuckingCompany.SelectedValue), Conversions.ToString(cboRateType.SelectedItem)))
            {
                //TODO
                //startDate = Conversions.ToDate(item.fromDate);
                //if (!cboStartDate.Items.Contains(startDate.ToString("dd-MMM-yyyy")))
                //{
                //    cboStartDate.Items.Add(startDate.ToString("dd-MMM-yyyy"));
                //}
            }

            if (cboStartDate.Items.Count > 0)
            {
                cboStartDate.SelectedIndex = 0;
            }
        }

        private void dgvAssignedRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                decimal firstValue = 0m;
                decimal afterValue = 0m;
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvAssignedRates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, true, false)))
                {
                    dgvAssignedRates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    dgvAssignedRates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    NumericUpDown1.Value = 0m;
                    NumericUpDown1.BackColor = Color.White;
                    for (int i = 0, loopTo = dgvAssignedRates.Rows.Count - 1; i <= loopTo; i++)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvAssignedRates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, true, false)))
                        {
                            if (i == 0)
                            {
                                firstValue = Conversions.ToDecimal(dgvAssignedRates.Rows[e.RowIndex].Cells[11].Value);
                                afterValue = firstValue;
                            }
                            else
                            {
                                afterValue = Conversions.ToDecimal(dgvAssignedRates.Rows[e.RowIndex].Cells[11].Value);
                            }

                            if (firstValue == afterValue)
                            {
                                NumericUpDown1.Value = Conversions.ToDecimal(dgvAssignedRates.Rows[e.RowIndex].Cells[11].Value);
                            }
                            else
                            {
                                NumericUpDown1.BackColor = Color.FromArgb(255, 192, 128);
                                NumericUpDown1.Value = 0m;
                                break;
                            }
                        }
                    }
                }
            }

            checkSaveButton();
        }

        private void cboStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAssignedRates();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0, loopTo = dgvAssignedRates.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvAssignedRates.Rows[i].Cells[0].Value, true, false)))
                {
                    dr.Delete(Conversions.ToInteger(dgvAssignedRates.Rows[i].Cells[1].Value));
                }
            }

            getAssignedRates();
        }
    }
}