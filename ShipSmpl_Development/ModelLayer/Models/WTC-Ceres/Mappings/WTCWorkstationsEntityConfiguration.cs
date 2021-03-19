using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class WTCWorkstationsEntityConfiguration : EntityTypeConfiguration<WTCWorkstations>
    {
        public WTCWorkstationsEntityConfiguration()
        {
            this.Property(e => e.WorkStation_Name)
            .IsUnicode(false);

            this.Property(e => e.Workstation_Type)
            .IsUnicode(false);
        }
    }
}