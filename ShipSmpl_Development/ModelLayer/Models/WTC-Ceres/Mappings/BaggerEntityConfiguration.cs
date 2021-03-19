using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class BaggerEntityConfiguration : EntityTypeConfiguration<Bagger>
    {
        public BaggerEntityConfiguration()
        {
            this.Property(e => e.BaggerName)
                .IsUnicode(false);
        }
    }
}