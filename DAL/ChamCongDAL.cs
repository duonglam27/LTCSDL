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
    public class ChamCongDAL:DataProvider
    {
        public int ChamCongVao(ChamCongDTO chamCong)
        {
            string sql = "INSERT INTO ChamCong (NhanVienID,Ngay, GioVao, GhiChu) " +
                         "VALUES (@NhanVienID,@Ngay, @GioVao, @GhiChu)";
            SqlParameter[] parameters = {
                new SqlParameter("@NhanVienID", chamCong.NhanVienID),
                new SqlParameter("@Ngay", chamCong.Ngay),
                new SqlParameter("@GioVao", chamCong.GioVao),
                new SqlParameter("@GhiChu", chamCong.GhiChu ?? "")
            };
            return MyExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public int ChamCongRa(int nhanVienID)
        {
            string sql = "UPDATE ChamCong SET GioRa = @GioRa " +
                         "WHERE NhanVienID = @NhanVienID " +
                         "AND GioRa IS NULL " +
                         "AND Ngay IS NOT NULL " + 
                         "AND CAST(Ngay AS DATE) = CAST(GETDATE() AS DATE)";  

            SqlParameter[] parameters = {
                new SqlParameter("@GioRa", DateTime.Now),  
                new SqlParameter("@NhanVienID", nhanVienID)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public bool KiemTraDaChamCongVao(int nhanVienID)
        {
            string sql = "SELECT COUNT(*) FROM ChamCong " +
                         "WHERE NhanVienID = @NhanVienID AND CONVERT(date, Ngay) = CONVERT(date, GETDATE())";

            SqlParameter[] parameters = {
                new SqlParameter("@NhanVienID", nhanVienID)
            };

            object result = MyExecuteScalar(sql, CommandType.Text, parameters);
            int count = Convert.ToInt32(result);
            return count > 0;
        }
        public ChamCongDTO GetChamCongVao(int nhanVienID)
        {
            string sql = @"SELECT * FROM ChamCong WHERE NhanVienID = @NhanVienID AND Ngay = @Ngay AND GioRa IS NULL";
            SqlParameter[] parameters = {
                new SqlParameter("@NhanVienID", nhanVienID),
                new SqlParameter("@Ngay", DateTime.Today)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new ChamCongDTO(
                        chamCongID: Convert.ToInt32(reader["ChamCongID"]),  
                        nhanVienID: Convert.ToInt32(reader["NhanVienID"]),  
                        ngay: Convert.ToDateTime(reader["Ngay"]),  
                        gioVao: Convert.ToDateTime(reader["GioVao"]), 
                        gioRa: reader["GioRa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["GioRa"]),  
                        ghiChu: reader["GhiChu"].ToString()  
                    );
                }
            }
            return null;
        }



        public List<ChamCongDTO> GetDanhSachChamCongDAL()
        {
            List<ChamCongDTO> danhSach = new List<ChamCongDTO>();
            string sql = "SELECT * FROM ChamCong";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int chamCongID = Convert.ToInt32(reader["ChamCongID"]);
                    int nhanVienID = Convert.ToInt32(reader["NhanVienID"]);
                    DateTime ngay = Convert.ToDateTime(reader["Ngay"]);
                    DateTime? gioVao = reader["GioVao"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["GioVao"]);
                    DateTime? gioRa = reader["GioRa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["GioRa"]);
                    string ghiChu = reader["GhiChu"].ToString();

                    ChamCongDTO chamCong = new ChamCongDTO(chamCongID, nhanVienID, ngay, gioVao, gioRa, ghiChu);
                    danhSach.Add(chamCong);
                }
            }
            return danhSach;
        }

        public List<ChamCongDTO> GetDanhSachChamCongBangIDDAL(int nhanVienID)
        {
            List<ChamCongDTO> danhSach = new List<ChamCongDTO>();
            string sql = "SELECT * FROM ChamCong WHERE NhanVienID = @NhanVienID";

            SqlParameter[] parameters = {
                new SqlParameter("@NhanVienID", nhanVienID)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    int chamCongID = Convert.ToInt32(reader["ChamCongID"]);
                    Convert.ToInt32(reader["NhanVienID"]);
                    DateTime ngay = Convert.ToDateTime(reader["Ngay"]);
                    DateTime? gioVao = reader["GioVao"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["GioVao"]);
                    DateTime? gioRa = reader["GioRa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["GioRa"]);
                    string ghiChu = reader["GhiChu"].ToString();

                    ChamCongDTO chamCong = new ChamCongDTO(chamCongID, nhanVienID, ngay, gioVao, gioRa, ghiChu);
                    danhSach.Add(chamCong);
                }
            }
            return danhSach;
        }


        public bool SuaChamCongDAL(ChamCongDTO chamCong)
        {
            string sql = "UPDATE ChamCong SET NhanVienID = @NhanVienID, Ngay = @Ngay, GioVao = @GioVao, GioRa = @GioRa, GhiChu = @GhiChu " +
                         "WHERE ChamCongID = @ChamCongID";

            SqlParameter[] parameters = {
                new SqlParameter("@ChamCongID", chamCong.ChamCongID),
                new SqlParameter("@NhanVienID", chamCong.NhanVienID),
                new SqlParameter("@Ngay", chamCong.Ngay),
                new SqlParameter("@GioVao", chamCong.GioVao ?? (object)DBNull.Value),
                new SqlParameter("@GioRa", chamCong.GioRa ?? (object)DBNull.Value),
                new SqlParameter("@GhiChu", chamCong.GhiChu ?? "")
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }

        public bool XoaChamCongDAL(int chamCongID)
        {
            string sql = "DELETE FROM ChamCong WHERE ChamCongID = @ChamCongID";

            SqlParameter[] parameters = {
                new SqlParameter("@ChamCongID", chamCongID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }
    }

}
