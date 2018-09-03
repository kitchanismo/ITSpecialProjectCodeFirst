using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using ITSpecialProject.Components.Popups;
using DataLayer.Core;
using DataLayer.Core.Model;
using DataLayer.Persistence;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ITSpecialProject.Monostate;

namespace ITSpecialProject.Views.Accounts
{
    public partial class AccountView : IModule
    {
        public UserControl Instance()
        {
            return new AccountView();
        }

        public void Initialize()
        {
            InitializeFiltersEvent();
            InitializeAccountList();
            InitializeAccountInfo();
        }

        #region Account List

        private (string SearchKey, UserType UserType, bool Flag) _filter;

        private Account _selectedAccount;

        private void InitializeAccountList()
        {
            _filter = (string.Empty, UserType.Administrator, true);

            BrowseAccounts(true);
        }

        private void BrowseAccounts(bool resetPage)
        {
            flpAccounts.Controls.Clear();

            if(resetPage)
                pgAccount.ResetPage();

            var accounts = GetAccounts();

            flpAccounts.Controls.AddRange(GenerateAccountCards(accounts).ToArray());

            _selectedAccount = accounts.Count() != 0 ? accounts.First() : null;

            FillAccountInformation();
        }

        private IEnumerable<Account> GetAccounts()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                SetAccountTotalPage(context);

