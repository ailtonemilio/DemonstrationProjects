using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmBlockContainer
    {
        public FrmBlockContainer()
        {
            InitializeComponent();
            _RichTextBox1.Name = "RichTextBox1";
            _blockContainerButton.Name = "blockContainerButton";
            _closeLabel.Name = "closeLabel";
            _noBunifuButton.Name = "noBunifuButton";
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                var withBlock = cboShippingLine;
                withBlock.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Steamship_Line, new WTCCeresEntities());
                withBlock.DisplayMember = "CompanyName";
                withBlock.ValueMember = "CompanyId";
            }

            titleLabel.ForeColor = Color.FromArgb(64, 64, 64);
            titleLabel.Text = "Block Container";
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] containerList;
            containerList = RichTextBox1.Text.Split(Conversions.ToChar(Constants.vbLf));
            cleanDataGrids();
            titleLabel.Text = "Block Container";
            foreach (var cont in containerList)
            {
                string condition = "where [Container Number] = '" + cont + "'";
                // if container number is valid, add it to the valid containers list
                if (MdlContainerManagement.ValidateContainer(cont) & db.isOnDatabase("[Blocked Containers]", condition) == false)
                {
                    goodContDataGrid.Rows.Add(cont);
                }
                // if already on database, show ** and add to the not valid containers list
                else if (db.isOnDatabase("[Blocked Containers]", condition) == true)
                {
                    badContDataGrid.Rows.Add("* " + cont + " *");
                    warningLabel.Visible = true;
                }
                else
                {
                    // otherwise just add to the not valid containers list with no **
                    badContDataGrid.Rows.Add(cont);
                }
            }
        }

        private void blockContainerButton_ButtonClick(object sender, EventArgs e)
        {
            string container = "";
            string lineCode = "";
            string lineName = "";
            VW_CompanyCompanyType ssLineObj = (VW_CompanyCompanyType)cboShippingLine.SelectedItem;
            var blockTillDate = DateAndTime.Now;
            for (int i = 0, loopTo = goodContDataGrid.Rows.Count - 1; i <= loopTo; i++)
            {
                container = Conversions.ToString(goodContDataGrid.Rows[i].Cells[0].Value);
                lineCode = ssLineObj.CompanyCode;
                lineName = ssLineObj.CompanyName;
                db.saveBlockedContainers(container, lineCode, lineName, DateAndTime.Now.Date, blockTillDate.AddDays((double)NumericUpDown1.Value).Date);
            }

            titleLabel.Text = "The containers were blocked successfuly!";
            titleLabel.ForeColor = Color.Green;
            cleanDataGrids();
        }

        private void cleanDataGrids()
        {
            int count = goodContDataGrid.Rows.Count - 1;
            while (count >= 0)
            {
                goodContDataGrid.Rows.RemoveAt(count);
                count = goodContDataGrid.Rows.Count - 1;
            }

            count = badContDataGrid.Rows.Count - 1;
            while (count >= 0)
            {
                badContDataGrid.Rows.RemoveAt(count);
                count = badContDataGrid.Rows.Count - 1;
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.DimGray;
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