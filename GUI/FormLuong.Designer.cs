namespace GUI
{
    partial class FormLuong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnThongKeThang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chartLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgvLuong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.chartLuong);
            this.panel1.Controls.Add(this.dtgvLuong);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 426);
            this.panel1.TabIndex = 3;
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
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(74, 54);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(139, 22);
            this.txtNam.TabIndex = 9;
            this.txtNam.Text = "2025";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Năm";
            // 
            // chartLuong
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLuong.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartLuong.Legends.Add(legend4);
            this.chartLuong.Location = new System.Drawing.Point(3, 219);
            this.chartLuong.Name = "chartLuong";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartLuong.Series.Add(series4);
            this.chartLuong.Size = new System.Drawing.Size(549, 204);
            this.chartLuong.TabIndex = 8;
            this.chartLuong.Text = "Doanh thu theo tháng";
            // 
            // dtgvLuong
            // 
            this.dtgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuong.Location = new System.Drawing.Point(3, 3);
            this.dtgvLuong.Name = "dtgvLuong";
            this.dtgvLuong.RowHeadersWidth = 51;
            this.dtgvLuong.RowTemplate.Height = 24;
            this.dtgvLuong.Size = new System.Drawing.Size(549, 212);
            this.dtgvLuong.TabIndex = 0;
            // 
            // FormLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormLuong";
            this.Text = "FormLuong";
            this.Load += new System.EventHandler(this.FormLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnThongKeThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLuong;
        private System.Windows.Forms.DataGridView dtgvLuong;
    }
}