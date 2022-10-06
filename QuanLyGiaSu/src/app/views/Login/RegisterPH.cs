using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.Login
{
    public partial class RegisterPH : Form
    {
        public RegisterPH()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            NhapThongTinPhuHuynh nhapThongTinPhuHuynh = new NhapThongTinPhuHuynh();
            this.Hide();
            nhapThongTinPhuHuynh.ShowDialog();
            this.Close();
        }
    }
}
