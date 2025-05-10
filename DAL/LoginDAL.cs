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
        public bool Login(TaiKhoanDTO taikhoan)
        {
            
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @Username AND PasswordHash = @PasswordHash";

            SqlParameter[] parameters = new SqlParameter[]
                {
                  new SqlParameter ("@Username",taikhoan.Username),
                  new SqlParameter ("@PasswordHash",taikhoan.PasswordHash)
                };
            object result =MyExecuteScalar(sql,CommandType.Text,parameters);
                                               
            return result !=null && Convert.ToInt32(result)>0;
        }

    }
}
