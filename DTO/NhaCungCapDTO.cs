using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public NhaCungCapDTO(int nhaCungCapID, string tenNhaCungCap, string diaChi, string soDienThoai, string email)
        {
            NhaCungCapID = nhaCungCapID;
            TenNhaCungCap = tenNhaCungCap;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }
    }
}
