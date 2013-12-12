using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy.DataAccess
{
    public static class CaseStudyDB
    {
        private const string _connection = @"Data Source=|DataDirectory|\CaseStudyDB.sdf";

        internal static SqlCeConnection GetConnection()
        {
            return new SqlCeConnection(_connection);
        }

        public static long? ExecuteNonQuery(string query)
        {
            try
            {
                SqlCeConnection conn = CaseStudyDB.GetConnection();
                conn.Open();
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                cmd.ExecuteScalar();
                cmd = new SqlCeCommand("SELECT @@IDENTITY", conn);
                object queryReturn = cmd.ExecuteScalar();
                long value;
                long.TryParse(queryReturn.ToString(),out value);
                conn.Close();
                if(value != 0)
                {
                    return value;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error exeuting query: {0}", ex.Message));
                return null;
            }
        }

        public static SqlCeDataReader ExecuteReader(string query)
        {
            try
            {
                SqlCeConnection conn = CaseStudyDB.GetConnection();
                conn.Open();

                SqlCeCommand cmd = new SqlCeCommand(query, conn);

                return cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error exeuting query: {0}", ex.Message));
                return null;
            }
        }
    }
}
