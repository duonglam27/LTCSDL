using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{

    public partial class FormDangKiKhachHang: Form
    {
        private KhachHangBLL khachHangBLL;

        public string SoDienThoai
        {
            get { return txtSDTKhachHang.Text; }
            set { txtSDTKhachHang.Text = value; }
        }

        public FormDangKiKhachHang()
        {
            InitializeComponent();
            khachHangBLL = new KhachHangBLL();
        }

        private void FormDangKiKhachHang_Load(object sender, EventArgs e)
        {
            

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtTenKhachHang.Text.Trim();
            string sdt = txtSDTKhachHang.Text.Trim();
            KhachHangDTO khachHang = khachHangBLL.KiemTraSDTKhachHang(sdt);

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và SĐT.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (khachHang != null)
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ketQua = khachHangBLL.ThemKhachHang(hoTen, sdt);

            if (ketQua)
            {
                MessageBox.Show("Đăng ký khách hàng thành công! Lần sau dùng số này để tích điểm ", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Có thể SĐT đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
