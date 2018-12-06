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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
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
        /// Sửa nhân viên đang chọn trong cơ sở dữ liệu
        /// </summary>
        private bool suaNhanVien()
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

        /// <summary>
        /// Xác nhận trước khi xóa nhân viên
        /// </summary>
        /// <returns></returns>
        private bool deleteConfirm()
        {
            string tenNhanVien = this.txtTenNhanVien.Text.Trim();
            if (tenNhanVien == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        /// <returns></returns>
        private bool isError()
        {
            string tenNhanVien = this.txtTenNhanVien.Text;
            string cmnd = this.txtCmnd.Text;
            string loaiNV = this.cboLoaiNhanVien.Text;
            DateTime ngaySinh = this.dtpNgaySinh.Value;

            // Kiểm tra xem người dùng đã nhập tên nhân viên mới
            if (tenNhanVien == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên mới!");
                return true;
            }
            else if (!stringValidator(tenNhanVien))
            {
                MessageBox.Show("Tên không phù hợp, vui lòng nhập lại!");
                return true;
            }
            // Kiểm tra xem người dùng đã nhập chứng minh nhân dân của nhân viên mới
            else if (cmnd == "")
            {
                MessageBox.Show("Vui lòng nhập số chứng minh nhân dân!");
                return true;
            }
            else if (cmnd.Length != 9 || cmnd.Length != 12)
            {
                MessageBox.Show("Chứng minh nhân dân không phù hợp, vui lòng nhập lại");
                return true;
            }
            // Kiểm tra xem người dùng đã chọn loại nhân viên
            else if (loaiNV == "")
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên!");
                return true;
            }
            else if (DateTime.Now.Year - ngaySinh.Year < 18)
            {
                MessageBox.Show("Nhân viên phải lớn hơn 18 tuổi");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (!isError())
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
        /// Sửa nhân viên đang chọn
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (!isError())
            {
                // Kiểm tra xem đã thêm thành công hay không
                if (xoaNhanVien())
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể thêm mới!");
                }
            }
        }

        /// <summary>
        /// Xóa nhân viên đang chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteConfirm())
            {
                if (xoaNhanVien())
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể xóa!");
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
            DB db = new DB();
            db.moKetNoi();
            dataGridView1.DataSource = db.layDuLieuTuBang("NhanVien");
            db.dongKetNoi();
        }
    }
}
