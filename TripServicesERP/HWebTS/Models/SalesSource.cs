//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWebTS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesSource
    {
        public int IdSalesSource { get; set; }
        public Nullable<decimal> Value { get; set; }
        public Nullable<decimal> PercentPay { get; set; }
        public string TypePay { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public Nullable<int> IdSalesContact { get; set; }
        public Nullable<int> NumInvoice { get; set; }
    
        public virtual SalesContact SalesContact { get; set; }
    }
}
