using QuanLyGiaSu.src.app.views.layer;
using QuanLyGiaSu.src.app.views.Login;
using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.views.layer.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu
{
    public partial class formMainGiaSu : Form
    {
        public formMainGiaSu()
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
            btn_GiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Lớp mới
        private void btn_LopMoi_Click(object sender, EventArgs e)
        {
            uC_LopMoiChoGiaSu1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(30, 144, 255);
            btn_GiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Gia sư
        private void btn_GiaSu_Click(object sender, EventArgs e)
        {
            uC_GiaSu1.BringToFront();
            uC_GiaSu1.BackColor = SystemColors.ButtonHighlight;
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_GiaSu.BackColor = Color.FromArgb(30, 144, 255);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Quản lý danh sách lớp
        private void btn_QlyDSLOP_Click(object sender, EventArgs e)
        {
            uC_DanhSachLopDaDangKyDay1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_GiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(30, 144, 255);
        }
        #endregion

        #region Load form
        private void formMainGiaSu_Load(object sender, EventArgs e)
        {
            lbSoDu.Text = Locator.server.getNganSach(Locator.author.UserName).ToString();
            btnTrangchu.BackColor = Color.FromArgb(30, 144, 255);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_GiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Lịch sử giao dịch
        private void btnLichSuGiaoDich_Click(object sender, EventArgs e)
        {
            uC_LichSuGiaoDichPhuHuynh_GiaSu1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btn_DanhSachLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_GiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(30, 144, 255);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Xử lý data
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            NapTien napTien = new NapTien();
            if (Locator.isOpenningNapTien)
            {
                return;
            }
            else if (e.Button == MouseButtons.Left)
            {
                napTien.Show();
                Locator.isOpenningNapTien = true;
            }
        }

        private void formMainGiaSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Locator.author.PhanQuyen = "";
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

        private void uC_TrangChu1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
