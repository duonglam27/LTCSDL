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

    }
}
