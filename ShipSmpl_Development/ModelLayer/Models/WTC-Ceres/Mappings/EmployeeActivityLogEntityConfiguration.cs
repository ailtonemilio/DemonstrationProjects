using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class EmployeeActivityLogEntityConfiguration : EntityTypeConfiguration<EmployeeActivityLog>
    {
        public EmployeeActivityLogEntityConfiguration()
        {
            this.Property(e => e.RecordModified)
            .IsUnicode(false);

            this.Property(e => e.ActionTaken)
                .IsUnicode(false);

            this.Property(e => e.ModuleName)
                .IsUnicode(false);

            this.Property(e => e.Detail)
                .IsUnicode(false);
        }
    }
}