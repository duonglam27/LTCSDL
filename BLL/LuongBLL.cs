using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LuongBLL
    {
        private LuongDAL luongDAL = new LuongDAL();

        public List<LuongDTO> LayTatCaLuong()
        {
            return luongDAL.GetAllLuongDAL();
        }
        public List<LuongDTO> LayTatCaLuongTheoID(int nhanVienID)
        {
            return luongDAL.GetAllLuongDALTheoID(nhanVienID);
        }

        public List<LuongDTO> LayLuongTheoThangNam(int thangNam, int nhanVienID)
        {
            return luongDAL.GetLuongTheoThangNam(thangNam,nhanVienID);
        }

        public bool ThemLuong(LuongDTO luong)
        {
            return luongDAL.ThemLuongDAL(luong);
        }

        public bool CapNhatLuong(LuongDTO luong)
        {
            return luongDAL.SuaLuongDAL(luong);
        }

        public bool XoaLuong(int luongID)
        {
            return luongDAL.XoaLuongDAL(luongID);
        }
    }
}
