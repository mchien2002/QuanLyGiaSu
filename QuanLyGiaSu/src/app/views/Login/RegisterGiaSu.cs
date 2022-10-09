﻿using QuanLyGiaSu.src.controller;
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
    public partial class RegisterGiaSu : Form
    {
        public RegisterGiaSu()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapThongTinGiaSu nhapThongTinGiaSu = new NhapThongTinGiaSu();
            nhapThongTinGiaSu.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();            
            this.Close();
        }

        private void RegisterGiaSu_Load(object sender, EventArgs e)
        {
        }
    }
}
