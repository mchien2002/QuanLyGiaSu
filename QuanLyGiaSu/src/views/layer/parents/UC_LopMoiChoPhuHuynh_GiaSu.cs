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
    public partial class UC_LopMoiChoPhuHuynh : UserControl
    {
        public UC_LopMoiChoPhuHuynh()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnDangKyMoLop_Click(object sender, EventArgs e)
        {
            DangKyMoLop dangKyMoLop = new DangKyMoLop();
            dangKyMoLop.FormClosing += new FormClosingEventHandler(this.DangKyMoLop_FormClosing);
            dangKyMoLop.Show();
        }

        private void cbbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbSearchType.Text == "Tất Cả")
            {
                tb_TimKiem.Text = "";
                tb_TimKiem.Enabled = false;
                tb_TimKiem.Visible = true;
                cbbSearch.Hide();
                dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
            }
            else if (cbbSearchType.Text == "Lớp Học")
            {
                tb_TimKiem.Hide();
                cbbSearch.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible = true;
                tb_TimKiem.Enabled = true;
            }
        }

        private void UC_LopMoi2_Load(object sender, EventArgs e)
        {
            cbbSearch.Hide();
            //Int32 selectedCellCount = dgvTHONGTINLOPMOI.GetCellCount(DataGridViewElementStates.Selected);
            dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
            for (int i = 0; i < dgvTHONGTINLOPMOI.Rows.Count - 1; i++)
            {
                if (dgvTHONGTINLOPMOI.Rows[i].Cells[11].Value.ToString() == "Đã nhận")
                {
                    dgvTHONGTINLOPMOI.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(246, 227, 227);
                }
                else
                {
                    dgvTHONGTINLOPMOI.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225, 251, 206);

                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSearchType.Text == "Mã Lớp")
                {
                    dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_PH_GS_LMID(Convert.ToInt32(tb_TimKiem.Text));
                }
                else if (cbbSearchType.Text == "Môn Học")
                {
                    dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_PH_GS_MonHoc(tb_TimKiem.Text.Trim());
                }
                else if (cbbSearchType.Text == "Lớp Học")
                {
                    dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_PH_GS_LopHoc(cbbSearch.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm");
            }               
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTHONGTINLOPMOI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_LopMoi2_Load(sender, e);
        }
        private void DangKyMoLop_FormClosing(object sender,FormClosingEventArgs e)
        {
            UC_LopMoi2_Load(sender, e);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTHONGTINLOPMOI.Rows.Count - 1; i++)
            {
                if (dgvTHONGTINLOPMOI.Rows[i].Cells[11].Value.ToString() == "Đã nhận")
                {
                    dgvTHONGTINLOPMOI.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(246, 227, 227);
                }
                else
                {
                    dgvTHONGTINLOPMOI.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225, 251, 206);

                }
            }
        }
    }
}
