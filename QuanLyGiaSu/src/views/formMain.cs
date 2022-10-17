using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            uC_TrangChu1.BringToFront();
        }

        private void btn_GiaSu_Click(object sender, EventArgs e)
        {
            uC_GiaSu1.BringToFront();
        }


        private void btn_QlyLop_Click(object sender, EventArgs e)
        {
            uC_QuanLyLop1.BringToFront();
        }

        private void btn_QlyGiaSu_Click(object sender, EventArgs e)
        {
            uC_QuanLyGiaSu1.BringToFront();
        }

        private void btn_QlyPhuHuynh_Click(object sender, EventArgs e)
        {
            uC_QuanLyPhuHuynh1.BringToFront();
        }

        private void btn_QlyDSLOP_Click(object sender, EventArgs e)
        {
            uC_QuanLyDanhSachDangKyDay1.BringToFront();
        }

        private void btnLichSuGiaoDich_Click(object sender, EventArgs e)
        {
            uC_LichSuGiaoDich1.BringToFront();
        }
    }
}
