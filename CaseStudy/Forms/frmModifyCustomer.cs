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
    public partial class frmModifyCustomer : frmNewCustomer
    {
        private Customer _customerToModify = null;

        public frmModifyCustomer(Customer customer)
        {
            if(customer != null)
            {
                _customerToModify = customer;
            }
            else
            {
                this.Close();
            }
            InitializeComponent();
            FillFormData();
        }

        internal override void btnSubmit_Click(object sender, EventArgs e)
        {
            if (base.IsValidData())
            {
                _customerToModify.FirstName = txtFirstName.Text;
                _customerToModify.LastName = txtLastName.Text;
                _customerToModify.Email = txtEmail.Text;
                _customerToModify.Password = txtPassword.Text;
                _customerToModify.DateOfBirth = dateDOB.Value;
                Customer.Types type = (Customer.Types)Enum.Parse(typeof(Customer.Types), comboType.SelectedItem.ToString());
                _customerToModify.Type = type;
                if (chkResponsibleParty.Checked)
                {
                    _customerToModify.PersonType = Person.PersonTypes.ResponsibleParty;
                    _customerToModify.Address.Street = txtStreet.Text;
                    _customerToModify.Address.City = txtCity.Text;
                    _customerToModify.Address.State = txtState.Text;
                    _customerToModify.Address.Zip = int.Parse(txtZip.Text);
                    if(base.responsibleParty != null)
                    {
                        base.responsibleParty.RemoveDependant(_customerToModify);
                        _customerToModify.ResponsibleParty = null;
                    }
                }
                else
                {
                    _customerToModify.PersonType = Person.PersonTypes.Customer;
                    _customerToModify.SetAddress(base.responsibleParty.Address);
                    base.responsibleParty.AddDependant(_customerToModify);
                }

                base.customer = _customerToModify;

                base.Close();
            }
        }

        internal override void chkResponsibleParty_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkResponsibleParty.Checked && _customerToModify.Dependants != null)
            {
                if (_customerToModify.Dependants.Count > 0)
                {
                    MessageBox.Show(string.Format("{0} has dependants and must stay a responsible party.",
                        _customerToModify.FirstName));
                    chkResponsibleParty.Checked = true;
                }
            }
            base.chkResponsibleParty_CheckedChanged(sender, e);
        }

        private void FillFormData()
        {
            if (_customerToModify != null)
            {
                base.txtFirstName.Text = _customerToModify.FirstName;
                base.txtLastName.Text = _customerToModify.LastName;
                base.txtEmail.Text = _customerToModify.Email;
                base.txtPassword.Text = _customerToModify.Password;
                base.txtPasswordConfirm.Text = _customerToModify.Password;
                base.dateDOB.Value = (DateTime)_customerToModify.DateOfBirth;
                base.comboType.SelectedItem = _customerToModify.Type;
                if (_customerToModify.PersonType == Person.PersonTypes.ResponsibleParty)
                {
                    base.chkResponsibleParty.CheckState = CheckState.Checked;
                    base.UpdateEnabledControls(true);
                }
                else
                {
                    base.chkResponsibleParty.CheckState = CheckState.Unchecked;
                    if (_customerToModify.ResponsibleParty != null)
                    {
                        base.comboResponsibleParty.SelectedIndex = base.comboResponsibleParty.Items.IndexOf(_customerToModify.ResponsibleParty);
                    }
                    base.UpdateEnabledControls(false);
                }
                base.txtStreet.Text = _customerToModify.Address.Street;
                base.txtCity.Text = _customerToModify.Address.City;
                base.txtState.Text = _customerToModify.Address.State;
                base.txtZip.Text = _customerToModify.Address.Zip.ToString();
            }
        }
    }
}
