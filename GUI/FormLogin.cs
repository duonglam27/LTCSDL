using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool XacNhanThoat()
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dg == DialogResult.Yes;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (XacNhanThoat())
                Application.Exit(); 
        }

    
       

        

    }
}
