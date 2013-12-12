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
    public partial class frmNewProduct : Form
    {
        internal Product product = null;

        public frmNewProduct()
        {
            InitializeComponent();
            comboType.DataSource = Enum.GetValues(typeof(Product.Types));
        }

        internal Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        internal bool IsValidData()
        {
            return Validator.IsPresent(txtName) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsInt(txtPrice);
        }

        internal virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                product = new Product();
                product.Name = txtName.Text;
                product.Description = txtDescription.Text;
                product.Price = int.Parse(txtPrice.Text);
                product.Type = (Product.Types)comboType.SelectedItem;

                ProductDB.AddProduct(product);
                this.Close();
            }
        }
    }
}
