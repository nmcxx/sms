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
    public partial class fQlhs : Form
    {
        public fQlhs()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private int checkUserType()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                int check = 0;
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select usertype from Account where username='"+fLogin.LuuID.IDUser+"'", connect);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    check = Convert.ToInt32(dtr["usertype"].ToString());
                }
                connect.Close();
                return check;
            }
        }

        private string checkLop()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                string check = "";
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select malop from GiaoVien where username='" + fLogin.LuuID.IDUser + "'", connect);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    check = dtr["malop"].ToString();
                }
                connect.Close();
                return check;
            }
        }

        private void FillDGV()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("HocSinhViewOrSearch", connect);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@per", checkUserType());
                da.SelectCommand.Parameters.AddWithValue("@timkiem", txt_timkiem.Text.Trim());
                da.SelectCommand.Parameters.AddWithValue("@malop", checkLop());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_hocsinh.DataSource = dt;
                connect.Close();
            }
        }


        private void fQlhs_Load(object sender, EventArgs e)
        {
            if(checkUserType()==2)
            {
                btn_diem.Left = 393;
                btn_thongtin.Left = 474;
                btn_xoa.Hide();
            }
            else
            {
                btn_diem.Hide();
            }
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            FillDGV();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            FillDGV();
        }

        static public string selectUser = "";
        private void dgv_hocsinh_Click(object sender, EventArgs e)
        {
            if (dgv_hocsinh.CurrentRow.Index != -1)
            {
                selectUser = dgv_hocsinh.CurrentRow.Cells[0].Value.ToString();
                //fThongtinhocsinh ftths = new fThongtinhocsinh();
                //ftths.Show();
                //txt_tentaikhoan.Enabled = false;
            }
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh cần kiểm tra thông tin");
                return;
            }
            fThongtinhocsinh ftths = new fThongtinhocsinh();
            ftths.Show();
        }

        private void btn_diem_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh cần kiểm tra điểm");
                return;
            }
            fDiem fdiem = new fDiem();
            fdiem.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectUser == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh cần xóa");
                return;
            }
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("delete from Account where username='" + selectUser + "'",connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa học sinh thành công");
                FillDGV();
                selectUser = "";
                connect.Close();
            }
        }


    }
}
