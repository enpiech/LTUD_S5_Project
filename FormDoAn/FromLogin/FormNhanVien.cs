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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm nhân viên mới vào cơ sở dữ liệu
        /// </summary>
        private bool themNhanVien()
        {
            string tenNhanVien = this.txtTenNhanVien.Text;
            string cmnd = this.txtCmnd.Text;
            string ngaySinh = this.dtpNgaySinh.Text;
            string diaChi = this.txtDiaChi.Text;
            string queQuan = this.txtQueQuan.Text;
            string loaiNhanVien = this.cboLoaiNhanVien.Text;
            string soDienThoai = this.txtSoDienThoai.Text;
            double luong = Convert.ToDouble(this.numLuong);

            return false;
        }

        /// <summary>
        /// Xóa loại nhân viên đang chọn ra khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaNhanVien()
        {
            string tenNhanVien = this.txtTenNhanVien.Text;

            return false;
        }

        private bool xacNhanTruocKhiXoa()
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (xacNhanTruocKhiXoa())
            {
                string tenNhanVien = this.txtTenNhanVien.Text;
                string cmnd = this.txtCmnd.Text;
                string loaiNV = this.cboLoaiNhanVien.Text;

                // Kiểm tra xem người dùng đã nhập tên nhân viên mới
                if (tenNhanVien == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên mới!");
                }
                // Kiểm tra xem người dùng đã nhập chứng minh nhân dân của nhân viên mới
                else if (cmnd == "")
                {
                    MessageBox.Show("Vui lòng nhập số chứng minh nhân dân!");
                }
                // Kiểm tra xem người dùng đã chọn loại nhân viên
                else if (loaiNV == "")
                {
                    MessageBox.Show("Vui lòng chọn loại nhân viên!");
                }
                else
                {
                    // Kiểm tra xem đã thêm thành công hay không
                    if (themNhanVien())
                    {
                        MessageBox.Show("Thêm mới thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi phát sinh, không thể thêm mới!");
                    }
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

        /// <summary>
        /// Xác nhận trước khi đóng form
        /// </summary>
        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
