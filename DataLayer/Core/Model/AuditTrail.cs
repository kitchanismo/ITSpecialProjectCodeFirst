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
    
    public partial class AuditTrail
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Activity { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
