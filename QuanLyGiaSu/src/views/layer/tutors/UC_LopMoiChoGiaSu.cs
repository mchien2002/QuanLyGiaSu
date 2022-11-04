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
            if (x != null)
            {
                Int32.TryParse(x.ToString(), out Locator.LMID);
            }
            if (Locator.LMID != 0)
            {
                DangKyDay dangKyDay = new DangKyDay();
                dangKyDay.Show();
            }

        }

        private void btn_TimLM_Click(object sender, EventArgs e)
        {
            if (cbb_TimTheoLM.Text == "Mã Lớp")
            {
                dgvTHONGTINLOPMOI.DataSource = Locator.server.TimKiemLM_LMID(Convert.ToInt32(tb_TimKiemLM.Text));
            }
        }
        private void cbb_TimTheoLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheoLM.Text == "Tất Cả")
            {
                tb_TimKiemLM.Text = "";
                tb_TimKiemLM.Enabled = false;
                dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
            }
            else
                tb_TimKiemLM.Enabled = true;
        }
    }
}
