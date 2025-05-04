using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoginBLL
    {
        private LoginDAL loginDAL;
        public LoginBLL()
        {
            loginDAL = new LoginDAL();
        }
        public bool Login(TaiKhoanDTO taikhoan)
        {
            return loginDAL.Login(taikhoan);
        }
    }
}
