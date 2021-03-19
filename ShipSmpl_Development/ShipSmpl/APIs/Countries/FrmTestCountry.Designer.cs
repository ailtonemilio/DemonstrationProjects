using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmTestCountry : Form
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
            _cboCountry = new ComboBox();
            _cboCountry.SelectedIndexChanged += new EventHandler(cboCountry_SelectedIndexChanged);
            _cboRegion = new ComboBox();
            _cboRegion.SelectedIndexChanged += new EventHandler(cboRegion_SelectedIndexChanged);
            _cboCity = new ComboBox();
            _cboCity.SelectedIndexChanged += new EventHandler(cboCity_SelectedIndexChanged);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            SuspendLayout();
            // 
            // cboCountry
            // 
            _cboCountry.AutoCompleteMode = AutoCompleteMode.Append;
            _cboCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCountry.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCountry.FormattingEnabled = true;
            _cboCountry.Location = new Point(167, 103);
            _cboCountry.Name = "_cboCountry";
            _cboCountry.Size = new Size(252, 28);
            _cboCountry.TabIndex = 0;
            // 
            // cboRegion
            // 
            _cboRegion.AutoCompleteMode = AutoCompleteMode.Append;
            _cboRegion.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboRegion.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboRegion.FormattingEnabled = true;
            _cboRegion.Location = new Point(167, 150);
            _cboRegion.Name = "_cboRegion";
            _cboRegion.Size = new Size(252, 28);
            _cboRegion.TabIndex = 1;
            // 
            // cboCity
            // 
            _cboCity.AutoCompleteMode = AutoCompleteMode.Append;
            _cboCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCity.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCity.FormattingEnabled = true;
            _cboCity.Location = new Point(167, 201);
            _cboCity.Name = "_cboCity";
            _cboCity.Size = new Size(252, 28);
            _cboCity.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(104, 109);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 17);
            Label1.TabIndex = 3;
            Label1.Text = "Country";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(104, 161);
            Label2.Name = "Label2";
            Label2.Size = new Size(53, 17);
            Label2.TabIndex = 4;
            Label2.Text = "Region";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(104, 212);
            Label3.Name = "Label3";
            Label3.Size = new Size(31, 17);
            Label3.TabIndex = 5;
            Label3.Text = "City";
            // 
            // FrmTestCountry
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 332);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_cboCity);
            Controls.Add(_cboRegion);
            Controls.Add(_cboCountry);
            Name = "FrmTestCountry";
            Text = "FrmTestCountry";
            Load += new EventHandler(FrmTestCountry_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox _cboCountry;

        internal ComboBox cboCountry
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCountry;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCountry != null)
                {
                    _cboCountry.SelectedIndexChanged -= cboCountry_SelectedIndexChanged;
                }

                _cboCountry = value;
                if (_cboCountry != null)
                {
                    _cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboRegion;

        internal ComboBox cboRegion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboRegion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboRegion != null)
                {
                    _cboRegion.SelectedIndexChanged -= cboRegion_SelectedIndexChanged;
                }

                _cboRegion = value;
                if (_cboRegion != null)
                {
                    _cboRegion.SelectedIndexChanged += cboRegion_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboCity;

        internal ComboBox cboCity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCity != null)
                {
                    _cboCity.SelectedIndexChanged -= cboCity_SelectedIndexChanged;
                }

                _cboCity = value;
                if (_cboCity != null)
                {
                    _cboCity.SelectedIndexChanged += cboCity_SelectedIndexChanged;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
    }
}