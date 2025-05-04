using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDAL : DataProvider
    {
        public bool Login(TaiKhoanDTO taikhoan)
        {
            bool result = false;
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @Username AND PasswordHash = @PasswordHash";

            using (SqlConnection conn = GetConnection())  // Kế thừa từ DataProvider
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", taikhoan.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", taikhoan.PasswordHash);

                    int count = (int)cmd.ExecuteScalar();  // Trả về 0 hoặc 1
                    result = count > 0;
                }
            }                                     

            return result;
        }

    }
}
