using QuanLyGiaSu.src.views.layer.admin;
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
    public partial class formMainPhuHuynh : Form
    {
        public formMainPhuHuynh()
        {
            InitializeComponent();
            uC_TrangChu1.BringToFront();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            uC_TrangChu1.BringToFront();
        }

        private void btn_LopMoi_Click(object sender, EventArgs e)
        {
            uC_LopMoi21.BringToFront();
        }


        private void btn_LienHe_Click(object sender, EventArgs e)
        {
            uC_LienHe1.BringToFront();
        }

        private void btn_ThongTinhPhuHuynh_Click(object sender, EventArgs e)
        {
            uC_ThongTinPhuHuynh1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uC_LichSuGiaoDich1.BringToFront();
            uC_LSGD_PH1.BringToFront();
        }

        private void btn_DanhSachMoLop_Click(object sender, EventArgs e)
        {
            uC_DanhSachMoLop1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                NapTien napTien = new NapTien();
                napTien.Show();
            }    
        }
    }
}
