using System;
using System.Collections.Generic;

namespace CaseStudy.Business
{
    public class Customer : Person
    {
        #region Properties
        private long? _customerID = null;
        public long? CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private Customer _responsibleParty = null;
        public Customer ResponsibleParty
        {
            get { return _responsibleParty; }
            set { _responsibleParty = value; }
        }

        private List<Customer> _dependants = null;
        public IEnumerable<Customer> Dependants
        {
            get { return _dependants; }
        }

        public enum Types
        {
            Student,
            Parent,
            Teacher,
            Unknown
        }

        private Types _type = Types.Unknown;
        public Types Type
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion

        public Customer() : base()
        {

        }

        public Customer(long? customerID, Types type, long? personID, string firstName, 
                        string lastName, DateTime? dateOfBirth, PersonTypes customerType)
                        : base(personID, firstName, lastName, dateOfBirth, customerType)
        {
            _customerID = customerID;
            _type = type;
        }

        public void AddDependant(Customer dependant)
        {
            if (this.PersonType == PersonTypes.ResponsibleParty && dependant.PersonType == PersonTypes.Customer)
            {
                if (_dependants == null)
                {
                    _dependants = new List<Customer>();
                }
                _dependants.Add(dependant);
                dependant.ResponsibleParty = this;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer)
            {
                Customer customer = (Customer)obj;
                if (customer.FullName != null && customer.Address != null && customer.DateOfBirth != null)
                {
                    return ((this.FullName == customer.FullName) &&
                            (this.Address.AddressID == customer.Address.AddressID) &&
                            (this.DateOfBirth == customer.DateOfBirth) &&
                             this.Type == customer.Type &&
                             this.ResponsibleParty == customer.ResponsibleParty);
                }
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0}, Type: {1}, Customer Type: {2}", this.FullName, base.PersonType, this.Type);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
