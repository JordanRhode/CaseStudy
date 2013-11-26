using CaseStudy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.DataAccess
{
    public static class PersonDB
    {
        public static long? AddPerson(Person person)
        {
            string _query = string.Format("INSERT INTO Person (FirstName, LastName, AddressID, DateOfBirth, PersonType, Email) " +
                "VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}')", person.FirstName, person.LastName,
                person.Address.AddressID, person.DateOfBirth, person.PersonType, person.Email);
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
            " PersonType='{4}', Email='{5}' WHERE PersonID = {6}", 
            person.FirstName, person.LastName, person.Address.AddressID, 
            person.DateOfBirth, person.PersonType, person.Email, person.PersonID);

            CaseStudyDB.ExecuteNonQuery(_query);
        }
    }
}
