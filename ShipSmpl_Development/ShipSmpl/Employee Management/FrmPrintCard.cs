using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmPrintCard
    {
        public FrmPrintCard()
        {
            InitializeComponent();
            _employeesListView.Name = "employeesListView";
            _NameTextBox.Name = "NameTextBox";
            _PositionTextBox.Name = "PositionTextBox";
            _Button1.Name = "Button1";
            _selectAllCheckBox.Name = "selectAllCheckBox";
            _CheckBox1.Name = "CheckBox1";
        }

        private DatabaseHelper db = new DatabaseHelper();

        private void reportFromListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateInfo();
        }

        private void FrmPrintCard_Load(object sender, EventArgs e)
        {
            foreach (DataRow employee in (IEnumerable)db.getAllActiveEmployees1().Rows)
                employeesListView.Items.Add(new ListViewItem(new[] { Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["Alias"], " "), employee["Last_Name"])), Conversions.ToString(employee["ID"]) }));
        }

        private int totalPages = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            HH = 0;
            index = 0;
            if (employeesListView.CheckedItems.Count > 0)
            {
                totalPages = employeesListView.CheckedItems.Count;
                PrintDialog1.Document = PrintDocument1;
                if (PrintDialog1.ShowDialog() == DialogResult.OK)
                {
                    PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
                    var New_Paper = new PaperSize("", 213, 338);
                    New_Paper.PaperName = ((int)PaperKind.Custom).ToString();
                    var New_Margin = new Margins();
                    New_Margin.Left = 0;
                    New_Margin.Top = 0;
                    {
                        var withBlock = PrintDocument1;
                        withBlock.DefaultPageSettings.PaperSize = New_Paper;
                        withBlock.DefaultPageSettings.Margins = New_Margin;
                        // .PrinterSettings.DefaultPageSettings.Landscape = False
                        withBlock.Print();
                    }
                }

                warningLabel.Hide();
            }
            else
            {
                warningLabel.Show();
            }
        }

        private int HH = 0;
        private int index = 0;

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            for (int i = index, loopTo = employeesListView.Items.Count - 1; i <= loopTo; i++)
            {
                if (employeesListView.Items[i].Checked)
                {
                    if (employeesListView.CheckedItems.Count != 1)
                    {
                        employeesListView.Items[i].Focused = true;
                        populateInfo();
                    }

                    if (CheckBox1.Checked)
                    {
                        e.Graphics.DrawImage(PictureBox4.BackgroundImage, new Rectangle(75, 17, 69, 17));
                        e.Graphics.DrawImage(My.Resources.Resources.wtcLogoCard11, 39, 40);
                        e.Graphics.DrawString("WTCgroup.com", new Font("Audiowide", 7f, FontStyle.Regular), Brushes.Black, 91f, 93f);
                        employeePictureBox.BorderStyle = BorderStyle.FixedSingle;
                        e.Graphics.DrawImage(employeePictureBox.BackgroundImage, new Rectangle(57, 110, 100, 120));
                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(57, 110, 100, 120));
                        e.Graphics.DrawImage(My.Resources.Resources.redBackground, new Rectangle(0, 235, 213, 105));
                        var StringAlign = new StringFormat();
                        StringAlign.Alignment = StringAlignment.Center;
                        StringAlign.LineAlignment = StringAlignment.Far;
                        e.Graphics.DrawString(nameLabel.Text, new Font("MagistralC", 14f, FontStyle.Bold), Brushes.White, new Rectangle(0, 242, 213, 25), StringAlign);

                        // e.Graphics.DrawString(employeeName, drawFont, drawBrush,
                        // drawRect, drawFormat)

                        e.Graphics.DrawString(positionLabel.Text, new Font("MagistralC", 12f), Brushes.Black, new Rectangle(0, 257, 213, 30), StringAlign);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(58, 310, 100, 50));
                        e.Graphics.DrawString("ID: " + idLabel.Text, new Font("Roboto", 8f, FontStyle.Bold), Brushes.Red, 84f, 324f);
                        e.Graphics.DrawString(barcodeLabel.Text, new Font("IDAutomationHC39M", 16f), Brushes.Black, new Rectangle(28, 299, 200, 25));
                        index = i + 1;
                        totalPages -= 1;
                        if (totalPages != 0)
                        {
                            e.HasMorePages = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        e.Graphics.DrawImage(My.Resources.Resources.wtcLogoCard11, 39, 10);
                        e.Graphics.DrawString("WTCgroup.com", new Font("Audiowide", 7f, FontStyle.Regular), Brushes.Black, 91f, 63f);
                        employeePictureBox.BorderStyle = BorderStyle.FixedSingle;
                        e.Graphics.DrawImage(employeePictureBox.BackgroundImage, new Rectangle(57, 80, 100, 120));
                        e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(57, 80, 100, 120));
                        e.Graphics.DrawImage(My.Resources.Resources.redBackground, new Rectangle(0, 210, 213, 130));
                        var StringAlign = new StringFormat();
                        StringAlign.Alignment = StringAlignment.Center;
                        StringAlign.LineAlignment = StringAlignment.Far;
                        e.Graphics.DrawString(nameLabel.Text, new Font("MagistralC", 14f, FontStyle.Bold), Brushes.White, new Rectangle(0, 220, 213, 25), StringAlign);

                        // e.Graphics.DrawString(employeeName, drawFont, drawBrush,
                        // drawRect, drawFormat)

                        e.Graphics.DrawString(positionLabel.Text, new Font("MagistralC", 12f), Brushes.Black, new Rectangle(0, 243, 213, 30), StringAlign);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(58, 310, 100, 50));
                        e.Graphics.DrawString("ID: " + idLabel.Text, new Font("Roboto", 8f, FontStyle.Bold), Brushes.Red, 84f, 324f);
                        e.Graphics.DrawString(barcodeLabel.Text, new Font("IDAutomationHC39M", 16f), Brushes.Black, new Rectangle(28, 289, 200, 30));
                        index = i + 1;
                        totalPages -= 1;
                        if (totalPages != 0)
                        {
                            e.HasMorePages = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            // Times New Roman
        }

        private bool lowerSettings = false;

        private void populateInfo()
        {
            int selectedItem = employeesListView.FocusedItem.Index;
            foreach (DataRow employee in (IEnumerable)db.getEmployee(Conversions.ToInteger(employeesListView.Items[selectedItem].SubItems[1].Text)).Rows)
            {
                NameTextBox.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(employee["First_Name"], " "), employee["Last_Name"]));
                nameLabel.Text = NameTextBox.Text;
                PositionTextBox.Text = Conversions.ToString(employee["Job_Description"]);
                positionLabel.Text = PositionTextBox.Text;
                IDTextBox.Text = Conversions.ToString(employee["ID"]);
                string zeros = "";
                for (int i = IDTextBox.Text.Length; i <= 4; i++)
                    zeros += "0";
                idLabel.Text = zeros + IDTextBox.Text;
                barcodeLabel.Text = "*" + idLabel.Text + "*";
                var ftpModule = new MdlFtp();
                Bitmap ImageFromDB;
                if (!Information.IsDBNull(employee["EmployeePicturePath"]) && !employee["EmployeePicturePath"].Equals(""))
                {
                    ImageFromDB = ftpModule.GetFTPImage(Conversions.ToString(employee["EmployeePicturePath"]));
                    employeePictureBox.BackgroundImage = ImageFromDB;
                }
                else
                {
                    employeePictureBox.BackgroundImage = null;
                }
            }

            string[] names;
            var namesModified = default(string);
            nameLabel.Text = Strings.Trim(nameLabel.Text);
            names = nameLabel.Text.Split(' ');
            for (int i = 0, loopTo = names.Count() - 1; i <= loopTo; i++)
            {
                string name_ = names[i];
                if (!name_.Equals(""))
                {
                    name_ = name_.ToLower();
                    name_ = name_.Substring(0, 1).ToUpper() + name_.Substring(1, name_.Length - 1);
                    namesModified += name_.ToString() + " ";
                }
            }

            nameLabel.Text = Strings.Trim(namesModified);
            lowNameLabel.Text = nameLabel.Text;
            lowPictureBox.BackgroundImage = employeePictureBox.BackgroundImage;
            lowPositionLabe.Text = positionLabel.Text;
            lowIdLabel.Text = idLabel.Text;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                employeesListView.Items.OfType<ListViewItem>().All(c =>
                {
                    c.Checked = true;
                    return true;
                });
            }
            else
            {
                employeesListView.Items.OfType<ListViewItem>().All(c =>
                {
                    c.Checked = false;
                    return true;
                });
            }
        }

        private void PositionTextBox_TextChanged(object sender, EventArgs e)
        {
            positionLabel.Text = PositionTextBox.Text;
            lowPositionLabe.Text = PositionTextBox.Text;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] names;
            var namesModified = default(string);
            nameLabel.Text = Strings.Trim(NameTextBox.Text);
            names = nameLabel.Text.Split(' ');
            for (int i = 0, loopTo = names.Count() - 1; i <= loopTo; i++)
            {
                string name_ = names[i];
                if (!name_.Equals(""))
                {
                    name_ = name_.ToLower();
                    name_ = name_.Substring(0, 1).ToUpper() + name_.Substring(1, name_.Length - 1);
                    namesModified += name_.ToString() + " ";
                }
            }

            nameLabel.Text = namesModified;
            lowNameLabel.Text = namesModified;
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                lowerSettingsPanel.Show();
                lowerSettingsPanel.BringToFront();
            }
            else
            {
                normalSettingPanel.BringToFront();
            }

            Button1.BringToFront();
        }
    }
}