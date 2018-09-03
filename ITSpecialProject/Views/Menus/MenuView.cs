using System.Windows.Forms;

namespace ITSpecialProject.Views.Menus
{
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MenuView_Load(object sender, System.EventArgs e)
        {
            Initialize();
        }

        private void TxtSearch_TextChanged(object sender, System.EventArgs e)
        {
            _filter.MenuName = txtSearch.Text;

            FillMenus(true);
        }

        private void PgMenu_PageNavigationButtonClicked(object sender, System.EventArgs e)
        {
            FillMenus(false);
        }

        private void PgMenu_RecordCountChanged(object sender, System.EventArgs e)
        {
            FillMenus(true);
        }

        private void PgMenu_RefreshButtonClicked(object sender, System.EventArgs e)
        {
            FillMenus(true);
        }

        private void BsMenu_CurrentChanged(object sender, System.EventArgs e)
        {
            FillMenuInformation();
        }

        private void BtnUpdateMenuDetails_Click(object sender, System.EventArgs e)
        {
            UpdateMenu();
        }

        private void LnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UploadMenuImage();
        }

        private void BtnAddMenu_Click(object sender, System.EventArgs e)
        {
            CreateMenu();
        }

        private void BtnDeleteMenu_Click(object sender, System.EventArgs e)
        {
            DeleteMenu();
        }
    }
}
