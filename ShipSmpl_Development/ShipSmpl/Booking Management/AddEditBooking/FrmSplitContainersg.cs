using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmSplitContainersg
    {
        public FrmSplitContainersg()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _cancelButton.Name = "cancelButton";
            _addButton.Name = "addButton";
            _numMBNumericUpDown.Name = "numMBNumericUpDown";
        }

        public int numbOfMB = 0;

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            numbOfMB = 0;
            Close();
        }

        private void FrmSplitBooking_Load(object sender, EventArgs e)
        {
            numMBNumericUpDown.Value = 0m;
            warningLabel.Text = "";
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            numbOfMB = (int)Math.Round(numMBNumericUpDown.Value);
            var mbDataTable = new List<Minibooking>(My.MyProject.Forms.FrmEditAddBooking.originalMBTable);
            int focusedMB = My.MyProject.Forms.FrmEditAddBooking.focusedMB;
            int numbOfContFocMB = (int)mbDataTable[focusedMB].NumberOfContainer;
            if (numbOfMB <= 0)
            {
                warningLabel.Text = "Number of containers to this minibooking must be greater than 0";
            }
            else if (numbOfContFocMB - numbOfMB > 0)
            {
                int sumTotalCOnt = 0;
                // For Each mb In mbDataTable.Rows
                // sumTotalCOnt += mbDataTable.Rows(focusedMB).Item("Number Of Containers")
                // Next

                // If sumTotalCOnt <= FrmEditAddBooking.totalContainersNumericUpDown.Value Then
                mbDataTable[focusedMB].NumberOfContainer = numbOfContFocMB - numbOfMB;
                warningLabel.Text = "";
                Close();
            }
            // Else
            // warningLabel.Text = "Number of containers on minibookings will exceed total number of containers"
            // End If
            else
            {
                warningLabel.Text = "Number of containers for the previous minibooking can not be 0 or less than 0";
            }
        }

        private void numMBNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            numbOfMB = (int)Math.Round(numMBNumericUpDown.Value);
            if (numbOfMB <= 1)
            {
                warningLabel.Text = "Number of Minibookings must be greater than 1";
            }
            else
            {
                warningLabel.Text = "";
            }
        }
    }
}