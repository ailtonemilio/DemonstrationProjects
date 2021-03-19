using Bunifu.ToggleSwitch;
using Bunifu.UI.WinForms;
using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmCFIALabel
    {
        public FrmCFIALabel()
        {
            InitializeComponent();
            _unitNumberTextBox.Name = "unitNumberTextBox";
            _sampletitlecombobox.Name = "sampletitlecombobox";
            _cboBooking.Name = "cboBooking";
            _selectAllCheckBox.Name = "selectAllCheckBox";
            _dgvUnits.Name = "dgvUnits";
            _tgActiveBooking.Name = "tgActiveBooking";
            _BunifuToggleSwitch1.Name = "BunifuToggleSwitch1";
            _printButton.Name = "printButton";
            _pasteBunifuButton.Name = "pasteBunifuButton";
            _addBttn.Name = "addBttn";
            _printLabelsBunifuButton.Name = "printLabelsBunifuButton";
            _RichTextBox1.Name = "RichTextBox1";
            _deleteBunifuButton1.Name = "deleteBunifuButton1";
            _RichTextBox2.Name = "RichTextBox2";
            _deleteBunifuButto2.Name = "deleteBunifuButto2";
            _RichTextBox3.Name = "RichTextBox3";
            _FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            _deleteBunifuButton3.Name = "deleteBunifuButton3";
            _RichTextBox4.Name = "RichTextBox4";
        }

        public struct unitgrades
        {
            public string unitnumber;
            public short numberofcommodities;
            public string g1;
            public string c1;
            public string g2;
            public string c2;
        }
        int currentChar = 0;
        private int hh = 0;
        private int pagestoprint = 0;
        private int lineperpage;
        private int i_start;
        private int i_start_items;
        private object i_counter;
        private string gradeandcomodidty = "";
        private bool firstpage = true;
        private int numbOfCargoLbls = 1;
        private ToolTip tooltip = new ToolTip();

        private void frmcfialabel_load(object sender, EventArgs e)
        {
            tooltip.SetToolTip(pasteBunifuButton, "Paste");
            tooltip.SetToolTip(addBttn, "Add Label");
            MdlOptionsManagement.getCFIALabelFunctionalities(this);
            {
                var withBlock = cboBooking;
                withBlock.DataSource = MinibookingService.GetJointBooking(tgActiveBooking.Value);
                withBlock.DisplayMember = "BookingNumber";
                withBlock.ValueMember = "MinibookingId";
            }

            cboBooking.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboBooking.AutoCompleteSource = AutoCompleteSource.ListItems;

            // tbCustomer.DroppedDown = True
            fromdatetimepicker.Value = DateAndTime.Now;
            todatetimepicker.Value = DateAndTime.Now;
            sampletitlecombobox.SelectedIndex = 1;
            resizeCagoLabels(1);
        }

        private void resizeCagoLabels(int numOfLabels)
        {
            addBttn.Show();
            deleteBunifuButton1.Show();
            deleteBunifuButto2.Show();
            deleteBunifuButton3.Show();
            if (numbOfCargoLbls == 1)
            {
                mainLabelPanel.Size = (Size)new Point(590, 450);
                mainLabelPanel.Location = new Point((int)Math.Round(Width / 2d - 350d), (int)Math.Round(Height / 2d - 295d));
                addBttn.Location = new Point((int)Math.Round(Width / 2d + 350d), (int)Math.Round(Height / 2d - 120d));
            }
            else if (numbOfCargoLbls == 2)
            {
                mainLabelPanel.Size = (Size)new Point(1189, 450);
                mainLabelPanel.Location = new Point((int)Math.Round(Width / 2d - 606d), (int)Math.Round(Height / 2d - 295d));
                addBttn.Location = new Point((int)Math.Round(Width / 2d - 350d), (int)Math.Round(Height / 2d + 200d));
            }
            else if (numbOfCargoLbls == 3)
            {
                mainLabelPanel.Size = (Size)new Point(1189, 903);
                mainLabelPanel.Location = new Point((int)Math.Round(Width / 2d - 606d), (int)Math.Round(Height / 2d - 495d));
                addBttn.Location = new Point((int)Math.Round(Width / 2d + 250d), (int)Math.Round(Height / 2d + 10d));
                deleteBunifuButton1.Hide();
                labelPanel4.Hide();
            }
            else if (numbOfCargoLbls == 4)
            {
                mainLabelPanel.Size = (Size)new Point(1189, 903);
                mainLabelPanel.Location = new Point((int)Math.Round(Width / 2d - 606d), (int)Math.Round(Height / 2d - 495d));
                deleteBunifuButton1.Hide();
                deleteBunifuButto2.Hide();
                addBttn.Hide();
                labelPanel4.Show();
            }

            pagesToPrintCargo = numOfLabels;
        }

        private void printdocument1_printpage(object sender, PrintPageEventArgs e)
        {
            VW_MinibookingMiniUnitAssignment unitRow;
            if (sampletitlecombobox.SelectedIndex != 0)
            {
                if (BunifuToggleSwitch1.Value == false)
                {
                    for (int i = i_start, loopTo = dgvUnits.Rows.Count - 1; i <= loopTo; i++)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvUnits.Rows[i].Cells[0].Value, true, false)))
                        {
                            unitRow = (VW_MinibookingMiniUnitAssignment)dgvUnits.Rows[i].DataBoundItem;
                            hh += 50;
                            int titleposition;
                            int customerposition;
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(sampletitlecombobox.SelectedItem.ToString().Length, 10, false)))
                            {
                                titleposition = 40;
                            }
                            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLess(sampletitlecombobox.SelectedItem.ToString().Length, 5, false)))
                            {
                                titleposition = 110;
                            }
                            else
                            {
                                titleposition = 50;
                            }

                            if (Strings.Trim(tbCustomer.Text).Length > 1 & Strings.Trim(tbCustomer.Text).Length <= 20)
                            {
                                customerposition = 75;
                            }
                            else if (Strings.Trim(tbCustomer.Text).Length >= 20 & Strings.Trim(tbCustomer.Text).Length <= 25)
                            {
                                customerposition = 30;
                            }
                            else
                            {
                                customerposition = 0;
                            }

                            e.Graphics.DrawImage(My.Resources.Resources.wtc, new Rectangle(15, 15, 100, 65));
                            e.Graphics.DrawString(Conversions.ToString(sampletitlecombobox.SelectedItem), new Font("times new roman", 17f), Brushes.Black, titleposition + 85, hh - 5);
                            hh += 60;
                            e.Graphics.DrawString("Unit: " + unitRow.MiniUnitNumber, new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                            if (fromdatetimepicker.Value.Date == todatetimepicker.Value.Date)
                            {
                                e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 220f, hh);
                            }
                            else
                            {
                                e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy") + "            To: " + todatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 220f, hh);
                            }

                            // e.graphics.drawstring("date: " + fromdatetimepicker.value.date.tostring("mmm dd, yyyy"),
                            // new system.drawing.font("times new roman", 12), brushes.black, 220, hh)
                            hh += 45;
                            e.Graphics.DrawString("Shipper: " + Strings.Trim(tbCustomer.Text), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                            hh += 45;
                            e.Graphics.DrawString("Commodity: " + unitRow.CommodityGrade, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                            hh += 45;
                            e.Graphics.DrawString("Booking #: " + cboBooking.Text, new Font("times new roman", 12f), Brushes.Black, 20f, hh);

                            // If tempunitgrade.numberofcommodities > 1 Then
                            // tempunitgrade.numberofcommodities -= 1
                            // 'pagestoprint += 1
                            // gradeandcomodidty = Trim(db.getGradesAndCommodities("grade", "[gradecode]='" + tempunitgrade.g2 + "'").rows(0).item("gradename")) + " " +
                            // Trim(db.getGradesAndCommodities("commodity", "[commoditycode]='" + tempunitgrade.c2 + "'").rows(0).item("commodityname"))
                            // hh = 0
                            // e.HasMorePages = True
                            // firstpage = False
                            // Exit For
                            // End If

                            if (pagestoprint - 1 > 0)
                            {
                                e.HasMorePages = true;
                                i_start += 1;
                                pagestoprint -= 1;
                                hh = 0;
                                firstpage = true;
                                break;
                            }
                        }

                        i_start += 1;
                        hh = 0;
                        if (pagestoprint == 0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    hh += 50;
                    int titleposition;
                    int customerposition;
                    if (sampletitlecombobox.Text.Length > 10)
                    {
                        titleposition = 40;
                    }
                    else if (sampletitlecombobox.Text.Length < 5)
                    {
                        titleposition = 110;
                    }
                    else
                    {
                        titleposition = 50;
                    }

                    if (Strings.Trim(tbCustomer.Text).Length > 1 & Strings.Trim(tbCustomer.Text).Length <= 20)
                    {
                        customerposition = 75;
                    }
                    else if (Strings.Trim(tbCustomer.Text).Length >= 20 & Strings.Trim(tbCustomer.Text).Length <= 25)
                    {
                        customerposition = 30;
                    }
                    else
                    {
                        customerposition = 0;
                    }

                    e.Graphics.DrawImage(My.Resources.Resources.wtc, new Rectangle(15, 15, 100, 65));
                    e.Graphics.DrawString(sampletitlecombobox.Text, new Font("times new roman", 17f), Brushes.Black, titleposition + 85, hh - 5);
                    hh += 60;
                    e.Graphics.DrawString("Unit: " + unitNumberTextBox.Text.ToString(), new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                    if (unitNumberTextBox.Text.Length > 13)
                    {
                        hh += 35;
                        if (fromdatetimepicker.Value.Date == todatetimepicker.Value.Date)
                        {
                            e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        }
                        else
                        {
                            e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy") + "             To: " + todatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        }

                        hh += 35;
                        e.Graphics.DrawString("Shipper: " + Strings.Trim(tbCustomer.Text), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        hh += 35;
                        e.Graphics.DrawString("Commodity: " + commodityTextBox.Text, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        hh += 35;
                        e.Graphics.DrawString("Booking #: " + cboBooking.Text, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                    }
                    else
                    {
                        if (fromdatetimepicker.Value.Date == todatetimepicker.Value.Date)
                        {
                            e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 220f, hh);
                        }
                        else
                        {
                            e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy") + "             To: " + todatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 220f, hh);
                        }

                        hh += 45;
                        e.Graphics.DrawString("Shipper: " + Strings.Trim(tbCustomer.Text), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        hh += 45;
                        e.Graphics.DrawString("Commodity: " + commodityTextBox.Text, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        hh += 45;
                        e.Graphics.DrawString("Booking #: " + cboBooking.Text, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                    }
                }
            }
            else if (BunifuToggleSwitch1.Value == false)
            {
                for (int i = i_start, loopTo1 = dgvUnits.Rows.Count - 1; i <= loopTo1; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvUnits.Rows[i].Cells[0].Value, true, false)))
                    {
                        unitRow = (VW_MinibookingMiniUnitAssignment)dgvUnits.Rows[i].DataBoundItem;
                        hh += 50;
                        int titleposition;
                        int customerposition;
                        if (sampletitlecombobox.Text.Length > 10)
                        {
                            titleposition = 40;
                        }
                        else if (sampletitlecombobox.Text.Length < 5)
                        {
                            titleposition = 110;
                        }
                        else
                        {
                            titleposition = 50;
                        }

                        if (Strings.Trim(tbCustomer.Text).Length > 1 & Strings.Trim(tbCustomer.Text).Length <= 20)
                        {
                            customerposition = 75;
                        }
                        else if (Strings.Trim(tbCustomer.Text).Length >= 20 & Strings.Trim(tbCustomer.Text).Length <= 25)
                        {
                            customerposition = 30;
                        }
                        else
                        {
                            customerposition = 0;
                        }

                        e.Graphics.DrawImage(My.Resources.Resources.wtc, new Rectangle(15, 15, 100, 65));
                        e.Graphics.DrawString(sampletitlecombobox.Text, new Font("times new roman", 17f), Brushes.Black, titleposition + 85, hh - 5);
                        hh += 45;
                        // e.graphics.drawstring("(" + Trim(tbCustomer.Text) + ")", new system.drawing.font("times new roman", 10), brushes.black, customerposition + 80, hh + 10)

                        e.Graphics.DrawString("Sample ID: " + cboBooking.Text, new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                        hh += 38;
                        if (BunifuToggleSwitch1.Value == false)
                        {
                            e.Graphics.DrawString("Unit: " + unitRow.MiniUnitNumber, new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                        }
                        else
                        {
                            e.Graphics.DrawString("Unit: " + unitNumberTextBox.Text.ToString(), new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                            BunifuToggleSwitch1.Value = false;
                        }

                        hh += 38;
                        if (fromdatetimepicker.Value.Date == todatetimepicker.Value.Date)
                        {
                            e.Graphics.DrawString("Sample Date: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        }
                        else
                        {
                            e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy") + "             To: " + todatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        }

                        hh += 38;

                        // e.graphics.drawstring("booking #: " + bookingsnumbcombobox.selecteditem,
                        // new system.drawing.font("times new roman", 12), brushes.black, 20, hh)

                        e.Graphics.DrawString("Shipper: " + Strings.Trim(tbCustomer.Text), new Font("Times new roman", 12f), Brushes.Black, 20f, hh);
                        hh += 38;
                        e.Graphics.DrawString("Commodity: " + unitRow.CommodityGrade, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                        hh += 38;

                        // If tempunitgrade.numberofcommodities > 1 Then
                        // tempunitgrade.numberofcommodities -= 1
                        // 'pagestoprint += 1
                        // gradeandcomodidty = Trim(db.getGradesAndCommodities("Grade", "[gradecode]='" + tempunitgrade.g2 + "'").rows(0).item("gradename")) + " " +
                        // Trim(db.getGradesAndCommodities("commodity", "[commoditycode]='" + tempunitgrade.c2 + "'").rows(0).item("commodityname"))
                        // hh = 0
                        // e.HasMorePages = True
                        // firstpage = False
                        // Exit For
                        // End If

                        if (pagestoprint - 1 > 0)
                        {
                            e.HasMorePages = true;
                            i_start += 1;
                            pagestoprint -= 1;
                            hh = 0;
                            firstpage = true;
                            break;
                        }
                    }

                    i_start += 1;
                    hh = 0;
                    if (pagestoprint == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                hh += 50;
                int titleposition;
                int customerposition;
                if (sampletitlecombobox.Text.Length > 10)
                {
                    titleposition = 40;
                }
                else if (sampletitlecombobox.Text.Length < 5)
                {
                    titleposition = 110;
                }
                else
                {
                    titleposition = 50;
                }

                if (Strings.Trim(tbCustomer.Text).Length > 1 & Strings.Trim(tbCustomer.Text).Length <= 20)
                {
                    customerposition = 75;
                }
                else if (Strings.Trim(tbCustomer.Text).Length >= 20 & Strings.Trim(tbCustomer.Text).Length <= 25)
                {
                    customerposition = 30;
                }
                else
                {
                    customerposition = 0;
                }

                e.Graphics.DrawImage(My.Resources.Resources.wtc, new Rectangle(15, 15, 100, 65));
                e.Graphics.DrawString(sampletitlecombobox.Text, new Font("times new roman", 17f), Brushes.Black, titleposition + 85, hh - 5);
                hh += 45;
                // e.graphics.drawstring("(" + Trim(tbCustomer.Text) + ")", new system.drawing.font("times new roman", 10), brushes.black, customerposition + 80, hh + 10)

                e.Graphics.DrawString("Sample ID: " + cboBooking.Text, new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                hh += 38;
                e.Graphics.DrawString("Unit: " + unitNumberTextBox.Text.ToString(), new Font("times new roman", 13f, FontStyle.Bold), Brushes.Black, 20f, hh);
                hh += 38;
                if (fromdatetimepicker.Value.Date == todatetimepicker.Value.Date)
                {
                    e.Graphics.DrawString("Sample Date " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                }
                else
                {
                    e.Graphics.DrawString("From: " + fromdatetimepicker.Value.Date.ToString("MMM dd, yyyy") + "             To: " + todatetimepicker.Value.Date.ToString("MMM dd, yyyy"), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                }

                hh += 38;
                e.Graphics.DrawString("Shipper: " + Strings.Trim(tbCustomer.Text), new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                hh += 38;
                e.Graphics.DrawString("Commodity: " + commodityTextBox.Text, new Font("times new roman", 12f), Brushes.Black, 20f, hh);
                hh += 38;
            }
        }

        private object index = 0;
        private DatabaseHelperCeres db = new DatabaseHelperCeres();

        private void button1_click(object sender, EventArgs e)
        {
            firstpage = true;
            pagestoprint = 0;
            if (dgvUnits.SelectedRows.Count > 0 & !string.IsNullOrEmpty(sampletitlecombobox.Text) & !string.IsNullOrEmpty(Strings.Trim(tbCustomer.Text).Length.ToString()) & !string.IsNullOrEmpty(cboBooking.Text.Length.ToString()) | BunifuToggleSwitch1.Value == true)
            {
                i_start_items = 0;
                i_start = 0;
                hh = 0;
                index = 0;
                PrintDialog1.Document = PrintDocument1;
                for (int i = 0, loopTo = dgvUnits.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvUnits.Rows[i].Cells[0].Value, true, false)))
                    {
                        pagestoprint += 1;
                    }
                }

                if (PrintDialog1.ShowDialog() == DialogResult.OK)
                {
                    PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings;
                    var new_paper = new PaperSize("", 400, 300);
                    new_paper.PaperName = ((int)PaperKind.Custom).ToString();
                    var new_margin = new Margins();
                    new_margin.Left = 10;
                    new_margin.Top = 10;
                    {
                        var withBlock = PrintDocument1;
                        withBlock.DefaultPageSettings.PaperSize = new_paper;
                        withBlock.DefaultPageSettings.Margins = new_margin;
                        withBlock.PrinterSettings.DefaultPageSettings.Landscape = false;
                        withBlock.Print();
                    }
                }

                warningLabel.Text = "";
            }
            else
            {
                warningLabel.Text = "Please make sure to select the units to be printed";
            }
        }

        private object completecommodityinfo;

        public void populateunits()
        {
            VW_BookingMinibooking selectedMB = (VW_BookingMinibooking)cboBooking.SelectedItem;
            tbCustomer.Text = selectedMB.CustomerName;
            VWMinibookingMiniUnitAssignmentBindingSource.DataSource = MinibookingMiniUnitAssignmentService.GetByMiniBookingId(selectedMB.MiniBookingId);
        }

        // Private Sub customercombo_selectedindexchanged(sender As Object, e As EventArgs)
        // populatebookingcombobox()
        // End Sub

        private void sampletitlecombobox_selectedindexchanged(object sender, EventArgs e)
        {
            if (sampletitlecombobox.SelectedIndex == 0)
            {
                bookingIDLabel.Text = "Sample ID:";
                customerLabel.Text = "Shipper:";
            }
            else
            {
                bookingIDLabel.Text = "Booking #:";
                customerLabel.Text = "Customer:";
            }
        }

        private int selecteunitindex = 0;

        private void unitslistview_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnits.Rows.Count > 0)
            {
                VW_MinibookingMiniUnitAssignment unitRow = (VW_MinibookingMiniUnitAssignment)dgvUnits.CurrentRow.DataBoundItem;
                gradeAndComodityLabe.Text = unitRow.CommodityGrade;
            }
            else
            {
                gradeAndComodityLabe.Text = "";
            }
        }

        private void sampleidcfiacombobox_selectedindexchanged(object sender, EventArgs e)
        {
            populateunits();
        }

        private void checkbox2_checkedchanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(c.Checked, true, false)))
            {
                for (int i = 0, loopTo = dgvUnits.Rows.Count - 1; i <= loopTo; i++)
                    dgvUnits.Rows[i].Cells[0].Value = true;
            }
            else
            {
                for (int i = 0, loopTo1 = dgvUnits.Rows.Count - 1; i <= loopTo1; i++)
                    dgvUnits.Rows[i].Cells[0].Value = false;
            }
        }

        private void bunifutoggleswitch1_onvaluechange(object sender, EventArgs e)
        {
            BunifuToggleSwitch b = (BunifuToggleSwitch)sender;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(b.Value, true, false)))
            {
                typeUnitPanel.Visible = true;
                selectUnitPanel.Visible = false;
                Label2.Hide();
                gradeAndComodityLabe.Hide();
            }
            else
            {
                typeUnitPanel.Visible = false;
                selectUnitPanel.Visible = true;
                Label2.Show();
                gradeAndComodityLabe.Show();
            }
        }

        private void bookingsnumbcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateunits();
        }

        private void unitiesBunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvUnits.Rows[e.RowIndex].Cells[0].Value, true, false)))
            {
                dgvUnits.Rows[e.RowIndex].Cells[0].Value = false;
            }
            else
            {
                dgvUnits.Rows[e.RowIndex].Cells[0].Value = true;
            }
        }

        private void checkbox2_checkedchanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
        }

        private int pagesToPrintCargo;

        private void addBttn_Click(object sender, EventArgs e)
        {
            numbOfCargoLbls += 1;
            resizeCagoLabels(numbOfCargoLbls);
        }

        private void deleteBunifuButton3_Click(object sender, EventArgs e)
        {
            numbOfCargoLbls = 3;
            resizeCagoLabels(numbOfCargoLbls);
        }

        private void deleteBunifuButto2_Click(object sender, EventArgs e)
        {
            numbOfCargoLbls = 2;
            resizeCagoLabels(numbOfCargoLbls);
        }

        private void deleteBunifuButton1_Click(object sender, EventArgs e)
        {
            numbOfCargoLbls = 1;
            resizeCagoLabels(numbOfCargoLbls);
        }

        private int h, w;
        private int left, top;

        private void printLabelsBunifuButton_Click(object sender, EventArgs e)
        {
            i_start_items = 0;
            i_start = 0;
            hh = 0;
            pageText = RichTextBox1;
            PrintDialog2.Document = PrintDocument2;
            focusedTextBox = 1;
            y = 0;
            heightr = 0;
            h = 0;
            w = 0;
            left = 0;
            top = 0;
            {
                var withBlock = PrintDocument1.DefaultPageSettings;
                h = 290;
                w = 390;
                left = 10;
                top = 20;
            }

            if (PrintDocument1.DefaultPageSettings.Landscape)
            {
                int a;
                a = h;
                h = w;
                w = a;
            }

            for (int i = 0, loopTo = dgvUnits.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dgvUnits.Rows[i].Cells[0].Value, true, false)))
                {
                    pagestoprint += 1;
                }
            }

            pagesToPrintCargo = numbOfCargoLbls;
            if (PrintDialog2.ShowDialog() == DialogResult.OK)
            {
                PrintDialog2.PrinterSettings = PrintDocument2.PrinterSettings;
                var new_paper = new PaperSize("", 400, 300);
                new_paper.PaperName = ((int)PaperKind.Custom).ToString();
                var new_margin = new Margins();
                new_margin.Left = 10;
                new_margin.Top = 10;
                {
                    var withBlock1 = PrintDocument2;
                    withBlock1.DefaultPageSettings.PaperSize = new_paper;
                    withBlock1.DefaultPageSettings.Margins = new_margin;
                    withBlock1.PrinterSettings.DefaultPageSettings.Landscape = false;
                    withBlock1.Print();
                }
            }
        }

        private RichTextBox pageText;
        private int focusedTextBox;
        private int y;
        private int heightr;

        private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            for (int x = 1, loopTo = pagesToPrintCargo; x <= loopTo; x++)
            {
                focusedTextBox = pagesToPrintCargo;
                if (focusedTextBox == 1)
                {
                    pageText = RichTextBox1;
                }
                else if (focusedTextBox == 2)
                {
                    pageText = RichTextBox2;
                }
                else if (focusedTextBox == 3)
                {
                    pageText = RichTextBox3;
                }
                else if (focusedTextBox == 4)
                {
                    pageText = RichTextBox4;
                };



                int currentLine = 0;


                var textfont = pageText.Font;

                // Optional Rectangle Blue.
                // e.Graphics.DrawRectangle(Pens.Blue, New Rectangle(left, top, w, h))

                int lines = (int)Math.Round(Math.Round((double)h / (double)textfont.Height));
                var b = new Rectangle(left, top, w, h);
                StringFormat format;
                var StringAlign = new StringFormat();
                StringAlign.LineAlignment = StringAlignment.Center;
                object t;
                bool twoLines = false;
                bool beforeWastitle = false;
                y = 0;
                heightr = 0;
                for (int i = currentLine, loopTo1 = Math.Min(currentLine + lines, pageText.Lines.Length - 1); i <= loopTo1; i++)
                {
                    t = (object)pageText.Lines[i].Length;
                    if (i == 0 & focusedTextBox == 1)
                    {
                        StringAlign.Alignment = StringAlignment.Center;
                        e.Graphics.DrawString(Strings.Trim(pageText.Lines[i]), new Font("times new roman", 16f, FontStyle.Bold), Brushes.Black, new RectangleF((float)left, (float)(top + textfont.Height * (i - currentLine)), (float)w, (float)textfont.Height), StringAlign);
                        beforeWastitle = true;
                    }
                    else
                    {
                        StringAlign.Alignment = StringAlignment.Near;
                        int s = textfont.Height * (i - currentLine);
                        if (focusedTextBox == 1)
                        {
                            if (beforeWastitle & !Strings.Trim(pageText.Lines[i]).Equals(""))
                            {
                                y += 50; // + addy + textfont.Height * (i - currentLine)
                                beforeWastitle = false;
                            }
                            else if (Strings.Trim(pageText.Lines[i]).Equals(""))
                            {
                                y += 0;
                            }
                            else if (twoLines)
                            {
                                y += 20;
                            }
                            else
                            {
                                y += 15;
                            }

                            heightr += 20; // textfont.Height + addVal
                        }
                        else
                        {
                            if (twoLines)
                            {
                                y += 30;
                            }
                            else
                            {
                                y += 15;
                            }

                            heightr += 20;
                        } // textfont.Height + addVal

                        e.Graphics.DrawString(pageText.Lines[i], new Font("times new roman", 10f), Brushes.Black, new RectangleF((float)left, (float)y, (float)w, (float)heightr), StringAlign);
                        if (focusedTextBox == 1)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(t, 40, false)))
                            {
                                twoLines = true;
                            }
                            else
                            {
                                twoLines = false;
                            }
                        }
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(t, 30, false)))
                        {
                            twoLines = true;
                        }
                        else
                        {
                            twoLines = false;
                        }
                    }
                }

                pagesToPrintCargo -= 1;
                if (pagesToPrintCargo == 0)
                {
                    e.HasMorePages = false;
                }
                else
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            // If currentLine >= pageText.Lines.Length Then
            // e.HasMorePages = False
            // currentLine = 0
            // Else
            // e.HasMorePages = True
            // End If
            // Exit Sub

        }



        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {

                // Code for Copy Action
                if (!string.IsNullOrEmpty(RichTextBox1.Text))
                {
                    RichTextBox1.Font = new Font("times new roman", 14f, FontStyle.Regular);
                    RichTextBox1.ForeColor = Color.Black;
                    string firstLine = RichTextBox1.Lines[0];
                    RichTextBox1.Select(RichTextBox1.GetFirstCharIndexFromLine(0), firstLine.Length);
                    RichTextBox1.SelectionFont = new Font("times new roman", 20f, FontStyle.Bold);
                }
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                focusedRichTextBox.Text = My.MyProject.Computer.Clipboard.GetText();
                if (!string.IsNullOrEmpty(focusedRichTextBox.Text))
                {
                    focusedRichTextBox.Font = new Font("times new roman", 14f, FontStyle.Regular);
                    focusedRichTextBox.ForeColor = Color.Black;
                    if (focusedRichTextBox.Equals(RichTextBox1))
                    {
                        string firstLine = focusedRichTextBox.Lines[0];
                        focusedRichTextBox.Select(focusedRichTextBox.GetFirstCharIndexFromLine(0), firstLine.Length);
                        focusedRichTextBox.SelectionFont = new Font("times new roman", 22f, FontStyle.Bold);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select the label you want to paste the copied text", "Select Label");
            }
        }

        private RichTextBox focusedRichTextBox;

        private void RichTextBox1_GotFocus(object sender, EventArgs e)
        {
            focusedRichTextBox = RichTextBox1;
        }

        private void RichTextBox2_GotFocus(object sender, EventArgs e)
        {
            focusedRichTextBox = RichTextBox2;
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void unitNumberTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void RichTextBox3_GotFocus(object sender, EventArgs e)
        {
            focusedRichTextBox = RichTextBox3;
        }

        private void tgActiveBooking_OnValuechange(object sender, EventArgs e)
        {
            cboBooking.DataSource = MinibookingService.GetJointBooking(tgActiveBooking.Value);
        }

        private void RichTextBox4_GotFocus(object sender, EventArgs e)
        {
            focusedRichTextBox = RichTextBox4;
        }

        private void dgvUnits_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUnits.Rows.Count > 0)
            {
                VW_MinibookingMiniUnitAssignment unitRow = (VW_MinibookingMiniUnitAssignment)dgvUnits.CurrentRow.DataBoundItem;
                My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                var unit = UnitSourceService.GetVWById(unitRow.UnitSourceId);
                var unitList = new List<VW_UnitSource>();
                unitList.Add(unit);
                My.MyProject.Forms.FrmEditAddRailList.isNewRecord = false;
                My.MyProject.Forms.FrmEditAddRailList.isMultiEdit = false;
                My.MyProject.Forms.FrmEditAddRailList.LoadForm(unitList);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditAddRailList, ParentForm);
                populateunits();
            }
        }
    }
}