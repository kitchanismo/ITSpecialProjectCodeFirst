using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using ITSpecialProject.Components.Popups;
using DataLayer.Core.Model;
using DataLayer.Persistence;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Menu = DataLayer.Core.Model.Menu;

namespace ITSpecialProject.Views.Menus
{
    public partial class CreateMenuView
    {
        private string _image;

        private void Initialize()
        {
            _image = string.Empty;

            FillMenuCategories();
            InitializeEvents();
        }

        private void FillMenuCategories()
        {
            cbMenuCategory.DataSource = GetMenuCategories();
            cbMenuCategory.ValueMember = "Id";
            cbMenuCategory.DisplayMember = "Name";
        }

        private void InitializeEvents()
        {
            foreach (var control in pnlBody.Controls.Cast<Control>())
            {
                if (control is FlatTextBox textBox)
                {
                    textBox.TextChanged += (s, e) => { epMenuForm.SetError(textBox, string.Empty); };
                }
            }
        }

        private IEnumerable<MenuCategory> GetMenuCategories()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                return context.MenuCategories.GetAll();
            }
        }

        private void CreateMenu()
        {
            if (!ValidateMenuOnCreate()) return;

            using (var context = UnitOfWork.Factory.Instance())
            {
                var menu = new Menu
                {
                    Name = txtMenuName.Text,
                    Acronym = txtMenuAcronym.Text,
                    CategoryId = (int)cbMenuCategory.SelectedValue,
                    MenuImage = _image,
                    Availability = cbMenuAvailability.Checked,
                    Price = decimal.TryParse(txtMenuDefaultPrice.Text, out var price)
                        ? price
                        : 0.00m,
                    Flag = true
                };

                context.Menus.Add(menu);

                context.SaveChanges();

                FlatMessageAlert.Show("Added Successfully.");

                this.Close();
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
                    RemovePreviousImage();

                    _image = PathHelper.CopyImage(upload.FileName);

                    pbAccount.Image = Image.FromFile(upload.FileName);
                }
            }
        }

        private void RemovePreviousImage()
        {
            var previousImage = Path.Combine(PathHelper.GetImagePath(), _image);

            if (File.Exists(previousImage))
            {
                File.Delete(previousImage);
            }
        }

        private bool ValidateMenuOnCreate()
        {
            var validated = true;

            using (var context = UnitOfWork.Factory.Instance())
            {
                if (context.Menus.NameAlreadyUsed(txtMenuName.Text))
                {
                    validated = SetErrorMessage(txtMenuName, MessageHelper.DuplicateRecord(txtMenuName.Text));
                }

                if (context.Menus.AcronymAlreadyUsed(txtMenuAcronym.Text))
                {
                    validated = SetErrorMessage(txtMenuAcronym, MessageHelper.DuplicateRecord(txtMenuAcronym.Text));
                }
            }

            if (string.IsNullOrEmpty(txtMenuName.Text.Trim()))
            {
                validated = SetErrorMessage(txtMenuName, MessageHelper.NoInput());
            }

            if (string.IsNullOrEmpty(txtMenuAcronym.Text.Trim()))
            {
                validated = SetErrorMessage(txtMenuAcronym, MessageHelper.NoInput());
            }

            if (string.IsNullOrEmpty(txtMenuDefaultPrice.Text.Trim()))
            {
                validated = SetErrorMessage(txtMenuDefaultPrice, MessageHelper.NoInput());
            }

            return validated;
        }

        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epMenuForm.SetError(control, errorMessage);

            return false;
        }
    }
}
