using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL;
        public KhachHangBLL()
        {
            khachHangDAL = new KhachHangDAL();
        }

        public KhachHangDTO KiemTraSDTKhachHang(string sdt)
        {
            return khachHangDAL.KiemTraSDTKhachHang(sdt);
        }
        public bool CapNhatDiemTichLuy(int khachHangID, int diemCongThem)
        {
            return khachHangDAL.CapNhatDiemTichLuy(khachHangID, diemCongThem);
        }
        public bool CapNhatDiemTichLuyTruBLL(int khachHangID, int diemTru)
        {
            return khachHangDAL.CapNhatDiemTichLuyTru(khachHangID, diemTru);
        }

        public int LayDiemTichLuy(int khachHangID)
        {
            return khachHangDAL.LayDiemTichLuy(khachHangID);
        }

        public bool ThemKhachHang(string hoTen, string sdt, int diemTichLuy = 0)
        {
            return khachHangDAL.ThemKhachHangDAL(hoTen, sdt, diemTichLuy);
        }

        public bool XoaKhachHang(int khachHangID)
        {
            return khachHangDAL.XoaKhachHangDAL(khachHangID);
        }

        public bool SuaKhachHang(int khachHangID, string hoTen, string sdt, int diemTichLuy)
        {
            return khachHangDAL.SuaKhachHangDAL(khachHangID, hoTen, sdt, diemTichLuy);
        }

        
       

    }
}
