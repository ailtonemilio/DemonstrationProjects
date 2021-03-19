using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmDisplayTemplates : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayTemplates));
            _templatesListView = new ListView();
            _templatesListView.Click += new EventHandler(templatesListView_SelectedIndexChanged);
            _templatesListView.SelectedIndexChanged += new EventHandler(templatesListView_SelectedIndexChanged_1);
            MenuStrip1 = new MenuStrip();
            _typeToolStripComboBox = new ToolStripComboBox();
            _typeToolStripComboBox.SelectedIndexChanged += new EventHandler(typeToolStripComboBox_Click);
            _typeToolStripComboBox.SelectedIndexChanged += new EventHandler(typeToolStripComboBox_Click_1);
            _searchWordToolStripTextBox1 = new ToolStripTextBox();
            _searchWordToolStripTextBox1.Click += new EventHandler(searchWordToolStripTextBox1_Click);
            _searchWordToolStripTextBox1.LostFocus += new EventHandler(searchWordToolStripTextBox1_LostFocus);
            _searchWordToolStripTextBox1.TextChanged += new EventHandler(searchWordToolStripTextBox1_TextChanged);
            Label14 = new Label();
            Label17 = new Label();
            _newToolStripMenuItem = new ToolStripMenuItem();
            _newToolStripMenuItem.Click += new EventHandler(newToolStripMenuItem_Click);
            _EditToolStripMenuItem = new ToolStripMenuItem();
            _EditToolStripMenuItem.Click += new EventHandler(EditToolStripMenuItem_Click);
            _DeleteToolStripMenuItem = new ToolStripMenuItem();
            _DeleteToolStripMenuItem.Click += new EventHandler(DeleteToolStripMenuItem_Click);
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // templatesListView
            // 
            _templatesListView.BackColor = Color.Snow;
            _templatesListView.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _templatesListView.FullRowSelect = true;
            _templatesListView.GridLines = true;
            _templatesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            _templatesListView.HideSelection = false;
            _templatesListView.Location = new Point(65, 195);
            _templatesListView.MultiSelect = false;
            _templatesListView.Name = "_templatesListView";
            _templatesListView.Size = new Size(970, 364);
            _templatesListView.TabIndex = 23;
            _templatesListView.UseCompatibleStateImageBehavior = false;
            _templatesListView.View = View.Details;
            // 
            // MenuStrip1
            // 
            MenuStrip1.BackColor = Color.Transparent;
            MenuStrip1.Dock = DockStyle.None;
            MenuStrip1.GripMargin = new Padding(2);
            MenuStrip1.GripStyle = ToolStripGripStyle.Visible;
            MenuStrip1.ImageScalingSize = new Size(18, 18);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { _newToolStripMenuItem, _EditToolStripMenuItem, _DeleteToolStripMenuItem, _typeToolStripComboBox, _searchWordToolStripTextBox1 });
            MenuStrip1.Location = new Point(65, 150);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Padding = new Padding(2);
            MenuStrip1.Size = new Size(945, 42);
            MenuStrip1.TabIndex = 22;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // typeToolStripComboBox
            // 
            _typeToolStripComboBox.BackColor = Color.Snow;
            _typeToolStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeToolStripComboBox.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _typeToolStripComboBox.Items.AddRange(new object[] { "All" });
            _typeToolStripComboBox.Margin = new Padding(20, 0, 30, 0);
            _typeToolStripComboBox.Name = "_typeToolStripComboBox";
            _typeToolStripComboBox.Size = new Size(180, 38);
            // 
            // searchWordToolStripTextBox1
            // 
            _searchWordToolStripTextBox1.AccessibleName = "";
            _searchWordToolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            _searchWordToolStripTextBox1.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _searchWordToolStripTextBox1.ForeColor = Color.Gray;
            _searchWordToolStripTextBox1.Name = "_searchWordToolStripTextBox1";
            _searchWordToolStripTextBox1.Size = new Size(270, 38);
            _searchWordToolStripTextBox1.Tag = "";
            _searchWordToolStripTextBox1.Text = "Find...";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.DarkSlateGray;
            Label14.Location = new Point(46, 41);
            Label14.Name = "Label14";
            Label14.Size = new Size(310, 35);
            Label14.TabIndex = 24;
            Label14.Text = "Message Templates";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Location = new Point(48, 63);
            Label17.Name = "Label17";
            Label17.Size = new Size(1022, 24);
            Label17.TabIndex = 25;
            Label17.Text = "_________________________________________________________________________________" + "___________";
            // 
            // newToolStripMenuItem
            // 
            _newToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            _newToolStripMenuItem.Name = "_newToolStripMenuItem";
            _newToolStripMenuItem.Padding = new Padding(2, 2, 35, 2);
            _newToolStripMenuItem.Size = new Size(115, 38);
            _newToolStripMenuItem.Text = "New";
            // 
            // EditToolStripMenuItem
            // 
            _EditToolStripMenuItem.Enabled = false;
            _EditToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25f);
            _EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            _EditToolStripMenuItem.Name = "_EditToolStripMenuItem";
            _EditToolStripMenuItem.Padding = new Padding(2, 2, 70, 2);
            _EditToolStripMenuItem.Size = new Size(144, 38);
            _EditToolStripMenuItem.Text = "Edit";
            // 
            // DeleteToolStripMenuItem
            // 
            _DeleteToolStripMenuItem.Enabled = false;
            _DeleteToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25f);
            _DeleteToolStripMenuItem.Image = (Image)resources.GetObject("DeleteToolStripMenuItem.Image");
            _DeleteToolStripMenuItem.Name = "_DeleteToolStripMenuItem";
            _DeleteToolStripMenuItem.Padding = new Padding(2, 2, 70, 2);
            _DeleteToolStripMenuItem.Size = new Size(169, 38);
            _DeleteToolStripMenuItem.Text = "Delete";
            // 
            // FrmDisplayTemplates
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1214, 717);
            Controls.Add(_templatesListView);
            Controls.Add(MenuStrip1);
            Controls.Add(Label14);
            Controls.Add(Label17);
            Name = "FrmDisplayTemplates";
            StartPosition = FormStartPosition.CenterScreen;
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            Load += new EventHandler(FrmDisplayTemplates_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private ListView _templatesListView;

        internal ListView templatesListView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _templatesListView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_templatesListView != null)
                {
                    _templatesListView.Click -= templatesListView_SelectedIndexChanged;
                    _templatesListView.SelectedIndexChanged -= templatesListView_SelectedIndexChanged_1;
                }

                _templatesListView = value;
                if (_templatesListView != null)
                {
                    _templatesListView.Click += templatesListView_SelectedIndexChanged;
                    _templatesListView.SelectedIndexChanged += templatesListView_SelectedIndexChanged_1;
                }
            }
        }

        internal MenuStrip MenuStrip1;
        private ToolStripMenuItem _newToolStripMenuItem;

        internal ToolStripMenuItem newToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _newToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_newToolStripMenuItem != null)
                {
                    _newToolStripMenuItem.Click -= newToolStripMenuItem_Click;
                }

                _newToolStripMenuItem = value;
                if (_newToolStripMenuItem != null)
                {
                    _newToolStripMenuItem.Click += newToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _EditToolStripMenuItem;

        internal ToolStripMenuItem EditToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EditToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EditToolStripMenuItem != null)
                {
                    _EditToolStripMenuItem.Click -= EditToolStripMenuItem_Click;
                }

                _EditToolStripMenuItem = value;
                if (_EditToolStripMenuItem != null)
                {
                    _EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _DeleteToolStripMenuItem;

        internal ToolStripMenuItem DeleteToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DeleteToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DeleteToolStripMenuItem != null)
                {
                    _DeleteToolStripMenuItem.Click -= DeleteToolStripMenuItem_Click;
                }

                _DeleteToolStripMenuItem = value;
                if (_DeleteToolStripMenuItem != null)
                {
                    _DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripComboBox _typeToolStripComboBox;

        internal ToolStripComboBox typeToolStripComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _typeToolStripComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_typeToolStripComboBox != null)
                {
                    _typeToolStripComboBox.SelectedIndexChanged -= typeToolStripComboBox_Click;
                    _typeToolStripComboBox.SelectedIndexChanged -= typeToolStripComboBox_Click_1;
                }

                _typeToolStripComboBox = value;
                if (_typeToolStripComboBox != null)
                {
                    _typeToolStripComboBox.SelectedIndexChanged += typeToolStripComboBox_Click;
                    _typeToolStripComboBox.SelectedIndexChanged += typeToolStripComboBox_Click_1;
                }
            }
        }

        private ToolStripTextBox _searchWordToolStripTextBox1;

        internal ToolStripTextBox searchWordToolStripTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _searchWordToolStripTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_searchWordToolStripTextBox1 != null)
                {
                    _searchWordToolStripTextBox1.Click -= searchWordToolStripTextBox1_Click;
                    _searchWordToolStripTextBox1.LostFocus -= searchWordToolStripTextBox1_LostFocus;
                    _searchWordToolStripTextBox1.TextChanged -= searchWordToolStripTextBox1_TextChanged;
                }

                _searchWordToolStripTextBox1 = value;
                if (_searchWordToolStripTextBox1 != null)
                {
                    _searchWordToolStripTextBox1.Click += searchWordToolStripTextBox1_Click;
                    _searchWordToolStripTextBox1.LostFocus += searchWordToolStripTextBox1_LostFocus;
                    _searchWordToolStripTextBox1.TextChanged += searchWordToolStripTextBox1_TextChanged;
                }
            }
        }

        internal Label Label14;
        internal Label Label17;
    }
}