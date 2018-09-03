using System;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Accounts
{
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();

            Initialize();
        }

        #region Account List

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            _filter.SearchKey = txtSearch.Text;

            BrowseAccounts(true);
        }

        private void BtnActive_Click(object sender, EventArgs e)
        {
            _filter.Flag = true;

            BrowseAccounts(true);
        }

        private void BtnInactive_Click(object sender, EventArgs e)
        {
            _filter.Flag = false;

            BrowseAccounts(true);
        }

        private void PgAccount_PageNavigationButtonClicked(object sender, EventArgs e)
        {
            BrowseAccounts(false);
        }

        private void PgAccount_RefreshButtonClicked(object sender, EventArgs e)
        {
            BrowseAccounts(true);
        }

        #endregion

        #region Account Information

        private void BtnAccountDetails_Click(object sender, EventArgs e)
        {
            tcAccounts.SelectedTab = tpAccountDetails;
        }

        private void BtnAccountAccess_Click(object sender, EventArgs e)
        {
            tcAccounts.SelectedTab = tpAccountAccess;
        }

        private void BtnAccountActivities_Click(object sender, EventArgs e)
        {
            tcAccounts.SelectedTab = tpAccountActivities;
        }


        #endregion

        private void BtnUpdateAccountDetails_Click(object sender, EventArgs e)
        {
            UpdateAccountDetails();
        }

        private void BtnUpdateAccountAccess_Click(object sender, EventArgs e)
        {
            UpdateAccountAccesses();
        }

        private void BtnNewAccount_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeactivateAccount_Click(object sender, EventArgs e)
        {
            DeactivateAccount();
        }
    }
}
