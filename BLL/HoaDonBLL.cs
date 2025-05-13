using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL hoaDonDAL;
        public HoaDonBLL()
        {
            hoaDonDAL = new HoaDonDAL();
        }
        public bool ThemHoaDonBLL(DateTime ngayLap, int banID, int tongTien, string trangThai, int nhanVienID, int khachHangID, string ghiChu)
        {
            return hoaDonDAL.ThemHoaDonDAL(ngayLap, banID, tongTien, trangThai, nhanVienID, khachHangID,ghiChu);
        }
        public decimal TinhDoanhThuNgayBLL(DateTime ngay)
        {
            return hoaDonDAL.TinhDoanhThuNgay(ngay);
        }


    }
}
