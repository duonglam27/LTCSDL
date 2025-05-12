using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NguyenLieuBLL
    {
        private NguyenLieuDAL nguyenLieuDAL;
        public NguyenLieuBLL()
        {
            nguyenLieuDAL = new NguyenLieuDAL();
        }
        public List<NguyenLieuDTO> GetNguyenLieuBLL()
        {
            return nguyenLieuDAL.GetNguyenLieuDAL();
        }

        public bool ThemNguyenLieuBLL(string tenNguyenLieu,string donViTinh)
        {
            return nguyenLieuDAL.ThemNguyenLieuDAL(tenNguyenLieu,donViTinh);
        }
        public bool XoaNguyenLieuBLL(int nguyenLieuID)
        {
            return nguyenLieuDAL.XoaNguyenLieuDAL(nguyenLieuID);
        }

        public bool SuaNguyenLieuBLL(int nguyenLieuID, string tenNguyenLieu, string donViTinh)
        {
            return nguyenLieuDAL.SuaNguyenLieuDAL(nguyenLieuID,tenNguyenLieu,donViTinh);
        }
    }
}
