using Microsoft.VisualBasic;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmTimeTracker
    {
        public FrmTimeTracker()
        {
            InitializeComponent();
            _clockInOutButton.Name = "clockInOutButton";
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void clockInOutButton_Click(object sender, EventArgs e)
        {
            if (db.needToclockedOutLastShift())
            {
                db.punchtime("clockout");
                var timeDiff = DateAndTime.Now.Subtract(db.startTime);
                messageButto.BackColor = Color.DarkGray;
                messageButto.Text = "CLOCKED " + Constants.vbNewLine + "OUT";
                clockInOutButton.Text = "Clock In";
                clockInOutButton.IdleFillColor = Color.Green;
                titleLabel.Text = "You are clocked out. Hours Worked: " + timeDiff.Hours.ToString() + "H " + timeDiff.Minutes.ToString() + "min.";
            }
            else
            {
                db.punchtime("clockin");
                clockInOutButton.Text = "Clock Out";
                messageButto.BackColor = Color.Green;
                titleLabel.Text = "You are clocked in. Time: " + DateAndTime.Now.ToShortTimeString();
                messageButto.Text = "CLOCKED " + Constants.vbNewLine + "IN";
                clockInOutButton.IdleFillColor = Color.Firebrick;
            }
        }

        private void FrmTimeTracker_Load(object sender, EventArgs e)
        {
            if (db.needToclockedOutLastShift())
            {
                var timeDiff = DateAndTime.Now.Subtract(db.startTime);
                titleLabel.Text = "Hello " + My.MyProject.Forms.FrmLoginWindow._employeeName + ". You have worked: " + timeDiff.Hours.ToString() + "H " + timeDiff.Minutes.ToString() + "min . Clock out now?";
                messageButto.BackColor = Color.Green;
                messageButto.Text = "CLOCKED " + Constants.vbNewLine + "IN";
                clockInOutButton.Text = "Clock Out";
                clockInOutButton.IdleFillColor = Color.Firebrick;
            }
            else
            {
                titleLabel.Text = "Hello " + My.MyProject.Forms.FrmLoginWindow._employeeName + ". Clock in now?";
                messageButto.BackColor = Color.DarkGray;
                messageButto.Text = "CLOCKED " + Constants.vbNewLine + "OUT";
                clockInOutButton.Text = "Clock In";
                clockInOutButton.IdleFillColor = Color.Green;
            }
        }
    }
}