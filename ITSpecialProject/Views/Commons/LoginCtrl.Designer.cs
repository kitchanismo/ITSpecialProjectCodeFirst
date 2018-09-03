using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Components.Popups;
using ITSpecialProject.Monostate;
using DataLayer.Persistence;
using ITSpecialProject.Views.Main;
using ITSpecialProject.Views.Utilities;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Commons
{
    public partial class LoginView
    {
        private bool _isConnected;

        private void LoadSplashScreen()
        {
            var isDone = false;

            ThreadPool.QueueUserWorkItem((x) =>
            {
                using (var splash = new SplashScreenView())
                {
                    splash.Show();

                    while (!isDone)
                    {
                        Application.DoEvents();
                    }

                    splash.Close();
                }
            });

            Thread.Sleep(5000);

            isDone = true;
        }

        private void CheckConnection()
        {
            if (UnitOfWork.Factory.Instance().TestConnection())
            {
                FlatMessageAlert.Show("Connected");

                EnableControls();
            }
            else
            {
                FlatMessageAlert.Show("Disconnected", alertType: AlertType.BadInfo);

                DisableControls();
            }

            this.Focus();
        }

        public void EnableControls()
        {
            txtUserName.Enabled = true;
            txtUserPass.Enabled = true;
            btnLogin.Enabled = true;
            btnQrLogin.Enabled = true;

            pbConnection.Image = Properties.Resources.Connected_32;
            _isConnected = true;
        }

        public void DisableControls()
        {
            txtUserName.Enabled = false;
            txtUserPass.Enabled = false;
            btnLogin.Enabled = false;
            btnQrLogin.Enabled = false;

            pbConnection.Image = Properties.Resources.Disconnected_42;
            _isConnected = false;
        }


        private void Login()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                var login = context.Accounts.Login(txtUserName.Text, txtUserPass.Text);

                if (!login.Exists)
                {
                    LoginErrorMessage();
                    return;
                }

                AccountSession.SetAccount(login.Account);

                this.Hide();

                var main = new MainView();
                main.FormClosed += (s, e) => { this.Show(); };
                main.Show();
            }
        }

        private void LoginErrorMessage()
        {
            FlatMessageAlert.Show("Invalid Credentials", "Error", alertType: AlertType.BadInfo);
        }

        private void QrLogin()
        {
            using (var context = UnitOfWork.Factory.Instance())
            {
                using (var form = new ImageStreamView(context.Accounts.GetAccountByQrCode()))
                {
                    form.Location = new Point(0, 0);
                    form.Size = new Size((this.Width / 3), this.Height);
                    form.ShowDialog();
                }
            }
        }

        private void ShowConfiguration()
        {
            using (var form = new DbConfigurationView())
            {
                form.ShowDialog();

                CheckConnection();
            }
        }

        private void ShowAbout()
        {
            using (var form = new AboutView())
            {
                form.ShowDialog();
            }
        }

        #region Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && _isConnected) Login();

            if (keyData == (Keys.Alt | Keys.Q)) QrLogin();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
