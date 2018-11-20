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
    public partial class frmHangXe : Form
    {
        public frmHangXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm hãng xe mới vào cơ sở dữ liệu
        /// </summary>
        private bool themHangXe()
        {
            string tenHangXe = this.txtTenHangXe.Text;
            int soLuongXe = Convert.ToInt32(this.numSoLuongXe);
            double chiPhiThueBai = Convert.ToDouble(this.numChiPhi);

            MessageBox.Show(tenHangXe + soLuongXe + chiPhiThueBai);

            return false;
        }

        /// <summary>
        /// Xóa hãng xe đã chọn trong cơ sở dữ liệu
        /// </summary>
        private bool xoaHangXe()
        {
            string tenHangXe = this.txtTenHangXe.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm hãng xe mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy tên hãng xe từ text box
            string tenHangXe = this.txtTenHangXe.Text;
            // Nếu người dùng chưa nhập tên hãng xe
            if (tenHangXe == "")
            {
                MessageBox.Show("Vui lòng nhập tên hãng xe mới!");
            }
            else
            {
                // Kiểm tra xem đã thêm thành công
                if (themHangXe())
                {
                    MessageBox.Show("Thêm hãng xe mới thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm hãng xe mới!");
                }
            }
        }

        /// <summary>
        /// Kiểm tra lỗi rồi xóa hãng xe
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Lấy ten hãng xe từ text box
            string tenHangXe = this.txtTenHangXe.Text;
            // Nếu người dùng chưa chọn hãng xe
            if (tenHangXe == "")
            {
                MessageBox.Show("Vui lòng chọn hãng xe cần xóa!");
            }
            else
            {
                // Kiểm tra xem đã xóa thành công
                if (xoaHangXe())
                {
                    MessageBox.Show("Xóa hãng xe thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa hãng xe này!");
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
        private void frmHangXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
