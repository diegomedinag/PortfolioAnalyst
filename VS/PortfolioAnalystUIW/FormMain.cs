using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PortfolioAnalystUIW
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private UsersForm _usersForm;
        private AccountsForm _accountsForm;

        public FormMain()
        {
            InitializeComponent();
        }

        private void BarButtonItemAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _accountsForm = new AccountsForm();
            _accountsForm.MdiParent = this;
            _accountsForm.Show();
        }

        private void BarButtonItemUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _usersForm = new UsersForm();
            _usersForm.MdiParent = this;
            _usersForm.Show();
        }
    }
}
