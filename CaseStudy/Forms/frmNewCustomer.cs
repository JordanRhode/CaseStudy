using CaseStudy.Base;
using CaseStudy.Business;
using System;
using System.Windows.Forms;

namespace CaseStudy
{
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
            comboType.DataSource = Enum.GetValues(typeof(Customer.Types));
            UpdateEnabledControls(false);
        }

        internal Customer customer = null;

        internal Business.Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        internal void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Random randomNum = new Random();
                Address address = new Address(randomNum.Next(1000, 9999), txtStreet.Text, 
                                              txtCity.Text, txtState.Text, Int32.Parse(txtZip.Text));
                Customer.Types type = (Customer.Types)Enum.Parse(typeof(Customer.Types), comboType.SelectedItem.ToString());
                customer = new Customer(randomNum.Next(10000, 99999), type, randomNum.Next(10000, 99999), txtFirstName.Text,
                                        txtLastName.Text, dateDOB.Value, Person.PersonTypes.Customer);
                customer.SetAddress(address);
                this.Close();
            }
        }

        internal bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                   Validator.IsPresent(txtLastName) &&
                   Validator.IsPresent(txtStreet) &&
                   Validator.IsPresent(txtCity) &&
                   Validator.IsPresent(txtState) &&
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
            //TODO: get responsible party address and autofill address fields
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
            }
        }

        internal void UpdateEnabledControls(bool isResponsibleParty)
        {
            if (isResponsibleParty)
            {
                lblResponsibleParty.Enabled = false;
                comboResponsibleParty.Enabled = false;
                lblAddress.Enabled = true;
                lblStreet.Enabled = true;
                lblCity.Enabled = true;
                lblState.Enabled = true;
                lblZip.Enabled = true;
                txtCity.Enabled = true;
                txtStreet.Enabled = true;
                txtState.Enabled = true;
                txtZip.Enabled = true;
            }
            else
            {
                //TODO: get responsible parties from db
                lblResponsibleParty.Enabled = true;
                comboResponsibleParty.Enabled = true;
                lblAddress.Enabled = false;
                lblStreet.Enabled = false;
                lblCity.Enabled = false;
                lblState.Enabled = false;
                lblZip.Enabled = false;
                txtCity.Enabled = false;
                txtStreet.Enabled = false;
                txtState.Enabled = false;
                txtZip.Enabled = false;
            }
        }
    }
}
