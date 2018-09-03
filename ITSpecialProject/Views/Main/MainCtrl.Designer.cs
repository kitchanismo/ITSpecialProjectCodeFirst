using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Components.Popups;
using DataLayer.Core;
using DataLayer.Core.Model;
using ITSpecialProject.Views.Accounts;
using ITSpecialProject.Views.Commons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Monostate;
using ITSpecialProject.Views.Menus;
using ITSpecialProject.Views.PointOfSale;

namespace ITSpecialProject.Views.Main
{
    public partial class MainView
    {
        private bool _isLogout;

        private void GetCurrentDateTime()
        {
            lblDateTime.Text = $"{DateTime.Now.ToString("MMM dd")} • {DateTime.Now.ToString("hh:mm tt")}";
        }

        public void FillUserDetails()
        {
            btnProfile.Text = $"Good Day, {AccountSession.GetAccount.FirstName}!";

            GetCurrentDateTime();
        }

        #region Navigation

        private void Home()
        {
            SetTitle("Home");

            CreateNavigationContents(null);
        }

        private void Manage()
        {
            CreateNavigationContents(GetManageModules());
        }

        private void Reports()
        {
            CreateNavigationContents(null);
        }

        private void Settings()
        {
            CreateNavigationContents(null);
        }

        private void Support()
        {
            CreateNavigationContents(null);

        }

        private void POS()
        {
            SetTitle("Point Of Sales");

            ClearContents();

            var pos = new PointOfSaleView();

            pnlBody.Controls.Add(pos);

            pos.Dock = DockStyle.Fill;

            CreateNavigationContents(null);
        }

        private void SetTitle(string title)
        {
            lblModuleTitle.Text = title;
        }

        #endregion

        #region Modules

        private void CreateNavigationContents(List<Module> modules)
        {
            if (modules is null)
            {
                pnlSubNavigation.Hide();
                return;
            }

            pnlSubNavigation.Show();

            pnlSubNavigation.Initialize(modules);

            pnlSubNavigation.NavigationButtonClicked += (s, e) =>
            {
                ShowModule(); 
            };
        }

        private static List<Module> GetManageModules()
        {
            return new List<Module>
            {
                new Module { Title = "Menus", Instance = new MenuView() },
                new Module { Title = "Consumables", Instance = new AccountView() },
                new Module { Title = "Stocks", Instance = new AccountView() },
                new Module { Title = "Accounts", Instance = new AccountView() },
            };
        }

        private void ShowModule()
        {
            ClearContents();

            SetModuleTitle();

            CreateModuleInstance();
        }

        private void CreateModuleInstance()
        {
            var module = pnlSubNavigation.SelectedModule.Instance();

            pnlBody.Controls.Add(module);

            module.Dock = DockStyle.Fill;
        }

        private void SetModuleTitle()
        {
            lblModuleTitle.Text = pnlSubNavigation.SelectedTitle;
        }

        private void ClearContents()
        {
            pnlBody.Controls.Clear();
        }

        #endregion

        #region Sign Off

        private void LockScreen()
        {
            this.Hide();

            var form = new LockScreenView();
            form.Show();

            form.FormClosed += (s, e) => { this.Show(); };
        }

        private bool Logout()
        {
            if (!LogoutMessage()) return false;

            _isLogout = true;

            return true;
        }

        private bool LogoutMessage()
        {
            return FlatMessageBox.Show("Do you want to logout?", "Logout", DialogButtons.YesNo, DialogType.Info) == DialogButton.Yes
                ? true
                : false;
        }

        private bool Exit()
        {
            if (ExitMessage())
            {
                Environment.Exit(0);
            }

            return false;
        }

        private bool ExitMessage()
        {
            return FlatMessageBox.Show("Do you want to exit?", "Exit", DialogButtons.YesNo, DialogType.Info) == DialogButton.Yes
                ? true
                : false;
        }

        #endregion
    }
}
