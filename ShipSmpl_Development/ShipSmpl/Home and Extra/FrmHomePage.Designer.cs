using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmHomePage : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            mainPanel = new Panel();
            StatasContainerFlowLayoutPanel = new FlowLayoutPanel();
            containersMainWidgetPanel = new Panel();
            Label26 = new Label();
            TableLayoutPanel15 = new TableLayoutPanel();
            TableLayoutPanel16 = new TableLayoutPanel();
            TableLayoutPanel17 = new TableLayoutPanel();
            Label19 = new Label();
            Label20 = new Label();
            TableLayoutPanel18 = new TableLayoutPanel();
            Label21 = new Label();
            Label22 = new Label();
            TableLayoutPanel19 = new TableLayoutPanel();
            Label23 = new Label();
            Label25 = new Label();
            TableLayoutPanel10 = new TableLayoutPanel();
            TableLayoutPanel11 = new TableLayoutPanel();
            TableLayoutPanel12 = new TableLayoutPanel();
            Label11 = new Label();
            Label13 = new Label();
            TableLayoutPanel13 = new TableLayoutPanel();
            Label14 = new Label();
            Label15 = new Label();
            TableLayoutPanel14 = new TableLayoutPanel();
            Label16 = new Label();
            Label17 = new Label();
            Label18 = new Label();
            TableLayoutPanel4 = new TableLayoutPanel();
            TableLayoutPanel6 = new TableLayoutPanel();
            TableLayoutPanel7 = new TableLayoutPanel();
            Label4 = new Label();
            Label1 = new Label();
            TableLayoutPanel8 = new TableLayoutPanel();
            Label10 = new Label();
            Label3 = new Label();
            TableLayoutPanel9 = new TableLayoutPanel();
            Label5 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            TransfersTableLayoutPanel = new TableLayoutPanel();
            TableLayoutPanel5 = new TableLayoutPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            Label2 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            containersInTransferLabel = new Label();
            Label12 = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            toLindseyLabel = new Label();
            toOtherTerminalLabel = new Label();
            toEwenLabel = new Label();
            Panel2 = new Panel();
            Panel3 = new Panel();
            ShapedLabel4 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabel3 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabel2 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabel1 = new CustomizedControlsLibrary.ShapedLabel();
            Label30 = new Label();
            TableLayoutPanel23 = new TableLayoutPanel();
            totalNumbEmployeesLabel = new Label();
            Label29 = new Label();
            activeEmpNumbLabel = new Label();
            InactiveEmpNumberLabel = new Label();
            TableLayoutPanel20 = new TableLayoutPanel();
            _Label24 = new Label();
            _Label24.Click += new EventHandler(Label2_Click);
            panelmageList = new ImageList(components);
            _probationPeriodNumberLabel = new Label();
            _probationPeriodNumberLabel.Click += new EventHandler(Label2_Click);
            messageEmployeeeTableLayoutPanel = new TableLayoutPanel();
            _messageEmployeeLabel = new Label();
            _messageEmployeeLabel.Click += new EventHandler(messageEmployeeLabel_Click);
            ImageList1 = new ImageList(components);
            TableLayoutPanel21 = new TableLayoutPanel();
            Label27 = new Label();
            alertsCountLabel = new Label();
            TableLayoutPanel22 = new TableLayoutPanel();
            _Label28 = new Label();
            _Label28.Click += new EventHandler(Label15_Click);
            _BirthdayCountLabel = new Label();
            _BirthdayCountLabel.Click += new EventHandler(Label15_Click);
            Label47 = new Label();
            Label48 = new Label();
            Panel4 = new Panel();
            _actionComboBox1 = new ComboBox();
            _actionComboBox1.SelectedIndexChanged += new EventHandler(actiongeComboBox_SelectedIndexChanged);
            _typeComboBox = new ComboBox();
            _typeComboBox.SelectedIndexChanged += new EventHandler(typeMessageComboBox_SelectedIndexChanged);
            _NotificationCenter1 = new YardTabletControls.NotificationCenter();
            _NotificationCenter1.NotifyButtonPressed += new YardTabletControls.NotificationCenter.NotifyButtonPressedEventHandler(NotificationCenter1_NotifyButtonPressed);
            _NotificationCenter1.ExpandNotifications += new YardTabletControls.NotificationCenter.ExpandNotificationsEventHandler(NotificationCenter1_ExpandNotifications);
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            mainPanel.SuspendLayout();
            StatasContainerFlowLayoutPanel.SuspendLayout();
            containersMainWidgetPanel.SuspendLayout();
            TableLayoutPanel15.SuspendLayout();
            TableLayoutPanel16.SuspendLayout();
            TableLayoutPanel17.SuspendLayout();
            TableLayoutPanel18.SuspendLayout();
            TableLayoutPanel19.SuspendLayout();
            TableLayoutPanel10.SuspendLayout();
            TableLayoutPanel11.SuspendLayout();
            TableLayoutPanel12.SuspendLayout();
            TableLayoutPanel13.SuspendLayout();
            TableLayoutPanel14.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            TableLayoutPanel6.SuspendLayout();
            TableLayoutPanel7.SuspendLayout();
            TableLayoutPanel8.SuspendLayout();
            TableLayoutPanel9.SuspendLayout();
            TransfersTableLayoutPanel.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            TableLayoutPanel23.SuspendLayout();
            TableLayoutPanel20.SuspendLayout();
            messageEmployeeeTableLayoutPanel.SuspendLayout();
            TableLayoutPanel21.SuspendLayout();
            TableLayoutPanel22.SuspendLayout();
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
            BunifuShadowPanel1.Padding = new Padding(13, 7, 7, 6);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1856, 1074);
            BunifuShadowPanel1.TabIndex = 5;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(13, 7);
            Panel1.Margin = new Padding(4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1836, 1061);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.DimGray;
            Panel5.Controls.Add(mainPanel);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Margin = new Padding(4);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 49, 0, 0);
            Panel5.Size = new Size(1836, 1061);
            Panel5.TabIndex = 33;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(StatasContainerFlowLayoutPanel);
            mainPanel.Controls.Add(Panel4);
            mainPanel.Controls.Add(_actionComboBox1);
            mainPanel.Controls.Add(_typeComboBox);
            mainPanel.Controls.Add(_NotificationCenter1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 49);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1836, 1012);
            mainPanel.TabIndex = 0;
            // 
            // StatasContainerFlowLayoutPanel
            // 
            StatasContainerFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            StatasContainerFlowLayoutPanel.AutoScroll = true;
            StatasContainerFlowLayoutPanel.Controls.Add(containersMainWidgetPanel);
            StatasContainerFlowLayoutPanel.Controls.Add(Panel2);
            StatasContainerFlowLayoutPanel.Location = new Point(0, 0);
            StatasContainerFlowLayoutPanel.Margin = new Padding(4);
            StatasContainerFlowLayoutPanel.Name = "StatasContainerFlowLayoutPanel";
            StatasContainerFlowLayoutPanel.Padding = new Padding(27, 25, 0, 25);
            StatasContainerFlowLayoutPanel.Size = new Size(1836, 958);
            StatasContainerFlowLayoutPanel.TabIndex = 57;
            // 
            // containersMainWidgetPanel
            // 
            containersMainWidgetPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            containersMainWidgetPanel.Controls.Add(Label26);
            containersMainWidgetPanel.Controls.Add(TableLayoutPanel15);
            containersMainWidgetPanel.Controls.Add(TableLayoutPanel10);
            containersMainWidgetPanel.Controls.Add(TableLayoutPanel4);
            containersMainWidgetPanel.Controls.Add(Label6);
            containersMainWidgetPanel.Controls.Add(Label7);
            containersMainWidgetPanel.Controls.Add(TransfersTableLayoutPanel);
            containersMainWidgetPanel.Location = new Point(31, 29);
            containersMainWidgetPanel.Margin = new Padding(4);
            containersMainWidgetPanel.Name = "containersMainWidgetPanel";
            containersMainWidgetPanel.Size = new Size(1872, 743);
            containersMainWidgetPanel.TabIndex = 36;
            // 
            // Label26
            // 
            Label26.Anchor = AnchorStyles.Left;
            Label26.AutoSize = true;
            Label26.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label26.Location = new Point(4, 385);
            Label26.Margin = new Padding(4, 0, 4, 0);
            Label26.Name = "Label26";
            Label26.Padding = new Padding(67, 12, 0, 0);
            Label26.Size = new Size(153, 37);
            Label26.TabIndex = 60;
            Label26.Text = "Requests";
            Label26.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TableLayoutPanel15
            // 
            TableLayoutPanel15.BackColor = Color.Peru;
            TableLayoutPanel15.ColumnCount = 1;
            TableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel15.Controls.Add(TableLayoutPanel16, 0, 0);
            TableLayoutPanel15.Controls.Add(TableLayoutPanel19, 0, 1);
            TableLayoutPanel15.Location = new Point(75, 448);
            TableLayoutPanel15.Margin = new Padding(4);
            TableLayoutPanel15.Name = "TableLayoutPanel15";
            TableLayoutPanel15.RowCount = 2;
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 134.0f));
            TableLayoutPanel15.Size = new Size(517, 274);
            TableLayoutPanel15.TabIndex = 59;
            // 
            // TableLayoutPanel16
            // 
            TableLayoutPanel16.ColumnCount = 2;
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel16.Controls.Add(TableLayoutPanel17, 1, 0);
            TableLayoutPanel16.Controls.Add(TableLayoutPanel18, 0, 0);
            TableLayoutPanel16.Dock = DockStyle.Fill;
            TableLayoutPanel16.Location = new Point(1, 1);
            TableLayoutPanel16.Margin = new Padding(1);
            TableLayoutPanel16.Name = "TableLayoutPanel16";
            TableLayoutPanel16.RowCount = 1;
            TableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel16.Size = new Size(515, 138);
            TableLayoutPanel16.TabIndex = 0;
            // 
            // TableLayoutPanel17
            // 
            TableLayoutPanel17.BackColor = Color.Transparent;
            TableLayoutPanel17.ColumnCount = 1;
            TableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 272.0f));
            TableLayoutPanel17.Controls.Add(Label19, 0, 1);
            TableLayoutPanel17.Controls.Add(Label20, 0, 0);
            TableLayoutPanel17.Dock = DockStyle.Fill;
            TableLayoutPanel17.Location = new Point(258, 1);
            TableLayoutPanel17.Margin = new Padding(1);
            TableLayoutPanel17.Name = "TableLayoutPanel17";
            TableLayoutPanel17.RowCount = 2;
            TableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 97.0f));
            TableLayoutPanel17.Size = new Size(256, 136);
            TableLayoutPanel17.TabIndex = 54;
            // 
            // Label19
            // 
            Label19.BackColor = Color.SandyBrown;
            Label19.Dock = DockStyle.Top;
            Label19.Font = new Font("Segoe UI", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = Color.White;
            Label19.Location = new Point(4, 39);
            Label19.Margin = new Padding(4, 0, 4, 0);
            Label19.Name = "Label19";
            Label19.Size = new Size(264, 54);
            Label19.TabIndex = 5;
            Label19.Text = "...";
            Label19.TextAlign = ContentAlignment.TopRight;
            // 
            // Label20
            // 
            Label20.BackColor = Color.White;
            Label20.BorderStyle = BorderStyle.FixedSingle;
            Label20.Dock = DockStyle.Top;
            Label20.Font = new Font("Segoe UI", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label20.Location = new Point(4, 0);
            Label20.Margin = new Padding(4, 0, 4, 0);
            Label20.Name = "Label20";
            Label20.Size = new Size(264, 36);
            Label20.TabIndex = 4;
            Label20.Text = "No new requests";
            Label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel18
            // 
            TableLayoutPanel18.ColumnCount = 1;
            TableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel18.Controls.Add(Label21, 0, 1);
            TableLayoutPanel18.Controls.Add(Label22, 0, 0);
            TableLayoutPanel18.Dock = DockStyle.Fill;
            TableLayoutPanel18.Location = new Point(1, 1);
            TableLayoutPanel18.Margin = new Padding(1);
            TableLayoutPanel18.Name = "TableLayoutPanel18";
            TableLayoutPanel18.RowCount = 2;
            TableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 48.0f));
            TableLayoutPanel18.Size = new Size(255, 136);
            TableLayoutPanel18.TabIndex = 53;
            // 
            // Label21
            // 
            Label21.Dock = DockStyle.Fill;
            Label21.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.Location = new Point(4, 88);
            Label21.Margin = new Padding(4, 0, 4, 0);
            Label21.Name = "Label21";
            Label21.Size = new Size(247, 48);
            Label21.TabIndex = 2;
            Label21.Text = "Inbound Requests";
            Label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label22
            // 
            Label22.Anchor = AnchorStyles.None;
            Label22.AutoSize = true;
            Label22.Font = new Font("Microsoft Sans Serif", 41.89091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.Location = new Point(98, 12);
            Label22.Margin = new Padding(4, 0, 4, 0);
            Label22.Name = "Label22";
            Label22.Size = new Size(59, 64);
            Label22.TabIndex = 0;
            Label22.Text = "0";
            Label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel19
            // 
            TableLayoutPanel19.ColumnCount = 2;
            TableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel19.Controls.Add(Label23, 0, 0);
            TableLayoutPanel19.Controls.Add(Label25, 1, 0);
            TableLayoutPanel19.Dock = DockStyle.Fill;
            TableLayoutPanel19.Location = new Point(1, 141);
            TableLayoutPanel19.Margin = new Padding(1);
            TableLayoutPanel19.Name = "TableLayoutPanel19";
            TableLayoutPanel19.Padding = new Padding(7, 6, 7, 6);
            TableLayoutPanel19.RowCount = 1;
            TableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel19.Size = new Size(515, 132);
            TableLayoutPanel19.TabIndex = 55;
            // 
            // Label23
            // 
            Label23.Anchor = AnchorStyles.None;
            Label23.BackColor = Color.SandyBrown;
            Label23.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.Location = new Point(35, 20);
            Label23.Margin = new Padding(4, 0, 4, 0);
            Label23.Name = "Label23";
            Label23.Size = new Size(193, 91);
            Label23.TabIndex = 4;
            Label23.Text = "To Lindsey" + '\r' + '\n' + "0";
            Label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label25
            // 
            Label25.Anchor = AnchorStyles.None;
            Label25.BackColor = Color.SandyBrown;
            Label25.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.Location = new Point(290, 21);
            Label25.Margin = new Padding(4, 0, 4, 0);
            Label25.Name = "Label25";
            Label25.Size = new Size(185, 89);
            Label25.TabIndex = 2;
            Label25.Text = "To Ewen" + '\r' + '\n' + "0";
            Label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel10
            // 
            TableLayoutPanel10.BackColor = Color.SaddleBrown;
            TableLayoutPanel10.ColumnCount = 1;
            TableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel10.Controls.Add(TableLayoutPanel11, 0, 0);
            TableLayoutPanel10.Controls.Add(TableLayoutPanel14, 0, 1);
            TableLayoutPanel10.Location = new Point(941, 97);
            TableLayoutPanel10.Margin = new Padding(4);
            TableLayoutPanel10.Name = "TableLayoutPanel10";
            TableLayoutPanel10.RowCount = 2;
            TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 124.0f));
            TableLayoutPanel10.Size = new Size(397, 274);
            TableLayoutPanel10.TabIndex = 58;
            // 
            // TableLayoutPanel11
            // 
            TableLayoutPanel11.ColumnCount = 2;
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel11.Controls.Add(TableLayoutPanel12, 1, 0);
            TableLayoutPanel11.Controls.Add(TableLayoutPanel13, 0, 0);
            TableLayoutPanel11.Location = new Point(1, 1);
            TableLayoutPanel11.Margin = new Padding(1);
            TableLayoutPanel11.Name = "TableLayoutPanel11";
            TableLayoutPanel11.RowCount = 1;
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel11.Size = new Size(395, 144);
            TableLayoutPanel11.TabIndex = 0;
            // 
            // TableLayoutPanel12
            // 
            TableLayoutPanel12.ColumnCount = 1;
            TableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel12.Controls.Add(Label11, 0, 1);
            TableLayoutPanel12.Controls.Add(Label13, 0, 0);
            TableLayoutPanel12.Dock = DockStyle.Fill;
            TableLayoutPanel12.Location = new Point(198, 1);
            TableLayoutPanel12.Margin = new Padding(1);
            TableLayoutPanel12.Name = "TableLayoutPanel12";
            TableLayoutPanel12.RowCount = 2;
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 94.0f));
            TableLayoutPanel12.Size = new Size(196, 142);
            TableLayoutPanel12.TabIndex = 54;
            // 
            // Label11
            // 
            Label11.Dock = DockStyle.Fill;
            Label11.Font = new Font("Segoe UI", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(4, 48);
            Label11.Margin = new Padding(4, 0, 4, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(188, 94);
            Label11.TabIndex = 5;
            Label11.Text = "Dispatch";
            Label11.TextAlign = ContentAlignment.TopRight;
            // 
            // Label13
            // 
            Label13.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(4, 0);
            Label13.Margin = new Padding(4, 0, 4, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(187, 48);
            Label13.TabIndex = 4;
            Label13.Text = "Outbound";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel13
            // 
            TableLayoutPanel13.ColumnCount = 1;
            TableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel13.Controls.Add(Label14, 0, 1);
            TableLayoutPanel13.Controls.Add(Label15, 0, 0);
            TableLayoutPanel13.Dock = DockStyle.Fill;
            TableLayoutPanel13.Location = new Point(1, 1);
            TableLayoutPanel13.Margin = new Padding(1);
            TableLayoutPanel13.Name = "TableLayoutPanel13";
            TableLayoutPanel13.RowCount = 2;
            TableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.0f));
            TableLayoutPanel13.Size = new Size(195, 142);
            TableLayoutPanel13.TabIndex = 53;
            // 
            // Label14
            // 
            Label14.Dock = DockStyle.Fill;
            Label14.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.Location = new Point(4, 98);
            Label14.Margin = new Padding(4, 0, 4, 0);
            Label14.Name = "Label14";
            Label14.Size = new Size(187, 44);
            Label14.TabIndex = 2;
            Label14.Text = "Containers";
            Label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.None;
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 41.89091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(68, 17);
            Label15.Margin = new Padding(4, 0, 4, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(59, 64);
            Label15.TabIndex = 0;
            Label15.Text = "0";
            Label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel14
            // 
            TableLayoutPanel14.ColumnCount = 3;
            TableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127.0f));
            TableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112.0f));
            TableLayoutPanel14.Controls.Add(Label16, 0, 0);
            TableLayoutPanel14.Controls.Add(Label17, 2, 0);
            TableLayoutPanel14.Controls.Add(Label18, 1, 0);
            TableLayoutPanel14.Dock = DockStyle.Fill;
            TableLayoutPanel14.Location = new Point(1, 151);
            TableLayoutPanel14.Margin = new Padding(1);
            TableLayoutPanel14.Name = "TableLayoutPanel14";
            TableLayoutPanel14.Padding = new Padding(7, 6, 7, 6);
            TableLayoutPanel14.RowCount = 1;
            TableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel14.Size = new Size(395, 122);
            TableLayoutPanel14.TabIndex = 55;
            // 
            // Label16
            // 
            Label16.Anchor = AnchorStyles.None;
            Label16.BackColor = Color.Chocolate;
            Label16.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(11, 15);
            Label16.Margin = new Padding(4, 0, 4, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(134, 91);
            Label16.TabIndex = 4;
            Label16.Text = "To Lindsey" + '\r' + '\n' + "0";
            Label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            Label17.Anchor = AnchorStyles.None;
            Label17.BackColor = Color.Chocolate;
            Label17.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.Location = new Point(280, 15);
            Label17.Margin = new Padding(4, 0, 4, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(104, 91);
            Label17.TabIndex = 3;
            Label17.Text = "Other" + '\r' + '\n' + "0";
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label18
            // 
            Label18.Anchor = AnchorStyles.None;
            Label18.BackColor = Color.Chocolate;
            Label18.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.Location = new Point(153, 16);
            Label18.Margin = new Padding(4, 0, 4, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(119, 89);
            Label18.TabIndex = 2;
            Label18.Text = "To Ewen" + '\r' + '\n' + "0";
            Label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            TableLayoutPanel4.ColumnCount = 1;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.Controls.Add(TableLayoutPanel6, 0, 0);
            TableLayoutPanel4.Controls.Add(TableLayoutPanel9, 0, 1);
            TableLayoutPanel4.Location = new Point(501, 97);
            TableLayoutPanel4.Margin = new Padding(4);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 2;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 124.0f));
            TableLayoutPanel4.Size = new Size(397, 274);
            TableLayoutPanel4.TabIndex = 57;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 2;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.Controls.Add(TableLayoutPanel7, 1, 0);
            TableLayoutPanel6.Controls.Add(TableLayoutPanel8, 0, 0);
            TableLayoutPanel6.Location = new Point(1, 1);
            TableLayoutPanel6.Margin = new Padding(1);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 1;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.Size = new Size(395, 144);
            TableLayoutPanel6.TabIndex = 0;
            // 
            // TableLayoutPanel7
            // 
            TableLayoutPanel7.ColumnCount = 1;
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel7.Controls.Add(Label4, 0, 1);
            TableLayoutPanel7.Controls.Add(Label1, 0, 0);
            TableLayoutPanel7.Dock = DockStyle.Fill;
            TableLayoutPanel7.Location = new Point(198, 1);
            TableLayoutPanel7.Margin = new Padding(1);
            TableLayoutPanel7.Name = "TableLayoutPanel7";
            TableLayoutPanel7.RowCount = 2;
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 94.0f));
            TableLayoutPanel7.Size = new Size(196, 142);
            TableLayoutPanel7.TabIndex = 54;
            // 
            // Label4
            // 
            Label4.Dock = DockStyle.Fill;
            Label4.Font = new Font("Segoe UI", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(4, 48);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(188, 94);
            Label4.TabIndex = 5;
            Label4.Text = "Dispatch";
            Label4.TextAlign = ContentAlignment.TopRight;
            // 
            // Label1
            // 
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(4, 0);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(187, 48);
            Label1.TabIndex = 4;
            Label1.Text = "Inbound";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel8
            // 
            TableLayoutPanel8.ColumnCount = 1;
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel8.Controls.Add(Label10, 0, 1);
            TableLayoutPanel8.Controls.Add(Label3, 0, 0);
            TableLayoutPanel8.Dock = DockStyle.Fill;
            TableLayoutPanel8.Location = new Point(1, 1);
            TableLayoutPanel8.Margin = new Padding(1);
            TableLayoutPanel8.Name = "TableLayoutPanel8";
            TableLayoutPanel8.RowCount = 2;
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.0f));
            TableLayoutPanel8.Size = new Size(195, 142);
            TableLayoutPanel8.TabIndex = 53;
            // 
            // Label10
            // 
            Label10.Dock = DockStyle.Fill;
            Label10.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(4, 98);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(187, 44);
            Label10.TabIndex = 2;
            Label10.Text = "Containers";
            Label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 41.89091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(68, 17);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(59, 64);
            Label3.TabIndex = 0;
            Label3.Text = "0";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel9
            // 
            TableLayoutPanel9.ColumnCount = 3;
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125.0f));
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112.0f));
            TableLayoutPanel9.Controls.Add(Label5, 0, 0);
            TableLayoutPanel9.Controls.Add(Label8, 2, 0);
            TableLayoutPanel9.Controls.Add(Label9, 1, 0);
            TableLayoutPanel9.Dock = DockStyle.Fill;
            TableLayoutPanel9.Location = new Point(1, 151);
            TableLayoutPanel9.Margin = new Padding(1);
            TableLayoutPanel9.Name = "TableLayoutPanel9";
            TableLayoutPanel9.Padding = new Padding(7, 6, 7, 6);
            TableLayoutPanel9.RowCount = 1;
            TableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel9.Size = new Size(395, 122);
            TableLayoutPanel9.TabIndex = 55;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.None;
            Label5.BackColor = Color.Olive;
            Label5.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(11, 15);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(136, 91);
            Label5.TabIndex = 4;
            Label5.Text = "To Lindsey" + '\r' + '\n' + "0";
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.None;
            Label8.BackColor = Color.Olive;
            Label8.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(280, 15);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(104, 91);
            Label8.TabIndex = 3;
            Label8.Text = "Other" + '\r' + '\n' + "0";
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.BackColor = Color.Olive;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(155, 16);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(117, 89);
            Label9.TabIndex = 2;
            Label9.Text = "To Ewen" + '\r' + '\n' + "0";
            Label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Dock = DockStyle.Top;
            Label6.ForeColor = Color.Gray;
            Label6.Location = new Point(0, 37);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Padding = new Padding(67, 0, 0, 0);
            Label6.Size = new Size(1965, 16);
            Label6.TabIndex = 31;
            Label6.Text = resources.GetString("Label6.Text");
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Dock = DockStyle.Top;
            Label7.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(0, 0);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Padding = new Padding(67, 12, 0, 0);
            Label7.Size = new Size(170, 37);
            Label7.TabIndex = 30;
            Label7.Text = "Containers";
            Label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TransfersTableLayoutPanel
            // 
            TransfersTableLayoutPanel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TransfersTableLayoutPanel.ColumnCount = 1;
            TransfersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TransfersTableLayoutPanel.Controls.Add(TableLayoutPanel5, 0, 0);
            TransfersTableLayoutPanel.Controls.Add(TableLayoutPanel3, 0, 1);
            TransfersTableLayoutPanel.Location = new Point(72, 97);
            TransfersTableLayoutPanel.Margin = new Padding(4);
            TransfersTableLayoutPanel.Name = "TransfersTableLayoutPanel";
            TransfersTableLayoutPanel.RowCount = 2;
            TransfersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TransfersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 121.0f));
            TransfersTableLayoutPanel.Size = new Size(397, 274);
            TransfersTableLayoutPanel.TabIndex = 56;
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.Controls.Add(TableLayoutPanel2, 1, 0);
            TableLayoutPanel5.Controls.Add(TableLayoutPanel1, 0, 0);
            TableLayoutPanel5.Location = new Point(1, 1);
            TableLayoutPanel5.Margin = new Padding(1);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.Size = new Size(395, 144);
            TableLayoutPanel5.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 1;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Controls.Add(Label2, 0, 0);
            TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel2.Location = new Point(198, 1);
            TableLayoutPanel2.Margin = new Padding(1);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 2;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 94.0f));
            TableLayoutPanel2.Size = new Size(196, 142);
            TableLayoutPanel2.TabIndex = 54;
            // 
            // Label2
            // 
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(4, 0);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(187, 48);
            Label2.TabIndex = 4;
            Label2.Text = "Transfers";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(containersInTransferLabel, 0, 0);
            TableLayoutPanel1.Controls.Add(Label12, 0, 1);
            TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel1.Location = new Point(1, 1);
            TableLayoutPanel1.Margin = new Padding(1);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.0f));
            TableLayoutPanel1.Size = new Size(195, 142);
            TableLayoutPanel1.TabIndex = 53;
            // 
            // containersInTransferLabel
            // 
            containersInTransferLabel.Anchor = AnchorStyles.None;
            containersInTransferLabel.AutoSize = true;
            containersInTransferLabel.Font = new Font("Microsoft Sans Serif", 41.89091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            containersInTransferLabel.Location = new Point(68, 17);
            containersInTransferLabel.Margin = new Padding(4, 0, 4, 0);
            containersInTransferLabel.Name = "containersInTransferLabel";
            containersInTransferLabel.Size = new Size(59, 64);
            containersInTransferLabel.TabIndex = 0;
            containersInTransferLabel.Text = "0";
            containersInTransferLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            Label12.Dock = DockStyle.Fill;
            Label12.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(4, 98);
            Label12.Margin = new Padding(4, 0, 4, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(187, 44);
            Label12.TabIndex = 1;
            Label12.Text = "Containers";
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 3;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121.0f));
            TableLayoutPanel3.Controls.Add(toLindseyLabel, 0, 0);
            TableLayoutPanel3.Controls.Add(toOtherTerminalLabel, 2, 0);
            TableLayoutPanel3.Controls.Add(toEwenLabel, 1, 0);
            TableLayoutPanel3.Dock = DockStyle.Fill;
            TableLayoutPanel3.Location = new Point(1, 154);
            TableLayoutPanel3.Margin = new Padding(1);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.Padding = new Padding(7, 6, 7, 6);
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.Size = new Size(395, 119);
            TableLayoutPanel3.TabIndex = 55;
            // 
            // toLindseyLabel
            // 
            toLindseyLabel.Anchor = AnchorStyles.None;
            toLindseyLabel.BackColor = Color.Teal;
            toLindseyLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            toLindseyLabel.Location = new Point(11, 14);
            toLindseyLabel.Margin = new Padding(4, 0, 4, 0);
            toLindseyLabel.Name = "toLindseyLabel";
            toLindseyLabel.Size = new Size(136, 91);
            toLindseyLabel.TabIndex = 4;
            toLindseyLabel.Text = "To Lindsey" + '\r' + '\n' + "0";
            toLindseyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toOtherTerminalLabel
            // 
            toOtherTerminalLabel.Anchor = AnchorStyles.None;
            toOtherTerminalLabel.BackColor = Color.Teal;
            toOtherTerminalLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            toOtherTerminalLabel.Location = new Point(271, 14);
            toOtherTerminalLabel.Margin = new Padding(4, 0, 4, 0);
            toOtherTerminalLabel.Name = "toOtherTerminalLabel";
            toOtherTerminalLabel.Size = new Size(113, 91);
            toOtherTerminalLabel.TabIndex = 3;
            toOtherTerminalLabel.Text = "Other" + '\r' + '\n' + "0";
            toOtherTerminalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toEwenLabel
            // 
            toEwenLabel.Anchor = AnchorStyles.None;
            toEwenLabel.BackColor = Color.Teal;
            toEwenLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            toEwenLabel.Location = new Point(155, 15);
            toEwenLabel.Margin = new Padding(4, 0, 4, 0);
            toEwenLabel.Name = "toEwenLabel";
            toEwenLabel.Size = new Size(108, 89);
            toEwenLabel.TabIndex = 2;
            toEwenLabel.Text = "To Ewen" + '\r' + '\n' + "0";
            toEwenLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(Panel3);
            Panel2.Controls.Add(TableLayoutPanel23);
            Panel2.Controls.Add(TableLayoutPanel20);
            Panel2.Controls.Add(messageEmployeeeTableLayoutPanel);
            Panel2.Controls.Add(TableLayoutPanel21);
            Panel2.Controls.Add(TableLayoutPanel22);
            Panel2.Controls.Add(Label47);
            Panel2.Controls.Add(Label48);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(31, 780);
            Panel2.Margin = new Padding(4, 4, 4, 98);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1872, 668);
            Panel2.TabIndex = 37;
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(ShapedLabel4);
            Panel3.Controls.Add(ShapedLabel3);
            Panel3.Controls.Add(ShapedLabel2);
            Panel3.Controls.Add(ShapedLabel1);
            Panel3.Controls.Add(Label30);
            Panel3.Location = new Point(77, 266);
            Panel3.Margin = new Padding(4);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(821, 185);
            Panel3.TabIndex = 64;
            // 
            // ShapedLabel4
            // 
            ShapedLabel4.BackColor = Color.Teal;
            ShapedLabel4.BorderColor = Color.White;
            ShapedLabel4.Edge = 95;
            ShapedLabel4.FlatStyle = FlatStyle.Flat;
            ShapedLabel4.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            ShapedLabel4.ForeColor = Color.Transparent;
            ShapedLabel4.Location = new Point(647, 50);
            ShapedLabel4.Margin = new Padding(4, 0, 4, 0);
            ShapedLabel4.Name = "ShapedLabel4";
            ShapedLabel4.Size = new Size(141, 118);
            ShapedLabel4.TabIndex = 36;
            ShapedLabel4.Text = "Other" + '\r' + '\n' + "0";
            ShapedLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShapedLabel3
            // 
            ShapedLabel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedLabel3.BorderColor = Color.White;
            ShapedLabel3.Edge = 95;
            ShapedLabel3.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            ShapedLabel3.ForeColor = Color.Transparent;
            ShapedLabel3.Location = new Point(453, 50);
            ShapedLabel3.Margin = new Padding(4, 0, 4, 0);
            ShapedLabel3.Name = "ShapedLabel3";
            ShapedLabel3.Size = new Size(141, 118);
            ShapedLabel3.TabIndex = 35;
            ShapedLabel3.Text = "Job Letter" + '\r' + '\n' + "0";
            ShapedLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShapedLabel2
            // 
            ShapedLabel2.BackColor = Color.Teal;
            ShapedLabel2.BorderColor = Color.White;
            ShapedLabel2.Edge = 95;
            ShapedLabel2.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            ShapedLabel2.ForeColor = Color.Transparent;
            ShapedLabel2.Location = new Point(240, 50);
            ShapedLabel2.Margin = new Padding(4, 0, 4, 0);
            ShapedLabel2.Name = "ShapedLabel2";
            ShapedLabel2.Size = new Size(141, 118);
            ShapedLabel2.TabIndex = 34;
            ShapedLabel2.Text = "Time Off" + '\r' + '\n' + "0";
            ShapedLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShapedLabel1
            // 
            ShapedLabel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedLabel1.BorderColor = Color.White;
            ShapedLabel1.Edge = 95;
            ShapedLabel1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            ShapedLabel1.ForeColor = Color.Transparent;
            ShapedLabel1.Location = new Point(23, 50);
            ShapedLabel1.Margin = new Padding(4, 0, 4, 0);
            ShapedLabel1.Name = "ShapedLabel1";
            ShapedLabel1.Padding = new Padding(0, 6, 0, 0);
            ShapedLabel1.Size = new Size(141, 118);
            ShapedLabel1.TabIndex = 33;
            ShapedLabel1.Text = "Vacation Pay" + '\r' + '\n' + "0";
            ShapedLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.Dock = DockStyle.Top;
            Label30.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label30.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label30.Location = new Point(0, 0);
            Label30.Margin = new Padding(4, 0, 4, 0);
            Label30.Name = "Label30";
            Label30.Padding = new Padding(7, 6, 7, 6);
            Label30.Size = new Size(100, 37);
            Label30.TabIndex = 31;
            Label30.Text = "Requests";
            Label30.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TableLayoutPanel23
            // 
            TableLayoutPanel23.AutoSize = true;
            TableLayoutPanel23.BackColor = Color.Green;
            TableLayoutPanel23.ColumnCount = 2;
            TableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.41935f));
            TableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.58065f));
            TableLayoutPanel23.Controls.Add(totalNumbEmployeesLabel, 0, 0);
            TableLayoutPanel23.Controls.Add(Label29, 0, 1);
            TableLayoutPanel23.Controls.Add(activeEmpNumbLabel, 0, 2);
            TableLayoutPanel23.Controls.Add(InactiveEmpNumberLabel, 1, 2);
            TableLayoutPanel23.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel23.ForeColor = Color.White;
            TableLayoutPanel23.Location = new Point(963, 266);
            TableLayoutPanel23.Margin = new Padding(4);
            TableLayoutPanel23.Name = "TableLayoutPanel23";
            TableLayoutPanel23.Padding = new Padding(13, 12, 13, 12);
            TableLayoutPanel23.RowCount = 3;
            TableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 67.64706f));
            TableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 32.35294f));
            TableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Absolute, 111.0f));
            TableLayoutPanel23.Size = new Size(411, 290);
            TableLayoutPanel23.TabIndex = 63;
            // 
            // totalNumbEmployeesLabel
            // 
            totalNumbEmployeesLabel.AutoSize = true;
            totalNumbEmployeesLabel.Font = new Font("Microsoft Sans Serif", 48.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            totalNumbEmployeesLabel.Location = new Point(17, 12);
            totalNumbEmployeesLabel.Margin = new Padding(4, 0, 4, 0);
            totalNumbEmployeesLabel.Name = "totalNumbEmployeesLabel";
            totalNumbEmployeesLabel.Size = new Size(104, 73);
            totalNumbEmployeesLabel.TabIndex = 0;
            totalNumbEmployeesLabel.Text = "19";
            totalNumbEmployeesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label29
            // 
            Label29.AutoSize = true;
            Label29.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label29.Location = new Point(17, 116);
            Label29.Margin = new Padding(4, 0, 4, 0);
            Label29.Name = "Label29";
            Label29.Size = new Size(104, 25);
            Label29.TabIndex = 1;
            Label29.Text = "Employees";
            // 
            // activeEmpNumbLabel
            // 
            activeEmpNumbLabel.Anchor = AnchorStyles.None;
            activeEmpNumbLabel.BackColor = Color.DarkSeaGreen;
            activeEmpNumbLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            activeEmpNumbLabel.Location = new Point(23, 180);
            activeEmpNumbLabel.Margin = new Padding(4, 0, 4, 0);
            activeEmpNumbLabel.Name = "activeEmpNumbLabel";
            activeEmpNumbLabel.Size = new Size(180, 84);
            activeEmpNumbLabel.TabIndex = 2;
            activeEmpNumbLabel.Text = "Active" + '\r' + '\n' + "19";
            activeEmpNumbLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InactiveEmpNumberLabel
            // 
            InactiveEmpNumberLabel.Anchor = AnchorStyles.None;
            InactiveEmpNumberLabel.BackColor = Color.DarkSeaGreen;
            InactiveEmpNumberLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            InactiveEmpNumberLabel.Location = new Point(218, 180);
            InactiveEmpNumberLabel.Margin = new Padding(4, 0, 4, 0);
            InactiveEmpNumberLabel.Name = "InactiveEmpNumberLabel";
            InactiveEmpNumberLabel.Size = new Size(175, 84);
            InactiveEmpNumberLabel.TabIndex = 3;
            InactiveEmpNumberLabel.Text = "Inactive" + '\r' + '\n' + "0";
            InactiveEmpNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel20
            // 
            TableLayoutPanel20.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel20.BackColor = Color.Snow;
            TableLayoutPanel20.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel20.ColumnCount = 2;
            TableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179.0f));
            TableLayoutPanel20.Controls.Add(_Label24, 0, 0);
            TableLayoutPanel20.Controls.Add(_probationPeriodNumberLabel, 1, 0);
            TableLayoutPanel20.Location = new Point(75, 90);
            TableLayoutPanel20.Margin = new Padding(4);
            TableLayoutPanel20.Name = "TableLayoutPanel20";
            TableLayoutPanel20.RowCount = 1;
            TableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            TableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 63.0f));
            TableLayoutPanel20.Size = new Size(620, 64);
            TableLayoutPanel20.TabIndex = 59;
            // 
            // Label24
            // 
            _Label24.BackColor = Color.White;
            _Label24.Dock = DockStyle.Fill;
            _Label24.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label24.ForeColor = Color.Black;
            _Label24.ImageAlign = ContentAlignment.MiddleLeft;
            _Label24.ImageIndex = 2;
            _Label24.ImageList = panelmageList;
            _Label24.Location = new Point(5, 1);
            _Label24.Margin = new Padding(4, 0, 4, 0);
            _Label24.Name = "_Label24";
            _Label24.Size = new Size(430, 62);
            _Label24.TabIndex = 0;
            _Label24.Text = "              Probation period reminder";
            _Label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelmageList
            // 
            panelmageList.ImageStream = (ImageListStreamer)resources.GetObject("panelmageList.ImageStream");
            panelmageList.TransparentColor = Color.Transparent;
            panelmageList.Images.SetKeyName(0, "announcements.png");
            panelmageList.Images.SetKeyName(1, "greenBall.png");
            panelmageList.Images.SetKeyName(2, "calendar.png");
            panelmageList.Images.SetKeyName(3, "expired-131964752748201554_512.png");
            panelmageList.Images.SetKeyName(4, "greenBall.png");
            panelmageList.Images.SetKeyName(5, "redBall.png");
            panelmageList.Images.SetKeyName(6, "1a60846c999975a2b2b35964c3f1e117.png");
            // 
            // probationPeriodNumberLabel
            // 
            _probationPeriodNumberLabel.BackColor = Color.White;
            _probationPeriodNumberLabel.Dock = DockStyle.Fill;
            _probationPeriodNumberLabel.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _probationPeriodNumberLabel.ForeColor = Color.White;
            _probationPeriodNumberLabel.ImageIndex = 4;
            _probationPeriodNumberLabel.ImageList = panelmageList;
            _probationPeriodNumberLabel.Location = new Point(444, 1);
            _probationPeriodNumberLabel.Margin = new Padding(4, 0, 4, 0);
            _probationPeriodNumberLabel.Name = "_probationPeriodNumberLabel";
            _probationPeriodNumberLabel.Size = new Size(171, 62);
            _probationPeriodNumberLabel.TabIndex = 2;
            _probationPeriodNumberLabel.Text = " 0";
            _probationPeriodNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // messageEmployeeeTableLayoutPanel
            // 
            messageEmployeeeTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messageEmployeeeTableLayoutPanel.BackColor = Color.Snow;
            messageEmployeeeTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            messageEmployeeeTableLayoutPanel.ColumnCount = 1;
            messageEmployeeeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            messageEmployeeeTableLayoutPanel.Controls.Add(_messageEmployeeLabel, 0, 0);
            messageEmployeeeTableLayoutPanel.Location = new Point(740, 162);
            messageEmployeeeTableLayoutPanel.Margin = new Padding(4);
            messageEmployeeeTableLayoutPanel.Name = "messageEmployeeeTableLayoutPanel";
            messageEmployeeeTableLayoutPanel.RowCount = 1;
            messageEmployeeeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            messageEmployeeeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 63.0f));
            messageEmployeeeTableLayoutPanel.Size = new Size(553, 64);
            messageEmployeeeTableLayoutPanel.TabIndex = 62;
            // 
            // messageEmployeeLabel
            // 
            _messageEmployeeLabel.BackColor = Color.White;
            _messageEmployeeLabel.Dock = DockStyle.Fill;
            _messageEmployeeLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _messageEmployeeLabel.ForeColor = Color.Black;
            _messageEmployeeLabel.ImageAlign = ContentAlignment.BottomLeft;
            _messageEmployeeLabel.ImageIndex = 0;
            _messageEmployeeLabel.ImageList = ImageList1;
            _messageEmployeeLabel.Location = new Point(5, 1);
            _messageEmployeeLabel.Margin = new Padding(4, 0, 4, 0);
            _messageEmployeeLabel.Name = "_messageEmployeeLabel";
            _messageEmployeeLabel.RightToLeft = RightToLeft.No;
            _messageEmployeeLabel.Size = new Size(543, 62);
            _messageEmployeeLabel.TabIndex = 0;
            _messageEmployeeLabel.Text = "              Message Employees";
            _messageEmployeeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "email.png");
            // 
            // TableLayoutPanel21
            // 
            TableLayoutPanel21.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel21.BackColor = Color.Snow;
            TableLayoutPanel21.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel21.ColumnCount = 2;
            TableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161.0f));
            TableLayoutPanel21.Controls.Add(Label27, 0, 0);
            TableLayoutPanel21.Controls.Add(alertsCountLabel, 1, 0);
            TableLayoutPanel21.Location = new Point(740, 91);
            TableLayoutPanel21.Margin = new Padding(4);
            TableLayoutPanel21.Name = "TableLayoutPanel21";
            TableLayoutPanel21.RowCount = 1;
            TableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            TableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Absolute, 63.0f));
            TableLayoutPanel21.Size = new Size(553, 64);
            TableLayoutPanel21.TabIndex = 60;
            // 
            // Label27
            // 
            Label27.BackColor = Color.White;
            Label27.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = Color.Black;
            Label27.ImageAlign = ContentAlignment.MiddleLeft;
            Label27.ImageIndex = 3;
            Label27.ImageList = panelmageList;
            Label27.Location = new Point(5, 1);
            Label27.Margin = new Padding(4, 0, 4, 0);
            Label27.Name = "Label27";
            Label27.Size = new Size(381, 62);
            Label27.TabIndex = 0;
            Label27.Text = "              Expiry Alerts";
            Label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alertsCountLabel
            // 
            alertsCountLabel.BackColor = Color.White;
            alertsCountLabel.Dock = DockStyle.Fill;
            alertsCountLabel.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            alertsCountLabel.ForeColor = Color.White;
            alertsCountLabel.ImageIndex = 5;
            alertsCountLabel.ImageList = panelmageList;
            alertsCountLabel.Location = new Point(395, 1);
            alertsCountLabel.Margin = new Padding(4, 0, 4, 0);
            alertsCountLabel.Name = "alertsCountLabel";
            alertsCountLabel.Size = new Size(153, 62);
            alertsCountLabel.TabIndex = 2;
            alertsCountLabel.Text = " 0";
            alertsCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel22
            // 
            TableLayoutPanel22.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel22.BackColor = Color.Snow;
            TableLayoutPanel22.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel22.ColumnCount = 2;
            TableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181.0f));
            TableLayoutPanel22.Controls.Add(_Label28, 0, 0);
            TableLayoutPanel22.Controls.Add(_BirthdayCountLabel, 1, 0);
            TableLayoutPanel22.Location = new Point(80, 161);
            TableLayoutPanel22.Margin = new Padding(4);
            TableLayoutPanel22.Name = "TableLayoutPanel22";
            TableLayoutPanel22.RowCount = 1;
            TableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            TableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 63.0f));
            TableLayoutPanel22.Size = new Size(615, 64);
            TableLayoutPanel22.TabIndex = 61;
            // 
            // Label28
            // 
            _Label28.BackColor = Color.White;
            _Label28.Dock = DockStyle.Fill;
            _Label28.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label28.ForeColor = Color.Black;
            _Label28.ImageAlign = ContentAlignment.MiddleLeft;
            _Label28.ImageIndex = 6;
            _Label28.ImageList = panelmageList;
            _Label28.Location = new Point(5, 1);
            _Label28.Margin = new Padding(4, 0, 4, 0);
            _Label28.Name = "_Label28";
            _Label28.Size = new Size(423, 62);
            _Label28.TabIndex = 0;
            _Label28.Text = "              Upcominng Birthdays";
            _Label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BirthdayCountLabel
            // 
            _BirthdayCountLabel.BackColor = Color.White;
            _BirthdayCountLabel.Dock = DockStyle.Fill;
            _BirthdayCountLabel.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _BirthdayCountLabel.ForeColor = Color.White;
            _BirthdayCountLabel.ImageIndex = 1;
            _BirthdayCountLabel.ImageList = panelmageList;
            _BirthdayCountLabel.Location = new Point(437, 1);
            _BirthdayCountLabel.Margin = new Padding(4, 0, 4, 0);
            _BirthdayCountLabel.Name = "_BirthdayCountLabel";
            _BirthdayCountLabel.Size = new Size(173, 62);
            _BirthdayCountLabel.TabIndex = 2;
            _BirthdayCountLabel.Text = " 0";
            _BirthdayCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label47
            // 
            Label47.AutoSize = true;
            Label47.Dock = DockStyle.Top;
            Label47.ForeColor = Color.Gray;
            Label47.Location = new Point(0, 37);
            Label47.Margin = new Padding(4, 0, 4, 0);
            Label47.Name = "Label47";
            Label47.Padding = new Padding(67, 0, 0, 0);
            Label47.Size = new Size(1965, 16);
            Label47.TabIndex = 31;
            Label47.Text = resources.GetString("Label47.Text");
            // 
            // Label48
            // 
            Label48.AutoSize = true;
            Label48.Dock = DockStyle.Top;
            Label48.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label48.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label48.Location = new Point(0, 0);
            Label48.Margin = new Padding(4, 0, 4, 0);
            Label48.Name = "Label48";
            Label48.Padding = new Padding(67, 12, 0, 0);
            Label48.Size = new Size(169, 37);
            Label48.TabIndex = 30;
            Label48.Text = "Employees";
            Label48.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Panel4
            // 
            Panel4.Dock = DockStyle.Bottom;
            Panel4.Location = new Point(0, 965);
            Panel4.Margin = new Padding(4);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1368, 47);
            Panel4.TabIndex = 66;
            // 
            // actionComboBox1
            // 
            _actionComboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _actionComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            _actionComboBox1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _actionComboBox1.FormattingEnabled = true;
            _actionComboBox1.Items.AddRange(new object[] { "New", "Approved", "Declined", "Dismissed", "Solved" });
            _actionComboBox1.Location = new Point(1675, 965);
            _actionComboBox1.Margin = new Padding(4);
            _actionComboBox1.Name = "_actionComboBox1";
            _actionComboBox1.Size = new Size(151, 29);
            _actionComboBox1.TabIndex = 49;
            // 
            // typeComboBox
            // 
            _typeComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _typeComboBox.FormattingEnabled = true;
            _typeComboBox.Items.AddRange(new object[] { "All", "Reminders", "Requests", "Warnings" });
            _typeComboBox.Location = new Point(1437, 965);
            _typeComboBox.Margin = new Padding(4);
            _typeComboBox.Name = "_typeComboBox";
            _typeComboBox.Size = new Size(160, 29);
            _typeComboBox.TabIndex = 47;
            // 
            // NotificationCenter1
            // 
            _NotificationCenter1.BackColor = Color.Transparent;
            _NotificationCenter1.BodyFontSize = Conversions.ToShort(14);
            _NotificationCenter1.ButtonCaptionForeColour = Color.White;
            _NotificationCenter1.ButtonFontSize = Conversions.ToShort(16);
            _NotificationCenter1.ButtonWidth = Conversions.ToShort(130);
            _NotificationCenter1.CaptionFontSzie = Conversions.ToShort(14);
            _NotificationCenter1.Dock = DockStyle.Right;
            _NotificationCenter1.FloatButtonCaption = false;
            _NotificationCenter1.Location = new Point(1368, 0);
            _NotificationCenter1.Margin = new Padding(3, 2, 3, 2);
            _NotificationCenter1.Name = "_NotificationCenter1";
            _NotificationCenter1.NotificationAlert = false;
            _NotificationCenter1.NotificationBackColour = SystemColors.ControlDarkDark;
            _NotificationCenter1.NotifyBox3DBevel = Conversions.ToShort(0);
            _NotificationCenter1.RefreshNotifications = false;
            _NotificationCenter1.Size = new Size(468, 1012);
            _NotificationCenter1.TabIndex = 48;
            // 
            // FrmHomePage
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1856, 1074);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmHomePage";
            StartPosition = FormStartPosition.Manual;
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            StatasContainerFlowLayoutPanel.ResumeLayout(false);
            containersMainWidgetPanel.ResumeLayout(false);
            containersMainWidgetPanel.PerformLayout();
            TableLayoutPanel15.ResumeLayout(false);
            TableLayoutPanel16.ResumeLayout(false);
            TableLayoutPanel17.ResumeLayout(false);
            TableLayoutPanel18.ResumeLayout(false);
            TableLayoutPanel18.PerformLayout();
            TableLayoutPanel19.ResumeLayout(false);
            TableLayoutPanel10.ResumeLayout(false);
            TableLayoutPanel11.ResumeLayout(false);
            TableLayoutPanel12.ResumeLayout(false);
            TableLayoutPanel13.ResumeLayout(false);
            TableLayoutPanel13.PerformLayout();
            TableLayoutPanel14.ResumeLayout(false);
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel7.ResumeLayout(false);
            TableLayoutPanel8.ResumeLayout(false);
            TableLayoutPanel8.PerformLayout();
            TableLayoutPanel9.ResumeLayout(false);
            TransfersTableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TableLayoutPanel23.ResumeLayout(false);
            TableLayoutPanel23.PerformLayout();
            TableLayoutPanel20.ResumeLayout(false);
            messageEmployeeeTableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel21.ResumeLayout(false);
            TableLayoutPanel22.ResumeLayout(false);
            Load += new EventHandler(Form1_Load);
            Resize += new EventHandler(FrmHomeScreen_Resize);
            ResumeLayout(false);
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        internal Panel mainPanel;
        private ComboBox _actionComboBox1;

        internal ComboBox actionComboBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _actionComboBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_actionComboBox1 != null)
                {
                    _actionComboBox1.SelectedIndexChanged -= actiongeComboBox_SelectedIndexChanged;
                }

                _actionComboBox1 = value;
                if (_actionComboBox1 != null)
                {
                    _actionComboBox1.SelectedIndexChanged += actiongeComboBox_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _typeComboBox;

        internal ComboBox typeComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _typeComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_typeComboBox != null)
                {
                    _typeComboBox.SelectedIndexChanged -= typeMessageComboBox_SelectedIndexChanged;
                }

                _typeComboBox = value;
                if (_typeComboBox != null)
                {
                    _typeComboBox.SelectedIndexChanged += typeMessageComboBox_SelectedIndexChanged;
                }
            }
        }

        private YardTabletControls.NotificationCenter _NotificationCenter1;

        internal YardTabletControls.NotificationCenter NotificationCenter1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NotificationCenter1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NotificationCenter1 != null)
                {
                    _NotificationCenter1.NotifyButtonPressed -= NotificationCenter1_NotifyButtonPressed;
                    _NotificationCenter1.ExpandNotifications -= NotificationCenter1_ExpandNotifications;
                }

                _NotificationCenter1 = value;
                if (_NotificationCenter1 != null)
                {
                    _NotificationCenter1.NotifyButtonPressed += NotificationCenter1_NotifyButtonPressed;
                    _NotificationCenter1.ExpandNotifications += NotificationCenter1_ExpandNotifications;
                }
            }
        }

        internal ImageList panelmageList;
        internal Label toOtherTerminalLabel;
        internal Label containersInTransferLabel;
        internal Label toLindseyLabel;
        internal Label toEwenLabel;
        internal Label Label12;
        internal TableLayoutPanel TableLayoutPanel2;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label2;
        internal TableLayoutPanel TableLayoutPanel3;
        internal TableLayoutPanel TransfersTableLayoutPanel;
        internal TableLayoutPanel TableLayoutPanel5;
        internal FlowLayoutPanel StatasContainerFlowLayoutPanel;
        internal Panel containersMainWidgetPanel;
        internal Label Label6;
        internal Label Label7;
        internal Label Label26;
        internal TableLayoutPanel TableLayoutPanel15;
        internal TableLayoutPanel TableLayoutPanel16;
        internal TableLayoutPanel TableLayoutPanel17;
        internal Label Label19;
        internal Label Label20;
        internal TableLayoutPanel TableLayoutPanel18;
        internal Label Label21;
        internal Label Label22;
        internal TableLayoutPanel TableLayoutPanel19;
        internal Label Label23;
        internal Label Label25;
        internal TableLayoutPanel TableLayoutPanel10;
        internal TableLayoutPanel TableLayoutPanel11;
        internal TableLayoutPanel TableLayoutPanel12;
        internal Label Label11;
        internal Label Label13;
        internal TableLayoutPanel TableLayoutPanel13;
        internal Label Label14;
        internal Label Label15;
        internal TableLayoutPanel TableLayoutPanel14;
        internal Label Label16;
        internal Label Label17;
        internal Label Label18;
        internal TableLayoutPanel TableLayoutPanel4;
        internal TableLayoutPanel TableLayoutPanel6;
        internal TableLayoutPanel TableLayoutPanel7;
        internal Label Label4;
        internal Label Label1;
        internal TableLayoutPanel TableLayoutPanel8;
        internal Label Label10;
        internal Label Label3;
        internal TableLayoutPanel TableLayoutPanel9;
        internal Label Label5;
        internal Label Label9;
        internal Panel Panel2;
        internal Label Label47;
        internal Label Label48;
        internal TableLayoutPanel TableLayoutPanel20;
        private Label _Label24;

        internal Label Label24
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label24;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label24 != null)
                {
                    _Label24.Click -= Label2_Click;
                }

                _Label24 = value;
                if (_Label24 != null)
                {
                    _Label24.Click += Label2_Click;
                }
            }
        }

        private Label _probationPeriodNumberLabel;

        internal Label probationPeriodNumberLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _probationPeriodNumberLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_probationPeriodNumberLabel != null)
                {
                    _probationPeriodNumberLabel.Click -= Label2_Click;
                }

                _probationPeriodNumberLabel = value;
                if (_probationPeriodNumberLabel != null)
                {
                    _probationPeriodNumberLabel.Click += Label2_Click;
                }
            }
        }

        internal TableLayoutPanel messageEmployeeeTableLayoutPanel;
        private Label _messageEmployeeLabel;

        internal Label messageEmployeeLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _messageEmployeeLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_messageEmployeeLabel != null)
                {
                    _messageEmployeeLabel.Click -= messageEmployeeLabel_Click;
                }

                _messageEmployeeLabel = value;
                if (_messageEmployeeLabel != null)
                {
                    _messageEmployeeLabel.Click += messageEmployeeLabel_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel21;
        internal Label Label27;
        internal Label alertsCountLabel;
        internal TableLayoutPanel TableLayoutPanel22;
        private Label _Label28;

        internal Label Label28
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label28;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label28 != null)
                {
                    _Label28.Click -= Label15_Click;
                }

                _Label28 = value;
                if (_Label28 != null)
                {
                    _Label28.Click += Label15_Click;
                }
            }
        }

        private Label _BirthdayCountLabel;

        internal Label BirthdayCountLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BirthdayCountLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BirthdayCountLabel != null)
                {
                    _BirthdayCountLabel.Click -= Label15_Click;
                }

                _BirthdayCountLabel = value;
                if (_BirthdayCountLabel != null)
                {
                    _BirthdayCountLabel.Click += Label15_Click;
                }
            }
        }

        internal Panel Panel3;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabel4;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabel3;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabel2;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabel1;
        internal Label Label30;
        internal TableLayoutPanel TableLayoutPanel23;
        internal Label totalNumbEmployeesLabel;
        internal Label Label29;
        internal Label activeEmpNumbLabel;
        internal Label InactiveEmpNumberLabel;
        internal Panel Panel4;
        internal ImageList ImageList1;
        internal Label Label8;
    }
}