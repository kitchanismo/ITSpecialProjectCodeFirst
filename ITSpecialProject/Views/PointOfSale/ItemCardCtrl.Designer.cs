using ITSpecialProject.Commons.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Menu = DataLayer.Core.Model.Menu;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class ItemCardView
    {
        private readonly Menu _menu;

        private void Initialize()
        {
            foreach (var control in this.Controls.Cast<Control>())
            {
                control.Cursor = Cursors.Hand;
            }

            SetMenuDetails();
        }

        private void SetMenuDetails()
        {
            lblItemName.Text = _menu.Name;
            lblItemPrice.Text = $"\u20b1 {_menu.Price}";
            pbItemImage.Image = !string.IsNullOrEmpty(_menu.MenuImage)
                ? PathHelper.GetImage(_menu.MenuImage)
                : Properties.Resources.Default_100;

            if (_menu.Availability)
            {
                pnlIsAvailable.BackColor = ColorHelper.FlatGreenNormal;
            }
            else
            {
                pnlIsAvailable.BackColor = ColorHelper.FlatRedNormal;
                this.BackColor = ColorHelper.FlatRedTransparent;
            }
        }

        public Menu GetMenu => _menu;

        public event EventHandler CardClicked
        {
            add
            {
                foreach (var control in this.Controls.Cast<Control>())
                {
                    control.Click += value;
                }
            }
            remove
            {
                foreach (var control in this.Controls.Cast<Control>())
                {
                    control.Click -= value;
                }
            }
        }
    }
}
