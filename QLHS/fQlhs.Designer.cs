namespace QLHS
{
    partial class fQlhs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlhs));
            this.dgv_hocsinh = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_diem = new System.Windows.Forms.Button();
            this.btn_thongtin = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hocsinh
            // 
            this.dgv_hocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hocsinh.Location = new System.Drawing.Point(12, 51);
            this.dgv_hocsinh.Name = "dgv_hocsinh";
            this.dgv_hocsinh.Size = new System.Drawing.Size(537, 150);
            this.dgv_hocsinh.TabIndex = 2;
            this.dgv_hocsinh.Click += new System.EventHandler(this.dgv_hocsinh_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(12, 12);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(176, 20);
            this.txt_timkiem.TabIndex = 4;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(194, 12);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_diem
            // 
            this.btn_diem.Location = new System.Drawing.Point(312, 208);
            this.btn_diem.Name = "btn_diem";
            this.btn_diem.Size = new System.Drawing.Size(75, 23);
            this.btn_diem.TabIndex = 5;
            this.btn_diem.Text = "Điểm";
            this.btn_diem.UseVisualStyleBackColor = true;
            this.btn_diem.Click += new System.EventHandler(this.btn_diem_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.Location = new System.Drawing.Point(393, 208);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(75, 23);
            this.btn_thongtin.TabIndex = 6;
            this.btn_thongtin.Text = "Thông tin";
            this.btn_thongtin.UseVisualStyleBackColor = true;
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(474, 208);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // fQlhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 363);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_thongtin);
            this.Controls.Add(this.btn_diem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dgv_hocsinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQlhs";
            this.Text = "fQlhs";
            this.Load += new System.EventHandler(this.fQlhs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hocsinh;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_diem;
        private System.Windows.Forms.Button btn_thongtin;
        private System.Windows.Forms.Button btn_xoa;
    }
}