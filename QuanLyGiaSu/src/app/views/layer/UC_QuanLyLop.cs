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
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sửaThôngTinLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaThongTinLop suaThongTinLop = new SuaThongTinLop();
            suaThongTinLop.Show();
        }

        private void UC_QuanLyLop_Load(object sender, EventArgs e)
        {

        }
    }
}
