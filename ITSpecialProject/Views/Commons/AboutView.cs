using System;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Commons
{
    public partial class AboutView : Form
    {
        public AboutView()
        {
            InitializeComponent();

            FillAssemblyInformation();
        }

        private void BtnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
