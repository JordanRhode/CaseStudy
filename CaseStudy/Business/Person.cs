using System;

namespace CaseStudy.Business
{
    public class Person
    {
        #region Properties
        private long? _personID = null;
        public long? PersonID
        {
            set { _personID = value; }
            get { return _personID; }
        }

        private string _firstName = null;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName = null;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        private string _email = null;
        public string Email { get; set; }

        private Address _address = null;
        public Address Address
        {
            get { return _address; }
        }

        private DateTime? _dateOfBirth = null;
        public DateTime? DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public enum PersonTypes
        {
            Customer,
            ResponsibleParty,
            Admin
        }

        private PersonTypes _personType = PersonTypes.Customer;
        public PersonTypes PersonType
        {
            get { return _personType; }
            set { _personType = value; }
        }
        #endregion

        public Person()
        {

        }

        public Person(long? personID, string firstName, string lastName, DateTime? dateOfBirth, PersonTypes type)
        {
            _personID = personID;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _personType = type;
        }

        public void SetAddress(Address address)
        {
            _address = address;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = (Person)obj;
                if (person.FullName != null && person._address != null && person.DateOfBirth != null)
                {
                    return ((this.FullName == person.FullName) &&
                            (this._address.AddressID == person._address.AddressID) &&
                            (this.DateOfBirth == person.DateOfBirth));
                }
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0}, Type: {1}", this.FullName, this._personType);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
