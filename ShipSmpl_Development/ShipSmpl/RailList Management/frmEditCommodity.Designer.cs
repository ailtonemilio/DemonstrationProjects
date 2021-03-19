using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmEditCommodity : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCommodity));
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
            txtCommodity = new BunifuTextBox();
            txtCommodityCode = new BunifuTextBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            _btnEditCommodity = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnEditCommodity.Click += new EventHandler(btnEditCommodity_Click);
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
            _closeLabel.Location = new Point(463, -3);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 38);
            _closeLabel.TabIndex = 150;
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
            Label2.Size = new Size(503, 38);
            Label2.TabIndex = 149;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCommodity
            // 
            txtCommodity.AcceptsReturn = false;
            txtCommodity.AcceptsTab = false;
            txtCommodity.Anchor = AnchorStyles.Left;
            txtCommodity.AnimationSpeed = 200;
            txtCommodity.AutoCompleteMode = AutoCompleteMode.None;
            txtCommodity.AutoCompleteSource = AutoCompleteSource.None;
            txtCommodity.BackColor = Color.Transparent;
            txtCommodity.BackgroundImage = (Image)resources.GetObject("txtCommodity.BackgroundImage");
            txtCommodity.BorderColorActive = Color.DodgerBlue;
            txtCommodity.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtCommodity.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtCommodity.BorderColorIdle = Color.Silver;
            txtCommodity.BorderRadius = 1;
            txtCommodity.BorderThickness = 1;
            txtCommodity.CharacterCasing = CharacterCasing.Upper;
            txtCommodity.Cursor = Cursors.IBeam;
            txtCommodity.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            txtCommodity.DefaultText = "";
            txtCommodity.FillColor = Color.White;
            txtCommodity.ForeColor = Color.Black;
            txtCommodity.HideSelection = true;
            txtCommodity.IconLeft = null;
            txtCommodity.IconLeftCursor = Cursors.IBeam;
            txtCommodity.IconPadding = 10;
            txtCommodity.IconRight = null;
            txtCommodity.IconRightCursor = Cursors.IBeam;
            txtCommodity.Lines = new string[0];
            txtCommodity.Location = new Point(3, 45);
            txtCommodity.MaxLength = 32767;
            txtCommodity.MinimumSize = new Size(100, 30);
            txtCommodity.Modified = false;
            txtCommodity.Multiline = false;
            txtCommodity.Name = "txtCommodity";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            txtCommodity.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            txtCommodity.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            txtCommodity.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Black;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            txtCommodity.OnIdleState = StateProperties4;
            txtCommodity.PasswordChar = '\0';
            txtCommodity.PlaceholderForeColor = Color.Silver;
            txtCommodity.PlaceholderText = "COMMODITY";
            txtCommodity.ReadOnly = false;
            txtCommodity.ScrollBars = ScrollBars.None;
            txtCommodity.SelectedText = "";
            txtCommodity.SelectionLength = 0;
            txtCommodity.SelectionStart = 0;
            txtCommodity.ShortcutsEnabled = true;
            txtCommodity.Size = new Size(450, 30);
            txtCommodity.Style = _Style.Bunifu;
            txtCommodity.TabIndex = 244;
            txtCommodity.TextAlign = HorizontalAlignment.Left;
            txtCommodity.TextMarginBottom = 0;
            txtCommodity.TextMarginLeft = 5;
            txtCommodity.TextMarginTop = 0;
            txtCommodity.TextPlaceholder = "COMMODITY";
            txtCommodity.UseSystemPasswordChar = false;
            txtCommodity.WordWrap = true;
            // 
            // txtCommodityCode
            // 
            txtCommodityCode.AcceptsReturn = false;
            txtCommodityCode.AcceptsTab = false;
            txtCommodityCode.Anchor = AnchorStyles.Left;
            txtCommodityCode.AnimationSpeed = 200;
            txtCommodityCode.AutoCompleteMode = AutoCompleteMode.None;
            txtCommodityCode.AutoCompleteSource = AutoCompleteSource.None;
            txtCommodityCode.BackColor = Color.Transparent;
            txtCommodityCode.BackgroundImage = (Image)resources.GetObject("txtCommodityCode.BackgroundImage");
            txtCommodityCode.BorderColorActive = Color.DodgerBlue;
            txtCommodityCode.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtCommodityCode.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtCommodityCode.BorderColorIdle = Color.Silver;
            txtCommodityCode.BorderRadius = 1;
            txtCommodityCode.BorderThickness = 1;
            txtCommodityCode.CharacterCasing = CharacterCasing.Upper;
            txtCommodityCode.Cursor = Cursors.IBeam;
            txtCommodityCode.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            txtCommodityCode.DefaultText = "";
            txtCommodityCode.FillColor = Color.White;
            txtCommodityCode.ForeColor = Color.Black;
            txtCommodityCode.HideSelection = true;
            txtCommodityCode.IconLeft = null;
            txtCommodityCode.IconLeftCursor = Cursors.IBeam;
            txtCommodityCode.IconPadding = 10;
            txtCommodityCode.IconRight = null;
            txtCommodityCode.IconRightCursor = Cursors.IBeam;
            txtCommodityCode.Lines = new string[0];
            txtCommodityCode.Location = new Point(3, 5);
            txtCommodityCode.MaxLength = 32767;
            txtCommodityCode.MinimumSize = new Size(100, 30);
            txtCommodityCode.Modified = false;
            txtCommodityCode.Multiline = false;
            txtCommodityCode.Name = "txtCommodityCode";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            txtCommodityCode.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            txtCommodityCode.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            txtCommodityCode.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Black;
            StateProperties8.PlaceholderForeColor = Color.Empty;
            txtCommodityCode.OnIdleState = StateProperties8;
            txtCommodityCode.PasswordChar = '\0';
            txtCommodityCode.PlaceholderForeColor = Color.Silver;
            txtCommodityCode.PlaceholderText = "CODE";
            txtCommodityCode.ReadOnly = false;
            txtCommodityCode.ScrollBars = ScrollBars.None;
            txtCommodityCode.SelectedText = "";
            txtCommodityCode.SelectionLength = 0;
            txtCommodityCode.SelectionStart = 0;
            txtCommodityCode.ShortcutsEnabled = true;
            txtCommodityCode.Size = new Size(114, 30);
            txtCommodityCode.Style = _Style.Bunifu;
            txtCommodityCode.TabIndex = 243;
            txtCommodityCode.TextAlign = HorizontalAlignment.Left;
            txtCommodityCode.TextMarginBottom = 0;
            txtCommodityCode.TextMarginLeft = 5;
            txtCommodityCode.TextMarginTop = 0;
            txtCommodityCode.TextPlaceholder = "CODE";
            txtCommodityCode.UseSystemPasswordChar = false;
            txtCommodityCode.WordWrap = true;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(txtCommodityCode, 0, 0);
            TableLayoutPanel1.Controls.Add(_btnEditCommodity, 0, 3);
            TableLayoutPanel1.Controls.Add(txtCommodity, 0, 1);
            TableLayoutPanel1.Location = new Point(20, 105);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.Size = new Size(464, 160);
            TableLayoutPanel1.TabIndex = 247;
            // 
            // btnEditCommodity
            // 
            _btnEditCommodity.AllowToggling = false;
            _btnEditCommodity.Anchor = AnchorStyles.Right;
            _btnEditCommodity.AnimationSpeed = 200;
            _btnEditCommodity.AutoGenerateColors = false;
            _btnEditCommodity.BackColor = Color.Transparent;
            _btnEditCommodity.BackColor1 = Color.Teal;
            _btnEditCommodity.BackgroundImage = (Image)resources.GetObject("btnEditCommodity.BackgroundImage");
            _btnEditCommodity.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnEditCommodity.ButtonText = "Save";
            _btnEditCommodity.ButtonTextMarginLeft = 0;
            _btnEditCommodity.ColorContrastOnClick = 45;
            _btnEditCommodity.ColorContrastOnHover = 45;
            _btnEditCommodity.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnEditCommodity.CustomizableEdges = BorderEdges1;
            _btnEditCommodity.DialogResult = DialogResult.None;
            _btnEditCommodity.DisabledBorderColor = Color.Empty;
            _btnEditCommodity.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnEditCommodity.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnEditCommodity.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnEditCommodity.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnEditCommodity.ForeColor = Color.White;
            _btnEditCommodity.IconLeftCursor = Cursors.Hand;
            _btnEditCommodity.IconMarginLeft = 11;
            _btnEditCommodity.IconPadding = 10;
            _btnEditCommodity.IconRightCursor = Cursors.Hand;
            _btnEditCommodity.IdleBorderColor = Color.Teal;
            _btnEditCommodity.IdleBorderRadius = 3;
            _btnEditCommodity.IdleBorderThickness = 1;
            _btnEditCommodity.IdleFillColor = Color.Teal;
            _btnEditCommodity.IdleIconLeftImage = null;
            _btnEditCommodity.IdleIconRightImage = null;
            _btnEditCommodity.IndicateFocus = true;
            _btnEditCommodity.Location = new Point(381, 123);
            _btnEditCommodity.Name = "_btnEditCommodity";
            StateProperties9.BorderColor = Color.LightSeaGreen;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.LightSeaGreen;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnEditCommodity.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnEditCommodity.OnPressedState = StateProperties10;
            _btnEditCommodity.Size = new Size(80, 33);
            _btnEditCommodity.TabIndex = 249;
            _btnEditCommodity.TextAlign = ContentAlignment.MiddleCenter;
            _btnEditCommodity.TextMarginLeft = 0;
            _btnEditCommodity.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.Anchor = AnchorStyles.Top;
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(22, 61);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(163, 26);
            BunifuLabel7.TabIndex = 248;
            BunifuLabel7.Text = "Update Commodity";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmEditCommodity
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(503, 300);
            Controls.Add(BunifuLabel7);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditCommodity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditCommodity";
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(frmEditCommodity_Load);
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
        internal BunifuTextBox txtCommodity;
        internal BunifuTextBox txtCommodityCode;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnEditCommodity;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditCommodity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEditCommodity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnEditCommodity != null)
                {
                    _btnEditCommodity.Click -= btnEditCommodity_Click;
                }

                _btnEditCommodity = value;
                if (_btnEditCommodity != null)
                {
                    _btnEditCommodity.Click += btnEditCommodity_Click;
                }
            }
        }
    }
}