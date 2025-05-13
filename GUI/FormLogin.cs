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

        
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtTaiKhoan.Text.Trim();
            pass = txtMatKhau.Text;
            TaiKhoanDTO ketQua=loginBLL.Login(user,pass);

            
            if (ketQua!=null)
            {                                                            
                Session.Username = ketQua.Username;
                Session.TaiKhoanID = ketQua.TaiKhoanID;
                Session.NhanVienID = ketQua.NhanVienID;
                Session.Role = ketQua.Role;

                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                string msg = "Sai ten tai khoan hoac mat khau";
                DialogResult result = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.RetryCancel,MessageBoxIcon.Question);
            }

            
        }
    }
}
