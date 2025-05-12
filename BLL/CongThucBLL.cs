using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CongThucBLL
    {
        private CongThucDAL congThucDAL;
        public CongThucBLL()
        {
            congThucDAL = new CongThucDAL();
        }

        public List<CongThucDTO> GetCongThucBLL()
        {
            return congThucDAL.GetCongThucDAL();
        }

        public bool ThemCongThucBLL(int monID, int nguyenLieuID, int dinhLuong)
        {
            return congThucDAL.ThemCongThuccDAL(monID, nguyenLieuID,dinhLuong);
        }
        public bool XoaCongThucBLL(int congThucID)
        {
            return congThucDAL.XoaCongThucDAL(congThucID);
        }

        public bool SuaCongThucBLL(int congThucID, int monID, int nguyenLieuID, int gia)
        {
            return congThucDAL.SuaCongThucDAL(congThucID,monID,nguyenLieuID,gia);
        }
    }
}
