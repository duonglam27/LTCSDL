using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL:DataProvider
    {
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

        public decimal TinhDoanhThuNgay(DateTime ngay)
        {
            string sql = "SELECT SUM(TongTien) FROM HoaDon WHERE CAST(NgayLap AS DATE) = @Ngay AND TrangThai = N'Đã thanh toán'";
            SqlParameter[] parameters = { new SqlParameter("@Ngay", ngay) };
            object result = MyExecuteScalar(sql, CommandType.Text, parameters);
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }


    }
}

