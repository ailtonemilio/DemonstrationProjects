namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContainerDelegation")]
    public partial class ContainerDelegation
    {
        public int ContainerDelegationId { get; set; }

        [StringLength(15)]
        public string DelegationName { get; set; }
    }
}
