using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmVesselCSVUpdate : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVesselCSVUpdate));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(btnClose_Click);
            Label2 = new Label();
            _dgvVesselCSV = new DataGridView();
            _dgvVesselCSV.KeyDown += new KeyEventHandler(dgvVesselCSV_KeyDown);
            VesselName = new DataGridViewTextBoxColumn();
            Owner = new DataGridViewTextBoxColumn();
            Manager = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Flag = new DataGridViewTextBoxColumn();
            Active = new DataGridViewTextBoxColumn();
            TableLayoutPanel1 = new TableLayoutPanel();
            _btnClear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnClear.Click += new EventHandler(btnClear_Click);
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            Label5 = new Label();
            lblMessage = new Label();
            pnlMessage = new Panel();
            Label4 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            pnlMessageDefault = new Panel();
            Label9 = new Label();
            _lblClosePanel = new Label();
            _lblClosePanel.Click += new EventHandler(lblClosePanel_Click);
            Label7 = new Label();
            lbMessage = new ListBox();
            Label6 = new Label();
            Label10 = new Label();
            Panel1 = new Panel();
            Label8 = new Label();
            Label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)_dgvVesselCSV).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            pnlMessage.SuspendLayout();
            pnlMessageDefault.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(1159, 0);
            _btnClose.Margin = new Padding(0);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(40, 41);
            _btnClose.TabIndex = 207;
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
            Label2.Size = new Size(1200, 41);
            Label2.TabIndex = 206;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvVesselCSV
            // 
            _dgvVesselCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvVesselCSV.Columns.AddRange(new DataGridViewColumn[] { VesselName, Owner, Manager, Capacity, Year, Flag, Active });
            _dgvVesselCSV.EnableHeadersVisualStyles = false;
            _dgvVesselCSV.Location = new Point(12, 143);
            _dgvVesselCSV.Name = "_dgvVesselCSV";
            _dgvVesselCSV.Size = new Size(1180, 459);
            _dgvVesselCSV.TabIndex = 208;
            // 
            // VesselName
            // 
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            VesselName.DefaultCellStyle = DataGridViewCellStyle1;
            VesselName.HeaderText = "Vessel Name";
            VesselName.MinimumWidth = 250;
            VesselName.Name = "VesselName";
            VesselName.Width = 250;
            // 
            // Owner
            // 
            Owner.HeaderText = "Owner";
            Owner.MinimumWidth = 250;
            Owner.Name = "Owner";
            Owner.Width = 250;
            // 
            // Manager
            // 
            Manager.HeaderText = "Manager";
            Manager.MinimumWidth = 200;
            Manager.Name = "Manager";
            Manager.Width = 200;
            // 
            // Capacity
            // 
            Capacity.HeaderText = "Capacity";
            Capacity.MinimumWidth = 110;
            Capacity.Name = "Capacity";
            Capacity.Width = 110;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MaxInputLength = 4;
            Year.MinimumWidth = 100;
            Year.Name = "Year";
            // 
            // Flag
            // 
            Flag.HeaderText = "Flag";
            Flag.MaxInputLength = 50;
            Flag.MinimumWidth = 110;
            Flag.Name = "Flag";
            Flag.Width = 110;
            // 
            // Active
            // 
            Active.HeaderText = "Active";
            Active.MinimumWidth = 100;
            Active.Name = "Active";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.73643f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.79845f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.46511f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.Controls.Add(_btnClear, 3, 0);
            TableLayoutPanel1.Controls.Add(_btnSave, 2, 0);
            TableLayoutPanel1.Location = new Point(562, 608);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Size = new Size(626, 43);
            TableLayoutPanel1.TabIndex = 209;
            // 
            // btnClear
            // 
            _btnClear.AllowToggling = false;
            _btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClear.AnimationSpeed = 200;
            _btnClear.AutoGenerateColors = false;
            _btnClear.BackColor = Color.Transparent;
            _btnClear.BackColor1 = Color.IndianRed;
            _btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            _btnClear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnClear.ButtonText = "Clear Grid";
            _btnClear.ButtonTextMarginLeft = 0;
            _btnClear.ColorContrastOnClick = 45;
            _btnClear.ColorContrastOnHover = 45;
            _btnClear.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnClear.CustomizableEdges = BorderEdges1;
            _btnClear.DialogResult = DialogResult.None;
            _btnClear.DisabledBorderColor = Color.Empty;
            _btnClear.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnClear.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnClear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnClear.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClear.ForeColor = Color.White;
            _btnClear.IconLeftCursor = Cursors.Hand;
            _btnClear.IconMarginLeft = 11;
            _btnClear.IconPadding = 10;
            _btnClear.IconRightCursor = Cursors.Hand;
            _btnClear.IdleBorderColor = Color.IndianRed;
            _btnClear.IdleBorderRadius = 3;
            _btnClear.IdleBorderThickness = 1;
            _btnClear.IdleFillColor = Color.IndianRed;
            _btnClear.IdleIconLeftImage = null;
            _btnClear.IdleIconRightImage = null;
            _btnClear.IndicateFocus = true;
            _btnClear.Location = new Point(521, 3);
            _btnClear.Name = "_btnClear";
            StateProperties1.BorderColor = Color.Salmon;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Salmon;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnClear.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnClear.OnPressedState = StateProperties2;
            _btnClear.Size = new Size(102, 35);
            _btnClear.TabIndex = 78;
            _btnClear.TextAlign = ContentAlignment.MiddleCenter;
            _btnClear.TextMarginLeft = 0;
            _btnClear.UseDefaultRadiusAndThickness = true;
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnSave.AnimationSpeed = 200;
            _btnSave.AutoGenerateColors = false;
            _btnSave.BackColor = Color.Transparent;
            _btnSave.BackColor1 = Color.Teal;
            _btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            _btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave.ButtonText = "Sync and update";
            _btnSave.ButtonTextMarginLeft = 0;
            _btnSave.ColorContrastOnClick = 45;
            _btnSave.ColorContrastOnHover = 45;
            _btnSave.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges2;
            _btnSave.DialogResult = DialogResult.None;
            _btnSave.DisabledBorderColor = Color.Empty;
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
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
            _btnSave.Location = new Point(348, 3);
            _btnSave.Name = "_btnSave";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnSave.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties4;
            _btnSave.Size = new Size(149, 35);
            _btnSave.TabIndex = 77;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label5.Location = new Point(12, 53);
            Label5.Name = "Label5";
            Label5.Size = new Size(170, 25);
            Label5.TabIndex = 211;
            Label5.Text = "CSV Vessel Update";
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Left;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(3, 37);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(367, 15);
            lblMessage.TabIndex = 216;
            lblMessage.Text = "please check the data reported in the Grid and try again.";
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            pnlMessage.Controls.Add(Label4);
            pnlMessage.Controls.Add(Label3);
            pnlMessage.Controls.Add(Label1);
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Location = new Point(814, 44);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(371, 75);
            pnlMessage.TabIndex = 214;
            pnlMessage.Visible = false;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Left;
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.Red;
            Label4.Location = new Point(4, 56);
            Label4.Name = "Label4";
            Label4.Size = new Size(303, 15);
            Label4.TabIndex = 219;
            Label4.Text = "If the error persists, contact the IT department.";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Left;
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Red;
            Label3.Location = new Point(3, 21);
            Label3.Name = "Label3";
            Label3.Size = new Size(190, 15);
            Label3.TabIndex = 218;
            Label3.Text = "the lines that are in the Grid,";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Left;
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Red;
            Label1.Location = new Point(3, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(339, 15);
            Label1.TabIndex = 217;
            Label1.Text = "There was an error that cannot be synchronized and";
            // 
            // pnlMessageDefault
            // 
            pnlMessageDefault.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            pnlMessageDefault.Controls.Add(Label9);
            pnlMessageDefault.Controls.Add(_lblClosePanel);
            pnlMessageDefault.Controls.Add(Label7);
            pnlMessageDefault.Controls.Add(lbMessage);
            pnlMessageDefault.Location = new Point(285, 195);
            pnlMessageDefault.Name = "pnlMessageDefault";
            pnlMessageDefault.Size = new Size(621, 326);
            pnlMessageDefault.TabIndex = 224;
            pnlMessageDefault.Visible = false;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Left;
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.Red;
            Label9.Location = new Point(3, 42);
            Label9.Name = "Label9";
            Label9.Size = new Size(551, 17);
            Label9.TabIndex = 224;
            Label9.Text = "The red items need to be corrected. Attention to the header of the column.";
            // 
            // lblClosePanel
            // 
            _lblClosePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _lblClosePanel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _lblClosePanel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lblClosePanel.ForeColor = Color.White;
            _lblClosePanel.Location = new Point(592, -6);
            _lblClosePanel.Margin = new Padding(0);
            _lblClosePanel.Name = "_lblClosePanel";
            _lblClosePanel.Size = new Size(30, 32);
            _lblClosePanel.TabIndex = 224;
            _lblClosePanel.Text = "🗙";
            _lblClosePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.None;
            Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(0, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(621, 29);
            Label7.TabIndex = 224;
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMessage
            // 
            lbMessage.FormattingEnabled = true;
            lbMessage.Location = new Point(3, 70);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(615, 251);
            lbMessage.TabIndex = 0;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(3, 25);
            Label6.Name = "Label6";
            Label6.Size = new Size(567, 17);
            Label6.TabIndex = 225;
            Label6.Text = "Capacity field: Use Numbers (N,NNN.NN) or (NNN) or Empty field will equal 0";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(5, 72);
            Label10.Name = "Label10";
            Label10.Size = new Size(217, 17);
            Label10.TabIndex = 227;
            Label10.Text = "Field Active: TRUE or FALSE";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(Label14);
            Panel1.Controls.Add(Label10);
            Panel1.Controls.Add(Label6);
            Panel1.Location = new Point(215, 45);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(582, 92);
            Panel1.TabIndex = 233;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(3, 48);
            Label8.Name = "Label8";
            Label8.Size = new Size(433, 17);
            Label8.TabIndex = 228;
            Label8.Text = "Year field: Use Numbers (YYYY) or Empty field will equal 0";
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.Left;
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.Red;
            Label14.Location = new Point(3, 2);
            Label14.Name = "Label14";
            Label14.Size = new Size(543, 17);
            Label14.TabIndex = 217;
            Label14.Text = "For the synchronization to work correctly use the formatting for the fields:";
            // 
            // frmVesselCSVUpdate
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 659);
            Controls.Add(Panel1);
            Controls.Add(pnlMessageDefault);
            Controls.Add(pnlMessage);
            Controls.Add(Label5);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_dgvVesselCSV);
            Controls.Add(_btnClose);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVesselCSVUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVesselCSVUpdate";
            ((System.ComponentModel.ISupportInitialize)_dgvVesselCSV).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            pnlMessageDefault.ResumeLayout(false);
            pnlMessageDefault.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(frmVesselCSVUpdate_Load);
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
        private DataGridView _dgvVesselCSV;

        internal DataGridView dgvVesselCSV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvVesselCSV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvVesselCSV != null)
                {
                    _dgvVesselCSV.KeyDown -= dgvVesselCSV_KeyDown;
                }

                _dgvVesselCSV = value;
                if (_dgvVesselCSV != null)
                {
                    _dgvVesselCSV.KeyDown += dgvVesselCSV_KeyDown;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnClear;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClear != null)
                {
                    _btnClear.Click -= btnClear_Click;
                }

                _btnClear = value;
                if (_btnClear != null)
                {
                    _btnClear.Click += btnClear_Click;
                }
            }
        }

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

        internal Label Label5;
        internal DataGridViewTextBoxColumn VesselName;
        internal DataGridViewTextBoxColumn Owner;
        internal DataGridViewTextBoxColumn Manager;
        internal DataGridViewTextBoxColumn Capacity;
        internal DataGridViewTextBoxColumn Year;
        internal DataGridViewTextBoxColumn Flag;
        internal DataGridViewTextBoxColumn Active;
        internal Label lblMessage;
        internal Panel pnlMessage;
        internal Label Label4;
        internal Label Label3;
        internal Label Label1;
        internal Panel pnlMessageDefault;
        internal Label Label9;
        private Label _lblClosePanel;

        internal Label lblClosePanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblClosePanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblClosePanel != null)
                {
                    _lblClosePanel.Click -= lblClosePanel_Click;
                }

                _lblClosePanel = value;
                if (_lblClosePanel != null)
                {
                    _lblClosePanel.Click += lblClosePanel_Click;
                }
            }
        }

        internal Label Label7;
        internal ListBox lbMessage;
        internal Label Label6;
        internal Label Label10;
        internal Panel Panel1;
        internal Label Label8;
        internal Label Label14;
    }
}