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

namespace QuanLyGiaSu.src.app.views.Login
{
    public partial class NhapThongTinPhuHuynh : Form
    {
        public NhapThongTinPhuHuynh()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //  TẠO ACCOUNT
            if (Locator.server.addAccount(Locator.author))
            {
                // UPDATE THÔNG TIN
                if (!Locator.server.updateParent(
                    Locator.author.UserName,
                    tbNamePH.Text,
                    tbPhonePH.Text,
                    Convert.ToDateTime(dtBirthDayPH.Value.ToString()),
                    tbAddressPH.Text,
                    tbJobPH.Text,
                    cbbGender.Text,
                    tbCmndPH.Text
                    ))
                {
                    return;
                }
            }
            else
            {
                return;
            }

            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        bool checkButton()
        {
            if (
                tbNamePH.Text.Length > 0
                && tbPhonePH.Text.Length > 0
                && dtBirthDayPH.Text.Length > 0
                && tbAddressPH.Text.Length > 0
                && tbJobPH.Text.Length > 0
                && cbbGender.Text.Length > 0
                && tbCmndPH.Text.Length > 0) return true;
            return false;
        }

        private void tmCheckBtn_Tick(object sender, EventArgs e)
        {
            if (!checkButton())
            {
                btnRegisterPH.Enabled = false;
                btnRegisterPH.BackColor = Color.Gray;
            }
            else
            {
                btnRegisterPH.Enabled = true;
                btnRegisterPH.BackColor = Color.Blue;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void NhapThongTinPhuHuynh_Load(object sender, EventArgs e)
        {

        }
    }
}
