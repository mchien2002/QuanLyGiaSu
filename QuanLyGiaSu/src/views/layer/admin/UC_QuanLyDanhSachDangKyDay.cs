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
            timer1.Start();
        }

        private void UC_QuanLyDanhSachDangKyDay_Load(object sender, EventArgs e)
        {
            dgvDSDKD.DataSource = Locator.server.fetchDanhSachDangKyDayAD();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyDanhSachDangKyDay_Load(sender, e);
        }

        private void dgvDSDKD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDSDKD.Rows[e.RowIndex];
            int gsid = Int32.Parse(row.Cells[1].Value.ToString());
            int lmid = Int32.Parse(row.Cells[2].Value.ToString());
            dgvGS.DataSource = Locator.server.TimKiemGiaSu_GSID(gsid);
            dgvLop.DataSource = Locator.server.TimKiemLM_LMID(lmid);
            tbHoTen.Text = dgvGS.Rows[0].Cells[2].Value.ToString();
            tbCMND.Text = dgvGS.Rows[0].Cells[3].Value.ToString();
            tbSDT.Text = dgvGS.Rows[0].Cells[6].Value.ToString();
            tbMonHoc.Text = dgvLop.Rows[0].Cells[2].Value.ToString();
            tbLop.Text = dgvLop.Rows[0].Cells[3].Value.ToString();
            tbDiaChi.Text = dgvLop.Rows[0].Cells[4].Value.ToString();
            tbSDTph.Text = dgvLop.Rows[0].Cells[5].Value.ToString();
            tbSoBuoi.Text = dgvLop.Rows[0].Cells[9].Value.ToString();
            tbHinhThuc.Text = dgvLop.Rows[0].Cells[10].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDSDKD.Rows.Count - 1; i++)
            {
                dgvDSDKD.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(64, 224, 208);
            }
        }
    }
}
