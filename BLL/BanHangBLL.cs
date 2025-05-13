using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanHangBLL
    {
        private CongThucDAL congThucDAL = new CongThucDAL();
        private KhoTonDAL khoTonDAL = new KhoTonDAL();

        public bool TruNguyenLieuKhiBanMon(int monID, int soLuongMon)
        {
            var danhSachNguyenLieu = congThucDAL.GetNguyenLieuTheoMon(monID);

            foreach (var item in danhSachNguyenLieu)
            {
                int tongTru = item.DinhLuong * soLuongMon;
                bool daTru = khoTonDAL.TruNguyenLieu(item.NguyenLieuID, tongTru);
                if (!daTru)
                {
                    //không đủ nguyên liệu viết sau
                    return false;
                }
            }

            return true;
        }

    }
}
