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
        }

        void refreshTextBoxPassword()
        {
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
            // LƯU THÔNG TIN ACCOUTN
            if (tbPassword.Text != tbConfirmPass.Text)
            {
                lbExceptionPassword.Visible = true;
                refreshTextBoxPassword();
                return;
            };
            if (Locator.server.isUserExist(tbUser.Text) || Locator.server.isEmailExist(tbEmail.Text)){
                lbExceptionUserName.Visible = true;
                return;
            } 
            Locator.author.getAccount(
                this.userType == UserType.tutor ? "Gia sư" 
                : this.userType == UserType.parent ? "Phụ huynh"
                : "Admin", 
                tbUser.Text, 
                Locator.server.hashPassWord(tbPassword.Text, tbUser.Text), tbEmail.Text, 0
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
    }
}
