using QuanLyGiaSu.src.app.views.Login;
using QuanLyGiaSu.src.controller;
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

        #region Trang chủ
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            uC_TrangChu1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(30, 144, 255);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Lớp mới
        private void btn_LopMoi_Click(object sender, EventArgs e)
        {
            uC_LopMoiChoPhuHuynh1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(30, 144, 255);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Liên hệ
        private void btn_LienHe_Click(object sender, EventArgs e)
        {
            uC_LienHe1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Thông tin phụ huynh
        private void btn_ThongTinhPhuHuynh_Click(object sender, EventArgs e)
        {
            uC_ThongTinPhuHuynh1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(30, 144, 255);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Lịch sử giao dịch
        private void button1_Click(object sender, EventArgs e)
        {
            //uC_LichSuGiaoDich1.BringToFront();
            uC_LSGD_PH1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(30, 144, 255);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Danh sách mở lớp
        private void btn_DanhSachMoLop_Click(object sender, EventArgs e)
        {
            uC_DanhSachMoLop1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(30, 144, 255);
        }
        #endregion

        #region xử lý panel
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
        #endregion

        #region Load form
        private void formMainPhuHuynh_Load(object sender, EventArgs e)
        {
            lbSoDu.Text = Locator.server.getNganSach(Locator.author.UserName).ToString();
            btnTrangchu.BackColor = Color.FromArgb(30, 144, 255);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_ThongTinhPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachMoLop.BackColor = Color.FromArgb(255, 250, 250);
        }

        private void formMainPhuHuynh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
