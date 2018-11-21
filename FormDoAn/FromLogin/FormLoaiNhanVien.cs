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
    public partial class frmLoaiNhanVien : Form
    {
        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm loại nhân viên mới vào cơ sở dữ liệu
        /// </summary>
        private bool themLoaiNhanVien()
        {
            string tenLoaiNhanVien = this.txtTenKhachHang.Text;
            double luongCoBan = Convert.ToDouble(this.numLuongCoBan);

            return false;
        }

        /// <summary>
        /// Xóa loại nhân viên đang chọn khỏi cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        private bool xoaLoaiNhanVien()
        {
            string tenLoaiNhanVien = this.txtTenKhachHang.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi ròi thêm loại nhân viên mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenLoaiNhanVien = this.txtTenKhachHang.Text;

            // Kiểm tra xem người dùng đã nhập tên loại nhân viên mới
            if (tenLoaiNhanVien == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại nhân viên mới");
            }
            else
            {
                // Kiểm tra có thêm thành công hay không
                if (themLoaiNhanVien())
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
        /// Kiểm tra lỗi rồi xóa loại nhân viên đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tenLoaiNhanVien = this.txtTenKhachHang.Text;

            // Kiểm tra xem người dùng đã nhập tên loại nhân viên cần xóa
            if (tenLoaiNhanVien == "")
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên cần xóa!");
            }
            else
            {
                // Kiểm tra có xóa thành công hay không
                if (xoaLoaiNhanVien())
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
        /// Trở về form quản lý
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmQuanLy formQuanLy = new frmQuanLy();
            formQuanLy.Show();
            this.Close();
        }
    }
}
