using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using WaitLoading;

namespace ShipSmpl
{
    public partial class frmStoreFiles
    {
        public frmStoreFiles()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _dgvEmployees.Name = "dgvEmployees";
            _ddlEmployee.Name = "ddlEmployee";
            _ddlType.Name = "ddlType";
            _btnSearchFile.Name = "btnSearchFile";
            _btnAdd.Name = "btnAdd";
            _btnClose.Name = "btnClose";
            _ddlArea.Name = "ddlArea";
            _ckbDate.Name = "ckbDate";
            _rbIssueDate.Name = "rbIssueDate";
            _rbExpireDate.Name = "rbExpireDate";
            _btnDelete.Name = "btnDelete";
            _txtEndDate.Name = "txtEndDate";
            _txtStartDate.Name = "txtStartDate";
            _txtFileType.Name = "txtFileType";
            _txtDecription.Name = "txtDecription";
        }

        private WaitLoadingRun waitForm = new WaitLoadingRun();
        private FTPServerManagement ftpser = new FTPServerManagement();
        private List<DocumentsStored> listDoc;

        private void frmStoreFiles_Load(object sender, EventArgs e)
        {
            waitForm.Show(this);
            LoadForm();
            waitForm.Close();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmAddEditStoreFiles.ClearFields();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmAddEditStoreFiles, this);
            DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentId(Conversions.ToInteger(ddlArea.SelectedValue));
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            SearchDocs();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpneFile();
        }

        private void btnOpenWeb_Click(object sender, EventArgs e)
        {
            // showDialogForm(frmWebBrowserPDF, Me)
            // frmWebBrowserPDF.LoadPDF(ReturnFile(), ReturnFileName())
        }

        private void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlType.Enabled = true;
            DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentIdForDropBox(Conversions.ToInteger(ddlArea.SelectedValue), false);
            ddlType.Refresh();
            SearchDocs();
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            int DepId = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[9].Value);
            int IdUser = My.MyProject.Forms.FrmLoginWindow._userID;
            if (DocumentsStoredUserDepartmentService.VerifySecurityDepartmentUser(DepId, IdUser) == false)
            {
                MessageBox.Show("Viewing a document restricted to the department." + Constants.vbCrLf + "If you need access, contact the IT department.!", "Restricted access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ftp_fileName = ReturnFileName()
            string FileName = ReturnFileName();
            // ftp_root = ReturnFile()
            string FTPDirFile = ReturnFile();

            //TODO

            // My.MyProject.Forms.frmLoadingPDF.ftpfileName = FileName;
            //  My.MyProject.Forms.frmLoadingPDF.ftpDirFileName = FTPDirFile;
            //   MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmLoadingPDF, this);
        }

        private void ckbDate_Click(object sender, EventArgs e)
        {
            VerifyCheckDate();
            SearchDocs();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStartDate.CustomFormat = " ";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            txtEndDate.CustomFormat = " ";
        }

        private void txtStartDate_ValueChanged(object sender, EventArgs e)
        {
            txtStartDate.CustomFormat = "MMM dd, yyyy";
        }

        private void txtEndDate_ValueChanged(object sender, EventArgs e)
        {
            txtEndDate.CustomFormat = "MMM dd, yyyy";
        }

        private void txtStartDate_ValueChanged_1(object sender, EventArgs e)
        {
            txtStartDate.CustomFormat = "MMM dd, yyyy";
        }

        private void txtEndDate_ValueChanged_1(object sender, EventArgs e)
        {
            txtEndDate.CustomFormat = "MMM dd, yyyy";
        }

        private void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchDocs();
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchDocs();
        }

        private void txtFileType_TextChange(object sender, EventArgs e)
        {
            SearchDocs();
        }

        private void txtDecription_TextChanged(object sender, EventArgs e)
        {
            SearchDocs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int DepId = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[9].Value);
            int IdUser = My.MyProject.Forms.FrmLoginWindow._userID;
            if (DocumentsStoredUserDepartmentService.VerifySecurityDepartmentUser(DepId, IdUser) == false)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Viewing a document restricted to the department." + Constants.vbCrLf + "If you need access, contact the IT department.!", "Restricted access", this);
                return;
            }

            int DocId = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[0].Value);
            string FileOrigin = dgvEmployees.CurrentRow.Cells[6].Value.ToString();
            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Delete this document ?", "Are you sure you want to delete this document ID #" + DocId.ToString(), My.Resources.Resources.caution, this);
            if (result == DialogResult.Yes)
            {
                if (ftpser.DeleteSFTPFile(FileOrigin))
                {
                    if (DocumentsStoredService.Delete(DocId))
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Document deleted successfully!", "Message", this);
                        SearchDocs();
                    }
                    else
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Check if you are using WTC VPN or if your computer is connected to the WTC Network." + Constants.vbCrLf + "If this error persists, contact the IT Department!", "Error Message", this);
                    }
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Check if you are using WTC VPN or if your computer is connected to the WTC Network." + Constants.vbCrLf + "If this error persists, contact the IT Department!", "Error Message", this);
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void LoadForm()
        {
            EmployeeNameBindingSource.DataSource = EmployeeService.GetFirstNameLastNameForDropBox();
            ddlEmployee.SelectedValue = 0;
            DocumentsStoredDepartmentBindingSource.DataSource = DocumentsStoredDepartmentService.GetAllForDropBox();
            ddlArea.SelectedValue = 0;
            DocumentsStoredTypeBindingSource.DataSource = DocumentsStoredTypeService.GetByDeparmentIdForDropBox(Conversions.ToInteger(ddlArea.SelectedValue), false);
            DocumentsStoredBindingSource.DataSource = DocumentsStoredService.GetByFilters(txtFileType.Text, txtDecription.Text, "", "", 0, "", "", true);
            txtStartDate.CustomFormat = " ";
            txtEndDate.CustomFormat = " ";
            ConfigLayoutForUserPerfil();
        }

        public void ConfigLayoutForUserPerfil()
        {
            int IdUser = My.MyProject.Forms.FrmLoginWindow._userID;
            if (dgvEmployees.Rows.Count > 0)
            {
                switch (IdUser)
                {
                    // 54 - JORDAN
                    // 63 - LYNDON
                    // 70 - MAY
                    // 124 - Vania
                    // 135 - Roger
                    // 163 - Emilio
                    case 135:
                        {
                            btnDelete.Visible = false;
                            break;
                        }

                    case 70:
                        {
                            btnDelete.Visible = false;
                            break;
                        }

                    case 54:
                        {
                            btnDelete.Visible = true;
                            break;
                        }

                    case 63:
                        {
                            btnDelete.Visible = true;
                            break;
                        }

                    case 124:
                        {
                            btnDelete.Visible = true;
                            break;
                        }

                    case 163:
                        {
                            btnDelete.Visible = true;
                            break;
                        }
                }
            }
            else
            {
                btnDelete.Visible = false;
            }
        }

        public void SearchDocs()
        {
            waitForm.Show(this);
            string StartDate = "";
            string EndDate = "";
            string Department = ddlArea.Text;
            string DocType = ddlType.Text;
            if (ckbDate.Checked)
            {
                StartDate = txtStartDate.Value.ToShortDateString();
                EndDate = txtEndDate.Value.ToShortDateString();
            }

            if (string.IsNullOrEmpty(Department) | Department == "ALL")
            {
                Department = "";
            }

            if (string.IsNullOrEmpty(DocType) | DocType == "ALL")
            {
                DocType = "";
            }

            if (rbIssueDate.Checked)
            {
                DocumentsStoredBindingSource.DataSource = DocumentsStoredService.GetByFilters(txtFileType.Text, txtDecription.Text, Department, DocType, Conversions.ToInteger(ddlEmployee.SelectedValue), StartDate, EndDate, true);
                // DocumentsStoredBindingSource.DataSource = DocumentsStoredService.GetByTypeDocEmployeeIssueExpire(txtFileType.Text, txtDecription.Text, ddlArea.SelectedValue, ddlType.SelectedValue, ddlEmployee.SelectedValue, StartDate, EndDate, True)
                dgvEmployees.Refresh();
            }
            else
            {
                DocumentsStoredBindingSource.DataSource = DocumentsStoredService.GetByFilters(txtFileType.Text, txtDecription.Text, Department, DocType, Conversions.ToInteger(ddlEmployee.SelectedValue), StartDate, EndDate, false);
                // DocumentsStoredBindingSource.DataSource = DocumentsStoredService.GetByTypeDocEmployeeIssueExpire(txtFileType.Text, txtDecription.Text, ddlArea.SelectedValue, ddlType.SelectedValue, ddlEmployee.SelectedValue, StartDate, EndDate, False)
                dgvEmployees.Refresh();
            }

            ConfigLayoutForUserPerfil();
            waitForm.Close();
        }

        private void OpneFile()
        {
            int Id = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[0].Value);
            var a = default(string);
            var Docs = DocumentsStoredService.GetById(Id);
            foreach (var item in Docs)
                a = item.ServerPath;
            Process.Start(a);
        }

        public string ReturnFile()
        {
            int Id = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[0].Value);
            string a = "";
            var Docs = DocumentsStoredService.GetById(Id);
            foreach (var item in Docs)
                a = item.ServerPath;
            return a;
        }

        public string ReturnFileName()
        {
            int Id = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[0].Value);
            string a = "";
            var Docs = DocumentsStoredService.GetById(Id);
            foreach (var item in Docs)
                a = item.FileName;
            return a;
        }

        public bool VerifyDepartmentUser()
        {
            bool isDepOK = false;
            int DocId = Conversions.ToInteger(dgvEmployees.CurrentRow.Cells[0].Value);

            // Department code:
            // HR - 17
            // SAFETY_AND_RISK - 18

            // Verifica se usuario pode excluir documentos do departamento.
            int IdUser = My.MyProject.Forms.FrmLoginWindow._userID;
            switch (IdUser)
            {
                // 54 - JORDAN
                // 63 - LYNDON
                // 70 - MAY
                // 124 - Vania
                // 135 - Roger
                // 163 - Emilio
                case 135:
                    {
                        if (DocumentsStoredService.VerifiDocByDepartment(DocId, 18))
                        {
                            isDepOK = true;
                        }

                        break;
                    }

                case 70:
                    {
                        if (DocumentsStoredService.VerifiDocByDepartment(DocId, 17))
                        {
                            isDepOK = true;
                        }

                        break;
                    }
            }

            return isDepOK;
        }

        public void LoadEmployee()
        {
            var List = EmployeeService.GetFirstNameLastName();
            foreach (var item in List)
            {
            }

            {
                var withBlock = ddlEmployee;
                withBlock.DataSource = EmployeeService.GetFirstNameLastName();
                withBlock.DisplayMember = "getName";
                withBlock.ValueMember = "getId";
            }
        }

        public void VerifyCheckDate()
        {
            if (ckbDate.Checked)
            {
                rbIssueDate.Visible = true;
                rbIssueDate.Checked = true;
                rbExpireDate.Visible = true;
                rbExpireDate.Checked = false;
                lblExpireDate.Visible = true;
                lblIssueDate.Visible = true;
                txtStartDate.Enabled = true;
                txtEndDate.Enabled = true;
                txtStartDate.CustomFormat = "MMM dd, yyyy";
                txtEndDate.CustomFormat = "MMM dd, yyyy";
            }
            else
            {
                rbExpireDate.Visible = false;
                rbIssueDate.Visible = false;
                lblExpireDate.Visible = false;
                lblIssueDate.Visible = false;
                txtStartDate.CustomFormat = " ";
                txtEndDate.CustomFormat = " ";
                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
            }
        }

        private void rbIssueDate_Click(object sender, EventArgs e)
        {
            SearchDocs();
        }

        private void rbExpireDate_Click(object sender, EventArgs e)
        {
            SearchDocs();
        }



        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}