using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int TaiKhoanID { get; set; }
        public int NhanVienID { get; set; }
        public string Username { get; set; }
        public string PasswordHash  { get; set; }
        public string Role { get; set; }


    }
}
