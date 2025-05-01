using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            try
            {
                string strcon = @"Data Source=LAPTOP\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(strcon); //khởi tạo connect
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối CSDL trong DAL", ex);//quăng lỗi cho GUI xử lý (nếu có)
            }
          
        }
    }

    public class DB_Access
    {
        public static string CheckLogin(TaiKhoanDTO taiKhoanDTO)
        {
            string user = null;

            return user;
        }
                                                                         


    }
}
