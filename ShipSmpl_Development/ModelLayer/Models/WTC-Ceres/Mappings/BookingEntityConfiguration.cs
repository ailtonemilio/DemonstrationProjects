using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BookingEntityConfiguration : EntityTypeConfiguration<Booking>
    {
        public BookingEntityConfiguration()
        {
            this.Property(e => e.BookingNumber)
                            .IsUnicode(false);

            this.Property(e => e.ShipperReference)
                .IsUnicode(false);

            this.Property(e => e.ForwarderReference)
                .IsUnicode(false);

            this.Property(e => e.ExporterReference)
                .IsUnicode(false);

            this.HasMany(e => e.BookingCompany)
            .WithRequired(e => e.Booking)
            .WillCascadeOnDelete(false);
        }
    }
}