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
    public partial class frmNewInvoice : Form
    {
        private List<Customer> _customers = null;
        private List<Product> _products = null;
        private const double _teacherDiscount = .20;
        private Customer _customer = null;
        private Product _product = null;

        private enum FamilyDiscounts
        {
            Zero = 0,
            Ten = 1,
            Twenty = 2,
            Thirty = 3,
            Forty = 4,
            Fifty = 5,
            Sixty = 6,
            Seventy = 7,
            Eighty = 8,
            Ninety = 9
        }

        public frmNewInvoice()
        {
            InitializeComponent();
            numQuantity.Enabled = false;
            comboFamilyDiscount.DataSource = Enum.GetValues(typeof(FamilyDiscounts));
            _customers = CustomerDB.GetCustomers(false);
            _products = ProductDB.GetProducts();
            FillCustomerListBox();
            FillProductListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in _customers)
            {
                if (c.PersonType == Person.PersonTypes.ResponsibleParty)
                {
                    c.LoadDependents();
                }
                else
                {
                    c.ResponsibleParty = _customers.FirstOrDefault(cu => cu.CustomerID == c.ResponsiblePartyID);
                }
                lstCustomers.Items.Add(c.ToString());
            }
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product p in _products)
            {
                lstProducts.Items.Add(p.ToString());
            }
        }

        private void UpdatePrices()
        {
            double total = (double)_product.Price * (double)numQuantity.Value;
            FamilyDiscounts disc = (FamilyDiscounts)Enum.Parse(typeof(FamilyDiscounts), comboFamilyDiscount.SelectedItem.ToString());
            double familyDiscount = ((int)disc * .1) * total;
            double teacherDicount = 0;
            if(_customer.Type == Customer.Types.Teacher)
            {
                teacherDicount = _teacherDiscount;
            }
            txtTotal.Text = total.ToString();
            txtFamilyDiscount.Text = familyDiscount.ToString();
            txtTeacherDiscount.Text = teacherDicount.ToString();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCustomers.SelectedIndex != -1)
            {
                if (lstProducts.SelectedIndex != -1)
                {
                    numQuantity.Enabled = true;
                }
                _customer = _customers[lstCustomers.SelectedIndex];
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstProducts.SelectedIndex != -1)
            {
                if (lstCustomers.SelectedIndex != -1)
                {
                    numQuantity.Enabled = true;
                }
                _product = _products[lstProducts.SelectedIndex];
            }
        }

        private bool IsValid()
        {
            if(lstCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select A Customer");
                return false;
            }
            else if(lstProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select A Product");
                return false;
            }
            else if(numQuantity.Value == 0)
            {
                MessageBox.Show("Must Select A Quantity");
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                Transaction transaction = new Transaction();
                transaction.CustomerID = _customer.CustomerID;
                if (chkPaid.Checked)
                {
                    transaction.PaymentRecieved = DateTime.Today;
                }
                else
                {
                    transaction.PaymentRecieved = null;
                }
                transaction.ResponsiblePartyID = _customer.ResponsiblePartyID;
                transaction.TransactionDate = DateTime.Today;
                transaction.TotalPrice = long.Parse(txtTotal.Text);

                TransactionProduct transactionProduct = new TransactionProduct();
                transactionProduct.ProductID = _product.ProductID;
                transactionProduct.Quantity = (int)numQuantity.Value;

                transaction.AddTransactionProduct(transactionProduct);

                TransactionDB.AddTransaction(transaction);
                MessageBox.Show("Transaction Added");
                this.Close();
            }
        }

        private void comboFamilyDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numQuantity.Value > 0)
            {
                UpdatePrices();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
