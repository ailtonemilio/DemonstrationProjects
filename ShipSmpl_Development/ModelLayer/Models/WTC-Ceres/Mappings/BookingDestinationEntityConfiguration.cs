using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BookingDestinationEntityConfiguration : EntityTypeConfiguration<BookingDestination>
    {
        public BookingDestinationEntityConfiguration()
        {
            this.Property(e => e.CountryCode)
             .IsUnicode(false);

            this.Property(e => e.OriginalRegionName)
                .IsUnicode(false);

            this.Property(e => e.RegionName)
                .IsUnicode(false);

            this.Property(e => e.City)
                .IsUnicode(false);

            this.Property(e => e.AddressDestination)
                .IsUnicode(false);

            this.Property(e => e.Coordinates)
                .IsUnicode(false);
        }
    }
}