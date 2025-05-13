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

        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            return hoaDonDAL.GetAllHoaDon();
        }
        public bool ThemHoaDonBLL(DateTime ngayLap, int banID, int tongTien, string trangThai, int nhanVienID, int khachHangID, string ghiChu)
        {
            return hoaDonDAL.ThemHoaDonDAL(ngayLap, banID, tongTien, trangThai, nhanVienID, khachHangID,ghiChu);
        }

        public List<DoanhThuTheoNgayDTO> GetDoanhThuTheoNgayBLL(int thang,int namthang)
        {
            return hoaDonDAL.GetDoanhThuTheoNgayDAL(thang,namthang);
        }

        public List<DoanhThuTheoNamDTO> GetDoanhThuTheoNamBLL(int nam)
        {
            return hoaDonDAL.GetDoanhThuTheoNamDAL(nam);
        }
        public bool CapNhatHoaDon(HoaDonDTO hoaDon)
        {
            return hoaDonDAL.CapNhatHoaDon(hoaDon);
        }

        public bool XoaHoaDon(int id)
        {
            return hoaDonDAL.XoaHoaDon(id);
        }
        public HoaDonDTO LayHoaDonTheoID(int id)
        {
            return hoaDonDAL.GetHoaDonByID(id);
        }

    }
}
