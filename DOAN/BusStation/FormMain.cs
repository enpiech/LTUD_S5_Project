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
        // Lưu dữ liệu của nhân viên đang đăng nhập
        private NhanVien nvHienHai;

        internal NhanVien NVHienTai
        {
            get { return nvHienHai; }
            set { nvHienHai = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lí dữ liệu khi mở form
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Nếu người dùng chưa đăng nhập thì khóa tất cả chức năng trừ thoát chương trình
            if (NVHienTai == null)
            {
                voHieuHoaFormMain();
                moForm("Login");
                // Mở form yêu cầu đăng nhập khi khởi động chương trình
            }    
        }

        /// <summary>
        /// Xác nhận trước khi đóng form
        /// </summary>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                if (mnuQuanLy.Enabled == false)
                {
                    moForm("Login");
                }
            }
        }

        /// <summary>
        /// Mở form theo tên truyền vào
        /// </summary>
        public void moForm(string tenForm)
        {
            Form form;

            if (tenForm == "Login")
            {
                form = new frmLogin();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm.Name.Equals("frm" + tenForm))
                    {
                        frm.Focus();
                        return;
                    }
                }
                if (tenForm == "HangXe")
                {
                    form = new frmHangXe();
                }
                else if (tenForm == "KhachHang")
                {
                    form = new frmKhachHang();
                }
                else if (tenForm == "LoaiNV")
                {
                    form = new frmLoaiNhanVien();
                }
                else if (tenForm == "LoaiXe")
                {
                    form = new frmLoaiXe();
                }
                else if (tenForm == "NhanVien")
                {
                    form = new frmNhanVien();
                }
                else if (tenForm == "TaiKhoanNV")
                {
                    form = new frmTaiKhoanNhanVien();
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
                    MessageBox.Show("Phát sinh lỗi\n\n" + ex.Message.ToString());
                }
            }
        }

        /// <summary>
        /// Mở form theo loại nhân viên của tài khoản vừa đang nhập
        /// </summary>
        public void moChucNangFormMain()
        {
            // Nếu là nhân viên quản lý
            if (NVHienTai.LoaiNV == "QL")
            {
                // Mở khóa menu cho nhân viên quản lý
                mnuQuanLy.Enabled = true;
            }

            // Mở khóa menu đăng xuất
            this.mnuDangXuat.Enabled = true;
        }

        /// <summary>
        /// Vô hiệu hóa các chức năng trong form main
        /// </summary>
        public void voHieuHoaFormMain()
        {
            mnuQuanLy.Enabled = false;
            mnuDangXuat.Enabled = false;
        }

        /// <summary>
        /// Đăng xuất khỏi tài khoản nhân viên hiện tại
        /// </summary>
        public void dangXuat()
        {
            // Nếu người dùng đã đăng nhập thì đăng xuất tài khoản và tắt các chức năng rồi mở form đăng nhập
            if (NVHienTai != null)
            {
                nvHienHai = null;
                voHieuHoaFormMain();
                moForm("Login");
            }
            else
            {
                mnuDangXuat.Enabled = false;
            }
        }

        /// <summary>
        /// Lấy tên form từ tên mnu
        /// </summary>
        /// <param name="tenMnu">Tên mnu đã click</param>
        private void moFormTuMnu(string tenMnu)
        {
            string tenForm = tenMnu.Substring(3, tenMnu.Length - 3);
            moForm(tenForm);
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
        /// Mở tên bảng dựa theo tên control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">ToolStripItemClicked</param>
        private void mnuQuanLy_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Mở các form quản lý từ tên của menu được chọn
            moFormTuMnu(e.ClickedItem.Name);
        }

        /// <summary>
        /// Mở tên bảng dựa theo tên control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTuyChon_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == mnuDangXuat.Name)
            {
                dangXuat();
            }
            else if (e.ClickedItem.Name == mnuThoat.Name)
            {
                Application.Exit();
            }
        }
    }
}
