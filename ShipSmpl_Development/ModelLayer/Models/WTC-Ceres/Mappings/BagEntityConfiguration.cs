using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BagEntityConfiguration : EntityTypeConfiguration<Bag>
    {
        public BagEntityConfiguration()
        {
            this.Property(e => e.ColorType)
            .IsUnicode(false);

            this.Property(e => e.BagDescription)
            .IsUnicode(false);

            this.HasMany(e => e.BagInventory)
                .WithRequired(e => e.Bag)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInventory)
                .WithRequired(e => e.Bag)
                .WillCascadeOnDelete(false);
        }
    }
}