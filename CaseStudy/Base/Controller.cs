using CaseStudy.Business;
using CaseStudy.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy.Base
{
    public static class Controller
    {
        public static void Login(bool initialLoad)
        {
            Login login = new Login();
            login.Show();
            if (initialLoad)
            {
                Application.Run();
            }
        }

        public static void Logout()
        {
            UserInfo.Logout();
            Login(false);
        }

        public static void OpenControlPanel()
        {
            if (UserInfo.CurrentUser.PersonType == Person.PersonTypes.Admin)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
            }
            else
            {
                CustomerPanel customerPanel = new CustomerPanel();
                customerPanel.ShowDialog();
            }
        }
    }
}
