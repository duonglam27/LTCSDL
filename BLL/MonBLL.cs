using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class MonBLL
    {
        private MonDAL monDAL;
        public MonBLL()
        {
            monDAL = new MonDAL();
        }
        
        public List<MonDTO> GetMonBLL()
        {
            return monDAL.GetMonDAL();
        }

        public bool ThemMonBLL(string tenMon, int danhMucID, int gia)
        {
            return monDAL.ThemMonDAL(tenMon, danhMucID, gia);
        }
        public bool XoaMonBLL(int monID)
        {
            return monDAL.XoaMonDAL(monID);
        }

        public bool SuaMonBLL(int monID, string tenMon, int danhMucID, int gia)
        {
            return monDAL.SuaMonDAL(monID,tenMon,danhMucID,gia);
        }

        public List<MonDTO> TimMonTheoTenBLL(string tenMon)
        {
            return monDAL.TimMonTheoTenDAL(tenMon);
        }
        public List<MonDTO> TimMonTheoDanhMucBLL(int danhMucID)
        {
            return monDAL.TimMonTheoDanhMucDAL(danhMucID);
        }



    }
}
