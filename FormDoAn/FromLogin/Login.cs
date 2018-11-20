using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromLogin
{
    class Login
    {
        private string maTaiKhoan;
        private string matKhau;

        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public Login(string maTaiKhoan, string matKhau)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.matKhau = matKhau;
        }

        public Login()
        {
            this.maTaiKhoan = String.Empty;
            this.matKhau = String.Empty;
        }

        // Xóa text box cho 2 field của login form
        public void clearTexts(string maTaiKhoan, string matKhau)
        {
            maTaiKhoan = String.Empty;
            maTaiKhoan = String.Empty;
        }

        // Kiểm tra chuỗi chỉ chứa các kí từ là chữ
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
        // Kiểm tra nếu chuỗi nhập vào là số
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

        internal bool isLoggedIn(string maTaiKhoan, string matKhau)
        {
            // Kiểm tra nếu người dùng chưa nhập maTaiKhoan
            if (string.IsNullOrEmpty(maTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập maTaiKhoan!");
                return false;
            }
            // Kiểm tra maTaiKhoan chỉ gồm các kí tự chữ
            else if (stringValidator(maTaiKhoan))
            {
                MessageBox.Show("Chỉ nhập các kí tự là chữ!");
                return false;
            }
            else
            {
                // Kiểm tra nếu maTaiKhoan đúng
                if (maTaiKhoan != MaTaiKhoan)
                {
                    MessageBox.Show("Tên đăng nhập không chính xác!");
                    clearTexts(maTaiKhoan, matKhau);
                    return false;
                }
                else
                {
                    // Kiểm tra nếu người dùng chưa nhập matKhau
                    if (string.IsNullOrEmpty(matKhau))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu!");
                        return false;
                    }
                    // Kiểm tra nếu matKhau chỉ chứa các kí tự số
                    else if (integerValidator(matKhau))
                    {
                        MessageBox.Show("Chỉ nhập các chữ số!");
                        return false;
                    }
                    // Kiểm tra nếu đúng matKhau
                    else if (matKhau != MatKhau)
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
