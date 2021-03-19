namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            BagInventory = new HashSet<BagInventory>();
            BookingCompany = new HashSet<BookingCompany>();
            BookingCompanyChangeLog = new HashSet<BookingCompanyChangeLog>();
            CompanyCompanyType = new HashSet<CompanyCompanyType>();
            CompanySSLineEDIRequired = new HashSet<CompanySSLineEDIRequired>();
            DrayageScheme = new HashSet<DrayageScheme>();
            DrayageScheme1 = new HashSet<DrayageScheme>();
            DrayageScheme2 = new HashSet<DrayageScheme>();
            Minibooking = new HashSet<Minibooking>();
            UnitSource = new HashSet<UnitSource>();
            CompanyAddress = new HashSet<CompanyAddress>();
            CompanyCompanyType1 = new HashSet<CompanyCompanyType>();
            CompanyCustomerRateType = new HashSet<CompanyCustomerRateType>();
            CompanySSLineEDIRequired1 = new HashSet<CompanySSLineEDIRequired>();
            Container = new HashSet<Container>();
            Container1 = new HashSet<Container>();
            GrainInventory = new HashSet<GrainInventory>();
            InboundRequest = new HashSet<InboundRequest>();
            MiniBookingChangeLog = new HashSet<MiniBookingChangeLog>();
            MiniBookingChangeLog1 = new HashSet<MiniBookingChangeLog>();
            MiniBookingChangeLog2 = new HashSet<MiniBookingChangeLog>();
            MiniUnit = new HashSet<MiniUnit>();
            ReleaseDistributionRequest = new HashSet<ReleaseDistributionRequest>();
            RelOrderPickUpDropOffLocation = new HashSet<RelOrderPickUpDropOffLocation>();
            TruckDriverCompany = new HashSet<TruckDriverCompany>();
            VesselVoyage = new HashSet<VesselVoyage>();
        }

        public int CompanyId { get; set; }

        [StringLength(10)]
        public string CompanyCode { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [Column(TypeName = "text")]
        public string Notes { get; set; }

        public int? Rating { get; set; }

        [StringLength(200)]
        public string Attention { get; set; }

        public int CompanyCategoryId { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BagInventory> BagInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingCompany> BookingCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingCompanyChangeLog> BookingCompanyChangeLog { get; set; }

        public virtual CompanyCategory CompanyCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCompanyType> CompanyCompanyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySSLineEDIRequired> CompanySSLineEDIRequired { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrayageScheme> DrayageScheme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrayageScheme> DrayageScheme1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrayageScheme> DrayageScheme2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Minibooking> Minibooking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitSource> UnitSource { get; set; }

        public virtual CompanyCategory CompanyCategory1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyAddress> CompanyAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCompanyType> CompanyCompanyType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCustomerRateType> CompanyCustomerRateType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySSLineEDIRequired> CompanySSLineEDIRequired1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Container> Container { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Container> Container1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInventory> GrainInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundRequest> InboundRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniBookingChangeLog> MiniBookingChangeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniBookingChangeLog> MiniBookingChangeLog1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniBookingChangeLog> MiniBookingChangeLog2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniUnit> MiniUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseDistributionRequest> ReleaseDistributionRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelOrderPickUpDropOffLocation> RelOrderPickUpDropOffLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TruckDriverCompany> TruckDriverCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselVoyage> VesselVoyage { get; set; }
    }
}