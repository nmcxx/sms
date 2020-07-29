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
    public partial class fQltk : Form
    {
        public fQltk()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tentaikhoan.Text == "" || txt_matkhau.Text == "" || txt_loainguoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thêm");
                return;
            }
            if (txt_tentaikhoan.Text.Length >= 8)
            {
                MessageBox.Show("Tài khoản chỉ được tối đa 7 ký tự");
                return;
            }
            if (txt_matkhau.Text.Length >= 51)
            {
                MessageBox.Show("Mật khẩu chỉ được tối đa 50 ký tự");
                return;
            }
            if (txt_loainguoidung.Text != "1" && txt_loainguoidung.Text != "2" && txt_loainguoidung.Text!="3")
            {
                MessageBox.Show("Loại người dùng chỉ được từ 1 đến 3");
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Account where username='" + txt_tentaikhoan.Text +"'", connect);
                    SqlDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read() == true)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập lại");
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("AccountAddOrEdit", connect); 
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@mode", "Add");
                        cmd2.Parameters.AddWithValue("@username", txt_tentaikhoan.Text.Trim());
                        cmd2.Parameters.AddWithValue("@password", txt_matkhau.Text.Trim());
                        cmd2.Parameters.AddWithValue("@usertype", txt_loainguoidung.Text.Trim());
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Tài khoản đã được thêm");
                        FillDGV();
                    }
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FillDGV()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter("AccountViewOrSearch", connect);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@username", txt_timkiem.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_taikhoan.DataSource = dt;
                connect.Close();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                FillDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fQltk_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            FillDGV();
        }

       // string accountId = "";
        private void dgv_taikhoan_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_taikhoan.CurrentRow.Index != -1)
            {
                //accountId = dgv_taikhoan.CurrentRow.Cells[0].Value.ToString();
                txt_tentaikhoan.Text=dgv_taikhoan.CurrentRow.Cells[0].Value.ToString();
                txt_matkhau.Text = dgv_taikhoan.CurrentRow.Cells[1].Value.ToString();
                txt_loainguoidung.Text = dgv_taikhoan.CurrentRow.Cells[2].Value.ToString();
                txt_tentaikhoan.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tentaikhoan.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa");
                return;
            }
            if (txt_tentaikhoan.Text == "" || txt_matkhau.Text == "" || txt_loainguoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần sửa");
                return;
            }
            if (txt_matkhau.Text.Length >= 51)
            {
                MessageBox.Show("Mật khẩu chỉ được tối đa 50 ký tự");
                return;
            }
            if (txt_loainguoidung.Text != "1" && txt_loainguoidung.Text != "2" && txt_loainguoidung.Text!="3")
            {
                MessageBox.Show("Loại người dùng chỉ được từ 1 đến 3");
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                        connect.Open();
                        SqlCommand cmd2 = new SqlCommand("AccountAddOrEdit", connect);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@mode", "Edit");
                        cmd2.Parameters.AddWithValue("@username", txt_tentaikhoan.Text.Trim());
                        cmd2.Parameters.AddWithValue("@password", txt_matkhau.Text.Trim());
                        cmd2.Parameters.AddWithValue("@usertype", txt_loainguoidung.Text.Trim());
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Chỉnh sửa thành công");
                        FillDGV();
                        connect.Close();
                        txt_tentaikhoan.Enabled = true;
                        txt_tentaikhoan.Clear();
                        txt_matkhau.Clear();
                        txt_loainguoidung.Clear();
                        connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tentaikhoan.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa");
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd2 = new SqlCommand("AccountDelete", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@username", txt_tentaikhoan.Text.Trim());
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Xóa tài khoản thành công");
                    FillDGV();
                    connect.Close();
                    txt_tentaikhoan.Enabled = true;
                    txt_tentaikhoan.Clear();
                    txt_matkhau.Clear();
                    txt_loainguoidung.Clear();
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
