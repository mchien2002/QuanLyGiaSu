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

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class UC_DanhSachLopDaDangKy : UserControl
    {
        public UC_DanhSachLopDaDangKy()
        {
            InitializeComponent();
        }

        private void UC_DanhSachLopDaDangKy_Load(object sender, EventArgs e)
        {
            dgvDSDKD.DataSource = Locator.server.fetchDanhSachLopDaDangKyDayTable(Locator.author.UserName);
        }

    }
}
