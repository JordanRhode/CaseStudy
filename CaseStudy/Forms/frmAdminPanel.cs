using CaseStudy.Base;
using CaseStudy.Business;
using CaseStudy.DataAccess;
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
        private List<Transaction> outstandingInvoices = null;

        public frmAdminPanel()
        {
            InitializeComponent();
            lblWelcome.Text = string.Format("Welcome, {0}!", UserInfo.CurrentUser.FirstName);
            lstOutstandingInvoices.Visible = false;
            lblOutstandingInvoices.Visible = false;
        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            frmCustomerList customerList = new frmCustomerList();
            this.Hide();
            customerList.ShowDialog();
            this.Show();
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

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            frmProductList productList = new frmProductList();
            this.Hide();
            productList.ShowDialog();
            this.Show();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            frmNewInvoice newInvoice = new frmNewInvoice();
            this.Hide();
            newInvoice.ShowDialog();
            this.Show();
        }

        private void btnOutstandingInvoices_Click(object sender, EventArgs e)
        {
            if (lblOutstandingInvoices.Visible)
            {
                lstOutstandingInvoices.Visible = false;
                lblOutstandingInvoices.Visible = false;
            }
            else
            {
                lstOutstandingInvoices.Visible = true;
                lblOutstandingInvoices.Visible = true;
            }
            outstandingInvoices = TransactionDB.GetOutstandingInvoices();
            if (outstandingInvoices != null)
            {
                lstOutstandingInvoices.DataSource = outstandingInvoices;
            }
        }
    }
}
