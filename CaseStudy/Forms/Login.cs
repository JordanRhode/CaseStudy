using CaseStudy.Base;
using CaseStudy.Business;
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
    public partial class Login : Form
    {
        private bool exitApp = true;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check if username and password is correct, return dialog.ok
            if (!ValidateUser())
            {
                txtEmail.Clear();
                txtPassword.Clear();
                MessageBox.Show("Email and/or Password is incorrect", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Person person = new Person(1234, "Jordan", "Rhode", DateTime.Now, Person.PersonTypes.Admin);
            UserInfo.SetUser(person);
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
