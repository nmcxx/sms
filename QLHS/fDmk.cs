using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class fDmk : Form
    {
        public fDmk()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void fDmk_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select password from Account where username='" + fLogin.LuuID.IDUser + "'", connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_mkht.Text = dr["password"].ToString();
                    txt_mkht.Enabled = false;
                }
                connect.Close();
            }
        }

        private void btn_dmk_Click(object sender, EventArgs e)
        {
            if (txt_mkm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                return;
            }
            if (txt_nlmkm.Text != txt_mkm.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng");
                return;
            }
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("update Account set password='"+txt_nlmkm.Text.Trim()+"' where username='" + fLogin.LuuID.IDUser + "'", connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Hide();
                connect.Close();
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
