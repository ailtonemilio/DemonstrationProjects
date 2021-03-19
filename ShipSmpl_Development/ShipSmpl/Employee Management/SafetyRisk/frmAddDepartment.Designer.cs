using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmAddDepartment : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDepartment));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(btnClose_Click);
            Label2 = new Label();
            txtDocumentType = new BunifuTextBox();
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            _btnInsert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnInsert.Click += new EventHandler(btnInsert_Click);
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            SuspendLayout();
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(563, 0);
            _btnClose.Margin = new Padding(0);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(40, 41);
            _btnClose.TabIndex = 205;
            _btnClose.Text = "🗙";
            _btnClose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(603, 41);
            Label2.TabIndex = 204;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDocumentType
            // 
            txtDocumentType.AcceptsReturn = false;
            txtDocumentType.AcceptsTab = false;
            txtDocumentType.AnimationSpeed = 200;
            txtDocumentType.AutoCompleteMode = AutoCompleteMode.None;
            txtDocumentType.AutoCompleteSource = AutoCompleteSource.None;
            txtDocumentType.BackColor = Color.Transparent;
            txtDocumentType.BackgroundImage = (Image)resources.GetObject("txtDocumentType.BackgroundImage");
            txtDocumentType.BorderColorActive = Color.DodgerBlue;
            txtDocumentType.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtDocumentType.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtDocumentType.BorderColorIdle = Color.Silver;
            txtDocumentType.BorderRadius = 1;
            txtDocumentType.BorderThickness = 1;
            txtDocumentType.CharacterCasing = CharacterCasing.Upper;
            txtDocumentType.Cursor = Cursors.IBeam;
            txtDocumentType.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            txtDocumentType.DefaultText = "";
            txtDocumentType.FillColor = Color.White;
            txtDocumentType.HideSelection = true;
            txtDocumentType.IconLeft = null;
            txtDocumentType.IconLeftCursor = Cursors.IBeam;
            txtDocumentType.IconPadding = 10;
            txtDocumentType.IconRight = null;
            txtDocumentType.IconRightCursor = Cursors.IBeam;
            txtDocumentType.Lines = new string[0];
            txtDocumentType.Location = new Point(130, 97);
            txtDocumentType.MaxLength = 32767;
            txtDocumentType.MinimumSize = new Size(100, 35);
            txtDocumentType.Modified = false;
            txtDocumentType.Multiline = false;
            txtDocumentType.Name = "txtDocumentType";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            txtDocumentType.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            txtDocumentType.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            txtDocumentType.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            txtDocumentType.OnIdleState = StateProperties4;
            txtDocumentType.PasswordChar = '\0';
            txtDocumentType.PlaceholderForeColor = Color.Silver;
            txtDocumentType.PlaceholderText = "ENTER TEXT";
            txtDocumentType.ReadOnly = false;
            txtDocumentType.ScrollBars = ScrollBars.None;
            txtDocumentType.SelectedText = "";
            txtDocumentType.SelectionLength = 0;
            txtDocumentType.SelectionStart = 0;
            txtDocumentType.ShortcutsEnabled = true;
            txtDocumentType.Size = new Size(451, 35);
            txtDocumentType.Style = _Style.Bunifu;
            txtDocumentType.TabIndex = 207;
            txtDocumentType.TextAlign = HorizontalAlignment.Left;
            txtDocumentType.TextMarginBottom = 0;
            txtDocumentType.TextMarginLeft = 5;
            txtDocumentType.TextMarginTop = 0;
            txtDocumentType.TextPlaceholder = "ENTER TEXT";
            txtDocumentType.UseSystemPasswordChar = false;
            txtDocumentType.WordWrap = true;
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.Location = new Point(26, 104);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(92, 22);
            BunifuLabel3.TabIndex = 206;
            BunifuLabel3.Text = "Department:";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnInsert
            // 
            _btnInsert.AllowToggling = false;
            _btnInsert.AnimationSpeed = 200;
            _btnInsert.AutoGenerateColors = false;
            _btnInsert.BackColor = Color.Transparent;
            _btnInsert.BackColor1 = Color.Teal;
            _btnInsert.BackgroundImage = (Image)resources.GetObject("btnInsert.BackgroundImage");
            _btnInsert.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnInsert.ButtonText = "Insert";
            _btnInsert.ButtonTextMarginLeft = 0;
            _btnInsert.ColorContrastOnClick = 45;
            _btnInsert.ColorContrastOnHover = 45;
            _btnInsert.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnInsert.CustomizableEdges = BorderEdges1;
            _btnInsert.DialogResult = DialogResult.None;
            _btnInsert.DisabledBorderColor = Color.Empty;
            _btnInsert.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnInsert.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnInsert.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnInsert.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnInsert.ForeColor = Color.White;
            _btnInsert.IconLeftCursor = Cursors.Hand;
            _btnInsert.IconMarginLeft = 11;
            _btnInsert.IconPadding = 10;
            _btnInsert.IconRightCursor = Cursors.Hand;
            _btnInsert.IdleBorderColor = Color.Teal;
            _btnInsert.IdleBorderRadius = 3;
            _btnInsert.IdleBorderThickness = 1;
            _btnInsert.IdleFillColor = Color.Teal;
            _btnInsert.IdleIconLeftImage = null;
            _btnInsert.IdleIconRightImage = null;
            _btnInsert.IndicateFocus = true;
            _btnInsert.Location = new Point(480, 137);
            _btnInsert.Name = "_btnInsert";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnInsert.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnInsert.OnPressedState = StateProperties6;
            _btnInsert.Size = new Size(100, 40);
            _btnInsert.TabIndex = 208;
            _btnInsert.TextAlign = ContentAlignment.MiddleCenter;
            _btnInsert.TextMarginLeft = 0;
            _btnInsert.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel1.Location = new Point(26, 58);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(150, 24);
            BunifuLabel1.TabIndex = 209;
            BunifuLabel1.Text = "Add department:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmAddDepartment
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(603, 198);
            Controls.Add(BunifuLabel1);
            Controls.Add(_btnInsert);
            Controls.Add(txtDocumentType);
            Controls.Add(BunifuLabel3);
            Controls.Add(_btnClose);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddDepartment";
            Text = "frmAddDepartment";
            Load += new EventHandler(frmAddDepartment_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label _btnClose;

        internal Label btnClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClose != null)
                {
                    _btnClose.Click -= btnClose_Click;
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += btnClose_Click;
                }
            }
        }

        internal Label Label2;
        internal BunifuTextBox txtDocumentType;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnInsert;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnInsert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnInsert != null)
                {
                    _btnInsert.Click -= btnInsert_Click;
                }

                _btnInsert = value;
                if (_btnInsert != null)
                {
                    _btnInsert.Click += btnInsert_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
    }
}