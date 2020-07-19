namespace QLHS
{
    partial class fNhapdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapdiem));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_nhapdiem = new System.Windows.Forms.Button();
            this.txt_mhs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_monhoc = new System.Windows.Forms.ComboBox();
            this.cbb_loaidiem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sodiem = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "________________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập điểm";
            // 
            // but_nhapdiem
            // 
            this.but_nhapdiem.Location = new System.Drawing.Point(89, 315);
            this.but_nhapdiem.Name = "but_nhapdiem";
            this.but_nhapdiem.Size = new System.Drawing.Size(75, 23);
            this.but_nhapdiem.TabIndex = 4;
            this.but_nhapdiem.Text = "Nhập điểm";
            this.but_nhapdiem.UseVisualStyleBackColor = true;
            this.but_nhapdiem.Click += new System.EventHandler(this.but_nhapdiem_Click);
            // 
            // txt_mhs
            // 
            this.txt_mhs.Location = new System.Drawing.Point(63, 92);
            this.txt_mhs.Name = "txt_mhs";
            this.txt_mhs.Size = new System.Drawing.Size(249, 20);
            this.txt_mhs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã học sinh";
            // 
            // cbb_monhoc
            // 
            this.cbb_monhoc.FormattingEnabled = true;
            this.cbb_monhoc.Location = new System.Drawing.Point(63, 150);
            this.cbb_monhoc.Name = "cbb_monhoc";
            this.cbb_monhoc.Size = new System.Drawing.Size(249, 21);
            this.cbb_monhoc.TabIndex = 7;
            // 
            // cbb_loaidiem
            // 
            this.cbb_loaidiem.FormattingEnabled = true;
            this.cbb_loaidiem.Location = new System.Drawing.Point(63, 211);
            this.cbb_loaidiem.Name = "cbb_loaidiem";
            this.cbb_loaidiem.Size = new System.Drawing.Size(249, 21);
            this.cbb_loaidiem.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điểm";
            // 
            // txt_sodiem
            // 
            this.txt_sodiem.Location = new System.Drawing.Point(63, 268);
            this.txt_sodiem.Name = "txt_sodiem";
            this.txt_sodiem.Size = new System.Drawing.Size(249, 20);
            this.txt_sodiem.TabIndex = 12;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(197, 315);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // fNhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 366);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_sodiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_loaidiem);
            this.Controls.Add(this.cbb_monhoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mhs);
            this.Controls.Add(this.but_nhapdiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNhapdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNhapdiem";
            this.Load += new System.EventHandler(this.fNhapdiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_nhapdiem;
        private System.Windows.Forms.TextBox txt_mhs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_monhoc;
        private System.Windows.Forms.ComboBox cbb_loaidiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sodiem;
        private System.Windows.Forms.Button btn_huy;
    }
}