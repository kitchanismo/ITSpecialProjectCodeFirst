using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using DataLayer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Commons;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class FilterView
    {
        private IMenuOrder _selectedOrder;

        private void Initialize()
        {
            _selectedOrder = new MenuOrderByAscending();

            InitializeFilterButtonEvent();
        }

        private void InitializeFilterButtonEvent()
        {
            var controls = tlpFilters.Controls.Cast<Control>().ToList();

            foreach (var control in controls)
            {
                if (control is FlatButton button)
                {
                    button.Click += (s, e) =>
                    {
                        SelectMenuCategoryButton(button);

                        var type = Helper.GetMenuOrderByType(button.Text);

                        _selectedOrder = (IMenuOrder) Activator.CreateInstance(type);
                    };
                }
            }
        }

        private void SelectMenuCategoryButton(FlatButton button)
        {
            SelectedButtonTheme(button);

            DeselectMenuCategoryButton(button);
        }

        private void SelectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatGreenNormal;
            button.BackColorOnHover = ColorHelper.FlatGreenNormal;
            button.BackColorOnClick = ColorHelper.FlatGreenNormal;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void DeselectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatGreenTransparent;
            button.BackColorOnHover = ColorHelper.FlatGreenTransparent;
            button.BackColorOnClick = ColorHelper.FlatGreenTransparent;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }


        private void DeselectMenuCategoryButton(FlatButton button)
        {
            foreach (var control in tlpFilters.Controls.Cast<Control>())
            {
                if (control is FlatButton currentButton && !currentButton.Equals(button))
                {
                    DeselectedButtonTheme(currentButton);
                }
            }
        }

        public IMenuOrder GetSelectedOrder()
        {
            return _selectedOrder;
        }

        public event EventHandler FilterButtonClicked
        {
            add
            {
                var controls = tlpFilters.Controls.Cast<Control>().ToList();

                foreach (var control in controls)
                {
                    if (control is FlatButton button)
                    {
                        button.Click += value;
                    }
                }
            }
            remove
            {
                var controls = tlpFilters.Controls.Cast<Control>().ToList();

                foreach (var control in controls)
                {
                    if (control is FlatButton button)
                    {
                        button.Click -= value;
                    }
                }

            }
        }
    }
}
