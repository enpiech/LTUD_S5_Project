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
        private const string TEN_BANG = "KhachHang";
        DB db = new DB();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lấy dữ liệu từ csdl lên view khi load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }

        /// <summary>
        /// Thêm khách khàng mới vào cơ sở dữ liệu
        /// </summary>
        private bool themKhachHang()
        {
            // Lấy dữ liệu từ các control
            string maKH = this.txtMaKhachHang.Text;
            string tenKhachHang = this.txtTenKhachHang.Text;
            string cmnd = this.txtCmnd.Text;
            string soDienThoai = this.txtSoDienThoai.Text;
            string maXe = this.cboMaXe.Text;
            string maGhe = this.txtMaGhe.Text;

            // Thêm dữ liệu mới vào csdl
            if (db.themKhachHang(maKH, tenKhachHang, cmnd, soDienThoai, maXe, maGhe) == -1)
            {
                return true;
            }

            // Cập nhật lại view
            dgvKhachHang.DataSource = db.layDuLieuTuBang(TEN_BANG);

            return false;
        }

        /// <summary>
        /// Sửa khách hàng trong cơ sở dữ liệu
        /// </summary>
        private bool suaKhachHang()
        {
            // Lấy dữ liệu từ các control
            string maKH = this.txtMaKhachHang.Text;
            string tenKhachHang = this.txtTenKhachHang.Text;
            string cmnd = this.txtCmnd.Text;
            string soDienThoai = this.txtSoDienThoai.Text;
            string maXe = this.cboMaXe.Text;
            string maGhe = this.txtMaGhe.Text;

            // Thêm dữ liệu mới vào csdl

            if (db.suaKhachHang(maKH, tenKhachHang, cmnd, soDienThoai, maXe, maGhe) == -1)
            {
                return true;
            }

            // Cập nhật lại view
            dgvKhachHang.DataSource = db.layDuLieuTuBang(TEN_BANG);

            return false;
        }

        /// <summary>
        /// Xóa khách hàng trong cơ sở dữ liệu
        /// </summary>
        private bool xoaKhachHang()
        {
            string maKhachHang = this.txtMaKhachHang.Text;

            if (db.xoaKhachHang(maKhachHang) == -1)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra nếu người dùng nhập dữ liệu bị lỗi
        /// </summary>
        private bool coLoi()
        {
            string tenKhachHang = this.txtTenKhachHang.Text.Trim();
            string cmnd = this.txtCmnd.Text.Trim();
            string sdt = this.txtSoDienThoai.Text.Trim();
            string maGhe = this.txtMaGhe.Text.Trim();

            if (!KiemTraNhapLieu.khongRong(tenKhachHang))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.laCMND(cmnd))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            else if (!KiemTraNhapLieu.laSoDienThoai(sdt))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            else if (!KiemTraNhapLieu.khongRong(maGhe))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm khách hàng mới
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập tên khách hàng
            if (!coLoi())
            { 
                if (themKhachHang())
                {
                    MessageBox.Show(ThongBao.themThanhCong);
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheThem);
                }
            }
        }

        /// <summary>
        /// Trở về form chọn bảng
        /// </summary>
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập tên khách hàng
            if (!coLoi())
            {
                if (suaKhachHang())
                {
                    MessageBox.Show(ThongBao.suaThanhCong);
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheSua);
                }
            }
        }

        /// <summary>
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool deleteConfirm()
        {
            string maKH = this.txtMaKhachHang.Text;

            if (!KiemTraNhapLieu.khongRong(maKH))
            {
                MessageBox.Show(ThongBao.chonTruocKhiXoa);
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (deleteConfirm())
            {
                // Kiểm tra nếu xóa thành công
                if (xoaKhachHang())
                {
                    MessageBox.Show(ThongBao.xoaThanhCong);
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheXoa);
                }
            }
        }
 
    }
}
