using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmActionDetails : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            _TouchButton1 = new YardTabletControls.TouchButton();
            _TouchButton1.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(TouchButton1_Load);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            titleLabel = new Label();
            byLabel = new Label();
            actionTakenLabel = new Label();
            dateLabel = new Label();
            Label6 = new Label();
            commentsRichTextBox = new RichTextBox();
            _addCommentsButton = new Button();
            _addCommentsButton.Click += new EventHandler(addCommentsButton_Click);
            SuspendLayout();
            // 
            // TouchButton1
            // 
            _TouchButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _TouchButton1.BevelWidth = Conversions.ToShort(2);
            _TouchButton1.ButtonEnabled = true;
            _TouchButton1.ButtonFontSize = Conversions.ToShort(22);
            _TouchButton1.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _TouchButton1.Caption = "X";
            _TouchButton1.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _TouchButton1.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _TouchButton1.Location = new Point(604, 12);
            _TouchButton1.Margin = new Padding(4, 3, 4, 3);
            _TouchButton1.Name = "_TouchButton1";
            _TouchButton1.Size = new Size(50, 47);
            _TouchButton1.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _TouchButton1.TabIndex = 0;
            _TouchButton1.TextColour = Color.White;
            _TouchButton1.TouchButtonColour = Color.Firebrick;
            _TouchButton1.Value = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(19, 131);
            Label1.Name = "Label1";
            Label1.Size = new Size(160, 29);
            Label1.TabIndex = 1;
            Label1.Text = "Action taken:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(124, 183);
            Label2.Name = "Label2";
            Label2.Size = new Size(50, 29);
            Label2.TabIndex = 2;
            Label2.Text = "By:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(93, 301);
            Label3.Name = "Label3";
            Label3.Size = new Size(86, 29);
            Label3.TabIndex = 3;
            Label3.Text = "Notes:";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Microsoft Sans Serif", 32.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(677, 91);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Notification details";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // byLabel
            // 
            byLabel.BackColor = Color.SeaShell;
            byLabel.BorderStyle = BorderStyle.Fixed3D;
            byLabel.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            byLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            byLabel.Location = new Point(173, 177);
            byLabel.Name = "byLabel";
            byLabel.Size = new Size(350, 31);
            byLabel.TabIndex = 7;
            byLabel.Text = "N/A";
            // 
            // actionTakenLabel
            // 
            actionTakenLabel.BackColor = Color.SeaShell;
            actionTakenLabel.BorderStyle = BorderStyle.Fixed3D;
            actionTakenLabel.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            actionTakenLabel.ForeColor = Color.Green;
            actionTakenLabel.Location = new Point(173, 130);
            actionTakenLabel.Name = "actionTakenLabel";
            actionTakenLabel.Size = new Size(350, 31);
            actionTakenLabel.TabIndex = 8;
            actionTakenLabel.Text = "N/A";
            // 
            // dateLabel
            // 
            dateLabel.BackColor = Color.SeaShell;
            dateLabel.BorderStyle = BorderStyle.Fixed3D;
            dateLabel.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dateLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dateLabel.Location = new Point(173, 241);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(350, 31);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "N/A";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(16, 247);
            Label6.Name = "Label6";
            Label6.Size = new Size(176, 29);
            Label6.TabIndex = 9;
            Label6.Text = "Date of action:";
            // 
            // commentsRichTextBox
            // 
            commentsRichTextBox.BackColor = Color.SeaShell;
            commentsRichTextBox.Font = new Font("Microsoft Sans Serif", 14.25f);
            commentsRichTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            commentsRichTextBox.Location = new Point(129, 329);
            commentsRichTextBox.Name = "commentsRichTextBox";
            commentsRichTextBox.ReadOnly = true;
            commentsRichTextBox.Size = new Size(464, 115);
            commentsRichTextBox.TabIndex = 11;
            commentsRichTextBox.Text = "N/A";
            // 
            // addCommentsButton
            // 
            _addCommentsButton.Font = new Font("Microsoft Sans Serif", 14.25f);
            _addCommentsButton.Location = new Point(254, 465);
            _addCommentsButton.Name = "_addCommentsButton";
            _addCommentsButton.Size = new Size(172, 37);
            _addCommentsButton.TabIndex = 12;
            _addCommentsButton.Text = "Add notes";
            _addCommentsButton.UseVisualStyleBackColor = true;
            // 
            // FrmActionDetails
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(677, 529);
            ControlBox = false;
            Controls.Add(_addCommentsButton);
            Controls.Add(commentsRichTextBox);
            Controls.Add(dateLabel);
            Controls.Add(Label6);
            Controls.Add(actionTakenLabel);
            Controls.Add(byLabel);
            Controls.Add(_TouchButton1);
            Controls.Add(titleLabel);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmActionDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(FrmActionDetails_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private YardTabletControls.TouchButton _TouchButton1;

        internal YardTabletControls.TouchButton TouchButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TouchButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TouchButton1 != null)
                {
                    _TouchButton1.ButtonClick -= TouchButton1_Load;
                }

                _TouchButton1 = value;
                if (_TouchButton1 != null)
                {
                    _TouchButton1.ButtonClick += TouchButton1_Load;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label titleLabel;
        internal Label byLabel;
        internal Label actionTakenLabel;
        internal Label dateLabel;
        internal Label Label6;
        internal RichTextBox commentsRichTextBox;
        private Button _addCommentsButton;

        internal Button addCommentsButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addCommentsButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addCommentsButton != null)
                {
                    _addCommentsButton.Click -= addCommentsButton_Click;
                }

                _addCommentsButton = value;
                if (_addCommentsButton != null)
                {
                    _addCommentsButton.Click += addCommentsButton_Click;
                }
            }
        }
    }
}