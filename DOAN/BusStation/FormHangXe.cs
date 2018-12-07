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
    public partial class frmHangXe : Form
    {
        private const string TEN_BANG = "HangXe";
        DB db = new DB();

        public frmHangXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kiểm tra lỗi nhập liệu
        /// </summary>
        /// <returns>true Nếu có lỗi nhập liệu</returns>
        private bool coLoi()
        {
            // Lấy dữ liệu từ control
            string maHangXe = this.txtMaHangXe.Text;
            string tenHangXe = this.txtTenHangXe.Text;
            string soLuong = this.txtSoLuongXe.Text;
            string chiPhi = this.txtChiPhiThueBai.Text;

            // Kiểm tra xem tên hãng xe có hợp lệ hay không
            if (!KiemTraNhapLieu.laChuoi(tenHangXe))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }

            // Kiểm tra xem mã hãng xe có hợp lệ hay không
            if (!KiemTraNhapLieu.laChuoi(maHangXe))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }

            // Kiểm tra xem số lượng xe có hợp lệ không
            if (!KiemTraNhapLieu.laSoNguyen(soLuong))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }

            // Kiểm tra chi phí thuê bãi có hợp lệ không
            if (!KiemTraNhapLieu.laSoNguyen(chiPhi))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }

            return false;
        }
        
        /// <summary>
        /// Trở về form quản lý
        /// </summary>
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }

        /// <summary>
        /// Lấy dữ liệu từ csdl lên view khi mở form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHangXe_Load(object sender, EventArgs e)
        {
            dgvhangXe.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }

        /// <summary>
        /// Xóa những control nhập dữ liệu
        /// </summary>
        private void xoaDuLieuTrenControl()
        {
            txtMaHangXe.Clear();
            txtTenHangXe.Clear();
            txtSoLuongXe.Clear();
            txtChiPhiThueBai.Clear();
        }

        /// <summary>
        /// Thêm hãng xe mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có lỗi thì thêm mới
            if (!coLoi())
            {
                string tenHangXe = txtMaHangXe.Text;
                string maHangXe = txtTenHangXe.Text;
                int soLuong = Convert.ToInt32(txtSoLuongXe.Text);
                double chiPhi = Convert.ToDouble(txtChiPhiThueBai.Text);

                db.themHangXe(tenHangXe, maHangXe, soLuong, chiPhi);

                // Cập nhật view
                DB.dgv_capNhat(dgvhangXe, TEN_BANG);

                xoaDuLieuTrenControl();
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheThem);
            }
        }

        /// <summary>
        /// Kiểm tra trước khi xóa hãng xe
        /// </summary>
        /// <returns>true Nếu xác nhận xóa</returns>
        private bool xacNhanXoa()
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa hãng xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra trước khi sửa hãng xe
        /// </summary>
        /// <returns>true Nếu xác nhận sửa</returns>
        private bool xacNhanSua()
        {
            DialogResult result = MessageBox.Show("Bạn muốn sửa dữ liệu hãng xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Xóa hãng xe đã chọn trong csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Nếu đã xác nhận xóa
            if (xacNhanXoa())
            {
                // Nếu xóa thành công thì thông báo và cập nhật lại view
                if (db.xoaHangXe(txtMaHangXe.Text) != -1)
                {
                    MessageBox.Show("Xóa Thành Công");
                    DB.dgv_capNhat(dgvhangXe, TEN_BANG);
                }

                xoaDuLieuTrenControl();

                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không thể xóa! Vui lòng kiểm tra lại");
            }
        }

        /// <summary>
        /// Sửa hãng xe đã chọn trong csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(xacNhanSua() && !coLoi())
            {
                // Kiểm tra nếu sửa thành công thì thông báo cho người dùng rồi cập nhật lại danh sách
                if (db.suaHangXe(txtMaHangXe.Text, txtTenHangXe.Text, Convert.ToInt32(txtSoLuongXe.Text), Convert.ToDouble(txtChiPhiThueBai.Text)) != -1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công!");
                    DB.dgv_capNhat(dgvhangXe, TEN_BANG);
                }
                xoaDuLieuTrenControl();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheXoa);
            }
        }

        /// <summary>
        /// Khi chọn 1 hàng trong View thì lấy dữ liệu lên form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu từ view
            string maHangXe = dgvhangXe.SelectedRows[0].Cells[0].Value.ToString();
            string tenHangXe = dgvhangXe.SelectedRows[0].Cells[1].Value.ToString();
            string soLuong = dgvhangXe.SelectedRows[0].Cells[2].Value.ToString();
            string chiPhi = dgvhangXe.SelectedRows[0].Cells[3].Value.ToString();

            // Truyền dữ liệu lên control tương ứng
            txtMaHangXe.Text = maHangXe;
            txtTenHangXe.Text = tenHangXe;
            txtSoLuongXe.Text = soLuong;
            txtChiPhiThueBai.Text = chiPhi;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }

        /// <summary>
        /// Kiểm tra nếu người dùng bỏ qua thì nhập dữ liệu mặc định vào
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoLuongXe_Leave(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu.khongRong(txtSoLuongXe.Text))
            {
                txtSoLuongXe.Text = "0";
            }
        }

        /// <summary>
        /// Kiểm tra nếu người dùng bỏ qua thì nhập dữ liệu mặc định vào
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtChiPhiThueBai_Leave(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu.khongRong(txtChiPhiThueBai.Text))
            {
                txtChiPhiThueBai.Text = "0";
            }
        }
    }
}
