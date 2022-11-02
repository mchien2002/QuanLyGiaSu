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
            tbEmail.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Locator.server.updateInfoTutor(tbUser.Text, tbHoTen.Text, tbCMND.Text, cbbGioiTinh.Text, dtpNgaySinh.Value, tbSDT.Text, tbQueQuan.Text, tbDiaChi.Text, tbTruongDT.Text, tbTrinhDo.Text, null);
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
        
        public void ShowThongTinGiaSu(string GSID,string ACCID,
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
            int idgs = Int32.Parse(ACCID);
            //tbUser.Text = Locator.server.getUsername(idgs);
            tbUser.Text = Locator.server.getUsername(idgs);
            tbEmail.Text = Locator.server.getEmail(idgs);
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
            tbTrinhDo.Text = trinhDo;
        }
    }
}
