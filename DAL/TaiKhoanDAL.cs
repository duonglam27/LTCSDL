using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL : DataProvider
    {
        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            string sql = "SELECT * FROM TaiKhoan";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    TaiKhoanDTO tk = new TaiKhoanDTO(
                        Convert.ToInt32(reader["TaiKhoanID"]),
                        Convert.ToInt32(reader["NhanVienID"]),
                        reader["Username"].ToString(),
                        reader["PasswordHash"].ToString(),
                        reader["Role"].ToString(),
                        Convert.ToBoolean(reader["TrangThai"])
                    );
                    list.Add(tk);
                }
            }
            return list;
        }

        public TaiKhoanDTO DangNhap(string username, string passwordHash)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE Username = @Username AND PasswordHash = @PasswordHash AND TrangThai = 1";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHash", passwordHash)
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

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            string sql = @"INSERT INTO TaiKhoan (NhanVienID, Username, PasswordHash, Role, TrangThai)
                           VALUES (@NhanVienID, @Username, @PasswordHash, @Role, @TrangThai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@NhanVienID", tk.NhanVienID),
                new SqlParameter("@Username", tk.Username),
                new SqlParameter("@PasswordHash", tk.PasswordHash),
                new SqlParameter("@Role", tk.Role),
                new SqlParameter("@TrangThai", tk.TrangThai)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool CapNhatTrangThai(int taiKhoanID, bool trangThai)
        {
            string sql = "UPDATE TaiKhoan SET TrangThai = @TrangThai WHERE TaiKhoanID = @TaiKhoanID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@TaiKhoanID", taiKhoanID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }
    }
}
