using CaseStudy.Business;
using CaseStudy.Forms;
using System;
using System.Windows.Forms;

namespace CaseStudy.Base
{
    class Program
    {
        public static void Main()
        {
            Controller.Login(true);
            //Application.Run(new Login());
            
            //Login login = new Login();
            //DialogResult result = login.ShowDialog();
            //if (result == System.Windows.Forms.DialogResult.Yes)
            //{
            //    if (UserInfo.CurrentUser.PersonType == Person.PersonTypes.Admin)
            //    {
            //        AdminPanel adminPanel = new AdminPanel();
            //        adminPanel.ShowDialog();
            //    }
            //    else
            //    {
            //        CustomerPanel customerPanel = new CustomerPanel();
            //        customerPanel.ShowDialog();
            //    }
            //}
        }
    }
}
