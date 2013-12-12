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

        public static Person GetPersonFromReader(SqlCeDataReader reader)
        {
            if (reader != null)
            {
                Person person = new Person();
                person.PersonID = (long)reader["PersonID"];
                person.FirstName = reader["FirstName"].ToString();
                person.LastName = reader["LastName"].ToString();
                person.SetAddress(AddressDB.GetAddressFromReader(reader));
                person.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                Person.PersonTypes personType;
                Enum.TryParse<Person.PersonTypes>(reader["PersonType"].ToString(), out personType);
                person.PersonType = personType;
                person.Email = reader["Email"].ToString();
                person.Password = reader["Password"].ToString();

                return person;
            }
            return null;
        }

        public static bool Login(string email, string password)
        {
            string _query = string.Format("SELECT * FROM Person P " +
                "LEFT JOIN Customer C ON C.PersonID = P.PersonID " +
                "JOIN Address A ON A.AddressID = P.AddressID " +
                "WHERE P.Email='{0}' AND P.Password='{1}'", email, password);

            using (SqlCeDataReader reader = CaseStudyDB.ExecuteReader(_query))
            {
                if (reader != null && reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("CustomerID")))
                    {
                        Customer customer = CustomerDB.GetCustomerFromReader(reader);
                        if (customer != null)
                        {
                            UserInfo.SetUser(customer);
                            return true;
                        }
                    }
                    else
                    {
                        Person person = GetPersonFromReader(reader);
                        if (person != null)
                        {
                            UserInfo.SetUser(person);
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
