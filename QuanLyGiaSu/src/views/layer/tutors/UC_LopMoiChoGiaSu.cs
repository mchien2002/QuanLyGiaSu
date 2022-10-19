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
            cbbSearch.Hide();
            dgvTHONGTINLOPMOI.DataSource = Locator.server.fetchLopMoiPH_GSTable();
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

        private void DangKyDayHoc_Click(object sender, EventArgs e)
        {
            DangKyDay dangKyDay = new DangKyDay();
            dangKyDay.Show();
        }
    }
}
