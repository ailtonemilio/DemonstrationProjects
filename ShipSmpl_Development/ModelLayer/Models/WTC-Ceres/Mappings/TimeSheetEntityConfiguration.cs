using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class TimeSheetEntityConfiguration : EntityTypeConfiguration<TimeSheet>
    {
        public TimeSheetEntityConfiguration()
        {
            this.Property(e => e.PunchType)
             .IsUnicode(false);

            this.Property(e => e.DeviceName)
                .IsUnicode(false);

            this.Property(e => e.SiteLocation)
                .IsUnicode(false);

            this.Property(e => e.DeviceIPAddress)
                .IsUnicode(false);
        }
    }
}