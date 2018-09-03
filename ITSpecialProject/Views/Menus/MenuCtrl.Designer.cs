using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using ITSpecialProject.Components.Popups;
using DataLayer.Core;
using DataLayer.Core.Model;
using DataLayer.Filters;
using DataLayer.Persistence;
using DataLayer.Extensions;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Menu = DataLayer.Core.Model.Menu;

namespace ITSpecialProject.Views.Menus
{
    public partial class MenuView : IModule
    {
        private MenuFilter _filter;

        public UserControl Instance()
        {
            return new MenuView();
        }

        public void Initialize()
        {
            InitializeProperties();
            InitializeEvents();
        }

        #region Menu List

        private void InitializeProperties()
        {
            _filter = new MenuFilter()
            {
                MenuName = string.Empty,
                CategoryId = 10,
                MenuOrder = new MenuOrderByAscending(),
                Availability = true,
                Flag = true

            };

            FillMenuFilters();
            FillMenus(true);
        }

        private void FillMenuFilters()
        {
            cbCategory.DataSource = cbMenuCategory.DataSource = GetMenuCategories();
            cbCategory.ValueMember = cbMenuCategory.ValueMember = "Id";
            cbCategory.DisplayMember = cbMenuCategory.DisplayMember = "Name";

            cbStatus.SelectedIndex = 0;
            cbFlag.SelectedIndex = 0;
        }

