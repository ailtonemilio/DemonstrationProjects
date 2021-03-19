using System;
using System.Diagnostics;
using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmListContainers : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListContainers));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label1 = new Label();
            _ComboSSLineList = new Bunifu.UI.WinForms.BunifuDropdown();
            _ComboSSLineList.SelectedIndexChanged += new EventHandler(ComboSSLineList_SelectedIndexChanged);
            _TextSSLineListSearch = new BunifuTextBox();
            _TextSSLineListSearch.TextChanged += new EventHandler(BunifuTextBox1_TextChanged);
            _assignBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _assignBunifuButton.Click += new EventHandler(BunifuButton2_Click);
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Panel2 = new Panel();
            _ContainerList2 = new WTC_CeresControls.ContainerList();
            _ContainerList2.RemoveAssignment += new WTC_CeresControls.ContainerList.RemoveAssignmentEventHandler(ContainerList2_RemoveAssignment);
            _ContainerList2.ExportAsCSV += new WTC_CeresControls.ContainerList.ExportAsCSVEventHandler(ContainerList2_ExportAsCSV);
            _ContainerList2.ContainersSelected += new WTC_CeresControls.ContainerList.ContainersSelectedEventHandler(ContainerList2_ContainersSelected);
            Label2 = new Label();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(121, 64);
            Label1.Name = "Label1";
            Label1.Size = new Size(131, 25);
            Label1.TabIndex = 2;
            Label1.Text = "Shipping Line:";
            // 
            // ComboSSLineList
            // 
            _ComboSSLineList.Anchor = AnchorStyles.Top;
            _ComboSSLineList.BackColor = Color.White;
            _ComboSSLineList.BorderRadius = 3;
            _ComboSSLineList.Color = Color.Teal;
            _ComboSSLineList.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _ComboSSLineList.DisabledColor = Color.Gray;
            _ComboSSLineList.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboSSLineList.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _ComboSSLineList.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboSSLineList.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _ComboSSLineList.FillDropDown = false;
            _ComboSSLineList.FillIndicator = true;
            _ComboSSLineList.FlatStyle = FlatStyle.Flat;
            _ComboSSLineList.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _ComboSSLineList.ForeColor = SystemColors.ControlDarkDark;
            _ComboSSLineList.FormattingEnabled = true;
            _ComboSSLineList.Icon = null;
            _ComboSSLineList.IndicatorColor = Color.Teal;
            _ComboSSLineList.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _ComboSSLineList.ItemBackColor = Color.White;
            _ComboSSLineList.ItemBorderColor = Color.White;
            _ComboSSLineList.ItemForeColor = SystemColors.ControlDarkDark;
            _ComboSSLineList.ItemHeight = 28;
            _ComboSSLineList.ItemHighLightColor = Color.Gray;
            _ComboSSLineList.Location = new Point(253, 58);
            _ComboSSLineList.MaxDropDownItems = 50;
            _ComboSSLineList.Name = "_ComboSSLineList";
            _ComboSSLineList.Size = new Size(465, 34);
            _ComboSSLineList.TabIndex = 106;
            _ComboSSLineList.Text = null;
            // 
            // TextSSLineListSearch
            // 
            _TextSSLineListSearch.AcceptsReturn = false;
            _TextSSLineListSearch.AcceptsTab = false;
            _TextSSLineListSearch.Anchor = AnchorStyles.Top;
            _TextSSLineListSearch.AnimationSpeed = 200;
            _TextSSLineListSearch.AutoCompleteMode = AutoCompleteMode.None;
            _TextSSLineListSearch.AutoCompleteSource = AutoCompleteSource.None;
            _TextSSLineListSearch.BackColor = Color.Transparent;
            _TextSSLineListSearch.BackgroundImage = (Image)resources.GetObject("TextSSLineListSearch.BackgroundImage");
            _TextSSLineListSearch.BorderColorActive = Color.Teal;
            _TextSSLineListSearch.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _TextSSLineListSearch.BorderColorHover = Color.Teal;
            _TextSSLineListSearch.BorderColorIdle = Color.Gray;
            _TextSSLineListSearch.BorderRadius = 1;
            _TextSSLineListSearch.BorderThickness = 1;
            _TextSSLineListSearch.CharacterCasing = CharacterCasing.Normal;
            _TextSSLineListSearch.Cursor = Cursors.IBeam;
            _TextSSLineListSearch.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _TextSSLineListSearch.DefaultText = "";
            _TextSSLineListSearch.FillColor = Color.White;
            _TextSSLineListSearch.HideSelection = true;
            _TextSSLineListSearch.IconLeft = null;
            _TextSSLineListSearch.IconLeftCursor = Cursors.IBeam;
            _TextSSLineListSearch.IconPadding = 10;
            _TextSSLineListSearch.IconRight = null;
            _TextSSLineListSearch.IconRightCursor = Cursors.IBeam;
            _TextSSLineListSearch.Lines = new string[0];
            _TextSSLineListSearch.Location = new Point(1055, 58);
            _TextSSLineListSearch.MaxLength = 32767;
            _TextSSLineListSearch.MinimumSize = new Size(100, 35);
            _TextSSLineListSearch.Modified = false;
            _TextSSLineListSearch.Multiline = false;
            _TextSSLineListSearch.Name = "_TextSSLineListSearch";
            StateProperties1.BorderColor = Color.Teal;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            _TextSSLineListSearch.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            _TextSSLineListSearch.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.Teal;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _TextSSLineListSearch.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Gray;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            _TextSSLineListSearch.OnIdleState = StateProperties4;
            _TextSSLineListSearch.PasswordChar = '\0';
            _TextSSLineListSearch.PlaceholderForeColor = Color.Silver;
            _TextSSLineListSearch.PlaceholderText = "Search...";
            _TextSSLineListSearch.ReadOnly = false;
            _TextSSLineListSearch.ScrollBars = ScrollBars.None;
            _TextSSLineListSearch.SelectedText = "";
            _TextSSLineListSearch.SelectionLength = 0;
            _TextSSLineListSearch.SelectionStart = 0;
            _TextSSLineListSearch.ShortcutsEnabled = true;
            _TextSSLineListSearch.Size = new Size(324, 35);
            _TextSSLineListSearch.Style = _Style.Bunifu;
            _TextSSLineListSearch.TabIndex = 108;
            _TextSSLineListSearch.TextAlign = HorizontalAlignment.Left;
            _TextSSLineListSearch.TextMarginBottom = 0;
            _TextSSLineListSearch.TextMarginLeft = 5;
            _TextSSLineListSearch.TextMarginTop = 0;
            _TextSSLineListSearch.TextPlaceholder = "Search...";
            _TextSSLineListSearch.UseSystemPasswordChar = false;
            _TextSSLineListSearch.WordWrap = true;
            // 
            // assignBunifuButton
            // 
            _assignBunifuButton.AllowToggling = false;
            _assignBunifuButton.Anchor = AnchorStyles.Right;
            _assignBunifuButton.AnimationSpeed = 200;
            _assignBunifuButton.AutoGenerateColors = false;
            _assignBunifuButton.BackColor = Color.Transparent;
            _assignBunifuButton.BackColor1 = Color.Teal;
            _assignBunifuButton.BackgroundImage = (Image)resources.GetObject("assignBunifuButton.BackgroundImage");
            _assignBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _assignBunifuButton.ButtonText = "Assign...";
            _assignBunifuButton.ButtonTextMarginLeft = 0;
            _assignBunifuButton.ColorContrastOnClick = 45;
            _assignBunifuButton.ColorContrastOnHover = 45;
            _assignBunifuButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _assignBunifuButton.CustomizableEdges = BorderEdges1;
            _assignBunifuButton.DialogResult = DialogResult.None;
            _assignBunifuButton.DisabledBorderColor = Color.Empty;
            _assignBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _assignBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _assignBunifuButton.Enabled = false;
            _assignBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _assignBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _assignBunifuButton.ForeColor = Color.White;
            _assignBunifuButton.IconLeftCursor = Cursors.Hand;
            _assignBunifuButton.IconMarginLeft = 11;
            _assignBunifuButton.IconPadding = 10;
            _assignBunifuButton.IconRightCursor = Cursors.Hand;
            _assignBunifuButton.IdleBorderColor = Color.Teal;
            _assignBunifuButton.IdleBorderRadius = 3;
            _assignBunifuButton.IdleBorderThickness = 1;
            _assignBunifuButton.IdleFillColor = Color.Teal;
            _assignBunifuButton.IdleIconLeftImage = null;
            _assignBunifuButton.IdleIconRightImage = null;
            _assignBunifuButton.IndicateFocus = true;
            _assignBunifuButton.Location = new Point(1372, 824);
            _assignBunifuButton.Name = "_assignBunifuButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _assignBunifuButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _assignBunifuButton.OnPressedState = StateProperties6;
            _assignBunifuButton.Size = new Size(123, 44);
            _assignBunifuButton.TabIndex = 116;
            _assignBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _assignBunifuButton.TextMarginLeft = 0;
            _assignBunifuButton.UseDefaultRadiusAndThickness = true;
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
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1537, 928);
            BunifuShadowPanel1.TabIndex = 117;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1522, 917);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(_closeFlatButton);
            Panel5.Controls.Add(Panel2);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1522, 917);
            Panel5.TabIndex = 33;
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Font = new Font("Microsoft Sans Serif", 7.854546f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
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
            _closeFlatButton.Location = new Point(1478, 3);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(44, 37);
            _closeFlatButton.TabIndex = 168;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 20.29091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(_ContainerList2);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(_ComboSSLineList);
            Panel2.Controls.Add(_assignBunifuButton);
            Panel2.Controls.Add(_TextSSLineListSearch);
            Panel2.Controls.Add(Label1);
            Panel2.Dock = DockStyle.Fill;
            Panel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1522, 877);
            Panel2.TabIndex = 0;
            // 
            // ContainerList2
            // 
            _ContainerList2.ContainerListMode = WTC_CeresControls.ContainerList.ModeOfContainerList.SSLineContainerList;
            _ContainerList2.Location = new Point(141, 98);
            _ContainerList2.Name = "_ContainerList2";
            _ContainerList2.Size = new Size(1354, 672);
            _ContainerList2.TabIndex = 118;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(121, 14);
            Label2.Name = "Label2";
            Label2.Size = new Size(176, 30);
            Label2.TabIndex = 117;
            Label2.Text = "List of containers";
            // 
            // FrmListContainers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1537, 928);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListContainers";
            StartPosition = FormStartPosition.CenterParent;
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Load += new EventHandler(FrmListContainers_Load);
            ResumeLayout(false);
        }

        internal WTC_CeresControls.ContainerList ContainerList1;
        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuDropdown _ComboSSLineList;

        internal Bunifu.UI.WinForms.BunifuDropdown ComboSSLineList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboSSLineList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboSSLineList != null)
                {
                    _ComboSSLineList.SelectedIndexChanged -= ComboSSLineList_SelectedIndexChanged;
                }

                _ComboSSLineList = value;
                if (_ComboSSLineList != null)
                {
                    _ComboSSLineList.SelectedIndexChanged += ComboSSLineList_SelectedIndexChanged;
                }
            }
        }

        private BunifuTextBox _TextSSLineListSearch;

        internal BunifuTextBox TextSSLineListSearch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextSSLineListSearch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextSSLineListSearch != null)
                {
                    _TextSSLineListSearch.TextChanged -= BunifuTextBox1_TextChanged;
                }

                _TextSSLineListSearch = value;
                if (_TextSSLineListSearch != null)
                {
                    _TextSSLineListSearch.TextChanged += BunifuTextBox1_TextChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _assignBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton assignBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _assignBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_assignBunifuButton != null)
                {
                    _assignBunifuButton.Click -= BunifuButton2_Click;
                }

                _assignBunifuButton = value;
                if (_assignBunifuButton != null)
                {
                    _assignBunifuButton.Click += BunifuButton2_Click;
                }
            }
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        internal Panel Panel2;
        internal Label Label2;
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

        private WTC_CeresControls.ContainerList _ContainerList2;

        internal WTC_CeresControls.ContainerList ContainerList2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContainerList2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContainerList2 != null)
                {
                    _ContainerList2.RemoveAssignment -= ContainerList2_RemoveAssignment;
                    _ContainerList2.ExportAsCSV -= ContainerList2_ExportAsCSV;
                    _ContainerList2.ContainersSelected -= ContainerList2_ContainersSelected;
                }

                _ContainerList2 = value;
                if (_ContainerList2 != null)
                {
                    _ContainerList2.RemoveAssignment += ContainerList2_RemoveAssignment;
                    _ContainerList2.ExportAsCSV += ContainerList2_ExportAsCSV;
                    _ContainerList2.ContainersSelected += ContainerList2_ContainersSelected;
                }
            }
        }
    }
}