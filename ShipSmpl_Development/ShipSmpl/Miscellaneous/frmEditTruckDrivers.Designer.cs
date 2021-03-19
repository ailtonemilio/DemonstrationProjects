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
    public partial class frmEditTruckDrivers : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTruckDrivers));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this._closeLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.CompaniesNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtTruckNumber = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.ckbSuspend = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLastName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPassID = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this._btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this._btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tblTruckDriver = new System.Windows.Forms.TableLayoutPanel();
            this.ddlTruckCompanie = new System.Windows.Forms.ComboBox();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbxReadCard = new System.Windows.Forms.PictureBox();
            this.tblPassCard = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesNameBindingSource)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.tblTruckDriver.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReadCard)).BeginInit();
            this.tblPassCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // _closeLabel
            // 
            this._closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._closeLabel.Font = new System.Drawing.Font("Arial Narrow", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._closeLabel.ForeColor = System.Drawing.Color.White;
            this._closeLabel.Location = new System.Drawing.Point(637, 0);
            this._closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this._closeLabel.Name = "_closeLabel";
            this._closeLabel.Size = new System.Drawing.Size(40, 41);
            this._closeLabel.TabIndex = 144;
            this._closeLabel.Text = "🗙";
            this._closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(677, 41);
            this.Label2.TabIndex = 143;
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label6.Location = new System.Drawing.Point(18, 10);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(85, 20);
            this.Label6.TabIndex = 211;
            this.Label6.Text = "Companie:";
            // 
            // CompaniesNameBindingSource
            // 
            this.CompaniesNameBindingSource.DataSource = typeof(ModelLayer.CustomModel.CompaniesName);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.94273F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.05727F));
            this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.txtTruckNumber, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.ckbSuspend, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.txtLastName, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(12, 152);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 4;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(648, 160);
            this.TableLayoutPanel1.TabIndex = 234;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label5.Location = new System.Drawing.Point(5, 130);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(112, 20);
            this.Label5.TabIndex = 154;
            this.Label5.Text = "Truck Number:";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label7.Location = new System.Drawing.Point(22, 90);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 20);
            this.Label7.TabIndex = 237;
            this.Label7.Text = "Suspend:";
            // 
            // txtTruckNumber
            // 
            this.txtTruckNumber.AcceptsReturn = false;
            this.txtTruckNumber.AcceptsTab = false;
            this.txtTruckNumber.AnimationSpeed = 200;
            this.txtTruckNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTruckNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTruckNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtTruckNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTruckNumber.BackgroundImage")));
            this.txtTruckNumber.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTruckNumber.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTruckNumber.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTruckNumber.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTruckNumber.BorderRadius = 1;
            this.txtTruckNumber.BorderThickness = 1;
            this.txtTruckNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTruckNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTruckNumber.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtTruckNumber.DefaultText = "";
            this.txtTruckNumber.FillColor = System.Drawing.Color.White;
            this.txtTruckNumber.HideSelection = true;
            this.txtTruckNumber.IconLeft = null;
            this.txtTruckNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTruckNumber.IconPadding = 10;
            this.txtTruckNumber.IconRight = null;
            this.txtTruckNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTruckNumber.Lines = new string[0];
            this.txtTruckNumber.Location = new System.Drawing.Point(125, 123);
            this.txtTruckNumber.MaxLength = 32767;
            this.txtTruckNumber.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTruckNumber.Modified = false;
            this.txtTruckNumber.Multiline = false;
            this.txtTruckNumber.Name = "txtTruckNumber";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTruckNumber.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTruckNumber.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTruckNumber.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTruckNumber.OnIdleState = stateProperties4;
            this.txtTruckNumber.PasswordChar = '\0';
            this.txtTruckNumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTruckNumber.PlaceholderText = "ENTER TEXT";
            this.txtTruckNumber.ReadOnly = false;
            this.txtTruckNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTruckNumber.SelectedText = "";
            this.txtTruckNumber.SelectionLength = 0;
            this.txtTruckNumber.SelectionStart = 0;
            this.txtTruckNumber.ShortcutsEnabled = true;
            this.txtTruckNumber.Size = new System.Drawing.Size(240, 35);
            this.txtTruckNumber.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTruckNumber.TabIndex = 5;
            this.txtTruckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTruckNumber.TextMarginBottom = 0;
            this.txtTruckNumber.TextMarginLeft = 5;
            this.txtTruckNumber.TextMarginTop = 0;
            this.txtTruckNumber.TextPlaceholder = "ENTER TEXT";
            this.txtTruckNumber.UseSystemPasswordChar = false;
            this.txtTruckNumber.WordWrap = true;
            // 
            // ckbSuspend
            // 
            this.ckbSuspend.AllowBindingControlAnimation = true;
            this.ckbSuspend.AllowBindingControlColorChanges = false;
            this.ckbSuspend.AllowBindingControlLocation = true;
            this.ckbSuspend.AllowCheckBoxAnimation = false;
            this.ckbSuspend.AllowCheckmarkAnimation = true;
            this.ckbSuspend.AllowOnHoverStates = true;
            this.ckbSuspend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckbSuspend.AutoCheck = true;
            this.ckbSuspend.BackColor = System.Drawing.Color.Transparent;
            this.ckbSuspend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckbSuspend.BackgroundImage")));
            this.ckbSuspend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ckbSuspend.BindingControl = null;
            this.ckbSuspend.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ckbSuspend.Checked = false;
            this.ckbSuspend.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.ckbSuspend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSuspend.CustomCheckmarkImage = null;
            this.ckbSuspend.Location = new System.Drawing.Point(125, 87);
            this.ckbSuspend.MinimumSize = new System.Drawing.Size(17, 17);
            this.ckbSuspend.Name = "ckbSuspend";
            this.ckbSuspend.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ckbSuspend.OnCheck.BorderRadius = 2;
            this.ckbSuspend.OnCheck.BorderThickness = 2;
            this.ckbSuspend.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ckbSuspend.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ckbSuspend.OnCheck.CheckmarkThickness = 2;
            this.ckbSuspend.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ckbSuspend.OnDisable.BorderRadius = 2;
            this.ckbSuspend.OnDisable.BorderThickness = 2;
            this.ckbSuspend.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbSuspend.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ckbSuspend.OnDisable.CheckmarkThickness = 2;
            this.ckbSuspend.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbSuspend.OnHoverChecked.BorderRadius = 2;
            this.ckbSuspend.OnHoverChecked.BorderThickness = 2;
            this.ckbSuspend.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbSuspend.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ckbSuspend.OnHoverChecked.CheckmarkThickness = 2;
            this.ckbSuspend.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbSuspend.OnHoverUnchecked.BorderRadius = 2;
            this.ckbSuspend.OnHoverUnchecked.BorderThickness = 2;
            this.ckbSuspend.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbSuspend.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ckbSuspend.OnUncheck.BorderRadius = 2;
            this.ckbSuspend.OnUncheck.BorderThickness = 2;
            this.ckbSuspend.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbSuspend.Size = new System.Drawing.Size(25, 25);
            this.ckbSuspend.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ckbSuspend.TabIndex = 4;
            this.ckbSuspend.ThreeState = false;
            this.ckbSuspend.ToolTipText = null;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(16, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 20);
            this.Label1.TabIndex = 150;
            this.Label1.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.AcceptsReturn = false;
            this.txtLastName.AcceptsTab = false;
            this.txtLastName.AnimationSpeed = 200;
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLastName.BackgroundImage")));
            this.txtLastName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtLastName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLastName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLastName.BorderRadius = 1;
            this.txtLastName.BorderThickness = 1;
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtLastName.DefaultText = "";
            this.txtLastName.FillColor = System.Drawing.Color.White;
            this.txtLastName.HideSelection = true;
            this.txtLastName.IconLeft = null;
            this.txtLastName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.IconPadding = 10;
            this.txtLastName.IconRight = null;
            this.txtLastName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(125, 43);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtLastName.Modified = false;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLastName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLastName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLastName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLastName.OnIdleState = stateProperties8;
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLastName.PlaceholderText = "ENTER TEXT";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(336, 35);
            this.txtLastName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.TextMarginBottom = 0;
            this.txtLastName.TextMarginLeft = 5;
            this.txtLastName.TextMarginTop = 0;
            this.txtLastName.TextPlaceholder = "ENTER TEXT";
            this.txtLastName.UseSystemPasswordChar = false;
            this.txtLastName.WordWrap = true;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label4.Location = new System.Drawing.Point(16, 50);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 20);
            this.Label4.TabIndex = 152;
            this.Label4.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsReturn = false;
            this.txtFirstName.AcceptsTab = false;
            this.txtFirstName.AnimationSpeed = 200;
            this.txtFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFirstName.BackgroundImage")));
            this.txtFirstName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFirstName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtFirstName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFirstName.BorderRadius = 1;
            this.txtFirstName.BorderThickness = 1;
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.FillColor = System.Drawing.Color.White;
            this.txtFirstName.HideSelection = true;
            this.txtFirstName.IconLeft = null;
            this.txtFirstName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.IconPadding = 10;
            this.txtFirstName.IconRight = null;
            this.txtFirstName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(125, 3);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtFirstName.Modified = false;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFirstName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.OnIdleState = stateProperties12;
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFirstName.PlaceholderText = "ENTER TEXT";
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(336, 35);
            this.txtFirstName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.TextMarginBottom = 0;
            this.txtFirstName.TextMarginLeft = 5;
            this.txtFirstName.TextMarginTop = 0;
            this.txtFirstName.TextPlaceholder = "ENTER TEXT";
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.WordWrap = true;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label3.Location = new System.Drawing.Point(26, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 20);
            this.Label3.TabIndex = 148;
            this.Label3.Text = "Pass ID:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassID
            // 
            this.txtPassID.AcceptsReturn = false;
            this.txtPassID.AcceptsTab = false;
            this.txtPassID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassID.AnimationSpeed = 200;
            this.txtPassID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassID.BackColor = System.Drawing.Color.Transparent;
            this.txtPassID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassID.BackgroundImage")));
            this.txtPassID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassID.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassID.BorderRadius = 1;
            this.txtPassID.BorderThickness = 1;
            this.txtPassID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassID.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtPassID.DefaultText = "";
            this.txtPassID.FillColor = System.Drawing.Color.White;
            this.txtPassID.HideSelection = true;
            this.txtPassID.IconLeft = null;
            this.txtPassID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassID.IconPadding = 10;
            this.txtPassID.IconRight = null;
            this.txtPassID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassID.Lines = new string[0];
            this.txtPassID.Location = new System.Drawing.Point(3, 3);
            this.txtPassID.MaxLength = 32767;
            this.txtPassID.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassID.Modified = false;
            this.txtPassID.Multiline = false;
            this.txtPassID.Name = "txtPassID";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassID.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassID.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassID.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassID.OnIdleState = stateProperties16;
            this.txtPassID.PasswordChar = '\0';
            this.txtPassID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassID.PlaceholderText = "ENTER TEXT";
            this.txtPassID.ReadOnly = false;
            this.txtPassID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassID.SelectedText = "";
            this.txtPassID.SelectionLength = 0;
            this.txtPassID.SelectionStart = 0;
            this.txtPassID.ShortcutsEnabled = true;
            this.txtPassID.Size = new System.Drawing.Size(278, 35);
            this.txtPassID.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassID.TabIndex = 1;
            this.txtPassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassID.TextMarginBottom = 0;
            this.txtPassID.TextMarginLeft = 5;
            this.txtPassID.TextMarginTop = 0;
            this.txtPassID.TextPlaceholder = "ENTER TEXT";
            this.txtPassID.UseSystemPasswordChar = false;
            this.txtPassID.WordWrap = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.AllowToggling = false;
            this._btnCancel.AnimationSpeed = 200;
            this._btnCancel.AutoGenerateColors = false;
            this._btnCancel.BackColor = System.Drawing.Color.Transparent;
            this._btnCancel.BackColor1 = System.Drawing.Color.IndianRed;
            this._btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnCancel.BackgroundImage")));
            this._btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this._btnCancel.ButtonText = "Cancel";
            this._btnCancel.ButtonTextMarginLeft = 0;
            this._btnCancel.ColorContrastOnClick = 45;
            this._btnCancel.ColorContrastOnHover = 45;
            this._btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this._btnCancel.CustomizableEdges = borderEdges1;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this._btnCancel.DisabledBorderColor = System.Drawing.Color.Empty;
            this._btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this._btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this._btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this._btnCancel.IconMarginLeft = 11;
            this._btnCancel.IconPadding = 10;
            this._btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this._btnCancel.IdleBorderColor = System.Drawing.Color.IndianRed;
            this._btnCancel.IdleBorderRadius = 3;
            this._btnCancel.IdleBorderThickness = 1;
            this._btnCancel.IdleFillColor = System.Drawing.Color.IndianRed;
            this._btnCancel.IdleIconLeftImage = null;
            this._btnCancel.IdleIconRightImage = null;
            this._btnCancel.IndicateFocus = true;
            this._btnCancel.Location = new System.Drawing.Point(525, 374);
            this._btnCancel.Name = "_btnCancel";
            stateProperties17.BorderColor = System.Drawing.Color.Salmon;
            stateProperties17.BorderRadius = 3;
            stateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties17.BorderThickness = 1;
            stateProperties17.FillColor = System.Drawing.Color.Salmon;
            stateProperties17.ForeColor = System.Drawing.Color.White;
            stateProperties17.IconLeftImage = null;
            stateProperties17.IconRightImage = null;
            this._btnCancel.onHoverState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.IndianRed;
            stateProperties18.BorderRadius = 3;
            stateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties18.BorderThickness = 1;
            stateProperties18.FillColor = System.Drawing.Color.IndianRed;
            stateProperties18.ForeColor = System.Drawing.Color.White;
            stateProperties18.IconLeftImage = null;
            stateProperties18.IconRightImage = null;
            this._btnCancel.OnPressedState = stateProperties18;
            this._btnCancel.Size = new System.Drawing.Size(135, 34);
            this._btnCancel.TabIndex = 8;
            this._btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnCancel.TextMarginLeft = 0;
            this._btnCancel.UseDefaultRadiusAndThickness = true;
            this._btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // _btnSave
            // 
            this._btnSave.AllowToggling = false;
            this._btnSave.AnimationSpeed = 200;
            this._btnSave.AutoGenerateColors = false;
            this._btnSave.BackColor = System.Drawing.Color.Transparent;
            this._btnSave.BackColor1 = System.Drawing.Color.Teal;
            this._btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnSave.BackgroundImage")));
            this._btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this._btnSave.ButtonText = "Save";
            this._btnSave.ButtonTextMarginLeft = 0;
            this._btnSave.ColorContrastOnClick = 45;
            this._btnSave.ColorContrastOnHover = 45;
            this._btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this._btnSave.CustomizableEdges = borderEdges2;
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this._btnSave.DisabledBorderColor = System.Drawing.Color.Empty;
            this._btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this._btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this._btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.ForeColor = System.Drawing.Color.White;
            this._btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this._btnSave.IconMarginLeft = 11;
            this._btnSave.IconPadding = 10;
            this._btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this._btnSave.IdleBorderColor = System.Drawing.Color.Teal;
            this._btnSave.IdleBorderRadius = 3;
            this._btnSave.IdleBorderThickness = 1;
            this._btnSave.IdleFillColor = System.Drawing.Color.Teal;
            this._btnSave.IdleIconLeftImage = null;
            this._btnSave.IdleIconRightImage = null;
            this._btnSave.IndicateFocus = true;
            this._btnSave.Location = new System.Drawing.Point(373, 374);
            this._btnSave.Name = "_btnSave";
            stateProperties19.BorderColor = System.Drawing.Color.MediumTurquoise;
            stateProperties19.BorderRadius = 3;
            stateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties19.BorderThickness = 1;
            stateProperties19.FillColor = System.Drawing.Color.MediumTurquoise;
            stateProperties19.ForeColor = System.Drawing.Color.White;
            stateProperties19.IconLeftImage = null;
            stateProperties19.IconRightImage = null;
            this._btnSave.onHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Teal;
            stateProperties20.BorderRadius = 3;
            stateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties20.BorderThickness = 1;
            stateProperties20.FillColor = System.Drawing.Color.Teal;
            stateProperties20.ForeColor = System.Drawing.Color.White;
            stateProperties20.IconLeftImage = null;
            stateProperties20.IconRightImage = null;
            this._btnSave.OnPressedState = stateProperties20;
            this._btnSave.Size = new System.Drawing.Size(133, 34);
            this._btnSave.TabIndex = 7;
            this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnSave.TextMarginLeft = 0;
            this._btnSave.UseDefaultRadiusAndThickness = true;
            this._btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblTruckDriver
            // 
            this.tblTruckDriver.ColumnCount = 2;
            this.tblTruckDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblTruckDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 526F));
            this.tblTruckDriver.Controls.Add(this.Label6, 0, 0);
            this.tblTruckDriver.Controls.Add(this.ddlTruckCompanie, 1, 0);
            this.tblTruckDriver.Location = new System.Drawing.Point(12, 312);
            this.tblTruckDriver.Name = "tblTruckDriver";
            this.tblTruckDriver.RowCount = 1;
            this.tblTruckDriver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblTruckDriver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblTruckDriver.Size = new System.Drawing.Size(648, 40);
            this.tblTruckDriver.TabIndex = 236;
            // 
            // ddlTruckCompanie
            // 
            this.ddlTruckCompanie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ddlTruckCompanie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlTruckCompanie.DataSource = this.CompaniesNameBindingSource;
            this.ddlTruckCompanie.DisplayMember = "CompanyName";
            this.ddlTruckCompanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTruckCompanie.FormattingEnabled = true;
            this.ddlTruckCompanie.Location = new System.Drawing.Point(125, 3);
            this.ddlTruckCompanie.Name = "ddlTruckCompanie";
            this.ddlTruckCompanie.Size = new System.Drawing.Size(520, 32);
            this.ddlTruckCompanie.TabIndex = 6;
            this.ddlTruckCompanie.ValueMember = "CompanieId";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.CursorType = null;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(136, 26);
            this.lblTitle.TabIndex = 239;
            this.lblTitle.Text = "Add New Driver";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.47439F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.52561F));
            this.TableLayoutPanel2.Controls.Add(this.pbxReadCard, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.txtPassID, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(125, 3);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(449, 39);
            this.TableLayoutPanel2.TabIndex = 242;
            // 
            // pbxReadCard
            // 
            this.pbxReadCard.Image = global::ShipSmpl.My.Resources.Resources.tapCardIcon2;
            this.pbxReadCard.Location = new System.Drawing.Point(288, 3);
            this.pbxReadCard.Name = "pbxReadCard";
            this.pbxReadCard.Size = new System.Drawing.Size(40, 33);
            this.pbxReadCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReadCard.TabIndex = 241;
            this.pbxReadCard.TabStop = false;
            // 
            // tblPassCard
            // 
            this.tblPassCard.ColumnCount = 2;
            this.tblPassCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.98148F));
            this.tblPassCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.01852F));
            this.tblPassCard.Controls.Add(this.TableLayoutPanel2, 1, 0);
            this.tblPassCard.Controls.Add(this.Label3, 0, 0);
            this.tblPassCard.Location = new System.Drawing.Point(12, 106);
            this.tblPassCard.Name = "tblPassCard";
            this.tblPassCard.RowCount = 1;
            this.tblPassCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPassCard.Size = new System.Drawing.Size(648, 45);
            this.tblPassCard.TabIndex = 240;
            // 
            // frmEditTruckDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 426);
            this.Controls.Add(this.tblPassCard);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tblTruckDriver);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this._closeLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this._btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditTruckDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditTruckDrivers";
            this.Load += new System.EventHandler(this.frmEditTruckDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesNameBindingSource)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.tblTruckDriver.ResumeLayout(false);
            this.tblTruckDriver.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxReadCard)).EndInit();
            this.tblPassCard.ResumeLayout(false);
            this.tblPassCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label _closeLabel;

        internal Label closeLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeLabel != null)
                {
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label2;
        internal Label Label6;
        internal TableLayoutPanel TableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancel;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancel != null)
                {
                    _btnCancel.Click -= btnCancel_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click;
                }
            }
        }

        internal Label Label3;
        internal BunifuTextBox txtLastName;
        internal Label Label4;
        internal BunifuTextBox txtFirstName;
        internal Label Label1;
        internal Label Label5;
        internal BunifuTextBox txtTruckNumber;
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

        internal Bunifu.UI.WinForms.BunifuCheckBox ckbSuspend;
        internal Label Label7;
        internal TableLayoutPanel tblTruckDriver;
        internal BindingSource CompaniesNameBindingSource;
        internal ComboBox ddlTruckCompanie;
        internal BunifuTextBox txtPassID;
        internal Bunifu.UI.WinForms.BunifuLabel lblTitle;
        internal TableLayoutPanel TableLayoutPanel2;
        internal PictureBox pbxReadCard;
        internal TableLayoutPanel tblPassCard;
    }
}