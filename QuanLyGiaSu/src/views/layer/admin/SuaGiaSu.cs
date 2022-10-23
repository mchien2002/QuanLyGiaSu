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
        
        public void ShowThongTinGiaSu(string GSID,
            string truongDT,
            string hoTen,
            string ngaySinh,
            string gioiTinh,
            string soDienThoai,
            string cmnd,
            string diaChi,
            string queQuan,
            string uuDiem,
            string trinhDo
            )
        {
            tbGSID.Text = GSID;
            tbTruongDT.Text = truongDT;
            tbHoTen.Text = hoTen;
            dtpNgaySinh.Value = Convert.ToDateTime(ngaySinh);
            cbbGioiTinh.Text = gioiTinh;
            tbSDT.Text = soDienThoai;
            tbCMND.Text = cmnd;
            tbDiaChi.Text = diaChi;
            tbQueQuan.Text = queQuan;
            tbUuDiem.Text = uuDiem;
            cbbsTrinhDo.Text = trinhDo;
        }
    }
}
