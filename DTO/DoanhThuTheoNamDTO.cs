using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThuTheoNamDTO
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal DoanhThu { get; set; }

        public DoanhThuTheoNamDTO(int thang, int nam, decimal doanhThu)
        {
            Thang = thang;
            Nam = nam;
            DoanhThu = doanhThu;
        }
    }
}
