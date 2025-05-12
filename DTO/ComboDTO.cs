using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComboDTO
    {
        public int ComboID { get; set; }
        public string TenCombo { get; set; }

        public int Gia { get; set; }

        public ComboDTO(int comboID, string tenCombo, int gia)
        {
            ComboID = comboID;
            TenCombo = tenCombo;
            Gia = gia;
        }
    }
}
