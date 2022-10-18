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
    public partial class ThemSuaLop : Form
    {
        public ThemSuaLop()
        {
            InitializeComponent();
            lbText.Text = "Thêm Lớp : ";
        }
        public ThemSuaLop(string text)
        {
            InitializeComponent();
            lbText.Text = text;
        }

        private void ThemSuaLop_Load(object sender, EventArgs e)
        {

        }
    }
}
