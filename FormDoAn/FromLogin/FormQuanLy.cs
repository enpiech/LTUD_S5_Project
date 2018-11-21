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
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Yêu cầu xác nhận trước khi đóng form
        /// </summary>
        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Đăng xuất tài khoản nhân viên hiện tại
        /// </summary>
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

            // Mở form đăng nhập
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }

        /// <summary>
        /// Mở bảng khi theo lựa chọn trong combobox
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string tenBang = this.cboTenBang.Text;
            if (tenBang == "Loại Xe")
            {
                frmLoaiXe formLoaiXe = new frmLoaiXe();
                formLoaiXe.Show();
                this.Hide();
            }
            else if (tenBang == "Hãng Xe")
            {
                frmHangXe formHangXe = new frmHangXe();
                formHangXe.Show();
                this.Hide();
            }
            else if (tenBang == "Xe")
            {
                frmXe formXe = new frmXe();
                formXe.Show();
                this.Hide();
            }
            else if (tenBang == "Loại Nhân Viên")
            {
                frmLoaiNhanVien formLoaiNhanVien = new frmLoaiNhanVien();
                formLoaiNhanVien.Show();
                this.Hide();
            }
            else if (tenBang == "Nhân Viên")
            {
                frmNhanVien formNhanVien = new frmNhanVien();
                formNhanVien.Show();
                this.Hide();
            }
            else if (tenBang == "Tài Khoản Nhân Viên")
            {
                frmTaiKhoanNhanVien formTaiKhoan = new frmTaiKhoanNhanVien();
                formTaiKhoan.Show();
                this.Hide();
            }
            else if (tenBang == "Khách Hàng")
            {
                frmNhanVien formNhanVien = new frmNhanVien();
                formNhanVien.Show();
                this.Hide();
            }
        }
    }
}
