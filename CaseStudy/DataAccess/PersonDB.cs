using CaseStudy.Base;
using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.DataAccess
{
    public static class PersonDB
    {
        public static long? AddPerson(Person person)
        {
            string _query = string.Format("INSERT INTO Person (FirstName, LastName, AddressID, DateOfBirth, PersonType, Email, Password) " +
                "VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}')", 
                person.FirstName, person.LastName,
                person.Address.AddressID, person.DateOfBirth, 
                person.PersonType, person.Email, person.Password);
            return CaseStudyDB.ExecuteNonQuery(_query);
        }

        public static void DeletePerson(long? personID)
        {
            string _query = string.Format("DELETE FROM Person WHERE PersonID = {0}", personID);
            CaseStudyDB.ExecuteNonQuery(_query);
        }

        internal static void UpdatePerson(Person person)
        {
            string _query = string.Format("UPDATE Person " +
            "SET FirstName='{0}', LastName='{1}', AddressID={2}, DateOfBirth='{3}'," +
            " PersonType='{4}', Email='{5}', Password='{6}' WHERE PersonID = {7}", 
            person.FirstName, person.LastName, person.Address.AddressID, 
            person.DateOfBirth, person.PersonType, person.Email, person.Password, person.PersonID);

            CaseStudyDB.ExecuteNonQuery(_query);
        }

        public static bool Login(string email, string password)
        {
            string _query = string.Format("SELECT * FROM Person P " +
                "LEFT JOIN Customer C ON C.PersonID = P.PersonID " +
                "JOIN Address A ON A.AddressID = P.AddressID " +
                "WHERE P.Email='{0}' AND P.Password='{1}'", email, password);

            using (SqlCeDataReader reader = CaseStudyDB.ExecuteReader(_query))
            {
                if(reader != null && reader.Read())
                {
                    Address address = new Address();
                    address.AddressID = (long)reader["AddressID"];
                    address.Street = reader["Street"].ToString();
                    address.City = reader["City"].ToString();
                    address.State = reader["State"].ToString();
                    address.Zip = (int)reader["Zip"];

                    Person person = new Person();
                    person.PersonID = (long)reader["PersonID"];
                    person.FirstName = reader["FirstName"].ToString();
                    person.LastName = reader["LastName"].ToString();
                    person.SetAddress(address);
                    person.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                    Person.PersonTypes personType;
                    Enum.TryParse<Person.PersonTypes>(reader["PersonType"].ToString(), out personType);
                    person.PersonType = personType;
                    person.Email = reader["Email"].ToString();
                    person.Password = reader["Password"].ToString();

                    Customer customer;
                    if (!reader.IsDBNull(reader.GetOrdinal("CustomerID")))
                    {
                        customer = (Customer)person; customer.CustomerID = (long)reader["CustomerID"];
                        customer.PersonID = (long)reader["PersonID"];
                        if (!reader.IsDBNull(reader.GetOrdinal("ResponsiblePartyID")))
                        {
                            customer.ResponsiblePartyID = (long)reader["ResponsiblePartyID"];

                        }

                        Customer.Types type;
                        Enum.TryParse<Customer.Types>(reader["Type"].ToString(), out type);
                        customer.Type = type;
                        UserInfo.SetUser(customer);
                        return true;
                    }
                    UserInfo.SetUser(person);
                    return true;
                }
                return false;
            }
        }
    }
}
