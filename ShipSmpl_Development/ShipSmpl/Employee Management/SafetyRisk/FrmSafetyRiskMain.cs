using BusinessLayer.WTCOperations;
using System;

namespace ShipSmpl
{
    public partial class FrmSafetyRiskMain
    {
        public FrmSafetyRiskMain()
        {
            InitializeComponent();
            _menuWorkedHours.Name = "menuWorkedHours";
            _menuDocumentStorage.Name = "menuDocumentStorage";
            _ReportOfWhoIsWorkingToolStripMenuItem.Name = "ReportOfWhoIsWorkingToolStripMenuItem";
        }

        private void FrmSafetyRiskManagement_Load(object sender, EventArgs e)
        {
            var List = Safetyand_Risk_Management_ClearanceService.GetByUserId(My.MyProject.Forms.FrmLoginWindow._userID);
            foreach (var item in List)
            {
                if (item.Worked_Hours == true)
                {
                    menuWorkedHours.Visible = true;
                }
                else
                {
                    menuWorkedHours.Visible = false;
                }

                if (item.Document_Storage == true)
                {
                    menuDocumentStorage.Visible = true;
                }
                else
                {
                    menuDocumentStorage.Visible = false;
                }
            }
        }

        public void ManagerMEnu(int _userId)
        {
        }

        private void menuWorkedHours_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmSafetyRiskManagement, ParentForm);
        }

        private void menuDocumentStorage_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmStoreFiles, ParentForm);
        }

        private void ReportOfWhoIsWorkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmReportEmployeeIsworking, ParentForm);
        }
    }
}