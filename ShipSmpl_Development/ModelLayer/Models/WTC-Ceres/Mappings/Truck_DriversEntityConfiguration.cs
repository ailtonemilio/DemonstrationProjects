using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class Truck_DriversEntityConfiguration : EntityTypeConfiguration<Truck_Drivers>
    {
        public Truck_DriversEntityConfiguration()
        {
            this.Property(e => e.Port_Pass_ID)
             .IsFixedLength()
             .IsUnicode(false);

            this.Property(e => e.First_Name)
                .IsFixedLength()
                .IsUnicode(false);

            this.Property(e => e.Last_Name)
                .IsFixedLength()
                .IsUnicode(false);

            this.Property(e => e.Truck_Company_ID)
                .IsFixedLength()
                .IsUnicode(false);

            this.Property(e => e.Truck_Company_Name)
                .IsFixedLength()
                .IsUnicode(false);

            this.Property(e => e.Truck_Number)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}