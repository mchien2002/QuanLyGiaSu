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
    public partial class UC_DanhSachLopDaMo : UserControl
    {
        public UC_DanhSachLopDaMo()
        {
            InitializeComponent();
        }

        private void UC_DanhSachMoLop_Load(object sender, EventArgs e)
        {
            cbb_TimTheo.Text = "Tất Cả";
            dgvDANHSACHMOLOP.DataSource = Locator.server.fetchDanhSachLopDaMo_PhuHuynh(Locator.author.UserName);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DanhSachMoLop_Load(sender, e);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_TimTheo.Text == "Mã Lớp")
                {
                    dgvDANHSACHMOLOP.DataSource = Locator.server.TimKiem_DSLDM_LMID(Locator.author.UserName, Convert.ToInt32(tb_TimKiem.Text));
                }
                else if (cbb_TimTheo.Text == "Môn Học")
                {
                    dgvDANHSACHMOLOP.DataSource = Locator.server.TimKiem_DSLDM_MonHoc(Locator.author.UserName, tb_TimKiem.Text.Trim());
                }
                else if (cbb_TimTheo.Text == "Lớp Học")
                {
                    dgvDANHSACHMOLOP.DataSource = Locator.server.TimKiem_DSLDM_LopHoc(Locator.author.UserName, cbb_TimKiem.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm");
            }
        }

        private void cbbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheo.Text == "Tất Cả")
            {
                tb_TimKiem.Text = "";
                tb_TimKiem.Enabled = false;
                tb_TimKiem.Visible = true;
                cbb_TimKiem.Hide();
                dgvDANHSACHMOLOP.DataSource = Locator.server.fetchDanhSachLopDaMo_PhuHuynh(Locator.author.UserName);
            }
            else if (cbb_TimTheo.Text == "Lớp Học")
            {
                tb_TimKiem.Hide();
                cbb_TimKiem.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else
            {
                cbb_TimKiem.Hide();
                tb_TimKiem.Visible = true;
                tb_TimKiem.Enabled = true;
            }
        }
    }
}
