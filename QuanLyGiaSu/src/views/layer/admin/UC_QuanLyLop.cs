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
            cbb_TimTheoLM.Text = cbb_TimTheoLM.Items[0].ToString();
        }

        private void UC_QuanLyLop_Load(object sender, EventArgs e)
        {
            dgvQuanLyLopMoi.DataSource = Locator.server.fetchDanhSachLopMoiAD();
        }


        private void SuaThongTinLop_Click(object sender, EventArgs e)
        {   
            Locator.LMID=Int32.Parse(dgvQuanLyLopMoi.CurrentRow.Cells[0].Value.ToString());
            Locator.idPH= Int32.Parse(dgvQuanLyLopMoi.CurrentRow.Cells[1].Value.ToString());
            SuaThongTinLop suaThongTinLop = new SuaThongTinLop();
            suaThongTinLop.Show();
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
                    dgvQuanLyLopMoi.DataSource = Locator.server.searchBySubject(tb_TimKiemLM.Text.Trim());
                } else if (cbb_TimTheoLM.Text == "Lớp Học")
                {
                    dgvQuanLyLopMoi.DataSource = Locator.server.searchByClass(tb_TimKiemLM.Text.Trim());
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
    }
}
