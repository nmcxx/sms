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
    public partial class fQlgv : Form
    {
        public fQlgv()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void FillDGV()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("GiaoVienViewOrSearch", connect);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@timkiem", txt_timkiem.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_giaovien.DataSource = dt;
                connect.Close();
            }
        }

        private void fQlgv_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            FillDGV();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần kiểm tra thông tin");
                return;
            }
            fThongtingiaovien fttgv = new fThongtingiaovien();
            fttgv.Show();
        }

        static public string selectUser = "";
        private void dgv_giaovien_Click(object sender, EventArgs e)
        {
            if (dgv_giaovien.CurrentRow.Index != -1)
            {
                selectUser = dgv_giaovien.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa");
                return;
            }
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("delete from Account where username='" + selectUser + "'", connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa giáo viên thành công");
                FillDGV();
                selectUser = "";
                connect.Close();
            }
        }
    }
}
