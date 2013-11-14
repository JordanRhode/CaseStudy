using System.Drawing;
namespace CaseStudy.Forms
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnModifyCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEmailCustomer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.HorizontalScrollbar = true;
            this.lstCustomers.ItemHeight = 24;
            this.lstCustomers.Location = new System.Drawing.Point(22, 58);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(500, 316);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.CustomerIndexChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(14, 20);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(125, 29);
            this.lblCustomers.TabIndex = 1;
            this.lblCustomers.Text = "Customers";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(543, 58);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(220, 60);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnModifyCustomer
            // 
            this.btnModifyCustomer.Enabled = false;
            this.btnModifyCustomer.Location = new System.Drawing.Point(543, 124);
            this.btnModifyCustomer.Name = "btnModifyCustomer";
            this.btnModifyCustomer.Size = new System.Drawing.Size(220, 60);
            this.btnModifyCustomer.TabIndex = 3;
            this.btnModifyCustomer.Text = "Modify Customer";
            this.btnModifyCustomer.UseVisualStyleBackColor = true;
            this.btnModifyCustomer.Click += new System.EventHandler(this.btnModifyCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(543, 190);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(220, 60);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEmailCustomer
            // 
            this.btnEmailCustomer.Enabled = false;
            this.btnEmailCustomer.Location = new System.Drawing.Point(543, 256);
            this.btnEmailCustomer.Name = "btnEmailCustomer";
            this.btnEmailCustomer.Size = new System.Drawing.Size(220, 60);
            this.btnEmailCustomer.TabIndex = 5;
            this.btnEmailCustomer.Text = "Email Customer";
            this.btnEmailCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(543, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 60);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEmailCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnModifyCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnModifyCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEmailCustomer;
        private System.Windows.Forms.Button btnCancel;
    }
}