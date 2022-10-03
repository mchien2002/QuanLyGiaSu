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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if(rb_Admin.Checked == true)
            {
                this.Hide();
                formMain formMain = new formMain();
                formMain.ShowDialog();
                this.Close();
            }    
            else if (rb_GiaSu.Checked == true)
            {
                this.Hide();
                formMainGiaSu formMainGiaSu = new formMainGiaSu();
                formMainGiaSu.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                formMainPhuHuynh formMainPhuHuynh = new formMainPhuHuynh();
                formMainPhuHuynh.ShowDialog();
                this.Close();
            }
                
        }
    }
}
