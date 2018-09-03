using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Core.Model;

namespace ITSpecialProject.Views.Accounts
{
    public partial class AccountCardView : UserControl
    {
        public AccountCardView(Account account)
        {
            InitializeComponent();

            _account = account;

            Initialize();
        }
    }
}
