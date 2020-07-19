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
    public partial class fThemlop : Form
    {
        public fThemlop()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void cbbKhoi()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select makhoi from KhoiLop", connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_khoilop.Items.Add(dr[0]);
                }
                connect.Close();
            }
        }

        private void fThemlop_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            cbbKhoi();
            if (fQllh.mode == false)
            {

            }
            else
            {
                label1.Text = "Sửa lớp học";
                btn_them.Text = "Sửa";
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from LopHoc where malop='" + fQllh.selectUser + "'", connect);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txt_malop.Text = dr["malop"].ToString();
                        txt_malop.Enabled = false;
                        txt_tenlop.Text = dr["tenlop"].ToString();
                        cbb_khoilop.SelectedIndex = cbb_khoilop.FindStringExact(dr["makhoi"].ToString());
                    }
                    connect.Close();
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (fQllh.mode == false)
            {
                if (cbb_khoilop.GetItemText(cbb_khoilop.SelectedItem) == "")
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                    return;
                }
                if (txt_malop.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                    return;
                }
                if (txt_tenlop.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                    return;
                }
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from LopHoc where malop='" + txt_malop.Text + "'",connect);
                    SqlDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read() == true)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại");
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("LopHocAddOrEdit", connect);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@mode", "Add");
                        cmd2.Parameters.AddWithValue("@malop", txt_malop.Text.Trim());
                        cmd2.Parameters.AddWithValue("@tenlop", txt_tenlop.Text.Trim());
                        cmd2.Parameters.AddWithValue("@makhoi", cbb_khoilop.GetItemText(cbb_khoilop.SelectedItem));
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        this.Hide();
                    }
                    connect.Close();
                }
            }
            else
            {
                if (cbb_khoilop.GetItemText(cbb_khoilop.SelectedItem) == "")
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                    return;
                }
                if (txt_tenlop.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                    return;
                }
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd2 = new SqlCommand("LopHocAddOrEdit", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@mode", "Edit");
                    cmd2.Parameters.AddWithValue("@malop", fQllh.selectUser);
                    cmd2.Parameters.AddWithValue("@tenlop", txt_tenlop.Text.Trim());
                    cmd2.Parameters.AddWithValue("@makhoi", cbb_khoilop.GetItemText(cbb_khoilop.SelectedItem));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa thành công");
                    this.Hide();
                    connect.Close();
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
