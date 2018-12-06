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
        /// <summary>
        /// Xóa text box cho 2 field của login form
        /// </summary>
        public void clearTexts(string taiKhoan, string matKhau)
        {
            taiKhoan = String.Empty;
            matKhau = String.Empty;
        }

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        /// <param name="taiKhoan">Mã tài khoản cần kiểm tra</param>
        /// <param name="matKhau">Mật khẩu cần kiểm tra</param>
        /// <returns>true Nếu có lỗi nhập liệu</returns>
        private bool coLoi(string taiKhoan, string matKhau)
        {
            // Kiểm tra nếu người dùng chưa nhập mã tài khoản
            if (!KiemTraNhapLieu.khongRong(taiKhoan))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản!");
                return true;
            }
            // Kiểm tra nếu người dùng chưa nhập matKhau
            else if (!KiemTraNhapLieu.khongRong(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi và kiểm tra người dùng đăng nhập thành công
        /// </summary>
        public bool isLoggedIn(string taiKhoan, string matKhau)
        {
            // Kiểm tra lỗi nhập liệu
            if (!coLoi(taiKhoan, matKhau))
            {
                DB db = new DB();
                db.moKetNoi();

                // Nếu xác nhận đúng mã tài khoản và mật khẩu
                if (db.kiemTraDangNhap(taiKhoan, matKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    db.dongKetNoi();
                    return true;
                }    
            }

            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            return false;
        }
    }
}
