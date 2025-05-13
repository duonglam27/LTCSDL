using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class FormOrder: Form
    {
        private DanhMucBLL danhMucBLL;
        private MonBLL monBLL;
        private ChiTietHoaDonBLL chiTietHoaDonBLL;
        private HoaDonBLL hoaDonBLL;
        private List<ChiTietHoaDonDTO> danhSachTam = new List<ChiTietHoaDonDTO>();



        public FormOrder()
        {
            InitializeComponent();
            danhMucBLL = new DanhMucBLL();
            monBLL = new MonBLL();
            hoaDonBLL = new HoaDonBLL();
            chiTietHoaDonBLL = new ChiTietHoaDonBLL();


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadMon();
        }

        private void LoadDanhMuc()
        {
            cbbDanhMucFormOrder.DataSource = danhMucBLL.GetDanhMucBLL();
            cbbDanhMucFormOrder.DisplayMember = "TenDanhMuc";
            cbbDanhMucFormOrder.ValueMember = "DanhMucID";
        }
        private void LoadMonTheoDanhMuc()
        {
            int danhMucID = Convert.ToInt32(cbbDanhMucFormOrder.SelectedValue.ToString());
            dtgvDSMon.DataSource = monBLL.TimMonTheoDanhMucBLL(danhMucID);
        }
        private void cbbDanhMucFormOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadMonTheoDanhMuc();
        }

        private void LoadMon()
        {
            dtgvDSMon.DataSource = monBLL.GetMonBLL();
        }
        private void LoadMonTheoTen()
        {
            string tenMon = txtTimKiem.Text.ToString();
            dtgvDSMon.DataSource = monBLL.TimMonTheoTenBLL(tenMon);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadMonTheoTen();
        }
        


        private void btnHOME_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            if (dtgvDSMon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDSMon.SelectedRows[0];
                int monID = Convert.ToInt32(row.Cells["MonID"].Value);
                string tenMon = row.Cells["TenMon"].Value.ToString();
                int soLuong = 1;//mặc định là 1 hồi sửa sau
                int donGia = Convert.ToInt32(row.Cells["Gia"].Value);

                ChiTietHoaDonDTO chiTiet = new ChiTietHoaDonDTO(0, 0, monID, soLuong, donGia);
                danhSachTam.Add(chiTiet);

                listBoxMonDaOrder.Items.Add($"{tenMon} - {donGia:N0} VND");  // hiển thị tạm vào ListBox bên trái (ds món đã chọn)
                int tongTien = danhSachTam.Sum(x => x.DonGia * x.SoLuong);
                lblTongTien.Text = "Tổng tiền:" +tongTien.ToString()+" VND";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachTam.Count == 0)
            {
                MessageBox.Show("Chưa có món nào để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormGhiChuHoaDon FrmGhiChuHoaDon = new FormGhiChuHoaDon();
            if (FrmGhiChuHoaDon.ShowDialog()==DialogResult.OK)
            {
                DateTime ngayLap = DateTime.Now;
                int banID = FrmGhiChuHoaDon.banID; //hồi sửa thành lấy từ combobox
                int tongTien = danhSachTam.Sum(x => x.DonGia * x.SoLuong);
                string trangThai = "Đã thanh toán";
                int nhanVienID = Session.NhanVienID; //hồi sửa sau
                int khachHangID = FrmGhiChuHoaDon.khachHangID; // hồi sửa sau
                string ghiChu = FrmGhiChuHoaDon.ghiChu;


                int hoaDonID = Convert.ToInt32(hoaDonBLL.ThemHoaDonBLL(ngayLap, banID, tongTien, trangThai, nhanVienID, khachHangID, ghiChu));

                if (hoaDonID > 0)
                {

                    foreach (var item in danhSachTam)
                    {
                        chiTietHoaDonBLL.ThemChiTietHoaDonBLL(hoaDonID, item.MonID, item.SoLuong, item.DonGia);
                    }

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxMonDaOrder.Items.Clear();
                    danhSachTam.Clear();
                    lblTongTien.Text = "Tổng tiền: 0 VND";
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy order?","Xác nhận hủy",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                listBoxMonDaOrder.Items.Clear();
                danhSachTam.Clear();
            }
        }
    }
}
