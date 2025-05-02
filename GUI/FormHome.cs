using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHome: Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormOrder frmOrder = new FormOrder();
            //frmOrder.FormClosed += (s, args) => this.Show();
            frmOrder.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhThu frmDoanhThu = new FormDoanhThu();
            frmDoanhThu.ShowDialog();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            FormChamCong frmChamCong = new FormChamCong();
            frmChamCong.ShowDialog();
            
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            FormQuanLy frmQuanLy = new FormQuanLy();
            frmQuanLy.ShowDialog();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {        
            FormThongTinCaNhan frmTTCN = new FormThongTinCaNhan();           
            frmTTCN.ShowDialog();
        }
    }
}
