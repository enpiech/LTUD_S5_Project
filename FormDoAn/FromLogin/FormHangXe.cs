using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
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
        /// Sửa hãng xe trong cơ sở dữ liệu
        /// </summary>
        private bool suaHangXe()
        {
            string tenHangXe = this.txtTenHangXe.Text;
            int soLuongXe = Convert.ToInt32(this.numSoLuongXe);
            double chiPhiThueBai = Convert.ToDouble(this.numChiPhi);

            MessageBox.Show(tenHangXe + soLuongXe + chiPhiThueBai);

            return false;
        }

        /// <summary>
        /// Kiểm tra chuỗi chỉ chứa các kí từ là chữ
        /// </summary>
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

        /// <summary>
        /// Kiểm tra nếu chuỗi nhập vào là số
        /// </summary>
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

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        private bool isError()
        {
            string tenHangXe = this.txtTenHangXe.Text.Trim();
            int soLuong = Convert.ToInt32(this.numSoLuongXe.Value);
            double chiPhi = Convert.ToDouble(this.numChiPhi.Value);

            if (!stringValidator(tenHangXe) || tenHangXe == "")
            {
                MessageBox.Show("Tên không phù hợp, vui lòng nhập lại!");
                return true;
            }

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
            if (!isError())
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
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool deleteConfirm()
        {
            string hangXe = this.txtTenHangXe.Text;

            if (hangXe == "")
            {
                MessageBox.Show("Vui lòng chọn hãng xe muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa hãng xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi xóa hãng xe
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteConfirm())
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
            foreach (Form form in ((frmMain)this.MdiParent).MdiChildren)
            {
                if (form.Text == "Quản Lý")
                {
                    form.Visible = true;
                    break;
                }
            }
            this.Close();
        }

        /// <summary>
        /// Sửa thông tin hãng xe đang chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy tên hãng xe từ text box
            string tenHangXe = this.txtTenHangXe.Text;
            // Nếu người dùng chưa nhập tên hãng xe
            if (!isError())
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
    }
}
