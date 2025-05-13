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
    public class KhachHangDAL : DataProvider
    {
        public KhachHangDTO KiemTraSDTKhachHang(string sdt)
        {
            string sql = "SELECT KhachHangID, HoTen, SDT, DiemTichLuy " +
                         " FROM KhachHang WHERE  SDT= @SDT";

            SqlParameter[] parameters = {
                new SqlParameter("@SDT",sdt )
            };

            using (SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    return new KhachHangDTO(
                        Convert.ToInt32(reader["KhachHangID"]),
                        reader["HoTen"].ToString(),
                        reader["SDT"].ToString(),
                        Convert.ToInt32(reader["DiemTichLuy"]));


                };
            }
            return null;
        }
    } 
}
