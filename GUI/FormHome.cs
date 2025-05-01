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
            this.Hide();
            FormOrder frmOrder = new FormOrder();
            frmOrder.FormClosed += (s, args) => this.Show();
            frmOrder.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoanhThu frmDoanhThu = new FormDoanhThu();
            frmDoanhThu.FormClosed += (s, args) => this.Show();
            frmDoanhThu.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChamCong frmChamCong = new FormChamCong();
            frmChamCong.FormClosed += (s, args) => this.Show();
            frmChamCong.Show();
            
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLy frmQuanLy = new FormQuanLy();
            frmQuanLy.FormClosed += (s, args) => this.Close();
            frmQuanLy.Show();
        }
    }
}
