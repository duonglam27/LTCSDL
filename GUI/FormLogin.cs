using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;


namespace GUI
{
    public partial class FormLogin: Form
    {
        private LoginBLL loginBLL;
        public FormLogin()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
        }
        private bool XacNhanThoat()
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dg == DialogResult.Yes;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (XacNhanThoat())
                Application.Exit();
        }

        public bool UserLogin(TaiKhoanDTO taikhoan)
        {
            try
            {
                return loginBLL.Login(taikhoan);
            }
            catch (SqlException ex)
            {

                throw;
            }
            return true;
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtTaiKhoan.Text.Trim();
            pass = txtMatKhau.Text;

            TaiKhoanDTO taikhoan = new TaiKhoanDTO(user, pass);
            if (UserLogin(taikhoan))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //string msg = "Sai ten tai khoan hoac mat khau";
                //DialogResult result =MessageBox.Show(msg,"Login",MessageBoxButtons.RetryCancel
            }
        }
    }
}
