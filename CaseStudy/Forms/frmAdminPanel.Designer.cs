using CaseStudy.Base;
using System.Drawing;
namespace CaseStudy.Forms
{
    partial class frmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPanel));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCustomerManager = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnOutstandingInvoices = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.lstOutstandingInvoices = new System.Windows.Forms.ListBox();
            this.lblOutstandingInvoices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(119, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(119, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnCustomerManager
            // 
            this.btnCustomerManager.Location = new System.Drawing.Point(547, 103);
            this.btnCustomerManager.Name = "btnCustomerManager";
            this.btnCustomerManager.Size = new System.Drawing.Size(220, 60);
            this.btnCustomerManager.TabIndex = 1;
            this.btnCustomerManager.Text = "Manage Customers";
            this.btnCustomerManager.UseVisualStyleBackColor = true;
            this.btnCustomerManager.Click += new System.EventHandler(this.btnCustomerManager_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(547, 169);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(220, 60);
            this.btnManageProducts.TabIndex = 2;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnOutstandingInvoices
            // 
            this.btnOutstandingInvoices.Location = new System.Drawing.Point(547, 235);
            this.btnOutstandingInvoices.Name = "btnOutstandingInvoices";
            this.btnOutstandingInvoices.Size = new System.Drawing.Size(220, 60);
            this.btnOutstandingInvoices.TabIndex = 3;
            this.btnOutstandingInvoices.Text = "Outstanding Invoices";
            this.btnOutstandingInvoices.UseVisualStyleBackColor = true;
            this.btnOutstandingInvoices.Click += new System.EventHandler(this.btnOutstandingInvoices_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(547, 301);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(220, 60);
            this.btnNewInvoice.TabIndex = 4;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // lstOutstandingInvoices
            // 
            this.lstOutstandingInvoices.FormattingEnabled = true;
            this.lstOutstandingInvoices.ItemHeight = 24;
            this.lstOutstandingInvoices.Location = new System.Drawing.Point(22, 103);
            this.lstOutstandingInvoices.Name = "lstOutstandingInvoices";
            this.lstOutstandingInvoices.Size = new System.Drawing.Size(509, 316);
            this.lstOutstandingInvoices.TabIndex = 6;
            // 
            // lblOutstandingInvoices
            // 
            this.lblOutstandingInvoices.AutoSize = true;
            this.lblOutstandingInvoices.BackColor = System.Drawing.Color.Transparent;
            this.lblOutstandingInvoices.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.lblOutstandingInvoices.Location = new System.Drawing.Point(17, 70);
            this.lblOutstandingInvoices.Name = "lblOutstandingInvoices";
            this.lblOutstandingInvoices.Size = new System.Drawing.Size(237, 29);
            this.lblOutstandingInvoices.TabIndex = 7;
            this.lblOutstandingInvoices.Text = "Outstanding Invoices";
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblOutstandingInvoices);
            this.Controls.Add(this.lstOutstandingInvoices);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOutstandingInvoices);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.btnCustomerManager);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCustomerManager;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnOutstandingInvoices;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.ListBox lstOutstandingInvoices;
        private System.Windows.Forms.Label lblOutstandingInvoices;
    }
}