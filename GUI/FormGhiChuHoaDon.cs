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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class FormGhiChuHoaDon: Form
    {
        public int banID { get; private set; }
        public string ghiChu { get; private set; }
        private BanBLL banBLL;
        public FormGhiChuHoaDon()
        {
            InitializeComponent();
            banBLL = new BanBLL();
        }

        private void GhiChuHoaDon_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void LoadBan()
        {
            cbbBan.DataSource = banBLL.GetBanBLL();
            cbbBan.DisplayMember = "TenBan";
            cbbBan.ValueMember = "BanID";

        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            this.banID = Convert.ToInt32(cbbBan.SelectedValue);
            this.ghiChu = txtGhiChu.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
