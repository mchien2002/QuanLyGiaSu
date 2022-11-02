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
    public partial class UC_ThongTinPhuHuynh : UserControl
    {
        public UC_ThongTinPhuHuynh()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void UC_ThongTinPhuHuynh_Load(object sender, EventArgs e)
        {
            //tbTruong.Focus();
            int PHID = 0;
            string GioiTinh = "", DiaChi = "", SDT = "", Cmnd = "",  HoTen = "", Email = "", Username = "", Pw = "", NgheNghiep="";
            DateTime NgaySinh = DateTime.Now;
            if (Locator.server.getThongTinPhuHuynh_private(Locator.author.UserName,
                                                     ref PHID,
                                                    ref HoTen,
                                                    ref GioiTinh,
                                                     ref NgaySinh,
                                                     ref DiaChi,
                                                    ref SDT,
                                                    ref Cmnd,
                                                    ref Email,
                                                    ref NgheNghiep,
                                                    ref Pw))
            {
                tbNamePH.Text = HoTen;
                tbCmndPH.Text = Cmnd;
                tbAddressPH.Text = DiaChi;
                dtpBirthDayPH.Value = NgaySinh;
                tbPhonePH.Text = SDT;
                lbPHID.Text = PHID.ToString();
                tbJobPH.Text = NgheNghiep;
                tbUsername.Text = Locator.author.UserName;
                tbPass.Text = Pw;
                tbEmail.Text = Locator.author.Email = Email;
                cbbGender.Text = GioiTinh;
                btnUpdate.Enabled = true;
                Locator.author.Password = Pw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbPass.Text);
            //MessageBox.Show(Locator.author.Password);
            //if(Locator.author.Password==tbPass.Text)
            //{
            //    Locator.author.Email=tbEmail.Text;
            //    Locator.server.updateAccount(Locator.author);
            //}
            //else
            //{
            //    Locator.author.Email = tbEmail.Text;
            //    Locator.author.Password=tbPass.Text;
            //    Locator.server.updateAccount(Locator.author);
            //}
            Locator.server.updateParent(tbUsername.Text, tbNamePH.Text, tbPhonePH.Text, dtpBirthDayPH.Value, tbAddressPH.Text, tbJobPH.Text, cbbGender.Text, tbCmndPH.Text);
            UC_ThongTinPhuHuynh_Load(sender, e);
        }
    }
}
