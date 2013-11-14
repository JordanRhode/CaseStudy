using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseStudy.Business
{
    public class Transaction
    {
        #region Properties
        private long? _transactionID = null;
        public long? TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }

        private Dictionary<Product, int> _products = null;
        public Dictionary<Product, int> Products
        {
            get { return _products; }
        }

        private long? _totalPrice = null;
        public long? TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        private long? _customerID = null;
        public long? CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private DateTime? _date = null;
        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        public void AddProduct(Product product, int quantity)
        {
            _products.Add(product, quantity);
        }

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
