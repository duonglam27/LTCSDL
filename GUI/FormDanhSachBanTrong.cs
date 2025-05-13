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
    
    public partial class FormDanhSachBanTrong: Form
    {
        private BanBLL banBLL;
        public FormDanhSachBanTrong()
        {
            InitializeComponent();
            banBLL = new BanBLL();
        }
        public void LayDanhSachBan()
        {
            List<BanDTO> danhSachBan = banBLL.GetBanBLL();
            dtgvBanTrong.DataSource = danhSachBan;
        }

        private void DanhSachBanTrong_Load(object sender, EventArgs e)
        {
            LayDanhSachBan();
        }

        private void btnHoanThanhNuoc_Click(object sender, EventArgs e)
        {
            if (dtgvBanTrong.SelectedRows.Count > 0)
            {
                int banID = Convert.ToInt32(dtgvBanTrong.SelectedRows[0].Cells["BanID"].Value);
                string tenBan = dtgvBanTrong.SelectedRows[0].Cells["BanID"].Value.ToString();

                  
                string trangThaiMoi = "Đã hoàn thành";  

                bool capNhatThanhCong = banBLL.CapNhatTrangThaiBan(banID , trangThaiMoi);  

                if (capNhatThanhCong)
                {
                    MessageBox.Show("Cập nhật bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachBan();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
