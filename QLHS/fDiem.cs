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
    public partial class fDiem : Form
    {
        public fDiem()
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

        private int checkUserType()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                int check = 0;
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select usertype from Account where username='" + fLogin.LuuID.IDUser + "'", connect);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    check = Convert.ToInt32(dtr["usertype"].ToString());
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
                SqlDataAdapter da = new SqlDataAdapter("XemDiem", connect);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@mode", cbb_hocky.GetItemText(cbb_hocky.SelectedItem));
                da.SelectCommand.Parameters.AddWithValue("@mhs", lbl_mahocsinh.Text.Trim());
                da.SelectCommand.Parameters.AddWithValue("@mamon", cbb_monhoc.GetItemText(cbb_monhoc.SelectedItem));
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_diem.DataSource = dt;
                connect.Close();
            }
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            cbbMonHoc();
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                if (checkUserType() == 1 || checkUserType() == 2)
                {
                    lbl_mahocsinh.Text = fQlhs.selectUser;
                    SqlCommand cmd = new SqlCommand("select hoten from AccInfo where username='" + fQlhs.selectUser + "'", connect);
                    SqlDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read())
                    {
                        lbl_hoten.Text = dtr["hoten"].ToString();
                    }
                }
                else
                {
                    btn_nhapdiem.Hide();
                    btn_dong.Left = 258;
                    lbl_mahocsinh.Text = fLogin.LuuID.IDUser;
                    SqlCommand cmd = new SqlCommand("select hoten from AccInfo where username='" + fLogin.LuuID.IDUser + "'", connect);
                    SqlDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read())
                    {
                        lbl_hoten.Text = dtr["hoten"].ToString();
                    }
                }
                connect.Close();
            }
        }

        private void btn_xemhk_Click(object sender, EventArgs e)
        {
            if (cbb_monhoc.GetItemText(cbb_monhoc.SelectedItem) == "" || cbb_hocky.GetItemText(cbb_hocky.SelectedItem) == "")
            {
                MessageBox.Show("Vui lòng chọn Học kỳ/Môn học để xem");
                return;
            }
            FillDGV();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_nhapdiem_Click(object sender, EventArgs e)
        {
            fNhapdiem fnd = new fNhapdiem();
            fnd.Show();
        }
    }
}
