using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using DataLayer.Core.Model;
using DataLayer.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class MenuCategoryView
    {
        private int _currentPage = 1;

        private readonly int _displayedCategoryCount = 5;

        private MenuCategory _selectedCategory;

        public void Initialize()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                _selectedCategory = context.MenuCategories.GetById(1);
            }

            FillMenuCategories();
        }

        private void FillMenuCategories()
        {
            DisposeMenuCategories();

            int columnIndex = 0;

            foreach (var category in GetMenuCategories())
            {
                tlpCategory.Controls.Add(InitializeMenuCategoryButton(columnIndex == 0, category),
                    columnIndex++,
                    0);
            }

            ValidatePage();
        }

        private void DisposeMenuCategories()
        {
            var categories = tlpCategory.Controls.Cast<Control>().ToList();

            foreach (var control in categories)
            {
                control.Dispose();
            }
        }

        private IEnumerable<MenuCategory> GetMenuCategories()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                return context.MenuCategories.GetAll((_currentPage - 1) * _displayedCategoryCount, _displayedCategoryCount);
            }
        }

        private FlatButton InitializeMenuCategoryButton(bool isSelected, MenuCategory category)
        {
            var button = new FlatButton()
            {
                Text = category.Name
            };

            if (isSelected)
                SelectedButtonTheme(button);
            else
                DeselectedButtonTheme(button);

            InitalizeMenuCategoryButtonEvent(button, category);

            return button;
        }

        private void SelectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 0, 1, 0);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatBrownLight;
            button.BackColorOnHover = ColorHelper.FlatBrownLight;
            button.BackColorOnClick = ColorHelper.FlatBrownLight;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void DeselectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 0, 1, 0);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatBrownTransparent;
            button.BackColorOnHover = ColorHelper.FlatBrownTransparent;
            button.BackColorOnClick = ColorHelper.FlatBrownTransparent;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void InitalizeMenuCategoryButtonEvent(FlatButton button, MenuCategory category)
        {
            button.Click += (s, e) =>
            {
                SelectMenuCategoryButton(button);

                _selectedCategory = category;
            };
        }

        private void SelectMenuCategoryButton(FlatButton button)
        {
            SelectedButtonTheme(button);

            DeselectMenuCategoryButton(button);
        }

        private void DeselectMenuCategoryButton(FlatButton button)
        {
            foreach (var control in tlpCategory.Controls.Cast<Control>())
            {
                if (control is FlatButton currentButton && !currentButton.Equals(button))
                {
                    DeselectedButtonTheme(currentButton);
                }
            }
        }

        public MenuCategory GetSelectedCategory()
        {
            return _selectedCategory;
        }

        private void ValidatePage()
        {
            btnPreviousPage.Enabled = _currentPage != 1;
            btnNextPage.Enabled = _currentPage != GetTotalPage();
        }

        private void PreviousPage()
        {
            if (_currentPage == 1)
            {
                ValidatePage();

                return;
            }

            _currentPage--;

            FillMenuCategories();
        }

        private void NextPage()
        {
            if (_currentPage == GetTotalPage())
            {
                ValidatePage();

                return;
            }

            _currentPage++;

            FillMenuCategories();
        }

        private int GetTotalPage()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                var categoryCount = context.MenuCategories.Count();

                var totalPage = categoryCount % _displayedCategoryCount == 0 && categoryCount >= _displayedCategoryCount
                    ? categoryCount / _displayedCategoryCount
                    : (categoryCount / _displayedCategoryCount) + 1;

                return totalPage;
            }
        }

        public event EventHandler PaginatorClicked
        {
            add
            {
                btnPreviousPage.Click += value;
                btnNextPage.Click += value;
            }
            remove
            {
                btnPreviousPage.Click -= value;
                btnNextPage.Click -= value;
            }
        }

        public event EventHandler CategoryClicked
        {
            add
            {
                var categories = tlpCategory.Controls.Cast<Control>().ToList();

                foreach (var category in categories)
                {
                    if (category is FlatButton button)
                        button.Click += value;
                }
            }
            remove
            {
                var categories = tlpCategory.Controls.Cast<Control>().ToList();

                foreach (var category in categories)
                {
                    if (category is FlatButton button)
                        button.Click -= value;
                }
            }
        }
    }
}
