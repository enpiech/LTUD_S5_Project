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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mở form theo loại nhân viên của tài khoản vừa đang nhập
        /// </summary>
        public void moFormTheoLoaiNV(string loaiNV)
        {
            // Nếu là nhân viên quản lý thì mở form quản lý cơ sở dữ liệu
            if (loaiNV == "QL")
            {
                frmQuanLy formQuanLy = new frmQuanLy();
                formQuanLy.Show();
            }
            // Nếu là nhân viên phòng vé thì mở form bán vé
            else if (loaiNV == "PV")
            {
                frmBanVe formBanVe = new frmBanVe();
                formBanVe.Show();
            }
            // Nếu là kế toán thì mở form tính toán lương
            else if (loaiNV == "KT")
            {
                frmTinhTien formTinhTien = new frmTinhTien();
                formTinhTien.Show();
            }
        }

        /// <summary>
        /// Xử lí dữ liệu khi mở form
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Mở form yêu cầu đăng nhập khi khởi động chương trình
            frmLogin formLogin = new frmLogin();
            formLogin.MdiParent = this;
            formLogin.Show();
        }

        /// <summary>
        /// Đóng ứng dụng
        /// </summary>
        private void menuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Đăng xuất tài khoản nhân viên và mở lại form đăng nhập
        /// </summary>
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.MdiParent = this;
            formLogin.Show();
        }
    }
}
