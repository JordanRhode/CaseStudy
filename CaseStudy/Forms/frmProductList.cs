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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        private List<Product> products = null;

        private void frmProductList_Load(object sender, EventArgs e)
        {
            products = ProductDB.GetProducts();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product p in products)
            {
                lstProducts.Items.Add(p);
            }
            UpdateEnabledControls();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();
            if (product != null)
            {
                products.Add(product);

                FillProductListBox();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                Product product = (Product)lstProducts.SelectedItem;
                string message = string.Format("Are you sure you want to delete {0}?", product.Name);
                DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    products.Remove(product);
                    ProductDB.DeleteProduct(product);
                    FillProductListBox();
                }
            }
        }

        private void ProductIndexChanged(object sender, System.EventArgs e)
        {
            UpdateEnabledControls();
        }

        private void UpdateEnabledControls()
        {
            if (lstProducts.SelectedIndex != -1)
            {
                btnModifyProduct.Enabled = true;
                btnDeleteProduct.Enabled = true;
            }
            else
            {
                btnModifyProduct.Enabled = false;
                btnDeleteProduct.Enabled = false;
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                int i = products.IndexOf((Product)lstProducts.SelectedItem);
                frmModifyProduct modifyProductForm = new frmModifyProduct((Product)lstProducts.SelectedItem);
                Product product = modifyProductForm.GetNewProduct();
                if (product != null)
                {
                    ProductDB.ModifyProduct(product);
                    products[i] = product;
                    FillProductListBox();
                }
            }
        }

    }
}
