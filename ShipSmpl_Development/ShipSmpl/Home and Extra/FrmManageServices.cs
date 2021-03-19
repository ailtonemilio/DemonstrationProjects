using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmManageServices
    {
        public FrmManageServices()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _cancelButton.Name = "cancelButton";
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            Close();
        }
    }
}