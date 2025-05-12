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

        public bool ThemMonDAL(string tenMon,int danhMucID,int gia)
        {

            string sql = "INSERT INTO Mon (tenMon,danhMucID,gia) VALUES (@TenMon,@DanhMucID,@Gia)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenMon",tenMon),
                new SqlParameter("@DanhMucID",danhMucID),
                new SqlParameter("@Gia",gia),
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd > 0;
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
        public bool SuaMonDAL(int monID, string tenMon, int danhMucID, int gia)
        {
            string sql = "UPDATE Mon SET TenMon = @TenMon, DanhMucID=@DanhMucID, Gia=@Gia WHERE MonID = @MonID";
            SqlParameter[] parameters = {
                new SqlParameter("@MonID",monID),
                new SqlParameter("@TenMon",tenMon),
                new SqlParameter("@DanhMucID",danhMucID),
                new SqlParameter("@Gia",gia)
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd > 0;
        }

        public List<MonDTO> TimMonTheoTenDAL(string tenMon)
        {
            List<MonDTO> danhsach = new List<MonDTO>();

            string sql = "SELECT * FROM dbo.Mon WHERE TenMon LIKE @TenMon";

            SqlParameter[] parameters = {
                new SqlParameter("@TenMon", "%" + tenMon + "%")  
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
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
 
        public List<MonDTO> TimMonTheoDanhMucDAL(int danhMucID)
        {
            List<MonDTO> danhsach = new List<MonDTO>();

            string sql = "SELECT * FROM dbo.Mon WHERE DanhMucID = @DanhMucID";

            SqlParameter[] parameters = {
                new SqlParameter("@DanhMucID", danhMucID)
                };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
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


    }
}
