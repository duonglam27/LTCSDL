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

namespace GUI
{
    public partial class FormChamCong: Form
    {
        private ChamCongBLL chamCongBLL;
        int nhanVienID = Session.NhanVienID;
        public FormChamCong()
        {
            InitializeComponent();
            chamCongBLL = new ChamCongBLL();
            
        }
        private void FormChamCong_Load(object sender, EventArgs e)
        {
            LoadDanhSachCong();
        }

        private void btnChamCongVao_Click(object sender, EventArgs e)
        {
            if (chamCongBLL.ChamCongVao(nhanVienID) > 0)
            {
                MessageBox.Show("Đã chấm công vào ca.");
                LoadDanhSachCong();
            }
            else
            {
                MessageBox.Show("Bạn đã chấm công vào rồi!!! Chấm công vào thất bại.");
            }
           
        }

        private void btnChamCongRa_Click(object sender, EventArgs e)
        {
            if (chamCongBLL.ChamCongRa(nhanVienID) > 0)
            {
                MessageBox.Show("Đã chấm công ra ca.");
                LoadDanhSachCong();
            }
            else
            {
                MessageBox.Show("Bạn chưa chấm công vào hoặc đã chấm công đủ lần !!! Chấm công ra thất bại.");
            }

        }

        private void LoadDanhSachCong()
        {
            dtgvDSChamCong.DataSource = chamCongBLL.GetDanhSachChamCongBangIDBLL(nhanVienID);
        }

       
    }
}
