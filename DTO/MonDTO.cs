using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonDTO
    {
        public int MonID { get; set; }
        public string TenMon { get; set; }
        public int DanhMucID { get; set; }
        public int Gia { get; set; }

        public MonDTO(int monID, string tenMon, int danhMucID, int gia)
        {
            MonID = monID;
            TenMon = tenMon;
            DanhMucID = danhMucID;
            Gia = gia;
        }
    }
}
