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
    public partial class NapTien : Form
    {
        public NapTien()
        {
            InitializeComponent();
            ptbQRMomo.Hide();
            ptbQRVietCom.Hide();
            lbCTK.Text = "";
            lbSTK.Text = "";
            lbNoidung.Text = "";
            lbUser.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbbLoaiNap_TextChanged(object sender, EventArgs e)
        {
            if(cbbLoaiNap.Text == "Momo")
            {
                lbSTK.Text = "Số Momo : 0379324239 ";
                lbCTK.Text = "Mai Hải Đăng";
                lbNoidung.Text = "Nội dung : ";
                lbUser.Text = "username";
                ptbQRVietCom.Hide();
                ptbQRMomo.Show();
                
            }    
            else if(cbbLoaiNap.Text == "Vietcombank")
            {
                lbSTK.Text = "STK : 0231000676593";
                lbCTK.Text = "Mai Hai Dang";
                lbNoidung.Text = "Nội dung : ";
                lbUser.Text = "user";
                ptbQRMomo.Hide();
                ptbQRVietCom.Show();
            }  
        }

        private void NapTien_Load(object sender, EventArgs e)
        {

        }
    }
}
