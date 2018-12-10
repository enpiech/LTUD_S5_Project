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
    public partial class frmTaiKhoanNhanVien : Form
    {
        private const string TEN_BANG = "TaiKhoanNhanVien";
        DB db = new DB();

        public frmTaiKhoanNhanVien()
        {
            InitializeComponent();
        }
        /// <summary>
        /// hàm kiểm tra nhập liệu
        /// </summary>
        /// <returns></returns>
        private bool coLoi()
        {
            //lấy dữ liệu từ các control
            string maNV = txtMaNV.Text;
            string tenNV = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            return false;
        }
        /// <summary>
        /// trở về form chính
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// lấy dữ liệu từ bảng loại xe mổi khi load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaiKhoanNhanVien_Load(object sender, EventArgs e)
        {
            dgvTKNV.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }
        /// <summary>
        /// Xóa những control nhập dữ liệu
        /// </summary>
        private void xoaDuLieuTrenControl()
        {
            txtMaNV.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }
        /***** Thêm *****/
        /// <summary>
        /// Thêm tài khoản mới vào csdl
        /// </summary>
        private bool themTKNhanVien()
        {
            string maNV = txtMaNV.Text;
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (db.themTaiKhoanNV(maNV, taiKhoan, matKhau) == -1)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// thêm tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi nhập liệu
            if (!coLoi())
            {
                // Kiểm tra xem đã thêm thành công hay không
                if (themTKNhanVien())
                {
                    MessageBox.Show(ThongBao.themThanhCong);
                    dgvTKNV.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    xoaDuLieuTrenControl();
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheThem);
                }
            }
        }
        /***** Xóa *****/
        /// <summary>
        /// Xác nhận trước khi xóa tài khoản
        /// </summary>
        /// <returns>false Nếu không đồng ý</returns>
        private bool xacNhanXoa()
        {
            // Kiểm tra dữ liệu
            string maNV = txtMaNV.Text;
            if (!KiemTraNhapLieu.khongRong(maNV))
            {
                MessageBox.Show(ThongBao.chonTruocKhiXoa);
                return false;
            }

            // Mở dialog xác nhận
            DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Xóa tài khoản đang chọn ra khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaNhanVien()
        {
            string maNV = txtMaNV.Text;

            if (db.xoaTaiKhoanNV(maNV) == -1)
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Xóa loại xe đã chọn trong csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (xacNhanXoa())
            {
                if (xoaNhanVien())
                {
                    MessageBox.Show(ThongBao.xoaThanhCong);
                    dgvTKNV.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    xoaDuLieuTrenControl();
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheXoa);
                }
            }
        }
        /***** SỬA *****/

        /// <summary>
        /// Xác nhận trước khi sửa loại nhân viên
        /// </summary>
        /// <returns>false Nếu không đồng ý</returns>
        private bool xacNhanSua()
        {
            // Mở dialog xác nhận
            DialogResult result = MessageBox.Show("Bạn muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// sửa tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi sửa và kiểm tra lỗi
            if (!coLoi() && xacNhanSua())
            {
                string maNV = txtMaNV.Text;
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau =txtMatKhau.Text;

                if (db.suaTaiKhoanNV(maNV, taiKhoan, matKhau) != -1)
                {
                    MessageBox.Show(ThongBao.suaThanhCong);
                    dgvTKNV.DataSource = db.layDuLieuTuBang(TEN_BANG);
                }
                xoaDuLieuTrenControl();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheSua);
            }
        }
        /// <summary>
        /// Khi chọn 1 hàng trong View thì lấy dữ liệu lên form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTKNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu từ view
            string maLoaiXe = dgvTKNV.SelectedRows[0].Cells[0].Value.ToString();
            string taikhoan = dgvTKNV.SelectedRows[0].Cells[1].Value.ToString();
            string matkhau = dgvTKNV.SelectedRows[0].Cells[2].Value.ToString();


            // Truyền dữ liệu lên control tương ứng
            txtMaNV.Text = maLoaiXe;
            txtTaiKhoan.Text = taikhoan;
            txtMatKhau.Text = matkhau;


            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }


         
    }
}
