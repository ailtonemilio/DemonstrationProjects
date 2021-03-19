using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmEditGrade : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditGrade));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label2 = new Label();
            txtGrade = new BunifuTextBox();
            txtGradeCode = new BunifuTextBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            _btnSaveGrade = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSaveGrade.Click += new EventHandler(btnSaveGrade_Click);
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(460, -1);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 38);
            _closeLabel.TabIndex = 152;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(500, 38);
            Label2.TabIndex = 151;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGrade
            // 
            txtGrade.AcceptsReturn = false;
            txtGrade.AcceptsTab = false;
            txtGrade.Anchor = AnchorStyles.Left;
            txtGrade.AnimationSpeed = 200;
            txtGrade.AutoCompleteMode = AutoCompleteMode.None;
            txtGrade.AutoCompleteSource = AutoCompleteSource.None;
            txtGrade.BackColor = Color.Transparent;
            txtGrade.BackgroundImage = (Image)resources.GetObject("txtGrade.BackgroundImage");
            txtGrade.BorderColorActive = Color.DodgerBlue;
            txtGrade.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtGrade.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtGrade.BorderColorIdle = Color.Silver;
            txtGrade.BorderRadius = 1;
            txtGrade.BorderThickness = 1;
            txtGrade.CharacterCasing = CharacterCasing.Upper;
            txtGrade.Cursor = Cursors.IBeam;
            txtGrade.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            txtGrade.DefaultText = "";
            txtGrade.FillColor = Color.White;
            txtGrade.ForeColor = Color.Black;
            txtGrade.HideSelection = true;
            txtGrade.IconLeft = null;
            txtGrade.IconLeftCursor = Cursors.IBeam;
            txtGrade.IconPadding = 10;
            txtGrade.IconRight = null;
            txtGrade.IconRightCursor = Cursors.IBeam;
            txtGrade.Lines = new string[0];
            txtGrade.Location = new Point(3, 45);
            txtGrade.MaxLength = 32767;
            txtGrade.MinimumSize = new Size(100, 30);
            txtGrade.Modified = false;
            txtGrade.Multiline = false;
            txtGrade.Name = "txtGrade";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            txtGrade.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            txtGrade.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            txtGrade.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Black;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            txtGrade.OnIdleState = StateProperties4;
            txtGrade.PasswordChar = '\0';
            txtGrade.PlaceholderForeColor = Color.Silver;
            txtGrade.PlaceholderText = "GRADE";
            txtGrade.ReadOnly = false;
            txtGrade.ScrollBars = ScrollBars.None;
            txtGrade.SelectedText = "";
            txtGrade.SelectionLength = 0;
            txtGrade.SelectionStart = 0;
            txtGrade.ShortcutsEnabled = true;
            txtGrade.Size = new Size(450, 30);
            txtGrade.Style = _Style.Bunifu;
            txtGrade.TabIndex = 245;
            txtGrade.TextAlign = HorizontalAlignment.Left;
            txtGrade.TextMarginBottom = 0;
            txtGrade.TextMarginLeft = 5;
            txtGrade.TextMarginTop = 0;
            txtGrade.TextPlaceholder = "GRADE";
            txtGrade.UseSystemPasswordChar = false;
            txtGrade.WordWrap = true;
            // 
            // txtGradeCode
            // 
            txtGradeCode.AcceptsReturn = false;
            txtGradeCode.AcceptsTab = false;
            txtGradeCode.Anchor = AnchorStyles.Left;
            txtGradeCode.AnimationSpeed = 200;
            txtGradeCode.AutoCompleteMode = AutoCompleteMode.None;
            txtGradeCode.AutoCompleteSource = AutoCompleteSource.None;
            txtGradeCode.BackColor = Color.Transparent;
            txtGradeCode.BackgroundImage = (Image)resources.GetObject("txtGradeCode.BackgroundImage");
            txtGradeCode.BorderColorActive = Color.DodgerBlue;
            txtGradeCode.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtGradeCode.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtGradeCode.BorderColorIdle = Color.Silver;
            txtGradeCode.BorderRadius = 1;
            txtGradeCode.BorderThickness = 1;
            txtGradeCode.CharacterCasing = CharacterCasing.Upper;
            txtGradeCode.Cursor = Cursors.IBeam;
            txtGradeCode.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            txtGradeCode.DefaultText = "";
            txtGradeCode.FillColor = Color.White;
            txtGradeCode.ForeColor = Color.Black;
            txtGradeCode.HideSelection = true;
            txtGradeCode.IconLeft = null;
            txtGradeCode.IconLeftCursor = Cursors.IBeam;
            txtGradeCode.IconPadding = 10;
            txtGradeCode.IconRight = null;
            txtGradeCode.IconRightCursor = Cursors.IBeam;
            txtGradeCode.Lines = new string[0];
            txtGradeCode.Location = new Point(3, 5);
            txtGradeCode.MaxLength = 32767;
            txtGradeCode.MinimumSize = new Size(100, 30);
            txtGradeCode.Modified = false;
            txtGradeCode.Multiline = false;
            txtGradeCode.Name = "txtGradeCode";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            txtGradeCode.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            txtGradeCode.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            txtGradeCode.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Black;
            StateProperties8.PlaceholderForeColor = Color.Empty;
            txtGradeCode.OnIdleState = StateProperties8;
            txtGradeCode.PasswordChar = '\0';
            txtGradeCode.PlaceholderForeColor = Color.Silver;
            txtGradeCode.PlaceholderText = "CODE";
            txtGradeCode.ReadOnly = false;
            txtGradeCode.ScrollBars = ScrollBars.None;
            txtGradeCode.SelectedText = "";
            txtGradeCode.SelectionLength = 0;
            txtGradeCode.SelectionStart = 0;
            txtGradeCode.ShortcutsEnabled = true;
            txtGradeCode.Size = new Size(114, 30);
            txtGradeCode.Style = _Style.Bunifu;
            txtGradeCode.TabIndex = 244;
            txtGradeCode.TextAlign = HorizontalAlignment.Left;
            txtGradeCode.TextMarginBottom = 0;
            txtGradeCode.TextMarginLeft = 5;
            txtGradeCode.TextMarginTop = 0;
            txtGradeCode.TextPlaceholder = "CODE";
            txtGradeCode.UseSystemPasswordChar = false;
            txtGradeCode.WordWrap = true;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(txtGradeCode, 0, 0);
            TableLayoutPanel1.Controls.Add(txtGrade, 0, 1);
            TableLayoutPanel1.Controls.Add(_btnSaveGrade, 0, 3);
            TableLayoutPanel1.Location = new Point(20, 111);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.Size = new Size(459, 160);
            TableLayoutPanel1.TabIndex = 246;
            // 
            // btnSaveGrade
            // 
            _btnSaveGrade.AllowToggling = false;
            _btnSaveGrade.Anchor = AnchorStyles.Right;
            _btnSaveGrade.AnimationSpeed = 200;
            _btnSaveGrade.AutoGenerateColors = false;
            _btnSaveGrade.BackColor = Color.Transparent;
            _btnSaveGrade.BackColor1 = Color.Teal;
            _btnSaveGrade.BackgroundImage = (Image)resources.GetObject("btnSaveGrade.BackgroundImage");
            _btnSaveGrade.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSaveGrade.ButtonText = "Save";
            _btnSaveGrade.ButtonTextMarginLeft = 0;
            _btnSaveGrade.ColorContrastOnClick = 45;
            _btnSaveGrade.ColorContrastOnHover = 45;
            _btnSaveGrade.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnSaveGrade.CustomizableEdges = BorderEdges1;
            _btnSaveGrade.DialogResult = DialogResult.None;
            _btnSaveGrade.DisabledBorderColor = Color.Empty;
            _btnSaveGrade.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSaveGrade.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSaveGrade.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSaveGrade.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSaveGrade.ForeColor = Color.White;
            _btnSaveGrade.IconLeftCursor = Cursors.Hand;
            _btnSaveGrade.IconMarginLeft = 11;
            _btnSaveGrade.IconPadding = 10;
            _btnSaveGrade.IconRightCursor = Cursors.Hand;
            _btnSaveGrade.IdleBorderColor = Color.Teal;
            _btnSaveGrade.IdleBorderRadius = 3;
            _btnSaveGrade.IdleBorderThickness = 1;
            _btnSaveGrade.IdleFillColor = Color.Teal;
            _btnSaveGrade.IdleIconLeftImage = null;
            _btnSaveGrade.IdleIconRightImage = null;
            _btnSaveGrade.IndicateFocus = true;
            _btnSaveGrade.Location = new Point(376, 123);
            _btnSaveGrade.Name = "_btnSaveGrade";
            StateProperties9.BorderColor = Color.LightSeaGreen;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.LightSeaGreen;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnSaveGrade.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnSaveGrade.OnPressedState = StateProperties10;
            _btnSaveGrade.Size = new Size(80, 33);
            _btnSaveGrade.TabIndex = 248;
            _btnSaveGrade.TextAlign = ContentAlignment.MiddleCenter;
            _btnSaveGrade.TextMarginLeft = 0;
            _btnSaveGrade.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.Anchor = AnchorStyles.Top;
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(24, 64);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(120, 26);
            BunifuLabel7.TabIndex = 247;
            BunifuLabel7.Text = "Update Grade";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmEditGrade
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 300);
            Controls.Add(BunifuLabel7);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditGrade";
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(frmEditGrade_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label _closeLabel;

        internal Label closeLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeLabel != null)
                {
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label2;
        internal BunifuTextBox txtGrade;
        internal BunifuTextBox txtGradeCode;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSaveGrade;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveGrade != null)
                {
                    _btnSaveGrade.Click -= btnSaveGrade_Click;
                }

                _btnSaveGrade = value;
                if (_btnSaveGrade != null)
                {
                    _btnSaveGrade.Click += btnSaveGrade_Click;
                }
            }
        }
    }
}