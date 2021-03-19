using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmParentScreen : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParentScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuIconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelmageList = new System.Windows.Forms.ImageList(this.components);
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this._SlideMenu1 = new YardTabletControls.SlideMenu();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this._shirnkExpandPictureBox = new System.Windows.Forms.PictureBox();
            this._upperBunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this._btnChanges = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Panel3 = new System.Windows.Forms.Panel();
            this._minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.profileShapedPictureBox1 = new CustomizedControlsLibrary.ShapedPictureBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this._exitPictureBox = new System.Windows.Forms.PictureBox();
            this._FormsTab1 = new YardTabletControls.FormsTab();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PanelWindows = new System.Windows.Forms.Panel();
            this._BunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this._dgvPendingChanges = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MinibookingNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyncMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VWCeresExcelPendingSyncBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlQueueChanges = new CustomizedControlsLibrary.ShapedPanel();
            this.ShapedPanel2 = new CustomizedControlsLibrary.ShapedPanel();
            this.menuPanel.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._shirnkExpandPictureBox)).BeginInit();
            this._upperBunifuShadowPanel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileShapedPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvPendingChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VWCeresExcelPendingSyncBookingBindingSource)).BeginInit();
            this.pnlQueueChanges.SuspendLayout();
            this.ShapedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuIconsImageList
            // 
            this.MainMenuIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainMenuIconsImageList.ImageStream")));
            this.MainMenuIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainMenuIconsImageList.Images.SetKeyName(0, "homeLight.png");
            this.MainMenuIconsImageList.Images.SetKeyName(1, "container.png");
            this.MainMenuIconsImageList.Images.SetKeyName(2, "homeDark.png");
            this.MainMenuIconsImageList.Images.SetKeyName(3, "customers.png");
            this.MainMenuIconsImageList.Images.SetKeyName(4, "HR.png");
            this.MainMenuIconsImageList.Images.SetKeyName(5, "RailcarsIcon.png");
            this.MainMenuIconsImageList.Images.SetKeyName(6, "book.png");
            this.MainMenuIconsImageList.Images.SetKeyName(7, "bill.png");
            this.MainMenuIconsImageList.Images.SetKeyName(8, "truck.png");
            this.MainMenuIconsImageList.Images.SetKeyName(9, "miscelaneous.png");
            this.MainMenuIconsImageList.Images.SetKeyName(10, "clock.png");
            this.MainMenuIconsImageList.Images.SetKeyName(11, "inventory.png");
            // 
            // panelmageList
            // 
            this.panelmageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("panelmageList.ImageStream")));
            this.panelmageList.TransparentColor = System.Drawing.Color.Transparent;
            this.panelmageList.Images.SetKeyName(0, "announcements.png");
            this.panelmageList.Images.SetKeyName(1, "greenBall.png");
            this.panelmageList.Images.SetKeyName(2, "calendar.png");
            this.panelmageList.Images.SetKeyName(3, "expired-131964752748201554_512.png");
            this.panelmageList.Images.SetKeyName(4, "greenBall.png");
            this.panelmageList.Images.SetKeyName(5, "redBall.png");
            this.panelmageList.Images.SetKeyName(6, "1a60846c999975a2b2b35964c3f1e117.png");
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.Panel1);
            this.menuPanel.Controls.Add(this._SlideMenu1);
            this.menuPanel.Controls.Add(this.Panel2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(219, 1020);
            this.menuPanel.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = global::ShipSmpl.My.Resources.Resources.wtcFooter;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 926);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(219, 94);
            this.Panel1.TabIndex = 6;
            // 
            // _SlideMenu1
            // 
            this._SlideMenu1.BackgroundPattern = YardTabletControls.SlideMenu.PatternOfBackground.FlatBackground;
            this._SlideMenu1.ColourGamut = YardTabletControls.SlideMenu.GamutOfColour.TenPercent;
            this._SlideMenu1.FooterLogo = global::ShipSmpl.My.Resources.Resources.wtcFooter;
            this._SlideMenu1.FooterLogoBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._SlideMenu1.FooterLogoHeight = ((short)(60));
            this._SlideMenu1.FooterLogoPadding = ((short)(1));
            this._SlideMenu1.FooterLogoVisible = false;
            this._SlideMenu1.HeaderLogo = global::ShipSmpl.My.Resources.Resources.ceresVerticalIconWhite;
            this._SlideMenu1.HeaderLogoBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._SlideMenu1.HeaderLogoHeight = ((short)(90));
            this._SlideMenu1.HeaderLogoPadding = ((short)(1));
            this._SlideMenu1.HeaderLogoVisible = false;
            this._SlideMenu1.Location = new System.Drawing.Point(0, 140);
            this._SlideMenu1.MainMenuFontColour = System.Drawing.Color.White;
            this._SlideMenu1.MainMenuFontSize = ((short)(16));
            this._SlideMenu1.MainMenuHeight = ((short)(35));
            this._SlideMenu1.Margin = new System.Windows.Forms.Padding(4);
            this._SlideMenu1.Name = "_SlideMenu1";
            this._SlideMenu1.Size = new System.Drawing.Size(219, 807);
            this._SlideMenu1.SlideMenuBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._SlideMenu1.SubMenuFontColour = System.Drawing.Color.White;
            this._SlideMenu1.SubMenuFontSize = ((short)(14));
            this._SlideMenu1.SubMenuHeight = ((short)(30));
            this._SlideMenu1.TabIndex = 8;
            this._SlideMenu1.MainMenuKeySelected += new YardTabletControls.SlideMenu.MainMenuKeySelectedEventHandler(this.SlideMenu1_MainMenuKeySelected);
            this._SlideMenu1.SubMenuKeySelected += new YardTabletControls.SlideMenu.SubMenuKeySelectedEventHandler(this.SlideMenu1_SubMenuKeySelected);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this._shirnkExpandPictureBox);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(219, 140);
            this.Panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Development";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::ShipSmpl.My.Resources.Resources.SSWithName;
            this.PictureBox1.Location = new System.Drawing.Point(46, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(127, 121);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // _shirnkExpandPictureBox
            // 
            this._shirnkExpandPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._shirnkExpandPictureBox.Image = global::ShipSmpl.My.Resources.Resources.shrinkArrow;
            this._shirnkExpandPictureBox.Location = new System.Drawing.Point(194, 3);
            this._shirnkExpandPictureBox.Name = "_shirnkExpandPictureBox";
            this._shirnkExpandPictureBox.Size = new System.Drawing.Size(20, 20);
            this._shirnkExpandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._shirnkExpandPictureBox.TabIndex = 1;
            this._shirnkExpandPictureBox.TabStop = false;
            this._shirnkExpandPictureBox.Click += new System.EventHandler(this.shirnkExpandPictureBox_Click);
            // 
            // _upperBunifuShadowPanel1
            // 
            this._upperBunifuShadowPanel1.BackColor = System.Drawing.Color.White;
            this._upperBunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent;
            this._upperBunifuShadowPanel1.Controls.Add(this.Label1);
            this._upperBunifuShadowPanel1.Controls.Add(this._btnChanges);
            this._upperBunifuShadowPanel1.Controls.Add(this.Panel3);
            this._upperBunifuShadowPanel1.Controls.Add(this._FormsTab1);
            this._upperBunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this._upperBunifuShadowPanel1.Location = new System.Drawing.Point(219, 0);
            this._upperBunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this._upperBunifuShadowPanel1.Name = "_upperBunifuShadowPanel1";
            this._upperBunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this._upperBunifuShadowPanel1.ShadowDept = 2;
            this._upperBunifuShadowPanel1.ShadowTopLeftVisible = false;
            this._upperBunifuShadowPanel1.Size = new System.Drawing.Size(1502, 53);
            this._upperBunifuShadowPanel1.TabIndex = 4;
            this._upperBunifuShadowPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this._upperBunifuShadowPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this._upperBunifuShadowPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(954, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(182, 17);
            this.Label1.TabIndex = 180;
            this.Label1.Text = "Pending changes on queue";
            // 
            // _btnChanges
            // 
            this._btnChanges.AllowToggling = false;
            this._btnChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnChanges.AnimationSpeed = 200;
            this._btnChanges.AutoGenerateColors = false;
            this._btnChanges.BackColor = System.Drawing.Color.Transparent;
            this._btnChanges.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._btnChanges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnChanges.BackgroundImage")));
            this._btnChanges.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this._btnChanges.ButtonText = "0";
            this._btnChanges.ButtonTextMarginLeft = 0;
            this._btnChanges.ColorContrastOnClick = 45;
            this._btnChanges.ColorContrastOnHover = 45;
            this._btnChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this._btnChanges.CustomizableEdges = borderEdges1;
            this._btnChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this._btnChanges.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this._btnChanges.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._btnChanges.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this._btnChanges.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this._btnChanges.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChanges.ForeColor = System.Drawing.Color.White;
            this._btnChanges.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this._btnChanges.IconMarginLeft = 11;
            this._btnChanges.IconPadding = 10;
            this._btnChanges.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this._btnChanges.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._btnChanges.IdleBorderRadius = 10;
            this._btnChanges.IdleBorderThickness = 1;
            this._btnChanges.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._btnChanges.IdleIconLeftImage = null;
            this._btnChanges.IdleIconRightImage = null;
            this._btnChanges.IndicateFocus = false;
            this._btnChanges.Location = new System.Drawing.Point(1141, 2);
            this._btnChanges.Margin = new System.Windows.Forms.Padding(0);
            this._btnChanges.Name = "_btnChanges";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this._btnChanges.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties2.BorderRadius = 10;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this._btnChanges.OnPressedState = stateProperties2;
            this._btnChanges.Size = new System.Drawing.Size(33, 23);
            this._btnChanges.TabIndex = 179;
            this._btnChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnChanges.TextMarginLeft = 0;
            this._btnChanges.UseDefaultRadiusAndThickness = true;
            this._btnChanges.Click += new System.EventHandler(this.btnAddBagInventory_Click);
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.Controls.Add(this._minimizePictureBox);
            this.Panel3.Controls.Add(this.profileShapedPictureBox1);
            this.Panel3.Controls.Add(this.employeeNameLabel);
            this.Panel3.Controls.Add(this._exitPictureBox);
            this.Panel3.Location = new System.Drawing.Point(1179, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(316, 48);
            this.Panel3.TabIndex = 0;
            // 
            // _minimizePictureBox
            // 
            this._minimizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._minimizePictureBox.Image = global::ShipSmpl.My.Resources.Resources.minimize;
            this._minimizePictureBox.Location = new System.Drawing.Point(238, 7);
            this._minimizePictureBox.Name = "_minimizePictureBox";
            this._minimizePictureBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._minimizePictureBox.Size = new System.Drawing.Size(27, 34);
            this._minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._minimizePictureBox.TabIndex = 1;
            this._minimizePictureBox.TabStop = false;
            this._minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            this._minimizePictureBox.MouseLeave += new System.EventHandler(this.minimizePictureBox_MouseLeave);
            this._minimizePictureBox.MouseHover += new System.EventHandler(this.minimizePictureBox_MouseHover);
            // 
            // profileShapedPictureBox1
            // 
            this.profileShapedPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.profileShapedPictureBox1.BorderColor = System.Drawing.Color.Transparent;
            this.profileShapedPictureBox1.Edge = 50;
            this.profileShapedPictureBox1.Image = global::ShipSmpl.My.Resources.Resources.starOn;
            this.profileShapedPictureBox1.Location = new System.Drawing.Point(3, 2);
            this.profileShapedPictureBox1.Name = "profileShapedPictureBox1";
            this.profileShapedPictureBox1.Size = new System.Drawing.Size(44, 45);
            this.profileShapedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileShapedPictureBox1.TabIndex = 2;
            this.profileShapedPictureBox1.TabStop = false;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.employeeNameLabel.Location = new System.Drawing.Point(50, 11);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(175, 29);
            this.employeeNameLabel.TabIndex = 3;
            this.employeeNameLabel.Text = "Bob Singer";
            // 
            // _exitPictureBox
            // 
            this._exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._exitPictureBox.Image = global::ShipSmpl.My.Resources.Resources.exitIcon;
            this._exitPictureBox.Location = new System.Drawing.Point(271, 7);
            this._exitPictureBox.Name = "_exitPictureBox";
            this._exitPictureBox.Size = new System.Drawing.Size(42, 34);
            this._exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._exitPictureBox.TabIndex = 0;
            this._exitPictureBox.TabStop = false;
            this._exitPictureBox.Click += new System.EventHandler(this.PictureBox3_Click);
            this._exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_Leave);
            this._exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_Mouse_Hover);
            // 
            // _FormsTab1
            // 
            this._FormsTab1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_FormsTab1.BackgroundImage")));
            this._FormsTab1.BackgroundPattern = YardTabletControls.FormsTab.PatternOfBackground.FlatBackground;
            this._FormsTab1.ColourGamut = YardTabletControls.FormsTab.GamutOfColour.TenPercent;
            this._FormsTab1.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._FormsTab1.FontColourFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._FormsTab1.FontColourNotFocused = System.Drawing.Color.DarkGray;
            this._FormsTab1.FontStyle = YardTabletControls.FormsTab.StyleOfFont.FlatFont;
            this._FormsTab1.FormTabBorderColour = System.Drawing.Color.Silver;
            this._FormsTab1.Location = new System.Drawing.Point(0, 20);
            this._FormsTab1.Margin = new System.Windows.Forms.Padding(4);
            this._FormsTab1.Name = "_FormsTab1";
            this._FormsTab1.Size = new System.Drawing.Size(1062, 24);
            this._FormsTab1.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._FormsTab1.TabFontSize = ((short)(11));
            this._FormsTab1.TabHeight = ((short)(25));
            this._FormsTab1.TabIndex = 1;
            this._FormsTab1.TabWidth = ((short)(145));
            this._FormsTab1.FormTabSelected += new YardTabletControls.FormsTab.FormTabSelectedEventHandler(this.FormsTab1_FormTabSelected);
            this._FormsTab1.DeleteTabForm += new YardTabletControls.FormsTab.DeleteTabFormEventHandler(this.FormsTab1_DeleteTabForm);
            // 
            // ImageList1
            // 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList1.ImageSize = new System.Drawing.Size(45, 45);
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PanelWindows
            // 
            this.PanelWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelWindows.Location = new System.Drawing.Point(225, 56);
            this.PanelWindows.Margin = new System.Windows.Forms.Padding(0);
            this.PanelWindows.Name = "PanelWindows";
            this.PanelWindows.Size = new System.Drawing.Size(1484, 973);
            this.PanelWindows.TabIndex = 5;
            // 
            // _BunifuFormDock1
            // 
            this._BunifuFormDock1.AllowFormDragging = true;
            this._BunifuFormDock1.AllowFormDropShadow = true;
            this._BunifuFormDock1.AllowFormResizing = true;
            this._BunifuFormDock1.AllowHidingBottomRegion = true;
            this._BunifuFormDock1.AllowOpacityChangesWhileDragging = true;
            this._BunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this._BunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this._BunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this._BunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this._BunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this._BunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this._BunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this._BunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this._BunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this._BunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this._BunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this._BunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this._BunifuFormDock1.ContainerControl = this;
            this._BunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this._BunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this._BunifuFormDock1.DockingOptions.DockAll = true;
            this._BunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this._BunifuFormDock1.DockingOptions.DockBottomRight = true;
            this._BunifuFormDock1.DockingOptions.DockFullScreen = true;
            this._BunifuFormDock1.DockingOptions.DockLeft = true;
            this._BunifuFormDock1.DockingOptions.DockRight = true;
            this._BunifuFormDock1.DockingOptions.DockTopLeft = true;
            this._BunifuFormDock1.DockingOptions.DockTopRight = true;
            this._BunifuFormDock1.FormDraggingOpacity = 0.4D;
            this._BunifuFormDock1.ParentForm = this;
            this._BunifuFormDock1.ShowCursorChanges = true;
            this._BunifuFormDock1.ShowDockingIndicators = true;
            this._BunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this._BunifuFormDock1.TitleBarOptions.BunifuFormDock = this._BunifuFormDock1;
            this._BunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this._BunifuFormDock1.TitleBarOptions.TitleBarControl = this._upperBunifuShadowPanel1;
            this._BunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            this._BunifuFormDock1.DockChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuFormDock.DockChangedEventArgs>(this.BunifuFormDock1_DockChanged);
            // 
            // _dgvPendingChanges
            // 
            this._dgvPendingChanges.AllowCustomTheming = true;
            this._dgvPendingChanges.AllowUserToAddRows = false;
            this._dgvPendingChanges.AllowUserToDeleteRows = false;
            this._dgvPendingChanges.AllowUserToResizeColumns = false;
            this._dgvPendingChanges.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this._dgvPendingChanges.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvPendingChanges.AutoGenerateColumns = false;
            this._dgvPendingChanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvPendingChanges.BackgroundColor = System.Drawing.Color.White;
            this._dgvPendingChanges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvPendingChanges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._dgvPendingChanges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvPendingChanges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvPendingChanges.ColumnHeadersHeight = 25;
            this._dgvPendingChanges.ColumnHeadersVisible = false;
            this._dgvPendingChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MinibookingNumberCol,
            this.CurrentStatus,
            this.SyncMessage});
            this._dgvPendingChanges.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this._dgvPendingChanges.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this._dgvPendingChanges.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this._dgvPendingChanges.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this._dgvPendingChanges.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this._dgvPendingChanges.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._dgvPendingChanges.CurrentTheme.GridColor = System.Drawing.Color.Wheat;
            this._dgvPendingChanges.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.White;
            this._dgvPendingChanges.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this._dgvPendingChanges.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._dgvPendingChanges.CurrentTheme.Name = null;
            this._dgvPendingChanges.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this._dgvPendingChanges.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this._dgvPendingChanges.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this._dgvPendingChanges.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this._dgvPendingChanges.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this._dgvPendingChanges.DataSource = this.VWCeresExcelPendingSyncBookingBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvPendingChanges.DefaultCellStyle = dataGridViewCellStyle4;
            this._dgvPendingChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvPendingChanges.EnableHeadersVisualStyles = false;
            this._dgvPendingChanges.GridColor = System.Drawing.Color.Wheat;
            this._dgvPendingChanges.HeaderBackColor = System.Drawing.Color.White;
            this._dgvPendingChanges.HeaderBgColor = System.Drawing.Color.Empty;
            this._dgvPendingChanges.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._dgvPendingChanges.Location = new System.Drawing.Point(0, 0);
            this._dgvPendingChanges.Name = "_dgvPendingChanges";
            this._dgvPendingChanges.ReadOnly = true;
            this._dgvPendingChanges.RowHeadersVisible = false;
            this._dgvPendingChanges.RowHeadersWidth = 25;
            this._dgvPendingChanges.RowTemplate.Height = 25;
            this._dgvPendingChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvPendingChanges.Size = new System.Drawing.Size(283, 96);
            this._dgvPendingChanges.TabIndex = 0;
            this._dgvPendingChanges.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            this._dgvPendingChanges.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPendingChanges_RowPostPaint);
            // 
            // MinibookingNumberCol
            // 
            this.MinibookingNumberCol.DataPropertyName = "MinibookingNumber";
            this.MinibookingNumberCol.FillWeight = 106.599F;
            this.MinibookingNumberCol.HeaderText = "MinibookingNumber";
            this.MinibookingNumberCol.Name = "MinibookingNumberCol";
            this.MinibookingNumberCol.ReadOnly = true;
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.DataPropertyName = "CurrentStatus";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CurrentStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.CurrentStatus.FillWeight = 85.90214F;
            this.CurrentStatus.HeaderText = "CurrentStatus";
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.ReadOnly = true;
            // 
            // SyncMessage
            // 
            this.SyncMessage.DataPropertyName = "SyncMessage";
            this.SyncMessage.FillWeight = 107.4989F;
            this.SyncMessage.HeaderText = "SyncMessage";
            this.SyncMessage.Name = "SyncMessage";
            this.SyncMessage.ReadOnly = true;
            // 
            // VWCeresExcelPendingSyncBookingBindingSource
            // 
            this.VWCeresExcelPendingSyncBookingBindingSource.DataSource = typeof(ModelLayer.VW_CeresExcelPendingSyncBooking);
            // 
            // _Timer1
            // 
            this._Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnlQueueChanges
            // 
            this.pnlQueueChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQueueChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlQueueChanges.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlQueueChanges.Controls.Add(this.ShapedPanel2);
            this.pnlQueueChanges.Edge = 15;
            this.pnlQueueChanges.Location = new System.Drawing.Point(1106, 22);
            this.pnlQueueChanges.Margin = new System.Windows.Forms.Padding(0);
            this.pnlQueueChanges.Name = "pnlQueueChanges";
            this.pnlQueueChanges.Padding = new System.Windows.Forms.Padding(2);
            this.pnlQueueChanges.Size = new System.Drawing.Size(287, 100);
            this.pnlQueueChanges.TabIndex = 181;
            this.pnlQueueChanges.Visible = false;
            // 
            // ShapedPanel2
            // 
            this.ShapedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ShapedPanel2.BorderColor = System.Drawing.Color.White;
            this.ShapedPanel2.Controls.Add(this._dgvPendingChanges);
            this.ShapedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShapedPanel2.Edge = 15;
            this.ShapedPanel2.Location = new System.Drawing.Point(2, 2);
            this.ShapedPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.ShapedPanel2.Name = "ShapedPanel2";
            this.ShapedPanel2.Size = new System.Drawing.Size(283, 96);
            this.ShapedPanel2.TabIndex = 182;
            // 
            // FrmParentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1721, 1020);
            this.ControlBox = false;
            this.Controls.Add(this.pnlQueueChanges);
            this.Controls.Add(this.PanelWindows);
            this.Controls.Add(this._upperBunifuShadowPanel1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "FrmParentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FrmParentScreen_Resize);
            this.menuPanel.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._shirnkExpandPictureBox)).EndInit();
            this._upperBunifuShadowPanel1.ResumeLayout(false);
            this._upperBunifuShadowPanel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileShapedPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvPendingChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VWCeresExcelPendingSyncBookingBindingSource)).EndInit();
            this.pnlQueueChanges.ResumeLayout(false);
            this.ShapedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal ImageList MainMenuIconsImageList;
        internal ImageList panelmageList;
        // Friend WithEvents EmployeesTableAdapter As WTCOperationsDataSetTableAdapters.EmployeesTableAdapter
        internal DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FirstNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn AliasDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TypeDataGridViewTextBoxColumn;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Panel menuPanel;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel _upperBunifuShadowPanel1;

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel upperBunifuShadowPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _upperBunifuShadowPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_upperBunifuShadowPanel1 != null)
                {
                    _upperBunifuShadowPanel1.MouseDown -= Form1_MouseDown;
                    _upperBunifuShadowPanel1.MouseUp -= Form1_MouseUp;
                    _upperBunifuShadowPanel1.MouseMove -= Form1_MouseMove;
                }

                _upperBunifuShadowPanel1 = value;
                if (_upperBunifuShadowPanel1 != null)
                {
                    _upperBunifuShadowPanel1.MouseDown += Form1_MouseDown;
                    _upperBunifuShadowPanel1.MouseUp += Form1_MouseUp;
                    _upperBunifuShadowPanel1.MouseMove += Form1_MouseMove;
                }
            }
        }

        private PictureBox _exitPictureBox;

        internal PictureBox exitPictureBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _exitPictureBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_exitPictureBox != null)
                {
                    _exitPictureBox.Click -= PictureBox3_Click;
                    _exitPictureBox.MouseLeave -= exitPictureBox_Leave;
                    _exitPictureBox.MouseHover -= exitPictureBox_Mouse_Hover;
                }

                _exitPictureBox = value;
                if (_exitPictureBox != null)
                {
                    _exitPictureBox.Click += PictureBox3_Click;
                    _exitPictureBox.MouseLeave += exitPictureBox_Leave;
                    _exitPictureBox.MouseHover += exitPictureBox_Mouse_Hover;
                }
            }
        }

        private PictureBox _shirnkExpandPictureBox;

        internal PictureBox shirnkExpandPictureBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _shirnkExpandPictureBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_shirnkExpandPictureBox != null)
                {
                    _shirnkExpandPictureBox.Click -= shirnkExpandPictureBox_Click;
                }

                _shirnkExpandPictureBox = value;
                if (_shirnkExpandPictureBox != null)
                {
                    _shirnkExpandPictureBox.Click += shirnkExpandPictureBox_Click;
                }
            }
        }

        internal Panel Panel2;
        internal PictureBox PictureBox1;
        internal Panel Panel1;
        private YardTabletControls.SlideMenu _SlideMenu1;

        internal YardTabletControls.SlideMenu SlideMenu1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SlideMenu1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SlideMenu1 != null)
                {
                    _SlideMenu1.SubMenuKeySelected -= SlideMenu1_SubMenuKeySelected;
                    _SlideMenu1.MainMenuKeySelected -= SlideMenu1_MainMenuKeySelected;
                }

                _SlideMenu1 = value;
                if (_SlideMenu1 != null)
                {
                    _SlideMenu1.SubMenuKeySelected += SlideMenu1_SubMenuKeySelected;
                    _SlideMenu1.MainMenuKeySelected += SlideMenu1_MainMenuKeySelected;
                }
            }
        }

        private YardTabletControls.FormsTab _FormsTab1;

        internal YardTabletControls.FormsTab FormsTab1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FormsTab1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FormsTab1 != null)
                {
                    _FormsTab1.FormTabSelected -= FormsTab1_FormTabSelected;
                    _FormsTab1.DeleteTabForm -= FormsTab1_DeleteTabForm;
                }

                _FormsTab1 = value;
                if (_FormsTab1 != null)
                {
                    _FormsTab1.FormTabSelected += FormsTab1_FormTabSelected;
                    _FormsTab1.DeleteTabForm += FormsTab1_DeleteTabForm;
                }
            }
        }

        internal Panel PanelWindows;
        internal Panel Panel3;
        private PictureBox _minimizePictureBox;

        internal PictureBox minimizePictureBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _minimizePictureBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_minimizePictureBox != null)
                {
                    _minimizePictureBox.Click -= minimizePictureBox_Click;
                    _minimizePictureBox.MouseHover -= minimizePictureBox_MouseHover;
                    _minimizePictureBox.MouseLeave -= minimizePictureBox_MouseLeave;
                }

                _minimizePictureBox = value;
                if (_minimizePictureBox != null)
                {
                    _minimizePictureBox.Click += minimizePictureBox_Click;
                    _minimizePictureBox.MouseHover += minimizePictureBox_MouseHover;
                    _minimizePictureBox.MouseLeave += minimizePictureBox_MouseLeave;
                }
            }
        }

        public Label employeeNameLabel;
        internal ImageList ImageList1;
        internal CustomizedControlsLibrary.ShapedPictureBox profileShapedPictureBox1;
        private Bunifu.UI.WinForms.BunifuFormDock _BunifuFormDock1;

        internal Bunifu.UI.WinForms.BunifuFormDock BunifuFormDock1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuFormDock1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuFormDock1 != null)
                {
                    _BunifuFormDock1.DockChanged -= BunifuFormDock1_DockChanged;
                }

                _BunifuFormDock1 = value;
                if (_BunifuFormDock1 != null)
                {
                    _BunifuFormDock1.DockChanged += BunifuFormDock1_DockChanged;
                }
            }
        }

        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnChanges;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChanges
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnChanges;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnChanges != null)
                {
                    _btnChanges.Click -= btnAddBagInventory_Click;
                }

                _btnChanges = value;
                if (_btnChanges != null)
                {
                    _btnChanges.Click += btnAddBagInventory_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _dgvPendingChanges;

        internal Bunifu.UI.WinForms.BunifuDataGridView dgvPendingChanges
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvPendingChanges;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvPendingChanges != null)
                {
                    _dgvPendingChanges.RowPostPaint -= dgvPendingChanges_RowPostPaint;
                }

                _dgvPendingChanges = value;
                if (_dgvPendingChanges != null)
                {
                    _dgvPendingChanges.RowPostPaint += dgvPendingChanges_RowPostPaint;
                }
            }
        }

        internal BindingSource VWCeresExcelPendingSyncBookingBindingSource;
        private Timer _Timer1;

        internal Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= Timer1_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += Timer1_Tick;
                }
            }
        }

        internal DataGridViewTextBoxColumn MinibookingNumberCol;
        internal DataGridViewTextBoxColumn CurrentStatus;
        internal DataGridViewTextBoxColumn SyncMessage;
        internal CustomizedControlsLibrary.ShapedPanel pnlQueueChanges;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel2;
        internal Label label2;
    }
}