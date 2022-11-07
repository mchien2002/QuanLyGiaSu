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
            btnUpdate.Enabled = false;
        }

        private void UC_GiaSu_Load(object sender, EventArgs e)
        {
            //tbTruong.Focus();
            int gsid=0;
            string GioiTinh="",DiaChi="", SDT="", Cmnd="", QueQuan="", TrinhDo="", TruongDT="", UuDiem="", HoTen="", Email="", Username="",Pw="";
            DateTime NgaySinh=DateTime.Now;
            string[] MonHoc = new string[100];
            string[] LopHoc = new string[100];
            if (Locator.server.getThongTinGiaSu_private(Locator.author.UserName,
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
                                                    ref UuDiem,
                                                    ref Email,
                                                    ref Pw,
                                                    ref MonHoc,
                                                    ref LopHoc))
            {
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
                tbUser.Text = Locator.author.UserName;
                tbPass.Text = "*********";
                tbCMND.Text = Cmnd;
                tbEmail.Text = Locator.author.Email = Email;
                btnUpdate.Enabled = true;
            }

            foreach (string x in Locator.server.fetchMonHoc())
            {
                clbMonDay.Items.Add(x);
                foreach (string y in MonHoc)
                {
                    if (y != null)

                        if (y.Trim() == x.Trim())
                        {
                            clbMonDay.SetItemCheckState(clbMonDay.Items.IndexOf(x), CheckState.Checked);
                        }
                }
            }
            foreach (string x in Locator.server.fetchLopHoc())
            {
                clbLopDay.Items.Add(x);
                foreach (string y in LopHoc)
                {
                    if (y != null)

                        if (y.Trim() == x.Trim())
                        {
                            clbLopDay.SetItemCheckState(clbLopDay.Items.IndexOf(x), CheckState.Checked);
                        }
                }
            }

        }

        private void tbUuDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> MonHoc = new List<string>();
            foreach (string item in clbMonDay.CheckedItems)
            {
                MonHoc.Add(item.ToString());
            }

            List<string> LopHoc = new List<string>();
            foreach (string item in clbLopDay.CheckedItems)
            {
                LopHoc.Add(item.ToString());
            }
            Locator.server.updateInfoTutor(Locator.author.UserName, tbTen.Text, tbCMND.Text, cbbGioiTinh.Text, dtpNgaySinh.Value, tbSDT.Text, tbQueQuan.Text, tbDiaChi.Text, tbTruong.Text, tbTrinhDo.Text, tbDiemManh.Text);
            Locator.server.updateInfoTutor_MH_LH(Locator.author.UserName, MonHoc, LopHoc);
            UC_GiaSu_Load(sender, e);
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
