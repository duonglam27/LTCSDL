using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormLuong : Form
    {
        private LuongBLL luongBLL;

        public FormLuong()
        {
            InitializeComponent();
            luongBLL = new LuongBLL();
        }

        private void FormLuong_Load(object sender, EventArgs e)
        {
            dtgvLuong.DataSource = luongBLL.LayTatCaLuongTheoID(Session.NhanVienID);
        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNam.Text))
            {
                int nam;
                if (int.TryParse(txtNam.Text, out nam))
                {
                    if (nam > 1900 && nam <= DateTime.Now.Year)
                    {
                        List<LuongDTO> dsLuong = luongBLL.LayLuongTheoThangNam(nam,Session.NhanVienID);
                        dtgvLuong.DataSource = dsLuong;
                        chartLuong.Series.Clear();  
                        Series series = new Series("Lương");
                        series.ChartType = SeriesChartType.Column;
                        chartLuong.Series.Add(series);
                        foreach (var item in dsLuong)
                        {
                            chartLuong.Series["Lương"].Points.AddXY(item.ThangNam.ToString("MM/yyyy"), item.TongLuong);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Năm không hợp lệ. Vui lòng nhập năm từ 1900 đến hiện tại.");
                    }
                }
                else
                {
                    MessageBox.Show("Năm không hợp lệ, vui lòng nhập số!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm để thống kê.");
            }
        }
    }
}
