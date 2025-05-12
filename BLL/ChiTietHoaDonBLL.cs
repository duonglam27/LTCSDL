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
        public bool ThemChiTietHoaDonBLL(int hoaDonID, int monID, int soLuong, int donGia)
        {
            return chiTietHoaDonDAL.ThemChiTietHoaDonDAL(hoaDonID, monID, soLuong, donGia);
        }
    }
}
