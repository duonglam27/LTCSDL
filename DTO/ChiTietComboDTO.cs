using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietComboDTO
    {
        public int ChiTietComboID { get; set; }
        public int ComboID { get; set; }

        public int MonID { get; set; }
        public int SoLuong { get; set; }

        public ChiTietComboDTO(int chiTietComboID, int comboID, int monID, int soLuong)
        {
            ChiTietComboID = chiTietComboID;
            ComboID = comboID;
            MonID = monID;
            SoLuong = soLuong;
        }
    }
}
