using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ITSpecialProject.Views.Utilities
{
    public partial class ImageStreamView : Form
    {
        public ImageStreamView(IEnumerable<string> registeredQrCode)
        {
            InitializeComponent();

            Initialize(registeredQrCode);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            StopImageStream();
        }

        private void TmrDecode_Tick(object sender, EventArgs e)
        {
            ValidateQrCode();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            _isScanning = !_isScanning ? StartScanning() : EndScanning();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {

        }
    }
}
