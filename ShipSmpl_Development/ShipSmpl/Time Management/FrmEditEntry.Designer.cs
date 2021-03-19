using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEditEntry : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditEntry));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            clockInTimePicker = new DateTimePicker();
            clockOutTimePicker = new DateTimePicker();
            editEntryTitleLabel = new Label();
            clockInDateTimePicker = new DateTimePicker();
            clockoOutDateTimePicker = new DateTimePicker();
            warningLabel = new Label();
            _reasonNewEntryComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _reasonNewEntryComboBox.SelectedIndexChanged += new EventHandler(reasonNewEntryComboBox_SelectedIndexChanged);
            _clockInCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _clockInCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(CheckBox1_CheckedChanged);
            shiftTypeComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            Panel2 = new Panel();
            workDoneListView = new ListView();
            Label11 = new Label();
            Panel1 = new Panel();
            Label10 = new Label();
            RichTextBox1 = new RichTextBox();
            _clockOutCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _clockOutCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(clockOutCheckBox_CheckedChanged);
            Label3 = new Label();
            Label8 = new Label();
            Label6 = new Label();
            Label4 = new Label();
            Label7 = new Label();
            _closeLabel = new Label();
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_MouseLeave);
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            modifiedByTextBox = new Label();
            _createNewEntryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _createNewEntryButton.Click += new EventHandler(Button1_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            Panel2.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // clockInTimePicker
            // 
            clockInTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            clockInTimePicker.CustomFormat = "\"hh:mm\"";
            clockInTimePicker.Font = new Font("Microsoft Sans Serif", 14.25f);
            clockInTimePicker.Format = DateTimePickerFormat.Time;
            clockInTimePicker.Location = new Point(335, 142);
            clockInTimePicker.Name = "clockInTimePicker";
            clockInTimePicker.ShowUpDown = true;
            clockInTimePicker.Size = new Size(162, 32);
            clockInTimePicker.TabIndex = 2;
            clockInTimePicker.Visible = false;
            // 
            // clockOutTimePicker
            // 
            clockOutTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            clockOutTimePicker.CustomFormat = "\"hh:mm\"";
            clockOutTimePicker.Font = new Font("Microsoft Sans Serif", 14.25f);
            clockOutTimePicker.Format = DateTimePickerFormat.Time;
            clockOutTimePicker.Location = new Point(335, 181);
            clockOutTimePicker.Name = "clockOutTimePicker";
            clockOutTimePicker.ShowUpDown = true;
            clockOutTimePicker.Size = new Size(162, 32);
            clockOutTimePicker.TabIndex = 3;
            clockOutTimePicker.Visible = false;
            // 
            // editEntryTitleLabel
            // 
            editEntryTitleLabel.BackColor = Color.White;
            editEntryTitleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            editEntryTitleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            editEntryTitleLabel.Location = new Point(40, 57);
            editEntryTitleLabel.Name = "editEntryTitleLabel";
            editEntryTitleLabel.Padding = new Padding(20, 0, 20, 0);
            editEntryTitleLabel.Size = new Size(467, 36);
            editEntryTitleLabel.TabIndex = 11;
            editEntryTitleLabel.Text = "Check the fields to be modified";
            editEntryTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clockInDateTimePicker
            // 
            clockInDateTimePicker.Font = new Font("Microsoft Sans Serif", 14.25f);
            clockInDateTimePicker.Format = DateTimePickerFormat.Short;
            clockInDateTimePicker.Location = new Point(196, 142);
            clockInDateTimePicker.Name = "clockInDateTimePicker";
            clockInDateTimePicker.Size = new Size(133, 32);
            clockInDateTimePicker.TabIndex = 15;
            clockInDateTimePicker.Visible = false;
            // 
            // clockoOutDateTimePicker
            // 
            clockoOutDateTimePicker.Font = new Font("Microsoft Sans Serif", 14.25f);
            clockoOutDateTimePicker.Format = DateTimePickerFormat.Short;
            clockoOutDateTimePicker.Location = new Point(196, 181);
            clockoOutDateTimePicker.Name = "clockoOutDateTimePicker";
            clockoOutDateTimePicker.Size = new Size(133, 32);
            clockoOutDateTimePicker.TabIndex = 16;
            clockoOutDateTimePicker.Visible = false;
            // 
            // warningLabel
            // 
            warningLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            warningLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.Maroon;
            warningLabel.Location = new Point(503, 142);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(259, 82);
            warningLabel.TabIndex = 131;
            warningLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // reasonNewEntryComboBox
            // 
            _reasonNewEntryComboBox.BackColor = Color.Snow;
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
            _reasonNewEntryComboBox.Location = new Point(190, 227);
            _reasonNewEntryComboBox.MaxDropDownItems = 50;
            _reasonNewEntryComboBox.Name = "_reasonNewEntryComboBox";
            _reasonNewEntryComboBox.Size = new Size(551, 34);
            _reasonNewEntryComboBox.TabIndex = 130;
            _reasonNewEntryComboBox.Text = null;
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
            _clockInCheckBox.Location = new Point(63, 146);
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
            _clockInCheckBox.TabIndex = 129;
            _clockInCheckBox.ThreeState = false;
            _clockInCheckBox.ToolTipText = null;
            // 
            // shiftTypeComboBox
            // 
            shiftTypeComboBox.BackColor = Color.Snow;
            shiftTypeComboBox.BorderRadius = 3;
            shiftTypeComboBox.Color = Color.Teal;
            shiftTypeComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            shiftTypeComboBox.DisabledColor = Color.Gray;
            shiftTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            shiftTypeComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            shiftTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shiftTypeComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            shiftTypeComboBox.FillDropDown = false;
            shiftTypeComboBox.FillIndicator = true;
            shiftTypeComboBox.FlatStyle = FlatStyle.Flat;
            shiftTypeComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            shiftTypeComboBox.ForeColor = SystemColors.ControlDarkDark;
            shiftTypeComboBox.FormattingEnabled = true;
            shiftTypeComboBox.Icon = null;
            shiftTypeComboBox.IndicatorColor = Color.Teal;
            shiftTypeComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            shiftTypeComboBox.ItemBackColor = Color.White;
            shiftTypeComboBox.ItemBorderColor = Color.White;
            shiftTypeComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            shiftTypeComboBox.ItemHeight = 28;
            shiftTypeComboBox.ItemHighLightColor = Color.Gray;
            shiftTypeComboBox.Items.AddRange(new object[] { "Hourly", "Salary", "Piece Work" });
            shiftTypeComboBox.Location = new Point(190, 102);
            shiftTypeComboBox.MaxDropDownItems = 50;
            shiftTypeComboBox.Name = "shiftTypeComboBox";
            shiftTypeComboBox.Size = new Size(195, 34);
            shiftTypeComboBox.TabIndex = 127;
            shiftTypeComboBox.Text = null;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Transparent;
            Panel2.Controls.Add(workDoneListView);
            Panel2.Controls.Add(Label11);
            Panel2.Location = new Point(768, 92);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(224, 283);
            Panel2.TabIndex = 124;
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
            workDoneListView.Location = new Point(16, 27);
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
            Label11.Location = new Point(7, 1);
            Label11.Name = "Label11";
            Label11.Size = new Size(174, 25);
            Label11.TabIndex = 16;
            Label11.Text = "* Work Description:";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label10);
            Panel1.Controls.Add(RichTextBox1);
            Panel1.Location = new Point(62, 271);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(679, 104);
            Panel1.TabIndex = 123;
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
            // RichTextBox1
            // 
            RichTextBox1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RichTextBox1.Location = new Point(128, 2);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(541, 92);
            RichTextBox1.TabIndex = 41;
            RichTextBox1.Text = "";
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
            _clockOutCheckBox.Location = new Point(64, 187);
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
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(95, 187);
            Label3.Name = "Label3";
            Label3.Size = new Size(95, 25);
            Label3.TabIndex = 16;
            Label3.Text = "Clock out:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(73, 105);
            Label8.Name = "Label8";
            Label8.Size = new Size(111, 25);
            Label8.TabIndex = 120;
            Label8.Text = "* Shift Type:";
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.Maroon;
            Label6.Location = new Point(3, 432);
            Label6.Name = "Label6";
            Label6.Size = new Size(156, 25);
            Label6.TabIndex = 117;
            Label6.Text = "* Madatory fields";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(95, 230);
            Label4.Name = "Label4";
            Label4.Size = new Size(89, 25);
            Label4.TabIndex = 116;
            Label4.Text = "* Reason:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(107, 146);
            Label7.Name = "Label7";
            Label7.Size = new Size(83, 25);
            Label7.TabIndex = 114;
            Label7.Text = "Clock in:";
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1001, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 46);
            _closeLabel.TabIndex = 133;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(1049, 46);
            Label12.TabIndex = 132;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modifiedByTextBox
            // 
            modifiedByTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            modifiedByTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            modifiedByTextBox.ForeColor = Color.Maroon;
            modifiedByTextBox.Location = new Point(361, 432);
            modifiedByTextBox.Name = "modifiedByTextBox";
            modifiedByTextBox.Size = new Size(259, 25);
            modifiedByTextBox.TabIndex = 134;
            modifiedByTextBox.TextAlign = ContentAlignment.MiddleLeft;
            modifiedByTextBox.Visible = false;
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
            _createNewEntryButton.ButtonText = "Update Entry";
            _createNewEntryButton.ButtonTextMarginLeft = 0;
            _createNewEntryButton.ColorContrastOnClick = 45;
            _createNewEntryButton.ColorContrastOnHover = 45;
            _createNewEntryButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _createNewEntryButton.CustomizableEdges = BorderEdges1;
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
            _createNewEntryButton.Location = new Point(763, 402);
            _createNewEntryButton.Name = "_createNewEntryButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _createNewEntryButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _createNewEntryButton.OnPressedState = StateProperties2;
            _createNewEntryButton.Size = new Size(128, 45);
            _createNewEntryButton.TabIndex = 125;
            _createNewEntryButton.TextAlign = ContentAlignment.MiddleCenter;
            _createNewEntryButton.TextMarginLeft = 0;
            _createNewEntryButton.UseDefaultRadiusAndThickness = true;
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
            _cancelButton.Location = new Point(914, 402);
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
            _cancelButton.Size = new Size(103, 45);
            _cancelButton.TabIndex = 126;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmEditEntry
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1049, 466);
            ControlBox = false;
            Controls.Add(modifiedByTextBox);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            Controls.Add(_clockOutCheckBox);
            Controls.Add(warningLabel);
            Controls.Add(_reasonNewEntryComboBox);
            Controls.Add(Label3);
            Controls.Add(_clockInCheckBox);
            Controls.Add(shiftTypeComboBox);
            Controls.Add(_cancelButton);
            Controls.Add(_createNewEntryButton);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(Label8);
            Controls.Add(Label6);
            Controls.Add(Label4);
            Controls.Add(Label7);
            Controls.Add(clockoOutDateTimePicker);
            Controls.Add(clockInDateTimePicker);
            Controls.Add(editEntryTitleLabel);
            Controls.Add(clockOutTimePicker);
            Controls.Add(clockInTimePicker);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmEditEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(FrmEditEntry_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal DateTimePicker clockInTimePicker;
        internal DateTimePicker clockOutTimePicker;
        internal Label editEntryTitleLabel;
        internal DateTimePicker clockInDateTimePicker;
        internal DateTimePicker clockoOutDateTimePicker;

        // Private Sub reasonNewEntryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

        // End Sub

        internal Label warningLabel;
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
                    _clockInCheckBox.CheckedChanged -= CheckBox1_CheckedChanged;
                }

                _clockInCheckBox = value;
                if (_clockInCheckBox != null)
                {
                    _clockInCheckBox.CheckedChanged += CheckBox1_CheckedChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDropdown shiftTypeComboBox;
        internal Panel Panel2;
        internal ListView workDoneListView;
        internal Label Label11;
        internal Panel Panel1;
        internal Label Label10;
        internal RichTextBox RichTextBox1;
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

        internal Label Label3;
        internal Label Label8;
        internal Label Label6;
        internal Label Label4;
        internal Label Label7;
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

        internal Label Label12;
        internal Label modifiedByTextBox;
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
                    _createNewEntryButton.Click -= Button1_Click;
                }

                _createNewEntryButton = value;
                if (_createNewEntryButton != null)
                {
                    _createNewEntryButton.Click += Button1_Click;
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
    }
}