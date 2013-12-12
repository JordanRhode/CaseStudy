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
                    c.LoadDependents();
                }
                else
                {
                    c.ResponsibleParty = customers.FirstOrDefault(cu => cu.CustomerID == c.ResponsiblePartyID);
                }
                lstCustomers.Items.Add(c);
            }
            lstCustomers.Sorted = true;
            UpdateEnabledControls();
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
            if (lstCustomers.SelectedIndex != -1)
            {
                Customer customer = (Customer)lstCustomers.SelectedItem;
                string message = string.Format("Are you sure you want to delete {0}?", customer.FullName);
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    if (customer.Dependents != null && customer.Dependents.Count > 0)
                    {
                        MessageBox.Show("Cannot delete customer with dependents");
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
            UpdateEnabledControls();
        }

        private void UpdateEnabledControls()
        {
            if(lstCustomers.SelectedIndex != -1)
            {
                btnModifyCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnEmailCustomer.Enabled = true;
            }
            else
            {
                btnModifyCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;
                btnEmailCustomer.Enabled = false;
            }
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex != -1)
            {
                int i = customers.IndexOf((Customer)lstCustomers.SelectedItem);
                frmModifyCustomer modifyCustomerForm = new frmModifyCustomer((Customer)lstCustomers.SelectedItem);
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
