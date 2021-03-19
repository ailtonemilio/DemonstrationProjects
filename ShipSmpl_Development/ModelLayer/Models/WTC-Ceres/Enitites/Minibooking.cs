namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Minibooking")]
    public partial class Minibooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Minibooking()
        {
            BookingBagAssignment = new HashSet<BookingBagAssignment>();
            GrainInvMinibookingAssignment = new HashSet<GrainInvMinibookingAssignment>();
            GrainInvMinibookingTransaction = new HashSet<GrainInvMinibookingTransaction>();
            MiniBookingCommodity = new HashSet<MiniBookingCommodity>();
            MinibookingMiniUnitAssignment = new HashSet<MinibookingMiniUnitAssignment>();
            ReleaseOrderMinibooking = new HashSet<ReleaseOrderMinibooking>();
        }

        public int MiniBookingId { get; set; }

        public bool? isMainBooking { get; set; }

        public int? MiniBookingOrder { get; set; }

        public int? NumberOfContainer { get; set; }

        [StringLength(100)]
        public string FreeTime { get; set; }

        [StringLength(20)]
        public string BagProvider { get; set; }

        [StringLength(10)]
        public string Tagging { get; set; }

        [StringLength(20)]
        public string Bagtype { get; set; }

        [StringLength(10)]
        public string AmountRequested { get; set; }

        [StringLength(10)]
        public string SpecialMax { get; set; }

        [StringLength(10)]
        public string BagWeight { get; set; }

        [StringLength(4)]
        public string BagWeightUnit { get; set; }

        [StringLength(30)]
        public string LotNumber { get; set; }

        [StringLength(20)]
        public string SpecialInstrux { get; set; }

        [StringLength(300)]
        public string SpecialInstruxNote { get; set; }

        [StringLength(20)]
        public string GradeBy { get; set; }

        [StringLength(20)]
        public string PhytosanitaryBy { get; set; }

        [StringLength(30)]
        public string InspectionBy { get; set; }

        [StringLength(30)]
        public string FumigationBy { get; set; }

        [StringLength(60)]
        public string Other { get; set; }

        [StringLength(300)]
        public string TerminalEffcFee { get; set; }

        public int? CarrierOutId { get; set; }

        public bool? isMultiMB { get; set; }

        public int BookingId { get; set; }

        public bool HoldBooking { get; set; }

        public int ContainerSizeId { get; set; }

        public bool isClosedMB { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        public virtual Booking Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingBagAssignment> BookingBagAssignment { get; set; }

        public virtual Company Company { get; set; }

        public virtual ContainerSize ContainerSize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvMinibookingAssignment> GrainInvMinibookingAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrainInvMinibookingTransaction> GrainInvMinibookingTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiniBookingCommodity> MiniBookingCommodity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinibookingMiniUnitAssignment> MinibookingMiniUnitAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseOrderMinibooking> ReleaseOrderMinibooking { get; set; }
    }
}