using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmInvenotryDetail : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvenotryDetail));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            lblRemaining = new Label();
            Label1 = new Label();
            lblQuantity = new Label();
            lblCustomer = new Label();
            Label15 = new Label();
            Label8 = new Label();
            Label13 = new Label();
            lblStorageDate = new Label();
            TableLayoutPanel6 = new TableLayoutPanel();
            Label11 = new Label();
            Panel1 = new Panel();
            dgvBagLocations = new Bunifu.UI.WinForms.BunifuDataGridView();
            VWInvenotryBagLocationBindingSource = new BindingSource(components);
            TableLayoutPanel4 = new TableLayoutPanel();
            lblBagDescription = new Label();
            lblLogoYear = new Label();
            lblLogoDescription = new Label();
            Label3 = new Label();
            Label10 = new Label();
            Label5 = new Label();
            Label9 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            lblColorType = new Label();
            lblBagColor = new Label();
            lblBagWeight = new Label();
            lblBagSize = new Label();
            Label12 = new Label();
            Label19 = new Label();
            pbBagImage = new PictureBox();
            Label22 = new Label();
            _btnEdit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnEdit.Click += new EventHandler(btnEdit_Click);
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(closeFlatButton_Click);
            Label2 = new Label();
            BunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            BunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            BunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            Label4 = new Label();
            StorageTypeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            YardLocationName = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            BagQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel6.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBagLocations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWInvenotryBagLocationBindingSource).BeginInit();
            TableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBagImage).BeginInit();
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
            _closeFlatButton.Location = new Point(1084, 0);
            _closeFlatButton.Margin = new Padding(7);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 39);
            _closeFlatButton.TabIndex = 193;
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
            Label17.Margin = new Padding(5, 0, 5, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(1127, 39);
            Label17.TabIndex = 192;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8642f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.1358f));
            TableLayoutPanel3.Controls.Add(lblRemaining, 1, 2);
            TableLayoutPanel3.Controls.Add(Label1, 0, 2);
            TableLayoutPanel3.Controls.Add(lblQuantity, 1, 1);
            TableLayoutPanel3.Controls.Add(lblCustomer, 1, 0);
            TableLayoutPanel3.Controls.Add(Label15, 0, 1);
            TableLayoutPanel3.Controls.Add(Label8, 0, 0);
            TableLayoutPanel3.Controls.Add(Label13, 0, 3);
            TableLayoutPanel3.Controls.Add(lblStorageDate, 1, 3);
            TableLayoutPanel3.Location = new Point(58, 105);
            TableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 4;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel3.Size = new Size(486, 137);
            TableLayoutPanel3.TabIndex = 194;
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Left;
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblRemaining.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblRemaining.Location = new Point(153, 81);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(44, 17);
            lblRemaining.TabIndex = 211;
            lblRemaining.Text = "Size:";
            lblRemaining.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(72, 81);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 17);
            Label1.TabIndex = 210;
            Label1.Text = "Remaining";
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblQuantity.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblQuantity.Location = new Point(153, 45);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(44, 17);
            lblQuantity.TabIndex = 210;
            lblQuantity.Text = "Size:";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.Left;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCustomer.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblCustomer.Location = new Point(153, 9);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(44, 17);
            lblCustomer.TabIndex = 211;
            lblCustomer.Text = "Size:";
            lblCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.Right;
            Label15.AutoSize = true;
            Label15.Location = new Point(82, 45);
            Label15.Name = "Label15";
            Label15.Size = new Size(65, 17);
            Label15.TabIndex = 6;
            Label15.Text = "Quantity:";
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Location = new Point(75, 9);
            Label8.Name = "Label8";
            Label8.Size = new Size(72, 17);
            Label8.TabIndex = 11;
            Label8.Text = "Customer:";
            // 
            // Label13
            // 
            Label13.Anchor = AnchorStyles.Right;
            Label13.AutoSize = true;
            Label13.Location = new Point(51, 114);
            Label13.Name = "Label13";
            Label13.Size = new Size(96, 17);
            Label13.TabIndex = 9;
            Label13.Text = "Storage Date:";
            // 
            // lblStorageDate
            // 
            lblStorageDate.Anchor = AnchorStyles.Left;
            lblStorageDate.AutoSize = true;
            lblStorageDate.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblStorageDate.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblStorageDate.Location = new Point(153, 114);
            lblStorageDate.Name = "lblStorageDate";
            lblStorageDate.Size = new Size(44, 17);
            lblStorageDate.TabIndex = 209;
            lblStorageDate.Text = "Size:";
            lblStorageDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 1;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.68724f));
            TableLayoutPanel6.Controls.Add(Label11, 0, 0);
            TableLayoutPanel6.Controls.Add(Panel1, 0, 1);
            TableLayoutPanel6.Location = new Point(54, 614);
            TableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 2;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 93.0f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 22.0f));
            TableLayoutPanel6.Size = new Size(501, 115);
            TableLayoutPanel6.TabIndex = 195;
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Left;
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(3, 2);
            Label11.Name = "Label11";
            Label11.Size = new Size(98, 17);
            Label11.TabIndex = 211;
            Label11.Text = "Bag location";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(dgvBagLocations);
            Panel1.Location = new Point(3, 25);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(495, 87);
            Panel1.TabIndex = 205;
            // 
            // dgvBagLocations
            // 
            dgvBagLocations.AllowCustomTheming = true;
            dgvBagLocations.AllowUserToAddRows = false;
            dgvBagLocations.AllowUserToDeleteRows = false;
            dgvBagLocations.AllowUserToResizeColumns = false;
            dgvBagLocations.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dgvBagLocations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvBagLocations.AutoGenerateColumns = false;
            dgvBagLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBagLocations.BackgroundColor = Color.White;
            dgvBagLocations.BorderStyle = BorderStyle.None;
            dgvBagLocations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBagLocations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Silver;
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = Color.Black;
            DataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBagLocations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvBagLocations.ColumnHeadersHeight = 20;
            dgvBagLocations.Columns.AddRange(new DataGridViewColumn[] { StorageTypeNameDataGridViewTextBoxColumn, YardLocationName, LocationName, BagQuantityDataGridViewTextBoxColumn });
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.CurrentTheme.BackColor = Color.White;
            dgvBagLocations.CurrentTheme.GridColor = Color.DarkGray;
            dgvBagLocations.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            dgvBagLocations.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dgvBagLocations.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            dgvBagLocations.CurrentTheme.Name = null;
            dgvBagLocations.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvBagLocations.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvBagLocations.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            dgvBagLocations.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.DataSource = VWInvenotryBagLocationBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBagLocations.DefaultCellStyle = DataGridViewCellStyle3;
            dgvBagLocations.Dock = DockStyle.Fill;
            dgvBagLocations.EnableHeadersVisualStyles = false;
            dgvBagLocations.GridColor = Color.DarkGray;
            dgvBagLocations.HeaderBackColor = Color.Silver;
            dgvBagLocations.HeaderBgColor = Color.Empty;
            dgvBagLocations.HeaderForeColor = Color.Black;
            dgvBagLocations.Location = new Point(0, 0);
            dgvBagLocations.MultiSelect = false;
            dgvBagLocations.Name = "dgvBagLocations";
            dgvBagLocations.ReadOnly = true;
            dgvBagLocations.RowHeadersVisible = false;
            dgvBagLocations.RowHeadersWidth = 25;
            dgvBagLocations.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            dgvBagLocations.RowTemplate.Height = 25;
            dgvBagLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBagLocations.Size = new Size(493, 85);
            dgvBagLocations.TabIndex = 203;
            dgvBagLocations.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // VWInvenotryBagLocationBindingSource
            // 
            VWInvenotryBagLocationBindingSource.DataSource = typeof(ModelLayer.VW_InventoryBagLocation);
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.893f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.10699f));
            TableLayoutPanel4.Controls.Add(lblBagDescription, 1, 0);
            TableLayoutPanel4.Controls.Add(lblLogoYear, 1, 6);
            TableLayoutPanel4.Controls.Add(lblLogoDescription, 1, 5);
            TableLayoutPanel4.Controls.Add(Label3, 0, 0);
            TableLayoutPanel4.Controls.Add(Label10, 0, 5);
            TableLayoutPanel4.Controls.Add(Label5, 0, 4);
            TableLayoutPanel4.Controls.Add(Label9, 0, 3);
            TableLayoutPanel4.Controls.Add(Label7, 0, 2);
            TableLayoutPanel4.Controls.Add(Label6, 0, 1);
            TableLayoutPanel4.Controls.Add(lblColorType, 1, 4);
            TableLayoutPanel4.Controls.Add(lblBagColor, 1, 3);
            TableLayoutPanel4.Controls.Add(lblBagWeight, 1, 2);
            TableLayoutPanel4.Controls.Add(lblBagSize, 1, 1);
            TableLayoutPanel4.Controls.Add(Label12, 0, 6);
            TableLayoutPanel4.Location = new Point(58, 303);
            TableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 7;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30.0f));
            TableLayoutPanel4.Size = new Size(486, 250);
            TableLayoutPanel4.TabIndex = 205;
            // 
            // lblBagDescription
            // 
            lblBagDescription.Anchor = AnchorStyles.Left;
            lblBagDescription.AutoSize = true;
            lblBagDescription.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagDescription.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagDescription.Location = new Point(158, 9);
            lblBagDescription.Name = "lblBagDescription";
            lblBagDescription.Size = new Size(123, 17);
            lblBagDescription.TabIndex = 213;
            lblBagDescription.Text = "BagDescription:";
            lblBagDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLogoYear
            // 
            lblLogoYear.Anchor = AnchorStyles.Left;
            lblLogoYear.AutoSize = true;
            lblLogoYear.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLogoYear.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblLogoYear.Location = new Point(158, 224);
            lblLogoYear.Name = "lblLogoYear";
            lblLogoYear.Size = new Size(49, 17);
            lblLogoYear.TabIndex = 210;
            lblLogoYear.Text = "Logo:";
            lblLogoYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLogoDescription
            // 
            lblLogoDescription.Anchor = AnchorStyles.Left;
            lblLogoDescription.AutoSize = true;
            lblLogoDescription.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLogoDescription.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblLogoDescription.Location = new Point(158, 189);
            lblLogoDescription.Name = "lblLogoDescription";
            lblLogoDescription.Size = new Size(49, 17);
            lblLogoDescription.TabIndex = 206;
            lblLogoDescription.Text = "Logo:";
            lblLogoDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.Location = new Point(40, 9);
            Label3.Name = "Label3";
            Label3.Size = new Size(112, 17);
            Label3.TabIndex = 211;
            Label3.Text = "Bag Description:";
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Location = new Point(10, 181);
            Label10.Name = "Label10";
            Label10.Size = new Size(142, 34);
            Label10.TabIndex = 9;
            Label10.Text = "Logo/Special Printing Description:";
            Label10.TextAlign = ContentAlignment.TopRight;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Location = new Point(75, 153);
            Label5.Name = "Label5";
            Label5.Size = new Size(77, 17);
            Label5.TabIndex = 6;
            Label5.Text = "Color Type";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Location = new Point(107, 117);
            Label9.Name = "Label9";
            Label9.Size = new Size(45, 17);
            Label9.TabIndex = 8;
            Label9.Text = "Color:";
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Right;
            Label7.AutoSize = true;
            Label7.Location = new Point(100, 81);
            Label7.Name = "Label7";
            Label7.Size = new Size(52, 17);
            Label7.TabIndex = 7;
            Label7.Text = "Weight";
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.Location = new Point(113, 45);
            Label6.Name = "Label6";
            Label6.Size = new Size(39, 17);
            Label6.TabIndex = 5;
            Label6.Text = "Size:";
            // 
            // lblColorType
            // 
            lblColorType.Anchor = AnchorStyles.Left;
            lblColorType.AutoSize = true;
            lblColorType.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblColorType.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblColorType.Location = new Point(158, 153);
            lblColorType.Name = "lblColorType";
            lblColorType.Size = new Size(87, 17);
            lblColorType.TabIndex = 203;
            lblColorType.Text = "Color Type";
            lblColorType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBagColor
            // 
            lblBagColor.Anchor = AnchorStyles.Left;
            lblBagColor.AutoSize = true;
            lblBagColor.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagColor.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagColor.Location = new Point(158, 117);
            lblBagColor.Name = "lblBagColor";
            lblBagColor.Size = new Size(51, 17);
            lblBagColor.TabIndex = 205;
            lblBagColor.Text = "Color:";
            lblBagColor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBagWeight
            // 
            lblBagWeight.Anchor = AnchorStyles.Left;
            lblBagWeight.AutoSize = true;
            lblBagWeight.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagWeight.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagWeight.Location = new Point(158, 81);
            lblBagWeight.Name = "lblBagWeight";
            lblBagWeight.Size = new Size(58, 17);
            lblBagWeight.TabIndex = 204;
            lblBagWeight.Text = "Weight";
            lblBagWeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBagSize
            // 
            lblBagSize.Anchor = AnchorStyles.Left;
            lblBagSize.AutoSize = true;
            lblBagSize.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagSize.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagSize.Location = new Point(158, 45);
            lblBagSize.Name = "lblBagSize";
            lblBagSize.Size = new Size(44, 17);
            lblBagSize.TabIndex = 10;
            lblBagSize.Text = "Size:";
            lblBagSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            Label12.Anchor = AnchorStyles.Right;
            Label12.AutoSize = true;
            Label12.Location = new Point(49, 224);
            Label12.Name = "Label12";
            Label12.Size = new Size(103, 17);
            Label12.TabIndex = 207;
            Label12.Text = "Bag/Logo Year";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Font = new Font("Segoe UI", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label19.Location = new Point(30, 258);
            Label19.Name = "Label19";
            Label19.Size = new Size(141, 25);
            Label19.TabIndex = 207;
            Label19.Text = "Bag Information";
            // 
            // pbBagImage
            // 
            pbBagImage.BorderStyle = BorderStyle.FixedSingle;
            pbBagImage.Location = new Point(660, 188);
            pbBagImage.Margin = new Padding(0);
            pbBagImage.Name = "pbBagImage";
            pbBagImage.Size = new Size(379, 491);
            pbBagImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbBagImage.TabIndex = 209;
            pbBagImage.TabStop = false;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Font = new Font("Segoe UI", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label22.Location = new Point(30, 65);
            Label22.Name = "Label22";
            Label22.Size = new Size(186, 25);
            Label22.TabIndex = 208;
            Label22.Text = "Inventory Information";
            // 
            // btnEdit
            // 
            _btnEdit.AllowToggling = false;
            _btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnEdit.AnimationSpeed = 200;
            _btnEdit.AutoGenerateColors = false;
            _btnEdit.BackColor = Color.Transparent;
            _btnEdit.BackColor1 = Color.Teal;
            _btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            _btnEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnEdit.ButtonText = "Edit ";
            _btnEdit.ButtonTextMarginLeft = 0;
            _btnEdit.ColorContrastOnClick = 45;
            _btnEdit.ColorContrastOnHover = 45;
            _btnEdit.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnEdit.CustomizableEdges = BorderEdges1;
            _btnEdit.DialogResult = DialogResult.None;
            _btnEdit.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnEdit.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnEdit.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnEdit.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnEdit.ForeColor = Color.White;
            _btnEdit.IconLeftCursor = Cursors.Hand;
            _btnEdit.IconMarginLeft = 11;
            _btnEdit.IconPadding = 10;
            _btnEdit.IconRightCursor = Cursors.Hand;
            _btnEdit.IdleBorderColor = Color.Teal;
            _btnEdit.IdleBorderRadius = 3;
            _btnEdit.IdleBorderThickness = 1;
            _btnEdit.IdleFillColor = Color.Teal;
            _btnEdit.IdleIconLeftImage = null;
            _btnEdit.IdleIconRightImage = null;
            _btnEdit.IndicateFocus = false;
            _btnEdit.Location = new Point(473, 745);
            _btnEdit.Margin = new Padding(3, 2, 3, 2);
            _btnEdit.Name = "_btnEdit";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnEdit.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnEdit.OnPressedState = StateProperties2;
            _btnEdit.Size = new Size(82, 33);
            _btnEdit.TabIndex = 210;
            _btnEdit.TextAlign = ContentAlignment.MiddleCenter;
            _btnEdit.TextMarginLeft = 0;
            _btnEdit.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuButton1
            // 
            _BunifuButton1.AllowToggling = false;
            _BunifuButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _BunifuButton1.AnimationSpeed = 200;
            _BunifuButton1.AutoGenerateColors = false;
            _BunifuButton1.BackColor = Color.Transparent;
            _BunifuButton1.BackColor1 = Color.White;
            _BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            _BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton1.ButtonText = "Close";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges2;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Segoe UI Semibold", 9.75f);
            _BunifuButton1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 11;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuButton1.IdleBorderRadius = 3;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.White;
            _BunifuButton1.IdleIconLeftImage = null;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = false;
            _BunifuButton1.Location = new Point(588, 745);
            _BunifuButton1.Margin = new Padding(3, 2, 3, 2);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.White;
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties4;
            _BunifuButton1.Size = new Size(82, 33);
            _BunifuButton1.TabIndex = 211;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Left;
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(811, 161);
            Label2.Name = "Label2";
            Label2.Size = new Size(89, 17);
            Label2.TabIndex = 212;
            Label2.Text = "Bag Image:";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuSeparator1
            // 
            BunifuSeparator1.BackColor = Color.Transparent;
            BunifuSeparator1.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator1.LineThickness = 1;
            BunifuSeparator1.Location = new Point(35, 286);
            BunifuSeparator1.Margin = new Padding(4);
            BunifuSeparator1.Name = "BunifuSeparator1";
            BunifuSeparator1.Size = new Size(517, 11);
            BunifuSeparator1.TabIndex = 213;
            BunifuSeparator1.Transparency = 255;
            BunifuSeparator1.Vertical = false;
            // 
            // BunifuSeparator2
            // 
            BunifuSeparator2.BackColor = Color.Transparent;
            BunifuSeparator2.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator2.LineThickness = 1;
            BunifuSeparator2.Location = new Point(35, 90);
            BunifuSeparator2.Margin = new Padding(5);
            BunifuSeparator2.Name = "BunifuSeparator2";
            BunifuSeparator2.Size = new Size(528, 14);
            BunifuSeparator2.TabIndex = 214;
            BunifuSeparator2.Transparency = 255;
            BunifuSeparator2.Vertical = false;
            // 
            // BunifuSeparator3
            // 
            BunifuSeparator3.BackColor = Color.Transparent;
            BunifuSeparator3.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator3.LineThickness = 1;
            BunifuSeparator3.Location = new Point(58, 596);
            BunifuSeparator3.Margin = new Padding(7, 6, 7, 6);
            BunifuSeparator3.Name = "BunifuSeparator3";
            BunifuSeparator3.Size = new Size(482, 17);
            BunifuSeparator3.TabIndex = 216;
            BunifuSeparator3.Transparency = 255;
            BunifuSeparator3.Vertical = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label4.Location = new Point(53, 565);
            Label4.Name = "Label4";
            Label4.Size = new Size(186, 25);
            Label4.TabIndex = 215;
            Label4.Text = "Inventory Information";
            // 
            // StorageTypeNameDataGridViewTextBoxColumn
            // 
            StorageTypeNameDataGridViewTextBoxColumn.DataPropertyName = "StorageTypeName";
            StorageTypeNameDataGridViewTextBoxColumn.HeaderText = "Storage Type";
            StorageTypeNameDataGridViewTextBoxColumn.Name = "StorageTypeNameDataGridViewTextBoxColumn";
            StorageTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // YardLocationName
            // 
            YardLocationName.DataPropertyName = "YardLocationName";
            YardLocationName.HeaderText = "Yard";
            YardLocationName.Name = "YardLocationName";
            YardLocationName.ReadOnly = true;
            // 
            // LocationName
            // 
            LocationName.DataPropertyName = "LocationStorageName";
            LocationName.FillWeight = 146.7332f;
            LocationName.HeaderText = "Location";
            LocationName.Name = "LocationName";
            LocationName.ReadOnly = true;
            // 
            // BagQuantityDataGridViewTextBoxColumn
            // 
            BagQuantityDataGridViewTextBoxColumn.DataPropertyName = "BagQuantity";
            BagQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            BagQuantityDataGridViewTextBoxColumn.Name = "BagQuantityDataGridViewTextBoxColumn";
            BagQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmInvenotryDetail
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1127, 803);
            Controls.Add(BunifuSeparator3);
            Controls.Add(Label4);
            Controls.Add(BunifuSeparator2);
            Controls.Add(BunifuSeparator1);
            Controls.Add(Label2);
            Controls.Add(_BunifuButton1);
            Controls.Add(_btnEdit);
            Controls.Add(Label22);
            Controls.Add(pbBagImage);
            Controls.Add(Label19);
            Controls.Add(TableLayoutPanel4);
            Controls.Add(TableLayoutPanel6);
            Controls.Add(TableLayoutPanel3);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmInvenotryDetail";
            Text = "FrmInvenotryDetail";
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel6.PerformLayout();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBagLocations).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWInvenotryBagLocationBindingSource).EndInit();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBagImage).EndInit();
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

        internal Label Label17;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label Label13;
        internal Label Label15;
        internal Label Label8;
        internal TableLayoutPanel TableLayoutPanel6;
        internal TableLayoutPanel TableLayoutPanel4;
        internal Label lblLogoDescription;
        internal Label Label10;
        internal Label lblColorType;
        internal Label Label5;
        internal Label lblBagWeight;
        internal Label lblBagColor;
        internal Label Label6;
        internal Label Label7;
        internal Label Label9;
        internal Label lblBagSize;
        internal Label lblStorageDate;
        internal Label lblQuantity;
        internal Label lblCustomer;
        public PictureBox pbBagImage;
        internal Label Label12;
        internal Label Label19;
        internal Label Label22;
        internal Label lblRemaining;
        internal Label Label1;
        internal Label lblLogoYear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnEdit;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEdit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEdit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnEdit != null)
                {
                    _btnEdit.Click -= btnEdit_Click;
                }

                _btnEdit = value;
                if (_btnEdit != null)
                {
                    _btnEdit.Click += btnEdit_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click -= closeFlatButton_Click;
                }

                _BunifuButton1 = value;
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click += closeFlatButton_Click;
                }
            }
        }

        internal Label Label2;
        internal Label lblBagDescription;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator1;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator2;
        internal Label Label11;
        internal Panel Panel1;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvBagLocations;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator3;
        internal Label Label4;
        internal BindingSource VWInvenotryBagLocationBindingSource;
        internal DataGridViewTextBoxColumn StorageTypeNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn YardLocationName;
        internal DataGridViewTextBoxColumn LocationName;
        internal DataGridViewTextBoxColumn BagQuantityDataGridViewTextBoxColumn;
    }
}