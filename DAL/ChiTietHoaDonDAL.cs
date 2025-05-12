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


    }
}
