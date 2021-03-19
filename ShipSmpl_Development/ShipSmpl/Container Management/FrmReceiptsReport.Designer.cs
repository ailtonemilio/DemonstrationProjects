using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ShipSmpl.Container_Management;
using ShipSmpl.Reports;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmReceiptsReport : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceiptsReport));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this._closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Label8 = new System.Windows.Forms.Label();
            this.bkngLabel = new System.Windows.Forms.Label();
            this.manEntryPanel = new System.Windows.Forms.Panel();
            this.bkgRelTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.destinationTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this._Label26 = new System.Windows.Forms.Label();
            this._applyChangesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.shipToDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Label25 = new System.Windows.Forms.Label();
            this.contNumbTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.lrdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.erdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.driverDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.commentsTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.truckDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.conditionDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.statusDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.sizeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.vesselTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cargoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.grossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label23 = new System.Windows.Forms.Label();
            this.tareNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pickUpDropOffDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.carrierDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.sealTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.ssLineDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this._CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalTruckingReport1 = new ShipSmpl.Billing.CrystalTruckingReport();
         //   this.CrystalReportReceipt1 = new ShipSmpl.Reports.CrystalReportReceipt();
            this.manEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeFlatButton
            // 
            this._closeFlatButton.Active = false;
            this._closeFlatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._closeFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._closeFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._closeFlatButton.BorderRadius = 0;
            this._closeFlatButton.ButtonText = "🗙";
            this._closeFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this._closeFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this._closeFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this._closeFlatButton.Iconimage = null;
            this._closeFlatButton.Iconimage_right = null;
            this._closeFlatButton.Iconimage_right_Selected = null;
            this._closeFlatButton.Iconimage_Selected = null;
            this._closeFlatButton.IconMarginLeft = 0;
            this._closeFlatButton.IconMarginRight = 0;
            this._closeFlatButton.IconRightVisible = true;
            this._closeFlatButton.IconRightZoom = 0D;
            this._closeFlatButton.IconVisible = true;
            this._closeFlatButton.IconZoom = 90D;
            this._closeFlatButton.IsTab = false;
            this._closeFlatButton.Location = new System.Drawing.Point(1601, 0);
            this._closeFlatButton.Name = "_closeFlatButton";
            this._closeFlatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._closeFlatButton.OnHovercolor = System.Drawing.Color.Gray;
            this._closeFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this._closeFlatButton.selected = false;
            this._closeFlatButton.Size = new System.Drawing.Size(43, 41);
            this._closeFlatButton.TabIndex = 170;
            this._closeFlatButton.Text = "🗙";
            this._closeFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._closeFlatButton.Textcolor = System.Drawing.Color.White;
            this._closeFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._closeFlatButton.Click += new System.EventHandler(this.closeFlatButton_Click);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(0, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(1644, 41);
            this.Label8.TabIndex = 169;
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bkngLabel
            // 
            this.bkngLabel.AutoSize = true;
            this.bkngLabel.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkngLabel.Location = new System.Drawing.Point(22, 10);
            this.bkngLabel.Name = "bkngLabel";
            this.bkngLabel.Size = new System.Drawing.Size(76, 20);
            this.bkngLabel.TabIndex = 182;
            this.bkngLabel.Text = "Release #:";
            // 
            // manEntryPanel
            // 
            this.manEntryPanel.Controls.Add(this.bkgRelTextBox);
            this.manEntryPanel.Controls.Add(this.destinationTextBox);
            this.manEntryPanel.Controls.Add(this._Label26);
            this.manEntryPanel.Controls.Add(this.bkngLabel);
            this.manEntryPanel.Controls.Add(this._applyChangesButton);
            this.manEntryPanel.Controls.Add(this.shipToDropdown);
            this.manEntryPanel.Controls.Add(this.Label25);
            this.manEntryPanel.Controls.Add(this.contNumbTextBox);
            this.manEntryPanel.Controls.Add(this.Label24);
            this.manEntryPanel.Controls.Add(this.lrdDatePicker);
            this.manEntryPanel.Controls.Add(this.erdDatePicker);
            this.manEntryPanel.Controls.Add(this.timePicker);
            this.manEntryPanel.Controls.Add(this.datePicker);
            this.manEntryPanel.Controls.Add(this.driverDropdown);
            this.manEntryPanel.Controls.Add(this.commentsTextBox);
            this.manEntryPanel.Controls.Add(this.truckDropdown);
            this.manEntryPanel.Controls.Add(this.conditionDropdown);
            this.manEntryPanel.Controls.Add(this.statusDropdown);
            this.manEntryPanel.Controls.Add(this.sizeDropdown);
            this.manEntryPanel.Controls.Add(this.vesselTextBox);
            this.manEntryPanel.Controls.Add(this.cargoNumericUpDown);
            this.manEntryPanel.Controls.Add(this.grossNumericUpDown);
            this.manEntryPanel.Controls.Add(this.Label23);
            this.manEntryPanel.Controls.Add(this.tareNumericUpDown);
            this.manEntryPanel.Controls.Add(this.pickUpDropOffDropdown);
            this.manEntryPanel.Controls.Add(this.carrierDropdown);
            this.manEntryPanel.Controls.Add(this.sealTextBox2);
            this.manEntryPanel.Controls.Add(this.ssLineDropdown);
            this.manEntryPanel.Controls.Add(this.Label22);
            this.manEntryPanel.Controls.Add(this.Label21);
            this.manEntryPanel.Controls.Add(this.Label20);
            this.manEntryPanel.Controls.Add(this.Label19);
            this.manEntryPanel.Controls.Add(this.Label18);
            this.manEntryPanel.Controls.Add(this.Label17);
            this.manEntryPanel.Controls.Add(this.Label16);
            this.manEntryPanel.Controls.Add(this.Label15);
            this.manEntryPanel.Controls.Add(this.Label14);
            this.manEntryPanel.Controls.Add(this.Label13);
            this.manEntryPanel.Controls.Add(this.Label12);
            this.manEntryPanel.Controls.Add(this.Label11);
            this.manEntryPanel.Controls.Add(this.Label10);
            this.manEntryPanel.Controls.Add(this.Label9);
            this.manEntryPanel.Controls.Add(this.Label7);
            this.manEntryPanel.Controls.Add(this.Label6);
            this.manEntryPanel.Controls.Add(this.Label5);
            this.manEntryPanel.Location = new System.Drawing.Point(24, 150);
            this.manEntryPanel.Name = "manEntryPanel";
            this.manEntryPanel.Size = new System.Drawing.Size(415, 696);
            this.manEntryPanel.TabIndex = 185;
            // 
            // bkgRelTextBox
            // 
            this.bkgRelTextBox.AcceptsReturn = false;
            this.bkgRelTextBox.AcceptsTab = false;
            this.bkgRelTextBox.AnimationSpeed = 200;
            this.bkgRelTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bkgRelTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bkgRelTextBox.BackColor = System.Drawing.Color.Transparent;
            this.bkgRelTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bkgRelTextBox.BackgroundImage")));
            this.bkgRelTextBox.BorderColorActive = System.Drawing.Color.LightSeaGreen;
            this.bkgRelTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bkgRelTextBox.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.bkgRelTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.bkgRelTextBox.BorderRadius = 1;
            this.bkgRelTextBox.BorderThickness = 1;
            this.bkgRelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bkgRelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bkgRelTextBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.163636F, System.Drawing.FontStyle.Bold);
            this.bkgRelTextBox.DefaultText = "";
            this.bkgRelTextBox.FillColor = System.Drawing.Color.White;
            this.bkgRelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bkgRelTextBox.HideSelection = true;
            this.bkgRelTextBox.IconLeft = null;
            this.bkgRelTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bkgRelTextBox.IconPadding = 10;
            this.bkgRelTextBox.IconRight = null;
            this.bkgRelTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bkgRelTextBox.Lines = new string[0];
            this.bkgRelTextBox.Location = new System.Drawing.Point(106, 3);
            this.bkgRelTextBox.MaxLength = 32767;
            this.bkgRelTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.bkgRelTextBox.Modified = false;
            this.bkgRelTextBox.Multiline = false;
            this.bkgRelTextBox.Name = "bkgRelTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bkgRelTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bkgRelTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bkgRelTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bkgRelTextBox.OnIdleState = stateProperties4;
            this.bkgRelTextBox.PasswordChar = '\0';
            this.bkgRelTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bkgRelTextBox.PlaceholderText = "";
            this.bkgRelTextBox.ReadOnly = false;
            this.bkgRelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bkgRelTextBox.SelectedText = "";
            this.bkgRelTextBox.SelectionLength = 0;
            this.bkgRelTextBox.SelectionStart = 0;
            this.bkgRelTextBox.ShortcutsEnabled = true;
            this.bkgRelTextBox.Size = new System.Drawing.Size(132, 30);
            this.bkgRelTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bkgRelTextBox.TabIndex = 227;
            this.bkgRelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bkgRelTextBox.TextMarginBottom = 0;
            this.bkgRelTextBox.TextMarginLeft = 5;
            this.bkgRelTextBox.TextMarginTop = 0;
            this.bkgRelTextBox.TextPlaceholder = "";
            this.bkgRelTextBox.UseSystemPasswordChar = false;
            this.bkgRelTextBox.WordWrap = true;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.AcceptsReturn = false;
            this.destinationTextBox.AcceptsTab = false;
            this.destinationTextBox.AnimationSpeed = 200;
            this.destinationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.destinationTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.destinationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.destinationTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("destinationTextBox.BackgroundImage")));
            this.destinationTextBox.BorderColorActive = System.Drawing.Color.LightSeaGreen;
            this.destinationTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.destinationTextBox.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.destinationTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.destinationTextBox.BorderRadius = 1;
            this.destinationTextBox.BorderThickness = 1;
            this.destinationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.destinationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationTextBox.DefaultText = "";
            this.destinationTextBox.FillColor = System.Drawing.Color.White;
            this.destinationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.destinationTextBox.HideSelection = true;
            this.destinationTextBox.IconLeft = null;
            this.destinationTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationTextBox.IconPadding = 10;
            this.destinationTextBox.IconRight = null;
            this.destinationTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationTextBox.Lines = new string[0];
            this.destinationTextBox.Location = new System.Drawing.Point(106, 584);
            this.destinationTextBox.MaxLength = 32767;
            this.destinationTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.destinationTextBox.Modified = false;
            this.destinationTextBox.Multiline = false;
            this.destinationTextBox.Name = "destinationTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.destinationTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.destinationTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.destinationTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Gray;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.destinationTextBox.OnIdleState = stateProperties8;
            this.destinationTextBox.PasswordChar = '\0';
            this.destinationTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.destinationTextBox.PlaceholderText = "";
            this.destinationTextBox.ReadOnly = false;
            this.destinationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.destinationTextBox.SelectedText = "";
            this.destinationTextBox.SelectionLength = 0;
            this.destinationTextBox.SelectionStart = 0;
            this.destinationTextBox.ShortcutsEnabled = true;
            this.destinationTextBox.Size = new System.Drawing.Size(225, 25);
            this.destinationTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.destinationTextBox.TabIndex = 226;
            this.destinationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.destinationTextBox.TextMarginBottom = 0;
            this.destinationTextBox.TextMarginLeft = 5;
            this.destinationTextBox.TextMarginTop = 0;
            this.destinationTextBox.TextPlaceholder = "";
            this.destinationTextBox.UseSystemPasswordChar = false;
            this.destinationTextBox.WordWrap = true;
            // 
            // _Label26
            // 
            this._Label26.AutoSize = true;
            this._Label26.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label26.Location = new System.Drawing.Point(6, 584);
            this._Label26.Name = "_Label26";
            this._Label26.Size = new System.Drawing.Size(88, 20);
            this._Label26.TabIndex = 225;
            this._Label26.Text = "Destination:";
            this._Label26.Click += new System.EventHandler(this.Label26_Click);
            // 
            // _applyChangesButton
            // 
            this._applyChangesButton.AllowToggling = false;
            this._applyChangesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._applyChangesButton.AnimationSpeed = 200;
            this._applyChangesButton.AutoGenerateColors = false;
            this._applyChangesButton.BackColor = System.Drawing.Color.Transparent;
            this._applyChangesButton.BackColor1 = System.Drawing.Color.Teal;
            this._applyChangesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_applyChangesButton.BackgroundImage")));
            this._applyChangesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this._applyChangesButton.ButtonText = "Apply Changes";
            this._applyChangesButton.ButtonTextMarginLeft = 0;
            this._applyChangesButton.ColorContrastOnClick = 45;
            this._applyChangesButton.ColorContrastOnHover = 45;
            this._applyChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this._applyChangesButton.CustomizableEdges = borderEdges1;
            this._applyChangesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this._applyChangesButton.DisabledBorderColor = System.Drawing.Color.Empty;
            this._applyChangesButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._applyChangesButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this._applyChangesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this._applyChangesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._applyChangesButton.ForeColor = System.Drawing.Color.White;
            this._applyChangesButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this._applyChangesButton.IconMarginLeft = 11;
            this._applyChangesButton.IconPadding = 10;
            this._applyChangesButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this._applyChangesButton.IdleBorderColor = System.Drawing.Color.Teal;
            this._applyChangesButton.IdleBorderRadius = 3;
            this._applyChangesButton.IdleBorderThickness = 1;
            this._applyChangesButton.IdleFillColor = System.Drawing.Color.Teal;
            this._applyChangesButton.IdleIconLeftImage = null;
            this._applyChangesButton.IdleIconRightImage = null;
            this._applyChangesButton.IndicateFocus = true;
            this._applyChangesButton.Location = new System.Drawing.Point(133, 658);
            this._applyChangesButton.Name = "_applyChangesButton";
            stateProperties9.BorderColor = System.Drawing.Color.MediumTurquoise;
            stateProperties9.BorderRadius = 3;
            stateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.MediumTurquoise;
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this._applyChangesButton.onHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Teal;
            stateProperties10.BorderRadius = 3;
            stateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.Teal;
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this._applyChangesButton.OnPressedState = stateProperties10;
            this._applyChangesButton.Size = new System.Drawing.Size(127, 33);
            this._applyChangesButton.TabIndex = 224;
            this._applyChangesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._applyChangesButton.TextMarginLeft = 0;
            this._applyChangesButton.UseDefaultRadiusAndThickness = true;
            this._applyChangesButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // shipToDropdown
            // 
            this.shipToDropdown.BackColor = System.Drawing.Color.White;
            this.shipToDropdown.BorderRadius = 3;
            this.shipToDropdown.Color = System.Drawing.Color.Teal;
            this.shipToDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.shipToDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.shipToDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.shipToDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.shipToDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipToDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.shipToDropdown.FillDropDown = false;
            this.shipToDropdown.FillIndicator = true;
            this.shipToDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shipToDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipToDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shipToDropdown.FormattingEnabled = true;
            this.shipToDropdown.Icon = null;
            this.shipToDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.shipToDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.shipToDropdown.ItemBackColor = System.Drawing.Color.White;
            this.shipToDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.shipToDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shipToDropdown.ItemHeight = 20;
            this.shipToDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.shipToDropdown.Location = new System.Drawing.Point(105, 227);
            this.shipToDropdown.MaxDropDownItems = 50;
            this.shipToDropdown.Name = "shipToDropdown";
            this.shipToDropdown.Size = new System.Drawing.Size(284, 26);
            this.shipToDropdown.TabIndex = 223;
            this.shipToDropdown.Text = null;
            // 
            // Label25
            // 
            this.Label25.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(7, 227);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(99, 23);
            this.Label25.TabIndex = 222;
            this.Label25.Text = "Ship To:";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contNumbTextBox
            // 
            this.contNumbTextBox.AcceptsReturn = false;
            this.contNumbTextBox.AcceptsTab = false;
            this.contNumbTextBox.AnimationSpeed = 200;
            this.contNumbTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.contNumbTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.contNumbTextBox.BackColor = System.Drawing.Color.Transparent;
            this.contNumbTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contNumbTextBox.BackgroundImage")));
            this.contNumbTextBox.BorderColorActive = System.Drawing.Color.LightSeaGreen;
            this.contNumbTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.contNumbTextBox.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.contNumbTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.contNumbTextBox.BorderRadius = 1;
            this.contNumbTextBox.BorderThickness = 1;
            this.contNumbTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contNumbTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contNumbTextBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.163636F, System.Drawing.FontStyle.Bold);
            this.contNumbTextBox.DefaultText = "";
            this.contNumbTextBox.FillColor = System.Drawing.Color.White;
            this.contNumbTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contNumbTextBox.HideSelection = true;
            this.contNumbTextBox.IconLeft = null;
            this.contNumbTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.contNumbTextBox.IconPadding = 10;
            this.contNumbTextBox.IconRight = null;
            this.contNumbTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.contNumbTextBox.Lines = new string[0];
            this.contNumbTextBox.Location = new System.Drawing.Point(106, 34);
            this.contNumbTextBox.MaxLength = 32767;
            this.contNumbTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.contNumbTextBox.Modified = false;
            this.contNumbTextBox.Multiline = false;
            this.contNumbTextBox.Name = "contNumbTextBox";
            stateProperties11.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.contNumbTextBox.OnActiveState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Empty;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.contNumbTextBox.OnDisabledState = stateProperties12;
            stateProperties13.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.contNumbTextBox.OnHoverState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Gray;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.contNumbTextBox.OnIdleState = stateProperties14;
            this.contNumbTextBox.PasswordChar = '\0';
            this.contNumbTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.contNumbTextBox.PlaceholderText = "";
            this.contNumbTextBox.ReadOnly = false;
            this.contNumbTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contNumbTextBox.SelectedText = "";
            this.contNumbTextBox.SelectionLength = 0;
            this.contNumbTextBox.SelectionStart = 0;
            this.contNumbTextBox.ShortcutsEnabled = true;
            this.contNumbTextBox.Size = new System.Drawing.Size(132, 30);
            this.contNumbTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.contNumbTextBox.TabIndex = 221;
            this.contNumbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contNumbTextBox.TextMarginBottom = 0;
            this.contNumbTextBox.TextMarginLeft = 5;
            this.contNumbTextBox.TextMarginTop = 0;
            this.contNumbTextBox.TextPlaceholder = "";
            this.contNumbTextBox.UseSystemPasswordChar = false;
            this.contNumbTextBox.WordWrap = true;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(3, 36);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(89, 20);
            this.Label24.TabIndex = 220;
            this.Label24.Text = "Container #:";
            // 
            // lrdDatePicker
            // 
            this.lrdDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrdDatePicker.CustomFormat = "MMM dd, yyyy";
            this.lrdDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrdDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lrdDatePicker.Location = new System.Drawing.Point(107, 339);
            this.lrdDatePicker.MinimumSize = new System.Drawing.Size(110, 20);
            this.lrdDatePicker.Name = "lrdDatePicker";
            this.lrdDatePicker.Size = new System.Drawing.Size(110, 25);
            this.lrdDatePicker.TabIndex = 219;
            // 
            // erdDatePicker
            // 
            this.erdDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erdDatePicker.CustomFormat = "MMM dd, yyyy";
            this.erdDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erdDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.erdDatePicker.Location = new System.Drawing.Point(107, 311);
            this.erdDatePicker.MinimumSize = new System.Drawing.Size(110, 20);
            this.erdDatePicker.Name = "erdDatePicker";
            this.erdDatePicker.Size = new System.Drawing.Size(110, 25);
            this.erdDatePicker.TabIndex = 218;
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(107, 283);
            this.timePicker.MinimumSize = new System.Drawing.Size(110, 20);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(110, 25);
            this.timePicker.TabIndex = 217;
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CustomFormat = "MMM dd, yyyy";
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(107, 254);
            this.datePicker.MinimumSize = new System.Drawing.Size(110, 20);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(110, 25);
            this.datePicker.TabIndex = 216;
            // 
            // driverDropdown
            // 
            this.driverDropdown.BackColor = System.Drawing.Color.White;
            this.driverDropdown.BorderRadius = 3;
            this.driverDropdown.Color = System.Drawing.Color.Teal;
            this.driverDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.driverDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.driverDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.driverDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.driverDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.driverDropdown.FillDropDown = false;
            this.driverDropdown.FillIndicator = true;
            this.driverDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.driverDropdown.FormattingEnabled = true;
            this.driverDropdown.Icon = null;
            this.driverDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.driverDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.driverDropdown.ItemBackColor = System.Drawing.Color.White;
            this.driverDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.driverDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.driverDropdown.ItemHeight = 20;
            this.driverDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.driverDropdown.Location = new System.Drawing.Point(107, 531);
            this.driverDropdown.MaxDropDownItems = 50;
            this.driverDropdown.Name = "driverDropdown";
            this.driverDropdown.Size = new System.Drawing.Size(265, 26);
            this.driverDropdown.TabIndex = 215;
            this.driverDropdown.Text = null;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.AcceptsReturn = false;
            this.commentsTextBox.AcceptsTab = false;
            this.commentsTextBox.AnimationSpeed = 200;
            this.commentsTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.commentsTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.commentsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.commentsTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commentsTextBox.BackgroundImage")));
            this.commentsTextBox.BorderColorActive = System.Drawing.Color.LightSeaGreen;
            this.commentsTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.commentsTextBox.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.commentsTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.commentsTextBox.BorderRadius = 1;
            this.commentsTextBox.BorderThickness = 1;
            this.commentsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.commentsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commentsTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.DefaultText = "";
            this.commentsTextBox.FillColor = System.Drawing.Color.White;
            this.commentsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commentsTextBox.HideSelection = true;
            this.commentsTextBox.IconLeft = null;
            this.commentsTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.commentsTextBox.IconPadding = 10;
            this.commentsTextBox.IconRight = null;
            this.commentsTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.commentsTextBox.Lines = new string[0];
            this.commentsTextBox.Location = new System.Drawing.Point(105, 558);
            this.commentsTextBox.MaxLength = 32767;
            this.commentsTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.commentsTextBox.Modified = false;
            this.commentsTextBox.Multiline = false;
            this.commentsTextBox.Name = "commentsTextBox";
            stateProperties15.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.commentsTextBox.OnActiveState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Empty;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.commentsTextBox.OnDisabledState = stateProperties16;
            stateProperties17.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.commentsTextBox.OnHoverState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Gray;
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.commentsTextBox.OnIdleState = stateProperties18;
            this.commentsTextBox.PasswordChar = '\0';
            this.commentsTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.commentsTextBox.PlaceholderText = "";
            this.commentsTextBox.ReadOnly = false;
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commentsTextBox.SelectedText = "";
            this.commentsTextBox.SelectionLength = 0;
            this.commentsTextBox.SelectionStart = 0;
            this.commentsTextBox.ShortcutsEnabled = true;
            this.commentsTextBox.Size = new System.Drawing.Size(225, 25);
            this.commentsTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.commentsTextBox.TabIndex = 213;
            this.commentsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.commentsTextBox.TextMarginBottom = 0;
            this.commentsTextBox.TextMarginLeft = 5;
            this.commentsTextBox.TextMarginTop = 0;
            this.commentsTextBox.TextPlaceholder = "";
            this.commentsTextBox.UseSystemPasswordChar = false;
            this.commentsTextBox.WordWrap = true;
            // 
            // truckDropdown
            // 
            this.truckDropdown.BackColor = System.Drawing.Color.White;
            this.truckDropdown.BorderRadius = 3;
            this.truckDropdown.Color = System.Drawing.Color.Teal;
            this.truckDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.truckDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.truckDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.truckDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.truckDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.truckDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.truckDropdown.FillDropDown = false;
            this.truckDropdown.FillIndicator = true;
            this.truckDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.truckDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truckDropdown.FormattingEnabled = true;
            this.truckDropdown.Icon = null;
            this.truckDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.truckDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.truckDropdown.ItemBackColor = System.Drawing.Color.White;
            this.truckDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.truckDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truckDropdown.ItemHeight = 20;
            this.truckDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.truckDropdown.Location = new System.Drawing.Point(107, 503);
            this.truckDropdown.MaxDropDownItems = 50;
            this.truckDropdown.Name = "truckDropdown";
            this.truckDropdown.Size = new System.Drawing.Size(102, 26);
            this.truckDropdown.TabIndex = 214;
            this.truckDropdown.Text = null;
            // 
            // conditionDropdown
            // 
            this.conditionDropdown.BackColor = System.Drawing.Color.White;
            this.conditionDropdown.BorderRadius = 3;
            this.conditionDropdown.Color = System.Drawing.Color.Teal;
            this.conditionDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.conditionDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.conditionDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.conditionDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.conditionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.conditionDropdown.FillDropDown = false;
            this.conditionDropdown.FillIndicator = true;
            this.conditionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.conditionDropdown.FormattingEnabled = true;
            this.conditionDropdown.Icon = null;
            this.conditionDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.conditionDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.conditionDropdown.ItemBackColor = System.Drawing.Color.White;
            this.conditionDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.conditionDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.conditionDropdown.ItemHeight = 20;
            this.conditionDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.conditionDropdown.Items.AddRange(new object[] {
            "GOOD",
            "HOLE",
            "BENT",
            "BROKEN",
            "CUT",
            "DENT",
            "BULGE",
            "MISSING"});
            this.conditionDropdown.Location = new System.Drawing.Point(107, 119);
            this.conditionDropdown.MaxDropDownItems = 50;
            this.conditionDropdown.Name = "conditionDropdown";
            this.conditionDropdown.Size = new System.Drawing.Size(134, 26);
            this.conditionDropdown.TabIndex = 212;
            this.conditionDropdown.Text = null;
            // 
            // statusDropdown
            // 
            this.statusDropdown.BackColor = System.Drawing.Color.White;
            this.statusDropdown.BorderRadius = 3;
            this.statusDropdown.Color = System.Drawing.Color.Teal;
            this.statusDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.statusDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.statusDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.statusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.statusDropdown.FillDropDown = false;
            this.statusDropdown.FillIndicator = true;
            this.statusDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Icon = null;
            this.statusDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.statusDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.statusDropdown.ItemBackColor = System.Drawing.Color.White;
            this.statusDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.statusDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusDropdown.ItemHeight = 20;
            this.statusDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.statusDropdown.Items.AddRange(new object[] {
            "EMPTY",
            "PARTIAL",
            "LOADED"});
            this.statusDropdown.Location = new System.Drawing.Point(107, 91);
            this.statusDropdown.MaxDropDownItems = 50;
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(134, 26);
            this.statusDropdown.TabIndex = 211;
            this.statusDropdown.Text = null;
            // 
            // sizeDropdown
            // 
            this.sizeDropdown.BackColor = System.Drawing.Color.White;
            this.sizeDropdown.BorderRadius = 3;
            this.sizeDropdown.Color = System.Drawing.Color.Teal;
            this.sizeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.sizeDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.sizeDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sizeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.sizeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sizeDropdown.FillDropDown = false;
            this.sizeDropdown.FillIndicator = true;
            this.sizeDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sizeDropdown.FormattingEnabled = true;
            this.sizeDropdown.Icon = null;
            this.sizeDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.sizeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sizeDropdown.ItemBackColor = System.Drawing.Color.White;
            this.sizeDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.sizeDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sizeDropdown.ItemHeight = 20;
            this.sizeDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.sizeDropdown.Items.AddRange(new object[] {
            "20 FT",
            "40 FT",
            "40 HC FT ",
            "53 FT"});
            this.sizeDropdown.Location = new System.Drawing.Point(107, 64);
            this.sizeDropdown.MaxDropDownItems = 50;
            this.sizeDropdown.Name = "sizeDropdown";
            this.sizeDropdown.Size = new System.Drawing.Size(134, 26);
            this.sizeDropdown.TabIndex = 210;
            this.sizeDropdown.Text = null;
            // 
            // vesselTextBox
            // 
            this.vesselTextBox.AcceptsReturn = false;
            this.vesselTextBox.AcceptsTab = false;
            this.vesselTextBox.AnimationSpeed = 200;
            this.vesselTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.vesselTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.vesselTextBox.BackColor = System.Drawing.Color.Transparent;
            this.vesselTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vesselTextBox.BackgroundImage")));
            this.vesselTextBox.BorderColorActive = System.Drawing.Color.LightSeaGreen;
            this.vesselTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.vesselTextBox.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.vesselTextBox.BorderColorIdle = System.Drawing.Color.Gray;
            this.vesselTextBox.BorderRadius = 1;
            this.vesselTextBox.BorderThickness = 1;
            this.vesselTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.vesselTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vesselTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vesselTextBox.DefaultText = "";
            this.vesselTextBox.FillColor = System.Drawing.Color.White;
            this.vesselTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vesselTextBox.HideSelection = true;
            this.vesselTextBox.IconLeft = null;
            this.vesselTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.vesselTextBox.IconPadding = 10;
            this.vesselTextBox.IconRight = null;
            this.vesselTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.vesselTextBox.Lines = new string[0];
            this.vesselTextBox.Location = new System.Drawing.Point(107, 450);
            this.vesselTextBox.MaxLength = 32767;
            this.vesselTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.vesselTextBox.Modified = false;
            this.vesselTextBox.Multiline = false;
            this.vesselTextBox.Name = "vesselTextBox";
            stateProperties19.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.vesselTextBox.OnActiveState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Empty;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.vesselTextBox.OnDisabledState = stateProperties20;
            stateProperties21.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.vesselTextBox.OnHoverState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.Gray;
            stateProperties22.FillColor = System.Drawing.Color.White;
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.vesselTextBox.OnIdleState = stateProperties22;
            this.vesselTextBox.PasswordChar = '\0';
            this.vesselTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.vesselTextBox.PlaceholderText = "";
            this.vesselTextBox.ReadOnly = false;
            this.vesselTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vesselTextBox.SelectedText = "";
            this.vesselTextBox.SelectionLength = 0;
            this.vesselTextBox.SelectionStart = 0;
            this.vesselTextBox.ShortcutsEnabled = true;
            this.vesselTextBox.Size = new System.Drawing.Size(137, 25);
            this.vesselTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.vesselTextBox.TabIndex = 209;
            this.vesselTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vesselTextBox.TextMarginBottom = 0;
            this.vesselTextBox.TextMarginLeft = 5;
            this.vesselTextBox.TextMarginTop = 0;
            this.vesselTextBox.TextPlaceholder = "";
            this.vesselTextBox.UseSystemPasswordChar = false;
            this.vesselTextBox.WordWrap = true;
            // 
            // cargoNumericUpDown
            // 
            this.cargoNumericUpDown.DecimalPlaces = 3;
            this.cargoNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoNumericUpDown.Location = new System.Drawing.Point(107, 418);
            this.cargoNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cargoNumericUpDown.Name = "cargoNumericUpDown";
            this.cargoNumericUpDown.Size = new System.Drawing.Size(67, 24);
            this.cargoNumericUpDown.TabIndex = 207;
            // 
            // grossNumericUpDown
            // 
            this.grossNumericUpDown.DecimalPlaces = 3;
            this.grossNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossNumericUpDown.Location = new System.Drawing.Point(107, 392);
            this.grossNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.grossNumericUpDown.Name = "grossNumericUpDown";
            this.grossNumericUpDown.Size = new System.Drawing.Size(67, 24);
            this.grossNumericUpDown.TabIndex = 206;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(12, 558);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(83, 20);
            this.Label23.TabIndex = 200;
            this.Label23.Text = "Comments:";
            // 
            // tareNumericUpDown
            // 
            this.tareNumericUpDown.DecimalPlaces = 3;
            this.tareNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareNumericUpDown.Location = new System.Drawing.Point(107, 365);
            this.tareNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tareNumericUpDown.Name = "tareNumericUpDown";
            this.tareNumericUpDown.Size = new System.Drawing.Size(67, 24);
            this.tareNumericUpDown.TabIndex = 205;
            // 
            // pickUpDropOffDropdown
            // 
            this.pickUpDropOffDropdown.BackColor = System.Drawing.Color.White;
            this.pickUpDropOffDropdown.BorderRadius = 3;
            this.pickUpDropOffDropdown.Color = System.Drawing.Color.Teal;
            this.pickUpDropOffDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.pickUpDropOffDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.pickUpDropOffDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pickUpDropOffDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.pickUpDropOffDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickUpDropOffDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.pickUpDropOffDropdown.FillDropDown = false;
            this.pickUpDropOffDropdown.FillIndicator = true;
            this.pickUpDropOffDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickUpDropOffDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpDropOffDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pickUpDropOffDropdown.FormattingEnabled = true;
            this.pickUpDropOffDropdown.Icon = null;
            this.pickUpDropOffDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.pickUpDropOffDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.pickUpDropOffDropdown.ItemBackColor = System.Drawing.Color.White;
            this.pickUpDropOffDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.pickUpDropOffDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pickUpDropOffDropdown.ItemHeight = 20;
            this.pickUpDropOffDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.pickUpDropOffDropdown.Location = new System.Drawing.Point(105, 200);
            this.pickUpDropOffDropdown.MaxDropDownItems = 50;
            this.pickUpDropOffDropdown.Name = "pickUpDropOffDropdown";
            this.pickUpDropOffDropdown.Size = new System.Drawing.Size(284, 26);
            this.pickUpDropOffDropdown.TabIndex = 204;
            this.pickUpDropOffDropdown.Text = null;
            // 
            // carrierDropdown
            // 
            this.carrierDropdown.BackColor = System.Drawing.Color.White;
            this.carrierDropdown.BorderRadius = 3;
            this.carrierDropdown.Color = System.Drawing.Color.Teal;
            this.carrierDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.carrierDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.carrierDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carrierDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.carrierDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carrierDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.carrierDropdown.FillDropDown = false;
            this.carrierDropdown.FillIndicator = true;
            this.carrierDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carrierDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carrierDropdown.FormattingEnabled = true;
            this.carrierDropdown.Icon = null;
            this.carrierDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.carrierDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.carrierDropdown.ItemBackColor = System.Drawing.Color.White;
            this.carrierDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.carrierDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carrierDropdown.ItemHeight = 20;
            this.carrierDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.carrierDropdown.Location = new System.Drawing.Point(105, 173);
            this.carrierDropdown.MaxDropDownItems = 50;
            this.carrierDropdown.Name = "carrierDropdown";
            this.carrierDropdown.Size = new System.Drawing.Size(284, 26);
            this.carrierDropdown.TabIndex = 203;
            this.carrierDropdown.Text = null;
            // 
            // sealTextBox2
            // 
            this.sealTextBox2.AcceptsReturn = false;
            this.sealTextBox2.AcceptsTab = false;
            this.sealTextBox2.AnimationSpeed = 200;
            this.sealTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sealTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sealTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.sealTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sealTextBox2.BackgroundImage")));
            this.sealTextBox2.BorderColorActive = System.Drawing.Color.LightSeaGreen;
            this.sealTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.sealTextBox2.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.sealTextBox2.BorderColorIdle = System.Drawing.Color.Gray;
            this.sealTextBox2.BorderRadius = 1;
            this.sealTextBox2.BorderThickness = 1;
            this.sealTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sealTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sealTextBox2.DefaultFont = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sealTextBox2.DefaultText = "";
            this.sealTextBox2.FillColor = System.Drawing.Color.White;
            this.sealTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sealTextBox2.HideSelection = true;
            this.sealTextBox2.IconLeft = null;
            this.sealTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.sealTextBox2.IconPadding = 10;
            this.sealTextBox2.IconRight = null;
            this.sealTextBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sealTextBox2.Lines = new string[0];
            this.sealTextBox2.Location = new System.Drawing.Point(107, 476);
            this.sealTextBox2.MaxLength = 32767;
            this.sealTextBox2.MinimumSize = new System.Drawing.Size(100, 20);
            this.sealTextBox2.Modified = false;
            this.sealTextBox2.Multiline = false;
            this.sealTextBox2.Name = "sealTextBox2";
            stateProperties23.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sealTextBox2.OnActiveState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Empty;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.sealTextBox2.OnDisabledState = stateProperties24;
            stateProperties25.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sealTextBox2.OnHoverState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.Gray;
            stateProperties26.FillColor = System.Drawing.Color.White;
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sealTextBox2.OnIdleState = stateProperties26;
            this.sealTextBox2.PasswordChar = '\0';
            this.sealTextBox2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.sealTextBox2.PlaceholderText = "";
            this.sealTextBox2.ReadOnly = false;
            this.sealTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sealTextBox2.SelectedText = "";
            this.sealTextBox2.SelectionLength = 0;
            this.sealTextBox2.SelectionStart = 0;
            this.sealTextBox2.ShortcutsEnabled = true;
            this.sealTextBox2.Size = new System.Drawing.Size(137, 25);
            this.sealTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.sealTextBox2.TabIndex = 202;
            this.sealTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sealTextBox2.TextMarginBottom = 0;
            this.sealTextBox2.TextMarginLeft = 5;
            this.sealTextBox2.TextMarginTop = 0;
            this.sealTextBox2.TextPlaceholder = "";
            this.sealTextBox2.UseSystemPasswordChar = false;
            this.sealTextBox2.WordWrap = true;
            // 
            // ssLineDropdown
            // 
            this.ssLineDropdown.BackColor = System.Drawing.Color.White;
            this.ssLineDropdown.BorderRadius = 3;
            this.ssLineDropdown.Color = System.Drawing.Color.Teal;
            this.ssLineDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ssLineDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.ssLineDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ssLineDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ssLineDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssLineDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ssLineDropdown.FillDropDown = false;
            this.ssLineDropdown.FillIndicator = true;
            this.ssLineDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssLineDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssLineDropdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ssLineDropdown.FormattingEnabled = true;
            this.ssLineDropdown.Icon = null;
            this.ssLineDropdown.IndicatorColor = System.Drawing.Color.Teal;
            this.ssLineDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ssLineDropdown.ItemBackColor = System.Drawing.Color.White;
            this.ssLineDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.ssLineDropdown.ItemForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ssLineDropdown.ItemHeight = 20;
            this.ssLineDropdown.ItemHighLightColor = System.Drawing.Color.Gray;
            this.ssLineDropdown.Location = new System.Drawing.Point(106, 146);
            this.ssLineDropdown.MaxDropDownItems = 50;
            this.ssLineDropdown.Name = "ssLineDropdown";
            this.ssLineDropdown.Size = new System.Drawing.Size(284, 26);
            this.ssLineDropdown.TabIndex = 201;
            this.ssLineDropdown.Text = null;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(24, 417);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(70, 20);
            this.Label22.TabIndex = 199;
            this.Label22.Text = "Cargo W:";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(51, 451);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(52, 20);
            this.Label21.TabIndex = 198;
            this.Label21.Text = "Vessel:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(66, 310);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(40, 20);
            this.Label20.TabIndex = 197;
            this.Label20.Text = "ERD:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(67, 339);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(39, 20);
            this.Label19.TabIndex = 196;
            this.Label19.Text = "LRD:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(50, 478);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(53, 20);
            this.Label18.TabIndex = 195;
            this.Label18.Text = "Seal #:";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(51, 532);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(52, 20);
            this.Label17.TabIndex = 194;
            this.Label17.Text = "Driver:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(56, 507);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(46, 20);
            this.Label16.TabIndex = 193;
            this.Label16.Text = "Truck:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(41, 174);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(56, 20);
            this.Label15.TabIndex = 192;
            this.Label15.Text = "Carrier:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(32, 364);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(64, 20);
            this.Label14.TabIndex = 191;
            this.Label14.Text = "TARE W:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(17, 391);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(76, 20);
            this.Label13.TabIndex = 190;
            this.Label13.Text = "GROSS W:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(40, 147);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(59, 20);
            this.Label12.TabIndex = 189;
            this.Label12.Text = "SS Line:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(22, 120);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(77, 20);
            this.Label11.TabIndex = 188;
            this.Label11.Text = "Condition:";
            // 
            // Label10
            // 
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(45, 200);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 23);
            this.Label10.TabIndex = 187;
            this.Label10.Text = "P/U:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(67, 64);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(39, 20);
            this.Label9.TabIndex = 186;
            this.Label9.Text = "Size:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(51, 91);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 20);
            this.Label7.TabIndex = 185;
            this.Label7.Text = "Status:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(57, 285);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(45, 20);
            this.Label6.TabIndex = 184;
            this.Label6.Text = "Time:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(62, 255);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 20);
            this.Label5.TabIndex = 183;
            this.Label5.Text = "Date:";
            // 
            // _CrystalReportViewer1
            // 
            this._CrystalReportViewer1.ActiveViewIndex = 0;
            this._CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this._CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this._CrystalReportViewer1.Location = new System.Drawing.Point(468, 41);
            this._CrystalReportViewer1.Name = "_CrystalReportViewer1";
         //   this._CrystalReportViewer1.ReportSource = this.CrystalReportReceipt1;
            this._CrystalReportViewer1.Size = new System.Drawing.Size(1176, 817);
            this._CrystalReportViewer1.TabIndex = 171;
            this._CrystalReportViewer1.PageChanged += new System.EventHandler(this.CrystalReportViewer1_PageChanged);
            // 
            // CrystalTruckingReport1
            // 
            this.CrystalTruckingReport1.FileName = "rassdk://C:\\Users\\vania\\AppData\\Local\\Temp\\temp_6a5f1261-6745-495e-8ece-7ffb263b0" +
    "29c.rpt";
            // 
            // FrmReceiptsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1644, 858);
            this.Controls.Add(this.manEntryPanel);
            this.Controls.Add(this._CrystalReportViewer1);
            this.Controls.Add(this._closeFlatButton);
            this.Controls.Add(this.Label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReceiptsReport";
            this.Text = "FrmReceiptsIn";
            this.Load += new System.EventHandler(this.FrmReceiptsReport_Load);
            this.manEntryPanel.ResumeLayout(false);
            this.manEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareNumericUpDown)).EndInit();
            this.ResumeLayout(false);

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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer _CrystalReportViewer1;

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CrystalReportViewer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CrystalReportViewer1 != null)
                {
                    _CrystalReportViewer1.PageChanged -= CrystalReportViewer1_PageChanged;
                }

                _CrystalReportViewer1 = value;
                if (_CrystalReportViewer1 != null)
                {
                    _CrystalReportViewer1.PageChanged += CrystalReportViewer1_PageChanged;
                }
            }
        }

        internal Label bkngLabel;
        internal Panel manEntryPanel;
        internal Label Label23;
        internal Label Label22;
        internal Label Label21;
        internal Label Label20;
        internal Label Label19;
        internal Label Label18;
        internal Label Label17;
        internal Label Label16;
        internal Label Label15;
        internal Label Label14;
        internal Label Label13;
        internal Label Label12;
        internal Label Label11;
        internal Label Label10;
        internal Label Label9;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Bunifu.UI.WinForms.BunifuDropdown ssLineDropdown;
        internal BunifuTextBox sealTextBox2;
        internal Bunifu.UI.WinForms.BunifuDropdown pickUpDropOffDropdown;
        internal Bunifu.UI.WinForms.BunifuDropdown carrierDropdown;
        internal Bunifu.UI.WinForms.BunifuDropdown driverDropdown;
        internal Bunifu.UI.WinForms.BunifuDropdown truckDropdown;
        internal BunifuTextBox commentsTextBox;
        internal Bunifu.UI.WinForms.BunifuDropdown conditionDropdown;
        internal Bunifu.UI.WinForms.BunifuDropdown statusDropdown;
        internal Bunifu.UI.WinForms.BunifuDropdown sizeDropdown;
        internal BunifuTextBox vesselTextBox;
        internal NumericUpDown cargoNumericUpDown;
        internal NumericUpDown grossNumericUpDown;
        internal NumericUpDown tareNumericUpDown;
        internal DateTimePicker lrdDatePicker;
        internal DateTimePicker erdDatePicker;
        internal DateTimePicker timePicker;
        internal DateTimePicker datePicker;
        internal BunifuTextBox contNumbTextBox;
        internal Label Label24;
        internal Bunifu.UI.WinForms.BunifuDropdown shipToDropdown;
        internal Label Label25;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _applyChangesButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton applyChangesButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _applyChangesButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_applyChangesButton != null)
                {
                    _applyChangesButton.Click -= applyChangesButton_Click;
                }

                _applyChangesButton = value;
                if (_applyChangesButton != null)
                {
                    _applyChangesButton.Click += applyChangesButton_Click;
                }
            }
        }

        internal BunifuTextBox destinationTextBox;
        private Label _Label26;

        internal Label Label26
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label26;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label26 != null)
                {
                    _Label26.Click -= Label26_Click;
                }

                _Label26 = value;
                if (_Label26 != null)
                {
                    _Label26.Click += Label26_Click;
                }
            }
        }

        internal BunifuTextBox bkgRelTextBox;

        private Billing.CrystalTruckingReport CrystalTruckingReport1;
      //  private Reports.CrystalReportReceipt CrystalReportReceipt1;
    }
}