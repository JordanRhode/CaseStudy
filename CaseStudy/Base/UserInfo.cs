using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Base
{
    public static class UserInfo
    {
        private static Person _currentUser = null;
        public static Person CurrentUser
        {
            get { return _currentUser; }
        }

        public static void SetUser(Person person)
        {
            _currentUser = person;
        }

        public static void Logout()
        {
            _currentUser = null;
        }
    }
}
