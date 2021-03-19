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
    public partial class FrmAddEditRelease : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditRelease));
            var BorderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties25 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties26 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var BorderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle19 = new DataGridViewCellStyle();
            var DataGridViewCellStyle20 = new DataGridViewCellStyle();
            var BorderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties31 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties32 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties33 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties34 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties35 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties36 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties37 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties38 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties39 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties40 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            lblBalance = new Label();
            Label17 = new Label();
            lblReqRelease = new Label();
            Panel1 = new Panel();
            Label4 = new Label();
            _tbReleaseNumber = new TextBox();
            _tbReleaseNumber.TextChanged += new EventHandler(tbReleaseNumber_TextChanged);
            _bdnSaveRelease = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _bdnSaveRelease.Click += new EventHandler(bdnSaveRelease_Click);
            Label15 = new Label();
            lblReleaseType = new Label();
            Label33 = new Label();
            ShapedPanel3 = new CustomizedControlsLibrary.ShapedPanel();
            _tbSeacrhBooking = new BunifuTextBox();
            _tbSeacrhBooking.TextChanged += new EventHandler(tbSeacrhBooking_TextChanged);
            lblTotalBks = new Label();
            Label5 = new Label();
            dgvBookingRelease = new Bunifu.UI.WinForms.BunifuDataGridView();
            VWReleaseOrderMinibookingBindingSource = new BindingSource(components);
            Label7 = new Label();
            _btnRmBooking = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRmBooking.Click += new EventHandler(btnRmBooking_Click);
            _btnAddReleaseDetail = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddReleaseDetail.Click += new EventHandler(btnAddReleaseDetail_Click);
            ShapedPanel1 = new CustomizedControlsLibrary.ShapedPanel();
            lblTotalRelDetails = new Label();
            Label12 = new Label();
            _dgvReleaseDetail = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvReleaseDetail.DoubleClick += new EventHandler(dgvReleaseDetail_DoubleClick);
            _dgvReleaseDetail.SelectionChanged += new EventHandler(dgvReleaseDetail_SelectionChanged);
            DateAcceptedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QtyAcceptedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ReleaseOrderBindingSource = new BindingSource(components);
            Label3 = new Label();
            _btnRmReleaseDetail = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRmReleaseDetail.Click += new EventHandler(btnRmReleaseDetail_Click);
            Label9 = new Label();
            PictureBox1 = new PictureBox();
            BunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label14 = new Label();
            BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label10 = new Label();
            DateAccepted = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ReleaseOrderId = new DataGridViewTextBoxColumn();
            TableLayoutPanel1 = new TableLayoutPanel();
            Panel2 = new Panel();
            Label6 = new Label();
            Label11 = new Label();
            Label16 = new Label();
            _btnAddBooking = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddBooking.Click += new EventHandler(btnAddBooking_Click);
            MinibookingNumber = new DataGridViewTextBoxColumn();
            QtyRequestedMb = new DataGridViewTextBoxColumn();
            BunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label1 = new Label();
            Label13 = new Label();
            Panel1.SuspendLayout();
            ShapedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingRelease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWReleaseOrderMinibookingBindingSource).BeginInit();
            ShapedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvReleaseDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReleaseOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
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
            _closeFlatButton.Location = new Point(756, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 36);
            _closeFlatButton.TabIndex = 184;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label8
            // 
            Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Dock = DockStyle.Top;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(0, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(799, 36);
            Label8.TabIndex = 183;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBalance.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblBalance.Location = new Point(77, 8);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(25, 26);
            lblBalance.TabIndex = 220;
            lblBalance.Text = "0";
            lblBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Location = new Point(3, 10);
            Label17.Name = "Label17";
            Label17.Size = new Size(71, 20);
            Label17.TabIndex = 217;
            Label17.Text = "Balance:";
            Label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblReqRelease
            // 
            lblReqRelease.AutoSize = true;
            lblReqRelease.BackColor = Color.Transparent;
            lblReqRelease.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblReqRelease.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblReqRelease.Location = new Point(113, 7);
            lblReqRelease.Name = "lblReqRelease";
            lblReqRelease.Size = new Size(25, 26);
            lblReqRelease.TabIndex = 222;
            lblReqRelease.Text = "0";
            lblReqRelease.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.LemonChiffon;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(Label17);
            Panel1.Controls.Add(lblBalance);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(177, 0);
            Panel1.Margin = new Padding(0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(150, 50);
            Panel1.TabIndex = 224;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(59, 133);
            Label4.Name = "Label4";
            Label4.Size = new Size(123, 18);
            Label4.TabIndex = 226;
            Label4.Text = "Release Number:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbReleaseNumber
            // 
            _tbReleaseNumber.CharacterCasing = CharacterCasing.Upper;
            _tbReleaseNumber.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _tbReleaseNumber.Location = new Point(188, 129);
            _tbReleaseNumber.Name = "_tbReleaseNumber";
            _tbReleaseNumber.Size = new Size(194, 26);
            _tbReleaseNumber.TabIndex = 227;
            // 
            // bdnSaveRelease
            // 
            _bdnSaveRelease.AllowToggling = false;
            _bdnSaveRelease.AnimationSpeed = 200;
            _bdnSaveRelease.AutoGenerateColors = false;
            _bdnSaveRelease.BackColor = Color.Transparent;
            _bdnSaveRelease.BackColor1 = Color.Teal;
            _bdnSaveRelease.BackgroundImage = (Image)resources.GetObject("bdnSaveRelease.BackgroundImage");
            _bdnSaveRelease.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _bdnSaveRelease.ButtonText = "Save";
            _bdnSaveRelease.ButtonTextMarginLeft = 0;
            _bdnSaveRelease.ColorContrastOnClick = 45;
            _bdnSaveRelease.ColorContrastOnHover = 45;
            _bdnSaveRelease.Cursor = Cursors.Hand;
            BorderEdges9.BottomLeft = true;
            BorderEdges9.BottomRight = true;
            BorderEdges9.TopLeft = true;
            BorderEdges9.TopRight = true;
            _bdnSaveRelease.CustomizableEdges = BorderEdges9;
            _bdnSaveRelease.DialogResult = DialogResult.None;
            _bdnSaveRelease.DisabledBorderColor = Color.Empty;
            _bdnSaveRelease.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _bdnSaveRelease.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _bdnSaveRelease.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _bdnSaveRelease.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _bdnSaveRelease.ForeColor = Color.White;
            _bdnSaveRelease.IconLeftCursor = Cursors.Hand;
            _bdnSaveRelease.IconMarginLeft = 11;
            _bdnSaveRelease.IconPadding = 10;
            _bdnSaveRelease.IconRightCursor = Cursors.Hand;
            _bdnSaveRelease.IdleBorderColor = Color.Teal;
            _bdnSaveRelease.IdleBorderRadius = 3;
            _bdnSaveRelease.IdleBorderThickness = 1;
            _bdnSaveRelease.IdleFillColor = Color.Teal;
            _bdnSaveRelease.IdleIconLeftImage = null;
            _bdnSaveRelease.IdleIconRightImage = null;
            _bdnSaveRelease.IndicateFocus = true;
            _bdnSaveRelease.Location = new Point(343, 492);
            _bdnSaveRelease.Name = "_bdnSaveRelease";
            StateProperties21.BorderColor = Color.MediumTurquoise;
            StateProperties21.BorderRadius = 3;
            StateProperties21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties21.BorderThickness = 1;
            StateProperties21.FillColor = Color.MediumTurquoise;
            StateProperties21.ForeColor = Color.White;
            StateProperties21.IconLeftImage = null;
            StateProperties21.IconRightImage = null;
            _bdnSaveRelease.onHoverState = StateProperties21;
            StateProperties22.BorderColor = Color.Teal;
            StateProperties22.BorderRadius = 3;
            StateProperties22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties22.BorderThickness = 1;
            StateProperties22.FillColor = Color.Teal;
            StateProperties22.ForeColor = Color.White;
            StateProperties22.IconLeftImage = null;
            StateProperties22.IconRightImage = null;
            _bdnSaveRelease.OnPressedState = StateProperties22;
            _bdnSaveRelease.Size = new Size(120, 33);
            _bdnSaveRelease.TabIndex = 136;
            _bdnSaveRelease.TextAlign = ContentAlignment.MiddleCenter;
            _bdnSaveRelease.TextMarginLeft = 0;
            _bdnSaveRelease.UseDefaultRadiusAndThickness = true;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label15.Location = new Point(21, 44);
            Label15.Name = "Label15";
            Label15.Size = new Size(133, 25);
            Label15.TabIndex = 228;
            Label15.Text = "Create release";
            // 
            // lblReleaseType
            // 
            lblReleaseType.AutoSize = true;
            lblReleaseType.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblReleaseType.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblReleaseType.Location = new Point(185, 169);
            lblReleaseType.Name = "lblReleaseType";
            lblReleaseType.Size = new Size(108, 18);
            lblReleaseType.TabIndex = 239;
            lblReleaseType.Text = "Shipping Line";
            lblReleaseType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label33.Location = new Point(82, 169);
            Label33.Name = "Label33";
            Label33.Size = new Size(97, 18);
            Label33.TabIndex = 240;
            Label33.Text = "Release type:";
            Label33.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ShapedPanel3
            // 
            ShapedPanel3.BackColor = Color.Gray;
            ShapedPanel3.BorderColor = Color.Gray;
            ShapedPanel3.Controls.Add(_tbSeacrhBooking);
            ShapedPanel3.Controls.Add(lblTotalBks);
            ShapedPanel3.Controls.Add(Label5);
            ShapedPanel3.Controls.Add(dgvBookingRelease);
            ShapedPanel3.Controls.Add(Label7);
            ShapedPanel3.Edge = 2;
            ShapedPanel3.Location = new Point(477, 264);
            ShapedPanel3.Name = "ShapedPanel3";
            ShapedPanel3.Padding = new Padding(1);
            ShapedPanel3.Size = new Size(233, 173);
            ShapedPanel3.TabIndex = 242;
            // 
            // tbSeacrhBooking
            // 
            _tbSeacrhBooking.AcceptsReturn = false;
            _tbSeacrhBooking.AcceptsTab = false;
            _tbSeacrhBooking.AnimationSpeed = 200;
            _tbSeacrhBooking.AutoCompleteMode = AutoCompleteMode.None;
            _tbSeacrhBooking.AutoCompleteSource = AutoCompleteSource.None;
            _tbSeacrhBooking.BackColor = Color.Transparent;
            _tbSeacrhBooking.BackgroundImage = (Image)resources.GetObject("tbSeacrhBooking.BackgroundImage");
            _tbSeacrhBooking.BorderColorActive = Color.DodgerBlue;
            _tbSeacrhBooking.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbSeacrhBooking.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbSeacrhBooking.BorderColorIdle = Color.Silver;
            _tbSeacrhBooking.BorderRadius = 1;
            _tbSeacrhBooking.BorderThickness = 1;
            _tbSeacrhBooking.CharacterCasing = CharacterCasing.Upper;
            _tbSeacrhBooking.Cursor = Cursors.IBeam;
            _tbSeacrhBooking.DefaultFont = new Font("Segoe UI Semibold", 9.0f);
            _tbSeacrhBooking.DefaultText = "";
            _tbSeacrhBooking.FillColor = Color.White;
            _tbSeacrhBooking.HideSelection = true;
            _tbSeacrhBooking.IconLeft = null;
            _tbSeacrhBooking.IconLeftCursor = Cursors.IBeam;
            _tbSeacrhBooking.IconPadding = 10;
            _tbSeacrhBooking.IconRight = null;
            _tbSeacrhBooking.IconRightCursor = Cursors.IBeam;
            _tbSeacrhBooking.Lines = new string[0];
            _tbSeacrhBooking.Location = new Point(77, 151);
            _tbSeacrhBooking.MaxLength = 32767;
            _tbSeacrhBooking.MinimumSize = new Size(100, 10);
            _tbSeacrhBooking.Modified = false;
            _tbSeacrhBooking.Multiline = false;
            _tbSeacrhBooking.Name = "_tbSeacrhBooking";
            StateProperties23.BorderColor = Color.DodgerBlue;
            StateProperties23.FillColor = Color.Empty;
            StateProperties23.ForeColor = Color.Empty;
            StateProperties23.PlaceholderForeColor = Color.Empty;
            _tbSeacrhBooking.OnActiveState = StateProperties23;
            StateProperties24.BorderColor = Color.Empty;
            StateProperties24.FillColor = Color.White;
            StateProperties24.ForeColor = Color.Empty;
            StateProperties24.PlaceholderForeColor = Color.Silver;
            _tbSeacrhBooking.OnDisabledState = StateProperties24;
            StateProperties25.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties25.FillColor = Color.Empty;
            StateProperties25.ForeColor = Color.Empty;
            StateProperties25.PlaceholderForeColor = Color.Empty;
            _tbSeacrhBooking.OnHoverState = StateProperties25;
            StateProperties26.BorderColor = Color.Silver;
            StateProperties26.FillColor = Color.White;
            StateProperties26.ForeColor = Color.Empty;
            StateProperties26.PlaceholderForeColor = Color.Empty;
            _tbSeacrhBooking.OnIdleState = StateProperties26;
            _tbSeacrhBooking.PasswordChar = '\0';
            _tbSeacrhBooking.PlaceholderForeColor = Color.Silver;
            _tbSeacrhBooking.PlaceholderText = "SEARCH...";
            _tbSeacrhBooking.ReadOnly = false;
            _tbSeacrhBooking.ScrollBars = ScrollBars.None;
            _tbSeacrhBooking.SelectedText = "";
            _tbSeacrhBooking.SelectionLength = 0;
            _tbSeacrhBooking.SelectionStart = 0;
            _tbSeacrhBooking.ShortcutsEnabled = true;
            _tbSeacrhBooking.Size = new Size(127, 21);
            _tbSeacrhBooking.Style = _Style.Bunifu;
            _tbSeacrhBooking.TabIndex = 244;
            _tbSeacrhBooking.TextAlign = HorizontalAlignment.Left;
            _tbSeacrhBooking.TextMarginBottom = 0;
            _tbSeacrhBooking.TextMarginLeft = 5;
            _tbSeacrhBooking.TextMarginTop = 0;
            _tbSeacrhBooking.TextPlaceholder = "SEARCH...";
            _tbSeacrhBooking.UseSystemPasswordChar = false;
            _tbSeacrhBooking.WordWrap = true;
            // 
            // lblTotalBks
            // 
            lblTotalBks.AutoSize = true;
            lblTotalBks.BackColor = Color.Gray;
            lblTotalBks.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalBks.ForeColor = Color.White;
            lblTotalBks.Location = new Point(34, 153);
            lblTotalBks.Name = "lblTotalBks";
            lblTotalBks.Size = new Size(17, 18);
            lblTotalBks.TabIndex = 244;
            lblTotalBks.Text = "0" + '\r' + '\n';
            lblTotalBks.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(2, 152);
            Label5.Name = "Label5";
            Label5.Size = new Size(35, 18);
            Label5.TabIndex = 227;
            Label5.Text = "Qty:";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvBookingRelease
            // 
            dgvBookingRelease.AllowCustomTheming = true;
            dgvBookingRelease.AllowUserToAddRows = false;
            dgvBookingRelease.AllowUserToDeleteRows = false;
            dgvBookingRelease.AllowUserToOrderColumns = true;
            dgvBookingRelease.AllowUserToResizeRows = false;
            DataGridViewCellStyle11.BackColor = SystemColors.Control;
            DataGridViewCellStyle11.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle11.ForeColor = Color.Black;
            DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBookingRelease.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11;
            dgvBookingRelease.AutoGenerateColumns = false;
            dgvBookingRelease.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingRelease.BackgroundColor = Color.White;
            dgvBookingRelease.BorderStyle = BorderStyle.None;
            dgvBookingRelease.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvBookingRelease.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvBookingRelease.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.Gray;
            DataGridViewCellStyle12.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle12.ForeColor = Color.White;
            DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvBookingRelease.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12;
            dgvBookingRelease.ColumnHeadersHeight = 25;
            dgvBookingRelease.Columns.AddRange(new DataGridViewColumn[] { MinibookingNumber, QtyRequestedMb });
            dgvBookingRelease.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            dgvBookingRelease.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            dgvBookingRelease.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvBookingRelease.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvBookingRelease.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvBookingRelease.CurrentTheme.BackColor = Color.White;
            dgvBookingRelease.CurrentTheme.GridColor = Color.Gainsboro;
            dgvBookingRelease.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            dgvBookingRelease.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            dgvBookingRelease.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvBookingRelease.CurrentTheme.Name = null;
            dgvBookingRelease.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvBookingRelease.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            dgvBookingRelease.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvBookingRelease.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvBookingRelease.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dgvBookingRelease.DataSource = VWReleaseOrderMinibookingBindingSource;
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle13.BackColor = Color.White;
            DataGridViewCellStyle13.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle13.ForeColor = Color.Black;
            DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle13.SelectionForeColor = Color.Black;
            DataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvBookingRelease.DefaultCellStyle = DataGridViewCellStyle13;
            dgvBookingRelease.Dock = DockStyle.Top;
            dgvBookingRelease.EnableHeadersVisualStyles = false;
            dgvBookingRelease.GridColor = Color.Gainsboro;
            dgvBookingRelease.HeaderBackColor = Color.Gray;
            dgvBookingRelease.HeaderBgColor = Color.Empty;
            dgvBookingRelease.HeaderForeColor = Color.White;
            dgvBookingRelease.Location = new Point(1, 1);
            dgvBookingRelease.MultiSelect = false;
            dgvBookingRelease.Name = "dgvBookingRelease";
            dgvBookingRelease.ReadOnly = true;
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvBookingRelease.RowHeadersDefaultCellStyle = DataGridViewCellStyle14;
            dgvBookingRelease.RowHeadersVisible = false;
            dgvBookingRelease.RowHeadersWidth = 29;
            DataGridViewCellStyle15.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvBookingRelease.RowsDefaultCellStyle = DataGridViewCellStyle15;
            dgvBookingRelease.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            dgvBookingRelease.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvBookingRelease.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvBookingRelease.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBookingRelease.RowTemplate.Height = 27;
            dgvBookingRelease.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookingRelease.Size = new Size(231, 149);
            dgvBookingRelease.TabIndex = 141;
            dgvBookingRelease.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // VWReleaseOrderMinibookingBindingSource
            // 
            // Me.VWReleaseOrderMinibookingBindingSource.DataSource = GetType(ModelLayer.VW_ReleaseOrderMinibooking)
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Narrow", 6.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(3, 16);
            Label7.Name = "Label7";
            Label7.Size = new Size(34, 13);
            Label7.TabIndex = 140;
            Label7.Text = "FILTER";
            // 
            // btnRmBooking
            // 
            _btnRmBooking.AllowToggling = false;
            _btnRmBooking.AnimationSpeed = 200;
            _btnRmBooking.AutoGenerateColors = false;
            _btnRmBooking.BackColor = Color.Transparent;
            _btnRmBooking.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmBooking.BackgroundImage = (Image)resources.GetObject("btnRmBooking.BackgroundImage");
            _btnRmBooking.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRmBooking.ButtonText = "";
            _btnRmBooking.ButtonTextMarginLeft = 0;
            _btnRmBooking.ColorContrastOnClick = 45;
            _btnRmBooking.ColorContrastOnHover = 45;
            _btnRmBooking.Cursor = Cursors.Hand;
            BorderEdges10.BottomLeft = true;
            BorderEdges10.BottomRight = true;
            BorderEdges10.TopLeft = true;
            BorderEdges10.TopRight = true;
            _btnRmBooking.CustomizableEdges = BorderEdges10;
            _btnRmBooking.DialogResult = DialogResult.None;
            _btnRmBooking.DisabledBorderColor = Color.Empty;
            _btnRmBooking.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRmBooking.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRmBooking.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRmBooking.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRmBooking.ForeColor = Color.White;
            _btnRmBooking.IconLeftCursor = Cursors.Hand;
            _btnRmBooking.IconMarginLeft = 5;
            _btnRmBooking.IconPadding = 5;
            _btnRmBooking.IconRightCursor = Cursors.Hand;
            _btnRmBooking.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmBooking.IdleBorderRadius = 20;
            _btnRmBooking.IdleBorderThickness = 1;
            _btnRmBooking.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmBooking.IdleIconLeftImage = My.Resources.Resources.removeWhite;
            _btnRmBooking.IdleIconRightImage = null;
            _btnRmBooking.IndicateFocus = true;
            _btnRmBooking.Location = new Point(713, 391);
            _btnRmBooking.Name = "_btnRmBooking";
            StateProperties27.BorderColor = Color.Red;
            StateProperties27.BorderRadius = 20;
            StateProperties27.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties27.BorderThickness = 1;
            StateProperties27.FillColor = Color.Red;
            StateProperties27.ForeColor = Color.White;
            StateProperties27.IconLeftImage = null;
            StateProperties27.IconRightImage = null;
            _btnRmBooking.onHoverState = StateProperties27;
            StateProperties28.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties28.BorderRadius = 20;
            StateProperties28.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties28.BorderThickness = 1;
            StateProperties28.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties28.ForeColor = Color.White;
            StateProperties28.IconLeftImage = null;
            StateProperties28.IconRightImage = null;
            _btnRmBooking.OnPressedState = StateProperties28;
            _btnRmBooking.Size = new Size(24, 23);
            _btnRmBooking.TabIndex = 245;
            _btnRmBooking.TextAlign = ContentAlignment.MiddleCenter;
            _btnRmBooking.TextMarginLeft = 0;
            _btnRmBooking.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddReleaseDetail
            // 
            _btnAddReleaseDetail.AllowToggling = false;
            _btnAddReleaseDetail.AnimationSpeed = 200;
            _btnAddReleaseDetail.AutoGenerateColors = false;
            _btnAddReleaseDetail.BackColor = Color.Transparent;
            _btnAddReleaseDetail.BackColor1 = Color.Teal;
            _btnAddReleaseDetail.BackgroundImage = (Image)resources.GetObject("btnAddReleaseDetail.BackgroundImage");
            _btnAddReleaseDetail.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddReleaseDetail.ButtonText = " ";
            _btnAddReleaseDetail.ButtonTextMarginLeft = 0;
            _btnAddReleaseDetail.ColorContrastOnClick = 45;
            _btnAddReleaseDetail.ColorContrastOnHover = 45;
            _btnAddReleaseDetail.Cursor = Cursors.Hand;
            BorderEdges11.BottomLeft = true;
            BorderEdges11.BottomRight = true;
            BorderEdges11.TopLeft = true;
            BorderEdges11.TopRight = true;
            _btnAddReleaseDetail.CustomizableEdges = BorderEdges11;
            _btnAddReleaseDetail.DialogResult = DialogResult.None;
            _btnAddReleaseDetail.DisabledBorderColor = Color.Empty;
            _btnAddReleaseDetail.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddReleaseDetail.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddReleaseDetail.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddReleaseDetail.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddReleaseDetail.ForeColor = Color.White;
            _btnAddReleaseDetail.IconLeftCursor = Cursors.Hand;
            _btnAddReleaseDetail.IconMarginLeft = 7;
            _btnAddReleaseDetail.IconPadding = 7;
            _btnAddReleaseDetail.IconRightCursor = Cursors.Hand;
            _btnAddReleaseDetail.IdleBorderColor = Color.Teal;
            _btnAddReleaseDetail.IdleBorderRadius = 23;
            _btnAddReleaseDetail.IdleBorderThickness = 1;
            _btnAddReleaseDetail.IdleFillColor = Color.Teal;
            _btnAddReleaseDetail.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddReleaseDetail.IdleIconRightImage = null;
            _btnAddReleaseDetail.IndicateFocus = true;
            _btnAddReleaseDetail.Location = new Point(290, 263);
            _btnAddReleaseDetail.Name = "_btnAddReleaseDetail";
            StateProperties29.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties29.BorderRadius = 23;
            StateProperties29.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties29.BorderThickness = 1;
            StateProperties29.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties29.ForeColor = Color.White;
            StateProperties29.IconLeftImage = null;
            StateProperties29.IconRightImage = null;
            _btnAddReleaseDetail.onHoverState = StateProperties29;
            StateProperties30.BorderColor = Color.Teal;
            StateProperties30.BorderRadius = 23;
            StateProperties30.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties30.BorderThickness = 1;
            StateProperties30.FillColor = Color.Teal;
            StateProperties30.ForeColor = Color.White;
            StateProperties30.IconLeftImage = null;
            StateProperties30.IconRightImage = null;
            _btnAddReleaseDetail.OnPressedState = StateProperties30;
            _btnAddReleaseDetail.Size = new Size(25, 25);
            _btnAddReleaseDetail.TabIndex = 247;
            _btnAddReleaseDetail.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddReleaseDetail.TextMarginLeft = 0;
            _btnAddReleaseDetail.UseDefaultRadiusAndThickness = true;
            // 
            // ShapedPanel1
            // 
            ShapedPanel1.BackColor = Color.Gray;
            ShapedPanel1.BorderColor = Color.Gray;
            ShapedPanel1.Controls.Add(lblTotalRelDetails);
            ShapedPanel1.Controls.Add(Label12);
            ShapedPanel1.Controls.Add(_dgvReleaseDetail);
            ShapedPanel1.Controls.Add(Label3);
            ShapedPanel1.Edge = 2;
            ShapedPanel1.Location = new Point(91, 264);
            ShapedPanel1.Name = "ShapedPanel1";
            ShapedPanel1.Padding = new Padding(1);
            ShapedPanel1.Size = new Size(196, 171);
            ShapedPanel1.TabIndex = 246;
            // 
            // lblTotalRelDetails
            // 
            lblTotalRelDetails.AutoSize = true;
            lblTotalRelDetails.BackColor = Color.Gray;
            lblTotalRelDetails.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalRelDetails.ForeColor = Color.White;
            lblTotalRelDetails.Location = new Point(37, 152);
            lblTotalRelDetails.Name = "lblTotalRelDetails";
            lblTotalRelDetails.Size = new Size(17, 18);
            lblTotalRelDetails.TabIndex = 246;
            lblTotalRelDetails.Text = "0" + '\r' + '\n';
            lblTotalRelDetails.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.White;
            Label12.Location = new Point(4, 152);
            Label12.Name = "Label12";
            Label12.Size = new Size(35, 18);
            Label12.TabIndex = 245;
            Label12.Text = "Qty:";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvReleaseDetail
            // 
            _dgvReleaseDetail.AllowCustomTheming = true;
            _dgvReleaseDetail.AllowUserToAddRows = false;
            _dgvReleaseDetail.AllowUserToDeleteRows = false;
            _dgvReleaseDetail.AllowUserToOrderColumns = true;
            _dgvReleaseDetail.AllowUserToResizeRows = false;
            DataGridViewCellStyle16.BackColor = SystemColors.Control;
            DataGridViewCellStyle16.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle16.ForeColor = Color.Black;
            DataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvReleaseDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16;
            _dgvReleaseDetail.AutoGenerateColumns = false;
            _dgvReleaseDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvReleaseDetail.BackgroundColor = Color.White;
            _dgvReleaseDetail.BorderStyle = BorderStyle.None;
            _dgvReleaseDetail.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgvReleaseDetail.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvReleaseDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle17.BackColor = Color.Gray;
            DataGridViewCellStyle17.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle17.ForeColor = Color.White;
            DataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            _dgvReleaseDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17;
            _dgvReleaseDetail.ColumnHeadersHeight = 25;
            _dgvReleaseDetail.Columns.AddRange(new DataGridViewColumn[] { DateAcceptedDataGridViewTextBoxColumn, QtyAcceptedDataGridViewTextBoxColumn });
            _dgvReleaseDetail.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _dgvReleaseDetail.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgvReleaseDetail.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvReleaseDetail.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvReleaseDetail.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvReleaseDetail.CurrentTheme.BackColor = Color.White;
            _dgvReleaseDetail.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvReleaseDetail.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            _dgvReleaseDetail.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgvReleaseDetail.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvReleaseDetail.CurrentTheme.Name = null;
            _dgvReleaseDetail.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvReleaseDetail.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgvReleaseDetail.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvReleaseDetail.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvReleaseDetail.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvReleaseDetail.DataSource = ReleaseOrderBindingSource;
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle18.BackColor = Color.White;
            DataGridViewCellStyle18.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle18.ForeColor = Color.Black;
            DataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle18.SelectionForeColor = Color.Black;
            DataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            _dgvReleaseDetail.DefaultCellStyle = DataGridViewCellStyle18;
            _dgvReleaseDetail.Dock = DockStyle.Top;
            _dgvReleaseDetail.EnableHeadersVisualStyles = false;
            _dgvReleaseDetail.GridColor = Color.Gainsboro;
            _dgvReleaseDetail.HeaderBackColor = Color.Gray;
            _dgvReleaseDetail.HeaderBgColor = Color.Empty;
            _dgvReleaseDetail.HeaderForeColor = Color.White;
            _dgvReleaseDetail.Location = new Point(1, 1);
            _dgvReleaseDetail.MultiSelect = false;
            _dgvReleaseDetail.Name = "_dgvReleaseDetail";
            _dgvReleaseDetail.ReadOnly = true;
            DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            _dgvReleaseDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle19;
            _dgvReleaseDetail.RowHeadersVisible = false;
            _dgvReleaseDetail.RowHeadersWidth = 29;
            DataGridViewCellStyle20.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvReleaseDetail.RowsDefaultCellStyle = DataGridViewCellStyle20;
            _dgvReleaseDetail.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgvReleaseDetail.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgvReleaseDetail.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvReleaseDetail.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgvReleaseDetail.RowTemplate.Height = 27;
            _dgvReleaseDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvReleaseDetail.Size = new Size(194, 147);
            _dgvReleaseDetail.TabIndex = 141;
            _dgvReleaseDetail.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DateAcceptedDataGridViewTextBoxColumn
            // 
            DateAcceptedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateAcceptedDataGridViewTextBoxColumn.DataPropertyName = "DateAccepted";
            DateAcceptedDataGridViewTextBoxColumn.FillWeight = 142.132f;
            DateAcceptedDataGridViewTextBoxColumn.HeaderText = "Date Accepted";
            DateAcceptedDataGridViewTextBoxColumn.Name = "DateAcceptedDataGridViewTextBoxColumn";
            DateAcceptedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QtyAcceptedDataGridViewTextBoxColumn
            // 
            QtyAcceptedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QtyAcceptedDataGridViewTextBoxColumn.DataPropertyName = "QtyAccepted";
            QtyAcceptedDataGridViewTextBoxColumn.FillWeight = 57.86803f;
            QtyAcceptedDataGridViewTextBoxColumn.HeaderText = "Qty";
            QtyAcceptedDataGridViewTextBoxColumn.Name = "QtyAcceptedDataGridViewTextBoxColumn";
            QtyAcceptedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReleaseOrderBindingSource
            // 
            ReleaseOrderBindingSource.DataSource = typeof(ModelLayer.ReleaseOrder);
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Narrow", 6.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(3, 16);
            Label3.Name = "Label3";
            Label3.Size = new Size(34, 13);
            Label3.TabIndex = 140;
            Label3.Text = "FILTER";
            // 
            // btnRmReleaseDetail
            // 
            _btnRmReleaseDetail.AllowToggling = false;
            _btnRmReleaseDetail.AnimationSpeed = 200;
            _btnRmReleaseDetail.AutoGenerateColors = false;
            _btnRmReleaseDetail.BackColor = Color.Transparent;
            _btnRmReleaseDetail.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmReleaseDetail.BackgroundImage = (Image)resources.GetObject("btnRmReleaseDetail.BackgroundImage");
            _btnRmReleaseDetail.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRmReleaseDetail.ButtonText = "";
            _btnRmReleaseDetail.ButtonTextMarginLeft = 0;
            _btnRmReleaseDetail.ColorContrastOnClick = 45;
            _btnRmReleaseDetail.ColorContrastOnHover = 45;
            _btnRmReleaseDetail.Cursor = Cursors.Hand;
            BorderEdges12.BottomLeft = true;
            BorderEdges12.BottomRight = true;
            BorderEdges12.TopLeft = true;
            BorderEdges12.TopRight = true;
            _btnRmReleaseDetail.CustomizableEdges = BorderEdges12;
            _btnRmReleaseDetail.DialogResult = DialogResult.None;
            _btnRmReleaseDetail.DisabledBorderColor = Color.Empty;
            _btnRmReleaseDetail.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRmReleaseDetail.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRmReleaseDetail.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRmReleaseDetail.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRmReleaseDetail.ForeColor = Color.White;
            _btnRmReleaseDetail.IconLeftCursor = Cursors.Hand;
            _btnRmReleaseDetail.IconMarginLeft = 5;
            _btnRmReleaseDetail.IconPadding = 5;
            _btnRmReleaseDetail.IconRightCursor = Cursors.Hand;
            _btnRmReleaseDetail.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmReleaseDetail.IdleBorderRadius = 20;
            _btnRmReleaseDetail.IdleBorderThickness = 1;
            _btnRmReleaseDetail.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmReleaseDetail.IdleIconLeftImage = My.Resources.Resources.removeWhite;
            _btnRmReleaseDetail.IdleIconRightImage = null;
            _btnRmReleaseDetail.IndicateFocus = true;
            _btnRmReleaseDetail.Location = new Point(290, 388);
            _btnRmReleaseDetail.Name = "_btnRmReleaseDetail";
            StateProperties31.BorderColor = Color.Red;
            StateProperties31.BorderRadius = 20;
            StateProperties31.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties31.BorderThickness = 1;
            StateProperties31.FillColor = Color.Red;
            StateProperties31.ForeColor = Color.White;
            StateProperties31.IconLeftImage = null;
            StateProperties31.IconRightImage = null;
            _btnRmReleaseDetail.onHoverState = StateProperties31;
            StateProperties32.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties32.BorderRadius = 20;
            StateProperties32.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties32.BorderThickness = 1;
            StateProperties32.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties32.ForeColor = Color.White;
            StateProperties32.IconLeftImage = null;
            StateProperties32.IconRightImage = null;
            _btnRmReleaseDetail.OnPressedState = StateProperties32;
            _btnRmReleaseDetail.Size = new Size(23, 23);
            _btnRmReleaseDetail.TabIndex = 248;
            _btnRmReleaseDetail.TextAlign = ContentAlignment.MiddleCenter;
            _btnRmReleaseDetail.TextMarginLeft = 0;
            _btnRmReleaseDetail.UseDefaultRadiusAndThickness = true;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(93, 436);
            Label9.Name = "Label9";
            Label9.Size = new Size(136, 17);
            Label9.TabIndex = 249;
            Label9.Text = "* Double click to edit";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Gray;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Image = My.Resources.Resources.arrowRightWhiteBackground;
            PictureBox1.Location = new Point(357, 322);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(47, 36);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 250;
            PictureBox1.TabStop = false;
            // 
            // BunifuButton4
            // 
            BunifuButton4.AllowToggling = false;
            BunifuButton4.AnimationSpeed = 200;
            BunifuButton4.AutoGenerateColors = false;
            BunifuButton4.BackColor = Color.Transparent;
            BunifuButton4.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.BackgroundImage = (Image)resources.GetObject("BunifuButton4.BackgroundImage");
            BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton4.ButtonText = "1";
            BunifuButton4.ButtonTextMarginLeft = 0;
            BunifuButton4.ColorContrastOnClick = 45;
            BunifuButton4.ColorContrastOnHover = 45;
            BunifuButton4.Cursor = Cursors.Hand;
            BorderEdges13.BottomLeft = true;
            BorderEdges13.BottomRight = true;
            BorderEdges13.TopLeft = true;
            BorderEdges13.TopRight = true;
            BunifuButton4.CustomizableEdges = BorderEdges13;
            BunifuButton4.DialogResult = DialogResult.None;
            BunifuButton4.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.DisabledForecolor = Color.White;
            BunifuButton4.Enabled = false;
            BunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton4.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton4.ForeColor = Color.White;
            BunifuButton4.IconLeftCursor = Cursors.Hand;
            BunifuButton4.IconMarginLeft = 8;
            BunifuButton4.IconPadding = 8;
            BunifuButton4.IconRightCursor = Cursors.Hand;
            BunifuButton4.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.IdleBorderRadius = 25;
            BunifuButton4.IdleBorderThickness = 1;
            BunifuButton4.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.IdleIconLeftImage = null;
            BunifuButton4.IdleIconRightImage = null;
            BunifuButton4.IndicateFocus = true;
            BunifuButton4.Location = new Point(31, 86);
            BunifuButton4.Name = "BunifuButton4";
            StateProperties33.BorderColor = Color.Coral;
            StateProperties33.BorderRadius = 25;
            StateProperties33.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties33.BorderThickness = 1;
            StateProperties33.FillColor = Color.Coral;
            StateProperties33.ForeColor = Color.White;
            StateProperties33.IconLeftImage = null;
            StateProperties33.IconRightImage = null;
            BunifuButton4.onHoverState = StateProperties33;
            StateProperties34.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties34.BorderRadius = 25;
            StateProperties34.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties34.BorderThickness = 1;
            StateProperties34.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties34.ForeColor = Color.White;
            StateProperties34.IconLeftImage = null;
            StateProperties34.IconRightImage = null;
            BunifuButton4.OnPressedState = StateProperties34;
            BunifuButton4.Size = new Size(29, 29);
            BunifuButton4.TabIndex = 252;
            BunifuButton4.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton4.TextMarginLeft = 0;
            BunifuButton4.UseDefaultRadiusAndThickness = true;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label14.Location = new Point(66, 93);
            Label14.Name = "Label14";
            Label14.Size = new Size(151, 20);
            Label14.TabIndex = 251;
            Label14.Text = "Edit Release Number";
            // 
            // BunifuButton1
            // 
            BunifuButton1.AllowToggling = false;
            BunifuButton1.AnimationSpeed = 200;
            BunifuButton1.AutoGenerateColors = false;
            BunifuButton1.BackColor = Color.Transparent;
            BunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton1.ButtonText = "2";
            BunifuButton1.ButtonTextMarginLeft = 0;
            BunifuButton1.ColorContrastOnClick = 45;
            BunifuButton1.ColorContrastOnHover = 45;
            BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges14.BottomLeft = true;
            BorderEdges14.BottomRight = true;
            BorderEdges14.TopLeft = true;
            BorderEdges14.TopRight = true;
            BunifuButton1.CustomizableEdges = BorderEdges14;
            BunifuButton1.DialogResult = DialogResult.None;
            BunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.DisabledForecolor = Color.White;
            BunifuButton1.Enabled = false;
            BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton1.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton1.ForeColor = Color.White;
            BunifuButton1.IconLeftCursor = Cursors.Hand;
            BunifuButton1.IconMarginLeft = 8;
            BunifuButton1.IconPadding = 8;
            BunifuButton1.IconRightCursor = Cursors.Hand;
            BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.IdleBorderRadius = 25;
            BunifuButton1.IdleBorderThickness = 1;
            BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.IdleIconLeftImage = null;
            BunifuButton1.IdleIconRightImage = null;
            BunifuButton1.IndicateFocus = true;
            BunifuButton1.Location = new Point(30, 221);
            BunifuButton1.Name = "BunifuButton1";
            StateProperties35.BorderColor = Color.Coral;
            StateProperties35.BorderRadius = 25;
            StateProperties35.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties35.BorderThickness = 1;
            StateProperties35.FillColor = Color.Coral;
            StateProperties35.ForeColor = Color.White;
            StateProperties35.IconLeftImage = null;
            StateProperties35.IconRightImage = null;
            BunifuButton1.onHoverState = StateProperties35;
            StateProperties36.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties36.BorderRadius = 25;
            StateProperties36.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties36.BorderThickness = 1;
            StateProperties36.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties36.ForeColor = Color.White;
            StateProperties36.IconLeftImage = null;
            StateProperties36.IconRightImage = null;
            BunifuButton1.OnPressedState = StateProperties36;
            BunifuButton1.Size = new Size(29, 29);
            BunifuButton1.TabIndex = 254;
            BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton1.TextMarginLeft = 0;
            BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label10.Location = new Point(65, 228);
            Label10.Name = "Label10";
            Label10.Size = new Size(146, 20);
            Label10.TabIndex = 253;
            Label10.Text = "Add Release Details:";
            // 
            // DateAccepted
            // 
            DateAccepted.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateAccepted.DataPropertyName = "DateAccepted";
            DateAccepted.FillWeight = 131.9797f;
            DateAccepted.HeaderText = "Date Accepted";
            DateAccepted.Name = "DateAccepted";
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "DateAccepted";
            DataGridViewTextBoxColumn1.HeaderText = "DateAccepted";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "DateAccepted";
            DataGridViewTextBoxColumn2.HeaderText = "DateAccepted";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.Width = 193;
            // 
            // ReleaseOrderId
            // 
            ReleaseOrderId.DataPropertyName = "ReleaseOrderId";
            ReleaseOrderId.HeaderText = "ReleaseOrderId";
            ReleaseOrderId.Name = "ReleaseOrderId";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.43425f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.56575f));
            TableLayoutPanel1.Controls.Add(Panel2, 0, 0);
            TableLayoutPanel1.Controls.Add(Panel1, 1, 0);
            TableLayoutPanel1.Location = new Point(469, 39);
            TableLayoutPanel1.Margin = new Padding(0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(327, 50);
            TableLayoutPanel1.TabIndex = 255;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Cornsilk;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(Label11);
            Panel2.Controls.Add(lblReqRelease);
            Panel2.Controls.Add(Label16);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 0);
            Panel2.Margin = new Padding(0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(177, 50);
            Panel2.TabIndex = 225;
            // 
            // Label6
            // 
            Label6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(3, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(104, 40);
            Label6.TabIndex = 221;
            Label6.Text = "Qty req. to be accepted:";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(224, 2);
            Label11.Name = "Label11";
            Label11.Size = new Size(71, 20);
            Label11.TabIndex = 217;
            Label11.Text = "Balance:";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.BackColor = Color.White;
            Label16.Font = new Font("Microsoft Sans Serif", 15.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label16.Location = new Point(298, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(24, 25);
            Label16.TabIndex = 220;
            Label16.Text = "0";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddBooking
            // 
            _btnAddBooking.AllowToggling = false;
            _btnAddBooking.AnimationSpeed = 200;
            _btnAddBooking.AutoGenerateColors = false;
            _btnAddBooking.BackColor = Color.Transparent;
            _btnAddBooking.BackColor1 = Color.Teal;
            _btnAddBooking.BackgroundImage = (Image)resources.GetObject("btnAddBooking.BackgroundImage");
            _btnAddBooking.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddBooking.ButtonText = " ";
            _btnAddBooking.ButtonTextMarginLeft = 0;
            _btnAddBooking.ColorContrastOnClick = 45;
            _btnAddBooking.ColorContrastOnHover = 45;
            _btnAddBooking.Cursor = Cursors.Hand;
            BorderEdges15.BottomLeft = true;
            BorderEdges15.BottomRight = true;
            BorderEdges15.TopLeft = true;
            BorderEdges15.TopRight = true;
            _btnAddBooking.CustomizableEdges = BorderEdges15;
            _btnAddBooking.DialogResult = DialogResult.None;
            _btnAddBooking.DisabledBorderColor = Color.Empty;
            _btnAddBooking.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddBooking.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddBooking.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddBooking.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddBooking.ForeColor = Color.White;
            _btnAddBooking.IconLeftCursor = Cursors.Hand;
            _btnAddBooking.IconMarginLeft = 7;
            _btnAddBooking.IconPadding = 7;
            _btnAddBooking.IconRightCursor = Cursors.Hand;
            _btnAddBooking.IdleBorderColor = Color.Teal;
            _btnAddBooking.IdleBorderRadius = 23;
            _btnAddBooking.IdleBorderThickness = 1;
            _btnAddBooking.IdleFillColor = Color.Teal;
            _btnAddBooking.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddBooking.IdleIconRightImage = null;
            _btnAddBooking.IndicateFocus = true;
            _btnAddBooking.Location = new Point(713, 265);
            _btnAddBooking.Name = "_btnAddBooking";
            StateProperties37.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties37.BorderRadius = 23;
            StateProperties37.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties37.BorderThickness = 1;
            StateProperties37.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties37.ForeColor = Color.White;
            StateProperties37.IconLeftImage = null;
            StateProperties37.IconRightImage = null;
            _btnAddBooking.onHoverState = StateProperties37;
            StateProperties38.BorderColor = Color.Teal;
            StateProperties38.BorderRadius = 23;
            StateProperties38.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties38.BorderThickness = 1;
            StateProperties38.FillColor = Color.Teal;
            StateProperties38.ForeColor = Color.White;
            StateProperties38.IconLeftImage = null;
            StateProperties38.IconRightImage = null;
            _btnAddBooking.OnPressedState = StateProperties38;
            _btnAddBooking.Size = new Size(25, 25);
            _btnAddBooking.TabIndex = 256;
            _btnAddBooking.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddBooking.TextMarginLeft = 0;
            _btnAddBooking.UseDefaultRadiusAndThickness = true;
            // 
            // MinibookingNumber
            // 
            MinibookingNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MinibookingNumber.DataPropertyName = "MinibookingNumber";
            MinibookingNumber.HeaderText = "Booking Number";
            MinibookingNumber.Name = "MinibookingNumber";
            MinibookingNumber.ReadOnly = true;
            MinibookingNumber.Width = 175;
            // 
            // QtyRequestedMb
            // 
            QtyRequestedMb.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            QtyRequestedMb.DataPropertyName = "QtyRequestedMb";
            QtyRequestedMb.HeaderText = "Qty";
            QtyRequestedMb.Name = "QtyRequestedMb";
            QtyRequestedMb.ReadOnly = true;
            QtyRequestedMb.Width = 55;
            // 
            // BunifuButton2
            // 
            BunifuButton2.AllowToggling = false;
            BunifuButton2.AnimationSpeed = 200;
            BunifuButton2.AutoGenerateColors = false;
            BunifuButton2.BackColor = Color.Transparent;
            BunifuButton2.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.BackgroundImage = (Image)resources.GetObject("BunifuButton2.BackgroundImage");
            BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton2.ButtonText = "3";
            BunifuButton2.ButtonTextMarginLeft = 0;
            BunifuButton2.ColorContrastOnClick = 45;
            BunifuButton2.ColorContrastOnHover = 45;
            BunifuButton2.Cursor = Cursors.Hand;
            BorderEdges16.BottomLeft = true;
            BorderEdges16.BottomRight = true;
            BorderEdges16.TopLeft = true;
            BorderEdges16.TopRight = true;
            BunifuButton2.CustomizableEdges = BorderEdges16;
            BunifuButton2.DialogResult = DialogResult.None;
            BunifuButton2.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.DisabledForecolor = Color.White;
            BunifuButton2.Enabled = false;
            BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton2.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton2.ForeColor = Color.White;
            BunifuButton2.IconLeftCursor = Cursors.Hand;
            BunifuButton2.IconMarginLeft = 8;
            BunifuButton2.IconPadding = 8;
            BunifuButton2.IconRightCursor = Cursors.Hand;
            BunifuButton2.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.IdleBorderRadius = 25;
            BunifuButton2.IdleBorderThickness = 1;
            BunifuButton2.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.IdleIconLeftImage = null;
            BunifuButton2.IdleIconRightImage = null;
            BunifuButton2.IndicateFocus = true;
            BunifuButton2.Location = new Point(438, 221);
            BunifuButton2.Name = "BunifuButton2";
            StateProperties39.BorderColor = Color.Coral;
            StateProperties39.BorderRadius = 25;
            StateProperties39.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties39.BorderThickness = 1;
            StateProperties39.FillColor = Color.Coral;
            StateProperties39.ForeColor = Color.White;
            StateProperties39.IconLeftImage = null;
            StateProperties39.IconRightImage = null;
            BunifuButton2.onHoverState = StateProperties39;
            StateProperties40.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties40.BorderRadius = 25;
            StateProperties40.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties40.BorderThickness = 1;
            StateProperties40.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties40.ForeColor = Color.White;
            StateProperties40.IconLeftImage = null;
            StateProperties40.IconRightImage = null;
            BunifuButton2.OnPressedState = StateProperties40;
            BunifuButton2.Size = new Size(29, 29);
            BunifuButton2.TabIndex = 258;
            BunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton2.TextMarginLeft = 0;
            BunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(473, 229);
            Label1.Name = "Label1";
            Label1.Size = new Size(206, 20);
            Label1.TabIndex = 257;
            Label1.Text = "Add Bookings Under Release";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(478, 441);
            Label13.Name = "Label13";
            Label13.Size = new Size(136, 17);
            Label13.TabIndex = 259;
            Label13.Text = "* Double click to edit";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmAddEditRelease
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 542);
            Controls.Add(Label13);
            Controls.Add(BunifuButton2);
            Controls.Add(Label1);
            Controls.Add(_btnAddBooking);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(BunifuButton1);
            Controls.Add(Label10);
            Controls.Add(BunifuButton4);
            Controls.Add(Label14);
            Controls.Add(PictureBox1);
            Controls.Add(Label9);
            Controls.Add(_btnRmReleaseDetail);
            Controls.Add(_btnAddReleaseDetail);
            Controls.Add(ShapedPanel1);
            Controls.Add(_btnRmBooking);
            Controls.Add(ShapedPanel3);
            Controls.Add(lblReleaseType);
            Controls.Add(Label33);
            Controls.Add(Label15);
            Controls.Add(_bdnSaveRelease);
            Controls.Add(_tbReleaseNumber);
            Controls.Add(Label4);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditRelease";
            Text = "FrmAddEditRelease";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ShapedPanel3.ResumeLayout(false);
            ShapedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingRelease).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWReleaseOrderMinibookingBindingSource).EndInit();
            ShapedPanel1.ResumeLayout(false);
            ShapedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvReleaseDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReleaseOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal Label Label8;
        internal Label lblBalance;
        internal Label Label17;
        internal Label lblReqRelease;
        internal Panel Panel1;
        internal Label Label4;
        private TextBox _tbReleaseNumber;

        internal TextBox tbReleaseNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbReleaseNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbReleaseNumber != null)
                {
                    _tbReleaseNumber.TextChanged -= tbReleaseNumber_TextChanged;
                }

                _tbReleaseNumber = value;
                if (_tbReleaseNumber != null)
                {
                    _tbReleaseNumber.TextChanged += tbReleaseNumber_TextChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _bdnSaveRelease;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton bdnSaveRelease
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bdnSaveRelease;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bdnSaveRelease != null)
                {
                    _bdnSaveRelease.Click -= bdnSaveRelease_Click;
                }

                _bdnSaveRelease = value;
                if (_bdnSaveRelease != null)
                {
                    _bdnSaveRelease.Click += bdnSaveRelease_Click;
                }
            }
        }

        internal Label Label15;
        internal Label lblReleaseType;
        internal Label Label33;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel3;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvBookingRelease;
        internal Label Label7;
        private BunifuTextBox _tbSeacrhBooking;

        internal BunifuTextBox tbSeacrhBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbSeacrhBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSeacrhBooking != null)
                {
                    _tbSeacrhBooking.TextChanged -= tbSeacrhBooking_TextChanged;
                }

                _tbSeacrhBooking = value;
                if (_tbSeacrhBooking != null)
                {
                    _tbSeacrhBooking.TextChanged += tbSeacrhBooking_TextChanged;
                }
            }
        }

        internal Label lblTotalBks;
        internal Label Label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRmBooking;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRmBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRmBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRmBooking != null)
                {
                    _btnRmBooking.Click -= btnRmBooking_Click;
                }

                _btnRmBooking = value;
                if (_btnRmBooking != null)
                {
                    _btnRmBooking.Click += btnRmBooking_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddReleaseDetail;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddReleaseDetail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddReleaseDetail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddReleaseDetail != null)
                {
                    _btnAddReleaseDetail.Click -= btnAddReleaseDetail_Click;
                }

                _btnAddReleaseDetail = value;
                if (_btnAddReleaseDetail != null)
                {
                    _btnAddReleaseDetail.Click += btnAddReleaseDetail_Click;
                }
            }
        }

        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvReleaseDetail;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvReleaseDetail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvReleaseDetail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvReleaseDetail != null)
                {
                    _dgvReleaseDetail.DoubleClick -= dgvReleaseDetail_DoubleClick;
                    _dgvReleaseDetail.SelectionChanged -= dgvReleaseDetail_SelectionChanged;
                }

                _dgvReleaseDetail = value;
                if (_dgvReleaseDetail != null)
                {
                    _dgvReleaseDetail.DoubleClick += dgvReleaseDetail_DoubleClick;
                    _dgvReleaseDetail.SelectionChanged += dgvReleaseDetail_SelectionChanged;
                }
            }
        }

        internal Label Label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRmReleaseDetail;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRmReleaseDetail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRmReleaseDetail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRmReleaseDetail != null)
                {
                    _btnRmReleaseDetail.Click -= btnRmReleaseDetail_Click;
                }

                _btnRmReleaseDetail = value;
                if (_btnRmReleaseDetail != null)
                {
                    _btnRmReleaseDetail.Click += btnRmReleaseDetail_Click;
                }
            }
        }

        internal Label Label9;
        internal PictureBox PictureBox1;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton4;
        internal Label Label14;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1;
        internal Label Label10;
        internal Label lblTotalRelDetails;
        internal Label Label12;
        internal DataGridViewTextBoxColumn QtyAccepted;
        internal DataGridViewTextBoxColumn DateAccepted;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal BindingSource ReleaseOrderBindingSource;
        internal DataGridViewTextBoxColumn ReleaseOrderId;
        internal BindingSource VWReleaseOrderMinibookingBindingSource;
        internal DataGridViewTextBoxColumn DateAcceptedDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn QtyAcceptedDataGridViewTextBoxColumn;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Panel Panel2;
        internal Label Label6;
        internal Label Label11;
        internal Label Label16;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddBooking;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddBooking != null)
                {
                    _btnAddBooking.Click -= btnAddBooking_Click;
                }

                _btnAddBooking = value;
                if (_btnAddBooking != null)
                {
                    _btnAddBooking.Click += btnAddBooking_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn MinibookingNumber;
        internal DataGridViewTextBoxColumn QtyRequestedMb;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton2;
        internal Label Label1;
        internal Label Label13;
    }
}