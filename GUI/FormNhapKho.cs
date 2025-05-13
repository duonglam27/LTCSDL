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
    public partial class FormNhapKho: Form
    {
        private NhapKhoBLL nhapKhoBLL = new NhapKhoBLL();
        private ChiTietNhapKhoBLL chitietnhapkhoBLL = new ChiTietNhapKhoBLL();
        private NguyenLieuBLL nguyenLieuBLL = new NguyenLieuBLL();
        private KhoTonBLL khoTonBLL = new KhoTonBLL();
        public FormNhapKho()
        {
            InitializeComponent();
            
        }
        private void FormNhapKho_Load(object sender, EventArgs e)
        {
            LoadNguyenLieuTuCBB();
            txtNhanVienID.Text = Session.NhanVienID.ToString();
        }
        private void LoadNguyenLieuTuCBB()
        {
            List<NguyenLieuDTO> nguyenLieuList = new NguyenLieuBLL().GetNguyenLieuBLL();
            cbbNguyenLieuIDCTNK.DataSource = nguyenLieuList;
            cbbNguyenLieuIDCTNK.DisplayMember = "TenNguyenLieu";
            cbbNguyenLieuIDCTNK.ValueMember = "NguyenLieuID";
        }




        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            string ghiChu = txtGhiChuNhapKho.Text.ToString();
            
            NhapKhoDTO nhapKho = new NhapKhoDTO(0, DateTime.Now, Session.NhanVienID, ghiChu);

            int nhapKhoID = nhapKhoBLL.ThemNhapKhoBLL(nhapKho);

            if (nhapKhoID > 0)
            {
                txtNhapKhoIDCTNK.Text = nhapKhoID.ToString();
                MessageBox.Show("Tạo phiếu nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tạo phiếu nhập thất bại!");
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtNhapKhoIDCTNK.Text) ||
                cbbNguyenLieuIDCTNK.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSoLuongCTNK.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhapCTNK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nhapKhoID = int.Parse(txtNhapKhoIDCTNK.Text);
            if (
                !int.TryParse(txtSoLuongCTNK.Text, out int soLuong) ||
                !int.TryParse(txtGiaNhapCTNK.Text, out int giaNhap) ||
                nhapKhoID <= 0 || soLuong <= 0 || giaNhap <= 0)
            {
                MessageBox.Show("Mã nhập kho, số lượng và giá nhập phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nguyenLieuID = Convert.ToInt32(cbbNguyenLieuIDCTNK.SelectedValue);

            ChiTietNhapKhoDTO chiTiet = new ChiTietNhapKhoDTO(0, nhapKhoID, nguyenLieuID, soLuong, giaNhap);

            bool ketQua = chitietnhapkhoBLL.ThemChiTietNhapKho(chiTiet);

            if (ketQua)
            {
                
                
                khoTonBLL.CongSoLuongTon(nguyenLieuID, soLuong);

                MessageBox.Show("Thêm chi tiết nhập kho thành công và đã cập nhật kho tồn!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongCTNK.Clear();
                txtGiaNhapCTNK.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
