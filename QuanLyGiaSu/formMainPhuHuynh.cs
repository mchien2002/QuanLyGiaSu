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
            uC_LopMoi1.BringToFront();
        }

        private void btn_TuyenDung_Click(object sender, EventArgs e)
        {
            uC_TuyenDung1.BringToFront();
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
            uC_LichSuGiaoDich1.BringToFront();
        }
    }
}
