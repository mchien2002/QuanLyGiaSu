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
            dgvLICHSUNAPTIEN.Hide();
        }

        private void UC_LichSuGiaoDichPhuHuynh_Load(object sender, EventArgs e)
        {
            dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLichSuGiaoDichUserTable(Locator.author.UserName);
            dgvLICHSUNAPTIEN.DataSource=Locator.server.fetchLichSuNapTienUserTable(Locator.author.UserName);
        }

        private void btn_LichSuNap_Click(object sender, EventArgs e)
        {
            if(btn_LichSuNap.Text == "Xem Lịch Sử Nạp Tiền")
            {
                dgvLICHSUGIAODICH.Hide();
                dgvLICHSUNAPTIEN.Show();
                btn_LichSuNap.Text = "Xem Lịch Sử Giao Dịch";
                lbText.Text = "LỊCH SỬ NẠP TIỀN";
            }
            else
            {
                dgvLICHSUNAPTIEN.Hide();
                dgvLICHSUGIAODICH.Show();
                btn_LichSuNap.Text = "Xem Lịch Sử Nạp Tiền";
                lbText.Text = "LỊCH SỬ GIAO DỊCH";
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_LichSuGiaoDichPhuHuynh_Load(sender, e);
        }
    }
}
