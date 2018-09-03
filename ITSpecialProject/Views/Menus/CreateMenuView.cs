using ITSpecialProject.Components;

namespace ITSpecialProject.Views.Menus
{
    public partial class CreateMenuView : FlatForm
    {
        public CreateMenuView()
        {
            InitializeComponent();
            Initialize();
        }

        private void BtnCreate_Click(object sender, System.EventArgs e)
        {
            CreateMenu();
        }

        private void LnkUpload_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            UploadMenuImage();
        }
    }
}
