using CaseStudy.Business;
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
    public partial class frmModifyProduct : frmNewProduct
    {
        private Product _productToModify = null;
        public frmModifyProduct(Product product)
        {
            InitializeComponent();
            if(product != null)
            {
                _productToModify = product;
                FillFormData();
            }
            else
            {
                this.Close();
            }
        }

        private void FillFormData()
        {
            txtName.Text = _productToModify.Name;
            txtPrice.Text = _productToModify.Price.ToString();
            txtDescription.Text = _productToModify.Description;
            base.comboType.SelectedIndex = base.comboType.Items.IndexOf(_productToModify.Type);
        }

        internal override void btnSubmit_Click(object sender, EventArgs e)
        {
            if(base.IsValidData())
            {
                _productToModify.Name = txtName.Text;
                _productToModify.Price = int.Parse(txtPrice.Text);
                _productToModify.Description = txtDescription.Text;
                _productToModify.Type = (Product.Types)base.comboType.SelectedItem;

                base.product = _productToModify;
                this.Close();
            }
        }
    }
}
