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

namespace QuanLyGiaSu.src.views.layer.admin
{
    public partial class UC_QuanLyDanhSachDangKyDay : UserControl
    {
        public UC_QuanLyDanhSachDangKyDay()
        {
            InitializeComponent();
        }

        private void UC_QuanLyDanhSachDangKyDay_Load(object sender, EventArgs e)
        {
            dgvDSDKD.DataSource = Locator.server.fetchDanhSachDangKyDayAD();
        }
    }
}
