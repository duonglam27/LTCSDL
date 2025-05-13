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
    public class LuongDAL:DataProvider
    {
        public List<LuongDTO> GetAllLuongDAL()
        {
            List<LuongDTO> danhSach = new List<LuongDTO>();
            string sql = @"SELECT * From Luong";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int luongID = Convert.ToInt32(reader["LuongID"]);
                    int nhanVienID = Convert.ToInt32(reader["NhanVienID"]);
                    DateTime thang = DateTime.Parse(reader["ThangNam"].ToString());
                    decimal luongCoBan = Convert.ToDecimal(reader["LuongCoBan"]);
                    int thuong = Convert.ToInt32(reader["Thuong"]);
                    int phat = Convert.ToInt32(reader["Phat"]);
                    int tongLuong = Convert.ToInt32(reader["TongLuong"]);

                    LuongDTO luong = new LuongDTO(luongID, nhanVienID, thang, luongCoBan, thuong, phat, tongLuong);
                    danhSach.Add(luong);
                }
            }

            return danhSach;
        }
        public List<LuongDTO> GetAllLuongDALTheoID(int nhanVienID)
        {
            List<LuongDTO> danhSach = new List<LuongDTO>();
            string sql = @"SELECT * From Luong WHERE NhanVienID=@NhanVienID";
            SqlParameter[] parameters ={
                              new SqlParameter("@NhanVienID", nhanVienID)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))

            {
                while (reader.Read())
                {
                    int luongID = Convert.ToInt32(reader["LuongID"]);
                    nhanVienID = Convert.ToInt32(reader["NhanVienID"]);
                    DateTime thang = DateTime.Parse(reader["ThangNam"].ToString());
                    decimal luongCoBan = Convert.ToDecimal(reader["LuongCoBan"]);
                    int thuong = Convert.ToInt32(reader["Thuong"]);
                    int phat = Convert.ToInt32(reader["Phat"]);
                    int tongLuong = Convert.ToInt32(reader["TongLuong"]);

                    LuongDTO luong = new LuongDTO(luongID, nhanVienID, thang, luongCoBan, thuong, phat, tongLuong);
                    danhSach.Add(luong);
                }
            }

            return danhSach;
        }

        public bool ThemLuongDAL(LuongDTO luong)
        {
            string sql = @"INSERT INTO Luong (NhanVienID, ThangNam, LuongCoBan, Thuong, Phat, TongLuong)
                   VALUES (@NhanVienID, @ThangNam, @LuongCoBan, @Thuong, @Phat, @TongLuong)";
            SqlParameter[] parameters = {
                new SqlParameter("@NhanVienID", luong.NhanVienID),
                new SqlParameter("@ThangNam", luong.ThangNam),  // Đảm bảo ThangNam là kiểu DateTime
                new SqlParameter("@LuongCoBan", luong.LuongCoBan),
                new SqlParameter("@Thuong", luong.Thuong),
                new SqlParameter("@Phat", luong.Phat),
                new SqlParameter("@TongLuong", luong.TongLuong)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }


        public bool SuaLuongDAL(LuongDTO luong)
        {
            string sql = @"UPDATE Luong 
                           SET NhanVienID = @NhanVienID, ThangNam = @ThangNam, LuongCoBan = @LuongCoBan, 
                               Thuong = @Thuong, Phat = @Phat, TongLuong = @TongLuong
                           WHERE LuongID = @LuongID";
            SqlParameter[] parameters = {
                new SqlParameter("@LuongID", luong.LuongID),
                new SqlParameter("@NhanVienID", luong.NhanVienID),
                new SqlParameter("@ThangNam", luong.ThangNam),
                new SqlParameter("@LuongCoBan", luong.LuongCoBan),
                new SqlParameter("@Thuong", luong.Thuong),
                new SqlParameter("@Phat", luong.Phat),
                new SqlParameter("@TongLuong", luong.TongLuong)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public bool XoaLuongDAL(int luongID)
        {
            string sql = "DELETE FROM Luong WHERE LuongID = @LuongID";
            SqlParameter[] parameters = {
                new SqlParameter("@LuongID", luongID)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        public List<LuongDTO> GetLuongTheoThangNam(int nam,int nhanVienID)
        {
            List<LuongDTO> danhSach = new List<LuongDTO>();
            string sql = "SELECT * FROM Luong WHERE YEAR(ThangNam) = @Nam AND NhanVienID=@NhanVienID";

                SqlParameter[] parameters = {
                  
                    new SqlParameter("@Nam", nam),
                    new SqlParameter("@NhanVienID", nhanVienID)
                };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    int luongID = Convert.ToInt32(reader["LuongID"]);
                    nhanVienID = Convert.ToInt32(reader["NhanVienID"]);
                    DateTime thangNam = DateTime.Parse(reader["ThangNam"].ToString());
                    decimal luongCoBan = Convert.ToDecimal(reader["LuongCoBan"]);
                    int thuong = Convert.ToInt32(reader["Thuong"]);
                    int phat = Convert.ToInt32(reader["Phat"]);
                    int tongLuong = Convert.ToInt32(reader["TongLuong"]);

                    LuongDTO luong = new LuongDTO(luongID, nhanVienID, thangNam, luongCoBan, thuong, phat, tongLuong);
                    danhSach.Add(luong);
                }
            }

            return danhSach;
        }


        public void CapNhatLuong(int nhanVienID, DateTime ngay, decimal luongNgay)
        {
            string sql = "UPDATE Luong SET LuongCoBan = @Luong WHERE NhanVienID = @NhanVienID AND ThangNam = @Ngay";

            SqlParameter[] parameters = {
                new SqlParameter("@Luong", luongNgay),
                new SqlParameter("@NhanVienID", nhanVienID),
                new SqlParameter("@Ngay", ngay)
            };

            MyExecuteNonQuery(sql, CommandType.Text, parameters);
        }


    }
}
