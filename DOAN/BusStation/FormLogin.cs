using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusStation
{
    public partial class frmLogin : Form
    {
        private NhanVien nhanVien;

        internal NhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }
        //internal NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thoát chương trình
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Xác nhận trước khi đóng form
        /// </summary>
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu người dùng chưa đăng nhập
            if (this.NhanVien == null)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Truyền dữ liệu vào main form
        /// </summary>
        private void enableFormMain()
        {
            NhanVien = new NhanVien("NV1", "QL");
            ((frmMain)this.MdiParent).NhanVienHienTai = NhanVien;

            ((frmMain)this.MdiParent).enableFormMain();
        }

        /// <summary>
        /// Kiểm tra tài khoản nhân viên và mật khẩu rồi đăng nhập vào hệ thống
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if(login.isLoggedIn(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                // Truyền dữ liệu vào form main
                enableFormMain();

                // Đóng form hiện tại
                this.Close();

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }


    }
}
