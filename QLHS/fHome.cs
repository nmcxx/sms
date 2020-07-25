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
using System.Timers;

namespace QLHS
{
    public partial class fHome : Form
    {
        public fHome()
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

  
        private void fHome_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximumSize = this.MinimumSize = this.Size;
            customizeDesing();
            timer1.Start();
            //lbl_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (checkUserType() == 1)
            {
                btn_thongtin.Hide();
                btn_xemdiem.Hide();
            }
            else if (checkUserType() == 2)
            {
                btn_qlgv.Hide();
                btn_qltk.Hide();
                btn_qllh.Hide();
                btn_xemdiem.Hide();
            }
            else
            {
                btn_qlgv.Hide();
                btn_qltk.Hide();
                btn_qllh.Hide();
                btn_qlhs.Hide();
            }
        }

        private void customizeDesing()
        {
            pn_submenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (pn_submenu.Visible == true)
                pn_submenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void pn_submenu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
          //  ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            showSubmenu(pn_submenu);
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            fLogin flogin = new fLogin();
            flogin.Show();
            this.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_childform.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_qltk_Click(object sender, EventArgs e)
        {
            openChildForm(new fQltk());
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }

        private void btn_qlhs_Click(object sender, EventArgs e)
        {
            openChildForm(new fQlhs());
        }

        private void btn_qlgv_Click(object sender, EventArgs e)
        {
            openChildForm(new fQlgv());
        }

        private void btn_qllh_Click(object sender, EventArgs e)
        {
            openChildForm(new fQllh());
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            fThongtin fThongtin = new fThongtin();
            fThongtin.Show();
        }

        private void btn_xemdiem_Click(object sender, EventArgs e)
        {
            fDiem fdiem = new fDiem();
            fdiem.Show();
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }


    }
}
