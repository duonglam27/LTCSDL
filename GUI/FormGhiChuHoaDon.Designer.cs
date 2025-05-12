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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMatKhau);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Location = new System.Drawing.Point(147, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 43);
            this.panel2.TabIndex = 4;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(15, 11);
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
            this.panel1.Location = new System.Drawing.Point(147, 48);
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
            this.btXacNhan.Location = new System.Drawing.Point(458, 169);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(98, 29);
            this.btXacNhan.TabIndex = 5;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // FormGhiChuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 234);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btXacNhan);
            this.Name = "FormGhiChuHoaDon";
            this.Text = "GhiChuHoaDon";
            this.Load += new System.EventHandler(this.GhiChuHoaDon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}