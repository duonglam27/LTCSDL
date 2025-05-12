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

    }
}
