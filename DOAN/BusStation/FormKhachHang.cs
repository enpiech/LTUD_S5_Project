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

            //db.themDuLieuVaoComboBox(cboMaXe, "Xe");
            cboMaXe.ValueMember = "MaXe";
            cboMaXe.DisplayMember = "SoXe";
            cboMaXe.DataSource = db.layDuLieuTuBang("Xe");
        }

        /// <summary>
        /// Xóa tất cả dữ liệu trên các input control
        /// </summary>
        private void xoaDuLieuTrenControl()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtMaGhe.Clear();
            txtCmnd.Clear();
        }

        /// <summary>
        /// Kiểm tra nếu người dùng nhập dữ liệu bị lỗi
        /// </summary>
        private bool coLoi()
        {
            string maKH = txtMaKhachHang.Text;
            string tenKhachHang = txtTenKhachHang.Text;
            string cmnd = txtCmnd.Text;
            string sdt = txtSoDienThoai.Text;
            string maGhe = txtMaGhe.Text;

            if (!KiemTraNhapLieu.khongRong(maKH))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
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

            if (!KiemTraNhapLieu.khongRong(sdt))
            {
                txtSoDienThoai.Text = "";
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
            { // Lấy dữ liệu từ các control
                string maKH = this.txtMaKhachHang.Text;
                string tenKhachHang = this.txtTenKhachHang.Text;
                string cmnd = this.txtCmnd.Text;
                string soDienThoai = this.txtSoDienThoai.Text;
                string maXe = this.cboMaXe.SelectedValue.ToString();
                string maGhe = this.txtMaGhe.Text;

                // Thêm dữ liệu mới vào csdl
                if (db.themKhachHang(maKH, tenKhachHang, cmnd, soDienThoai, maXe, maGhe) == -1)
                {
                    // Cập nhật lại view
                    dgvKhachHang.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    MessageBox.Show(ThongBao.themThanhCong);
                }
                xoaDuLieuTrenControl();
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheThem);
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
                // Lấy dữ liệu từ các control
                string maKH = this.txtMaKhachHang.Text;
                string tenKhachHang = this.txtTenKhachHang.Text;
                string cmnd = this.txtCmnd.Text;
                string soDienThoai = this.txtSoDienThoai.Text;
                string maXe = this.cboMaXe.SelectedValue.ToString();
                string maGhe = this.txtMaGhe.Text;

                // Thêm dữ liệu mới vào csdl

                if (db.suaKhachHang(maKH, tenKhachHang, cmnd, soDienThoai, maXe, maGhe) != -1)
                {
                    // Cập nhật lại view
                    dgvKhachHang.DataSource = db.layDuLieuTuBang(TEN_BANG);
                    MessageBox.Show(ThongBao.suaThanhCong);
                }
                xoaDuLieuTrenControl();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show(ThongBao.khongTheSua);
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
                string maKH = txtMaKhachHang.Text;
                // Kiểm tra nếu xóa thành công
                if (db.xoaKhachHang(maKH) != -1)
                {
                    MessageBox.Show(ThongBao.xoaThanhCong);
                    dgvKhachHang.DataSource = db.layDuLieuTuBang(TEN_BANG);

                    xoaDuLieuTrenControl();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    MessageBox.Show(ThongBao.khongTheXoa);
                }
            }
        }

        /// <summary>
        /// Lấy hàng dữ liệu từ view rồi cập nhật control tương ứng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
            txtCmnd.Text = dgvKhachHang.SelectedRows[0].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvKhachHang.SelectedRows[0].Cells[3].Value.ToString();
            txtMaGhe.Text = dgvKhachHang.SelectedRows[0].Cells[5].Value.ToString();
            cboMaXe.SelectedIndex = db.timMaXe(dgvKhachHang.SelectedRows[0].Cells[4].Value.ToString());
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
