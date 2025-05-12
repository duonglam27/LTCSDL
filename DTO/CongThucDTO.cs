using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongThucDTO
    {
        public int CongThucID { get; set; }
        public int MonID { get; set; }
        public int NguyenLieuID { get; set; }
        public int DinhLuong { get; set; }

        public CongThucDTO(int congThucID, int monID, int nguyenLieuID, int dinhLuong)
        {
            CongThucID = congThucID;
            MonID = monID;
            NguyenLieuID = nguyenLieuID;
            DinhLuong = dinhLuong;
        }
    }
}
