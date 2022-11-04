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
    public partial class UC_QLyLichSuNap : UserControl
    {
        public UC_QLyLichSuNap()
        {
            InitializeComponent();
        }

        private void btn_TimLSNT_Click(object sender, EventArgs e)
        {
            if (cbb_TimTheoLSNT.Text == "Giao Dịch ID")
            {
                dgvQLyLichSuNap.DataSource = Locator.server.TimKiemLSNT_GDID(Convert.ToInt32(tb_TimKiemLSNT.Text));
            }
            else if (cbb_TimTheoLSNT.Text == "Account ID")
            {
                dgvQLyLichSuNap.DataSource = Locator.server.TimKiemLSNT_ACCID(Convert.ToInt32(tb_TimKiemLSNT.Text));
            }
            else if (cbb_TimTheoLSNT.Text == "Số Tiền")
            {
                dgvQLyLichSuNap.DataSource = Locator.server.TimKiemLSNT_SoTien(Convert.ToInt32(tb_TimKiemLSNT.Text));
            }
        }

        private void cbb_TimTheoLSNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheoLSNT.Text == "Tất Cả")
            {
                tb_TimKiemLSNT.Text = "";
                tb_TimKiemLSNT.Enabled = false;
                dgvQLyLichSuNap.DataSource = Locator.server.fetchLichSuNapTienUserTable(Locator.author.UserName);
            }
            else
                tb_TimKiemLSNT.Enabled = true;
        }

        private void UC_QLyLichSuNap_Load(object sender, EventArgs e)
        {
            dgvQLyLichSuNap.DataSource = Locator.server.fetchLichSuNapTienUserTable(Locator.author.UserName);
        }
    }
}
