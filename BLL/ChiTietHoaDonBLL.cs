using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
   public  class ChiTietHoaDonBLL
    {
        private ChiTietHoaDonDAL chiTietHoaDonDAL;
        public ChiTietHoaDonBLL()
        {
            chiTietHoaDonDAL = new ChiTietHoaDonDAL();
        }

        public List<ChiTietHoaDonDTO> LayTatCaChiTiet()
        {
            return chiTietHoaDonDAL.GetAllChiTietHoaDon();
        }

        public List<ChiTietHoaDonDTO> LayChiTietTheoHoaDonID(int hoaDonID)
        {
            return chiTietHoaDonDAL.GetChiTietByHoaDonID(hoaDonID);
        }
        public bool ThemChiTietHoaDonBLL(int hoaDonID, int monID, int soLuong, int donGia)
        {
            return chiTietHoaDonDAL.ThemChiTietHoaDonDAL(hoaDonID, monID, soLuong, donGia);
        }
        public bool XoaChiTiet(int chiTietID)
        {
            return chiTietHoaDonDAL.XoaChiTietHoaDon(chiTietID);
        }
    }
}
