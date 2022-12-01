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
            timer1.Start();
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
                dgvQLyLichSuNap.DataSource = Locator.server.fetchLishSuNapTien();
            }
            else
                tb_TimKiemLSNT.Enabled = true;
        }

        private void UC_QLyLichSuNap_Load(object sender, EventArgs e)
        {
            dgvQLyLichSuNap.DataSource = Locator.server.fetchLishSuNapTien();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLyLichSuNap_Load(sender, e);
        }

        private void dgvQLyLichSuNap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQLyLichSuNap.Rows[e.RowIndex];
                int accid = Int32.Parse(row.Cells[1].Value.ToString());
                dgvAccount.DataSource = Locator.server.TimKiem_Account_ACCID(accid);
                tbUser.Text = dgvAccount.Rows[0].Cells[2].Value.ToString();
                tbEmail.Text = dgvAccount.Rows[0].Cells[4].Value.ToString();
                tbPhanQuyen.Text = dgvAccount.Rows[0].Cells[1].Value.ToString();
                tbSoDu.Text = dgvAccount.Rows[0].Cells[5].Value.ToString();
                tbThoiGianNap.Text = dgvQLyLichSuNap.Rows[0].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvQLyLichSuNap.Rows.Count - 1; i++)
            {
                dgvQLyLichSuNap.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(64, 224, 208);
            }
        }
    }
}
