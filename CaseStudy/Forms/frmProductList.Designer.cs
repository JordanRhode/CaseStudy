namespace CaseStudy.Forms
{
    partial class frmProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            this.lblProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(17, 70);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(105, 29);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Products";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.HorizontalScrollbar = true;
            this.lstProducts.ItemHeight = 24;
            this.lstProducts.Location = new System.Drawing.Point(22, 103);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(509, 316);
            this.lstProducts.TabIndex = 3;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.ProductIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(548, 103);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(220, 60);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(548, 169);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(220, 60);
            this.btnModifyProduct.TabIndex = 5;
            this.btnModifyProduct.Text = "Modify Product";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(548, 235);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(220, 60);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblProducts);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnBack;
    }
}