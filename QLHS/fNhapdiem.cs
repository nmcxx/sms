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
    public partial class fNhapdiem : Form
    {
        public fNhapdiem()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void cbbMonHoc()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select mamon from MonHoc", connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_monhoc.Items.Add(dr[0]);
                }
                connect.Close();
            }
        }

        private void cbbLoaiDiem()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select maloaidiem from LoaiDiem", connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_loaidiem.Items.Add(dr[0]);
                }
                connect.Close();
            }
        }

        private void fNhapdiem_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            cbbMonHoc();
            cbbLoaiDiem();
            txt_mhs.Text = fQlhs.selectUser;
            txt_mhs.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void but_nhapdiem_Click(object sender, EventArgs e)
        {
            float sodiem;
            if (cbb_loaidiem.GetItemText(cbb_loaidiem.SelectedItem) == "")
            {
                MessageBox.Show("Vui lòng chọn loại điểm");
                return;
            }
            if (cbb_monhoc.GetItemText(cbb_monhoc.SelectedItem) == "")
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if (float.TryParse(txt_sodiem.Text, out sodiem))
            {
                if(sodiem>10 || sodiem<0)
                {
                    MessageBox.Show("Số điểm nhập phải từ 0 đến 10");
                    return;
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connectionStr))
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("DiemAdd", connect);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mhs", txt_mhs.Text.Trim());
                        cmd.Parameters.AddWithValue("@mamon", cbb_monhoc.GetItemText(cbb_monhoc.SelectedItem));
                        cmd.Parameters.AddWithValue("@maloaidiem", cbb_loaidiem.GetItemText(cbb_loaidiem.SelectedItem));
                        cmd.Parameters.AddWithValue("@diem", sodiem);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nhập điểm thành công");
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Số điểm nhập phải từ 0 đến 10");
                return;
            }
        }
    }
}
