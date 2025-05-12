using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int HoaDonID { get; set; }
        public DateTime NgayLap { get; set; }
        public int BanID { get; set; }

        public int TongTien { get; set; }
        public string TrangThai { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }

        public string GhiChu { get; set; }

        public HoaDonDTO(int hoaDonID, DateTime ngayLap, int banID, int tongTien, string trangThai, int nhanVienID, int khachHangID, string ghiChu)
        {
            HoaDonID = hoaDonID;
            NgayLap = ngayLap;
            BanID = banID;
            TongTien = tongTien;
            TrangThai = trangThai;
            NhanVienID = nhanVienID;
            KhachHangID = khachHangID;
            GhiChu = ghiChu;
        }
    }
}
