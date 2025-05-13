namespace GUI
{
    partial class FormChamCong
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
            this.btnChamCongVao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDSChamCong = new System.Windows.Forms.DataGridView();
            this.btnChamCongRa = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChamCongVao
            // 
            this.btnChamCongVao.Location = new System.Drawing.Point(12, 363);
            this.btnChamCongVao.Name = "btnChamCongVao";
            this.btnChamCongVao.Size = new System.Drawing.Size(267, 75);
            this.btnChamCongVao.TabIndex = 0;
            this.btnChamCongVao.Text = "Chấm công vào";
            this.btnChamCongVao.UseVisualStyleBackColor = true;
            this.btnChamCongVao.Click += new System.EventHandler(this.btnChamCongVao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDSChamCong);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 331);
            this.panel1.TabIndex = 2;
            // 
            // dtgvDSChamCong
            // 
            this.dtgvDSChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSChamCong.Location = new System.Drawing.Point(12, 15);
            this.dtgvDSChamCong.Name = "dtgvDSChamCong";
            this.dtgvDSChamCong.RowHeadersWidth = 51;
            this.dtgvDSChamCong.RowTemplate.Height = 24;
            this.dtgvDSChamCong.Size = new System.Drawing.Size(748, 302);
            this.dtgvDSChamCong.TabIndex = 0;
            // 
            // btnChamCongRa
            // 
            this.btnChamCongRa.Location = new System.Drawing.Point(521, 363);
            this.btnChamCongRa.Name = "btnChamCongRa";
            this.btnChamCongRa.Size = new System.Drawing.Size(267, 75);
            this.btnChamCongRa.TabIndex = 1;
            this.btnChamCongRa.Text = "Chấm công ra";
            this.btnChamCongRa.UseVisualStyleBackColor = true;
            this.btnChamCongRa.Click += new System.EventHandler(this.btnChamCongRa_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 387);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // FormChamCong
            // 
            this.AcceptButton = this.btnChamCongVao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChamCongRa);
            this.Controls.Add(this.btnChamCongVao);
            this.Name = "FormChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChamCong";
            this.Load += new System.EventHandler(this.FormChamCong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamCongVao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChamCongRa;
        private System.Windows.Forms.DataGridView dtgvDSChamCong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}