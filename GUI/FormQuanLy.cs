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

        public void LoadMon()
        {
            dtgvMon.DataSource = monBLL.getMonBLL();
            
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

        private void dtgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvMon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvMon.SelectedRows[0];
                txtMonID.Text= row.Cells["MonID"].Value.ToString();
                txtTenMon.Text = row.Cells["TenMon"].Value.ToString();

                int danhMucID = Convert.ToInt32(row.Cells["DanhMucID"].Value);
                cbbDanhMucIDMon.SelectedValue = danhMucID;

                txtGiaMon.Text = row.Cells["Gia"].Value.ToString();


            }
        }
        
    }
}
