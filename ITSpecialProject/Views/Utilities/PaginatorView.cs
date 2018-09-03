using System;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Utilities
{
    public partial class PaginatorView : UserControl
    {
        public PaginatorView()
        {
            InitializeComponent();

            Initialize();
        }

        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            GoToFirstPage();
        }

        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            GoToPreviousPage();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            GoToNextPage();
        }

        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            GoToLastPage();
        }
    }
}
