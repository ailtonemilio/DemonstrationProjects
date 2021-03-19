using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CountryRegionConfiguration : EntityTypeConfiguration<CountryRegion>
    {
        public CountryRegionConfiguration()
        {
            this.Property(e => e.RegionCode)
            .IsUnicode(false);

            this.HasMany(e => e.RegionCity)
            .WithRequired(e => e.CountryRegion)
            .WillCascadeOnDelete(false);
        }
    }
}