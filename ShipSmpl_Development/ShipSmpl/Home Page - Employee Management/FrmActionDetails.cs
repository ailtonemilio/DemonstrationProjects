using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmActionDetails
    {
        public FrmActionDetails()
        {
            InitializeComponent();
            _TouchButton1.Name = "TouchButton1";
            _addCommentsButton.Name = "addCommentsButton";
        }

        private void FrmActionDetails_Load(object sender, EventArgs e)
        {
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void TouchButton1_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void addCommentsButton_Click(object sender, EventArgs e)
        {
            if (addCommentsButton.Text.Equals("Add notes"))
            {
                if (commentsRichTextBox.Text.Equals("N/A"))
                {
                    commentsRichTextBox.Text = "";
                }

                titleLabel.Text = "Editing notes...";
                commentsRichTextBox.BackColor = Color.Snow;
                commentsRichTextBox.ReadOnly = false;
                commentsRichTextBox.Select();
                addCommentsButton.Text = "Save notes";
            }
            else
            {
                if (commentsRichTextBox.Text.Equals(""))
                {
                    commentsRichTextBox.Text = "N/A";
                }

                db.updateNotesActionTaken(My.MyProject.Forms.FrmEmployeeManagementHP.notificationID, commentsRichTextBox.Text);
                commentsRichTextBox.BackColor = Color.SeaShell;
                commentsRichTextBox.ReadOnly = true;
                addCommentsButton.Text = "Add notes";
                titleLabel.Text = "Saved";
                titleLabel.BackColor = Color.Green;
                MdlControllerModifier.pause(2000);
                Close();
                // titleLabel.Text = "Notification details"
                // titleLabel.BackColor = Color.FromArgb(0, 64, 64)
            }

            titleLabel.Update();
            addCommentsButton.Update();
        }
    }
}