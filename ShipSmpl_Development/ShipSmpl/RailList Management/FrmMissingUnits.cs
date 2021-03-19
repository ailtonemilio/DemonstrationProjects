using Microsoft.VisualBasic;
using System;

namespace ShipSmpl
{
    public partial class FrmMissingUnits
    {
        public FrmMissingUnits()
        {
            InitializeComponent();
        }

        private void FrmMissingUnits_Load(object sender, EventArgs e)
        {
            // Dim XPos As Int16 = 0, YPos As Int16 = 0

            // XPos = ((Screen.PrimaryScreen.WorkingArea.Width - FrmDesktop.Dashboard1.Width) - Me.Width) / 2
            // YPos = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            // If XPos < FrmDesktop.Dashboard1.Width Then
            // Me.Location = New System.Drawing.Point(FrmDesktop.Dashboard1.Width + 60, YPos)
            // Else
            // Me.Location = New System.Drawing.Point(XPos + FrmDesktop.Dashboard1.Width, YPos)
            // End If
        }

        public void PublishMissingUnits(string MissingUnits)
        {
            int x = 0;
            string TempLine = "";
            string GoodDate = "";
            var loopTo = Strings.Len(MissingUnits);
            for (x = 1; x <= loopTo; x += 63)
            {
                if ((Strings.Mid(MissingUnits, x + 59, 4) ?? "") == (MdlContainerManagement.DoFunctions.MKL(0) ?? ""))
                {
                    GoodDate = "";
                }
                else
                {
                    GoodDate = MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(MissingUnits, x + 59, 4));
                }

                TempLine += Strings.RTrim(Strings.Mid(MissingUnits, x, 11)) + Constants.vbTab + Strings.RTrim(Strings.Mid(MissingUnits, x + 11, 4)) + Constants.vbTab + MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(MissingUnits, x + 15, 4)) + Constants.vbTab + Strings.RTrim(Strings.Mid(MissingUnits, x + 19, 20)) + Constants.vbTab + Strings.RTrim(Strings.Mid(MissingUnits, x + 39, 20)) + Constants.vbTab + GoodDate + Constants.vbCrLf;
            }

            RichTextBox1.Text = TempLine;
            Text = "Missing Rail Units....";
        }

        public void PublishCLMErrorFiles(string CLMFiles)
        {
            int x = 0;
            string TempLine = "";
            var loopTo = Strings.Len(CLMFiles);
            for (x = 1; x <= loopTo; x += 54)
                TempLine += Strings.RTrim(Strings.Mid(CLMFiles, x, 50)) + Constants.vbTab + MdlContainerManagement.DoFunctions.NumToDate(Strings.Mid(CLMFiles, x + 50, 4)) + Constants.vbCrLf;
            RichTextBox1.Text = TempLine;
            Text = "CLM File Errors....";
        }
    }
}