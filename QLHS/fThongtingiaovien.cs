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
    public partial class fThongtingiaovien : Form
    {
        public fThongtingiaovien()
        {
            InitializeComponent();
        }

        private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True;MultipleActiveResultSets=true";

        private void cbbLop()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select malop from LopHoc", connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_cnl.Items.Add(dr[0]);
                }
                connect.Close();
            }
        }

        private void cbbMonHoc()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select mamon from MonHoc", connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbb_bomon.Items.Add(dr[0]);
                }
                connect.Close();
            }
        }

        private void fThongtingiaovien_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            dtp_ns.Format = DateTimePickerFormat.Short;
           // dtp_ns.Value = (DateTime;
            //MessageBox.Show(""+dtp_ns);
            cbbLop();
            cbbMonHoc();
            txt_magv.Text = fQlgv.selectUser;
            txt_magv.Enabled = false;
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select GiaoVien.*,AccInfo.* from GiaoVien,AccInfo where GiaoVien.username=AccInfo.username and GiaoVien.mgv='" + fQlgv.selectUser + "'", connect);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    txt_htgv.Text = dtr["hoten"].ToString();
                    dtp_ns.Value = (DateTime)dtr["ngaysinh"];
                    //txt_ns.Text = dtr["ngaysinh"].ToString();
                    txt_qq.Text = dtr["quequan"].ToString();
                    txt_cmnd.Text = dtr["cmnd"].ToString();
                    if (dtr["gioitinh"].ToString() == "True")
                    {
                        cbb_gt.SelectedIndex = cbb_gt.FindStringExact("Nam");
                    }
                    else
                    {
                        cbb_gt.SelectedIndex = cbb_gt.FindStringExact("Nữ");
                    }
                    cbb_cnl.SelectedIndex = cbb_cnl.FindStringExact(dtr["malop"].ToString());
                    cbb_bomon.SelectedIndex = cbb_bomon.FindStringExact(dtr["mamon"].ToString());
                    txt_diachitt.Text = dtr["diachi"].ToString();
                    txt_cmnd.Text = dtr["cmnd"].ToString();
                   // txt.Text = dtr["nghenghiepcha"].ToString();
                }
                connect.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                bool gt;
                if (cbb_gt.GetItemText(cbb_gt.SelectedItem) == "Nam")
                {
                    gt = true;
                }
                else
                {
                    gt = false;
                }
                SqlCommand cmd2 = new SqlCommand("GiaoVienUpdateOrDelete", connect);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@mode", "Update");
                cmd2.Parameters.AddWithValue("@mgv", fQlgv.selectUser);
                cmd2.Parameters.AddWithValue("@malop", cbb_cnl.GetItemText(cbb_cnl.SelectedItem));
                cmd2.Parameters.AddWithValue("@mamon", cbb_bomon.GetItemText(cbb_bomon.SelectedItem));
                cmd2.Parameters.AddWithValue("@hoten", txt_htgv.Text.Trim());
                cmd2.Parameters.AddWithValue("@gioitinh", gt);
                cmd2.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dtp_ns.Value.Date));
                cmd2.Parameters.AddWithValue("@quequan", txt_qq.Text.Trim());
                cmd2.Parameters.AddWithValue("@cmnd", txt_cmnd.Text.Trim());
                cmd2.Parameters.AddWithValue("@diachi", txt_diachitt.Text.Trim());
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công");
                this.Hide();
                connect.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
