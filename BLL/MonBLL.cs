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
        
        public List<MonDTO> getMonBLL()
        {
            return monDAL.GetMonDAL();
        }
        public bool XoaMonBLL(int monID)
        {
            return monDAL.XoaMonDAL(monID);
        }
    }
}
