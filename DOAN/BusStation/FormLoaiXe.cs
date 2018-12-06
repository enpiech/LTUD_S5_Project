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
    public partial class frmLoaiXe : Form
    {
        public frmLoaiXe()
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
        /// Thêm loại xe mới vào cơ sở dữ liệu
        /// </summary>
        private bool themLoaiXe()
        {
            string tenLoaiXe = this.txtTenLoaiXe.Text;

            return false;
        }

        /// <summary>
        /// Sửa loại xe trong cơ sở dữ liệu
        /// </summary>
        private bool suaLoaiXe()
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

        private bool isError()
        {
            string tenLoaiXe = this.txtTenLoaiXe.Text.Trim();
            if (!stringValidator(tenLoaiXe) || tenLoaiXe == "")
            {
                MessageBox.Show("Tên không hợp lệ, vui lòng nhập lại!");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm loại xe mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập tên loại xe mới
            if (!isError())
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
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool deleteConfirm()
        {
            string tenLoaiXe = this.txtTenLoaiXe.Text;

            if (tenLoaiXe == "")
            {
                MessageBox.Show("Vui lòng chọn loại xe muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa loại xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi và xóa loại xe đã chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa chọn loại xe cần xóa
            if (deleteConfirm())
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
        /// Sửa loại xe đang chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập tên loại xe mới
            if (!isError())
            {
                // Kiểm tra xem đã thêm thành công
                if (suaLoaiXe() == true)
                {
                    MessageBox.Show("Thêm loại xe mới thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm loại xe mới!");
                }
            }
        }

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
            DB db = new DB();
            db.moKetNoi();
            dataGridView1.DataSource = db.layDuLieuTuBang("LoaiXe");
            db.dongKetNoi();
        }
    }
}
