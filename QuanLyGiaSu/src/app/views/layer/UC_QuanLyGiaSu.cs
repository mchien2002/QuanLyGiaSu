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
    public partial class UC_QuanLyGiaSu : UserControl
    {
        public UC_QuanLyGiaSu()
        {
            InitializeComponent();
        }

        private void sửaThôngTinGiaSưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaGiaSu suaGiaSu = new SuaGiaSu();
            suaGiaSu.Show();
        }
    }
}
