using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CommodityEntityConfiguration : EntityTypeConfiguration<Commodity>
    {
        public CommodityEntityConfiguration()
        {
            this.Property(e => e.CommodityCode)
            .IsUnicode(false);

            this.Property(e => e.CommodityName)
                .IsUnicode(false);

            this.HasMany(e => e.MiniBookingCommodity)
                .WithRequired(e => e.Commodity)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.MiniUnit)
                .WithRequired(e => e.Commodity)
                .WillCascadeOnDelete(false);
        }
    }
}