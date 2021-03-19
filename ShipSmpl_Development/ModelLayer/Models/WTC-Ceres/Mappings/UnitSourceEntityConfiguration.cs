using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class UnitSourceEntityConfiguration : EntityTypeConfiguration<UnitSource>
    {
        public UnitSourceEntityConfiguration()
        {
            this.Property(e => e.UnitNumber)
            .IsUnicode(false);

            this.Property(e => e.UnitType)
            .IsUnicode(false);

            this.Property(e => e.OriginLocation)
            .IsUnicode(false);

            this.Property(e => e.ETALocation)
            .IsUnicode(false);

            this.Property(e => e.LastLocation)
            .IsUnicode(false);

            this.Property(e => e.Sequence)
            .IsUnicode(false);

            this.Property(e => e.Track)
            .IsUnicode(false);

            this.Property(e => e.RailIncShipperName)
            .IsUnicode(false);

            this.Property(e => e.CargoDescription)
            .IsUnicode(false);

            this.Property(e => e.OriginalUnitNumber)
            .IsUnicode(false);

            this.HasMany(e => e.MiniUnit)
                .WithOptional(e => e.UnitSource)
                .WillCascadeOnDelete();
        }
    }
}