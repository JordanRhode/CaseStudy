using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseStudy.Business
{
    public class Transaction
    {
        private List<TransactionProducts> transactionProducts;
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

        private long? _responsiblePartyID = null;
        public long? ResponsiblePartyID
        {
            get { return _responsiblePartyID; }
            set { _responsiblePartyID = value; }
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
        #endregion

        public long CalculateTotalPrice()
        {
            long totalPrice = 0;
            foreach (Product product in _products.Keys)
            {
                totalPrice += (product.Price.Value * _products[product]);
            }
            return totalPrice;
        }

    }
}
