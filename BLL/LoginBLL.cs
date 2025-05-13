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
        public TaiKhoanDTO Login(string userName, string password)
        {
            return loginDAL.Login(userName,password);
        }
        public bool CapNhatMatKhauBLL(string username, string matKhauCu, string matKhauMoi)
        {
            return loginDAL.CapNhatMatKhauDAL(username, matKhauCu, matKhauMoi);
        }

    }
}
