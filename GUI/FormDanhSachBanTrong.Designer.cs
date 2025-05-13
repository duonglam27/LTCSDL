namespace GUI
{
    partial class FormDanhSachBanTrong
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
            this.dtgvBanTrong = new System.Windows.Forms.DataGridView();
            this.btnHoanThanhNuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBanTrong
            // 
            this.dtgvBanTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanTrong.Location = new System.Drawing.Point(12, 12);
            this.dtgvBanTrong.Name = "dtgvBanTrong";
            this.dtgvBanTrong.RowHeadersWidth = 51;
            this.dtgvBanTrong.RowTemplate.Height = 24;
            this.dtgvBanTrong.Size = new System.Drawing.Size(837, 450);
            this.dtgvBanTrong.TabIndex = 0;
            // 
            // btnHoanThanhNuoc
            // 
            this.btnHoanThanhNuoc.Location = new System.Drawing.Point(555, 471);
            this.btnHoanThanhNuoc.Name = "btnHoanThanhNuoc";
            this.btnHoanThanhNuoc.Size = new System.Drawing.Size(294, 58);
            this.btnHoanThanhNuoc.TabIndex = 1;
            this.btnHoanThanhNuoc.Text = "Hoàn thành nước";
            this.btnHoanThanhNuoc.UseVisualStyleBackColor = true;
            this.btnHoanThanhNuoc.Click += new System.EventHandler(this.btnHoanThanhNuoc_Click);
            // 
            // FormDanhSachBanTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 541);
            this.Controls.Add(this.btnHoanThanhNuoc);
            this.Controls.Add(this.dtgvBanTrong);
            this.Name = "FormDanhSachBanTrong";
            this.Text = "DanhSachBanTrong";
            this.Load += new System.EventHandler(this.DanhSachBanTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanTrong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBanTrong;
        private System.Windows.Forms.Button btnHoanThanhNuoc;
    }
}