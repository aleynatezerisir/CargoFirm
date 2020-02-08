using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace CargoFirm
{
    public class DBHelper
    {
        public static void ExecuteNoneQuery(string sql)
        {
            ExecuteNoneQuery(sql, null);
        }
        public static void ExecuteNoneQuery(string sql, List<SqlParameter> param)
        {
            SqlCommand cmd = new SqlCommand(sql, new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));
            if (param != null)
            {
                foreach (SqlParameter item in param)
                {
                    cmd.Parameters.Add(item);
                }
            }

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, null);
        }
        public static object ExecuteScalar(string sql, List<SqlParameter> param)
        {
            object retval = null;
            SqlCommand cmd = new SqlCommand(sql, new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));
            if (param != null)
            {
                foreach (SqlParameter item in param)
                {
                    cmd.Parameters.Add(item);
                }
            }

            try
            {
                cmd.Connection.Open();
                retval = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                ErrorLog(ex.ToString());
                throw ex;

            }
            finally
            {
                cmd.Connection.Close();
            }
            return retval;
        }
        public static DataSet ExecuteDataset(string sql)
        {
            return ExecuteDataset(sql, null);
        }
        public static DataSet ExecuteDataset(string sql, List<SqlParameter> param)
        {
            DataSet retval = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));
            if (param != null)
            {
                foreach (SqlParameter item in param)
                {
                    da.SelectCommand.Parameters.Add(item);
                }
            }
            da.Fill(retval);
            return retval;
        }
        public static void ErrorLog(string error)
        {
        }
    }

}
