using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class MiniUnitEntityConfiguration : EntityTypeConfiguration<MiniUnit>
    {
        public MiniUnitEntityConfiguration()
        {
            this.Property(e => e.TotalBilled)
            .HasPrecision(8, 3);

            this.Property(e => e.UnBilled)
            .HasPrecision(8, 3);

            this.Property(e => e.BilledByUnit)
            .HasPrecision(8, 3);

            this.Property(e => e.BilledByUnitUnitType)
            .IsUnicode(false);

            this.Property(e => e.UnBilledByUnit)
            .HasPrecision(8, 3);

            this.Property(e => e.UnBilledByUnitUnitType)
            .IsUnicode(false);

            this.Property(e => e.MULocation)
            .IsUnicode(false);

            this.Property(e => e.Comments)
            .IsUnicode(false);

            this.Property(e => e.LotNumber)
            .IsUnicode(false);

            this.HasMany(e => e.GrainInventory)
            .WithRequired(e => e.MiniUnit)
            .WillCascadeOnDelete(false);
        }
    }
}