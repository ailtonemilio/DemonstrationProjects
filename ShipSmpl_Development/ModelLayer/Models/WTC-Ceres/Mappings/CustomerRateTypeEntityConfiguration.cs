using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CustomerRateTypeEntityConfiguration : EntityTypeConfiguration<CustomerRateType>
    {
        public CustomerRateTypeEntityConfiguration()
        {
            this.Property(e => e.RateCode)
            .IsUnicode(false);

            this.Property(e => e.RateDescription)
            .IsUnicode(false);
        }
    }
}