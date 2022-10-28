using QuanLyGiaSu.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.views.layer.admin
{
    public partial class NapTienAdmin : Form
    {
        int userAccountID;
        public NapTienAdmin()
        {
            InitializeComponent();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            try
            {
                // Nạp tiền cho tài khoản
                MessageBox.Show("Giao dịch thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Giao dịch thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
;        }

        public void ShowThongTinNapTien(string username)
        {
            lbTenTaiKhoan.Text = username;
            userAccountID = Locator.server.getAccountIDByUsername(username);
        }
    }
}
