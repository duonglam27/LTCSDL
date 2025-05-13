using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class NhapKhoBLL
    {
        private NhapKhoDAL nhapKhoDAL = new NhapKhoDAL();

        List<NhapKhoDTO> danhSach = new List<NhapKhoDTO>();

        public List<NhapKhoDTO> GetNhapKhoBLL()
        {
            return nhapKhoDAL.GetNhapKhoDAL();
        }

        public int ThemNhapKhoBLL(NhapKhoDTO nhapKho)
        {
            return nhapKhoDAL.ThemNhapKhoDAL(nhapKho);
        }

        public bool XoaNhapKhoDAL(int nhapKhoID)
        {
            return nhapKhoDAL.XoaNhapKhoDAL(nhapKhoID);
        }
        public bool SuaNhapKhoDAL(NhapKhoDTO nhapKho)
        {
            return nhapKhoDAL.SuaNhapKhoDAL(nhapKho);
        }
    }
}
