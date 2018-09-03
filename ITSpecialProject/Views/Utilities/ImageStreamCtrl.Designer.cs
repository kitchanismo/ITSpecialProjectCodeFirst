using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components.Popups;
using ITSpecialProject.Views.Main;
using ITSpecialProject.Views.Menus;
using ZXing;

namespace ITSpecialProject.Views.Utilities
{
    public partial class ImageStreamView
    {
        private FilterInfoCollection _webcamDevices;
        private VideoCaptureDevice _videoSource;

        private IEnumerable<string> _registeredQrCode;

        private bool _isScanning;

        private void Initialize(IEnumerable<string> registeredQrCode)
        {
            GetAvailableDevices();

            _registeredQrCode = registeredQrCode;
            StartStreaming();
        }

        private void GetAvailableDevices()
        {
            _webcamDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in _webcamDevices)
            {
                cbDevices.Items.Add(device.Name);
            }

            cbDevices.SelectedIndex = 0;
        }

        private void StartStreaming()
        {
            _videoSource = new VideoCaptureDevice();

            _videoSource = new VideoCaptureDevice(_webcamDevices[cbDevices.SelectedIndex].MonikerString);
            _videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            _videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbFrame.Image = (Image)eventArgs.Frame.Clone();
        }

        private bool StartScanning()
        {
            tmrDecode.Start();

            btnScan.Text = "stop\nscanning";

            btnScan.BackColorOnDefault = ColorHelper.FlatRedNormal;
            btnScan.BackColorOnHover = ColorHelper.FlatRedLight;
            btnScan.BackColorOnClick = ColorHelper.FlatRedDark;

            return true;
        }

        private bool EndScanning()
        {
            tmrDecode.Stop();

            btnScan.Text = "start\nscanning";

            btnScan.BackColorOnDefault = ColorHelper.FlatGreenNormal;
            btnScan.BackColorOnHover = ColorHelper.FlatGreenLight;
            btnScan.BackColorOnClick = ColorHelper.FlatGreenDark;

            return false;
        }

        private void ValidateQrCode()
        {
            var reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pbFrame.Image);

            try
            {
                var decodedValue = result.ToString().Trim();

                if (_registeredQrCode.Contains(decodedValue))
                {
                    tmrDecode.Stop();
                    this.Close();

                    FlatMessageAlert.Show(decodedValue);
                }
            }
            catch (Exception) { }
        }

        private void StopImageStream()
        {
            if (_videoSource.IsRunning)
            {
                _videoSource.Stop();
            }
        }

        private void CaptureImage()
        {
            var image = pbFrame.Image;

            var bitmap = (Bitmap) pbFrame.Image;
        }
    }
}
