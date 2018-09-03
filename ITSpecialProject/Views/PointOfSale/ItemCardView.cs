using System.Windows.Forms;
using Menu = DataLayer.Core.Model.Menu;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class ItemCardView : UserControl
    {
        public ItemCardView(Menu menu)
        {
            InitializeComponent();

            _menu = menu;

            Initialize();
        }
    }
}
