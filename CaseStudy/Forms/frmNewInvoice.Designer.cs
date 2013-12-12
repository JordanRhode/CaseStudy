namespace CaseStudy.Forms
{
    partial class frmNewInvoice
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblFamilyDiscount = new System.Windows.Forms.Label();
            this.comboFamilyDiscount = new System.Windows.Forms.ComboBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblFamilyDiscTotal = new System.Windows.Forms.Label();
            this.lblTeacherDiscTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFamilyDiscount = new System.Windows.Forms.Label();
            this.txtTeacherDiscount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.grpCustomer.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackgroundImage = global::CaseStudy.Properties.Resources.squairy_light;
            this.grpCustomer.Controls.Add(this.lblFamilyDiscount);
            this.grpCustomer.Controls.Add(this.comboFamilyDiscount);
            this.grpCustomer.Controls.Add(this.lstCustomers);
            this.grpCustomer.Location = new System.Drawing.Point(25, 31);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCustomer.Size = new System.Drawing.Size(353, 295);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // lblFamilyDiscount
            // 
            this.lblFamilyDiscount.AutoSize = true;
            this.lblFamilyDiscount.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.lblFamilyDiscount.Location = new System.Drawing.Point(47, 258);
            this.lblFamilyDiscount.Name = "lblFamilyDiscount";
            this.lblFamilyDiscount.Size = new System.Drawing.Size(175, 24);
            this.lblFamilyDiscount.TabIndex = 5;
            this.lblFamilyDiscount.Text = "Family Discount (%)";
            // 
            // comboFamilyDiscount
            // 
            this.comboFamilyDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFamilyDiscount.FormattingEnabled = true;
            this.comboFamilyDiscount.Location = new System.Drawing.Point(227, 255);
            this.comboFamilyDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboFamilyDiscount.Name = "comboFamilyDiscount";
            this.comboFamilyDiscount.Size = new System.Drawing.Size(121, 32);
            this.comboFamilyDiscount.TabIndex = 1;
            this.comboFamilyDiscount.SelectedIndexChanged += new System.EventHandler(this.comboFamilyDiscount_SelectedIndexChanged);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.HorizontalScrollbar = true;
            this.lstCustomers.ItemHeight = 24;
            this.lstCustomers.Location = new System.Drawing.Point(7, 30);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(341, 220);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // grpProduct
            // 
            this.grpProduct.BackgroundImage = global::CaseStudy.Properties.Resources.squairy_light;
            this.grpProduct.Controls.Add(this.numQuantity);
            this.grpProduct.Controls.Add(this.lblQuantity);
            this.grpProduct.Controls.Add(this.lstProducts);
            this.grpProduct.Location = new System.Drawing.Point(385, 31);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpProduct.Size = new System.Drawing.Size(353, 295);
            this.grpProduct.TabIndex = 1;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(227, 257);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 29);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.lblQuantity.Location = new System.Drawing.Point(138, 258);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 24);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.HorizontalScrollbar = true;
            this.lstProducts.ItemHeight = 24;
            this.lstProducts.Location = new System.Drawing.Point(7, 28);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(341, 220);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // lblFamilyDiscTotal
            // 
            this.lblFamilyDiscTotal.AutoSize = true;
            this.lblFamilyDiscTotal.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.lblFamilyDiscTotal.Location = new System.Drawing.Point(72, 349);
            this.lblFamilyDiscTotal.Name = "lblFamilyDiscTotal";
            this.lblFamilyDiscTotal.Size = new System.Drawing.Size(151, 24);
            this.lblFamilyDiscTotal.TabIndex = 6;
            this.lblFamilyDiscTotal.Text = "Family Discount:";
            // 
            // lblTeacherDiscTotal
            // 
            this.lblTeacherDiscTotal.AutoSize = true;
            this.lblTeacherDiscTotal.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.lblTeacherDiscTotal.Location = new System.Drawing.Point(62, 378);
            this.lblTeacherDiscTotal.Name = "lblTeacherDiscTotal";
            this.lblTeacherDiscTotal.Size = new System.Drawing.Size(160, 24);
            this.lblTeacherDiscTotal.TabIndex = 7;
            this.lblTeacherDiscTotal.Text = "Teacher Discount:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.lblTotalPrice.Location = new System.Drawing.Point(115, 408);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(107, 24);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(625, 390);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(493, 390);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 50);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFamilyDiscount
            // 
            this.txtFamilyDiscount.AutoSize = true;
            this.txtFamilyDiscount.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.txtFamilyDiscount.Location = new System.Drawing.Point(228, 349);
            this.txtFamilyDiscount.Name = "txtFamilyDiscount";
            this.txtFamilyDiscount.Size = new System.Drawing.Size(20, 24);
            this.txtFamilyDiscount.TabIndex = 9;
            this.txtFamilyDiscount.Text = "0";
            // 
            // txtTeacherDiscount
            // 
            this.txtTeacherDiscount.AutoSize = true;
            this.txtTeacherDiscount.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.txtTeacherDiscount.Location = new System.Drawing.Point(228, 378);
            this.txtTeacherDiscount.Name = "txtTeacherDiscount";
            this.txtTeacherDiscount.Size = new System.Drawing.Size(20, 24);
            this.txtTeacherDiscount.TabIndex = 10;
            this.txtTeacherDiscount.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Image = global::CaseStudy.Properties.Resources.squairy_light;
            this.txtTotal.Location = new System.Drawing.Point(228, 408);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(20, 24);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0";
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Location = new System.Drawing.Point(614, 345);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(124, 28);
            this.chkPaid.TabIndex = 12;
            this.chkPaid.Text = "Paid In Full";
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // frmNewInvoice
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaseStudy.Properties.Resources.squairy_light;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chkPaid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTeacherDiscount);
            this.Controls.Add(this.txtFamilyDiscount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTeacherDiscTotal);
            this.Controls.Add(this.lblFamilyDiscTotal);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpCustomer);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Invoice";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblFamilyDiscount;
        private System.Windows.Forms.ComboBox comboFamilyDiscount;
        private System.Windows.Forms.Label lblFamilyDiscTotal;
        private System.Windows.Forms.Label lblTeacherDiscTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label txtFamilyDiscount;
        private System.Windows.Forms.Label txtTeacherDiscount;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.CheckBox chkPaid;
    }
}