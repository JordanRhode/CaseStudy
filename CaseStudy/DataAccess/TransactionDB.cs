using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy.DataAccess
{
    public static class TransactionDB
    {
        public static List<Transaction> GetTransactions()
        {
            return null;
        }

        internal static void AddTransaction(Transaction transaction)
        {
            string paymentRecieved = "";
            if(transaction.PaymentRecieved != null)
            {
                paymentRecieved = transaction.PaymentRecieved.ToString();
            }
            string _query = string.Format("INSERT INTO [Transaction] (CustomerID, ResponsiblePartyID, TransactionDate, PaymentRecieved, TotalPrice) " +
                "VALUES({0}, {1}, '{2}', '{3}', {4})", transaction.CustomerID, 
                transaction.ResponsiblePartyID == null ? 0 : transaction.ResponsiblePartyID, 
                transaction.TransactionDate, paymentRecieved, transaction.TotalPrice);

            long? transactionID = CaseStudyDB.ExecuteNonQuery(_query);
            if(transactionID != null)
            {
                foreach(TransactionProduct product in transaction.TransactionProducts)
                {
                    _query = string.Format("INSERT INTO TransactionProducts (TransactionID, ProductID, Quantity) " +
                        "VALUES({0},{1},{2})", transactionID, product.ProductID, product.Quantity);
                    CaseStudyDB.ExecuteNonQuery(_query);
                }
            }
            else
            {
                MessageBox.Show("Couldn't save transaction");
            }
        }

        public static void DeleteTransactionsByCustomer(long customerID)
        {
            string _query = string.Format("DELETE FROM [Transaction] WHERE CustomerID={0}", customerID);
            long? val = CaseStudyDB.ExecuteNonQuery(_query);
        }

        internal static List<Transaction> GetOutstandingInvoices()
        {
            string _query = "SELECT * FROM [Transaction] WHERE PaymentRecieved < TransactionDate";
            List<Transaction> transactions = new List<Transaction>();

            try
            {
                using(SqlCeDataReader reader = CaseStudyDB.ExecuteReader(_query))
                {
                    while(reader != null && reader.Read())
                    {
                        Transaction transaction = GetTransactionFromReader(reader);
                        if(transaction != null)
                        {
                            transactions.Add(transaction);
                        }
                        else
                        {
                            throw new Exception("Can't get Transaction from DB");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Error Getting Transactions. {0}", ex.Message));
            }
            GetTransactionCustomer(ref transactions);
            SetTransactionProducts(ref transactions);
            return transactions;
        }

        private static void GetTransactionCustomer(ref List<Transaction> transactions)
        {
            foreach(Transaction transaction in transactions)
            {
                transaction.Customer = CustomerDB.GetCustomerByID((long)transaction.CustomerID);
                if (transaction.ResponsiblePartyID != null)
                {
                    transaction.ResponsibleParty = CustomerDB.GetCustomerByID((long)transaction.ResponsiblePartyID);
                }
            }
        }

        private static Transaction GetTransactionFromReader(SqlCeDataReader reader)
        {
            if(reader != null)
            {
                Transaction transaction = new Transaction();
                transaction.TransactionID = (long)reader["TransactionID"];
                transaction.CustomerID = (long)reader["CustomerID"];
                if (!reader.IsDBNull(reader.GetOrdinal("ResponsiblePartyID")))
                {
                    transaction.ResponsiblePartyID = (long)reader["ResponsiblePartyID"];
                }
                transaction.TransactionDate = DateTime.Parse(reader["TransactionDate"].ToString());
                transaction.PaymentRecieved = DateTime.Parse(reader["PaymentRecieved"].ToString());
                transaction.TotalPrice = (int)reader["TotalPrice"];

                return transaction;
            }
            return null;
        }

        private static void SetTransactionProducts(ref List<Transaction> transactions)
        {
            foreach (Transaction transaction in transactions)
            {
                string _query = string.Format("SELECT * FROM TransactionProducts WHERE TransactionID = {0}", transaction.TransactionID);

                try
                {
                    using (SqlCeDataReader reader = CaseStudyDB.ExecuteReader(_query))
                    {
                        while (reader != null && reader.Read())
                        {
                            TransactionProduct product = GetTransactionProductFromReader(reader);
                            if (product != null)
                            {
                                transaction.AddTransactionProduct(product);
                            }
                            else
                            {
                                throw new Exception("Can't get TransactionProducts from DB");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Error Getting Transaction Products. {0}", ex.Message));
                }
            }
        }

        private static TransactionProduct GetTransactionProductFromReader(SqlCeDataReader reader)
        {
            if (reader != null)
            {
                TransactionProduct product = new TransactionProduct();
                product.TransactionProductID = (long)reader["TransactionProductsID"];
                product.TransactionID = (long)reader["TransactionID"];
                product.ProductID = (long)reader["ProductID"];
                product.Quantity = (int)reader["Quantity"];

                return product;
            }
            return null;
        }
    }
}
