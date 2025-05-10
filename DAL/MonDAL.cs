using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MonDAL:DataProvider
    {
        public List<MonDTO> GetMonDAL()
        {
            List<MonDTO> danhsach = new List<MonDTO>();
            string sql = "SELECT * FROM dbo.Mon";

            using (SqlDataReader reader =MyExecuteReader(sql,CommandType.Text))
            {
                while (reader.Read())
                {
                    int MonID = Convert.ToInt32(reader["MonID"]);
                    string TenMon = reader["TenMon"].ToString();
                    int DanhMucID = Convert.ToInt32(reader["DanhMucID"]);
                    int Gia = Convert.ToInt32(reader["Gia"]);
                    MonDTO mon = new MonDTO(MonID, TenMon, DanhMucID, Gia);
                    danhsach.Add(mon);
                }
            }

                return danhsach;
        }

        public bool XoaMonDAL(int monID)
        { 
            string sql= "DELETE FROM Mon WHERE MonID = @MonID";
            SqlParameter[] parameters = {
                new SqlParameter("@MonID",monID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
                return rows > 0;
        }
    }
}
