using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCongDTO
    {
        public int ChamCongID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime? Ngay { get; set; }

        public DateTime? GioVao{ get; set; }
        public DateTime? GioRa { get; set; }
        public string GhiChu { get; set; }

        public ChamCongDTO(int chamCongID, int nhanVienID, DateTime ngay, DateTime? gioVao, DateTime? gioRa, string ghiChu)
        {
            ChamCongID = chamCongID;
            NhanVienID = nhanVienID;
            Ngay = ngay;
            GioVao = gioVao;
            GioRa = gioRa;
            GhiChu = ghiChu;
        }
    }
}
