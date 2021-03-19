using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Data;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlContactsModifySaveData
    {
        private static DatabaseHelperCeres db = new DatabaseHelperCeres();

        // Public Function formatPhoneNumberContacts(ByVal strPhoneNumber As String) As String

        // If Not String.IsNullOrEmpty(strPhoneNumber) Then
        // 'If Regex.IsMatch(strPhoneNumber, "^[0-9 ]+$") Then

        // strPhoneNumber = Replace(strPhoneNumber, ")", "")
        // strPhoneNumber = Replace(strPhoneNumber, "(", "")
        // strPhoneNumber = Replace(strPhoneNumber, "-", "")
        // strPhoneNumber = Replace(strPhoneNumber, ".", "")
        // strPhoneNumber = Replace(strPhoneNumber, "+", "")
        // strPhoneNumber = Replace(strPhoneNumber, Space(1), "")
        // If Not strPhoneNumber.Equals("") Then
        // strPhoneNumber = CLng(strPhoneNumber).ToString("(###) ###-###")
        // End If
        // 'Else
        // 'strPhoneNumber = "Wrong format"
        // 'End If

        // End If

        // Return strPhoneNumber
        // End Function

        // Public Sub populateCountriesCombo(ByVal countries As ComboBox)
        // Dim count As Integer = 0
        // For Each country In db.getTableInfo("Countries", "Name, code", "order by name").Rows

        // countries.Items.Add(country("name") + " - " + country("code"))
        // Next

        // countries.SelectedIndex = 0
        // End Sub

        public static void populateProvincesCombo(ComboBox province, ComboBox countries, ComboBox city)
        {
            province.Items.Clear();
            if (!countries.SelectedItem.Equals(""))
            {
                foreach (DataRow country in db.getTableInfo("Transport_Locations", "distinct(Sub_Division)", " where Country_Code = '" + Strings.Trim(countries.SelectedItem.ToString().Split('-')[1]) + "' and Sub_Division is not null order by Sub_Division").Rows)
                    province.Items.Add(country["Sub_Division"]);
            }

            if (province.Items.Count > 1)
            {
                province.SelectedIndex = 0;
            }
            else
            {
                province.Items.Clear();
                city.Items.Clear();
            }
        }

        public static void populateCitiesCombo(ComboBox city, ComboBox country, ComboBox province)
        {
            city.Items.Clear();
            if (!country.SelectedItem.Equals(""))
            {
                foreach (DataRow cit in db.getTableInfo("Transport_Locations", "distinct(Name)", Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(" where Sub_Division = '", province.SelectedItem), "' and name is not null and Country_Code = '"), Strings.Trim(country.SelectedItem.ToString().Split('-')[1])), "' order by name"))).Rows)
                    city.Items.Add(cit["Name"]);
            }

            if (city.Items.Count > 0)
            {
                city.SelectedIndex = 0;
            }
        }

        public static void populateEdi(int companyID)
        {
            foreach (DataRow info in db.getTableInfo("[Shipping Line EDI]", "*", "where [Shipping Line ID] = " + companyID.ToString()).Rows)
            {
                string countryCode = Conversions.ToString(db.getTableInfo("Countries", "*", Conversions.ToString(Operators.AddObject(Operators.AddObject("where Name = '", info["Country"]), "'"))).Rows[0]["code"]);
                {
                    var withBlock = My.MyProject.Forms.FrmEDI;
                    withBlock.clientTextBox.Text = Conversions.ToString(info["Client ID"]);
                    withBlock.senderTextBox.Text = Conversions.ToString(info["Sender ID"]);
                    withBlock.codeTextBox.Text = Conversions.ToString(info["Client SCAC Code"]);
                    withBlock.versionTextBox.Text = Conversions.ToString(info["Version"]);
                    withBlock.securityCodeTextBox1.Text = Conversions.ToString(info["Security Code"]);
                    withBlock.lineDelimeterTextBox2.Text = Conversions.ToString(info["Line Delimiter"]);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(info["Require EDI"], true, false)))
                    {
                        withBlock.requireEDIInOutGatesCheckBox1.Checked = true;
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(info["Allow PreSend"], true, false)))
                    {
                        withBlock.preSendsCheckBox2.Checked = true;
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(info["Use Email"], true, false)))
                    {
                        withBlock.emailEDICheckBox.Checked = true;
                        withBlock.emailTextBox3.Text = Conversions.ToString(info["Email"]);
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(info["Use FTP"], true, false)))
                    {
                        withBlock.userServerCheckBox.Checked = true;
                        withBlock.serverNameTextBox6.Text = Conversions.ToString(info["Server Name"]);
                        withBlock.userNameTextBox5.Text = Conversions.ToString(info["User Name"]);
                        withBlock.passwordTextBox7.Text = Conversions.ToString(info["Password"]);
                        withBlock.ipAddressTextBox8.Text = Conversions.ToString(info["IP Address"]);
                        withBlock.portNumberNumericUpDown1.Text = Conversions.ToString(info["Port Number"]);
                        withBlock.folderNameTextBox10.Text = Conversions.ToString(info["Folder Name"]);
                        withBlock.prefixTextBox9.Text = Conversions.ToString(info["Booking Prefix"]);
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}