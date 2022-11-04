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
    public partial class RegisterForm : Form
    {
        UserType userType;
        public RegisterForm(UserType userType)
        {
            InitializeComponent();
            this.userType = userType;
            lbUserType.Text =
                this.userType == UserType.tutor ? "ĐĂNG KÝ GIA SƯ" 
                : this.userType == UserType.parent ? "ĐĂNG KÝ PHỤ HUYNH"
                : "ĐĂNG KÝ ADMIN";

            // tmCheckInfoLogin.Start();
            btnRegister.Enabled = false;
            btnRegister.BackColor = Color.Gray;
        }

        void refreshTextBoxLogin()
        {
            tbUser.Clear();
            tbPassword.Clear();
            tbConfirmPass.Clear();
        }

        /*void checkInfoTextBox()
        {
            if (tbUser.Text.Length > 8 && tbEmail.Text.Length > 11 && tbPassword.Text.Length > 8 && tbConfirmPass.Text.Length > 8)
            {
                btnRegister.BackColor = Color.Gray;
                btnRegister.Enabled = false;
            }
            else
            {
                btnRegister.BackColor = Color.Blue;
                btnRegister.Enabled = true;
                tmCheckInfoLogin.Stop();
            }
        }*/

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // CHECK PASSWORD CÓ GIỐNG NHAU KHONG
            if (tbPassword.Text != tbConfirmPass.Text)
            {
                lbExceptionPassword.Visible = true;
                refreshTextBoxLogin();
                return;
            };
            lbExceptionPassword.Visible = false;
            if (Locator.server.isAccountExist(tbUser.Text, tbEmail.Text))
            {
                lbExceptionUserName.Visible = true;
                refreshTextBoxLogin();
                return;
            }
            lbExceptionUserName.Visible = false;
            Locator.author.setAccount(
               this.userType == UserType.tutor ? "Gia sư"
               : this.userType == UserType.parent ? "Phụ huynh"
               : "Admin",
               tbUser.Text,
               tbPassword.Text, 
               tbEmail.Text, 
               0
            );

            this.Hide();
            var nextRegisterPage = new Form();
            if (userType == UserType.tutor)
            {
                nextRegisterPage = new NhapThongTinGiaSu();
            } else
            {
                nextRegisterPage = new NhapThongTinPhuHuynh();
            }
            nextRegisterPage.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Clear();
            }
        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "Username")
            {
                tbUser.Clear();
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Clear();
            }
        }

        private void tbConfirmPass_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text == "Password")
            {
                tbConfirmPass.Clear();
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Email";
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Username";
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
            }
        }

        private void tbConfirmPass_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text == "")
            {
                tbConfirmPass.Text = "Password";
            }
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(tbEmail.Text != "Email" && tbUser.Text != "Username" && tbPassword.Text != "Password" && tbConfirmPass.Text != "Password")
            {
                btnRegister.BackColor = Color.Blue;
                btnRegister.Enabled = true;
            }    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
