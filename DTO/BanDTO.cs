using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanDTO
    {
        public int BanID { get; set; }
        public string TenBan { get; set; }

        public string TrangThai{ get; set; }
        public string GhiChu { get; set; }

        public BanDTO(int banID, string tenBan, string trangThai, string ghiChu)
        {
            BanID = banID;
            TenBan = tenBan;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }
    }

}
