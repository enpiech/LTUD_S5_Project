using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusStation
{
    class KiemTraNhapLieu
    {
        /// <summary>
        /// Kiểm tra chuỗi không phải chuỗi rỗng
        /// </summary>
        /// <param name="input">Chuỗi cần kiểm tra</param>
        /// <returns>false nếu chuỗi rỗng</returns>
        public static bool khongRong(string input)
        {
            if (input.Trim() != "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra chuỗi chỉ chứa các kí từ là chữ
        /// </summary>
        public static bool laChuoi(string input)
        {
            foreach (char digit in input)
            {
                if (Char.IsDigit(digit))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra nếu chuỗi nhập vào là số
        /// </summary>
        public static bool laSoNguyen(string input)
        {
            foreach (char digit in input)
            {
                if (!Char.IsDigit(digit))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra nếu chuỗi nhập vào là chứng minh nhân dân
        /// </summary>
        /// <param name="input">Chuỗi cần kiểm tra</param>
        /// <returns></returns>
        public static bool laCMND(string input)
        {
            // Kiểm tra chuỗi nhập vào không có chữ cái
            foreach (char digit in input)
            {
                if (!Char.IsDigit(digit))
                {
                    return false;
                }
            }

            // Kiểm tra độ dài chuỗi nhập vào
            if (input.Length != 9 || input.Length != 12)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra nếu chuỗi nhập vào là số điện thoại
        /// </summary>
        /// <param name="input">Chuỗi cần kiểm tra</param>
        /// <returns></returns>
        public static bool laSoDienThoai(string input)
        {
            // Kiểm tra chuỗi nhập vào không có chữ cái
            foreach (char digit in input)
            {
                if (!Char.IsDigit(digit))
                {
                    return false;
                }
            }

            // Kiểm tra độ dài chuỗi nhập vào
            if (input.Length != 10)
            {
                return false;
            }

            return true;
        }
    }
}
