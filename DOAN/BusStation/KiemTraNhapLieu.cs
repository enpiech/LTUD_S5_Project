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
                    return false;
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
                    return false;
            }

            return true;
        }
    }
}
