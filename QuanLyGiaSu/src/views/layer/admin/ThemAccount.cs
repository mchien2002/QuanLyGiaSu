using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class ThemAccount : Form
    {
        
        public ThemAccount()
        {
            InitializeComponent();
            btn_text.Text = "THÊM GIA SƯ";
            btn_text.Enabled = true;
        }
        public ThemAccount(string text)
        {
            InitializeComponent();
            btn_text.Text = text;
            btn_text.Enabled = true;
        }

        private void ThemAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AccountModel Acc=new AccountModel();
            Acc.UserName = tbUser.Text;
            Acc.Password = tbPassword.Text;
            Acc.NganSach = 0;
            Acc.Email = "";
            if (btn_text.Text == "THÊM GIA SƯ")
                Acc.PhanQuyen = "Gia sư";
            else Acc.PhanQuyen = "Phụ huynh";
            if (Locator.server.addAccount(Acc))
                MessageBox.Show("Tạo tài khoản thành công!");
            else MessageBox.Show("Tạo tài khoản thất bại!");
            this.Close();
        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            if(tbUser.Text == "Username")
            {
                tbUser.Clear();
            }    

        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == "Password")
            {
                tbPassword.Clear();
            }    
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if(tbUser.Text=="")
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
    }
}
