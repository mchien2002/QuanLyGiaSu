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
    public partial class RegisterGiaSu : Form
    {
        public RegisterGiaSu()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapThongTinGiaSu nhapThongTinGiaSu = new NhapThongTinGiaSu();
            nhapThongTinGiaSu.ShowDialog();            
            this.Close();
        }
    }
}
