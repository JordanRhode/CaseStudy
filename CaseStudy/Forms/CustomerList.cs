using CaseStudy.Business;
using CaseStudy.DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaseStudy.Forms
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private List<Customer> customers = null;

        private void CustomerList_Load(object sender, EventArgs e)
        {
            //customers = TextCustomerDB.GetCustomers();
            customers = XMLCustomerDB.GetCustomers();
            //customers = BinaryCustomerDB.GetCustomers();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.ToString());
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer newCustomerForm = new frmNewCustomer();
            Customer customer = newCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
                //TextCustomerDB.SaveCustomers(customers);
                XMLCustomerDB.SaveCustomers(customers);
                //BinaryCustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];
                string message = string.Format("Are you sure you want to delete {0}?", customer.FullName);
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    customers.Remove(customer);
                    //TextCustomerDB.SaveCustomers(customers);
                    XMLCustomerDB.SaveCustomers(customers);
                    //BinaryCustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }

        private void CustomerIndexChanged(object sender, EventArgs e)
        {
                btnModifyCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnEmailCustomer.Enabled = true;
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            frmModifyCustomer modifyCustomerForm = new frmModifyCustomer(customers[i]);
            Customer customer = modifyCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                customers[i] = customer;
                FillCustomerListBox();
            }
        }
    }
}
