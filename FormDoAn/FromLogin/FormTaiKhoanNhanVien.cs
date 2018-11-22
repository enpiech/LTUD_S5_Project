using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class frmTaiKhoanNhanVien : Form
    {
        public frmTaiKhoanNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kiểm tra chuỗi chỉ chứa các kí từ là chữ
        /// </summary>
        private bool stringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra nếu chuỗi nhập vào là số
        /// </summary>
        private bool integerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
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
        /// Sửa tài khoản nhân viên trong cơ sở dữ liệu
        /// </summary>
        private bool suaTaiKhoan()
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
        /// KIểm tra lỗi nhập liệu
        /// </summary>
        private bool isError()
        {
            string taiKhoan = this.txtTaiKhoan.Text.Trim();
            string matKhau = this.txtMatKhau.Text.Trim();

            // Kiểm tra nếu người dùng đã nhập tài khoản mới
            if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản mới!");
                return true;
            }
            else if (!stringValidator(taiKhoan))
            {
                MessageBox.Show("Mã tài khoản không phù hợp, vui lòng nhập lại!");
                return true;
            }
            // Kiểm tra nếu người dùng đã nhập mật khẩu
            else if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return true;
            }
            else if (!integerValidator(matKhau))
            {
                MessageBox.Show("Mật khẩu không phù hợp, vui lòng nhập lại!");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi và thêm tài khoản mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isError())
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
        /// Xác nhận truóc khi xóa
        /// </summary>
        /// <returns></returns>
        private bool deleteConfirm()
        {
            string taiKhoan = this.txtTaiKhoan.Text;

            if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng chọn xe muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra và xóa tài khoản đã chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (deleteConfirm())
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
        /// Trở về form chọn bảng
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form form in ((frmMain)this.MdiParent).MdiChildren)
            {
                if (form.Text == "Quản Lý")
                {
                    form.Visible = true;
                    break;
                }
            }
            this.Close();
        }

        /// <summary>
        /// Sửa tài khoản đã chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isError())
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
    }
}
