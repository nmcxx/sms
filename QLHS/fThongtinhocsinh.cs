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
    public partial class fThongtinhocsinh : Form
    {
        public fThongtinhocsinh()
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

        private void cbbLop()
        {
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select malop from LopHoc",connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()){
                    cbb_Lophoc.Items.Add(dr[0]);
                }
                connect.Close();
            }
        }

        private void fThongtinhocsinh_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            cbbLop();
            txt_mahs.Text = fQlhs.selectUser;
            txt_mahs.Enabled = false;
            if(checkUserType()==2){
                btn_sua.Hide();
                btn_quaylai.Left=245;
            }
            using (SqlConnection connect = new SqlConnection(connectionStr))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select HocSinh.mhs,malop,AccInfo.*,PhuHuynhHS.* from HocSinh,AccInfo,PhuHuynhHS where HocSinh.username=AccInfo.username and HocSinh.mhs=PhuHuynhHS.mhs and HocSinh.mhs='"+fQlhs.selectUser+"'", connect);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    txt_hths.Text = dtr["hoten"].ToString();
                    //txt_lh.Text = dtr["malop"].ToString();
                    dtp_nshs.Value = (DateTime)dtr["ngaysinh"];
                    txt_qq.Text = dtr["quequan"].ToString();
                    txt_cmnd.Text = dtr["cmnd"].ToString();
                    if(dtr["gioitinh"].ToString()=="True"){
                        cbb_gioitinh.SelectedIndex = cbb_gioitinh.FindStringExact("Nam");
                    }
                    else
                    {
                        cbb_gioitinh.SelectedIndex = cbb_gioitinh.FindStringExact("Nữ");
                    }
                    cbb_Lophoc.SelectedIndex = cbb_Lophoc.FindStringExact(dtr["malop"].ToString());
                    txt_hotencha.Text = dtr["hotencha"].ToString();
                    txt_hotenme.Text = dtr["hotenme"].ToString();
                    txt_nncha.Text = dtr["nghenghiepcha"].ToString();
                    txt_nnme.Text = dtr["nghenghiepme"].ToString();
                    dtp_nscha.Value = (DateTime)dtr["ngaysinhcha"];
                    dtp_nsme.Value = (DateTime)dtr["ngaysinhme"];
                    txt_qqcha.Text = dtr["quequancha"].ToString();
                    txt_qqme.Text = dtr["quequanme"].ToString();
                    txt_sdtcha.Text = dtr["sdtcha"].ToString();
                    txt_sdtme.Text = dtr["sdtme"].ToString();
                }
                connect.Close();
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
           // btn_quaylai.Left = 260;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(cbb_gioitinh.GetItemText(cbb_gioitinh.SelectedItem));
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionStr))
                {
                    connect.Open();
                    bool age;
                    if(cbb_gioitinh.GetItemText(cbb_gioitinh.SelectedItem)=="Nam")
                    {
                        age = true;
                    }
                    else
                    {
                        age = false;
                    }
                    SqlCommand cmd2 = new SqlCommand("HocSinhPHHSEdit", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@mhs", fQlhs.selectUser);
                    cmd2.Parameters.AddWithValue("@malop", cbb_Lophoc.GetItemText(cbb_Lophoc.SelectedItem));
                    cmd2.Parameters.AddWithValue("@hoten", txt_hths.Text.Trim());
                    cmd2.Parameters.AddWithValue("@gioitinh", age);
                    cmd2.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dtp_nshs.Value.Date));
                    cmd2.Parameters.AddWithValue("@quequan", txt_qq.Text.Trim());
                    cmd2.Parameters.AddWithValue("@cmnd", txt_cmnd.Text.Trim());
                    cmd2.Parameters.AddWithValue("@htcha", txt_hotencha.Text.Trim());
                    cmd2.Parameters.AddWithValue("@nscha", Convert.ToDateTime(dtp_nscha.Value.Date));
                    cmd2.Parameters.AddWithValue("@nncha", txt_nncha.Text.Trim());
                    cmd2.Parameters.AddWithValue("@qqcha", txt_qqcha.Text.Trim());
                    cmd2.Parameters.AddWithValue("@sdtcha", txt_sdtcha.Text.Trim());
                    cmd2.Parameters.AddWithValue("@htme", txt_hotenme.Text.Trim());
                    cmd2.Parameters.AddWithValue("@nsme", Convert.ToDateTime(dtp_nsme.Value.Date));
                    cmd2.Parameters.AddWithValue("@nnme", txt_nnme.Text.Trim());
                    cmd2.Parameters.AddWithValue("@qqme", txt_qqme.Text.Trim());
                    cmd2.Parameters.AddWithValue("@sdtme", txt_sdtme.Text.Trim());
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa thành công");
                    this.Hide();
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
