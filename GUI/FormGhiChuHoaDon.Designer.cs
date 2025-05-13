namespace GUI
{
    partial class FormGhiChuHoaDon
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbBan = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMatKhau);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Location = new System.Drawing.Point(75, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 43);
            this.panel2.TabIndex = 4;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(15, 14);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(103, 16);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Ghi chú hoá đơn";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(196, 8);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(189, 22);
            this.txtGhiChu.TabIndex = 2;
            this.txtGhiChu.Text = "Thanh toán tiền mặt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbBan);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Location = new System.Drawing.Point(75, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 43);
            this.panel1.TabIndex = 3;
            // 
            // cbbBan
            // 
            this.cbbBan.FormattingEnabled = true;
            this.cbbBan.Location = new System.Drawing.Point(196, 10);
            this.cbbBan.Name = "cbbBan";
            this.cbbBan.Size = new System.Drawing.Size(189, 24);
            this.cbbBan.TabIndex = 1;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(15, 13);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(31, 16);
            this.lb.TabIndex = 0;
            this.lb.Text = "Bàn";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(877, 462);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(118, 61);
            this.btXacNhan.TabIndex = 5;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSDTKhachHang);
            this.panel3.Location = new System.Drawing.Point(75, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 43);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại KH";
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Location = new System.Drawing.Point(196, 8);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtSDTKhachHang.TabIndex = 2;
            // 
            // FormGhiChuHoaDon
            // 
            this.AcceptButton = this.btXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btXacNhan);
            this.Name = "FormGhiChuHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.GhiChuHoaDon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.ComboBox cbbBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
    }
}