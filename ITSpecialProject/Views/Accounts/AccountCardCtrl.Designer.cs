using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using DataLayer.Core.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ITSpecialProject.Views.PointOfSale;

namespace ITSpecialProject.Views.Accounts
{
    public partial class AccountCardView
    {
        private readonly Account _account;

        private void Initialize()
        {
            SetAccountDetails();
            SetClickEvent();
        }

        private void SetAccountDetails()
        {
            lblUserName.Text = _account.UserName;
           // lblName.Text = _account.GetFullName;

            if (!string.IsNullOrEmpty(_account.ProfileImage))
            {
                pbAccountImage.Image = PathHelper.GetImage(_account.ProfileImage);
            }

            if (_account.Flag)
            {
                pnlFlag.BackColor = ColorHelper.FlatGreenNormal;
            }
            else
            {
                pnlFlag.BackColor = ColorHelper.FlatRedNormal;
            }
        }

        private void SetClickEvent()
        {
            CardClicked += (s, e) =>
            {
                var container = this.Parent.Controls.Cast<Control>().ToList();

                foreach (var control in container)
                {
                    if (control is AccountCardView card)
                    {
                        if (control.Equals(this))
                        {
                            SetSelectedBackColor(this);
                        }
                        else
                        {
                            SetDeselectedBackColor(card);
                        }
                    }
                }
            };
        }

        public void SetSelectedBackColor(AccountCardView card)
        {
            card.BackColor = ColorHelper.FlatYellowTransparent;

            card.pbAccountImage.BackColorOnDefault =
                pbAccountImage.BackColorOnHover = 
                    pbAccountImage.BackColorOnClick =
                        ColorHelper.FlatYellowNormal;
        }

        private void SetDeselectedBackColor(AccountCardView card)
        {
            card.BackColor = Color.FromArgb(32, 32, 32);

            card.pbAccountImage.BackColorOnDefault =
                pbAccountImage.BackColorOnHover =
                    pbAccountImage.BackColorOnClick =
                        Color.FromArgb(96, 96, 96);
        }

        public Account GetAccount => _account;

        public event EventHandler CardClicked
        {
            add
            {
                foreach (var control in this.Controls.Cast<Control>())
                {
                    if (!(control is FlatButton))
                        control.Click += value;
                }
            }
            remove
            {
                foreach (var control in this.Controls.Cast<Control>())
                {
                    if (!(control is FlatButton))
                        control.Click -= value;
                }
            }
        }

        public event EventHandler EditButtonClicked
        {
            add => btnEdit.Click += value;
            remove => btnEdit.Click -= value;
        }

        public event EventHandler DeleteButtonClicked
        {
            add => btnDelete.Click += value;
            remove => btnDelete.Click -= value;
        }

    }
}
