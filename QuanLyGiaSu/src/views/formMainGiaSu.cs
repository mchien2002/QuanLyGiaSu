using QuanLyGiaSu.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu
{
    public partial class formMainGiaSu : Form
    {
        public int chien;
        public formMainGiaSu()
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
            uC_LopMoiChoPhuHuynh_GiaSu1.BringToFront();
        }


        private void btn_LienHe_Click(object sender, EventArgs e)
        {
        }

        private void btn_GiaSu_Click(object sender, EventArgs e)
        {
            uC_GiaSu1.BringToFront();
        }

        private void btn_QlyDSLOP_Click(object sender, EventArgs e)
        {
            uC_DanhSachLopDaDangKyDay1.BringToFront();
        }


        private void formMainGiaSu_Load(object sender, EventArgs e)
        {
            lbSoDu.Text = Locator.server.getNganSach(Locator.author.UserName).ToString();
        }

        private void btnLichSuGiaoDich_Click(object sender, EventArgs e)
        {
            uC_LichSuGiaoDichPhuHuynh_GiaSu1.BringToFront();
        }
    }
}
