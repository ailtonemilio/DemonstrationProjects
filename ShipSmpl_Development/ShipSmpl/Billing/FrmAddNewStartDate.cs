using System;

namespace ShipSmpl
{
    public partial class FrmAddNewStartDate
    {
        public FrmAddNewStartDate()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _dtpNewDrayageDate.Name = "dtpNewDrayageDate";
            _saveButton.Name = "saveButton";
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddNewStartDate_Load(object sender, EventArgs e)
        {
            oldDateLabel.Text = dtpNewDrayageDate.Value.Date.AddDays(-1).ToString("dd-MMM-yyyy");
        }

        private void dtpNewDrayageDate_ValueChanged(object sender, EventArgs e)
        {
            oldDateLabel.Text = dtpNewDrayageDate.Value.Date.AddDays(-1).ToString("dd-MMM-yyyy");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmEditDrayage.cboStartDate.Items.Add(dtpNewDrayageDate.Value.ToString("dd-MMM-yyyy"));
            My.MyProject.Forms.FrmEditDrayage.cboStartDate.SelectedItem = dtpNewDrayageDate.Value.ToString("dd-MMM-yyyy");
            Close();
        }
    }
}