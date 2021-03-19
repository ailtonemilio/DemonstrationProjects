using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmReminderDetails : Form
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
            _ListView1 = new ListView();
            _ListView1.DoubleClick += new EventHandler(ListView1_SelectedIndexChanged);
            titleLabel = new Label();
            notificationTypeLabel = new Label();
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
            _TouchButton1.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _TouchButton1.Location = new Point(805, 8);
            _TouchButton1.Margin = new Padding(4, 3, 4, 3);
            _TouchButton1.Name = "_TouchButton1";
            _TouchButton1.Size = new Size(44, 39);
            _TouchButton1.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _TouchButton1.TabIndex = 0;
            _TouchButton1.TextColour = Color.White;
            _TouchButton1.TouchButtonColour = Color.Firebrick;
            _TouchButton1.Value = false;
            // 
            // ListView1
            // 
            _ListView1.BackColor = Color.WhiteSmoke;
            _ListView1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ListView1.FullRowSelect = true;
            _ListView1.HideSelection = false;
            _ListView1.Location = new Point(82, 190);
            _ListView1.MultiSelect = false;
            _ListView1.Name = "_ListView1";
            _ListView1.Size = new Size(688, 296);
            _ListView1.TabIndex = 1;
            _ListView1.UseCompatibleStateImageBehavior = false;
            _ListView1.View = View.Details;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.DarkSlateGray;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(860, 82);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Double click to see employee details";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notificationTypeLabel
            // 
            notificationTypeLabel.BackColor = Color.Transparent;
            notificationTypeLabel.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            notificationTypeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            notificationTypeLabel.Location = new Point(76, 131);
            notificationTypeLabel.Name = "notificationTypeLabel";
            notificationTypeLabel.Size = new Size(658, 56);
            notificationTypeLabel.TabIndex = 3;
            notificationTypeLabel.Text = "Double click to see employee details";
            notificationTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmProbationPeriodReminders
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(860, 593);
            ControlBox = false;
            Controls.Add(notificationTypeLabel);
            Controls.Add(_TouchButton1);
            Controls.Add(titleLabel);
            Controls.Add(_ListView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmProbationPeriodReminders";
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(FrmProbationPeriodReminders_Load);
            ResumeLayout(false);
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

        private ListView _ListView1;

        internal ListView ListView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListView1 != null)
                {
                    _ListView1.DoubleClick -= ListView1_SelectedIndexChanged;
                }

                _ListView1 = value;
                if (_ListView1 != null)
                {
                    _ListView1.DoubleClick += ListView1_SelectedIndexChanged;
                }
            }
        }

        internal Label titleLabel;
        internal Label notificationTypeLabel;
    }
}