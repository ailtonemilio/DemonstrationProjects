namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Terminal")]
    public partial class Terminal
    {
        [Key]
        [StringLength(10)]
        public string DOCKCODE { get; set; }

        [StringLength(40)]
        public string TERMINALNAME { get; set; }

        [StringLength(40)]
        public string ADDR1 { get; set; }

        [StringLength(40)]
        public string ADDR2 { get; set; }

        [StringLength(25)]
        public string CITY { get; set; }

        [StringLength(2)]
        public string PROVINCE { get; set; }

        [StringLength(11)]
        public string POSTALCODE { get; set; }

        [StringLength(14)]
        public string PHONE { get; set; }

        [StringLength(40)]
        public string CONTACT { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(60)]
        public string WEBSITE { get; set; }

        public bool? RESERVATIONFEE { get; set; }

        public decimal? RESERVATIONAMOUNT { get; set; }

        [StringLength(10)]
        public string USERID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CHGDATE { get; set; }
    }
}
