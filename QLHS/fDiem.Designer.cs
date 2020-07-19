namespace QLHS
{
    partial class fDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDiem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_hocky = new System.Windows.Forms.ComboBox();
            this.btn_xemhk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mahocsinh = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.dgv_diem = new System.Windows.Forms.DataGridView();
            this.btn_nhapdiem = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.cbb_monhoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.Items.AddRange(new object[] {
            resources.GetString("cbb_hocky.Items"),
            resources.GetString("cbb_hocky.Items1")});
            resources.ApplyResources(this.cbb_hocky, "cbb_hocky");
            this.cbb_hocky.Name = "cbb_hocky";
            // 
            // btn_xemhk
            // 
            resources.ApplyResources(this.btn_xemhk, "btn_xemhk");
            this.btn_xemhk.Name = "btn_xemhk";
            this.btn_xemhk.UseVisualStyleBackColor = true;
            this.btn_xemhk.Click += new System.EventHandler(this.btn_xemhk_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbl_mahocsinh
            // 
            resources.ApplyResources(this.lbl_mahocsinh, "lbl_mahocsinh");
            this.lbl_mahocsinh.Name = "lbl_mahocsinh";
            // 
            // lbl_hoten
            // 
            resources.ApplyResources(this.lbl_hoten, "lbl_hoten");
            this.lbl_hoten.Name = "lbl_hoten";
            // 
            // dgv_diem
            // 
            this.dgv_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_diem, "dgv_diem");
            this.dgv_diem.Name = "dgv_diem";
            // 
            // btn_nhapdiem
            // 
            resources.ApplyResources(this.btn_nhapdiem, "btn_nhapdiem");
            this.btn_nhapdiem.Name = "btn_nhapdiem";
            this.btn_nhapdiem.UseVisualStyleBackColor = true;
            this.btn_nhapdiem.Click += new System.EventHandler(this.btn_nhapdiem_Click);
            // 
            // btn_dong
            // 
            resources.ApplyResources(this.btn_dong, "btn_dong");
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // cbb_monhoc
            // 
            this.cbb_monhoc.FormattingEnabled = true;
            resources.ApplyResources(this.cbb_monhoc, "cbb_monhoc");
            this.cbb_monhoc.Name = "cbb_monhoc";
            // 
            // fDiem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_monhoc);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_nhapdiem);
            this.Controls.Add(this.dgv_diem);
            this.Controls.Add(this.lbl_hoten);
            this.Controls.Add(this.lbl_mahocsinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xemhk);
            this.Controls.Add(this.cbb_hocky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fDiem";
            this.Load += new System.EventHandler(this.fDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_hocky;
        private System.Windows.Forms.Button btn_xemhk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mahocsinh;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.DataGridView dgv_diem;
        private System.Windows.Forms.Button btn_nhapdiem;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.ComboBox cbb_monhoc;
    }
}