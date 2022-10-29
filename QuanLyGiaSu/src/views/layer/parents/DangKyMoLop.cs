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
    public partial class DangKyMoLop : Form
    {
        public DangKyMoLop()
        {
            InitializeComponent();
            btnRegister.Enabled = false;
            tbSoTien.Enabled = false;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            DateTime DTNow=DateTime.Now.Date;
            int LHID=0;
            if (!Locator.server.insertDSML(cbbClasses.SelectedText, Locator.author.UserName,
                tbDiaChi.Text, Int32.Parse(nudMucLuong.Value.ToString()), tbSDT.Text, DTNow, int.Parse(nudSoBuoi.Value.ToString()),
                tbHinhThucDay.Text, tbThoiGianHoc.Text, tbThongTinHocVien.Text,
                tbYeuCau.Text, ref LHID))
            {
                MessageBox.Show("Thêm lớp mới thất bại");
            }
            else
            {
                
                foreach (var x in clbSubjects.CheckedItems)
                {
                    if (!Locator.server.insertMonHocLopMoi(LHID, x.ToString()))
                    {
                        MessageBox.Show("Không thể thêm môn cho lớp mới");
                    }
                }
                MessageBox.Show("Thêm lớp mới thành công");
            }


            this.Close();
        }

        private void DangKyMoLop_Load(object sender, EventArgs e)
        {
            if (!(tbSDT.Text.ToString().Trim() == ""
                || tbHinhThucDay.Text.ToString().Trim() == ""
                || tbThoiGianHoc.Text.ToString().Trim() == ""
                || tbThongTinHocVien.Text.ToString().Trim() == ""
                || tbDiaChi.Text.ToString().Trim() == ""
                || tbYeuCau.Text.ToString().Trim() == "")) btnRegister.Enabled = true ;
            else btnRegister.Enabled = false ;
        }
    }
}
