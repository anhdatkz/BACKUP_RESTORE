using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BACKUP_RESTORE
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }


        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }


        private void executeLogin()
        {
            if (textBox_username.Text.Trim() == "")
            {
                MessageBox.Show("Tài Khoản đăng nhập không được rỗng!", "Báo lỗi đăng nhập.", MessageBoxButtons.OK);
                textBox_username.Focus();
                return;
            }

            Program.username = textBox_username.Text;
            Program.password = textBox_password.Text;

            try
            {

                if (Program.KetNoi() == 0) return;

                Program.frmChinh = new Form_Main();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password incorrect " + ex.Message, "Error message", MessageBoxButtons.OK);
                textBox_username.Focus();
                return;
            }
        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = (checkBox_show.Checked) ? false : true;
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
