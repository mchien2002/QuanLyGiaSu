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
    public partial class UC_DanhSachLopDaMo : UserControl
    {
        public UC_DanhSachLopDaMo()
        {
            InitializeComponent();
        }

        private void UC_DanhSachMoLop_Load(object sender, EventArgs e)
        {
            dgvDANHSACHMOLOP.DataSource = Locator.server.fetchDanhSachLopDaMo_PhuHuynh(Locator.author.UserName);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DanhSachMoLop_Load(sender, e);
        }
    }
}
