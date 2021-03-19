namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OCRData")]
    public partial class OCRData
    {
        public int OCRDataId { get; set; }

        [StringLength(15)]
        public string ContainerOutputOCR { get; set; }

        public DateTime? DataCollectionTime { get; set; }
    }
}
