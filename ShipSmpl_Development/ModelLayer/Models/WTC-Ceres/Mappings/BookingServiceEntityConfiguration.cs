using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BookingServiceEntityConfiguration : EntityTypeConfiguration<BookingService>
    {
        public BookingServiceEntityConfiguration()
        {
            this.Property(e => e.ServiceCode)
            .IsUnicode(false);

            this.Property(e => e.ServiceName)
                .IsUnicode(false);
        }
    }
}