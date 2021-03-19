using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CompanyAddressEntityConfiguration : EntityTypeConfiguration<CompanyAddress>
    {
        public CompanyAddressEntityConfiguration()
        {
            this.Property(e => e.StreetAddress)
                .IsUnicode(false);

            this.Property(e => e.ZipCode)
                .IsUnicode(false);

            this.Property(e => e.Phone)
                .IsUnicode(false);

            this.Property(e => e.Fax)
                .IsUnicode(false);

            this.Property(e => e.AddressDescription)
                .IsUnicode(false);
        }
    }
}