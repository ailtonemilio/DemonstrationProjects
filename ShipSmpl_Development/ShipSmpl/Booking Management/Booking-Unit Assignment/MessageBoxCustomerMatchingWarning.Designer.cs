using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class MessageBoxCustomerMatchingWarning : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxCustomerMatchingWarning));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            Label3 = new Label();
            Label9 = new Label();
            buttonsPanel = new TableLayoutPanel();
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(save_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            Label1 = new Label();
            Label2 = new Label();
            bkgCustomerLabel = new Label();
            bkgNumbLabel = new Label();
            unitSourvceNumbLabel = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label10 = new Label();
            unitSourceCustomLabel = new Label();
            Label11 = new Label();
            BunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            warningLabel = new Label();
            _openFormLinkLabel = new LinkLabel();
            _openFormLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(openFormLinkLabel_LinkClicked);
            chageUnitCustLabel = new Label();
            dontAsnLabel = new Label();
            changeUnitCustRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            _dontAsnRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            _dontAsnRadioButton.CheckedChanged += new EventHandler(BunifuRadioButton2_Click);
            PictureBox1 = new PictureBox();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
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
            _closeFlatButton.Location = new Point(747, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 170;
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
            Label8.Size = new Size(790, 41);
            Label8.TabIndex = 169;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(31, 110);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(735, 51);
            Label3.TabIndex = 173;
            Label3.Text = "The selected unit customer doesn't match the booking customer. Select the action " + "below to continue the assignment:" + '\r' + '\n';
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(9, 81);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(263, 25);
            Label9.TabIndex = 172;
            Label9.Text = "Customer matching problem:";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_saveButton, 0, 0);
            buttonsPanel.Controls.Add(_cancelButton, 1, 0);
            buttonsPanel.Location = new Point(560, 494);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(218, 39);
            buttonsPanel.TabIndex = 175;
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
            _saveButton.Location = new Point(3, 3);
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
            _saveButton.Size = new Size(102, 33);
            _saveButton.TabIndex = 136;
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
            _cancelButton.Location = new Point(112, 3);
            _cancelButton.Name = "_cancelButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties4;
            _cancelButton.Size = new Size(103, 33);
            _cancelButton.TabIndex = 137;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(134, 185);
            Label1.Margin = new Padding(0);
            Label1.Name = "Label1";
            Label1.Size = new Size(169, 25);
            Label1.TabIndex = 176;
            Label1.Text = "Booking Number:";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(134, 215);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(157, 25);
            Label2.TabIndex = 177;
            Label2.Text = "Booking Customer:";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bkgCustomerLabel
            // 
            bkgCustomerLabel.Anchor = AnchorStyles.None;
            bkgCustomerLabel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, Conversions.ToByte(0));
            bkgCustomerLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            bkgCustomerLabel.Location = new Point(317, 215);
            bkgCustomerLabel.Margin = new Padding(0);
            bkgCustomerLabel.Name = "bkgCustomerLabel";
            bkgCustomerLabel.Size = new Size(408, 40);
            bkgCustomerLabel.TabIndex = 179;
            bkgCustomerLabel.Text = "Booking Customer:";
            // 
            // bkgNumbLabel
            // 
            bkgNumbLabel.Anchor = AnchorStyles.None;
            bkgNumbLabel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            bkgNumbLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            bkgNumbLabel.Location = new Point(317, 185);
            bkgNumbLabel.Margin = new Padding(0);
            bkgNumbLabel.Name = "bkgNumbLabel";
            bkgNumbLabel.Size = new Size(203, 25);
            bkgNumbLabel.TabIndex = 178;
            bkgNumbLabel.Text = "Booking Number:";
            bkgNumbLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unitSourvceNumbLabel
            // 
            unitSourvceNumbLabel.Anchor = AnchorStyles.None;
            unitSourvceNumbLabel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            unitSourvceNumbLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            unitSourvceNumbLabel.Location = new Point(317, 276);
            unitSourvceNumbLabel.Margin = new Padding(0);
            unitSourvceNumbLabel.Name = "unitSourvceNumbLabel";
            unitSourvceNumbLabel.Size = new Size(203, 25);
            unitSourvceNumbLabel.TabIndex = 182;
            unitSourvceNumbLabel.Text = "Unit Number:";
            unitSourvceNumbLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.None;
            Label6.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(134, 306);
            Label6.Margin = new Padding(0);
            Label6.Name = "Label6";
            Label6.Size = new Size(183, 25);
            Label6.TabIndex = 181;
            Label6.Text = "Unit Source Customer:";
            Label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.None;
            Label7.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(134, 276);
            Label7.Margin = new Padding(0);
            Label7.Name = "Label7";
            Label7.Size = new Size(183, 25);
            Label7.TabIndex = 180;
            Label7.Text = "Unit Source Number:";
            Label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.None;
            Label10.Font = new Font("Segoe UI", 7.854546f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(134, 245);
            Label10.Margin = new Padding(0);
            Label10.Name = "Label10";
            Label10.Size = new Size(454, 16);
            Label10.TabIndex = 184;
            Label10.Text = "_________________________________________________________________________________" + "______________________";
            // 
            // unitSourceCustomLabel
            // 
            unitSourceCustomLabel.Anchor = AnchorStyles.None;
            unitSourceCustomLabel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, Conversions.ToByte(0));
            unitSourceCustomLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            unitSourceCustomLabel.Location = new Point(317, 306);
            unitSourceCustomLabel.Margin = new Padding(0);
            unitSourceCustomLabel.Name = "unitSourceCustomLabel";
            unitSourceCustomLabel.Size = new Size(408, 34);
            unitSourceCustomLabel.TabIndex = 183;
            unitSourceCustomLabel.Text = "Unit Customer:";
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.None;
            Label11.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(38, 354);
            Label11.Margin = new Padding(0);
            Label11.Name = "Label11";
            Label11.Size = new Size(65, 25);
            Label11.TabIndex = 185;
            Label11.Text = "Action:";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuFormDock1
            // 
            BunifuFormDock1.AllowFormDragging = true;
            BunifuFormDock1.AllowFormDropShadow = true;
            BunifuFormDock1.AllowFormResizing = true;
            BunifuFormDock1.AllowHidingBottomRegion = true;
            BunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            BunifuFormDock1.BorderOptions.BottomBorder.BorderColor = Color.Silver;
            BunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            BunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            BunifuFormDock1.BorderOptions.LeftBorder.BorderColor = Color.Silver;
            BunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            BunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            BunifuFormDock1.BorderOptions.RightBorder.BorderColor = Color.Silver;
            BunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            BunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            BunifuFormDock1.BorderOptions.TopBorder.BorderColor = Color.Silver;
            BunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            BunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            BunifuFormDock1.ContainerControl = this;
            BunifuFormDock1.DockingIndicatorsColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(202)), Conversions.ToInteger(Conversions.ToByte(215)), Conversions.ToInteger(Conversions.ToByte(233)));
            BunifuFormDock1.DockingIndicatorsOpacity = 0.5d;
            BunifuFormDock1.DockingOptions.DockAll = true;
            BunifuFormDock1.DockingOptions.DockBottomLeft = true;
            BunifuFormDock1.DockingOptions.DockBottomRight = true;
            BunifuFormDock1.DockingOptions.DockFullScreen = true;
            BunifuFormDock1.DockingOptions.DockLeft = true;
            BunifuFormDock1.DockingOptions.DockRight = true;
            BunifuFormDock1.DockingOptions.DockTopLeft = true;
            BunifuFormDock1.DockingOptions.DockTopRight = true;
            BunifuFormDock1.FormDraggingOpacity = 0.9d;
            BunifuFormDock1.ParentForm = this;
            BunifuFormDock1.ShowCursorChanges = true;
            BunifuFormDock1.ShowDockingIndicators = true;
            BunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            BunifuFormDock1.TitleBarOptions.BunifuFormDock = BunifuFormDock1;
            BunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            BunifuFormDock1.TitleBarOptions.TitleBarControl = Label8;
            BunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // warningLabel
            // 
            warningLabel.Anchor = AnchorStyles.None;
            warningLabel.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            warningLabel.Location = new Point(105, 439);
            warningLabel.Margin = new Padding(0);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(649, 41);
            warningLabel.TabIndex = 186;
            // 
            // openFormLinkLabel
            // 
            _openFormLinkLabel.Location = new Point(102, 480);
            _openFormLinkLabel.Name = "_openFormLinkLabel";
            _openFormLinkLabel.Size = new Size(122, 23);
            _openFormLinkLabel.TabIndex = 187;
            // 
            // chageUnitCustLabel
            // 
            chageUnitCustLabel.Anchor = AnchorStyles.None;
            chageUnitCustLabel.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            chageUnitCustLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            chageUnitCustLabel.Location = new Point(65, 404);
            chageUnitCustLabel.Margin = new Padding(0);
            chageUnitCustLabel.Name = "chageUnitCustLabel";
            chageUnitCustLabel.Size = new Size(457, 25);
            chageUnitCustLabel.TabIndex = 188;
            chageUnitCustLabel.Text = "Set Unit Source Customer same as Booking Customer";
            chageUnitCustLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dontAsnLabel
            // 
            dontAsnLabel.Anchor = AnchorStyles.None;
            dontAsnLabel.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dontAsnLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dontAsnLabel.Location = new Point(65, 379);
            dontAsnLabel.Margin = new Padding(0);
            dontAsnLabel.Name = "dontAsnLabel";
            dontAsnLabel.Size = new Size(457, 25);
            dontAsnLabel.TabIndex = 189;
            dontAsnLabel.Text = "Don't assign unit to booking";
            dontAsnLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // changeUnitCustRadioButton
            // 
            changeUnitCustRadioButton.Checked = true;
            changeUnitCustRadioButton.Location = new Point(44, 407);
            changeUnitCustRadioButton.Name = "changeUnitCustRadioButton";
            changeUnitCustRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            changeUnitCustRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            changeUnitCustRadioButton.Size = new Size(20, 20);
            changeUnitCustRadioButton.TabIndex = 190;
            changeUnitCustRadioButton.Text = null;
            // 
            // dontAsnRadioButton
            // 
            _dontAsnRadioButton.Checked = false;
            _dontAsnRadioButton.Location = new Point(44, 382);
            _dontAsnRadioButton.Name = "_dontAsnRadioButton";
            _dontAsnRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dontAsnRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dontAsnRadioButton.Size = new Size(20, 20);
            _dontAsnRadioButton.TabIndex = 191;
            _dontAsnRadioButton.Text = null;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.icon_available;
            PictureBox1.Location = new Point(56, 440);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(40, 40);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 192;
            PictureBox1.TabStop = false;
            // 
            // MessageBoxCustomerMatchingWarning
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(790, 545);
            ControlBox = false;
            Controls.Add(PictureBox1);
            Controls.Add(_dontAsnRadioButton);
            Controls.Add(changeUnitCustRadioButton);
            Controls.Add(dontAsnLabel);
            Controls.Add(chageUnitCustLabel);
            Controls.Add(_openFormLinkLabel);
            Controls.Add(warningLabel);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(unitSourceCustomLabel);
            Controls.Add(unitSourvceNumbLabel);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(bkgCustomerLabel);
            Controls.Add(bkgNumbLabel);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(buttonsPanel);
            Controls.Add(Label3);
            Controls.Add(Label9);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxCustomerMatchingWarning";
            StartPosition = FormStartPosition.CenterScreen;
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
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

        internal Label Label8;
        internal Label Label3;
        internal Label Label9;
        internal TableLayoutPanel buttonsPanel;
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
                    _saveButton.Click -= save_Click;
                }

                _saveButton = value;
                if (_saveButton != null)
                {
                    _saveButton.Click += save_Click;
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

        internal Label Label1;
        internal Label Label2;
        internal Label bkgCustomerLabel;
        internal Label bkgNumbLabel;
        internal Label unitSourvceNumbLabel;
        internal Label Label6;
        internal Label Label7;
        internal Label Label10;
        internal Label unitSourceCustomLabel;
        internal Label Label11;
        internal Bunifu.UI.WinForms.BunifuFormDock BunifuFormDock1;
        private LinkLabel _openFormLinkLabel;

        internal LinkLabel openFormLinkLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _openFormLinkLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_openFormLinkLabel != null)
                {
                    _openFormLinkLabel.LinkClicked -= openFormLinkLabel_LinkClicked;
                }

                _openFormLinkLabel = value;
                if (_openFormLinkLabel != null)
                {
                    _openFormLinkLabel.LinkClicked += openFormLinkLabel_LinkClicked;
                }
            }
        }

        internal Label warningLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton _dontAsnRadioButton;

        internal Bunifu.UI.WinForms.BunifuRadioButton dontAsnRadioButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dontAsnRadioButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dontAsnRadioButton != null)
                {
                    _dontAsnRadioButton.CheckedChanged -= BunifuRadioButton2_Click;
                }

                _dontAsnRadioButton = value;
                if (_dontAsnRadioButton != null)
                {
                    _dontAsnRadioButton.CheckedChanged += BunifuRadioButton2_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuRadioButton changeUnitCustRadioButton;
        internal Label dontAsnLabel;
        internal Label chageUnitCustLabel;
        internal PictureBox PictureBox1;
    }
}