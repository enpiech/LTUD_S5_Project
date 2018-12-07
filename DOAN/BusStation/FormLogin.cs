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

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thoát chương trình
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Truyền dữ liệu vào main form
        /// </summary>
        private void moFormMain()
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmMain")
                {
                    NhanVien = new NhanVien("NV1", "QL");
                    ((frmMain)form).NVHienTai = NhanVien;
                    ((frmMain)form).moChucNangFormMain();
                }
            } 
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
                moFormMain();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }


    }
}
