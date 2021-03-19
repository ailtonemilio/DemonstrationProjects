using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class Blocked_ContainerstEntityConfiguration : EntityTypeConfiguration<Blocked_Containers>
    {
        public Blocked_ContainerstEntityConfiguration()
        {
            this.Property(e => e.Container_Number)
            .IsFixedLength()
            .IsUnicode(false);

            this.Property(e => e.SS_LIne_Code)
            .IsFixedLength()
            .IsUnicode(false);

            this.Property(e => e.SS_Line_Name)
            .IsFixedLength()
            .IsUnicode(false);
        }
    }
}