using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        public int NguyenLieuID { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }

        public NguyenLieuDTO(int nguyenLieuID, string tenNguyenLieu, string donViTinh)
        {
            NguyenLieuID = nguyenLieuID;
            TenNguyenLieu = tenNguyenLieu;
            DonViTinh = donViTinh;
        }
    }
}
