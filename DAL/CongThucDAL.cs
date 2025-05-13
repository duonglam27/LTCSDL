using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace DAL
{
    public class CongThucDAL:DataProvider
    {
        public List<CongThucDTO> GetCongThucDAL()
        {
            List<CongThucDTO> danhSach = new List<CongThucDTO>();
            string sql = "SELECT * FROM dbo.CongThuc ";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int congThucID = Convert.ToInt32(reader["CongThucID"]);
                    int monID = Convert.ToInt32(reader["MonID"]);
                    int nguyenLieuID = Convert.ToInt32(reader["NguyenLieuID"]);
                    int dinhLuong = Convert.ToInt32(reader["DinhLuong"]);
                    CongThucDTO congThuc =new CongThucDTO(congThucID,monID,nguyenLieuID,dinhLuong);
                    danhSach.Add(congThuc);
                }
            }
            return danhSach;
        }

        public bool ThemCongThuccDAL(int monID, int nguyenLieuID,int dinhLuong)
        {
            string sql = "INSERT INTO CongThuc (monID,nguyenLieuID,dinhLuong) VALUES (@MonID,@NguyenLieuID,@DinhLuong)";
            SqlParameter[] parameters = {
                new SqlParameter("@MonID",monID),
                new SqlParameter("@NguyenLieuID",nguyenLieuID),
                new SqlParameter("@DinhLuong",dinhLuong)
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd > 0;
        }

        public bool XoaCongThucDAL(int congThucID)
        {
            string sql = "DELETE FROM CongThuc WHERE CongThucID = @CongThucID";
            SqlParameter[] parameters = {
                new SqlParameter("@CongThucID",congThucID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }
        public bool SuaCongThucDAL(int congThucID,int monID, int nguyenLieuID, int dinhLuong)
        {
            string sql = "UPDATE CongThuc SET MonID=@MonID,NguyenLieuID=@NguyenLieuID,DinhLuong=@DinhLuong WHERE CongThucID=@CongThucID";
            SqlParameter[] parameters = {
                new SqlParameter("CongThucID",congThucID),
                new SqlParameter("@MonID",monID),
                new SqlParameter("@NguyenLieuID",nguyenLieuID),
                new SqlParameter("@DinhLuong",dinhLuong)
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd > 0;
        }

        public List<CongThucDTO> GetNguyenLieuTheoMon(int monID)
        {
            List<CongThucDTO> list = new List<CongThucDTO>();
            string sql = "SELECT * FROM CongThuc WHERE MonID = @MonID";
            SqlParameter[] parameters = {
                new SqlParameter("@MonID", monID)
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    int congThucID = Convert.ToInt32(reader["CongThucID"]);
                    int nguyenLieuID = Convert.ToInt32(reader["NguyenLieuID"]);
                    int dinhLuong = Convert.ToInt32(reader["DinhLuong"]);
                    CongThucDTO ct = new CongThucDTO(congThucID, monID, nguyenLieuID, dinhLuong);
                    list.Add(ct);
                }
            }

            return list;
        }
    }
}
