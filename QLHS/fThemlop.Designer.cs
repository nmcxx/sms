namespace QLHS
{
    partial class fThemlop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemlop));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_khoilop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thêm lớp học";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 2);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khối lớp";
            // 
            // cbb_khoilop
            // 
            this.cbb_khoilop.FormattingEnabled = true;
            this.cbb_khoilop.Location = new System.Drawing.Point(85, 104);
            this.cbb_khoilop.Name = "cbb_khoilop";
            this.cbb_khoilop.Size = new System.Drawing.Size(208, 21);
            this.cbb_khoilop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên lớp";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(85, 162);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(208, 20);
            this.txt_malop.TabIndex = 12;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(96, 271);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(201, 271);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 14;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Location = new System.Drawing.Point(85, 220);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(208, 20);
            this.txt_tenlop.TabIndex = 15;
            // 
            // fThemlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 366);
            this.Controls.Add(this.txt_tenlop);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_malop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_khoilop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemlop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThemlop";
            this.Load += new System.EventHandler(this.fThemlop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_khoilop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_tenlop;
    }
}