namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MiniBookingCommodity")]
    public partial class MiniBookingCommodity
    {
        public int MiniBookingCommodityId { get; set; }

        public int MiniBookingId { get; set; }

        public int CommodityId { get; set; }

        public int GradeId { get; set; }

        public virtual Commodity Commodity { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual Minibooking Minibooking { get; set; }
    }
}
