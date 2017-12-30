using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace UIdesign
{
    public class DbHelperSQL
    {
        protected static string connectionString = "";

        static DbHelperSQL()
        {
            connectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
        }

        public static DataTable Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds,"ds");
                } 
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message + ex.InnerException.Message);
                }
                return ds.Tables[0];           
            }

         }

        public static int ExucuteSql(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        int row = cmd.ExecuteNonQuery();
                        return row;
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(ex.Message + ex.InnerException.Message);
                    }
                }
            }
        }
    }
}
