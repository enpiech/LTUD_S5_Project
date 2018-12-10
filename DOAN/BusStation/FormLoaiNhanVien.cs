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
        //khoi tao gia tri
        private const string TEN_BANG = "LoaiNhanVien";
        DB db = new DB();

        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xóa những control nhập dữ liệu
        /// </summary>
        private void xoaDuLieuTrenControl()
        {
            txtMaNV.Clear();
            txtTenLoaiNV.Clear();
            txtLuongCoBan.Clear();
        }
        /// <summary>
        /// trở về form chính
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //đóng form hiện tại
            this.Close();
        }

        /// <summary>
        /// hàm kiểm tra nhập liệu
        /// </summary>
        /// <returns></returns>
        private bool coLoi()
        {
            //lấy dữ liệu từ các control
            string maLoaiNV = txtTenLoaiNV.Text;
            string tenLoaiNV = txtTenLoaiNV.Text;
            string luongCoBan = txtLuongCoBan.Text;

            //kiểm tra nhập vào có hợp lệ hay không
            if (!KiemTraNhapLieu.laChuoi(maLoaiNV))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.laChuoi(tenLoaiNV))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.laSoNguyen(luongCoBan))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            return false;
        }


        /// <summary>
        /// lấy dữ liệu từ bảng loại nhân viên mổi khi load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            dgvLoaiNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }

        /***** Thêm *****/
        /// <summary>
        /// Thêm loại nhân viên mới vào cơ sở dữ liệu
        /// </summary>
        private bool themNhanVien()
        {
            string maLoaiNV = txtTenLoaiNV.Text;
            string tenLoaiNV = txtTenLoaiNV.Text;
            double luongCoBan = Convert.ToDouble( txtLuongCoBan.Text);

            if (db.themLoaiNV(maLoaiNV, tenLoaiNV, luongCoBan) == -1)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// thêm loại nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi nhập liệu
            if (!coLoi())
            {
                // Kiểm tra xem đã thêm thành công hay không
                if (themNhanVien())
                {
                    MessageBox.Show(ThongBao.themThanhCong);
                    dgvLoaiNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
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
        /// Xác nhận trước khi xóa loại nhân viên
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
        /// Xóa loại nhân viên đang chọn ra khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaNhanVien()
        {
            string maNV = txtMaNV.Text;

            if (db.xoaLoaiNV(maNV) == -1)
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Xóa loại nhân viên đã chọn trong csdl
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
                    dgvLoaiNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    xoaDuLieuTrenControl();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi sửa và kiểm tra lỗi
            if (!coLoi() && xacNhanSua())
            {
                string maNV = txtMaNV.Text;
                string tenLoaiNhanVien = txtTenLoaiNV.Text;
                double luongCoBan = Convert.ToDouble(txtLuongCoBan.Text);

                if (db.suaLoaiNV(maNV, tenLoaiNhanVien, luongCoBan) != -1)
                {
                    MessageBox.Show(ThongBao.suaThanhCong);
                    dgvLoaiNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
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
        private void dgvLoaiNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu từ view
            string maLoaiXe = dgvLoaiNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            string tenLoaiXe = dgvLoaiNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            string luongCoBan = dgvLoaiNhanVien.SelectedRows[0].Cells[2].Value.ToString();


            // Truyền dữ liệu lên control tương ứng
            txtMaNV.Text = maLoaiXe;
            txtTenLoaiNV.Text = tenLoaiXe;
            txtLuongCoBan.Text = luongCoBan;


            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }



       
    }
}
