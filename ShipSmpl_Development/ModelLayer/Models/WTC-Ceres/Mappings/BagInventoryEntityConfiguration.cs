using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BagInventoryEntityConfiguration : EntityTypeConfiguration<BagInventory>
    {
        public BagInventoryEntityConfiguration()
        {
            this.HasMany(e => e.BagLocation)
                .WithOptional(e => e.BagInventory)
                .WillCascadeOnDelete();
        }
    }
}