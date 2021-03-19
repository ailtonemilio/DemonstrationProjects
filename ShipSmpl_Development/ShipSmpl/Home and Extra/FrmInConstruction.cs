using System;

namespace ShipSmpl
{
    public partial class FrmInConstruction
    {
        public FrmInConstruction()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // Dim heigt As Decimal = My.Computer.Screen.Bounds.Size.Height - 110
            // Dim width As Decimal = My.Computer.Screen.Bounds.Size.Width - 240
            // Me.Size = New Point(width, heigt)

            // Me.Location = New Point(225, 55)
            // adjustScreen(Me, FrmParentScreen.menuIsExpanded)
        }

        private void TouchButton1_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuShadowPanel2_Paint(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEmployeeManagement.Show();
            Close();
        }
    }
}