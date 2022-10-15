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
    public partial class UC_DanhSachMoLop : UserControl
    {
        public UC_DanhSachMoLop()
        {
            InitializeComponent();
        }

        private void UC_DanhSachMoLop_Load(object sender, EventArgs e)
        {
            dgvDANHSACHMOLOP.DataSource = Locator.server.fetchLopMoiTable();
        }
    }
}
