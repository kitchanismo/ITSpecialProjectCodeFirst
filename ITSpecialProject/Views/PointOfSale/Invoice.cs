using DataLayer.Core.Model;
using System.Collections.Generic;

namespace ITSpecialProject.Views.PointOfSale
{
    public class Invoice
    {
        public List<MenuWithQuantity> Orders;
        public int TotalItems;
        public decimal SubTotal;
        public decimal DiscountId;
        public decimal NetAmount;

        public Invoice()
        {
            Orders = new List<MenuWithQuantity>();
        }

        public class MenuWithQuantity
        {
            public Menu Menu;
            public int Quantity;
        }
    }


}
