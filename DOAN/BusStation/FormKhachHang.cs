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
        /// Sửa khách hàng trong cơ sở dữ liệu
        /// </summary>
        private bool suaKhachHang()
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
        /// Kiểm tra nếu người dùng nhập dữ liệu bị lỗi
        /// </summary>
        private bool isError()
        {
            string tenKhachHang = this.txtTenKhachHang.Text.Trim();
            string cmnd = this.txtCmnd.Text.Trim();
            string sdt = this.txtSoDienThoai.Text.Trim();
            string maGhe = this.txtMaGhe.Text.Trim();

            if (!stringValidator(tenKhachHang) || tenKhachHang == "")
            {
                MessageBox.Show("Tên không hợp lệ, vui lòng nhập lại!");
                return true;
            }
            else if (!integerValidator(cmnd) && (cmnd.Length != 9 || cmnd.Length != 12))
            {
                MessageBox.Show("CMND không hợp lệ, vui lòng nhập lại!");
                return true;
            }
            else if (!integerValidator(sdt) && (sdt.Length != 9 || cmnd.Length != 10))
            {
                MessageBox.Show("Số điện thoại không hợp lệ, vui lòng nhập lại!");
                return true;
            }
            else if (maGhe.Length < 3 || maGhe.Length > 4)
            {
                MessageBox.Show("Mã ghế không hợp lệ, vui lòng nhập lại!");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm khách hàng mới
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập tên khách hàng
            if (!isError())
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
        /// Cập nhật dữ liệu
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập tên khách hàng
            if (!isError())
            {
                if (suaKhachHang())
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
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool deleteConfirm()
        {
            string tenKhachHang = this.txtTenKhachHang.Text;

            if (tenKhachHang == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!");
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Xóa khách hàng đã chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleteConfirm())
            {
                // Kiểm tra nếu xóa thành công
                if (xoaKhachHang())
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi phát sinh, không thể xóa!");
                }
            }
        }
        //ham lay du lieu dua vao datagidview
        xuLyDB xuly = new xuLyDB();
        public DataTable getAllKhachHang()
        {
            DataTable dtKH = new DataTable();
            string nameSp = "SP_layBangKhachHang";
            SqlCommand cm = new SqlCommand(nameSp, xuLyDB.connect);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adepter = new SqlDataAdapter(cm);
            adepter.Fill(dtKH);
            xuLyDB.connect.Close();

            dataGridView1.DataSource = dtKH;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return dtKH;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            getAllKhachHang();
        }
    }
}
