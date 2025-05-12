using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int KhachHangID { get; set; }
        public string HoTen { get; set; }
        public string SDT{ get; set; }

        public int DiemTichLuy { get; set; }

        public KhachHangDTO(int khachHangID, string hoTen, string sDT, int diemTichLuy)
        {
            KhachHangID = khachHangID;
            HoTen = hoTen;
            SDT = sDT;
            DiemTichLuy = diemTichLuy;
        }
    }
}
