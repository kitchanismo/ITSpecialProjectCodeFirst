using System;

namespace ITSpecialProject.Views.Commons
{
    public partial class DbConfigurationView
    {
        private enum Authentication
        {
            Windows = 0,
            SqlServer = 1
        }

        private void Authenticate()
        {
            cbAuthentication.SelectedItem = Properties.Settings.Default.Authentication;

            CheckAuthentication();
        }

        private void CheckAuthentication()
        {
            var authentication = cbAuthentication.SelectedIndex == 0
                    ? Authentication.Windows
                    : Authentication.SqlServer;

            switch (authentication)
            {
                case Authentication.Windows:
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    break;
                case Authentication.SqlServer:
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(authentication), authentication, null);
            }
        }

        private void SaveChanges()
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            this.Close();
        }
    }
}
