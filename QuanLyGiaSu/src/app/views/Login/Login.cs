using QuanLyGiaSu.src.app.views.layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            rbGiaSu.Checked = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (rb_Admin.Checked == true)
            {
                this.Hide();
                formMain formMain = new formMain();
                formMain.ShowDialog();
                this.Close();
            }
            else if (rbGiaSu.Checked == true)
            {
                this.Hide();
                formMainGiaSu formMainGiaSu = new formMainGiaSu();
                formMainGiaSu.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                formMainPhuHuynh formMainPhuHuynh = new formMainPhuHuynh();
                formMainPhuHuynh.ShowDialog();
                this.Close();
            }
        }

        private void llb_DangKyGiaSu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterGiaSu dangKyGiaSu = new RegisterGiaSu();
            this.Hide();
            dangKyGiaSu.ShowDialog();
            this.Close();
        }

        private void llb_DangKyPhuHuynh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPH dangKyTKPhuHuynh = new RegisterPH();
            this.Hide();
            dangKyTKPhuHuynh.ShowDialog();
            this.Close();
        }

        private void textBox_User_Click(object sender, EventArgs e)
        {
            if(textBox_User.Text == "Username")
            {
                textBox_User.Clear();
            }    
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            if(textBox_Password.Text == "Password")
            {
                textBox_Password.Clear();
            }    
        }
    }
}
