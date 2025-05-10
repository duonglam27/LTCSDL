using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DanhMucBLL
    {
        private DanhMucDAL danhMucDAL;

        public DanhMucBLL()
        {
            danhMucDAL = new DanhMucDAL();
        }
        public List<DanhMucDTO> getDanhMuc()
        {
            return danhMucDAL.GetDanhMuc();
        }

        public bool ThemDanhMucBLL(string tenDanhMuc)
        {
            return danhMucDAL.ThemDanhMucDAL(tenDanhMuc);
        }
        public bool XoaDanhMucBLL(int danhMucID)
        {
            return danhMucDAL.XoaDanhMucDAL(danhMucID);
        }
        
        public bool SuaDanhMucBLL(string tenDanhMuc,int danhMucID)
        {
            return danhMucDAL.SuaDanhMucDAL(tenDanhMuc,danhMucID);
        }
    }
}
