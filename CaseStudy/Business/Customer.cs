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

        private List<Customer> _dependents = null;
        public List<Customer> Dependents
        {
            get { return _dependents; }
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

        public void AddDependent(Customer dependent)
        {
            if (this.PersonType == PersonTypes.ResponsibleParty && dependent.PersonType == PersonTypes.Customer)
            {
                if (_dependents == null)
                {
                    _dependents = new List<Customer>();
                }
                _dependents.Add(dependent);
                dependent.ResponsibleParty = this;
                CustomerDB.ModifyCustomer(this);
            }
        }

        public void RemoveDependent(Customer dependent)
        {
            if(_dependents != null)
            {
                _dependents.Remove(dependent);
                CustomerDB.ModifyCustomer(this);
            }
        }

        public void LoadDependents()
        {
            _dependents = CustomerDB.GetDependents(CustomerID);
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
