using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class frmMain : Form
    {
        private NhanVien activeNhanVien;

        internal NhanVien ActiveNhanVien { get => activeNhanVien; set => activeNhanVien = value; }

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mở form theo tên
        /// </summary>
        public void moForm(string tenForm)
        {
            Form form;
            if (tenForm == "BanVe")
            {
                return;
                //form = new frmBanVe();
            }
            else if (tenForm == "HangXe")
            {
                form = new frmHangXe();
            }
            else if (tenForm == "KhachHang")
            {
                form = new frmKhachHang();
            }
            else if (tenForm == "LoaiNhanVien")
            {
                form = new frmLoaiNhanVien();
            }
            else if (tenForm == "LoaiXe")
            {
                form = new frmLoaiXe();
            }
            else if (tenForm == "Login")
            {
                form = new frmLogin();
            }
            else if (tenForm == "NhanVien")
            {
                form = new frmNhanVien();
            }
            else if (tenForm == "QuanLy")
            {
                form = new frmQuanLy();
            }
            else if (tenForm == "TaiKhoanNhanVien")
            {
                form = new frmTaiKhoanNhanVien();
            }
            else if (tenForm == "TinhTien")
            {
                return;
                //form = new frmTinhTien();
            }
            else if (tenForm == "LichSu")
            {
                return;
                //form = new frmLichSu();
            }
            else
            {
                form = new frmXe();
            }

            try
            {
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chức năng đang phát triển");
            }
            

        }

        /// <summary>
        /// Mở form theo loại nhân viên của tài khoản vừa đang nhập
        /// </summary>
        public void enableFormMain()
        {
            if (this.ActiveNhanVien != null)
            {
                // Nếu là nhân viên quản lý
                if (this.ActiveNhanVien.LoaiNV == "QL")
                {
                    // Mở khóa menu cho nhân viên quản lý
                    this.mnuQuanLy.Enabled = true;
                    this.mnuLichSu.Enabled = true;
                }
                // Nếu là nhân viên phòng vé
                else if (this.ActiveNhanVien.LoaiNV == "NVPV")
                {
                    // Mở khóa menu cho nhân viên phòng vé
                    this.mnuBanVe.Enabled = true;
                }
                // Nếu là nhân viên kế toán
                else if (this.ActiveNhanVien.LoaiNV == "KT")
                {
                    // Mở khóa menu cho nhân viên kế toán
                    this.mnuTinhLuong.Enabled = true;
                }

                // Mở khóa menu đăng xuất
                this.mnuDangXuat.Enabled = true;
            }
        }

        /// <summary>
        /// Vô hiệu hóa các chức năng trong form main
        /// </summary>
        public void disableFormMain()
        {
            this.mnuBanVe.Enabled = false;
            this.mnuLichSu.Enabled = false;
            this.mnuQuanLy.Enabled = false;
            this.mnuTinhLuong.Enabled = false;
            this.mnuDangXuat.Enabled = false;
        }

        /// <summary>
        /// Xử lí dữ liệu khi mở form
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Nếu người dùng chưa đăng nhập thì khóa tất cả chức năng trừ thoát chương trình
            if (this.ActiveNhanVien == null)
            {
                disableFormMain();
            }

            // Mở form yêu cầu đăng nhập khi khởi động chương trình
            moForm("Login");
        }

        /// <summary>
        /// Đóng ứng dụng
        /// </summary>
        private void menuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Đăng xuất khỏi tài khoản nhân viên hiện tại
        /// </summary>
        public void dangXuat()
        {
            // Nếu người dùng đã đăng nhập thì đăng xuất tài khoản và tắt các chức năng
            if (this.ActiveNhanVien != null)
            {
                this.activeNhanVien = null;
                this.disableFormMain();
                moForm("Login");
            }
            else
            {
                this.mnuDangXuat.Enabled = false;
            }
        }

        /// <summary>
        /// Đăng xuất tài khoản nhân viên và mở lại form đăng nhập
        /// </summary>
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            dangXuat();
        }

        /// <summary>
        /// Xác nhận trước khi đóng form
        /// </summary>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ActiveNhanVien != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Mở form bán vé
        /// </summary>
        private void mnuBanVe_Click(object sender, EventArgs e)
        {
            // Mở form bán vé
            moForm("BanVe");
        }

        /// <summary>
        /// Mở form tính lương
        /// </summary>
        private void mnuTinhLuong_Click(object sender, EventArgs e)
        {
            // Mở form tính lương
            moForm("TinhLuong");
        }

        /// <summary>
        /// Mở form quản lý danh sách
        /// </summary>
        private void mnuQuanLy_Click(object sender, EventArgs e)
        {
            moForm("QuanLy");
        }

        /// <summary>
        /// Mở form quản lý lịch sử
        /// </summary>
        private void mnuLichSu_Click(object sender, EventArgs e)
        {
            moForm("LichSu");
        }

        /// <summary>
        /// Đăng xuất tài khoản nhân viên
        /// </summary>
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.dangXuat();
        }

        /// <summary>
        /// Thoát chương trình
        /// </summary>
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
