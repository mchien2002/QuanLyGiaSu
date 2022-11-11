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

namespace DoAnCuoiKy_Nhom13
{
    public partial class UC_LichSuGiaoDich : UserControl
    {
        public UC_LichSuGiaoDich()
        {
            InitializeComponent();
            cbb_TimTheoLSGD.Text = cbb_TimTheoLSGD.Items[0].ToString();
            timer1.Start();
            
        }

        private void UC_LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            dtpFrom.Visible = false;
            dtpTo.Visible = false;
            lbFrom.Visible = false;
            lbTo.Visible = false;
            cbb_TimTheoLSGD.Text = "Tất Cả";
            dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLishSuGiaoDich();
            dgvLICHSUGIAODICH.Columns["GDID"].Width = 60;
            dgvLICHSUGIAODICH.Columns["ACCID"].Width = 60;
            dgvLICHSUGIAODICH.Columns["LMID"].Width = 60;
            dgvLICHSUGIAODICH.Columns["SoTien"].Width = 100;
            dgvLICHSUGIAODICH.Columns["ThoiGianGiaoDich"].Width = 200;

            
        }

        private void btn_TimLSGD_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbb_TimTheoLSGD.Text == "Giao dịch ID")
                {
                    dgvLICHSUGIAODICH.DataSource = Locator.server.TimKiemLSDG_GDID(Convert.ToInt32(tb_TimKiemLSGD.Text));
                }
                else if (cbb_TimTheoLSGD.Text == "Account ID")
                {
                    dgvLICHSUGIAODICH.DataSource = Locator.server.TimKiemLSDG_ACCID(Convert.ToInt32(tb_TimKiemLSGD.Text));
                }
                else if (cbb_TimTheoLSGD.Text == "Số Tiền")
                {
                    dgvLICHSUGIAODICH.DataSource = Locator.server.TimKiemLSDG_SoTien(Convert.ToInt32(tb_TimKiemLSGD.Text));
                }
                else if (cbb_TimTheoLSGD.Text == "Thời Gian GD")
                {
                    dgvLICHSUGIAODICH.DataSource = Locator.server.TimKiemLSGD_TGGD(dtpFrom.Value, dtpTo.Value);
                }
            }
            catch
            {
                dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLishSuGiaoDich();

            }
        }

        private void cbb_TimTheoLSGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_TimTheoLSGD.Text == "Thời Gian GD")
            {
                dtpFrom.Visible = true;
                dtpTo.Visible = true;
                lbFrom.Visible = true;
                lbTo.Visible = true;
                tb_TimKiemLSGD.Hide();
            }
            else if (cbb_TimTheoLSGD.Text == "Tất Cả")
            {
                tb_TimKiemLSGD.Text = "";
                tb_TimKiemLSGD.Enabled = false;
                dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLishSuGiaoDich();
            }
            else if(cbb_TimTheoLSGD.Text=="Số Tiền")
            {
                dtpFrom.Visible = false;
                dtpTo.Visible = false;
                lbFrom.Visible = false;
                lbTo.Visible = false;
                tb_TimKiemLSGD.Visible = true;
                tb_TimKiemLSGD.Enabled = true;
            }    
            else
            {
                dtpFrom.Visible = false;
                dtpTo.Visible = false;
                lbFrom.Visible = false;
                lbTo.Visible = false;
                tb_TimKiemLSGD.Visible = true;
                tb_TimKiemLSGD.Enabled = true;
            }    
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_LichSuGiaoDich_Load(sender, e);
            cbb_TimTheoLSGD.Text = "Tất Cả";
        }

        private void dgvLICHSUGIAODICH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvLICHSUGIAODICH.Rows[e.RowIndex];
            int accid = Int32.Parse(row.Cells[1].Value.ToString());
            int lmid = Int32.Parse(row.Cells[2].Value.ToString());
            dgvAccount.DataSource = Locator.server.TimKiem_Account_ACCID(accid);
            dgvLop.DataSource = Locator.server.TimKiemLM_LMID(lmid);
            tbMonHoc.Text = dgvLop.Rows[0].Cells[2].Value.ToString();
            tbLop.Text = dgvLop.Rows[0].Cells[3].Value.ToString();
            tbDiaChi.Text = dgvLop.Rows[0].Cells[4].Value.ToString();
            tbSDTph.Text = dgvLop.Rows[0].Cells[5].Value.ToString();
            tbSoBuoi.Text = dgvLop.Rows[0].Cells[9].Value.ToString();
            tbHinhThuc.Text = dgvLop.Rows[0].Cells[10].Value.ToString();
            tbUser.Text = dgvAccount.Rows[0].Cells[2].Value.ToString();
            tbEmail.Text = dgvAccount.Rows[0].Cells[4].Value.ToString();
            tbPhanQuyen.Text = dgvAccount.Rows[0].Cells[1].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLICHSUGIAODICH.Rows.Count - 1; i++)
            {
                dgvLICHSUGIAODICH.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(64, 224, 208);
            }
        }
    }
}
