using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BagSizeEntityConfiguration : EntityTypeConfiguration<BagSize>
    {
        public BagSizeEntityConfiguration()
        {
            this.Property(e => e.BagSizeName)
            .IsUnicode(false);

            this.HasMany(e => e.Bag)
            .WithRequired(e => e.BagSize)
            .WillCascadeOnDelete(false);
        }
    }
}