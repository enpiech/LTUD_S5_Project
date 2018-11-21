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
    public partial class frmTaiKhoanNhanVien : Form
    {
        public frmTaiKhoanNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm tài khoản nhân viên vào cơ sở dữ liệu
        /// </summary>
        private bool themTaiKhoan()
        {
            string taiKhoan = this.txtTaiKhoan.Text;
            string matKhau = this.txtMatKhau.Text;

            return false;
        }

        /// <summary>
        /// Xóa tìa khoản nhân viên khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaTaiKhoan()
        {
            string taiKhoan = this.txtTaiKhoan.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi và thêm tài khoản mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taiKhoan = this.txtTaiKhoan.Text;
            string matKhau = this.txtMatKhau.Text;

            // Kiểm tra nếu người dùng đã nhập tài khoản mới
            if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản mới!");
            }
            // Kiểm tra nếu người dùng đã nhập mật khẩu
            else if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                // Kiểm tra nếu thêm tài khoản thành công
                if (themTaiKhoan())
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm!");
                }
            }
        }

        /// <summary>
        /// Kiểm tra và xóa tài khoản đã chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string taiKhoan = this.txtTaiKhoan.Text;

            // Kiểm tra nếu người dùng đã nhập tài khoản mới
            if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản mới!");
            }
            else
            {
                // Kiểm tra nếu thêm tài khoản thành công
                if (xoaTaiKhoan())
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể xóa!");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmQuanLy formQuanLy = new frmQuanLy();
            formQuanLy.Show();
            this.Close();
        }  
    }
}
