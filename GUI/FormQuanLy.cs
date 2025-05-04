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
    public partial class FormQuanLy: Form
    {
        private DanhMucBLL danhMucBLL;
        public FormQuanLy()
        {
            InitializeComponent();
            danhMucBLL = new DanhMucBLL();
        }

      
        private void LoadDanhMuc()
        {
            dtgvDanhMucMon.DataSource = danhMucBLL.getDanhMuc();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }
    }
}
