using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.database;
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Locator.server.updateInfoTutor(tbUser.Text, tbHoTen.Text, tbCMND.Text, cbbGioiTinh.Text, dtpNgaySinh.Value, tbSDT.Text, tbQueQuan.Text, tbDiaChi.Text, tbTruongDT.Text, tbTrinhDo.Text, tbUuDiem.Text);
            
            Locator.server.updateAccount(tbUser.Text, tbPass.Text, tbEmail.Text);
            this.Close();
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
            string trinhDo,
            string[] monHoc,
            string[] lopHoc
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

            foreach (string x in Locator.server.fetchMonHoc())
            {
                clbMonDay.Items.Add(x);
                foreach (string y in monHoc)
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
                foreach (string y in lopHoc)
                {
                    if (y != null)

                        if (y.Trim() == x.Trim())
                        {
                            clbLopDay.SetItemCheckState(clbLopDay.Items.IndexOf(x), CheckState.Checked);
                        }
                }
            }
        }


    }
}
