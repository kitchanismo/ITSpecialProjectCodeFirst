//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplierLog
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public bool Flag { get; set; }
        public string ActionType { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
