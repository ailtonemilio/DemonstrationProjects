using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmAddDocumentType
    {
        public frmAddDocumentType()
        {
            InitializeComponent();
            _btnInsert.Name = "btnInsert";
            _btnClose.Name = "btnClose";
        }

        private FTPServerManagement ftpser = new FTPServerManagement();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.CreateSubFolderInFTPServer(Conversions.ToInteger(ddlDepartment.SelectedValue), ddlDepartment.Text, txtDocumentType.Text.Replace(" ", "_").Replace(",", "_"));
        }

        private void CreateSubFolderInFTPServer(int DepartmentId, string Department, string TypeDoc)
        {
            // 1 - Handles blank field errors
            if (string.IsNullOrEmpty(Department) | string.IsNullOrEmpty(TypeDoc) | string.IsNullOrWhiteSpace(TypeDoc))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("The Department and/or Document Type field must not be empty!", "Attention!", this);
                return;
            }

            // 2 - Checks whether the Department folder already exists
            if (DocumentsStoredTypeService.VerifyDocumentsStoredTypeEquals(DepartmentId, TypeDoc))
            {
                MessageBox.Show("This type of document already exists for the Department!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3 - creates the folder on the FTP Server
            if (ftpser.CreateSubFolder(ddlDepartment.Text, txtDocumentType.Text.Replace(" ", "_").Replace(",", "_")))
            {
                // 4 - After creating the folder in the server, insert the information in the database
                if (DocumentsStoredTypeService.Insert(txtDocumentType.Text.Replace(" ", "_").Replace(",", "_"), Conversions.ToInteger(ddlDepartment.SelectedValue)))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Document type successfully inserted!", "Success!", this);
                    My.MyProject.Forms.frmAddEditStoreFiles.LoadDocType();
                    Close();
                }
                else
                {
                    // 5 - Deleta pasta criada no Server FTP e dispara mensagem 
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("It was not possible to create this Department! Contact IT Department.", "Error!", this);
                    ftpser.DeleteSFTPFolder("/documentstorage/" + ddlDepartment.Text + "/" + txtDocumentType.Text.Replace(" ", "_").Replace(",", "_"));
                }
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("It was not possible to create this Department! If necessary Contact IT Department.", "Error!", this);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadForm(int DepId)
        {
            DocumentsStoredDepartmentBindingSource.DataSource = DocumentsStoredDepartmentService.GetAll();
            ddlDepartment.SelectedValue = DepId;
            txtDocumentType.Text = "";
        }

        private void frmAddDocumentType_Load(object sender, EventArgs e)
        {
        }
    }
}