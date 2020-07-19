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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(txt_taikhoan.Text=="")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng kiểm tra lại");
                return;
            }
            if(txt_matkhau.Text=="")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng kiểm tra lại");
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Account where username='"+txt_taikhoan.Text+"' and password='"+txt_matkhau.Text+"'", connect);
                    SqlDataReader dtr=cmd.ExecuteReader();
                    if(dtr.Read()==true)
                    {
                        LuuID.IDUser = txt_taikhoan.Text;
                        fHome fhome = new fHome();
                        fhome.Show();
                        this.Hide();
                        //connect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng kiểm tra lại");
                    }
                    connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi kết nối với hệ thống",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public class LuuID
        {
            static public string IDUser;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            // co dinh form
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
