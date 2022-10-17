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

namespace QuanLyGiaSu.src.views.layer.tutors
{
    public partial class UC_DanhSachLopDaDangKyDay : UserControl
    {
        public UC_DanhSachLopDaDangKyDay()
        {
            InitializeComponent();
        }

        private void UC_DanhSachLopDaDangKyDay_Load(object sender, EventArgs e)
        {
            dgvDSDKD.DataSource = Locator.server.fetchDanhSachLopDaDangKyDayTable(Locator.author.UserName);
        }
    }
}
