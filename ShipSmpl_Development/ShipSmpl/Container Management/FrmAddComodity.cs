using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmAddComodity
    {
        public FrmAddComodity()
        {
            InitializeComponent();
            _cancelButton.Name = "cancelButton";
            _saveButton.Name = "saveButton";
            _closeLabel.Name = "closeLabel";
        }

        private DatabaseHelperCeres db = new DatabaseHelperCeres();

        private void Button1_Click(object sender, EventArgs e)
        {
            // If Not String.IsNullOrEmpty(codeTextBox.Text) And Not String.IsNullOrEmpty(NameTextBox.Text) Then

            // If FrmCFIALabel.typeOfGrain.Equals("commodity") Then
            // Dim cm = New CommodityService
            // If db.getGradesAndCommodities("Commodity", " [CommodityCode] = '" + codeTextBox.Text + "'").Rows.Count = 0 Then
            // cm.Insert(Trim(codeTextBox.Text), Trim(NameTextBox.Text))
            // 'FrmCFIALabel.populateUnits()
            // Me.Close()
            // Else
            // warningLabel.ForeColor = Color.Firebrick
            // warningLabel.Text = "This Commodity Code already exists"
            // End If
            // Else
            // warningLabel.ForeColor = Color.Firebrick
            // warningLabel.Text = "Please make sure all te fields are filled up"
            // End If
            // ElseIf FrmCFIALabel.typeOfGrain.Equals("grade") Then
            // Dim g = New GradeService
            // If db.getGradesAndCommodities("Grade", " [GradeCode] = '" + codeTextBox.Text + "'").Rows.Count = 0 Then
            // g.Insert(Trim(codeTextBox.Text), Trim(NameTextBox.Text))
            // 'FrmCFIALabel.populateUnits()
            // Me.Close()
            // Else
            // warningLabel.ForeColor = Color.Firebrick
            // warningLabel.Text = "This Commodity Code already exists"
            // End If
            // Else
            // warningLabel.ForeColor = Color.Firebrick
            // warningLabel.Text = "Please make sure all te fields are filled up"

            // End If
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 0);
        }
    }
}