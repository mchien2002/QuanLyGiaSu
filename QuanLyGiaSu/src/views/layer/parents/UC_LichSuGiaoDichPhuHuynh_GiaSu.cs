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
    public partial class UC_LichSuGiaoDichPhuHuynh_GiaSu : UserControl
    {
        public UC_LichSuGiaoDichPhuHuynh_GiaSu()
        {
            InitializeComponent();
        }

        private void UC_LichSuGiaoDichPhuHuynh_Load(object sender, EventArgs e)
        {
            dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLichSuGiaoDichUserTable(Locator.author.UserName);
        }
    }
}
