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

        private void btn_LopMoi_Click(object sender, EventArgs e)
        {
            uC_LopMoi1.BringToFront();
        }

        private void btn_TuyenDung_Click(object sender, EventArgs e)
        {
            uC_TuyenDung1.BringToFront();
            //uC_TuyenDung1.BackColor = System.Drawing.Color.Red;
        }

        private void btn_LienHe_Click(object sender, EventArgs e)
        {
            uC_LienHe1.BringToFront();
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
            uC_DanhSachLopDaDangKy1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_PhuHuynh1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
