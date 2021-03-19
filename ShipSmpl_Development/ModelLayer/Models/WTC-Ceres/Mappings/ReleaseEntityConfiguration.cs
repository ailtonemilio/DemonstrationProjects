using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class ReleaseEntityConfiguration : EntityTypeConfiguration<Release>
    {
        public ReleaseEntityConfiguration()
        {
            this.Property(e => e.ReleaseNumber)
                .IsUnicode(false);
        }
    }
}