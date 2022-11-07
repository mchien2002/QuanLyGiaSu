using System;
using QuanLyGiaSu.src.controller;
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
            lbText.Text = "Thêm Môn Học ";
            lbText2.Text = "THÊM MÔN";
            btnDangky.Text = "Thêm Môn";
        }
        public ThemSuaMon(string text,string mon)
        {
            InitializeComponent();
            lbText.Text = text;
            lbText2.Text = mon;
            tbMon.Text = mon;
            btnDangky.Text = "Sửa";
        }

        private void ThemSuaMon_Load(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if(btnDangky.Text== "Thêm Môn")
            {
                Locator.server.insertMH(tbMon.Text);
                this.Close();
            }    
            else if(btnDangky.Text=="Sửa")
            {
                Locator.server.updateMH(Locator.server.checkMHID(lbText2.Text),tbMon.Text);
                this.Close();
            }    
        }
    }
}
