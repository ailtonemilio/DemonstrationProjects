using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmVesselVoyageCSVUpdateType : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVesselVoyageCSVUpdateType));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(btnClose_Click);
            Label2 = new Label();
            pnlMessage = new Panel();
            Label4 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            lblMessage = new Label();
            Label5 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            _btnClear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnClear.Click += new EventHandler(btnClear_Click);
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            _dgvVesselVoyageCSV = new DataGridView();
            _dgvVesselVoyageCSV.KeyDown += new KeyEventHandler(dgvVesselVoyageCSV_KeyDown);
            Line = new DataGridViewTextBoxColumn();
            VoyageNumber = new DataGridViewTextBoxColumn();
            Vessel = new DataGridViewTextBoxColumn();
            ERD = new DataGridViewTextBoxColumn();
            LRD = new DataGridViewTextBoxColumn();
            ETA = new DataGridViewTextBoxColumn();
            ETD = new DataGridViewTextBoxColumn();
            PortName = new DataGridViewTextBoxColumn();
            VoyageStatus = new DataGridViewTextBoxColumn();
            Active = new DataGridViewTextBoxColumn();
            pnlMessageDefault = new Panel();
            _btnSave_2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave_2.Click += new EventHandler(btnSave_2_Click);
            _ckbUpdateVoyage = new CheckBox();
            _ckbUpdateVoyage.Click += new EventHandler(ckbUpdateVoyage_Click);
            Label9 = new Label();
            _lblClosePanel = new Label();
            _lblClosePanel.Click += new EventHandler(lblClosePanel_Click);
            Label7 = new Label();
            lbMessage = new ListBox();
            pnlActions = new Panel();
            Label10 = new Label();
            Label12 = new Label();
            lblUpdated = new Label();
            lblInserted = new Label();
            lblActionsSummary = new Label();
            Label11 = new Label();
            Label8 = new Label();
            Panel1 = new Panel();
            Label17 = new Label();
            Label16 = new Label();
            Label15 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            pnlSynchronizingData = new Panel();
            TableLayoutPanel2 = new TableLayoutPanel();
            ProgressBar1 = new ProgressBar();
            Label6 = new Label();
            pnlMessage.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvVesselVoyageCSV).BeginInit();
            pnlMessageDefault.SuspendLayout();
            pnlActions.SuspendLayout();
            Panel1.SuspendLayout();
            pnlSynchronizingData.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(1460, 0);
            _btnClose.Margin = new Padding(0);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(53, 50);
            _btnClose.TabIndex = 209;
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
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(1513, 50);
            Label2.TabIndex = 208;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            pnlMessage.Controls.Add(Label4);
            pnlMessage.Controls.Add(Label3);
            pnlMessage.Controls.Add(Label1);
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Location = new Point(995, 127);
            pnlMessage.Margin = new Padding(4);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(495, 92);
            pnlMessage.TabIndex = 217;
            pnlMessage.Visible = false;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Left;
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.Red;
            Label4.Location = new Point(5, 69);
            Label4.Margin = new Padding(4, 0, 4, 0);
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
            Label3.Location = new Point(4, 26);
            Label3.Margin = new Padding(4, 0, 4, 0);
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
            Label1.Location = new Point(4, 5);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(339, 15);
            Label1.TabIndex = 217;
            Label1.Text = "There was an error that cannot be synchronized and";
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Left;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(4, 46);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(367, 15);
            lblMessage.TabIndex = 216;
            lblMessage.Text = "please check the data reported in the Grid and try again.";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label5.Location = new Point(16, 65);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(238, 25);
            Label5.TabIndex = 216;
            Label5.Text = "CSV Vessel Voyage Update";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.73643f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.79845f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.46511f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27.0f));
            TableLayoutPanel1.Controls.Add(_btnClear, 3, 0);
            TableLayoutPanel1.Controls.Add(_btnSave, 2, 0);
            TableLayoutPanel1.Location = new Point(661, 887);
            TableLayoutPanel1.Margin = new Padding(4);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Size = new Size(835, 53);
            TableLayoutPanel1.TabIndex = 220;
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
            _btnClear.Location = new Point(695, 4);
            _btnClear.Margin = new Padding(4);
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
            _btnClear.Size = new Size(136, 43);
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
            _btnSave.Location = new Point(417, 4);
            _btnSave.Margin = new Padding(4);
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
            _btnSave.Size = new Size(199, 43);
            _btnSave.TabIndex = 77;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // dgvVesselVoyageCSV
            // 
            _dgvVesselVoyageCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvVesselVoyageCSV.Columns.AddRange(new DataGridViewColumn[] { Line, VoyageNumber, Vessel, ERD, LRD, ETA, ETD, PortName, VoyageStatus, Active });
            _dgvVesselVoyageCSV.EnableHeadersVisualStyles = false;
            _dgvVesselVoyageCSV.Location = new Point(13, 251);
            _dgvVesselVoyageCSV.Margin = new Padding(4);
            _dgvVesselVoyageCSV.Name = "_dgvVesselVoyageCSV";
            _dgvVesselVoyageCSV.Size = new Size(1483, 622);
            _dgvVesselVoyageCSV.TabIndex = 219;
            // 
            // Line
            // 
            Line.HeaderText = "Line";
            Line.Name = "Line";
            Line.Width = 50;
            // 
            // VoyageNumber
            // 
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            VoyageNumber.DefaultCellStyle = DataGridViewCellStyle1;
            VoyageNumber.HeaderText = "Voyage Num.";
            VoyageNumber.MinimumWidth = 110;
            VoyageNumber.Name = "VoyageNumber";
            VoyageNumber.Width = 110;
            // 
            // Vessel
            // 
            Vessel.HeaderText = "Vessel";
            Vessel.MinimumWidth = 150;
            Vessel.Name = "Vessel";
            Vessel.Width = 150;
            // 
            // ERD
            // 
            ERD.HeaderText = "ERD";
            ERD.MinimumWidth = 110;
            ERD.Name = "ERD";
            ERD.Width = 110;
            // 
            // LRD
            // 
            DataGridViewCellStyle2.NullValue = null;
            LRD.DefaultCellStyle = DataGridViewCellStyle2;
            LRD.HeaderText = "LRD";
            LRD.MinimumWidth = 110;
            LRD.Name = "LRD";
            LRD.Width = 110;
            // 
            // ETA
            // 
            ETA.HeaderText = "ETA";
            ETA.MinimumWidth = 110;
            ETA.Name = "ETA";
            ETA.Width = 110;
            // 
            // ETD
            // 
            ETD.HeaderText = "ETD";
            ETD.MinimumWidth = 110;
            ETD.Name = "ETD";
            ETD.Width = 110;
            // 
            // PortName
            // 
            PortName.HeaderText = "Port Name";
            PortName.MaxInputLength = 50;
            PortName.MinimumWidth = 150;
            PortName.Name = "PortName";
            PortName.Width = 150;
            // 
            // VoyageStatus
            // 
            VoyageStatus.HeaderText = "Status";
            VoyageStatus.MinimumWidth = 100;
            VoyageStatus.Name = "VoyageStatus";
            // 
            // Active
            // 
            Active.HeaderText = "Active";
            Active.Name = "Active";
            Active.Width = 50;
            // 
            // pnlMessageDefault
            // 
            pnlMessageDefault.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            pnlMessageDefault.Controls.Add(_btnSave_2);
            pnlMessageDefault.Controls.Add(_ckbUpdateVoyage);
            pnlMessageDefault.Controls.Add(Label9);
            pnlMessageDefault.Controls.Add(_lblClosePanel);
            pnlMessageDefault.Controls.Add(Label7);
            pnlMessageDefault.Controls.Add(lbMessage);
            pnlMessageDefault.Location = new Point(339, 361);
            pnlMessageDefault.Margin = new Padding(4);
            pnlMessageDefault.Name = "pnlMessageDefault";
            pnlMessageDefault.Size = new Size(828, 437);
            pnlMessageDefault.TabIndex = 223;
            pnlMessageDefault.Visible = false;
            // 
            // btnSave_2
            // 
            _btnSave_2.AllowToggling = false;
            _btnSave_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnSave_2.AnimationSpeed = 200;
            _btnSave_2.AutoGenerateColors = false;
            _btnSave_2.BackColor = Color.Transparent;
            _btnSave_2.BackColor1 = Color.Teal;
            _btnSave_2.BackgroundImage = (Image)resources.GetObject("btnSave_2.BackgroundImage");
            _btnSave_2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave_2.ButtonText = "Sync and update";
            _btnSave_2.ButtonTextMarginLeft = 0;
            _btnSave_2.ColorContrastOnClick = 45;
            _btnSave_2.ColorContrastOnHover = 45;
            _btnSave_2.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnSave_2.CustomizableEdges = BorderEdges3;
            _btnSave_2.DialogResult = DialogResult.None;
            _btnSave_2.DisabledBorderColor = Color.Empty;
            _btnSave_2.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave_2.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave_2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave_2.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSave_2.ForeColor = Color.White;
            _btnSave_2.IconLeftCursor = Cursors.Hand;
            _btnSave_2.IconMarginLeft = 11;
            _btnSave_2.IconPadding = 10;
            _btnSave_2.IconRightCursor = Cursors.Hand;
            _btnSave_2.IdleBorderColor = Color.Teal;
            _btnSave_2.IdleBorderRadius = 3;
            _btnSave_2.IdleBorderThickness = 1;
            _btnSave_2.IdleFillColor = Color.Teal;
            _btnSave_2.IdleIconLeftImage = null;
            _btnSave_2.IdleIconRightImage = null;
            _btnSave_2.IndicateFocus = true;
            _btnSave_2.Location = new Point(609, 379);
            _btnSave_2.Margin = new Padding(4);
            _btnSave_2.Name = "_btnSave_2";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnSave_2.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnSave_2.OnPressedState = StateProperties6;
            _btnSave_2.Size = new Size(199, 43);
            _btnSave_2.TabIndex = 226;
            _btnSave_2.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave_2.TextMarginLeft = 0;
            _btnSave_2.UseDefaultRadiusAndThickness = true;
            _btnSave_2.Visible = false;
            // 
            // ckbUpdateVoyage
            // 
            _ckbUpdateVoyage.AutoSize = true;
            _ckbUpdateVoyage.Location = new Point(8, 70);
            _ckbUpdateVoyage.Margin = new Padding(4);
            _ckbUpdateVoyage.Name = "_ckbUpdateVoyage";
            _ckbUpdateVoyage.Size = new Size(408, 20);
            _ckbUpdateVoyage.TabIndex = 225;
            _ckbUpdateVoyage.Text = "Enable syncc and update the data marked in the Coral color line ";
            _ckbUpdateVoyage.UseVisualStyleBackColor = true;
            _ckbUpdateVoyage.Visible = false;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Left;
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.Red;
            Label9.Location = new Point(4, 42);
            Label9.Margin = new Padding(4, 0, 4, 0);
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
            _lblClosePanel.Location = new Point(789, -7);
            _lblClosePanel.Margin = new Padding(0);
            _lblClosePanel.Name = "_lblClosePanel";
            _lblClosePanel.Size = new Size(40, 39);
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
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(828, 36);
            Label7.TabIndex = 224;
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMessage
            // 
            lbMessage.FormattingEnabled = true;
            lbMessage.ItemHeight = 16;
            lbMessage.Location = new Point(4, 102);
            lbMessage.Margin = new Padding(4);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(819, 260);
            lbMessage.TabIndex = 0;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            pnlActions.Controls.Add(Label10);
            pnlActions.Controls.Add(Label12);
            pnlActions.Controls.Add(lblUpdated);
            pnlActions.Controls.Add(lblInserted);
            pnlActions.Controls.Add(lblActionsSummary);
            pnlActions.Location = new Point(9, 101);
            pnlActions.Margin = new Padding(4);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(243, 143);
            pnlActions.TabIndex = 238;
            pnlActions.Visible = false;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(13, 96);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(65, 15);
            Label10.TabIndex = 241;
            Label10.Text = "Updated:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(13, 60);
            Label12.Margin = new Padding(4, 0, 4, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(63, 15);
            Label12.TabIndex = 240;
            Label12.Text = "Inserted:";
            // 
            // lblUpdated
            // 
            lblUpdated.AutoSize = true;
            lblUpdated.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblUpdated.Location = new Point(97, 96);
            lblUpdated.Margin = new Padding(4, 0, 4, 0);
            lblUpdated.Name = "lblUpdated";
            lblUpdated.Size = new Size(87, 18);
            lblUpdated.TabIndex = 239;
            lblUpdated.Text = "lblUpdated";
            // 
            // lblInserted
            // 
            lblInserted.AutoSize = true;
            lblInserted.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblInserted.Location = new Point(97, 60);
            lblInserted.Margin = new Padding(4, 0, 4, 0);
            lblInserted.Name = "lblInserted";
            lblInserted.Size = new Size(85, 18);
            lblInserted.TabIndex = 238;
            lblInserted.Text = "lblInserted";
            // 
            // lblActionsSummary
            // 
            lblActionsSummary.Anchor = AnchorStyles.Left;
            lblActionsSummary.AutoSize = true;
            lblActionsSummary.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblActionsSummary.ForeColor = Color.Red;
            lblActionsSummary.Location = new Point(19, 16);
            lblActionsSummary.Margin = new Padding(4, 0, 4, 0);
            lblActionsSummary.Name = "lblActionsSummary";
            lblActionsSummary.Size = new Size(155, 17);
            lblActionsSummary.TabIndex = 237;
            lblActionsSummary.Text = "Summary of actions.";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(9, 44);
            Label11.Margin = new Padding(4, 0, 4, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(210, 15);
            Label11.TabIndex = 231;
            Label11.Text = "ERD Date: DD/MM/YYYY hh:mm";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(328, 52);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(152, 15);
            Label8.TabIndex = 230;
            Label8.Text = "Active: TRUE or FALSE";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Panel1.Controls.Add(Label17);
            Panel1.Controls.Add(Label16);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(Label13);
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(Label14);
            Panel1.Controls.Add(Label11);
            Panel1.Location = new Point(257, 101);
            Panel1.Margin = new Padding(4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(729, 143);
            Panel1.TabIndex = 232;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.Location = new Point(328, 82);
            Label17.Margin = new Padding(4, 0, 4, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(263, 15);
            Label17.TabIndex = 235;
            Label17.Text = "Line: Sequential number starting with 1.";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(9, 116);
            Label16.Margin = new Padding(4, 0, 4, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(208, 15);
            Label16.TabIndex = 234;
            Label16.Text = "ETD Date: DD/MM/YYYY hh:mm";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(9, 92);
            Label15.Margin = new Padding(4, 0, 4, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(206, 15);
            Label15.TabIndex = 233;
            Label15.Text = "ETA Date: DD/MM/YYYY hh:mm";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(9, 68);
            Label13.Margin = new Padding(4, 0, 4, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(209, 15);
            Label13.TabIndex = 232;
            Label13.Text = "LRD Date: DD/MM/YYYY hh:mm";
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.Left;
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.Red;
            Label14.Location = new Point(4, 14);
            Label14.Margin = new Padding(4, 0, 4, 0);
            Label14.Name = "Label14";
            Label14.Size = new Size(543, 17);
            Label14.TabIndex = 217;
            Label14.Text = "For the synchronization to work correctly use the formatting for the fields:";
            // 
            // pnlSynchronizingData
            // 
            pnlSynchronizingData.BackColor = SystemColors.WindowFrame;
            pnlSynchronizingData.BorderStyle = BorderStyle.FixedSingle;
            pnlSynchronizingData.Controls.Add(TableLayoutPanel2);
            pnlSynchronizingData.Location = new Point(309, 475);
            pnlSynchronizingData.Margin = new Padding(4);
            pnlSynchronizingData.Name = "pnlSynchronizingData";
            pnlSynchronizingData.Size = new Size(879, 208);
            pnlSynchronizingData.TabIndex = 233;
            pnlSynchronizingData.Visible = false;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 1;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Controls.Add(ProgressBar1, 0, 0);
            TableLayoutPanel2.Controls.Add(Label6, 0, 1);
            TableLayoutPanel2.Location = new Point(11, 48);
            TableLayoutPanel2.Margin = new Padding(4);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 2;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Size = new Size(855, 123);
            TableLayoutPanel2.TabIndex = 8;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Anchor = AnchorStyles.None;
            ProgressBar1.Location = new Point(8, 13);
            ProgressBar1.Margin = new Padding(4);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(839, 34);
            ProgressBar1.TabIndex = 5;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.None;
            Label6.AutoSize = true;
            Label6.Font = new Font("Arial", 20.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.LawnGreen;
            Label6.Location = new Point(302, 76);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(251, 32);
            Label6.TabIndex = 7;
            Label6.Text = "Synchronizing Data";
            // 
            // frmVesselVoyageCSVUpdate
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1513, 953);
            Controls.Add(pnlActions);
            Controls.Add(pnlSynchronizingData);
            Controls.Add(Panel1);
            Controls.Add(pnlMessageDefault);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_dgvVesselVoyageCSV);
            Controls.Add(pnlMessage);
            Controls.Add(Label5);
            Controls.Add(_btnClose);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmVesselVoyageCSVUpdate";
            Text = "frmVesselVoyageCSVUpdate";
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvVesselVoyageCSV).EndInit();
            pnlMessageDefault.ResumeLayout(false);
            pnlMessageDefault.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            pnlSynchronizingData.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            Load += new EventHandler(frmVesselVoyageCSVUpdate);
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
        internal Panel pnlMessage;
        internal Label Label4;
        internal Label Label3;
        internal Label Label1;
        internal Label lblMessage;
        internal Label Label5;
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

        private DataGridView _dgvVesselVoyageCSV;

        internal DataGridView dgvVesselVoyageCSV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvVesselVoyageCSV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvVesselVoyageCSV != null)
                {
                    _dgvVesselVoyageCSV.KeyDown -= dgvVesselVoyageCSV_KeyDown;
                }

                _dgvVesselVoyageCSV = value;
                if (_dgvVesselVoyageCSV != null)
                {
                    _dgvVesselVoyageCSV.KeyDown += dgvVesselVoyageCSV_KeyDown;
                }
            }
        }

        internal Panel pnlMessageDefault;
        internal ListBox lbMessage;
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
        internal Label Label9;
        internal Label Label11;
        internal Label Label8;
        internal Panel Panel1;
        internal Label Label14;
        private CheckBox _ckbUpdateVoyage;

        internal CheckBox ckbUpdateVoyage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckbUpdateVoyage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckbUpdateVoyage != null)
                {
                    _ckbUpdateVoyage.Click -= ckbUpdateVoyage_Click;
                }

                _ckbUpdateVoyage = value;
                if (_ckbUpdateVoyage != null)
                {
                    _ckbUpdateVoyage.Click += ckbUpdateVoyage_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSave_2;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave_2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSave_2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave_2 != null)
                {
                    _btnSave_2.Click -= btnSave_2_Click;
                }

                _btnSave_2 = value;
                if (_btnSave_2 != null)
                {
                    _btnSave_2.Click += btnSave_2_Click;
                }
            }
        }

        internal Panel pnlSynchronizingData;
        internal Label Label6;
        internal ProgressBar ProgressBar1;
        internal Label lblActionsSummary;
        internal Panel pnlActions;
        internal Label lblUpdated;
        internal Label lblInserted;
        internal Label Label10;
        internal Label Label12;
        internal Label Label16;
        internal Label Label15;
        internal Label Label13;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label17;
        internal DataGridViewTextBoxColumn Line;
        internal DataGridViewTextBoxColumn VoyageNumber;
        internal DataGridViewTextBoxColumn Vessel;
        internal DataGridViewTextBoxColumn ERD;
        internal DataGridViewTextBoxColumn LRD;
        internal DataGridViewTextBoxColumn ETA;
        internal DataGridViewTextBoxColumn ETD;
        internal DataGridViewTextBoxColumn PortName;
        internal DataGridViewTextBoxColumn VoyageStatus;
        internal DataGridViewTextBoxColumn Active;
    }
}