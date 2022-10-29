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

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class UC_ThongTinPhuHuynh : UserControl
    {
        public UC_ThongTinPhuHuynh()
        {
            InitializeComponent();
        }

        private void UC_ThongTinPhuHuynh_Load(object sender, EventArgs e)
        {
            //tbTruong.Focus();
            int PHID = 0;
            string GioiTinh = "", DiaChi = "", SDT = "", Cmnd = "",  HoTen = "", Email = "", Username = "", Pw = "", NgheNghiep="";
            DateTime NgaySinh = DateTime.Now;
            Locator.server.getThongTinPhuHuynh_private(Locator.author.UserName,
                                                     ref PHID,
                                                    ref HoTen,
                                                    ref GioiTinh,
                                                     ref NgaySinh,
                                                     ref DiaChi,
                                                    ref SDT,
                                                    ref Cmnd,
                                                    ref Email,
                                                    ref NgheNghiep,
                                                    ref Pw);
            
            tbNamePH.Text = HoTen;
            tbCmndPH.Text = Cmnd;
            tbAddressPH.Text = DiaChi;
            dtpBirthDayPH.Value = NgaySinh;
            tbPhonePH.Text = SDT;
            lbPHID.Text = PHID.ToString();
            tbJobPH.Text = NgheNghiep;
            tbUsername.Text = Locator.author.UserName;
            tbPass.Text = "*********";
            tbEmail.Text = Locator.author.Email = Email;
            cbbGender.Text = GioiTinh;
        }
    }
}
