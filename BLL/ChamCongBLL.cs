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
        private LuongDAL luongDAL = new LuongDAL();
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

        public decimal TinhLuong(DateTime? gioVao, DateTime gioRa)
        {
            if (gioVao.HasValue)
            {
                // Tính số giờ làm việc
                TimeSpan diff = gioRa - gioVao.Value;

                // Trả về số giờ làm việc (hoặc lương tùy theo logic bạn muốn)
                return (decimal)diff.TotalHours; // Trả về tổng số giờ làm việc
            }

            return 0;
        }


        public int ChamCongRa(int nhanVienID)
        {

            ChamCongDTO chamCong = chamCongDAL.GetChamCongVao(nhanVienID);

            if (chamCong != null)
            {
            
                DateTime gioRa = DateTime.Now;

      
                decimal luongNgay = TinhLuong(chamCong.GioVao, gioRa);

                luongDAL.CapNhatLuong(nhanVienID, DateTime.Today, luongNgay);

               
                chamCong.GioRa = gioRa;

          
                return chamCongDAL.ChamCongRa(nhanVienID);
            }

            return 0; 
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
