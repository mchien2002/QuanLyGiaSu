using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.database;
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
    public partial class UC_QuanLyLop : UserControl
    {
        public UC_QuanLyLop()
        {
            InitializeComponent();
            timer1.Start();
            cbb_TimTheoLM.Text = cbb_TimTheoLM.Items[0].ToString();
        }

        private void UC_QuanLyLop_Load(object sender, EventArgs e)
        {
            dgvQuanLyLopMoi.DataSource = Locator.server.fetchDanhSachLopMoiAD();
        }


        private void SuaThongTinLop_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyLopMoi.CurrentRow.Cells[0].Value != null && dgvQuanLyLopMoi.CurrentRow.Cells[1].Value != null)
            {
                Locator.LMID = Int32.Parse(dgvQuanLyLopMoi.CurrentRow.Cells[0].Value.ToString());
                Locator.idPH = Int32.Parse(dgvQuanLyLopMoi.CurrentRow.Cells[1].Value.ToString());
                SuaThongTinLop suaThongTinLop = new SuaThongTinLop();
                suaThongTinLop.FormClosing += new FormClosingEventHandler(this.SuaThongTinLop_FormClosing);
                suaThongTinLop.Show();
            }
        }

        private void btn_TimLM_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_TimTheoLM.Text == "Mã Lớp")
                {
                    dgvQuanLyLopMoi.DataSource = Locator.server.TimKiemLM_LMID(Convert.ToInt32(tb_TimKiemLM.Text));
                }
                else if (cbb_TimTheoLM.Text == "Môn Học")
                {
                    dgvQuanLyLopMoi.DataSource = Locator.server.TimKiemLM_MonHoc(tb_TimKiemLM.Text.Trim());
                } else if (cbb_TimTheoLM.Text == "Lớp Học")
                {
                    dgvQuanLyLopMoi.DataSource = Locator.server.TimKiemLM_LopHoc(tb_TimKiemLM.Text.Trim());
                }
            }
            catch
            {
                dgvQuanLyLopMoi.DataSource = Locator.server.fetchDanhSachLopMoiAD();
            }
        }

        private void cbb_TimTheoLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheoLM.Text == "Tất Cả")
            {
                tb_TimKiemLM.Text = "";
                tb_TimKiemLM.Enabled = false;
                dgvQuanLyLopMoi.DataSource = Locator.server.fetchDanhSachLopMoiAD();
            }
            else tb_TimKiemLM.Enabled = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyLop_Load(sender, e);
        }
        private void SuaThongTinLop_FormClosing(object sender,FormClosingEventArgs e)
        {
            UC_QuanLyLop_Load(sender, e);
        }

        private void XoaLop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvQuanLyLopMoi.Rows.Count - 1; i++)
            {
                if (dgvQuanLyLopMoi.Rows[i].Cells[13].Value.ToString() == "Đã nhận")
                {
                    dgvQuanLyLopMoi.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(246, 227, 227);
                }
                else
                {
                    dgvQuanLyLopMoi.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225, 251, 206);

                }
            }
        }
    }
}
