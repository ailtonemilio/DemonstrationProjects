using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAddEditDestination
    {
        public FrmAddEditDestination()
        {
            InitializeComponent();
            _doneAddressButton.Name = "doneAddressButton";
            _closeAddressButton.Name = "closeAddressButton";
            _closeLabel.Name = "closeLabel";
        }

        public bool isNewDest;
        private int selDestId;

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void doneAddressButton_Click(object sender, EventArgs e)
        {
            var destService = new BookingDestinationService();
            BookingDestination bkDest;
            if (isNewDest)
            {
                bkDest = new BookingDestination();
                bkDest.BookingDestinationId = default;
            }
            else
            {
                bkDest = BookingDestinationService.GetById(selDestId);
            }

            bkDest.CountryCode = Strings.Trim(tbCountryCode.Text);
            bkDest.OriginalRegionName = Strings.Trim(tbRegionName.Text);
            bkDest.RegionName = Strings.Trim(tbRegionName.Text);
            bkDest.City = Strings.Trim(tbCityName.Text);
            bkDest.AddressDestination = Strings.Trim(addressTextBox.Text);
            bkDest.Coordinates = Strings.Trim(tbCoordinates.Text);
            destService.AddOrUpdate(bkDest);
            Close();
        }

        public void populateDestInfo(VW_BookingDestination bkDest)
        {
            tbCountryCode.Text = bkDest.CountryCode;
            tbRegionName.Text = bkDest.OriginalRegionName;
            tbRegionName.Text = bkDest.RegionName;
            tbCityName.Text = bkDest.City;
            addressTextBox.Text = bkDest.AddressDestination;
            tbCoordinates.Text = bkDest.Coordinates;
            selDestId = bkDest.BookingDestinationId;
        }

        private void closeAddressButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}