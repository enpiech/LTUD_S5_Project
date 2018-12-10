using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BusStation
{
    public partial class frmBanVe : Form
    {
        //khoi tao gia tri
        private const string TEN_BANG = "Xe";
        DB db = new DB();

        public frmBanVe()
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
            string tenKH = txtTenKH.Text;
            string CMND = txtCMND.Text;
            string sDT = txtSoDienThoai.Text;

            //kiểm tra nhập vào có hợp lệ hay không
            if (!KiemTraNhapLieu.laChuoi(tenKH))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.laCMND(CMND))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            if (!KiemTraNhapLieu.laSoDienThoai(sDT))
            {
                MessageBox.Show(ThongBao.duLieuKhongPhuHop);
                return true;
            }
            return false;
        }
        

        private void btnMuaVe_Click(object sender, FormClosingEventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string hangXe = cboHangXe.Text.Trim();
            string loaiXe = cboLoaiXe.Text.Trim();
            int soGhe = Convert.ToInt32(cboGhe.Text.Trim());

            string kq = "Họ Tên " + tenKH 
                + "\nSố CMND " + cmnd
                + "\n Số Điện Thoại " + sdt
                + "\nHãng Xe " + hangXe 
                + "\nLoại Xe" + loaiXe
                + "\nSố Ghế" + soGhe;

            DialogResult r;
            r = MessageBox.Show(kq.ToString(), "Thông Báo", MessageBoxButtons.YesNo);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string hangXe = cboHangXe.Text.Trim();
            string loaiXe = cboLoaiXe.Text.Trim();
            string soGhe = cboGhe.Text.Trim();

            string kq = "Thông Tin Khách Hàng\n";
            kq += "Họ Tên " + tenKH 
                + "\nSố CMND " + cmnd 
                + "\nSố Điện Thoại " + sdt 
                + "\nThông Tin Vé Xe\n"
                + "\nHãng Xe " + hangXe 
                + "\nLoại Xe " + loaiXe 
                + "\nSố Ghế" + soGhe;

            DialogResult r;
            r = MessageBox.Show(kq.ToString(), "Thông Báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Mua Vé Thành Công");
            }
        }
        private void frmBanVe_Load(object sender, EventArgs e)
        {
            //gọi hàm để hiển thị
            dgvBanVe.DataSource = db.layDuLieuTuBang(TEN_BANG);
        }  
    }
}
