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
    public partial class FormQuanLy: Form
    {
        private DanhMucBLL danhMucBLL;
        private MonBLL monBLL;
        private CongThucBLL congThucBLL;
        private NguyenLieuBLL nguyenLieuBLL;
        public FormQuanLy()
        {
            InitializeComponent();
            danhMucBLL = new DanhMucBLL();
            monBLL = new MonBLL();
            congThucBLL = new CongThucBLL();
            nguyenLieuBLL = new NguyenLieuBLL();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadMon();
            LoadCongThuc();
            LoadNguyenLieu();
        }

        private void LoadDanhMuc()
        {
            dtgvDanhMucMon.DataSource = danhMucBLL.GetDanhMucBLL();
            cbbDanhMucIDMon.DataSource = danhMucBLL.GetDanhMucBLL();
            cbbDanhMucIDMon.ValueMember = "DanhMucID";
        }

        private void dtgvDanhMucMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvDanhMucMon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvDanhMucMon.SelectedRows[0];
                txtDanhMucID.Text = row.Cells["DanhMucID"].Value.ToString();
                txtTenDanhMuc.Text = row.Cells["TenDanhMuc"].Value.ToString();
                             
            }
        }

        private void btnThemDanhMucMon_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = txtTenDanhMuc.Text;
            bool themDanhMucMonThanhCong = danhMucBLL.ThemDanhMucBLL(tenDanhMuc);
            if (themDanhMucMonThanhCong)
            {
                MessageBox.Show("Thêm danh mục món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();
            }
        }

        private void btnXoaDanhMucMon_Click(object sender, EventArgs e)
        {
            if (dtgvDanhMucMon.SelectedRows.Count > 0)
            {
                int danhMucID = Convert.ToInt32(dtgvDanhMucMon.SelectedRows[0].Cells["DanhMucID"].Value);
                DialogResult result = MessageBox.Show("Bạn chắc muốn xoá chứ ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool xoaDanhMucMonThanhCong = danhMucBLL.XoaDanhMucBLL(danhMucID);
                    if (xoaDanhMucMonThanhCong)
                    {
                        MessageBox.Show("Xoá danh mục món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Xoá danh mục món thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục món cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDanhMucMon_Click(object sender, EventArgs e)
        {
            
            if (dtgvDanhMucMon.SelectedRows.Count > 0)
            {
                int danhMucID = Convert.ToInt32(dtgvDanhMucMon.SelectedRows[0].Cells["DanhMucID"].Value);
                string tenDanhMuc = txtTenDanhMuc.Text.Trim();
                danhMucBLL.SuaDanhMucBLL(tenDanhMuc, danhMucID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục món cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDanhMuc();
            }
            
        }

        private void btnXemDanhMucMon_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }








        public void LoadMon()
        {
            dtgvMon.DataSource = monBLL.GetMonBLL();
            cbbDanhMucIDMon.DataSource = danhMucBLL.GetDanhMucBLL();
            cbbDanhMucIDMon.ValueMember = "DanhMucID";
            
        }

        private void dtgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvMon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvMon.SelectedRows[0];
                txtMonID.Text = row.Cells["MonID"].Value.ToString();
                txtTenMon.Text = row.Cells["TenMon"].Value.ToString();

                int danhMucID = Convert.ToInt32(row.Cells["DanhMucID"].Value);
                cbbDanhMucIDMon.SelectedValue = danhMucID;

                txtGiaMon.Text = row.Cells["Gia"].Value.ToString();


            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            int danhMucID = Convert.ToInt32(cbbDanhMucIDMon.Text);
            int gia = Convert.ToInt32(txtGiaMon.Text);
            
            bool themMonThanhCong = monBLL.ThemMonBLL(tenMon, danhMucID, gia);
            if (themMonThanhCong)
            {
                MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMon();
            }
            
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dtgvMon.SelectedRows.Count>0)
            {
                int monID = Convert.ToInt32(dtgvMon.SelectedRows[0].Cells["MonID"].Value);
                DialogResult result = MessageBox.Show("Bạn chắc muốn xoá chứ ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {
                    bool xoaMonThanhCong = monBLL.XoaMonBLL(monID);
                    if (xoaMonThanhCong)
                    {
                        MessageBox.Show("Xoá món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMon(); 
                    }
                    else
                    {
                        MessageBox.Show("Xoá món thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            int monID = Convert.ToInt32(dtgvMon.SelectedRows[0].Cells["MonID"].Value);
            string tenMon = txtTenMon.Text;
            int danhMucID = Convert.ToInt32(cbbDanhMucIDMon.Text);
            int gia = Convert.ToInt32(txtGiaMon.Text);

            monBLL.SuaMonBLL(monID, tenMon, danhMucID, gia);
            LoadMon();
        }









        private void LoadCongThuc()
        {
            dtgvCongThuc.DataSource = congThucBLL.GetCongThucBLL();
            cbbMonIDCongThuc.DataSource = monBLL.GetMonBLL();
            cbbMonIDCongThuc.ValueMember = "MonID";
            cbbNguyenLieuIDCongThuc.DataSource = nguyenLieuBLL.GetNguyenLieuBLL();
            cbbNguyenLieuIDCongThuc.ValueMember = "NguyenLieuID";
           
        }
        private void dtgvCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCongThuc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvCongThuc.SelectedRows[0];
                txtCongThucID.Text = row.Cells["CongThucID"].Value.ToString();
                cbbMonIDCongThuc.SelectedValue = Convert.ToInt32(row.Cells["MonID"].Value);
                cbbNguyenLieuIDCongThuc.SelectedValue = Convert.ToInt32(row.Cells["NguyenLieuID"].Value);
                txtDinhLuong.Text = (row.Cells["DinhLuong"].Value).ToString();


            }
        }

        private void btnThemCongThuc_Click(object sender, EventArgs e)
        {
            int monID = Convert.ToInt32(cbbMonIDCongThuc.Text);
            int nguyenLieuID = Convert.ToInt32(cbbNguyenLieuIDCongThuc.Text);
            int dinhLuong = Convert.ToInt32(txtDinhLuong.Text);
            bool themCongThucThanhCong = congThucBLL.ThemCongThucBLL(monID,nguyenLieuID,dinhLuong);
            if (themCongThucThanhCong)
            {
                MessageBox.Show("Thêm công thức mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCongThuc();
            }

        }

        private void btnXoaCongThuc_Click(object sender, EventArgs e)
        {
            if (dtgvCongThuc.SelectedRows.Count > 0)
            {
                int congThucID = Convert.ToInt32(dtgvCongThuc.SelectedRows[0].Cells["CongThucID"].Value);
                bool xoaCongThucThanhCong = congThucBLL.XoaCongThucBLL(congThucID);
                if (xoaCongThucThanhCong)
                {
                    MessageBox.Show("Xoá Công Thức thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCongThuc();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hàng nào được chọn, vui lòng chọn hàng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void btnSuaCongThuc_Click(object sender, EventArgs e)
        {
            if (dtgvCongThuc.SelectedRows.Count > 0)
            {
                int congThucID = Convert.ToInt32(dtgvCongThuc.SelectedRows[0].Cells["CongThucID"].Value);
                int monID = Convert.ToInt32(cbbMonIDCongThuc.Text);
                int nguyenLieuID = Convert.ToInt32(cbbNguyenLieuIDCongThuc.Text);
                int dinhLuong = Convert.ToInt32(txtDinhLuong.Text);
                bool suaCongThucThanhCong = congThucBLL.SuaCongThucBLL(congThucID, monID, nguyenLieuID, dinhLuong);
                if (suaCongThucThanhCong)
                {

                    MessageBox.Show("Sửa Công Thức thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCongThuc();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hàng nào được chọn, vui lòng chọn hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void btnXemCongThuc_Click(object sender, EventArgs e)
        {
            LoadCongThuc();
        }







        private void LoadNguyenLieu()
        {
            dtgvNguyenLieu.DataSource = nguyenLieuBLL.GetNguyenLieuBLL();
        }

        private void dtgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvNguyenLieu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvNguyenLieu.SelectedRows[0];
                txtNguyenLieuID.Text = row.Cells["NguyenLieuID"].Value.ToString();
                txtTenNguyenLieu.Text = row.Cells["TenNguyenLieu"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
            }
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            string tenNguyenLieu = txtTenNguyenLieu.Text;
            string DonViTinh = txtDonViTinh.Text;
            bool themNguyenLieuThanhCong= nguyenLieuBLL.ThemNguyenLieuBLL(tenNguyenLieu, DonViTinh);
            if (themNguyenLieuThanhCong)
            {
                MessageBox.Show("Thêm Nguyên Liệu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNguyenLieu();
            }


        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (dtgvNguyenLieu.SelectedRows.Count > 0)
            {
                int nguyenLieuID = Convert.ToInt32(dtgvNguyenLieu.SelectedRows[0].Cells["NguyenLieuID"].Value);
                bool xoaNguyenLieuThanhCong = nguyenLieuBLL.XoaNguyenLieuBLL(nguyenLieuID);
                if (xoaNguyenLieuThanhCong)
                {
                    MessageBox.Show("Xoá Nguyên Liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNguyenLieu();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hàng nào được chọn, vui lòng chọn hàng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (dtgvNguyenLieu.SelectedRows.Count > 0)
            {
                int nguyenLieuID = Convert.ToInt32(dtgvNguyenLieu.SelectedRows[0].Cells["NguyenLieuID"].Value);
                string tenNguyenLieu = txtTenNguyenLieu.Text;
                string donViTinh = txtDonViTinh.Text;

                bool suaNguyenLieuThanhCong = nguyenLieuBLL.SuaNguyenLieuBLL(nguyenLieuID, tenNguyenLieu, donViTinh);
                if (suaNguyenLieuThanhCong)
                {
                    MessageBox.Show("Sửa Nguyên Liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNguyenLieu();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hàng nào được chọn, vui lòng chọn hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnXemNguyenLieu_Click(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        
    }
}
