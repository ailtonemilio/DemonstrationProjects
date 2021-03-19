namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MiniBookingChangeLog")]
    public partial class MiniBookingChangeLog
    {
        public int? BookingGroupID { get; set; }

        public int? GroupCounter { get; set; }

        public int? MinibookingId { get; set; }

        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(225)]
        public string RVs { get; set; }

        [StringLength(255)]
        public string BookingNote { get; set; }

        public bool? isMainBooking { get; set; }

        public int? MiniBookingOrder { get; set; }

        public int? NumberOfContainer { get; set; }

        [StringLength(20)]
        public string ContainerSize { get; set; }

        [StringLength(10)]
        public string CarrierCodeIn { get; set; }

        [StringLength(50)]
        public string CarrierNameIn { get; set; }

        [StringLength(10)]
        public string CarrierCodeOut { get; set; }

        [StringLength(50)]
        public string CarrierNameOut { get; set; }

        [StringLength(10)]
        public string ReleaseFromCode { get; set; }

        [StringLength(40)]
        public string ReleaseFromName { get; set; }

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

        public int? CarrierInId { get; set; }

        public int? CarrierOutId { get; set; }

        public int? TerminalId { get; set; }

        public int MinibookingChangeLogId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual Company Company2 { get; set; }
    }
}
