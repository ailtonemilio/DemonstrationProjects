using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class TruckDriverCompanyEntityConfiguration : EntityTypeConfiguration<TruckDriverCompany>
    {
        public TruckDriverCompanyEntityConfiguration()
        {
            this.Property(e => e.PortPassId)
             .IsUnicode(false);

            this.Property(e => e.TruckNumber)
            .IsUnicode(false);
        }
    }
}