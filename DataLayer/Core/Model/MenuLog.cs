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
    
    public partial class MenuLog
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }
        public string MenuImage { get; set; }
        public bool Flag { get; set; }
        public string ActionType { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        public virtual Menu Menu { get; set; }
    }
}
