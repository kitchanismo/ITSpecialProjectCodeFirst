using System;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Commons
{
    public partial class DbConfigurationView : Form
    {
        public DbConfigurationView()
        {
            InitializeComponent();

            Authenticate();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAuthentication();
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
