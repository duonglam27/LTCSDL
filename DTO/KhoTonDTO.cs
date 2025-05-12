using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoTonDTO
    {
        public int KhoTonID { get; set; }
        public int NguyenLieuID { get; set; }
        public int SoLuongTon { get; set; }

        public KhoTonDTO(int khoTonID, int nguyenLieuID, int soLuongTon)
        {
            KhoTonID = khoTonID;
            NguyenLieuID = nguyenLieuID;
            SoLuongTon = soLuongTon;
        }
    }
}
