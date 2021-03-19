using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class ColorListEntityConfiguration : EntityTypeConfiguration<ColorList>
    {
        public ColorListEntityConfiguration()
        {
            this.Property(e => e.ColorName)
            .IsUnicode(false);

            this.HasMany(e => e.Bag)
            .WithRequired(e => e.ColorList)
            .WillCascadeOnDelete(false);
        }
    }
}