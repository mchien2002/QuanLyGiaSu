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

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class SuaGiaSu : Form
    {
        public SuaGiaSu()
        {
            InitializeComponent();
            tbUser.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Locator.server.updateInfoTutor(Locator.author.UserName,tbHovaTen,)
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void SuaGiaSu_Load(object sender, EventArgs e)
        {

        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
