using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class UC_QuanLyPhuHuynh : UserControl
    {
        public UC_QuanLyPhuHuynh()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void sửaThôngTinPhụHuynhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaPhuHuynh suaPhuHuynh = new SuaPhuHuynh();
            suaPhuHuynh.Show();
        }

        private void UC_QuanLyPhuHuynh_Load(object sender, EventArgs e)
        {

        }

        private void ThemPhuHuynh_Click(object sender, EventArgs e)
        {
            ThemAccount themAccount = new ThemAccount("THÊM PHỤ HUYNH");
            themAccount.Show();
        }
    }
}