                return context.Accounts.GetAll(_filter, pgAccount.GetSkipPage, pgAccount.GetRecordsPerPage);
            }
        }

        private void SetAccountTotalPage(UnitOfWork context)
        {
            pgAccount.SetMaxPage(context.Accounts.Count(_filter));
        }

        private IEnumerable<AccountCardView> GenerateAccountCards(IEnumerable<Account> accounts)
        {
            var toggle = true;

            foreach (var account in accounts)
            {
                var card = new AccountCardView(account);

                if (toggle)
                {
                    card.SetSelectedBackColor(card);

                    toggle = false;
                }

                card.CardClicked += (s, e) =>
                {
                    _selectedAccount = card.GetAccount;

                    FillAccountInformation();
                };

                card.EditButtonClicked += (s, e) =>
                {
                    _selectedAccount = card.GetAccount;

                    cbEditMode.Checked = true;

                    FillAccountInformation();

                    SetAccountEditMode(true);
                };

                card.DeleteButtonClicked += (s, e) =>
                {
                    _selectedAccount = card.GetAccount;

                    FillAccountInformation();

                    DeactivateAccount();
                };

                yield return card;
            }
        }

        public Account SelectedAccount => _selectedAccount;


        #endregion

        #region Account Information

        private void InitializeAccountInfo()
        {
            cbEditMode.CheckedChanged += (s, e) =>
            {
                SetAccountEditMode(cbEditMode.Checked);
            };

            tblUserAccess.CellClick += (s, e) =>
            {
                if (cbEditMode.Checked)
                {
                    tblUserAccess[e.ColumnIndex, e.RowIndex].Value = !(bool)tblUserAccess[e.ColumnIndex, e.RowIndex].Value;
                }
            };

            foreach (var control in flpAccountDetails.Controls.Cast<Control>())
            {
                if (control is FlatTextBox textbox)
                {
                    textbox.TextChanged += (s, e) => { epAccountForm.SetError(textbox, string.Empty); };
                }
            }
        }

        public void FillAccountInformation()
        {
            if (_selectedAccount == null)
            {
                ClearAccountInfo();
                return;
            }

            ShowAccountDetails(_selectedAccount);
            ShowAccountAccess(_selectedAccount.Id);
        }

        private void ClearAccountInfo()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();
            txtUserPass.Clear();
            pbAccount.Image = PathHelper.GetDefaultAccountImage;
            bsAccountAccess.Clear();
        }

        private void ShowAccountDetails(Account account)
        {
            txtFirstName.Text = account.FirstName;
            txtLastName.Text = account.LastName;
            txtUserName.Text = account.UserName;
            txtUserPass.Text = account.UserPass;

            pbAccount.Image = string.IsNullOrEmpty(account.ProfileImage)
                ? PathHelper.GetDefaultAccountImage
                : PathHelper.GetImage(account.ProfileImage);
        }

        private void ShowAccountAccess(int id)
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                bsAccountAccess.DataSource = context.AccountAccess.GetByAccountId(id);
            }
        }

        private void SetAccountEditMode(bool state)
        {
            btnUpdateAccountDetails.Visible =
                btnUpdateAccountAccess.Visible =
                    lnkUpload.Visible =
                        state;

            cbEditMode.Text = state
                ? cbEditMode.Text.Replace("OFF", "ON")
                : cbEditMode.Text.Replace("ON", "OFF");

            SelectAccountTabFilterButton(btnAccountDetails);

            tcAccounts.SelectedTab = tpAccountDetails;

            txtFirstName.Focus();
        }

        private void UpdateAccountDetails()
        {
            if (_selectedAccount == null) return;

            if (!ValidateAccountDetails()) return;

            if (FlatMessageBox.Show("Are you sure?", "Update", DialogButtons.YesNo, DialogType.Question) ==
                DialogButton.No) return;

            using (var context = UnitOfWork.Factory.Instance())
            {
                var account = context.Accounts.GetById(SelectedAccount.Id);

                account.FirstName = txtFirstName.Text;
                account.LastName = txtLastName.Text;
                account.UserName = txtUserName.Text;
                account.UserPass = txtUserPass.Text;

                context.SaveChanges();

                AccountSession.SetAccount(account);

                FlatMessageAlert.Show("updated successfully.", "info", AlertType.Update);
            }
        }

        private bool ValidateAccountDetails()
        {
            var isValidated = true;

            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
                isValidated = SetErrorMessage(txtFirstName, MessageHelper.NoInput());

            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
                isValidated = SetErrorMessage(txtLastName, MessageHelper.NoInput());

            if (string.IsNullOrEmpty(txtUserPass.Text.Trim()))
                isValidated = SetErrorMessage(txtUserPass, MessageHelper.NoInput());

            using (var context = UnitOfWork.Factory.Instance())
            {
                if (context.Accounts.UserNameAlreadyUsed(txtUserName.Text, SelectedAccount.Id))
                {
                    isValidated = SetErrorMessage(txtUserName, MessageHelper.DuplicateRecord(txtUserName.Text));
                }
            }

            return isValidated;
        }

        private void UpdateAccountAccesses()
        {
            if (_selectedAccount == null) return;

            if (FlatMessageBox.Show("Are you sure?", "Update Account", DialogButtons.YesNo, DialogType.Question) ==
                DialogButton.Yes)
            {
                using (var context = UnitOfWork.Factory.Instance())
                {
                    foreach (var access in context.AccountAccess.GetByAccountId(SelectedAccount.Id))
                    {
                        var newAccess = bsAccountAccess.Cast<AccountAccess>().SingleOrDefault(a => a.Id == access.Id);

                        access.Accessible = newAccess.Accessible;
                        access.AddRecord = newAccess.AddRecord;
                        access.EditRecord = newAccess.EditRecord;
                        access.DeleteRecord = newAccess.DeleteRecord;
                        access.GenerateReport = newAccess.GenerateReport;  
                    }

                    context.SaveChanges();

                    FlatMessageAlert.Show("Update Successful.", alertType: AlertType.Update);
                }
            }
        }

        private bool SetErrorMessage(Control control, string errorMessage)
        {
            epAccountForm.SetError(control, errorMessage);

            return false;
        }

        private void DeactivateAccount()
        {
            if (_selectedAccount == null) return;

            if (_selectedAccount.Id == AccountSession.GetAccount.Id)
            {
                FlatMessageAlert.Show("You cannot deactivate your own account.", "Error", AlertType.Error);

                return;
            }

            if (FlatMessageBox.Show(
                    "Deactivating this account indicates that you may not able to use this account on any kind of transaction. " +
                    "Do you still want to proceed?", "Deactivate Account", DialogButtons.YesNo, DialogType.Warning) ==
                DialogButton.Yes)
            {
                using (var context = UnitOfWork.Factory.Instance())
                {
                    var account = context.Accounts.GetById(_selectedAccount.Id);

                    account.Flag = false;

                    context.SaveChanges();

                    FlatMessageAlert.Show("Deactivate Successful.", alertType: AlertType.Info);

                    BrowseAccounts(true);
                }
            }
        }

        #endregion

        #region Filters Event

        private void InitializeFiltersEvent()
        {
            CreateFlagFilterEvent();
            CreateAccountTabFilterEvent();
        }

        private void CreateFlagFilterEvent()
        {
            var controls = tlpFlagTab.Controls.Cast<Control>().ToList();

            foreach (var control in controls)
            {
                if (control is FlatButton button)
                {
                    button.Click += (s, e) =>
                    {
                        SelectFlagFilterButton(button);
                    };
                }
            }
        }

        private void SelectFlagFilterButton(FlatButton button)
        {
            SelectedFlagButtonTheme(button);

            DeselectFlagFilterButton(button);
        }

        private void SelectedFlagButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = button.Equals(btnActive) ? ColorHelper.FlatGreenNormal : ColorHelper.FlatRedNormal;
            button.BackColorOnHover = button.Equals(btnActive) ? ColorHelper.FlatGreenNormal : ColorHelper.FlatRedNormal;
            button.BackColorOnClick = button.Equals(btnActive) ? ColorHelper.FlatGreenNormal : ColorHelper.FlatRedNormal;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void DeselectFlagFilterButton(FlatButton button)
        {
            foreach (var control in tlpFlagTab.Controls.Cast<Control>())
            {
                if (control is FlatButton currentButton && !currentButton.Equals(button))
                {
                    DeselectedButtonTheme(currentButton);
                }
            }
        }

        private void CreateAccountTabFilterEvent()
        {
            var controls = tlpAccountTab.Controls.Cast<Control>().ToList();

            foreach (var control in controls)
            {
                if (control is FlatButton button)
                {
                    button.Click += (s, e) =>
                    {
                        SelectAccountTabFilterButton(button);
                    };
                }
            }
        }

        private void SelectAccountTabFilterButton(FlatButton button)
        {
            SelectedAccountTabButtonTheme(button);

            DeselectAccountTabFilterButton(button);
        }

        private void SelectedAccountTabButtonTheme(FlatButton button)
        {
            button.Margin = new Padding(1, 1, 1, 1);
            button.Dock = DockStyle.Fill;
            button.BackColorOnDefault = ColorHelper.FlatYellowNormal;
            button.BackColorOnHover = ColorHelper.FlatYellowNormal;
            button.BackColorOnClick = ColorHelper.FlatYellowNormal;
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void DeselectAccountTabFilterButton(FlatButton button)
        {
            foreach (var control in tlpAccountTab.Controls.Cast<Control>())
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
            button.BackColorOnDefault = Color.FromArgb(72, 72, 72);
            button.BackColorOnHover = Color.FromArgb(72, 72, 72);
            button.BackColorOnClick = Color.FromArgb(72, 72, 72);
            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }


        #endregion
    }
}
