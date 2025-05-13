using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            return taiKhoanDAL.GetAllTaiKhoan();
        }

        public TaiKhoanDTO DangNhap(string username, string passwordHash)
        {
            return taiKhoanDAL.DangNhap(username, passwordHash);
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return taiKhoanDAL.ThemTaiKhoan(tk);
        }

        public bool DoiTrangThai(int taiKhoanID, bool trangThai)
        {
            return taiKhoanDAL.CapNhatTrangThai(taiKhoanID, trangThai);
        }
    }
}

