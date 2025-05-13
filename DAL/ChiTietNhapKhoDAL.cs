using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ChiTietNhapKhoDAL : DataProvider
    {
        public List<ChiTietNhapKhoDTO> GetDanhSachChiTietNhapKho()
        {
            List<ChiTietNhapKhoDTO> danhSach = new List<ChiTietNhapKhoDTO>();
            string sql = "SELECT * FROM ChiTietNhapKho";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int chiTietID = Convert.ToInt32(reader["ChiTietNhapKhoID"]);
                    int nhapKhoID = Convert.ToInt32(reader["NhapKhoID"]);
                    int nguyenLieuID = Convert.ToInt32(reader["NguyenLieuID"]);
                    int soLuong = Convert.ToInt32(reader["SoLuong"]);
                    int giaNhap = Convert.ToInt32(reader["GiaNhap"]);

                    ChiTietNhapKhoDTO ct = new ChiTietNhapKhoDTO(chiTietID, nhapKhoID, nguyenLieuID, soLuong, giaNhap);
                    danhSach.Add(ct);
                }
            }

            return danhSach;
        }

        public bool ThemChiTietNhapKho(ChiTietNhapKhoDTO ct)
        {
            string sql = @"INSERT INTO ChiTietNhapKho (NhapKhoID, NguyenLieuID, SoLuong, GiaNhap) 
                           VALUES (@NhapKhoID, @NguyenLieuID, @SoLuong, @GiaNhap)";

            SqlParameter[] parameters = {
                new SqlParameter("@NhapKhoID", ct.NhapKhoID),
                new SqlParameter("@NguyenLieuID", ct.NguyenLieuID),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@GiaNhap", ct.GiaNhap)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool XoaChiTietNhapKho(int chiTietNhapKhoID)
        {
            string sql = "DELETE FROM ChiTietNhapKho WHERE ChiTietNhapKhoID = @ChiTietNhapKhoID";

            SqlParameter[] parameters = {
                new SqlParameter("@ChiTietNhapKhoID", chiTietNhapKhoID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool SuaChiTietNhapKho(ChiTietNhapKhoDTO ct)
        {
            string sql = @"UPDATE ChiTietNhapKho SET 
                            NhapKhoID = @NhapKhoID, 
                            NguyenLieuID = @NguyenLieuID, 
                            SoLuong = @SoLuong, 
                            GiaNhap = @GiaNhap 
                           WHERE ChiTietNhapKhoID = @ChiTietNhapKhoID";

            SqlParameter[] parameters = {
                new SqlParameter("@NhapKhoID", ct.NhapKhoID),
                new SqlParameter("@NguyenLieuID", ct.NguyenLieuID),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@GiaNhap", ct.GiaNhap),
                new SqlParameter("@ChiTietNhapKhoID", ct.ChiTietNhapKhoID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public List<ChiTietNhapKhoDTO> GetChiTietTheoNhapKhoID(int nhapKhoID)
        {
            List<ChiTietNhapKhoDTO> danhSach = new List<ChiTietNhapKhoDTO>();
            string sql = "SELECT * FROM ChiTietNhapKho WHERE NhapKhoID = @NhapKhoID";

            SqlParameter[] parameters = {
                new SqlParameter("@NhapKhoID", nhapKhoID)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    int chiTietID = Convert.ToInt32(reader["ChiTietNhapKhoID"]);
                    int nguyenLieuID = Convert.ToInt32(reader["NguyenLieuID"]);
                    int soLuong = Convert.ToInt32(reader["SoLuong"]);
                    int giaNhap = Convert.ToInt32(reader["GiaNhap"]);

                    ChiTietNhapKhoDTO ct = new ChiTietNhapKhoDTO(chiTietID, nhapKhoID, nguyenLieuID, soLuong, giaNhap);
                    danhSach.Add(ct);
                }
            }

            return danhSach;
        }
    }
}
