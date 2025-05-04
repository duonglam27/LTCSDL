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
    }
}
