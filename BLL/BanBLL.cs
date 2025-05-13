using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BanBLL
    {
        private BanDAL banDAL;
        public BanBLL()
        {
            banDAL = new BanDAL();
        }
        public List<BanDTO> GetBanBLL()
        {
            return banDAL.GetBanDAL();  
        }

        public bool ThemBanBLL(string tenBan, string trangThai, string ghiChu)
        {
            if (string.IsNullOrEmpty(tenBan))
            {
                throw new Exception("Tên bàn không được để trống.");
            }

            return banDAL.ThemBanDAL(tenBan, trangThai, ghiChu); 
        }

        public bool SuaBanBLL(int banID, string tenBan, string trangThai, string ghiChu)
        {
            if (string.IsNullOrEmpty(tenBan))
            {
                throw new Exception("Tên bàn không được để trống.");
            }

            return banDAL.SuaBanDAL(banID, tenBan, trangThai, ghiChu);  
        }

        public bool XoaBanBLL(int banID)
        {
            return banDAL.XoaBanDAL(banID);  
        }

        public bool CapNhatTrangThaiBan(int banID, string trangThai)
        {
            return banDAL.CapNhatTrangThaiBan(banID, trangThai);
        }
    }
}
