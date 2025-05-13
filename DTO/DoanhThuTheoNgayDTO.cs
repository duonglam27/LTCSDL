using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThuTheoNgayDTO
    {
        public int Ngay { get; set; }
        public decimal DoanhThu { get; set; }

        public DoanhThuTheoNgayDTO(int ngay, decimal doanhThu)
        {
            Ngay = ngay;
            DoanhThu = doanhThu;
        }
    }
}
