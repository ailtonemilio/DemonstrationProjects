using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmShiftScheduling
    {
        public FrmShiftScheduling()
        {
            InitializeComponent();
            _Button1.Name = "Button1";
            _TouchButton3.Name = "TouchButton3";
            _selectAllCheckBox.Name = "selectAllCheckBox";
            _scheduleEmployeesTouchButton.Name = "scheduleEmployeesTouchButton";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShiftScheduling_Load(object sender, EventArgs e)
        {
            string condition = "";
            yardComboBox.SelectedIndex = 3;
            typeComboBox.SelectedIndex = 0;
            jobDescriptionComboBox.SelectedIndex = 21;
            payMethodComboBox.SelectedIndex = 0;
            MdlControllerModifier.populateEmployeeListSchedule(selectEmpoyeeListView, condition);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                selectEmpoyeeListView.Items.OfType<ListViewItem>().All(c =>
                {
                    c.Checked = true;
                    return true;
                });
            }
            else
            {
                selectEmpoyeeListView.Items.OfType<ListViewItem>().All(c =>
                {
                    c.Checked = false;
                    return true;
                });
            }
        }

        private void TouchButton3_Load(object sender, EventArgs e)
        {
            string condition = "";
            if (typeComboBox.SelectedIndex != 0)
            {
                condition = Conversions.ToString(condition + Operators.AddObject(Operators.AddObject("And Type = '", typeComboBox.SelectedItem), "' "));
            }

            if (yardComboBox.SelectedIndex != 3)
            {
                condition = Conversions.ToString(condition + Operators.AddObject(Operators.AddObject("And Yard = '", yardComboBox.SelectedItem), "'"));
            }

            if (jobDescriptionComboBox.SelectedIndex != 21)
            {
                condition = Conversions.ToString(condition + Operators.AddObject(Operators.AddObject("And Job_Description = '", jobDescriptionComboBox.SelectedItem), "'"));
            }

            if (payMethodComboBox.SelectedIndex != 0)
            {
                condition = Conversions.ToString(condition + Operators.AddObject(Operators.AddObject("And Pay_Method = '", payMethodComboBox.SelectedItem), "' "));
            }

            MdlControllerModifier.populateEmployeeListSchedule(selectEmpoyeeListView, condition);
        }

        private void scheduleEmployeesTouchButton_Load(object sender, EventArgs e)
        {
        }
    }
}