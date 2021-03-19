using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEDI : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEDI));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _userServerCheckBox = new CheckBox();
            _userServerCheckBox.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged_1);
            Label4 = new Label();
            serverTableLayoutPanel = new TableLayoutPanel();
            Label16 = new Label();
            TableLayoutPanel5 = new TableLayoutPanel();
            folderNameTextBox10 = new TextBox();
            TableLayoutPanel3 = new TableLayoutPanel();
            portNumberNumericUpDown1 = new NumericUpDown();
            TableLayoutPanel4 = new TableLayoutPanel();
            userNameTextBox5 = new TextBox();
            Label7 = new Label();
            TableLayoutPanel12 = new TableLayoutPanel();
            passwordTextBox7 = new TextBox();
            Label8 = new Label();
            Label9 = new Label();
            TableLayoutPanel13 = new TableLayoutPanel();
            ipAddressTextBox8 = new TextBox();
            Label10 = new Label();
            Label6 = new Label();
            TableLayoutPanel2 = new TableLayoutPanel();
            serverNameTextBox6 = new TextBox();
            TableLayoutPanel14 = new TableLayoutPanel();
            prefixTextBox9 = new TextBox();
            Label15 = new Label();
            Label3 = new Label();
            Label17 = new Label();
            versionTextBox = new TextBox();
            Label14 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            requireEDIInOutGatesCheckBox1 = new CheckBox();
            TableLayoutPanel10 = new TableLayoutPanel();
            senderTextBox = new TextBox();
            TableLayoutPanel8 = new TableLayoutPanel();
            clientTextBox = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            TableLayoutPanel9 = new TableLayoutPanel();
            codeTextBox = new TextBox();
            Label12 = new Label();
            preSendsCheckBox2 = new CheckBox();
            _emailEDICheckBox = new CheckBox();
            _emailEDICheckBox.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged);
            ediEmailTableLayoutPanel = new TableLayoutPanel();
            Label13 = new Label();
            emailTextBox3 = new TextBox();
            Label11 = new Label();
            TableLayoutPanel11 = new TableLayoutPanel();
            lineDelimeterTextBox2 = new TextBox();
            TableLayoutPanel6 = new TableLayoutPanel();
            securityCodeTextBox1 = new TextBox();
            TableLayoutPanel7 = new TableLayoutPanel();
            Label5 = new Label();
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(Button3_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Button4_Click);
            serverTableLayoutPanel.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)portNumberNumericUpDown1).BeginInit();
            TableLayoutPanel4.SuspendLayout();
            TableLayoutPanel12.SuspendLayout();
            TableLayoutPanel13.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel14.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel10.SuspendLayout();
            TableLayoutPanel8.SuspendLayout();
            TableLayoutPanel9.SuspendLayout();
            ediEmailTableLayoutPanel.SuspendLayout();
            TableLayoutPanel11.SuspendLayout();
            TableLayoutPanel6.SuspendLayout();
            TableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // userServerCheckBox
            // 
            _userServerCheckBox.AutoSize = true;
            _userServerCheckBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _userServerCheckBox.Location = new Point(39, 397);
            _userServerCheckBox.Name = "_userServerCheckBox";
            _userServerCheckBox.Size = new Size(306, 29);
            _userServerCheckBox.TabIndex = 63;
            _userServerCheckBox.Text = "Use FTP / SFTP Server to Upload";
            _userServerCheckBox.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Fill;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(3, 152);
            Label4.Name = "Label4";
            Label4.Size = new Size(224, 38);
            Label4.TabIndex = 3;
            Label4.Text = "EDI Version:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // serverTableLayoutPanel
            // 
            serverTableLayoutPanel.ColumnCount = 4;
            serverTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.95774f));
            serverTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.04225f));
            serverTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185.0f));
            serverTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215.0f));
            serverTableLayoutPanel.Controls.Add(Label16, 0, 5);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel5, 0, 5);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel3, 1, 4);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel4, 1, 1);
            serverTableLayoutPanel.Controls.Add(Label7, 0, 1);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel12, 1, 2);
            serverTableLayoutPanel.Controls.Add(Label8, 0, 2);
            serverTableLayoutPanel.Controls.Add(Label9, 0, 3);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel13, 1, 3);
            serverTableLayoutPanel.Controls.Add(Label10, 0, 4);
            serverTableLayoutPanel.Controls.Add(Label6, 0, 0);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel2, 1, 0);
            serverTableLayoutPanel.Controls.Add(TableLayoutPanel14, 3, 0);
            serverTableLayoutPanel.Controls.Add(Label15, 2, 0);
            serverTableLayoutPanel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            serverTableLayoutPanel.Location = new Point(32, 437);
            serverTableLayoutPanel.Name = "serverTableLayoutPanel";
            serverTableLayoutPanel.RowCount = 6;
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            serverTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            serverTableLayoutPanel.Size = new Size(1091, 237);
            serverTableLayoutPanel.TabIndex = 62;
            serverTableLayoutPanel.Visible = false;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Dock = DockStyle.Fill;
            Label16.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(3, 195);
            Label16.Name = "Label16";
            Label16.Size = new Size(221, 42);
            Label16.TabIndex = 57;
            Label16.Text = "FTP / SFTP Folder Name:";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.ColumnCount = 1;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel5.Controls.Add(folderNameTextBox10, 0, 0);
            TableLayoutPanel5.Dock = DockStyle.Fill;
            TableLayoutPanel5.Location = new Point(229, 197);
            TableLayoutPanel5.Margin = new Padding(2);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel5.Size = new Size(459, 38);
            TableLayoutPanel5.TabIndex = 56;
            // 
            // folderNameTextBox10
            // 
            folderNameTextBox10.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            folderNameTextBox10.Location = new Point(3, 3);
            folderNameTextBox10.Name = "folderNameTextBox10";
            folderNameTextBox10.Size = new Size(416, 28);
            folderNameTextBox10.TabIndex = 4;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 1;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel3.Controls.Add(portNumberNumericUpDown1, 0, 0);
            TableLayoutPanel3.Dock = DockStyle.Fill;
            TableLayoutPanel3.Location = new Point(230, 159);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.Size = new Size(457, 33);
            TableLayoutPanel3.TabIndex = 48;
            // 
            // portNumberNumericUpDown1
            // 
            portNumberNumericUpDown1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            portNumberNumericUpDown1.Location = new Point(3, 3);
            portNumberNumericUpDown1.Name = "portNumberNumericUpDown1";
            portNumberNumericUpDown1.Size = new Size(125, 32);
            portNumberNumericUpDown1.TabIndex = 5;
            portNumberNumericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 1;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel4.Controls.Add(userNameTextBox5, 0, 0);
            TableLayoutPanel4.Dock = DockStyle.Fill;
            TableLayoutPanel4.Location = new Point(229, 41);
            TableLayoutPanel4.Margin = new Padding(2);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 1;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.Size = new Size(459, 35);
            TableLayoutPanel4.TabIndex = 12;
            // 
            // userNameTextBox5
            // 
            userNameTextBox5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            userNameTextBox5.Location = new Point(3, 3);
            userNameTextBox5.Name = "userNameTextBox5";
            userNameTextBox5.Size = new Size(358, 28);
            userNameTextBox5.TabIndex = 2;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Dock = DockStyle.Fill;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(3, 39);
            Label7.Name = "Label7";
            Label7.Size = new Size(221, 39);
            Label7.TabIndex = 1;
            Label7.Text = "FTP / SFTP User Name:";
            Label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel12
            // 
            TableLayoutPanel12.ColumnCount = 1;
            TableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel12.Controls.Add(passwordTextBox7, 0, 0);
            TableLayoutPanel12.Dock = DockStyle.Fill;
            TableLayoutPanel12.Location = new Point(229, 80);
            TableLayoutPanel12.Margin = new Padding(2);
            TableLayoutPanel12.Name = "TableLayoutPanel12";
            TableLayoutPanel12.RowCount = 1;
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel12.Size = new Size(459, 35);
            TableLayoutPanel12.TabIndex = 13;
            // 
            // passwordTextBox7
            // 
            passwordTextBox7.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            passwordTextBox7.Location = new Point(3, 3);
            passwordTextBox7.Name = "passwordTextBox7";
            passwordTextBox7.Size = new Size(358, 28);
            passwordTextBox7.TabIndex = 3;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Dock = DockStyle.Fill;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(3, 78);
            Label8.Name = "Label8";
            Label8.Size = new Size(221, 39);
            Label8.TabIndex = 8;
            Label8.Text = "FTP / SFTP Password:";
            Label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Dock = DockStyle.Fill;
            Label9.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(3, 117);
            Label9.Name = "Label9";
            Label9.Size = new Size(221, 39);
            Label9.TabIndex = 3;
            Label9.Text = "FTP / SFTP IP Address:";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel13
            // 
            TableLayoutPanel13.ColumnCount = 1;
            TableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel13.Controls.Add(ipAddressTextBox8, 0, 0);
            TableLayoutPanel13.Dock = DockStyle.Fill;
            TableLayoutPanel13.Location = new Point(229, 119);
            TableLayoutPanel13.Margin = new Padding(2);
            TableLayoutPanel13.Name = "TableLayoutPanel13";
            TableLayoutPanel13.RowCount = 1;
            TableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel13.Size = new Size(459, 35);
            TableLayoutPanel13.TabIndex = 12;
            // 
            // ipAddressTextBox8
            // 
            ipAddressTextBox8.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ipAddressTextBox8.Location = new Point(3, 3);
            ipAddressTextBox8.Name = "ipAddressTextBox8";
            ipAddressTextBox8.Size = new Size(358, 28);
            ipAddressTextBox8.TabIndex = 4;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Dock = DockStyle.Fill;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(3, 156);
            Label10.Name = "Label10";
            Label10.Size = new Size(221, 39);
            Label10.TabIndex = 14;
            Label10.Text = "FTP / SFTP Port Number:";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Dock = DockStyle.Fill;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(3, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(221, 39);
            Label6.TabIndex = 0;
            Label6.Text = "FTP / SFTP Server Name:";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 1;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel2.Controls.Add(serverNameTextBox6, 0, 0);
            TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel2.Location = new Point(229, 2);
            TableLayoutPanel2.Margin = new Padding(2);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Size = new Size(459, 35);
            TableLayoutPanel2.TabIndex = 55;
            // 
            // serverNameTextBox6
            // 
            serverNameTextBox6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            serverNameTextBox6.Location = new Point(3, 3);
            serverNameTextBox6.Name = "serverNameTextBox6";
            serverNameTextBox6.Size = new Size(358, 28);
            serverNameTextBox6.TabIndex = 2;
            // 
            // TableLayoutPanel14
            // 
            TableLayoutPanel14.ColumnCount = 1;
            TableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel14.Controls.Add(prefixTextBox9, 0, 0);
            TableLayoutPanel14.Dock = DockStyle.Fill;
            TableLayoutPanel14.Location = new Point(877, 2);
            TableLayoutPanel14.Margin = new Padding(2);
            TableLayoutPanel14.Name = "TableLayoutPanel14";
            TableLayoutPanel14.RowCount = 1;
            TableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 35.0f));
            TableLayoutPanel14.Size = new Size(212, 35);
            TableLayoutPanel14.TabIndex = 49;
            // 
            // prefixTextBox9
            // 
            prefixTextBox9.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            prefixTextBox9.Location = new Point(3, 3);
            prefixTextBox9.Name = "prefixTextBox9";
            prefixTextBox9.Size = new Size(162, 28);
            prefixTextBox9.TabIndex = 4;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Dock = DockStyle.Fill;
            Label15.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(693, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(179, 39);
            Label15.TabIndex = 50;
            Label15.Text = "Booking Prefix:";
            Label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Dock = DockStyle.Fill;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(3, 190);
            Label3.Name = "Label3";
            Label3.Size = new Size(224, 38);
            Label3.TabIndex = 14;
            Label3.Text = "EDI Security Code:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Location = new Point(26, 71);
            Label17.Name = "Label17";
            Label17.Size = new Size(1220, 24);
            Label17.TabIndex = 64;
            Label17.Text = "_________________________________________________________________________________" + "_____________________________";
            // 
            // versionTextBox
            // 
            versionTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            versionTextBox.Location = new Point(3, 3);
            versionTextBox.Name = "versionTextBox";
            versionTextBox.Size = new Size(358, 28);
            versionTextBox.TabIndex = 4;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label14.Location = new Point(25, 39);
            Label14.Name = "Label14";
            Label14.Size = new Size(165, 30);
            Label14.TabIndex = 61;
            Label14.Text = "EDI Information";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.64596f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.35404f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 401.0f));
            TableLayoutPanel1.Controls.Add(requireEDIInOutGatesCheckBox1, 3, 0);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel10, 1, 1);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel8, 1, 0);
            TableLayoutPanel1.Controls.Add(Label1, 0, 0);
            TableLayoutPanel1.Controls.Add(Label2, 0, 1);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel9, 1, 2);
            TableLayoutPanel1.Controls.Add(Label12, 0, 2);
            TableLayoutPanel1.Controls.Add(preSendsCheckBox2, 3, 1);
            TableLayoutPanel1.Controls.Add(_emailEDICheckBox, 3, 2);
            TableLayoutPanel1.Controls.Add(ediEmailTableLayoutPanel, 3, 3);
            TableLayoutPanel1.Controls.Add(Label11, 0, 6);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel11, 1, 6);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel6, 1, 5);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel7, 1, 4);
            TableLayoutPanel1.Controls.Add(Label3, 0, 5);
            TableLayoutPanel1.Controls.Add(Label4, 0, 4);
            TableLayoutPanel1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel1.Location = new Point(32, 102);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 7;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel1.Size = new Size(1091, 271);
            TableLayoutPanel1.TabIndex = 59;
            // 
            // requireEDIInOutGatesCheckBox1
            // 
            requireEDIInOutGatesCheckBox1.AutoSize = true;
            requireEDIInOutGatesCheckBox1.Dock = DockStyle.Fill;
            requireEDIInOutGatesCheckBox1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            requireEDIInOutGatesCheckBox1.Location = new Point(692, 3);
            requireEDIInOutGatesCheckBox1.Name = "requireEDIInOutGatesCheckBox1";
            requireEDIInOutGatesCheckBox1.Size = new Size(396, 32);
            requireEDIInOutGatesCheckBox1.TabIndex = 48;
            requireEDIInOutGatesCheckBox1.Text = "EDI is required for In Gates and Out Gates";
            requireEDIInOutGatesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel10
            // 
            TableLayoutPanel10.ColumnCount = 1;
            TableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel10.Controls.Add(senderTextBox, 0, 0);
            TableLayoutPanel10.Dock = DockStyle.Fill;
            TableLayoutPanel10.Location = new Point(232, 40);
            TableLayoutPanel10.Margin = new Padding(2);
            TableLayoutPanel10.Name = "TableLayoutPanel10";
            TableLayoutPanel10.RowCount = 1;
            TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel10.Size = new Size(395, 34);
            TableLayoutPanel10.TabIndex = 12;
            // 
            // senderTextBox
            // 
            senderTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            senderTextBox.Location = new Point(3, 3);
            senderTextBox.Name = "senderTextBox";
            senderTextBox.Size = new Size(358, 28);
            senderTextBox.TabIndex = 2;
            // 
            // TableLayoutPanel8
            // 
            TableLayoutPanel8.ColumnCount = 1;
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel8.Controls.Add(clientTextBox, 0, 0);
            TableLayoutPanel8.Dock = DockStyle.Fill;
            TableLayoutPanel8.Location = new Point(232, 2);
            TableLayoutPanel8.Margin = new Padding(2);
            TableLayoutPanel8.Name = "TableLayoutPanel8";
            TableLayoutPanel8.RowCount = 1;
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel8.Size = new Size(395, 34);
            TableLayoutPanel8.TabIndex = 12;
            // 
            // clientTextBox
            // 
            clientTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            clientTextBox.Location = new Point(3, 3);
            clientTextBox.Name = "clientTextBox";
            clientTextBox.Size = new Size(358, 28);
            clientTextBox.TabIndex = 6;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Dock = DockStyle.Fill;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(3, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(224, 38);
            Label1.TabIndex = 0;
            Label1.Text = "EDI Client ID:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Dock = DockStyle.Fill;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(3, 38);
            Label2.Name = "Label2";
            Label2.Size = new Size(224, 38);
            Label2.TabIndex = 1;
            Label2.Text = "EDI Sender ID:";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel9
            // 
            TableLayoutPanel9.ColumnCount = 1;
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel9.Controls.Add(codeTextBox, 0, 0);
            TableLayoutPanel9.Dock = DockStyle.Fill;
            TableLayoutPanel9.Location = new Point(232, 78);
            TableLayoutPanel9.Margin = new Padding(2);
            TableLayoutPanel9.Name = "TableLayoutPanel9";
            TableLayoutPanel9.RowCount = 1;
            TableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel9.Size = new Size(395, 34);
            TableLayoutPanel9.TabIndex = 13;
            // 
            // codeTextBox
            // 
            codeTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            codeTextBox.Location = new Point(3, 3);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(358, 28);
            codeTextBox.TabIndex = 3;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Dock = DockStyle.Fill;
            Label12.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(3, 76);
            Label12.Name = "Label12";
            Label12.Size = new Size(224, 38);
            Label12.TabIndex = 8;
            Label12.Text = "EDI Client SCAC  Code:";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // preSendsCheckBox2
            // 
            preSendsCheckBox2.AutoSize = true;
            preSendsCheckBox2.Dock = DockStyle.Fill;
            preSendsCheckBox2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            preSendsCheckBox2.Location = new Point(692, 41);
            preSendsCheckBox2.Name = "preSendsCheckBox2";
            preSendsCheckBox2.Size = new Size(396, 32);
            preSendsCheckBox2.TabIndex = 51;
            preSendsCheckBox2.Text = "Allow EDI Pre-Sends";
            preSendsCheckBox2.UseVisualStyleBackColor = true;
            // 
            // emailEDICheckBox
            // 
            _emailEDICheckBox.AutoSize = true;
            _emailEDICheckBox.Dock = DockStyle.Fill;
            _emailEDICheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _emailEDICheckBox.Location = new Point(692, 79);
            _emailEDICheckBox.Name = "_emailEDICheckBox";
            _emailEDICheckBox.Size = new Size(396, 32);
            _emailEDICheckBox.TabIndex = 54;
            _emailEDICheckBox.Text = "Use Email to send EDI";
            _emailEDICheckBox.UseVisualStyleBackColor = true;
            // 
            // ediEmailTableLayoutPanel
            // 
            ediEmailTableLayoutPanel.ColumnCount = 2;
            ediEmailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            ediEmailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 327.0f));
            ediEmailTableLayoutPanel.Controls.Add(Label13, 0, 0);
            ediEmailTableLayoutPanel.Controls.Add(emailTextBox3, 1, 0);
            ediEmailTableLayoutPanel.Dock = DockStyle.Fill;
            ediEmailTableLayoutPanel.Location = new Point(692, 117);
            ediEmailTableLayoutPanel.Name = "ediEmailTableLayoutPanel";
            ediEmailTableLayoutPanel.RowCount = 1;
            ediEmailTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            ediEmailTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32.0f));
            ediEmailTableLayoutPanel.Size = new Size(396, 32);
            ediEmailTableLayoutPanel.TabIndex = 52;
            ediEmailTableLayoutPanel.Visible = false;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Dock = DockStyle.Fill;
            Label13.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(3, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(63, 32);
            Label13.TabIndex = 54;
            Label13.Text = "Email:";
            Label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox3
            // 
            emailTextBox3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emailTextBox3.Location = new Point(72, 3);
            emailTextBox3.Name = "emailTextBox3";
            emailTextBox3.Size = new Size(304, 28);
            emailTextBox3.TabIndex = 4;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Dock = DockStyle.Fill;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(3, 228);
            Label11.Name = "Label11";
            Label11.Size = new Size(224, 43);
            Label11.TabIndex = 50;
            Label11.Text = "EDI Line Delimiter:";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel11
            // 
            TableLayoutPanel11.ColumnCount = 1;
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel11.Controls.Add(lineDelimeterTextBox2, 0, 0);
            TableLayoutPanel11.Dock = DockStyle.Fill;
            TableLayoutPanel11.Location = new Point(232, 230);
            TableLayoutPanel11.Margin = new Padding(2);
            TableLayoutPanel11.Name = "TableLayoutPanel11";
            TableLayoutPanel11.RowCount = 1;
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 39.0f));
            TableLayoutPanel11.Size = new Size(395, 39);
            TableLayoutPanel11.TabIndex = 49;
            // 
            // lineDelimeterTextBox2
            // 
            lineDelimeterTextBox2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lineDelimeterTextBox2.Location = new Point(3, 3);
            lineDelimeterTextBox2.Name = "lineDelimeterTextBox2";
            lineDelimeterTextBox2.Size = new Size(358, 28);
            lineDelimeterTextBox2.TabIndex = 4;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 1;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel6.Controls.Add(securityCodeTextBox1, 0, 0);
            TableLayoutPanel6.Dock = DockStyle.Fill;
            TableLayoutPanel6.Location = new Point(232, 192);
            TableLayoutPanel6.Margin = new Padding(2);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 1;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.Size = new Size(395, 34);
            TableLayoutPanel6.TabIndex = 48;
            // 
            // securityCodeTextBox1
            // 
            securityCodeTextBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            securityCodeTextBox1.Location = new Point(3, 3);
            securityCodeTextBox1.Name = "securityCodeTextBox1";
            securityCodeTextBox1.Size = new Size(358, 28);
            securityCodeTextBox1.TabIndex = 4;
            // 
            // TableLayoutPanel7
            // 
            TableLayoutPanel7.ColumnCount = 1;
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel7.Controls.Add(versionTextBox, 0, 0);
            TableLayoutPanel7.Dock = DockStyle.Fill;
            TableLayoutPanel7.Location = new Point(232, 154);
            TableLayoutPanel7.Margin = new Padding(2);
            TableLayoutPanel7.Name = "TableLayoutPanel7";
            TableLayoutPanel7.RowCount = 1;
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel7.Size = new Size(395, 34);
            TableLayoutPanel7.TabIndex = 12;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(26, 362);
            Label5.Name = "Label5";
            Label5.Size = new Size(1220, 25);
            Label5.TabIndex = 60;
            Label5.Text = "_________________________________________________________________________________" + "______________________________________________________________________";
            // 
            // saveButton
            // 
            _saveButton.AllowToggling = false;
            _saveButton.AnimationSpeed = 200;
            _saveButton.AutoGenerateColors = false;
            _saveButton.BackColor = Color.Transparent;
            _saveButton.BackColor1 = Color.Teal;
            _saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            _saveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _saveButton.ButtonText = "Save";
            _saveButton.ButtonTextMarginLeft = 0;
            _saveButton.ColorContrastOnClick = 45;
            _saveButton.ColorContrastOnHover = 45;
            _saveButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges1;
            _saveButton.DialogResult = DialogResult.None;
            _saveButton.DisabledBorderColor = Color.Empty;
            _saveButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _saveButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _saveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _saveButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveButton.ForeColor = Color.White;
            _saveButton.IconLeftCursor = Cursors.Hand;
            _saveButton.IconMarginLeft = 11;
            _saveButton.IconPadding = 10;
            _saveButton.IconRightCursor = Cursors.Hand;
            _saveButton.IdleBorderColor = Color.Teal;
            _saveButton.IdleBorderRadius = 3;
            _saveButton.IdleBorderThickness = 1;
            _saveButton.IdleFillColor = Color.Teal;
            _saveButton.IdleIconLeftImage = null;
            _saveButton.IdleIconRightImage = null;
            _saveButton.IndicateFocus = true;
            _saveButton.Location = new Point(964, 696);
            _saveButton.Name = "_saveButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _saveButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties2;
            _saveButton.Size = new Size(122, 45);
            _saveButton.TabIndex = 68;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _cancelButton.AnimationSpeed = 200;
            _cancelButton.AutoGenerateColors = false;
            _cancelButton.BackColor = Color.Transparent;
            _cancelButton.BackColor1 = Color.White;
            _cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            _cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cancelButton.ButtonText = "Cancel";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges2;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.Gray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(1115, 696);
            _cancelButton.Name = "_cancelButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties4;
            _cancelButton.Size = new Size(107, 45);
            _cancelButton.TabIndex = 69;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmEDI
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 766);
            Controls.Add(Label14);
            Controls.Add(_cancelButton);
            Controls.Add(_saveButton);
            Controls.Add(_userServerCheckBox);
            Controls.Add(serverTableLayoutPanel);
            Controls.Add(Label17);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(Label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEDI";
            StartPosition = FormStartPosition.CenterScreen;
            serverTableLayoutPanel.ResumeLayout(false);
            serverTableLayoutPanel.PerformLayout();
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel5.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)portNumberNumericUpDown1).EndInit();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            TableLayoutPanel12.ResumeLayout(false);
            TableLayoutPanel12.PerformLayout();
            TableLayoutPanel13.ResumeLayout(false);
            TableLayoutPanel13.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            TableLayoutPanel14.ResumeLayout(false);
            TableLayoutPanel14.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            TableLayoutPanel10.ResumeLayout(false);
            TableLayoutPanel10.PerformLayout();
            TableLayoutPanel8.ResumeLayout(false);
            TableLayoutPanel8.PerformLayout();
            TableLayoutPanel9.ResumeLayout(false);
            TableLayoutPanel9.PerformLayout();
            ediEmailTableLayoutPanel.ResumeLayout(false);
            ediEmailTableLayoutPanel.PerformLayout();
            TableLayoutPanel11.ResumeLayout(false);
            TableLayoutPanel11.PerformLayout();
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel6.PerformLayout();
            TableLayoutPanel7.ResumeLayout(false);
            TableLayoutPanel7.PerformLayout();
            Load += new EventHandler(FrmEDI_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox _userServerCheckBox;

        internal CheckBox userServerCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _userServerCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_userServerCheckBox != null)
                {
                    _userServerCheckBox.CheckedChanged -= CheckBox3_CheckedChanged_1;
                }

                _userServerCheckBox = value;
                if (_userServerCheckBox != null)
                {
                    _userServerCheckBox.CheckedChanged += CheckBox3_CheckedChanged_1;
                }
            }
        }

        internal Label Label4;
        internal TableLayoutPanel serverTableLayoutPanel;
        internal Label Label16;
        internal TableLayoutPanel TableLayoutPanel5;
        internal TextBox folderNameTextBox10;
        internal TableLayoutPanel TableLayoutPanel3;
        internal NumericUpDown portNumberNumericUpDown1;
        internal TableLayoutPanel TableLayoutPanel4;
        internal TextBox userNameTextBox5;
        internal Label Label7;
        internal TableLayoutPanel TableLayoutPanel12;
        internal TextBox passwordTextBox7;
        internal Label Label8;
        internal Label Label9;
        internal TableLayoutPanel TableLayoutPanel13;
        internal TextBox ipAddressTextBox8;
        internal Label Label10;
        internal Label Label6;
        internal TableLayoutPanel TableLayoutPanel2;
        internal TextBox serverNameTextBox6;
        internal TableLayoutPanel TableLayoutPanel14;
        internal TextBox prefixTextBox9;
        internal Label Label15;
        internal Label Label3;
        internal Label Label17;
        internal TextBox versionTextBox;
        internal Label Label14;
        internal TableLayoutPanel TableLayoutPanel1;
        internal CheckBox requireEDIInOutGatesCheckBox1;
        internal TableLayoutPanel TableLayoutPanel10;
        internal TextBox senderTextBox;
        internal TableLayoutPanel TableLayoutPanel8;
        internal TextBox clientTextBox;
        internal Label Label1;
        internal Label Label2;
        internal TableLayoutPanel TableLayoutPanel9;
        internal TextBox codeTextBox;
        internal Label Label12;
        internal CheckBox preSendsCheckBox2;
        private CheckBox _emailEDICheckBox;

        internal CheckBox emailEDICheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _emailEDICheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_emailEDICheckBox != null)
                {
                    _emailEDICheckBox.CheckedChanged -= CheckBox3_CheckedChanged;
                }

                _emailEDICheckBox = value;
                if (_emailEDICheckBox != null)
                {
                    _emailEDICheckBox.CheckedChanged += CheckBox3_CheckedChanged;
                }
            }
        }

        internal TableLayoutPanel ediEmailTableLayoutPanel;
        internal Label Label13;
        internal TextBox emailTextBox3;
        internal Label Label11;
        internal TableLayoutPanel TableLayoutPanel11;
        internal TextBox lineDelimeterTextBox2;
        internal TableLayoutPanel TableLayoutPanel6;
        internal TextBox securityCodeTextBox1;
        internal TableLayoutPanel TableLayoutPanel7;
        internal Label Label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _saveButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveButton != null)
                {
                    _saveButton.Click -= Button3_Click;
                }

                _saveButton = value;
                if (_saveButton != null)
                {
                    _saveButton.Click += Button3_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _cancelButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cancelButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cancelButton != null)
                {
                    _cancelButton.Click -= Button4_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += Button4_Click;
                }
            }
        }
    }
}