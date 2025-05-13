using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class NhapKhoDAL:DataProvider
    {
        public List<NhapKhoDTO> GetNhapKhoDAL()
        {
            List<NhapKhoDTO> danhSach = new List<NhapKhoDTO>();
            string sql = "SELECT * FROM dbo.NhapKho";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int nhapKhoID = Convert.ToInt32(reader["NhapKhoID"]);
                    DateTime ngayNhap = Convert.ToDateTime(reader["NgayNhap"]);
                    int nhanVienID = Convert.ToInt32(reader["NhanVienID"]);
                    string ghiChu = reader["GhiChu"]?.ToString() ?? "";

                    NhapKhoDTO nhapKho = new NhapKhoDTO(nhapKhoID, ngayNhap, nhanVienID, ghiChu);
                    danhSach.Add(nhapKho);
                }
            }

            return danhSach;
        }

        public int ThemNhapKhoDAL(NhapKhoDTO nhapKho)
        {
            string sql = "INSERT INTO NhapKho (NgayNhap, NhanVienID, GhiChu) " +
                         "VALUES (@NgayNhap, @NhanVienID, @GhiChu); " +
                         "SELECT SCOPE_IDENTITY();";  

            SqlParameter[] parameters = {
                new SqlParameter("@NgayNhap", nhapKho.NgayNhap),
                new SqlParameter("@NhanVienID", nhapKho.NhanVienID),
                new SqlParameter("@GhiChu", nhapKho.GhiChu ?? "")
            };

            object result = MyExecuteScalar(sql, CommandType.Text, parameters);

            return result != null ? Convert.ToInt32(result) : -1;
        }

        public bool XoaNhapKhoDAL(int nhapKhoID)
        {
            string sql = "DELETE FROM NhapKho WHERE NhapKhoID = @NhapKhoID";

            SqlParameter[] parameters = {
                new SqlParameter("@NhapKhoID", nhapKhoID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool SuaNhapKhoDAL(NhapKhoDTO nhapKho)
        {
            string sql = "UPDATE NhapKho SET NgayNhap = @NgayNhap, NhanVienID = @NhanVienID, GhiChu = @GhiChu " +
                         "WHERE NhapKhoID = @NhapKhoID";

            SqlParameter[] parameters = {
                new SqlParameter("@NgayNhap", nhapKho.NgayNhap),
                new SqlParameter("@NhanVienID", nhapKho.NhanVienID),
                new SqlParameter("@GhiChu", nhapKho.GhiChu ?? ""),
                new SqlParameter("@NhapKhoID", nhapKho.NhapKhoID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }
    }
}
