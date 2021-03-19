using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class FSC_RateEntityConfiguration : EntityTypeConfiguration<FSC_Rate>
    {
        public FSC_RateEntityConfiguration()
        {
            this.Property(e => e.Rate_Name)
            .IsUnicode(false);
        }
    }
}