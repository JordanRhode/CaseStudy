using CaseStudy.DataAccess;
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

        private long? _responsiblePartyID = null;
        public long? ResponsiblePartyID { get; set; }

        private Customer _responsibleParty = null;
        public Customer ResponsibleParty
        {
            get { return _responsibleParty; }
            set 
            { 
                _responsibleParty = value;
                if (_responsibleParty != null)
                {
                    _responsiblePartyID = _responsibleParty._responsiblePartyID;
                }
                else
                {
                    _responsiblePartyID = null;
                }
            }
        }

        private List<Customer> _dependants = null;
        public List<Customer> Dependants
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
                        string lastName, string email, string password, DateTime? dateOfBirth, 
                        PersonTypes customerType)
                        : base(personID, firstName, lastName, email, password, dateOfBirth, customerType)
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
                CustomerDB.ModifyCustomer(this);
            }
        }

        public void RemoveDependant(Customer dependant)
        {
            if(_dependants != null)
            {
                _dependants.Remove(dependant);
                CustomerDB.ModifyCustomer(this);
            }
        }

        public void LoadDependants()
        {
            _dependants = CustomerDB.GetDependants(CustomerID);
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
            return string.Format("{0} - {1} - {2}", this.FullName, this.Type, base.PersonType);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
