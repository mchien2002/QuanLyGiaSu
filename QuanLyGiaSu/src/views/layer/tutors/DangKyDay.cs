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
    public partial class DangKyDay : Form
    {
        public DangKyDay()
        {
            InitializeComponent();
        }

        private void DangKyDay_Load(object sender, EventArgs e)
        {
            Locator.author.NganSach = Locator.server.getNganSach(Locator.author.UserName);
            string TenLop = "", DiaChi = "", MucLuong = "", TGDK = "", SDT = "", SB = "", HinhTDay = "", ThoiGH = "", TTHocVien = "", YeuCau = "", TrangThai = "";
            string[] MonHoc = new string[100];
            Locator.server.fetchLopMoiLMID(Locator.LMID, ref TenLop, ref DiaChi, ref MucLuong, ref TGDK, ref SDT, ref SB, ref HinhTDay, ref ThoiGH, ref TTHocVien, ref YeuCau, ref TrangThai, ref MonHoc);
            tbClasses.Text = TenLop;
            tbDiaChi.Text = DiaChi;
            tbMucLuong.Text = MucLuong;
            dtpTGDK.Value = Convert.ToDateTime(TGDK);
            tbSDT.Text = SDT;
            tbSoBuoi.Text = SB;
            tbHinhThucDay.Text = HinhTDay;
            tbThoiGianHoc.Text = ThoiGH;
            tbThongTinHocVien.Text = TTHocVien;
            tbYeuCau.Text = YeuCau;
            tbSoTien.Text = Convert.ToString(0.4 * Int32.Parse(tbMucLuong.Text.ToString()));

            foreach (string x in Locator.server.fetchMonHoc())
            {
                clbSubjects.Items.Add(x);
                foreach (string y in MonHoc)
                {
                    if (y != null)

                        if (y.Trim() == x.Trim())
                        {
                            clbSubjects.SetItemCheckState(clbSubjects.Items.IndexOf(x), CheckState.Checked);
                        }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (Locator.author.NganSach >= Int32.Parse(tbSoTien.Text))
                if (Locator.server.insertDSDK(Locator.author.UserName, Locator.LMID, DateTime.Now))
                {
                    MessageBox.Show("Đăng ký lớp thành công!");
                    Locator.author.NganSach = Locator.server.getNganSach(Locator.author.UserName);
                }
                else MessageBox.Show("Đăng ký thất bại!");
            else MessageBox.Show("Nạp tiền để đăng kí");
        }
    }
}
