using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class NguyenLieuDAL:DataProvider
    {
        public List<NguyenLieuDTO> GetNguyenLieuDAL()
        {
            List<NguyenLieuDTO> danhSach = new List<NguyenLieuDTO>();
            string sql = "SELECT * FROM dbo.NguyenLieu ";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int nguyenLieuID = Convert.ToInt32(reader["NguyenLieuID"]);
                    string tenNguyenLieu = reader["TenNguyenLieu"].ToString();
                    string donViTinh = reader["DonViTinh"].ToString();
                    NguyenLieuDTO nguyenLieu = new NguyenLieuDTO(nguyenLieuID,tenNguyenLieu,donViTinh);
                    danhSach.Add(nguyenLieu);
                }
            }
            return danhSach;
        }

        public bool ThemNguyenLieuDAL(string tenNguyenLieu, string donViTinh)
        {
            string sql = "INSERT INTO NguyenLieu (tenNguyenLieu,donViTinh) VALUES (@TenNguyenLieu,@DonViTinh)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenNguyenLieu",tenNguyenLieu),
                new SqlParameter("@DonViTinh",donViTinh)
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd > 0;
        }

        public bool XoaNguyenLieuDAL(int nguyenLieuID)
        {
            string sql = "DELETE FROM NguyenLieu WHERE NguyenLieuID = @NguyenLieuID";
            SqlParameter[] parameters = {
                new SqlParameter("@NguyenLieuID",nguyenLieuID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }
        public bool SuaNguyenLieuDAL(int nguyenLieuID,string tenNguyenLieu,string donViTinh)
        {
            string sql = "UPDATE NguyenLieu SET TenNguyenLieu=@TenNguyenLieu, DonViTinh=@DonViTinh WHERE NguyenLieuID=@NguyenLieuID";
            SqlParameter[] parameters = {
                new SqlParameter("NguyenLieuID",nguyenLieuID),
                new SqlParameter("@TenNguyenLieu",tenNguyenLieu),
                new SqlParameter("@DonViTinh",donViTinh)
            };
            int resultAdd = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return resultAdd > 0;
        }
    }
}
