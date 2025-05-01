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


namespace GUI
{
    public partial class FormOrder: Form
    {
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
