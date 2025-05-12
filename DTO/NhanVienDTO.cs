using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int NhanVienID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string PhongBan { get; set; }
        public string TrangThai { get; set; }

        public NhanVienDTO(int nhanVienID, string hoTen, DateTime ngaySinh, string email, string soDienThoai, string phongBan, string trangThai)
        {
            NhanVienID = nhanVienID;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            PhongBan = phongBan;
            TrangThai = trangThai;
        }
    }
}
