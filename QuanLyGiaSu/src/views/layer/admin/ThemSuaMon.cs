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
    public partial class ThemSuaMon : Form
    {
        public ThemSuaMon()
        {
            InitializeComponent();
            lbText.Text = "Thêm Môn Học : ";
        }
        public ThemSuaMon(string text)
        {
            InitializeComponent();
            lbText.Text = text;
        }

        private void ThemSuaMon_Load(object sender, EventArgs e)
        {

        }
    }
}
