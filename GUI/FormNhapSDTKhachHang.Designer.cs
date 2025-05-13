namespace GUI
{
    partial class FormNhapSDTKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbnen = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Location = new System.Drawing.Point(193, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 43);
            this.panel1.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(3, 8);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(288, 22);
            this.txtSDT.TabIndex = 1;
            // 
            // lbnen
            // 
            this.lbnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnen.Location = new System.Drawing.Point(89, 97);
            this.lbnen.Name = "lbnen";
            this.lbnen.Size = new System.Drawing.Size(461, 43);
            this.lbnen.TabIndex = 2;
            this.lbnen.Text = "Nhập SDT";
            this.lbnen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(409, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormNhapSDTKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 287);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbnen);
            this.Name = "FormNhapSDTKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapSDTKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbnen;
        private System.Windows.Forms.Button btnOK;
    }
}