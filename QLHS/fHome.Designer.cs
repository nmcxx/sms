namespace QLHS
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_submenu = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_xemdiem = new System.Windows.Forms.Button();
            this.btn_thongtin = new System.Windows.Forms.Button();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.btn_qllh = new System.Windows.Forms.Button();
            this.btn_qlgv = new System.Windows.Forms.Button();
            this.btn_qlhs = new System.Windows.Forms.Button();
            this.btn_qltk = new System.Windows.Forms.Button();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_childform = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pn_submenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_submenu);
            this.panel1.Controls.Add(this.btn_taikhoan);
            this.panel1.Controls.Add(this.btn_qllh);
            this.panel1.Controls.Add(this.btn_qlgv);
            this.panel1.Controls.Add(this.btn_qlhs);
            this.panel1.Controls.Add(this.btn_qltk);
            this.panel1.Controls.Add(this.btn_trangchu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pn_submenu
            // 
            this.pn_submenu.Controls.Add(this.btn_dangxuat);
            this.pn_submenu.Controls.Add(this.btn_xemdiem);
            this.pn_submenu.Controls.Add(this.btn_thongtin);
            this.pn_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_submenu.Location = new System.Drawing.Point(0, 318);
            this.pn_submenu.Name = "pn_submenu";
            this.pn_submenu.Size = new System.Drawing.Size(157, 141);
            this.pn_submenu.TabIndex = 6;
            this.pn_submenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_submenu_Paint);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 70);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(157, 35);
            this.btn_dangxuat.TabIndex = 2;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_xemdiem
            // 
            this.btn_xemdiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_xemdiem.Location = new System.Drawing.Point(0, 35);
            this.btn_xemdiem.Name = "btn_xemdiem";
            this.btn_xemdiem.Size = new System.Drawing.Size(157, 35);
            this.btn_xemdiem.TabIndex = 1;
            this.btn_xemdiem.Text = "Xem điểm";
            this.btn_xemdiem.UseVisualStyleBackColor = true;
            this.btn_xemdiem.Click += new System.EventHandler(this.btn_xemdiem_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongtin.Location = new System.Drawing.Point(0, 0);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(157, 35);
            this.btn_thongtin.TabIndex = 0;
            this.btn_thongtin.Text = "Thông tin";
            this.btn_thongtin.UseVisualStyleBackColor = true;
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_taikhoan.Image = global::QLHS.Properties.Resources.icon_user;
            this.btn_taikhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_taikhoan.Location = new System.Drawing.Point(0, 265);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(157, 53);
            this.btn_taikhoan.TabIndex = 5;
            this.btn_taikhoan.Text = "Tài khoản";
            this.btn_taikhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_taikhoan.UseVisualStyleBackColor = true;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // btn_qllh
            // 
            this.btn_qllh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qllh.Image = global::QLHS.Properties.Resources.icon_users;
            this.btn_qllh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_qllh.Location = new System.Drawing.Point(0, 212);
            this.btn_qllh.Name = "btn_qllh";
            this.btn_qllh.Size = new System.Drawing.Size(157, 53);
            this.btn_qllh.TabIndex = 4;
            this.btn_qllh.Text = "Quản lý lớp học";
            this.btn_qllh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_qllh.UseVisualStyleBackColor = true;
            this.btn_qllh.Click += new System.EventHandler(this.btn_qllh_Click);
            // 
            // btn_qlgv
            // 
            this.btn_qlgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qlgv.Image = global::QLHS.Properties.Resources.icon_user_md;
            this.btn_qlgv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_qlgv.Location = new System.Drawing.Point(0, 159);
            this.btn_qlgv.Name = "btn_qlgv";
            this.btn_qlgv.Size = new System.Drawing.Size(157, 53);
            this.btn_qlgv.TabIndex = 3;
            this.btn_qlgv.Text = "Quản lý giáo viên";
            this.btn_qlgv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_qlgv.UseVisualStyleBackColor = true;
            this.btn_qlgv.Click += new System.EventHandler(this.btn_qlgv_Click);
            // 
            // btn_qlhs
            // 
            this.btn_qlhs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qlhs.Image = global::QLHS.Properties.Resources.icon_graduation_cap;
            this.btn_qlhs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_qlhs.Location = new System.Drawing.Point(0, 106);
            this.btn_qlhs.Name = "btn_qlhs";
            this.btn_qlhs.Size = new System.Drawing.Size(157, 53);
            this.btn_qlhs.TabIndex = 2;
            this.btn_qlhs.Text = "Quản lý học sinh";
            this.btn_qlhs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_qlhs.UseVisualStyleBackColor = true;
            this.btn_qlhs.Click += new System.EventHandler(this.btn_qlhs_Click);
            // 
            // btn_qltk
            // 
            this.btn_qltk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qltk.Image = global::QLHS.Properties.Resources.phonebook;
            this.btn_qltk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_qltk.Location = new System.Drawing.Point(0, 53);
            this.btn_qltk.Name = "btn_qltk";
            this.btn_qltk.Size = new System.Drawing.Size(157, 53);
            this.btn_qltk.TabIndex = 1;
            this.btn_qltk.Text = "Quản lý tài khoản";
            this.btn_qltk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_qltk.UseVisualStyleBackColor = true;
            this.btn_qltk.Click += new System.EventHandler(this.btn_qltk_Click);
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_trangchu.Image = global::QLHS.Properties.Resources.homepage1;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_trangchu.Location = new System.Drawing.Point(0, 0);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(157, 53);
            this.btn_trangchu.TabIndex = 0;
            this.btn_trangchu.Text = "Trang chủ";
            this.btn_trangchu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_trangchu.UseVisualStyleBackColor = true;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_date);
            this.panel4.Controls.Add(this.lbl_time);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 51);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(65, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(52, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "labelngay";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(68, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(43, 13);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "labelgio";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 53);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pn_childform
            // 
            this.pn_childform.Location = new System.Drawing.Point(163, 59);
            this.pn_childform.Name = "pn_childform";
            this.pn_childform.Size = new System.Drawing.Size(581, 400);
            this.pn_childform.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 471);
            this.Controls.Add(this.pn_childform);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THPT Nguyễn Chí Thanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHome_FormClosing);
            this.Load += new System.EventHandler(this.fHome_Load);
            this.panel1.ResumeLayout(false);
            this.pn_submenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_submenu;
        private System.Windows.Forms.Button btn_xemdiem;
        private System.Windows.Forms.Button btn_thongtin;
        private System.Windows.Forms.Button btn_taikhoan;
        private System.Windows.Forms.Button btn_qllh;
        private System.Windows.Forms.Button btn_qlgv;
        private System.Windows.Forms.Button btn_qlhs;
        private System.Windows.Forms.Button btn_qltk;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_childform;
        private System.Windows.Forms.Timer timer1;
    }
}