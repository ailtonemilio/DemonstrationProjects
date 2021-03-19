using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ShipSmpl
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FrmPushBooking : Form
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
            _BookingList1 = new WTC_CeresControls.BookingList();
            _BookingList1.PushBookingNumbers += new WTC_CeresControls.BookingList.PushBookingNumbersEventHandler(BookingList1_PushBookingNumbers);
            SuspendLayout();
            // 
            // BookingList1
            // 
            _BookingList1.Location = new Point(94, 12);
            _BookingList1.Name = "_BookingList1";
            _BookingList1.Size = new Size(762, 546);
            _BookingList1.TabIndex = 0;
            // 
            // FrmPushBooking
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(937, 570);
            Controls.Add(_BookingList1);
            Name = "FrmPushBooking";
            Text = "FrmPushBooking";
            Load += new EventHandler(FrmPushBooking_Load);
            ResumeLayout(false);
        }

        private WTC_CeresControls.BookingList _BookingList1;

        internal WTC_CeresControls.BookingList BookingList1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BookingList1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BookingList1 != null)
                {
                    _BookingList1.PushBookingNumbers -= BookingList1_PushBookingNumbers;
                }

                _BookingList1 = value;
                if (_BookingList1 != null)
                {
                    _BookingList1.PushBookingNumbers += BookingList1_PushBookingNumbers;
                }
            }
        }
    }
}