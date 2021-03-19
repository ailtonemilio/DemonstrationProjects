using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAssignContainer : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssignContainer));
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            Panel2 = new Panel();
            _bookingActivBookingBunifuToggleSwitch2 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _bookingActivBookingBunifuToggleSwitch2.OnValuechange += new EventHandler(bookingActivBookingBunifuToggleSwitch2_OnValuechange);
            Label7 = new Label();
            Label10 = new Label();
            _BunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton2.Click += new EventHandler(BunifuButton2_Click);
            BunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            Label13 = new Label();
            LRDLabel = new Label();
            label56 = new Label();
            label22 = new Label();
            cansLabel = new Label();
            typeLabel = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            vesselLabel = new Label();
            Label19 = new Label();
            Label6 = new Label();
            Label8 = new Label();
            customerNameLabel = new Label();
            ssLineLabel = new Label();
            Label9 = new Label();
            bookingLabel = new Label();
            ShapedPanel1 = new CustomizedControlsLibrary.ShapedPanel();
            statusLabel = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            _changeBookingBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _changeBookingBtn.Click += new EventHandler(changeBookingBtn_Click);
            _holdButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _holdButton.Click += new EventHandler(holdButton_Click);
            _removeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _removeButton.Click += new EventHandler(deleteButton_Click);
            _transloadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _transloadButton.Click += new EventHandler(transloadButton_Click);
            Label3 = new Label();
            Label2 = new Label();
            Panel4 = new Panel();
            _selectAllCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _selectAllCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(selectAllCheckBox_CheckedChanged);
            _assignedContainersBunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            _assignedContainersBunifuDataGridView2.CellContentClick += new DataGridViewCellEventHandler(assignedContainersBunifuDataGridView2_CellContentClick);
            _assignedContainersBunifuDataGridView2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(assignedContainersBunifuDataGridView2_RowPostPaint);
            Column13 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewCheckBoxColumn();
            truckout = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Label1 = new Label();
            _bookingComboBox = new ComboBox();
            _bookingComboBox.SelectedIndexChanged += new EventHandler(bookingComboBox_SelectedIndexChanged);
            _assignBunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _assignBunifuButton1.Click += new EventHandler(assignBunifuButton1_Click);
            Panel3 = new Panel();
            _containersBunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            _containersBunifuDataGridView1.CellContentClick += new DataGridViewCellEventHandler(summaryBunifuDataGridView_CellContentClick);
            _containersBunifuDataGridView1.SelectionChanged += new EventHandler(containersBunifuDataGridView1_SelectionChanged);
            Column6 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            grossWeight = new DataGridViewCheckBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Panel6 = new Panel();
            Panel7 = new Panel();
            totalContainersLabel = new Label();
            _searchBunifuTextBox1 = new BunifuTextBox();
            _searchBunifuTextBox1.KeyDown += new KeyEventHandler(searchBunifuTextBox1_KeyDown);
            Timer1 = new Timer(components);
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            Panel2.SuspendLayout();
            BunifuShadowPanel2.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            ShapedPanel1.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_assignedContainersBunifuDataGridView2).BeginInit();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_containersBunifuDataGridView1).BeginInit();
            Panel6.SuspendLayout();
            Panel7.SuspendLayout();
            SuspendLayout();
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1557, 890);
            BunifuShadowPanel1.TabIndex = 6;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1542, 879);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.DimGray;
            Panel5.Controls.Add(Panel2);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1542, 879);
            Panel5.TabIndex = 33;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(_bookingActivBookingBunifuToggleSwitch2);
            Panel2.Controls.Add(Label7);
            Panel2.Controls.Add(Label10);
            Panel2.Controls.Add(_BunifuButton2);
            Panel2.Controls.Add(BunifuShadowPanel2);
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Panel4);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(_bookingComboBox);
            Panel2.Controls.Add(_assignBunifuButton1);
            Panel2.Controls.Add(Panel3);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Panel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1542, 839);
            Panel2.TabIndex = 0;
            // 
            // bookingActivBookingBunifuToggleSwitch2
            // 
            _bookingActivBookingBunifuToggleSwitch2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _bookingActivBookingBunifuToggleSwitch2.Animation = 5;
            _bookingActivBookingBunifuToggleSwitch2.BackColor = Color.Transparent;
            _bookingActivBookingBunifuToggleSwitch2.BackgroundImage = (Image)resources.GetObject("bookingActivBookingBunifuToggleSwitch2.BackgroundImage");
            _bookingActivBookingBunifuToggleSwitch2.Cursor = Cursors.Hand;
            _bookingActivBookingBunifuToggleSwitch2.Font = new Font("Segoe UI", 9.163636f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _bookingActivBookingBunifuToggleSwitch2.Location = new Point(1355, 9);
            _bookingActivBookingBunifuToggleSwitch2.Margin = new Padding(5, 6, 5, 6);
            _bookingActivBookingBunifuToggleSwitch2.Name = "_bookingActivBookingBunifuToggleSwitch2";
            _bookingActivBookingBunifuToggleSwitch2.Size = new Size(44, 21);
            _bookingActivBookingBunifuToggleSwitch2.TabIndex = 119;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _bookingActivBookingBunifuToggleSwitch2.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Tomato;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Tomato;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 17;
            ToggleState2.BorderRadiusInner = 15;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _bookingActivBookingBunifuToggleSwitch2.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.Green;
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.Green;
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 17;
            ToggleState3.BorderRadiusInner = 15;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _bookingActivBookingBunifuToggleSwitch2.ToggleStateOn = ToggleState3;
            _bookingActivBookingBunifuToggleSwitch2.Value = true;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.Tomato;
            Label7.Location = new Point(1288, 9);
            Label7.Name = "Label7";
            Label7.Size = new Size(58, 19);
            Label7.TabIndex = 121;
            Label7.Text = "Inactive";
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.Green;
            Label10.Location = new Point(1404, 9);
            Label10.Name = "Label10";
            Label10.Size = new Size(48, 19);
            Label10.TabIndex = 120;
            Label10.Text = "Active";
            // 
            // BunifuButton2
            // 
            _BunifuButton2.AllowToggling = false;
            _BunifuButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuButton2.AnimationSpeed = 200;
            _BunifuButton2.AutoGenerateColors = false;
            _BunifuButton2.BackColor = Color.Transparent;
            _BunifuButton2.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuButton2.BackgroundImage = (Image)resources.GetObject("BunifuButton2.BackgroundImage");
            _BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton2.ButtonText = "";
            _BunifuButton2.ButtonTextMarginLeft = 0;
            _BunifuButton2.ColorContrastOnClick = 45;
            _BunifuButton2.ColorContrastOnHover = 45;
            _BunifuButton2.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _BunifuButton2.CustomizableEdges = BorderEdges1;
            _BunifuButton2.DialogResult = DialogResult.None;
            _BunifuButton2.DisabledBorderColor = Color.Empty;
            _BunifuButton2.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton2.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton2.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton2.ForeColor = Color.White;
            _BunifuButton2.IconLeftCursor = Cursors.Hand;
            _BunifuButton2.IconMarginLeft = 5;
            _BunifuButton2.IconPadding = 5;
            _BunifuButton2.IconRightCursor = Cursors.Hand;
            _BunifuButton2.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuButton2.IdleBorderRadius = 3;
            _BunifuButton2.IdleBorderThickness = 1;
            _BunifuButton2.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuButton2.IdleIconLeftImage = My.Resources.Resources.script;
            _BunifuButton2.IdleIconRightImage = null;
            _BunifuButton2.IndicateFocus = true;
            _BunifuButton2.Location = new Point(1477, 9);
            _BunifuButton2.Name = "_BunifuButton2";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Silver;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _BunifuButton2.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _BunifuButton2.OnPressedState = StateProperties2;
            _BunifuButton2.Size = new Size(44, 44);
            _BunifuButton2.TabIndex = 118;
            _BunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton2.TextMarginLeft = 0;
            _BunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuShadowPanel2
            // 
            BunifuShadowPanel2.Anchor = AnchorStyles.None;
            BunifuShadowPanel2.BorderColor = Color.Transparent;
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel2);
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel1);
            BunifuShadowPanel2.Controls.Add(ShapedPanel1);
            BunifuShadowPanel2.Location = new Point(700, 101);
            BunifuShadowPanel2.Name = "BunifuShadowPanel2";
            BunifuShadowPanel2.PanelColor = Color.Empty;
            BunifuShadowPanel2.ShadowDept = 2;
            BunifuShadowPanel2.ShadowTopLeftVisible = true;
            BunifuShadowPanel2.Size = new Size(760, 191);
            BunifuShadowPanel2.TabIndex = 79;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.70886f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.29114f));
            TableLayoutPanel2.Controls.Add(Label13, 0, 0);
            TableLayoutPanel2.Controls.Add(LRDLabel, 1, 0);
            TableLayoutPanel2.Controls.Add(label56, 0, 2);
            TableLayoutPanel2.Controls.Add(label22, 0, 1);
            TableLayoutPanel2.Controls.Add(cansLabel, 1, 2);
            TableLayoutPanel2.Controls.Add(typeLabel, 1, 1);
            TableLayoutPanel2.Location = new Point(508, 69);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 3;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
            TableLayoutPanel2.Size = new Size(236, 108);
            TableLayoutPanel2.TabIndex = 6;
            // 
            // Label13
            // 
            Label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label13.Location = new Point(32, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(51, 21);
            Label13.TabIndex = 4;
            Label13.Text = "L.R.D:";
            Label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LRDLabel
            // 
            LRDLabel.AutoSize = true;
            LRDLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LRDLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            LRDLabel.Location = new Point(89, 0);
            LRDLabel.Name = "LRDLabel";
            LRDLabel.Size = new Size(104, 21);
            LRDLabel.TabIndex = 8;
            LRDLabel.Text = "01-JAN-2020";
            // 
            // label56
            // 
            label56.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label56.AutoSize = true;
            label56.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            label56.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            label56.Location = new Point(22, 72);
            label56.Name = "label56";
            label56.Size = new Size(61, 21);
            label56.TabIndex = 5;
            label56.Text = "Cans #:";
            label56.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            label22.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            label22.Location = new Point(34, 36);
            label22.Name = "label22";
            label22.Size = new Size(49, 21);
            label22.TabIndex = 6;
            label22.Text = "Type:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cansLabel
            // 
            cansLabel.AutoSize = true;
            cansLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cansLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            cansLabel.Location = new Point(89, 72);
            cansLabel.Name = "cansLabel";
            cansLabel.Size = new Size(28, 21);
            cansLabel.TabIndex = 9;
            cansLabel.Text = "10";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            typeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            typeLabel.Location = new Point(89, 36);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(36, 21);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "BLK";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.65217f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.34783f));
            TableLayoutPanel1.Controls.Add(vesselLabel, 1, 2);
            TableLayoutPanel1.Controls.Add(Label19, 0, 2);
            TableLayoutPanel1.Controls.Add(Label6, 0, 0);
            TableLayoutPanel1.Controls.Add(Label8, 0, 1);
            TableLayoutPanel1.Controls.Add(customerNameLabel, 1, 0);
            TableLayoutPanel1.Controls.Add(ssLineLabel, 1, 1);
            TableLayoutPanel1.Controls.Add(Label9, 0, 3);
            TableLayoutPanel1.Controls.Add(bookingLabel, 1, 3);
            TableLayoutPanel1.Location = new Point(23, 32);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.Size = new Size(467, 145);
            TableLayoutPanel1.TabIndex = 5;
            // 
            // vesselLabel
            // 
            vesselLabel.AutoSize = true;
            vesselLabel.Dock = DockStyle.Fill;
            vesselLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            vesselLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            vesselLabel.Location = new Point(146, 72);
            vesselLabel.Name = "vesselLabel";
            vesselLabel.Size = new Size(318, 36);
            vesselLabel.TabIndex = 80;
            vesselLabel.Text = "EXPRESS TEST";
            // 
            // Label19
            // 
            Label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label19.AutoSize = true;
            Label19.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label19.Location = new Point(81, 72);
            Label19.Name = "Label19";
            Label19.Size = new Size(59, 21);
            Label19.TabIndex = 80;
            Label19.Text = "Vessel:";
            Label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(54, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(86, 21);
            Label6.TabIndex = 4;
            Label6.Text = "Customer:";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Location = new Point(27, 36);
            Label8.Name = "Label8";
            Label8.Size = new Size(113, 21);
            Label8.TabIndex = 5;
            Label8.Text = "Shipping Line:";
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Dock = DockStyle.Fill;
            customerNameLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            customerNameLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            customerNameLabel.Location = new Point(146, 0);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(318, 36);
            customerNameLabel.TabIndex = 8;
            customerNameLabel.Text = "TEST COMPANY CORPORATION";
            // 
            // ssLineLabel
            // 
            ssLineLabel.AutoSize = true;
            ssLineLabel.Dock = DockStyle.Fill;
            ssLineLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ssLineLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ssLineLabel.Location = new Point(146, 36);
            ssLineLabel.Name = "ssLineLabel";
            ssLineLabel.Size = new Size(318, 36);
            ssLineLabel.TabIndex = 9;
            ssLineLabel.Text = "TEST SHIPPING LINE";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(52, 108);
            Label9.Name = "Label9";
            Label9.Size = new Size(88, 21);
            Label9.TabIndex = 6;
            Label9.Text = "Booking #:";
            Label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookingLabel
            // 
            bookingLabel.AutoSize = true;
            bookingLabel.Dock = DockStyle.Fill;
            bookingLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            bookingLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            bookingLabel.Location = new Point(146, 108);
            bookingLabel.Name = "bookingLabel";
            bookingLabel.Size = new Size(318, 37);
            bookingLabel.TabIndex = 10;
            bookingLabel.Text = "ABC123456";
            // 
            // ShapedPanel1
            // 
            ShapedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShapedPanel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedPanel1.BorderColor = Color.White;
            ShapedPanel1.Controls.Add(statusLabel);
            ShapedPanel1.Edge = 20;
            ShapedPanel1.Location = new Point(539, 17);
            ShapedPanel1.Name = "ShapedPanel1";
            ShapedPanel1.Size = new Size(202, 32);
            ShapedPanel1.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(0, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(202, 32);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "CLOSED";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.None;
            TableLayoutPanel3.ColumnCount = 4;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.69679f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.89796f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.40525f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129.0f));
            TableLayoutPanel3.Controls.Add(_changeBookingBtn, 0, 0);
            TableLayoutPanel3.Controls.Add(_holdButton, 0, 0);
            TableLayoutPanel3.Controls.Add(_removeButton, 3, 0);
            TableLayoutPanel3.Controls.Add(_transloadButton, 2, 0);
            TableLayoutPanel3.Location = new Point(1053, 739);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(457, 51);
            TableLayoutPanel3.TabIndex = 77;
            // 
            // changeBookingBtn
            // 
            _changeBookingBtn.AllowToggling = false;
            _changeBookingBtn.AnimationSpeed = 200;
            _changeBookingBtn.AutoGenerateColors = false;
            _changeBookingBtn.BackColor = Color.Transparent;
            _changeBookingBtn.BackColor1 = Color.Teal;
            _changeBookingBtn.BackgroundImage = (Image)resources.GetObject("changeBookingBtn.BackgroundImage");
            _changeBookingBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _changeBookingBtn.ButtonText = "Change Booking";
            _changeBookingBtn.ButtonTextMarginLeft = 0;
            _changeBookingBtn.ColorContrastOnClick = 45;
            _changeBookingBtn.ColorContrastOnHover = 45;
            _changeBookingBtn.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _changeBookingBtn.CustomizableEdges = BorderEdges2;
            _changeBookingBtn.DialogResult = DialogResult.None;
            _changeBookingBtn.DisabledBorderColor = Color.Empty;
            _changeBookingBtn.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _changeBookingBtn.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _changeBookingBtn.Enabled = false;
            _changeBookingBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _changeBookingBtn.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _changeBookingBtn.ForeColor = Color.White;
            _changeBookingBtn.IconLeftCursor = Cursors.Hand;
            _changeBookingBtn.IconMarginLeft = 11;
            _changeBookingBtn.IconPadding = 10;
            _changeBookingBtn.IconRightCursor = Cursors.Hand;
            _changeBookingBtn.IdleBorderColor = Color.Teal;
            _changeBookingBtn.IdleBorderRadius = 3;
            _changeBookingBtn.IdleBorderThickness = 1;
            _changeBookingBtn.IdleFillColor = Color.Teal;
            _changeBookingBtn.IdleIconLeftImage = null;
            _changeBookingBtn.IdleIconRightImage = null;
            _changeBookingBtn.IndicateFocus = true;
            _changeBookingBtn.Location = new Point(93, 3);
            _changeBookingBtn.Name = "_changeBookingBtn";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _changeBookingBtn.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _changeBookingBtn.OnPressedState = StateProperties4;
            _changeBookingBtn.Size = new Size(141, 45);
            _changeBookingBtn.TabIndex = 71;
            _changeBookingBtn.TextAlign = ContentAlignment.MiddleCenter;
            _changeBookingBtn.TextMarginLeft = 0;
            _changeBookingBtn.UseDefaultRadiusAndThickness = true;
            // 
            // holdButton
            // 
            _holdButton.AllowToggling = false;
            _holdButton.AnimationSpeed = 200;
            _holdButton.AutoGenerateColors = false;
            _holdButton.BackColor = Color.Transparent;
            _holdButton.BackColor1 = Color.Teal;
            _holdButton.BackgroundImage = (Image)resources.GetObject("holdButton.BackgroundImage");
            _holdButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _holdButton.ButtonText = "Hold";
            _holdButton.ButtonTextMarginLeft = 0;
            _holdButton.ColorContrastOnClick = 45;
            _holdButton.ColorContrastOnHover = 45;
            _holdButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _holdButton.CustomizableEdges = BorderEdges3;
            _holdButton.DialogResult = DialogResult.None;
            _holdButton.DisabledBorderColor = Color.Empty;
            _holdButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _holdButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _holdButton.Enabled = false;
            _holdButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _holdButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _holdButton.ForeColor = Color.White;
            _holdButton.IconLeftCursor = Cursors.Hand;
            _holdButton.IconMarginLeft = 11;
            _holdButton.IconPadding = 10;
            _holdButton.IconRightCursor = Cursors.Hand;
            _holdButton.IdleBorderColor = Color.Teal;
            _holdButton.IdleBorderRadius = 3;
            _holdButton.IdleBorderThickness = 1;
            _holdButton.IdleFillColor = Color.Teal;
            _holdButton.IdleIconLeftImage = null;
            _holdButton.IdleIconRightImage = null;
            _holdButton.IndicateFocus = true;
            _holdButton.Location = new Point(3, 3);
            _holdButton.Name = "_holdButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _holdButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _holdButton.OnPressedState = StateProperties6;
            _holdButton.Size = new Size(84, 45);
            _holdButton.TabIndex = 69;
            _holdButton.TextAlign = ContentAlignment.MiddleCenter;
            _holdButton.TextMarginLeft = 0;
            _holdButton.UseDefaultRadiusAndThickness = true;
            // 
            // removeButton
            // 
            _removeButton.AllowToggling = false;
            _removeButton.AnimationSpeed = 200;
            _removeButton.AutoGenerateColors = false;
            _removeButton.BackColor = Color.Transparent;
            _removeButton.BackColor1 = Color.IndianRed;
            _removeButton.BackgroundImage = (Image)resources.GetObject("removeButton.BackgroundImage");
            _removeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _removeButton.ButtonText = "Remove";
            _removeButton.ButtonTextMarginLeft = 0;
            _removeButton.ColorContrastOnClick = 45;
            _removeButton.ColorContrastOnHover = 45;
            _removeButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _removeButton.CustomizableEdges = BorderEdges4;
            _removeButton.DialogResult = DialogResult.None;
            _removeButton.DisabledBorderColor = Color.Empty;
            _removeButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _removeButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _removeButton.Enabled = false;
            _removeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _removeButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _removeButton.ForeColor = Color.White;
            _removeButton.IconLeftCursor = Cursors.Hand;
            _removeButton.IconMarginLeft = 11;
            _removeButton.IconPadding = 10;
            _removeButton.IconRightCursor = Cursors.Hand;
            _removeButton.IdleBorderColor = Color.IndianRed;
            _removeButton.IdleBorderRadius = 3;
            _removeButton.IdleBorderThickness = 1;
            _removeButton.IdleFillColor = Color.IndianRed;
            _removeButton.IdleIconLeftImage = null;
            _removeButton.IdleIconRightImage = null;
            _removeButton.IndicateFocus = true;
            _removeButton.Location = new Point(329, 3);
            _removeButton.Name = "_removeButton";
            StateProperties7.BorderColor = Color.LightCoral;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.LightCoral;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _removeButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.IndianRed;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.IndianRed;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _removeButton.OnPressedState = StateProperties8;
            _removeButton.Size = new Size(108, 45);
            _removeButton.TabIndex = 70;
            _removeButton.TextAlign = ContentAlignment.MiddleCenter;
            _removeButton.TextMarginLeft = 0;
            _removeButton.UseDefaultRadiusAndThickness = true;
            // 
            // transloadButton
            // 
            _transloadButton.AllowToggling = false;
            _transloadButton.AnimationSpeed = 200;
            _transloadButton.AutoGenerateColors = false;
            _transloadButton.BackColor = Color.Transparent;
            _transloadButton.BackColor1 = Color.Teal;
            _transloadButton.BackgroundImage = (Image)resources.GetObject("transloadButton.BackgroundImage");
            _transloadButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _transloadButton.ButtonText = "Transload";
            _transloadButton.ButtonTextMarginLeft = 0;
            _transloadButton.ColorContrastOnClick = 45;
            _transloadButton.ColorContrastOnHover = 45;
            _transloadButton.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _transloadButton.CustomizableEdges = BorderEdges5;
            _transloadButton.DialogResult = DialogResult.None;
            _transloadButton.DisabledBorderColor = Color.Empty;
            _transloadButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _transloadButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _transloadButton.Enabled = false;
            _transloadButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _transloadButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _transloadButton.ForeColor = Color.White;
            _transloadButton.IconLeftCursor = Cursors.Hand;
            _transloadButton.IconMarginLeft = 11;
            _transloadButton.IconPadding = 10;
            _transloadButton.IconRightCursor = Cursors.Hand;
            _transloadButton.IdleBorderColor = Color.Teal;
            _transloadButton.IdleBorderRadius = 3;
            _transloadButton.IdleBorderThickness = 1;
            _transloadButton.IdleFillColor = Color.Teal;
            _transloadButton.IdleIconLeftImage = null;
            _transloadButton.IdleIconRightImage = null;
            _transloadButton.IndicateFocus = true;
            _transloadButton.Location = new Point(240, 3);
            _transloadButton.Name = "_transloadButton";
            StateProperties9.BorderColor = Color.MediumTurquoise;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.MediumTurquoise;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _transloadButton.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _transloadButton.OnPressedState = StateProperties10;
            _transloadButton.Size = new Size(83, 45);
            _transloadButton.TabIndex = 61;
            _transloadButton.TextAlign = ContentAlignment.MiddleCenter;
            _transloadButton.TextMarginLeft = 0;
            _transloadButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(622, 294);
            Label3.Name = "Label3";
            Label3.Size = new Size(155, 21);
            Label3.TabIndex = 6;
            Label3.Text = "Assigned Containers:";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(30, 41);
            Label2.Name = "Label2";
            Label2.Size = new Size(155, 21);
            Label2.TabIndex = 5;
            Label2.Text = "Available Containers:";
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_selectAllCheckBox);
            Panel4.Controls.Add(_assignedContainersBunifuDataGridView2);
            Panel4.Location = new Point(626, 322);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(885, 417);
            Panel4.TabIndex = 4;
            // 
            // selectAllCheckBox
            // 
            _selectAllCheckBox.AllowBindingControlAnimation = true;
            _selectAllCheckBox.AllowBindingControlColorChanges = false;
            _selectAllCheckBox.AllowBindingControlLocation = true;
            _selectAllCheckBox.AllowCheckBoxAnimation = false;
            _selectAllCheckBox.AllowCheckmarkAnimation = true;
            _selectAllCheckBox.AllowOnHoverStates = true;
            _selectAllCheckBox.AutoCheck = true;
            _selectAllCheckBox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _selectAllCheckBox.BackgroundImage = (Image)resources.GetObject("selectAllCheckBox.BackgroundImage");
            _selectAllCheckBox.BackgroundImageLayout = ImageLayout.Zoom;
            _selectAllCheckBox.BindingControl = null;
            _selectAllCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _selectAllCheckBox.Checked = false;
            _selectAllCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            _selectAllCheckBox.Cursor = Cursors.Hand;
            _selectAllCheckBox.CustomCheckmarkImage = null;
            _selectAllCheckBox.Location = new Point(8, 8);
            _selectAllCheckBox.MinimumSize = new Size(17, 17);
            _selectAllCheckBox.Name = "_selectAllCheckBox";
            _selectAllCheckBox.OnCheck.BorderColor = Color.Teal;
            _selectAllCheckBox.OnCheck.BorderRadius = 2;
            _selectAllCheckBox.OnCheck.BorderThickness = 2;
            _selectAllCheckBox.OnCheck.CheckBoxColor = Color.Teal;
            _selectAllCheckBox.OnCheck.CheckmarkColor = Color.White;
            _selectAllCheckBox.OnCheck.CheckmarkThickness = 2;
            _selectAllCheckBox.OnDisable.BorderColor = Color.LightGray;
            _selectAllCheckBox.OnDisable.BorderRadius = 2;
            _selectAllCheckBox.OnDisable.BorderThickness = 2;
            _selectAllCheckBox.OnDisable.CheckBoxColor = Color.Transparent;
            _selectAllCheckBox.OnDisable.CheckmarkColor = Color.LightGray;
            _selectAllCheckBox.OnDisable.CheckmarkThickness = 2;
            _selectAllCheckBox.OnHoverChecked.BorderColor = Color.LightSeaGreen;
            _selectAllCheckBox.OnHoverChecked.BorderRadius = 2;
            _selectAllCheckBox.OnHoverChecked.BorderThickness = 2;
            _selectAllCheckBox.OnHoverChecked.CheckBoxColor = Color.LightSeaGreen;
            _selectAllCheckBox.OnHoverChecked.CheckmarkColor = Color.White;
            _selectAllCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            _selectAllCheckBox.OnHoverUnchecked.BorderColor = Color.LightSeaGreen;
            _selectAllCheckBox.OnHoverUnchecked.BorderRadius = 2;
            _selectAllCheckBox.OnHoverUnchecked.BorderThickness = 2;
            _selectAllCheckBox.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _selectAllCheckBox.OnUncheck.BorderColor = Color.Teal;
            _selectAllCheckBox.OnUncheck.BorderRadius = 2;
            _selectAllCheckBox.OnUncheck.BorderThickness = 2;
            _selectAllCheckBox.OnUncheck.CheckBoxColor = Color.Transparent;
            _selectAllCheckBox.Size = new Size(23, 23);
            _selectAllCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _selectAllCheckBox.TabIndex = 78;
            _selectAllCheckBox.ThreeState = false;
            _selectAllCheckBox.ToolTipText = null;
            // 
            // assignedContainersBunifuDataGridView2
            // 
            _assignedContainersBunifuDataGridView2.AllowCustomTheming = true;
            _assignedContainersBunifuDataGridView2.AllowUserToAddRows = false;
            _assignedContainersBunifuDataGridView2.AllowUserToDeleteRows = false;
            _assignedContainersBunifuDataGridView2.AllowUserToOrderColumns = true;
            _assignedContainersBunifuDataGridView2.AllowUserToResizeColumns = false;
            _assignedContainersBunifuDataGridView2.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            _assignedContainersBunifuDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _assignedContainersBunifuDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _assignedContainersBunifuDataGridView2.BackgroundColor = Color.White;
            _assignedContainersBunifuDataGridView2.BorderStyle = BorderStyle.None;
            _assignedContainersBunifuDataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _assignedContainersBunifuDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _assignedContainersBunifuDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _assignedContainersBunifuDataGridView2.ColumnHeadersHeight = 40;
            _assignedContainersBunifuDataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column13, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, Column8, Column9, Column10, Column11, Column12, DataGridViewTextBoxColumn6, Column15, truckout, Column17 });
            _assignedContainersBunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _assignedContainersBunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _assignedContainersBunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _assignedContainersBunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _assignedContainersBunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _assignedContainersBunifuDataGridView2.CurrentTheme.BackColor = Color.Snow;
            _assignedContainersBunifuDataGridView2.CurrentTheme.GridColor = Color.Gray;
            _assignedContainersBunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _assignedContainersBunifuDataGridView2.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _assignedContainersBunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _assignedContainersBunifuDataGridView2.CurrentTheme.Name = null;
            _assignedContainersBunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _assignedContainersBunifuDataGridView2.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _assignedContainersBunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _assignedContainersBunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _assignedContainersBunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _assignedContainersBunifuDataGridView2.DefaultCellStyle = DataGridViewCellStyle3;
            _assignedContainersBunifuDataGridView2.Dock = DockStyle.Fill;
            _assignedContainersBunifuDataGridView2.EnableHeadersVisualStyles = false;
            _assignedContainersBunifuDataGridView2.GridColor = Color.Gray;
            _assignedContainersBunifuDataGridView2.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _assignedContainersBunifuDataGridView2.HeaderBgColor = Color.Empty;
            _assignedContainersBunifuDataGridView2.HeaderForeColor = Color.White;
            _assignedContainersBunifuDataGridView2.Location = new Point(0, 0);
            _assignedContainersBunifuDataGridView2.Name = "_assignedContainersBunifuDataGridView2";
            _assignedContainersBunifuDataGridView2.RowHeadersVisible = false;
            _assignedContainersBunifuDataGridView2.RowTemplate.Height = 35;
            _assignedContainersBunifuDataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _assignedContainersBunifuDataGridView2.Size = new Size(883, 415);
            _assignedContainersBunifuDataGridView2.TabIndex = 60;
            _assignedContainersBunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column13
            // 
            Column13.FillWeight = 58.89623f;
            Column13.HeaderText = "";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.FillWeight = 178.9183f;
            DataGridViewTextBoxColumn1.HeaderText = "Container #";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.FillWeight = 109.1811f;
            DataGridViewTextBoxColumn2.HeaderText = "SS Line";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.FillWeight = 81.02694f;
            DataGridViewTextBoxColumn3.HeaderText = "H/S";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.FillWeight = 83.14812f;
            DataGridViewTextBoxColumn4.HeaderText = "Tare";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.FillWeight = 142.4574f;
            DataGridViewTextBoxColumn5.HeaderText = "Date";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.FillWeight = 79.43243f;
            Column8.HeaderText = "Truck";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 104.7979f;
            Column9.HeaderText = "Seal #";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 100.6318f;
            Column10.HeaderText = "Load";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 140.4016f;
            Column11.HeaderText = "Delivered";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.FillWeight = 81.36381f;
            Column12.HeaderText = "Truck";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.HeaderText = "ID";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            DataGridViewTextBoxColumn6.Visible = false;
            // 
            // Column15
            // 
            Column15.HeaderText = "hold";
            Column15.Name = "Column15";
            Column15.Resizable = DataGridViewTriState.True;
            Column15.SortMode = DataGridViewColumnSortMode.Automatic;
            Column15.Visible = false;
            // 
            // truckout
            // 
            truckout.HeaderText = "truckID";
            truckout.Name = "truckout";
            truckout.Visible = false;
            // 
            // Column17
            // 
            Column17.HeaderText = "";
            Column17.Name = "Column17";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(587, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(164, 25);
            Label1.TabIndex = 3;
            Label1.Text = "Booking Number:";
            // 
            // bookingComboBox
            // 
            _bookingComboBox.Anchor = AnchorStyles.Top;
            _bookingComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _bookingComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _bookingComboBox.DisplayMember = "Record_ID";
            _bookingComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _bookingComboBox.FormattingEnabled = true;
            _bookingComboBox.ItemHeight = 21;
            _bookingComboBox.Location = new Point(782, 21);
            _bookingComboBox.Name = "_bookingComboBox";
            _bookingComboBox.Size = new Size(306, 29);
            _bookingComboBox.TabIndex = 2;
            _bookingComboBox.ValueMember = "Record_ID";
            // 
            // assignBunifuButton1
            // 
            _assignBunifuButton1.AllowToggling = false;
            _assignBunifuButton1.Anchor = AnchorStyles.None;
            _assignBunifuButton1.AnimationSpeed = 200;
            _assignBunifuButton1.AutoGenerateColors = false;
            _assignBunifuButton1.BackColor = Color.Transparent;
            _assignBunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _assignBunifuButton1.BackgroundImage = (Image)resources.GetObject("assignBunifuButton1.BackgroundImage");
            _assignBunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _assignBunifuButton1.ButtonText = "";
            _assignBunifuButton1.ButtonTextMarginLeft = 0;
            _assignBunifuButton1.ColorContrastOnClick = 45;
            _assignBunifuButton1.ColorContrastOnHover = 45;
            _assignBunifuButton1.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _assignBunifuButton1.CustomizableEdges = BorderEdges6;
            _assignBunifuButton1.DialogResult = DialogResult.None;
            _assignBunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _assignBunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _assignBunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _assignBunifuButton1.Enabled = false;
            _assignBunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _assignBunifuButton1.Font = new Font("Microsoft Sans Serif", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _assignBunifuButton1.ForeColor = Color.White;
            _assignBunifuButton1.IconLeftCursor = Cursors.Hand;
            _assignBunifuButton1.IconMarginLeft = 8;
            _assignBunifuButton1.IconPadding = 8;
            _assignBunifuButton1.IconRightCursor = Cursors.Hand;
            _assignBunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _assignBunifuButton1.IdleBorderRadius = 30;
            _assignBunifuButton1.IdleBorderThickness = 1;
            _assignBunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _assignBunifuButton1.IdleIconLeftImage = My.Resources.Resources.arrowRight;
            _assignBunifuButton1.IdleIconRightImage = null;
            _assignBunifuButton1.IndicateFocus = false;
            _assignBunifuButton1.Location = new Point(558, 433);
            _assignBunifuButton1.Name = "_assignBunifuButton1";
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties11.BorderRadius = 30;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _assignBunifuButton1.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties12.BorderRadius = 30;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _assignBunifuButton1.OnPressedState = StateProperties12;
            _assignBunifuButton1.Size = new Size(53, 52);
            _assignBunifuButton1.TabIndex = 1;
            _assignBunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _assignBunifuButton1.TextMarginLeft = 0;
            _assignBunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.None;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(_containersBunifuDataGridView1);
            Panel3.Controls.Add(Panel6);
            Panel3.Location = new Point(30, 68);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(512, 669);
            Panel3.TabIndex = 0;
            // 
            // containersBunifuDataGridView1
            // 
            _containersBunifuDataGridView1.AllowCustomTheming = true;
            _containersBunifuDataGridView1.AllowUserToAddRows = false;
            _containersBunifuDataGridView1.AllowUserToDeleteRows = false;
            _containersBunifuDataGridView1.AllowUserToOrderColumns = true;
            _containersBunifuDataGridView1.AllowUserToResizeColumns = false;
            _containersBunifuDataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            _containersBunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _containersBunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _containersBunifuDataGridView1.BackgroundColor = Color.White;
            _containersBunifuDataGridView1.BorderStyle = BorderStyle.None;
            _containersBunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _containersBunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _containersBunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _containersBunifuDataGridView1.ColumnHeadersHeight = 40;
            _containersBunifuDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column5, Column7, grossWeight, Column14, Column16 });
            _containersBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _containersBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _containersBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _containersBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _containersBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _containersBunifuDataGridView1.CurrentTheme.BackColor = Color.Snow;
            _containersBunifuDataGridView1.CurrentTheme.GridColor = Color.Gray;
            _containersBunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _containersBunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _containersBunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _containersBunifuDataGridView1.CurrentTheme.Name = null;
            _containersBunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _containersBunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _containersBunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _containersBunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _containersBunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _containersBunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle6;
            _containersBunifuDataGridView1.Dock = DockStyle.Fill;
            _containersBunifuDataGridView1.EnableHeadersVisualStyles = false;
            _containersBunifuDataGridView1.GridColor = Color.Gray;
            _containersBunifuDataGridView1.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _containersBunifuDataGridView1.HeaderBgColor = Color.Empty;
            _containersBunifuDataGridView1.HeaderForeColor = Color.White;
            _containersBunifuDataGridView1.Location = new Point(0, 0);
            _containersBunifuDataGridView1.MultiSelect = false;
            _containersBunifuDataGridView1.Name = "_containersBunifuDataGridView1";
            _containersBunifuDataGridView1.ReadOnly = true;
            _containersBunifuDataGridView1.RowHeadersVisible = false;
            _containersBunifuDataGridView1.RowTemplate.Height = 35;
            _containersBunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _containersBunifuDataGridView1.Size = new Size(510, 624);
            _containersBunifuDataGridView1.TabIndex = 80;
            _containersBunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column6
            // 
            Column6.FillWeight = 31.41167f;
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.FillWeight = 170.5206f;
            Column1.HeaderText = "Container #";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 62.89331f;
            Column2.HeaderText = "H/S";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 86.6913f;
            Column3.HeaderText = "TARE";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 123.3734f;
            Column4.HeaderText = "Date";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 65.21121f;
            Column5.HeaderText = "Age";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // grossWeight
            // 
            grossWeight.HeaderText = "Column14";
            grossWeight.Name = "grossWeight";
            grossWeight.ReadOnly = true;
            grossWeight.Resizable = DataGridViewTriState.True;
            grossWeight.SortMode = DataGridViewColumnSortMode.Automatic;
            grossWeight.Visible = false;
            // 
            // Column14
            // 
            Column14.HeaderText = "truckCode";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Visible = false;
            // 
            // Column16
            // 
            Column16.FillWeight = 159.8985f;
            Column16.HeaderText = "Release #";
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Panel6
            // 
            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(Panel7);
            Panel6.Controls.Add(_searchBunifuTextBox1);
            Panel6.Dock = DockStyle.Bottom;
            Panel6.Location = new Point(0, 624);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(510, 43);
            Panel6.TabIndex = 79;
            // 
            // Panel7
            // 
            Panel7.Controls.Add(totalContainersLabel);
            Panel7.Dock = DockStyle.Left;
            Panel7.Location = new Point(0, 0);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(83, 41);
            Panel7.TabIndex = 7;
            // 
            // totalContainersLabel
            // 
            totalContainersLabel.AutoSize = true;
            totalContainersLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalContainersLabel.Location = new Point(4, 8);
            totalContainersLabel.Name = "totalContainersLabel";
            totalContainersLabel.Size = new Size(50, 21);
            totalContainersLabel.TabIndex = 7;
            totalContainersLabel.Text = "0 of 0";
            // 
            // searchBunifuTextBox1
            // 
            _searchBunifuTextBox1.AcceptsReturn = false;
            _searchBunifuTextBox1.AcceptsTab = false;
            _searchBunifuTextBox1.AnimationSpeed = 200;
            _searchBunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            _searchBunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            _searchBunifuTextBox1.BackColor = Color.Transparent;
            _searchBunifuTextBox1.BackgroundImage = (Image)resources.GetObject("searchBunifuTextBox1.BackgroundImage");
            _searchBunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            _searchBunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _searchBunifuTextBox1.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _searchBunifuTextBox1.BorderColorIdle = Color.Silver;
            _searchBunifuTextBox1.BorderRadius = 1;
            _searchBunifuTextBox1.BorderThickness = 1;
            _searchBunifuTextBox1.CharacterCasing = CharacterCasing.Upper;
            _searchBunifuTextBox1.Cursor = Cursors.IBeam;
            _searchBunifuTextBox1.DefaultFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _searchBunifuTextBox1.DefaultText = "";
            _searchBunifuTextBox1.FillColor = Color.White;
            _searchBunifuTextBox1.HideSelection = true;
            _searchBunifuTextBox1.IconLeft = null;
            _searchBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            _searchBunifuTextBox1.IconPadding = 10;
            _searchBunifuTextBox1.IconRight = null;
            _searchBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            _searchBunifuTextBox1.Lines = new string[0];
            _searchBunifuTextBox1.Location = new Point(96, 3);
            _searchBunifuTextBox1.MaxLength = 32767;
            _searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            _searchBunifuTextBox1.Modified = false;
            _searchBunifuTextBox1.Multiline = false;
            _searchBunifuTextBox1.Name = "_searchBunifuTextBox1";
            StateProperties13.BorderColor = Color.DodgerBlue;
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnActiveState = StateProperties13;
            StateProperties14.BorderColor = Color.Empty;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Empty;
            StateProperties14.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.OnDisabledState = StateProperties14;
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.FillColor = Color.Empty;
            StateProperties15.ForeColor = Color.Empty;
            StateProperties15.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Silver;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.Empty;
            StateProperties16.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnIdleState = StateProperties16;
            _searchBunifuTextBox1.PasswordChar = '\0';
            _searchBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.PlaceholderText = "SEARCH CONTAINER...";
            _searchBunifuTextBox1.ReadOnly = false;
            _searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            _searchBunifuTextBox1.SelectedText = "";
            _searchBunifuTextBox1.SelectionLength = 0;
            _searchBunifuTextBox1.SelectionStart = 0;
            _searchBunifuTextBox1.ShortcutsEnabled = true;
            _searchBunifuTextBox1.Size = new Size(270, 35);
            _searchBunifuTextBox1.Style = _Style.Bunifu;
            _searchBunifuTextBox1.TabIndex = 0;
            _searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            _searchBunifuTextBox1.TextMarginBottom = 0;
            _searchBunifuTextBox1.TextMarginLeft = 5;
            _searchBunifuTextBox1.TextMarginTop = 0;
            _searchBunifuTextBox1.TextPlaceholder = "SEARCH CONTAINER...";
            _searchBunifuTextBox1.UseSystemPasswordChar = false;
            _searchBunifuTextBox1.WordWrap = true;
            // 
            // FrmAssignContainer
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1557, 890);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAssignContainer";
            Text = "FrmAssignContainer";
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            BunifuShadowPanel2.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ShapedPanel1.ResumeLayout(false);
            TableLayoutPanel3.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_assignedContainersBunifuDataGridView2).EndInit();
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_containersBunifuDataGridView1).EndInit();
            Panel6.ResumeLayout(false);
            Panel7.ResumeLayout(false);
            Panel7.PerformLayout();
            Load += new EventHandler(FrmAssignContainer_Load);
            ResumeLayout(false);
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        internal Panel Panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _assignBunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton assignBunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _assignBunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_assignBunifuButton1 != null)
                {
                    _assignBunifuButton1.Click -= assignBunifuButton1_Click;
                }

                _assignBunifuButton1 = value;
                if (_assignBunifuButton1 != null)
                {
                    _assignBunifuButton1.Click += assignBunifuButton1_Click;
                }
            }
        }

        internal Panel Panel3;
        internal Label Label3;
        internal Label Label2;
        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _assignedContainersBunifuDataGridView2;

        internal Bunifu.UI.WinForms.BunifuDataGridView assignedContainersBunifuDataGridView2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _assignedContainersBunifuDataGridView2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_assignedContainersBunifuDataGridView2 != null)
                {
                    _assignedContainersBunifuDataGridView2.CellContentClick -= assignedContainersBunifuDataGridView2_CellContentClick;
                    _assignedContainersBunifuDataGridView2.RowPostPaint -= assignedContainersBunifuDataGridView2_RowPostPaint;
                }

                _assignedContainersBunifuDataGridView2 = value;
                if (_assignedContainersBunifuDataGridView2 != null)
                {
                    _assignedContainersBunifuDataGridView2.CellContentClick += assignedContainersBunifuDataGridView2_CellContentClick;
                    _assignedContainersBunifuDataGridView2.RowPostPaint += assignedContainersBunifuDataGridView2_RowPostPaint;
                }
            }
        }

        internal Label Label1;
        private ComboBox _bookingComboBox;

        internal ComboBox bookingComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bookingComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bookingComboBox != null)
                {
                    _bookingComboBox.SelectedIndexChanged -= bookingComboBox_SelectedIndexChanged;
                }

                _bookingComboBox = value;
                if (_bookingComboBox != null)
                {
                    _bookingComboBox.SelectedIndexChanged += bookingComboBox_SelectedIndexChanged;
                }
            }
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel2;
        internal TableLayoutPanel TableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _holdButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton holdButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _holdButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_holdButton != null)
                {
                    _holdButton.Click -= holdButton_Click;
                }

                _holdButton = value;
                if (_holdButton != null)
                {
                    _holdButton.Click += holdButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _transloadButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton transloadButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _transloadButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_transloadButton != null)
                {
                    _transloadButton.Click -= transloadButton_Click;
                }

                _transloadButton = value;
                if (_transloadButton != null)
                {
                    _transloadButton.Click += transloadButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _removeButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton removeButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _removeButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_removeButton != null)
                {
                    _removeButton.Click -= deleteButton_Click;
                }

                _removeButton = value;
                if (_removeButton != null)
                {
                    _removeButton.Click += deleteButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _containersBunifuDataGridView1;

        internal Bunifu.UI.WinForms.BunifuDataGridView containersBunifuDataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _containersBunifuDataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_containersBunifuDataGridView1 != null)
                {
                    _containersBunifuDataGridView1.CellContentClick -= summaryBunifuDataGridView_CellContentClick;
                    _containersBunifuDataGridView1.SelectionChanged -= containersBunifuDataGridView1_SelectionChanged;
                }

                _containersBunifuDataGridView1 = value;
                if (_containersBunifuDataGridView1 != null)
                {
                    _containersBunifuDataGridView1.CellContentClick += summaryBunifuDataGridView_CellContentClick;
                    _containersBunifuDataGridView1.SelectionChanged += containersBunifuDataGridView1_SelectionChanged;
                }
            }
        }

        internal Panel Panel6;
        internal Panel Panel7;
        internal Label totalContainersLabel;
        private BunifuTextBox _searchBunifuTextBox1;

        internal BunifuTextBox searchBunifuTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _searchBunifuTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.KeyDown -= searchBunifuTextBox1_KeyDown;
                }

                _searchBunifuTextBox1 = value;
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.KeyDown += searchBunifuTextBox1_KeyDown;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label13;
        internal Label label56;
        internal Label label22;
        internal Label LRDLabel;
        internal Label cansLabel;
        internal Label typeLabel;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label6;
        internal Label Label8;
        internal Label Label9;
        internal Label customerNameLabel;
        internal Label ssLineLabel;
        internal Label bookingLabel;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel1;
        internal Label statusLabel;
        internal Label vesselLabel;
        internal Label Label19;
        internal Timer Timer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton2;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton2 != null)
                {
                    _BunifuButton2.Click -= BunifuButton2_Click;
                }

                _BunifuButton2 = value;
                if (_BunifuButton2 != null)
                {
                    _BunifuButton2.Click += BunifuButton2_Click;
                }
            }
        }

        internal DataGridViewCheckBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewCheckBoxColumn grossWeight;
        internal DataGridViewTextBoxColumn Column14;
        internal DataGridViewTextBoxColumn Column16;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _changeBookingBtn;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton changeBookingBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _changeBookingBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_changeBookingBtn != null)
                {
                    _changeBookingBtn.Click -= changeBookingBtn_Click;
                }

                _changeBookingBtn = value;
                if (_changeBookingBtn != null)
                {
                    _changeBookingBtn.Click += changeBookingBtn_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuCheckBox _selectAllCheckBox;

        internal Bunifu.UI.WinForms.BunifuCheckBox selectAllCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _selectAllCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_selectAllCheckBox != null)
                {
                    _selectAllCheckBox.CheckedChanged -= selectAllCheckBox_CheckedChanged;
                }

                _selectAllCheckBox = value;
                if (_selectAllCheckBox != null)
                {
                    _selectAllCheckBox.CheckedChanged += selectAllCheckBox_CheckedChanged;
                }
            }
        }

        private Bunifu.ToggleSwitch.BunifuToggleSwitch _bookingActivBookingBunifuToggleSwitch2;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch bookingActivBookingBunifuToggleSwitch2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bookingActivBookingBunifuToggleSwitch2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bookingActivBookingBunifuToggleSwitch2 != null)
                {
                    _bookingActivBookingBunifuToggleSwitch2.OnValuechange -= bookingActivBookingBunifuToggleSwitch2_OnValuechange;
                }

                _bookingActivBookingBunifuToggleSwitch2 = value;
                if (_bookingActivBookingBunifuToggleSwitch2 != null)
                {
                    _bookingActivBookingBunifuToggleSwitch2.OnValuechange += bookingActivBookingBunifuToggleSwitch2_OnValuechange;
                }
            }
        }

        internal Label Label7;
        internal Label Label10;
        internal DataGridViewCheckBoxColumn Column13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column11;
        internal DataGridViewTextBoxColumn Column12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewCheckBoxColumn Column15;
        internal DataGridViewTextBoxColumn truckout;
        internal DataGridViewTextBoxColumn Column17;
    }
}