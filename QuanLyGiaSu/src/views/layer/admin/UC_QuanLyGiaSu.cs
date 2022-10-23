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
    public partial class UC_QuanLyGiaSu : UserControl
    {
        TRUNGTAMGIASUDataContext db;
        public UC_QuanLyGiaSu()
        {
            InitializeComponent();
            db = new TRUNGTAMGIASUDataContext();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Lớp Dạy")
            {
               tb_TimKiem.Hide();
                cbb_TimKiem.Visible = true;
            }
            else
            {
                cbb_TimKiem.Hide();
                tb_TimKiem.Visible = true;
            }
        }

        private void UC_QuanLyGiaSu_Load(object sender, EventArgs e)
        {
            cbb_TimKiem.Hide();
            dgvQuanLyGiaSu.DataSource=Locator.server.fetchGiaSuTable();
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
                if (dgvQuanLyGiaSu.CurrentRow.Cells[11].Value.ToString() == null)
                {
                    truongDT = "";
                }
                else
                    truongDT = dgvQuanLyGiaSu.CurrentRow.Cells[11].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[2].Value.ToString() == null)
                {
                    hoTen = "";
                }
                else
                    hoTen = dgvQuanLyGiaSu.CurrentRow.Cells[2].Value.ToString();
                if (dgvQuanLyGiaSu.CurrentRow.Cells[5].Value.ToString() == null)
                {
                    ngaySinh = "";
                }
                else
                    ngaySinh = dgvQuanLyGiaSu.CurrentRow.Cells[5].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[3].Value.ToString() == null)
                {
                    gioiTinh = "";
                }
                else
                    gioiTinh = dgvQuanLyGiaSu.CurrentRow.Cells[3].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[6].Value.ToString() == null)
                {
                    soDienThoai = "";
                }
                else
                    soDienThoai = dgvQuanLyGiaSu.CurrentRow.Cells[6].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[4].Value.ToString() == null)
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

                if (dgvQuanLyGiaSu.CurrentRow.Cells[9].Value.ToString() == null)
                {
                    queQuan = "";
                }
                else
                    queQuan = dgvQuanLyGiaSu.CurrentRow.Cells[9].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[12].Value.ToString() == null)
                {
                    uuDiem = "";
                }
                else
                    uuDiem = dgvQuanLyGiaSu.CurrentRow.Cells[12].Value.ToString();

                if (dgvQuanLyGiaSu.CurrentRow.Cells[10].Value.ToString() == null)
                {
                    trinhDo = "";
                }
                else
                    trinhDo = dgvQuanLyGiaSu.CurrentRow.Cells[10].Value.ToString();


                suaGiaSu1.ShowThongTinGiaSu(dgvQuanLyGiaSu.CurrentRow.Cells[0].Value.ToString(),
                               truongDT,
                               hoTen,
                               ngaySinh,
                               gioiTinh,
                               soDienThoai,
                               cmnd,
                               diaChi,
                               queQuan,
                               uuDiem,
                               trinhDo
                               );
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            suaGiaSu1.Show();
        }

        private void ThemGiaSu_Click(object sender, EventArgs e)
        {
            ThemAccount themAccount = new ThemAccount();
            themAccount.Show();
        }

        private void dgvQuanLyGiaSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyGiaSu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQuanLyGiaSu.CurrentRow.Selected = true;
            }
        }
    }
}
