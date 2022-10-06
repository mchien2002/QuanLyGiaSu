using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy_Nhom13
{
    public partial class UC_LichSuGiaoDich : UserControl
    {
        public UC_LichSuGiaoDich()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void UC_LichSuGiaoDich_Load(object sender, EventArgs e)
        {

        }
    }
}
