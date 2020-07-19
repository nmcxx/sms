namespace QLHS
{
    partial class fQltk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQltk));
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.lbl_tentaikhoan = new System.Windows.Forms.Label();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_loainguoidung = new System.Windows.Forms.Label();
            this.txt_tentaikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_loainguoidung = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(195, 15);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 0;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(12, 70);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.Size = new System.Drawing.Size(280, 150);
            this.dgv_taikhoan.TabIndex = 1;
            this.dgv_taikhoan.DoubleClick += new System.EventHandler(this.dgv_taikhoan_DoubleClick);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(13, 15);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(176, 20);
            this.txt_timkiem.TabIndex = 2;
            // 
            // lbl_tentaikhoan
            // 
            this.lbl_tentaikhoan.AutoSize = true;
            this.lbl_tentaikhoan.Location = new System.Drawing.Point(313, 86);
            this.lbl_tentaikhoan.Name = "lbl_tentaikhoan";
            this.lbl_tentaikhoan.Size = new System.Drawing.Size(73, 13);
            this.lbl_tentaikhoan.TabIndex = 3;
            this.lbl_tentaikhoan.Text = "Tên tài khoản";
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(313, 126);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(52, 13);
            this.lbl_matkhau.TabIndex = 4;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // lbl_loainguoidung
            // 
            this.lbl_loainguoidung.AutoSize = true;
            this.lbl_loainguoidung.Location = new System.Drawing.Point(313, 170);
            this.lbl_loainguoidung.Name = "lbl_loainguoidung";
            this.lbl_loainguoidung.Size = new System.Drawing.Size(83, 13);
            this.lbl_loainguoidung.TabIndex = 5;
            this.lbl_loainguoidung.Text = "Loại người dùng";
            // 
            // txt_tentaikhoan
            // 
            this.txt_tentaikhoan.Location = new System.Drawing.Point(396, 83);
            this.txt_tentaikhoan.Name = "txt_tentaikhoan";
            this.txt_tentaikhoan.Size = new System.Drawing.Size(171, 20);
            this.txt_tentaikhoan.TabIndex = 6;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(396, 123);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(171, 20);
            this.txt_matkhau.TabIndex = 7;
            // 
            // txt_loainguoidung
            // 
            this.txt_loainguoidung.Location = new System.Drawing.Point(396, 163);
            this.txt_loainguoidung.Name = "txt_loainguoidung";
            this.txt_loainguoidung.Size = new System.Drawing.Size(171, 20);
            this.txt_loainguoidung.TabIndex = 8;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(297, 197);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(396, 197);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(494, 197);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // fQltk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 363);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_loainguoidung);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tentaikhoan);
            this.Controls.Add(this.lbl_loainguoidung);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.lbl_tentaikhoan);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.btn_timkiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQltk";
            this.Text = "fQltk";
            this.Load += new System.EventHandler(this.fQltk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lbl_tentaikhoan;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_loainguoidung;
        private System.Windows.Forms.TextBox txt_tentaikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_loainguoidung;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}