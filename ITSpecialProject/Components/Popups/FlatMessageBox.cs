using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSpecialProject.Commons.Enums;
using ITSpecialProject.Commons.Helpers;

namespace ITSpecialProject.Components.Popups
{
    public partial class FlatMessageBox : Form
    {
        #region Initialization

        public DialogButtons DialogButtons;

        public DialogButton SelectedDialogButton { get; set; }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FlatMessageBox(string message, string messageTitle, DialogButtons dialogButtonses, DialogType dialogType)
        {
            InitializeComponent();

            lblMessage.Text = message;
            lblTitle.Text = messageTitle;

            SelectedButton(dialogButtonses);

            SetBackGroundColor(dialogType);

            DialogButtons = dialogButtonses;

            AllMouseMove(Controls);
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
                        SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
                    };

                    AllMouseMove(c.Controls);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    switch (DialogButtons)
                    {
                        case DialogButtons.Ok:
                        case DialogButtons.OkCancel:
                            SelectedDialogButton = DialogButton.Ok;
                            break;
                        case DialogButtons.YesNo:
                        case DialogButtons.YesNoCancel:
                            SelectedDialogButton = DialogButton.Yes;
                            break;
                        case DialogButtons.ApplyCancel:
                            SelectedDialogButton = DialogButton.Apply;
                            break;
                        case DialogButtons.SaveCancel:
                            SelectedDialogButton = DialogButton.Save;
                            break;
                    }
                    Close();
                    break;
                case Keys.Escape:
                    SelectedDialogButton = DialogButton.Cancel;
                    Close();
                    break;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SelectedButton(DialogButtons db)
        {
            switch (db)
            {
                case DialogButtons.Ok:
                    SetButtonVisibility(true, false, false, false, false, false);
                    break;
                case DialogButtons.OkCancel:
                    SetButtonVisibility(true, false, false, false, false, true);
                    break;
                case DialogButtons.YesNoCancel:
                    SetButtonVisibility(false, true, true, false, false, true);
                    break;
                case DialogButtons.YesNo:
                    SetButtonVisibility(false, true, true, false, false, false);
                    break;
                case DialogButtons.ApplyCancel:
                    SetButtonVisibility(false, false, false, true, false, true);
                    break;
                case DialogButtons.SaveCancel:
                    SetButtonVisibility(false, false, false, false, true, true);
                    break;
            }
        }

        private void SetButtonVisibility(bool ok, bool yes, bool no, bool apply, bool save, bool cancel)
        {
            btnOk.Visible = ok;
            btnYes.Visible = yes;
            btnNo.Visible = no;
            btnApply.Visible = apply;
            btnSave.Visible = save;
            btnCancel.Visible = cancel;
        }

        private void SetBackGroundColor(DialogType dialogType)
        {
            switch (dialogType)
            {
                case DialogType.Info:
                    this.BackColor = ColorHelper.FlatBlueNormal;
                    break;
                case DialogType.Question:
                    this.BackColor = ColorHelper.FlatBlueNormal;
                    break;
                case DialogType.Hand:
                    this.BackColor = ColorHelper.FlatYellowNormal;
                    break;
                case DialogType.Warning:
                    this.BackColor = ColorHelper.FlatYellowNormal;
                    break;
                case DialogType.Error:
                    this.BackColor = ColorHelper.FlatBlueNormal;
                    break;
            }
        }

        #endregion

        #region Button Events

        private void BtnOk_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.Ok;
            this.Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.Yes;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.No;
            this.Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.Apply;
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.Save;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.Cancel;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            SelectedDialogButton = DialogButton.Cancel;
            this.Close();
        }

        #endregion

        public static DialogButton Show(string message,
            string messageTitle = "Info",
            DialogButtons dialogButtons = DialogButtons.Ok,
            DialogType dialogType = DialogType.Info)
        {
            using (var msg = new FlatMessageBox(message, messageTitle, dialogButtons, dialogType))
            {
                msg.ShowDialog();

                return msg.SelectedDialogButton;
            }
        }
    }
}
