using BusinessLayer.WTC_Ceres;
using System;

namespace ShipSmpl
{
    public partial class frmAddDepartment
    {
        public frmAddDepartment()
        {
            InitializeComponent();
            _btnClose.Name = "btnClose";
            _btnInsert.Name = "btnInsert";
        }

        private FTPServerManagement ftpser = new FTPServerManagement();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentType.Text) == false)
            {
                if (DocumentsStoredDepartmentService.VerifyDepartmentEquals(txtDocumentType.Text.TrimEnd().Replace(" ", "_").Replace(",", "_")))
                {
                    // MessageBox.Show("This Department Exists!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("This Department Exists!", "Attention!", this);
                    return;
                }
            }
            else
            {
                // MessageBox.Show("Field is empty!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Field is empty!", "Attention!", this);
                return;
            }

            if (ftpser.CreateFolder(txtDocumentType.Text.Replace(" ", "_").Replace(",", "_")))
            {
                if (DocumentsStoredDepartmentService.Insert(txtDocumentType.Text.Replace(" ", "_").Replace(",", "_")))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Department successfully inserted!", "Success!", this);
                    My.MyProject.Forms.frmAddEditStoreFiles.LoadDepartment(DocumentsStoredDepartmentService.GetLastId());
                    DocumentsStoredUserDepartmentService.Insert(DocumentsStoredDepartmentService.GetLastId(), 163);
                    DocumentsStoredUserDepartmentService.Insert(DocumentsStoredDepartmentService.GetLastId(), 124);
                    DocumentsStoredUserDepartmentService.Insert(DocumentsStoredDepartmentService.GetLastId(), 63);
                    Close();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("It was not possible to create this Department! Contact IT Department.", "Error!", this);
                    ftpser.DeleteSFTPFolder("/documentstorage/" + txtDocumentType.Text.Replace(" ", "_").Replace(",", "_"));
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

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {
        }
    }
}