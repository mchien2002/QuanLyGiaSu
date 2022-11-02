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
    public partial class UC_QuanLyPhuHuynh : UserControl
    {
        public UC_QuanLyPhuHuynh()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();

        }


        private void UC_QuanLyPhuHuynh_Load(object sender, EventArgs e)
        {
            dgvQuanLyPhuHuynh.DataSource = Locator.server.fetchPhuHuynhAD();
        }

        private void ThemPhuHuynh_Click(object sender, EventArgs e)
        {
            ThemAccount themAccount = new ThemAccount("THÊM PHỤ HUYNH");
            themAccount.Show();
        }

        private void dgvQuanLyPhuHuynh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyPhuHuynh.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null )
            {
                dgvQuanLyPhuHuynh.CurrentRow.Selected = true;
            }    
        }

        private void SuaThongTinPhuHuynh_Click(object sender, EventArgs e)
        {
            SuaPhuHuynh suaPhuHuynh = new SuaPhuHuynh();
            try
            {
                string hoTen;
                string CMND;
                string ngaySinh;
                string gioiTinh;
                string SDT;
                string ngheNghiep;
                string diaChi;
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[2].Value.ToString() == null)
                {
                    hoTen = "";
                }
                else
                    hoTen = dgvQuanLyPhuHuynh.CurrentRow.Cells[2].Value.ToString();
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[8].Value.ToString() == null)
                {
                    CMND = "";
                }
                else
                    CMND = dgvQuanLyPhuHuynh.CurrentRow.Cells[8].Value.ToString();
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[4].Value.ToString() == null)
                {
                    ngaySinh = "";
                }
                else
                    ngaySinh = dgvQuanLyPhuHuynh.CurrentRow.Cells[4].Value.ToString();
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[3].Value.ToString() == null)
                {
                    gioiTinh = "";
                }
                else
                    gioiTinh = dgvQuanLyPhuHuynh.CurrentRow.Cells[3].Value.ToString();
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[7].Value.ToString() == null)
                {
                    SDT = "";
                }
                else
                    SDT = dgvQuanLyPhuHuynh.CurrentRow.Cells[7].Value.ToString();
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[5].Value.ToString() == null)
                {
                    ngheNghiep = "";
                }
                else
                    ngheNghiep = dgvQuanLyPhuHuynh.CurrentRow.Cells[5].Value.ToString();
                if (dgvQuanLyPhuHuynh.CurrentRow.Cells[6].Value.ToString() == null)
                {
                    diaChi = "";
                }
                else
                    diaChi = dgvQuanLyPhuHuynh.CurrentRow.Cells[6].Value.ToString();
                suaPhuHuynh.ShowThongTinPhuHuynh(dgvQuanLyPhuHuynh.CurrentRow.Cells[0].Value.ToString(),
                    dgvQuanLyPhuHuynh.CurrentRow.Cells[1].Value.ToString(),
                    hoTen,
                    CMND,
                    ngaySinh,
                    gioiTinh,
                    SDT,
                    ngheNghiep,
                    diaChi
                    );
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            suaPhuHuynh.Show();
        }

        private void dgvQuanLyPhuHuynh_MouseMove(object sender, MouseEventArgs e)
        {
            //UC_QuanLyPhuHuynh_Load(sender, e);
        }
    }
}
