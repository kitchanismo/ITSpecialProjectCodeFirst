using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Utilities
{
    public partial class PreloaderView : UserControl
    {
        private int _counter;

        public PreloaderView()
        {
            InitializeComponent();

            tmrPreloader.Enabled = true;
        }

        private async void TmrPreloader_Tick(object sender, EventArgs e)
        {
            await Task.Run(() => { BeginAnimation(++_counter); });

            if (_counter == this.Controls.Count)
                _counter = -1;
        }

        private void BeginAnimation(int bulletIndex)
        {
            pbPreloader1.Image = bulletIndex == 1 ? Properties.Resources.PreloaderColor_64 : Properties.Resources.Preloader_64;

            pbPreloader2.Image = bulletIndex == 2 ? Properties.Resources.PreloaderColor_64 : Properties.Resources.Preloader_64;

            pbPreloader3.Image = bulletIndex == 3 ? Properties.Resources.PreloaderColor_64 : Properties.Resources.Preloader_64;

        }
    }
}
