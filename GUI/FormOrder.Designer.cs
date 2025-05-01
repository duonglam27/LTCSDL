namespace GUI
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.FlowLayoutPanel flpMon;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDoiDiem;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnChonBan;
        private System.Windows.Forms.Button btnGhiChu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.flpMon = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDoiDiem = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnChonBan = new System.Windows.Forms.Button();
            this.btnGhiChu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.lbMonDaOrder = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder.Controls.Add(this.lbMonDaOrder);
            this.pnlOrder.Location = new System.Drawing.Point(10, 37);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(200, 356);
            this.pnlOrder.TabIndex = 0;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(10, 403);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(108, 16);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền: 0 VND";
            // 
            // cboLoai
            // 
            this.cboLoai.Location = new System.Drawing.Point(220, 38);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(150, 24);
            this.cboLoai.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(380, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 22);
            this.txtTimKiem.TabIndex = 3;
            // 
            // flpMon
            // 
            this.flpMon.AutoScroll = true;
            this.flpMon.Location = new System.Drawing.Point(220, 66);
            this.flpMon.Name = "flpMon";
            this.flpMon.Size = new System.Drawing.Size(600, 267);
            this.flpMon.TabIndex = 4;
            // 
            // btnDoiDiem
            // 
            this.btnDoiDiem.Location = new System.Drawing.Point(220, 340);
            this.btnDoiDiem.Name = "btnDoiDiem";
            this.btnDoiDiem.Size = new System.Drawing.Size(100, 36);
            this.btnDoiDiem.TabIndex = 5;
            this.btnDoiDiem.Text = "Đổi điểm";
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(330, 340);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(100, 36);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "Combo";
            // 
            // btnChonBan
            // 
            this.btnChonBan.Location = new System.Drawing.Point(440, 340);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(100, 36);
            this.btnChonBan.TabIndex = 7;
            this.btnChonBan.Text = "Bàn";
            // 
            // btnGhiChu
            // 
            this.btnGhiChu.Location = new System.Drawing.Point(550, 340);
            this.btnGhiChu.Name = "btnGhiChu";
            this.btnGhiChu.Size = new System.Drawing.Size(100, 36);
            this.btnGhiChu.TabIndex = 8;
            this.btnGhiChu.Text = "Ghi chú";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(660, 340);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Location = new System.Drawing.Point(660, 379);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 44);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnHOME
            // 
            this.btnHOME.Location = new System.Drawing.Point(720, 3);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(100, 34);
            this.btnHOME.TabIndex = 11;
            this.btnHOME.TabStop = false;
            this.btnHOME.Text = "HOME";
            this.btnHOME.UseVisualStyleBackColor = true;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // lbMonDaOrder
            // 
            this.lbMonDaOrder.AutoSize = true;
            this.lbMonDaOrder.Location = new System.Drawing.Point(44, 8);
            this.lbMonDaOrder.Name = "lbMonDaOrder";
            this.lbMonDaOrder.Size = new System.Drawing.Size(87, 16);
            this.lbMonDaOrder.TabIndex = 0;
            this.lbMonDaOrder.Text = "Món đã order";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(536, 37);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(61, 23);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 431);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.flpMon);
            this.Controls.Add(this.btnDoiDiem);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnChonBan);
            this.Controls.Add(this.btnGhiChu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThanhToan);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label lbMonDaOrder;
        private System.Windows.Forms.Button btnTim;
    }
}