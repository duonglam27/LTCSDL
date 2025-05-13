using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietHoaDonDAL:DataProvider
    {
        public List<ChiTietHoaDonDTO> GetAllChiTietHoaDon()
        {
            List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();
            string sql = "SELECT * FROM ChiTietHoaDon";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO(
                        Convert.ToInt32(reader["ChiTietHoaDonID"]),
                        Convert.ToInt32(reader["HoaDonID"]),
                        Convert.ToInt32(reader["MonID"]),
                        Convert.ToInt32(reader["SoLuong"]),
                        Convert.ToInt32(reader["DonGia"])
                    );
                    list.Add(ct);
                }
            }
            return list;
        }

        public List<ChiTietHoaDonDTO> GetChiTietByHoaDonID(int hoaDonID)
        {
            List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();
            string sql = "SELECT * FROM ChiTietHoaDon WHERE HoaDonID = @HoaDonID";
            SqlParameter[] parameters = {
                new SqlParameter("@HoaDonID", hoaDonID)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO(
                        Convert.ToInt32(reader["ChiTietHoaDonID"]),
                        Convert.ToInt32(reader["HoaDonID"]),
                        Convert.ToInt32(reader["MonID"]),
                        Convert.ToInt32(reader["SoLuong"]),
                        Convert.ToInt32(reader["DonGia"])
                    );
                    list.Add(ct);
                }
            }

            return list;
        }

        public bool ThemChiTietHoaDonDAL(int hoaDonID, int monID, int soLuong, int donGia)
        {
            string sql = "INSERT INTO ChiTietHoaDon (HoaDonID, MonID, SoLuong, DonGia) " +
                         "VALUES (@HoaDonID, @MonID, @SoLuong, @DonGia)";

            SqlParameter[] parameters = {
                new SqlParameter("@HoaDonID", hoaDonID),
                new SqlParameter("@MonID", monID),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", donGia)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool ThemDanhSachChiTietDAL(int hoaDonID, List<ChiTietHoaDonDTO> danhSachChiTiet)
        {
            foreach (var ct in danhSachChiTiet)
            {
                bool result = ThemChiTietHoaDonDAL(hoaDonID, ct.MonID, ct.SoLuong, ct.DonGia);
                if (!result)
                    return false; // Nếu 1 dòng lỗi thì dừng
            }

            return true;
        }
        public bool XoaChiTietHoaDon(int chiTietID)
        {
            string sql = "DELETE FROM ChiTietHoaDon WHERE ChiTietHoaDonID = @ChiTietHoaDonID";
            SqlParameter[] parameters = {
                new SqlParameter("@ChiTietHoaDonID", chiTietID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }


    }
}
