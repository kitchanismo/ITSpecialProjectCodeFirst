using System;
using System.Windows.Forms;
using ITSpecialProject.Components;
using DataLayer.Core.Model;
using ITSpecialProject.Monostate;
using DataLayer.Persistence;
using ITSpecialProject.Views.Accounts;

namespace ITSpecialProject.Views.Main
{
    public partial class MainView : FlatForm
    {
        public MainView()
        {
            InitializeComponent();

            using (var context = UnitOfWork.Factory.Instance())
            {
                AccountSession.SetAccount(context.Accounts.GetById(1));
            }

            Initialize();
        }

        private void Initialize()
        {
            FillUserDetails();

            Home();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLogout)
            {
                if (!Exit())
                    e.Cancel = true;
            }
        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            GetCurrentDateTime();
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            LockScreen();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        #region Navigation

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            Manage();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Reports();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
           Settings();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Support();
        }

        private void BtnPos_Click(object sender, EventArgs e)
        {
            POS();
        }

        #endregion

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            CreateNavigationContents(null);
        }
    }
}
