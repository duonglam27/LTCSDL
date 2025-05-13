using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongDTO
    {
        public int LuongID  {get;set;}
        public int NhanVienID { get; set; }
        public DateTime ThangNam { get; set; }

        public decimal LuongCoBan { get; set; }
        public decimal Thuong { get; set; }
        public decimal Phat { get; set; }
        public int TongLuong { get; set; }

        public LuongDTO(int luongID, int nhanVienID, DateTime thangNam, decimal luongCoBan, int thuong, int phat, int tongLuong)
        {
            LuongID = luongID;
            NhanVienID = nhanVienID;
            ThangNam = thangNam;
            LuongCoBan = luongCoBan;
            Thuong = thuong;
            Phat = phat;
            TongLuong = tongLuong;
        }
        
    }
}
