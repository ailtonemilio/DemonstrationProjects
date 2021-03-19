using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BagWeightEntityConfiguration : EntityTypeConfiguration<BagWeight>
    {
        public BagWeightEntityConfiguration()
        {
            this.Property(e => e.BagWeightName)
            .IsUnicode(false);

            this.Property(e => e.BagUnit)
            .IsUnicode(false);

            this.HasMany(e => e.Bag)
            .WithRequired(e => e.BagWeight)
            .WillCascadeOnDelete(false);
        }
    }
}