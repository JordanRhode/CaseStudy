using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseStudy.Business
{
    public class TransactionProduct
    {
        private long? _transactionProductID = null;
        public long? TransactionProductID
        {
            get { return _transactionProductID; }
            set { _transactionProductID = value; }
        }

        private long? _transactionID = null;
        public long? TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }

        private long? _productID = null;
        public long? ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        private int? _quantity = null;
        public int? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public TransactionProduct() { }

        public TransactionProduct(long? transactionProductID, long? transactionID, long? productID, int? quantity)
        {
            _transactionProductID = transactionProductID;
            _transactionID = transactionID;
            _productID = productID;
            _quantity = quantity;
        }
    }
}
