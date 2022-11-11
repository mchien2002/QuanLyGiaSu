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

namespace QuanLyGiaSu.src.views.layer.tutors
{
    public partial class UC_DanhSachLopDaDangKyDay : UserControl
    {
        public UC_DanhSachLopDaDangKyDay()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void UC_DanhSachLopDaDangKyDay_Load(object sender, EventArgs e)
        {
            dgvDSDKD.DataSource = Locator.server.fetchDanhSachLopDaDangKyDayTable(Locator.author.UserName);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DanhSachLopDaDangKyDay_Load(sender, e);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_TimTheo.Text == "Mã Lớp")
                {
                    dgvDSDKD.DataSource = Locator.server.TimKiem_DSDK_LMID(Locator.author.UserName, Convert.ToInt32(tb_TimKiem.Text));
                }
                else if (cbb_TimTheo.Text == "Môn Học")
                {
                    dgvDSDKD.DataSource = Locator.server.TimKiem_DSDK_MonHoc(Locator.author.UserName, tb_TimKiem.Text.Trim());
                }
                else if (cbb_TimTheo.Text == "Lớp Học")
                {
                    dgvDSDKD.DataSource = Locator.server.TimKiem_DSDK_LopHoc(Locator.author.UserName, cbb_TimKiem.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm");
            }
        }

        private void cbb_TimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbb_TimTheo.Text == "Tất Cả")
            {
                tb_TimKiem.Text = "";
                tb_TimKiem.Enabled = false;
                tb_TimKiem.Visible = true;
                cbb_TimKiem.Hide();
                dgvDSDKD.DataSource = Locator.server.fetchDanhSachLopDaDangKyDayTable(Locator.author.UserName);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDSDKD.Rows.Count - 1; i++)
            {
                dgvDSDKD.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(246, 227, 227);
            }
        }
    }
}
