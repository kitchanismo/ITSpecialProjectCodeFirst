using System;
using System.Windows.Forms;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class MenuCategoryView : UserControl
    {
        public MenuCategoryView()
        {
            InitializeComponent();
        }

        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            NextPage();
        }
    }
}
