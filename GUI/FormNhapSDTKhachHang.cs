using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhapSDTKhachHang : Form
    {
        private KhachHangBLL khachHangBLL;
        public int KhachHangID { get; private set; } = 0; 

        public FormNhapSDTKhachHang()
        {
            InitializeComponent();
            khachHangBLL = new KhachHangBLL();
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO khachHang = khachHangBLL.KiemTraSDTKhachHang(sdt);

            if (khachHang != null)
            {
                KhachHangID = khachHang.KhachHangID;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với SĐT này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
