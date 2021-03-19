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
    public partial class FrmAddNewEntry : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewEntry));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Label6 = new Label();
            editEntryTitleLabel = new Label();
            newEntrymodifiedByTextBox = new TextBox();
            Label3 = new Label();
            _newEntryclockOutTimePicker = new DateTimePicker();
            _newEntryclockOutTimePicker.ValueChanged += new EventHandler(newEntryclockOutTimePicker_ValueChanged);
            _newEntryclockInTimePicker = new DateTimePicker();
            _newEntryclockInTimePicker.ValueChanged += new EventHandler(newEntryclockInTimePicker_ValueChanged);
            Label2 = new Label();
            Label1 = new Label();
            Label5 = new Label();
            newEntryDatePicker = new DateTimePicker();
            Label8 = new Label();
            Label9 = new Label();
            clockOutPanel = new Panel();
            _clockOutCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _clockOutCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(clockOutCheckBox_CheckedChanged);
            RichTextBox1 = new RichTextBox();
            Panel1 = new Panel();
            Label10 = new Label();
            Panel2 = new Panel();
            workDoneListView = new ListView();
            Label11 = new Label();
            Label12 = new Label();
            _closeLabel = new Label();
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_MouseLeave);
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            _createNewEntryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _createNewEntryButton.Click += new EventHandler(createNewEntryButton_Click);
            _shiftTypeComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _shiftTypeComboBox.SelectedIndexChanged += new EventHandler(shiftTypeComboBox_SelectedIndexChanged);
            siteLocationComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _clockInCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _clockInCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(clockInCheckBox_CheckedChanged);
            _reasonNewEntryComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _reasonNewEntryComboBox.SelectedIndexChanged += new EventHandler(reasonNewEntryComboBox_SelectedIndexChanged);
            Panel4 = new Panel();
            _createEntyDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            _createEntyDataGrid.SelectionChanged += new EventHandler(createEntyEmployeesListView_SelectedIndexChanged);
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            _findEmployee = new BunifuTextBox();
            _findEmployee.TextChanged += new EventHandler(BunifuTextBox1_TextChanged);
            warningLabel = new Label();
            clockOutPanel.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_createEntyDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.Maroon;
            Label6.Location = new Point(3, 698);
            Label6.Name = "Label6";
            Label6.Size = new Size(156, 25);
            Label6.TabIndex = 26;
            Label6.Text = "* Madatory fields";
            // 
            // editEntryTitleLabel
            // 
            editEntryTitleLabel.BackColor = Color.White;
            editEntryTitleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            editEntryTitleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            editEntryTitleLabel.Location = new Point(35, 66);
            editEntryTitleLabel.Name = "editEntryTitleLabel";
            editEntryTitleLabel.Padding = new Padding(20, 0, 20, 0);
            editEntryTitleLabel.Size = new Size(619, 37);
            editEntryTitleLabel.TabIndex = 25;
            editEntryTitleLabel.Text = "Select employee and entries to be created";
            editEntryTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // newEntrymodifiedByTextBox
            // 
            newEntrymodifiedByTextBox.BackColor = Color.White;
            newEntrymodifiedByTextBox.BorderStyle = BorderStyle.None;
            newEntrymodifiedByTextBox.CharacterCasing = CharacterCasing.Upper;
            newEntrymodifiedByTextBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            newEntrymodifiedByTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            newEntrymodifiedByTextBox.Location = new Point(213, 699);
            newEntrymodifiedByTextBox.Name = "newEntrymodifiedByTextBox";
            newEntrymodifiedByTextBox.ReadOnly = true;
            newEntrymodifiedByTextBox.Size = new Size(333, 24);
            newEntrymodifiedByTextBox.TabIndex = 24;
            newEntrymodifiedByTextBox.Visible = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(99, 496);
            Label3.Name = "Label3";
            Label3.Size = new Size(89, 25);
            Label3.TabIndex = 22;
            Label3.Text = "* Reason:";
            // 
            // newEntryclockOutTimePicker
            // 
            _newEntryclockOutTimePicker.Anchor = AnchorStyles.None;
            _newEntryclockOutTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _newEntryclockOutTimePicker.CustomFormat = "";
            _newEntryclockOutTimePicker.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _newEntryclockOutTimePicker.Format = DateTimePickerFormat.Time;
            _newEntryclockOutTimePicker.Location = new Point(139, 1);
            _newEntryclockOutTimePicker.Name = "_newEntryclockOutTimePicker";
            _newEntryclockOutTimePicker.ShowUpDown = true;
            _newEntryclockOutTimePicker.Size = new Size(167, 32);
            _newEntryclockOutTimePicker.TabIndex = 18;
            _newEntryclockOutTimePicker.Visible = false;
            // 
            // newEntryclockInTimePicker
            // 
            _newEntryclockInTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _newEntryclockInTimePicker.CustomFormat = "";
            _newEntryclockInTimePicker.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _newEntryclockInTimePicker.Format = DateTimePickerFormat.Time;
            _newEntryclockInTimePicker.Location = new Point(235, 397);
            _newEntryclockInTimePicker.Name = "_newEntryclockInTimePicker";
            _newEntryclockInTimePicker.ShowUpDown = true;
            _newEntryclockInTimePicker.Size = new Size(167, 32);
            _newEntryclockInTimePicker.TabIndex = 17;
            _newEntryclockInTimePicker.Visible = false;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(37, 6);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 25);
            Label2.TabIndex = 16;
            Label2.Text = "Clock out:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(146, 400);
            Label1.Name = "Label1";
            Label1.Size = new Size(83, 25);
            Label1.TabIndex = 15;
            Label1.Text = "Clock in:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(173, 364);
            Label5.Name = "Label5";
            Label5.Size = new Size(55, 25);
            Label5.TabIndex = 29;
            Label5.Text = "Date:";
            // 
            // newEntryDatePicker
            // 
            newEntryDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            newEntryDatePicker.CustomFormat = "";
            newEntryDatePicker.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            newEntryDatePicker.Format = DateTimePickerFormat.Short;
            newEntryDatePicker.Location = new Point(234, 359);
            newEntryDatePicker.Name = "newEntryDatePicker";
            newEntryDatePicker.Size = new Size(168, 32);
            newEntryDatePicker.TabIndex = 30;
            newEntryDatePicker.Value = new DateTime(2019, 9, 26, 0, 0, 0, 0);
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(459, 366);
            Label8.Name = "Label8";
            Label8.Size = new Size(111, 25);
            Label8.TabIndex = 34;
            Label8.Text = "* Shift Type:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(435, 408);
            Label9.Name = "Label9";
            Label9.Size = new Size(137, 25);
            Label9.TabIndex = 36;
            Label9.Text = "* Site Location:";
            // 
            // clockOutPanel
            // 
            clockOutPanel.Controls.Add(_clockOutCheckBox);
            clockOutPanel.Controls.Add(_newEntryclockOutTimePicker);
            clockOutPanel.Controls.Add(Label2);
            clockOutPanel.Location = new Point(96, 434);
            clockOutPanel.Name = "clockOutPanel";
            clockOutPanel.Size = new Size(324, 43);
            clockOutPanel.TabIndex = 38;
            clockOutPanel.Visible = false;
            // 
            // clockOutCheckBox
            // 
            _clockOutCheckBox.AllowBindingControlAnimation = true;
            _clockOutCheckBox.AllowBindingControlColorChanges = false;
            _clockOutCheckBox.AllowBindingControlLocation = true;
            _clockOutCheckBox.AllowCheckBoxAnimation = false;
            _clockOutCheckBox.AllowCheckmarkAnimation = true;
            _clockOutCheckBox.AllowOnHoverStates = true;
            _clockOutCheckBox.AutoCheck = true;
            _clockOutCheckBox.BackColor = Color.Transparent;
            _clockOutCheckBox.BackgroundImage = (Image)resources.GetObject("clockOutCheckBox.BackgroundImage");
            _clockOutCheckBox.BackgroundImageLayout = ImageLayout.Zoom;
            _clockOutCheckBox.BindingControl = null;
            _clockOutCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _clockOutCheckBox.Checked = false;
            _clockOutCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            _clockOutCheckBox.Cursor = Cursors.Hand;
            _clockOutCheckBox.CustomCheckmarkImage = null;
            _clockOutCheckBox.Location = new Point(6, 6);
            _clockOutCheckBox.MinimumSize = new Size(20, 20);
            _clockOutCheckBox.Name = "_clockOutCheckBox";
            _clockOutCheckBox.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockOutCheckBox.OnCheck.BorderRadius = 2;
            _clockOutCheckBox.OnCheck.BorderThickness = 2;
            _clockOutCheckBox.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockOutCheckBox.OnCheck.CheckmarkColor = Color.White;
            _clockOutCheckBox.OnCheck.CheckmarkThickness = 2;
            _clockOutCheckBox.OnDisable.BorderColor = Color.LightGray;
            _clockOutCheckBox.OnDisable.BorderRadius = 2;
            _clockOutCheckBox.OnDisable.BorderThickness = 2;
            _clockOutCheckBox.OnDisable.CheckBoxColor = Color.Transparent;
            _clockOutCheckBox.OnDisable.CheckmarkColor = Color.LightGray;
            _clockOutCheckBox.OnDisable.CheckmarkThickness = 2;
            _clockOutCheckBox.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockOutCheckBox.OnHoverChecked.BorderRadius = 2;
            _clockOutCheckBox.OnHoverChecked.BorderThickness = 2;
            _clockOutCheckBox.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockOutCheckBox.OnHoverChecked.CheckmarkColor = Color.White;
            _clockOutCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            _clockOutCheckBox.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockOutCheckBox.OnHoverUnchecked.BorderRadius = 2;
            _clockOutCheckBox.OnHoverUnchecked.BorderThickness = 2;
            _clockOutCheckBox.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _clockOutCheckBox.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockOutCheckBox.OnUncheck.BorderRadius = 2;
            _clockOutCheckBox.OnUncheck.BorderThickness = 2;
            _clockOutCheckBox.OnUncheck.CheckBoxColor = Color.Transparent;
            _clockOutCheckBox.Size = new Size(25, 25);
            _clockOutCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _clockOutCheckBox.TabIndex = 109;
            _clockOutCheckBox.ThreeState = false;
            _clockOutCheckBox.ToolTipText = null;
            // 
            // RichTextBox1
            // 
            RichTextBox1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RichTextBox1.Location = new Point(128, 2);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(541, 92);
            RichTextBox1.TabIndex = 41;
            RichTextBox1.Text = "";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label10);
            Panel1.Controls.Add(RichTextBox1);
            Panel1.Location = new Point(66, 537);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(679, 104);
            Panel1.TabIndex = 39;
            Panel1.Visible = false;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.None;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(32, 4);
            Label10.Name = "Label10";
            Label10.Size = new Size(86, 25);
            Label10.TabIndex = 16;
            Label10.Text = "* Details:";
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Transparent;
            Panel2.Controls.Add(workDoneListView);
            Panel2.Controls.Add(Label11);
            Panel2.Location = new Point(779, 358);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(242, 283);
            Panel2.TabIndex = 43;
            Panel2.Visible = false;
            // 
            // workDoneListView
            // 
            workDoneListView.AllowColumnReorder = true;
            workDoneListView.CheckBoxes = true;
            workDoneListView.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            workDoneListView.FullRowSelect = true;
            workDoneListView.HeaderStyle = ColumnHeaderStyle.None;
            workDoneListView.HideSelection = false;
            workDoneListView.Location = new Point(21, 27);
            workDoneListView.MultiSelect = false;
            workDoneListView.Name = "workDoneListView";
            workDoneListView.Size = new Size(197, 253);
            workDoneListView.TabIndex = 17;
            workDoneListView.UseCompatibleStateImageBehavior = false;
            workDoneListView.View = View.Details;
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.None;
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(16, 1);
            Label11.Name = "Label11";
            Label11.Size = new Size(174, 25);
            Label11.TabIndex = 16;
            Label11.Text = "* Work Description:";
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(1056, 46);
            Label12.TabIndex = 73;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1008, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 46);
            _closeLabel.TabIndex = 74;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges1;
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
            _cancelButton.Location = new Point(903, 657);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(103, 45);
            _cancelButton.TabIndex = 76;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // createNewEntryButton
            // 
            _createNewEntryButton.AllowToggling = false;
            _createNewEntryButton.AnimationSpeed = 200;
            _createNewEntryButton.AutoGenerateColors = false;
            _createNewEntryButton.BackColor = Color.Transparent;
            _createNewEntryButton.BackColor1 = Color.Teal;
            _createNewEntryButton.BackgroundImage = (Image)resources.GetObject("createNewEntryButton.BackgroundImage");
            _createNewEntryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _createNewEntryButton.ButtonText = "Create Entry";
            _createNewEntryButton.ButtonTextMarginLeft = 0;
            _createNewEntryButton.ColorContrastOnClick = 45;
            _createNewEntryButton.ColorContrastOnHover = 45;
            _createNewEntryButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _createNewEntryButton.CustomizableEdges = BorderEdges2;
            _createNewEntryButton.DialogResult = DialogResult.None;
            _createNewEntryButton.DisabledBorderColor = Color.Empty;
            _createNewEntryButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _createNewEntryButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _createNewEntryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _createNewEntryButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createNewEntryButton.ForeColor = Color.White;
            _createNewEntryButton.IconLeftCursor = Cursors.Hand;
            _createNewEntryButton.IconMarginLeft = 11;
            _createNewEntryButton.IconPadding = 10;
            _createNewEntryButton.IconRightCursor = Cursors.Hand;
            _createNewEntryButton.IdleBorderColor = Color.Teal;
            _createNewEntryButton.IdleBorderRadius = 3;
            _createNewEntryButton.IdleBorderThickness = 1;
            _createNewEntryButton.IdleFillColor = Color.Teal;
            _createNewEntryButton.IdleIconLeftImage = null;
            _createNewEntryButton.IdleIconRightImage = null;
            _createNewEntryButton.IndicateFocus = true;
            _createNewEntryButton.Location = new Point(752, 657);
            _createNewEntryButton.Name = "_createNewEntryButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _createNewEntryButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _createNewEntryButton.OnPressedState = StateProperties4;
            _createNewEntryButton.Size = new Size(128, 45);
            _createNewEntryButton.TabIndex = 75;
            _createNewEntryButton.TextAlign = ContentAlignment.MiddleCenter;
            _createNewEntryButton.TextMarginLeft = 0;
            _createNewEntryButton.UseDefaultRadiusAndThickness = true;
            // 
            // shiftTypeComboBox
            // 
            _shiftTypeComboBox.BackColor = Color.White;
            _shiftTypeComboBox.BorderRadius = 3;
            _shiftTypeComboBox.Color = Color.Teal;
            _shiftTypeComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _shiftTypeComboBox.DisabledColor = Color.Gray;
            _shiftTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _shiftTypeComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _shiftTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _shiftTypeComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _shiftTypeComboBox.FillDropDown = false;
            _shiftTypeComboBox.FillIndicator = true;
            _shiftTypeComboBox.FlatStyle = FlatStyle.Flat;
            _shiftTypeComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _shiftTypeComboBox.ForeColor = SystemColors.ControlDarkDark;
            _shiftTypeComboBox.FormattingEnabled = true;
            _shiftTypeComboBox.Icon = null;
            _shiftTypeComboBox.IndicatorColor = Color.Teal;
            _shiftTypeComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _shiftTypeComboBox.ItemBackColor = Color.White;
            _shiftTypeComboBox.ItemBorderColor = Color.White;
            _shiftTypeComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _shiftTypeComboBox.ItemHeight = 28;
            _shiftTypeComboBox.ItemHighLightColor = Color.Gray;
            _shiftTypeComboBox.Items.AddRange(new object[] { "Hourly", "Salary", "Piece Work" });
            _shiftTypeComboBox.Location = new Point(576, 363);
            _shiftTypeComboBox.MaxDropDownItems = 50;
            _shiftTypeComboBox.Name = "_shiftTypeComboBox";
            _shiftTypeComboBox.Size = new Size(195, 34);
            _shiftTypeComboBox.TabIndex = 106;
            _shiftTypeComboBox.Text = null;
            // 
            // siteLocationComboBox
            // 
            siteLocationComboBox.BackColor = Color.White;
            siteLocationComboBox.BorderRadius = 3;
            siteLocationComboBox.Color = Color.Teal;
            siteLocationComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            siteLocationComboBox.DisabledColor = Color.Gray;
            siteLocationComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            siteLocationComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            siteLocationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            siteLocationComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            siteLocationComboBox.FillDropDown = false;
            siteLocationComboBox.FillIndicator = true;
            siteLocationComboBox.FlatStyle = FlatStyle.Flat;
            siteLocationComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            siteLocationComboBox.ForeColor = SystemColors.ControlDarkDark;
            siteLocationComboBox.FormattingEnabled = true;
            siteLocationComboBox.Icon = null;
            siteLocationComboBox.IndicatorColor = Color.Teal;
            siteLocationComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            siteLocationComboBox.ItemBackColor = Color.White;
            siteLocationComboBox.ItemBorderColor = Color.White;
            siteLocationComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            siteLocationComboBox.ItemHeight = 28;
            siteLocationComboBox.ItemHighLightColor = Color.Gray;
            siteLocationComboBox.Items.AddRange(new object[] { "Ewen", "Lindsey", "Remote" });
            siteLocationComboBox.Location = new Point(576, 403);
            siteLocationComboBox.MaxDropDownItems = 50;
            siteLocationComboBox.Name = "siteLocationComboBox";
            siteLocationComboBox.Size = new Size(195, 34);
            siteLocationComboBox.TabIndex = 107;
            siteLocationComboBox.Text = null;
            // 
            // clockInCheckBox
            // 
            _clockInCheckBox.AllowBindingControlAnimation = true;
            _clockInCheckBox.AllowBindingControlColorChanges = false;
            _clockInCheckBox.AllowBindingControlLocation = true;
            _clockInCheckBox.AllowCheckBoxAnimation = false;
            _clockInCheckBox.AllowCheckmarkAnimation = true;
            _clockInCheckBox.AllowOnHoverStates = true;
            _clockInCheckBox.AutoCheck = true;
            _clockInCheckBox.BackColor = Color.Transparent;
            _clockInCheckBox.BackgroundImage = (Image)resources.GetObject("clockInCheckBox.BackgroundImage");
            _clockInCheckBox.BackgroundImageLayout = ImageLayout.Zoom;
            _clockInCheckBox.BindingControl = null;
            _clockInCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _clockInCheckBox.Checked = false;
            _clockInCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            _clockInCheckBox.Cursor = Cursors.Hand;
            _clockInCheckBox.CustomCheckmarkImage = null;
            _clockInCheckBox.Location = new Point(102, 400);
            _clockInCheckBox.MinimumSize = new Size(20, 20);
            _clockInCheckBox.Name = "_clockInCheckBox";
            _clockInCheckBox.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockInCheckBox.OnCheck.BorderRadius = 2;
            _clockInCheckBox.OnCheck.BorderThickness = 2;
            _clockInCheckBox.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockInCheckBox.OnCheck.CheckmarkColor = Color.White;
            _clockInCheckBox.OnCheck.CheckmarkThickness = 2;
            _clockInCheckBox.OnDisable.BorderColor = Color.LightGray;
            _clockInCheckBox.OnDisable.BorderRadius = 2;
            _clockInCheckBox.OnDisable.BorderThickness = 2;
            _clockInCheckBox.OnDisable.CheckBoxColor = Color.Transparent;
            _clockInCheckBox.OnDisable.CheckmarkColor = Color.LightGray;
            _clockInCheckBox.OnDisable.CheckmarkThickness = 2;
            _clockInCheckBox.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockInCheckBox.OnHoverChecked.BorderRadius = 2;
            _clockInCheckBox.OnHoverChecked.BorderThickness = 2;
            _clockInCheckBox.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockInCheckBox.OnHoverChecked.CheckmarkColor = Color.White;
            _clockInCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            _clockInCheckBox.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockInCheckBox.OnHoverUnchecked.BorderRadius = 2;
            _clockInCheckBox.OnHoverUnchecked.BorderThickness = 2;
            _clockInCheckBox.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _clockInCheckBox.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _clockInCheckBox.OnUncheck.BorderRadius = 2;
            _clockInCheckBox.OnUncheck.BorderThickness = 2;
            _clockInCheckBox.OnUncheck.CheckBoxColor = Color.Transparent;
            _clockInCheckBox.Size = new Size(25, 25);
            _clockInCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _clockInCheckBox.TabIndex = 108;
            _clockInCheckBox.ThreeState = false;
            _clockInCheckBox.ToolTipText = null;
            // 
            // reasonNewEntryComboBox
            // 
            _reasonNewEntryComboBox.BackColor = Color.White;
            _reasonNewEntryComboBox.BorderRadius = 3;
            _reasonNewEntryComboBox.Color = Color.Teal;
            _reasonNewEntryComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _reasonNewEntryComboBox.DisabledColor = Color.Gray;
            _reasonNewEntryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _reasonNewEntryComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _reasonNewEntryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _reasonNewEntryComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _reasonNewEntryComboBox.FillDropDown = false;
            _reasonNewEntryComboBox.FillIndicator = true;
            _reasonNewEntryComboBox.FlatStyle = FlatStyle.Flat;
            _reasonNewEntryComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _reasonNewEntryComboBox.ForeColor = SystemColors.ControlDarkDark;
            _reasonNewEntryComboBox.FormattingEnabled = true;
            _reasonNewEntryComboBox.Icon = null;
            _reasonNewEntryComboBox.IndicatorColor = Color.Teal;
            _reasonNewEntryComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _reasonNewEntryComboBox.ItemBackColor = Color.White;
            _reasonNewEntryComboBox.ItemBorderColor = Color.White;
            _reasonNewEntryComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _reasonNewEntryComboBox.ItemHeight = 28;
            _reasonNewEntryComboBox.ItemHighLightColor = Color.Gray;
            _reasonNewEntryComboBox.Items.AddRange(new object[] { "Employee forgot to clock in/out", "Employee forgot card ID", "System prevented clock in (Employee forgot clock out last shift).", "System Error", "Working Remotely", "Other" });
            _reasonNewEntryComboBox.Location = new Point(194, 493);
            _reasonNewEntryComboBox.MaxDropDownItems = 50;
            _reasonNewEntryComboBox.Name = "_reasonNewEntryComboBox";
            _reasonNewEntryComboBox.Size = new Size(572, 34);
            _reasonNewEntryComboBox.TabIndex = 109;
            _reasonNewEntryComboBox.Text = null;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.Top;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_createEntyDataGrid);
            Panel4.Location = new Point(143, 132);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(784, 213);
            Panel4.TabIndex = 110;
            // 
            // createEntyDataGrid
            // 
            _createEntyDataGrid.AllowCustomTheming = true;
            _createEntyDataGrid.AllowUserToAddRows = false;
            _createEntyDataGrid.AllowUserToDeleteRows = false;
            _createEntyDataGrid.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _createEntyDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _createEntyDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _createEntyDataGrid.BackgroundColor = Color.White;
            _createEntyDataGrid.BorderStyle = BorderStyle.None;
            _createEntyDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _createEntyDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _createEntyDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _createEntyDataGrid.ColumnHeadersHeight = 40;
            _createEntyDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column4, Column14 });
            _createEntyDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _createEntyDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _createEntyDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _createEntyDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _createEntyDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _createEntyDataGrid.CurrentTheme.BackColor = Color.Snow;
            _createEntyDataGrid.CurrentTheme.GridColor = Color.Gray;
            _createEntyDataGrid.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _createEntyDataGrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _createEntyDataGrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _createEntyDataGrid.CurrentTheme.Name = null;
            _createEntyDataGrid.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _createEntyDataGrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _createEntyDataGrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _createEntyDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _createEntyDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle4.SelectionForeColor = Color.Black;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            _createEntyDataGrid.DefaultCellStyle = DataGridViewCellStyle4;
            _createEntyDataGrid.Dock = DockStyle.Fill;
            _createEntyDataGrid.EnableHeadersVisualStyles = false;
            _createEntyDataGrid.GridColor = Color.Gray;
            _createEntyDataGrid.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _createEntyDataGrid.HeaderBgColor = Color.Empty;
            _createEntyDataGrid.HeaderForeColor = Color.White;
            _createEntyDataGrid.Location = new Point(0, 0);
            _createEntyDataGrid.Name = "_createEntyDataGrid";
            _createEntyDataGrid.ReadOnly = true;
            _createEntyDataGrid.RowHeadersVisible = false;
            _createEntyDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _createEntyDataGrid.RowTemplate.Height = 40;
            _createEntyDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _createEntyDataGrid.Size = new Size(782, 211);
            _createEntyDataGrid.TabIndex = 57;
            _createEntyDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column6
            // 
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Column6.DefaultCellStyle = DataGridViewCellStyle3;
            Column6.FillWeight = 96.23104f;
            Column6.HeaderText = "Alias";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            // 
            // Column1
            // 
            Column1.FillWeight = 96.2751f;
            Column1.HeaderText = "First name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 95.74711f;
            Column2.HeaderText = "Last Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "ID";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column14
            // 
            Column14.HeaderText = "type";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Visible = false;
            // 
            // findEmployee
            // 
            _findEmployee.AcceptsReturn = false;
            _findEmployee.AcceptsTab = false;
            _findEmployee.AnimationSpeed = 200;
            _findEmployee.AutoCompleteMode = AutoCompleteMode.None;
            _findEmployee.AutoCompleteSource = AutoCompleteSource.None;
            _findEmployee.BackColor = Color.Transparent;
            _findEmployee.BackgroundImage = (Image)resources.GetObject("findEmployee.BackgroundImage");
            _findEmployee.BorderColorActive = Color.DodgerBlue;
            _findEmployee.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _findEmployee.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _findEmployee.BorderColorIdle = Color.Silver;
            _findEmployee.BorderRadius = 5;
            _findEmployee.BorderThickness = 1;
            _findEmployee.CharacterCasing = CharacterCasing.Normal;
            _findEmployee.Cursor = Cursors.IBeam;
            _findEmployee.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _findEmployee.DefaultText = "";
            _findEmployee.FillColor = Color.White;
            _findEmployee.HideSelection = true;
            _findEmployee.IconLeft = null;
            _findEmployee.IconLeftCursor = Cursors.IBeam;
            _findEmployee.IconPadding = 10;
            _findEmployee.IconRight = null;
            _findEmployee.IconRightCursor = Cursors.IBeam;
            _findEmployee.Lines = new string[0];
            _findEmployee.Location = new Point(655, 95);
            _findEmployee.MaxLength = 32767;
            _findEmployee.MinimumSize = new Size(100, 35);
            _findEmployee.Modified = false;
            _findEmployee.Multiline = false;
            _findEmployee.Name = "_findEmployee";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _findEmployee.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _findEmployee.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _findEmployee.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Empty;
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _findEmployee.OnIdleState = StateProperties8;
            _findEmployee.PasswordChar = '\0';
            _findEmployee.PlaceholderForeColor = Color.Silver;
            _findEmployee.PlaceholderText = "Search employee...";
            _findEmployee.ReadOnly = false;
            _findEmployee.ScrollBars = ScrollBars.None;
            _findEmployee.SelectedText = "";
            _findEmployee.SelectionLength = 0;
            _findEmployee.SelectionStart = 0;
            _findEmployee.ShortcutsEnabled = true;
            _findEmployee.Size = new Size(271, 35);
            _findEmployee.Style = _Style.Bunifu;
            _findEmployee.TabIndex = 112;
            _findEmployee.TextAlign = HorizontalAlignment.Left;
            _findEmployee.TextMarginBottom = 0;
            _findEmployee.TextMarginLeft = 5;
            _findEmployee.TextMarginTop = 0;
            _findEmployee.TextPlaceholder = "Search employee...";
            _findEmployee.UseSystemPasswordChar = false;
            _findEmployee.WordWrap = true;
            // 
            // warningLabel
            // 
            warningLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            warningLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.Maroon;
            warningLabel.Location = new Point(426, 440);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(340, 50);
            warningLabel.TabIndex = 113;
            warningLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmAddNewEntry
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 731);
            Controls.Add(warningLabel);
            Controls.Add(_findEmployee);
            Controls.Add(Panel4);
            Controls.Add(_reasonNewEntryComboBox);
            Controls.Add(_clockInCheckBox);
            Controls.Add(siteLocationComboBox);
            Controls.Add(_shiftTypeComboBox);
            Controls.Add(_cancelButton);
            Controls.Add(_createNewEntryButton);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(clockOutPanel);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(newEntryDatePicker);
            Controls.Add(Label5);
            Controls.Add(Label6);
            Controls.Add(editEntryTitleLabel);
            Controls.Add(newEntrymodifiedByTextBox);
            Controls.Add(Label3);
            Controls.Add(_newEntryclockInTimePicker);
            Controls.Add(Label1);
            ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddNewEntry";
            StartPosition = FormStartPosition.CenterParent;
            clockOutPanel.ResumeLayout(false);
            clockOutPanel.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_createEntyDataGrid).EndInit();
            Load += new EventHandler(FrmAddNewEntry_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label6;
        internal Label editEntryTitleLabel;
        internal TextBox newEntrymodifiedByTextBox;
        internal Label Label3;
        private DateTimePicker _newEntryclockOutTimePicker;

        internal DateTimePicker newEntryclockOutTimePicker
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _newEntryclockOutTimePicker;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_newEntryclockOutTimePicker != null)
                {
                    _newEntryclockOutTimePicker.ValueChanged -= newEntryclockOutTimePicker_ValueChanged;
                }

                _newEntryclockOutTimePicker = value;
                if (_newEntryclockOutTimePicker != null)
                {
                    _newEntryclockOutTimePicker.ValueChanged += newEntryclockOutTimePicker_ValueChanged;
                }
            }
        }

        private DateTimePicker _newEntryclockInTimePicker;

        internal DateTimePicker newEntryclockInTimePicker
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _newEntryclockInTimePicker;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_newEntryclockInTimePicker != null)
                {
                    _newEntryclockInTimePicker.ValueChanged -= newEntryclockInTimePicker_ValueChanged;
                }

                _newEntryclockInTimePicker = value;
                if (_newEntryclockInTimePicker != null)
                {
                    _newEntryclockInTimePicker.ValueChanged += newEntryclockInTimePicker_ValueChanged;
                }
            }
        }

        internal Label Label2;
        internal Label Label1;
        internal Label Label5;
        internal DateTimePicker newEntryDatePicker;
        internal Label Label8;
        internal Label Label9;
        internal Panel clockOutPanel;
        internal RichTextBox RichTextBox1;
        internal Panel Panel1;
        internal Label Label10;
        internal Panel Panel2;
        internal ListView workDoneListView;
        internal Label Label11;
        internal Label Label12;
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
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_MouseLeave;
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_MouseLeave;
                    _closeLabel.Click += closeLabel_Click;
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
                    _cancelButton.Click -= cancelButton_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += cancelButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _createNewEntryButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton createNewEntryButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createNewEntryButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createNewEntryButton != null)
                {
                    _createNewEntryButton.Click -= createNewEntryButton_Click;
                }

                _createNewEntryButton = value;
                if (_createNewEntryButton != null)
                {
                    _createNewEntryButton.Click += createNewEntryButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _shiftTypeComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown shiftTypeComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _shiftTypeComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_shiftTypeComboBox != null)
                {
                    _shiftTypeComboBox.SelectedIndexChanged -= shiftTypeComboBox_SelectedIndexChanged;
                }

                _shiftTypeComboBox = value;
                if (_shiftTypeComboBox != null)
                {
                    _shiftTypeComboBox.SelectedIndexChanged += shiftTypeComboBox_SelectedIndexChanged;
                }
            }
        }

        // Private Sub shiftTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

        // End Sub

        internal Bunifu.UI.WinForms.BunifuDropdown siteLocationComboBox;
        private Bunifu.UI.WinForms.BunifuCheckBox _clockOutCheckBox;

        internal Bunifu.UI.WinForms.BunifuCheckBox clockOutCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _clockOutCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_clockOutCheckBox != null)
                {
                    _clockOutCheckBox.CheckedChanged -= clockOutCheckBox_CheckedChanged;
                }

                _clockOutCheckBox = value;
                if (_clockOutCheckBox != null)
                {
                    _clockOutCheckBox.CheckedChanged += clockOutCheckBox_CheckedChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuCheckBox _clockInCheckBox;

        internal Bunifu.UI.WinForms.BunifuCheckBox clockInCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _clockInCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_clockInCheckBox != null)
                {
                    _clockInCheckBox.CheckedChanged -= clockInCheckBox_CheckedChanged;
                }

                _clockInCheckBox = value;
                if (_clockInCheckBox != null)
                {
                    _clockInCheckBox.CheckedChanged += clockInCheckBox_CheckedChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _reasonNewEntryComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown reasonNewEntryComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _reasonNewEntryComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_reasonNewEntryComboBox != null)
                {
                    _reasonNewEntryComboBox.SelectedIndexChanged -= reasonNewEntryComboBox_SelectedIndexChanged;
                }

                _reasonNewEntryComboBox = value;
                if (_reasonNewEntryComboBox != null)
                {
                    _reasonNewEntryComboBox.SelectedIndexChanged += reasonNewEntryComboBox_SelectedIndexChanged;
                }
            }
        }

        // Private Sub FrmAddNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        // End Sub

        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _createEntyDataGrid;

        public Bunifu.UI.WinForms.BunifuDataGridView createEntyDataGrid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createEntyDataGrid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createEntyDataGrid != null)
                {
                    _createEntyDataGrid.SelectionChanged -= createEntyEmployeesListView_SelectedIndexChanged;
                }

                _createEntyDataGrid = value;
                if (_createEntyDataGrid != null)
                {
                    _createEntyDataGrid.SelectionChanged += createEntyEmployeesListView_SelectedIndexChanged;
                }
            }
        }

        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column14;
        private BunifuTextBox _findEmployee;

        internal BunifuTextBox findEmployee
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _findEmployee;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_findEmployee != null)
                {
                    _findEmployee.TextChanged -= BunifuTextBox1_TextChanged;
                }

                _findEmployee = value;
                if (_findEmployee != null)
                {
                    _findEmployee.TextChanged += BunifuTextBox1_TextChanged;
                }
            }
        }

        internal Label warningLabel;
    }
}