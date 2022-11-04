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
        }

        private void btnDangKyMoLop_Click(object sender, EventArgs e)
        {
            DangKyMoLop dangKyMoLop = new DangKyMoLop();
            dangKyMoLop.Show();
        }

        private void cbbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearchType.Text == "Lớp Học")
            {
                tb_TimKiem.Hide();
                cbbSearch.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else if (cbbSearchType.Text == "Mã Lớp")
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible = true;
            }
            else
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible = true;
            }
        }

        private void UC_LopMoi2_Load(object sender, EventArgs e)
        {
            cbbSearch.Hide();
            dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

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
    }
}
