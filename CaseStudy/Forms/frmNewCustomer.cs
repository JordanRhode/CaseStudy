using CaseStudy.Base;
using CaseStudy.Business;
using CaseStudy.DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaseStudy
{
    public partial class frmNewCustomer : Form
    {
        private List<Customer> responsiblePartyCustomers = null;
        internal Customer responsibleParty = null;

        public frmNewCustomer()
        {
            InitializeComponent();
            responsiblePartyCustomers = CustomerDB.GetCustomers(true);
            comboResponsibleParty.DataSource = responsiblePartyCustomers;
            comboType.DataSource = Enum.GetValues(typeof(Customer.Types));
            UpdateEnabledControls(false);
        }

        internal Customer customer = null;

        internal Business.Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        internal virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Address address = new Address();
                
                customer = new Customer();
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Email = txtEmail.Text;
                customer.Password = txtPassword.Text;
                customer.DateOfBirth = dateDOB.Value;
                customer.Type = (Customer.Types)Enum.Parse(typeof(Customer.Types), comboType.SelectedItem.ToString());

                if(chkResponsibleParty.Checked)
                {
                    customer.PersonType = Person.PersonTypes.ResponsibleParty;
                    address.Street = txtStreet.Text;
                    address.City = txtCity.Text;
                    address.State = txtState.Text;
                    address.Zip = Int32.Parse(txtZip.Text);
                }
                else
                {
                    address = responsibleParty.Address;
                    customer.PersonType = Person.PersonTypes.Customer;
                    customer.ResponsiblePartyID = responsibleParty.CustomerID;
                }
                customer.SetAddress(address);
                this.Close();
            }
        }

        internal bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                   Validator.IsPresent(txtLastName) &&
                   Validator.IsEmail(txtEmail) &&
                   Validator.IsPresent(txtStreet) &&
                   Validator.IsPresent(txtCity) &&
                   Validator.IsPresent(txtState) &&
                   Validator.IsPresent(txtPassword) &&
                   Validator.IsPresent(txtPasswordConfirm) &&
                   Validator.IsEqualTo(txtPassword, txtPasswordConfirm) &&
                   Validator.IsInt(txtZip);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void comboResponsibleParty_IndexChanged(object sender, EventArgs e)
        {
            if (!chkResponsibleParty.Checked)
            {
                responsibleParty = (Customer)comboResponsibleParty.SelectedItem;
                if (responsibleParty != null)
                {
                    FillAddressWithResponsibleParty();
                }
            }
        }

        private void FillAddressWithResponsibleParty()
        {
            txtStreet.Text = responsibleParty.Address.Street;
            txtCity.Text = responsibleParty.Address.City;
            txtState.Text = responsibleParty.Address.State;
            txtZip.Text = responsibleParty.Address.Zip.ToString();
        }

        private void chkResponsibleParty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResponsibleParty.Checked)
            {
                UpdateEnabledControls(true);
            }
            else
            {
                UpdateEnabledControls(false);
                FillAddressWithResponsibleParty();
            }
        }

        internal void UpdateEnabledControls(bool isResponsibleParty)
        {
            if (isResponsibleParty)
            {
                lblResponsibleParty.Enabled = false;
                comboResponsibleParty.Enabled = false;
                grpAddress.Enabled = true;
                //lblStreet.Enabled = true;
                //lblCity.Enabled = true;
                //lblState.Enabled = true;
                //lblZip.Enabled = true;
                txtCity.Enabled = true;
                txtCity.Text = "";
                txtStreet.Enabled = true;
                txtStreet.Text = "";
                txtState.Enabled = true;
                txtState.Text = "";
                txtZip.Enabled = true;
                txtZip.Text = "";
            }
            else
            {
                lblResponsibleParty.Enabled = true;
                comboResponsibleParty.Enabled = true;
                grpAddress.Enabled = false;
                //lblStreet.Enabled = false;
                //lblCity.Enabled = false;
                //lblState.Enabled = false;
                //lblZip.Enabled = false;
                txtCity.Enabled = false;
                txtStreet.Enabled = false;
                txtState.Enabled = false;
                txtZip.Enabled = false;
            }
        }
    }
}
