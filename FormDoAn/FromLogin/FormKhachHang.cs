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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm khách khàng mới vào cơ sở dữ liệu
        /// </summary>
        private bool themKhachHang()
        {
            string tenKhachHang = this.txtTenKhachHang.Text;
            string cmnd = this.txtCmnd.Text;
            string soDienThoai = this.txtSoDienThoai.Text;
            string maXe = this.cboMaXe.Text;
            string maGhe = this.txtMaGhe.Text;

            return false;
        }

        /// <summary>
        /// Xóa khách hàng trong cơ sở dữ liệu
        /// </summary>
        private bool xoaKhachHang()
        {
            string tenKhachHang = this.txtTenKhachHang.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm khách hàng mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenKhachHang = this.txtTenKhachHang.Text;

            // Kiểm tra xem đã nhập tên khách hàng
            if (tenKhachHang == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng mới");
            }
            else
            {
                if (themKhachHang())
                {
                    MessageBox.Show("Thêm khách hàng mới thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm khách hàng!");
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
