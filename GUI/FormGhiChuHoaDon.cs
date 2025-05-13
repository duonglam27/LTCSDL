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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class FormGhiChuHoaDon: Form
    {
        public int banID { get; private set; }
        public string ghiChu { get; private set; }
        public int khachHangID { get; private set; }
        private BanBLL banBLL;
        private KhachHangBLL khachHangBLL;
        public FormGhiChuHoaDon()
        {
            InitializeComponent();
            banBLL = new BanBLL();
            khachHangBLL = new KhachHangBLL();
        }

        private void GhiChuHoaDon_Load(object sender, EventArgs e)
        {
            LoadBan();
           
        }

        private void LoadBan()
        {
            cbbBan.DataSource = banBLL.GetBanBLL();
            cbbBan.DisplayMember = "TenBan";
            cbbBan.ValueMember = "BanID";

        }

        public void NhapSDTKhachHang()
        {
            string sdt = txtSDTKhachHang.Text.Trim();
            KhachHangDTO khachHang = khachHangBLL.KiemTraSDTKhachHang(sdt);

            if (khachHang != null)
            {
                this.khachHangID = khachHang.KhachHangID;
                MessageBox.Show($"Đã tìm thấy khách hàng: {khachHang.HoTen}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này. Bạn có muốn đăng ký khách hàng mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    FormDangKiKhachHang frmDangKy = new FormDangKiKhachHang();
                    frmDangKy.SoDienThoai = sdt;
                    frmDangKy.ShowDialog();
                        
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn không đăng ký. Tiếp tục với khách hàng ID = 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.khachHangID = 0;
                }
            }
        }

 


        private void btXacNhan_Click(object sender, EventArgs e)
        {
            this.banID = Convert.ToInt32(cbbBan.SelectedValue);
            NhapSDTKhachHang();
            this.ghiChu = txtGhiChu.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
