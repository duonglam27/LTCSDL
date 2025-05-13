using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanDAL:DataProvider    
    {
        public List<BanDTO> GetBanDAL()
        {
            List<BanDTO> danhSach = new List<BanDTO>();
            string sql = "SELECT * FROM dbo.Ban";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int banID = Convert.ToInt32(reader["BanID"]);
                    string tenBan = reader["TenBan"].ToString();
                    string trangThai = reader["TrangThai"].ToString(); // Chỉnh sửa ở đây
                    string ghiChu = reader["GhiChu"].ToString(); // Chỉnh sửa ở đây
                    BanDTO ban = new BanDTO(banID, tenBan, trangThai, ghiChu);
                    danhSach.Add(ban);
                }
            }
            return danhSach;
        }


        public bool ThemBanDAL(string tenBan, string trangThai, string ghiChu)
        {
            string sql = "INSERT INTO Ban (TenBan, TrangThai, GhiChu) VALUES (@TenBan, @TrangThai, @GhiChu)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenBan", tenBan),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@GhiChu", ghiChu)
            };
            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }


        public bool SuaBanDAL(int banID, string tenBan, string trangThai, string ghiChu)
        {
            string sql = "UPDATE Ban SET TenBan = @TenBan, TrangThai = @TrangThai, GhiChu = @GhiChu WHERE BanID = @BanID";
            SqlParameter[] parameters = {
                new SqlParameter("@BanID", banID),
                new SqlParameter("@TenBan", tenBan),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@GhiChu", ghiChu)
            };
            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }

        public bool XoaBanDAL(int banID)
        {
            string sql = "DELETE FROM Ban WHERE BanID = @BanID";
            SqlParameter[] parameters = {
                new SqlParameter("@BanID", banID)
            };
            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }
        public bool CapNhatTrangThaiBan(int banID, string trangThai)
        {
            string sql = "UPDATE Ban SET TrangThai = @TrangThai WHERE BanID = @BanID";
            SqlParameter[] parameters = {
                new SqlParameter("@BanID", banID),
                new SqlParameter("@TrangThai", trangThai)
            };
            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }


    }
}
