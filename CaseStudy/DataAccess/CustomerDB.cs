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
    public static class CustomerDB
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                string _query = "SELECT * FROM Customer C " +
                                "JOIN Person P ON P.PersonID = C.PersonID " +
                                "JOIN Address A ON A.AddressID = P.AddressID";

                using(SqlCeDataReader reader = CaseStudyDB.ExecuteReader(_query))
                {
                    while (reader != null & reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = (long)reader["CustomerID"];
                        customer.PersonID = (long)reader["PersonID"];
                        if (!reader.IsDBNull(reader.GetOrdinal("ResponsiblePartyID")))
                        {
                            customer.CustomerID = (long)reader["ResponsiblePartyID"];
                        }

                        Customer.Types type;
                        Enum.TryParse<Customer.Types>(reader["Type"].ToString(), out type);
                        customer.Type = type;
                        customer.FirstName = reader["FirstName"].ToString();
                        customer.LastName = reader["LastName"].ToString();
                        Person.PersonTypes personType;
                        Enum.TryParse<Person.PersonTypes>(reader["PersonType"].ToString(), out personType);
                        customer.PersonType = personType;
                        customer.Email = reader["Email"].ToString();

                        Address address = new Address();
                        address.AddressID = (long)reader["AddressID"];
                        address.Street = reader["Street"].ToString();
                        address.City = reader["City"].ToString();
                        address.State = reader["State"].ToString();
                        address.Zip = (int)reader["Zip"];

                        customer.SetAddress(address);
                        customers.Add(customer);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Error Getting Customers. {0}", ex.Message));
            }
            return customers;
        }

        public static long? AddCustomer(Customer customer)
        {
            if(customer.PersonType == Person.PersonTypes.ResponsibleParty)
            {
                customer.Address.AddressID = AddressDB.AddAddress(customer.Address);
            }
            customer.PersonID =  PersonDB.AddPerson(customer);
            string _query = string.Format("INSERT INTO Customer " +
                "VALUES({},{},{})", customer.PersonID, customer.ResponsiblePartyID, customer.PersonType);
            return CaseStudyDB.ExecuteScalar(_query);
        }

        public static void ModifyCustomer(Customer customer)
        {

        }

        public static void DeleteCustomer(Customer customer)
        {
            if(customer.Dependants.Count > 0)
            {
                MessageBox.Show("Cannot delete customer with dependants");
                return;
            }

            if(customer.PersonType == Person.PersonTypes.ResponsibleParty)
            {
                AddressDB.DeleteAddress(customer.Address);
            }

            PersonDB.DeletePerson(customer.PersonID);
            

            string _query = string.Format("DELETE FROM Customer WHERE CustomerID = {0}", customer.CustomerID);
            CaseStudyDB.ExecuteScalar(_query);

        }

    }
}
