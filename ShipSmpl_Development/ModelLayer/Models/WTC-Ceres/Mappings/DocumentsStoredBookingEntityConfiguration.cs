using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class DocumentsStoredBookingEntityConfiguration : EntityTypeConfiguration<DocumentsStoredBooking>
    {
        public DocumentsStoredBookingEntityConfiguration()
        {
            this.Property(e => e.BookingNumber)
            .IsUnicode(false);
        }
    }
}