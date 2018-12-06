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
using System.Data.SqlClient;

namespace BusStation
{
    public partial class frmXe : Form
    {
        public frmXe()
        {
            InitializeComponent();
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
        /// Sửa xe trong cơ sở dữ liệu
        /// </summary>
        private bool suaXe()
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

        private bool isError()
        {
            string soXe = this.txtSoXe.Text.Trim();
            string hangXe = this.cboHangXe.Text.Trim();
            string loaiXe = this.cboLoaiXe.Text.Trim();
            string maNVLaiXe = this.cboNVLaiXe.Text.Trim();

            // Kiểm tra người dùng đã nhập số xe
            if (soXe == "")
            {
                MessageBox.Show("Vui lòng nhập số xe!");
                return true;
            }
            else if (soXe.Length != 8 || soXe.Length != 9)
            {
                MessageBox.Show("Số xe không hợp lệ, vui lòng nhập lại!");
                return true;
            }
            // Kiểm tra người dùng đã chọn hãng xe
            else if (hangXe == "")
            {
                MessageBox.Show("Vui lòng chọn hãng xe!");
                return true;
            }
            // Kiểm tra người dùng đã chọn loại xe
            else if (loaiXe == "")
            {
                MessageBox.Show("Vui lòng chọn loại xe!");
                return true;
            }
            // Kiểm tra người dùng đã chọn nhân viên lái xe
            else if (maNVLaiXe == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên lái xe!");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm xe mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!isError())
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
        private bool deleteConfirm()
        {
            string soXe = this.txtSoXe.Text;

            if (soXe == "")
            {
                MessageBox.Show("Vui lòng chọn xe muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            
            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi xóa xe được chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteConfirm())
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
        /// Sửa xe đã chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isError())
            {
                // Kiểm tra xem thêm thành công hay không
                if (suaXe())
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể xóa!");
                }
            }
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
            DB db = new DB();
            db.moKetNoi();
            dataGridView1.DataSource = db.layDuLieuTuBang("Xe");
            db.dongKetNoi();
        }
    }
}
