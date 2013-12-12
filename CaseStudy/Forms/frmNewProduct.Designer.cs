using System.Drawing;
namespace CaseStudy.Forms
{
    partial class frmNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewProduct));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(608, 339);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 42);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(473, 339);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 42);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(66, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 24);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 29);
            this.txtName.TabIndex = 15;
            this.txtName.Tag = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(369, 124);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(364, 109);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.Tag = "Description";
            this.txtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(365, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 24);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(198, 29);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.Tag = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(55, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 24);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price($)";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(136, 206);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(198, 32);
            this.comboType.TabIndex = 20;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Location = new System.Drawing.Point(75, 209);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 24);
            this.lblType.TabIndex = 21;
            this.lblType.Text = "Type";
            // 
            // frmNewProduct
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblType;
    }
}