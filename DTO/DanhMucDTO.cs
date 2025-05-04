using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucDTO
    {
        public int DanhMucID { get; set; }
        public string TenDanhMuc { get; set; }

        public DanhMucDTO(int danhMucID, string tenDanhMuc)
        {
            DanhMucID = danhMucID;
            TenDanhMuc = tenDanhMuc;
        }
    }
}
