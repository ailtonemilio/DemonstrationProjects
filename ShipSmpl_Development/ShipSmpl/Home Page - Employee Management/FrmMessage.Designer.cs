using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmMessage : Form
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
            messageEmailRichTextBox = new RichTextBox();
            Label1 = new Label();
            Label2 = new Label();
            subjectEmailTextBox = new TextBox();
            _sendEmailTouchButton = new YardTabletControls.TouchButton();
            _sendEmailTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(sendEmailTouchButton_Load);
            _canceEmaillTouchButton = new YardTabletControls.TouchButton();
            _canceEmaillTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(canceEmaillTouchButton_Load);
            Label3 = new Label();
            fromEmailTextBox = new TextBox();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            ToEmailComboBox = new ComboBox();
            Label4 = new Label();
            TabPage2 = new TabPage();
            Label6 = new Label();
            Label7 = new Label();
            employeesListView = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader4 = new ColumnHeader();
            titleemployeeLabel = new Label();
            messageEmployeeRichTextBox = new RichTextBox();
            _cancelMessageTouchButton = new YardTabletControls.TouchButton();
            _cancelMessageTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(cancelMessageTouchButton_Load);
            _sendMessageTouchButton = new YardTabletControls.TouchButton();
            _sendMessageTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(sendMessageTouchButton_Load);
            subjectTextBox = new TextBox();
            Label8 = new Label();
            Label9 = new Label();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // messageEmailRichTextBox
            // 
            messageEmailRichTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            messageEmailRichTextBox.Location = new Point(97, 348);
            messageEmailRichTextBox.Name = "messageEmailRichTextBox";
            messageEmailRichTextBox.Size = new Size(555, 162);
            messageEmailRichTextBox.TabIndex = 4;
            messageEmailRichTextBox.Text = "";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(89, 204);
            Label1.Name = "Label1";
            Label1.Size = new Size(43, 25);
            Label1.TabIndex = 2;
            Label1.Text = "To:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(45, 257);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 25);
            Label2.TabIndex = 4;
            Label2.Text = "Subject:";
            // 
            // subjectEmailTextBox
            // 
            subjectEmailTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            subjectEmailTextBox.Location = new Point(141, 253);
            subjectEmailTextBox.Name = "subjectEmailTextBox";
            subjectEmailTextBox.Size = new Size(514, 29);
            subjectEmailTextBox.TabIndex = 3;
            // 
            // sendEmailTouchButton
            // 
            _sendEmailTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _sendEmailTouchButton.BevelWidth = Conversions.ToShort(2);
            _sendEmailTouchButton.ButtonEnabled = true;
            _sendEmailTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _sendEmailTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _sendEmailTouchButton.Caption = "Send";
            _sendEmailTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _sendEmailTouchButton.Location = new Point(207, 533);
            _sendEmailTouchButton.Margin = new Padding(4, 3, 4, 3);
            _sendEmailTouchButton.Name = "_sendEmailTouchButton";
            _sendEmailTouchButton.Size = new Size(146, 42);
            _sendEmailTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _sendEmailTouchButton.TabIndex = 5;
            _sendEmailTouchButton.TextColour = Color.White;
            _sendEmailTouchButton.TouchButtonColour = Color.Teal;
            _sendEmailTouchButton.Value = false;
            // 
            // canceEmaillTouchButton
            // 
            _canceEmaillTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _canceEmaillTouchButton.BevelWidth = Conversions.ToShort(2);
            _canceEmaillTouchButton.ButtonEnabled = true;
            _canceEmaillTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _canceEmaillTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _canceEmaillTouchButton.Caption = "Cancel";
            _canceEmaillTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _canceEmaillTouchButton.Location = new Point(407, 533);
            _canceEmaillTouchButton.Margin = new Padding(4, 3, 4, 3);
            _canceEmaillTouchButton.Name = "_canceEmaillTouchButton";
            _canceEmaillTouchButton.Size = new Size(146, 42);
            _canceEmaillTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _canceEmaillTouchButton.TabIndex = 6;
            _canceEmaillTouchButton.TextColour = Color.White;
            _canceEmaillTouchButton.TouchButtonColour = Color.Gray;
            _canceEmaillTouchButton.Value = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(68, 152);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 25);
            Label3.TabIndex = 8;
            Label3.Text = "From:";
            // 
            // fromEmailTextBox
            // 
            fromEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            fromEmailTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromEmailTextBox.Location = new Point(141, 151);
            fromEmailTextBox.Name = "fromEmailTextBox";
            fromEmailTextBox.ReadOnly = true;
            fromEmailTextBox.Size = new Size(390, 29);
            fromEmailTextBox.TabIndex = 1;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabControl1.ItemSize = new Size(70, 30);
            TabControl1.Location = new Point(0, 0);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(780, 664);
            TabControl1.TabIndex = 9;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(Label9);
            TabPage1.Controls.Add(ToEmailComboBox);
            TabPage1.Controls.Add(Label4);
            TabPage1.Controls.Add(fromEmailTextBox);
            TabPage1.Controls.Add(Label3);
            TabPage1.Controls.Add(messageEmailRichTextBox);
            TabPage1.Controls.Add(_canceEmaillTouchButton);
            TabPage1.Controls.Add(Label1);
            TabPage1.Controls.Add(_sendEmailTouchButton);
            TabPage1.Controls.Add(subjectEmailTextBox);
            TabPage1.Controls.Add(Label2);
            TabPage1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabPage1.Location = new Point(4, 34);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(772, 626);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Email";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // ToEmailComboBox
            // 
            ToEmailComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ToEmailComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            ToEmailComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            ToEmailComboBox.FormattingEnabled = true;
            ToEmailComboBox.Location = new Point(138, 197);
            ToEmailComboBox.Name = "ToEmailComboBox";
            ToEmailComboBox.Size = new Size(514, 32);
            ToEmailComboBox.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.BackColor = Color.DarkSlateGray;
            Label4.Dock = DockStyle.Top;
            Label4.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(3, 3);
            Label4.Name = "Label4";
            Label4.Size = new Size(766, 90);
            Label4.TabIndex = 9;
            Label4.Text = "Send Email";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(Label8);
            TabPage2.Controls.Add(subjectTextBox);
            TabPage2.Controls.Add(Label6);
            TabPage2.Controls.Add(Label7);
            TabPage2.Controls.Add(employeesListView);
            TabPage2.Controls.Add(titleemployeeLabel);
            TabPage2.Controls.Add(messageEmployeeRichTextBox);
            TabPage2.Controls.Add(_cancelMessageTouchButton);
            TabPage2.Controls.Add(_sendMessageTouchButton);
            TabPage2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabPage2.Location = new Point(4, 34);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(772, 626);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Message Employee";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(73, 345);
            Label6.Name = "Label6";
            Label6.Size = new Size(106, 25);
            Label6.TabIndex = 43;
            Label6.Text = "Message:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(71, 106);
            Label7.Name = "Label7";
            Label7.Size = new Size(213, 25);
            Label7.TabIndex = 42;
            Label7.Text = "Select the employee:";
            // 
            // employeesListView
            // 
            employeesListView.BackColor = Color.White;
            employeesListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader4 });
            employeesListView.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            employeesListView.FullRowSelect = true;
            employeesListView.HeaderStyle = ColumnHeaderStyle.None;
            employeesListView.HideSelection = false;
            employeesListView.Location = new Point(76, 134);
            employeesListView.MultiSelect = false;
            employeesListView.Name = "employeesListView";
            employeesListView.Size = new Size(483, 138);
            employeesListView.TabIndex = 41;
            employeesListView.UseCompatibleStateImageBehavior = false;
            employeesListView.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Name";
            ColumnHeader1.Width = 320;
            // 
            // ColumnHeader4
            // 
            ColumnHeader4.Text = "";
            ColumnHeader4.Width = 0;
            // 
            // titleemployeeLabel
            // 
            titleemployeeLabel.BackColor = Color.DarkSlateGray;
            titleemployeeLabel.Dock = DockStyle.Top;
            titleemployeeLabel.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleemployeeLabel.ForeColor = Color.White;
            titleemployeeLabel.Location = new Point(3, 3);
            titleemployeeLabel.Name = "titleemployeeLabel";
            titleemployeeLabel.Size = new Size(766, 85);
            titleemployeeLabel.TabIndex = 11;
            titleemployeeLabel.Text = "Send message to employee's clock in screen";
            titleemployeeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // messageEmployeeRichTextBox
            // 
            messageEmployeeRichTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            messageEmployeeRichTextBox.Location = new Point(78, 373);
            messageEmployeeRichTextBox.Name = "messageEmployeeRichTextBox";
            messageEmployeeRichTextBox.Size = new Size(618, 135);
            messageEmployeeRichTextBox.TabIndex = 10;
            messageEmployeeRichTextBox.Text = "";
            // 
            // cancelMessageTouchButton
            // 
            _cancelMessageTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _cancelMessageTouchButton.BevelWidth = Conversions.ToShort(2);
            _cancelMessageTouchButton.ButtonEnabled = true;
            _cancelMessageTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _cancelMessageTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _cancelMessageTouchButton.Caption = "Cancel";
            _cancelMessageTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelMessageTouchButton.Location = new Point(427, 541);
            _cancelMessageTouchButton.Margin = new Padding(4, 3, 4, 3);
            _cancelMessageTouchButton.Name = "_cancelMessageTouchButton";
            _cancelMessageTouchButton.Size = new Size(146, 42);
            _cancelMessageTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _cancelMessageTouchButton.TabIndex = 8;
            _cancelMessageTouchButton.TextColour = Color.White;
            _cancelMessageTouchButton.TouchButtonColour = Color.Gray;
            _cancelMessageTouchButton.Value = false;
            // 
            // sendMessageTouchButton
            // 
            _sendMessageTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _sendMessageTouchButton.BevelWidth = Conversions.ToShort(2);
            _sendMessageTouchButton.ButtonEnabled = true;
            _sendMessageTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _sendMessageTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _sendMessageTouchButton.Caption = "Send";
            _sendMessageTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _sendMessageTouchButton.Location = new Point(241, 541);
            _sendMessageTouchButton.Margin = new Padding(4, 3, 4, 3);
            _sendMessageTouchButton.Name = "_sendMessageTouchButton";
            _sendMessageTouchButton.Size = new Size(146, 42);
            _sendMessageTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _sendMessageTouchButton.TabIndex = 7;
            _sendMessageTouchButton.TextColour = Color.White;
            _sendMessageTouchButton.TouchButtonColour = Color.Teal;
            _sendMessageTouchButton.Value = false;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            subjectTextBox.Location = new Point(169, 301);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(340, 29);
            subjectTextBox.TabIndex = 44;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Location = new Point(73, 301);
            Label8.Name = "Label8";
            Label8.Size = new Size(90, 25);
            Label8.TabIndex = 45;
            Label8.Text = "Subject:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(29, 320);
            Label9.Name = "Label9";
            Label9.Size = new Size(106, 25);
            Label9.TabIndex = 11;
            Label9.Text = "Message:";
            // 
            // FrmMessage
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 664);
            ControlBox = false;
            Controls.Add(TabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMessage";
            StartPosition = FormStartPosition.CenterScreen;
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            Load += new EventHandler(FrmMessage_Load);
            ResumeLayout(false);
        }

        internal RichTextBox messageEmailRichTextBox;
        internal Label Label1;
        internal Label Label2;
        internal TextBox subjectEmailTextBox;
        private YardTabletControls.TouchButton _sendEmailTouchButton;

        internal YardTabletControls.TouchButton sendEmailTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sendEmailTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sendEmailTouchButton != null)
                {
                    _sendEmailTouchButton.ButtonClick -= sendEmailTouchButton_Load;
                }

                _sendEmailTouchButton = value;
                if (_sendEmailTouchButton != null)
                {
                    _sendEmailTouchButton.ButtonClick += sendEmailTouchButton_Load;
                }
            }
        }

        private YardTabletControls.TouchButton _canceEmaillTouchButton;

        internal YardTabletControls.TouchButton canceEmaillTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _canceEmaillTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_canceEmaillTouchButton != null)
                {
                    _canceEmaillTouchButton.ButtonClick -= canceEmaillTouchButton_Load;
                }

                _canceEmaillTouchButton = value;
                if (_canceEmaillTouchButton != null)
                {
                    _canceEmaillTouchButton.ButtonClick += canceEmaillTouchButton_Load;
                }
            }
        }

        internal Label Label3;
        internal TextBox fromEmailTextBox;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal Label Label4;
        internal TabPage TabPage2;
        internal Label titleemployeeLabel;
        internal RichTextBox messageEmployeeRichTextBox;
        private YardTabletControls.TouchButton _cancelMessageTouchButton;

        internal YardTabletControls.TouchButton cancelMessageTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cancelMessageTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cancelMessageTouchButton != null)
                {
                    _cancelMessageTouchButton.ButtonClick -= cancelMessageTouchButton_Load;
                }

                _cancelMessageTouchButton = value;
                if (_cancelMessageTouchButton != null)
                {
                    _cancelMessageTouchButton.ButtonClick += cancelMessageTouchButton_Load;
                }
            }
        }

        private YardTabletControls.TouchButton _sendMessageTouchButton;

        internal YardTabletControls.TouchButton sendMessageTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sendMessageTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sendMessageTouchButton != null)
                {
                    _sendMessageTouchButton.ButtonClick -= sendMessageTouchButton_Load;
                }

                _sendMessageTouchButton = value;
                if (_sendMessageTouchButton != null)
                {
                    _sendMessageTouchButton.ButtonClick += sendMessageTouchButton_Load;
                }
            }
        }

        internal ListView employeesListView;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader4;
        internal Label Label6;
        internal Label Label7;
        internal ComboBox ToEmailComboBox;
        internal Label Label8;
        internal TextBox subjectTextBox;
        internal Label Label9;
    }
}