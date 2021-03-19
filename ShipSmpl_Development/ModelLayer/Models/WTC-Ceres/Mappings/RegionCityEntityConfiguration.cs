using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class RegionCityEntityConfiguration : EntityTypeConfiguration<RegionCity>
    {
        public RegionCityEntityConfiguration()
        {
            this.Property(e => e.CityName)
            .IsUnicode(false);

            this.Property(e => e.CityCode)
             .IsUnicode(false);
        }
    }
}