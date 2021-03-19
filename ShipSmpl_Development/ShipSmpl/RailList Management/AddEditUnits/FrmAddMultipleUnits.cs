using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddMultipleUnits
    {
        public FrmAddMultipleUnits()
        {
            InitializeComponent();
            _dgv.Name = "dgv";
            _cboCustomer.Name = "cboCustomer";
            _nudTotalBilledWeight.Name = "nudTotalBilledWeight";
            _updateButton.Name = "updateButton";
            _cboCargoType.Name = "cboCargoType";
            _cboType.Name = "cboType";
            _tbCreateUnits.Name = "tbCreateUnits";
            _tbUnits.Name = "tbUnits";
            _closeLabel.Name = "closeLabel";
            _cboCommodity.Name = "cboCommodity";
            _cboGrade.Name = "cboGrade";
        }

        public struct Unit
        {
            public int UnitId;
            public string UnitNumber;
            public string OriginalUnitNumber;
            public int CustomerId;
            public string CustomerName;
            public int CargoTypeId;
            public string CargoType;
            public string Commodity;
            public int UnitStatusId;
            public string UnitStatus;
            public string UnitType;
            public decimal TotalBilled;
        }

        private List<UnitSource> AllUnits;
        private List<Unit> UnitList = new List<Unit>();
        private string unitsFound;
        private bool firstLoad;

        private void populateComboBoxes()
        {
            firstLoad = true;
            tbUnits.Text = "";
            UnitList.Clear();
            dgv.Rows.Clear();
            lblPasteUnits.Show();
            lblFormat.Show();
            using (var db = new WTCCeresEntities())
            {
                {
                    var withBlock = cboCustomer;
                    var categories = new List<int>();
                    categories.Add((int)MdlEnum.CompanyCategory.CUSTOMER);
                    categories.Add((int)MdlEnum.CompanyCategory.CUSTOMER_VENDOR);
                    withBlock.DataSource = CompanyService.GetByCompanyCategoryId(categories, db);
                    withBlock.DisplayMember = "CompanyName";
                    withBlock.ValueMember = "CompanyId";
                }

                {
                    var withBlock1 = cboCargoType;
                    withBlock1.DataSource = CargoTypeService.GetAll(db);
                    withBlock1.DisplayMember = "CargoTypeName";
                    withBlock1.ValueMember = "CargoTypeId";
                }

                // With cboStatus
                // .DataSource = UnitStatusService.GetAll()
                // .DisplayMember = "StatusName"
                // .ValueMember = "UnitStatusId"
                // End With
                {
                    var withBlock2 = cboCommodity;
                    withBlock2.DataSource = CommodityService.GetAll(db);
                    withBlock2.DisplayMember = "CommodityName";
                    withBlock2.ValueMember = "CommodityId";
                }

                {
                    var withBlock3 = cboGrade;
                    withBlock3.DataSource = GradeService.GetAll(db);
                    withBlock3.DisplayMember = "GradeName";
                    withBlock3.ValueMember = "GradeId";
                }

                {
                    var withBlock4 = cboType;
                    withBlock4.Items.Clear();
                    withBlock4.Items.Add("");
                    withBlock4.Items.Add("BOX");
                    withBlock4.Items.Add("HOPPER");
                    withBlock4.Items.Add("IMDL");
                    withBlock4.SelectedItem = "";
                }

                {
                    var withBlock5 = cboWeightUnit;
                    withBlock5.Items.Clear();
                    withBlock5.Items.Add("KG");
                    withBlock5.Items.Add("LB");
                    withBlock5.Items.Add("MT");
                    withBlock5.SelectedItem = "MT";
                }
            }

            AllUnits = UnitSourceService.GetByActiveStatus(Conversions.ToBoolean(1));
            firstLoad = false;
        }

        private void tbUnits_TextChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                string[] listUnit;
                listUnit = tbUnits.Text.Split(Conversions.ToChar(Constants.vbLf));
                if (listUnit.Count() > 0)
                {
                    lblPasteUnits.Hide();
                    lblFormat.Hide();
                }
                else
                {
                    lblPasteUnits.Show();
                    lblFormat.Show();
                }

                PopulateUnits(listUnit);
                MandatoryFieldsOk();
            }
        }

        private void PopulateUnits(object listUnit)
        {
            UnitList.Clear();
            dgv.Rows.Clear();
            unitsFound = "";
            int unitId = 0;
            var unitFound = default(UnitSource);
            string[] UnitsAndWeightList;
            string UnitNumb = 0.ToString();
            decimal Weight = 0m;
            foreach (var u in (IEnumerable)listUnit)
            {
                if (!string.IsNullOrEmpty(Strings.Trim(Conversions.ToString(u))))
                {
                    UnitsAndWeightList = u.ToString().Split(Conversions.ToChar(Constants.vbTab));
                    if (UnitsAndWeightList.Length == 2)
                    {
                        UnitNumb = Conversions.ToString(UnitsAndWeightList[0]);
                        Weight = Conversions.ToDecimal(UnitsAndWeightList[1]);
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(UnitsAndWeightList.Length, 1, false)))
                    {
                        UnitNumb = Conversions.ToString(UnitsAndWeightList[0]);
                        Weight = 0m;
                    }

                    var un = new Unit();
                    // If unit exists, get the id
                    if (MdlUnits.UnitAlreadyExist(MdlUnits.ReformatCarNumber(UnitNumb), AllUnits, ref unitFound) == true)
                    {
                        unitsFound += unitFound.UnitNumber + Constants.vbNewLine;
                        unitId = unitFound.UnitSourceId;
                        un.UnitStatusId = unitFound.UnitStatusId;
                        switch (unitFound.UnitStatusId)
                        {
                            case (int)MdlEnum.UnitStatus.IN_TRANSIT:
                                {
                                    un.UnitStatus = "IN TRANSIT";
                                    break;
                                }

                            case (int)MdlEnum.UnitStatus.AVAILABLE:
                                {
                                    un.UnitStatus = "AVAILABLE";
                                    break;
                                }

                            case (int)MdlEnum.UnitStatus.CALLED:
                                {
                                    un.UnitStatus = "CALLED";
                                    break;
                                }

                            case (int)MdlEnum.UnitStatus.NOT_TRACING:
                                {
                                    un.UnitStatus = "NOT TRACING";
                                    break;
                                }

                            case (int)MdlEnum.UnitStatus.MISSED:
                                {
                                    un.UnitStatus = "MISSED";
                                    break;
                                }

                            case (int)MdlEnum.UnitStatus.ON_HAND:
                                {
                                    un.UnitStatus = "ON HAND";
                                    break;
                                }

                            case (int)MdlEnum.UnitStatus.RELEASED:
                                {
                                    un.UnitStatus = "RELEASED";
                                    break;
                                }
                        }
                    }
                    else
                    {
                        unitId = 0;
                        un.UnitStatusId = (int)MdlEnum.UnitStatus.IN_TRANSIT;
                        un.UnitStatus = "IN TRANSIT";
                    }

                    un.UnitId = unitId;
                    un.UnitNumber = MdlUnits.ReformatCarNumber(UnitNumb);
                    un.OriginalUnitNumber = UnitNumb;
                    un.CustomerId = Conversions.ToInteger(cboCustomer.SelectedValue);
                    un.CustomerName = cboCustomer.Text;
                    un.Commodity = cboGrade.Text + " " + cboCommodity.Text;
                    un.CargoTypeId = Conversions.ToInteger(cboCargoType.SelectedValue);
                    un.CargoType = cboCargoType.Text;
                    un.UnitType = Conversions.ToString(cboType.SelectedItem);
                    un.TotalBilled = Weight;
                    UnitList.Add(un);
                    dgv.Rows.Add(un.OriginalUnitNumber, un.CustomerName, un.Commodity, un.CargoType, un.UnitStatus, un.UnitType, Weight, un.UnitId, un.UnitNumber);
                }
            }

            if (UnitList.Count > 0)
            {
                updateButton.Enabled = true;
            }
            else
            {
                updateButton.Enabled = true;
            }
            // If unitsFound.Length > 0 Then
            // MessageBoxCeresOK.ShowDialog("Units not added:", "The following units already exist and will not be added again: " +
            // unitsFound, Me)
            // End If
            populateDgvFields();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                populateDgvFields();
            }
        }

        private void populateDgvFields()
        {
            if (cboCargoType.Text.Equals("BULK"))
            {
                nudTotalBilledWeight.DecimalPlaces = 3;
                cboWeightUnit.Enabled = true;
                lblWeightUni.Text = Conversions.ToString(cboWeightUnit.SelectedItem);
            }
            else
            {
                nudTotalBilledWeight.DecimalPlaces = 0;
                cboWeightUnit.Enabled = false;
                lblWeightUni.Text = "PC";
            }

            int counter = 0;
            if (UnitList.Count > 0)
            {
                for (int i = 0; i < UnitList.Count; i++)
                {
                    Unit unit = UnitList[i];
                    unit.CustomerId = Conversions.ToInteger(cboCustomer.SelectedValue);
                    unit.CustomerName = cboCustomer.Text;
                    unit.Commodity = cboGrade.Text + " " + cboCommodity.Text;
                    unit.CargoTypeId = Conversions.ToInteger(cboCargoType.SelectedValue);
                    unit.CargoType = cboCargoType.Text;
                    // unit.UnitStatusId = cboStatus.SelectedValue
                    // unit.UnitStatus = cboStatus.Text
                    unit.UnitType = Conversions.ToString(cboType.SelectedItem);
                    dgv.Rows[counter].Cells[1].Value = unit.CustomerName;
                    dgv.Rows[counter].Cells[2].Value = unit.Commodity;
                    dgv.Rows[counter].Cells[3].Value = unit.CargoType;
                    dgv.Rows[counter].Cells[4].Value = unit.UnitStatus;
                    dgv.Rows[counter].Cells[5].Value = unit.UnitType;
                    counter += 1;
                }
            }

            MandatoryFieldsOk();
        }

        private void dgvUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                if (dgv.SelectedRows.Count == 1)
                {
                    var unitRow = UnitList[dgv.CurrentRow.Index];
                    if (!Information.IsNothing(unitRow.TotalBilled))
                    {
                        nudTotalBilledWeight.Value = unitRow.TotalBilled;
                    }
                    else
                    {
                        nudTotalBilledWeight.Value = 0m;
                    }
                }
                else
                {
                    nudTotalBilledWeight.Value = 0m;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    var unitRow = UnitList[row.Index];
                    unitRow.TotalBilled = nudTotalBilledWeight.Value;
                    UnitList[row.Index] = unitRow;
                    row.Cells[6].Value = unitRow.TotalBilled;
                }
            }

            MandatoryFieldsOk();
        }

        private void FrmAddMultipleUnits_Load(object sender, EventArgs e)
        {
            // DataGridView1.AutoGenerateColumns = True
            updateButton.Enabled = false;
            populateComboBoxes();
        }

        private void tbCreateUnits_Click(object sender, EventArgs e)
        {
            if (MandatoryFieldsOk())
            {
                var unitService = new UnitSourceService();
                int insertedUSId;
                var muService = new MiniUnitService();
                string unitBilled;
                if (cboCargoType.Text.Equals("BULK"))
                {
                    unitBilled = Conversions.ToString(cboWeightUnit.SelectedItem);
                }
                else
                {
                    unitBilled = "PC";
                }

                //  My.MyProject.Forms.FrmParentScreen.showLOadForm();
                foreach (var unit in UnitList)
                {
                    UnitSource ExistingUnit;
                    MiniUnit mu;
                    if (unit.UnitId != 0)
                    {
                        ExistingUnit = AllUnits.Where(u => u.UnitSourceId == unit.UnitId).ToList()[0];

                        // ExistingUnit.UnitStatusId = cboStatus.SelectedValue
                        ExistingUnit.UnitType = Conversions.ToString(cboType.SelectedItem);
                        ExistingUnit.CargoTypeId = Conversions.ToInteger(cboCargoType.SelectedValue);
                        ExistingUnit.LastUpdate = DateAndTime.Now;
                        ExistingUnit.TotalBilled = (double?)unit.TotalBilled;
                        ExistingUnit.OriginalUnitNumber = unit.OriginalUnitNumber;
                        bool isSaved = unitService.AddOrUpdate(ExistingUnit);
                        insertedUSId = unit.UnitId;
                        var muList = new List<MiniUnit>();
                        muList = MiniUnitService.GetAllByUSId(unit.UnitId);
                        foreach (var currentMu in muList)
                        {
                            mu = currentMu;
                            if (muList.Count == 1)
                            {
                                mu.TotalBilled = unit.TotalBilled;
                            }

                            mu.BilledByUnitUnitType = unitBilled;
                            mu.UnBilledByUnitUnitType = unitBilled;
                            mu.CustomerId = Conversions.ToInteger(cboCustomer.SelectedValue);
                            mu.GradeId = Conversions.ToInteger(cboGrade.SelectedValue);
                            mu.CommodityId = Conversions.ToInteger(cboCommodity.SelectedValue);
                            muService.InsertOrUpdate(mu);
                        }
                    }
                    else
                    {
                        var us = new UnitSource();
                        us.UnitNumber = unit.UnitNumber;
                        us.OriginalUnitNumber = unit.OriginalUnitNumber;
                        us.UnitStatusId = unit.UnitStatusId;
                        us.UnitType = Conversions.ToString(cboType.SelectedItem);
                        us.CargoTypeId = Conversions.ToInteger(cboCargoType.SelectedValue);
                        us.OriginLocation = "";
                        us.UnitLine = "";
                        us.ETALocation = "";
                        us.Sequence = "";
                        us.Track = "";
                        us.LastLocation = "";
                        us.DemurageDays = 0;
                        us.InTransitDays = 0;
                        us.TotalBilled = (double?)unit.TotalBilled;
                        us.LastUpdate = DateAndTime.Now;
                        us.ActiveUpdates = true;
                        us.Active = true;
                        us.RecordKey = 0;
                        us.CargoDescription = "";
                        us.ShipperId = 0;
                        us.ETADate = default;
                        us.BillDate = default;
                        us.CallDate = default;
                        us.AvailableDate = default;
                        us.ArrivalDate = default;
                        us.ReleaseDate = default;
                        unitService.AddOrUpdate(us);
                        insertedUSId = unitService.GetLastUnitSourceId();
                        mu = new MiniUnit();
                        mu.MiniUnitOrder = 1;
                        mu.UnitSourceId = insertedUSId;
                        mu.TotalBilled = unit.TotalBilled;
                        mu.UnBilled = 0;
                        mu.BilledByUnit = 0;
                        mu.BilledByUnitUnitType = unitBilled;
                        mu.UnBilledByUnit = 0;
                        mu.UnBilledByUnitUnitType = unitBilled;
                        mu.MULocation = "";
                        mu.Comments = "";
                        mu.CustomerId = Conversions.ToInteger(cboCustomer.SelectedValue);
                        mu.GradeId = Conversions.ToInteger(cboGrade.SelectedValue);
                        mu.CommodityId = Conversions.ToInteger(cboCommodity.SelectedValue);
                        mu.BalanceToStorageAllowed = true;
                        mu.isMultiMU = false;
                        muService.InsertOrUpdate(mu);
                    }
                }

                //     My.MyProject.Forms.FrmParentScreen.HideLoadForm();
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Success!", "Units added with success. Do you want continue creating/updating units?", My.Resources.Resources.icon_available, this);
                if (!(result == DialogResult.Yes))
                {
                    Close();
                }
                else
                {
                    UnitList.Clear();
                    AllUnits = UnitSourceService.GetByActiveStatus(Conversions.ToBoolean(1));
                    tbUnits.Text = "";
                }
            }
        }

        private bool MandatoryFieldsOk()
        {
            if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(cboCustomer.SelectedValue, 0, false), cboType.SelectedItem.Equals("")), Operators.ConditionalCompareObjectEqual(cboCargoType.SelectedValue, 0, false)), Operators.ConditionalCompareObjectEqual(cboCommodity.SelectedValue, 0, false)), UnitList.Count == 0), HasNoTotalNulledValue())))
            {
                tbCreateUnits.Enabled = false;
                lblWarning.Text = "Mandatory fields must be filled";
                return false;
            }
            else
            {
                lblWarning.Text = "";
                tbCreateUnits.Enabled = true;
                return true;
            }
        }

        private bool HasNoTotalNulledValue()
        {
            foreach (var unit in UnitList)
            {
                if (unit.TotalBilled == 0m)
                {
                    lblWarning.Text = "Total Billed of unit " + unit.UnitNumber + " can not be 0";
                    return true;
                }
            }

            lblWarning.Text = "";
            return false;
        }

        private void nudTotalBilledWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv.SelectedRows)
                    {
                        var unitRow = UnitList[row.Index];
                        unitRow.TotalBilled = nudTotalBilledWeight.Value;
                        UnitList[row.Index] = unitRow;
                        row.Cells[6].Value = unitRow.TotalBilled;
                    }
                }
            }

            MandatoryFieldsOk();
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var unitRow = dgv.Rows[e.RowIndex];
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(unitRow.Cells["UnitId"].Value, 0, false)))
            {
                unitRow.DefaultCellStyle.BackColor = Color.Goldenrod;
                unitRow.DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
            }
            else
            {
                unitRow.DefaultCellStyle.BackColor = Color.White;
                unitRow.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                unitRow.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }
    }
}