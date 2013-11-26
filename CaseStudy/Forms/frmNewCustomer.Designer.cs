using CaseStudy.Business;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace CaseStudy
{
    partial class frmNewCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.chkResponsibleParty = new System.Windows.Forms.CheckBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblResponsibleParty = new System.Windows.Forms.Label();
            this.comboResponsibleParty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 84);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 29);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "First Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(76, 87);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 24);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(84, 128);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 24);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(188, 125);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 29);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "Last Name";
            // 
            // dateDOB
            // 
            this.dateDOB.Location = new System.Drawing.Point(188, 166);
            this.dateDOB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(199, 29);
            this.dateDOB.TabIndex = 2;
            this.dateDOB.Tag = "Date of Birth";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Location = new System.Drawing.Point(58, 170);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(120, 24);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Location = new System.Drawing.Point(489, 128);
            this.lblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 24);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(542, 125);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(197, 29);
            this.txtCity.TabIndex = 7;
            this.txtCity.Tag = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Location = new System.Drawing.Point(469, 87);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(63, 24);
            this.lblStreet.TabIndex = 7;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(542, 84);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(197, 29);
            this.txtStreet.TabIndex = 6;
            this.txtStreet.Tag = "Street";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Location = new System.Drawing.Point(476, 169);
            this.lblState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 24);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(542, 166);
            this.txtState.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(52, 29);
            this.txtState.TabIndex = 8;
            this.txtState.Tag = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Location = new System.Drawing.Point(456, 214);
            this.lblZip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(76, 24);
            this.lblZip.TabIndex = 14;
            this.lblZip.Text = "Zipcode";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(542, 211);
            this.txtZip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(78, 29);
            this.txtZip.TabIndex = 9;
            this.txtZip.Tag = "Zipcode";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(480, 343);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 42);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(615, 343);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 42);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(188, 208);
            this.comboType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(199, 32);
            this.comboType.TabIndex = 3;
            this.comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Location = new System.Drawing.Point(43, 211);
            this.lblType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(135, 24);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Customer Type";
            // 
            // chkResponsibleParty
            // 
            this.chkResponsibleParty.AutoSize = true;
            this.chkResponsibleParty.BackColor = System.Drawing.Color.Transparent;
            this.chkResponsibleParty.Location = new System.Drawing.Point(188, 251);
            this.chkResponsibleParty.Name = "chkResponsibleParty";
            this.chkResponsibleParty.Size = new System.Drawing.Size(197, 28);
            this.chkResponsibleParty.TabIndex = 4;
            this.chkResponsibleParty.Text = "Is Responsible Party";
            this.chkResponsibleParty.UseVisualStyleBackColor = false;
            this.chkResponsibleParty.CheckedChanged += new System.EventHandler(this.chkResponsibleParty_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(456, 43);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 24);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address";
            // 
            // lblResponsibleParty
            // 
            this.lblResponsibleParty.AutoSize = true;
            this.lblResponsibleParty.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsibleParty.Location = new System.Drawing.Point(19, 291);
            this.lblResponsibleParty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResponsibleParty.Name = "lblResponsibleParty";
            this.lblResponsibleParty.Size = new System.Drawing.Size(159, 24);
            this.lblResponsibleParty.TabIndex = 22;
            this.lblResponsibleParty.Text = "Responsible Party";
            // 
            // comboResponsibleParty
            // 
            this.comboResponsibleParty.FormattingEnabled = true;
            this.comboResponsibleParty.Location = new System.Drawing.Point(188, 288);
            this.comboResponsibleParty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboResponsibleParty.Name = "comboResponsibleParty";
            this.comboResponsibleParty.Size = new System.Drawing.Size(199, 32);
            this.comboResponsibleParty.TabIndex = 5;
            this.comboResponsibleParty.SelectedIndexChanged += new System.EventHandler(this.comboResponsibleParty_IndexChanged);
            this.comboResponsibleParty.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // frmNewCustomer
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.comboResponsibleParty);
            this.Controls.Add(this.lblResponsibleParty);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.chkResponsibleParty);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.DateTimePicker dateDOB;
        internal System.Windows.Forms.Label lblDOB;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.Label lblStreet;
        internal System.Windows.Forms.TextBox txtStreet;
        internal System.Windows.Forms.Label lblState;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.Label lblZip;
        internal System.Windows.Forms.TextBox txtZip;
        internal System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.ComboBox comboType;
        internal System.Windows.Forms.Label lblType;
        internal System.Windows.Forms.CheckBox chkResponsibleParty;
        internal System.Windows.Forms.Label lblAddress;
        internal System.Windows.Forms.Label lblResponsibleParty;
        internal System.Windows.Forms.ComboBox comboResponsibleParty;
    }
}