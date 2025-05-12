using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNhapKhoDTO
    {
        public int ChiTietNhapKhoID { get; set; }
        public int NhapKhoID { get; set; }

        public int NguyenLieuID { get; set; }

        public int SoLuong { get; set; }

        public int GiaNhap { get; set; }

        public ChiTietNhapKhoDTO(int chiTietNhapKhoID, int nhapKhoID, int nguyenLieuID, int soLuong, int giaNhap)
        {
            ChiTietNhapKhoID = chiTietNhapKhoID;
            NhapKhoID = nhapKhoID;
            NguyenLieuID = nguyenLieuID;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
        }
    }
}
