using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAL
{
    public class NhanVienDAL:DataProvider
    {
        public List<NhanVienDTO> GetAllNhanVienDAL()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            string sql = "SELECT * FROM NhanVien";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["NhanVienID"]);
                    string hoTen = reader["HoTen"].ToString();
                    DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    string email = reader["Email"].ToString();
                    string soDienThoai = reader["SoDienThoai"].ToString();
                    string phongBan = reader["PhongBan"].ToString();
                    string trangThai = reader["TrangThai"].ToString();

                    NhanVienDTO nv = new NhanVienDTO(id, hoTen, ngaySinh, email, soDienThoai, phongBan, trangThai);
                    list.Add(nv);
                }
            }
            return list;
        }

        public NhanVienDTO GetNhanVienByIDDAL(int id)
        {
            string sql = "SELECT * FROM NhanVien WHERE NhanVienID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    string hoTen = reader["HoTen"].ToString();
                    DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    string email = reader["Email"].ToString();
                    string soDienThoai = reader["SoDienThoai"].ToString();
                    string phongBan = reader["PhongBan"].ToString();
                    string trangThai = reader["TrangThai"].ToString();

                    return new NhanVienDTO(id, hoTen, ngaySinh, email, soDienThoai, phongBan, trangThai);
                }
            }
            return null;
        }

        public bool ThemNhanVienDAL(NhanVienDTO nv)
        {
            string sql = "INSERT INTO NhanVien (HoTen, NgaySinh, Email, SoDienThoai, PhongBan, TrangThai) " +
                         "VALUES (@HoTen, @NgaySinh, @Email, @SoDienThoai, @PhongBan, @TrangThai)";
            SqlParameter[] parameters = {
                new SqlParameter("@HoTen", nv.HoTen),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@SoDienThoai", nv.SoDienThoai),
                new SqlParameter("@PhongBan", nv.PhongBan),
                new SqlParameter("@TrangThai", nv.TrangThai)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool SuaNhanVienDAL(NhanVienDTO nv)
        {
            string sql = "UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, Email = @Email, " +
                         "SoDienThoai = @SoDienThoai, PhongBan = @PhongBan, TrangThai = @TrangThai " +
                         "WHERE NhanVienID = @NhanVienID";
            SqlParameter[] parameters = {
                new SqlParameter("@NhanVienID", nv.NhanVienID),
                new SqlParameter("@HoTen", nv.HoTen),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@SoDienThoai", nv.SoDienThoai),
                new SqlParameter("@PhongBan", nv.PhongBan),
                new SqlParameter("@TrangThai", nv.TrangThai)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool XoaNhanVienDAL(int id)
        {
            string sql = "DELETE FROM NhanVien WHERE NhanVienID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }
    }
}
