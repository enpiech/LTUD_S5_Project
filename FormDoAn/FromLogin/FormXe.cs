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
    public partial class frmXe : Form
    {
        public frmXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm xe mới vào cơ sở dữ liệu
        /// </summary>
        private bool themXe()
        {
            string soXe = this.txtSoXe.Text;
            string hangXe = this.cboHangXe.Text;
            string loaiXe = this.cboLoaiXe.Text;
            string hanhTrinh = this.txtHanhTrinh.Text;
            double gia = Convert.ToDouble(this.numGia);
            string gioXuatPhat = this.dtpGioXuatPhat.Text;
            int soLuongGhe = Convert.ToInt32(this.numSoLuongGhe);
            int soLuongKhachHang = Convert.ToInt32(this.numSoLuongKhachHang);
            string maNVLaiXe = this.cboNVLaiXe.Text;

            return false;
        }

        /// <summary>
        /// Xóa xe đang chọn khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaXe()
        {
            string soXe = this.txtSoXe.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm xe mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string soXe = this.txtSoXe.Text;
            string hangXe = this.cboHangXe.Text;
            string loaiXe = this.cboLoaiXe.Text;
            string maNVLaiXe = this.cboNVLaiXe.Text;

            // Kiểm tra người dùng đã nhập số xe
            if (soXe == "")
            {
                MessageBox.Show("Vui lòng nhập số xe!");
            }
            // Kiểm tra người dùng đã chọn hãng xe
            else if (hangXe == "")
            {
                MessageBox.Show("Vui lòng chọn hãng xe!");
            }
            // Kiểm tra người dùng đã chọn loại xe
            else if (loaiXe == "")
            {
                MessageBox.Show("Vui lòng chọn loại xe!");
            }
            // Kiểm tra người dùng đã chọn nhân viên lái xe
            else if (maNVLaiXe == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên lái xe!");
            }
            else
            {
                // Kiểm tra xem thêm thành công hay không
                if (themXe())
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể xóa!");
                }
            }
        }

        /// <summary>
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool xacNhanXoa()
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi xóa xe được chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (xacNhanXoa())
            {
                string soXe = this.txtSoXe.Text;

                if (soXe == "")
                {
                    MessageBox.Show("Vui lòng chọn xe muốn xóa!");
                }
                else
                {
                    // Kiểm tra nếu xóa xe thành công
                    if (xoaXe())
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi phát sinh, không thể xóa!");
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
        private void FormXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
