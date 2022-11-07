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
        string userName;
        public NapTienAdmin()
        {
            InitializeComponent();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            try
            {
                Locator.server.setLSNTByUSerName(userName, Int32.Parse(tbNapTien.Text), Convert.ToDateTime(DateTime.Now.Date));
                MessageBox.Show("Giao dịch thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Giao dịch thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Close();
        }

        public void ShowThongTinNapTien(string username)
        {
            lbTenTaiKhoan.Text = username;
            userName = username;
        }

        private void tbNapTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void NapTienAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
