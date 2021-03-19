using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class YardLocationEntityConfiguration : EntityTypeConfiguration<YardLocation>
    {
        public YardLocationEntityConfiguration()
        {
            this.Property(e => e.YardName)
            .IsUnicode(false);

            this.Property(e => e.YardAddress)
                .IsUnicode(false);

            this.HasMany(e => e.Bagger)
                .WithRequired(e => e.YardLocation)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Container)
                .WithRequired(e => e.YardLocation)
                .HasForeignKey(e => e.CurrentYardLocationId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Pallet)
                .WithRequired(e => e.YardLocation)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RelOrderPickUpDropOffLocation)
                .WithRequired(e => e.YardLocation)
                .HasForeignKey(e => e.DropOffYardLocationId)
                .WillCascadeOnDelete(false);
        }
    }
}