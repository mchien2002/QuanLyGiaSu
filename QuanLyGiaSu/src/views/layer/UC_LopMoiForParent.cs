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
    public partial class UC_LopMoiForParent : UserControl
    {
        public UC_LopMoiForParent()
        {
            InitializeComponent();
        }

        private void btnDangKyMoLop_Click(object sender, EventArgs e)
        {
            DangKyDay dangKyDay = new DangKyDay();
            dangKyDay.Show();
        }

        private void cbbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearchType.Text == "Lớp Học")
            {
                tb_TimKiem.Hide();
                cbbSearch.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else if (cbbSearchType.Text == "Mã Lớp")
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible = true;
            }
            else
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible = true;
            }
        }

        private void UC_LopMoi2_Load(object sender, EventArgs e)
        {
            cbbSearch.Hide();
        }
    }
}
