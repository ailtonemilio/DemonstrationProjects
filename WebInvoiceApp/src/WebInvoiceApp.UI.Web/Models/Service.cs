//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebInvoiceApp.UI.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int IdService { get; set; }
        public string TypeServices { get; set; }
        public string DescriptionServ { get; set; }
        public Nullable<decimal> HourRate { get; set; }
        public Nullable<decimal> Hour { get; set; }
        public Nullable<decimal> TotalServ { get; set; }
        public Nullable<decimal> TaxServ { get; set; }
        public Nullable<decimal> LineTotalServ { get; set; }
        public Nullable<int> NumInvoice { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
