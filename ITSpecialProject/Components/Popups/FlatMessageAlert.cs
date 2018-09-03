using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Commons.Helpers;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ITSpecialProject.Components.Popups
{
    internal partial class FlatMessageAlert : Form
    {
        private readonly int _screenX = Screen.PrimaryScreen.Bounds.Width;
        private readonly int _screenY = Screen.PrimaryScreen.Bounds.Height;
        private int _interval;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private FlatMessageAlert(string message, string messageTitle, AlertType alertType)
        {
            Initialize(message);

            SetMessageAlert(alertType, messageTitle);
        }

        private void Initialize(string message)
        {
            InitializeComponent();

            this.TopMost = true;
            this.Left = _screenX - this.Width - 50;
            this.Top = -1 * _screenY;

            lblMessage.Text = message;

            AllMouseMove(this.Controls);
        }

        private void AllMouseMove(Control.ControlCollection coll)
        {
            foreach (Control c in coll)
            {
                if (!(c is FlatButton))
                {
                    c.MouseMove += (sender, e) =>
                    {
                        if (e.Button != MouseButtons.Left) return;

                        ReleaseCapture();

                        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    };
                }

                AllMouseMove(c.Controls);
            }
        }

        private void SetMessageAlert(AlertType alertType, string messageTitle)
        {
            switch (alertType)
            {
                case AlertType.Info:
                    this.BackColor = ColorHelper.FlatBlueNormal;
                    this.pbIcon.Image = Properties.Resources.Info_48;
                    break;
                case AlertType.BadInfo:
                    this.BackColor = ColorHelper.FlatRedNormal;
                    this.pbIcon.Image = Properties.Resources.Info_48;
                    break;
                case AlertType.Update:
                    this.BackColor = ColorHelper.FlatGreenNormal;
                    this.pbIcon.Image = Properties.Resources.Update_48;
                    break;
                case AlertType.Delete:
                    this.BackColor = ColorHelper.FlatRedNormal;
                    this.pbIcon.Image = Properties.Resources.Delete_48;
                    break;
                case AlertType.Notification:
                    this.BackColor = ColorHelper.FlatGreenNormal;
                    this.pbIcon.Image = Properties.Resources.Notification_48;
                    break;
                case AlertType.Message:
                    this.BackColor = ColorHelper.FlatGreenNormal;
                    this.pbIcon.Image = Properties.Resources.Message_48;
                    break;
                case AlertType.Hand:
                    this.BackColor = ColorHelper.FlatYellowNormal;
                    this.pbIcon.Image = Properties.Resources.Hand_48;
                    break;
                case AlertType.Warning:
                    this.BackColor = ColorHelper.FlatYellowNormal;
                    this.pbIcon.Image = Properties.Resources.Warning_48;
                    break;
                case AlertType.Error:
                    this.BackColor = ColorHelper.FlatRedNormal;
                    this.pbIcon.Image = Properties.Resources.Error_48;
                    break;
            }

            SetMessageTitle(alertType, messageTitle);
            BeginShowing();
        }

        private void BeginShowing()
        {
            tmrShow.Enabled = true;
            tmrShow.Start();
        }

        private void SetMessageTitle(AlertType alertType, string messageTitle)
        {
            lblTitle.Text = string.IsNullOrEmpty(messageTitle) ? alertType.ToString() : messageTitle;
        }

        private void TmrShow_Tick(object sender, EventArgs e)
        {
            if (this.Top < 50)
            {
                this.Top = _interval;
                _interval += 2;
            }
            else
            {
                tmrShow.Stop();

                tmrDelay.Enabled = true;
                tmrDelay.Start();
            }
        }

        private void TmrDelay_Tick(object sender, EventArgs e)
        {
            tmrDelay.Stop();
            tmrClose.Enabled = true;
            tmrClose.Start();
        }

        private void TmrClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0.00)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                this.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => this.Close();

        public static void Show(string message, string messageTitle = "Info", AlertType alertType = AlertType.Info)
            => new FlatMessageAlert(message, messageTitle, alertType).Show();
    }
}
