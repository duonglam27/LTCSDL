using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormThongTinCaNhan: Form
    {
        private LoginBLL loginBLL;
        private NhanVienBLL nhanVienBLL;
        public FormThongTinCaNhan()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
            nhanVienBLL = new NhanVienBLL();
        }

        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadThongTinTheoID();
            txtTaiKhoan.Text = Session.Username;

        }

        private void LoadThongTinTheoID()
        {
            NhanVienDTO nhanVien = nhanVienBLL.GetNhanVienByIDBLL(Session.NhanVienID);
            if (nhanVien != null)
            {
                txtNhanVienID.Text = nhanVien.NhanVienID.ToString();
                txtHoTen.Text = nhanVien.HoTen;
                txtNgaySinh.Text = nhanVien.NgaySinh.ToString("dd/MM/yyyy");
                txtEmail.Text = nhanVien.Email;
                txtSoDienThoai.Text = nhanVien.SoDienThoai;
                txtPhongBan.Text = nhanVien.PhongBan;
                txtTrangThai.Text = nhanVien.TrangThai;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên.");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            string password = txtMatKhau.Text.ToString();
            string newpass = txtMatKhauMoi.Text.ToString();
            string confirmpass = txtNhapLai.Text.ToString();
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(newpass) || string.IsNullOrEmpty(confirmpass))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để cập nhật!!!");
                return;
            }
            if (newpass != confirmpass)
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau!!!Cập nhật KHÔNG thành công");
                return;
            }
            bool thanhcong = loginBLL.CapNhatMatKhauBLL(Session.Username, password, newpass);
            if (thanhcong)
            {
                MessageBox.Show("Cập nhật mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ KHÔNG KHỚP!!! Cập nhật KHÔNG thành công");
            }

        }

        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            FormLuong frmLuong = new FormLuong();
            frmLuong.ShowDialog();
        }
    }
}
