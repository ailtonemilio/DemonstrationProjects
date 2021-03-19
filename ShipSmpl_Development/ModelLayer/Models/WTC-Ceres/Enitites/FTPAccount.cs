namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FTPAccount")]
    public partial class FTPAccount
    {
        public int FTPAccountId { get; set; }

        [StringLength(250)]
        public string FTPHost { get; set; }

        [StringLength(50)]
        public string FTPUser { get; set; }

        [StringLength(25)]
        public string FTPUserId { get; set; }

        [StringLength(25)]
        public string FTPPassword { get; set; }

        public bool? FTPActive { get; set; }

        [StringLength(200)]
        public string CertificateFingerPrint { get; set; }
    }
}
