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
    public class KhachHangDAL : DataProvider
    {
        public KhachHangDTO KiemTraSDTKhachHang(string sdt)
        {
            string sql = "SELECT KhachHangID, HoTen, SDT, DiemTichLuy " +
                         " FROM KhachHang WHERE  SDT= @SDT";

            SqlParameter[] parameters = {
                new SqlParameter("@SDT",sdt )
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new KhachHangDTO(
                        Convert.ToInt32(reader["KhachHangID"]),
                        reader["HoTen"].ToString(),
                        reader["SDT"].ToString(),
                        Convert.ToInt32(reader["DiemTichLuy"]));


                };
            }
            return null;
        }
        public bool CapNhatDiemTichLuy(int khachHangID, int diemCongThem)
        {
            string sql = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @DiemCongThem WHERE KhachHangID = @KhachHangID";

            SqlParameter[] parameters = {
                new SqlParameter("@DiemCongThem", diemCongThem),
                new SqlParameter("@KhachHangID", khachHangID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }

        public bool CapNhatDiemTichLuyTru(int khachHangID, int diemTru)
        {
            string sql = @"
                UPDATE KhachHang 
                SET DiemTichLuy = DiemTichLuy - @DiemTru 
                WHERE KhachHangID = @KhachHangID AND DiemTichLuy >= @DiemTru";

            SqlParameter[] parameters = {
                new SqlParameter("@DiemTru", diemTru),
                new SqlParameter("@KhachHangID", khachHangID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }

        public int LayDiemTichLuy(int khachHangID)
        {
            string sql = "SELECT DiemTichLuy FROM KhachHang WHERE KhachHangID = @KhachHangID";
            SqlParameter[] parameters = { new SqlParameter("@KhachHangID", khachHangID) };
            object result = MyExecuteScalar(sql, CommandType.Text, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }


        public List<KhachHangDTO> GetKhachHangDAL()
        {
            List<KhachHangDTO> danhSach = new List<KhachHangDTO>();
            string sql = "SELECT * FROM KhachHang";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["KhachHangID"]);
                    string hoTen = reader["HoTen"].ToString();
                    string sdt = reader["SDT"].ToString();
                    int diem = Convert.ToInt32(reader["DiemTichLuy"]);

                    KhachHangDTO kh = new KhachHangDTO(id, hoTen, sdt, diem);
                    danhSach.Add(kh);
                }
            }

            return danhSach;
        }

        public bool ThemKhachHangDAL(string hoTen, string sdt, int diemTichLuy)
        {
            string sql = "INSERT INTO KhachHang (HoTen, SDT, DiemTichLuy) VALUES (@HoTen, @SDT, @DiemTichLuy)";
            SqlParameter[] parameters = {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@DiemTichLuy", diemTichLuy)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool XoaKhachHangDAL(int khachHangID)
        {
            string sql = "DELETE FROM KhachHang WHERE KhachHangID = @KhachHangID";
            SqlParameter[] parameters = {
                new SqlParameter("@KhachHangID", khachHangID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool SuaKhachHangDAL(int khachHangID, string hoTen, string sdt, int diemTichLuy)
        {
            string sql = "UPDATE KhachHang SET HoTen = @HoTen, SDT = @SDT, DiemTichLuy = @DiemTichLuy WHERE KhachHangID = @KhachHangID";
            SqlParameter[] parameters = {
                new SqlParameter("@KhachHangID", khachHangID),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@DiemTichLuy", diemTichLuy)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        

    } 
}
