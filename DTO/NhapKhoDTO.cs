using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapKhoDTO
    {
        public int NhapKhoID { get; set; }
        public DateTime NgayNhap { get; set; }

        public int NhanVienID { get; set; }
        public string GhiChu { get; set; }

        public NhapKhoDTO(int nhapKhoID, DateTime ngayNhap, int nhanVienID, string ghiChu)
        {
            NhapKhoID = nhapKhoID;
            NgayNhap = ngayNhap;
            NhanVienID = nhanVienID;
            GhiChu = ghiChu;
        }
    }
}
