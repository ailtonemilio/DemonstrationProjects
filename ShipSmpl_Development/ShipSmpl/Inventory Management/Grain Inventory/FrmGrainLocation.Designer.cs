﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmGrainLocation : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrainLocation));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            TableLayoutPanel6 = new TableLayoutPanel();
            Label21 = new Label();
            _cboStorageType = new ComboBox();
            _cboStorageType.SelectedIndexChanged += new EventHandler(cboLocationType_SelectedIndexChanged);
            Label23 = new Label();
            cboStorage = new ComboBox();
            Quantity = new Label();
            nudBagQty = new NumericUpDown();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            lblWarning = new Label();
            Label1 = new Label();
            _btnOk = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnOk.Click += new EventHandler(btnSave_Click);
            Label7 = new Label();
            TableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBagQty).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 2;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.90852f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.09148f));
            TableLayoutPanel6.Controls.Add(Label21, 0, 0);
            TableLayoutPanel6.Controls.Add(_cboStorageType, 1, 0);
            TableLayoutPanel6.Controls.Add(Label23, 0, 1);
            TableLayoutPanel6.Controls.Add(cboStorage, 1, 1);
            TableLayoutPanel6.Controls.Add(Quantity, 0, 2);
            TableLayoutPanel6.Controls.Add(nudBagQty, 1, 2);
            TableLayoutPanel6.Location = new Point(27, 82);
            TableLayoutPanel6.Margin = new Padding(2);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 3;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 30.0f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 18.0f));
            TableLayoutPanel6.Size = new Size(317, 103);
            TableLayoutPanel6.TabIndex = 202;
            // 
            // Label21
            // 
            Label21.Anchor = AnchorStyles.Right;
            Label21.AutoSize = true;
            Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.Location = new Point(13, 10);
            Label21.Margin = new Padding(2, 0, 2, 0);
            Label21.Name = "Label21";
            Label21.Size = new Size(102, 16);
            Label21.TabIndex = 6;
            Label21.Text = "* Storage Type:";
            // 
            // cboStorageType
            // 
            _cboStorageType.Anchor = AnchorStyles.Left;
            _cboStorageType.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboStorageType.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboStorageType.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboStorageType.FormattingEnabled = true;
            _cboStorageType.Items.AddRange(new object[] { "CONTAINER", "BAGGER" });
            _cboStorageType.Location = new Point(119, 5);
            _cboStorageType.Margin = new Padding(2);
            _cboStorageType.Name = "_cboStorageType";
            _cboStorageType.Size = new Size(150, 26);
            _cboStorageType.TabIndex = 177;
            // 
            // Label23
            // 
            Label23.Anchor = AnchorStyles.Right;
            Label23.AutoSize = true;
            Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.Location = new Point(48, 46);
            Label23.Margin = new Padding(2, 0, 2, 0);
            Label23.Name = "Label23";
            Label23.Size = new Size(67, 16);
            Label23.TabIndex = 176;
            Label23.Text = "* Storage:";
            // 
            // cboStorage
            // 
            cboStorage.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboStorage.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStorage.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboStorage.FormattingEnabled = true;
            cboStorage.Location = new Point(119, 38);
            cboStorage.Margin = new Padding(2);
            cboStorage.Name = "cboStorage";
            cboStorage.Size = new Size(159, 26);
            cboStorage.TabIndex = 7;
            // 
            // Quantity
            // 
            Quantity.Anchor = AnchorStyles.Right;
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Quantity.Location = new Point(51, 79);
            Quantity.Margin = new Padding(2, 0, 2, 0);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(64, 16);
            Quantity.TabIndex = 178;
            Quantity.Text = "* Quantity";
            // 
            // nudBagQty
            // 
            nudBagQty.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudBagQty.Location = new Point(119, 74);
            nudBagQty.Margin = new Padding(2);
            nudBagQty.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBagQty.Name = "nudBagQty";
            nudBagQty.Size = new Size(108, 26);
            nudBagQty.TabIndex = 179;
            nudBagQty.TextAlign = HorizontalAlignment.Center;
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Iconcolor = Color.Transparent;
            _closeFlatButton.Iconimage = null;
            _closeFlatButton.Iconimage_right = null;
            _closeFlatButton.Iconimage_right_Selected = null;
            _closeFlatButton.Iconimage_Selected = null;
            _closeFlatButton.IconMarginLeft = 0;
            _closeFlatButton.IconMarginRight = 0;
            _closeFlatButton.IconRightVisible = true;
            _closeFlatButton.IconRightZoom = 0d;
            _closeFlatButton.IconVisible = true;
            _closeFlatButton.IconZoom = 90.0d;
            _closeFlatButton.IsTab = false;
            _closeFlatButton.Location = new Point(333, 0);
            _closeFlatButton.Margin = new Padding(5, 6, 5, 6);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(41, 29);
            _closeFlatButton.TabIndex = 201;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label17
            // 
            Label17.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Dock = DockStyle.Top;
            Label17.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(0, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(374, 29);
            Label17.TabIndex = 200;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = AnchorStyles.Right;
            lblWarning.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(35, 71);
            lblWarning.Margin = new Padding(2, 0, 2, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(309, 16);
            lblWarning.TabIndex = 206;
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(35, 187);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(97, 13);
            Label1.TabIndex = 205;
            Label1.Text = "* : Mandatory fields";
            // 
            // btnOk
            // 
            _btnOk.AllowToggling = false;
            _btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnOk.AnimationSpeed = 200;
            _btnOk.AutoGenerateColors = false;
            _btnOk.BackColor = Color.Transparent;
            _btnOk.BackColor1 = Color.Teal;
            _btnOk.BackgroundImage = (Image)resources.GetObject("btnOk.BackgroundImage");
            _btnOk.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnOk.ButtonText = "Add Location";
            _btnOk.ButtonTextMarginLeft = 0;
            _btnOk.ColorContrastOnClick = 45;
            _btnOk.ColorContrastOnHover = 45;
            _btnOk.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnOk.CustomizableEdges = BorderEdges1;
            _btnOk.DialogResult = DialogResult.None;
            _btnOk.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnOk.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnOk.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnOk.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnOk.Font = new Font("Segoe UI Semibold", 11.0f);
            _btnOk.ForeColor = Color.White;
            _btnOk.IconLeftCursor = Cursors.Hand;
            _btnOk.IconMarginLeft = 11;
            _btnOk.IconPadding = 10;
            _btnOk.IconRightCursor = Cursors.Hand;
            _btnOk.IdleBorderColor = Color.Teal;
            _btnOk.IdleBorderRadius = 3;
            _btnOk.IdleBorderThickness = 1;
            _btnOk.IdleFillColor = Color.Teal;
            _btnOk.IdleIconLeftImage = null;
            _btnOk.IdleIconRightImage = null;
            _btnOk.IndicateFocus = false;
            _btnOk.Location = new Point(142, 219);
            _btnOk.Margin = new Padding(2);
            _btnOk.Name = "_btnOk";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnOk.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnOk.OnPressedState = StateProperties2;
            _btnOk.Size = new Size(103, 36);
            _btnOk.TabIndex = 204;
            _btnOk.TextAlign = ContentAlignment.MiddleCenter;
            _btnOk.TextMarginLeft = 0;
            _btnOk.UseDefaultRadiusAndThickness = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(9, 42);
            Label7.Margin = new Padding(2, 0, 2, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(261, 25);
            Label7.TabIndex = 203;
            Label7.Text = "Add Grain Inventory location";
            // 
            // FrmGrainLocation
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 266);
            Controls.Add(TableLayoutPanel6);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Controls.Add(lblWarning);
            Controls.Add(Label1);
            Controls.Add(_btnOk);
            Controls.Add(Label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGrainLocation";
            Text = "FrmGrainLocation";
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBagQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TableLayoutPanel TableLayoutPanel6;
        internal Label Quantity;
        internal Label Label23;
        internal Label Label21;
        private ComboBox _cboStorageType;

        internal ComboBox cboStorageType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboStorageType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboStorageType != null)
                {
                    _cboStorageType.SelectedIndexChanged -= cboLocationType_SelectedIndexChanged;
                }

                _cboStorageType = value;
                if (_cboStorageType != null)
                {
                    _cboStorageType.SelectedIndexChanged += cboLocationType_SelectedIndexChanged;
                }
            }
        }

        internal ComboBox cboStorage;
        internal NumericUpDown nudBagQty;
        private Bunifu.Framework.UI.BunifuFlatButton _closeFlatButton;

        internal Bunifu.Framework.UI.BunifuFlatButton closeFlatButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeFlatButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click -= closeFlatButton_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeFlatButton_Click;
                }
            }
        }

        internal Label Label17;
        internal Label lblWarning;
        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnOk;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOk
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOk;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOk != null)
                {
                    _btnOk.Click -= btnSave_Click;
                }

                _btnOk = value;
                if (_btnOk != null)
                {
                    _btnOk.Click += btnSave_Click;
                }
            }
        }

        internal Label Label7;
    }
}