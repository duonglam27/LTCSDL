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
    public class DanhMucDAL: DataProvider
    {
        public List<DanhMucDTO> GetDanhMuc()
        {
            List<DanhMucDTO> danhSach = new List<DanhMucDTO>();
            string sql = "SELECT * FROM dbo.DanhMucMon ";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int danhMucID = Convert.ToInt32(reader["DanhMucID"]);
                    string tenDanhMuc = reader["TenDanhMuc"].ToString();
                    DanhMucDTO danhMuc = new DanhMucDTO(danhMucID, tenDanhMuc);
                    danhSach.Add(danhMuc);
                }
            }
                return danhSach;
        }

        public bool ThemDanhMucDAL(string tenDanhMuc)
        {
            string sql = "INSERT INTO DanhMucMon (tenDanhMuc) VALUES (@TenDanhMuc)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenDanhMuc",tenDanhMuc)
            };
            int resultAdd = MyExecuteNonQuery(sql,CommandType.Text,parameters);
            return resultAdd > 0;
        }

        public bool XoaDanhMucDAL(int danhMucID)
        {
            string sql = "DELETE FROM DanhMucMon WHERE DanhMucID = @DanhMucID";
            SqlParameter[] parameters = {
                new SqlParameter("@DanhMucID",danhMucID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }
        public bool SuaDanhMucDAL(string tenDanhMuc,int danhMucID)
        {
            string sql = "UPDATE DanhMucMon SET TenDanhMuc = @TenDanhMuc WHERE DanhMucID = @DanhMucID";
            SqlParameter[] parameters = {
                new SqlParameter("@TenDanhMuc",tenDanhMuc),
                new SqlParameter("@DanhMucID",danhMucID)          
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd>0;
        }
    }
}
