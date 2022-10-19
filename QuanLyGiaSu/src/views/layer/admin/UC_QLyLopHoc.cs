using QuanLyGiaSu.src.app.views.layer;
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
    public partial class UC_QLyLopHoc : UserControl
    {
        public UC_QLyLopHoc()
        {
            InitializeComponent();
        }

        private void ThemLopHoc_Click(object sender, EventArgs e)
        {
            ThemSuaLop themSuaLop = new ThemSuaLop();
            themSuaLop.Show();
        }

        private void SuaLopHoc_Click(object sender, EventArgs e)
        {
            ThemSuaLop suaLop = new ThemSuaLop("Sửa Lớp");
            suaLop.Show();
        }

        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            ThemSuaMon themSuaMon = new ThemSuaMon();
            themSuaMon.Show();
        }

        private void SuaMonHoc_Click(object sender, EventArgs e)
        {
            ThemSuaMon suaMon = new ThemSuaMon("Sửa Môn");
            suaMon.Show();
        }

        private void UC_QLyLopHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
