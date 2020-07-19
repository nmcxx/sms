namespace QLHS
{
    partial class fDmk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDmk));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mkht = new System.Windows.Forms.TextBox();
            this.txt_mkm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nlmkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_dmk = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 2);
            this.label2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // txt_mkht
            // 
            this.txt_mkht.Location = new System.Drawing.Point(62, 99);
            this.txt_mkht.Name = "txt_mkht";
            this.txt_mkht.Size = new System.Drawing.Size(271, 20);
            this.txt_mkht.TabIndex = 22;
            // 
            // txt_mkm
            // 
            this.txt_mkm.Location = new System.Drawing.Point(62, 158);
            this.txt_mkm.Name = "txt_mkm";
            this.txt_mkm.Size = new System.Drawing.Size(271, 20);
            this.txt_mkm.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txt_nlmkm
            // 
            this.txt_nlmkm.Location = new System.Drawing.Point(62, 220);
            this.txt_nlmkm.Name = "txt_nlmkm";
            this.txt_nlmkm.Size = new System.Drawing.Size(271, 20);
            this.txt_nlmkm.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // btn_dmk
            // 
            this.btn_dmk.Location = new System.Drawing.Point(96, 262);
            this.btn_dmk.Name = "btn_dmk";
            this.btn_dmk.Size = new System.Drawing.Size(88, 23);
            this.btn_dmk.TabIndex = 27;
            this.btn_dmk.Text = "Đổi mật khẩu";
            this.btn_dmk.UseVisualStyleBackColor = true;
            this.btn_dmk.Click += new System.EventHandler(this.btn_dmk_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(202, 262);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 28;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // fDmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 368);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_dmk);
            this.Controls.Add(this.txt_nlmkm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_mkm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mkht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDmk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THPT Nguyễn Chí Thanh";
            this.Load += new System.EventHandler(this.fDmk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mkht;
        private System.Windows.Forms.TextBox txt_mkm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nlmkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_dmk;
        private System.Windows.Forms.Button btn_dong;
    }
}