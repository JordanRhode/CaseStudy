using CaseStudy.Base;
using CaseStudy.Business;
using CaseStudy.DataAccess;
using CaseStudy.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy
{
    public partial class frmLogin : Form
    {
        private bool exitApp = true;
        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "rhode.jordan@gmail.com";
            txtPassword.Text = "password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check if username and password is correct, return dialog.ok
            if (!ValidateUser())
            {
                txtEmail.Clear();
            }
            else
            {
                exitApp = false;
                this.Close();
                Controller.OpenControlPanel();
            }
        }

        private bool ValidateUser()
        {
            //Validate Email
            //Validate Password
            if (Validator.IsEmail(txtEmail) && Validator.IsPresent(txtPassword))
            {
                if(!PersonDB.Login(txtEmail.Text, txtPassword.Text))
                {
                    MessageBox.Show("Invalid Username and/or Password");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Email or Password not valid.");
                return false;
            }
            //Person person = new Person(1234, "Jordan", "Rhode", "", "", DateTime.Now, Person.PersonTypes.Admin);
            return true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (exitApp)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
