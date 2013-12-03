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
            this.lblResponsibleParty = new System.Windows.Forms.Label();
            this.comboResponsibleParty = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.grpAddress.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.grpCustInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(180, 31);
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
            this.lblFirstName.Location = new System.Drawing.Point(66, 34);
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
            this.lblLastName.Location = new System.Drawing.Point(74, 75);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 24);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(180, 72);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 29);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "Last Name";
            // 
            // dateDOB
            // 
            this.dateDOB.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.dateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDOB.Location = new System.Drawing.Point(180, 113);
            this.dateDOB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateDOB.MaxDate = new System.DateTime(2013, 11, 26, 0, 0, 0, 0);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(199, 26);
            this.dateDOB.TabIndex = 2;
            this.dateDOB.Tag = "Date of Birth";
            this.dateDOB.Value = new System.DateTime(2013, 11, 26, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Location = new System.Drawing.Point(50, 111);
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
            this.lblCity.Location = new System.Drawing.Point(51, 75);
            this.lblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 24);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(104, 72);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(197, 29);
            this.txtCity.TabIndex = 1;
            this.txtCity.Tag = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Location = new System.Drawing.Point(31, 34);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(63, 24);
            this.lblStreet.TabIndex = 7;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(104, 31);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(197, 29);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.Tag = "Street";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Location = new System.Drawing.Point(38, 116);
            this.lblState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 24);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(104, 113);
            this.txtState.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(52, 29);
            this.txtState.TabIndex = 2;
            this.txtState.Tag = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Location = new System.Drawing.Point(18, 161);
            this.lblZip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(76, 24);
            this.lblZip.TabIndex = 14;
            this.lblZip.Text = "Zipcode";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(104, 158);
            this.txtZip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(78, 29);
            this.txtZip.TabIndex = 3;
            this.txtZip.Tag = "Zipcode";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(480, 343);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 50);
            this.btnSubmit.TabIndex = 3;
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
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(180, 151);
            this.comboType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(199, 32);
            this.comboType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Location = new System.Drawing.Point(35, 154);
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
            this.chkResponsibleParty.Location = new System.Drawing.Point(180, 194);
            this.chkResponsibleParty.Name = "chkResponsibleParty";
            this.chkResponsibleParty.Size = new System.Drawing.Size(197, 28);
            this.chkResponsibleParty.TabIndex = 4;
            this.chkResponsibleParty.Text = "Is Responsible Party";
            this.chkResponsibleParty.UseVisualStyleBackColor = false;
            this.chkResponsibleParty.CheckedChanged += new System.EventHandler(this.chkResponsibleParty_CheckedChanged);
            // 
            // lblResponsibleParty
            // 
            this.lblResponsibleParty.AutoSize = true;
            this.lblResponsibleParty.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsibleParty.Location = new System.Drawing.Point(11, 233);
            this.lblResponsibleParty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResponsibleParty.Name = "lblResponsibleParty";
            this.lblResponsibleParty.Size = new System.Drawing.Size(159, 24);
            this.lblResponsibleParty.TabIndex = 22;
            this.lblResponsibleParty.Text = "Responsible Party";
            // 
            // comboResponsibleParty
            // 
            this.comboResponsibleParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResponsibleParty.FormattingEnabled = true;
            this.comboResponsibleParty.Location = new System.Drawing.Point(180, 230);
            this.comboResponsibleParty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboResponsibleParty.Name = "comboResponsibleParty";
            this.comboResponsibleParty.Size = new System.Drawing.Size(199, 32);
            this.comboResponsibleParty.TabIndex = 5;
            this.comboResponsibleParty.SelectedIndexChanged += new System.EventHandler(this.comboResponsibleParty_IndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 21);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 29);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Tag = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(111, 24);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(197, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "Last Name";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(180, 103);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(197, 29);
            this.txtPasswordConfirm.TabIndex = 3;
            this.txtPasswordConfirm.Tag = "Last Name";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Location = new System.Drawing.Point(7, 106);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(161, 24);
            this.lblConfirmPassword.TabIndex = 27;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(79, 65);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 24);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            // 
            // grpAddress
            // 
            this.grpAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpAddress.BackgroundImage")));
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.txtState);
            this.grpAddress.Controls.Add(this.lblState);
            this.grpAddress.Controls.Add(this.txtZip);
            this.grpAddress.Controls.Add(this.lblZip);
            this.grpAddress.Location = new System.Drawing.Point(436, 68);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(323, 212);
            this.grpAddress.TabIndex = 2;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // grpLogin
            // 
            this.grpLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpLogin.BackgroundImage")));
            this.grpLogin.Controls.Add(this.txtPasswordConfirm);
            this.grpLogin.Controls.Add(this.txtEmail);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.lblConfirmPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Location = new System.Drawing.Point(26, 9);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(388, 147);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpCustInfo.BackgroundImage")));
            this.grpCustInfo.Controls.Add(this.txtFirstName);
            this.grpCustInfo.Controls.Add(this.lblLastName);
            this.grpCustInfo.Controls.Add(this.txtLastName);
            this.grpCustInfo.Controls.Add(this.comboResponsibleParty);
            this.grpCustInfo.Controls.Add(this.lblFirstName);
            this.grpCustInfo.Controls.Add(this.lblResponsibleParty);
            this.grpCustInfo.Controls.Add(this.dateDOB);
            this.grpCustInfo.Controls.Add(this.chkResponsibleParty);
            this.grpCustInfo.Controls.Add(this.lblDOB);
            this.grpCustInfo.Controls.Add(this.lblType);
            this.grpCustInfo.Controls.Add(this.comboType);
            this.grpCustInfo.Location = new System.Drawing.Point(26, 170);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Size = new System.Drawing.Size(388, 279);
            this.grpCustInfo.TabIndex = 1;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer Info";
            // 
            // frmNewCustomer
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpCustInfo);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Customer";
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.ResumeLayout(false);

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
        internal System.Windows.Forms.Label lblResponsibleParty;
        internal System.Windows.Forms.ComboBox comboResponsibleParty;
        internal TextBox txtEmail;
        internal Label lblEmail;
        internal TextBox txtPassword;
        internal TextBox txtPasswordConfirm;
        internal Label lblConfirmPassword;
        internal Label lblPassword;
        private GroupBox grpAddress;
        private GroupBox grpLogin;
        private GroupBox grpCustInfo;
    }
}