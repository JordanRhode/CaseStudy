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
    public static class AddressDB
    {
        public static long? AddAddress(Address address)
        {
            string _query = string.Format("INSERT INTO Address " +
                 "VALUES({0},{1},{2},{3})", address.Street, address.City, address.State, address.Zip);
            try
            {
                using (SqlCeConnection conn = CaseStudyDB.GetConnection())
                using (SqlCeCommand cmd = new SqlCeCommand(_query, conn))
                {
                    conn.Open();
                    return (long?)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error Adding Address {0}", ex.Message));
                return null;
            }
        }

        public static Address GetAddressByID(long? addressID)
        {
            //TODO: get address from db
            return new Address();
        }

        public static void DeleteAddress(Address address)
        {
            string _query = string.Format("DELETE FROM Address WHERE AddressID = {0}", address);
            try
            {
                using (SqlCeConnection conn = CaseStudyDB.GetConnection())
                using (SqlCeCommand cmd = new SqlCeCommand(_query, conn))
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error Deleting Address {0}", ex.Message));
                return;
            }
        }
    }
}
