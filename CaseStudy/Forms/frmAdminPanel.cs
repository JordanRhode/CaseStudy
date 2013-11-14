using CaseStudy.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy.Forms
{
    public partial class frmAdminPanel : Form
    {
        private bool loggingOut = false;
        public frmAdminPanel()
        {
            InitializeComponent();
            lblWelcome.Text = string.Format("Welcome, {0}!", UserInfo.CurrentUser.FirstName);
        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            frmCustomerList customerList = new frmCustomerList();
            customerList.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (loggingOut)
            {
                Controller.Logout();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggingOut = true;
        }
    }
}
