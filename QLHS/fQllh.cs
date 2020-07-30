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
    public partial class fQllh : Form
    {
        public fQllh()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void FillDGV()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                //SqlCommand cmd = new SqlCommand("")
                SqlDataAdapter da = new SqlDataAdapter("select makhoi,malop,(select COUNT(*) from HocSinh where HocSinh.malop=LopHoc.malop) as 'Số lượng HS' from LopHoc", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_lophoc.DataSource = dt;
                connect.Close();
            }
        }

        private void fQllh_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            FillDGV();
        }

        static public string selectUser = "";
        static private int slHs;

        private void btn_themlop_Click(object sender, EventArgs e)
        {
            mode = false; // THEM
            fThemlop ftl = new fThemlop();
            ftl.Show();
        }

        private void dgv_lophoc_Click(object sender, EventArgs e)
        {
            if (dgv_lophoc.CurrentRow.Index != -1)
            {
                selectUser = dgv_lophoc.CurrentRow.Cells[1].Value.ToString();
                slHs = Convert.ToInt32(dgv_lophoc.CurrentRow.Cells[2].Value.ToString());
            }
        }

        static public bool mode;
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa");
                return;
            }
            mode = true; // SUA
            fThemlop ftl = new fThemlop();
            ftl.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa");
                return;
            }
            if (slHs > 0)
            {
                MessageBox.Show("Không thể xóa lớp học có học sinh");
                return;
            }
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("delete from LopHoc where malop='" + selectUser + "'", connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa lớp học thành công");
                FillDGV();
                selectUser = "";
                connect.Close();
            }
        }
    }
}
