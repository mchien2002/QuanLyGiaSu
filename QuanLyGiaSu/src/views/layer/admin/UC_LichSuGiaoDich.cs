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
            //comboBox1.Text = this.Items[0].ToString();
        }

        private void UC_LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLishSuGiaoDich();
        }

        private void btn_TimLSGD_Click(object sender, EventArgs e)
        {
            if (cbb_TimTheoLSGD.Text == "Mã Giao Dịch")
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
        }

        private void cbb_TimTheoLSGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheoLSGD.Text == "Tất Cả")
            {
                tb_TimKiemLSGD.Text = "";
                tb_TimKiemLSGD.Enabled = false;
                dgvLICHSUGIAODICH.DataSource = Locator.server.fetchLishSuGiaoDich();
            }
            else
                tb_TimKiemLSGD.Enabled = true;
        }



    }
}
