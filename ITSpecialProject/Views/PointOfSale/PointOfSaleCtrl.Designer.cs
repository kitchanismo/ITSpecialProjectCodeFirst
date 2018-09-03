using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Components.Popups;
using DataLayer.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Menu = DataLayer.Core.Model.Menu;

namespace ITSpecialProject.Views.PointOfSale
{
    public partial class PointOfSaleView
    {
        private Invoice _invoice;

        private void Initialize()
        {
            InitializeMenus();
            InitializeInvoice();
            InitializeEvents();
        }

        private void InitializeMenus()
        {
            InitializeMenuFilters();
            BrowseMenus(true);
        }

        private void InitializeInvoice()
        {
            _invoice = new Invoice();
            UpdateInvoice();
        }

        private void InitializeMenuFilters()
        {
            ucMenuCategory.Initialize();

            pgMenu.SetRecordsPerPage(2);
        }

        private void BrowseMenus(bool resetPage)
        {
            if (resetPage)
            {
                pgMenu.ResetPage();
            }

            flowMenus.Controls.Clear();

            flowMenus.Controls.AddRange(GetMenuCards().ToArray());
        }

        private IEnumerable<ItemCardView> GetMenuCards()
        {
            var menus = GetMenus();

            foreach (var menu in menus)
            {
                var menuCard = new ItemCardView(menu);

                menuCard.CardClicked += (s, e) =>
                {
                    if (menuCard.GetMenu.Availability)
                    {
                        SelectMenu(menu);
                    }
                    else
                    {
                        FlatMessageAlert.Show($"{menuCard.GetMenu.Name} is not available", alertType: AlertType.BadInfo);
                    }
                };

                yield return menuCard;
            }
        }

        private IEnumerable<Menu> GetMenus()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                var categoryId = ucMenuCategory.GetSelectedCategory().Id;

                pgMenu.SetMaxPage(context.Menus
                    .Find(m => m.CategoryId == categoryId)
                    .Count());

                return ucFilterView.GetSelectedOrder()
                    .SetMenuOrder(
                        context.Menus
                            .Find(m =>
                                m.CategoryId == categoryId)
                            .OrderBy(m => m.Id)
                            .Skip(pgMenu.GetSkipPage)
                            .Take(pgMenu.GetRecordsPerPage));
            }
        }

        private void CreateCategoryClickedEvent()
        {
            ucMenuCategory.CategoryClicked += (s, e) =>
            {
                BrowseMenus(true);
            };
        }

        private void InitializeEvents()
        {
            CreateCategoryClickedEvent();

            ucMenuCategory.PaginatorClicked += (s, e) =>
            {
                CreateCategoryClickedEvent();

                BrowseMenus(false);
            };

            ucFilterView.FilterButtonClicked += (s, e) =>
            {
                BrowseMenus(true);
            };

            pgMenu.PageNavigationButtonClicked += (s, e) =>
            {
                BrowseMenus(false);
            };
            pgMenu.RefreshButtonClicked += (s, e) =>
            {
                BrowseMenus(true);
            };

            pgMenu.RecordCountChanged += (s, e) =>
            {
                BrowseMenus(true);
            };
        }

        private void SelectMenu(Menu menu)
        {
            if (MenuDuplicated(menu)) return;

            var invoiceCard = new InvoiceCardView(menu);

            AddInvoice(menu);

            invoiceCard.QuantityChanged += (s, e) =>
            {
                UpdateQuantity(invoiceCard);
            };

            invoiceCard.ItemRemoved += (s, e) =>
            {
                RemoveItem(invoiceCard);
            };

            flowInvoice.Controls.Add(invoiceCard);
        }

        private bool MenuDuplicated(Menu menu)
        {
            foreach (var control in flowInvoice.Controls.Cast<Control>())
            {
                if (control is InvoiceCardView invoiceCard)
                {
                    if (invoiceCard.GetMenu.Equals(menu))
                    {
                        invoiceCard.IncreaseQuantity();

                        UpdateQuantity(invoiceCard);

                        return true;
                    };
                }
            }

            return false;
        }

        private void AddInvoice(Menu menu)
        {
            _invoice.Orders.Add(new Invoice.MenuWithQuantity { Menu = menu, Quantity = 1 });

            UpdateInvoice();
        }

        private void UpdateQuantity(InvoiceCardView invoiceCard)
        {
            var invoice = _invoice.Orders.SingleOrDefault(m => m.Menu.Id == invoiceCard.GetMenu.Id);

            invoice.Quantity = invoiceCard.GetQuantity;

            UpdateInvoice();
        }

        private void RemoveItem(InvoiceCardView invoiceCard)
        {
            var index = _invoice.Orders.FindIndex(i => i.Menu.Id == invoiceCard.GetMenu.Id);

            _invoice.Orders.RemoveAt(index);

            invoiceCard.Dispose();

            UpdateInvoice();
        }

        private void UpdateInvoice()
        {
            _invoice.SubTotal = (_invoice.Orders.Select(i => i.Menu.Price * i.Quantity)).Sum();

            _invoice.NetAmount = _invoice.SubTotal;

            lblDiscount.Text = $"0%";

            lblSubTotal.Text = $"\u20b1 {_invoice.SubTotal}";

            lblNetAmount.Text = $"\u20b1 {_invoice.NetAmount}";

            btnPay.Text = $"PAY\n" +
                          $"{lblNetAmount.Text}";
        }
    }
}
