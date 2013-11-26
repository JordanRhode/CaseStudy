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
            string _query = string.Format("INSERT INTO Address(Street, City, State, Zip) " +
                 "VALUES('{0}', '{1}', '{2}', {3})", address.Street, address.City, address.State, address.Zip);
            try
            {
                return (CaseStudyDB.ExecuteNonQuery(_query));
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

        internal static void UpdateAddress(Address address)
        {
            string _query = string.Format("UPDATE Address " +
                "SET Street='{0}', City='{1}', State='{2}', Zip={3} " +
                "WHERE AddressID = {4}", address.Street, address.City, 
                 address.State, address.Zip, address.AddressID);
            try
            {
                CaseStudyDB.ExecuteNonQuery(_query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error Adding Address {0}", ex.Message));
            }
        }
    }
}
