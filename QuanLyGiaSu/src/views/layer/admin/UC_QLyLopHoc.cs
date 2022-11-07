using QuanLyGiaSu.src.app.views.layer;
using QuanLyGiaSu.src.controller;
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
            themSuaLop.FormClosing += new FormClosingEventHandler(this.SuaLopHoc_FormClosing);
            themSuaLop.Show();
        }

        private void SuaLopHoc_Click(object sender, EventArgs e)
        {
            string lop = dgvQLyLopHoc.CurrentRow.Cells[0].Value.ToString();
            ThemSuaLop suaLop = new ThemSuaLop("Sửa Lớp",lop);
            suaLop.FormClosing += new FormClosingEventHandler(this.SuaLopHoc_FormClosing);
            suaLop.Show();
        }

        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            ThemSuaMon themSuaMon = new ThemSuaMon();
            themSuaMon.FormClosing += new FormClosingEventHandler(this.SuaLopHoc_FormClosing);
            themSuaMon.Show();
        }

        private void SuaMonHoc_Click(object sender, EventArgs e)
        {
            string mon = dgvQLyMonHoc.CurrentRow.Cells[0].Value.ToString();
            ThemSuaMon suaMon = new ThemSuaMon("Sửa Môn",mon);
            suaMon.FormClosing += new FormClosingEventHandler(this.SuaLopHoc_FormClosing);
            suaMon.Show();
        }

        private void UC_QLyLopHoc_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Tên lớp");
            foreach(var x in Locator.server.fetchLopHoc())
            {
                tb.Rows.Add(x.ToString());
            }
            dgvQLyLopHoc.DataSource = tb;



            DataTable tb2 = new DataTable(); 
            tb2.Columns.Add("Tên môn");
            foreach (var x in Locator.server.fetchMonHoc())
            {
                tb2.Rows.Add(x.ToString());
            }
            dgvQLyMonHoc.DataSource = tb2;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLyLopHoc_Load(sender, e);
        }
        private void SuaLopHoc_FormClosing(object sender,FormClosingEventArgs e)
        {
            UC_QLyLopHoc_Load(sender, e);
        }

        private void XoaLopHoc_Click(object sender, EventArgs e)
        {

        }
    }
}
