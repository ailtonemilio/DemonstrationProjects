using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BagLogoEntityConfiguration : EntityTypeConfiguration<BagLogo>
    {
        public BagLogoEntityConfiguration()
        {
            this.Property(e => e.BagYear)
            .IsUnicode(false);

            this.Property(e => e.LogoDescription)
            .IsUnicode(false);

            this.Property(e => e.ImagePath)
                 .IsUnicode(false);

            this.HasMany(e => e.Bag)
            .WithRequired(e => e.BagLogo)
            .WillCascadeOnDelete(false);
        }
    }
}