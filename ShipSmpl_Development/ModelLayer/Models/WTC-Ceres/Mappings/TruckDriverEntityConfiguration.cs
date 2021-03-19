using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class TruckDriverEntityConfiguration : EntityTypeConfiguration<TruckDriver>
    {
        public TruckDriverEntityConfiguration()
        {
            this.Property(e => e.FirstName)
            .IsUnicode(false);

            this.Property(e => e.LastName)
             .IsUnicode(false);
        }
    }
}