using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL 
    {
        private NhanVienDAL nhanVienDAL;
        public NhanVienBLL()
        {
            nhanVienDAL = new NhanVienDAL();
        }
        public List<NhanVienDTO> GetAllNhanVienBLL()
        {
            return nhanVienDAL.GetAllNhanVienDAL();
        }
        public NhanVienDTO GetNhanVienByIDBLL(int nhanVienID)
        {
            return nhanVienDAL.GetNhanVienByIDDAL( nhanVienID);
        }

    }
}
