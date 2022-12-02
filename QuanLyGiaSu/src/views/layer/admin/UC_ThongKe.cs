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

namespace QuanLyGiaSu.src.views.layer.admin
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_ThongKe_Load(sender, e);
        }

        public void LoadMonthly()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Monthly");

            List<(string time, string total)> totalList = Locator.server.total_Monthly();
               
            foreach (var x in totalList)
            {
                chart1.Series["Monthly"].Points.AddXY(x.time, x.total);
            }
        }
        public void LoadYearly()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Yearly");

            List<(string time, string total)> totalList = Locator.server.total_annual();
            foreach (var x in totalList)
            {
                chart1.Series["Yearly"].Points.AddXY(x.time, x.total);
            }
        }
        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            LoadMonthly();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            try
            {
                if (chart1.Series["Monthly"].Enabled == true)
                {
                    LoadYearly();
                }
            }
            catch
            {
                LoadMonthly();
            }
        }
    }
}
