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
    public partial class frmLoaiXe : Form
    {
        public frmLoaiXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm loại xe mới vào cơ sở dữ liệu
        /// </summary>
        private bool themLoaiXe()
        {
            string tenLoaiXe = this.txtTenLoaiXe.Text;

            return false;
        }

        /// <summary>
        /// Xóa 1 loại xe trong cơ sở dữ liệu
        /// </summary>
        private bool xoaLoaiXe()
        {
            string tenLoaiXe = this.txtTenLoaiXe.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm loại xe mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy tên loại xe từ text box
            string tenLoaiXe = this.txtTenLoaiXe.Text;
            // Kiểm tra nếu người dùng chưa nhập tên loại xe mới
            if (tenLoaiXe == "")
            {
                MessageBox.Show("Vui lòng chọn loại xe cần thêm!");
            }
            else
            {
                // Kiểm tra xem đã thêm thành công
                if (themLoaiXe() == true)
                {
                    MessageBox.Show("Thêm loại xe mới thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm loại xe mới!");
                }
            }
        }

        /// <summary>
        /// Kiểm tra lỗi và xóa loại xe đã chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa chọn loại xe cần xóa
            if (string.IsNullOrEmpty(this.txtTenLoaiXe.Text))
            {
                MessageBox.Show("Vui lòng chọn loại xe cần xóa!");
            }
            else
            {
                // Lấy tên loại xe từ textbox
                string tenLoaiXe = this.txtTenLoaiXe.Text.Trim();

                // Kiểm tra nếu có thể xóa thì xóa loại xe đã chọn
                if (xoaLoaiXe() == true)
                {
                    MessageBox.Show("Xóa loại xe {0} thành công!", tenLoaiXe);
                }
                else
                {
                    MessageBox.Show("Không thể xóa loại xe này!");
                }
            }
        }

        /// <summary>
        /// Trở về form chọn bảng
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
        private void frmLoaiXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
