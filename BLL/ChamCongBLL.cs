using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChamCongBLL
    {
        private ChamCongDAL chamCongDAL = new ChamCongDAL();
        public bool DaChamCongVaoHomNay(int nhanVienID)
        {
            return chamCongDAL.KiemTraDaChamCongVao(nhanVienID);
        }

        public int ChamCongVao(int nhanVienID, string ghiChu = "")
        {
            if (!DaChamCongVaoHomNay(nhanVienID))
            {
                ChamCongDTO chamCong = new ChamCongDTO(
                    chamCongID: 0,
                    nhanVienID: nhanVienID,
                    ngay: DateTime.Today,
                    gioVao: DateTime.Now,
                    gioRa: null,
                    ghiChu: ghiChu
                );
                return chamCongDAL.ChamCongVao(chamCong);
            }
            return 0;
        }

        public int ChamCongRa(int nhanVienID)
        {
            return chamCongDAL.ChamCongRa(nhanVienID);
        }

        public List<ChamCongDTO> GetDanhSachChamCongBLL() 
        {
            return chamCongDAL.GetDanhSachChamCongDAL();
        }
        public List<ChamCongDTO> GetDanhSachChamCongBangIDBLL(int nhanVienID)
        {
            return chamCongDAL.GetDanhSachChamCongBangIDDAL( nhanVienID);
        }
    }
}
