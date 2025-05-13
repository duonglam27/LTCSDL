namespace GUI
{
    partial class FormDangKiKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbnen = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMatKhau);
            this.panel2.Controls.Add(this.txtSDTKhachHang);
            this.panel2.Location = new System.Drawing.Point(197, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 43);
            this.panel2.TabIndex = 5;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(15, 11);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(85, 16);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Số điện thoại";
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Location = new System.Drawing.Point(126, 8);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtSDTKhachHang.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTaiKhoan);
            this.panel1.Controls.Add(this.txtTenKhachHang);
            this.panel1.Location = new System.Drawing.Point(197, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 43);
            this.panel1.TabIndex = 3;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(15, 13);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(31, 16);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tên";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(126, 8);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // lbnen
            // 
            this.lbnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnen.Location = new System.Drawing.Point(117, 54);
            this.lbnen.Name = "lbnen";
            this.lbnen.Size = new System.Drawing.Size(461, 43);
            this.lbnen.TabIndex = 4;
            this.lbnen.Text = "Đăng Kí Khách Hàng";
            this.lbnen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(414, 230);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(98, 29);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // FormDangKiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 313);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbnen);
            this.Controls.Add(this.btnDangKy);
            this.Name = "FormDangKiKhachHang";
            this.Text = "FormDangKiKhachHang";
            this.Load += new System.EventHandler(this.FormDangKiKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lbnen;
        private System.Windows.Forms.Button btnDangKy;
    }
}