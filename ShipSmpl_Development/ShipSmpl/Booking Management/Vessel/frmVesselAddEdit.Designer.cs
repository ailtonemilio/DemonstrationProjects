using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmVesselAddEdit : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVesselAddEdit));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(btnClose_Click);
            Label2 = new Label();
            lblTitleVessel = new Bunifu.UI.WinForms.BunifuLabel();
            TableLayoutPanel1 = new TableLayoutPanel();
            cboFlag = new ComboBox();
            CountryBindingSource = new BindingSource(components);
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            txtVesselOwner = new TextBox();
            BunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            _txtVesselName = new TextBox();
            _txtVesselName.KeyPress += new KeyPressEventHandler(txtVesselName_KeyPress);
            txtVesselManager = new TextBox();
            _txtVesselCapacity = new TextBox();
            _txtVesselCapacity.KeyPress += new KeyPressEventHandler(txtVesselCapacity_KeyPress);
            _txtVesselYear = new TextBox();
            _txtVesselYear.KeyPress += new KeyPressEventHandler(txtVesselYear_KeyPress);
            ckbActive = new CheckBox();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(756, 0);
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
            Label2.Size = new Size(800, 41);
            Label2.TabIndex = 204;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleVessel
            // 
            lblTitleVessel.AutoEllipsis = false;
            lblTitleVessel.CursorType = null;
            lblTitleVessel.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitleVessel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitleVessel.Location = new Point(12, 56);
            lblTitleVessel.Name = "lblTitleVessel";
            lblTitleVessel.RightToLeft = RightToLeft.No;
            lblTitleVessel.Size = new Size(110, 24);
            lblTitleVessel.TabIndex = 213;
            lblTitleVessel.Text = "Add Vessel:";
            lblTitleVessel.TextAlignment = ContentAlignment.TopLeft;
            lblTitleVessel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 5;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.30769f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.69231f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62.0f));
            TableLayoutPanel1.Controls.Add(cboFlag, 1, 3);
            TableLayoutPanel1.Controls.Add(BunifuLabel3, 0, 3);
            TableLayoutPanel1.Controls.Add(txtVesselOwner, 1, 1);
            TableLayoutPanel1.Controls.Add(BunifuLabel5, 0, 0);
            TableLayoutPanel1.Controls.Add(BunifuLabel1, 0, 1);
            TableLayoutPanel1.Controls.Add(BunifuLabel2, 2, 0);
            TableLayoutPanel1.Controls.Add(BunifuLabel6, 2, 1);
            TableLayoutPanel1.Controls.Add(BunifuLabel9, 0, 2);
            TableLayoutPanel1.Controls.Add(_txtVesselName, 1, 0);
            TableLayoutPanel1.Controls.Add(txtVesselManager, 1, 2);
            TableLayoutPanel1.Controls.Add(_txtVesselCapacity, 3, 0);
            TableLayoutPanel1.Controls.Add(_txtVesselYear, 3, 1);
            TableLayoutPanel1.Controls.Add(ckbActive, 3, 2);
            TableLayoutPanel1.Location = new Point(6, 110);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.Size = new Size(782, 160);
            TableLayoutPanel1.TabIndex = 214;
            // 
            // cboFlag
            // 
            cboFlag.Anchor = AnchorStyles.Left;
            cboFlag.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboFlag.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboFlag.DataSource = CountryBindingSource;
            cboFlag.DisplayMember = "CountryName";
            cboFlag.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboFlag.FormattingEnabled = true;
            cboFlag.Location = new Point(123, 126);
            cboFlag.Name = "cboFlag";
            cboFlag.Size = new Size(314, 28);
            cboFlag.TabIndex = 4;
            cboFlag.ValueMember = "Code";
            // 
            // CountryBindingSource
            // 
            CountryBindingSource.DataSource = typeof(ModelLayer.Country);
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.Anchor = AnchorStyles.Right;
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel3.Location = new Point(14, 129);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(103, 22);
            BunifuLabel3.TabIndex = 220;
            BunifuLabel3.Text = "Flag(Country):";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtVesselOwner
            // 
            txtVesselOwner.Anchor = AnchorStyles.Left;
            txtVesselOwner.CharacterCasing = CharacterCasing.Upper;
            txtVesselOwner.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtVesselOwner.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            txtVesselOwner.Location = new Point(123, 47);
            txtVesselOwner.MaxLength = 250;
            txtVesselOwner.MinimumSize = new Size(4, 30);
            txtVesselOwner.Name = "txtVesselOwner";
            txtVesselOwner.Size = new Size(314, 30);
            txtVesselOwner.TabIndex = 2;
            // 
            // BunifuLabel5
            // 
            BunifuLabel5.Anchor = AnchorStyles.Right;
            BunifuLabel5.AutoEllipsis = false;
            BunifuLabel5.CursorType = null;
            BunifuLabel5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel5.Location = new Point(16, 9);
            BunifuLabel5.Name = "BunifuLabel5";
            BunifuLabel5.RightToLeft = RightToLeft.No;
            BunifuLabel5.Size = new Size(101, 22);
            BunifuLabel5.TabIndex = 211;
            BunifuLabel5.Text = "Vessel Name:";
            BunifuLabel5.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.Anchor = AnchorStyles.Right;
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel1.Location = new Point(64, 49);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(53, 22);
            BunifuLabel1.TabIndex = 212;
            BunifuLabel1.Text = "Owner:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel2
            // 
            BunifuLabel2.Anchor = AnchorStyles.None;
            BunifuLabel2.AutoEllipsis = false;
            BunifuLabel2.CursorType = null;
            BunifuLabel2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel2.Location = new Point(450, 9);
            BunifuLabel2.Name = "BunifuLabel2";
            BunifuLabel2.RightToLeft = RightToLeft.No;
            BunifuLabel2.Size = new Size(68, 22);
            BunifuLabel2.TabIndex = 213;
            BunifuLabel2.Text = "Capacity:";
            BunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel6
            // 
            BunifuLabel6.Anchor = AnchorStyles.None;
            BunifuLabel6.AutoEllipsis = false;
            BunifuLabel6.CursorType = null;
            BunifuLabel6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel6.Location = new Point(463, 49);
            BunifuLabel6.Name = "BunifuLabel6";
            BunifuLabel6.RightToLeft = RightToLeft.No;
            BunifuLabel6.Size = new Size(41, 22);
            BunifuLabel6.TabIndex = 216;
            BunifuLabel6.Text = "Year:";
            BunifuLabel6.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel9
            // 
            BunifuLabel9.Anchor = AnchorStyles.Right;
            BunifuLabel9.AutoEllipsis = false;
            BunifuLabel9.CursorType = null;
            BunifuLabel9.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel9.Location = new Point(47, 89);
            BunifuLabel9.Name = "BunifuLabel9";
            BunifuLabel9.RightToLeft = RightToLeft.No;
            BunifuLabel9.Size = new Size(70, 22);
            BunifuLabel9.TabIndex = 219;
            BunifuLabel9.Text = "Manager:";
            BunifuLabel9.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtVesselName
            // 
            _txtVesselName.Anchor = AnchorStyles.Left;
            _txtVesselName.CharacterCasing = CharacterCasing.Upper;
            _txtVesselName.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVesselName.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtVesselName.Location = new Point(123, 7);
            _txtVesselName.MaxLength = 150;
            _txtVesselName.MinimumSize = new Size(4, 30);
            _txtVesselName.Name = "_txtVesselName";
            _txtVesselName.Size = new Size(314, 30);
            _txtVesselName.TabIndex = 1;
            // 
            // txtVesselManager
            // 
            txtVesselManager.Anchor = AnchorStyles.Left;
            txtVesselManager.CharacterCasing = CharacterCasing.Upper;
            txtVesselManager.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtVesselManager.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            txtVesselManager.Location = new Point(123, 87);
            txtVesselManager.MaxLength = 250;
            txtVesselManager.MinimumSize = new Size(4, 30);
            txtVesselManager.Name = "txtVesselManager";
            txtVesselManager.Size = new Size(314, 30);
            txtVesselManager.TabIndex = 3;
            // 
            // txtVesselCapacity
            // 
            _txtVesselCapacity.Anchor = AnchorStyles.Left;
            _txtVesselCapacity.CharacterCasing = CharacterCasing.Upper;
            _txtVesselCapacity.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVesselCapacity.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtVesselCapacity.Location = new Point(531, 7);
            _txtVesselCapacity.MaxLength = 50;
            _txtVesselCapacity.MinimumSize = new Size(4, 30);
            _txtVesselCapacity.Name = "_txtVesselCapacity";
            _txtVesselCapacity.Size = new Size(185, 30);
            _txtVesselCapacity.TabIndex = 5;
            // 
            // txtVesselYear
            // 
            _txtVesselYear.Anchor = AnchorStyles.Left;
            _txtVesselYear.CharacterCasing = CharacterCasing.Upper;
            _txtVesselYear.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVesselYear.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtVesselYear.Location = new Point(531, 47);
            _txtVesselYear.MaxLength = 4;
            _txtVesselYear.MinimumSize = new Size(4, 30);
            _txtVesselYear.Name = "_txtVesselYear";
            _txtVesselYear.Size = new Size(185, 30);
            _txtVesselYear.TabIndex = 6;
            // 
            // ckbActive
            // 
            ckbActive.Anchor = AnchorStyles.Left;
            ckbActive.AutoSize = true;
            ckbActive.Checked = true;
            ckbActive.CheckState = CheckState.Checked;
            ckbActive.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ckbActive.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ckbActive.Location = new Point(531, 88);
            ckbActive.Name = "ckbActive";
            ckbActive.Size = new Size(71, 24);
            ckbActive.TabIndex = 7;
            ckbActive.Text = "Active";
            ckbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.AnimationSpeed = 200;
            _btnSave.AutoGenerateColors = false;
            _btnSave.BackColor = Color.Transparent;
            _btnSave.BackColor1 = Color.Teal;
            _btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            _btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave.ButtonText = "Save";
            _btnSave.ButtonTextMarginLeft = 0;
            _btnSave.ColorContrastOnClick = 45;
            _btnSave.ColorContrastOnHover = 45;
            _btnSave.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges1;
            _btnSave.DialogResult = DialogResult.None;
            _btnSave.DisabledBorderColor = Color.Empty;
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSave.ForeColor = Color.White;
            _btnSave.IconLeftCursor = Cursors.Hand;
            _btnSave.IconMarginLeft = 11;
            _btnSave.IconPadding = 10;
            _btnSave.IconRightCursor = Cursors.Hand;
            _btnSave.IdleBorderColor = Color.Teal;
            _btnSave.IdleBorderRadius = 3;
            _btnSave.IdleBorderThickness = 1;
            _btnSave.IdleFillColor = Color.Teal;
            _btnSave.IdleIconLeftImage = null;
            _btnSave.IdleIconRightImage = null;
            _btnSave.IndicateFocus = true;
            _btnSave.Location = new Point(688, 304);
            _btnSave.Name = "_btnSave";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnSave.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties2;
            _btnSave.Size = new Size(100, 40);
            _btnSave.TabIndex = 8;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // frmVesselAddEdit
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 356);
            Controls.Add(_btnSave);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(lblTitleVessel);
            Controls.Add(_btnClose);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVesselAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVesselAddEdit";
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountryBindingSource).EndInit();
            Load += new EventHandler(frmVesselAddEdit_Load);
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
        internal Bunifu.UI.WinForms.BunifuLabel lblTitleVessel;
        internal TableLayoutPanel TableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSave;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave != null)
                {
                    _btnSave.Click -= btnSave_Click;
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                    _btnSave.Click += btnSave_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel5;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel6;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel9;
        internal CheckBox ckbActive;
        private TextBox _txtVesselName;

        internal TextBox txtVesselName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVesselName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVesselName != null)
                {
                    _txtVesselName.KeyPress -= txtVesselName_KeyPress;
                }

                _txtVesselName = value;
                if (_txtVesselName != null)
                {
                    _txtVesselName.KeyPress += txtVesselName_KeyPress;
                }
            }
        }

        internal TextBox txtVesselOwner;
        internal TextBox txtVesselManager;
        private TextBox _txtVesselYear;

        internal TextBox txtVesselYear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVesselYear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVesselYear != null)
                {
                    _txtVesselYear.KeyPress -= txtVesselYear_KeyPress;
                }

                _txtVesselYear = value;
                if (_txtVesselYear != null)
                {
                    _txtVesselYear.KeyPress += txtVesselYear_KeyPress;
                }
            }
        }

        private TextBox _txtVesselCapacity;

        internal TextBox txtVesselCapacity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVesselCapacity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVesselCapacity != null)
                {
                    _txtVesselCapacity.KeyPress -= txtVesselCapacity_KeyPress;
                }

                _txtVesselCapacity = value;
                if (_txtVesselCapacity != null)
                {
                    _txtVesselCapacity.KeyPress += txtVesselCapacity_KeyPress;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        internal ComboBox cboFlag;
        internal BindingSource CountryBindingSource;
    }
}