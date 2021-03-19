using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BookingTypeEntityConfiguration : EntityTypeConfiguration<BookingType>
    {
        public BookingTypeEntityConfiguration()
        {
            this.Property(e => e.TypeName)
            .IsUnicode(false);

            this.HasMany(e => e.Booking)
            .WithRequired(e => e.BookingType)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.InboundRequest)
            .WithRequired(e => e.BookingType)
            .WillCascadeOnDelete(false);
        }
    }
}