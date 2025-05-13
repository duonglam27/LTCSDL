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
using System.Windows.Forms.DataVisualization.Charting;

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

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
          
        }

        private void LoadDoanhThuNgay()
        {
            if (!string.IsNullOrWhiteSpace(txtNamThang.Text)&& !string.IsNullOrWhiteSpace(txtThang.Text))
            {
                int namThang;
                int thang;
                if (int.TryParse(txtNamThang.Text, out namThang) && int.TryParse(txtThang.Text, out thang))
                {
                    List<DoanhThuTheoNgayDTO> dsDoanhThu = hoaDonBLL.GetDoanhThuTheoNgayBLL(thang,namThang);
                    dtgvDoanhThu.DataSource = dsDoanhThu;

                    chartDoanhThu.Series.Clear();
                    Series series = new Series("DoanhThu");
                    series.ChartType = SeriesChartType.Column;
                    chartDoanhThu.Series.Add(series);

                    foreach (var item in dsDoanhThu)
                    {
                        chartDoanhThu.Series["DoanhThu"].Points.AddXY($"{item.Ngay}", item.DoanhThu);
                    }
                }
                else
                {
                    MessageBox.Show("Năm hoặc tháng không hợp lệ, vui lòng nhập số!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm và tháng để thống kê");
            }
        }
        private void LoadDoanhThuNam()
        {
            if (!string.IsNullOrWhiteSpace(txtNam.Text))
            {
                int nam;
                if (int.TryParse(txtNam.Text, out nam))
                {
                    List<DoanhThuTheoNamDTO> dsDoanhThu = hoaDonBLL.GetDoanhThuTheoNamBLL(nam);
                    dtgvDoanhThu.DataSource = dsDoanhThu;

                    chartDoanhThu.Series.Clear();
                    Series series = new Series("DoanhThu");
                    series.ChartType = SeriesChartType.Column;
                    chartDoanhThu.Series.Add(series);

                    foreach (var item in dsDoanhThu)
                    {
                        chartDoanhThu.Series["DoanhThu"].Points.AddXY($"{item.Thang}/{item.Nam}", item.DoanhThu);
                    }
                }
                else
                {
                    MessageBox.Show("Năm không hợp lệ, vui lòng nhập số!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm để thống kê");
            }


        }

        

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            LoadDoanhThuNam();

        }

        private void btnThongKeTheoThang_Click(object sender, EventArgs e)
        {
            LoadDoanhThuNgay();
        }
    }
}
