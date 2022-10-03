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
    public partial class ThemAccount : Form
    {
        
        public ThemAccount()
        {
            InitializeComponent();
            btn_text.Text = "THÊM GIA SƯ";
            btn_text.Enabled = true;
        }
        public ThemAccount(string text)
        {
            InitializeComponent();
            btn_text.Text = text;
            btn_text.Enabled = true;
        }

        private void ThemAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
