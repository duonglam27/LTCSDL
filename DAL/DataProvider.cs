using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using System.Data;


namespace DAL
{
    public class DataProvider
    {
        public SqlConnection connect;
        public SqlCommand cmd;
        public DataProvider()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connect = new SqlConnection(connStr);
        }
        public void Connect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void Disconnect()
        {
            if (connect != null && connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
        public SqlDataReader MyExecuteReader(string sql, CommandType type, SqlParameter[] parameters =null)
        {
            try
            {
                Connect();
                cmd = new SqlCommand(sql, connect);
                cmd.CommandType = type;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException )
            {

                throw ;
            }
           
        }

        public int MyExecuteNonQuery(string sql, CommandType type, SqlParameter[] parameters=null)
        {

            try
            {
                Connect();
                cmd = new SqlCommand(sql, connect);
                cmd.CommandType = type;
                if (parameters!=null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException )
            {

                throw ;
            }
            finally
            {
                Disconnect();
            }
            
        }

        public object MyExecuteScalar(string sql, CommandType type, SqlParameter[] parameters = null)
        {
            try
            {
                Connect();
                cmd = new SqlCommand(sql, connect);
                cmd.CommandType = type;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteScalar();
            }
            catch (SqlException )
            {

                throw ;
            }
            finally
            {
                Disconnect();
            }
        }
        
    }



    public class DB_Access
    {
        
                                                                         


    }
}
