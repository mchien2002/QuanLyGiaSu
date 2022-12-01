using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class UC_QuanLyGiaSu : UserControl
    {
        TRUNGTAMGIASUDataContext db;
        public UC_QuanLyGiaSu()
        {
            InitializeComponent();
            db = new TRUNGTAMGIASUDataContext();
            cbb_TimTheo.Text = cbb_TimTheo.Items[0].ToString();
            timer1.Start();
        }


        private void UC_QuanLyGiaSu_Load(object sender, EventArgs e)
        {
            dgvQuanLyGiaSu.DataSource=Locator.server.fetchGiaSuTable();
            cbb_TimTheo.Text = "Tất Cả";
        }

        private void SuaThongTinGiaSu_Click(object sender, EventArgs e)
        {
            SuaGiaSu suaGiaSu1 = new SuaGiaSu();
            try                  
            {
                string truongDT;
                string hoTen;
                string ngaySinh;
                string gioiTinh;
                string soDienThoai;
                string cmnd;
                string diaChi;
                string queQuan;
                string uuDiem;
                string trinhDo;
                string[] monHoc = new string[100];
                string[] lopHoc=new string[100];
                if(dgvQuanLyGiaSu.CurrentRow.Cells[7].Value != null)
                {
                    monHoc = dgvQuanLyGiaSu.CurrentRow.Cells[7].Value.ToString().Split(new Char[] { ' ', ','});
                }
                if(dgvQuanLyGiaSu.CurrentRow.Cells[8].Value != null)
                {
                    lopHoc = dgvQuanLyGiaSu.CurrentRow.Cells[8].Value.ToString().Split(new Char[] { ' ', ',' });
                }
                if (dgvQuanLyGiaSu.CurrentRow.Cells[11].Value == null)
                {
                    truongDT = "";
                }
                else
                    truongDT = dgvQuanLyGiaSu.CurrentRow.Cells[11].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[2].Value == null)
                {
                    hoTen = "";
                }
                else
                    hoTen = dgvQuanLyGiaSu.CurrentRow.Cells[2].Value.ToString();
                if (dgvQuanLyGiaSu.CurrentRow.Cells[5].Value == null)
                {
                    ngaySinh = "";
                }
                else
                    ngaySinh = dgvQuanLyGiaSu.CurrentRow.Cells[5].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[3].Value == null)
                {
                    gioiTinh = "";
                }
                else
                    gioiTinh = dgvQuanLyGiaSu.CurrentRow.Cells[3].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[6].Value == null)
                {
                    soDienThoai = "";
                }
                else
                    soDienThoai = dgvQuanLyGiaSu.CurrentRow.Cells[6].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[4].Value == null)
                {
                    cmnd = "";
                }
                else
                    cmnd = dgvQuanLyGiaSu.CurrentRow.Cells[4].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[13].Value == null)
                {
                    diaChi = "";
                }
                else
                    diaChi = dgvQuanLyGiaSu.CurrentRow.Cells[13].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[9].Value == null)
                {
                    queQuan = "";
                }
                else
                    queQuan = dgvQuanLyGiaSu.CurrentRow.Cells[9].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[12].Value == null)
                {
                    uuDiem = "";
                }
                else
                    uuDiem = dgvQuanLyGiaSu.CurrentRow.Cells[12].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[10].Value == null)
                {
                    trinhDo = "";
                }
                else
                    trinhDo = dgvQuanLyGiaSu.CurrentRow.Cells[10].Value.ToString();


                suaGiaSu1.ShowThongTinGiaSu(dgvQuanLyGiaSu.CurrentRow.Cells[0].Value.ToString(),
                    dgvQuanLyGiaSu.CurrentRow.Cells[1].Value.ToString(),
                               truongDT,
                               hoTen,
                               ngaySinh,
                               gioiTinh,
                               soDienThoai,
                               cmnd,
                               diaChi,
                               queQuan,
                               uuDiem,
                               trinhDo,
                               monHoc,
                               lopHoc
                               );
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //string accid = dgvQuanLyGiaSu.CurrentRow.Cells[1].Value.ToString();
            suaGiaSu1.FormClosing += new FormClosingEventHandler(this.SuaThongTinGiaSu_FormClosing);
            suaGiaSu1.Show();
        }

        private void ThemGiaSu_Click(object sender, EventArgs e)
        {
            ThemAccount themAccount = new ThemAccount();
            themAccount.FormClosing += new FormClosingEventHandler(this.SuaThongTinGiaSu_FormClosing);
            themAccount.Show();
        }

        private void dgvQuanLyGiaSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQuanLyGiaSu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQuanLyGiaSu.CurrentRow.Selected = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_TimGS_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_TimTheo.Text == "Mã Gia Sư")
                {
                    dgvQuanLyGiaSu.DataSource = Locator.server.TimKiemGiaSu_GSID(Convert.ToInt32(tb_TimKiem.Text));
                }
                else if (cbb_TimTheo.Text == "Account ID")
                {
                    dgvQuanLyGiaSu.DataSource = Locator.server.TimKiemGiaSu_ACCID(Convert.ToInt32(tb_TimKiem.Text));
                }
                else if (cbb_TimTheo.Text == "Tên Gia Sư")
                {
                    dgvQuanLyGiaSu.DataSource = Locator.server.TimKiemGiaSu_TenGS(tb_TimKiem.Text);
                }
                else if (cbb_TimTheo.Text == "Môn Dạy")
                {
                    dgvQuanLyGiaSu.DataSource = Locator.server.TimKiemGiaSu_MonDay(tb_TimKiem.Text.Trim());
                }
                else if (cbb_TimTheo.Text == "Lớp Dạy")
                {
                    dgvQuanLyGiaSu.DataSource = Locator.server.TimKiemGiaSu_LopDay(cbb_TimKiem.Text.Trim());
                }
                else
                {
                    dgvQuanLyGiaSu.DataSource = dgvQuanLyGiaSu.DataSource = Locator.server.fetchGiaSuTable();
                }

            }
            catch 
            {
                dgvQuanLyGiaSu.DataSource = Locator.server.fetchGiaSuTable();
            }

        }

        private void cbbTimTheoGS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheo.Text == "Tất Cả")
            {
                tb_TimKiem.Text = "";
                tb_TimKiem.Enabled = false;
                tb_TimKiem.Visible = true;
                cbb_TimKiem.Hide();
                dgvQuanLyGiaSu.DataSource = Locator.server.fetchGiaSuTable();
            }
            else if (cbb_TimTheo.Text == "Lớp Dạy")
            {
                tb_TimKiem.Hide();
                cbb_TimKiem.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else
            {
                cbb_TimKiem.Hide();
                tb_TimKiem.Visible = true;
                tb_TimKiem.Enabled = true;
            }
        }

        private void XoaGiaSu_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyGiaSu_Load(sender, e);
        }
        private void SuaThongTinGiaSu_FormClosing(object sender,FormClosingEventArgs e)
        {
            UC_QuanLyGiaSu_Load(sender, e);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvQuanLyGiaSu.Rows.Count - 1; i++)
            {
                if (dgvQuanLyGiaSu.Rows[i].Cells[3].Value.ToString() == "Nữ")
                {
                    dgvQuanLyGiaSu.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                }
                else
                {
                    dgvQuanLyGiaSu.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 246, 143);

                }
            }
        }
    }
}
