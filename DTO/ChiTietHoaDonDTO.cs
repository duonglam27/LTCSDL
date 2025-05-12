using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public int ChiTietHoaDonID { get; set; }
        public int HoaDonID { get; set; }
        public int MonID { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        

        public int ThanhTien
        {
            get { return SoLuong * DonGia; }
        }

        public ChiTietHoaDonDTO(int chiTietHoaDonID, int hoaDonID, int monID, int soLuong, int donGia)
        {
            ChiTietHoaDonID = chiTietHoaDonID;
            HoaDonID = hoaDonID;
            MonID = monID;
            SoLuong = soLuong;
            DonGia = donGia;
     
        }
        
    }
}
