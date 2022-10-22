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

namespace QuanLyGiaSu.src.views.layer.admin
{
    public partial class UC_QuanLyAccount : UserControl
    {
        public UC_QuanLyAccount()
        {
            InitializeComponent();
        }

        private void UC_QuanLyAccount_Load(object sender, EventArgs e)
        {
            dgvQLyAccount.DataSource = Locator.server.fetchAccount();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cbbTimKiem.Text=="User Name")
            {
                dgvQLyAccount.DataSource = Locator.server.fetchAccountByUserName(tb_TimKiem.Text);
            }
            if (tb_TimKiem.Text == "")
            {
                dgvQLyAccount.DataSource = Locator.server.fetchAccount();
            }
        }
    }
}
