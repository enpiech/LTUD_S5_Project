using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLogin
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want exit?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if(ctrl.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtUser, "Bạn phải nhập User name");
                txtUser.Focus();
            }else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtPass, "Bạn phải nhập Password");
                txtPass.Focus();
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            if(user == "thaihoangtuan" && pass == "1999")
            {
                MessageBox.Show("đăng nhập thành công");
            }else
            {
                MessageBox.Show("sai tên tài khoảng hoặc mật khẩu\nvui lòng kiểm tra lại!");
            }
        }
    }
}
