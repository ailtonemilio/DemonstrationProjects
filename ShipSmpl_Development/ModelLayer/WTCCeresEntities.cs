using ModelLayer.Models.WTC_Ceres.Mappings;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelLayer
{
    public partial class WTCCeresEntities : DbContext
    {
        public WTCCeresEntities()
            : base("name=WTCCeresEntities")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WTCCeresEntities, ModelLayer.Migrations.Configuration>());
        }

        public virtual DbSet<Bag> Bag { get; set; }
        public virtual DbSet<Bagger> Bagger { get; set; }
        public virtual DbSet<BagInventory> BagInventory { get; set; }
        public virtual DbSet<BagInventoryTransaction> BagInventoryTransaction { get; set; }
        public virtual DbSet<BagLocation> BagLocation { get; set; }
        public virtual DbSet<BagLogo> BagLogo { get; set; }
        public virtual DbSet<BagSize> BagSize { get; set; }
        public virtual DbSet<BagWeight> BagWeight { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingBagAssignment> BookingBagAssignment { get; set; }
        public virtual DbSet<BookingBagUsage> BookingBagUsage { get; set; }
        public virtual DbSet<BookingChangeLog> BookingChangeLog { get; set; }
        public virtual DbSet<BookingCompany> BookingCompany { get; set; }
        public virtual DbSet<BookingDestination> BookingDestination { get; set; }
        public virtual DbSet<BookingService> BookingService { get; set; }
        public virtual DbSet<BookingStatus> BookingStatus { get; set; }
        public virtual DbSet<BookingType> BookingType { get; set; }
        public virtual DbSet<CargoType> CargoType { get; set; }
        public virtual DbSet<CeresExcelPendingSync> CeresExcelPendingSync { get; set; }
        public virtual DbSet<ColorList> ColorList { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<Company> Company { get; set; }

        public virtual DbSet<Containers_In_Out> Containers_In_Out { get; set; }
        public virtual DbSet<DrayageSchemeRate> DrayageSchemeRate { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddress { get; set; }
        public virtual DbSet<CompanyCategory> CompanyCategory { get; set; }
        public virtual DbSet<CompanyCompanyType> CompanyCompanyType { get; set; }
        public virtual DbSet<CompanyCustomerRateType> CompanyCustomerRateType { get; set; }
        public virtual DbSet<CompanySSLineEDIRequired> CompanySSLineEDIRequired { get; set; }
        public virtual DbSet<CompanyType> CompanyType { get; set; }
        public virtual DbSet<Container> Container { get; set; }
        public virtual DbSet<ContainerMinibooking> ContainerMinibooking { get; set; }
        public virtual DbSet<ContainerSize> ContainerSize { get; set; }
        public virtual DbSet<ContainerStatus> ContainerStatus { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<CustomerRateType> CustomerRateType { get; set; }
        public virtual DbSet<DocumentsStored> DocumentsStored { get; set; }
        public virtual DbSet<DocumentsStoredBooking> DocumentsStoredBooking { get; set; }
        public virtual DbSet<DocumentsStoredDepartment> DocumentsStoredDepartment { get; set; }
        public virtual DbSet<DocumentsStoredGroup> DocumentsStoredGroup { get; set; }
        public virtual DbSet<DocumentsStoredType> DocumentsStoredType { get; set; }
        public virtual DbSet<DocumentsStoredUserDepartment> DocumentsStoredUserDepartment { get; set; }
        public virtual DbSet<DrayageRate> DrayageRate { get; set; }
        public virtual DbSet<DrayageScheme> DrayageScheme { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeActivityLog> EmployeeActivityLog { get; set; }
        public virtual DbSet<FSC_Rate> FSC_Rate { get; set; }
        public virtual DbSet<FTPAccount> FTPAccount { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<GrainInventory> GrainInventory { get; set; }
        public virtual DbSet<GrainInventoryTransaction> GrainInventoryTransaction { get; set; }
        public virtual DbSet<GrainInventoryTransfer> GrainInventoryTransfer { get; set; }
        public virtual DbSet<GrainInvMinibookingAssignment> GrainInvMinibookingAssignment { get; set; }
        public virtual DbSet<GrainInvMinibookingTransaction> GrainInvMinibookingTransaction { get; set; }
        public virtual DbSet<GrainInvStorageLocation> GrainInvStorageLocation { get; set; }
        public virtual DbSet<GrainInvTransactionGrainStorageLocation> GrainInvTransactionGrainStorageLocation { get; set; }
        public virtual DbSet<InboundFollowUpRequest> InboundFollowUpRequest { get; set; }
        public virtual DbSet<InboundReqDeclinedQty> InboundReqDeclinedQty { get; set; }
        public virtual DbSet<InboundRequest> InboundRequest { get; set; }
        public virtual DbSet<ManualEDILog> ManualEDILog { get; set; }
        public virtual DbSet<MiniBookingCommodity> MiniBookingCommodity { get; set; }
        public virtual DbSet<MinibookingMiniUnitAssignment> MinibookingMiniUnitAssignment { get; set; }
        public virtual DbSet<Minibooking> Minibooking { get; set; }
        public virtual DbSet<MiniUnit> MiniUnit { get; set; }
        public virtual DbSet<Pallet> Pallet { get; set; }
        public virtual DbSet<RegionCity> RegionCity { get; set; }
        public virtual DbSet<RelDistChangeReqSchedule> RelDistChangeReqSchedule { get; set; }
        public virtual DbSet<RelDistChangeReqScheduleDeclinedQty> RelDistChangeReqScheduleDeclinedQty { get; set; }
        public virtual DbSet<RelDistRequestSchedule> RelDistRequestSchedule { get; set; }
        public virtual DbSet<RelDistScheduleAccepted> RelDistScheduleAccepted { get; set; }
        public virtual DbSet<Release> Release { get; set; }
        public virtual DbSet<ReleaseDistributionRequest> ReleaseDistributionRequest { get; set; }
        public virtual DbSet<ReleaseOrder> ReleaseOrder { get; set; }
        public virtual DbSet<ReleaseOrderMinibooking> ReleaseOrderMinibooking { get; set; }
        public virtual DbSet<RelOrderPickUpDropOffLocation> RelOrderPickUpDropOffLocation { get; set; }
        public virtual DbSet<RequestStatus> RequestStatus { get; set; }
        public virtual DbSet<StorageType> StorageType { get; set; }
        public virtual DbSet<TEF_Rate> TEF_Rate { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<TimeSheet> TimeSheet { get; set; }
        public virtual DbSet<TruckDriver> TruckDriver { get; set; }
        public virtual DbSet<Truck_Drivers> Truck_Drivers { get; set; }
        public virtual DbSet<TruckDriverCompany> TruckDriverCompany { get; set; }
        public virtual DbSet<UnitSource> UnitSource { get; set; }
        public virtual DbSet<UnitStatus> UnitStatus { get; set; }
        public virtual DbSet<Vessel> Vessel { get; set; }
        public virtual DbSet<VesselVoyage> VesselVoyage { get; set; }
        public virtual DbSet<VesselVoyageStatus> VesselVoyageStatus { get; set; }
        public virtual DbSet<YardLocation> YardLocation { get; set; }
        public virtual DbSet<WTCWorkstations> WTCWorkstations { get; set; }
        public virtual DbSet<VW_ActiveCarrierBookings> VW_ActiveCarrierBookings { get; set; }
        public virtual DbSet<VW_Bag> VW_Bag { get; set; }
        public virtual DbSet<VW_BagInventory> VW_BagInventory { get; set; }
        public virtual DbSet<VW_BagInventoryTransaction> VW_BagInventoryTransaction { get; set; }
        public virtual DbSet<VW_Booking> VW_Booking { get; set; }
        public virtual DbSet<VW_BookingBagInventoryAssignment> VW_BookingBagInventoryAssignment { get; set; }
        public virtual DbSet<VW_BookingContainerAssignments> VW_BookingContainerAssignments { get; set; }
        public virtual DbSet<VW_BookingDestination> VW_BookingDestination { get; set; }
        public virtual DbSet<VW_BookingMinibooking> VW_BookingMinibooking { get; set; }
        public virtual DbSet<VW_CeresExcelPendingSyncBooking> VW_CeresExcelPendingSyncBooking { get; set; }
        public virtual DbSet<VW_CompanyCompanyType> VW_CompanyCompanyType { get; set; }
        public virtual DbSet<VW_Container> VW_Container { get; set; }
        public virtual DbSet<VW_ContainersByBooking> VW_ContainersByBooking { get; set; }
        public virtual DbSet<VW_ContainerGrainDoor> VW_ContainerGrainDoor { get; set; }
        public virtual DbSet<VW_ContainersInOutDrayage> VW_ContainersInOutDrayage { get; set; }
        public virtual DbSet<VW_EDIPerformanceAudit> VW_EDIPerformanceAudit { get; set; }
        public virtual DbSet<VW_EmployeeActivityLog> VW_EmployeeActivityLog { get; set; }
        public virtual DbSet<VW_ExcelHarvesterPushRequest> VW_ExcelHarvesterPushRequest { get; set; }
        public virtual DbSet<VW_GrainInventory> VW_GrainInventory { get; set; }
        public virtual DbSet<VW_GrainInventoryTransaction> VW_GrainInventoryTransaction { get; set; }
        public virtual DbSet<VW_GrainInvMinibookingAssignment> VW_GrainInvMinibookingAssignment { get; set; }
        public virtual DbSet<VW_GrainInvMinibookingTransaction> VW_GrainInvMinibookingTransaction { get; set; }
        public virtual DbSet<VW_GrainUnitStorage> VW_GrainUnitStorage { get; set; }
        public virtual DbSet<VW_InboundFollowUpRequest> VW_InboundFollowUpRequest { get; set; }
        public virtual DbSet<VW_InboundReport> VW_InboundReport { get; set; }
        public virtual DbSet<VW_InboundRequest> VW_InboundRequest { get; set; }
        public virtual DbSet<VW_InventoryBagLocation> VW_InventoryBagLocation { get; set; }
        public virtual DbSet<VW_MinibookingCommodity> VW_MinibookingCommodity { get; set; }
        public virtual DbSet<VW_MinibookingMiniUnitAssignment> VW_MinibookingMiniUnitAssignment { get; set; }
        public virtual DbSet<VW_RegionCity> VW_RegionCity { get; set; }
        public virtual DbSet<VW_RelDistChangeReqSchedule> VW_RelDistChangeReqSchedule { get; set; }
        public virtual DbSet<VW_RelDistReqSchRelDistSchAccpt> VW_RelDistReqSchRelDistSchAccpt { get; set; }
        public virtual DbSet<VW_RelDistRequestSchedule> VW_RelDistRequestSchedule { get; set; }
        public virtual DbSet<VW_RelDistScheduleAccepted> VW_RelDistScheduleAccepted { get; set; }
        public virtual DbSet<VW_Release> VW_Release { get; set; }
        public virtual DbSet<VW_ReleaseDistributionRequest> VW_ReleaseDistributionRequest { get; set; }
        public virtual DbSet<VW_ReleaseOrder> VW_ReleaseOrder { get; set; }
        public virtual DbSet<VW_ReleaseOrderMinibooking> VW_ReleaseOrderMinibooking { get; set; }
        public virtual DbSet<VW_RelOrderPickUpDropOffLocation> VW_RelOrderPickUpDropOffLocation { get; set; }
        public virtual DbSet<VW_TransloadMiniUnitMiniBooking> VW_TransloadMiniUnitMiniBooking { get; set; }
        public virtual DbSet<VW_TransloadRecords> VW_TransloadRecords { get; set; }
        public virtual DbSet<VW_UnitSource> VW_UnitSource { get; set; }
        public virtual DbSet<VW_UnitSourceMiniUnit> VW_UnitSourceMiniUnit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BagEntityConfiguration());
            modelBuilder.Configurations.Add(new BaggerEntityConfiguration());
            modelBuilder.Configurations.Add(new BagInventoryEntityConfiguration());
            modelBuilder.Configurations.Add(new BagLocationEntityConfiguration());
            modelBuilder.Configurations.Add(new BagLogoEntityConfiguration());
            modelBuilder.Configurations.Add(new BagSizeEntityConfiguration());
            modelBuilder.Configurations.Add(new BagWeightEntityConfiguration());
            modelBuilder.Configurations.Add(new Blocked_ContainerstEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingCompanyEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingChangeLogEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingDestinationEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingServiceEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingStatusEntityConfiguration());
            modelBuilder.Configurations.Add(new BookingTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CargoTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CeresExcelPendingSyncEntityConfiguration());
            modelBuilder.Configurations.Add(new ColorListEntityConfiguration());
            modelBuilder.Configurations.Add(new CommodityEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyAddressEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyCategoryEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new ContainerEntityConfiguration());
            modelBuilder.Configurations.Add(new ContainerSizeEntityConfiguration());
            modelBuilder.Configurations.Add(new ContainerStatusEntityConfiguration());
            modelBuilder.Configurations.Add(new CountryEntityConfiguration());
            modelBuilder.Configurations.Add(new CountryRegionConfiguration());
            modelBuilder.Configurations.Add(new CustomerRateTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentsStoredEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentsStoredBookingEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentsStoredDepartmentEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentsStoredGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentsStoredTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new DrayageRateEntityConfiguration());
            modelBuilder.Configurations.Add(new DrayageSchemeRateEntityConfiguration());
            modelBuilder.Configurations.Add(new EmployeeEntityConfiguration());
            modelBuilder.Configurations.Add(new EmployeeActivityLogEntityConfiguration());
            modelBuilder.Configurations.Add(new FSC_RateEntityConfiguration());
            modelBuilder.Configurations.Add(new FTPAccountEntityConfiguration());
            modelBuilder.Configurations.Add(new GradeEntityConfiguration());
            modelBuilder.Configurations.Add(new GrainInventoryEntityConfiguration());
            modelBuilder.Configurations.Add(new GrainInventoryTransactionEntityConfiguration());
            modelBuilder.Configurations.Add(new GrainInvStorageLocationEntityConfiguration());
            modelBuilder.Configurations.Add(new InboundReqDeclinedQtyEntityConfiguration());
            modelBuilder.Configurations.Add(new InboundRequestEntityConfiguration());
            modelBuilder.Configurations.Add(new MinibookingEntityConfiguration());
            modelBuilder.Configurations.Add(new MiniUnitEntityConfiguration());
            modelBuilder.Configurations.Add(new RegionCityEntityConfiguration());
            modelBuilder.Configurations.Add(new RelDistChangeReqScheduleEntityConfiguration());
            modelBuilder.Configurations.Add(new RelDistChangeReqScheduleDeclinedQtyEntityConfiguration());
            modelBuilder.Configurations.Add(new RelDistRequestScheduleEntityConfiguration());
            modelBuilder.Configurations.Add(new RelDistScheduleAcceptedEntityConfiguration());
            modelBuilder.Configurations.Add(new ReleaseEntityConfiguration());
            modelBuilder.Configurations.Add(new ReleaseOrderEntityConfiguration());
            modelBuilder.Configurations.Add(new RelOrderPickUpDropOffLocationEntityConfiguration());
            modelBuilder.Configurations.Add(new RequestStatusEntityConfiguration());
            modelBuilder.Configurations.Add(new StorageTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new TEF_RateEntityConfiguration());
            modelBuilder.Configurations.Add(new TransactionTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new TruckDriverEntityConfiguration());
            modelBuilder.Configurations.Add(new TruckDriverCompanyEntityConfiguration());
            modelBuilder.Configurations.Add(new UnitSourceEntityConfiguration());
            modelBuilder.Configurations.Add(new UnitStatusEntityConfiguration());
            modelBuilder.Configurations.Add(new VesselEntityConfiguration());
            modelBuilder.Configurations.Add(new VesselVoyageEntityConfiguration());
            modelBuilder.Configurations.Add(new YardLocationEntityConfiguration());
        }
    }
}