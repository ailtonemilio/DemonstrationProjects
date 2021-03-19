using System;
using System.Drawing;
using System.Windows.Forms;
using WaitLoading;

namespace ShipSmpl
{
    static class MdlLoadingSetting
    {
        public static WaitLoadingRun waitForm = new WaitLoadingRun();

        public static void adjustScreen(Panel focusedPanel, bool menuIsExpanded)
        {
            decimal heigt = My.MyProject.Computer.Screen.WorkingArea.Height - 50;
            decimal width = 0m;
            if (menuIsExpanded)
            {
                width = My.MyProject.Computer.Screen.WorkingArea.Width - 225;
                focusedPanel.SetBounds(220, 50, (int)Math.Round(width), (int)Math.Round(heigt));
            }
            else
            {
                width = My.MyProject.Computer.Screen.WorkingArea.Width - 50;
                focusedPanel.SetBounds(45, 50, (int)Math.Round(width), (int)Math.Round(heigt));
            }
            // focusedForm.Location = New Point(0, 0)
            // focusedForm.Size = New Point(width, heigt)

            My.MyProject.Forms.FrmParentScreen.SlideMenu1.Visible = true;
        }

        public static void adjustScreen(Form focusedPanel, bool menuIsExpanded)
        {
            decimal heigt = My.MyProject.Computer.Screen.WorkingArea.Height - 50;
            decimal width = 0m;
            if (menuIsExpanded)
            {
                width = My.MyProject.Computer.Screen.WorkingArea.Width - 225;
            }
            else
            {
                width = My.MyProject.Computer.Screen.WorkingArea.Width - 50;
            }

            focusedPanel.SetBounds(0, 0, (int)Math.Round(width), (int)Math.Round(heigt));
        }

        public static void showDialogForm(Form dialogForm, Form parentForm)
        {
            var bmp = new Bitmap(parentForm.ClientRectangle.Width, parentForm.ClientRectangle.Height);
            using (var G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(parentForm.PointToScreen(new Point(0, 0)), new Point(0, 0), parentForm.ClientRectangle.Size);
                double percent = 0.4d;
                var darken = Color.FromArgb((int)Math.Round(255d * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, parentForm.ClientRectangle);
                }
            }

            using (var p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = parentForm.ClientRectangle.Size;
                p.BackgroundImage = bmp;
                parentForm.Controls.Add(p);
                p.BringToFront();
                dialogForm.StartPosition = FormStartPosition.CenterParent;
                dialogForm.ShowDialog();
            }
        }
    }
}