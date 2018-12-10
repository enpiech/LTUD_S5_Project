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
        //khoi tao gia tri
        private const string TEN_BANG = "LoaiXe";
        DB db = new DB();

        public frmLoaiXe()
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
            string maLoaiXe = txtMaLoaiXe.Text;
            string tenLoaiXe = txtTenLoaiXe.Text;

            //kiểm tra nhập vào có hợp lệ hay không
            if (!KiemTraNhapLieu.laChuoi(maLoaiXe))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.laChuoi(tenLoaiXe))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Xóa những control nhập dữ liệu
        /// </summary>
        private void xoaDuLieuTrenControl()
        {
            txtMaLoaiXe.Clear();
            txtTenLoaiXe.Clear();
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
        /// lấy dữ liệu từ bảng loại xe mổi khi load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            dgvLoaiXe.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }
        /***** Thêm *****/
        /// <summary>
        /// Thêm loại xe mới vào cơ sở dữ liệu
        /// </summary>
        private bool themNhanVien()
        {
            string maLoaiXe = txtMaLoaiXe.Text;
            string tenLoaiXe = txtTenLoaiXe.Text;

            if (db.themLoaiXe(maLoaiXe, tenLoaiXe) == -1)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// thêm loại xe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi nhập liệu
            if (!coLoi())
            {
                // Kiểm tra xem đã thêm thành công hay không
                if (themNhanVien())
                {
                    MessageBox.Show(ThongBao.themThanhCong);
                    dgvLoaiXe.DataSource = db.layDuLieuTuBang(TEN_BANG);
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
        /// Xác nhận trước khi xóa loại xe
        /// </summary>
        /// <returns>false Nếu không đồng ý</returns>
        private bool xacNhanXoa()
        {
            // Kiểm tra dữ liệu
            string maLoaiXe = txtMaLoaiXe.Text;
            if (!KiemTraNhapLieu.khongRong(maLoaiXe))
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
        /// Xóa loại xe đang chọn ra khỏi cơ sở dữ liệu
        /// </summary>
        private bool xoaNhanVien()
        {
            string maLoaiXe = txtMaLoaiXe.Text;

            if (db.xoaLoaiXe(maLoaiXe) == -1)
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
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (xacNhanXoa())
            {
                if (xoaNhanVien())
                {
                    MessageBox.Show(ThongBao.xoaThanhCong);
                    dgvLoaiXe.DataSource = db.layDuLieuTuBang(TEN_BANG);
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
        /***** SỬA *****/

        /// <summary>
        /// Xác nhận trước khi sửa loại xe
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
       /// sữa loại xe đã chọn trong csdl
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa và kiểm tra lỗi
            if (!coLoi() && xacNhanSua())
            {
                string maLoaiNV = txtMaLoaiXe.Text;
                string tenLoaiNV = txtTenLoaiXe.Text;

                if (db.suaLoaiXe(maLoaiNV, tenLoaiNV) != -1)
                {
                    MessageBox.Show(ThongBao.suaThanhCong);
                    dgvLoaiXe.DataSource = db.layDuLieuTuBang(TEN_BANG);
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
        /// Khi chọn 1 hàng trong View thì lấy dữ liệu lên form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgLoaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu từ view
            string maLoaiXe = dgvLoaiXe.SelectedRows[0].Cells[0].Value.ToString();
            string tenLoaiXe = dgvLoaiXe.SelectedRows[0].Cells[1].Value.ToString();


            // Truyền dữ liệu lên control tương ứng
            txtMaLoaiXe.Text = maLoaiXe;
            txtTenLoaiXe.Text = tenLoaiXe;


            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }
       

    }       
}