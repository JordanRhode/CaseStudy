using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.DataAccess
{
    public static class ProductDB
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            string _query = "SELECT * FROM Product";
            using (SqlCeDataReader reader = CaseStudyDB.ExecuteReader(_query))
            {
                while(reader != null && reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = (long?)reader["ProductID"];
                    product.Name = reader["Name"].ToString();
                    product.Description = reader["Description"].ToString();
                    product.Price = (int?)reader["Price"];
                    Product.Types type;
                    Enum.TryParse<Product.Types>(reader["Type"].ToString(), out type);
                    product.Type = type;
                    products.Add(product);
                }
                return products;
            }
        }

        public static long? AddProduct(Product product)
        {
            if (product != null)
            {
                string _query = string.Format("INSERT INTO Product (Name, Price, Description, Type) " +
                    "VALUES('{0}', {1}, '{2}', '{3}')",
                    product.Name, product.Price, product.Description, product.Type);
                return CaseStudyDB.ExecuteNonQuery(_query);
            }
            return null;
        }

        public static long? ModifyProduct(Product product)
        {
            if(product != null)
            {
                string _query = string.Format("UPDATE Product " +
                    "SET Name='{0}', Price={1}, Description='{2}', Type='{3}' " +
                    "WHERE ProductID = {4}", product.Name, product.Price,
                    product.Description, product.Type, product.ProductID);
                return CaseStudyDB.ExecuteNonQuery(_query);
            }
            return null;
        }

        internal static long? DeleteProduct(Product product)
        {
            if(product != null)
            {
                string _query = string.Format("DELETE FROM Product WHERE ProductID = {0}", product.ProductID);
                return CaseStudyDB.ExecuteNonQuery(_query);
            }
            return null;
        }
    }
}
