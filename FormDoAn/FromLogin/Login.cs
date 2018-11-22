using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    class Login
    {
        private string inputMaTaiKhoan;
        private string matKhau;

        public string MaTaiKhoan { get => inputMaTaiKhoan; set => inputMaTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public Login(string inputMaTaiKhoan, string matKhau)
        {
            this.inputMaTaiKhoan = inputMaTaiKhoan;
            this.matKhau = matKhau;
        }

        public Login()
        {
            this.inputMaTaiKhoan = String.Empty;
            this.matKhau = String.Empty;
        }

        /// <summary>
        /// Xóa text box cho 2 field của login form
        /// </summary>
        public void clearTexts(string inputMaTaiKhoan, string matKhau)
        {
            inputMaTaiKhoan = String.Empty;
            inputMaTaiKhoan = String.Empty;
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
        /// Kiểm tra lỗi và kiểm tra người dùng đăng nhập thành công
        /// </summary>
        internal bool isLoggedIn(string inputMaTaiKhoan, string inputMatKhau)
        {
            // Kiểm tra nếu người dùng chưa nhập inputMaTaiKhoan
            if (string.IsNullOrEmpty(inputMaTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản!");
                return false;
            }
            // Kiểm tra inputMaTaiKhoan chỉ gồm các kí tự chữ
            else if (stringValidator(inputMaTaiKhoan))
            {
                MessageBox.Show("Mã tài khoản chỉ gồm các kí tự chữ cái!");
                return false;
            }
            else
            {
                // Kiểm tra nếu mã tài khoản nhập vào đúng
                if (inputMaTaiKhoan != MaTaiKhoan)
                {
                    MessageBox.Show("Tên đăng nhập không chính xác!");
                    // Xóa text box
                    clearTexts(inputMaTaiKhoan, inputMatKhau);
                    return false;
                }
                else
                {
                    // Kiểm tra nếu người dùng chưa nhập matKhau
                    if (string.IsNullOrEmpty(inputMatKhau))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu!");
                        return false;
                    }
                    // Kiểm tra nếu matKhau chỉ chứa các kí tự số
                    else if (integerValidator(inputMatKhau))
                    {
                        MessageBox.Show("Chỉ nhập các chữ số!");
                        return false;
                    }
                    // Kiểm tra nếu đúng matKhau
                    else if (inputMatKhau != MatKhau)
                    {
                        MessageBox.Show("Mật khẩu không chính xác!");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
