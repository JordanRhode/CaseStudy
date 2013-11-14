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
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(24, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(119, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnCustomerManager
            // 
            this.btnCustomerManager.Location = new System.Drawing.Point(436, 58);
            this.btnCustomerManager.Name = "btnCustomerManager";
            this.btnCustomerManager.Size = new System.Drawing.Size(250, 60);
            this.btnCustomerManager.TabIndex = 1;
            this.btnCustomerManager.Text = "Manage Customers";
            this.btnCustomerManager.UseVisualStyleBackColor = true;
            this.btnCustomerManager.Click += new System.EventHandler(this.btnCustomerManager_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(436, 137);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(250, 60);
            this.btnManageProducts.TabIndex = 2;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            // 
            // btnOutstandingInvoices
            // 
            this.btnOutstandingInvoices.Location = new System.Drawing.Point(436, 217);
            this.btnOutstandingInvoices.Name = "btnOutstandingInvoices";
            this.btnOutstandingInvoices.Size = new System.Drawing.Size(250, 60);
            this.btnOutstandingInvoices.TabIndex = 3;
            this.btnOutstandingInvoices.Text = "Outstanding Invoices";
            this.btnOutstandingInvoices.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(436, 299);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 60);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOutstandingInvoices);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.btnCustomerManager);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminPanel";
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
    }
}