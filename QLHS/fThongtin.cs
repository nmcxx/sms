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
    public partial class fThongtin : Form
    {
        public fThongtin()
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

        private void btn_dmk_Click(object sender, EventArgs e)
        {
            fDmk fdmk = new fDmk();
            fdmk.Show();
        }

        private void fThongtin_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            if (checkUserType() == 2)
            {
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from AccInfo,GiaoVien where AccInfo.username='" + fLogin.LuuID.IDUser + "' and AccInfo.username=GiaoVien.username", connect);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lbl_ma.Text = dr["username"].ToString();
                        lbl_cnl.Text = dr["malop"].ToString();
                        lbl_cmnd.Text = dr["cmnd"].ToString();
                        lbl_dctt.Text = dr["diachi"].ToString();
                        lbl_ht.Text = dr["hoten"].ToString();
                        lbl_ns.Text = Convert.ToDateTime(dr["ngaysinh"]).ToString("dd/MM/yyyy");
                        lbl_qq.Text = dr["quequan"].ToString();
                        if (dr["gioitinh"].ToString() == "True")
                        {
                            lbl_gt.Text = "Nam";
                        }
                        else
                        {
                            lbl_gt.Text = "Nữ";
                        }
                    }
                    connect.Close();
                }
            }
            else
            {
                label1.Text = "Mã học sinh";
                label5.Text = "Lớp học";
                label5.Left = 90;
                label10.Hide();
                lbl_cmnd.Hide();
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from AccInfo,HocSinh where AccInfo.username='"+fLogin.LuuID.IDUser+"' and AccInfo.username=HocSinh.username", connect);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lbl_ma.Text = dr["username"].ToString();
                        lbl_cnl.Text=dr["malop"].ToString();
                        lbl_cmnd.Text = dr["cmnd"].ToString();
                        lbl_dctt.Text = dr["diachi"].ToString();
                        lbl_ht.Text = dr["hoten"].ToString();
                        lbl_ns.Text = Convert.ToDateTime(dr["ngaysinh"]).ToString("dd/MM/yyyy");
                        lbl_qq.Text = dr["quequan"].ToString();
                        if (dr["gioitinh"].ToString() == "True")
                        {
                            lbl_gt.Text = "Nam";
                        }
                        else
                        {
                            lbl_gt.Text = "Nữ";
                        }
                    }
                    connect.Close();
                }
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
