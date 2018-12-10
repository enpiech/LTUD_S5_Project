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
        DB db = new DB();

        public frmXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        /// <returns></returns>
        private bool coLoi()
        {
            string maXe = txtMaXe.Text;
            string soXe = txtSoXe.Text;
            string gia = txtGiaVe.Text;

            // Kiểm tra người dùng đã nhập số xe
            if (!KiemTraNhapLieu.khongRong(soXe) || !KiemTraNhapLieu.khongRong(maXe) || !KiemTraNhapLieu.khongRong(gia))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi thêm xe mới
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        { 
            if (!coLoi())
            {
                string maXe = txtMaXe.Text;
                string soXe = txtSoXe.Text;
                string maHangXe = cboHangXe.SelectedValue.ToString();
                string maLoaiXe = cboLoaiXe.SelectedValue.ToString();
                string hanhTrinh = txtHanhTrinh.Text;
                double gia = Convert.ToDouble(txtGiaVe.Text);
                DateTime gioXuatPhat = dtpGioXuatPhat.Value;
                int soLuongGhe = Convert.ToInt32(numSoLuongGhe);
                int soLuongKhachHang = Convert.ToInt32(numSoLuongKhachHang);
                string maNVLaiXe = cboNVLaiXe.SelectedValue.ToString();

                // Kiểm tra xem thêm thành công hay không
                if (db.themXe(maXe, maHangXe, soXe, maLoaiXe, hanhTrinh, gia, gioXuatPhat, soLuongGhe, soLuongKhachHang, maLoaiXe) != -1)
                {
                    MessageBox.Show(ThongBao.themThanhCong);
                    dgvXe.DataSource = db.layDuLieuTuBang("Xe");
                }
                loadDuLieu();
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheThem);
            }
        }

        /// <summary>
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool xacNhanXoa()
        {
            string soXe = txtSoXe.Text;

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
        /// Xác nhận trước khi xóa
        /// </summary>
        private bool xacNhanSua()
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra lỗi rồi xóa xe được chọn
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (xacNhanXoa())
            {
                string maXe = txtMaXe.Text;
                // Kiểm tra nếu xóa xe thành công
                if (db.xoaXe(maXe) != -1)
                {
                    MessageBox.Show(ThongBao.xoaThanhCong);
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheXoa);
                }
                loadDuLieu();
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
        /// Sửa xe đã chọn
        /// </summary>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!coLoi())
            {
                string maXe = txtMaXe.Text;
                string soXe = txtSoXe.Text;
                string maHangXe = cboHangXe.SelectedValue.ToString();
                string maLoaiXe = cboLoaiXe.SelectedValue.ToString();
                string hanhTrinh = txtHanhTrinh.Text;
                double gia = Convert.ToDouble(txtGiaVe.Text);
                DateTime gioXuatPhat = dtpGioXuatPhat.Value;
                int soLuongGhe = (int)numSoLuongGhe.Value;
                int soLuongKhachHang = (int)numSoLuongKhachHang.Value;
                string maNVLaiXe = cboNVLaiXe.SelectedValue.ToString();

                //Kiểm tra xem thêm thành công hay không
                if (db.suaXe(maXe, maHangXe, soXe, maLoaiXe, hanhTrinh, gia, gioXuatPhat, soLuongGhe, soLuongKhachHang, maLoaiXe) != -1)
                {
                    MessageBox.Show(ThongBao.suaThanhCong);
                }
                loadDuLieu();
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheSua);
            }
        }

        /// <summary>
        /// Lấy dữ liệu cơ bản lên các control tương ứng
        /// </summary>
        private void loadDuLieu()
        {
            txtMaXe.Clear();
            txtSoXe.Clear();
            txtHanhTrinh.Clear();
            txtGiaVe.Text = "0";
            dtpGioXuatPhat.Value = DateTime.Now;
            numSoLuongGhe.Value = 0;
            numSoLuongKhachHang.Value = 0;

            // Lấy data lên gridview
            dgvXe.DataSource = db.layDuLieuTuBang("Xe");
            // Lấy data lên cbo Hãng xe
            cboHangXe.DataSource = db.layDuLieuTuBang("HangXe");
            cboHangXe.DisplayMember = "TenHangXe";
            cboHangXe.ValueMember = "MaHangXe";
            // Lấy data lên cbo Loại Xe
            cboLoaiXe.DataSource = db.layDuLieuTuBang("LoaiXe");
            cboLoaiXe.DisplayMember = "TenLoaiXe";
            cboLoaiXe.ValueMember = "MaLoaiXe";
            // Lấy data lên cbo Nhân viên lái xe
            cboNVLaiXe.DataSource = db.layDuLieuTuBang("NhanVien");
            cboNVLaiXe.DisplayMember = "TenNV";
            cboNVLaiXe.ValueMember = "MaNV";

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        /// <summary>
        /// Lấy dữ liệu từ csdl lên control tương ứng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmXe_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXe.Text = dgvXe.SelectedRows[0].Cells[0].Value.ToString();
            cboHangXe.SelectedIndex = db.timMaHangXe(dgvXe.SelectedRows[0].Cells[1].Value.ToString());
            txtSoXe.Text = dgvXe.SelectedRows[0].Cells[2].Value.ToString();
            cboLoaiXe.SelectedIndex = db.timMaLoaiXe(dgvXe.SelectedRows[0].Cells[3].Value.ToString());
            txtHanhTrinh.Text = dgvXe.SelectedRows[0].Cells[4].Value.ToString();
            txtGiaVe.Text = dgvXe.SelectedRows[0].Cells[5].Value.ToString();
            dtpGioXuatPhat.Value = Convert.ToDateTime(dgvXe.SelectedRows[0].Cells[6].Value);
            numSoLuongGhe.Value = Convert.ToInt32(dgvXe.SelectedRows[0].Cells[7].Value);
            numSoLuongKhachHang.Value = Convert.ToInt32(dgvXe.SelectedRows[0].Cells[8].Value);
            cboNVLaiXe.SelectedIndex = db.timMaLoaiXe(dgvXe.SelectedRows[0].Cells[9].Value.ToString());

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
