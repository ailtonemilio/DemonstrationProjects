using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CompanyEntityConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyEntityConfiguration()
        {
            this.Property(e => e.CompanyCode)
                .IsUnicode(false);

            this.Property(e => e.CompanyName)
                .IsUnicode(false);

            this.Property(e => e.Email)
                .IsUnicode(false);

            this.Property(e => e.Website)
                .IsUnicode(false);

            this.Property(e => e.Notes)
                .IsUnicode(false);

            this.Property(e => e.Attention)
                .IsUnicode(false);

            this.HasMany(e => e.BagInventory)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.ShipperId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BookingCompany)
                .WithRequired(e => (Company)e.Company)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CompanyCompanyType)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CompanySSLineEDIRequired)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.DrayageScheme)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.FromDockId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.DrayageScheme1)
                .WithRequired(e => e.Company1)
                .HasForeignKey(e => e.ToDockId)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.DrayageScheme2)
                .WithRequired(e => e.Company2)
                .HasForeignKey(e => e.TruckingCompanyId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Minibooking)
                .WithOptional(e => (Company)e.Company)
                .HasForeignKey(e => e.CarrierOutId);

            this.HasMany(e => e.UnitSource)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.ShipperId);

            this.HasMany(e => e.CompanyCompanyType1)
                .WithRequired(e => e.Company1)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CompanySSLineEDIRequired1)
                .WithRequired(e => e.Company1)
                .HasForeignKey(e => e.CompanyId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Container)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.OwnerId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Container1)
                .WithRequired(e => e.Company1)
                .HasForeignKey(e => e.SSLineId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInventory)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InboundRequest)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.ShippingLineId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.MiniUnit)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.ReleaseDistributionRequest)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CarrierId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RelOrderPickUpDropOffLocation)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.PickUpTerminalId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.VesselVoyage)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.PortId);
        }
    }
}