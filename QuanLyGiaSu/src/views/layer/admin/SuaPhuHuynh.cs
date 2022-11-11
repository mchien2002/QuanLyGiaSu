using QuanLyGiaSu.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class SuaPhuHuynh : Form
    {
        public SuaPhuHuynh()
        {
            InitializeComponent();
            tbUser.Enabled = false;
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Locator.server.updateParent(tbUser.Text, tbHoTen.Text, tbSDT.Text, dtpNgaySinh.Value, tbDiaChi.Text, tbNgheNghiep.Text, cbbGioiTinh.Text, tbCMND.Text);

            Locator.server.updateAccount(tbUser.Text, tbPass.Text, tbEmail.Text);
            this.Close();
        }
        public void ShowThongTinPhuHuynh(string PHID,
            string ACCID,
            string hoTen,
            string CMND,
            string ngaySinh,
            string gioiTinh,
            string SDT,
            string NgheNghiep,
            string diaChi)
        {
            int idacc = Int32.Parse(ACCID);
            tbUser.Text = Locator.server.getUsername(idacc);
            tbEmail.Text = Locator.server.getEmail(idacc);
            tbCMND.Text = CMND;
            tbHoTen.Text = hoTen;
            dtpNgaySinh.Value = Convert.ToDateTime(ngaySinh);
            cbbGioiTinh.Text = gioiTinh;
            tbSDT.Text = SDT;
            tbNgheNghiep.Text = NgheNghiep;
            tbDiaChi.Text = diaChi;
        }


    }
}
