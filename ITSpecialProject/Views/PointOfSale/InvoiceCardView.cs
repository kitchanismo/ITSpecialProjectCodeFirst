using System;
using System.Windows.Forms;
using Menu = DataLayer.Core.Model.Menu;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class InvoiceCardView : UserControl
    {
        public InvoiceCardView(Menu menu)
        {
            InitializeComponent();

            _menu = menu;

            SetValues();
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            IncreaseQuantity();
        }

        private void BtnDecrease_Click(object sender, EventArgs e)
        {
            DecreaseQuantity();
        }
    }
}
