using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class LoginDAL : DataProvider
    {
        public TaiKhoanDTO Login(string userName, string password)
        {
            string sql = "SELECT TaiKhoanID, NhanVienID, Username, PasswordHash, Role, TrangThai " +
                         "FROM TaiKhoan WHERE Username = @Username AND PasswordHash = @PasswordHash";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", userName),
                new SqlParameter("@PasswordHash", password)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new TaiKhoanDTO(
                        Convert.ToInt32(reader["TaiKhoanID"]),
                        Convert.ToInt32(reader["NhanVienID"]),
                        reader["Username"].ToString(),
                        reader["PasswordHash"].ToString(),
                        reader["Role"].ToString(),
                        Convert.ToBoolean(reader["TrangThai"])
                    );
                }
            }

            return null; 
        }

        public bool CapNhatMatKhauDAL(string username, string matKhauCu, string matKhauMoi)
        {
            string sql = "UPDATE TaiKhoan SET PasswordHash = @NewPassword WHERE Username = @Username AND PasswordHash = @Password";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", matKhauCu),
                new SqlParameter("@NewPassword", matKhauMoi)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }



    }
}
