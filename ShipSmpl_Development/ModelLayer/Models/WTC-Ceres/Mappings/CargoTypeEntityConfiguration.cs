using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CargoTypeEntityConfiguration : EntityTypeConfiguration<CargoType>
    {
        public CargoTypeEntityConfiguration()
        {
            this.Property(e => e.CargoTypeCode)
            .IsUnicode(false);

            this.Property(e => e.CargoTypeName)
                .IsUnicode(false);

            this.HasMany(e => e.UnitSource)
                .WithRequired(e => e.CargoType)
                .WillCascadeOnDelete(false);
        }
    }
}