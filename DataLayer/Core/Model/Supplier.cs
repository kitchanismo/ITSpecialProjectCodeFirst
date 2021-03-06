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
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.ConsumableOrders = new HashSet<ConsumableOrder>();
            this.Consumables = new HashSet<Consumable>();
            this.SupplierLogs = new HashSet<SupplierLog>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime CreationDate { get; set; }
        public bool Flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsumableOrder> ConsumableOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consumable> Consumables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLog> SupplierLogs { get; set; }
    }
}
