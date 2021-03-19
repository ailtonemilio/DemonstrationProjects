using System;

namespace ShipSmpl
{
    public partial class FrmEmployeeDetails
    {
        public FrmEmployeeDetails()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
            MdlModifyData.clearEmployeeDetails();
            MdlControllerModifier.clearFields();
        }
    }
}