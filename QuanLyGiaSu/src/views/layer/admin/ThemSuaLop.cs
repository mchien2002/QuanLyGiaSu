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
    public partial class ThemSuaLop : Form
    {
        public ThemSuaLop()
        {
            InitializeComponent();
            lbText.Text = "Thêm Lớp";
            btnDangky.Text = "Thêm Lớp";
            lbText2.Text = "THÊM LỚP";

        }
        public ThemSuaLop(string text,string lop)
        {
            InitializeComponent();
            lbText.Text = text;
            lbText2.Text = lop;
            btnDangky.Text = "Sửa Lớp";
            tbLop.Text = lop;
        }

        private void ThemSuaLop_Load(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if(btnDangky.Text == "Thêm Lớp")
            {
                Locator.server.insertLH(tbLop.Text);
                this.Close();
            }    
            else if(btnDangky.Text == "Sửa Lớp")
            {
                Locator.server.updateLH(Locator.server.checkLHID(lbText2.Text), tbLop.Text);
                this.Close();
                //MessageBox.Show(Locator.server.checkLHID(tbLop.Text).ToString());
            }    
        }
    }
}
