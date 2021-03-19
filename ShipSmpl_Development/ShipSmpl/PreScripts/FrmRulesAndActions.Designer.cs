using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmRulesAndActions : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRulesAndActions));
            _rulesListView = new ListView();
            _rulesListView.Click += new EventHandler(ListView1_SelectedIndexChanged);
            _rulesListView.SelectedIndexChanged += new EventHandler(rulesListView_SelectedIndexChanged);
            titleLabel = new Label();
            _closeTouchButton = new YardTabletControls.TouchButton();
            _closeTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(TouchButton1_Load);
            _ruleAndActionTextBox = new TextBox();
            _ruleAndActionTextBox.TextChanged += new EventHandler(ruleTextBox_TextChanged);
            ruleActionLabel = new Label();
            subTitleLabel = new Label();
            MenuStrip1 = new MenuStrip();
            _CompanyToolStripMenuItem = new ToolStripMenuItem();
            _CompanyToolStripMenuItem.Click += new EventHandler(CompanyToolStripMenuItem_Click);
            _EditToolStripMenuItem = new ToolStripMenuItem();
            _EditToolStripMenuItem.Click += new EventHandler(EditToolStripMenuItem_Click);
            _DeleteToolStripMenuItem = new ToolStripMenuItem();
            _DeleteToolStripMenuItem.Click += new EventHandler(DeleteToolStripMenuItem_Click);
            _createUpdateTouchButton = new YardTabletControls.TouchButton();
            _createUpdateTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(createUpdateTouchButton_Load);
            availableTitlePictureBox = new PictureBox();
            MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableTitlePictureBox).BeginInit();
            SuspendLayout();
            // 
            // rulesListView
            // 
            _rulesListView.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _rulesListView.FullRowSelect = true;
            _rulesListView.GridLines = true;
            _rulesListView.HeaderStyle = ColumnHeaderStyle.None;
            _rulesListView.HideSelection = false;
            _rulesListView.Location = new Point(30, 163);
            _rulesListView.Name = "_rulesListView";
            _rulesListView.Size = new Size(462, 311);
            _rulesListView.TabIndex = 0;
            _rulesListView.UseCompatibleStateImageBehavior = false;
            _rulesListView.View = View.Details;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 24.21818f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(928, 67);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Manage Rules";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeTouchButton
            // 
            _closeTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _closeTouchButton.BevelWidth = Conversions.ToShort(2);
            _closeTouchButton.ButtonEnabled = true;
            _closeTouchButton.ButtonFontSize = Conversions.ToShort(28);
            _closeTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _closeTouchButton.Caption = "X";
            _closeTouchButton.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _closeTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeTouchButton.Location = new Point(862, 12);
            _closeTouchButton.Margin = new Padding(4, 3, 4, 3);
            _closeTouchButton.Name = "_closeTouchButton";
            _closeTouchButton.Size = new Size(51, 47);
            _closeTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _closeTouchButton.TabIndex = 3;
            _closeTouchButton.TextColour = Color.White;
            _closeTouchButton.TouchButtonColour = Color.Firebrick;
            _closeTouchButton.Value = false;
            // 
            // ruleAndActionTextBox
            // 
            _ruleAndActionTextBox.CharacterCasing = CharacterCasing.Upper;
            _ruleAndActionTextBox.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ruleAndActionTextBox.Location = new Point(536, 200);
            _ruleAndActionTextBox.MaxLength = 250;
            _ruleAndActionTextBox.Name = "_ruleAndActionTextBox";
            _ruleAndActionTextBox.Size = new Size(322, 28);
            _ruleAndActionTextBox.TabIndex = 4;
            // 
            // ruleActionLabel
            // 
            ruleActionLabel.AutoSize = true;
            ruleActionLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ruleActionLabel.Location = new Point(531, 172);
            ruleActionLabel.Name = "ruleActionLabel";
            ruleActionLabel.Size = new Size(108, 25);
            ruleActionLabel.TabIndex = 5;
            ruleActionLabel.Text = "Rule Name:";
            // 
            // subTitleLabel
            // 
            subTitleLabel.AutoSize = true;
            subTitleLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            subTitleLabel.Location = new Point(22, 81);
            subTitleLabel.Name = "subTitleLabel";
            subTitleLabel.Size = new Size(470, 25);
            subTitleLabel.TabIndex = 6;
            subTitleLabel.Text = "Select existing rule to edit, delete or create a new one";
            // 
            // MenuStrip1
            // 
            MenuStrip1.BackColor = Color.Transparent;
            MenuStrip1.Dock = DockStyle.None;
            MenuStrip1.GripMargin = new Padding(2);
            MenuStrip1.GripStyle = ToolStripGripStyle.Visible;
            MenuStrip1.ImageScalingSize = new Size(18, 18);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { _CompanyToolStripMenuItem, _EditToolStripMenuItem, _DeleteToolStripMenuItem });
            MenuStrip1.Location = new Point(27, 122);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Padding = new Padding(2);
            MenuStrip1.Size = new Size(443, 38);
            MenuStrip1.TabIndex = 33;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // CompanyToolStripMenuItem
            // 
            _CompanyToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _CompanyToolStripMenuItem.Image = (Image)resources.GetObject("CompanyToolStripMenuItem.Image");
            _CompanyToolStripMenuItem.Name = "_CompanyToolStripMenuItem";
            _CompanyToolStripMenuItem.Padding = new Padding(2, 2, 35, 2);
            _CompanyToolStripMenuItem.Size = new Size(115, 34);
            _CompanyToolStripMenuItem.Text = "New";
            // 
            // EditToolStripMenuItem
            // 
            _EditToolStripMenuItem.Enabled = false;
            _EditToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25f);
            _EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            _EditToolStripMenuItem.Name = "_EditToolStripMenuItem";
            _EditToolStripMenuItem.Padding = new Padding(2, 2, 70, 2);
            _EditToolStripMenuItem.Size = new Size(144, 34);
            _EditToolStripMenuItem.Text = "Edit";
            // 
            // DeleteToolStripMenuItem
            // 
            _DeleteToolStripMenuItem.Enabled = false;
            _DeleteToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25f);
            _DeleteToolStripMenuItem.Image = (Image)resources.GetObject("DeleteToolStripMenuItem.Image");
            _DeleteToolStripMenuItem.Name = "_DeleteToolStripMenuItem";
            _DeleteToolStripMenuItem.Padding = new Padding(2, 2, 70, 2);
            _DeleteToolStripMenuItem.Size = new Size(169, 34);
            _DeleteToolStripMenuItem.Text = "Delete";
            // 
            // createUpdateTouchButton
            // 
            _createUpdateTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _createUpdateTouchButton.BevelWidth = Conversions.ToShort(2);
            _createUpdateTouchButton.ButtonEnabled = true;
            _createUpdateTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _createUpdateTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _createUpdateTouchButton.Caption = "Create Rule";
            _createUpdateTouchButton.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _createUpdateTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createUpdateTouchButton.Location = new Point(631, 286);
            _createUpdateTouchButton.Margin = new Padding(4, 3, 4, 3);
            _createUpdateTouchButton.Name = "_createUpdateTouchButton";
            _createUpdateTouchButton.Size = new Size(157, 47);
            _createUpdateTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _createUpdateTouchButton.TabIndex = 34;
            _createUpdateTouchButton.TextColour = Color.White;
            _createUpdateTouchButton.TouchButtonColour = Color.Gray;
            _createUpdateTouchButton.Value = false;
            // 
            // availableTitlePictureBox
            // 
            availableTitlePictureBox.Location = new Point(863, 198);
            availableTitlePictureBox.Name = "availableTitlePictureBox";
            availableTitlePictureBox.Size = new Size(32, 31);
            availableTitlePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            availableTitlePictureBox.TabIndex = 40;
            availableTitlePictureBox.TabStop = false;
            availableTitlePictureBox.Visible = false;
            // 
            // FrmRulesAndActions
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(928, 519);
            ControlBox = false;
            Controls.Add(availableTitlePictureBox);
            Controls.Add(_createUpdateTouchButton);
            Controls.Add(MenuStrip1);
            Controls.Add(subTitleLabel);
            Controls.Add(ruleActionLabel);
            Controls.Add(_ruleAndActionTextBox);
            Controls.Add(_closeTouchButton);
            Controls.Add(titleLabel);
            Controls.Add(_rulesListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmRulesAndActions";
            StartPosition = FormStartPosition.CenterScreen;
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)availableTitlePictureBox).EndInit();
            Load += new EventHandler(FrmPreScriptRules_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private ListView _rulesListView;

        internal ListView rulesListView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rulesListView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rulesListView != null)
                {
                    _rulesListView.Click -= ListView1_SelectedIndexChanged;
                    _rulesListView.SelectedIndexChanged -= rulesListView_SelectedIndexChanged;
                }

                _rulesListView = value;
                if (_rulesListView != null)
                {
                    _rulesListView.Click += ListView1_SelectedIndexChanged;
                    _rulesListView.SelectedIndexChanged += rulesListView_SelectedIndexChanged;
                }
            }
        }

        internal Label titleLabel;
        private YardTabletControls.TouchButton _closeTouchButton;

        internal YardTabletControls.TouchButton closeTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeTouchButton != null)
                {
                    _closeTouchButton.ButtonClick -= TouchButton1_Load;
                }

                _closeTouchButton = value;
                if (_closeTouchButton != null)
                {
                    _closeTouchButton.ButtonClick += TouchButton1_Load;
                }
            }
        }

        private TextBox _ruleAndActionTextBox;

        internal TextBox ruleAndActionTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ruleAndActionTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ruleAndActionTextBox != null)
                {
                    _ruleAndActionTextBox.TextChanged -= ruleTextBox_TextChanged;
                }

                _ruleAndActionTextBox = value;
                if (_ruleAndActionTextBox != null)
                {
                    _ruleAndActionTextBox.TextChanged += ruleTextBox_TextChanged;
                }
            }
        }

        internal Label ruleActionLabel;
        internal Label subTitleLabel;
        internal MenuStrip MenuStrip1;
        private ToolStripMenuItem _CompanyToolStripMenuItem;

        internal ToolStripMenuItem CompanyToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CompanyToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CompanyToolStripMenuItem != null)
                {
                    _CompanyToolStripMenuItem.Click -= CompanyToolStripMenuItem_Click;
                }

                _CompanyToolStripMenuItem = value;
                if (_CompanyToolStripMenuItem != null)
                {
                    _CompanyToolStripMenuItem.Click += CompanyToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _EditToolStripMenuItem;

        internal ToolStripMenuItem EditToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EditToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EditToolStripMenuItem != null)
                {
                    _EditToolStripMenuItem.Click -= EditToolStripMenuItem_Click;
                }

                _EditToolStripMenuItem = value;
                if (_EditToolStripMenuItem != null)
                {
                    _EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _DeleteToolStripMenuItem;

        internal ToolStripMenuItem DeleteToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DeleteToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DeleteToolStripMenuItem != null)
                {
                    _DeleteToolStripMenuItem.Click -= DeleteToolStripMenuItem_Click;
                }

                _DeleteToolStripMenuItem = value;
                if (_DeleteToolStripMenuItem != null)
                {
                    _DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
                }
            }
        }

        private YardTabletControls.TouchButton _createUpdateTouchButton;

        internal YardTabletControls.TouchButton createUpdateTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createUpdateTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createUpdateTouchButton != null)
                {
                    _createUpdateTouchButton.ButtonClick -= createUpdateTouchButton_Load;
                }

                _createUpdateTouchButton = value;
                if (_createUpdateTouchButton != null)
                {
                    _createUpdateTouchButton.ButtonClick += createUpdateTouchButton_Load;
                }
            }
        }

        internal PictureBox availableTitlePictureBox;
    }
}