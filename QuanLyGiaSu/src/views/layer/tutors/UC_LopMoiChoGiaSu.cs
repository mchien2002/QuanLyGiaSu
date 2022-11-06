using System;
using QuanLyGiaSu.src.controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaSu.src.app.views.layer;

namespace QuanLyGiaSu.src.views.layer.tutors
{
    public partial class UC_LopMoiChoGiaSu : UserControl
    {
        public UC_LopMoiChoGiaSu()
        {
            InitializeComponent();
        }

        private void UC_LopMoiChoGiaSu_Load(object sender, EventArgs e)
        {
            dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
        }


        private void DangKyDayHoc_Click(object sender, EventArgs e)
        {
            
            var x = dgvTHONGTINLOPMOI.CurrentRow.Cells[0].Value;
            string TrangThai = dgvTHONGTINLOPMOI.CurrentRow.Cells[11].Value.ToString().Trim();
            if (x != null)
            {
                Int32.TryParse(x.ToString(), out Locator.LMID);
            }
            if (TrangThai != "Đã nhận")
            {
                if (Locator.LMID != 0)
                {
                    DangKyDay dangKyDay = new DangKyDay();
                    dangKyDay.Show();
                }
            }
            else
            {
                MessageBox.Show("Lớp đã được nhận không thể đăng ký lại");
            }


        }

        private void btn_TimLM_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_TimTheo.Text == "Mã Lớp")
                {
                    dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_PH_GS_LMID(Convert.ToInt32(tb_TimKiem.Text));
                }
                else if (cbb_TimTheo.Text == "Môn Học")
                {
                    dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_PH_GS_MonHoc(tb_TimKiem.Text.Trim());
                }
                else if (cbb_TimTheo.Text == "Lớp Học")
                {
                    dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_PH_GS_LopHoc(cbb_TimKiem.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm");
            }
        }
        private void cbb_TimTheoLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheo.Text == "Tất Cả")
            {
                tb_TimKiem.Text = "";
                tb_TimKiem.Enabled = false;
                tb_TimKiem.Visible = true;
                cbb_TimKiem.Hide();
                dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
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
