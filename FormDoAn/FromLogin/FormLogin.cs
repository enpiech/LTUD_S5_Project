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
    public partial class frmLogin : Form
    {
        private NhanVien nhanVien;
        internal NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public frmLogin()
        {
            this.NhanVien = new NhanVien();
            this.NhanVien.IsLogged = false;
            this.NhanVien.MaNV = string.Empty;
            this.NhanVien.TenNV = string.Empty;
            this.NhanVien.LoaiNV = string.Empty;
            this.NhanVien.Luong = 0;

            InitializeComponent();
        }

        // Tên đăng nhập và mật khẩu để test
        Login login = new Login("thaihoangtuan", "1999");

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
            if (this.NhanVien.IsLogged == false)
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

        private void getThongTinNhanVien()
        {
            this.NhanVien.LoaiNV = "QL";
            this.NhanVien.IsLogged = true;
        }

        /// <summary>
        /// Kiểm tra tài khoản nhân viên và mật khẩu rồi đăng nhập vào hệ thống
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ 2 textbox
            string user = this.txtUser.Text.Trim();
            string pass = this.txtPassword.Text.Trim();

            // Nếu người dùng đăng nhập thành công thì mở form main
            if (login.isLoggedIn(user, pass))
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Lấy thông tin nhân viên hiện tại
                getThongTinNhanVien();

                // Mở form theo loại nhân viên dựa theo mã số nhân viên sau khi đăng nhập
                frmMain formMain = new frmMain();
                formMain.moFormTheoLoaiNV(this.NhanVien.LoaiNV);

                // Đóng form hiện tại
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }
    }
}
