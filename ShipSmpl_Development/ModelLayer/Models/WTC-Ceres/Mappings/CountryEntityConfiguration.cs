using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CountryEntityConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryEntityConfiguration()
        {
            this.Property(e => e.Code)
            .IsUnicode(false);

            this.Property(e => e.CountryName)
            .IsUnicode(false);

            this.HasMany(e => e.CountryRegion)
            .WithRequired(e => e.Country)
            .WillCascadeOnDelete(false);
        }
    }
}