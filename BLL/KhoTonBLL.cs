using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class KhoTonBLL
    {
        private KhoTonDAL khoTonDAL;

        public KhoTonBLL()
        {
            khoTonDAL = new KhoTonDAL();
        }

        public List<KhoTonDTO> GetKhoTonBLL()
        {
            return khoTonDAL.GetKhoTonDAL();
        }

        public bool ThemKhoTonBLL(int nguyenLieuID, int soLuongTon)
        {
            return khoTonDAL.ThemKhoTonDAL(nguyenLieuID, soLuongTon);
        }

        public bool CapNhatKhoTonBLL(int khoTonID, int soLuongTon)
        {
            return khoTonDAL.CapNhatKhoTonDAL(khoTonID, soLuongTon);
        }

        public bool XoaKhoTonBLL(int khoTonID)
        {
            return khoTonDAL.XoaKhoTonDAL(khoTonID);
        }
    }
}
