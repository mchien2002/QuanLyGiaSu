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
using System.Windows.Forms.VisualStyles;

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class SuaThongTinLop : Form
    {
        public SuaThongTinLop()
        {
            InitializeComponent();
        }

        private void SuaTTLop_Load(object sender, EventArgs e)
        {
            string TenLop = "", DiaChi = "", MucLuong = "", TGDK = "", SDT = "", SB = "", HinhTDay = "", ThoiGH = "", TTHocVien = "", YeuCau = "", TrangThai = "";
            string[] MonHoc = new string[100];
            Locator.server.fetchLopMoiLMID(Locator.LMID, ref TenLop, ref DiaChi, ref MucLuong, ref TGDK, ref SDT, ref SB, ref HinhTDay, ref ThoiGH, ref TTHocVien, ref YeuCau, ref TrangThai, ref MonHoc);
            tbTenLop.Text = TenLop;
            tbDiaChi.Text = DiaChi;
            tbMucLuong.Text = MucLuong;
            dtpTGDK.Value = Convert.ToDateTime(TGDK);
            tbSDT.Text = SDT;
            tbSoBuoi.Text = SB;
            tbHinhThucDay.Text =HinhTDay;
            tbThoiGianHoc.Text = ThoiGH;
            tbThongTinHocVien.Text = TTHocVien;
            tbYeuCau.Text = YeuCau;
            tbTrangThai.Text = TrangThai;
            foreach(string x in Locator.server.fetchMonHoc())
            {
                clbMonHoc.Items.Add(x);
                foreach (string y in MonHoc)
                {           
                    if(y!=null)

                    if (y.Trim() == x.Trim())
                    {
                        clbMonHoc.SetItemCheckState(clbMonHoc.Items.IndexOf(x), CheckState.Checked);
                    }
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
