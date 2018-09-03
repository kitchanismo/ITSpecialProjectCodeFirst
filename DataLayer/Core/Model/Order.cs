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
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public short TableNo { get; set; }
        public System.DateTime DateOrdered { get; set; }
        public System.DateTime DateServed { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int AccountId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual OrderPayment OrderPayment { get; set; }
    }
}