        private IEnumerable<MenuCategory> GetMenuCategories()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                return context.MenuCategories.GetAll();
            }
        }

        private void FillMenus(bool resetPage)
        {
            if (resetPage)
                pgMenu.ResetPage();

            bsMenu.DataSource = GetMenus();

            FillMenuInformation();
        }

        private IEnumerable<DataLayer.Core.Model.Menu> GetMenus()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                SetMenuTotalPage(context);

                return context.Menus
                    .GetMenusByFilter(_filter);
            }
        }

        private void SetMenuTotalPage(UnitOfWork context)
        {
            pgMenu.SetMaxPage(context.Menus.Count(_filter));

            _filter.Skip = pgMenu.GetSkipPage;
            _filter.Take = pgMenu.GetRecordsPerPage;
        }

        #endregion

        #region Menu Information

        private void MenuEditMode(bool state)
        {
            btnUpdateMenuDetails.Visible =
                lnkUpload.Visible = state;

            cbEditMode.Text = state
                ? cbEditMode.Text.Replace("OFF", "ON")
                : cbEditMode.Text.Replace("ON", "OFF");
        }

        private void FillMenuInformation()
        {
            var menu = bsMenu.Current as Menu;

            if (menu == null)
            {
                ClearMenuInformation();

                return;
            }

            FillMenuDetails(menu);
        }

        private void ClearMenuInformation()
        {
            #region Menu Details

            txtMenuName.Clear();
            txtMenuAcronym.Clear();
            txtMenuPrice.Clear();
            cbMenuCategory.SelectedIndex = 0;
            cbMenuAvailability.Checked = true;
            pbAccount.Image = Properties.Resources.Default_100;

            #endregion
        }

        private void FillMenuDetails(Menu menu)
        {
            txtMenuName.Text = menu.Name;
            txtMenuAcronym.Text = menu.Acronym;
            txtMenuPrice.Text = menu.Price.ToString();

            cbMenuCategory.SelectedValue = menu.CategoryId;
            cbMenuAvailability.Checked = menu.Availability;

            pbAccount.Image = string.IsNullOrEmpty(menu.MenuImage)
                ? Properties.Resources.Default_100
                : PathHelper.GetImage(menu.MenuImage);
        }

        private void UpdateMenu()
        {
            var currentMenu = bsMenu.Current as Menu;

            if (currentMenu == null) return;

            if (!ValidateMenuOnUpdate(currentMenu)) return;

            using (var context = UnitOfWork.Factory.Instance())
            {
                var menu = context.Menus.GetById(currentMenu.Id);

                menu.Name = txtMenuName.Text;
                menu.Acronym = txtMenuAcronym.Text.ToUpper();
                menu.CategoryId = (int)cbCategory.SelectedValue;
                menu.Price = decimal.TryParse(txtMenuPrice.Text, out var price) ? price : 0.00m;
                menu.MenuImage = currentMenu.MenuImage;
                menu.Availability = cbMenuAvailability.Checked;

                context.SaveChanges();

                FillMenus(false);

                FlatMessageAlert.Show("Update Successful.", alertType: AlertType.Update);
            }
        }

        private void UploadMenuImage()
        {
            using (var upload = new OpenFileDialog())
            {
                upload.Filter = "All Image Types |*.jpeg;*.jpg;*png;*.bmp;";
                upload.InitialDirectory = PathHelper.GetDesktopPath();
                upload.Multiselect = false;

                if (upload.ShowDialog() == DialogResult.OK)
                {
                    var image = PathHelper.CopyImage(upload.FileName);

                    ((Menu)bsMenu.Current).MenuImage = image;

                    pbAccount.Image = Image.FromFile(upload.FileName);
                }
            }
        }

        private bool ValidateMenuOnUpdate(Menu menu)
        {
            var validated = true;

            using (var context = UnitOfWork.Factory.Instance())
            {
                if (context.Menus.NameAlreadyUsed(menu.Id, txtMenuName.Text))
                {
                    validated = SetErrorMessage(txtMenuName, MessageHelper.DuplicateRecord(txtMenuName.Text));
                }

                if (context.Menus.AcronymAlreadyUsed(menu.Id, txtMenuAcronym.Text))
                {
                    validated = SetErrorMessage(txtMenuAcronym, MessageHelper.DuplicateRecord(txtMenuAcronym.Text));
                }
            }

            if (string.IsNullOrEmpty(txtMenuName.Text.Trim()))
                validated = SetErrorMessage(txtMenuName, MessageHelper.NoInput());

            if (string.IsNullOrEmpty(txtMenuAcronym.Text.Trim()))
                validated = SetErrorMessage(txtMenuAcronym, MessageHelper.NoInput());

            return validated;
        }

        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epMenuForm.SetError(control, errorMessage);

            return false;
        }

        private void CreateMenu()
        {
            using (var form = new CreateMenuView())
            {
                form.ShowDialog();

                FillMenus(true);
            }
        }

        private void DeleteMenu()
        {
            var currentMenu = bsMenu.Current as Menu;

            if (currentMenu == null) return;

            if (FlatMessageBox.Show("Are you sure?", "Delete", DialogButtons.YesNo, DialogType.Warning) ==
                DialogButton.Yes)
            {
                using (var context = UnitOfWork.Factory.Instance())
                {
                    var menu = context.Menus.GetById(currentMenu.Id);

                    menu.Flag = false;

                    context.SaveChanges();

                    FillMenus(true);

                    FlatMessageAlert.Show("Delete Successful.", alertType: AlertType.Delete);
                }
            }
        }

        #endregion

        #region Filters Event

        private void InitializeEvents()
        {
            CreateTabFilterEvent();
            CreateMenuFilterEvent();
        }

        private void CreateMenuFilterEvent()
        {
            cbCategory.SelectedIndexChanged += (s, e) =>
            {
                _filter.CategoryId = (int)cbCategory.SelectedValue;

                FillMenus(true);
            };

            cbStatus.SelectedIndexChanged += (s, e) =>
            {
                _filter.Availability = cbStatus.SelectedIndex == 0;

                FillMenus(true);
            };

            cbFlag.SelectedIndexChanged += (s, e) =>
            {
                _filter.Flag = cbFlag.SelectedIndex == 0;

                FillMenus(true);
            };

            cbMenuAvailability.CheckedChanged += (s, e) =>
            {
                cbMenuAvailability.Text = cbMenuAvailability.Checked ? "available" : "not available";
            };

            cbEditMode.CheckedChanged += (s, e) =>
            {
                MenuEditMode(cbEditMode.Checked);
            };

            foreach (var control in flowMenuDetails.Controls.Cast<Control>())
            {
                if (control is FlatTextBox textBox)
                    textBox.TextChanged += (s, e) => { epMenuForm.SetError(textBox, string.Empty); };
            }
        }

        private void CreateTabFilterEvent()
        {
            var controls = tlpContents.Controls.Cast<Control>().ToList();

            foreach (var control in controls)
            {
                if (control is FlatButton button)
                {
                    button.Click += (s, e) =>
                    {
                        SelectTabFilterButton(button);
                    };
                }
            }
        }

        private void SelectTabFilterButton(FlatButton button)
        {
            SelectedTabButtonTheme(button);

            DeselectFTabFilterButton(button);
        }

        private void SelectedTabButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatBrownNormal;
            button.BackColorOnHover = ColorHelper.FlatBrownNormal;
            button.BackColorOnClick = ColorHelper.FlatBrownNormal;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void DeselectFTabFilterButton(FlatButton button)
        {
            foreach (var control in tlpContents.Controls.Cast<Control>())
            {
                if (control is FlatButton currentButton && !currentButton.Equals(button))
                {
                    DeselectedButtonTheme(currentButton);
                }
            }
        }

        private void DeselectedButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatBrownTransparent;
            button.BackColorOnHover = ColorHelper.FlatBrownTransparent;
            button.BackColorOnClick = ColorHelper.FlatBrownTransparent;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        #endregion
    }
}
