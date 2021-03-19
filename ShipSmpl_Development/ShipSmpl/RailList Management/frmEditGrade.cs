using BusinessLayer.WTC_Ceres;
using System;

namespace ShipSmpl
{
    public partial class frmEditGrade
    {
        public frmEditGrade()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnSaveGrade.Name = "btnSaveGrade";
        }

        public int GradeId;

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGradeCode.Text) | string.IsNullOrEmpty(txtGrade.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Fields Empty", "The Grade or Grade Code fields cannot be empty.", this);
            }
            else if (GradeService.VerifyByGradeCode(txtGradeCode.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Warning!", "This registration code already exists!", this);
            }
            else if (GradeId == 0)
            {
                if (GradeService.Insert(txtGradeCode.Text, txtGrade.Text))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success", "Grade inserted successfully.", this);
                    My.MyProject.Forms.frmCommodityGrainMain.LoadGrade();
                    Close();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error!", "There was an error when changing the Grade, please contact the IT department. Error # 0122", this);
                }
            }
            else if (GradeService.Update(GradeId, txtGradeCode.Text, txtGrade.Text))
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Success", "Grade updated successfully.", this);
                My.MyProject.Forms.frmCommodityGrainMain.LoadGrade();
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error!", "There was an error when changing the Grade, please contact the IT department. Error # 0122", this);
            }
        }

        private void frmEditGrade_Load(object sender, EventArgs e)
        {
            if (GradeId != 0)
            {
                var L = GradeService.GetById(GradeId);
                txtGrade.Text = L.GradeName;
                txtGradeCode.Text = L.GradeCode;
            }
        }
    }
}