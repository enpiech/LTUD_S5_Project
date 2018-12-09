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
        private DB db = new DB();
        private const string TEN_BANG = "NhanVien";

        public frmNhanVien()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Làm sạch (xóa dữ liệu) các control
        /// </summary>
        private void xoaDuLieuTrenControl()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            string cmnd = txtCmnd.Text;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtQueQuan.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            cboLoaiNV.Text = cboLoaiNV.Items[0].ToString();
            txtSdt.Clear();
            txtLuong.Clear();
        }

        /// <summary>
        /// Xác nhận trước khi xóa nhân viên
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
        /// Xác nhận trước khi sửa nhân viên
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
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        /// <returns></returns>
        private bool coLoi()
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string cmnd = txtCmnd.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string queQuan = txtQueQuan.Text;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            string loaiNhanVien = cboLoaiNV.Text;
            string sdt = txtSdt.Text;
            string luong = txtLuong.Text;

            // Kiểm tra người dùng đã nhập mã nhân viên mới
            if (!KiemTraNhapLieu.khongRong(maNV))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            // Kiểm tra người dùng đã nhập tên nhân viên mới
            if (!KiemTraNhapLieu.khongRong(tenNV))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            //Kiểm tra xem người dùng đã nhập chứng minh nhân dân của nhân viên mới
            if (!KiemTraNhapLieu.laCMND(cmnd))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            // Kiểm tra nhân viên mới đủ tuổi
            if (!KiemTraNhapLieu.duTuoi(ngaySinh))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            // Kiểm tra người dùng đã chọn loại nhân viên
            if (!KiemTraNhapLieu.khongRong(loaiNhanVien))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.khongRong(sdt))
            {
                txtSdt.Text = "";
            }
            if (!KiemTraNhapLieu.khongRong(luong))
            {
                txtLuong.Text = "0";
            }
            return false;
        }

        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi nhập liệu
            if (!coLoi())
            {
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNV.Text;
                string cmnd = txtCmnd.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string queQuan = txtQueQuan.Text;
                DateTime ngayBatDau = dtpNgayBatDau.Value;
                string loaiNhanVien = cboLoaiNV.SelectedValue.ToString();
                string sdt = txtSdt.Text;
                double luong = Convert.ToDouble(txtLuong.Text);

                if (db.themNhanVien(maNV, tenNV, ngaySinh, diaChi, queQuan, ngayBatDau, loaiNhanVien, sdt, luong) != -1)
                {
                    MessageBox.Show(ThongBao.themThanhCong);
                    dgvNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    xoaDuLieuTrenControl();
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
            Close();
        }

        /// <summary>
        /// Sửa nhân viên đang chọn
        /// </summary>
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa và kiểm tra lỗi
            if (!coLoi() && xacNhanSua())
            {
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNV.Text;
                string cmnd = txtCmnd.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string queQuan = txtQueQuan.Text;
                DateTime ngayBatDau = dtpNgayBatDau.Value;
                string loaiNhanVien = cboLoaiNV.Text;
                string sdt = txtSdt.Text;
                double luong = Convert.ToDouble(txtLuong.Text);

                if (db.suaNhanVien(maNV, tenNV, cmnd, ngaySinh, diaChi, queQuan, ngayBatDau, loaiNhanVien, sdt, luong) != -1)
                {
                    MessageBox.Show(ThongBao.suaThanhCong);
                    dgvNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
                }
                xoaDuLieuTrenControl();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheSua);
            }
        }

        /// <summary>
        /// Xóa nhân viên đang chọn
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (xacNhanXoa())
            {
                string maNV = txtMaNV.Text;

                if (db.xoaNhanVien(maNV) == -1)
                {
                    MessageBox.Show(ThongBao.xoaThanhCong);
                    dgvNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    btnXoa.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    xoaDuLieuTrenControl();
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheXoa);
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }

        /// <summary>
        /// Khi người dùng chọn 1 hàng dữ liệu thì cập nhật các control tương ứng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txtCmnd.Text = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.SelectedRows[0].Cells[3].Value);
            txtDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            txtQueQuan.Text = dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            dtpNgayBatDau.Value = Convert.ToDateTime(dgvNhanVien.SelectedRows[0].Cells[6].Value.ToString());
            cboLoaiNV.SelectedIndex = cboLoaiNV.FindStringExact(dgvNhanVien.SelectedRows[0].Cells[7].Value.ToString());
            txtSdt.Text = dgvNhanVien.SelectedRows[0].Cells[8].Value.ToString();
            txtLuong.Text = dgvNhanVien.SelectedRows[0].Cells[9].Value.ToString();
            
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
    }
}
