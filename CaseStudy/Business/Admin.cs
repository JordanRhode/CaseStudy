using System;

namespace CaseStudy.Business
{
    public class Admin : Person
    {
        #region Properties
        private long? _adminID = null;
        public long? AdminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }
        #endregion

        public Admin(long adminID, long personID, string firstName, string lastName, DateTime dateOfBirth, PersonTypes type)
            : base(personID, firstName, lastName, dateOfBirth, type)
        {
            _adminID = adminID;
        }
    }
}
