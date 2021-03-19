namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingCommoditiesChangeLog")]
    public partial class BookingCommoditiesChangeLog
    {
        public int BookingCommoditiesChangeLogId { get; set; }

        public int? BookingGroupID { get; set; }

        public int? GroupCounter { get; set; }

        public int MinibookingId { get; set; }

        [StringLength(40)]
        public string BookingNumber { get; set; }

        [StringLength(5)]
        public string CommodityCode { get; set; }

        [StringLength(5)]
        public string GradeCode { get; set; }
    }
}
