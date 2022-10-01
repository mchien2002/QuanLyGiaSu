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
    public partial class UC_LopMoi : UserControl
    {
        public UC_LopMoi()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void đăngKýDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyDay dangKyDay = new DangKyDay();
            dangKyDay.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Lớp Học")
            {
                tb_TimKiem.Hide();
                cbb_TimKiem.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else if(comboBox1.Text == "Mã Lớp")
            {
                cbb_TimKiem.Hide();
                tb_TimKiem.Visible=true;
            }
            else
            {
                cbb_TimKiem.Hide();
                tb_TimKiem.Visible = true;
            }
        }

        private void UC_LopMoi_Load(object sender, EventArgs e)
        {
            cbb_TimKiem.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKyMoLop dangKyMoLop = new DangKyMoLop();
            dangKyMoLop.Show();
        }
    }
}
