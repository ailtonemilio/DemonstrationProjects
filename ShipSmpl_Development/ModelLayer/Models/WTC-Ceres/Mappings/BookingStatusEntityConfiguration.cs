using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BookingStatusEntityConfiguration : EntityTypeConfiguration<BookingStatus>
    {
        public BookingStatusEntityConfiguration()
        {
            this.Property(e => e.StatusName)
            .IsUnicode(false);

            this.HasMany(e => e.Booking)
            .WithRequired(e => e.BookingStatus)
            .WillCascadeOnDelete(false);
        }
    }
}