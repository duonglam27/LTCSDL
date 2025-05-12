using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    { 
        public int KhuyenMaiID { get; set; }
        public string TenKhuyenMai { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public int GiamGia { get; set; }
        public string DieuKien { get; set; }

        public KhuyenMaiDTO(int khuyenMaiID, string tenKhuyenMai, DateTime ngayBatDau, DateTime ngayKetThuc, int giamGia, string dieuKien)
        {
            KhuyenMaiID = khuyenMaiID;
            TenKhuyenMai = tenKhuyenMai;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            GiamGia = giamGia;
            DieuKien = dieuKien;
        }
    }
}
