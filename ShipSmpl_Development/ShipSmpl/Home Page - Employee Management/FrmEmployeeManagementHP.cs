using System;

namespace ShipSmpl
{
    public partial class FrmEmployeeManagementHP
    {
        public FrmEmployeeManagementHP()
        {
            InitializeComponent();
        }

        public bool firstLoad = true;

        private void FrmOptionsManagement_Load(object sender, EventArgs e)
        {
            // messagesTouchButton.TakeButtonPicture(My.Resources.email)
            // adjustScreen(Me, FrmParentScreen.menuIsExpanded)

            MdlOptionsManagement.fillUpEmployeesStats();
        }

        private void FrmOptionsManagement_Closed(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLoginWindow.Close();
        }

        public int notificationID { get; set; } = 0;
    }
}