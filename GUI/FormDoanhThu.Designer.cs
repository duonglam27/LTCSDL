namespace GUI
{
    partial class FormDoanhThu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNamThang = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThongKeThang = new System.Windows.Forms.Button();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.btnThongKeTheoThang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chartDoanhThu);
            this.panel1.Controls.Add(this.dtgvDoanhThu);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 426);
            this.panel1.TabIndex = 2;
            // 
            // txtNamThang
            // 
            this.txtNamThang.Location = new System.Drawing.Point(74, 52);
            this.txtNamThang.Name = "txtNamThang";
            this.txtNamThang.Size = new System.Drawing.Size(139, 22);
            this.txtNamThang.TabIndex = 11;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(74, 24);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(139, 22);
            this.txtThang.TabIndex = 10;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(74, 54);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(139, 22);
            this.txtNam.TabIndex = 9;
            this.txtNam.Text = "2025";
            // 
            // chartDoanhThu
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend3);
            this.chartDoanhThu.Location = new System.Drawing.Point(3, 219);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDoanhThu.Series.Add(series3);
            this.chartDoanhThu.Size = new System.Drawing.Size(549, 204);
            this.chartDoanhThu.TabIndex = 8;
            this.chartDoanhThu.Text = "Doanh thu theo tháng";
            // 
            // btnThongKeThang
            // 
            this.btnThongKeThang.Location = new System.Drawing.Point(13, 82);
            this.btnThongKeThang.Name = "btnThongKeThang";
            this.btnThongKeThang.Size = new System.Drawing.Size(200, 26);
            this.btnThongKeThang.TabIndex = 7;
            this.btnThongKeThang.Text = "Thống kê Năm";
            this.btnThongKeThang.UseVisualStyleBackColor = true;
            this.btnThongKeThang.Click += new System.EventHandler(this.btnThongKeThang_Click);
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.RowHeadersWidth = 51;
            this.dtgvDoanhThu.RowTemplate.Height = 24;
            this.dtgvDoanhThu.Size = new System.Drawing.Size(549, 212);
            this.dtgvDoanhThu.TabIndex = 0;
            // 
            // btnThongKeTheoThang
            // 
            this.btnThongKeTheoThang.Location = new System.Drawing.Point(13, 80);
            this.btnThongKeTheoThang.Name = "btnThongKeTheoThang";
            this.btnThongKeTheoThang.Size = new System.Drawing.Size(200, 26);
            this.btnThongKeTheoThang.TabIndex = 12;
            this.btnThongKeTheoThang.Text = "Thống kê Tháng";
            this.btnThongKeTheoThang.UseVisualStyleBackColor = true;
            this.btnThongKeTheoThang.Click += new System.EventHandler(this.btnThongKeTheoThang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Năm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNamThang);
            this.panel2.Controls.Add(this.btnThongKeTheoThang);
            this.panel2.Location = new System.Drawing.Point(558, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 143);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtNam);
            this.panel3.Controls.Add(this.btnThongKeThang);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(558, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 132);
            this.panel3.TabIndex = 15;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoanhThu";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.Button btnThongKeThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtNamThang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnThongKeTheoThang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}