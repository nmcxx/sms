namespace QLHS
{
    partial class fQllh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQllh));
            this.btn_themlop = new System.Windows.Forms.Button();
            this.dgv_lophoc = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_themlop
            // 
            this.btn_themlop.Location = new System.Drawing.Point(13, 13);
            this.btn_themlop.Name = "btn_themlop";
            this.btn_themlop.Size = new System.Drawing.Size(100, 23);
            this.btn_themlop.TabIndex = 0;
            this.btn_themlop.Text = "Thêm lớp học";
            this.btn_themlop.UseVisualStyleBackColor = true;
            this.btn_themlop.Click += new System.EventHandler(this.btn_themlop_Click);
            // 
            // dgv_lophoc
            // 
            this.dgv_lophoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lophoc.Location = new System.Drawing.Point(13, 46);
            this.dgv_lophoc.Name = "dgv_lophoc";
            this.dgv_lophoc.Size = new System.Drawing.Size(543, 178);
            this.dgv_lophoc.TabIndex = 1;
            this.dgv_lophoc.Click += new System.EventHandler(this.dgv_lophoc_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(400, 230);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(481, 230);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // fQllh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 368);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dgv_lophoc);
            this.Controls.Add(this.btn_themlop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQllh";
            this.Text = "fQllh";
            this.Load += new System.EventHandler(this.fQllh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lophoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_themlop;
        private System.Windows.Forms.DataGridView dgv_lophoc;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}