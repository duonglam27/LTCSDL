using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietNhapKhoBLL
    {
        private ChiTietNhapKhoDAL chiTietNhapKhoDAL = new ChiTietNhapKhoDAL();

        public List<ChiTietNhapKhoDTO> LayDanhSachChiTietNhapKho()
        {
            return chiTietNhapKhoDAL.GetDanhSachChiTietNhapKho();
        }

        public List<ChiTietNhapKhoDTO> LayChiTietTheoNhapKhoID(int nhapKhoID)
        {
            return chiTietNhapKhoDAL.GetChiTietTheoNhapKhoID(nhapKhoID);
        }

        public bool ThemChiTietNhapKho(ChiTietNhapKhoDTO chiTiet)
        {
            return chiTietNhapKhoDAL.ThemChiTietNhapKho(chiTiet);
        }

        public bool XoaChiTietNhapKho(int chiTietNhapKhoID)
        {
            return chiTietNhapKhoDAL.XoaChiTietNhapKho(chiTietNhapKhoID);
        }

        public bool SuaChiTietNhapKho(ChiTietNhapKhoDTO chiTiet)
        {
            return chiTietNhapKhoDAL.SuaChiTietNhapKho(chiTiet);
        }
    }
}

