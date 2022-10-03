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
    public partial class UC_QuanLyLop : UserControl
    {
        public UC_QuanLyLop()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void UC_QuanLyLop_Load(object sender, EventArgs e)
        {
            cbb_TimKiem.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SuaThongTinLop_Click(object sender, EventArgs e)
        {
            SuaThongTinLop suaThongTinLop = new SuaThongTinLop();
            suaThongTinLop.Show();
        }
    }
}
