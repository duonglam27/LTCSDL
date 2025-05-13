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
    public class HoaDonDAL:DataProvider
    {

        public List<HoaDonDTO> GetAllHoaDon()
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            string sql = "SELECT * FROM HoaDon";
            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO(
                        Convert.ToInt32(reader["HoaDonID"]),
                        Convert.ToDateTime(reader["NgayLap"]),
                        Convert.ToInt32(reader["BanID"]),
                        Convert.ToInt32(reader["TongTien"]),
                        reader["TrangThai"].ToString(),
                        Convert.ToInt32(reader["NhanVienID"]),
                        Convert.ToInt32(reader["KhachHangID"]),
                        reader["GhiChu"]?.ToString() ?? ""
                    );
                    list.Add(hd);
                }
            }
            return list;
        }

        public bool ThemHoaDonDAL(DateTime ngayLap, int banID, int tongTien, string trangThai, int nhanVienID, int khachHangID,string ghiChu)
        {
            string sql = "INSERT INTO HoaDon (NgayLap, BanID, TongTien, TrangThai, NhanVienID, KhachHangID,GhiChu) " +
                         "VALUES (@NgayLap, @BanID, @TongTien, @TrangThai, @NhanVienID, @KhachHangID,@GhiChu)" +
                          "SELECT SCOPE_IDENTITY();";
            ;

            SqlParameter[] parameters = {
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@BanID", banID),
                new SqlParameter("@TongTien", tongTien),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@NhanVienID", nhanVienID),
                new SqlParameter("@KhachHangID", khachHangID),
                new SqlParameter("@GhiChu", ghiChu)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }
        public List<DoanhThuTheoNgayDTO> GetDoanhThuTheoNgayDAL(int thang,int namThang)
        {
            List<DoanhThuTheoNgayDTO> result = new List<DoanhThuTheoNgayDTO>();
            string sql = @"
                SELECT 
                DAY(NgayLap) AS Ngay,
                SUM(TongTien) AS DoanhThu
                FROM HoaDon
                WHERE TrangThai = N'Đã thanh toán' AND MONTH(NgayLap)=@Thang AND YEAR(NgayLap)=@Nam
                GROUP BY DAY(NgayLap)
                ORDER BY Ngay";

            SqlParameter[] parameters = {
                new SqlParameter("@Thang", thang),
                new SqlParameter("@Nam",namThang )
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    int ngay = Convert.ToInt32(reader["Ngay"]);
                    decimal doanhThu = Convert.ToDecimal(reader["DoanhThu"]);
                    DoanhThuTheoNgayDTO doanhThuu = new DoanhThuTheoNgayDTO(ngay, doanhThu);
                    result.Add(doanhThuu);
                }
            }
            return result;
        }


        public List<DoanhThuTheoNamDTO> GetDoanhThuTheoNamDAL(int nam)
        {
            List<DoanhThuTheoNamDTO> result = new List<DoanhThuTheoNamDTO>();
            string sql = @"
                SELECT 
                    MONTH(NgayLap) AS Thang,
                    YEAR(NgayLap) AS Nam,
                    SUM(TongTien) AS DoanhThu
                FROM HoaDon
                WHERE TrangThai = N'Đã thanh toán' AND YEAR(NgayLap)=@Nam
                GROUP BY YEAR(NgayLap), MONTH(NgayLap)
                ORDER BY Nam, Thang";

            SqlParameter[] parameters = {
                new SqlParameter("@Nam", nam)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    int thang = Convert.ToInt32(reader["Thang"]);
                    int namResult = Convert.ToInt32(reader["Nam"]);
                    decimal doanhThu = Convert.ToDecimal(reader["DoanhThu"]);
                    DoanhThuTheoNamDTO doanhThuu = new DoanhThuTheoNamDTO(thang, namResult, doanhThu);
                    result.Add(doanhThuu);
                }
            }
            return result;
        }

        public bool CapNhatHoaDon(HoaDonDTO hoaDon)
        {
            string sql = @"UPDATE HoaDon SET 
                           NgayLap = @NgayLap, 
                           BanID = @BanID,
                           TongTien = @TongTien,
                           TrangThai = @TrangThai,
                           NhanVienID = @NhanVienID,
                           KhachHangID = @KhachHangID,
                           GhiChu = @GhiChu
                           WHERE HoaDonID = @HoaDonID";

            SqlParameter[] parameters = {
                new SqlParameter("@NgayLap", hoaDon.NgayLap),
                new SqlParameter("@BanID", hoaDon.BanID),
                new SqlParameter("@TongTien", hoaDon.TongTien),
                new SqlParameter("@TrangThai", hoaDon.TrangThai),
                new SqlParameter("@NhanVienID", hoaDon.NhanVienID),
                new SqlParameter("@KhachHangID", hoaDon.KhachHangID),
                new SqlParameter("@GhiChu", hoaDon.GhiChu ?? ""),
                new SqlParameter("@HoaDonID", hoaDon.HoaDonID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool XoaHoaDon(int hoaDonID)
        {
            string sql = "DELETE FROM HoaDon WHERE HoaDonID = @HoaDonID";
            SqlParameter[] parameters = {
                new SqlParameter("@HoaDonID", hoaDonID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }
        public HoaDonDTO GetHoaDonByID(int id)
        {
            string sql = "SELECT * FROM HoaDon WHERE HoaDonID = @HoaDonID";
            SqlParameter[] parameters = {
                new SqlParameter("@HoaDonID", id)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new HoaDonDTO(
                        Convert.ToInt32(reader["HoaDonID"]),
                        Convert.ToDateTime(reader["NgayLap"]),
                        Convert.ToInt32(reader["BanID"]),
                        Convert.ToInt32(reader["TongTien"]),
                        reader["TrangThai"].ToString(),
                        Convert.ToInt32(reader["NhanVienID"]),
                        Convert.ToInt32(reader["KhachHangID"]),
                        reader["GhiChu"]?.ToString() ?? ""
                    );
                }
            }
            return null;
        }

    }
}

