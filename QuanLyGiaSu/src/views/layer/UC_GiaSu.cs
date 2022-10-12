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
    public partial class UC_GiaSu : UserControl
    {
        public UC_GiaSu()
        {
            InitializeComponent();
            
        }

        private void UC_GiaSu_Load(object sender, EventArgs e)
        {
            tbTruong.Focus();
        }

        private void tbUuDiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
