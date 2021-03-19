using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BookingChangeLogEntityConfiguration : EntityTypeConfiguration<BookingChangeLog>
    {
        public BookingChangeLogEntityConfiguration()
        {
            this.Property(e => e.OldBookingNumber)
         .IsUnicode(false);

            this.Property(e => e.NewBookingNumber)
                .IsUnicode(false);

            this.Property(e => e.CustomerReference)
                .IsUnicode(false);

            this.Property(e => e.ShipperReference)
                .IsUnicode(false);

            this.Property(e => e.ForwarderReference)
                .IsUnicode(false);

            this.Property(e => e.BookingTypeId)
                .IsUnicode(false);

            this.Property(e => e.BookingServiceId)
                .IsUnicode(false);

            this.Property(e => e.BookingStatusId)
                .IsUnicode(false);

            this.Property(e => e.ExporterReference)
            .IsUnicode(false);
        }
    }
}