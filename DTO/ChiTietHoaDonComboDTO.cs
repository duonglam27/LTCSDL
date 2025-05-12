using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonComboDTO
    {
        public int ChiTietHoaDonComboID{get;set;}
        public int HoaDonID { get; set; }
        public int ComboID { get; set; }

        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public ChiTietHoaDonComboDTO(int chiTietHoaDonComboID, int hoaDonID, int comboID, int soLuong, int donGia)
        {
            ChiTietHoaDonComboID = chiTietHoaDonComboID;
            HoaDonID = hoaDonID;
            ComboID = comboID;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
