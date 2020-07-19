using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ///this.Hide();
            fLogin flogin = new fLogin();
            flogin.Show();
            this.Hide();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
