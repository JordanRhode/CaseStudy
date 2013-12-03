using CaseStudy.Business;
using CaseStudy.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaseStudy.Forms
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private List<Customer> customers = null;

        private void CustomerList_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers(false);
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                if (c.PersonType == Person.PersonTypes.ResponsibleParty)
                {
                    c.LoadDependants();
                }
                else
                {
                    c.ResponsibleParty = customers.FirstOrDefault(cu => cu.CustomerID == c.ResponsiblePartyID);
                }
                lstCustomers.Items.Add(c.ToString());
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer newCustomerForm = new frmNewCustomer();
            Customer customer = newCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                customer.CustomerID = CustomerDB.AddCustomer(customer);
                customers.Add(customer);
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
                    if (customer.Dependants != null && customer.Dependants.Count > 0)
                    {
                        MessageBox.Show("Cannot delete customer with dependants");
                        return;
                    }
                    CustomerDB.DeleteCustomer(customer);
                    customers.Remove(customer);
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
            if (i != -1)
            {
                frmModifyCustomer modifyCustomerForm = new frmModifyCustomer(customers[i]);
                Customer customer = modifyCustomerForm.GetNewCustomer();
                if (customer != null)
                {
                    CustomerDB.ModifyCustomer(customer);
                    customers[i] = customer;
                    FillCustomerListBox();
                }
            }
        }
    }
}
