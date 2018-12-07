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
    public partial class frmLoaiNhanVien : Form
    {
        DB db = new DB();

        public frmLoaiNhanVien()
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
        /// Thêm loại nhân viên mới vào cơ sở dữ liệu
        /// </summary>
        private bool themLoaiNhanVien()
        {
            string tenLoaiNhanVien = this.txtTenLoaiNV.Text;
            double luongCoBan = Convert.ToDouble(this.numLuongCoBan);

            return false;
        }

        /// <summary>
        /// Sửa loại nhân viên trong cơ sở dữ liệu
        /// </summary>
        private bool suaLoaiNhanVien()
        {
            string tenLoaiNhanVien = this.txtTenLoaiNV.Text;
            double luongCoBan = Convert.ToDouble(this.numLuongCoBan);

            return false;
        }

        /// <summary>
        /// Xóa loại nhân viên đang chọn khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaLoaiNhanVien()
        {
            string tenLoaiNhanVien = this.txtTenLoaiNV.Text;

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        private bool isError()
        {
            string tenLoaiNhanVien = this.txtTenLoaiNV.Text.Trim();
            
            if (!stringValidator(tenLoaiNhanVien) || tenLoaiNhanVien == "")
            {
                MessageBox.Show("Tên không phù hợp, vui lòng nhập lại!");
                return true;
            }

            return false;

        }

        /// <summary>
        /// Kiểm tra lỗi ròi thêm loại nhân viên mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập tên loại nhân viên mới
            if (!isError())
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
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool deleteConfirm()
        {
            string tenLoaiNV = this.txtTenLoaiNV.Text;

            if (tenLoaiNV == "")
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa loại nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi xóa loại nhân viên đang chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteConfirm())
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
        /// Sửa thông tin loại nhân viên đang chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập tên loại nhân viên mới
            if (!isError())
            {
                // Kiểm tra có thêm thành công hay không
                if (suaLoaiNhanVien())
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm!");
                }
            }
        }

        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
            dataGridView1.DataSource = db.layDuLieuTuBang("LoaiNhanVien");
        }
    }
}
