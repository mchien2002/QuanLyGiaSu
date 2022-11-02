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
            int LMID=0;
            if (!Locator.server.insertDSML(cbbClasses.Text.ToString(), Locator.author.UserName,
                tbDiaChi.Text, Int32.Parse(nudMucLuong.Value.ToString()), tbSDT.Text, DTNow, int.Parse(nudSoBuoi.Value.ToString()),
                tbHinhThucDay.Text, tbThoiGianHoc.Text, tbThongTinHocVien.Text,
                tbYeuCau.Text, ref LMID) || Locator.author.NganSach < 200000)
            {
                if (Locator.author.NganSach < 200000)
                {
                    MessageBox.Show("Nạp thêm tiền để mở lớp");
                }
                MessageBox.Show("Thêm lớp mới thất bại");
            }
            else{
                
                foreach (var x in clbSubjects.CheckedItems.OfType<String>().ToList())
                {
                    if (!Locator.server.insertMonHocLopMoi(LMID, x))
                    {
                        MessageBox.Show("Không thể thêm môn cho lớp mới");
                    }
                }
            }
            this.Close();
        }

        private void DangKyMoLop_Load(object sender, EventArgs e)
        {
            foreach (string item in Locator.server.fetchLopHoc())
            {
                cbbClasses.Items.Add(item);
            }
            foreach(string item in Locator.server.fetchMonHoc())
            {
                clbSubjects.Items.Add((string)item);
            }
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            if (!(tbSDT.Text.ToString().Trim() == ""
                || tbHinhThucDay.Text.ToString().Trim() == ""
                || tbThoiGianHoc.Text.ToString().Trim() == ""
                || tbThongTinHocVien.Text.ToString().Trim() == ""
                || tbDiaChi.Text.ToString().Trim() == ""
                || tbYeuCau.Text.ToString().Trim() == "")) btnRegister.Enabled = true;
            else btnRegister.Enabled = false;
        }
    }
}
