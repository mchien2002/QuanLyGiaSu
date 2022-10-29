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
    public partial class DangKyDay : Form
    {
        public DangKyDay()
        {
            InitializeComponent();
        }

        private void DangKyDay_Load(object sender, EventArgs e)
        {
            tbSoTien.Text = Convert.ToString(0.4 * Int32.Parse(tbMucLuong.Text.ToString()));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (Locator.server.insertDSDK(Locator.author.UserName, Locator.LMID, DateTime.Now))
                MessageBox.Show("Đăng ký lớp thành công!");
            else MessageBox.Show("Đăng ký thất bại!");
        }
    }
}
