using QuanLyGiaSu.src.app.views.Login;
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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        #region Load Form
        private void formMain_Load(object sender, EventArgs e)
        {
            btnTrangchu.BackColor = Color.FromArgb(30, 144, 255);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Mở trang chủ
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            uC_TrangChu1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(30, 144, 255);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);

        }
        #endregion

        #region Gia sư
        private void btn_GiaSu_Click(object sender, EventArgs e)
        {
            uC_GiaSu1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(30, 144, 255);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Quản lý lớp mới
        private void btn_QlyLop_Click(object sender, EventArgs e)
        {
            uC_QuanLyLop1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(30, 144, 255);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Quản lý gia sư
        private void btn_QlyGiaSu_Click(object sender, EventArgs e)
        {
            uC_QuanLyGiaSu1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(30, 144, 255);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Quản lý phụ huynh
        private void btn_QlyPhuHuynh_Click(object sender, EventArgs e)
        {
            uC_QuanLyPhuHuynh1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(30, 144, 255);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Quản lý danh sách lớp
        private void btn_QlyDSLOP_Click(object sender, EventArgs e)
        {
            uC_QuanLyDanhSachDangKyDay1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(30, 144, 255);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Lịch sử giao dịch
        private void btnLichSuGiaoDich_Click(object sender, EventArgs e)
        {
            uC_LichSuGiaoDich1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(30, 144, 255);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Quản lý lớp và môn
        private void btnQuanLyLopVaMon_Click(object sender, EventArgs e)
        {
            uC_QLyLopHoc1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(30, 144, 255);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Lịch sử nạp tiền
        private void btnLichSuNapTien_Click(object sender, EventArgs e)
        {
            uC_QLyLichSuNap1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(30, 144, 255);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Thống kê
        private void button1_Click(object sender, EventArgs e)
        {
            uC_ThongKe1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(30, 144, 255);
        }
        #endregion

        #region Account
        private void btnAccount_Click(object sender, EventArgs e)
        {
            uC_QuanLyAccount1.BringToFront();
            btnTrangchu.BackColor = Color.FromArgb(255, 250, 250);
            btnQuanLyLopVaMon.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuNapTien.BackColor = Color.FromArgb(255, 250, 250);
            btnAccount.BackColor = Color.FromArgb(30, 144, 255);
            btn_QuanLyGiaSu.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyLopMoi.BackColor = Color.FromArgb(255, 250, 250);
            btn_QuanLyPhuHuynh.BackColor = Color.FromArgb(255, 250, 250);
            btn_QlyDSLOP.BackColor = Color.FromArgb(255, 250, 250);
            btnLichSuGiaoDich.BackColor = Color.FromArgb(255, 250, 250);
            button1.BackColor = Color.FromArgb(255, 250, 250);
        }
        #endregion

        #region Close Form
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Load form
        private void uC_TrangChu1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
