using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class KhoTonDAL:DataProvider
    {
        public List<KhoTonDTO> GetKhoTonDAL()
        {
            List<KhoTonDTO> list = new List<KhoTonDTO>();
            string sql = "SELECT * FROM KhoTon";

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text))
            {
                while (reader.Read())
                {
                    int khoTonID = Convert.ToInt32(reader["KhoTonID"]);
                    int nguyenLieuID = Convert.ToInt32(reader["NguyenLieuID"]);
                    int soLuongTon = Convert.ToInt32(reader["SoLuongTon"]);

                    list.Add(new KhoTonDTO(khoTonID, nguyenLieuID, soLuongTon));
                }
            }

            return list;
        }

        public bool ThemKhoTonDAL(int nguyenLieuID, int soLuongTon)
        {
            string sql = "INSERT INTO KhoTon (NguyenLieuID, SoLuongTon) VALUES (@NguyenLieuID, @SoLuongTon)";
            SqlParameter[] parameters = {
                new SqlParameter("@NguyenLieuID", nguyenLieuID),
                new SqlParameter("@SoLuongTon", soLuongTon)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool CapNhatKhoTonDAL(int khoTonID, int soLuongTon)
        {
            string sql = "UPDATE KhoTon SET SoLuongTon = @SoLuongTon WHERE KhoTonID = @KhoTonID";
            SqlParameter[] parameters = {
                new SqlParameter("@KhoTonID", khoTonID),
                new SqlParameter("@SoLuongTon", soLuongTon)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool XoaKhoTonDAL(int khoTonID)
        {
            string sql = "DELETE FROM KhoTon WHERE KhoTonID = @KhoTonID";
            SqlParameter[] parameters = {
                new SqlParameter("@KhoTonID", khoTonID)
            };

            int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return result > 0;
        }

        public bool TruNguyenLieu(int nguyenLieuID, int soLuongTru)
        {
            string sql = "UPDATE KhoTon SET SoLuongTon = SoLuongTon - @SoLuongTru " +
                         "WHERE NguyenLieuID = @NguyenLieuID AND SoLuongTon >= @SoLuongTru";

            SqlParameter[] parameters = {
            new SqlParameter("@SoLuongTru", soLuongTru),
            new SqlParameter("@NguyenLieuID", nguyenLieuID)
        };

            int rowsAffected = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rowsAffected > 0;
        }
        public bool CapNhatSoLuongTon(int nguyenLieuID, int soLuongThem)
        {
            string sql = "UPDATE KhoTon SET SoLuongTon = SoLuongTon + @SoLuongThem WHERE NguyenLieuID = @NguyenLieuID";

            SqlParameter[] parameters = {
                new SqlParameter("@SoLuongThem", soLuongThem),
                new SqlParameter("@NguyenLieuID", nguyenLieuID)
            };

            int rows = MyExecuteNonQuery(sql, CommandType.Text, parameters);
            return rows > 0;
        }


    }
}
