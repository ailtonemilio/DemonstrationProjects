using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEmployeeManagementHP : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeManagementHP));
            ImageList1 = new ImageList(components);
            ImageList2 = new ImageList(components);
            panelmageList = new ImageList(components);
            Splitter1 = new Splitter();
            Label16 = new Label();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel5 = new Panel();
            Panel1 = new Panel();
            scrollFlowLayoutPanel = new FlowLayoutPanel();
            Panel6 = new Panel();
            Panel4 = new Panel();
            Label9 = new Label();
            Label20 = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            totalNumbEmployeesLabel = new Label();
            Label8 = new Label();
            activeEmpNumbLabel = new Label();
            InactiveEmpNumberLabel = new Label();
            Panel3 = new Panel();
            Label6 = new Label();
            TableLayoutPanel4 = new TableLayoutPanel();
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            Label11 = new Label();
            Label7 = new Label();
            Panel2 = new Panel();
            Label5 = new Label();
            Label4 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            Label2 = new Label();
            probationPeriodNumberLabel = new Label();
            messageEmployeeeTableLayoutPanel = new TableLayoutPanel();
            messageEmployeeLabel = new Label();
            TableLayoutPanel2 = new TableLayoutPanel();
            Label3 = new Label();
            alertsCountLabel = new Label();
            TableLayoutPanel5 = new TableLayoutPanel();
            Label15 = new Label();
            BirthdayCountLabel = new Label();
            BunifuShadowPanel1.SuspendLayout();
            Panel5.SuspendLayout();
            Panel1.SuspendLayout();
            scrollFlowLayoutPanel.SuspendLayout();
            Panel6.SuspendLayout();
            Panel4.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel3.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            messageEmployeeeTableLayoutPanel.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "email.png");
            // 
            // ImageList2
            // 
            ImageList2.ImageStream = (ImageListStreamer)resources.GetObject("ImageList2.ImageStream");
            ImageList2.TransparentColor = Color.Transparent;
            ImageList2.Images.SetKeyName(0, "empManag.jpg");
            ImageList2.Images.SetKeyName(1, "trackerTime1.jpg");
            ImageList2.Images.SetKeyName(2, "clock5.jpg");
            ImageList2.Images.SetKeyName(3, "label.png");
            ImageList2.Images.SetKeyName(4, "incident-management.png");
            ImageList2.Images.SetKeyName(5, "timeManagement.png");
            ImageList2.Images.SetKeyName(6, "timeReports.png");
            ImageList2.Images.SetKeyName(7, "Block-Container-png.png");
            ImageList2.Images.SetKeyName(8, "Transfer-Container.png");
            ImageList2.Images.SetKeyName(9, "Container-Management.png");
            ImageList2.Images.SetKeyName(10, "printer-label-icon.png");
            ImageList2.Images.SetKeyName(11, "ContactIcon.png");
            ImageList2.Images.SetKeyName(12, "scriptPaper.png");
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
            // Splitter1
            // 
            Splitter1.Location = new Point(0, 0);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new Size(3, 988);
            Splitter1.TabIndex = 14;
            Splitter1.TabStop = false;
            // 
            // Label16
            // 
            Label16.BackColor = Color.White;
            Label16.Dock = DockStyle.Fill;
            Label16.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = Color.White;
            Label16.ImageIndex = 1;
            Label16.ImageList = panelmageList;
            Label16.Location = new Point(445, 1);
            Label16.Name = "Label16";
            Label16.Size = new Size(115, 56);
            Label16.TabIndex = 2;
            Label16.Text = " 0";
            Label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel5);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(3, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 10, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1548, 988);
            BunifuShadowPanel1.TabIndex = 34;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.DimGray;
            Panel5.Controls.Add(Panel1);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(10, 10);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(1533, 973);
            Panel5.TabIndex = 32;
            // 
            // Panel1
            // 
            Panel1.AutoScroll = true;
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(scrollFlowLayoutPanel);
            Panel1.Dock = DockStyle.Bottom;
            Panel1.Location = new Point(0, 53);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1533, 920);
            Panel1.TabIndex = 33;
            // 
            // scrollFlowLayoutPanel
            // 
            scrollFlowLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            scrollFlowLayoutPanel.AutoScroll = true;
            scrollFlowLayoutPanel.Controls.Add(Panel6);
            scrollFlowLayoutPanel.Location = new Point(-28, -2);
            scrollFlowLayoutPanel.Name = "scrollFlowLayoutPanel";
            scrollFlowLayoutPanel.Size = new Size(1566, 877);
            scrollFlowLayoutPanel.TabIndex = 36;
            // 
            // Panel6
            // 
            Panel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Panel6.Controls.Add(Panel4);
            Panel6.Controls.Add(Panel3);
            Panel6.Controls.Add(Panel2);
            Panel6.Location = new Point(3, 3);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(1463, 1303);
            Panel6.TabIndex = 0;
            // 
            // Panel4
            // 
            Panel4.Controls.Add(Label9);
            Panel4.Controls.Add(Label20);
            Panel4.Controls.Add(TableLayoutPanel3);
            Panel4.Dock = DockStyle.Top;
            Panel4.Location = new Point(0, 731);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1463, 359);
            Panel4.TabIndex = 36;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Dock = DockStyle.Top;
            Label9.ForeColor = Color.Gray;
            Label9.Location = new Point(0, 32);
            Label9.Name = "Label9";
            Label9.Padding = new Padding(70, 0, 0, 0);
            Label9.Size = new Size(2255, 13);
            Label9.TabIndex = 31;
            Label9.Text = resources.GetString("Label9.Text");
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Dock = DockStyle.Top;
            Label20.Font = new Font("Segoe UI", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label20.Location = new Point(0, 0);
            Label20.Name = "Label20";
            Label20.Padding = new Padding(70, 0, 0, 0);
            Label20.Size = new Size(190, 32);
            Label20.TabIndex = 30;
            Label20.Text = "Employee";
            Label20.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.AutoSize = true;
            TableLayoutPanel3.BackColor = Color.Green;
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.41935f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.58065f));
            TableLayoutPanel3.Controls.Add(totalNumbEmployeesLabel, 0, 0);
            TableLayoutPanel3.Controls.Add(Label8, 0, 1);
            TableLayoutPanel3.Controls.Add(activeEmpNumbLabel, 0, 2);
            TableLayoutPanel3.Controls.Add(InactiveEmpNumberLabel, 1, 2);
            TableLayoutPanel3.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel3.ForeColor = Color.White;
            TableLayoutPanel3.Location = new Point(89, 51);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.Padding = new Padding(10);
            TableLayoutPanel3.RowCount = 3;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 67.64706f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32.35294f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 90.0f));
            TableLayoutPanel3.Size = new Size(308, 236);
            TableLayoutPanel3.TabIndex = 32;
            // 
            // totalNumbEmployeesLabel
            // 
            totalNumbEmployeesLabel.AutoSize = true;
            totalNumbEmployeesLabel.Font = new Font("Microsoft Sans Serif", 48.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            totalNumbEmployeesLabel.Location = new Point(13, 10);
            totalNumbEmployeesLabel.Name = "totalNumbEmployeesLabel";
            totalNumbEmployeesLabel.Size = new Size(119, 85);
            totalNumbEmployeesLabel.TabIndex = 0;
            totalNumbEmployeesLabel.Text = "19";
            totalNumbEmployeesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(13, 95);
            Label8.Name = "Label8";
            Label8.Size = new Size(118, 25);
            Label8.TabIndex = 1;
            Label8.Text = "Employees";
            // 
            // activeEmpNumbLabel
            // 
            activeEmpNumbLabel.Anchor = AnchorStyles.None;
            activeEmpNumbLabel.BackColor = Color.DarkSeaGreen;
            activeEmpNumbLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            activeEmpNumbLabel.Location = new Point(17, 146);
            activeEmpNumbLabel.Name = "activeEmpNumbLabel";
            activeEmpNumbLabel.Size = new Size(135, 68);
            activeEmpNumbLabel.TabIndex = 2;
            activeEmpNumbLabel.Text = "Active" + '\r' + '\n' + "19";
            activeEmpNumbLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InactiveEmpNumberLabel
            // 
            InactiveEmpNumberLabel.Anchor = AnchorStyles.None;
            InactiveEmpNumberLabel.BackColor = Color.DarkSeaGreen;
            InactiveEmpNumberLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            InactiveEmpNumberLabel.Location = new Point(163, 146);
            InactiveEmpNumberLabel.Name = "InactiveEmpNumberLabel";
            InactiveEmpNumberLabel.Size = new Size(131, 68);
            InactiveEmpNumberLabel.TabIndex = 3;
            InactiveEmpNumberLabel.Text = "Inactive" + '\r' + '\n' + "0";
            InactiveEmpNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            Panel3.Controls.Add(Label6);
            Panel3.Controls.Add(TableLayoutPanel4);
            Panel3.Controls.Add(Label7);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(0, 353);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1463, 378);
            Panel3.TabIndex = 35;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Dock = DockStyle.Top;
            Label6.ForeColor = Color.Gray;
            Label6.Location = new Point(0, 32);
            Label6.Name = "Label6";
            Label6.Padding = new Padding(70, 0, 0, 0);
            Label6.Size = new Size(2255, 13);
            Label6.TabIndex = 31;
            Label6.Text = resources.GetString("Label6.Text");
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.AutoSize = true;
            TableLayoutPanel4.BackColor = Color.Teal;
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.41935f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.58065f));
            TableLayoutPanel4.Controls.Add(Label12, 0, 1);
            TableLayoutPanel4.Controls.Add(Label13, 0, 2);
            TableLayoutPanel4.Controls.Add(Label14, 1, 2);
            TableLayoutPanel4.Controls.Add(Label11, 0, 0);
            TableLayoutPanel4.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel4.ForeColor = Color.White;
            TableLayoutPanel4.Location = new Point(74, 75);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.Padding = new Padding(10);
            TableLayoutPanel4.RowCount = 3;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 67.64706f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 32.35294f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 90.0f));
            TableLayoutPanel4.Size = new Size(300, 236);
            TableLayoutPanel4.TabIndex = 33;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(13, 95);
            Label12.Name = "Label12";
            Label12.Size = new Size(103, 25);
            Label12.TabIndex = 1;
            Label12.Text = "Requests";
            // 
            // Label13
            // 
            Label13.Anchor = AnchorStyles.None;
            Label13.BackColor = Color.LightSeaGreen;
            Label13.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(15, 146);
            Label13.Name = "Label13";
            Label13.Size = new Size(136, 68);
            Label13.TabIndex = 2;
            Label13.Text = "Vacation" + '\r' + '\n' + "0";
            Label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.None;
            Label14.BackColor = Color.LightSeaGreen;
            Label14.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.Location = new Point(159, 146);
            Label14.Name = "Label14";
            Label14.Size = new Size(127, 68);
            Label14.TabIndex = 3;
            Label14.Text = "Day off" + '\r' + '\n' + "0";
            Label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 48.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(13, 10);
            Label11.Name = "Label11";
            Label11.Size = new Size(78, 85);
            Label11.TabIndex = 0;
            Label11.Text = "0";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Dock = DockStyle.Top;
            Label7.Font = new Font("Segoe UI", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(0, 0);
            Label7.Name = "Label7";
            Label7.Padding = new Padding(70, 0, 0, 0);
            Label7.Size = new Size(180, 32);
            Label7.TabIndex = 30;
            Label7.Text = "Requests";
            Label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(Label5);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(TableLayoutPanel1);
            Panel2.Controls.Add(messageEmployeeeTableLayoutPanel);
            Panel2.Controls.Add(TableLayoutPanel2);
            Panel2.Controls.Add(TableLayoutPanel5);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 0);
            Panel2.Name = "Panel2";
            Panel2.Padding = new Padding(0, 50, 0, 0);
            Panel2.Size = new Size(1463, 353);
            Panel2.TabIndex = 31;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Dock = DockStyle.Top;
            Label5.ForeColor = Color.Gray;
            Label5.Location = new Point(0, 82);
            Label5.Name = "Label5";
            Label5.Padding = new Padding(70, 0, 0, 0);
            Label5.Size = new Size(2255, 13);
            Label5.TabIndex = 31;
            Label5.Text = resources.GetString("Label5.Text");
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Top;
            Label4.Font = new Font("Segoe UI", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(0, 50);
            Label4.Name = "Label4";
            Label4.Padding = new Padding(70, 0, 0, 0);
            Label4.Size = new Size(245, 32);
            Label4.TabIndex = 30;
            Label4.Text = "Coming Events";
            Label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel1.BackColor = Color.Snow;
            TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110.0f));
            TableLayoutPanel1.Controls.Add(Label2, 0, 0);
            TableLayoutPanel1.Controls.Add(probationPeriodNumberLabel, 1, 0);
            TableLayoutPanel1.Location = new Point(72, 125);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57.0f));
            TableLayoutPanel1.Size = new Size(486, 58);
            TableLayoutPanel1.TabIndex = 15;
            // 
            // Label2
            // 
            Label2.BackColor = Color.White;
            Label2.Dock = DockStyle.Fill;
            Label2.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Black;
            Label2.ImageAlign = ContentAlignment.MiddleLeft;
            Label2.ImageIndex = 2;
            Label2.ImageList = panelmageList;
            Label2.Location = new Point(4, 1);
            Label2.Name = "Label2";
            Label2.Size = new Size(367, 56);
            Label2.TabIndex = 0;
            Label2.Text = "              Probation period reminder";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // probationPeriodNumberLabel
            // 
            probationPeriodNumberLabel.BackColor = Color.White;
            probationPeriodNumberLabel.Dock = DockStyle.Fill;
            probationPeriodNumberLabel.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            probationPeriodNumberLabel.ForeColor = Color.White;
            probationPeriodNumberLabel.ImageIndex = 4;
            probationPeriodNumberLabel.ImageList = panelmageList;
            probationPeriodNumberLabel.Location = new Point(378, 1);
            probationPeriodNumberLabel.Name = "probationPeriodNumberLabel";
            probationPeriodNumberLabel.Size = new Size(104, 56);
            probationPeriodNumberLabel.TabIndex = 2;
            probationPeriodNumberLabel.Text = " 0";
            probationPeriodNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // messageEmployeeeTableLayoutPanel
            // 
            messageEmployeeeTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messageEmployeeeTableLayoutPanel.BackColor = Color.Snow;
            messageEmployeeeTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            messageEmployeeeTableLayoutPanel.ColumnCount = 1;
            messageEmployeeeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            messageEmployeeeTableLayoutPanel.Controls.Add(messageEmployeeLabel, 0, 0);
            messageEmployeeeTableLayoutPanel.Location = new Point(648, 211);
            messageEmployeeeTableLayoutPanel.Name = "messageEmployeeeTableLayoutPanel";
            messageEmployeeeTableLayoutPanel.RowCount = 1;
            messageEmployeeeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            messageEmployeeeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 57.0f));
            messageEmployeeeTableLayoutPanel.Size = new Size(440, 58);
            messageEmployeeeTableLayoutPanel.TabIndex = 29;
            // 
            // messageEmployeeLabel
            // 
            messageEmployeeLabel.BackColor = Color.White;
            messageEmployeeLabel.Dock = DockStyle.Fill;
            messageEmployeeLabel.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            messageEmployeeLabel.ForeColor = Color.Black;
            messageEmployeeLabel.ImageAlign = ContentAlignment.MiddleLeft;
            messageEmployeeLabel.ImageIndex = 0;
            messageEmployeeLabel.ImageList = ImageList1;
            messageEmployeeLabel.Location = new Point(4, 1);
            messageEmployeeLabel.Name = "messageEmployeeLabel";
            messageEmployeeLabel.RightToLeft = RightToLeft.No;
            messageEmployeeLabel.Size = new Size(432, 56);
            messageEmployeeLabel.TabIndex = 0;
            messageEmployeeLabel.Text = "  Message Employees";
            messageEmployeeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel2.BackColor = Color.Snow;
            TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93.0f));
            TableLayoutPanel2.Controls.Add(Label3, 0, 0);
            TableLayoutPanel2.Controls.Add(alertsCountLabel, 1, 0);
            TableLayoutPanel2.Location = new Point(652, 124);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 57.0f));
            TableLayoutPanel2.Size = new Size(436, 58);
            TableLayoutPanel2.TabIndex = 16;
            // 
            // Label3
            // 
            Label3.BackColor = Color.White;
            Label3.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Black;
            Label3.ImageAlign = ContentAlignment.MiddleLeft;
            Label3.ImageIndex = 3;
            Label3.ImageList = panelmageList;
            Label3.Location = new Point(4, 1);
            Label3.Name = "Label3";
            Label3.Size = new Size(334, 56);
            Label3.TabIndex = 0;
            Label3.Text = "              Expiry Alerts";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alertsCountLabel
            // 
            alertsCountLabel.BackColor = Color.White;
            alertsCountLabel.Dock = DockStyle.Fill;
            alertsCountLabel.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            alertsCountLabel.ForeColor = Color.White;
            alertsCountLabel.ImageIndex = 5;
            alertsCountLabel.ImageList = panelmageList;
            alertsCountLabel.Location = new Point(345, 1);
            alertsCountLabel.Name = "alertsCountLabel";
            alertsCountLabel.Size = new Size(87, 56);
            alertsCountLabel.TabIndex = 2;
            alertsCountLabel.Text = " 0";
            alertsCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel5.BackColor = Color.Snow;
            TableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107.0f));
            TableLayoutPanel5.Controls.Add(Label15, 0, 0);
            TableLayoutPanel5.Controls.Add(BirthdayCountLabel, 1, 0);
            TableLayoutPanel5.Location = new Point(72, 212);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4375f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 57.0f));
            TableLayoutPanel5.Size = new Size(486, 58);
            TableLayoutPanel5.TabIndex = 20;
            // 
            // Label15
            // 
            Label15.BackColor = Color.White;
            Label15.Dock = DockStyle.Fill;
            Label15.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.Black;
            Label15.ImageAlign = ContentAlignment.MiddleLeft;
            Label15.ImageIndex = 6;
            Label15.ImageList = panelmageList;
            Label15.Location = new Point(4, 1);
            Label15.Name = "Label15";
            Label15.Size = new Size(370, 56);
            Label15.TabIndex = 0;
            Label15.Text = "              Upcominng Birthdays";
            Label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BirthdayCountLabel
            // 
            BirthdayCountLabel.BackColor = Color.White;
            BirthdayCountLabel.Dock = DockStyle.Fill;
            BirthdayCountLabel.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BirthdayCountLabel.ForeColor = Color.White;
            BirthdayCountLabel.ImageIndex = 1;
            BirthdayCountLabel.ImageList = panelmageList;
            BirthdayCountLabel.Location = new Point(381, 1);
            BirthdayCountLabel.Name = "BirthdayCountLabel";
            BirthdayCountLabel.Size = new Size(101, 56);
            BirthdayCountLabel.TabIndex = 2;
            BirthdayCountLabel.Text = " 0";
            BirthdayCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmEmployeeManagementHP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1551, 988);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            Controls.Add(Splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmEmployeeManagementHP";
            StartPosition = FormStartPosition.CenterScreen;
            BunifuShadowPanel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            scrollFlowLayoutPanel.ResumeLayout(false);
            Panel6.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            messageEmployeeeTableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel5.ResumeLayout(false);
            Load += new EventHandler(FrmOptionsManagement_Load);
            Closed += new EventHandler(FrmOptionsManagement_Closed);
            ResumeLayout(false);
        }

        internal ImageList ImageList1;
        // Friend WithEvents Dashboard1 As WTC_CeresControls.Dashboard
        internal ImageList ImageList2;
        internal ImageList panelmageList;
        internal Splitter Splitter1;
        internal Label Label16;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel5;
        internal Panel Panel1;
        internal FlowLayoutPanel scrollFlowLayoutPanel;
        internal Panel Panel6;
        internal Panel Panel4;
        internal Label Label9;
        internal Label Label20;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label totalNumbEmployeesLabel;
        internal Label Label8;
        internal Label activeEmpNumbLabel;
        internal Label InactiveEmpNumberLabel;
        internal Panel Panel3;
        internal Label Label6;
        internal TableLayoutPanel TableLayoutPanel4;
        internal Label Label12;
        internal Label Label13;
        internal Label Label14;
        internal Label Label11;
        internal Label Label7;
        internal Panel Panel2;
        internal Label Label5;
        internal Label Label4;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label2;
        internal Label probationPeriodNumberLabel;
        internal TableLayoutPanel messageEmployeeeTableLayoutPanel;
        internal Label messageEmployeeLabel;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label3;
        internal Label alertsCountLabel;
        internal TableLayoutPanel TableLayoutPanel5;
        internal Label Label15;
        internal Label BirthdayCountLabel;
    }
}