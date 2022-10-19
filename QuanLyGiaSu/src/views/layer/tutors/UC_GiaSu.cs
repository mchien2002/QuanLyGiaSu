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

namespace DoAnCuoiKy_Nhom13
{
    public partial class UC_GiaSu : UserControl
    {
        public UC_GiaSu()
        {
            InitializeComponent();
            
        }

        private void UC_GiaSu_Load(object sender, EventArgs e)
        {
            //tbTruong.Focus();
            int gsid=0;
            string GioiTinh="",DiaChi="", SDT="", Cmnd="", QueQuan="", TrinhDo="", TruongDT="", UuDiem="", HoTen="";
            DateTime NgaySinh=DateTime.Now;
            Locator.server.getThongTinGiaSu_private(Locator.author.UserName,
                                                     ref gsid,
                                                    ref HoTen,
                                                    ref GioiTinh,
                                                     ref NgaySinh,
                                                     ref DiaChi,
                                                    ref SDT,
                                                    ref Cmnd,
                                                    ref QueQuan,
                                                    ref TrinhDo,
                                                    ref TruongDT,
                                                    ref UuDiem);
            tbTruong.Text = TruongDT;
            tbTen.Text = HoTen;
            tbDiaChi.Text = DiaChi;
            tbQueQuan.Text = QueQuan;
            dtpNgaySinh.Value = NgaySinh;
            tbSDT.Text = SDT;
            tbUuDiem.Text = UuDiem;
            cbbGioiTinh.Text = GioiTinh;
            tbTrinhDo.Text = TrinhDo;
            lbGSID.Text = gsid.ToString();
            tbUser.Text=Locator.author.UserName;
            tbPass.Text = "*****";
            tbCMND.Text = Cmnd;
        }

        private void tbUuDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
