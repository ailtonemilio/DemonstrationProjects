using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ShipSmpl.Container_Management;
using ShipSmpl.Reports;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmOutGateReport : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutGateReport));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            _closeFlatButton.Load += new EventHandler(closeFlatButton_Load);
            Label8 = new Label();
            CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            _refreshInShapedButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _refreshInShapedButton.Click += new EventHandler(refreshInShapedButton_Click);
            toInBunifuDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            fromInBunifuDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            Label1 = new Label();
            Label2 = new Label();
            CrystalReportOuGate1 = new CrystalReportOuGate();
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
            _closeFlatButton.Location = new Point(1216, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 168;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label8
            // 
            Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Dock = DockStyle.Top;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(0, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(1259, 41);
            Label8.TabIndex = 167;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CrystalReportViewer1
            // 
            CrystalReportViewer1.ActiveViewIndex = 0;
            CrystalReportViewer1.BorderStyle = BorderStyle.FixedSingle;
            CrystalReportViewer1.Cursor = Cursors.Default;
            CrystalReportViewer1.Dock = DockStyle.Fill;
            CrystalReportViewer1.Location = new Point(0, 41);
            CrystalReportViewer1.Name = "CrystalReportViewer1";
            CrystalReportViewer1.ReportSource = CrystalReportOuGate1;
            CrystalReportViewer1.Size = new Size(1259, 758);
            CrystalReportViewer1.TabIndex = 169;
            // 
            // refreshInShapedButton
            // 
            _refreshInShapedButton.AllowToggling = false;
            _refreshInShapedButton.Anchor = AnchorStyles.None;
            _refreshInShapedButton.AnimationSpeed = 200;
            _refreshInShapedButton.AutoGenerateColors = false;
            _refreshInShapedButton.BackColor = Color.Transparent;
            _refreshInShapedButton.BackColor1 = Color.WhiteSmoke;
            _refreshInShapedButton.BackgroundImage = (Image)resources.GetObject("refreshInShapedButton.BackgroundImage");
            _refreshInShapedButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _refreshInShapedButton.ButtonText = "";
            _refreshInShapedButton.ButtonTextMarginLeft = 0;
            _refreshInShapedButton.ColorContrastOnClick = 45;
            _refreshInShapedButton.ColorContrastOnHover = 45;
            _refreshInShapedButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _refreshInShapedButton.CustomizableEdges = BorderEdges1;
            _refreshInShapedButton.DialogResult = DialogResult.None;
            _refreshInShapedButton.DisabledBorderColor = Color.Empty;
            _refreshInShapedButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _refreshInShapedButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _refreshInShapedButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _refreshInShapedButton.Font = new Font("Segoe UI Semibold", 9.75f);
            _refreshInShapedButton.ForeColor = Color.WhiteSmoke;
            _refreshInShapedButton.IconLeftCursor = Cursors.Hand;
            _refreshInShapedButton.IconMarginLeft = 3;
            _refreshInShapedButton.IconPadding = 3;
            _refreshInShapedButton.IconRightCursor = Cursors.Hand;
            _refreshInShapedButton.IdleBorderColor = Color.WhiteSmoke;
            _refreshInShapedButton.IdleBorderRadius = 3;
            _refreshInShapedButton.IdleBorderThickness = 1;
            _refreshInShapedButton.IdleFillColor = Color.WhiteSmoke;
            _refreshInShapedButton.IdleIconLeftImage = My.Resources.Resources.refresh_pngrepo_com;
            _refreshInShapedButton.IdleIconRightImage = null;
            _refreshInShapedButton.IndicateFocus = false;
            _refreshInShapedButton.Location = new Point(1041, 46);
            _refreshInShapedButton.Name = "_refreshInShapedButton";
            StateProperties1.BorderColor = Color.Teal;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.White;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _refreshInShapedButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.White;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _refreshInShapedButton.OnPressedState = StateProperties2;
            _refreshInShapedButton.Size = new Size(40, 31);
            _refreshInShapedButton.TabIndex = 174;
            _refreshInShapedButton.TextAlign = ContentAlignment.MiddleCenter;
            _refreshInShapedButton.TextMarginLeft = 0;
            _refreshInShapedButton.UseDefaultRadiusAndThickness = true;
            // 
            // toInBunifuDatePicker
            // 
            toInBunifuDatePicker.Anchor = AnchorStyles.None;
            toInBunifuDatePicker.BorderRadius = 3;
            toInBunifuDatePicker.CalendarFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toInBunifuDatePicker.Color = Color.Teal;
            toInBunifuDatePicker.CustomFormat = "MMM dd, yyyy";
            toInBunifuDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            toInBunifuDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            toInBunifuDatePicker.DisabledColor = Color.Gray;
            toInBunifuDatePicker.DisplayWeekNumbers = false;
            toInBunifuDatePicker.DPHeight = 0;
            toInBunifuDatePicker.DropDownAlign = LeftRightAlignment.Right;
            toInBunifuDatePicker.FillDatePicker = false;
            toInBunifuDatePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toInBunifuDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            toInBunifuDatePicker.Format = DateTimePickerFormat.Custom;
            toInBunifuDatePicker.Icon = (Image)resources.GetObject("toInBunifuDatePicker.Icon");
            toInBunifuDatePicker.IconColor = Color.Teal;
            toInBunifuDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            toInBunifuDatePicker.Location = new Point(876, 47);
            toInBunifuDatePicker.MinimumSize = new Size(160, 28);
            toInBunifuDatePicker.Name = "toInBunifuDatePicker";
            toInBunifuDatePicker.Size = new Size(160, 31);
            toInBunifuDatePicker.TabIndex = 173;
            // 
            // fromInBunifuDatePicker
            // 
            fromInBunifuDatePicker.Anchor = AnchorStyles.None;
            fromInBunifuDatePicker.BorderRadius = 3;
            fromInBunifuDatePicker.CalendarFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromInBunifuDatePicker.Color = Color.Teal;
            fromInBunifuDatePicker.CustomFormat = "MMM dd, yyyy";
            fromInBunifuDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            fromInBunifuDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            fromInBunifuDatePicker.DisabledColor = Color.Gray;
            fromInBunifuDatePicker.DisplayWeekNumbers = false;
            fromInBunifuDatePicker.DPHeight = 0;
            fromInBunifuDatePicker.DropDownAlign = LeftRightAlignment.Right;
            fromInBunifuDatePicker.FillDatePicker = false;
            fromInBunifuDatePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromInBunifuDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromInBunifuDatePicker.Format = DateTimePickerFormat.Custom;
            fromInBunifuDatePicker.Icon = (Image)resources.GetObject("fromInBunifuDatePicker.Icon");
            fromInBunifuDatePicker.IconColor = Color.Teal;
            fromInBunifuDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            fromInBunifuDatePicker.Location = new Point(638, 46);
            fromInBunifuDatePicker.MinimumSize = new Size(160, 28);
            fromInBunifuDatePicker.Name = "fromInBunifuDatePicker";
            fromInBunifuDatePicker.Size = new Size(160, 31);
            fromInBunifuDatePicker.TabIndex = 172;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.BackColor = Color.WhiteSmoke;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(834, 51);
            Label1.Margin = new Padding(0);
            Label1.Name = "Label1";
            Label1.Size = new Size(39, 27);
            Label1.TabIndex = 171;
            Label1.Text = "To:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.BackColor = Color.WhiteSmoke;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(570, 51);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(65, 26);
            Label2.TabIndex = 170;
            Label2.Text = "From:";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmOutGateReport
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1259, 799);
            Controls.Add(_refreshInShapedButton);
            Controls.Add(toInBunifuDatePicker);
            Controls.Add(fromInBunifuDatePicker);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(CrystalReportViewer1);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOutGateReport";
            Text = "FrmOutGateReport";
            Load += new EventHandler(FrmOutGateReport_Load);
            ResumeLayout(false);
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
                    _closeFlatButton.Load -= closeFlatButton_Load;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeFlatButton_Click;
                    _closeFlatButton.Load += closeFlatButton_Load;
                }
            }
        }

        internal Label Label8;
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _refreshInShapedButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton refreshInShapedButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _refreshInShapedButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_refreshInShapedButton != null)
                {
                    _refreshInShapedButton.Click -= refreshInShapedButton_Click;
                }

                _refreshInShapedButton = value;
                if (_refreshInShapedButton != null)
                {
                    _refreshInShapedButton.Click += refreshInShapedButton_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDatePicker toInBunifuDatePicker;
        internal Bunifu.UI.WinForms.BunifuDatePicker fromInBunifuDatePicker;
        internal Label Label1;
        internal Label Label2;
        internal CrystalReportOuGate CrystalReportOuGate1;
    }
}