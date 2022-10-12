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
    public partial class UC_LopMoiForTutor : UserControl
    {
        TRUNGTAMGIASUDataContext db;
        public UC_LopMoiForTutor()
        {
            InitializeComponent();
            cbbSearchType.Text = cbbSearchType.Items[0].ToString();
            db = new TRUNGTAMGIASUDataContext();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbSearchType.Text == "Lớp Học")
            {
                tb_TimKiem.Hide();
                cbbSearch.Visible = true;
                //cbb_TimKiem.Hide();
            }
            else if(cbbSearchType.Text == "Mã Lớp")
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible=true;
            }
            else
            {
                cbbSearch.Hide();
                tb_TimKiem.Visible = true;
            }
        }

        private void UC_LopMoi_Load(object sender, EventArgs e)
        {
            cbbSearch.Hide();
            Locator.tutorController.fetchLopMoiTable(dgvTHONGTINLOPMOI);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DangKyMoLop_Click(object sender, EventArgs e)
        {

        }

        private void DangKyDay_Click(object sender, EventArgs e)
        {
            DangKyDay dangKyDay = new DangKyDay();
            dangKyDay.Show();
        }
    }
}
