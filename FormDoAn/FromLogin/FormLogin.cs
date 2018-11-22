using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class frmLogin : Form
    {
        private NhanVien nhanVien;
        internal NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public frmLogin()
        {
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
        /// Lấy thông tin nhân viên từ cơ sở dữ liệu
        /// </summary>
        private void getNhanVienTuCSDL()
        {
            this.NhanVien = new NhanVien();

            this.NhanVien.IsLogged = false;
            this.NhanVien.MaNV = string.Empty;
            this.NhanVien.TenNV = string.Empty;
            this.NhanVien.LoaiNV = string.Empty;
            this.NhanVien.Luong = 0;

            this.NhanVien.LoaiNV = "QL";
            this.NhanVien.IsLogged = true;
        }

        /// <summary>
        /// Truyền dữ liệu vào main form
        /// </summary>
        private void enableFormMain()
        {
            ((frmMain)this.MdiParent).ActiveNhanVien = this.NhanVien;
            ((frmMain)this.MdiParent).enableFormMain();
        }

        /// <summary>
        /// Kiểm tra tài khoản nhân viên và mật khẩu rồi đăng nhập vào hệ thống
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ 2 textbox
            string user = this.txtUser.Text.Trim();
            string pass = this.txtPassword.Text.Trim();

            // Nếu người dùng đăng nhập thành công thì mở form main và truyền dữ liệu vào
            if (login.isLoggedIn(user, pass))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Lấy thông tin nhân viên vừa đăng nhập từ cơ sở dữ liệu
                getNhanVienTuCSDL();

                // Truyền dữ liệu vào form main
                enableFormMain();

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
