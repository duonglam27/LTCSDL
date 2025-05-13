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
    public partial class FormDoanhThu: Form
    {
        private HoaDonBLL hoaDonBLL;
        public FormDoanhThu()
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
        }

        private void LoadDoanhThuNgay()
        {
            DateTime ngay = dtTuNgay.Value.Date;
            decimal doanhthuNgay=hoaDonBLL.TinhDoanhThuNgayBLL(ngay);
            txtDoanhThu.Text = doanhthuNgay.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDoanhThuNgay();
        }
    }
}
