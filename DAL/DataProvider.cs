using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class DataProvider
    {
        private static readonly string strcon = @"Data Source=LAPTOP\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(strcon);
        }

        public static SqlConnection GetOpenConnection()
        {
            var conn = new SqlConnection(strcon);
            conn.Open();
            return conn;
        }
    }



    public class DB_Access
    {
        
                                                                         


    }
}
