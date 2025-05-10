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
        public FormQuanLy()
        {
            InitializeComponent();
            danhMucBLL = new DanhMucBLL();
            monBLL = new MonBLL();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadMon();
        }

        private void LoadDanhMuc()
        {
            dtgvDanhMucMon.DataSource = danhMucBLL.getDanhMuc();
            cbbDanhMucIDMon.DataSource = danhMucBLL.getDanhMuc();
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
                LoadDanhMuc();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục món cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnXemDanhMucMon_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        public void LoadMon()
        {
            dtgvMon.DataSource = monBLL.getMonBLL();
            
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
                        LoadMon(); // Refresh lại danh sách món
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

        
    }
}
