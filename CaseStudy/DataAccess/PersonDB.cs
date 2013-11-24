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
            string _query = string.Format("INSERT INTO Person " +
                "VALUES({0},{1},{2},{3},{4},{5})", person.FirstName, person.LastName,
                person.Address.AddressID, person.DateOfBirth, person.PersonType, person.Email);
            return CaseStudyDB.ExecuteScalar(_query);
        }

        public static void DeletePerson(long? personID)
        {
            string _query = string.Format("DELETE FROM Person WHERE PersonID = {0}", personID);
            CaseStudyDB.ExecuteScalar(_query);
        }
    }
}
