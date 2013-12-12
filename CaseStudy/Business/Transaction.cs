using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseStudy.Business
{
    public class Transaction
    {
        public List<TransactionProduct> transactionProducts;
        #region Properties
        private long? _transactionID = null;
        public long? TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }

        private long? _customerID = null;
        public long? CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private Customer _customer = null;
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private long? _responsiblePartyID = null;
        public long? ResponsiblePartyID
        {
            get { return _responsiblePartyID; }
            set { _responsiblePartyID = value; }
        }

        private Customer _responsibleParty = null;
        public Customer ResponsibleParty
        {
            get { return _responsibleParty; }
            set { _responsibleParty = value; }
        }

        private DateTime? _transactionDate = null;
        public DateTime? TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }

        private DateTime? _paymentRecieved = null;
        public DateTime? PaymentRecieved
        {
            get { return _paymentRecieved; }
            set { _paymentRecieved = value; }
        }

        private long? _totalPrice = null;
        public long? TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        private List<TransactionProduct> _transactionProducts = null;
        public IEnumerable<TransactionProduct> TransactionProducts
        {
            get { return _transactionProducts; }
        }
        #endregion
      
        public void AddTransactionProduct(TransactionProduct product)
        {
            if(_transactionProducts == null)
            {
                _transactionProducts = new List<TransactionProduct>();
            }
            _transactionProducts.Add(product);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - ${2}", Customer.FullName, _transactionDate.Value.ToShortDateString(), _totalPrice);
        }
    }
}
