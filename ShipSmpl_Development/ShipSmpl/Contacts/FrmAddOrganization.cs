using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmAddOrganization
    {
        public FrmAddOrganization()
        {
            InitializeComponent();
            _ediButton.Name = "ediButton";
            _cblCompanyType.Name = "cblCompanyType";
            _btnAddCompany.Name = "btnAddCompany";
            _Label8.Name = "Label8";
            _dgvAddresses.Name = "dgvAddresses";
            _PictureBox5.Name = "PictureBox5";
            _PictureBox4.Name = "PictureBox4";
            _PictureBox3.Name = "PictureBox3";
            _PictureBox2.Name = "PictureBox2";
            _PictureBox1.Name = "PictureBox1";
            _cboCompanyCategory.Name = "cboCompanyCategory";
            _cancelButton.Name = "cancelButton";
            _saveButton.Name = "saveButton";
        }

        private Company c;
        private CompanyCustomerRateType ccrt = new CompanyCustomerRateType();
        private List<CompanyCompanyType> cctList = new List<CompanyCompanyType>();
        public List<CompanyAddress> addrList = new List<CompanyAddress>();
        private bool firstLoad = true;
        private CompanyService cService = new CompanyService();
        private CompanyCompanyTypeService cctService = new CompanyCompanyTypeService();
        private CompanyAddressService caddrService = new CompanyAddressService();
        private CompanyCustomerRateTypeService ccrService = new CompanyCustomerRateTypeService();

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
            isCompanyCopy = false;
        }

        private int selectedItem = 0;
        private bool isCustomer;
        public Dictionary<string, string> edi = new Dictionary<string, string>();

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            int selectedRow = My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.CurrentCell.RowIndex;
            int companyID = Conversions.ToInteger(My.MyProject.Forms.FrmDisplayContacts.companiesBunifuDataGridView.Rows[selectedRow].Cells[4].Value);
            MdlContactsModifySaveData.populateEdi(companyID);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEDI, this);
        }

        private bool star1On = false;
        private bool star2On = false;
        private bool star3On = false;
        private bool star4On = false;
        private bool star5On = false;
        public int rating = 0;

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SetStarRate(1);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SetStarRate(2);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            SetStarRate(3);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            SetStarRate(4);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            SetStarRate(5);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int companyId;
            lblWarning.Text = "";
            if ((isCustomer && Convert.ToInt32(cboRateTier.SelectedValue) != 0) || isCustomer == false)
            {
                using (var db = new WTCCeresEntities())
                {
                    if (Information.IsNothing(c))
                    {
                        c = new Company();
                    }
                    // 
                    c.CompanyCategoryId = Conversions.ToInteger(cboCompanyCategory.SelectedValue);
                    c.CompanyCode = MdlDataCleasing.TrimAll(tbCode.Text);
                    c.CompanyName = MdlDataCleasing.TrimAll(tbName.Text);
                    c.Email = MdlDataCleasing.TrimAll(tbEmail.Text);
                    c.Website = MdlDataCleasing.TrimAll(tbWebsite.Text);
                    c.Attention = MdlDataCleasing.TrimAll(tbAttention.Text);
                    c.Notes = MdlDataCleasing.TrimAll(tbNotes.Text);
                    c.Rating = rating;
                    c.IsActive = true;
                    if (cService.AddOrUpdate(c, db))
                    {
                        companyId = cService.GetLastCompanyIdInserted();
                        if (isCustomer)
                        {
                            ccrt.CustomerRateTypeId = Conversions.ToInteger(cboRateTier.SelectedValue);
                            ccrt.CompanyId = companyId;
                            ccrService.AddOrUpdate(ccrt, db);
                        }

                        int count = 0;
                        foreach (var addr in addrList)
                        {
                            addr.CompanyId = companyId;
                            if (count == 0)
                            {
                                addr.MainAddress = true;
                            }
                            else
                            {
                                addr.MainAddress = false;
                            }

                            caddrService.AddOrUpdate(addr, db);
                            count += 1;
                        }

                        foreach (var cct in cctList)
                        {
                            cct.CompanyId = companyId;
                            cct.CompanyTypeId = cct.CompanyTypeId;
                            cctService.AddOrUpdate(cct, db);
                        }

                        Close();
                    }
                    else
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error", "There was an error and the information was not saved", this);
                    }
                }
            }
            else
            {
                lblWarning.Text = "Customer Rate needed.";
            }
        }

        private void typeCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Equals("Steamship Line") & (int)cblCompanyType.GetItemCheckState(e.Index) == Conversions.ToInteger(true))
            {
                ediPanel.Show();
            }
            else
            {
                ediPanel.Hide();
            }
        }

        private void areaCodeTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = Conversions.ToChar("");
            }
        }

        private void areaCodePhoneTextBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = Conversions.ToChar("");
            }
        }

        public bool isNewCompanyCode = false;
        public bool isCompanyCopy = false;
        public FrmAddOrganization newOrganizationForm;

        private void tbCompanyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboCompanyCategory.Text.Equals("VENDOR"))
            {
                pnlRAteTier.Show();
                isCustomer = true;
            }
            else
            {
                pnlRAteTier.Hide();
                isCustomer = false;
            }
        }

        public void loadForm()
        {
            ClearFields();
            firstLoad = true;
            using (var db = new WTCCeresEntities())
            {
                {
                    var withBlock = cboRateTier;
                    withBlock.DataSource = CompanyRateTypeService.GetAllCustomerRateType(db);
                    withBlock.DisplayMember = "RateCode";
                    withBlock.ValueMember = "CustomerRateTypeId";
                }

                cblCompanyType.DataSource = null;
                {
                    var withBlock1 = cblCompanyType;
                    withBlock1.DataSource = CompanyTypeService.GetAll(db);
                    withBlock1.DisplayMember = "DescCompanyType";
                    withBlock1.ValueMember = "CompanyTypeId";
                }

                {
                    var withBlock2 = cboCompanyCategory;
                    withBlock2.DataSource = CompanyCategoryService.GetAll(db);
                    withBlock2.DisplayMember = "Category";
                    withBlock2.ValueMember = "CompanyCategoryId";
                }

                cboRateTier.SelectedValue = 0;
            }

            cboCompanyCategory.SelectedValue = 1;
            isCustomer = true;
            firstLoad = false;
        }

        public void PopulateInfo(int companyId)
        {
            firstLoad = true;
            addrList.Clear();
            loadForm();
            using (var db = new WTCCeresEntities())
            {
                c = CompanyService.GetById(companyId, db);
                cctList = CompanyCompanyTypeService.GetByCompanyId(companyId, db);
                for (int i = 0, loopTo = cblCompanyType.Items.Count - 1; i <= loopTo; i++)
                {
                    CompanyType isInCheckList = (CompanyType)cblCompanyType.Items[i];

                    bool typeExistsInList = cctList.Where(c => Operators.ConditionalCompareObjectEqual(c.CompanyTypeId, isInCheckList.CompanyTypeId, false)).Count() > 0;
                    if (typeExistsInList)
                    {
                        cblCompanyType.SetItemChecked(i, true);
                    }
                }

                cboCompanyCategory.SelectedValue = c.CompanyCategoryId;
                tbCode.Text = c.CompanyCode;
                tbName.Text = c.CompanyName;
                tbEmail.Text = c.Email;
                tbWebsite.Text = c.Website;
                tbAttention.Text = c.Attention;
                tbNotes.Text = c.Notes;
                if (!Information.IsNothing(c.Rating))
                {
                    SetStarRate((int)c.Rating);
                }
                else
                {
                    SetStarRate(1);
                }

                addrList = CompanyAddressService.GetCompanyAddressByCompanyId(companyId, db);
                CompanyAddressBindingSource.DataSource = addrList;
                if (c.CompanyCategoryId != (int)MdlEnum.CompanyCategory.VENDOR)
                {
                    ccrt = CompanyCustomerRateTypeService.GetByCompanyId(companyId, db);
                    if (!Information.IsNothing(ccrt))
                    {
                        cboRateTier.SelectedValue = ccrt.CustomerRateTypeId;
                    }
                    else
                    {
                        ccrt = new CompanyCustomerRateType();
                        ccrt.CompanyId = companyId;
                        cboRateTier.SelectedValue = 0;
                    }

                    isCustomer = true;
                    pnlRAteTier.Show();
                }
                else
                {
                    isCustomer = false;
                    pnlRAteTier.Hide();
                }
            }

            firstLoad = false;
        }

        public void ClearFields()
        {
            tbCode.Text = "";
            titleLabel.Text = "Add New Company";
            tbName.Text = "";
            tbEmail.Text = "";
            tbWebsite.Text = "";
            tbNotes.Text = "";
            tbAttention.Text = "";
            cbRquiresedi.Checked = false;
            addrList.Clear();
            cctList.Clear();
        }

        private void SetStarRate(int NumberOfStars)
        {
            PictureBox1.BackgroundImage = My.Resources.Resources.starOff;
            PictureBox2.BackgroundImage = My.Resources.Resources.starOff;
            PictureBox3.BackgroundImage = My.Resources.Resources.starOff;
            PictureBox4.BackgroundImage = My.Resources.Resources.starOff;
            PictureBox5.BackgroundImage = My.Resources.Resources.starOff;
            if (NumberOfStars >= 1)
            {
                PictureBox1.BackgroundImage = My.Resources.Resources.starOn;
            }

            if (NumberOfStars >= 2)
            {
                PictureBox2.BackgroundImage = My.Resources.Resources.starOn;
            }

            if (NumberOfStars >= 3)
            {
                PictureBox3.BackgroundImage = My.Resources.Resources.starOn;
            }

            if (NumberOfStars >= 4)
            {
                PictureBox4.BackgroundImage = My.Resources.Resources.starOn;
            }

            if (NumberOfStars == 5)
            {
                PictureBox5.BackgroundImage = My.Resources.Resources.starOn;
            }

            rating = NumberOfStars;
        }

        private void Label8_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEditAddress.LoadForm();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddress, this);
        }

        private void dgvAddresses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyAddress ca = (CompanyAddress)dgvAddresses.CurrentRow.DataBoundItem;
            My.MyProject.Forms.FrmEditAddress.PopulateInfo(ca.CompanyAddressId);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddress, this);
            using (var db = new WTCCeresEntities())
            {
                CompanyAddressBindingSource.DataSource = addrList;
            }
        }

        private void cblCompanyType_CheckedChanged(object sender, ItemCheckEventArgs e)
        {
            object hasEdi;
            hasEdi = false;
            var ct = new CompanyType();
            ct = (CompanyType)cblCompanyType.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                if (cblCompanyType.Items[e.Index].Equals("Steamship Line"))
                {
                    hasEdi = true;
                }

                bool hasThisCompany = cctList.Where(ctt => ctt.CompanyTypeId == ct.CompanyTypeId).Count() > 0;
                if (!hasThisCompany && !firstLoad)
                {
                    var selectedCt = new CompanyCompanyType();
                    cctList.Add(selectedCt);
                }
            }
            else
            {
                var toDelete = cctList.Where(ctt => ctt.CompanyTypeId == ct.CompanyTypeId).ToList();
                if (toDelete.Count > 0 && !firstLoad)
                {
                    bool isDeleted = cctService.Delete(toDelete[0].CompanyCompanyTypeId);
                }
            }

            if (Conversions.ToBoolean(hasEdi))
            {
                ediPanel.Show();
            }
            else
            {
                ediPanel.Hide();
            }
        }
    }
}