using System;
using System.Windows.Forms;
using ITSpecialProject.Components.Popups;
using DataLayer.Core.Model;
using DataLayer.Persistence;

namespace ITSpecialProject.Views.Commons
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            LoadSplashScreen();

            InitializeComponent();

            CheckConnection();

/*
            using (var context = UnitOfWork.Factory.Instance())
            {
                var account = new Account
                {
                    UserName = "George",
                    UserPass = "123456",
                    UserLevel = UserType.Cashier,
                    LockCode = 1234,
                    FirstName = "George",
                    LastName = "Doe",
                    Flag = Flag.Inactive
                };

                context.Accounts.Add(account);
                context.SaveChanges();

                FlatMessageAlert.Show("Added!");
            }
*/
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnQrLogin_Click(object sender, EventArgs e)
        {
            QrLogin();
        }

        private void PbRefresh_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void PbConfiguration_Click(object sender, EventArgs e)
        {
            ShowConfiguration();
        }

        private void PbAbout_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
    }
}
