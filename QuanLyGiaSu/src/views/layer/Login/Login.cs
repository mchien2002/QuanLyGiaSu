using QuanLyGiaSu.src.app.views.layer;
using QuanLyGiaSu.src.controller;
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
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Locator.author.UserName = tbUserName.Text;
            Locator.author.PhanQuyen = Locator.server.checkAuthorization(Locator.author.UserName);

            if (Locator.author.PhanQuyen == "Admin" && Locator.server.checkAdmin(tbUserName.Text, tbPassword.Text))
            {
                loginPage();
            }
            if (Locator.server.checkSignIn(tbUserName.Text, Locator.server.hashPassWord(tbPassword.Text, tbUserName.Text), Locator.author.PhanQuyen))
                loginPage();
            else
            {
                lbCannotLogin.Visible = true;
                return;
            }
            //loginPage();
        }

        private void llb_DangKyGiaSu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm dangKyGiaSu = new RegisterForm(UserType.tutor);
            this.Hide();
            dangKyGiaSu.ShowDialog();
            this.Close();
        }

        private void llb_DangKyPhuHuynh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm dangKyTKPhuHuynh = new RegisterForm(UserType.parent);
            this.Hide();
            dangKyTKPhuHuynh.ShowDialog();
            this.Close();
        }

        private void textBox_User_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "Username")
            {
                tbUserName.Clear();
            }    
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == "Password")
            {
                tbPassword.Clear();
            }    
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        void loginPage()
        {
            if (Locator.author.PhanQuyen=="Admin")
            {
                this.Hide();
                formMain formMain = new formMain();
                formMain.ShowDialog();
                this.Close();
            }
            else if (Locator.author.PhanQuyen=="Gia Sư")
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

        private void rbPhuHuynh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Username";
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
            }
        }
    }
}
