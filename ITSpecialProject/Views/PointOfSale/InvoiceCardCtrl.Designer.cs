using DataLayer.Core.Model;
using System;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class InvoiceCardView
    {
        private readonly Menu _menu;

        private int _quantity = 1;

        private void SetValues()
        {
            lblMenuName.Text = $"x{_quantity} {_menu.Acronym}";
            lblMenuPrice.Text = $"\u20b1 {Math.Round(_menu.Price * _quantity, 2)}";
        }

        public void IncreaseQuantity()
        {
            _quantity++;

            SetValues();
        }

        public void DecreaseQuantity()
        {
            if (_quantity == 1) return;

            _quantity--;

            SetValues();
        }

        public Menu GetMenu => _menu;

        public int GetQuantity => _quantity;

        public event EventHandler QuantityChanged
        {
            add
            {
                btnIncrease.Click += value;
                btnDecrease.Click += value;
            }
            remove
            {
                btnIncrease.Click -= value;
                btnDecrease.Click -= value;
            }
        }

        public event EventHandler ItemRemoved
        {
            add => btnRemove.Click += value;
            remove => btnRemove.Click -= value;
        }
    }
}
