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
            string sql = "SELECT * FROM dbo.Ban ";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int banID = Convert.ToInt32(reader["BanID"]);
                    string tenBan = reader["TenBan"].ToString();
                    string TrangThai = reader["TenBan"].ToString();
                    string Ghichu = reader["TenBan"].ToString();
                    BanDTO ban = new BanDTO(banID,tenBan,TrangThai,Ghichu);
                    danhSach.Add(ban);
                }
            }
            return danhSach;
        }
    }
}
