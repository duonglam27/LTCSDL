using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
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

        private void FormHome_Load(object sender, EventArgs e)
        {

            if (Session.Role == "Thu Ngân")
            {
                btnQuanLy.Visible = false;
            }
            lbWelcome.Text = "Chào "+Session.Username;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            FormOrder frmOrder = new FormOrder();
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
      
            Application.Restart();

        }
    }
}
